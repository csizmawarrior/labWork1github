//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Dana\source\repos\LabWork1github\LabWork1github\PlayerGrammar.g4 by ANTLR 4.6.6

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
/// <see cref="PlayerGrammarParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IPlayerGrammarListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlayerGrammarParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] PlayerGrammarParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlayerGrammarParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] PlayerGrammarParser.ProgramContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PlayerGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] PlayerGrammarParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlayerGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] PlayerGrammarParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PlayerGrammarParser.direction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDirection([NotNull] PlayerGrammarParser.DirectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlayerGrammarParser.direction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDirection([NotNull] PlayerGrammarParser.DirectionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PlayerGrammarParser.movingStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMovingStatement([NotNull] PlayerGrammarParser.MovingStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlayerGrammarParser.movingStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMovingStatement([NotNull] PlayerGrammarParser.MovingStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PlayerGrammarParser.shootingStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShootingStatement([NotNull] PlayerGrammarParser.ShootingStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlayerGrammarParser.shootingStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShootingStatement([NotNull] PlayerGrammarParser.ShootingStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PlayerGrammarParser.healthCheckStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHealthCheckStatement([NotNull] PlayerGrammarParser.HealthCheckStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlayerGrammarParser.healthCheckStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHealthCheckStatement([NotNull] PlayerGrammarParser.HealthCheckStatementContext context);
}
} // namespace LabWork1github
