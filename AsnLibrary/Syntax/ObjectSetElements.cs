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
	// class associated with syntax rule ObjectSetElements
	//

	[DataContract]
	public class	ObjectSetElements : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectSetElements
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectSetElements
		{
			g_ObjectSetElements_1 = 1,	// Object

			g_ObjectSetElements_2 = 2,	// DefinedObjectSet

			g_ObjectSetElements_3 = 3,	// ObjectSetFromObjects

			g_ObjectSetElements_4 = 4,	// ParameterizedObjectSet

		};
		#endregion
		#region production markers associated with the syntax rule ObjectSetElements

		// markers associated with production: ObjectSetElements -> Object

		public enum production_marker_1 : ushort
		{
			m_Object,
			final
		};

		// markers associated with production: ObjectSetElements -> DefinedObjectSet

		public enum production_marker_2 : ushort
		{
			m_DefinedObjectSet,
			final
		};

		// markers associated with production: ObjectSetElements -> ObjectSetFromObjects

		public enum production_marker_3 : ushort
		{
			m_ObjectSetFromObjects,
			final
		};

		// markers associated with production: ObjectSetElements -> ParameterizedObjectSet

		public enum production_marker_4 : ushort
		{
			m_ParameterizedObjectSet,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectSetElements

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectSetElements

		//
		// Constructor associated with the following production(s)
		// ObjectSetElements -> Object

		//

		public ObjectSetElements (Object p_Object) : base ((uint) ProductionID._ObjectSetElements_ID, (uint) production_kind.g_ObjectSetElements_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Object = p_Object;
		}

		//
		// Constructor associated with the following production(s)
		// ObjectSetElements -> DefinedObjectSet

		//

		public ObjectSetElements (DefinedObjectSet p_DefinedObjectSet) : base ((uint) ProductionID._ObjectSetElements_ID, (uint) production_kind.g_ObjectSetElements_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinedObjectSet = p_DefinedObjectSet;
		}

		//
		// Constructor associated with the following production(s)
		// ObjectSetElements -> ObjectSetFromObjects

		//

		public ObjectSetElements (ObjectSetFromObjects p_ObjectSetFromObjects) : base ((uint) ProductionID._ObjectSetElements_ID, (uint) production_kind.g_ObjectSetElements_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjectSetFromObjects = p_ObjectSetFromObjects;
		}

		//
		// Constructor associated with the following production(s)
		// ObjectSetElements -> ParameterizedObjectSet

		//

		public ObjectSetElements (ParameterizedObjectSet p_ParameterizedObjectSet) : base ((uint) ProductionID._ObjectSetElements_ID, (uint) production_kind.g_ObjectSetElements_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ParameterizedObjectSet = p_ParameterizedObjectSet;
		}

		public ObjectSetElements () { }

		// Copy constructor

		public ObjectSetElements (ObjectSetElements p_ObjectSetElements) : base (p_ObjectSetElements.id, p_ObjectSetElements.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectSetElements.appInfo;
			switch ((production_kind) p_ObjectSetElements.kind)
			{
				case production_kind.g_ObjectSetElements_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Object = (p_ObjectSetElements.m_Object != null) ? new Object (p_ObjectSetElements.m_Object) : null) != null) m_Object.parent = this;
					break;
				case production_kind.g_ObjectSetElements_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinedObjectSet = (p_ObjectSetElements.m_DefinedObjectSet != null) ? new DefinedObjectSet (p_ObjectSetElements.m_DefinedObjectSet) : null) != null) m_DefinedObjectSet.parent = this;
					break;
				case production_kind.g_ObjectSetElements_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectSetFromObjects = (p_ObjectSetElements.m_ObjectSetFromObjects != null) ? new ObjectSetFromObjects (p_ObjectSetElements.m_ObjectSetFromObjects) : null) != null) m_ObjectSetFromObjects.parent = this;
					break;
				case production_kind.g_ObjectSetElements_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ParameterizedObjectSet = (p_ObjectSetElements.m_ParameterizedObjectSet != null) ? new ParameterizedObjectSet (p_ObjectSetElements.m_ParameterizedObjectSet) : null) != null) m_ParameterizedObjectSet.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectSetElements" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectSetElements (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Object?.Dispose ();
			m_DefinedObjectSet?.Dispose ();
			m_ObjectSetFromObjects?.Dispose ();
			m_ParameterizedObjectSet?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectSetElements

		// Content changing function(s) associated with production(s) of syntax rule ObjectSetElements

		//
		// Content changing function associated with following production(s)
		// ObjectSetElements -> Object

		//

		public void change(Object p_Object)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectSetElements_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Object = p_Object;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ObjectSetElements -> DefinedObjectSet

		//

		public void change(DefinedObjectSet p_DefinedObjectSet)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectSetElements_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinedObjectSet = p_DefinedObjectSet;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ObjectSetElements -> ObjectSetFromObjects

		//

		public void change(ObjectSetFromObjects p_ObjectSetFromObjects)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectSetElements_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjectSetFromObjects = p_ObjectSetFromObjects;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ObjectSetElements -> ParameterizedObjectSet

		//

		public void change(ParameterizedObjectSet p_ParameterizedObjectSet)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectSetElements_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ParameterizedObjectSet = p_ParameterizedObjectSet;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectSetElements
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Object != null) && m_Object.checkInclusion (element) ||
				(m_DefinedObjectSet != null) && m_DefinedObjectSet.checkInclusion (element) ||
				(m_ObjectSetFromObjects != null) && m_ObjectSetFromObjects.checkInclusion (element) ||
				(m_ParameterizedObjectSet != null) && m_ParameterizedObjectSet.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectSetElements

		//
		// emit production tree node associated with any production of syntax rule ObjectSetElements
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectSetElements_1:
					// emit syntax tree node associated with production
					// ObjectSetElements: Object

					s += m_Object.Emit (depth - 1);
				break;
				case production_kind.g_ObjectSetElements_2:
					// emit syntax tree node associated with production
					// ObjectSetElements: DefinedObjectSet

					s += m_DefinedObjectSet.Emit (depth - 1);
				break;
				case production_kind.g_ObjectSetElements_3:
					// emit syntax tree node associated with production
					// ObjectSetElements: ObjectSetFromObjects

					s += m_ObjectSetFromObjects.Emit (depth - 1);
				break;
				case production_kind.g_ObjectSetElements_4:
					// emit syntax tree node associated with production
					// ObjectSetElements: ParameterizedObjectSet

					s += m_ParameterizedObjectSet.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectSetElements
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectSetElements (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectSetElements_1:
					// emit syntax tree node associated with production
					// ObjectSetElements: Object

					s += m_Object.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ObjectSetElements_2:
					// emit syntax tree node associated with production
					// ObjectSetElements: DefinedObjectSet

					s += m_DefinedObjectSet.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ObjectSetElements_3:
					// emit syntax tree node associated with production
					// ObjectSetElements: ObjectSetFromObjects

					s += m_ObjectSetFromObjects.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ObjectSetElements_4:
					// emit syntax tree node associated with production
					// ObjectSetElements: ParameterizedObjectSet

					s += m_ParameterizedObjectSet.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectSetElements

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetElements with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectSetElements.production_kind kind = (ObjectSetElements.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectSetElements.production_kind.g_ObjectSetElements_1:
					// traverse syntax tree node associated with production
					// ObjectSetElements: Object

						m_Object.Visit (visitor, appData);
				break;
				case ObjectSetElements.production_kind.g_ObjectSetElements_2:
					// traverse syntax tree node associated with production
					// ObjectSetElements: DefinedObjectSet

						m_DefinedObjectSet.Visit (visitor, appData);
				break;
				case ObjectSetElements.production_kind.g_ObjectSetElements_3:
					// traverse syntax tree node associated with production
					// ObjectSetElements: ObjectSetFromObjects

						m_ObjectSetFromObjects.Visit (visitor, appData);
				break;
				case ObjectSetElements.production_kind.g_ObjectSetElements_4:
					// traverse syntax tree node associated with production
					// ObjectSetElements: ParameterizedObjectSet

						m_ParameterizedObjectSet.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Object?.reparent (this);
			m_DefinedObjectSet?.reparent (this);
			m_ObjectSetFromObjects?.reparent (this);
			m_ParameterizedObjectSet?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectSetElements
		//

		public void _init ()
		{
			m_Object = null;
			m_DefinedObjectSet = null;
			m_ObjectSetFromObjects = null;
			m_ParameterizedObjectSet = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectSetElements

		// counter of all nodes associated with syntax rule ObjectSetElements
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectSetElements
		[DataMember (Name = "m_Object")] public Object m_Object { get; private set; }
		[DataMember (Name = "m_DefinedObjectSet")] public DefinedObjectSet m_DefinedObjectSet { get; private set; }
		[DataMember (Name = "m_ObjectSetFromObjects")] public ObjectSetFromObjects m_ObjectSetFromObjects { get; private set; }
		[DataMember (Name = "m_ParameterizedObjectSet")] public ParameterizedObjectSet m_ParameterizedObjectSet { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectSetElements

		// delegate function (callback) prototype associated with syntax rule ObjectSetElements
		public delegate bool ObjectSetElements_Callback (SyntaxTreeCallbackReason reason, ObjectSetElements.production_kind kind, ObjectSetElements p_ObjectSetElements);

		// event associated with syntax rule ObjectSetElements
		public event ObjectSetElements_Callback ObjectSetElements_Event;

		// event trigger associated with syntax rule ObjectSetElements
		public bool Raise_ObjectSetElements_Event (SyntaxTreeCallbackReason reason, ObjectSetElements.production_kind kind, ObjectSetElements p_ObjectSetElements)
		{
			bool? status = ObjectSetElements_Event?.Invoke (reason, kind, p_ObjectSetElements);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectSetElements
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetElements
		//

		public void Traverse (ObjectSetElements p_ObjectSetElements)
		{
			if (p_ObjectSetElements.isLocked())
				return;
			p_ObjectSetElements.dolock();
			ObjectSetElements.production_kind kind = (ObjectSetElements.production_kind) p_ObjectSetElements.kind;
			p_ObjectSetElements.turn_reset ();
			if (Raise_ObjectSetElements_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectSetElements))
			switch (kind)
			{
				case ObjectSetElements.production_kind.g_ObjectSetElements_1:
					// traverse syntax tree node associated with production
					// ObjectSetElements: Object

					if (Raise_ObjectSetElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetElements))
						Traverse (p_ObjectSetElements.m_Object);
					p_ObjectSetElements.turn_inc ();
					Raise_ObjectSetElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetElements);
				break;
				case ObjectSetElements.production_kind.g_ObjectSetElements_2:
					// traverse syntax tree node associated with production
					// ObjectSetElements: DefinedObjectSet

					if (Raise_ObjectSetElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetElements))
						Traverse (p_ObjectSetElements.m_DefinedObjectSet);
					p_ObjectSetElements.turn_inc ();
					Raise_ObjectSetElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetElements);
				break;
				case ObjectSetElements.production_kind.g_ObjectSetElements_3:
					// traverse syntax tree node associated with production
					// ObjectSetElements: ObjectSetFromObjects

					if (Raise_ObjectSetElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetElements))
						Traverse (p_ObjectSetElements.m_ObjectSetFromObjects);
					p_ObjectSetElements.turn_inc ();
					Raise_ObjectSetElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetElements);
				break;
				case ObjectSetElements.production_kind.g_ObjectSetElements_4:
					// traverse syntax tree node associated with production
					// ObjectSetElements: ParameterizedObjectSet

					if (Raise_ObjectSetElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetElements))
						Traverse (p_ObjectSetElements.m_ParameterizedObjectSet);
					p_ObjectSetElements.turn_inc ();
					Raise_ObjectSetElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetElements);
				break;
			}
			Raise_ObjectSetElements_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectSetElements);
			p_ObjectSetElements.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetElements
		//

		public void TraverseCommon (ObjectSetElements p_ObjectSetElements)
		{
			ObjectSetElements.production_kind kind = (ObjectSetElements.production_kind) p_ObjectSetElements.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectSetElements))
			switch (kind)
			{
				case ObjectSetElements.production_kind.g_ObjectSetElements_1:
					// traverse syntax tree node associated with production
					// ObjectSetElements: Object

						TraverseCommon (p_ObjectSetElements.m_Object);
				break;
				case ObjectSetElements.production_kind.g_ObjectSetElements_2:
					// traverse syntax tree node associated with production
					// ObjectSetElements: DefinedObjectSet

						TraverseCommon (p_ObjectSetElements.m_DefinedObjectSet);
				break;
				case ObjectSetElements.production_kind.g_ObjectSetElements_3:
					// traverse syntax tree node associated with production
					// ObjectSetElements: ObjectSetFromObjects

						TraverseCommon (p_ObjectSetElements.m_ObjectSetFromObjects);
				break;
				case ObjectSetElements.production_kind.g_ObjectSetElements_4:
					// traverse syntax tree node associated with production
					// ObjectSetElements: ParameterizedObjectSet

						TraverseCommon (p_ObjectSetElements.m_ParameterizedObjectSet);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectSetElements);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectSetElements

		//
		// create syntax tree node associated with production
		// ObjectSetElements: Object

		//

		public ObjectSetElements ObjectSetElements_1 (Object p_Object)
		{
			ObjectSetElements p_ObjectSetElements_ref = new ObjectSetElements(p_Object);
			p_Object.parent = p_ObjectSetElements_ref;
			Raise_ObjectSetElements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectSetElements.production_kind.g_ObjectSetElements_1, p_ObjectSetElements_ref);
			return p_ObjectSetElements_ref;
		}

		//
		// create syntax tree node associated with production
		// ObjectSetElements: DefinedObjectSet

		//

		public ObjectSetElements ObjectSetElements_2 (DefinedObjectSet p_DefinedObjectSet)
		{
			ObjectSetElements p_ObjectSetElements_ref = new ObjectSetElements(p_DefinedObjectSet);
			p_DefinedObjectSet.parent = p_ObjectSetElements_ref;
			Raise_ObjectSetElements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectSetElements.production_kind.g_ObjectSetElements_2, p_ObjectSetElements_ref);
			return p_ObjectSetElements_ref;
		}

		//
		// create syntax tree node associated with production
		// ObjectSetElements: ObjectSetFromObjects

		//

		public ObjectSetElements ObjectSetElements_3 (ObjectSetFromObjects p_ObjectSetFromObjects)
		{
			ObjectSetElements p_ObjectSetElements_ref = new ObjectSetElements(p_ObjectSetFromObjects);
			p_ObjectSetFromObjects.parent = p_ObjectSetElements_ref;
			Raise_ObjectSetElements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectSetElements.production_kind.g_ObjectSetElements_3, p_ObjectSetElements_ref);
			return p_ObjectSetElements_ref;
		}

		//
		// create syntax tree node associated with production
		// ObjectSetElements: ParameterizedObjectSet

		//

		public ObjectSetElements ObjectSetElements_4 (ParameterizedObjectSet p_ParameterizedObjectSet)
		{
			ObjectSetElements p_ObjectSetElements_ref = new ObjectSetElements(p_ParameterizedObjectSet);
			p_ParameterizedObjectSet.parent = p_ObjectSetElements_ref;
			Raise_ObjectSetElements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectSetElements.production_kind.g_ObjectSetElements_4, p_ObjectSetElements_ref);
			return p_ObjectSetElements_ref;
		}
		#endregion
	};
}
