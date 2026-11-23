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
	// class associated with syntax rule AC-WriteSyntaxPart
	//

	[DataContract]
	public class	AC_WriteSyntaxPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-WriteSyntaxPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-WriteSyntaxPart
		{
			g_AC_WriteSyntaxPart_1 = 1,	// WRITE-SYNTAX AC-Syntax

			g_AC_WriteSyntaxPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule AC-WriteSyntaxPart

		// markers associated with production: AC-WriteSyntaxPart -> WRITE-SYNTAX AC-Syntax

		public enum production_marker_1 : ushort
		{
			m_AC_Syntax,
			final
		};

		// markers associated with production: AC-WriteSyntaxPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-WriteSyntaxPart

		// Constructor declaration(s) associated with production(s) of syntax rule AC-WriteSyntaxPart

		//
		// Constructor associated with the following production(s)
		// AC-WriteSyntaxPart -> WRITE-SYNTAX AC-Syntax

		//

		public AC_WriteSyntaxPart (SyntaxTreeToken p_token, AC_Syntax p_AC_Syntax) : base ((uint) ProductionID._AC_WriteSyntaxPart_ID, (uint) production_kind.g_AC_WriteSyntaxPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_WRITE_SYNTAX = p_token;
			children[1] = m_AC_Syntax = p_AC_Syntax;
		}

		//
		// Constructor associated with the following production(s)
		// AC-WriteSyntaxPart -> %empty

		//

		public AC_WriteSyntaxPart () : base ((uint) ProductionID._AC_WriteSyntaxPart_ID, (uint) production_kind.g_AC_WriteSyntaxPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public AC_WriteSyntaxPart (AC_WriteSyntaxPart p_AC_WriteSyntaxPart) : base (p_AC_WriteSyntaxPart.id, p_AC_WriteSyntaxPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_WriteSyntaxPart.appInfo;
			switch ((production_kind) p_AC_WriteSyntaxPart.kind)
			{
				case production_kind.g_AC_WriteSyntaxPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_WRITE_SYNTAX = (p_AC_WriteSyntaxPart.m_WRITE_SYNTAX != null) ? new SyntaxTreeToken (p_AC_WriteSyntaxPart.m_WRITE_SYNTAX) : null) != null) m_WRITE_SYNTAX.parent = this;
					if ((children [1] = m_AC_Syntax = (p_AC_WriteSyntaxPart.m_AC_Syntax != null) ? new AC_Syntax (p_AC_WriteSyntaxPart.m_AC_Syntax) : null) != null) m_AC_Syntax.parent = this;
					break;
				case production_kind.g_AC_WriteSyntaxPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "AC_WriteSyntaxPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_WriteSyntaxPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_WRITE_SYNTAX?.Dispose ();
			m_AC_Syntax?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-WriteSyntaxPart

		// Content changing function(s) associated with production(s) of syntax rule AC-WriteSyntaxPart

		//
		// Content changing function associated with following production(s)
		// AC-WriteSyntaxPart -> WRITE-SYNTAX AC-Syntax

		//

		public void change(SyntaxTreeToken p_token, AC_Syntax p_AC_Syntax)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_WriteSyntaxPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_WRITE_SYNTAX = p_token;
			children [1] = m_AC_Syntax = p_AC_Syntax;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AC-WriteSyntaxPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_WriteSyntaxPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-WriteSyntaxPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_WRITE_SYNTAX != null) && m_WRITE_SYNTAX.checkInclusion (element) ||
				(m_AC_Syntax != null) && m_AC_Syntax.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-WriteSyntaxPart

		//
		// emit production tree node associated with any production of syntax rule AC-WriteSyntaxPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_WriteSyntaxPart_1:
					// emit syntax tree node associated with production
					// AC-WriteSyntaxPart: WRITE-SYNTAX AC-Syntax

					s += m_WRITE_SYNTAX.Emit (depth - 1);
					s += " ";
					s += m_AC_Syntax.Emit (depth - 1);
				break;
				case production_kind.g_AC_WriteSyntaxPart_2:
					// emit syntax tree node associated with production
					// AC-WriteSyntaxPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-WriteSyntaxPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_WriteSyntaxPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_WriteSyntaxPart_1:
					// emit syntax tree node associated with production
					// AC-WriteSyntaxPart: WRITE-SYNTAX AC-Syntax

					s += "WRITE_SYNTAX";
					s += ' ';
					s += m_AC_Syntax.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_AC_WriteSyntaxPart_2:
					// emit syntax tree node associated with production
					// AC-WriteSyntaxPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-WriteSyntaxPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-WriteSyntaxPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_WriteSyntaxPart.production_kind kind = (AC_WriteSyntaxPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_WriteSyntaxPart.production_kind.g_AC_WriteSyntaxPart_1:
					// traverse syntax tree node associated with production
					// AC-WriteSyntaxPart: WRITE-SYNTAX AC-Syntax

						m_WRITE_SYNTAX.Visit (visitor, appData);
						m_AC_Syntax.Visit (visitor, appData);
				break;
				case AC_WriteSyntaxPart.production_kind.g_AC_WriteSyntaxPart_2:
					// traverse syntax tree node associated with production
					// AC-WriteSyntaxPart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_WRITE_SYNTAX?.reparent (this);
			m_AC_Syntax?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AC-WriteSyntaxPart
		//

		public void _init ()
		{
			m_WRITE_SYNTAX = null;
			m_AC_Syntax = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-WriteSyntaxPart

		// counter of all nodes associated with syntax rule AC-WriteSyntaxPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-WriteSyntaxPart
		[DataMember (Name = "m_WRITE_SYNTAX")] public SyntaxTreeToken m_WRITE_SYNTAX { get; private set; }
		[DataMember (Name = "m_AC_Syntax")] public AC_Syntax m_AC_Syntax { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-WriteSyntaxPart

		// delegate function (callback) prototype associated with syntax rule AC-WriteSyntaxPart
		public delegate bool AC_WriteSyntaxPart_Callback (SyntaxTreeCallbackReason reason, AC_WriteSyntaxPart.production_kind kind, AC_WriteSyntaxPart p_AC_WriteSyntaxPart);

		// event associated with syntax rule AC-WriteSyntaxPart
		public event AC_WriteSyntaxPart_Callback AC_WriteSyntaxPart_Event;

		// event trigger associated with syntax rule AC-WriteSyntaxPart
		public bool Raise_AC_WriteSyntaxPart_Event (SyntaxTreeCallbackReason reason, AC_WriteSyntaxPart.production_kind kind, AC_WriteSyntaxPart p_AC_WriteSyntaxPart)
		{
			bool? status = AC_WriteSyntaxPart_Event?.Invoke (reason, kind, p_AC_WriteSyntaxPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-WriteSyntaxPart
		//
		// traverse syntax tree node associated with any production of syntax rule AC-WriteSyntaxPart
		//

		public void Traverse (AC_WriteSyntaxPart p_AC_WriteSyntaxPart)
		{
			if (p_AC_WriteSyntaxPart.isLocked())
				return;
			p_AC_WriteSyntaxPart.dolock();
			AC_WriteSyntaxPart.production_kind kind = (AC_WriteSyntaxPart.production_kind) p_AC_WriteSyntaxPart.kind;
			p_AC_WriteSyntaxPart.turn_reset ();
			if (Raise_AC_WriteSyntaxPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_WriteSyntaxPart))
			switch (kind)
			{
				case AC_WriteSyntaxPart.production_kind.g_AC_WriteSyntaxPart_1:
					// traverse syntax tree node associated with production
					// AC-WriteSyntaxPart: WRITE-SYNTAX AC-Syntax

					if (Raise_AC_WriteSyntaxPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_WriteSyntaxPart))
						Traverse (p_AC_WriteSyntaxPart.m_AC_Syntax);
					p_AC_WriteSyntaxPart.turn_inc ();
					Raise_AC_WriteSyntaxPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_WriteSyntaxPart);
				break;
				case AC_WriteSyntaxPart.production_kind.g_AC_WriteSyntaxPart_2:
					// traverse syntax tree node associated with production
					// AC-WriteSyntaxPart: %empty

				break;
			}
			Raise_AC_WriteSyntaxPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_WriteSyntaxPart);
			p_AC_WriteSyntaxPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-WriteSyntaxPart
		//

		public void TraverseCommon (AC_WriteSyntaxPart p_AC_WriteSyntaxPart)
		{
			AC_WriteSyntaxPart.production_kind kind = (AC_WriteSyntaxPart.production_kind) p_AC_WriteSyntaxPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_WriteSyntaxPart))
			switch (kind)
			{
				case AC_WriteSyntaxPart.production_kind.g_AC_WriteSyntaxPart_1:
					// traverse syntax tree node associated with production
					// AC-WriteSyntaxPart: WRITE-SYNTAX AC-Syntax

						TraverseCommon (p_AC_WriteSyntaxPart.m_WRITE_SYNTAX);
						TraverseCommon (p_AC_WriteSyntaxPart.m_AC_Syntax);
				break;
				case AC_WriteSyntaxPart.production_kind.g_AC_WriteSyntaxPart_2:
					// traverse syntax tree node associated with production
					// AC-WriteSyntaxPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_WriteSyntaxPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-WriteSyntaxPart

		//
		// create syntax tree node associated with production
		// AC-WriteSyntaxPart: WRITE-SYNTAX AC-Syntax

		//

		public AC_WriteSyntaxPart AC_WriteSyntaxPart_1 (SyntaxTreeToken p_token, AC_Syntax p_AC_Syntax)
		{
			AC_WriteSyntaxPart p_AC_WriteSyntaxPart_ref = new AC_WriteSyntaxPart(p_token, p_AC_Syntax);
			p_token.parent = p_AC_WriteSyntaxPart_ref;
			p_AC_Syntax.parent = p_AC_WriteSyntaxPart_ref;
			Raise_AC_WriteSyntaxPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_WriteSyntaxPart.production_kind.g_AC_WriteSyntaxPart_1, p_AC_WriteSyntaxPart_ref);
			return p_AC_WriteSyntaxPart_ref;
		}

		//
		// create syntax tree node associated with production
		// AC-WriteSyntaxPart: %empty

		//

		public AC_WriteSyntaxPart AC_WriteSyntaxPart_2 ()
		{
			AC_WriteSyntaxPart p_AC_WriteSyntaxPart_ref = new AC_WriteSyntaxPart();
			Raise_AC_WriteSyntaxPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_WriteSyntaxPart.production_kind.g_AC_WriteSyntaxPart_2, p_AC_WriteSyntaxPart_ref);
			return p_AC_WriteSyntaxPart_ref;
		}
		#endregion
	};
}
