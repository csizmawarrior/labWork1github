//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Dana\Source\Repos\LabWork1github\LabWork1github\g4 files\MonsterGrammar.g4 by ANTLR 4.6.6

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
/// <see cref="MonsterGrammarParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IMonsterGrammarListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="MonsterGrammarParser.definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefinition([NotNull] MonsterGrammarParser.DefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MonsterGrammarParser.definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefinition([NotNull] MonsterGrammarParser.DefinitionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MonsterGrammarParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterName([NotNull] MonsterGrammarParser.NameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MonsterGrammarParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitName([NotNull] MonsterGrammarParser.NameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MonsterGrammarParser.statementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementList([NotNull] MonsterGrammarParser.StatementListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MonsterGrammarParser.statementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementList([NotNull] MonsterGrammarParser.StatementListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MonsterGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] MonsterGrammarParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MonsterGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] MonsterGrammarParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MonsterGrammarParser.nameDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNameDeclaration([NotNull] MonsterGrammarParser.NameDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MonsterGrammarParser.nameDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNameDeclaration([NotNull] MonsterGrammarParser.NameDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MonsterGrammarParser.rangeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRangeDeclaration([NotNull] MonsterGrammarParser.RangeDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MonsterGrammarParser.rangeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRangeDeclaration([NotNull] MonsterGrammarParser.RangeDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MonsterGrammarParser.moveRoundDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMoveRoundDeclaration([NotNull] MonsterGrammarParser.MoveRoundDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MonsterGrammarParser.moveRoundDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMoveRoundDeclaration([NotNull] MonsterGrammarParser.MoveRoundDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MonsterGrammarParser.shootRoundDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShootRoundDeclaration([NotNull] MonsterGrammarParser.ShootRoundDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MonsterGrammarParser.shootRoundDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShootRoundDeclaration([NotNull] MonsterGrammarParser.ShootRoundDeclarationContext context);
}
} // namespace LabWork1github
