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
	// class associated with syntax rule Setting
	//

	[DataContract]
	public class	Setting : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Setting
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Setting
		{
			g_Setting_1 = 1,	// Type

			g_Setting_2 = 2,	// Value

			g_Setting_3 = 3,	// ValueSet

			g_Setting_4 = 4,	// Object

			g_Setting_5 = 5,	// ObjectSet

		};
		#endregion
		#region production markers associated with the syntax rule Setting

		// markers associated with production: Setting -> Type

		public enum production_marker_1 : ushort
		{
			m_Type,
			final
		};

		// markers associated with production: Setting -> Value

		public enum production_marker_2 : ushort
		{
			m_Value,
			final
		};

		// markers associated with production: Setting -> ValueSet

		public enum production_marker_3 : ushort
		{
			m_ValueSet,
			final
		};

		// markers associated with production: Setting -> Object

		public enum production_marker_4 : ushort
		{
			m_Object,
			final
		};

		// markers associated with production: Setting -> ObjectSet

		public enum production_marker_5 : ushort
		{
			m_ObjectSet,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Setting

		// Constructor declaration(s) associated with production(s) of syntax rule Setting

		//
		// Constructor associated with the following production(s)
		// Setting -> Type

		//

		public Setting (Type p_Type) : base ((uint) ProductionID._Setting_ID, (uint) production_kind.g_Setting_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Type = p_Type;
		}

		//
		// Constructor associated with the following production(s)
		// Setting -> Value

		//

		public Setting (Value p_Value) : base ((uint) ProductionID._Setting_ID, (uint) production_kind.g_Setting_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Value = p_Value;
		}

		//
		// Constructor associated with the following production(s)
		// Setting -> ValueSet

		//

		public Setting (ValueSet p_ValueSet) : base ((uint) ProductionID._Setting_ID, (uint) production_kind.g_Setting_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ValueSet = p_ValueSet;
		}

		//
		// Constructor associated with the following production(s)
		// Setting -> Object

		//

		public Setting (Object p_Object) : base ((uint) ProductionID._Setting_ID, (uint) production_kind.g_Setting_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Object = p_Object;
		}

		//
		// Constructor associated with the following production(s)
		// Setting -> ObjectSet

		//

		public Setting (ObjectSet p_ObjectSet) : base ((uint) ProductionID._Setting_ID, (uint) production_kind.g_Setting_5)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjectSet = p_ObjectSet;
		}

		public Setting () { }

		// Copy constructor

		public Setting (Setting p_Setting) : base (p_Setting.id, p_Setting.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Setting.appInfo;
			switch ((production_kind) p_Setting.kind)
			{
				case production_kind.g_Setting_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Type = (p_Setting.m_Type != null) ? new Type (p_Setting.m_Type) : null) != null) m_Type.parent = this;
					break;
				case production_kind.g_Setting_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Value = (p_Setting.m_Value != null) ? new Value (p_Setting.m_Value) : null) != null) m_Value.parent = this;
					break;
				case production_kind.g_Setting_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ValueSet = (p_Setting.m_ValueSet != null) ? new ValueSet (p_Setting.m_ValueSet) : null) != null) m_ValueSet.parent = this;
					break;
				case production_kind.g_Setting_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Object = (p_Setting.m_Object != null) ? new Object (p_Setting.m_Object) : null) != null) m_Object.parent = this;
					break;
				case production_kind.g_Setting_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectSet = (p_Setting.m_ObjectSet != null) ? new ObjectSet (p_Setting.m_ObjectSet) : null) != null) m_ObjectSet.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Setting" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Setting (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Type?.Dispose ();
			m_Value?.Dispose ();
			m_ValueSet?.Dispose ();
			m_Object?.Dispose ();
			m_ObjectSet?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Setting

		// Content changing function(s) associated with production(s) of syntax rule Setting

		//
		// Content changing function associated with following production(s)
		// Setting -> Type

		//

		public void change(Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_Setting_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Setting -> Value

		//

		public void change(Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_Setting_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Setting -> ValueSet

		//

		public void change(ValueSet p_ValueSet)
		{
			_init ();
			this.kind = (uint) production_kind.g_Setting_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ValueSet = p_ValueSet;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Setting -> Object

		//

		public void change(Object p_Object)
		{
			_init ();
			this.kind = (uint) production_kind.g_Setting_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Object = p_Object;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Setting -> ObjectSet

		//

		public void change(ObjectSet p_ObjectSet)
		{
			_init ();
			this.kind = (uint) production_kind.g_Setting_5;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjectSet = p_ObjectSet;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Setting
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				(m_ValueSet != null) && m_ValueSet.checkInclusion (element) ||
				(m_Object != null) && m_Object.checkInclusion (element) ||
				(m_ObjectSet != null) && m_ObjectSet.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Setting

		//
		// emit production tree node associated with any production of syntax rule Setting
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Setting_1:
					// emit syntax tree node associated with production
					// Setting: Type

					s += m_Type.Emit (depth - 1);
				break;
				case production_kind.g_Setting_2:
					// emit syntax tree node associated with production
					// Setting: Value

					s += m_Value.Emit (depth - 1);
				break;
				case production_kind.g_Setting_3:
					// emit syntax tree node associated with production
					// Setting: ValueSet

					s += m_ValueSet.Emit (depth - 1);
				break;
				case production_kind.g_Setting_4:
					// emit syntax tree node associated with production
					// Setting: Object

					s += m_Object.Emit (depth - 1);
				break;
				case production_kind.g_Setting_5:
					// emit syntax tree node associated with production
					// Setting: ObjectSet

					s += m_ObjectSet.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Setting
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Setting (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Setting_1:
					// emit syntax tree node associated with production
					// Setting: Type

					s += m_Type.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Setting_2:
					// emit syntax tree node associated with production
					// Setting: Value

					s += m_Value.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Setting_3:
					// emit syntax tree node associated with production
					// Setting: ValueSet

					s += m_ValueSet.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Setting_4:
					// emit syntax tree node associated with production
					// Setting: Object

					s += m_Object.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Setting_5:
					// emit syntax tree node associated with production
					// Setting: ObjectSet

					s += m_ObjectSet.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Setting

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Setting with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Setting.production_kind kind = (Setting.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Setting.production_kind.g_Setting_1:
					// traverse syntax tree node associated with production
					// Setting: Type

						m_Type.Visit (visitor, appData);
				break;
				case Setting.production_kind.g_Setting_2:
					// traverse syntax tree node associated with production
					// Setting: Value

						m_Value.Visit (visitor, appData);
				break;
				case Setting.production_kind.g_Setting_3:
					// traverse syntax tree node associated with production
					// Setting: ValueSet

						m_ValueSet.Visit (visitor, appData);
				break;
				case Setting.production_kind.g_Setting_4:
					// traverse syntax tree node associated with production
					// Setting: Object

						m_Object.Visit (visitor, appData);
				break;
				case Setting.production_kind.g_Setting_5:
					// traverse syntax tree node associated with production
					// Setting: ObjectSet

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
			m_Object?.reparent (this);
			m_ObjectSet?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Setting
		//

		public void _init ()
		{
			m_Type = null;
			m_Value = null;
			m_ValueSet = null;
			m_Object = null;
			m_ObjectSet = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Setting

		// counter of all nodes associated with syntax rule Setting
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Setting
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		[DataMember (Name = "m_ValueSet")] public ValueSet m_ValueSet { get; private set; }
		[DataMember (Name = "m_Object")] public Object m_Object { get; private set; }
		[DataMember (Name = "m_ObjectSet")] public ObjectSet m_ObjectSet { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Setting

		// delegate function (callback) prototype associated with syntax rule Setting
		public delegate bool Setting_Callback (SyntaxTreeCallbackReason reason, Setting.production_kind kind, Setting p_Setting);

		// event associated with syntax rule Setting
		public event Setting_Callback Setting_Event;

		// event trigger associated with syntax rule Setting
		public bool Raise_Setting_Event (SyntaxTreeCallbackReason reason, Setting.production_kind kind, Setting p_Setting)
		{
			bool? status = Setting_Event?.Invoke (reason, kind, p_Setting);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Setting
		//
		// traverse syntax tree node associated with any production of syntax rule Setting
		//

		public void Traverse (Setting p_Setting)
		{
			if (p_Setting.isLocked())
				return;
			p_Setting.dolock();
			Setting.production_kind kind = (Setting.production_kind) p_Setting.kind;
			p_Setting.turn_reset ();
			if (Raise_Setting_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Setting))
			switch (kind)
			{
				case Setting.production_kind.g_Setting_1:
					// traverse syntax tree node associated with production
					// Setting: Type

					if (Raise_Setting_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Setting))
						Traverse (p_Setting.m_Type);
					p_Setting.turn_inc ();
					Raise_Setting_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Setting);
				break;
				case Setting.production_kind.g_Setting_2:
					// traverse syntax tree node associated with production
					// Setting: Value

					if (Raise_Setting_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Setting))
						Traverse (p_Setting.m_Value);
					p_Setting.turn_inc ();
					Raise_Setting_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Setting);
				break;
				case Setting.production_kind.g_Setting_3:
					// traverse syntax tree node associated with production
					// Setting: ValueSet

					if (Raise_Setting_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Setting))
						Traverse (p_Setting.m_ValueSet);
					p_Setting.turn_inc ();
					Raise_Setting_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Setting);
				break;
				case Setting.production_kind.g_Setting_4:
					// traverse syntax tree node associated with production
					// Setting: Object

					if (Raise_Setting_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Setting))
						Traverse (p_Setting.m_Object);
					p_Setting.turn_inc ();
					Raise_Setting_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Setting);
				break;
				case Setting.production_kind.g_Setting_5:
					// traverse syntax tree node associated with production
					// Setting: ObjectSet

					if (Raise_Setting_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Setting))
						Traverse (p_Setting.m_ObjectSet);
					p_Setting.turn_inc ();
					Raise_Setting_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Setting);
				break;
			}
			Raise_Setting_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Setting);
			p_Setting.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Setting
		//

		public void TraverseCommon (Setting p_Setting)
		{
			Setting.production_kind kind = (Setting.production_kind) p_Setting.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Setting))
			switch (kind)
			{
				case Setting.production_kind.g_Setting_1:
					// traverse syntax tree node associated with production
					// Setting: Type

						TraverseCommon (p_Setting.m_Type);
				break;
				case Setting.production_kind.g_Setting_2:
					// traverse syntax tree node associated with production
					// Setting: Value

						TraverseCommon (p_Setting.m_Value);
				break;
				case Setting.production_kind.g_Setting_3:
					// traverse syntax tree node associated with production
					// Setting: ValueSet

						TraverseCommon (p_Setting.m_ValueSet);
				break;
				case Setting.production_kind.g_Setting_4:
					// traverse syntax tree node associated with production
					// Setting: Object

						TraverseCommon (p_Setting.m_Object);
				break;
				case Setting.production_kind.g_Setting_5:
					// traverse syntax tree node associated with production
					// Setting: ObjectSet

						TraverseCommon (p_Setting.m_ObjectSet);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Setting);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Setting

		//
		// create syntax tree node associated with production
		// Setting: Type

		//

		public Setting Setting_1 (Type p_Type)
		{
			Setting p_Setting_ref = new Setting(p_Type);
			p_Type.parent = p_Setting_ref;
			Raise_Setting_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Setting.production_kind.g_Setting_1, p_Setting_ref);
			return p_Setting_ref;
		}

		//
		// create syntax tree node associated with production
		// Setting: Value

		//

		public Setting Setting_2 (Value p_Value)
		{
			Setting p_Setting_ref = new Setting(p_Value);
			p_Value.parent = p_Setting_ref;
			Raise_Setting_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Setting.production_kind.g_Setting_2, p_Setting_ref);
			return p_Setting_ref;
		}

		//
		// create syntax tree node associated with production
		// Setting: ValueSet

		//

		public Setting Setting_3 (ValueSet p_ValueSet)
		{
			Setting p_Setting_ref = new Setting(p_ValueSet);
			p_ValueSet.parent = p_Setting_ref;
			Raise_Setting_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Setting.production_kind.g_Setting_3, p_Setting_ref);
			return p_Setting_ref;
		}

		//
		// create syntax tree node associated with production
		// Setting: Object

		//

		public Setting Setting_4 (Object p_Object)
		{
			Setting p_Setting_ref = new Setting(p_Object);
			p_Object.parent = p_Setting_ref;
			Raise_Setting_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Setting.production_kind.g_Setting_4, p_Setting_ref);
			return p_Setting_ref;
		}

		//
		// create syntax tree node associated with production
		// Setting: ObjectSet

		//

		public Setting Setting_5 (ObjectSet p_ObjectSet)
		{
			Setting p_Setting_ref = new Setting(p_ObjectSet);
			p_ObjectSet.parent = p_Setting_ref;
			Raise_Setting_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Setting.production_kind.g_Setting_5, p_Setting_ref);
			return p_Setting_ref;
		}
		#endregion
	};
}
