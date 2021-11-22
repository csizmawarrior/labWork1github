//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Dana\Source\Repos\LabWork1github\LabWork1github\g4 files\BoardGrammar.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace LabWork1github {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class BoardGrammarParser : Parser {
	public const int
		SEMI=1, COMMA=2, COORDINATE=3, BOARD=4, PLAYER=5, MONSTER=6, TRAP=7, ID=8, 
		WS=9;
	public const int
		RULE_program = 0, RULE_statementList = 1, RULE_statement = 2, RULE_typeName = 3, 
		RULE_place = 4, RULE_x = 5, RULE_y = 6, RULE_boardCreation = 7, RULE_playerPlacement = 8, 
		RULE_monsterPlacement = 9, RULE_trapPlacement = 10;
	public static readonly string[] ruleNames = {
		"program", "statementList", "statement", "typeName", "place", "x", "y", 
		"boardCreation", "playerPlacement", "monsterPlacement", "trapPlacement"
	};

	private static readonly string[] _LiteralNames = {
		null, "';'", "','", null, "'board'", "'player'", "'monster'", "'trap'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "SEMI", "COMMA", "COORDINATE", "BOARD", "PLAYER", "MONSTER", "TRAP", 
		"ID", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "BoardGrammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public BoardGrammarParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class ProgramContext : ParserRuleContext {
		public StatementListContext statementList() {
			return GetRuleContext<StatementListContext>(0);
		}
		public ProgramContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_program; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.EnterProgram(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.ExitProgram(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBoardGrammarVisitor<TResult> typedVisitor = visitor as IBoardGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProgram(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgramContext program() {
		ProgramContext _localctx = new ProgramContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_program);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 22; statementList();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementListContext : ParserRuleContext {
		public BoardCreationContext boardCreation() {
			return GetRuleContext<BoardCreationContext>(0);
		}
		public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public StatementListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statementList; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.EnterStatementList(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.ExitStatementList(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBoardGrammarVisitor<TResult> typedVisitor = visitor as IBoardGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStatementList(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatementListContext statementList() {
		StatementListContext _localctx = new StatementListContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_statementList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 24; boardCreation();
			State = 28;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << PLAYER) | (1L << MONSTER) | (1L << TRAP))) != 0)) {
				{
				{
				State = 25; statement();
				}
				}
				State = 30;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementContext : ParserRuleContext {
		public PlayerPlacementContext playerPlacement() {
			return GetRuleContext<PlayerPlacementContext>(0);
		}
		public MonsterPlacementContext monsterPlacement() {
			return GetRuleContext<MonsterPlacementContext>(0);
		}
		public TrapPlacementContext trapPlacement() {
			return GetRuleContext<TrapPlacementContext>(0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBoardGrammarVisitor<TResult> typedVisitor = visitor as IBoardGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_statement);
		try {
			State = 34;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case PLAYER:
				EnterOuterAlt(_localctx, 1);
				{
				State = 31; playerPlacement();
				}
				break;
			case MONSTER:
				EnterOuterAlt(_localctx, 2);
				{
				State = 32; monsterPlacement();
				}
				break;
			case TRAP:
				EnterOuterAlt(_localctx, 3);
				{
				State = 33; trapPlacement();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TypeNameContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(BoardGrammarParser.ID, 0); }
		public TypeNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeName; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.EnterTypeName(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.ExitTypeName(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBoardGrammarVisitor<TResult> typedVisitor = visitor as IBoardGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTypeName(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TypeNameContext typeName() {
		TypeNameContext _localctx = new TypeNameContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_typeName);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 36; Match(ID);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PlaceContext : ParserRuleContext {
		public XContext x() {
			return GetRuleContext<XContext>(0);
		}
		public YContext y() {
			return GetRuleContext<YContext>(0);
		}
		public PlaceContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_place; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.EnterPlace(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.ExitPlace(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBoardGrammarVisitor<TResult> typedVisitor = visitor as IBoardGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPlace(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PlaceContext place() {
		PlaceContext _localctx = new PlaceContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_place);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 38; x();
			State = 39; Match(COMMA);
			State = 40; y();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class XContext : ParserRuleContext {
		public ITerminalNode COORDINATE() { return GetToken(BoardGrammarParser.COORDINATE, 0); }
		public XContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_x; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.EnterX(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.ExitX(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBoardGrammarVisitor<TResult> typedVisitor = visitor as IBoardGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitX(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public XContext x() {
		XContext _localctx = new XContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_x);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 42; Match(COORDINATE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class YContext : ParserRuleContext {
		public ITerminalNode COORDINATE() { return GetToken(BoardGrammarParser.COORDINATE, 0); }
		public YContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_y; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.EnterY(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.ExitY(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBoardGrammarVisitor<TResult> typedVisitor = visitor as IBoardGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitY(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public YContext y() {
		YContext _localctx = new YContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_y);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 44; Match(COORDINATE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BoardCreationContext : ParserRuleContext {
		public ITerminalNode BOARD() { return GetToken(BoardGrammarParser.BOARD, 0); }
		public PlaceContext place() {
			return GetRuleContext<PlaceContext>(0);
		}
		public BoardCreationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_boardCreation; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.EnterBoardCreation(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.ExitBoardCreation(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBoardGrammarVisitor<TResult> typedVisitor = visitor as IBoardGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBoardCreation(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public BoardCreationContext boardCreation() {
		BoardCreationContext _localctx = new BoardCreationContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_boardCreation);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 46; Match(BOARD);
			State = 47; place();
			State = 48; Match(SEMI);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PlayerPlacementContext : ParserRuleContext {
		public ITerminalNode PLAYER() { return GetToken(BoardGrammarParser.PLAYER, 0); }
		public PlaceContext place() {
			return GetRuleContext<PlaceContext>(0);
		}
		public PlayerPlacementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_playerPlacement; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.EnterPlayerPlacement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.ExitPlayerPlacement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBoardGrammarVisitor<TResult> typedVisitor = visitor as IBoardGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPlayerPlacement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PlayerPlacementContext playerPlacement() {
		PlayerPlacementContext _localctx = new PlayerPlacementContext(_ctx, State);
		EnterRule(_localctx, 16, RULE_playerPlacement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 50; Match(PLAYER);
			State = 51; place();
			State = 52; Match(SEMI);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MonsterPlacementContext : ParserRuleContext {
		public ITerminalNode MONSTER() { return GetToken(BoardGrammarParser.MONSTER, 0); }
		public PlaceContext place() {
			return GetRuleContext<PlaceContext>(0);
		}
		public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		public MonsterPlacementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_monsterPlacement; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.EnterMonsterPlacement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.ExitMonsterPlacement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBoardGrammarVisitor<TResult> typedVisitor = visitor as IBoardGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMonsterPlacement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MonsterPlacementContext monsterPlacement() {
		MonsterPlacementContext _localctx = new MonsterPlacementContext(_ctx, State);
		EnterRule(_localctx, 18, RULE_monsterPlacement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 54; Match(MONSTER);
			State = 55; place();
			State = 56; Match(COMMA);
			State = 57; typeName();
			State = 58; Match(SEMI);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TrapPlacementContext : ParserRuleContext {
		public ITerminalNode TRAP() { return GetToken(BoardGrammarParser.TRAP, 0); }
		public PlaceContext place() {
			return GetRuleContext<PlaceContext>(0);
		}
		public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		public TrapPlacementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_trapPlacement; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.EnterTrapPlacement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBoardGrammarListener typedListener = listener as IBoardGrammarListener;
			if (typedListener != null) typedListener.ExitTrapPlacement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBoardGrammarVisitor<TResult> typedVisitor = visitor as IBoardGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTrapPlacement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TrapPlacementContext trapPlacement() {
		TrapPlacementContext _localctx = new TrapPlacementContext(_ctx, State);
		EnterRule(_localctx, 20, RULE_trapPlacement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 60; Match(TRAP);
			State = 61; place();
			State = 62; Match(COMMA);
			State = 63; typeName();
			State = 64; Match(SEMI);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\v\x45\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t"+
		"\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x3\x2\x3\x2\x3\x3\x3\x3\a\x3\x1D\n\x3\f"+
		"\x3\xE\x3 \v\x3\x3\x4\x3\x4\x3\x4\x5\x4%\n\x4\x3\x5\x3\x5\x3\x6\x3\x6"+
		"\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3\n\x3"+
		"\n\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x2"+
		"\x2\x2\r\x2\x2\x4\x2\x6\x2\b\x2\n\x2\f\x2\xE\x2\x10\x2\x12\x2\x14\x2\x16"+
		"\x2\x2\x2<\x2\x18\x3\x2\x2\x2\x4\x1A\x3\x2\x2\x2\x6$\x3\x2\x2\x2\b&\x3"+
		"\x2\x2\x2\n(\x3\x2\x2\x2\f,\x3\x2\x2\x2\xE.\x3\x2\x2\x2\x10\x30\x3\x2"+
		"\x2\x2\x12\x34\x3\x2\x2\x2\x14\x38\x3\x2\x2\x2\x16>\x3\x2\x2\x2\x18\x19"+
		"\x5\x4\x3\x2\x19\x3\x3\x2\x2\x2\x1A\x1E\x5\x10\t\x2\x1B\x1D\x5\x6\x4\x2"+
		"\x1C\x1B\x3\x2\x2\x2\x1D \x3\x2\x2\x2\x1E\x1C\x3\x2\x2\x2\x1E\x1F\x3\x2"+
		"\x2\x2\x1F\x5\x3\x2\x2\x2 \x1E\x3\x2\x2\x2!%\x5\x12\n\x2\"%\x5\x14\v\x2"+
		"#%\x5\x16\f\x2$!\x3\x2\x2\x2$\"\x3\x2\x2\x2$#\x3\x2\x2\x2%\a\x3\x2\x2"+
		"\x2&\'\a\n\x2\x2\'\t\x3\x2\x2\x2()\x5\f\a\x2)*\a\x4\x2\x2*+\x5\xE\b\x2"+
		"+\v\x3\x2\x2\x2,-\a\x5\x2\x2-\r\x3\x2\x2\x2./\a\x5\x2\x2/\xF\x3\x2\x2"+
		"\x2\x30\x31\a\x6\x2\x2\x31\x32\x5\n\x6\x2\x32\x33\a\x3\x2\x2\x33\x11\x3"+
		"\x2\x2\x2\x34\x35\a\a\x2\x2\x35\x36\x5\n\x6\x2\x36\x37\a\x3\x2\x2\x37"+
		"\x13\x3\x2\x2\x2\x38\x39\a\b\x2\x2\x39:\x5\n\x6\x2:;\a\x4\x2\x2;<\x5\b"+
		"\x5\x2<=\a\x3\x2\x2=\x15\x3\x2\x2\x2>?\a\t\x2\x2?@\x5\n\x6\x2@\x41\a\x4"+
		"\x2\x2\x41\x42\x5\b\x5\x2\x42\x43\a\x3\x2\x2\x43\x17\x3\x2\x2\x2\x4\x1E"+
		"$";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace LabWork1github
