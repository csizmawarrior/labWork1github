//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Dana\source\repos\visual studio 2019\LabWork1github\g4 files\BoardGrammar.g4 by ANTLR 4.6.6

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
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class BoardGrammarLexer : Lexer {
	public const int
		SEMI=1, COMMA=2, COORDINATE=3, BOARD=4, PARTNER=5, PLAYER=6, NAME_T=7, 
		MONSTER=8, TRAP=9, EQUALS=10, ID=11, WS=12;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"SEMI", "COMMA", "COORDINATE", "BOARD", "PARTNER", "PLAYER", "NAME_T", 
		"MONSTER", "TRAP", "EQUALS", "ID", "WS"
	};


	public BoardGrammarLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "','", null, "'board'", "'partner'", "'player'", "'name'", 
		"'monster'", "'trap'", "'='"
	};
	private static readonly string[] _SymbolicNames = {
		null, "SEMI", "COMMA", "COORDINATE", "BOARD", "PARTNER", "PLAYER", "NAME_T", 
		"MONSTER", "TRAP", "EQUALS", "ID", "WS"
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

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\xEX\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x3\x2\x3\x2\x3\x3\x3\x3\x3"+
		"\x4\x6\x4!\n\x4\r\x4\xE\x4\"\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6"+
		"\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3"+
		"\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3"+
		"\t\x3\n\x3\n\x3\n\x3\n\x3\n\x3\v\x3\v\x3\f\x3\f\a\fP\n\f\f\f\xE\fS\v\f"+
		"\x3\r\x3\r\x3\r\x3\r\x2\x2\x2\xE\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2"+
		"\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x3\x2"+
		"\x6\x3\x2\x32;\x4\x2\x43\\\x63|\x6\x2\x32;\x43\\\x61\x61\x63|\x5\x2\v"+
		"\f\xF\xF\"\"Y\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2"+
		"\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2"+
		"\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2"+
		"\x2\x2\x19\x3\x2\x2\x2\x3\x1B\x3\x2\x2\x2\x5\x1D\x3\x2\x2\x2\a \x3\x2"+
		"\x2\x2\t$\x3\x2\x2\x2\v*\x3\x2\x2\x2\r\x32\x3\x2\x2\x2\xF\x39\x3\x2\x2"+
		"\x2\x11>\x3\x2\x2\x2\x13\x46\x3\x2\x2\x2\x15K\x3\x2\x2\x2\x17M\x3\x2\x2"+
		"\x2\x19T\x3\x2\x2\x2\x1B\x1C\a=\x2\x2\x1C\x4\x3\x2\x2\x2\x1D\x1E\a.\x2"+
		"\x2\x1E\x6\x3\x2\x2\x2\x1F!\t\x2\x2\x2 \x1F\x3\x2\x2\x2!\"\x3\x2\x2\x2"+
		"\" \x3\x2\x2\x2\"#\x3\x2\x2\x2#\b\x3\x2\x2\x2$%\a\x64\x2\x2%&\aq\x2\x2"+
		"&\'\a\x63\x2\x2\'(\at\x2\x2()\a\x66\x2\x2)\n\x3\x2\x2\x2*+\ar\x2\x2+,"+
		"\a\x63\x2\x2,-\at\x2\x2-.\av\x2\x2./\ap\x2\x2/\x30\ag\x2\x2\x30\x31\a"+
		"t\x2\x2\x31\f\x3\x2\x2\x2\x32\x33\ar\x2\x2\x33\x34\an\x2\x2\x34\x35\a"+
		"\x63\x2\x2\x35\x36\a{\x2\x2\x36\x37\ag\x2\x2\x37\x38\at\x2\x2\x38\xE\x3"+
		"\x2\x2\x2\x39:\ap\x2\x2:;\a\x63\x2\x2;<\ao\x2\x2<=\ag\x2\x2=\x10\x3\x2"+
		"\x2\x2>?\ao\x2\x2?@\aq\x2\x2@\x41\ap\x2\x2\x41\x42\au\x2\x2\x42\x43\a"+
		"v\x2\x2\x43\x44\ag\x2\x2\x44\x45\at\x2\x2\x45\x12\x3\x2\x2\x2\x46G\av"+
		"\x2\x2GH\at\x2\x2HI\a\x63\x2\x2IJ\ar\x2\x2J\x14\x3\x2\x2\x2KL\a?\x2\x2"+
		"L\x16\x3\x2\x2\x2MQ\t\x3\x2\x2NP\t\x4\x2\x2ON\x3\x2\x2\x2PS\x3\x2\x2\x2"+
		"QO\x3\x2\x2\x2QR\x3\x2\x2\x2R\x18\x3\x2\x2\x2SQ\x3\x2\x2\x2TU\t\x5\x2"+
		"\x2UV\x3\x2\x2\x2VW\b\r\x2\x2W\x1A\x3\x2\x2\x2\x5\x2\"Q\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace LabWork1github
