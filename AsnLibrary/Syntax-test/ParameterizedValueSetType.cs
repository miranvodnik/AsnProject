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
	// class associated with syntax rule ParameterizedValueSetType
	//

	[DataContract]
	public class	ParameterizedValueSetType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ParameterizedValueSetType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ParameterizedValueSetType
		{
			g_ParameterizedValueSetType_1 = 1,	// SimpleDefinedType ActualParameterList

		};
		#endregion
		#region production markers associated with the syntax rule ParameterizedValueSetType

		// markers associated with production: ParameterizedValueSetType -> SimpleDefinedType ActualParameterList

		public enum production_marker_1 : ushort
		{
			m_SimpleDefinedType,
			m_ActualParameterList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ParameterizedValueSetType

		// Constructor declaration(s) associated with production(s) of syntax rule ParameterizedValueSetType

		//
		// Constructor associated with the following production(s)
		// ParameterizedValueSetType -> SimpleDefinedType ActualParameterList

		//

		public ParameterizedValueSetType (SimpleDefinedType p_SimpleDefinedType, ActualParameterList p_ActualParameterList) : base ((uint) ProductionID._ParameterizedValueSetType_ID, (uint) production_kind.g_ParameterizedValueSetType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_SimpleDefinedType = p_SimpleDefinedType;
			children[1] = m_ActualParameterList = p_ActualParameterList;
		}

		public ParameterizedValueSetType () { }

		// Copy constructor

		public ParameterizedValueSetType (ParameterizedValueSetType p_ParameterizedValueSetType) : base (p_ParameterizedValueSetType.id, p_ParameterizedValueSetType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ParameterizedValueSetType.appInfo;
			switch ((production_kind) p_ParameterizedValueSetType.kind)
			{
				case production_kind.g_ParameterizedValueSetType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_SimpleDefinedType = (p_ParameterizedValueSetType.m_SimpleDefinedType != null) ? new SimpleDefinedType (p_ParameterizedValueSetType.m_SimpleDefinedType) : null) != null) m_SimpleDefinedType.parent = this;
					if ((children [1] = m_ActualParameterList = (p_ParameterizedValueSetType.m_ActualParameterList != null) ? new ActualParameterList (p_ParameterizedValueSetType.m_ActualParameterList) : null) != null) m_ActualParameterList.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ParameterizedValueSetType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ParameterizedValueSetType (this); }

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
		#region Content changing and inclusion checking methods associated with the syntax rule ParameterizedValueSetType

		// Content changing function(s) associated with production(s) of syntax rule ParameterizedValueSetType

		//
		// Content changing function associated with following production(s)
		// ParameterizedValueSetType -> SimpleDefinedType ActualParameterList

		//

		public void change(SimpleDefinedType p_SimpleDefinedType, ActualParameterList p_ActualParameterList)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedValueSetType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_SimpleDefinedType = p_SimpleDefinedType;
			children [1] = m_ActualParameterList = p_ActualParameterList;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ParameterizedValueSetType
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
		#region Syntax tree emit methods associated with the syntax rule ParameterizedValueSetType

		//
		// emit production tree node associated with any production of syntax rule ParameterizedValueSetType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ParameterizedValueSetType_1:
					// emit syntax tree node associated with production
					// ParameterizedValueSetType: SimpleDefinedType ActualParameterList

					s += m_SimpleDefinedType.Emit (depth - 1);
					s += " ";
					s += m_ActualParameterList.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ParameterizedValueSetType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ParameterizedValueSetType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ParameterizedValueSetType_1:
					// emit syntax tree node associated with production
					// ParameterizedValueSetType: SimpleDefinedType ActualParameterList

					s += m_SimpleDefinedType.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ActualParameterList.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ParameterizedValueSetType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedValueSetType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ParameterizedValueSetType.production_kind kind = (ParameterizedValueSetType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ParameterizedValueSetType.production_kind.g_ParameterizedValueSetType_1:
					// traverse syntax tree node associated with production
					// ParameterizedValueSetType: SimpleDefinedType ActualParameterList

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
		// initialize object associated with syntax rule ParameterizedValueSetType
		//

		public void _init ()
		{
			m_SimpleDefinedType = null;
			m_ActualParameterList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ParameterizedValueSetType

		// counter of all nodes associated with syntax rule ParameterizedValueSetType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ParameterizedValueSetType
		[DataMember (Name = "m_SimpleDefinedType")] public SimpleDefinedType m_SimpleDefinedType { get; private set; }
		[DataMember (Name = "m_ActualParameterList")] public ActualParameterList m_ActualParameterList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ParameterizedValueSetType

		// delegate function (callback) prototype associated with syntax rule ParameterizedValueSetType
		public delegate bool ParameterizedValueSetType_Callback (SyntaxTreeCallbackReason reason, ParameterizedValueSetType.production_kind kind, ParameterizedValueSetType p_ParameterizedValueSetType);

		// event associated with syntax rule ParameterizedValueSetType
		public event ParameterizedValueSetType_Callback ParameterizedValueSetType_Event;

		// event trigger associated with syntax rule ParameterizedValueSetType
		public bool Raise_ParameterizedValueSetType_Event (SyntaxTreeCallbackReason reason, ParameterizedValueSetType.production_kind kind, ParameterizedValueSetType p_ParameterizedValueSetType)
		{
			bool? status = ParameterizedValueSetType_Event?.Invoke (reason, kind, p_ParameterizedValueSetType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ParameterizedValueSetType
		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedValueSetType
		//

		public void Traverse (ParameterizedValueSetType p_ParameterizedValueSetType)
		{
			if (p_ParameterizedValueSetType.isLocked())
				return;
			p_ParameterizedValueSetType.dolock();
			ParameterizedValueSetType.production_kind kind = (ParameterizedValueSetType.production_kind) p_ParameterizedValueSetType.kind;
			p_ParameterizedValueSetType.turn_reset ();
			if (Raise_ParameterizedValueSetType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ParameterizedValueSetType))
			switch (kind)
			{
				case ParameterizedValueSetType.production_kind.g_ParameterizedValueSetType_1:
					// traverse syntax tree node associated with production
					// ParameterizedValueSetType: SimpleDefinedType ActualParameterList

					if (Raise_ParameterizedValueSetType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedValueSetType))
						Traverse (p_ParameterizedValueSetType.m_SimpleDefinedType);
					p_ParameterizedValueSetType.turn_inc ();
					if (Raise_ParameterizedValueSetType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedValueSetType))
						Traverse (p_ParameterizedValueSetType.m_ActualParameterList);
					p_ParameterizedValueSetType.turn_inc ();
					Raise_ParameterizedValueSetType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedValueSetType);
				break;
			}
			Raise_ParameterizedValueSetType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ParameterizedValueSetType);
			p_ParameterizedValueSetType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedValueSetType
		//

		public void TraverseCommon (ParameterizedValueSetType p_ParameterizedValueSetType)
		{
			ParameterizedValueSetType.production_kind kind = (ParameterizedValueSetType.production_kind) p_ParameterizedValueSetType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ParameterizedValueSetType))
			switch (kind)
			{
				case ParameterizedValueSetType.production_kind.g_ParameterizedValueSetType_1:
					// traverse syntax tree node associated with production
					// ParameterizedValueSetType: SimpleDefinedType ActualParameterList

						TraverseCommon (p_ParameterizedValueSetType.m_SimpleDefinedType);
						TraverseCommon (p_ParameterizedValueSetType.m_ActualParameterList);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ParameterizedValueSetType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ParameterizedValueSetType

		//
		// create syntax tree node associated with production
		// ParameterizedValueSetType: SimpleDefinedType ActualParameterList

		//

		public ParameterizedValueSetType ParameterizedValueSetType_1 (SimpleDefinedType p_SimpleDefinedType, ActualParameterList p_ActualParameterList)
		{
			ParameterizedValueSetType p_ParameterizedValueSetType_ref = new ParameterizedValueSetType(p_SimpleDefinedType, p_ActualParameterList);
			p_SimpleDefinedType.parent = p_ParameterizedValueSetType_ref;
			p_ActualParameterList.parent = p_ParameterizedValueSetType_ref;
			Raise_ParameterizedValueSetType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedValueSetType.production_kind.g_ParameterizedValueSetType_1, p_ParameterizedValueSetType_ref);
			return p_ParameterizedValueSetType_ref;
		}
		#endregion
	};
}
