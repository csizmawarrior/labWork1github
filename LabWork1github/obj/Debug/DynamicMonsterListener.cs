//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Dana\Source\Repos\LabWork1github\LabWork1github\g4 files\DynamicMonster.g4 by ANTLR 4.6.6

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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="DynamicMonsterParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IDynamicMonsterListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefinition([NotNull] DynamicMonsterParser.DefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefinition([NotNull] DynamicMonsterParser.DefinitionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterName([NotNull] DynamicMonsterParser.NameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitName([NotNull] DynamicMonsterParser.NameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.statementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementList([NotNull] DynamicMonsterParser.StatementListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.statementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementList([NotNull] DynamicMonsterParser.StatementListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] DynamicMonsterParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] DynamicMonsterParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.nameDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNameDeclaration([NotNull] DynamicMonsterParser.NameDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.nameDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNameDeclaration([NotNull] DynamicMonsterParser.NameDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.healthDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHealthDeclaration([NotNull] DynamicMonsterParser.HealthDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.healthDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHealthDeclaration([NotNull] DynamicMonsterParser.HealthDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.damageDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDamageDeclaration([NotNull] DynamicMonsterParser.DamageDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.damageDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDamageDeclaration([NotNull] DynamicMonsterParser.DamageDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.distanceDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDistanceDeclare([NotNull] DynamicMonsterParser.DistanceDeclareContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.distanceDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDistanceDeclare([NotNull] DynamicMonsterParser.DistanceDeclareContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.moveDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMoveDeclaration([NotNull] DynamicMonsterParser.MoveDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.moveDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMoveDeclaration([NotNull] DynamicMonsterParser.MoveDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.shootDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShootDeclaration([NotNull] DynamicMonsterParser.ShootDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.shootDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShootDeclaration([NotNull] DynamicMonsterParser.ShootDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.ifexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfexpression([NotNull] DynamicMonsterParser.IfexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.ifexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfexpression([NotNull] DynamicMonsterParser.IfexpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.whileexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileexpression([NotNull] DynamicMonsterParser.WhileexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.whileexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileexpression([NotNull] DynamicMonsterParser.WhileexpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] DynamicMonsterParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] DynamicMonsterParser.BlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.character"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCharacter([NotNull] DynamicMonsterParser.CharacterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.character"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCharacter([NotNull] DynamicMonsterParser.CharacterContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.possibleAttributes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPossibleAttributes([NotNull] DynamicMonsterParser.PossibleAttributesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.possibleAttributes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPossibleAttributes([NotNull] DynamicMonsterParser.PossibleAttributesContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.place"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPlace([NotNull] DynamicMonsterParser.PlaceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.place"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPlace([NotNull] DynamicMonsterParser.PlaceContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.x"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterX([NotNull] DynamicMonsterParser.XContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.x"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitX([NotNull] DynamicMonsterParser.XContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.y"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterY([NotNull] DynamicMonsterParser.YContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.y"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitY([NotNull] DynamicMonsterParser.YContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] DynamicMonsterParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] DynamicMonsterParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.something"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSomething([NotNull] DynamicMonsterParser.SomethingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.something"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSomething([NotNull] DynamicMonsterParser.SomethingContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DynamicMonsterParser.operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperation([NotNull] DynamicMonsterParser.OperationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DynamicMonsterParser.operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperation([NotNull] DynamicMonsterParser.OperationContext context);
}
} // namespace LabWork1github
