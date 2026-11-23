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
	// class associated with syntax rule Elems
	//

	[DataContract]
	public class	Elems : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Elems
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Elems
		{
			g_Elems_1 = 1,	// Elements

		};
		#endregion
		#region production markers associated with the syntax rule Elems

		// markers associated with production: Elems -> Elements

		public enum production_marker_1 : ushort
		{
			m_Elements,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Elems

		// Constructor declaration(s) associated with production(s) of syntax rule Elems

		//
		// Constructor associated with the following production(s)
		// Elems -> Elements

		//

		public Elems (Elements p_Elements) : base ((uint) ProductionID._Elems_ID, (uint) production_kind.g_Elems_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Elements = p_Elements;
		}

		public Elems () { }

		// Copy constructor

		public Elems (Elems p_Elems) : base (p_Elems.id, p_Elems.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Elems.appInfo;
			switch ((production_kind) p_Elems.kind)
			{
				case production_kind.g_Elems_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Elements = (p_Elems.m_Elements != null) ? new Elements (p_Elems.m_Elements) : null) != null) m_Elements.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Elems" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Elems (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Elements?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Elems

		// Content changing function(s) associated with production(s) of syntax rule Elems

		//
		// Content changing function associated with following production(s)
		// Elems -> Elements

		//

		public void change(Elements p_Elements)
		{
			_init ();
			this.kind = (uint) production_kind.g_Elems_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Elements = p_Elements;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Elems
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Elements != null) && m_Elements.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Elems

		//
		// emit production tree node associated with any production of syntax rule Elems
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Elems_1:
					// emit syntax tree node associated with production
					// Elems: Elements

					s += m_Elements.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Elems
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Elems (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Elems_1:
					// emit syntax tree node associated with production
					// Elems: Elements

					s += m_Elements.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Elems

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Elems with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Elems.production_kind kind = (Elems.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Elems.production_kind.g_Elems_1:
					// traverse syntax tree node associated with production
					// Elems: Elements

						m_Elements.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Elements?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Elems
		//

		public void _init ()
		{
			m_Elements = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Elems

		// counter of all nodes associated with syntax rule Elems
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Elems
		[DataMember (Name = "m_Elements")] public Elements m_Elements { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Elems

		// delegate function (callback) prototype associated with syntax rule Elems
		public delegate bool Elems_Callback (SyntaxTreeCallbackReason reason, Elems.production_kind kind, Elems p_Elems);

		// event associated with syntax rule Elems
		public event Elems_Callback Elems_Event;

		// event trigger associated with syntax rule Elems
		public bool Raise_Elems_Event (SyntaxTreeCallbackReason reason, Elems.production_kind kind, Elems p_Elems)
		{
			bool? status = Elems_Event?.Invoke (reason, kind, p_Elems);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Elems
		//
		// traverse syntax tree node associated with any production of syntax rule Elems
		//

		public void Traverse (Elems p_Elems)
		{
			if (p_Elems.isLocked())
				return;
			p_Elems.dolock();
			Elems.production_kind kind = (Elems.production_kind) p_Elems.kind;
			p_Elems.turn_reset ();
			if (Raise_Elems_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Elems))
			switch (kind)
			{
				case Elems.production_kind.g_Elems_1:
					// traverse syntax tree node associated with production
					// Elems: Elements

					if (Raise_Elems_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Elems))
						Traverse (p_Elems.m_Elements);
					p_Elems.turn_inc ();
					Raise_Elems_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Elems);
				break;
			}
			Raise_Elems_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Elems);
			p_Elems.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Elems
		//

		public void TraverseCommon (Elems p_Elems)
		{
			Elems.production_kind kind = (Elems.production_kind) p_Elems.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Elems))
			switch (kind)
			{
				case Elems.production_kind.g_Elems_1:
					// traverse syntax tree node associated with production
					// Elems: Elements

						TraverseCommon (p_Elems.m_Elements);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Elems);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Elems

		//
		// create syntax tree node associated with production
		// Elems: Elements

		//

		public Elems Elems_1 (Elements p_Elements)
		{
			Elems p_Elems_ref = new Elems(p_Elements);
			p_Elements.parent = p_Elems_ref;
			Raise_Elems_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Elems.production_kind.g_Elems_1, p_Elems_ref);
			return p_Elems_ref;
		}
		#endregion
	};
}
