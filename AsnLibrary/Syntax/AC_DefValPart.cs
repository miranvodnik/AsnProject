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
	// class associated with syntax rule AC-DefValPart
	//

	[DataContract]
	public class	AC_DefValPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-DefValPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-DefValPart
		{
			g_AC_DefValPart_1 = 1,	// DEFVAL "{" AC-Defvalue "}"

			g_AC_DefValPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule AC-DefValPart

		// markers associated with production: AC-DefValPart -> DEFVAL "{" AC-Defvalue "}"

		public enum production_marker_1 : ushort
		{
			m_AC_Defvalue,
			final
		};

		// markers associated with production: AC-DefValPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-DefValPart

		// Constructor declaration(s) associated with production(s) of syntax rule AC-DefValPart

		//
		// Constructor associated with the following production(s)
		// AC-DefValPart -> DEFVAL "{" AC-Defvalue "}"

		//

		public AC_DefValPart (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, AC_Defvalue p_AC_Defvalue, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._AC_DefValPart_ID, (uint) production_kind.g_AC_DefValPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_DEFVAL = p_token;
			children[1] = m_left_curly_bracket = p_token_1;
			children[2] = m_AC_Defvalue = p_AC_Defvalue;
			children[3] = m_right_curly_bracket = p_token_2;
		}

		//
		// Constructor associated with the following production(s)
		// AC-DefValPart -> %empty

		//

		public AC_DefValPart () : base ((uint) ProductionID._AC_DefValPart_ID, (uint) production_kind.g_AC_DefValPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public AC_DefValPart (AC_DefValPart p_AC_DefValPart) : base (p_AC_DefValPart.id, p_AC_DefValPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_DefValPart.appInfo;
			switch ((production_kind) p_AC_DefValPart.kind)
			{
				case production_kind.g_AC_DefValPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_DEFVAL = (p_AC_DefValPart.m_DEFVAL != null) ? new SyntaxTreeToken (p_AC_DefValPart.m_DEFVAL) : null) != null) m_DEFVAL.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_AC_DefValPart.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_AC_DefValPart.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_AC_Defvalue = (p_AC_DefValPart.m_AC_Defvalue != null) ? new AC_Defvalue (p_AC_DefValPart.m_AC_Defvalue) : null) != null) m_AC_Defvalue.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_AC_DefValPart.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_AC_DefValPart.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				case production_kind.g_AC_DefValPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "AC_DefValPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_DefValPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DEFVAL?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_AC_Defvalue?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-DefValPart

		// Content changing function(s) associated with production(s) of syntax rule AC-DefValPart

		//
		// Content changing function associated with following production(s)
		// AC-DefValPart -> DEFVAL "{" AC-Defvalue "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, AC_Defvalue p_AC_Defvalue, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_DefValPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_DEFVAL = p_token;
			children [1] = m_left_curly_bracket = p_token_1;
			children [2] = m_AC_Defvalue = p_AC_Defvalue;
			children [3] = m_right_curly_bracket = p_token_2;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AC-DefValPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_DefValPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-DefValPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DEFVAL != null) && m_DEFVAL.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_AC_Defvalue != null) && m_AC_Defvalue.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-DefValPart

		//
		// emit production tree node associated with any production of syntax rule AC-DefValPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_DefValPart_1:
					// emit syntax tree node associated with production
					// AC-DefValPart: DEFVAL "{" AC-Defvalue "}"

					s += m_DEFVAL.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_AC_Defvalue.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
				case production_kind.g_AC_DefValPart_2:
					// emit syntax tree node associated with production
					// AC-DefValPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-DefValPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_DefValPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_DefValPart_1:
					// emit syntax tree node associated with production
					// AC-DefValPart: DEFVAL "{" AC-Defvalue "}"

					s += "DEFVAL";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_AC_Defvalue.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
				case production_kind.g_AC_DefValPart_2:
					// emit syntax tree node associated with production
					// AC-DefValPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-DefValPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-DefValPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_DefValPart.production_kind kind = (AC_DefValPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_DefValPart.production_kind.g_AC_DefValPart_1:
					// traverse syntax tree node associated with production
					// AC-DefValPart: DEFVAL "{" AC-Defvalue "}"

						m_DEFVAL.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_AC_Defvalue.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
				case AC_DefValPart.production_kind.g_AC_DefValPart_2:
					// traverse syntax tree node associated with production
					// AC-DefValPart: %empty

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
			m_AC_Defvalue?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AC-DefValPart
		//

		public void _init ()
		{
			m_DEFVAL = null;
			m_left_curly_bracket = null;
			m_AC_Defvalue = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-DefValPart

		// counter of all nodes associated with syntax rule AC-DefValPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-DefValPart
		[DataMember (Name = "m_DEFVAL")] public SyntaxTreeToken m_DEFVAL { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_AC_Defvalue")] public AC_Defvalue m_AC_Defvalue { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-DefValPart

		// delegate function (callback) prototype associated with syntax rule AC-DefValPart
		public delegate bool AC_DefValPart_Callback (SyntaxTreeCallbackReason reason, AC_DefValPart.production_kind kind, AC_DefValPart p_AC_DefValPart);

		// event associated with syntax rule AC-DefValPart
		public event AC_DefValPart_Callback AC_DefValPart_Event;

		// event trigger associated with syntax rule AC-DefValPart
		public bool Raise_AC_DefValPart_Event (SyntaxTreeCallbackReason reason, AC_DefValPart.production_kind kind, AC_DefValPart p_AC_DefValPart)
		{
			bool? status = AC_DefValPart_Event?.Invoke (reason, kind, p_AC_DefValPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-DefValPart
		//
		// traverse syntax tree node associated with any production of syntax rule AC-DefValPart
		//

		public void Traverse (AC_DefValPart p_AC_DefValPart)
		{
			if (p_AC_DefValPart.isLocked())
				return;
			p_AC_DefValPart.dolock();
			AC_DefValPart.production_kind kind = (AC_DefValPart.production_kind) p_AC_DefValPart.kind;
			p_AC_DefValPart.turn_reset ();
			if (Raise_AC_DefValPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_DefValPart))
			switch (kind)
			{
				case AC_DefValPart.production_kind.g_AC_DefValPart_1:
					// traverse syntax tree node associated with production
					// AC-DefValPart: DEFVAL "{" AC-Defvalue "}"

					if (Raise_AC_DefValPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_DefValPart))
						Traverse (p_AC_DefValPart.m_AC_Defvalue);
					p_AC_DefValPart.turn_inc ();
					Raise_AC_DefValPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_DefValPart);
				break;
				case AC_DefValPart.production_kind.g_AC_DefValPart_2:
					// traverse syntax tree node associated with production
					// AC-DefValPart: %empty

				break;
			}
			Raise_AC_DefValPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_DefValPart);
			p_AC_DefValPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-DefValPart
		//

		public void TraverseCommon (AC_DefValPart p_AC_DefValPart)
		{
			AC_DefValPart.production_kind kind = (AC_DefValPart.production_kind) p_AC_DefValPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_DefValPart))
			switch (kind)
			{
				case AC_DefValPart.production_kind.g_AC_DefValPart_1:
					// traverse syntax tree node associated with production
					// AC-DefValPart: DEFVAL "{" AC-Defvalue "}"

						TraverseCommon (p_AC_DefValPart.m_DEFVAL);
						TraverseCommon (p_AC_DefValPart.m_left_curly_bracket);
						TraverseCommon (p_AC_DefValPart.m_AC_Defvalue);
						TraverseCommon (p_AC_DefValPart.m_right_curly_bracket);
				break;
				case AC_DefValPart.production_kind.g_AC_DefValPart_2:
					// traverse syntax tree node associated with production
					// AC-DefValPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_DefValPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-DefValPart

		//
		// create syntax tree node associated with production
		// AC-DefValPart: DEFVAL "{" AC-Defvalue "}"

		//

		public AC_DefValPart AC_DefValPart_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, AC_Defvalue p_AC_Defvalue, SyntaxTreeToken p_token_2)
		{
			AC_DefValPart p_AC_DefValPart_ref = new AC_DefValPart(p_token, p_token_1, p_AC_Defvalue, p_token_2);
			p_token.parent = p_AC_DefValPart_ref;
			p_token_1.parent = p_AC_DefValPart_ref;
			p_AC_Defvalue.parent = p_AC_DefValPart_ref;
			p_token_2.parent = p_AC_DefValPart_ref;
			Raise_AC_DefValPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_DefValPart.production_kind.g_AC_DefValPart_1, p_AC_DefValPart_ref);
			return p_AC_DefValPart_ref;
		}

		//
		// create syntax tree node associated with production
		// AC-DefValPart: %empty

		//

		public AC_DefValPart AC_DefValPart_2 ()
		{
			AC_DefValPart p_AC_DefValPart_ref = new AC_DefValPart();
			Raise_AC_DefValPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_DefValPart.production_kind.g_AC_DefValPart_2, p_AC_DefValPart_ref);
			return p_AC_DefValPart_ref;
		}
		#endregion
	};
}
