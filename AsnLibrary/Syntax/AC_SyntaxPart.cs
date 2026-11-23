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
	// class associated with syntax rule AC-SyntaxPart
	//

	[DataContract]
	public class	AC_SyntaxPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-SyntaxPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-SyntaxPart
		{
			g_AC_SyntaxPart_1 = 1,	// SYNTAX AC-Syntax

			g_AC_SyntaxPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule AC-SyntaxPart

		// markers associated with production: AC-SyntaxPart -> SYNTAX AC-Syntax

		public enum production_marker_1 : ushort
		{
			m_AC_Syntax,
			final
		};

		// markers associated with production: AC-SyntaxPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-SyntaxPart

		// Constructor declaration(s) associated with production(s) of syntax rule AC-SyntaxPart

		//
		// Constructor associated with the following production(s)
		// AC-SyntaxPart -> SYNTAX AC-Syntax

		//

		public AC_SyntaxPart (SyntaxTreeToken p_token, AC_Syntax p_AC_Syntax) : base ((uint) ProductionID._AC_SyntaxPart_ID, (uint) production_kind.g_AC_SyntaxPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_SYNTAX = p_token;
			children[1] = m_AC_Syntax = p_AC_Syntax;
		}

		//
		// Constructor associated with the following production(s)
		// AC-SyntaxPart -> %empty

		//

		public AC_SyntaxPart () : base ((uint) ProductionID._AC_SyntaxPart_ID, (uint) production_kind.g_AC_SyntaxPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public AC_SyntaxPart (AC_SyntaxPart p_AC_SyntaxPart) : base (p_AC_SyntaxPart.id, p_AC_SyntaxPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_SyntaxPart.appInfo;
			switch ((production_kind) p_AC_SyntaxPart.kind)
			{
				case production_kind.g_AC_SyntaxPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_SYNTAX = (p_AC_SyntaxPart.m_SYNTAX != null) ? new SyntaxTreeToken (p_AC_SyntaxPart.m_SYNTAX) : null) != null) m_SYNTAX.parent = this;
					if ((children [1] = m_AC_Syntax = (p_AC_SyntaxPart.m_AC_Syntax != null) ? new AC_Syntax (p_AC_SyntaxPart.m_AC_Syntax) : null) != null) m_AC_Syntax.parent = this;
					break;
				case production_kind.g_AC_SyntaxPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "AC_SyntaxPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_SyntaxPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SYNTAX?.Dispose ();
			m_AC_Syntax?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-SyntaxPart

		// Content changing function(s) associated with production(s) of syntax rule AC-SyntaxPart

		//
		// Content changing function associated with following production(s)
		// AC-SyntaxPart -> SYNTAX AC-Syntax

		//

		public void change(SyntaxTreeToken p_token, AC_Syntax p_AC_Syntax)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_SyntaxPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_SYNTAX = p_token;
			children [1] = m_AC_Syntax = p_AC_Syntax;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AC-SyntaxPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_SyntaxPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-SyntaxPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SYNTAX != null) && m_SYNTAX.checkInclusion (element) ||
				(m_AC_Syntax != null) && m_AC_Syntax.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-SyntaxPart

		//
		// emit production tree node associated with any production of syntax rule AC-SyntaxPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_SyntaxPart_1:
					// emit syntax tree node associated with production
					// AC-SyntaxPart: SYNTAX AC-Syntax

					s += m_SYNTAX.Emit (depth - 1);
					s += " ";
					s += m_AC_Syntax.Emit (depth - 1);
				break;
				case production_kind.g_AC_SyntaxPart_2:
					// emit syntax tree node associated with production
					// AC-SyntaxPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-SyntaxPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_SyntaxPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_SyntaxPart_1:
					// emit syntax tree node associated with production
					// AC-SyntaxPart: SYNTAX AC-Syntax

					s += "SYNTAX";
					s += ' ';
					s += m_AC_Syntax.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_AC_SyntaxPart_2:
					// emit syntax tree node associated with production
					// AC-SyntaxPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-SyntaxPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-SyntaxPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_SyntaxPart.production_kind kind = (AC_SyntaxPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_SyntaxPart.production_kind.g_AC_SyntaxPart_1:
					// traverse syntax tree node associated with production
					// AC-SyntaxPart: SYNTAX AC-Syntax

						m_SYNTAX.Visit (visitor, appData);
						m_AC_Syntax.Visit (visitor, appData);
				break;
				case AC_SyntaxPart.production_kind.g_AC_SyntaxPart_2:
					// traverse syntax tree node associated with production
					// AC-SyntaxPart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SYNTAX?.reparent (this);
			m_AC_Syntax?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AC-SyntaxPart
		//

		public void _init ()
		{
			m_SYNTAX = null;
			m_AC_Syntax = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-SyntaxPart

		// counter of all nodes associated with syntax rule AC-SyntaxPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-SyntaxPart
		[DataMember (Name = "m_SYNTAX")] public SyntaxTreeToken m_SYNTAX { get; private set; }
		[DataMember (Name = "m_AC_Syntax")] public AC_Syntax m_AC_Syntax { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-SyntaxPart

		// delegate function (callback) prototype associated with syntax rule AC-SyntaxPart
		public delegate bool AC_SyntaxPart_Callback (SyntaxTreeCallbackReason reason, AC_SyntaxPart.production_kind kind, AC_SyntaxPart p_AC_SyntaxPart);

		// event associated with syntax rule AC-SyntaxPart
		public event AC_SyntaxPart_Callback AC_SyntaxPart_Event;

		// event trigger associated with syntax rule AC-SyntaxPart
		public bool Raise_AC_SyntaxPart_Event (SyntaxTreeCallbackReason reason, AC_SyntaxPart.production_kind kind, AC_SyntaxPart p_AC_SyntaxPart)
		{
			bool? status = AC_SyntaxPart_Event?.Invoke (reason, kind, p_AC_SyntaxPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-SyntaxPart
		//
		// traverse syntax tree node associated with any production of syntax rule AC-SyntaxPart
		//

		public void Traverse (AC_SyntaxPart p_AC_SyntaxPart)
		{
			if (p_AC_SyntaxPart.isLocked())
				return;
			p_AC_SyntaxPart.dolock();
			AC_SyntaxPart.production_kind kind = (AC_SyntaxPart.production_kind) p_AC_SyntaxPart.kind;
			p_AC_SyntaxPart.turn_reset ();
			if (Raise_AC_SyntaxPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_SyntaxPart))
			switch (kind)
			{
				case AC_SyntaxPart.production_kind.g_AC_SyntaxPart_1:
					// traverse syntax tree node associated with production
					// AC-SyntaxPart: SYNTAX AC-Syntax

					if (Raise_AC_SyntaxPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_SyntaxPart))
						Traverse (p_AC_SyntaxPart.m_AC_Syntax);
					p_AC_SyntaxPart.turn_inc ();
					Raise_AC_SyntaxPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_SyntaxPart);
				break;
				case AC_SyntaxPart.production_kind.g_AC_SyntaxPart_2:
					// traverse syntax tree node associated with production
					// AC-SyntaxPart: %empty

				break;
			}
			Raise_AC_SyntaxPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_SyntaxPart);
			p_AC_SyntaxPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-SyntaxPart
		//

		public void TraverseCommon (AC_SyntaxPart p_AC_SyntaxPart)
		{
			AC_SyntaxPart.production_kind kind = (AC_SyntaxPart.production_kind) p_AC_SyntaxPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_SyntaxPart))
			switch (kind)
			{
				case AC_SyntaxPart.production_kind.g_AC_SyntaxPart_1:
					// traverse syntax tree node associated with production
					// AC-SyntaxPart: SYNTAX AC-Syntax

						TraverseCommon (p_AC_SyntaxPart.m_SYNTAX);
						TraverseCommon (p_AC_SyntaxPart.m_AC_Syntax);
				break;
				case AC_SyntaxPart.production_kind.g_AC_SyntaxPart_2:
					// traverse syntax tree node associated with production
					// AC-SyntaxPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_SyntaxPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-SyntaxPart

		//
		// create syntax tree node associated with production
		// AC-SyntaxPart: SYNTAX AC-Syntax

		//

		public AC_SyntaxPart AC_SyntaxPart_1 (SyntaxTreeToken p_token, AC_Syntax p_AC_Syntax)
		{
			AC_SyntaxPart p_AC_SyntaxPart_ref = new AC_SyntaxPart(p_token, p_AC_Syntax);
			p_token.parent = p_AC_SyntaxPart_ref;
			p_AC_Syntax.parent = p_AC_SyntaxPart_ref;
			Raise_AC_SyntaxPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_SyntaxPart.production_kind.g_AC_SyntaxPart_1, p_AC_SyntaxPart_ref);
			return p_AC_SyntaxPart_ref;
		}

		//
		// create syntax tree node associated with production
		// AC-SyntaxPart: %empty

		//

		public AC_SyntaxPart AC_SyntaxPart_2 ()
		{
			AC_SyntaxPart p_AC_SyntaxPart_ref = new AC_SyntaxPart();
			Raise_AC_SyntaxPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_SyntaxPart.production_kind.g_AC_SyntaxPart_2, p_AC_SyntaxPart_ref);
			return p_AC_SyntaxPart_ref;
		}
		#endregion
	};
}
