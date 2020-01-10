//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from .\AutoStepParser.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AutoStep.Compiler.Parser {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="AutoStepParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public interface IAutoStepParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFile([NotNull] AutoStepParser.FileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFile([NotNull] AutoStepParser.FileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.stepDefinitionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepDefinitionBlock([NotNull] AutoStepParser.StepDefinitionBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.stepDefinitionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepDefinitionBlock([NotNull] AutoStepParser.StepDefinitionBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.stepDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepDefinition([NotNull] AutoStepParser.StepDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.stepDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepDefinition([NotNull] AutoStepParser.StepDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.stepDefinitionBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepDefinitionBody([NotNull] AutoStepParser.StepDefinitionBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.stepDefinitionBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepDefinitionBody([NotNull] AutoStepParser.StepDefinitionBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>declareGiven</c>
	/// labeled alternative in <see cref="AutoStepParser.stepDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclareGiven([NotNull] AutoStepParser.DeclareGivenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>declareGiven</c>
	/// labeled alternative in <see cref="AutoStepParser.stepDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclareGiven([NotNull] AutoStepParser.DeclareGivenContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>declareWhen</c>
	/// labeled alternative in <see cref="AutoStepParser.stepDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclareWhen([NotNull] AutoStepParser.DeclareWhenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>declareWhen</c>
	/// labeled alternative in <see cref="AutoStepParser.stepDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclareWhen([NotNull] AutoStepParser.DeclareWhenContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>declareThen</c>
	/// labeled alternative in <see cref="AutoStepParser.stepDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclareThen([NotNull] AutoStepParser.DeclareThenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>declareThen</c>
	/// labeled alternative in <see cref="AutoStepParser.stepDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclareThen([NotNull] AutoStepParser.DeclareThenContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.stepDeclarationBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepDeclarationBody([NotNull] AutoStepParser.StepDeclarationBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.stepDeclarationBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepDeclarationBody([NotNull] AutoStepParser.StepDeclarationBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>declarationArgument</c>
	/// labeled alternative in <see cref="AutoStepParser.stepDeclarationSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarationArgument([NotNull] AutoStepParser.DeclarationArgumentContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>declarationArgument</c>
	/// labeled alternative in <see cref="AutoStepParser.stepDeclarationSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarationArgument([NotNull] AutoStepParser.DeclarationArgumentContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>declarationSection</c>
	/// labeled alternative in <see cref="AutoStepParser.stepDeclarationSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarationSection([NotNull] AutoStepParser.DeclarationSectionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>declarationSection</c>
	/// labeled alternative in <see cref="AutoStepParser.stepDeclarationSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarationSection([NotNull] AutoStepParser.DeclarationSectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.stepDeclarationArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepDeclarationArgument([NotNull] AutoStepParser.StepDeclarationArgumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.stepDeclarationArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepDeclarationArgument([NotNull] AutoStepParser.StepDeclarationArgumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.stepDeclarationArgumentName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepDeclarationArgumentName([NotNull] AutoStepParser.StepDeclarationArgumentNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.stepDeclarationArgumentName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepDeclarationArgumentName([NotNull] AutoStepParser.StepDeclarationArgumentNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.stepDeclarationTypeHint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepDeclarationTypeHint([NotNull] AutoStepParser.StepDeclarationTypeHintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.stepDeclarationTypeHint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepDeclarationTypeHint([NotNull] AutoStepParser.StepDeclarationTypeHintContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>declarationWord</c>
	/// labeled alternative in <see cref="AutoStepParser.stepDeclarationSectionContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarationWord([NotNull] AutoStepParser.DeclarationWordContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>declarationWord</c>
	/// labeled alternative in <see cref="AutoStepParser.stepDeclarationSectionContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarationWord([NotNull] AutoStepParser.DeclarationWordContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>declarationEscaped</c>
	/// labeled alternative in <see cref="AutoStepParser.stepDeclarationSectionContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarationEscaped([NotNull] AutoStepParser.DeclarationEscapedContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>declarationEscaped</c>
	/// labeled alternative in <see cref="AutoStepParser.stepDeclarationSectionContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarationEscaped([NotNull] AutoStepParser.DeclarationEscapedContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>declarationWs</c>
	/// labeled alternative in <see cref="AutoStepParser.stepDeclarationSectionContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarationWs([NotNull] AutoStepParser.DeclarationWsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>declarationWs</c>
	/// labeled alternative in <see cref="AutoStepParser.stepDeclarationSectionContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarationWs([NotNull] AutoStepParser.DeclarationWsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>declarationColon</c>
	/// labeled alternative in <see cref="AutoStepParser.stepDeclarationSectionContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarationColon([NotNull] AutoStepParser.DeclarationColonContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>declarationColon</c>
	/// labeled alternative in <see cref="AutoStepParser.stepDeclarationSectionContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarationColon([NotNull] AutoStepParser.DeclarationColonContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.featureBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFeatureBlock([NotNull] AutoStepParser.FeatureBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.featureBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFeatureBlock([NotNull] AutoStepParser.FeatureBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.annotations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnnotations([NotNull] AutoStepParser.AnnotationsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.annotations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnnotations([NotNull] AutoStepParser.AnnotationsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>tagAnnotation</c>
	/// labeled alternative in <see cref="AutoStepParser.annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTagAnnotation([NotNull] AutoStepParser.TagAnnotationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>tagAnnotation</c>
	/// labeled alternative in <see cref="AutoStepParser.annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTagAnnotation([NotNull] AutoStepParser.TagAnnotationContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>optionAnnotation</c>
	/// labeled alternative in <see cref="AutoStepParser.annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptionAnnotation([NotNull] AutoStepParser.OptionAnnotationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>optionAnnotation</c>
	/// labeled alternative in <see cref="AutoStepParser.annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptionAnnotation([NotNull] AutoStepParser.OptionAnnotationContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>blank</c>
	/// labeled alternative in <see cref="AutoStepParser.annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlank([NotNull] AutoStepParser.BlankContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>blank</c>
	/// labeled alternative in <see cref="AutoStepParser.annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlank([NotNull] AutoStepParser.BlankContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.featureDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFeatureDefinition([NotNull] AutoStepParser.FeatureDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.featureDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFeatureDefinition([NotNull] AutoStepParser.FeatureDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.featureTitle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFeatureTitle([NotNull] AutoStepParser.FeatureTitleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.featureTitle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFeatureTitle([NotNull] AutoStepParser.FeatureTitleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.featureBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFeatureBody([NotNull] AutoStepParser.FeatureBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.featureBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFeatureBody([NotNull] AutoStepParser.FeatureBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.backgroundBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBackgroundBlock([NotNull] AutoStepParser.BackgroundBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.backgroundBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBackgroundBlock([NotNull] AutoStepParser.BackgroundBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.backgroundBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBackgroundBody([NotNull] AutoStepParser.BackgroundBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.backgroundBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBackgroundBody([NotNull] AutoStepParser.BackgroundBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.scenarioBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScenarioBlock([NotNull] AutoStepParser.ScenarioBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.scenarioBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScenarioBlock([NotNull] AutoStepParser.ScenarioBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.scenarioDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScenarioDefinition([NotNull] AutoStepParser.ScenarioDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.scenarioDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScenarioDefinition([NotNull] AutoStepParser.ScenarioDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>normalScenarioTitle</c>
	/// labeled alternative in <see cref="AutoStepParser.scenarioTitle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNormalScenarioTitle([NotNull] AutoStepParser.NormalScenarioTitleContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>normalScenarioTitle</c>
	/// labeled alternative in <see cref="AutoStepParser.scenarioTitle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNormalScenarioTitle([NotNull] AutoStepParser.NormalScenarioTitleContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>scenarioOutlineTitle</c>
	/// labeled alternative in <see cref="AutoStepParser.scenarioTitle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScenarioOutlineTitle([NotNull] AutoStepParser.ScenarioOutlineTitleContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>scenarioOutlineTitle</c>
	/// labeled alternative in <see cref="AutoStepParser.scenarioTitle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScenarioOutlineTitle([NotNull] AutoStepParser.ScenarioOutlineTitleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.scenarioBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScenarioBody([NotNull] AutoStepParser.ScenarioBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.scenarioBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScenarioBody([NotNull] AutoStepParser.ScenarioBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.stepCollectionBodyLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepCollectionBodyLine([NotNull] AutoStepParser.StepCollectionBodyLineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.stepCollectionBodyLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepCollectionBodyLine([NotNull] AutoStepParser.StepCollectionBodyLineContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>statementWithTable</c>
	/// labeled alternative in <see cref="AutoStepParser.statementBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementWithTable([NotNull] AutoStepParser.StatementWithTableContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>statementWithTable</c>
	/// labeled alternative in <see cref="AutoStepParser.statementBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementWithTable([NotNull] AutoStepParser.StatementWithTableContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>statementLineTerminated</c>
	/// labeled alternative in <see cref="AutoStepParser.statementBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementLineTerminated([NotNull] AutoStepParser.StatementLineTerminatedContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>statementLineTerminated</c>
	/// labeled alternative in <see cref="AutoStepParser.statementBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementLineTerminated([NotNull] AutoStepParser.StatementLineTerminatedContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>statementEofTerminated</c>
	/// labeled alternative in <see cref="AutoStepParser.statementBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementEofTerminated([NotNull] AutoStepParser.StatementEofTerminatedContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>statementEofTerminated</c>
	/// labeled alternative in <see cref="AutoStepParser.statementBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementEofTerminated([NotNull] AutoStepParser.StatementEofTerminatedContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>given</c>
	/// labeled alternative in <see cref="AutoStepParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGiven([NotNull] AutoStepParser.GivenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>given</c>
	/// labeled alternative in <see cref="AutoStepParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGiven([NotNull] AutoStepParser.GivenContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>when</c>
	/// labeled alternative in <see cref="AutoStepParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhen([NotNull] AutoStepParser.WhenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>when</c>
	/// labeled alternative in <see cref="AutoStepParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhen([NotNull] AutoStepParser.WhenContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>then</c>
	/// labeled alternative in <see cref="AutoStepParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThen([NotNull] AutoStepParser.ThenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>then</c>
	/// labeled alternative in <see cref="AutoStepParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThen([NotNull] AutoStepParser.ThenContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>and</c>
	/// labeled alternative in <see cref="AutoStepParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnd([NotNull] AutoStepParser.AndContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>and</c>
	/// labeled alternative in <see cref="AutoStepParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnd([NotNull] AutoStepParser.AndContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.statementBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementBody([NotNull] AutoStepParser.StatementBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.statementBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementBody([NotNull] AutoStepParser.StatementBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>statementQuotedString</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementQuotedString([NotNull] AutoStepParser.StatementQuotedStringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>statementQuotedString</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementQuotedString([NotNull] AutoStepParser.StatementQuotedStringContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>statementSingleBlock</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementSingleBlock([NotNull] AutoStepParser.StatementSingleBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>statementSingleBlock</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementSingleBlock([NotNull] AutoStepParser.StatementSingleBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>statementWord</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSectionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementWord([NotNull] AutoStepParser.StatementWordContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>statementWord</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSectionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementWord([NotNull] AutoStepParser.StatementWordContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>statementEscapedChar</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSectionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementEscapedChar([NotNull] AutoStepParser.StatementEscapedCharContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>statementEscapedChar</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSectionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementEscapedChar([NotNull] AutoStepParser.StatementEscapedCharContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>statementVariable</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSectionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementVariable([NotNull] AutoStepParser.StatementVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>statementVariable</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSectionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementVariable([NotNull] AutoStepParser.StatementVariableContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>statementInt</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSectionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementInt([NotNull] AutoStepParser.StatementIntContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>statementInt</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSectionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementInt([NotNull] AutoStepParser.StatementIntContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>statementFloat</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSectionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementFloat([NotNull] AutoStepParser.StatementFloatContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>statementFloat</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSectionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementFloat([NotNull] AutoStepParser.StatementFloatContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>statementSymbol</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSectionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementSymbol([NotNull] AutoStepParser.StatementSymbolContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>statementSymbol</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSectionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementSymbol([NotNull] AutoStepParser.StatementSymbolContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>statementInterpolate</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSectionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementInterpolate([NotNull] AutoStepParser.StatementInterpolateContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>statementInterpolate</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSectionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementInterpolate([NotNull] AutoStepParser.StatementInterpolateContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>statementBlockWs</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSectionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementBlockWs([NotNull] AutoStepParser.StatementBlockWsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>statementBlockWs</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSectionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementBlockWs([NotNull] AutoStepParser.StatementBlockWsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.statementVariableName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementVariableName([NotNull] AutoStepParser.StatementVariableNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.statementVariableName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementVariableName([NotNull] AutoStepParser.StatementVariableNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.examples"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExamples([NotNull] AutoStepParser.ExamplesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.examples"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExamples([NotNull] AutoStepParser.ExamplesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.exampleBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExampleBlock([NotNull] AutoStepParser.ExampleBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.exampleBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExampleBlock([NotNull] AutoStepParser.ExampleBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.tableBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableBlock([NotNull] AutoStepParser.TableBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.tableBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableBlock([NotNull] AutoStepParser.TableBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.tableHeader"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableHeader([NotNull] AutoStepParser.TableHeaderContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.tableHeader"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableHeader([NotNull] AutoStepParser.TableHeaderContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.tableHeaderCell"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableHeaderCell([NotNull] AutoStepParser.TableHeaderCellContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.tableHeaderCell"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableHeaderCell([NotNull] AutoStepParser.TableHeaderCellContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.tableRow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableRow([NotNull] AutoStepParser.TableRowContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.tableRow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableRow([NotNull] AutoStepParser.TableRowContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.tableRowCell"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableRowCell([NotNull] AutoStepParser.TableRowCellContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.tableRowCell"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableRowCell([NotNull] AutoStepParser.TableRowCellContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.tableRowCellContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableRowCellContent([NotNull] AutoStepParser.TableRowCellContentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.tableRowCellContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableRowCellContent([NotNull] AutoStepParser.TableRowCellContentContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>cellWord</c>
	/// labeled alternative in <see cref="AutoStepParser.cellContentBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCellWord([NotNull] AutoStepParser.CellWordContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>cellWord</c>
	/// labeled alternative in <see cref="AutoStepParser.cellContentBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCellWord([NotNull] AutoStepParser.CellWordContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>cellEscapedChar</c>
	/// labeled alternative in <see cref="AutoStepParser.cellContentBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCellEscapedChar([NotNull] AutoStepParser.CellEscapedCharContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>cellEscapedChar</c>
	/// labeled alternative in <see cref="AutoStepParser.cellContentBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCellEscapedChar([NotNull] AutoStepParser.CellEscapedCharContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>cellVariable</c>
	/// labeled alternative in <see cref="AutoStepParser.cellContentBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCellVariable([NotNull] AutoStepParser.CellVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>cellVariable</c>
	/// labeled alternative in <see cref="AutoStepParser.cellContentBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCellVariable([NotNull] AutoStepParser.CellVariableContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>cellInterpolate</c>
	/// labeled alternative in <see cref="AutoStepParser.cellContentBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCellInterpolate([NotNull] AutoStepParser.CellInterpolateContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>cellInterpolate</c>
	/// labeled alternative in <see cref="AutoStepParser.cellContentBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCellInterpolate([NotNull] AutoStepParser.CellInterpolateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.cellVariableName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCellVariableName([NotNull] AutoStepParser.CellVariableNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.cellVariableName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCellVariableName([NotNull] AutoStepParser.CellVariableNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterText([NotNull] AutoStepParser.TextContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitText([NotNull] AutoStepParser.TextContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine([NotNull] AutoStepParser.LineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine([NotNull] AutoStepParser.LineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoStepParser.description"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDescription([NotNull] AutoStepParser.DescriptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.description"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDescription([NotNull] AutoStepParser.DescriptionContext context);
}
} // namespace AutoStep.Compiler.Parser
