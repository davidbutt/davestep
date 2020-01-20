﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using AutoStep.Elements;
using AutoStep.Elements.ReadOnly;
using AutoStep.Execution.Control;
using AutoStep.Execution.Dependency;

namespace AutoStep.Execution.Strategy
{
    public class DefaultRunExecutionStrategy : IRunExecutionStrategy
    {
        public async Task Execute(IServiceScope runScope, RunContext runContext, FeatureExecutionSet executionSet, IEventPipeline eventPipeline)
        {
            // Event handlers have all executed now.

            // Create a queue of all features.
            var featureQueue = new ConcurrentQueue<IFeatureInfo>(executionSet.Features);

            // Will need to come from config.
            var parallelConfig = 1;

            var parallelValue = Math.Min(featureQueue.Count, parallelConfig);

            // Create x tasks based on level of parallelism.
            var parallelTasks = new Task[parallelValue];

            IFeatureInfo? FeatureDeQueue(ConcurrentQueue<IFeatureInfo> queue)
            {
                if (queue.TryDequeue(out var result))
                {
                    return result;
                }

                return null;
            }

            for (int idx = 0; idx < parallelValue; idx++)
            {
                // Initially we'll just go for a feature parallel, but eventually we will
                // probably add support for a scenario parallel.
                parallelTasks[idx] = Task.Run(() => TestThreadFeatureParallel(runScope, idx, () => FeatureDeQueue(featureQueue), eventPipeline));
            }

            // Wait for test threads to finish.
            await Task.WhenAll(parallelTasks).ConfigureAwait(false);
        }

        private async Task TestThreadFeatureParallel(IServiceScope runScope, int testThreadId, Func<IFeatureInfo?> nextFeature, IEventPipeline events)
        {
            // Event handler is set by only caller, which has its own catch.
            Debug.Assert(events is object);

            var threadContext = new ThreadContext(testThreadId);

            using var threadScope = runScope.BeginNewScope(ScopeTags.ThreadTag, threadContext);

            var executionManager = threadScope.Resolve<IExecutionStateManager>();
            var featureStrategy = threadScope.Resolve<IFeatureExecutionStrategy>();

            await events.InvokeEvent(
                threadScope,
                threadContext,
                (handler, sc, ctxt, next) => handler.Thread(sc, ctxt, next),
                async (scope, ctxt) =>
                {
                    var haltInstruction = await executionManager.CheckforHalt(scope, ctxt, TestThreadState.Starting).ConfigureAwait(false);

                    // TODO: Do something with halt instruction (terminate, for example?).
                    while (true)
                    {
                        var feature = nextFeature();

                        if (feature is object)
                        {
                            // We have a feature.
                            await featureStrategy.Execute(scope, events, feature).ConfigureAwait(false);
                        }
                        else
                        {
                            // TODO: Logging.
                            //tracer.Debug("Test Thread ID {0}; no more features to run.", testThreadId);
                            break;
                        }
                    }
                }).ConfigureAwait(false);
        }
    }
}