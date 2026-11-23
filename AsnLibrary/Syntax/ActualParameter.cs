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
	// class associated with syntax rule ActualParameter
	//

	[DataContract]
	public class	ActualParameter : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ActualParameter
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ActualParameter
		{
			g_ActualParameter_1 = 1,	// Type

			g_ActualParameter_2 = 2,	// Value

			g_ActualParameter_3 = 3,	// ValueSet

			g_ActualParameter_4 = 4,	// DefinedObjectClass

			g_ActualParameter_5 = 5,	// Object

			g_ActualParameter_6 = 6,	// ObjectSet

		};
		#endregion
		#region production markers associated with the syntax rule ActualParameter

		// markers associated with production: ActualParameter -> Type

		public enum production_marker_1 : ushort
		{
			m_Type,
			final
		};

		// markers associated with production: ActualParameter -> Value

		public enum production_marker_2 : ushort
		{
			m_Value,
			final
		};

		// markers associated with production: ActualParameter -> ValueSet

		public enum production_marker_3 : ushort
		{
			m_ValueSet,
			final
		};

		// markers associated with production: ActualParameter -> DefinedObjectClass

		public enum production_marker_4 : ushort
		{
			m_DefinedObjectClass,
			final
		};

		// markers associated with production: ActualParameter -> Object

		public enum production_marker_5 : ushort
		{
			m_Object,
			final
		};

		// markers associated with production: ActualParameter -> ObjectSet

		public enum production_marker_6 : ushort
		{
			m_ObjectSet,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ActualParameter

		// Constructor declaration(s) associated with production(s) of syntax rule ActualParameter

		//
		// Constructor associated with the following production(s)
		// ActualParameter -> Type

		//

		public ActualParameter (Type p_Type) : base ((uint) ProductionID._ActualParameter_ID, (uint) production_kind.g_ActualParameter_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Type = p_Type;
		}

		//
		// Constructor associated with the following production(s)
		// ActualParameter -> Value

		//

		public ActualParameter (Value p_Value) : base ((uint) ProductionID._ActualParameter_ID, (uint) production_kind.g_ActualParameter_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Value = p_Value;
		}

		//
		// Constructor associated with the following production(s)
		// ActualParameter -> ValueSet

		//

		public ActualParameter (ValueSet p_ValueSet) : base ((uint) ProductionID._ActualParameter_ID, (uint) production_kind.g_ActualParameter_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ValueSet = p_ValueSet;
		}

		//
		// Constructor associated with the following production(s)
		// ActualParameter -> DefinedObjectClass

		//

		public ActualParameter (DefinedObjectClass p_DefinedObjectClass) : base ((uint) ProductionID._ActualParameter_ID, (uint) production_kind.g_ActualParameter_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinedObjectClass = p_DefinedObjectClass;
		}

		//
		// Constructor associated with the following production(s)
		// ActualParameter -> Object

		//

		public ActualParameter (Object p_Object) : base ((uint) ProductionID._ActualParameter_ID, (uint) production_kind.g_ActualParameter_5)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Object = p_Object;
		}

		//
		// Constructor associated with the following production(s)
		// ActualParameter -> ObjectSet

		//

		public ActualParameter (ObjectSet p_ObjectSet) : base ((uint) ProductionID._ActualParameter_ID, (uint) production_kind.g_ActualParameter_6)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjectSet = p_ObjectSet;
		}

		public ActualParameter () { }

		// Copy constructor

		public ActualParameter (ActualParameter p_ActualParameter) : base (p_ActualParameter.id, p_ActualParameter.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ActualParameter.appInfo;
			switch ((production_kind) p_ActualParameter.kind)
			{
				case production_kind.g_ActualParameter_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Type = (p_ActualParameter.m_Type != null) ? new Type (p_ActualParameter.m_Type) : null) != null) m_Type.parent = this;
					break;
				case production_kind.g_ActualParameter_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Value = (p_ActualParameter.m_Value != null) ? new Value (p_ActualParameter.m_Value) : null) != null) m_Value.parent = this;
					break;
				case production_kind.g_ActualParameter_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ValueSet = (p_ActualParameter.m_ValueSet != null) ? new ValueSet (p_ActualParameter.m_ValueSet) : null) != null) m_ValueSet.parent = this;
					break;
				case production_kind.g_ActualParameter_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinedObjectClass = (p_ActualParameter.m_DefinedObjectClass != null) ? new DefinedObjectClass (p_ActualParameter.m_DefinedObjectClass) : null) != null) m_DefinedObjectClass.parent = this;
					break;
				case production_kind.g_ActualParameter_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Object = (p_ActualParameter.m_Object != null) ? new Object (p_ActualParameter.m_Object) : null) != null) m_Object.parent = this;
					break;
				case production_kind.g_ActualParameter_6:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectSet = (p_ActualParameter.m_ObjectSet != null) ? new ObjectSet (p_ActualParameter.m_ObjectSet) : null) != null) m_ObjectSet.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ActualParameter" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ActualParameter (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Type?.Dispose ();
			m_Value?.Dispose ();
			m_ValueSet?.Dispose ();
			m_DefinedObjectClass?.Dispose ();
			m_Object?.Dispose ();
			m_ObjectSet?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ActualParameter

		// Content changing function(s) associated with production(s) of syntax rule ActualParameter

		//
		// Content changing function associated with following production(s)
		// ActualParameter -> Type

		//

		public void change(Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_ActualParameter_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ActualParameter -> Value

		//

		public void change(Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_ActualParameter_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ActualParameter -> ValueSet

		//

		public void change(ValueSet p_ValueSet)
		{
			_init ();
			this.kind = (uint) production_kind.g_ActualParameter_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ValueSet = p_ValueSet;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ActualParameter -> DefinedObjectClass

		//

		public void change(DefinedObjectClass p_DefinedObjectClass)
		{
			_init ();
			this.kind = (uint) production_kind.g_ActualParameter_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinedObjectClass = p_DefinedObjectClass;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ActualParameter -> Object

		//

		public void change(Object p_Object)
		{
			_init ();
			this.kind = (uint) production_kind.g_ActualParameter_5;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Object = p_Object;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ActualParameter -> ObjectSet

		//

		public void change(ObjectSet p_ObjectSet)
		{
			_init ();
			this.kind = (uint) production_kind.g_ActualParameter_6;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjectSet = p_ObjectSet;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ActualParameter
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				(m_ValueSet != null) && m_ValueSet.checkInclusion (element) ||
				(m_DefinedObjectClass != null) && m_DefinedObjectClass.checkInclusion (element) ||
				(m_Object != null) && m_Object.checkInclusion (element) ||
				(m_ObjectSet != null) && m_ObjectSet.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ActualParameter

		//
		// emit production tree node associated with any production of syntax rule ActualParameter
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ActualParameter_1:
					// emit syntax tree node associated with production
					// ActualParameter: Type

					s += m_Type.Emit (depth - 1);
				break;
				case production_kind.g_ActualParameter_2:
					// emit syntax tree node associated with production
					// ActualParameter: Value

					s += m_Value.Emit (depth - 1);
				break;
				case production_kind.g_ActualParameter_3:
					// emit syntax tree node associated with production
					// ActualParameter: ValueSet

					s += m_ValueSet.Emit (depth - 1);
				break;
				case production_kind.g_ActualParameter_4:
					// emit syntax tree node associated with production
					// ActualParameter: DefinedObjectClass

					s += m_DefinedObjectClass.Emit (depth - 1);
				break;
				case production_kind.g_ActualParameter_5:
					// emit syntax tree node associated with production
					// ActualParameter: Object

					s += m_Object.Emit (depth - 1);
				break;
				case production_kind.g_ActualParameter_6:
					// emit syntax tree node associated with production
					// ActualParameter: ObjectSet

					s += m_ObjectSet.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ActualParameter
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ActualParameter (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ActualParameter_1:
					// emit syntax tree node associated with production
					// ActualParameter: Type

					s += m_Type.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ActualParameter_2:
					// emit syntax tree node associated with production
					// ActualParameter: Value

					s += m_Value.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ActualParameter_3:
					// emit syntax tree node associated with production
					// ActualParameter: ValueSet

					s += m_ValueSet.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ActualParameter_4:
					// emit syntax tree node associated with production
					// ActualParameter: DefinedObjectClass

					s += m_DefinedObjectClass.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ActualParameter_5:
					// emit syntax tree node associated with production
					// ActualParameter: Object

					s += m_Object.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ActualParameter_6:
					// emit syntax tree node associated with production
					// ActualParameter: ObjectSet

					s += m_ObjectSet.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ActualParameter

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ActualParameter with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ActualParameter.production_kind kind = (ActualParameter.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ActualParameter.production_kind.g_ActualParameter_1:
					// traverse syntax tree node associated with production
					// ActualParameter: Type

						m_Type.Visit (visitor, appData);
				break;
				case ActualParameter.production_kind.g_ActualParameter_2:
					// traverse syntax tree node associated with production
					// ActualParameter: Value

						m_Value.Visit (visitor, appData);
				break;
				case ActualParameter.production_kind.g_ActualParameter_3:
					// traverse syntax tree node associated with production
					// ActualParameter: ValueSet

						m_ValueSet.Visit (visitor, appData);
				break;
				case ActualParameter.production_kind.g_ActualParameter_4:
					// traverse syntax tree node associated with production
					// ActualParameter: DefinedObjectClass

						m_DefinedObjectClass.Visit (visitor, appData);
				break;
				case ActualParameter.production_kind.g_ActualParameter_5:
					// traverse syntax tree node associated with production
					// ActualParameter: Object

						m_Object.Visit (visitor, appData);
				break;
				case ActualParameter.production_kind.g_ActualParameter_6:
					// traverse syntax tree node associated with production
					// ActualParameter: ObjectSet

						m_ObjectSet.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Type?.reparent (this);
			m_Value?.reparent (this);
			m_ValueSet?.reparent (this);
			m_DefinedObjectClass?.reparent (this);
			m_Object?.reparent (this);
			m_ObjectSet?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ActualParameter
		//

		public void _init ()
		{
			m_Type = null;
			m_Value = null;
			m_ValueSet = null;
			m_DefinedObjectClass = null;
			m_Object = null;
			m_ObjectSet = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ActualParameter

		// counter of all nodes associated with syntax rule ActualParameter
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ActualParameter
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		[DataMember (Name = "m_ValueSet")] public ValueSet m_ValueSet { get; private set; }
		[DataMember (Name = "m_DefinedObjectClass")] public DefinedObjectClass m_DefinedObjectClass { get; private set; }
		[DataMember (Name = "m_Object")] public Object m_Object { get; private set; }
		[DataMember (Name = "m_ObjectSet")] public ObjectSet m_ObjectSet { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ActualParameter

		// delegate function (callback) prototype associated with syntax rule ActualParameter
		public delegate bool ActualParameter_Callback (SyntaxTreeCallbackReason reason, ActualParameter.production_kind kind, ActualParameter p_ActualParameter);

		// event associated with syntax rule ActualParameter
		public event ActualParameter_Callback ActualParameter_Event;

		// event trigger associated with syntax rule ActualParameter
		public bool Raise_ActualParameter_Event (SyntaxTreeCallbackReason reason, ActualParameter.production_kind kind, ActualParameter p_ActualParameter)
		{
			bool? status = ActualParameter_Event?.Invoke (reason, kind, p_ActualParameter);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ActualParameter
		//
		// traverse syntax tree node associated with any production of syntax rule ActualParameter
		//

		public void Traverse (ActualParameter p_ActualParameter)
		{
			if (p_ActualParameter.isLocked())
				return;
			p_ActualParameter.dolock();
			ActualParameter.production_kind kind = (ActualParameter.production_kind) p_ActualParameter.kind;
			p_ActualParameter.turn_reset ();
			if (Raise_ActualParameter_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ActualParameter))
			switch (kind)
			{
				case ActualParameter.production_kind.g_ActualParameter_1:
					// traverse syntax tree node associated with production
					// ActualParameter: Type

					if (Raise_ActualParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ActualParameter))
						Traverse (p_ActualParameter.m_Type);
					p_ActualParameter.turn_inc ();
					Raise_ActualParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ActualParameter);
				break;
				case ActualParameter.production_kind.g_ActualParameter_2:
					// traverse syntax tree node associated with production
					// ActualParameter: Value

					if (Raise_ActualParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ActualParameter))
						Traverse (p_ActualParameter.m_Value);
					p_ActualParameter.turn_inc ();
					Raise_ActualParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ActualParameter);
				break;
				case ActualParameter.production_kind.g_ActualParameter_3:
					// traverse syntax tree node associated with production
					// ActualParameter: ValueSet

					if (Raise_ActualParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ActualParameter))
						Traverse (p_ActualParameter.m_ValueSet);
					p_ActualParameter.turn_inc ();
					Raise_ActualParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ActualParameter);
				break;
				case ActualParameter.production_kind.g_ActualParameter_4:
					// traverse syntax tree node associated with production
					// ActualParameter: DefinedObjectClass

					if (Raise_ActualParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ActualParameter))
						Traverse (p_ActualParameter.m_DefinedObjectClass);
					p_ActualParameter.turn_inc ();
					Raise_ActualParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ActualParameter);
				break;
				case ActualParameter.production_kind.g_ActualParameter_5:
					// traverse syntax tree node associated with production
					// ActualParameter: Object

					if (Raise_ActualParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ActualParameter))
						Traverse (p_ActualParameter.m_Object);
					p_ActualParameter.turn_inc ();
					Raise_ActualParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ActualParameter);
				break;
				case ActualParameter.production_kind.g_ActualParameter_6:
					// traverse syntax tree node associated with production
					// ActualParameter: ObjectSet

					if (Raise_ActualParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ActualParameter))
						Traverse (p_ActualParameter.m_ObjectSet);
					p_ActualParameter.turn_inc ();
					Raise_ActualParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ActualParameter);
				break;
			}
			Raise_ActualParameter_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ActualParameter);
			p_ActualParameter.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ActualParameter
		//

		public void TraverseCommon (ActualParameter p_ActualParameter)
		{
			ActualParameter.production_kind kind = (ActualParameter.production_kind) p_ActualParameter.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ActualParameter))
			switch (kind)
			{
				case ActualParameter.production_kind.g_ActualParameter_1:
					// traverse syntax tree node associated with production
					// ActualParameter: Type

						TraverseCommon (p_ActualParameter.m_Type);
				break;
				case ActualParameter.production_kind.g_ActualParameter_2:
					// traverse syntax tree node associated with production
					// ActualParameter: Value

						TraverseCommon (p_ActualParameter.m_Value);
				break;
				case ActualParameter.production_kind.g_ActualParameter_3:
					// traverse syntax tree node associated with production
					// ActualParameter: ValueSet

						TraverseCommon (p_ActualParameter.m_ValueSet);
				break;
				case ActualParameter.production_kind.g_ActualParameter_4:
					// traverse syntax tree node associated with production
					// ActualParameter: DefinedObjectClass

						TraverseCommon (p_ActualParameter.m_DefinedObjectClass);
				break;
				case ActualParameter.production_kind.g_ActualParameter_5:
					// traverse syntax tree node associated with production
					// ActualParameter: Object

						TraverseCommon (p_ActualParameter.m_Object);
				break;
				case ActualParameter.production_kind.g_ActualParameter_6:
					// traverse syntax tree node associated with production
					// ActualParameter: ObjectSet

						TraverseCommon (p_ActualParameter.m_ObjectSet);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ActualParameter);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ActualParameter

		//
		// create syntax tree node associated with production
		// ActualParameter: Type

		//

		public ActualParameter ActualParameter_1 (Type p_Type)
		{
			ActualParameter p_ActualParameter_ref = new ActualParameter(p_Type);
			p_Type.parent = p_ActualParameter_ref;
			Raise_ActualParameter_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ActualParameter.production_kind.g_ActualParameter_1, p_ActualParameter_ref);
			return p_ActualParameter_ref;
		}

		//
		// create syntax tree node associated with production
		// ActualParameter: Value

		//

		public ActualParameter ActualParameter_2 (Value p_Value)
		{
			ActualParameter p_ActualParameter_ref = new ActualParameter(p_Value);
			p_Value.parent = p_ActualParameter_ref;
			Raise_ActualParameter_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ActualParameter.production_kind.g_ActualParameter_2, p_ActualParameter_ref);
			return p_ActualParameter_ref;
		}

		//
		// create syntax tree node associated with production
		// ActualParameter: ValueSet

		//

		public ActualParameter ActualParameter_3 (ValueSet p_ValueSet)
		{
			ActualParameter p_ActualParameter_ref = new ActualParameter(p_ValueSet);
			p_ValueSet.parent = p_ActualParameter_ref;
			Raise_ActualParameter_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ActualParameter.production_kind.g_ActualParameter_3, p_ActualParameter_ref);
			return p_ActualParameter_ref;
		}

		//
		// create syntax tree node associated with production
		// ActualParameter: DefinedObjectClass

		//

		public ActualParameter ActualParameter_4 (DefinedObjectClass p_DefinedObjectClass)
		{
			ActualParameter p_ActualParameter_ref = new ActualParameter(p_DefinedObjectClass);
			p_DefinedObjectClass.parent = p_ActualParameter_ref;
			Raise_ActualParameter_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ActualParameter.production_kind.g_ActualParameter_4, p_ActualParameter_ref);
			return p_ActualParameter_ref;
		}

		//
		// create syntax tree node associated with production
		// ActualParameter: Object

		//

		public ActualParameter ActualParameter_5 (Object p_Object)
		{
			ActualParameter p_ActualParameter_ref = new ActualParameter(p_Object);
			p_Object.parent = p_ActualParameter_ref;
			Raise_ActualParameter_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ActualParameter.production_kind.g_ActualParameter_5, p_ActualParameter_ref);
			return p_ActualParameter_ref;
		}

		//
		// create syntax tree node associated with production
		// ActualParameter: ObjectSet

		//

		public ActualParameter ActualParameter_6 (ObjectSet p_ObjectSet)
		{
			ActualParameter p_ActualParameter_ref = new ActualParameter(p_ObjectSet);
			p_ObjectSet.parent = p_ActualParameter_ref;
			Raise_ActualParameter_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ActualParameter.production_kind.g_ActualParameter_6, p_ActualParameter_ref);
			return p_ActualParameter_ref;
		}
		#endregion
	};
}
