﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\ppmic\Desktop\Kalkulator dat\Daty\Daty.g4 by ANTLR 4.6.5

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Daty {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="DatyParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.5")]
[System.CLSCompliant(false)]
public interface IDatyListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>dzialanie</c>
	/// labeled alternative in <see cref="DatyParser.wyrazenie"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDzialanie([NotNull] DatyParser.DzialanieContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>dzialanie</c>
	/// labeled alternative in <see cref="DatyParser.wyrazenie"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDzialanie([NotNull] DatyParser.DzialanieContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>koniec</c>
	/// labeled alternative in <see cref="DatyParser.wyrazenie"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKoniec([NotNull] DatyParser.KoniecContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>koniec</c>
	/// labeled alternative in <see cref="DatyParser.wyrazenie"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKoniec([NotNull] DatyParser.KoniecContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DatyParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProg([NotNull] DatyParser.ProgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DatyParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProg([NotNull] DatyParser.ProgContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DatyParser.wyrazenie"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWyrazenie([NotNull] DatyParser.WyrazenieContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DatyParser.wyrazenie"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWyrazenie([NotNull] DatyParser.WyrazenieContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DatyParser.ddmmrrrr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDdmmrrrr([NotNull] DatyParser.DdmmrrrrContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DatyParser.ddmmrrrr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDdmmrrrr([NotNull] DatyParser.DdmmrrrrContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DatyParser.mmddrrrr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMmddrrrr([NotNull] DatyParser.MmddrrrrContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DatyParser.mmddrrrr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMmddrrrr([NotNull] DatyParser.MmddrrrrContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DatyParser.rrrrmmdd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRrrrmmdd([NotNull] DatyParser.RrrrmmddContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DatyParser.rrrrmmdd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRrrrmmdd([NotNull] DatyParser.RrrrmmddContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DatyParser.rrrrddmm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRrrrddmm([NotNull] DatyParser.RrrrddmmContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DatyParser.rrrrddmm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRrrrddmm([NotNull] DatyParser.RrrrddmmContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DatyParser.timespan"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTimespan([NotNull] DatyParser.TimespanContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DatyParser.timespan"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTimespan([NotNull] DatyParser.TimespanContext context);
}
} // namespace Daty
