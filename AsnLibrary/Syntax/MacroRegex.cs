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
	public class MacroRegex : Regex, RegexInterface
	{
		public MacroRegex (LexerBase scanner) : base (@"(?<g1>\/\*)|(?<g2>\-\-)|(?<g3>[A-Z]([a-zA-Z]|[0-9])*([_-]([a-zA-Z]|[0-9])+)*)|(?<g4>[a-z]([a-zA-Z]|[0-9])*([_-]([a-zA-Z]|[0-9])+)*)|(?<g5>(([1-9][0-9]*)|0))|(?<g6>(([1-9][0-9]*)(\.(([1-9][0-9]*)(E([1-9][0-9]*))?)?)?))|(?<g7>(\'[0-1]*\'B))|(?<g8>(\'[0-9A-Fa-f]*\'H))|(?<g9>\"")|(?<g10>\:\:\=)|(?<g11>\!)|(?<g12>\&)|(?<g13>\')|(?<g14>\()|(?<g15>\))|(?<g16>\*)|(?<g17>\,)|(?<g18>\-)|(?<g19>\.)|(?<g20>\/)|(?<g21>\:)|(?<g22>\;)|(?<g23>\<)|(?<g24>\=)|(?<g25>\>)|(?<g26>\@)|(?<g27>\[)|(?<g28>\])|(?<g29>\^)|(?<g30>\{)|(?<g31>\})|(?<g32>\|)|(?<g33>[ \t]+)|(?<g34>\n|\r)|(?<g35>.)", RegexOptions.ExplicitCapture)
		{
			Scanner = scanner;
		}

		public LexerBase Scanner { get; private set; }
		public static string Id { get; private set; } = "macroScanner";

		public delegate int scannerCallback (MacroRegex regex, LexerBase scanner);

			public event scannerCallback _type_reference__Event;


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
				result = 0;
				break;
			case 5:
				result = 0;
				break;
			case 6:
				result = 0;
				break;
			case 7:
				result = 0;
				break;
			case 8:
				result = 0;
				break;
			case 9:
				Scanner.pushScanner (CstringRegex.Id, text);
				result = 0;
				break;
			case 10:
				result = 0;
				break;
			case 11:
				result = 0;
				break;
			case 12:
				result = 0;
				break;
			case 13:
				result = 0;
				break;
			case 14:
				result = 0;
				break;
			case 15:
				result = 0;
				break;
			case 16:
				result = 0;
				break;
			case 17:
				result = 0;
				break;
			case 18:
				result = 0;
				break;
			case 19:
				result = 0;
				break;
			case 20:
				result = 0;
				break;
			case 21:
				result = 0;
				break;
			case 22:
				result = 0;
				break;
			case 23:
				result = 0;
				break;
			case 24:
				result = 0;
				break;
			case 25:
				result = 0;
				break;
			case 26:
				result = 0;
				break;
			case 27:
				result = 0;
				break;
			case 28:
				result = 0;
				break;
			case 29:
				result = 0;
				break;
			case 30:
				result = 0;
				break;
			case 31:
				result = 0;
				break;
			case 32:
				result = 0;
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

