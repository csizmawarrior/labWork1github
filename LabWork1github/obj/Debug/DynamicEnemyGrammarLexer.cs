//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Dana\Source\Repos\LabWork1github\LabWork1github\G4 files\DynamicEnemyGrammar.g4 by ANTLR 4.6.6

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
public partial class DynamicEnemyGrammarLexer : Lexer {
	public const int
		TELEPORT_PLACE=1, SPAWN_PLACE=2, SPAWN_TYPE=3, NOTHING=4, RANDOM=5, DISTANCE=6, 
		DAMAGE=7, DIRECTION=8, NAME_T=9, TRAP=10, MONSTER=11, PLAYER=12, PLACE_T=13, 
		ROUND=14, NEAR=15, IS=16, ME=17, IF=18, TO=19, WHILE=20, HEALTH=21, ALIVE=22, 
		MOVE=23, ON=24, SHOOT=25, SPAWN=26, TELEPORT_T=27, HEAL=28, EQUALS=29, 
		ABSOLUTE=30, NEGATE=31, BOOLCONNECTER=32, COMPARE=33, NUMCOMPARE=34, NUMCONNECTER=35, 
		PARENTHESISSTART=36, PARENTHESISCLOSE=37, BRACKETCLOSE=38, BRACKETSTART=39, 
		COLON=40, SEMI=41, COMMA=42, DOT=43, NUMBER=44, ID=45, WS=46;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"TELEPORT_PLACE", "SPAWN_PLACE", "SPAWN_TYPE", "NOTHING", "RANDOM", "DISTANCE", 
		"DAMAGE", "DIRECTION", "NAME_T", "TRAP", "MONSTER", "PLAYER", "PLACE_T", 
		"ROUND", "NEAR", "IS", "ME", "IF", "TO", "WHILE", "HEALTH", "ALIVE", "MOVE", 
		"ON", "SHOOT", "SPAWN", "TELEPORT_T", "HEAL", "EQUALS", "ABSOLUTE", "NEGATE", 
		"BOOLCONNECTER", "COMPARE", "NUMCOMPARE", "NUMCONNECTER", "PARENTHESISSTART", 
		"PARENTHESISCLOSE", "BRACKETCLOSE", "BRACKETSTART", "COLON", "SEMI", "COMMA", 
		"DOT", "NUMBER", "ID", "WS"
	};


	public DynamicEnemyGrammarLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'teleport_place'", "'spawn_place'", "'spawn_type'", "'nothing'", 
		"'random'", "'distance'", "'damage'", null, "'name'", "'trap'", "'monster'", 
		"'player'", "'place'", "'round'", "'near'", "'is'", "'me'", "'if'", "'to'", 
		"'while'", "'health'", "'alive'", "'move'", "'on'", "'shoot'", "'spawn'", 
		"'teleport'", "'heal'", "'='", "'|'", "'!'", null, null, null, null, "'('", 
		"')'", "'}'", "'{'", "':'", "';'", "','", "'.'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "TELEPORT_PLACE", "SPAWN_PLACE", "SPAWN_TYPE", "NOTHING", "RANDOM", 
		"DISTANCE", "DAMAGE", "DIRECTION", "NAME_T", "TRAP", "MONSTER", "PLAYER", 
		"PLACE_T", "ROUND", "NEAR", "IS", "ME", "IF", "TO", "WHILE", "HEALTH", 
		"ALIVE", "MOVE", "ON", "SHOOT", "SPAWN", "TELEPORT_T", "HEAL", "EQUALS", 
		"ABSOLUTE", "NEGATE", "BOOLCONNECTER", "COMPARE", "NUMCOMPARE", "NUMCONNECTER", 
		"PARENTHESISSTART", "PARENTHESISCLOSE", "BRACKETCLOSE", "BRACKETSTART", 
		"COLON", "SEMI", "COMMA", "DOT", "NUMBER", "ID", "WS"
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

	public override string GrammarFileName { get { return "DynamicEnemyGrammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x30\x14F\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A"+
		"\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 "+
		"\t \x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t"+
		")\x4*\t*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x3\x2\x3\x2\x3\x2\x3\x2\x3"+
		"\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5"+
		"\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3"+
		"\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b"+
		"\x3\b\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\n\x3\v\x3\v"+
		"\x3\v\x3\v\x3\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\r\x3\r\x3\r"+
		"\x3\r\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3"+
		"\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x11\x3\x11"+
		"\x3\x11\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14"+
		"\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x16"+
		"\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x18"+
		"\x3\x18\x3\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A"+
		"\x3\x1A\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1C"+
		"\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1D\x3\x1D"+
		"\x3\x1D\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3 \x3 \x3!\x3!\x3!"+
		"\x3!\x5!\x11C\n!\x3\"\x3\"\x3\"\x3\"\x5\"\x122\n\"\x3#\x3#\x3$\x3$\x3"+
		"%\x3%\x3&\x3&\x3\'\x3\'\x3(\x3(\x3)\x3)\x3*\x3*\x3+\x3+\x3,\x3,\x3-\x6"+
		"-\x139\n-\r-\xE-\x13A\x3-\x3-\x6-\x13F\n-\r-\xE-\x140\x5-\x143\n-\x3."+
		"\x3.\a.\x147\n.\f.\xE.\x14A\v.\x3/\x3/\x3/\x3/\x2\x2\x2\x30\x3\x2\x3\x5"+
		"\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2"+
		"\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13"+
		"%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31\x2\x1A\x33\x2\x1B"+
		"\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?\x2!\x41\x2\"\x43\x2#\x45"+
		"\x2$G\x2%I\x2&K\x2\'M\x2(O\x2)Q\x2*S\x2+U\x2,W\x2-Y\x2.[\x2/]\x2\x30\x3"+
		"\x2\t\x6\x2\x44\x44HHNNTT\x4\x2>>@@\x6\x2\'\',-//\x31\x31\x3\x2\x32;\x4"+
		"\x2\x43\\\x63|\x6\x2\x32;\x43\\\x61\x61\x63|\x5\x2\v\f\xF\xF\"\"\x154"+
		"\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2"+
		"\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2"+
		"\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2"+
		"\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3"+
		"\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2"+
		"\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2"+
		"\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2"+
		"\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2"+
		"\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2"+
		"\x2\x2K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2O\x3\x2\x2\x2\x2Q\x3\x2\x2\x2\x2"+
		"S\x3\x2\x2\x2\x2U\x3\x2\x2\x2\x2W\x3\x2\x2\x2\x2Y\x3\x2\x2\x2\x2[\x3\x2"+
		"\x2\x2\x2]\x3\x2\x2\x2\x3_\x3\x2\x2\x2\x5n\x3\x2\x2\x2\az\x3\x2\x2\x2"+
		"\t\x85\x3\x2\x2\x2\v\x8D\x3\x2\x2\x2\r\x94\x3\x2\x2\x2\xF\x9D\x3\x2\x2"+
		"\x2\x11\xA4\x3\x2\x2\x2\x13\xA6\x3\x2\x2\x2\x15\xAB\x3\x2\x2\x2\x17\xB0"+
		"\x3\x2\x2\x2\x19\xB8\x3\x2\x2\x2\x1B\xBF\x3\x2\x2\x2\x1D\xC5\x3\x2\x2"+
		"\x2\x1F\xCB\x3\x2\x2\x2!\xD0\x3\x2\x2\x2#\xD3\x3\x2\x2\x2%\xD6\x3\x2\x2"+
		"\x2\'\xD9\x3\x2\x2\x2)\xDC\x3\x2\x2\x2+\xE2\x3\x2\x2\x2-\xE9\x3\x2\x2"+
		"\x2/\xEF\x3\x2\x2\x2\x31\xF4\x3\x2\x2\x2\x33\xF7\x3\x2\x2\x2\x35\xFD\x3"+
		"\x2\x2\x2\x37\x103\x3\x2\x2\x2\x39\x10C\x3\x2\x2\x2;\x111\x3\x2\x2\x2"+
		"=\x113\x3\x2\x2\x2?\x115\x3\x2\x2\x2\x41\x11B\x3\x2\x2\x2\x43\x121\x3"+
		"\x2\x2\x2\x45\x123\x3\x2\x2\x2G\x125\x3\x2\x2\x2I\x127\x3\x2\x2\x2K\x129"+
		"\x3\x2\x2\x2M\x12B\x3\x2\x2\x2O\x12D\x3\x2\x2\x2Q\x12F\x3\x2\x2\x2S\x131"+
		"\x3\x2\x2\x2U\x133\x3\x2\x2\x2W\x135\x3\x2\x2\x2Y\x138\x3\x2\x2\x2[\x144"+
		"\x3\x2\x2\x2]\x14B\x3\x2\x2\x2_`\av\x2\x2`\x61\ag\x2\x2\x61\x62\an\x2"+
		"\x2\x62\x63\ag\x2\x2\x63\x64\ar\x2\x2\x64\x65\aq\x2\x2\x65\x66\at\x2\x2"+
		"\x66g\av\x2\x2gh\a\x61\x2\x2hi\ar\x2\x2ij\an\x2\x2jk\a\x63\x2\x2kl\a\x65"+
		"\x2\x2lm\ag\x2\x2m\x4\x3\x2\x2\x2no\au\x2\x2op\ar\x2\x2pq\a\x63\x2\x2"+
		"qr\ay\x2\x2rs\ap\x2\x2st\a\x61\x2\x2tu\ar\x2\x2uv\an\x2\x2vw\a\x63\x2"+
		"\x2wx\a\x65\x2\x2xy\ag\x2\x2y\x6\x3\x2\x2\x2z{\au\x2\x2{|\ar\x2\x2|}\a"+
		"\x63\x2\x2}~\ay\x2\x2~\x7F\ap\x2\x2\x7F\x80\a\x61\x2\x2\x80\x81\av\x2"+
		"\x2\x81\x82\a{\x2\x2\x82\x83\ar\x2\x2\x83\x84\ag\x2\x2\x84\b\x3\x2\x2"+
		"\x2\x85\x86\ap\x2\x2\x86\x87\aq\x2\x2\x87\x88\av\x2\x2\x88\x89\aj\x2\x2"+
		"\x89\x8A\ak\x2\x2\x8A\x8B\ap\x2\x2\x8B\x8C\ai\x2\x2\x8C\n\x3\x2\x2\x2"+
		"\x8D\x8E\at\x2\x2\x8E\x8F\a\x63\x2\x2\x8F\x90\ap\x2\x2\x90\x91\a\x66\x2"+
		"\x2\x91\x92\aq\x2\x2\x92\x93\ao\x2\x2\x93\f\x3\x2\x2\x2\x94\x95\a\x66"+
		"\x2\x2\x95\x96\ak\x2\x2\x96\x97\au\x2\x2\x97\x98\av\x2\x2\x98\x99\a\x63"+
		"\x2\x2\x99\x9A\ap\x2\x2\x9A\x9B\a\x65\x2\x2\x9B\x9C\ag\x2\x2\x9C\xE\x3"+
		"\x2\x2\x2\x9D\x9E\a\x66\x2\x2\x9E\x9F\a\x63\x2\x2\x9F\xA0\ao\x2\x2\xA0"+
		"\xA1\a\x63\x2\x2\xA1\xA2\ai\x2\x2\xA2\xA3\ag\x2\x2\xA3\x10\x3\x2\x2\x2"+
		"\xA4\xA5\t\x2\x2\x2\xA5\x12\x3\x2\x2\x2\xA6\xA7\ap\x2\x2\xA7\xA8\a\x63"+
		"\x2\x2\xA8\xA9\ao\x2\x2\xA9\xAA\ag\x2\x2\xAA\x14\x3\x2\x2\x2\xAB\xAC\a"+
		"v\x2\x2\xAC\xAD\at\x2\x2\xAD\xAE\a\x63\x2\x2\xAE\xAF\ar\x2\x2\xAF\x16"+
		"\x3\x2\x2\x2\xB0\xB1\ao\x2\x2\xB1\xB2\aq\x2\x2\xB2\xB3\ap\x2\x2\xB3\xB4"+
		"\au\x2\x2\xB4\xB5\av\x2\x2\xB5\xB6\ag\x2\x2\xB6\xB7\at\x2\x2\xB7\x18\x3"+
		"\x2\x2\x2\xB8\xB9\ar\x2\x2\xB9\xBA\an\x2\x2\xBA\xBB\a\x63\x2\x2\xBB\xBC"+
		"\a{\x2\x2\xBC\xBD\ag\x2\x2\xBD\xBE\at\x2\x2\xBE\x1A\x3\x2\x2\x2\xBF\xC0"+
		"\ar\x2\x2\xC0\xC1\an\x2\x2\xC1\xC2\a\x63\x2\x2\xC2\xC3\a\x65\x2\x2\xC3"+
		"\xC4\ag\x2\x2\xC4\x1C\x3\x2\x2\x2\xC5\xC6\at\x2\x2\xC6\xC7\aq\x2\x2\xC7"+
		"\xC8\aw\x2\x2\xC8\xC9\ap\x2\x2\xC9\xCA\a\x66\x2\x2\xCA\x1E\x3\x2\x2\x2"+
		"\xCB\xCC\ap\x2\x2\xCC\xCD\ag\x2\x2\xCD\xCE\a\x63\x2\x2\xCE\xCF\at\x2\x2"+
		"\xCF \x3\x2\x2\x2\xD0\xD1\ak\x2\x2\xD1\xD2\au\x2\x2\xD2\"\x3\x2\x2\x2"+
		"\xD3\xD4\ao\x2\x2\xD4\xD5\ag\x2\x2\xD5$\x3\x2\x2\x2\xD6\xD7\ak\x2\x2\xD7"+
		"\xD8\ah\x2\x2\xD8&\x3\x2\x2\x2\xD9\xDA\av\x2\x2\xDA\xDB\aq\x2\x2\xDB("+
		"\x3\x2\x2\x2\xDC\xDD\ay\x2\x2\xDD\xDE\aj\x2\x2\xDE\xDF\ak\x2\x2\xDF\xE0"+
		"\an\x2\x2\xE0\xE1\ag\x2\x2\xE1*\x3\x2\x2\x2\xE2\xE3\aj\x2\x2\xE3\xE4\a"+
		"g\x2\x2\xE4\xE5\a\x63\x2\x2\xE5\xE6\an\x2\x2\xE6\xE7\av\x2\x2\xE7\xE8"+
		"\aj\x2\x2\xE8,\x3\x2\x2\x2\xE9\xEA\a\x63\x2\x2\xEA\xEB\an\x2\x2\xEB\xEC"+
		"\ak\x2\x2\xEC\xED\ax\x2\x2\xED\xEE\ag\x2\x2\xEE.\x3\x2\x2\x2\xEF\xF0\a"+
		"o\x2\x2\xF0\xF1\aq\x2\x2\xF1\xF2\ax\x2\x2\xF2\xF3\ag\x2\x2\xF3\x30\x3"+
		"\x2\x2\x2\xF4\xF5\aq\x2\x2\xF5\xF6\ap\x2\x2\xF6\x32\x3\x2\x2\x2\xF7\xF8"+
		"\au\x2\x2\xF8\xF9\aj\x2\x2\xF9\xFA\aq\x2\x2\xFA\xFB\aq\x2\x2\xFB\xFC\a"+
		"v\x2\x2\xFC\x34\x3\x2\x2\x2\xFD\xFE\au\x2\x2\xFE\xFF\ar\x2\x2\xFF\x100"+
		"\a\x63\x2\x2\x100\x101\ay\x2\x2\x101\x102\ap\x2\x2\x102\x36\x3\x2\x2\x2"+
		"\x103\x104\av\x2\x2\x104\x105\ag\x2\x2\x105\x106\an\x2\x2\x106\x107\a"+
		"g\x2\x2\x107\x108\ar\x2\x2\x108\x109\aq\x2\x2\x109\x10A\at\x2\x2\x10A"+
		"\x10B\av\x2\x2\x10B\x38\x3\x2\x2\x2\x10C\x10D\aj\x2\x2\x10D\x10E\ag\x2"+
		"\x2\x10E\x10F\a\x63\x2\x2\x10F\x110\an\x2\x2\x110:\x3\x2\x2\x2\x111\x112"+
		"\a?\x2\x2\x112<\x3\x2\x2\x2\x113\x114\a~\x2\x2\x114>\x3\x2\x2\x2\x115"+
		"\x116\a#\x2\x2\x116@\x3\x2\x2\x2\x117\x118\a~\x2\x2\x118\x11C\a~\x2\x2"+
		"\x119\x11A\a(\x2\x2\x11A\x11C\a(\x2\x2\x11B\x117\x3\x2\x2\x2\x11B\x119"+
		"\x3\x2\x2\x2\x11C\x42\x3\x2\x2\x2\x11D\x11E\a?\x2\x2\x11E\x122\a?\x2\x2"+
		"\x11F\x120\a#\x2\x2\x120\x122\a?\x2\x2\x121\x11D\x3\x2\x2\x2\x121\x11F"+
		"\x3\x2\x2\x2\x122\x44\x3\x2\x2\x2\x123\x124\t\x3\x2\x2\x124\x46\x3\x2"+
		"\x2\x2\x125\x126\t\x4\x2\x2\x126H\x3\x2\x2\x2\x127\x128\a*\x2\x2\x128"+
		"J\x3\x2\x2\x2\x129\x12A\a+\x2\x2\x12AL\x3\x2\x2\x2\x12B\x12C\a\x7F\x2"+
		"\x2\x12CN\x3\x2\x2\x2\x12D\x12E\a}\x2\x2\x12EP\x3\x2\x2\x2\x12F\x130\a"+
		"<\x2\x2\x130R\x3\x2\x2\x2\x131\x132\a=\x2\x2\x132T\x3\x2\x2\x2\x133\x134"+
		"\a.\x2\x2\x134V\x3\x2\x2\x2\x135\x136\a\x30\x2\x2\x136X\x3\x2\x2\x2\x137"+
		"\x139\t\x5\x2\x2\x138\x137\x3\x2\x2\x2\x139\x13A\x3\x2\x2\x2\x13A\x138"+
		"\x3\x2\x2\x2\x13A\x13B\x3\x2\x2\x2\x13B\x142\x3\x2\x2\x2\x13C\x13E\a\x30"+
		"\x2\x2\x13D\x13F\t\x5\x2\x2\x13E\x13D\x3\x2\x2\x2\x13F\x140\x3\x2\x2\x2"+
		"\x140\x13E\x3\x2\x2\x2\x140\x141\x3\x2\x2\x2\x141\x143\x3\x2\x2\x2\x142"+
		"\x13C\x3\x2\x2\x2\x142\x143\x3\x2\x2\x2\x143Z\x3\x2\x2\x2\x144\x148\t"+
		"\x6\x2\x2\x145\x147\t\a\x2\x2\x146\x145\x3\x2\x2\x2\x147\x14A\x3\x2\x2"+
		"\x2\x148\x146\x3\x2\x2\x2\x148\x149\x3\x2\x2\x2\x149\\\x3\x2\x2\x2\x14A"+
		"\x148\x3\x2\x2\x2\x14B\x14C\t\b\x2\x2\x14C\x14D\x3\x2\x2\x2\x14D\x14E"+
		"\b/\x2\x2\x14E^\x3\x2\x2\x2\t\x2\x11B\x121\x13A\x140\x142\x148\x3\b\x2"+
		"\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace LabWork1github
