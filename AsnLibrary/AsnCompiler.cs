using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Asn.Parser;
using Asn.Lexer;
using Asn.Declarations;
using Asn.Scanner;
using Asn.RegexLib;
using Anglr.Lexer.Core;

namespace AsnLibrary
{
    internal enum PopState
    {
        None,
        MultiLineComment,
        SingleLineComment,
        MultiLineString,
        MacroBody
    }

    public class AsnCompiler : AsnParser
	{
		public AsnCompiler ()
		{
			sourceFileName = "";
		}

		public int Parse (string fileName, int [] startToken)
		{
			this.m_startToken = startToken;
			m_startTokenIndex = 0;
			sourceFileName = fileName;

            m_scanner = new AsnLexer (new StreamReader (sourceFileName));
			m_scanner.scannerEnterEvent += Scanner_scannerEnterEvent;
			m_scanner.scannerLeaveEvent += Scanner_scannerLeaveEvent;
            m_scanner.scannerPushEvent += Scanner_scannerPushEvent;
            m_scanner.scannerPopEvent += Scanner_scannerPopEvent;
            m_scanner.scannerTokenEvent += Scanner_scannerTokenEvent;

			CstringRegex cstringRegex = m_scanner.CstringRegex;
			cstringRegex._end_of_string__Event += CstringRegex__end_of_string__Event;

            MacroRegex macroRegex = m_scanner.MacroRegex;
			macroRegex._type_reference__Event += MacroRegex__type_reference__Event;

            AsnRegex asnRegex = m_scanner.AsnRegex;
			asnRegex._type_reference__Event += AsnRegex__type_reference__Event;
			asnRegex._identifier__Event += AsnRegex__identifier__Event;

			return parse (m_scanner);
		}

        public int ParseString (string str, int [] startToken)
		{
			this.m_startToken = startToken;
			m_startTokenIndex = 0;

            m_scanner = new AsnLexer (str);
			m_scanner.scannerEnterEvent += Scanner_scannerEnterEvent;
			m_scanner.scannerLeaveEvent += Scanner_scannerLeaveEvent;
			m_scanner.scannerPushEvent += Scanner_scannerPushEvent;
			m_scanner.scannerPopEvent += Scanner_scannerPopEvent;
			m_scanner.scannerTokenEvent += Scanner_scannerTokenEvent;

            CstringRegex cstringRegex = m_scanner.CstringRegex;
            cstringRegex._end_of_string__Event += CstringRegex__end_of_string__Event;

            MacroRegex macroRegex = m_scanner.MacroRegex;
            macroRegex._type_reference__Event += MacroRegex__type_reference__Event;

            AsnRegex asnRegex = m_scanner.AsnRegex;
            asnRegex._type_reference__Event += AsnRegex__type_reference__Event;
            asnRegex._identifier__Event += AsnRegex__identifier__Event;

            return parse (m_scanner);
		}

		public int ParseStringList (string [] lines, int [] startToken)
		{
			this.m_startToken = startToken;
			m_startTokenIndex = 0;

            m_scanner = new AsnLexer (lines);
			m_scanner.scannerEnterEvent += Scanner_scannerEnterEvent;
			m_scanner.scannerLeaveEvent += Scanner_scannerLeaveEvent;
			m_scanner.scannerPushEvent += Scanner_scannerPushEvent;
			m_scanner.scannerPopEvent += Scanner_scannerPopEvent;
			m_scanner.scannerTokenEvent += Scanner_scannerTokenEvent;

            CstringRegex cstringRegex = m_scanner.CstringRegex;
            cstringRegex._end_of_string__Event += CstringRegex__end_of_string__Event;

            MacroRegex macroRegex = m_scanner.MacroRegex;
            macroRegex._type_reference__Event += MacroRegex__type_reference__Event;

            AsnRegex asnRegex = m_scanner.AsnRegex;
            asnRegex._type_reference__Event += AsnRegex__type_reference__Event;
            asnRegex._identifier__Event += AsnRegex__identifier__Event;

            return parse (m_scanner);
		}

        private int Scanner_scannerEnterEvent ()
		{
			int token = (m_startTokenIndex < m_startToken.Length) ? m_startToken [m_startTokenIndex++] : -1;
			return token;
		}

		private void Scanner_scannerLeaveEvent (int token)
		{
			if (m_scanner.regexIndex != AsnLexer.asnScanner)
				return;
			switch (m_macroIndication)
			{
				case -1:
					if (token == AsnDeclarations.tokens.MACRO)
						m_macroIndication = 0;
					break;
				case 0:
					m_macroIndication = (token == AsnDeclarations.tokens.assignment_sign) ? 1 : -1;
					break;
				case 1:
					if (token == AsnDeclarations.tokens.BEGIN)
						m_scanner.pushScanner (AsnLexer.macroScanner, "");
					m_macroIndication = -1;
					break;
				default:
					m_macroIndication = -1;
					break;
			}
			if (debug)
				Console.WriteLine ($"(line: {m_scanner.lineno,5:d}, column: {m_scanner.column,5:d}, scanner: {m_scanner.regexIndex,5:d}, case: {m_scanner.scase,5:d}, token: {token,5:d}): {m_scanner.text}");
		}

		private void Scanner_scannerPushEvent (int oldCtx, int newCtx, string text)
		{
			switch (newCtx)
			{
				case AsnLexer.commentScanner:
					MultiLineComment = "";
					break;
				case AsnLexer.lineCommentScanner:
					SingleLineComment = "";
					break;
				case AsnLexer.cstringScanner:
					MultiLineString = "";
					break;
				case AsnLexer.macroScanner:
					MacroBody = "BEGIN";
					break;
				case AsnLexer.asnScanner:
					break;
			}
		}

		private void Scanner_scannerPopEvent (int oldCtx, int newCtx, string text)
		{
			if (true)
			switch (oldCtx)
			{
				case AsnLexer.commentScanner:
						m_state = PopState.MultiLineComment;
					break;
				case AsnLexer.lineCommentScanner:
                        m_state = PopState.SingleLineComment;
					break;
				case AsnLexer.cstringScanner:
                        m_state = PopState.MultiLineString;
					break;
				case AsnLexer.macroScanner:
                        m_state = PopState.MacroBody;
					break;
				case AsnLexer.asnScanner:
					break;
			}
		}

		private void Scanner_scannerTokenEvent (int ctx, int token, string text)
		{
			switch (ctx)
			{
				case AsnLexer.commentScanner:
					MultiLineComment += text;
					break;
				case AsnLexer.lineCommentScanner:
					SingleLineComment += text;
					break;
				case AsnLexer.cstringScanner:
					MultiLineString += text;
					break;
				case AsnLexer.macroScanner:
					MacroBody += text;
					break;
				case AsnLexer.asnScanner:
                    switch (m_state)
                    {
                        case PopState.None:
                            break;
                        case PopState.MultiLineComment:
							MultiLineComment += text;
                            break;
                        case PopState.SingleLineComment:
							SingleLineComment += text;
                            break;
                        case PopState.MultiLineString:
							MultiLineString += text;
							m_scanner.text = MultiLineString;
                            break;
                        case PopState.MacroBody:
							MacroBody += text;
                            break;
                    }
					m_state = PopState.None;
                    break;
            }
        }

        private int CstringRegex__end_of_string__Event (CstringRegex regex, LexerBase scanner)
        {
            scanner.popScanner ("");
            if (scanner.regexIndex != AsnLexer.asnScanner)
                return 0;
            return AsnDeclarations.tokens.cstring;
        }

        private int MacroRegex__type_reference__Event (MacroRegex regex, LexerBase scanner)
        {
            if (AsnKeywordDB.FindKeyword (regex.text) != AsnDeclarations.tokens.END)
                return 0;
            scanner.popScanner ("");
            return AsnDeclarations.tokens.END;
        }

        private int AsnRegex__type_reference__Event (AsnRegex regex, LexerBase scanner)
        {
            int t;
            if ((t = AsnKeywordDB.FindKeyword (regex.text)) < 0)
                return AsnDeclarations.tokens.typereference;
            return t;
        }

        private int AsnRegex__identifier__Event (AsnRegex regex, LexerBase scanner)
        {
            int t;
            if ((t = AsnKeywordDB.FindKeyword (regex.text)) < 0)
                return AsnDeclarations.tokens.identifier;
            return t;
        }

        public static bool Debug { get; private set; } = false;
		private int m_macroIndication = -1;
		private int [] m_startToken = null;
		private uint m_startTokenIndex = 0;
		private AsnLexer m_scanner = null;
		public string sourceFileName { get; private set; } = default;

		public string MultiLineComment { get; private set; } = default;
		public string SingleLineComment { get; private set; } = default;
		public string MultiLineString { get; private set; } = default;
		public string MacroBody { get; private set; } = default;

		private PopState m_state = PopState.None;
    }
}
