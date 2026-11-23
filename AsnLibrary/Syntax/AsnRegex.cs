//
//	This file was generated with ANGLR compiler
//
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

﻿using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Anglr.Lexer.Core;
using Asn.Declarations;

namespace Asn.RegexLib
{
	public class AsnRegex : Regex, RegexInterface
	{
		public AsnRegex (LexerBase scanner) : base (@"(?<g1>\/\*)|(?<g2>\-\-)|(?<g3>[A-Z]([a-zA-Z]|[0-9])*([_-]([a-zA-Z]|[0-9])+)*)|(?<g4>[a-z]([a-zA-Z]|[0-9])*([_-]([a-zA-Z]|[0-9])+)*)|(?<g5>(([1-9][0-9]*)|0))|(?<g6>(([1-9][0-9]*)(\.(([1-9][0-9]*)(E([1-9][0-9]*))?)?)?))|(?<g7>(\'[0-1]*\'B))|(?<g8>(\'[0-9A-Fa-f]*\'H))|(?<g9>\"")|(?<g10>\:\:\=)|(?<g11>\!)|(?<g12>\&)|(?<g13>\')|(?<g14>\()|(?<g15>\))|(?<g16>\*)|(?<g17>\,)|(?<g18>\-)|(?<g19>\.)|(?<g20>\/)|(?<g21>\:)|(?<g22>\;)|(?<g23>\<)|(?<g24>\=)|(?<g25>\>)|(?<g26>\@)|(?<g27>\[)|(?<g28>\])|(?<g29>\^)|(?<g30>\{)|(?<g31>\})|(?<g32>\|)|(?<g33>[ \t]+)|(?<g34>\n|\r)|(?<g35>.)", RegexOptions.ExplicitCapture)
		{
			Scanner = scanner;
		}

		public LexerBase Scanner { get; private set; }
		public static string Id { get; private set; } = "asnScanner";

		public delegate int scannerCallback (AsnRegex regex, LexerBase scanner);

			public event scannerCallback _type_reference__Event;
			public event scannerCallback _identifier__Event;


		public string text { get; private set; }

		public (int, int) match (string currentLine, int currentPosition)
		{
			int matchIndex = 0;
			int matchLength = 0;
			try
			{
				text = "";
				Match match = Match (currentLine, currentPosition);
				if (!match.Success)
					return (-1, 0);
					int index = 0;
				foreach (Group group in match.Groups)
				{
					if (index++ == 0)
						continue;
					if (!group.Success)
						continue;
					try
					{
						matchLength = match.Value.Length;
						matchIndex = index - 1;
						text = currentLine.Substring (currentPosition, matchLength);
					}
					catch (Exception)
					{
						continue;
					}
					break;
				}
			}
			catch (Exception e)
			{
				return (-2, 0);
			}

			int? result = null;

			switch (matchIndex)
			{
						case 1:
				Scanner.pushScanner (CommentRegex.Id, text);
				result = 0;
				break;
			case 2:
				Scanner.pushScanner (LineCommentRegex.Id, text);
				result = 0;
				break;
			case 3:
				result = _type_reference__Event?.Invoke (this, Scanner);
				break;
			case 4:
				result = _identifier__Event?.Invoke (this, Scanner);
				break;
			case 5:
				result = AsnDeclarations.tokens.number;
				break;
			case 6:
				result = AsnDeclarations.tokens.realnumber;
				break;
			case 7:
				result = AsnDeclarations.tokens.bstring;
				break;
			case 8:
				result = AsnDeclarations.tokens.hstring;
				break;
			case 9:
				Scanner.pushScanner (CstringRegex.Id, text);
				result = 0;
				break;
			case 10:
				result = AsnDeclarations.tokens.assignment_sign;
				break;
			case 11:
				result = AsnDeclarations.tokens.exclamation_mark;
				break;
			case 12:
				result = AsnDeclarations.tokens.ampersand;
				break;
			case 13:
				result = AsnDeclarations.tokens.single_quotes;
				break;
			case 14:
				result = AsnDeclarations.tokens.left_round_bracket;
				break;
			case 15:
				result = AsnDeclarations.tokens.right_round_bracket;
				break;
			case 16:
				result = AsnDeclarations.tokens.asterisk;
				break;
			case 17:
				result = AsnDeclarations.tokens.comma;
				break;
			case 18:
				result = AsnDeclarations.tokens.minus_sign;
				break;
			case 19:
				result = AsnDeclarations.tokens.dot;
				break;
			case 20:
				result = AsnDeclarations.tokens.forward_slash;
				break;
			case 21:
				result = AsnDeclarations.tokens.colon;
				break;
			case 22:
				result = AsnDeclarations.tokens.semicolon;
				break;
			case 23:
				result = AsnDeclarations.tokens.less_sign;
				break;
			case 24:
				result = AsnDeclarations.tokens.equals_sign;
				break;
			case 25:
				result = AsnDeclarations.tokens.greater_sign;
				break;
			case 26:
				result = AsnDeclarations.tokens.at_sign;
				break;
			case 27:
				result = AsnDeclarations.tokens.left_square_bracket;
				break;
			case 28:
				result = AsnDeclarations.tokens.right_square_bracket;
				break;
			case 29:
				result = AsnDeclarations.tokens.accent_sign;
				break;
			case 30:
				result = AsnDeclarations.tokens.left_curly_bracket;
				break;
			case 31:
				result = AsnDeclarations.tokens.right_curly_bracket;
				break;
			case 32:
				result = AsnDeclarations.tokens.vertical_bar;
				break;
			case 33:
				result = 0;
				break;
			case 34:
				result = 0;
				break;
			case 35:
				result = 0;
				break;

			}
			return (result != null) ? (result.Value, matchLength) : (0, matchLength);
		}
	}
}

