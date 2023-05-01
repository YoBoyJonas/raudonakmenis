//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\dzera\Documents\C#\Raudonakmenis\Raudonakmenis\Grammar.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Raudonakmenis {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="GrammarParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IGrammarVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompileUnit([NotNull] GrammarParser.CompileUnitContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] GrammarParser.ProgramContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLine([NotNull] GrammarParser.LineContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] GrammarParser.StatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment([NotNull] GrammarParser.AssignmentContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.assignment2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment2([NotNull] GrammarParser.Assignment2Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCall([NotNull] GrammarParser.FunctionCallContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfBlock([NotNull] GrammarParser.IfBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.blockas"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockas([NotNull] GrammarParser.BlockasContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseIfBlock([NotNull] GrammarParser.ElseIfBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.printStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrintStatement([NotNull] GrammarParser.PrintStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileBlock([NotNull] GrammarParser.WhileBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] GrammarParser.ExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.multOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultOp([NotNull] GrammarParser.MultOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.addOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddOp([NotNull] GrammarParser.AddOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.compareOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompareOp([NotNull] GrammarParser.CompareOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolOp([NotNull] GrammarParser.BoolOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstant([NotNull] GrammarParser.ConstantContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] GrammarParser.BlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.classDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassDeclaration([NotNull] GrammarParser.ClassDeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.className"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassName([NotNull] GrammarParser.ClassNameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.classBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassBody([NotNull] GrammarParser.ClassBodyContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.classMember"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassMember([NotNull] GrammarParser.ClassMemberContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.fieldDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFieldDeclaration([NotNull] GrammarParser.FieldDeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.fieldName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFieldName([NotNull] GrammarParser.FieldNameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.methodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodDeclaration([NotNull] GrammarParser.MethodDeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.methodName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodName([NotNull] GrammarParser.MethodNameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterList([NotNull] GrammarParser.ParameterListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameter([NotNull] GrammarParser.ParameterContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.parameterName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterName([NotNull] GrammarParser.ParameterNameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] GrammarParser.TypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodBody([NotNull] GrammarParser.MethodBodyContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.blockWithReturn"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockWithReturn([NotNull] GrammarParser.BlockWithReturnContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnStatement([NotNull] GrammarParser.ReturnStatementContext context);
}
} // namespace Raudonakmenis