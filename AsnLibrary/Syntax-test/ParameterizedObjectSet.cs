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
	// class associated with syntax rule ParameterizedObjectSet
	//

	[DataContract]
	public class	ParameterizedObjectSet : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ParameterizedObjectSet
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ParameterizedObjectSet
		{
			g_ParameterizedObjectSet_1 = 1,	// DefinedObjectSet ActualParameterList

		};
		#endregion
		#region production markers associated with the syntax rule ParameterizedObjectSet

		// markers associated with production: ParameterizedObjectSet -> DefinedObjectSet ActualParameterList

		public enum production_marker_1 : ushort
		{
			m_DefinedObjectSet,
			m_ActualParameterList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ParameterizedObjectSet

		// Constructor declaration(s) associated with production(s) of syntax rule ParameterizedObjectSet

		//
		// Constructor associated with the following production(s)
		// ParameterizedObjectSet -> DefinedObjectSet ActualParameterList

		//

		public ParameterizedObjectSet (DefinedObjectSet p_DefinedObjectSet, ActualParameterList p_ActualParameterList) : base ((uint) ProductionID._ParameterizedObjectSet_ID, (uint) production_kind.g_ParameterizedObjectSet_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_DefinedObjectSet = p_DefinedObjectSet;
			children[1] = m_ActualParameterList = p_ActualParameterList;
		}

		public ParameterizedObjectSet () { }

		// Copy constructor

		public ParameterizedObjectSet (ParameterizedObjectSet p_ParameterizedObjectSet) : base (p_ParameterizedObjectSet.id, p_ParameterizedObjectSet.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ParameterizedObjectSet.appInfo;
			switch ((production_kind) p_ParameterizedObjectSet.kind)
			{
				case production_kind.g_ParameterizedObjectSet_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_DefinedObjectSet = (p_ParameterizedObjectSet.m_DefinedObjectSet != null) ? new DefinedObjectSet (p_ParameterizedObjectSet.m_DefinedObjectSet) : null) != null) m_DefinedObjectSet.parent = this;
					if ((children [1] = m_ActualParameterList = (p_ParameterizedObjectSet.m_ActualParameterList != null) ? new ActualParameterList (p_ParameterizedObjectSet.m_ActualParameterList) : null) != null) m_ActualParameterList.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ParameterizedObjectSet" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ParameterizedObjectSet (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DefinedObjectSet?.Dispose ();
			m_ActualParameterList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ParameterizedObjectSet

		// Content changing function(s) associated with production(s) of syntax rule ParameterizedObjectSet

		//
		// Content changing function associated with following production(s)
		// ParameterizedObjectSet -> DefinedObjectSet ActualParameterList

		//

		public void change(DefinedObjectSet p_DefinedObjectSet, ActualParameterList p_ActualParameterList)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedObjectSet_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_DefinedObjectSet = p_DefinedObjectSet;
			children [1] = m_ActualParameterList = p_ActualParameterList;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ParameterizedObjectSet
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DefinedObjectSet != null) && m_DefinedObjectSet.checkInclusion (element) ||
				(m_ActualParameterList != null) && m_ActualParameterList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ParameterizedObjectSet

		//
		// emit production tree node associated with any production of syntax rule ParameterizedObjectSet
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ParameterizedObjectSet_1:
					// emit syntax tree node associated with production
					// ParameterizedObjectSet: DefinedObjectSet ActualParameterList

					s += m_DefinedObjectSet.Emit (depth - 1);
					s += " ";
					s += m_ActualParameterList.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ParameterizedObjectSet
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ParameterizedObjectSet (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ParameterizedObjectSet_1:
					// emit syntax tree node associated with production
					// ParameterizedObjectSet: DefinedObjectSet ActualParameterList

					s += m_DefinedObjectSet.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ActualParameterList.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ParameterizedObjectSet

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedObjectSet with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ParameterizedObjectSet.production_kind kind = (ParameterizedObjectSet.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ParameterizedObjectSet.production_kind.g_ParameterizedObjectSet_1:
					// traverse syntax tree node associated with production
					// ParameterizedObjectSet: DefinedObjectSet ActualParameterList

						m_DefinedObjectSet.Visit (visitor, appData);
						m_ActualParameterList.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DefinedObjectSet?.reparent (this);
			m_ActualParameterList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ParameterizedObjectSet
		//

		public void _init ()
		{
			m_DefinedObjectSet = null;
			m_ActualParameterList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ParameterizedObjectSet

		// counter of all nodes associated with syntax rule ParameterizedObjectSet
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ParameterizedObjectSet
		[DataMember (Name = "m_DefinedObjectSet")] public DefinedObjectSet m_DefinedObjectSet { get; private set; }
		[DataMember (Name = "m_ActualParameterList")] public ActualParameterList m_ActualParameterList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ParameterizedObjectSet

		// delegate function (callback) prototype associated with syntax rule ParameterizedObjectSet
		public delegate bool ParameterizedObjectSet_Callback (SyntaxTreeCallbackReason reason, ParameterizedObjectSet.production_kind kind, ParameterizedObjectSet p_ParameterizedObjectSet);

		// event associated with syntax rule ParameterizedObjectSet
		public event ParameterizedObjectSet_Callback ParameterizedObjectSet_Event;

		// event trigger associated with syntax rule ParameterizedObjectSet
		public bool Raise_ParameterizedObjectSet_Event (SyntaxTreeCallbackReason reason, ParameterizedObjectSet.production_kind kind, ParameterizedObjectSet p_ParameterizedObjectSet)
		{
			bool? status = ParameterizedObjectSet_Event?.Invoke (reason, kind, p_ParameterizedObjectSet);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ParameterizedObjectSet
		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedObjectSet
		//

		public void Traverse (ParameterizedObjectSet p_ParameterizedObjectSet)
		{
			if (p_ParameterizedObjectSet.isLocked())
				return;
			p_ParameterizedObjectSet.dolock();
			ParameterizedObjectSet.production_kind kind = (ParameterizedObjectSet.production_kind) p_ParameterizedObjectSet.kind;
			p_ParameterizedObjectSet.turn_reset ();
			if (Raise_ParameterizedObjectSet_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ParameterizedObjectSet))
			switch (kind)
			{
				case ParameterizedObjectSet.production_kind.g_ParameterizedObjectSet_1:
					// traverse syntax tree node associated with production
					// ParameterizedObjectSet: DefinedObjectSet ActualParameterList

					if (Raise_ParameterizedObjectSet_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectSet))
						Traverse (p_ParameterizedObjectSet.m_DefinedObjectSet);
					p_ParameterizedObjectSet.turn_inc ();
					if (Raise_ParameterizedObjectSet_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectSet))
						Traverse (p_ParameterizedObjectSet.m_ActualParameterList);
					p_ParameterizedObjectSet.turn_inc ();
					Raise_ParameterizedObjectSet_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectSet);
				break;
			}
			Raise_ParameterizedObjectSet_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ParameterizedObjectSet);
			p_ParameterizedObjectSet.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedObjectSet
		//

		public void TraverseCommon (ParameterizedObjectSet p_ParameterizedObjectSet)
		{
			ParameterizedObjectSet.production_kind kind = (ParameterizedObjectSet.production_kind) p_ParameterizedObjectSet.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ParameterizedObjectSet))
			switch (kind)
			{
				case ParameterizedObjectSet.production_kind.g_ParameterizedObjectSet_1:
					// traverse syntax tree node associated with production
					// ParameterizedObjectSet: DefinedObjectSet ActualParameterList

						TraverseCommon (p_ParameterizedObjectSet.m_DefinedObjectSet);
						TraverseCommon (p_ParameterizedObjectSet.m_ActualParameterList);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ParameterizedObjectSet);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ParameterizedObjectSet

		//
		// create syntax tree node associated with production
		// ParameterizedObjectSet: DefinedObjectSet ActualParameterList

		//

		public ParameterizedObjectSet ParameterizedObjectSet_1 (DefinedObjectSet p_DefinedObjectSet, ActualParameterList p_ActualParameterList)
		{
			ParameterizedObjectSet p_ParameterizedObjectSet_ref = new ParameterizedObjectSet(p_DefinedObjectSet, p_ActualParameterList);
			p_DefinedObjectSet.parent = p_ParameterizedObjectSet_ref;
			p_ActualParameterList.parent = p_ParameterizedObjectSet_ref;
			Raise_ParameterizedObjectSet_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedObjectSet.production_kind.g_ParameterizedObjectSet_1, p_ParameterizedObjectSet_ref);
			return p_ParameterizedObjectSet_ref;
		}
		#endregion
	};
}
