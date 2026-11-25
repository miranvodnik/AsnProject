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
	// class associated with syntax rule ParameterizedType
	//

	[DataContract]
	public class	ParameterizedType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ParameterizedType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ParameterizedType
		{
			g_ParameterizedType_1 = 1,	// SimpleDefinedType ActualParameterList

		};
		#endregion
		#region production markers associated with the syntax rule ParameterizedType

		// markers associated with production: ParameterizedType -> SimpleDefinedType ActualParameterList

		public enum production_marker_1 : ushort
		{
			m_SimpleDefinedType,
			m_ActualParameterList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ParameterizedType

		// Constructor declaration(s) associated with production(s) of syntax rule ParameterizedType

		//
		// Constructor associated with the following production(s)
		// ParameterizedType -> SimpleDefinedType ActualParameterList

		//

		public ParameterizedType (SimpleDefinedType p_SimpleDefinedType, ActualParameterList p_ActualParameterList) : base ((uint) ProductionID._ParameterizedType_ID, (uint) production_kind.g_ParameterizedType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_SimpleDefinedType = p_SimpleDefinedType;
			children[1] = m_ActualParameterList = p_ActualParameterList;
		}

		public ParameterizedType () { }

		// Copy constructor

		public ParameterizedType (ParameterizedType p_ParameterizedType) : base (p_ParameterizedType.id, p_ParameterizedType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ParameterizedType.appInfo;
			switch ((production_kind) p_ParameterizedType.kind)
			{
				case production_kind.g_ParameterizedType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_SimpleDefinedType = (p_ParameterizedType.m_SimpleDefinedType != null) ? new SimpleDefinedType (p_ParameterizedType.m_SimpleDefinedType) : null) != null) m_SimpleDefinedType.parent = this;
					if ((children [1] = m_ActualParameterList = (p_ParameterizedType.m_ActualParameterList != null) ? new ActualParameterList (p_ParameterizedType.m_ActualParameterList) : null) != null) m_ActualParameterList.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ParameterizedType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ParameterizedType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SimpleDefinedType?.Dispose ();
			m_ActualParameterList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ParameterizedType

		// Content changing function(s) associated with production(s) of syntax rule ParameterizedType

		//
		// Content changing function associated with following production(s)
		// ParameterizedType -> SimpleDefinedType ActualParameterList

		//

		public void change(SimpleDefinedType p_SimpleDefinedType, ActualParameterList p_ActualParameterList)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_SimpleDefinedType = p_SimpleDefinedType;
			children [1] = m_ActualParameterList = p_ActualParameterList;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ParameterizedType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SimpleDefinedType != null) && m_SimpleDefinedType.checkInclusion (element) ||
				(m_ActualParameterList != null) && m_ActualParameterList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ParameterizedType

		//
		// emit production tree node associated with any production of syntax rule ParameterizedType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ParameterizedType_1:
					// emit syntax tree node associated with production
					// ParameterizedType: SimpleDefinedType ActualParameterList

					s += m_SimpleDefinedType.Emit (depth - 1);
					s += " ";
					s += m_ActualParameterList.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ParameterizedType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ParameterizedType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ParameterizedType_1:
					// emit syntax tree node associated with production
					// ParameterizedType: SimpleDefinedType ActualParameterList

					s += m_SimpleDefinedType.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ActualParameterList.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ParameterizedType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ParameterizedType.production_kind kind = (ParameterizedType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ParameterizedType.production_kind.g_ParameterizedType_1:
					// traverse syntax tree node associated with production
					// ParameterizedType: SimpleDefinedType ActualParameterList

						m_SimpleDefinedType.Visit (visitor, appData);
						m_ActualParameterList.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SimpleDefinedType?.reparent (this);
			m_ActualParameterList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ParameterizedType
		//

		public void _init ()
		{
			m_SimpleDefinedType = null;
			m_ActualParameterList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ParameterizedType

		// counter of all nodes associated with syntax rule ParameterizedType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ParameterizedType
		[DataMember (Name = "m_SimpleDefinedType")] public SimpleDefinedType m_SimpleDefinedType { get; private set; }
		[DataMember (Name = "m_ActualParameterList")] public ActualParameterList m_ActualParameterList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ParameterizedType

		// delegate function (callback) prototype associated with syntax rule ParameterizedType
		public delegate bool ParameterizedType_Callback (SyntaxTreeCallbackReason reason, ParameterizedType.production_kind kind, ParameterizedType p_ParameterizedType);

		// event associated with syntax rule ParameterizedType
		public event ParameterizedType_Callback ParameterizedType_Event;

		// event trigger associated with syntax rule ParameterizedType
		public bool Raise_ParameterizedType_Event (SyntaxTreeCallbackReason reason, ParameterizedType.production_kind kind, ParameterizedType p_ParameterizedType)
		{
			bool? status = ParameterizedType_Event?.Invoke (reason, kind, p_ParameterizedType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ParameterizedType
		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedType
		//

		public void Traverse (ParameterizedType p_ParameterizedType)
		{
			if (p_ParameterizedType.isLocked())
				return;
			p_ParameterizedType.dolock();
			ParameterizedType.production_kind kind = (ParameterizedType.production_kind) p_ParameterizedType.kind;
			p_ParameterizedType.turn_reset ();
			if (Raise_ParameterizedType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ParameterizedType))
			switch (kind)
			{
				case ParameterizedType.production_kind.g_ParameterizedType_1:
					// traverse syntax tree node associated with production
					// ParameterizedType: SimpleDefinedType ActualParameterList

					if (Raise_ParameterizedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedType))
						Traverse (p_ParameterizedType.m_SimpleDefinedType);
					p_ParameterizedType.turn_inc ();
					if (Raise_ParameterizedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedType))
						Traverse (p_ParameterizedType.m_ActualParameterList);
					p_ParameterizedType.turn_inc ();
					Raise_ParameterizedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedType);
				break;
			}
			Raise_ParameterizedType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ParameterizedType);
			p_ParameterizedType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedType
		//

		public void TraverseCommon (ParameterizedType p_ParameterizedType)
		{
			ParameterizedType.production_kind kind = (ParameterizedType.production_kind) p_ParameterizedType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ParameterizedType))
			switch (kind)
			{
				case ParameterizedType.production_kind.g_ParameterizedType_1:
					// traverse syntax tree node associated with production
					// ParameterizedType: SimpleDefinedType ActualParameterList

						TraverseCommon (p_ParameterizedType.m_SimpleDefinedType);
						TraverseCommon (p_ParameterizedType.m_ActualParameterList);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ParameterizedType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ParameterizedType

		//
		// create syntax tree node associated with production
		// ParameterizedType: SimpleDefinedType ActualParameterList

		//

		public ParameterizedType ParameterizedType_1 (SimpleDefinedType p_SimpleDefinedType, ActualParameterList p_ActualParameterList)
		{
			ParameterizedType p_ParameterizedType_ref = new ParameterizedType(p_SimpleDefinedType, p_ActualParameterList);
			p_SimpleDefinedType.parent = p_ParameterizedType_ref;
			p_ActualParameterList.parent = p_ParameterizedType_ref;
			Raise_ParameterizedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedType.production_kind.g_ParameterizedType_1, p_ParameterizedType_ref);
			return p_ParameterizedType_ref;
		}
		#endregion
	};
}
