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
	// class associated with syntax rule ArcList
	//

	[DataContract]
	public class	ArcList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ArcList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ArcList
		{
			g_ArcList_1 = 1,	// Arc-set

		};
		#endregion
		#region production markers associated with the syntax rule ArcList

		// markers associated with production: ArcList -> Arc-set

		public enum production_marker_1 : ushort
		{
			m_Arc_set,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ArcList

		// Constructor declaration(s) associated with production(s) of syntax rule ArcList

		//
		// Constructor associated with the following production(s)
		// ArcList -> Arc-set

		//

		public ArcList (Arc_set p_Arc_set) : base ((uint) ProductionID._ArcList_ID, (uint) production_kind.g_ArcList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Arc_set = p_Arc_set;
		}

		public ArcList () { }

		// Copy constructor

		public ArcList (ArcList p_ArcList) : base (p_ArcList.id, p_ArcList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ArcList.appInfo;
			switch ((production_kind) p_ArcList.kind)
			{
				case production_kind.g_ArcList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Arc_set = (p_ArcList.m_Arc_set != null) ? new Arc_set (p_ArcList.m_Arc_set) : null) != null) m_Arc_set.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ArcList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ArcList (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Arc_set?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ArcList

		// Content changing function(s) associated with production(s) of syntax rule ArcList

		//
		// Content changing function associated with following production(s)
		// ArcList -> Arc-set

		//

		public void change(Arc_set p_Arc_set)
		{
			_init ();
			this.kind = (uint) production_kind.g_ArcList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Arc_set = p_Arc_set;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ArcList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Arc_set != null) && m_Arc_set.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ArcList

		//
		// emit production tree node associated with any production of syntax rule ArcList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ArcList_1:
					// emit syntax tree node associated with production
					// ArcList: Arc-set

					s += m_Arc_set.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ArcList
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ArcList (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ArcList_1:
					// emit syntax tree node associated with production
					// ArcList: Arc-set

					s += m_Arc_set.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ArcList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ArcList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ArcList.production_kind kind = (ArcList.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ArcList.production_kind.g_ArcList_1:
					// traverse syntax tree node associated with production
					// ArcList: Arc-set

						m_Arc_set.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Arc_set?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ArcList
		//

		public void _init ()
		{
			m_Arc_set = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ArcList

		// counter of all nodes associated with syntax rule ArcList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ArcList
		[DataMember (Name = "m_Arc_set")] public Arc_set m_Arc_set { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ArcList

		// delegate function (callback) prototype associated with syntax rule ArcList
		public delegate bool ArcList_Callback (SyntaxTreeCallbackReason reason, ArcList.production_kind kind, ArcList p_ArcList);

		// event associated with syntax rule ArcList
		public event ArcList_Callback ArcList_Event;

		// event trigger associated with syntax rule ArcList
		public bool Raise_ArcList_Event (SyntaxTreeCallbackReason reason, ArcList.production_kind kind, ArcList p_ArcList)
		{
			bool? status = ArcList_Event?.Invoke (reason, kind, p_ArcList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ArcList
		//
		// traverse syntax tree node associated with any production of syntax rule ArcList
		//

		public void Traverse (ArcList p_ArcList)
		{
			if (p_ArcList.isLocked())
				return;
			p_ArcList.dolock();
			ArcList.production_kind kind = (ArcList.production_kind) p_ArcList.kind;
			p_ArcList.turn_reset ();
			if (Raise_ArcList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ArcList))
			switch (kind)
			{
				case ArcList.production_kind.g_ArcList_1:
					// traverse syntax tree node associated with production
					// ArcList: Arc-set

					if (Raise_ArcList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ArcList))
						Traverse (p_ArcList.m_Arc_set);
					p_ArcList.turn_inc ();
					Raise_ArcList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ArcList);
				break;
			}
			Raise_ArcList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ArcList);
			p_ArcList.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ArcList
		//

		public void TraverseCommon (ArcList p_ArcList)
		{
			ArcList.production_kind kind = (ArcList.production_kind) p_ArcList.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ArcList))
			switch (kind)
			{
				case ArcList.production_kind.g_ArcList_1:
					// traverse syntax tree node associated with production
					// ArcList: Arc-set

						TraverseCommon (p_ArcList.m_Arc_set);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ArcList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ArcList

		//
		// create syntax tree node associated with production
		// ArcList: Arc-set

		//

		public ArcList ArcList_1 (Arc_set p_Arc_set)
		{
			ArcList p_ArcList_ref = new ArcList(p_Arc_set);
			p_Arc_set.parent = p_ArcList_ref;
			Raise_ArcList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ArcList.production_kind.g_ArcList_1, p_ArcList_ref);
			return p_ArcList_ref;
		}
		#endregion
	};
}
