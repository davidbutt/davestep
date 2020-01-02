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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="AutoStepParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public interface IAutoStepParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFile([NotNull] AutoStepParser.FileContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.featureBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFeatureBlock([NotNull] AutoStepParser.FeatureBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.annotations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnnotations([NotNull] AutoStepParser.AnnotationsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tagAnnotation</c>
	/// labeled alternative in <see cref="AutoStepParser.annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTagAnnotation([NotNull] AutoStepParser.TagAnnotationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>optionAnnotation</c>
	/// labeled alternative in <see cref="AutoStepParser.annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOptionAnnotation([NotNull] AutoStepParser.OptionAnnotationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>blank</c>
	/// labeled alternative in <see cref="AutoStepParser.annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlank([NotNull] AutoStepParser.BlankContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.featureDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFeatureDefinition([NotNull] AutoStepParser.FeatureDefinitionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.featureTitle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFeatureTitle([NotNull] AutoStepParser.FeatureTitleContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.featureBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFeatureBody([NotNull] AutoStepParser.FeatureBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.backgroundBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBackgroundBlock([NotNull] AutoStepParser.BackgroundBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.backgroundBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBackgroundBody([NotNull] AutoStepParser.BackgroundBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.scenarioBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScenarioBlock([NotNull] AutoStepParser.ScenarioBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.scenarioDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScenarioDefinition([NotNull] AutoStepParser.ScenarioDefinitionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>normalScenarioTitle</c>
	/// labeled alternative in <see cref="AutoStepParser.scenarioTitle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNormalScenarioTitle([NotNull] AutoStepParser.NormalScenarioTitleContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>scenarioOutlineTitle</c>
	/// labeled alternative in <see cref="AutoStepParser.scenarioTitle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScenarioOutlineTitle([NotNull] AutoStepParser.ScenarioOutlineTitleContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.scenarioBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScenarioBody([NotNull] AutoStepParser.ScenarioBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.stepCollectionBodyLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStepCollectionBodyLine([NotNull] AutoStepParser.StepCollectionBodyLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>statementWithTable</c>
	/// labeled alternative in <see cref="AutoStepParser.statementBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatementWithTable([NotNull] AutoStepParser.StatementWithTableContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>statementLineTerminated</c>
	/// labeled alternative in <see cref="AutoStepParser.statementBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatementLineTerminated([NotNull] AutoStepParser.StatementLineTerminatedContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>statementEofTerminated</c>
	/// labeled alternative in <see cref="AutoStepParser.statementBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatementEofTerminated([NotNull] AutoStepParser.StatementEofTerminatedContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>given</c>
	/// labeled alternative in <see cref="AutoStepParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGiven([NotNull] AutoStepParser.GivenContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>when</c>
	/// labeled alternative in <see cref="AutoStepParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhen([NotNull] AutoStepParser.WhenContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>then</c>
	/// labeled alternative in <see cref="AutoStepParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitThen([NotNull] AutoStepParser.ThenContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>and</c>
	/// labeled alternative in <see cref="AutoStepParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnd([NotNull] AutoStepParser.AndContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.statementBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatementBody([NotNull] AutoStepParser.StatementBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>statementSectionPart</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatementSectionPart([NotNull] AutoStepParser.StatementSectionPartContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>statementWs</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatementWs([NotNull] AutoStepParser.StatementWsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>argEmpty</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgEmpty([NotNull] AutoStepParser.ArgEmptyContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>argFloat</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgFloat([NotNull] AutoStepParser.ArgFloatContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>argInt</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgInt([NotNull] AutoStepParser.ArgIntContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>argInterpolate</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgInterpolate([NotNull] AutoStepParser.ArgInterpolateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>argText</c>
	/// labeled alternative in <see cref="AutoStepParser.statementSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgText([NotNull] AutoStepParser.ArgTextContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.statementArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatementArgument([NotNull] AutoStepParser.StatementArgumentContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exampleArgBlock</c>
	/// labeled alternative in <see cref="AutoStepParser.statementArgumentBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExampleArgBlock([NotNull] AutoStepParser.ExampleArgBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>textArgBlock</c>
	/// labeled alternative in <see cref="AutoStepParser.statementArgumentBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTextArgBlock([NotNull] AutoStepParser.TextArgBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.argumentExampleNameBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgumentExampleNameBody([NotNull] AutoStepParser.ArgumentExampleNameBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.argumentExampleNameBodyContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgumentExampleNameBodyContent([NotNull] AutoStepParser.ArgumentExampleNameBodyContentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.argumentBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgumentBody([NotNull] AutoStepParser.ArgumentBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.examples"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExamples([NotNull] AutoStepParser.ExamplesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.exampleBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExampleBlock([NotNull] AutoStepParser.ExampleBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.tableBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableBlock([NotNull] AutoStepParser.TableBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.tableHeader"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableHeader([NotNull] AutoStepParser.TableHeaderContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.tableHeaderCell"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableHeaderCell([NotNull] AutoStepParser.TableHeaderCellContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.tableRow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableRow([NotNull] AutoStepParser.TableRowContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.tableRowCell"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableRowCell([NotNull] AutoStepParser.TableRowCellContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cellFloat</c>
	/// labeled alternative in <see cref="AutoStepParser.tableRowCellContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCellFloat([NotNull] AutoStepParser.CellFloatContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cellInt</c>
	/// labeled alternative in <see cref="AutoStepParser.tableRowCellContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCellInt([NotNull] AutoStepParser.CellIntContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cellInterpolate</c>
	/// labeled alternative in <see cref="AutoStepParser.tableRowCellContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCellInterpolate([NotNull] AutoStepParser.CellInterpolateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cellText</c>
	/// labeled alternative in <see cref="AutoStepParser.tableRowCellContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCellText([NotNull] AutoStepParser.CellTextContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.headerCell"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeaderCell([NotNull] AutoStepParser.HeaderCellContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.cellArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCellArgument([NotNull] AutoStepParser.CellArgumentContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exampleCellBlock</c>
	/// labeled alternative in <see cref="AutoStepParser.cellArgumentBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExampleCellBlock([NotNull] AutoStepParser.ExampleCellBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>textCellBlock</c>
	/// labeled alternative in <see cref="AutoStepParser.cellArgumentBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTextCellBlock([NotNull] AutoStepParser.TextCellBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.headerCellBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeaderCellBody([NotNull] AutoStepParser.HeaderCellBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.cellExampleNameBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCellExampleNameBody([NotNull] AutoStepParser.CellExampleNameBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.cellExampleNameBodyContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCellExampleNameBodyContent([NotNull] AutoStepParser.CellExampleNameBodyContentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.generalCellBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGeneralCellBody([NotNull] AutoStepParser.GeneralCellBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitText([NotNull] AutoStepParser.TextContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLine([NotNull] AutoStepParser.LineContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AutoStepParser.description"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDescription([NotNull] AutoStepParser.DescriptionContext context);
}
} // namespace AutoStep.Compiler.Parser
