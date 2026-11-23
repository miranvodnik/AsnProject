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
	// class associated with syntax rule IntersectionElements
	//

	[DataContract]
	public class	IntersectionElements : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule IntersectionElements
		public enum production_kind : ushort	// enumerated production(s) of syntax rule IntersectionElements
		{
			g_IntersectionElements_1 = 1,	// Elements

			g_IntersectionElements_2 = 2,	// Elems Exclusions

		};
		#endregion
		#region production markers associated with the syntax rule IntersectionElements

		// markers associated with production: IntersectionElements -> Elements

		public enum production_marker_1 : ushort
		{
			m_Elements,
			final
		};

		// markers associated with production: IntersectionElements -> Elems Exclusions

		public enum production_marker_2 : ushort
		{
			m_Elems,
			m_Exclusions,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule IntersectionElements

		// Constructor declaration(s) associated with production(s) of syntax rule IntersectionElements

		//
		// Constructor associated with the following production(s)
		// IntersectionElements -> Elements

		//

		public IntersectionElements (Elements p_Elements) : base ((uint) ProductionID._IntersectionElements_ID, (uint) production_kind.g_IntersectionElements_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Elements = p_Elements;
		}

		//
		// Constructor associated with the following production(s)
		// IntersectionElements -> Elems Exclusions

		//

		public IntersectionElements (Elems p_Elems, Exclusions p_Exclusions) : base ((uint) ProductionID._IntersectionElements_ID, (uint) production_kind.g_IntersectionElements_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_Elems = p_Elems;
			children[1] = m_Exclusions = p_Exclusions;
		}

		public IntersectionElements () { }

		// Copy constructor

		public IntersectionElements (IntersectionElements p_IntersectionElements) : base (p_IntersectionElements.id, p_IntersectionElements.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_IntersectionElements.appInfo;
			switch ((production_kind) p_IntersectionElements.kind)
			{
				case production_kind.g_IntersectionElements_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Elements = (p_IntersectionElements.m_Elements != null) ? new Elements (p_IntersectionElements.m_Elements) : null) != null) m_Elements.parent = this;
					break;
				case production_kind.g_IntersectionElements_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_Elems = (p_IntersectionElements.m_Elems != null) ? new Elems (p_IntersectionElements.m_Elems) : null) != null) m_Elems.parent = this;
					if ((children [1] = m_Exclusions = (p_IntersectionElements.m_Exclusions != null) ? new Exclusions (p_IntersectionElements.m_Exclusions) : null) != null) m_Exclusions.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "IntersectionElements" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new IntersectionElements (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Elements?.Dispose ();
			m_Elems?.Dispose ();
			m_Exclusions?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule IntersectionElements

		// Content changing function(s) associated with production(s) of syntax rule IntersectionElements

		//
		// Content changing function associated with following production(s)
		// IntersectionElements -> Elements

		//

		public void change(Elements p_Elements)
		{
			_init ();
			this.kind = (uint) production_kind.g_IntersectionElements_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Elements = p_Elements;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// IntersectionElements -> Elems Exclusions

		//

		public void change(Elems p_Elems, Exclusions p_Exclusions)
		{
			_init ();
			this.kind = (uint) production_kind.g_IntersectionElements_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_Elems = p_Elems;
			children [1] = m_Exclusions = p_Exclusions;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule IntersectionElements
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Elements != null) && m_Elements.checkInclusion (element) ||
				(m_Elems != null) && m_Elems.checkInclusion (element) ||
				(m_Exclusions != null) && m_Exclusions.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule IntersectionElements

		//
		// emit production tree node associated with any production of syntax rule IntersectionElements
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_IntersectionElements_1:
					// emit syntax tree node associated with production
					// IntersectionElements: Elements

					s += m_Elements.Emit (depth - 1);
				break;
				case production_kind.g_IntersectionElements_2:
					// emit syntax tree node associated with production
					// IntersectionElements: Elems Exclusions

					s += m_Elems.Emit (depth - 1);
					s += " ";
					s += m_Exclusions.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule IntersectionElements
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "IntersectionElements (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_IntersectionElements_1:
					// emit syntax tree node associated with production
					// IntersectionElements: Elements

					s += m_Elements.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_IntersectionElements_2:
					// emit syntax tree node associated with production
					// IntersectionElements: Elems Exclusions

					s += m_Elems.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_Exclusions.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule IntersectionElements

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule IntersectionElements with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			IntersectionElements.production_kind kind = (IntersectionElements.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case IntersectionElements.production_kind.g_IntersectionElements_1:
					// traverse syntax tree node associated with production
					// IntersectionElements: Elements

						m_Elements.Visit (visitor, appData);
				break;
				case IntersectionElements.production_kind.g_IntersectionElements_2:
					// traverse syntax tree node associated with production
					// IntersectionElements: Elems Exclusions

						m_Elems.Visit (visitor, appData);
						m_Exclusions.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Elements?.reparent (this);
			m_Elems?.reparent (this);
			m_Exclusions?.reparent (this);
		}

		//
		// initialize object associated with syntax rule IntersectionElements
		//

		public void _init ()
		{
			m_Elements = null;
			m_Elems = null;
			m_Exclusions = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule IntersectionElements

		// counter of all nodes associated with syntax rule IntersectionElements
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule IntersectionElements
		[DataMember (Name = "m_Elements")] public Elements m_Elements { get; private set; }
		[DataMember (Name = "m_Elems")] public Elems m_Elems { get; private set; }
		[DataMember (Name = "m_Exclusions")] public Exclusions m_Exclusions { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule IntersectionElements

		// delegate function (callback) prototype associated with syntax rule IntersectionElements
		public delegate bool IntersectionElements_Callback (SyntaxTreeCallbackReason reason, IntersectionElements.production_kind kind, IntersectionElements p_IntersectionElements);

		// event associated with syntax rule IntersectionElements
		public event IntersectionElements_Callback IntersectionElements_Event;

		// event trigger associated with syntax rule IntersectionElements
		public bool Raise_IntersectionElements_Event (SyntaxTreeCallbackReason reason, IntersectionElements.production_kind kind, IntersectionElements p_IntersectionElements)
		{
			bool? status = IntersectionElements_Event?.Invoke (reason, kind, p_IntersectionElements);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule IntersectionElements
		//
		// traverse syntax tree node associated with any production of syntax rule IntersectionElements
		//

		public void Traverse (IntersectionElements p_IntersectionElements)
		{
			if (p_IntersectionElements.isLocked())
				return;
			p_IntersectionElements.dolock();
			IntersectionElements.production_kind kind = (IntersectionElements.production_kind) p_IntersectionElements.kind;
			p_IntersectionElements.turn_reset ();
			if (Raise_IntersectionElements_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_IntersectionElements))
			switch (kind)
			{
				case IntersectionElements.production_kind.g_IntersectionElements_1:
					// traverse syntax tree node associated with production
					// IntersectionElements: Elements

					if (Raise_IntersectionElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_IntersectionElements))
						Traverse (p_IntersectionElements.m_Elements);
					p_IntersectionElements.turn_inc ();
					Raise_IntersectionElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_IntersectionElements);
				break;
				case IntersectionElements.production_kind.g_IntersectionElements_2:
					// traverse syntax tree node associated with production
					// IntersectionElements: Elems Exclusions

					if (Raise_IntersectionElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_IntersectionElements))
						Traverse (p_IntersectionElements.m_Elems);
					p_IntersectionElements.turn_inc ();
					if (Raise_IntersectionElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_IntersectionElements))
						Traverse (p_IntersectionElements.m_Exclusions);
					p_IntersectionElements.turn_inc ();
					Raise_IntersectionElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_IntersectionElements);
				break;
			}
			Raise_IntersectionElements_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_IntersectionElements);
			p_IntersectionElements.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule IntersectionElements
		//

		public void TraverseCommon (IntersectionElements p_IntersectionElements)
		{
			IntersectionElements.production_kind kind = (IntersectionElements.production_kind) p_IntersectionElements.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_IntersectionElements))
			switch (kind)
			{
				case IntersectionElements.production_kind.g_IntersectionElements_1:
					// traverse syntax tree node associated with production
					// IntersectionElements: Elements

						TraverseCommon (p_IntersectionElements.m_Elements);
				break;
				case IntersectionElements.production_kind.g_IntersectionElements_2:
					// traverse syntax tree node associated with production
					// IntersectionElements: Elems Exclusions

						TraverseCommon (p_IntersectionElements.m_Elems);
						TraverseCommon (p_IntersectionElements.m_Exclusions);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_IntersectionElements);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule IntersectionElements

		//
		// create syntax tree node associated with production
		// IntersectionElements: Elements

		//

		public IntersectionElements IntersectionElements_1 (Elements p_Elements)
		{
			IntersectionElements p_IntersectionElements_ref = new IntersectionElements(p_Elements);
			p_Elements.parent = p_IntersectionElements_ref;
			Raise_IntersectionElements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, IntersectionElements.production_kind.g_IntersectionElements_1, p_IntersectionElements_ref);
			return p_IntersectionElements_ref;
		}

		//
		// create syntax tree node associated with production
		// IntersectionElements: Elems Exclusions

		//

		public IntersectionElements IntersectionElements_2 (Elems p_Elems, Exclusions p_Exclusions)
		{
			IntersectionElements p_IntersectionElements_ref = new IntersectionElements(p_Elems, p_Exclusions);
			p_Elems.parent = p_IntersectionElements_ref;
			p_Exclusions.parent = p_IntersectionElements_ref;
			Raise_IntersectionElements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, IntersectionElements.production_kind.g_IntersectionElements_2, p_IntersectionElements_ref);
			return p_IntersectionElements_ref;
		}
		#endregion
	};
}
