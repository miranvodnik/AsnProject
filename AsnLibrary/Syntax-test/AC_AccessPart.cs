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
	// class associated with syntax rule AC-AccessPart
	//

	[DataContract]
	public class	AC_AccessPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-AccessPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-AccessPart
		{
			g_AC_AccessPart_1 = 1,	// ACCESS AC-Access

			g_AC_AccessPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule AC-AccessPart

		// markers associated with production: AC-AccessPart -> ACCESS AC-Access

		public enum production_marker_1 : ushort
		{
			m_AC_Access,
			final
		};

		// markers associated with production: AC-AccessPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-AccessPart

		// Constructor declaration(s) associated with production(s) of syntax rule AC-AccessPart

		//
		// Constructor associated with the following production(s)
		// AC-AccessPart -> ACCESS AC-Access

		//

		public AC_AccessPart (SyntaxTreeToken p_token, AC_Access p_AC_Access) : base ((uint) ProductionID._AC_AccessPart_ID, (uint) production_kind.g_AC_AccessPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ACCESS = p_token;
			children[1] = m_AC_Access = p_AC_Access;
		}

		//
		// Constructor associated with the following production(s)
		// AC-AccessPart -> %empty

		//

		public AC_AccessPart () : base ((uint) ProductionID._AC_AccessPart_ID, (uint) production_kind.g_AC_AccessPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public AC_AccessPart (AC_AccessPart p_AC_AccessPart) : base (p_AC_AccessPart.id, p_AC_AccessPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_AccessPart.appInfo;
			switch ((production_kind) p_AC_AccessPart.kind)
			{
				case production_kind.g_AC_AccessPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ACCESS = (p_AC_AccessPart.m_ACCESS != null) ? new SyntaxTreeToken (p_AC_AccessPart.m_ACCESS) : null) != null) m_ACCESS.parent = this;
					if ((children [1] = m_AC_Access = (p_AC_AccessPart.m_AC_Access != null) ? new AC_Access (p_AC_AccessPart.m_AC_Access) : null) != null) m_AC_Access.parent = this;
					break;
				case production_kind.g_AC_AccessPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "AC_AccessPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_AccessPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ACCESS?.Dispose ();
			m_AC_Access?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-AccessPart

		// Content changing function(s) associated with production(s) of syntax rule AC-AccessPart

		//
		// Content changing function associated with following production(s)
		// AC-AccessPart -> ACCESS AC-Access

		//

		public void change(SyntaxTreeToken p_token, AC_Access p_AC_Access)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_AccessPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ACCESS = p_token;
			children [1] = m_AC_Access = p_AC_Access;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AC-AccessPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_AccessPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-AccessPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ACCESS != null) && m_ACCESS.checkInclusion (element) ||
				(m_AC_Access != null) && m_AC_Access.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-AccessPart

		//
		// emit production tree node associated with any production of syntax rule AC-AccessPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_AccessPart_1:
					// emit syntax tree node associated with production
					// AC-AccessPart: ACCESS AC-Access

					s += m_ACCESS.Emit (depth - 1);
					s += " ";
					s += m_AC_Access.Emit (depth - 1);
				break;
				case production_kind.g_AC_AccessPart_2:
					// emit syntax tree node associated with production
					// AC-AccessPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-AccessPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_AccessPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_AccessPart_1:
					// emit syntax tree node associated with production
					// AC-AccessPart: ACCESS AC-Access

					s += "ACCESS";
					s += ' ';
					s += m_AC_Access.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_AC_AccessPart_2:
					// emit syntax tree node associated with production
					// AC-AccessPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-AccessPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-AccessPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_AccessPart.production_kind kind = (AC_AccessPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_AccessPart.production_kind.g_AC_AccessPart_1:
					// traverse syntax tree node associated with production
					// AC-AccessPart: ACCESS AC-Access

						m_ACCESS.Visit (visitor, appData);
						m_AC_Access.Visit (visitor, appData);
				break;
				case AC_AccessPart.production_kind.g_AC_AccessPart_2:
					// traverse syntax tree node associated with production
					// AC-AccessPart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ACCESS?.reparent (this);
			m_AC_Access?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AC-AccessPart
		//

		public void _init ()
		{
			m_ACCESS = null;
			m_AC_Access = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-AccessPart

		// counter of all nodes associated with syntax rule AC-AccessPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-AccessPart
		[DataMember (Name = "m_ACCESS")] public SyntaxTreeToken m_ACCESS { get; private set; }
		[DataMember (Name = "m_AC_Access")] public AC_Access m_AC_Access { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-AccessPart

		// delegate function (callback) prototype associated with syntax rule AC-AccessPart
		public delegate bool AC_AccessPart_Callback (SyntaxTreeCallbackReason reason, AC_AccessPart.production_kind kind, AC_AccessPart p_AC_AccessPart);

		// event associated with syntax rule AC-AccessPart
		public event AC_AccessPart_Callback AC_AccessPart_Event;

		// event trigger associated with syntax rule AC-AccessPart
		public bool Raise_AC_AccessPart_Event (SyntaxTreeCallbackReason reason, AC_AccessPart.production_kind kind, AC_AccessPart p_AC_AccessPart)
		{
			bool? status = AC_AccessPart_Event?.Invoke (reason, kind, p_AC_AccessPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-AccessPart
		//
		// traverse syntax tree node associated with any production of syntax rule AC-AccessPart
		//

		public void Traverse (AC_AccessPart p_AC_AccessPart)
		{
			if (p_AC_AccessPart.isLocked())
				return;
			p_AC_AccessPart.dolock();
			AC_AccessPart.production_kind kind = (AC_AccessPart.production_kind) p_AC_AccessPart.kind;
			p_AC_AccessPart.turn_reset ();
			if (Raise_AC_AccessPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_AccessPart))
			switch (kind)
			{
				case AC_AccessPart.production_kind.g_AC_AccessPart_1:
					// traverse syntax tree node associated with production
					// AC-AccessPart: ACCESS AC-Access

					if (Raise_AC_AccessPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_AccessPart))
						Traverse (p_AC_AccessPart.m_AC_Access);
					p_AC_AccessPart.turn_inc ();
					Raise_AC_AccessPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_AccessPart);
				break;
				case AC_AccessPart.production_kind.g_AC_AccessPart_2:
					// traverse syntax tree node associated with production
					// AC-AccessPart: %empty

				break;
			}
			Raise_AC_AccessPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_AccessPart);
			p_AC_AccessPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-AccessPart
		//

		public void TraverseCommon (AC_AccessPart p_AC_AccessPart)
		{
			AC_AccessPart.production_kind kind = (AC_AccessPart.production_kind) p_AC_AccessPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_AccessPart))
			switch (kind)
			{
				case AC_AccessPart.production_kind.g_AC_AccessPart_1:
					// traverse syntax tree node associated with production
					// AC-AccessPart: ACCESS AC-Access

						TraverseCommon (p_AC_AccessPart.m_ACCESS);
						TraverseCommon (p_AC_AccessPart.m_AC_Access);
				break;
				case AC_AccessPart.production_kind.g_AC_AccessPart_2:
					// traverse syntax tree node associated with production
					// AC-AccessPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_AccessPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-AccessPart

		//
		// create syntax tree node associated with production
		// AC-AccessPart: ACCESS AC-Access

		//

		public AC_AccessPart AC_AccessPart_1 (SyntaxTreeToken p_token, AC_Access p_AC_Access)
		{
			AC_AccessPart p_AC_AccessPart_ref = new AC_AccessPart(p_token, p_AC_Access);
			p_token.parent = p_AC_AccessPart_ref;
			p_AC_Access.parent = p_AC_AccessPart_ref;
			Raise_AC_AccessPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_AccessPart.production_kind.g_AC_AccessPart_1, p_AC_AccessPart_ref);
			return p_AC_AccessPart_ref;
		}

		//
		// create syntax tree node associated with production
		// AC-AccessPart: %empty

		//

		public AC_AccessPart AC_AccessPart_2 ()
		{
			AC_AccessPart p_AC_AccessPart_ref = new AC_AccessPart();
			Raise_AC_AccessPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_AccessPart.production_kind.g_AC_AccessPart_2, p_AC_AccessPart_ref);
			return p_AC_AccessPart_ref;
		}
		#endregion
	};
}
