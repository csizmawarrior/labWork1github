//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Dana\source\repos\LabWork1\LabWork1\boardGrammar.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace LabWork1 {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="boardGrammarParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IboardGrammarListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="boardGrammarParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] boardGrammarParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="boardGrammarParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] boardGrammarParser.ProgramContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="boardGrammarParser.statementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementList([NotNull] boardGrammarParser.StatementListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="boardGrammarParser.statementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementList([NotNull] boardGrammarParser.StatementListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="boardGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] boardGrammarParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="boardGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] boardGrammarParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="boardGrammarParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeName([NotNull] boardGrammarParser.TypeNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="boardGrammarParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeName([NotNull] boardGrammarParser.TypeNameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="boardGrammarParser.place"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPlace([NotNull] boardGrammarParser.PlaceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="boardGrammarParser.place"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPlace([NotNull] boardGrammarParser.PlaceContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="boardGrammarParser.boardCreation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoardCreation([NotNull] boardGrammarParser.BoardCreationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="boardGrammarParser.boardCreation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoardCreation([NotNull] boardGrammarParser.BoardCreationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="boardGrammarParser.playerPlacement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPlayerPlacement([NotNull] boardGrammarParser.PlayerPlacementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="boardGrammarParser.playerPlacement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPlayerPlacement([NotNull] boardGrammarParser.PlayerPlacementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="boardGrammarParser.enemyPlacement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnemyPlacement([NotNull] boardGrammarParser.EnemyPlacementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="boardGrammarParser.enemyPlacement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnemyPlacement([NotNull] boardGrammarParser.EnemyPlacementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="boardGrammarParser.trapPlacement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrapPlacement([NotNull] boardGrammarParser.TrapPlacementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="boardGrammarParser.trapPlacement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrapPlacement([NotNull] boardGrammarParser.TrapPlacementContext context);
}
} // namespace LabWork1
