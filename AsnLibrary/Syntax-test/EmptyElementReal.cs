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
	// class associated with syntax rule EmptyElementReal
	//

	[DataContract]
	public class	EmptyElementReal : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule EmptyElementReal
		public enum production_kind : ushort	// enumerated production(s) of syntax rule EmptyElementReal
		{
			g_EmptyElementReal_1 = 1,	// "<" PLUS-INFINITY "/>"

			g_EmptyElementReal_2 = 2,	// "<" MINUS-INFINITY "/>"

			g_EmptyElementReal_3 = 3,	// "<" NOT-A-NUMBER "/>"

		};
		#endregion
		#region production markers associated with the syntax rule EmptyElementReal

		// markers associated with production: EmptyElementReal -> "<" PLUS-INFINITY "/>"

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: EmptyElementReal -> "<" MINUS-INFINITY "/>"

		public enum production_marker_2 : ushort
		{
			final
		};

		// markers associated with production: EmptyElementReal -> "<" NOT-A-NUMBER "/>"

		public enum production_marker_3 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule EmptyElementReal

		// Constructor declaration(s) associated with production(s) of syntax rule EmptyElementReal

		//
		// Constructor associated with the following production(s)
		// EmptyElementReal -> "<" PLUS-INFINITY "/>"

		// EmptyElementReal -> "<" MINUS-INFINITY "/>"

		// EmptyElementReal -> "<" NOT-A-NUMBER "/>"

		//

		public EmptyElementReal (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, int kind) : base ((uint) ProductionID._EmptyElementReal_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_EmptyElementReal_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
				children[0] = m_less_sign = p_token;
				children[1] = m_PLUS_INFINITY = p_token_1;
				children[2] = m_xml_single_tag_end_item = p_token_2;
				break;
			case production_kind.g_EmptyElementReal_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
				children[0] = m_less_sign = p_token;
				children[1] = m_MINUS_INFINITY = p_token_1;
				children[2] = m_xml_single_tag_end_item = p_token_2;
				break;
			case production_kind.g_EmptyElementReal_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
				children[0] = m_less_sign = p_token;
				children[1] = m_NOT_A_NUMBER = p_token_1;
				children[2] = m_xml_single_tag_end_item = p_token_2;
				break;
			default:
				{
					string[] args = new string[] { "EmptyElementReal" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		public EmptyElementReal () { }

		// Copy constructor

		public EmptyElementReal (EmptyElementReal p_EmptyElementReal) : base (p_EmptyElementReal.id, p_EmptyElementReal.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_EmptyElementReal.appInfo;
			switch ((production_kind) p_EmptyElementReal.kind)
			{
				case production_kind.g_EmptyElementReal_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_less_sign = (p_EmptyElementReal.m_less_sign != null) ? new SyntaxTreeToken (p_EmptyElementReal.m_less_sign) : null) != null) m_less_sign.parent = this;
					if ((children [1] = m_PLUS_INFINITY = (p_EmptyElementReal.m_PLUS_INFINITY != null) ? new SyntaxTreeToken (p_EmptyElementReal.m_PLUS_INFINITY) : null) != null) m_PLUS_INFINITY.parent = this;
					if ((children [2] = m_xml_single_tag_end_item = (p_EmptyElementReal.m_xml_single_tag_end_item != null) ? new SyntaxTreeToken (p_EmptyElementReal.m_xml_single_tag_end_item) : null) != null) m_xml_single_tag_end_item.parent = this;
					break;
				case production_kind.g_EmptyElementReal_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_less_sign = (p_EmptyElementReal.m_less_sign != null) ? new SyntaxTreeToken (p_EmptyElementReal.m_less_sign) : null) != null) m_less_sign.parent = this;
					if ((children [1] = m_MINUS_INFINITY = (p_EmptyElementReal.m_MINUS_INFINITY != null) ? new SyntaxTreeToken (p_EmptyElementReal.m_MINUS_INFINITY) : null) != null) m_MINUS_INFINITY.parent = this;
					if ((children [2] = m_xml_single_tag_end_item = (p_EmptyElementReal.m_xml_single_tag_end_item != null) ? new SyntaxTreeToken (p_EmptyElementReal.m_xml_single_tag_end_item) : null) != null) m_xml_single_tag_end_item.parent = this;
					break;
				case production_kind.g_EmptyElementReal_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_less_sign = (p_EmptyElementReal.m_less_sign != null) ? new SyntaxTreeToken (p_EmptyElementReal.m_less_sign) : null) != null) m_less_sign.parent = this;
					if ((children [1] = m_NOT_A_NUMBER = (p_EmptyElementReal.m_NOT_A_NUMBER != null) ? new SyntaxTreeToken (p_EmptyElementReal.m_NOT_A_NUMBER) : null) != null) m_NOT_A_NUMBER.parent = this;
					if ((children [2] = m_xml_single_tag_end_item = (p_EmptyElementReal.m_xml_single_tag_end_item != null) ? new SyntaxTreeToken (p_EmptyElementReal.m_xml_single_tag_end_item) : null) != null) m_xml_single_tag_end_item.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "EmptyElementReal" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new EmptyElementReal (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_less_sign?.Dispose ();
			m_PLUS_INFINITY?.Dispose ();
			m_xml_single_tag_end_item?.Dispose ();
			m_MINUS_INFINITY?.Dispose ();
			m_NOT_A_NUMBER?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule EmptyElementReal

		// Content changing function(s) associated with production(s) of syntax rule EmptyElementReal

		//
		// Content changing function associated with following production(s)
		// EmptyElementReal -> "<" PLUS-INFINITY "/>"

		// EmptyElementReal -> "<" MINUS-INFINITY "/>"

		// EmptyElementReal -> "<" NOT-A-NUMBER "/>"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_EmptyElementReal_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
				children [0] = m_less_sign = p_token;
				children [1] = m_PLUS_INFINITY = p_token_1;
				children [2] = m_xml_single_tag_end_item = p_token_2;
				break;
			case production_kind.g_EmptyElementReal_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
				children [0] = m_less_sign = p_token;
				children [1] = m_MINUS_INFINITY = p_token_1;
				children [2] = m_xml_single_tag_end_item = p_token_2;
				break;
			case production_kind.g_EmptyElementReal_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
				children [0] = m_less_sign = p_token;
				children [1] = m_NOT_A_NUMBER = p_token_1;
				children [2] = m_xml_single_tag_end_item = p_token_2;
				break;
			default:
				{
					string[] args = new string[] { "EmptyElementReal" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule EmptyElementReal
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_less_sign != null) && m_less_sign.checkInclusion (element) ||
				(m_PLUS_INFINITY != null) && m_PLUS_INFINITY.checkInclusion (element) ||
				(m_xml_single_tag_end_item != null) && m_xml_single_tag_end_item.checkInclusion (element) ||
				(m_MINUS_INFINITY != null) && m_MINUS_INFINITY.checkInclusion (element) ||
				(m_NOT_A_NUMBER != null) && m_NOT_A_NUMBER.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule EmptyElementReal

		//
		// emit production tree node associated with any production of syntax rule EmptyElementReal
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_EmptyElementReal_1:
					// emit syntax tree node associated with production
					// EmptyElementReal: "<" PLUS-INFINITY "/>"

					s += m_less_sign.Emit (depth - 1);
					s += " ";
					s += m_PLUS_INFINITY.Emit (depth - 1);
					s += " ";
					s += m_xml_single_tag_end_item.Emit (depth - 1);
				break;
				case production_kind.g_EmptyElementReal_2:
					// emit syntax tree node associated with production
					// EmptyElementReal: "<" MINUS-INFINITY "/>"

					s += m_less_sign.Emit (depth - 1);
					s += " ";
					s += m_MINUS_INFINITY.Emit (depth - 1);
					s += " ";
					s += m_xml_single_tag_end_item.Emit (depth - 1);
				break;
				case production_kind.g_EmptyElementReal_3:
					// emit syntax tree node associated with production
					// EmptyElementReal: "<" NOT-A-NUMBER "/>"

					s += m_less_sign.Emit (depth - 1);
					s += " ";
					s += m_NOT_A_NUMBER.Emit (depth - 1);
					s += " ";
					s += m_xml_single_tag_end_item.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule EmptyElementReal
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "EmptyElementReal (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_EmptyElementReal_1:
					// emit syntax tree node associated with production
					// EmptyElementReal: "<" PLUS-INFINITY "/>"

					s += "less_sign";
					s += ' ';
					s += "PLUS_INFINITY";
					s += ' ';
					s += "xml_single_tag_end_item";
				break;
				case production_kind.g_EmptyElementReal_2:
					// emit syntax tree node associated with production
					// EmptyElementReal: "<" MINUS-INFINITY "/>"

					s += "less_sign";
					s += ' ';
					s += "MINUS_INFINITY";
					s += ' ';
					s += "xml_single_tag_end_item";
				break;
				case production_kind.g_EmptyElementReal_3:
					// emit syntax tree node associated with production
					// EmptyElementReal: "<" NOT-A-NUMBER "/>"

					s += "less_sign";
					s += ' ';
					s += "NOT_A_NUMBER";
					s += ' ';
					s += "xml_single_tag_end_item";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule EmptyElementReal

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule EmptyElementReal with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			EmptyElementReal.production_kind kind = (EmptyElementReal.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case EmptyElementReal.production_kind.g_EmptyElementReal_1:
					// traverse syntax tree node associated with production
					// EmptyElementReal: "<" PLUS-INFINITY "/>"

						m_less_sign.Visit (visitor, appData);
						m_PLUS_INFINITY.Visit (visitor, appData);
						m_xml_single_tag_end_item.Visit (visitor, appData);
				break;
				case EmptyElementReal.production_kind.g_EmptyElementReal_2:
					// traverse syntax tree node associated with production
					// EmptyElementReal: "<" MINUS-INFINITY "/>"

						m_less_sign.Visit (visitor, appData);
						m_MINUS_INFINITY.Visit (visitor, appData);
						m_xml_single_tag_end_item.Visit (visitor, appData);
				break;
				case EmptyElementReal.production_kind.g_EmptyElementReal_3:
					// traverse syntax tree node associated with production
					// EmptyElementReal: "<" NOT-A-NUMBER "/>"

						m_less_sign.Visit (visitor, appData);
						m_NOT_A_NUMBER.Visit (visitor, appData);
						m_xml_single_tag_end_item.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_less_sign?.reparent (this);
			m_PLUS_INFINITY?.reparent (this);
			m_xml_single_tag_end_item?.reparent (this);
			m_MINUS_INFINITY?.reparent (this);
			m_NOT_A_NUMBER?.reparent (this);
		}

		//
		// initialize object associated with syntax rule EmptyElementReal
		//

		public void _init ()
		{
			m_less_sign = null;
			m_PLUS_INFINITY = null;
			m_xml_single_tag_end_item = null;
			m_MINUS_INFINITY = null;
			m_NOT_A_NUMBER = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule EmptyElementReal

		// counter of all nodes associated with syntax rule EmptyElementReal
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule EmptyElementReal
		[DataMember (Name = "m_less_sign")] public SyntaxTreeToken m_less_sign { get; private set; }
		[DataMember (Name = "m_PLUS_INFINITY")] public SyntaxTreeToken m_PLUS_INFINITY { get; private set; }
		[DataMember (Name = "m_xml_single_tag_end_item")] public SyntaxTreeToken m_xml_single_tag_end_item { get; private set; }
		[DataMember (Name = "m_MINUS_INFINITY")] public SyntaxTreeToken m_MINUS_INFINITY { get; private set; }
		[DataMember (Name = "m_NOT_A_NUMBER")] public SyntaxTreeToken m_NOT_A_NUMBER { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule EmptyElementReal

		// delegate function (callback) prototype associated with syntax rule EmptyElementReal
		public delegate bool EmptyElementReal_Callback (SyntaxTreeCallbackReason reason, EmptyElementReal.production_kind kind, EmptyElementReal p_EmptyElementReal);

		// event associated with syntax rule EmptyElementReal
		public event EmptyElementReal_Callback EmptyElementReal_Event;

		// event trigger associated with syntax rule EmptyElementReal
		public bool Raise_EmptyElementReal_Event (SyntaxTreeCallbackReason reason, EmptyElementReal.production_kind kind, EmptyElementReal p_EmptyElementReal)
		{
			bool? status = EmptyElementReal_Event?.Invoke (reason, kind, p_EmptyElementReal);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule EmptyElementReal
		//
		// traverse syntax tree node associated with any production of syntax rule EmptyElementReal
		//

		public void Traverse (EmptyElementReal p_EmptyElementReal)
		{
			if (p_EmptyElementReal.isLocked())
				return;
			p_EmptyElementReal.dolock();
			EmptyElementReal.production_kind kind = (EmptyElementReal.production_kind) p_EmptyElementReal.kind;
			p_EmptyElementReal.turn_reset ();
			if (Raise_EmptyElementReal_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_EmptyElementReal))
			switch (kind)
			{
				case EmptyElementReal.production_kind.g_EmptyElementReal_1:
					// traverse syntax tree node associated with production
					// EmptyElementReal: "<" PLUS-INFINITY "/>"

				break;
				case EmptyElementReal.production_kind.g_EmptyElementReal_2:
					// traverse syntax tree node associated with production
					// EmptyElementReal: "<" MINUS-INFINITY "/>"

				break;
				case EmptyElementReal.production_kind.g_EmptyElementReal_3:
					// traverse syntax tree node associated with production
					// EmptyElementReal: "<" NOT-A-NUMBER "/>"

				break;
			}
			Raise_EmptyElementReal_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_EmptyElementReal);
			p_EmptyElementReal.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule EmptyElementReal
		//

		public void TraverseCommon (EmptyElementReal p_EmptyElementReal)
		{
			EmptyElementReal.production_kind kind = (EmptyElementReal.production_kind) p_EmptyElementReal.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_EmptyElementReal))
			switch (kind)
			{
				case EmptyElementReal.production_kind.g_EmptyElementReal_1:
					// traverse syntax tree node associated with production
					// EmptyElementReal: "<" PLUS-INFINITY "/>"

						TraverseCommon (p_EmptyElementReal.m_less_sign);
						TraverseCommon (p_EmptyElementReal.m_PLUS_INFINITY);
						TraverseCommon (p_EmptyElementReal.m_xml_single_tag_end_item);
				break;
				case EmptyElementReal.production_kind.g_EmptyElementReal_2:
					// traverse syntax tree node associated with production
					// EmptyElementReal: "<" MINUS-INFINITY "/>"

						TraverseCommon (p_EmptyElementReal.m_less_sign);
						TraverseCommon (p_EmptyElementReal.m_MINUS_INFINITY);
						TraverseCommon (p_EmptyElementReal.m_xml_single_tag_end_item);
				break;
				case EmptyElementReal.production_kind.g_EmptyElementReal_3:
					// traverse syntax tree node associated with production
					// EmptyElementReal: "<" NOT-A-NUMBER "/>"

						TraverseCommon (p_EmptyElementReal.m_less_sign);
						TraverseCommon (p_EmptyElementReal.m_NOT_A_NUMBER);
						TraverseCommon (p_EmptyElementReal.m_xml_single_tag_end_item);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_EmptyElementReal);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule EmptyElementReal

		//
		// create syntax tree node associated with production
		// EmptyElementReal: "<" PLUS-INFINITY "/>"

		//

		public EmptyElementReal EmptyElementReal_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			EmptyElementReal p_EmptyElementReal_ref = new EmptyElementReal(p_token, p_token_1, p_token_2, 1);
			p_token.parent = p_EmptyElementReal_ref;
			p_token_1.parent = p_EmptyElementReal_ref;
			p_token_2.parent = p_EmptyElementReal_ref;
			Raise_EmptyElementReal_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EmptyElementReal.production_kind.g_EmptyElementReal_1, p_EmptyElementReal_ref);
			return p_EmptyElementReal_ref;
		}

		//
		// create syntax tree node associated with production
		// EmptyElementReal: "<" MINUS-INFINITY "/>"

		//

		public EmptyElementReal EmptyElementReal_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			EmptyElementReal p_EmptyElementReal_ref = new EmptyElementReal(p_token, p_token_1, p_token_2, 2);
			p_token.parent = p_EmptyElementReal_ref;
			p_token_1.parent = p_EmptyElementReal_ref;
			p_token_2.parent = p_EmptyElementReal_ref;
			Raise_EmptyElementReal_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EmptyElementReal.production_kind.g_EmptyElementReal_2, p_EmptyElementReal_ref);
			return p_EmptyElementReal_ref;
		}

		//
		// create syntax tree node associated with production
		// EmptyElementReal: "<" NOT-A-NUMBER "/>"

		//

		public EmptyElementReal EmptyElementReal_3 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			EmptyElementReal p_EmptyElementReal_ref = new EmptyElementReal(p_token, p_token_1, p_token_2, 3);
			p_token.parent = p_EmptyElementReal_ref;
			p_token_1.parent = p_EmptyElementReal_ref;
			p_token_2.parent = p_EmptyElementReal_ref;
			Raise_EmptyElementReal_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EmptyElementReal.production_kind.g_EmptyElementReal_3, p_EmptyElementReal_ref);
			return p_EmptyElementReal_ref;
		}
		#endregion
	};
}
