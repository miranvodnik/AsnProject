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
	// class associated with syntax rule Value
	//

	[DataContract]
	public class	Value : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Value
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Value
		{
			g_Value_1 = 1,	// BuiltinValue

			g_Value_2 = 2,	// ReferencedValue

			g_Value_3 = 3,	// OpenTypeFieldVal

		};
		#endregion
		#region production markers associated with the syntax rule Value

		// markers associated with production: Value -> BuiltinValue

		public enum production_marker_1 : ushort
		{
			m_BuiltinValue,
			final
		};

		// markers associated with production: Value -> ReferencedValue

		public enum production_marker_2 : ushort
		{
			m_ReferencedValue,
			final
		};

		// markers associated with production: Value -> OpenTypeFieldVal

		public enum production_marker_3 : ushort
		{
			m_OpenTypeFieldVal,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Value

		// Constructor declaration(s) associated with production(s) of syntax rule Value

		//
		// Constructor associated with the following production(s)
		// Value -> BuiltinValue

		//

		public Value (BuiltinValue p_BuiltinValue) : base ((uint) ProductionID._Value_ID, (uint) production_kind.g_Value_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_BuiltinValue = p_BuiltinValue;
		}

		//
		// Constructor associated with the following production(s)
		// Value -> ReferencedValue

		//

		public Value (ReferencedValue p_ReferencedValue) : base ((uint) ProductionID._Value_ID, (uint) production_kind.g_Value_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ReferencedValue = p_ReferencedValue;
		}

		//
		// Constructor associated with the following production(s)
		// Value -> OpenTypeFieldVal

		//

		public Value (OpenTypeFieldVal p_OpenTypeFieldVal) : base ((uint) ProductionID._Value_ID, (uint) production_kind.g_Value_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_OpenTypeFieldVal = p_OpenTypeFieldVal;
		}

		public Value () { }

		// Copy constructor

		public Value (Value p_Value) : base (p_Value.id, p_Value.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Value.appInfo;
			switch ((production_kind) p_Value.kind)
			{
				case production_kind.g_Value_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_BuiltinValue = (p_Value.m_BuiltinValue != null) ? new BuiltinValue (p_Value.m_BuiltinValue) : null) != null) m_BuiltinValue.parent = this;
					break;
				case production_kind.g_Value_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ReferencedValue = (p_Value.m_ReferencedValue != null) ? new ReferencedValue (p_Value.m_ReferencedValue) : null) != null) m_ReferencedValue.parent = this;
					break;
				case production_kind.g_Value_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OpenTypeFieldVal = (p_Value.m_OpenTypeFieldVal != null) ? new OpenTypeFieldVal (p_Value.m_OpenTypeFieldVal) : null) != null) m_OpenTypeFieldVal.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Value" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Value (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_BuiltinValue?.Dispose ();
			m_ReferencedValue?.Dispose ();
			m_OpenTypeFieldVal?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Value

		// Content changing function(s) associated with production(s) of syntax rule Value

		//
		// Content changing function associated with following production(s)
		// Value -> BuiltinValue

		//

		public void change(BuiltinValue p_BuiltinValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_Value_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_BuiltinValue = p_BuiltinValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Value -> ReferencedValue

		//

		public void change(ReferencedValue p_ReferencedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_Value_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ReferencedValue = p_ReferencedValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Value -> OpenTypeFieldVal

		//

		public void change(OpenTypeFieldVal p_OpenTypeFieldVal)
		{
			_init ();
			this.kind = (uint) production_kind.g_Value_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_OpenTypeFieldVal = p_OpenTypeFieldVal;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Value
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_BuiltinValue != null) && m_BuiltinValue.checkInclusion (element) ||
				(m_ReferencedValue != null) && m_ReferencedValue.checkInclusion (element) ||
				(m_OpenTypeFieldVal != null) && m_OpenTypeFieldVal.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Value

		//
		// emit production tree node associated with any production of syntax rule Value
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Value_1:
					// emit syntax tree node associated with production
					// Value: BuiltinValue

					s += m_BuiltinValue.Emit (depth - 1);
				break;
				case production_kind.g_Value_2:
					// emit syntax tree node associated with production
					// Value: ReferencedValue

					s += m_ReferencedValue.Emit (depth - 1);
				break;
				case production_kind.g_Value_3:
					// emit syntax tree node associated with production
					// Value: OpenTypeFieldVal

					s += m_OpenTypeFieldVal.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Value
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Value (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Value_1:
					// emit syntax tree node associated with production
					// Value: BuiltinValue

					s += m_BuiltinValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Value_2:
					// emit syntax tree node associated with production
					// Value: ReferencedValue

					s += m_ReferencedValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Value_3:
					// emit syntax tree node associated with production
					// Value: OpenTypeFieldVal

					s += m_OpenTypeFieldVal.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Value

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Value with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Value.production_kind kind = (Value.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Value.production_kind.g_Value_1:
					// traverse syntax tree node associated with production
					// Value: BuiltinValue

						m_BuiltinValue.Visit (visitor, appData);
				break;
				case Value.production_kind.g_Value_2:
					// traverse syntax tree node associated with production
					// Value: ReferencedValue

						m_ReferencedValue.Visit (visitor, appData);
				break;
				case Value.production_kind.g_Value_3:
					// traverse syntax tree node associated with production
					// Value: OpenTypeFieldVal

						m_OpenTypeFieldVal.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_BuiltinValue?.reparent (this);
			m_ReferencedValue?.reparent (this);
			m_OpenTypeFieldVal?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Value
		//

		public void _init ()
		{
			m_BuiltinValue = null;
			m_ReferencedValue = null;
			m_OpenTypeFieldVal = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Value

		// counter of all nodes associated with syntax rule Value
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Value
		[DataMember (Name = "m_BuiltinValue")] public BuiltinValue m_BuiltinValue { get; private set; }
		[DataMember (Name = "m_ReferencedValue")] public ReferencedValue m_ReferencedValue { get; private set; }
		[DataMember (Name = "m_OpenTypeFieldVal")] public OpenTypeFieldVal m_OpenTypeFieldVal { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Value

		// delegate function (callback) prototype associated with syntax rule Value
		public delegate bool Value_Callback (SyntaxTreeCallbackReason reason, Value.production_kind kind, Value p_Value);

		// event associated with syntax rule Value
		public event Value_Callback Value_Event;

		// event trigger associated with syntax rule Value
		public bool Raise_Value_Event (SyntaxTreeCallbackReason reason, Value.production_kind kind, Value p_Value)
		{
			bool? status = Value_Event?.Invoke (reason, kind, p_Value);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Value
		//
		// traverse syntax tree node associated with any production of syntax rule Value
		//

		public void Traverse (Value p_Value)
		{
			if (p_Value.isLocked())
				return;
			p_Value.dolock();
			Value.production_kind kind = (Value.production_kind) p_Value.kind;
			p_Value.turn_reset ();
			if (Raise_Value_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Value))
			switch (kind)
			{
				case Value.production_kind.g_Value_1:
					// traverse syntax tree node associated with production
					// Value: BuiltinValue

					if (Raise_Value_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Value))
						Traverse (p_Value.m_BuiltinValue);
					p_Value.turn_inc ();
					Raise_Value_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Value);
				break;
				case Value.production_kind.g_Value_2:
					// traverse syntax tree node associated with production
					// Value: ReferencedValue

					if (Raise_Value_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Value))
						Traverse (p_Value.m_ReferencedValue);
					p_Value.turn_inc ();
					Raise_Value_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Value);
				break;
				case Value.production_kind.g_Value_3:
					// traverse syntax tree node associated with production
					// Value: OpenTypeFieldVal

					if (Raise_Value_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Value))
						Traverse (p_Value.m_OpenTypeFieldVal);
					p_Value.turn_inc ();
					Raise_Value_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Value);
				break;
			}
			Raise_Value_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Value);
			p_Value.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Value
		//

		public void TraverseCommon (Value p_Value)
		{
			Value.production_kind kind = (Value.production_kind) p_Value.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Value))
			switch (kind)
			{
				case Value.production_kind.g_Value_1:
					// traverse syntax tree node associated with production
					// Value: BuiltinValue

						TraverseCommon (p_Value.m_BuiltinValue);
				break;
				case Value.production_kind.g_Value_2:
					// traverse syntax tree node associated with production
					// Value: ReferencedValue

						TraverseCommon (p_Value.m_ReferencedValue);
				break;
				case Value.production_kind.g_Value_3:
					// traverse syntax tree node associated with production
					// Value: OpenTypeFieldVal

						TraverseCommon (p_Value.m_OpenTypeFieldVal);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Value);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Value

		//
		// create syntax tree node associated with production
		// Value: BuiltinValue

		//

		public Value Value_1 (BuiltinValue p_BuiltinValue)
		{
			Value p_Value_ref = new Value(p_BuiltinValue);
			p_BuiltinValue.parent = p_Value_ref;
			Raise_Value_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Value.production_kind.g_Value_1, p_Value_ref);
			return p_Value_ref;
		}

		//
		// create syntax tree node associated with production
		// Value: ReferencedValue

		//

		public Value Value_2 (ReferencedValue p_ReferencedValue)
		{
			Value p_Value_ref = new Value(p_ReferencedValue);
			p_ReferencedValue.parent = p_Value_ref;
			Raise_Value_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Value.production_kind.g_Value_2, p_Value_ref);
			return p_Value_ref;
		}

		//
		// create syntax tree node associated with production
		// Value: OpenTypeFieldVal

		//

		public Value Value_3 (OpenTypeFieldVal p_OpenTypeFieldVal)
		{
			Value p_Value_ref = new Value(p_OpenTypeFieldVal);
			p_OpenTypeFieldVal.parent = p_Value_ref;
			Raise_Value_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Value.production_kind.g_Value_3, p_Value_ref);
			return p_Value_ref;
		}
		#endregion
	};
}
