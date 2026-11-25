//
//	This file was generated with ANGLR compiler
//
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Anglr.Lexer.Core;
using Asn.RegexLib;

namespace Asn.Lexer
{

	public class AsnLexer : LexerBase
	{
		public CommentRegex CommentRegex { get { return (CommentRegex) regarray [commentScanner]; } }
		public LineCommentRegex LineCommentRegex { get { return (LineCommentRegex) regarray [lineCommentScanner]; } }
		public CstringRegex CstringRegex { get { return (CstringRegex) regarray [cstringScanner]; } }
		public MacroRegex MacroRegex { get { return (MacroRegex) regarray [macroScanner]; } }
		public AsnRegex AsnRegex { get { return (AsnRegex) regarray [asnScanner]; } }
		public object [] Info { get; private set; }
		public AsnLexer (TextReader textReader, object [] info = null)
		{
			Info = info;
			Init ();
			pushInput (textReader);
			pushScanner (asnScanner, "");
		}

		public AsnLexer (string [] lines, object [] info = null)
		{
			Info = info;
			Init ();
			pushInput (lines);
			pushScanner (asnScanner, "");
		}

		public AsnLexer (string line, object [] info = null)
		{
			Info = info;
			Init ();
			pushInput (line);
			pushScanner (asnScanner, "");
		}

		public void Init ()
		{
			regarray = new RegexInterface []
			{
				new CommentRegex (this),
				new LineCommentRegex (this),
				new CstringRegex (this),
				new MacroRegex (this),
				new AsnRegex (this),
			};
		}

		public override int ScannerNameToId (string name) => scannerIds [name];
		public override RegexInterface GetRegexInterface (int index) => regarray [index];
		// array of regular expression scanners
		private RegexInterface [] regarray = null;
		private Dictionary<string, int> scannerIds = new Dictionary<string, int>
		{
			{
				CommentRegex.Id,
				commentScanner
			},
			{
				LineCommentRegex.Id,
				lineCommentScanner
			},
			{
				CstringRegex.Id,
				cstringScanner
			},
			{
				MacroRegex.Id,
				macroScanner
			},
			{
				AsnRegex.Id,
				asnScanner
			},
		};

		// scanner codes
		public const int commentScanner = 0;
		public const int lineCommentScanner = 1;
		public const int cstringScanner = 2;
		public const int macroScanner = 3;
		public const int asnScanner = 4;
	}
}

