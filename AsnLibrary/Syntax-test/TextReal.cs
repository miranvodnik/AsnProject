//
//	This file was generated with ANGLR compiler
//
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

using Anglr.Parser.Core;
using Anglr.Parser.SyntaxTree;
using Anglr.Parser.Walker;
namespace Asn.Parser
{
	//
	// class associated with syntax rule TextReal
	//

	[DataContract]
	public class	TextReal : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TextReal
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TextReal
		{
			g_TextReal_1 = 1,	// "INF"

			g_TextReal_2 = 2,	// "-" "INF"

			g_TextReal_3 = 3,	// "NaN"

		};
		#endregion
		#region production markers associated with the syntax rule TextReal

		// markers associated with production: TextReal -> "INF"

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: TextReal -> "-" "INF"

		public enum production_marker_2 : ushort
		{
			final
		};

		// markers associated with production: TextReal -> "NaN"

		public enum production_marker_3 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TextReal

		// Constructor declaration(s) associated with production(s) of syntax rule TextReal

		//
		// Constructor associated with the following production(s)
		// TextReal -> "INF"

		// TextReal -> "NaN"

		//

		public TextReal (SyntaxTreeToken p_token, int kind) : base ((uint) ProductionID._TextReal_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_TextReal_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_xml_real_infinity_item = p_token;
				break;
			case production_kind.g_TextReal_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_xml_real_not_a_number_item = p_token;
				break;
			default:
				{
					string[] args = new string[] { "TextReal" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		//
		// Constructor associated with the following production(s)
		// TextReal -> "-" "INF"

		//

		public TextReal (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._TextReal_ID, (uint) production_kind.g_TextReal_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_minus_sign = p_token;
			children[1] = m_xml_real_infinity_item = p_token_1;
		}

		public TextReal () { }

		// Copy constructor

		public TextReal (TextReal p_TextReal) : base (p_TextReal.id, p_TextReal.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TextReal.appInfo;
			switch ((production_kind) p_TextReal.kind)
			{
				case production_kind.g_TextReal_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_xml_real_infinity_item = (p_TextReal.m_xml_real_infinity_item != null) ? new SyntaxTreeToken (p_TextReal.m_xml_real_infinity_item) : null) != null) m_xml_real_infinity_item.parent = this;
					break;
				case production_kind.g_TextReal_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_xml_real_not_a_number_item = (p_TextReal.m_xml_real_not_a_number_item != null) ? new SyntaxTreeToken (p_TextReal.m_xml_real_not_a_number_item) : null) != null) m_xml_real_not_a_number_item.parent = this;
					break;
				case production_kind.g_TextReal_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_minus_sign = (p_TextReal.m_minus_sign != null) ? new SyntaxTreeToken (p_TextReal.m_minus_sign) : null) != null) m_minus_sign.parent = this;
					if ((children [1] = m_xml_real_infinity_item = (p_TextReal.m_xml_real_infinity_item != null) ? new SyntaxTreeToken (p_TextReal.m_xml_real_infinity_item) : null) != null) m_xml_real_infinity_item.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TextReal" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TextReal (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_xml_real_infinity_item?.Dispose ();
			m_minus_sign?.Dispose ();
			m_xml_real_not_a_number_item?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TextReal

		// Content changing function(s) associated with production(s) of syntax rule TextReal

		//
		// Content changing function associated with following production(s)
		// TextReal -> "INF"

		// TextReal -> "NaN"

		//

		public void change(SyntaxTreeToken p_token, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_TextReal_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_xml_real_infinity_item = p_token;
				break;
			case production_kind.g_TextReal_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_xml_real_not_a_number_item = p_token;
				break;
			default:
				{
					string[] args = new string[] { "TextReal" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TextReal -> "-" "INF"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_TextReal_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_minus_sign = p_token;
			children [1] = m_xml_real_infinity_item = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TextReal
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_xml_real_infinity_item != null) && m_xml_real_infinity_item.checkInclusion (element) ||
				(m_minus_sign != null) && m_minus_sign.checkInclusion (element) ||
				(m_xml_real_not_a_number_item != null) && m_xml_real_not_a_number_item.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TextReal

		//
		// emit production tree node associated with any production of syntax rule TextReal
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TextReal_1:
					// emit syntax tree node associated with production
					// TextReal: "INF"

					s += m_xml_real_infinity_item.Emit (depth - 1);
				break;
				case production_kind.g_TextReal_2:
					// emit syntax tree node associated with production
					// TextReal: "-" "INF"

					s += m_minus_sign.Emit (depth - 1);
					s += " ";
					s += m_xml_real_infinity_item.Emit (depth - 1);
				break;
				case production_kind.g_TextReal_3:
					// emit syntax tree node associated with production
					// TextReal: "NaN"

					s += m_xml_real_not_a_number_item.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TextReal
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TextReal (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TextReal_1:
					// emit syntax tree node associated with production
					// TextReal: "INF"

					s += "xml_real_infinity_item";
				break;
				case production_kind.g_TextReal_2:
					// emit syntax tree node associated with production
					// TextReal: "-" "INF"

					s += "minus_sign";
					s += ' ';
					s += "xml_real_infinity_item";
				break;
				case production_kind.g_TextReal_3:
					// emit syntax tree node associated with production
					// TextReal: "NaN"

					s += "xml_real_not_a_number_item";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TextReal

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TextReal with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TextReal.production_kind kind = (TextReal.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TextReal.production_kind.g_TextReal_1:
					// traverse syntax tree node associated with production
					// TextReal: "INF"

						m_xml_real_infinity_item.Visit (visitor, appData);
				break;
				case TextReal.production_kind.g_TextReal_2:
					// traverse syntax tree node associated with production
					// TextReal: "-" "INF"

						m_minus_sign.Visit (visitor, appData);
						m_xml_real_infinity_item.Visit (visitor, appData);
				break;
				case TextReal.production_kind.g_TextReal_3:
					// traverse syntax tree node associated with production
					// TextReal: "NaN"

						m_xml_real_not_a_number_item.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_xml_real_infinity_item?.reparent (this);
			m_minus_sign?.reparent (this);
			m_xml_real_not_a_number_item?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TextReal
		//

		public void _init ()
		{
			m_xml_real_infinity_item = null;
			m_minus_sign = null;
			m_xml_real_not_a_number_item = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TextReal

		// counter of all nodes associated with syntax rule TextReal
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TextReal
		[DataMember (Name = "m_xml_real_infinity_item")] public SyntaxTreeToken m_xml_real_infinity_item { get; private set; }
		[DataMember (Name = "m_minus_sign")] public SyntaxTreeToken m_minus_sign { get; private set; }
		[DataMember (Name = "m_xml_real_not_a_number_item")] public SyntaxTreeToken m_xml_real_not_a_number_item { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TextReal

		// delegate function (callback) prototype associated with syntax rule TextReal
		public delegate bool TextReal_Callback (SyntaxTreeCallbackReason reason, TextReal.production_kind kind, TextReal p_TextReal);

		// event associated with syntax rule TextReal
		public event TextReal_Callback TextReal_Event;

		// event trigger associated with syntax rule TextReal
		public bool Raise_TextReal_Event (SyntaxTreeCallbackReason reason, TextReal.production_kind kind, TextReal p_TextReal)
		{
			bool? status = TextReal_Event?.Invoke (reason, kind, p_TextReal);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TextReal
		//
		// traverse syntax tree node associated with any production of syntax rule TextReal
		//

		public void Traverse (TextReal p_TextReal)
		{
			if (p_TextReal.isLocked())
				return;
			p_TextReal.dolock();
			TextReal.production_kind kind = (TextReal.production_kind) p_TextReal.kind;
			p_TextReal.turn_reset ();
			if (Raise_TextReal_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TextReal))
			switch (kind)
			{
				case TextReal.production_kind.g_TextReal_1:
					// traverse syntax tree node associated with production
					// TextReal: "INF"

				break;
				case TextReal.production_kind.g_TextReal_2:
					// traverse syntax tree node associated with production
					// TextReal: "-" "INF"

				break;
				case TextReal.production_kind.g_TextReal_3:
					// traverse syntax tree node associated with production
					// TextReal: "NaN"

				break;
			}
			Raise_TextReal_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TextReal);
			p_TextReal.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TextReal
		//

		public void TraverseCommon (TextReal p_TextReal)
		{
			TextReal.production_kind kind = (TextReal.production_kind) p_TextReal.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TextReal))
			switch (kind)
			{
				case TextReal.production_kind.g_TextReal_1:
					// traverse syntax tree node associated with production
					// TextReal: "INF"

						TraverseCommon (p_TextReal.m_xml_real_infinity_item);
				break;
				case TextReal.production_kind.g_TextReal_2:
					// traverse syntax tree node associated with production
					// TextReal: "-" "INF"

						TraverseCommon (p_TextReal.m_minus_sign);
						TraverseCommon (p_TextReal.m_xml_real_infinity_item);
				break;
				case TextReal.production_kind.g_TextReal_3:
					// traverse syntax tree node associated with production
					// TextReal: "NaN"

						TraverseCommon (p_TextReal.m_xml_real_not_a_number_item);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TextReal);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TextReal

		//
		// create syntax tree node associated with production
		// TextReal: "INF"

		//

		public TextReal TextReal_1 (SyntaxTreeToken p_token)
		{
			TextReal p_TextReal_ref = new TextReal(p_token, 1);
			p_token.parent = p_TextReal_ref;
			Raise_TextReal_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TextReal.production_kind.g_TextReal_1, p_TextReal_ref);
			return p_TextReal_ref;
		}

		//
		// create syntax tree node associated with production
		// TextReal: "-" "INF"

		//

		public TextReal TextReal_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			TextReal p_TextReal_ref = new TextReal(p_token, p_token_1);
			p_token.parent = p_TextReal_ref;
			p_token_1.parent = p_TextReal_ref;
			Raise_TextReal_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TextReal.production_kind.g_TextReal_2, p_TextReal_ref);
			return p_TextReal_ref;
		}

		//
		// create syntax tree node associated with production
		// TextReal: "NaN"

		//

		public TextReal TextReal_3 (SyntaxTreeToken p_token)
		{
			TextReal p_TextReal_ref = new TextReal(p_token, 3);
			p_token.parent = p_TextReal_ref;
			Raise_TextReal_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TextReal.production_kind.g_TextReal_3, p_TextReal_ref);
			return p_TextReal_ref;
		}
		#endregion
	};
}
