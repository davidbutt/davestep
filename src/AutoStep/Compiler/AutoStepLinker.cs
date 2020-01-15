﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoStep.Compiler.Matching;
using AutoStep.Compiler.Parser;
using AutoStep.Definitions;
using AutoStep.Elements;
using AutoStep.Tracing;

namespace AutoStep.Compiler
{
    /// <summary>
    /// Links compiled autostep content.
    /// </summary>
    /// <remarks>
    /// Linker can hold state, to be able to know what has changed.
    /// The output of the compiler can be fed repeatedly into the linker, to update the references.
    /// </remarks>
    public class AutoStepLinker : IAutoStepLinker
    {
        private readonly IAutoStepCompiler compiler;
        private readonly IMatchingTree linkerTree;
        private readonly Dictionary<string, StepSourceWithTracking> trackedSources = new Dictionary<string, StepSourceWithTracking>();
        private readonly ITracer? tracer;

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoStepLinker"/> class.
        /// </summary>
        /// <param name="compiler">The autostep compiler to use when processing definition statements.</param>
        public AutoStepLinker(IAutoStepCompiler compiler)
        {
            this.compiler = compiler;
            linkerTree = new MatchingTree();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoStepLinker"/> class, providing a custom matcher tree.
        /// </summary>
        /// <param name="compiler">The autostep compiler to use when processing definition statements.</param>
        /// <param name="tracer">A tracer for the operations of the linker.</param>
        public AutoStepLinker(IAutoStepCompiler compiler, ITracer tracer)
            : this(compiler)
        {
            this.tracer = tracer;
        }

        /// <summary>
        /// Adds a source of step definitions to the linker.
        /// </summary>
        /// <param name="source">The source to add.</param>
        public void AddStepDefinitionSource(IStepDefinitionSource source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (trackedSources.Remove(source.Uid, out var oldSource))
            {
                // Unload an existing source with the same UID.
                oldSource.DeleteAllSteps(linkerTree);
            }

            var trackedSource = new StepSourceWithTracking(source);

            // Add/Replace the source.
            trackedSources.Add(source.Uid, trackedSource);

            // Load all the step definitions we have.
            RefreshStepDefinitions(trackedSource);
        }

        /// <summary>
        /// Add/Update an updatable step definition source. All step definitions in the source will be refreshed.
        /// </summary>
        /// <param name="stepDefinitionSource">The step definition source.</param>
        public void AddOrUpdateStepDefinitionSource(IUpdatableStepDefinitionSource stepDefinitionSource)
        {
            if (stepDefinitionSource is null)
            {
                throw new ArgumentNullException(nameof(stepDefinitionSource));
            }

            if (!trackedSources.TryGetValue(stepDefinitionSource.Uid, out var tracked))
            {
                tracked = new StepSourceWithTracking(stepDefinitionSource);
                trackedSources.Add(stepDefinitionSource.Uid, tracked);
            }

            tracked.UpdateSteps(linkerTree, stepDefinitionSource.GetStepDefinitions());
        }

        /// <summary>
        /// Remove a step definition source.
        /// </summary>
        /// <param name="stepDefinitionSource">The step definition source to remove.</param>
        public void RemoveStepDefinitionSource(IStepDefinitionSource stepDefinitionSource)
        {
            if (stepDefinitionSource is null)
            {
                throw new ArgumentNullException(nameof(stepDefinitionSource));
            }

            if (trackedSources.Remove(stepDefinitionSource.Uid, out var trackedSource))
            {
                trackedSource.DeleteAllSteps(linkerTree);
            }
            else
            {
                throw new InvalidOperationException(AutoStepLinkerMessages.CannotRemoveDefinitionSource);
            }
        }

        /// <summary>
        /// Links (or re-links) a built autostep file; all step references that can be updated with step definition bindings will be.
        /// </summary>
        /// <param name="file">The file to link.</param>
        /// <returns>A link result (including a reference to the same file).</returns>
        public LinkResult Link(FileElement file)
        {
            if (file is null)
            {
                throw new ArgumentNullException(nameof(file));
            }

            var messages = new List<CompilerMessage>();
            bool success = true;

            var allFoundStepSources = new Dictionary<string, IStepDefinitionSource>();

            // Go through all the steps and link them.
            foreach (var stepRef in file.AllStepReferences)
            {
                var matches = linkerTree.Match(stepRef, true, out var _);

                if (matches.Count == 0)
                {
                    // No matches.
                    messages.Add(CompilerMessageFactory.Create(file.SourceName, stepRef, CompilerMessageLevel.Error, CompilerMessageCode.LinkerNoMatchingStepDefinition));
                    stepRef.Unbind();
                    success = false;
                }
                else if (matches.Count > 1)
                {
                    messages.Add(CompilerMessageFactory.Create(file.SourceName, stepRef, CompilerMessageLevel.Error, CompilerMessageCode.LinkerMultipleMatchingDefinitions));
                    stepRef.Unbind();
                    success = false;
                }
                else
                {
                    var foundMatch = matches.First.Value;

                    // Link successful, bind the reference.
                    stepRef.Bind(foundMatch.Definition);

                    var defSource = foundMatch.Definition.Source;

                    allFoundStepSources.TryAdd(defSource.Uid, defSource);
                }
            }

            return new LinkResult(success, messages, allFoundStepSources.Values, file);
        }

        private void RefreshStepDefinitions(StepSourceWithTracking trackedSource)
        {
            var definitions = trackedSource.Source.GetStepDefinitions();

            // Make sure we have definitions.
            foreach (var stepDef in definitions)
            {
                if (stepDef.Definition is null)
                {
                    var definitionResult = compiler.CompileStepDefinitionElementFromStatementBody(stepDef.Type, stepDef.Declaration);

                    if (definitionResult.Success)
                    {
                        stepDef.Definition = definitionResult.Output;
                    }
                }
            }

            trackedSource.UpdateSteps(linkerTree, definitions);
        }

        private class StepSourceWithTracking
        {
            private readonly Dictionary<(StepType Type, string Declaration), StepDefinition> trackedSteps;

            public StepSourceWithTracking(IStepDefinitionSource source)
            {
                Source = source;
                trackedSteps = new Dictionary<(StepType Type, string Declaration), StepDefinition>();
            }

            public IStepDefinitionSource Source { get; }

            public void DeleteAllSteps(IMatchingTree tree) => UpdateSteps(tree, Enumerable.Empty<StepDefinition>());

            public void UpdateSteps(IMatchingTree tree, IEnumerable<StepDefinition> replaceDefinitions)
            {
                if (replaceDefinitions is null)
                {
                    throw new ArgumentNullException(nameof(replaceDefinitions));
                }

                var keysToRemove = new List<(StepType Type, string Declaration)>(trackedSteps.Keys);

                foreach (var compiledStepDef in replaceDefinitions)
                {
                    if (compiledStepDef.Declaration is null)
                    {
                        // We can't use the compiled step definition if it has no declaration.
                        continue;
                    }

                    var key = (compiledStepDef.Type, compiledStepDef.Declaration);

                    // There are some step definitions.
                    // Look at the declaration and see if we need to update a definition.
                    if (trackedSteps.TryGetValue(key, out var existingDef))
                    {
                        // There is already a definition with the same 'signature'. So we can just do an in-place swap.
                        existingDef.Definition = compiledStepDef.Definition;

                        // Don't remove this one, we've found it again.
                        keysToRemove.Remove(key);
                    }
                    else
                    {
                        // Need to add a new one.
                        trackedSteps.Add((compiledStepDef.Type, compiledStepDef.Declaration), compiledStepDef);

                        // Update the matching tree.
                        tree.AddOrUpdateDefinition(compiledStepDef);
                    }
                }

                foreach (var item in keysToRemove)
                {
                    if (trackedSteps.Remove(item, out var existingDef))
                    {
                        // Remove from the matching tree.
                        tree.RemoveDefinition(existingDef);
                    }
                }
            }
        }
    }
}