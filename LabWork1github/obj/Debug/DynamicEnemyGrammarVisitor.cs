//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Dana\source\repos\LabWork1github\LabWork1github\DynamicEnemyGrammar.g4 by ANTLR 4.6.6

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

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="DynamicEnemyGrammarParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IDynamicEnemyGrammarVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefinition([NotNull] DynamicEnemyGrammarParser.DefinitionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitName([NotNull] DynamicEnemyGrammarParser.NameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.statementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatementList([NotNull] DynamicEnemyGrammarParser.StatementListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] DynamicEnemyGrammarParser.StatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.nameDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNameDeclaration([NotNull] DynamicEnemyGrammarParser.NameDeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.healthDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHealthDeclaration([NotNull] DynamicEnemyGrammarParser.HealthDeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.healAmountDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHealAmountDeclaration([NotNull] DynamicEnemyGrammarParser.HealAmountDeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.damageAmountDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDamageAmountDeclaration([NotNull] DynamicEnemyGrammarParser.DamageAmountDeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.teleportPointDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTeleportPointDeclaration([NotNull] DynamicEnemyGrammarParser.TeleportPointDeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.spawnPointDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSpawnPointDeclaration([NotNull] DynamicEnemyGrammarParser.SpawnPointDeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.spawnTypeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSpawnTypeDeclaration([NotNull] DynamicEnemyGrammarParser.SpawnTypeDeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.distanceDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDistanceDeclare([NotNull] DynamicEnemyGrammarParser.DistanceDeclareContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.moveDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMoveDeclaration([NotNull] DynamicEnemyGrammarParser.MoveDeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.shootDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShootDeclaration([NotNull] DynamicEnemyGrammarParser.ShootDeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.damageDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDamageDeclaration([NotNull] DynamicEnemyGrammarParser.DamageDeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.healDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHealDeclaration([NotNull] DynamicEnemyGrammarParser.HealDeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.spawnDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSpawnDeclaration([NotNull] DynamicEnemyGrammarParser.SpawnDeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.teleportDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTeleportDeclaration([NotNull] DynamicEnemyGrammarParser.TeleportDeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.ifexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfexpression([NotNull] DynamicEnemyGrammarParser.IfexpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.whileexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileexpression([NotNull] DynamicEnemyGrammarParser.WhileexpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] DynamicEnemyGrammarParser.BlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.character"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCharacter([NotNull] DynamicEnemyGrammarParser.CharacterContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.possibleAttributes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPossibleAttributes([NotNull] DynamicEnemyGrammarParser.PossibleAttributesContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.place"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPlace([NotNull] DynamicEnemyGrammarParser.PlaceContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.x"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitX([NotNull] DynamicEnemyGrammarParser.XContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.y"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitY([NotNull] DynamicEnemyGrammarParser.YContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] DynamicEnemyGrammarParser.ExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.something"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSomething([NotNull] DynamicEnemyGrammarParser.SomethingContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DynamicEnemyGrammarParser.operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperation([NotNull] DynamicEnemyGrammarParser.OperationContext context);
}
} // namespace LabWork1github
