//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from MyGrammar.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IMyGrammarVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class MyGrammarBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IMyGrammarVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>ParenthesizedExpression</c>
	/// labeled alternative in <see cref="MyGrammarParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitParenthesizedExpression([NotNull] MyGrammarParser.ParenthesizedExpressionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>AdditiveExpression</c>
	/// labeled alternative in <see cref="MyGrammarParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAdditiveExpression([NotNull] MyGrammarParser.AdditiveExpressionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>MminFunction</c>
	/// labeled alternative in <see cref="MyGrammarParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMminFunction([NotNull] MyGrammarParser.MminFunctionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>Number</c>
	/// labeled alternative in <see cref="MyGrammarParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNumber([NotNull] MyGrammarParser.NumberContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>UnaryExpression</c>
	/// labeled alternative in <see cref="MyGrammarParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitUnaryExpression([NotNull] MyGrammarParser.UnaryExpressionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>Cell</c>
	/// labeled alternative in <see cref="MyGrammarParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCell([NotNull] MyGrammarParser.CellContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>MultiplicativeExpression</c>
	/// labeled alternative in <see cref="MyGrammarParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMultiplicativeExpression([NotNull] MyGrammarParser.MultiplicativeExpressionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>MmaxFunction</c>
	/// labeled alternative in <see cref="MyGrammarParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMmaxFunction([NotNull] MyGrammarParser.MmaxFunctionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MyGrammarParser.exprList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExprList([NotNull] MyGrammarParser.ExprListContext context) { return VisitChildren(context); }
}
