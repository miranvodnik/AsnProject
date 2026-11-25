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
	// class associated with syntax rule OT-DefValPart
	//

	[DataContract]
	public class	OT_DefValPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OT-DefValPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OT-DefValPart
		{
			g_OT_DefValPart_1 = 1,	// DEFVAL "{" OT-Defvalue "}"

			g_OT_DefValPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule OT-DefValPart

		// markers associated with production: OT-DefValPart -> DEFVAL "{" OT-Defvalue "}"

		public enum production_marker_1 : ushort
		{
			m_OT_Defvalue,
			final
		};

		// markers associated with production: OT-DefValPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OT-DefValPart

		// Constructor declaration(s) associated with production(s) of syntax rule OT-DefValPart

		//
		// Constructor associated with the following production(s)
		// OT-DefValPart -> DEFVAL "{" OT-Defvalue "}"

		//

		public OT_DefValPart (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, OT_Defvalue p_OT_Defvalue, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._OT_DefValPart_ID, (uint) production_kind.g_OT_DefValPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_DEFVAL = p_token;
			children[1] = m_left_curly_bracket = p_token_1;
			children[2] = m_OT_Defvalue = p_OT_Defvalue;
			children[3] = m_right_curly_bracket = p_token_2;
		}

		//
		// Constructor associated with the following production(s)
		// OT-DefValPart -> %empty

		//

		public OT_DefValPart () : base ((uint) ProductionID._OT_DefValPart_ID, (uint) production_kind.g_OT_DefValPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public OT_DefValPart (OT_DefValPart p_OT_DefValPart) : base (p_OT_DefValPart.id, p_OT_DefValPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OT_DefValPart.appInfo;
			switch ((production_kind) p_OT_DefValPart.kind)
			{
				case production_kind.g_OT_DefValPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_DEFVAL = (p_OT_DefValPart.m_DEFVAL != null) ? new SyntaxTreeToken (p_OT_DefValPart.m_DEFVAL) : null) != null) m_DEFVAL.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_OT_DefValPart.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_OT_DefValPart.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_OT_Defvalue = (p_OT_DefValPart.m_OT_Defvalue != null) ? new OT_Defvalue (p_OT_DefValPart.m_OT_Defvalue) : null) != null) m_OT_Defvalue.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_OT_DefValPart.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_OT_DefValPart.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				case production_kind.g_OT_DefValPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "OT_DefValPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OT_DefValPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DEFVAL?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_OT_Defvalue?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OT-DefValPart

		// Content changing function(s) associated with production(s) of syntax rule OT-DefValPart

		//
		// Content changing function associated with following production(s)
		// OT-DefValPart -> DEFVAL "{" OT-Defvalue "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, OT_Defvalue p_OT_Defvalue, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_DefValPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_DEFVAL = p_token;
			children [1] = m_left_curly_bracket = p_token_1;
			children [2] = m_OT_Defvalue = p_OT_Defvalue;
			children [3] = m_right_curly_bracket = p_token_2;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// OT-DefValPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_DefValPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OT-DefValPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DEFVAL != null) && m_DEFVAL.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_OT_Defvalue != null) && m_OT_Defvalue.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OT-DefValPart

		//
		// emit production tree node associated with any production of syntax rule OT-DefValPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_OT_DefValPart_1:
					// emit syntax tree node associated with production
					// OT-DefValPart: DEFVAL "{" OT-Defvalue "}"

					s += m_DEFVAL.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_OT_Defvalue.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
				case production_kind.g_OT_DefValPart_2:
					// emit syntax tree node associated with production
					// OT-DefValPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OT-DefValPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "OT_DefValPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_OT_DefValPart_1:
					// emit syntax tree node associated with production
					// OT-DefValPart: DEFVAL "{" OT-Defvalue "}"

					s += "DEFVAL";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_OT_Defvalue.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
				case production_kind.g_OT_DefValPart_2:
					// emit syntax tree node associated with production
					// OT-DefValPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OT-DefValPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OT-DefValPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			OT_DefValPart.production_kind kind = (OT_DefValPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case OT_DefValPart.production_kind.g_OT_DefValPart_1:
					// traverse syntax tree node associated with production
					// OT-DefValPart: DEFVAL "{" OT-Defvalue "}"

						m_DEFVAL.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_OT_Defvalue.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
				case OT_DefValPart.production_kind.g_OT_DefValPart_2:
					// traverse syntax tree node associated with production
					// OT-DefValPart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DEFVAL?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_OT_Defvalue?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule OT-DefValPart
		//

		public void _init ()
		{
			m_DEFVAL = null;
			m_left_curly_bracket = null;
			m_OT_Defvalue = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OT-DefValPart

		// counter of all nodes associated with syntax rule OT-DefValPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OT-DefValPart
		[DataMember (Name = "m_DEFVAL")] public SyntaxTreeToken m_DEFVAL { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_OT_Defvalue")] public OT_Defvalue m_OT_Defvalue { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OT-DefValPart

		// delegate function (callback) prototype associated with syntax rule OT-DefValPart
		public delegate bool OT_DefValPart_Callback (SyntaxTreeCallbackReason reason, OT_DefValPart.production_kind kind, OT_DefValPart p_OT_DefValPart);

		// event associated with syntax rule OT-DefValPart
		public event OT_DefValPart_Callback OT_DefValPart_Event;

		// event trigger associated with syntax rule OT-DefValPart
		public bool Raise_OT_DefValPart_Event (SyntaxTreeCallbackReason reason, OT_DefValPart.production_kind kind, OT_DefValPart p_OT_DefValPart)
		{
			bool? status = OT_DefValPart_Event?.Invoke (reason, kind, p_OT_DefValPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OT-DefValPart
		//
		// traverse syntax tree node associated with any production of syntax rule OT-DefValPart
		//

		public void Traverse (OT_DefValPart p_OT_DefValPart)
		{
			if (p_OT_DefValPart.isLocked())
				return;
			p_OT_DefValPart.dolock();
			OT_DefValPart.production_kind kind = (OT_DefValPart.production_kind) p_OT_DefValPart.kind;
			p_OT_DefValPart.turn_reset ();
			if (Raise_OT_DefValPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_OT_DefValPart))
			switch (kind)
			{
				case OT_DefValPart.production_kind.g_OT_DefValPart_1:
					// traverse syntax tree node associated with production
					// OT-DefValPart: DEFVAL "{" OT-Defvalue "}"

					if (Raise_OT_DefValPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_DefValPart))
						Traverse (p_OT_DefValPart.m_OT_Defvalue);
					p_OT_DefValPart.turn_inc ();
					Raise_OT_DefValPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_DefValPart);
				break;
				case OT_DefValPart.production_kind.g_OT_DefValPart_2:
					// traverse syntax tree node associated with production
					// OT-DefValPart: %empty

				break;
			}
			Raise_OT_DefValPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_OT_DefValPart);
			p_OT_DefValPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OT-DefValPart
		//

		public void TraverseCommon (OT_DefValPart p_OT_DefValPart)
		{
			OT_DefValPart.production_kind kind = (OT_DefValPart.production_kind) p_OT_DefValPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_OT_DefValPart))
			switch (kind)
			{
				case OT_DefValPart.production_kind.g_OT_DefValPart_1:
					// traverse syntax tree node associated with production
					// OT-DefValPart: DEFVAL "{" OT-Defvalue "}"

						TraverseCommon (p_OT_DefValPart.m_DEFVAL);
						TraverseCommon (p_OT_DefValPart.m_left_curly_bracket);
						TraverseCommon (p_OT_DefValPart.m_OT_Defvalue);
						TraverseCommon (p_OT_DefValPart.m_right_curly_bracket);
				break;
				case OT_DefValPart.production_kind.g_OT_DefValPart_2:
					// traverse syntax tree node associated with production
					// OT-DefValPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_OT_DefValPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OT-DefValPart

		//
		// create syntax tree node associated with production
		// OT-DefValPart: DEFVAL "{" OT-Defvalue "}"

		//

		public OT_DefValPart OT_DefValPart_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, OT_Defvalue p_OT_Defvalue, SyntaxTreeToken p_token_2)
		{
			OT_DefValPart p_OT_DefValPart_ref = new OT_DefValPart(p_token, p_token_1, p_OT_Defvalue, p_token_2);
			p_token.parent = p_OT_DefValPart_ref;
			p_token_1.parent = p_OT_DefValPart_ref;
			p_OT_Defvalue.parent = p_OT_DefValPart_ref;
			p_token_2.parent = p_OT_DefValPart_ref;
			Raise_OT_DefValPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_DefValPart.production_kind.g_OT_DefValPart_1, p_OT_DefValPart_ref);
			return p_OT_DefValPart_ref;
		}

		//
		// create syntax tree node associated with production
		// OT-DefValPart: %empty

		//

		public OT_DefValPart OT_DefValPart_2 ()
		{
			OT_DefValPart p_OT_DefValPart_ref = new OT_DefValPart();
			Raise_OT_DefValPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_DefValPart.production_kind.g_OT_DefValPart_2, p_OT_DefValPart_ref);
			return p_OT_DefValPart_ref;
		}
		#endregion
	};
}
