//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Dana\source\repos\LabWork1github\LabWork1github\DynamicMonster.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace LabWork1github {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IDynamicMonsterVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class DynamicMonsterBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IDynamicMonsterVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.definition"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDefinition([NotNull] DynamicMonsterParser.DefinitionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.name"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitName([NotNull] DynamicMonsterParser.NameContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.statementList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStatementList([NotNull] DynamicMonsterParser.StatementListContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStatement([NotNull] DynamicMonsterParser.StatementContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.insideBlock"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInsideBlock([NotNull] DynamicMonsterParser.InsideBlockContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.nameDeclaration"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNameDeclaration([NotNull] DynamicMonsterParser.NameDeclarationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.healthDeclaration"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitHealthDeclaration([NotNull] DynamicMonsterParser.HealthDeclarationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.damageDeclaration"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDamageDeclaration([NotNull] DynamicMonsterParser.DamageDeclarationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.distanceDeclare"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDistanceDeclare([NotNull] DynamicMonsterParser.DistanceDeclareContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.moveDeclaration"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMoveDeclaration([NotNull] DynamicMonsterParser.MoveDeclarationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.shootDeclaration"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitShootDeclaration([NotNull] DynamicMonsterParser.ShootDeclarationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.ifexpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIfexpression([NotNull] DynamicMonsterParser.IfexpressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.whileexpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWhileexpression([NotNull] DynamicMonsterParser.WhileexpressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.block"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBlock([NotNull] DynamicMonsterParser.BlockContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.numholder"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNumholder([NotNull] DynamicMonsterParser.NumholderContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.secondnumparam"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSecondnumparam([NotNull] DynamicMonsterParser.SecondnumparamContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.numberoperations"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNumberoperations([NotNull] DynamicMonsterParser.NumberoperationsContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.booloperation"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBooloperation([NotNull] DynamicMonsterParser.BooloperationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.secondbooloperation"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSecondbooloperation([NotNull] DynamicMonsterParser.SecondbooloperationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.boolsconnected"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBoolsconnected([NotNull] DynamicMonsterParser.BoolsconnectedContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.boolexpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBoolexpression([NotNull] DynamicMonsterParser.BoolexpressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.character"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCharacter([NotNull] DynamicMonsterParser.CharacterContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.possibleAttributes"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPossibleAttributes([NotNull] DynamicMonsterParser.PossibleAttributesContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.characterAttribute"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCharacterAttribute([NotNull] DynamicMonsterParser.CharacterAttributeContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.place"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPlace([NotNull] DynamicMonsterParser.PlaceContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.x"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitX([NotNull] DynamicMonsterParser.XContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicMonsterParser.y"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitY([NotNull] DynamicMonsterParser.YContext context) { return VisitChildren(context); }
}
} // namespace LabWork1github
