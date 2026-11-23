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
	// class associated with syntax rule MI-RevisionPart
	//

	[DataContract]
	public class	MI_RevisionPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MI-RevisionPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MI-RevisionPart
		{
			g_MI_RevisionPart_1 = 1,	// MI-Revisions

			g_MI_RevisionPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule MI-RevisionPart

		// markers associated with production: MI-RevisionPart -> MI-Revisions

		public enum production_marker_1 : ushort
		{
			m_MI_Revisions,
			final
		};

		// markers associated with production: MI-RevisionPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MI-RevisionPart

		// Constructor declaration(s) associated with production(s) of syntax rule MI-RevisionPart

		//
		// Constructor associated with the following production(s)
		// MI-RevisionPart -> MI-Revisions

		//

		public MI_RevisionPart (MI_Revisions p_MI_Revisions) : base ((uint) ProductionID._MI_RevisionPart_ID, (uint) production_kind.g_MI_RevisionPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_MI_Revisions = p_MI_Revisions;
		}

		//
		// Constructor associated with the following production(s)
		// MI-RevisionPart -> %empty

		//

		public MI_RevisionPart () : base ((uint) ProductionID._MI_RevisionPart_ID, (uint) production_kind.g_MI_RevisionPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public MI_RevisionPart (MI_RevisionPart p_MI_RevisionPart) : base (p_MI_RevisionPart.id, p_MI_RevisionPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MI_RevisionPart.appInfo;
			switch ((production_kind) p_MI_RevisionPart.kind)
			{
				case production_kind.g_MI_RevisionPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MI_Revisions = (p_MI_RevisionPart.m_MI_Revisions != null) ? new MI_Revisions (p_MI_RevisionPart.m_MI_Revisions) : null) != null) m_MI_Revisions.parent = this;
					break;
				case production_kind.g_MI_RevisionPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "MI_RevisionPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MI_RevisionPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_MI_Revisions?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MI-RevisionPart

		// Content changing function(s) associated with production(s) of syntax rule MI-RevisionPart

		//
		// Content changing function associated with following production(s)
		// MI-RevisionPart -> MI-Revisions

		//

		public void change(MI_Revisions p_MI_Revisions)
		{
			_init ();
			this.kind = (uint) production_kind.g_MI_RevisionPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_MI_Revisions = p_MI_Revisions;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MI-RevisionPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_MI_RevisionPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MI-RevisionPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_MI_Revisions != null) && m_MI_Revisions.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MI-RevisionPart

		//
		// emit production tree node associated with any production of syntax rule MI-RevisionPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MI_RevisionPart_1:
					// emit syntax tree node associated with production
					// MI-RevisionPart: MI-Revisions

					s += m_MI_Revisions.Emit (depth - 1);
				break;
				case production_kind.g_MI_RevisionPart_2:
					// emit syntax tree node associated with production
					// MI-RevisionPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MI-RevisionPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MI_RevisionPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MI_RevisionPart_1:
					// emit syntax tree node associated with production
					// MI-RevisionPart: MI-Revisions

					s += m_MI_Revisions.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MI_RevisionPart_2:
					// emit syntax tree node associated with production
					// MI-RevisionPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MI-RevisionPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MI-RevisionPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MI_RevisionPart.production_kind kind = (MI_RevisionPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MI_RevisionPart.production_kind.g_MI_RevisionPart_1:
					// traverse syntax tree node associated with production
					// MI-RevisionPart: MI-Revisions

						m_MI_Revisions.Visit (visitor, appData);
				break;
				case MI_RevisionPart.production_kind.g_MI_RevisionPart_2:
					// traverse syntax tree node associated with production
					// MI-RevisionPart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_MI_Revisions?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MI-RevisionPart
		//

		public void _init ()
		{
			m_MI_Revisions = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MI-RevisionPart

		// counter of all nodes associated with syntax rule MI-RevisionPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MI-RevisionPart
		[DataMember (Name = "m_MI_Revisions")] public MI_Revisions m_MI_Revisions { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MI-RevisionPart

		// delegate function (callback) prototype associated with syntax rule MI-RevisionPart
		public delegate bool MI_RevisionPart_Callback (SyntaxTreeCallbackReason reason, MI_RevisionPart.production_kind kind, MI_RevisionPart p_MI_RevisionPart);

		// event associated with syntax rule MI-RevisionPart
		public event MI_RevisionPart_Callback MI_RevisionPart_Event;

		// event trigger associated with syntax rule MI-RevisionPart
		public bool Raise_MI_RevisionPart_Event (SyntaxTreeCallbackReason reason, MI_RevisionPart.production_kind kind, MI_RevisionPart p_MI_RevisionPart)
		{
			bool? status = MI_RevisionPart_Event?.Invoke (reason, kind, p_MI_RevisionPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MI-RevisionPart
		//
		// traverse syntax tree node associated with any production of syntax rule MI-RevisionPart
		//

		public void Traverse (MI_RevisionPart p_MI_RevisionPart)
		{
			if (p_MI_RevisionPart.isLocked())
				return;
			p_MI_RevisionPart.dolock();
			MI_RevisionPart.production_kind kind = (MI_RevisionPart.production_kind) p_MI_RevisionPart.kind;
			p_MI_RevisionPart.turn_reset ();
			if (Raise_MI_RevisionPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MI_RevisionPart))
			switch (kind)
			{
				case MI_RevisionPart.production_kind.g_MI_RevisionPart_1:
					// traverse syntax tree node associated with production
					// MI-RevisionPart: MI-Revisions

					if (Raise_MI_RevisionPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MI_RevisionPart))
						Traverse (p_MI_RevisionPart.m_MI_Revisions);
					p_MI_RevisionPart.turn_inc ();
					Raise_MI_RevisionPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MI_RevisionPart);
				break;
				case MI_RevisionPart.production_kind.g_MI_RevisionPart_2:
					// traverse syntax tree node associated with production
					// MI-RevisionPart: %empty

				break;
			}
			Raise_MI_RevisionPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MI_RevisionPart);
			p_MI_RevisionPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MI-RevisionPart
		//

		public void TraverseCommon (MI_RevisionPart p_MI_RevisionPart)
		{
			MI_RevisionPart.production_kind kind = (MI_RevisionPart.production_kind) p_MI_RevisionPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MI_RevisionPart))
			switch (kind)
			{
				case MI_RevisionPart.production_kind.g_MI_RevisionPart_1:
					// traverse syntax tree node associated with production
					// MI-RevisionPart: MI-Revisions

						TraverseCommon (p_MI_RevisionPart.m_MI_Revisions);
				break;
				case MI_RevisionPart.production_kind.g_MI_RevisionPart_2:
					// traverse syntax tree node associated with production
					// MI-RevisionPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MI_RevisionPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MI-RevisionPart

		//
		// create syntax tree node associated with production
		// MI-RevisionPart: MI-Revisions

		//

		public MI_RevisionPart MI_RevisionPart_1 (MI_Revisions p_MI_Revisions)
		{
			MI_RevisionPart p_MI_RevisionPart_ref = new MI_RevisionPart(p_MI_Revisions);
			p_MI_Revisions.parent = p_MI_RevisionPart_ref;
			Raise_MI_RevisionPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MI_RevisionPart.production_kind.g_MI_RevisionPart_1, p_MI_RevisionPart_ref);
			return p_MI_RevisionPart_ref;
		}

		//
		// create syntax tree node associated with production
		// MI-RevisionPart: %empty

		//

		public MI_RevisionPart MI_RevisionPart_2 ()
		{
			MI_RevisionPart p_MI_RevisionPart_ref = new MI_RevisionPart();
			Raise_MI_RevisionPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MI_RevisionPart.production_kind.g_MI_RevisionPart_2, p_MI_RevisionPart_ref);
			return p_MI_RevisionPart_ref;
		}
		#endregion
	};
}
