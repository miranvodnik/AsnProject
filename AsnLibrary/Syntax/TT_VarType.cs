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
	// class associated with syntax rule TT-VarType
	//

	[DataContract]
	public class	TT_VarType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TT-VarType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TT-VarType
		{
			g_TT_VarType_1 = 1,	// Value

		};
		#endregion
		#region production markers associated with the syntax rule TT-VarType

		// markers associated with production: TT-VarType -> Value

		public enum production_marker_1 : ushort
		{
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TT-VarType

		// Constructor declaration(s) associated with production(s) of syntax rule TT-VarType

		//
		// Constructor associated with the following production(s)
		// TT-VarType -> Value

		//

		public TT_VarType (Value p_Value) : base ((uint) ProductionID._TT_VarType_ID, (uint) production_kind.g_TT_VarType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Value = p_Value;
		}

		public TT_VarType () { }

		// Copy constructor

		public TT_VarType (TT_VarType p_TT_VarType) : base (p_TT_VarType.id, p_TT_VarType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TT_VarType.appInfo;
			switch ((production_kind) p_TT_VarType.kind)
			{
				case production_kind.g_TT_VarType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Value = (p_TT_VarType.m_Value != null) ? new Value (p_TT_VarType.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TT_VarType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TT_VarType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TT-VarType

		// Content changing function(s) associated with production(s) of syntax rule TT-VarType

		//
		// Content changing function associated with following production(s)
		// TT-VarType -> Value

		//

		public void change(Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_TT_VarType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TT-VarType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TT-VarType

		//
		// emit production tree node associated with any production of syntax rule TT-VarType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TT_VarType_1:
					// emit syntax tree node associated with production
					// TT-VarType: Value

					s += m_Value.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TT-VarType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TT_VarType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TT_VarType_1:
					// emit syntax tree node associated with production
					// TT-VarType: Value

					s += m_Value.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TT-VarType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TT-VarType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TT_VarType.production_kind kind = (TT_VarType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TT_VarType.production_kind.g_TT_VarType_1:
					// traverse syntax tree node associated with production
					// TT-VarType: Value

						m_Value.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Value?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TT-VarType
		//

		public void _init ()
		{
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TT-VarType

		// counter of all nodes associated with syntax rule TT-VarType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TT-VarType
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TT-VarType

		// delegate function (callback) prototype associated with syntax rule TT-VarType
		public delegate bool TT_VarType_Callback (SyntaxTreeCallbackReason reason, TT_VarType.production_kind kind, TT_VarType p_TT_VarType);

		// event associated with syntax rule TT-VarType
		public event TT_VarType_Callback TT_VarType_Event;

		// event trigger associated with syntax rule TT-VarType
		public bool Raise_TT_VarType_Event (SyntaxTreeCallbackReason reason, TT_VarType.production_kind kind, TT_VarType p_TT_VarType)
		{
			bool? status = TT_VarType_Event?.Invoke (reason, kind, p_TT_VarType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TT-VarType
		//
		// traverse syntax tree node associated with any production of syntax rule TT-VarType
		//

		public void Traverse (TT_VarType p_TT_VarType)
		{
			if (p_TT_VarType.isLocked())
				return;
			p_TT_VarType.dolock();
			TT_VarType.production_kind kind = (TT_VarType.production_kind) p_TT_VarType.kind;
			p_TT_VarType.turn_reset ();
			if (Raise_TT_VarType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TT_VarType))
			switch (kind)
			{
				case TT_VarType.production_kind.g_TT_VarType_1:
					// traverse syntax tree node associated with production
					// TT-VarType: Value

					if (Raise_TT_VarType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TT_VarType))
						Traverse (p_TT_VarType.m_Value);
					p_TT_VarType.turn_inc ();
					Raise_TT_VarType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TT_VarType);
				break;
			}
			Raise_TT_VarType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TT_VarType);
			p_TT_VarType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TT-VarType
		//

		public void TraverseCommon (TT_VarType p_TT_VarType)
		{
			TT_VarType.production_kind kind = (TT_VarType.production_kind) p_TT_VarType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TT_VarType))
			switch (kind)
			{
				case TT_VarType.production_kind.g_TT_VarType_1:
					// traverse syntax tree node associated with production
					// TT-VarType: Value

						TraverseCommon (p_TT_VarType.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TT_VarType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TT-VarType

		//
		// create syntax tree node associated with production
		// TT-VarType: Value

		//

		public TT_VarType TT_VarType_1 (Value p_Value)
		{
			TT_VarType p_TT_VarType_ref = new TT_VarType(p_Value);
			p_Value.parent = p_TT_VarType_ref;
			Raise_TT_VarType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TT_VarType.production_kind.g_TT_VarType_1, p_TT_VarType_ref);
			return p_TT_VarType_ref;
		}
		#endregion
	};
}
