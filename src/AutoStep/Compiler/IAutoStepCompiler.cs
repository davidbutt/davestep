﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Antlr4.Runtime;
using AutoStep.Compiler.Parser;

namespace AutoStep.Compiler
{
    /// <summary>
    /// Provides the autostep compiler as a service, and allows text content to be turned into a built structure of AutoStep content.
    /// </summary>
    public interface IAutoStepCompiler
    {
        /// <summary>
        /// Compile a source of AutoStep content (e.g. a file) and output the result.
        /// </summary>
        /// <param name="source">The source of the content to load.</param>
        /// <param name="cancelToken">A cancellation token to allow source loading or compilation to be cancelled.</param>
        /// <returns>A compilation result that indicates success or failure, and contains the built content.</returns>
        ValueTask<FileCompilerResult> CompileAsync(IContentSource source, CancellationToken cancelToken = default);

        /// <summary>
        /// Generates a step definition from a statement body/declaration.
        /// </summary>
        /// <param name="stepType">The type of step.</param>
        /// <param name="statementBody">The body of the step.</param>
        /// <returns>The step definition parsing result (which may contain errors).</returns>
        public StepDefinitionFromBodyResult CompileStepDefinitionElementFromStatementBody(StepType stepType, string statementBody);
    }
}
