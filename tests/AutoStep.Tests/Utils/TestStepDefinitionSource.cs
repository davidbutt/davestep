﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoStep.Definitions;
using AutoStep.Execution;
using AutoStep.Execution.Dependency;

namespace AutoStep.Tests.Utils
{
    public class TestStepDefinitionSource : IStepDefinitionSource
    {
        public readonly static TestStepDefinitionSource Blank = new TestStepDefinitionSource();

        private readonly List<StepDefinition> defs;

        public TestStepDefinitionSource(string uid, params StepDefinition[] defs)
            : this(defs)
        {
            Uid = uid;
        }

        public TestStepDefinitionSource(params StepDefinition[] defs)
        {
            this.defs = defs.ToList();
        }

        public string Uid { get; } = "test";

        public string Name => "Test";

        public bool RegisterServicesCalled { get; private set; }

        public void AddStepDefinition(StepType type, string declaration)
        {
            defs.Add(new LocalStepDef(this, type, declaration));
        }

        public IEnumerable<StepDefinition> GetStepDefinitions()
        {
            return defs;
        }

        public void RegisterExecutionServices(IServicesBuilder servicesBuilder)
        {
            RegisterServicesCalled = true;
        }

        private class LocalStepDef : StepDefinition
        {
            public LocalStepDef(IStepDefinitionSource source, StepType type, string declaration) : base(source, type, declaration)
            {
            }

            public override Task ExecuteStepAsync(StepExecutionArgs executionArguments)
            {
                throw new System.NotImplementedException();
            }

            public override bool IsSameDefinition(StepDefinition def)
            {
                return def.Declaration == Declaration && def.Source == Source;
            }
        }
    }
}
