//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Dana\source\repos\LabWork1github\LabWork1github\g4 files\BoardGrammar.g4 by ANTLR 4.6.6

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
/// <see cref="BoardGrammarParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IBoardGrammarListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="BoardGrammarParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] BoardGrammarParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BoardGrammarParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] BoardGrammarParser.ProgramContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="BoardGrammarParser.statementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementList([NotNull] BoardGrammarParser.StatementListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BoardGrammarParser.statementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementList([NotNull] BoardGrammarParser.StatementListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="BoardGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] BoardGrammarParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BoardGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] BoardGrammarParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="BoardGrammarParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeName([NotNull] BoardGrammarParser.TypeNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BoardGrammarParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeName([NotNull] BoardGrammarParser.TypeNameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="BoardGrammarParser.place"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPlace([NotNull] BoardGrammarParser.PlaceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BoardGrammarParser.place"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPlace([NotNull] BoardGrammarParser.PlaceContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="BoardGrammarParser.x"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterX([NotNull] BoardGrammarParser.XContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BoardGrammarParser.x"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitX([NotNull] BoardGrammarParser.XContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="BoardGrammarParser.y"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterY([NotNull] BoardGrammarParser.YContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BoardGrammarParser.y"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitY([NotNull] BoardGrammarParser.YContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="BoardGrammarParser.boardCreation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoardCreation([NotNull] BoardGrammarParser.BoardCreationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BoardGrammarParser.boardCreation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoardCreation([NotNull] BoardGrammarParser.BoardCreationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="BoardGrammarParser.playerPlacement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPlayerPlacement([NotNull] BoardGrammarParser.PlayerPlacementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BoardGrammarParser.playerPlacement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPlayerPlacement([NotNull] BoardGrammarParser.PlayerPlacementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="BoardGrammarParser.monsterPlacement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMonsterPlacement([NotNull] BoardGrammarParser.MonsterPlacementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BoardGrammarParser.monsterPlacement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMonsterPlacement([NotNull] BoardGrammarParser.MonsterPlacementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="BoardGrammarParser.trapPlacement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrapPlacement([NotNull] BoardGrammarParser.TrapPlacementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BoardGrammarParser.trapPlacement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrapPlacement([NotNull] BoardGrammarParser.TrapPlacementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="BoardGrammarParser.nameDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNameDeclaration([NotNull] BoardGrammarParser.NameDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BoardGrammarParser.nameDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNameDeclaration([NotNull] BoardGrammarParser.NameDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="BoardGrammarParser.partnerDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartnerDeclaration([NotNull] BoardGrammarParser.PartnerDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BoardGrammarParser.partnerDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartnerDeclaration([NotNull] BoardGrammarParser.PartnerDeclarationContext context);
}
} // namespace LabWork1github
