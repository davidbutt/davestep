﻿using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoStep.Compiler;
using AutoStep.Definitions;
using AutoStep.Elements;
using AutoStep.Projects;
using AutoStep.Tests.Builders;
using FluentAssertions;
using Moq;
using Xunit;

namespace AutoStep.Tests.Projects
{
    public partial class ProjectCompilerTests
    {
        [Fact]
        public void ConstructorThrowsProjectNullArgumentException()
        { 
            Action act = () => new ProjectCompiler(null, new Mock<IAutoStepCompiler>().Object, new Mock<IAutoStepLinker>().Object);

            act.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void ConstructorThrowsCompilerNullArgumentException()
        {
            Action act = () => new ProjectCompiler(new Project(), null, new Mock<IAutoStepLinker>().Object);

            act.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void ConstructorThrowsLinkerNullArgumentException()
        {
            Action act = () => new ProjectCompiler(new Project(), new Mock<IAutoStepCompiler>().Object, null);

            act.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void CompilesNewFile()
        {
            var project = new Project();
            var mockSource = new Mock<IContentSource>();
            mockSource.Setup(s => s.GetLastContentModifyTime()).Returns(DateTime.Today);
            var mockCompiler = new Mock<IAutoStepCompiler>();
            // Compilation will return a compilation result (with an empty file).
            mockCompiler.Setup(x => x.CompileAsync(mockSource.Object, default)).Returns(new ValueTask<FileCompilerResult>(
                new FileCompilerResult(true, new FileElement())
            ));
            var mockLinker = new Mock<IAutoStepLinker>();

            var projFile = new ProjectFile("/file1", mockSource.Object);
            project.TryAddFile(projFile);

            var projectCompiler = new ProjectCompiler(project, mockCompiler.Object, mockLinker.Object);

            var result = projectCompiler.Compile().GetAwaiter().GetResult();

            result.Should().NotBeNull();
            result.Success.Should().BeTrue();

            projFile.LastCompileResult.Should().NotBeNull();
        }

        [Fact]
        public void CompilesMultipleFilesWithErrors()
        {
            var project = new Project();
            var mockSource1 = new Mock<IContentSource>();
            mockSource1.SetupGet(x => x.SourceName).Returns("/file1");
            mockSource1.Setup(s => s.GetLastContentModifyTime()).Returns(DateTime.Today);

            var mockSource2 = new Mock<IContentSource>();
            mockSource1.SetupGet(x => x.SourceName).Returns("/file2");
            mockSource2.Setup(s => s.GetLastContentModifyTime()).Returns(DateTime.Today);

            var mockCompiler = new Mock<IAutoStepCompiler>();

            // First compile result
            mockCompiler.Setup(x => x.CompileAsync(mockSource1.Object, default)).Returns(new ValueTask<FileCompilerResult>(
                new FileCompilerResult(true, new[] { new CompilerMessage("/file1", CompilerMessageLevel.Error, CompilerMessageCode.SyntaxError, "") })
            ));

            // Second compile result
            mockCompiler.Setup(x => x.CompileAsync(mockSource2.Object, default)).Returns(new ValueTask<FileCompilerResult>(
                new FileCompilerResult(true, new[] { new CompilerMessage("/file2", CompilerMessageLevel.Error, CompilerMessageCode.SyntaxError, "") })
            ));

            var mockLinker = new Mock<IAutoStepLinker>();

            var projFile1 = new ProjectFile("/file1", mockSource1.Object);
            var projFile2 = new ProjectFile("/file2", mockSource2.Object);
            project.TryAddFile(projFile1);
            project.TryAddFile(projFile2);

            var projectCompiler = new ProjectCompiler(project, mockCompiler.Object, mockLinker.Object);

            var result = projectCompiler.Compile().GetAwaiter().GetResult();

            result.Should().NotBeNull();
            result.Success.Should().BeTrue();

            var msgs = result.Messages.ToList();

            msgs.Should().HaveCount(2);

            msgs[0].SourceName.Should().Be("/file1");
            msgs[1].SourceName.Should().Be("/file2");
        }

        [Fact]
        public void DoesNotCompileFileThatHasNotBeenChanged()
        {
            var project = new Project();
            var mockSource = new Mock<IContentSource>();
            mockSource.Setup(s => s.GetLastContentModifyTime()).Returns(DateTime.Today);

            var mockCompiler = new Mock<IAutoStepCompiler>();
            // Compilation will return a compilation result (with an empty file).
            mockCompiler.Setup(x => x.CompileAsync(mockSource.Object, default)).Returns(new ValueTask<FileCompilerResult>(
                new FileCompilerResult(true, new FileElement())
            ));
            var mockLinker = new Mock<IAutoStepLinker>();

            var projFile = new ProjectFile("/file1", mockSource.Object);
            project.TryAddFile(projFile);

            var projectCompiler = new ProjectCompiler(project, mockCompiler.Object, mockLinker.Object);

            // Compile once.
            projectCompiler.Compile().GetAwaiter().GetResult();

            var originalCompilationresult = projFile.LastCompileResult;

            // Just do it again.
            projectCompiler.Compile().GetAwaiter().GetResult();

            // Result should be the same.
            projFile.LastCompileResult.Should().BeSameAs(originalCompilationresult);
        }
               
        [Fact]
        public void ReCompilesFileThatHasBeenChanged()
        {
            var project = new Project();
            var mockSource = new Mock<IContentSource>();

            var changeTime = DateTime.Today;

            mockSource.Setup(s => s.GetLastContentModifyTime()).Returns(() => changeTime);

            var mockCompiler = new Mock<IAutoStepCompiler>();
            // Compilation will return a compilation result (with an empty file).
            mockCompiler.Setup(x => x.CompileAsync(mockSource.Object, default)).Returns(new ValueTask<FileCompilerResult>(
                new FileCompilerResult(true, new FileElement())
            ));
            var mockLinker = new Mock<IAutoStepLinker>();

            var projFile = new ProjectFile("/file1", mockSource.Object);
            project.TryAddFile(projFile);

            var projectCompiler = new ProjectCompiler(project, mockCompiler.Object, mockLinker.Object);

            // Compile once.
            projectCompiler.Compile().GetAwaiter().GetResult();

            var originalCompilationresult = projFile.LastCompileResult;

            // Change the file timestamp.
            changeTime = projFile.LastCompileTime.AddMinutes(1);

            // Run it again.
            projectCompiler.Compile().GetAwaiter().GetResult();

            // Result should have changed.
            projFile.Should().NotBeSameAs(originalCompilationresult);
        }

        [Fact]
        public void AddsCompilationMessagesToProjectMessages()
        {
            var project = new Project();
            var mockSource = new Mock<IContentSource>();
            mockSource.Setup(s => s.GetLastContentModifyTime()).Returns(DateTime.Today);

            var fileMessage = new CompilerMessage("/path", CompilerMessageLevel.Error, CompilerMessageCode.SyntaxError, "");

            var mockCompiler = new Mock<IAutoStepCompiler>();
            // Compilation will return a compilation result (with an empty file).
            mockCompiler.Setup(x => x.CompileAsync(mockSource.Object, default)).Returns(new ValueTask<FileCompilerResult>(
                new FileCompilerResult(true, new[] { fileMessage })
            ));
            var mockLinker = new Mock<IAutoStepLinker>();

            var projFile = new ProjectFile("/file1", mockSource.Object);
            project.TryAddFile(projFile);

            var projectCompiler = new ProjectCompiler(project, mockCompiler.Object, mockLinker.Object);

            // Compile once.
            var overallResult = projectCompiler.Compile().GetAwaiter().GetResult();

            overallResult.Messages.Should().Contain(fileMessage);
        }

        [Fact]
        public void AddsIOExceptionCompilerMessageIfIOExceptionThrownInCompiler()
        {
            var project = new Project();
            var mockSource = new Mock<IContentSource>();
            mockSource.Setup(s => s.SourceName).Returns("/file1");
            mockSource.Setup(s => s.GetLastContentModifyTime()).Returns(DateTime.Today);

            var mockCompiler = new Mock<IAutoStepCompiler>();
            // Compilation will return a compilation result (with an empty file).
            mockCompiler.Setup(x => x.CompileAsync(mockSource.Object, default)).Throws(new IOException("IO Error"));

            var mockLinker = new Mock<IAutoStepLinker>();

            var projFile = new ProjectFile("/file1", mockSource.Object);
            project.TryAddFile(projFile);

            var projectCompiler = new ProjectCompiler(project, mockCompiler.Object, mockLinker.Object);

            // Compile once.
            var overallResult = projectCompiler.Compile().GetAwaiter().GetResult();

            var expectedMessage = new CompilerMessage("/file1", CompilerMessageLevel.Error, CompilerMessageCode.IOException,
                                                      "File access error: IO Error", 0, 0);

            overallResult.Messages.Should().Contain(expectedMessage);
        }

        [Fact]
        public void AddsUncategorisedExceptionCompilerMessageIfGeneralExceptionThrownInCompiler()
        {
            var project = new Project();
            var mockSource = new Mock<IContentSource>();
            mockSource.Setup(s => s.SourceName).Returns("/file1");
            mockSource.Setup(s => s.GetLastContentModifyTime()).Returns(DateTime.Today);

            var mockCompiler = new Mock<IAutoStepCompiler>();
            // Compilation will return a compilation result (with an empty file).
            mockCompiler.Setup(x => x.CompileAsync(mockSource.Object, default)).Throws(new ApplicationException("Unknown Error"));

            var mockLinker = new Mock<IAutoStepLinker>();

            var projFile = new ProjectFile("/file1", mockSource.Object);
            project.TryAddFile(projFile);

            var projectCompiler = new ProjectCompiler(project, mockCompiler.Object, mockLinker.Object);

            // Compile once.
            var overallResult = projectCompiler.Compile().GetAwaiter().GetResult();

            var expectedMessage = new CompilerMessage("/file1", CompilerMessageLevel.Error, CompilerMessageCode.UncategorisedException,                                                      
                                                      "Internal Error: Unknown Error", 0, 0);

            overallResult.Messages.Should().Contain(expectedMessage);
        }

        [Fact]
        public void CompileCanBeCancelled()
        {
            var project = new Project();
            var mockCompiler = new Mock<IAutoStepCompiler>();
            var mockLinker = new Mock<IAutoStepLinker>();
            
            var projectCompiler = new ProjectCompiler(project, mockCompiler.Object, mockLinker.Object);

            var projFile = new ProjectFile("/file1", new Mock<IContentSource>().Object);
            project.TryAddFile(projFile);

            var cancelledToken = new CancellationToken(true);

            // Compile once.
            var overallResult = projectCompiler.Invoking(c => c.Compile(cancelledToken)).Should().Throw<OperationCanceledException>();
        }

        [Fact]
        public void AddsStepDefinitionSourceForFileWithStepDefinitions()
        {
            var project = new Project();
            var mockSource = new Mock<IContentSource>();
            mockSource.Setup(s => s.GetLastContentModifyTime()).Returns(DateTime.Today);
            var mockCompiler = new Mock<IAutoStepCompiler>();

            var compiledFile = new FileBuilder()
                                .StepDefinition(StepType.Given, "I have defined something", 2, 2)
                                .Built;

            // Compilation will return a compilation result (with an empty file).
            mockCompiler.Setup(x => x.CompileAsync(mockSource.Object, default)).Returns(new ValueTask<FileCompilerResult>(
                new FileCompilerResult(true, compiledFile)
            ));

            var mockLinker = new Mock<IAutoStepLinker>();

            IUpdatableStepDefinitionSource addedSource = null;

            // Check that the linker is invoked.
            mockLinker.Setup(x => x.AddOrUpdateStepDefinitionSource(It.IsAny<IUpdatableStepDefinitionSource>()))
                      .Callback((IUpdatableStepDefinitionSource s) => addedSource = s);

            var projFile = new ProjectFile("/file1", mockSource.Object);
            project.TryAddFile(projFile);

            var projectCompiler = new ProjectCompiler(project, mockCompiler.Object, mockLinker.Object);

            var result = projectCompiler.Compile().GetAwaiter().GetResult();

            projFile.StepDefinitionSource.Should().NotBeNull();
            // Linker was called.
            addedSource.Should().NotBeNull();
        }
    }
}
