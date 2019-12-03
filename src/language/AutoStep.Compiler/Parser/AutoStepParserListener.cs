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
	/// Enter a parse tree produced by <see cref="AutoStepParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] AutoStepParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] AutoStepParser.StatementContext context);
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
	/// Enter a parse tree produced by <see cref="AutoStepParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterName([NotNull] AutoStepParser.NameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoStepParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitName([NotNull] AutoStepParser.NameContext context);
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
	/// <summary>
	/// Enter a parse tree produced by the <c>tag</c>
	/// labeled alternative in <see cref="AutoStepParser.annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTag([NotNull] AutoStepParser.TagContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>tag</c>
	/// labeled alternative in <see cref="AutoStepParser.annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTag([NotNull] AutoStepParser.TagContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>option</c>
	/// labeled alternative in <see cref="AutoStepParser.annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOption([NotNull] AutoStepParser.OptionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>option</c>
	/// labeled alternative in <see cref="AutoStepParser.annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOption([NotNull] AutoStepParser.OptionContext context);
}
} // namespace AutoStep.Compiler.Parser
