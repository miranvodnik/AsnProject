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
	// class associated with syntax rule RootAlternativeTypeList
	//

	[DataContract]
	public class	RootAlternativeTypeList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule RootAlternativeTypeList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule RootAlternativeTypeList
		{
			g_RootAlternativeTypeList_1 = 1,	// AlternativeTypeList

		};
		#endregion
		#region production markers associated with the syntax rule RootAlternativeTypeList

		// markers associated with production: RootAlternativeTypeList -> AlternativeTypeList

		public enum production_marker_1 : ushort
		{
			m_AlternativeTypeList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule RootAlternativeTypeList

		// Constructor declaration(s) associated with production(s) of syntax rule RootAlternativeTypeList

		//
		// Constructor associated with the following production(s)
		// RootAlternativeTypeList -> AlternativeTypeList

		//

		public RootAlternativeTypeList (AlternativeTypeList p_AlternativeTypeList) : base ((uint) ProductionID._RootAlternativeTypeList_ID, (uint) production_kind.g_RootAlternativeTypeList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_AlternativeTypeList = p_AlternativeTypeList;
		}

		public RootAlternativeTypeList () { }

		// Copy constructor

		public RootAlternativeTypeList (RootAlternativeTypeList p_RootAlternativeTypeList) : base (p_RootAlternativeTypeList.id, p_RootAlternativeTypeList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_RootAlternativeTypeList.appInfo;
			switch ((production_kind) p_RootAlternativeTypeList.kind)
			{
				case production_kind.g_RootAlternativeTypeList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_AlternativeTypeList = (p_RootAlternativeTypeList.m_AlternativeTypeList != null) ? new AlternativeTypeList (p_RootAlternativeTypeList.m_AlternativeTypeList) : null) != null) m_AlternativeTypeList.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "RootAlternativeTypeList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new RootAlternativeTypeList (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_AlternativeTypeList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule RootAlternativeTypeList

		// Content changing function(s) associated with production(s) of syntax rule RootAlternativeTypeList

		//
		// Content changing function associated with following production(s)
		// RootAlternativeTypeList -> AlternativeTypeList

		//

		public void change(AlternativeTypeList p_AlternativeTypeList)
		{
			_init ();
			this.kind = (uint) production_kind.g_RootAlternativeTypeList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_AlternativeTypeList = p_AlternativeTypeList;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule RootAlternativeTypeList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_AlternativeTypeList != null) && m_AlternativeTypeList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule RootAlternativeTypeList

		//
		// emit production tree node associated with any production of syntax rule RootAlternativeTypeList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_RootAlternativeTypeList_1:
					// emit syntax tree node associated with production
					// RootAlternativeTypeList: AlternativeTypeList

					s += m_AlternativeTypeList.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule RootAlternativeTypeList
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "RootAlternativeTypeList (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_RootAlternativeTypeList_1:
					// emit syntax tree node associated with production
					// RootAlternativeTypeList: AlternativeTypeList

					s += m_AlternativeTypeList.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule RootAlternativeTypeList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule RootAlternativeTypeList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			RootAlternativeTypeList.production_kind kind = (RootAlternativeTypeList.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case RootAlternativeTypeList.production_kind.g_RootAlternativeTypeList_1:
					// traverse syntax tree node associated with production
					// RootAlternativeTypeList: AlternativeTypeList

						m_AlternativeTypeList.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_AlternativeTypeList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule RootAlternativeTypeList
		//

		public void _init ()
		{
			m_AlternativeTypeList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule RootAlternativeTypeList

		// counter of all nodes associated with syntax rule RootAlternativeTypeList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule RootAlternativeTypeList
		[DataMember (Name = "m_AlternativeTypeList")] public AlternativeTypeList m_AlternativeTypeList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule RootAlternativeTypeList

		// delegate function (callback) prototype associated with syntax rule RootAlternativeTypeList
		public delegate bool RootAlternativeTypeList_Callback (SyntaxTreeCallbackReason reason, RootAlternativeTypeList.production_kind kind, RootAlternativeTypeList p_RootAlternativeTypeList);

		// event associated with syntax rule RootAlternativeTypeList
		public event RootAlternativeTypeList_Callback RootAlternativeTypeList_Event;

		// event trigger associated with syntax rule RootAlternativeTypeList
		public bool Raise_RootAlternativeTypeList_Event (SyntaxTreeCallbackReason reason, RootAlternativeTypeList.production_kind kind, RootAlternativeTypeList p_RootAlternativeTypeList)
		{
			bool? status = RootAlternativeTypeList_Event?.Invoke (reason, kind, p_RootAlternativeTypeList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule RootAlternativeTypeList
		//
		// traverse syntax tree node associated with any production of syntax rule RootAlternativeTypeList
		//

		public void Traverse (RootAlternativeTypeList p_RootAlternativeTypeList)
		{
			if (p_RootAlternativeTypeList.isLocked())
				return;
			p_RootAlternativeTypeList.dolock();
			RootAlternativeTypeList.production_kind kind = (RootAlternativeTypeList.production_kind) p_RootAlternativeTypeList.kind;
			p_RootAlternativeTypeList.turn_reset ();
			if (Raise_RootAlternativeTypeList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_RootAlternativeTypeList))
			switch (kind)
			{
				case RootAlternativeTypeList.production_kind.g_RootAlternativeTypeList_1:
					// traverse syntax tree node associated with production
					// RootAlternativeTypeList: AlternativeTypeList

					if (Raise_RootAlternativeTypeList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RootAlternativeTypeList))
						Traverse (p_RootAlternativeTypeList.m_AlternativeTypeList);
					p_RootAlternativeTypeList.turn_inc ();
					Raise_RootAlternativeTypeList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RootAlternativeTypeList);
				break;
			}
			Raise_RootAlternativeTypeList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_RootAlternativeTypeList);
			p_RootAlternativeTypeList.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule RootAlternativeTypeList
		//

		public void TraverseCommon (RootAlternativeTypeList p_RootAlternativeTypeList)
		{
			RootAlternativeTypeList.production_kind kind = (RootAlternativeTypeList.production_kind) p_RootAlternativeTypeList.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_RootAlternativeTypeList))
			switch (kind)
			{
				case RootAlternativeTypeList.production_kind.g_RootAlternativeTypeList_1:
					// traverse syntax tree node associated with production
					// RootAlternativeTypeList: AlternativeTypeList

						TraverseCommon (p_RootAlternativeTypeList.m_AlternativeTypeList);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_RootAlternativeTypeList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule RootAlternativeTypeList

		//
		// create syntax tree node associated with production
		// RootAlternativeTypeList: AlternativeTypeList

		//

		public RootAlternativeTypeList RootAlternativeTypeList_1 (AlternativeTypeList p_AlternativeTypeList)
		{
			RootAlternativeTypeList p_RootAlternativeTypeList_ref = new RootAlternativeTypeList(p_AlternativeTypeList);
			p_AlternativeTypeList.parent = p_RootAlternativeTypeList_ref;
			Raise_RootAlternativeTypeList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RootAlternativeTypeList.production_kind.g_RootAlternativeTypeList_1, p_RootAlternativeTypeList_ref);
			return p_RootAlternativeTypeList_ref;
		}
		#endregion
	};
}
