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
	// class associated with syntax rule RootComponentTypeList
	//

	[DataContract]
	public class	RootComponentTypeList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule RootComponentTypeList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule RootComponentTypeList
		{
			g_RootComponentTypeList_1 = 1,	// ComponentTypeList

		};
		#endregion
		#region production markers associated with the syntax rule RootComponentTypeList

		// markers associated with production: RootComponentTypeList -> ComponentTypeList

		public enum production_marker_1 : ushort
		{
			m_ComponentTypeList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule RootComponentTypeList

		// Constructor declaration(s) associated with production(s) of syntax rule RootComponentTypeList

		//
		// Constructor associated with the following production(s)
		// RootComponentTypeList -> ComponentTypeList

		//

		public RootComponentTypeList (ComponentTypeList p_ComponentTypeList) : base ((uint) ProductionID._RootComponentTypeList_ID, (uint) production_kind.g_RootComponentTypeList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ComponentTypeList = p_ComponentTypeList;
		}

		public RootComponentTypeList () { }

		// Copy constructor

		public RootComponentTypeList (RootComponentTypeList p_RootComponentTypeList) : base (p_RootComponentTypeList.id, p_RootComponentTypeList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_RootComponentTypeList.appInfo;
			switch ((production_kind) p_RootComponentTypeList.kind)
			{
				case production_kind.g_RootComponentTypeList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ComponentTypeList = (p_RootComponentTypeList.m_ComponentTypeList != null) ? new ComponentTypeList (p_RootComponentTypeList.m_ComponentTypeList) : null) != null) m_ComponentTypeList.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "RootComponentTypeList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new RootComponentTypeList (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ComponentTypeList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule RootComponentTypeList

		// Content changing function(s) associated with production(s) of syntax rule RootComponentTypeList

		//
		// Content changing function associated with following production(s)
		// RootComponentTypeList -> ComponentTypeList

		//

		public void change(ComponentTypeList p_ComponentTypeList)
		{
			_init ();
			this.kind = (uint) production_kind.g_RootComponentTypeList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ComponentTypeList = p_ComponentTypeList;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule RootComponentTypeList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ComponentTypeList != null) && m_ComponentTypeList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule RootComponentTypeList

		//
		// emit production tree node associated with any production of syntax rule RootComponentTypeList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_RootComponentTypeList_1:
					// emit syntax tree node associated with production
					// RootComponentTypeList: ComponentTypeList

					s += m_ComponentTypeList.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule RootComponentTypeList
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "RootComponentTypeList (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_RootComponentTypeList_1:
					// emit syntax tree node associated with production
					// RootComponentTypeList: ComponentTypeList

					s += m_ComponentTypeList.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule RootComponentTypeList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule RootComponentTypeList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			RootComponentTypeList.production_kind kind = (RootComponentTypeList.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case RootComponentTypeList.production_kind.g_RootComponentTypeList_1:
					// traverse syntax tree node associated with production
					// RootComponentTypeList: ComponentTypeList

						m_ComponentTypeList.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ComponentTypeList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule RootComponentTypeList
		//

		public void _init ()
		{
			m_ComponentTypeList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule RootComponentTypeList

		// counter of all nodes associated with syntax rule RootComponentTypeList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule RootComponentTypeList
		[DataMember (Name = "m_ComponentTypeList")] public ComponentTypeList m_ComponentTypeList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule RootComponentTypeList

		// delegate function (callback) prototype associated with syntax rule RootComponentTypeList
		public delegate bool RootComponentTypeList_Callback (SyntaxTreeCallbackReason reason, RootComponentTypeList.production_kind kind, RootComponentTypeList p_RootComponentTypeList);

		// event associated with syntax rule RootComponentTypeList
		public event RootComponentTypeList_Callback RootComponentTypeList_Event;

		// event trigger associated with syntax rule RootComponentTypeList
		public bool Raise_RootComponentTypeList_Event (SyntaxTreeCallbackReason reason, RootComponentTypeList.production_kind kind, RootComponentTypeList p_RootComponentTypeList)
		{
			bool? status = RootComponentTypeList_Event?.Invoke (reason, kind, p_RootComponentTypeList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule RootComponentTypeList
		//
		// traverse syntax tree node associated with any production of syntax rule RootComponentTypeList
		//

		public void Traverse (RootComponentTypeList p_RootComponentTypeList)
		{
			if (p_RootComponentTypeList.isLocked())
				return;
			p_RootComponentTypeList.dolock();
			RootComponentTypeList.production_kind kind = (RootComponentTypeList.production_kind) p_RootComponentTypeList.kind;
			p_RootComponentTypeList.turn_reset ();
			if (Raise_RootComponentTypeList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_RootComponentTypeList))
			switch (kind)
			{
				case RootComponentTypeList.production_kind.g_RootComponentTypeList_1:
					// traverse syntax tree node associated with production
					// RootComponentTypeList: ComponentTypeList

					if (Raise_RootComponentTypeList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RootComponentTypeList))
						Traverse (p_RootComponentTypeList.m_ComponentTypeList);
					p_RootComponentTypeList.turn_inc ();
					Raise_RootComponentTypeList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RootComponentTypeList);
				break;
			}
			Raise_RootComponentTypeList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_RootComponentTypeList);
			p_RootComponentTypeList.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule RootComponentTypeList
		//

		public void TraverseCommon (RootComponentTypeList p_RootComponentTypeList)
		{
			RootComponentTypeList.production_kind kind = (RootComponentTypeList.production_kind) p_RootComponentTypeList.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_RootComponentTypeList))
			switch (kind)
			{
				case RootComponentTypeList.production_kind.g_RootComponentTypeList_1:
					// traverse syntax tree node associated with production
					// RootComponentTypeList: ComponentTypeList

						TraverseCommon (p_RootComponentTypeList.m_ComponentTypeList);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_RootComponentTypeList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule RootComponentTypeList

		//
		// create syntax tree node associated with production
		// RootComponentTypeList: ComponentTypeList

		//

		public RootComponentTypeList RootComponentTypeList_1 (ComponentTypeList p_ComponentTypeList)
		{
			RootComponentTypeList p_RootComponentTypeList_ref = new RootComponentTypeList(p_ComponentTypeList);
			p_ComponentTypeList.parent = p_RootComponentTypeList_ref;
			Raise_RootComponentTypeList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RootComponentTypeList.production_kind.g_RootComponentTypeList_1, p_RootComponentTypeList_ref);
			return p_RootComponentTypeList_ref;
		}
		#endregion
	};
}
