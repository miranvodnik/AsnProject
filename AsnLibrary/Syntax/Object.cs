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
	// class associated with syntax rule Object
	//

	[DataContract]
	public class	Object : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Object
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Object
		{
			g_Object_1 = 1,	// DefinedObject

			g_Object_2 = 2,	// ObjectDefn

			g_Object_3 = 3,	// ObjectFromObject

			g_Object_4 = 4,	// ParameterizedObject

		};
		#endregion
		#region production markers associated with the syntax rule Object

		// markers associated with production: Object -> DefinedObject

		public enum production_marker_1 : ushort
		{
			m_DefinedObject,
			final
		};

		// markers associated with production: Object -> ObjectDefn

		public enum production_marker_2 : ushort
		{
			m_ObjectDefn,
			final
		};

		// markers associated with production: Object -> ObjectFromObject

		public enum production_marker_3 : ushort
		{
			m_ObjectFromObject,
			final
		};

		// markers associated with production: Object -> ParameterizedObject

		public enum production_marker_4 : ushort
		{
			m_ParameterizedObject,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Object

		// Constructor declaration(s) associated with production(s) of syntax rule Object

		//
		// Constructor associated with the following production(s)
		// Object -> DefinedObject

		//

		public Object (DefinedObject p_DefinedObject) : base ((uint) ProductionID._Object_ID, (uint) production_kind.g_Object_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinedObject = p_DefinedObject;
		}

		//
		// Constructor associated with the following production(s)
		// Object -> ObjectDefn

		//

		public Object (ObjectDefn p_ObjectDefn) : base ((uint) ProductionID._Object_ID, (uint) production_kind.g_Object_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjectDefn = p_ObjectDefn;
		}

		//
		// Constructor associated with the following production(s)
		// Object -> ObjectFromObject

		//

		public Object (ObjectFromObject p_ObjectFromObject) : base ((uint) ProductionID._Object_ID, (uint) production_kind.g_Object_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjectFromObject = p_ObjectFromObject;
		}

		//
		// Constructor associated with the following production(s)
		// Object -> ParameterizedObject

		//

		public Object (ParameterizedObject p_ParameterizedObject) : base ((uint) ProductionID._Object_ID, (uint) production_kind.g_Object_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ParameterizedObject = p_ParameterizedObject;
		}

		public Object () { }

		// Copy constructor

		public Object (Object p_Object) : base (p_Object.id, p_Object.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Object.appInfo;
			switch ((production_kind) p_Object.kind)
			{
				case production_kind.g_Object_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinedObject = (p_Object.m_DefinedObject != null) ? new DefinedObject (p_Object.m_DefinedObject) : null) != null) m_DefinedObject.parent = this;
					break;
				case production_kind.g_Object_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectDefn = (p_Object.m_ObjectDefn != null) ? new ObjectDefn (p_Object.m_ObjectDefn) : null) != null) m_ObjectDefn.parent = this;
					break;
				case production_kind.g_Object_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectFromObject = (p_Object.m_ObjectFromObject != null) ? new ObjectFromObject (p_Object.m_ObjectFromObject) : null) != null) m_ObjectFromObject.parent = this;
					break;
				case production_kind.g_Object_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ParameterizedObject = (p_Object.m_ParameterizedObject != null) ? new ParameterizedObject (p_Object.m_ParameterizedObject) : null) != null) m_ParameterizedObject.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Object" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Object (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DefinedObject?.Dispose ();
			m_ObjectDefn?.Dispose ();
			m_ObjectFromObject?.Dispose ();
			m_ParameterizedObject?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Object

		// Content changing function(s) associated with production(s) of syntax rule Object

		//
		// Content changing function associated with following production(s)
		// Object -> DefinedObject

		//

		public void change(DefinedObject p_DefinedObject)
		{
			_init ();
			this.kind = (uint) production_kind.g_Object_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinedObject = p_DefinedObject;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Object -> ObjectDefn

		//

		public void change(ObjectDefn p_ObjectDefn)
		{
			_init ();
			this.kind = (uint) production_kind.g_Object_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjectDefn = p_ObjectDefn;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Object -> ObjectFromObject

		//

		public void change(ObjectFromObject p_ObjectFromObject)
		{
			_init ();
			this.kind = (uint) production_kind.g_Object_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjectFromObject = p_ObjectFromObject;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Object -> ParameterizedObject

		//

		public void change(ParameterizedObject p_ParameterizedObject)
		{
			_init ();
			this.kind = (uint) production_kind.g_Object_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ParameterizedObject = p_ParameterizedObject;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Object
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DefinedObject != null) && m_DefinedObject.checkInclusion (element) ||
				(m_ObjectDefn != null) && m_ObjectDefn.checkInclusion (element) ||
				(m_ObjectFromObject != null) && m_ObjectFromObject.checkInclusion (element) ||
				(m_ParameterizedObject != null) && m_ParameterizedObject.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Object

		//
		// emit production tree node associated with any production of syntax rule Object
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Object_1:
					// emit syntax tree node associated with production
					// Object: DefinedObject

					s += m_DefinedObject.Emit (depth - 1);
				break;
				case production_kind.g_Object_2:
					// emit syntax tree node associated with production
					// Object: ObjectDefn

					s += m_ObjectDefn.Emit (depth - 1);
				break;
				case production_kind.g_Object_3:
					// emit syntax tree node associated with production
					// Object: ObjectFromObject

					s += m_ObjectFromObject.Emit (depth - 1);
				break;
				case production_kind.g_Object_4:
					// emit syntax tree node associated with production
					// Object: ParameterizedObject

					s += m_ParameterizedObject.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Object
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Object (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Object_1:
					// emit syntax tree node associated with production
					// Object: DefinedObject

					s += m_DefinedObject.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Object_2:
					// emit syntax tree node associated with production
					// Object: ObjectDefn

					s += m_ObjectDefn.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Object_3:
					// emit syntax tree node associated with production
					// Object: ObjectFromObject

					s += m_ObjectFromObject.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Object_4:
					// emit syntax tree node associated with production
					// Object: ParameterizedObject

					s += m_ParameterizedObject.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Object

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Object with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Object.production_kind kind = (Object.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Object.production_kind.g_Object_1:
					// traverse syntax tree node associated with production
					// Object: DefinedObject

						m_DefinedObject.Visit (visitor, appData);
				break;
				case Object.production_kind.g_Object_2:
					// traverse syntax tree node associated with production
					// Object: ObjectDefn

						m_ObjectDefn.Visit (visitor, appData);
				break;
				case Object.production_kind.g_Object_3:
					// traverse syntax tree node associated with production
					// Object: ObjectFromObject

						m_ObjectFromObject.Visit (visitor, appData);
				break;
				case Object.production_kind.g_Object_4:
					// traverse syntax tree node associated with production
					// Object: ParameterizedObject

						m_ParameterizedObject.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DefinedObject?.reparent (this);
			m_ObjectDefn?.reparent (this);
			m_ObjectFromObject?.reparent (this);
			m_ParameterizedObject?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Object
		//

		public void _init ()
		{
			m_DefinedObject = null;
			m_ObjectDefn = null;
			m_ObjectFromObject = null;
			m_ParameterizedObject = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Object

		// counter of all nodes associated with syntax rule Object
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Object
		[DataMember (Name = "m_DefinedObject")] public DefinedObject m_DefinedObject { get; private set; }
		[DataMember (Name = "m_ObjectDefn")] public ObjectDefn m_ObjectDefn { get; private set; }
		[DataMember (Name = "m_ObjectFromObject")] public ObjectFromObject m_ObjectFromObject { get; private set; }
		[DataMember (Name = "m_ParameterizedObject")] public ParameterizedObject m_ParameterizedObject { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Object

		// delegate function (callback) prototype associated with syntax rule Object
		public delegate bool Object_Callback (SyntaxTreeCallbackReason reason, Object.production_kind kind, Object p_Object);

		// event associated with syntax rule Object
		public event Object_Callback Object_Event;

		// event trigger associated with syntax rule Object
		public bool Raise_Object_Event (SyntaxTreeCallbackReason reason, Object.production_kind kind, Object p_Object)
		{
			bool? status = Object_Event?.Invoke (reason, kind, p_Object);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Object
		//
		// traverse syntax tree node associated with any production of syntax rule Object
		//

		public void Traverse (Object p_Object)
		{
			if (p_Object.isLocked())
				return;
			p_Object.dolock();
			Object.production_kind kind = (Object.production_kind) p_Object.kind;
			p_Object.turn_reset ();
			if (Raise_Object_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Object))
			switch (kind)
			{
				case Object.production_kind.g_Object_1:
					// traverse syntax tree node associated with production
					// Object: DefinedObject

					if (Raise_Object_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Object))
						Traverse (p_Object.m_DefinedObject);
					p_Object.turn_inc ();
					Raise_Object_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Object);
				break;
				case Object.production_kind.g_Object_2:
					// traverse syntax tree node associated with production
					// Object: ObjectDefn

					if (Raise_Object_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Object))
						Traverse (p_Object.m_ObjectDefn);
					p_Object.turn_inc ();
					Raise_Object_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Object);
				break;
				case Object.production_kind.g_Object_3:
					// traverse syntax tree node associated with production
					// Object: ObjectFromObject

					if (Raise_Object_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Object))
						Traverse (p_Object.m_ObjectFromObject);
					p_Object.turn_inc ();
					Raise_Object_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Object);
				break;
				case Object.production_kind.g_Object_4:
					// traverse syntax tree node associated with production
					// Object: ParameterizedObject

					if (Raise_Object_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Object))
						Traverse (p_Object.m_ParameterizedObject);
					p_Object.turn_inc ();
					Raise_Object_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Object);
				break;
			}
			Raise_Object_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Object);
			p_Object.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Object
		//

		public void TraverseCommon (Object p_Object)
		{
			Object.production_kind kind = (Object.production_kind) p_Object.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Object))
			switch (kind)
			{
				case Object.production_kind.g_Object_1:
					// traverse syntax tree node associated with production
					// Object: DefinedObject

						TraverseCommon (p_Object.m_DefinedObject);
				break;
				case Object.production_kind.g_Object_2:
					// traverse syntax tree node associated with production
					// Object: ObjectDefn

						TraverseCommon (p_Object.m_ObjectDefn);
				break;
				case Object.production_kind.g_Object_3:
					// traverse syntax tree node associated with production
					// Object: ObjectFromObject

						TraverseCommon (p_Object.m_ObjectFromObject);
				break;
				case Object.production_kind.g_Object_4:
					// traverse syntax tree node associated with production
					// Object: ParameterizedObject

						TraverseCommon (p_Object.m_ParameterizedObject);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Object);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Object

		//
		// create syntax tree node associated with production
		// Object: DefinedObject

		//

		public Object Object_1 (DefinedObject p_DefinedObject)
		{
			Object p_Object_ref = new Object(p_DefinedObject);
			p_DefinedObject.parent = p_Object_ref;
			Raise_Object_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Object.production_kind.g_Object_1, p_Object_ref);
			return p_Object_ref;
		}

		//
		// create syntax tree node associated with production
		// Object: ObjectDefn

		//

		public Object Object_2 (ObjectDefn p_ObjectDefn)
		{
			Object p_Object_ref = new Object(p_ObjectDefn);
			p_ObjectDefn.parent = p_Object_ref;
			Raise_Object_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Object.production_kind.g_Object_2, p_Object_ref);
			return p_Object_ref;
		}

		//
		// create syntax tree node associated with production
		// Object: ObjectFromObject

		//

		public Object Object_3 (ObjectFromObject p_ObjectFromObject)
		{
			Object p_Object_ref = new Object(p_ObjectFromObject);
			p_ObjectFromObject.parent = p_Object_ref;
			Raise_Object_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Object.production_kind.g_Object_3, p_Object_ref);
			return p_Object_ref;
		}

		//
		// create syntax tree node associated with production
		// Object: ParameterizedObject

		//

		public Object Object_4 (ParameterizedObject p_ParameterizedObject)
		{
			Object p_Object_ref = new Object(p_ParameterizedObject);
			p_ParameterizedObject.parent = p_Object_ref;
			Raise_Object_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Object.production_kind.g_Object_4, p_Object_ref);
			return p_Object_ref;
		}
		#endregion
	};
}
