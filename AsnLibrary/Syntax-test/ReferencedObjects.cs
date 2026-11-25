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
	// class associated with syntax rule ReferencedObjects
	//

	[DataContract]
	public class	ReferencedObjects : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ReferencedObjects
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ReferencedObjects
		{
			g_ReferencedObjects_1 = 1,	// DefinedObject

			g_ReferencedObjects_2 = 2,	// ParameterizedObject

			g_ReferencedObjects_3 = 3,	// DefinedObjectSet

			g_ReferencedObjects_4 = 4,	// ParameterizedObjectSet

		};
		#endregion
		#region production markers associated with the syntax rule ReferencedObjects

		// markers associated with production: ReferencedObjects -> DefinedObject

		public enum production_marker_1 : ushort
		{
			m_DefinedObject,
			final
		};

		// markers associated with production: ReferencedObjects -> ParameterizedObject

		public enum production_marker_2 : ushort
		{
			m_ParameterizedObject,
			final
		};

		// markers associated with production: ReferencedObjects -> DefinedObjectSet

		public enum production_marker_3 : ushort
		{
			m_DefinedObjectSet,
			final
		};

		// markers associated with production: ReferencedObjects -> ParameterizedObjectSet

		public enum production_marker_4 : ushort
		{
			m_ParameterizedObjectSet,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ReferencedObjects

		// Constructor declaration(s) associated with production(s) of syntax rule ReferencedObjects

		//
		// Constructor associated with the following production(s)
		// ReferencedObjects -> DefinedObject

		//

		public ReferencedObjects (DefinedObject p_DefinedObject) : base ((uint) ProductionID._ReferencedObjects_ID, (uint) production_kind.g_ReferencedObjects_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinedObject = p_DefinedObject;
		}

		//
		// Constructor associated with the following production(s)
		// ReferencedObjects -> ParameterizedObject

		//

		public ReferencedObjects (ParameterizedObject p_ParameterizedObject) : base ((uint) ProductionID._ReferencedObjects_ID, (uint) production_kind.g_ReferencedObjects_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ParameterizedObject = p_ParameterizedObject;
		}

		//
		// Constructor associated with the following production(s)
		// ReferencedObjects -> DefinedObjectSet

		//

		public ReferencedObjects (DefinedObjectSet p_DefinedObjectSet) : base ((uint) ProductionID._ReferencedObjects_ID, (uint) production_kind.g_ReferencedObjects_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinedObjectSet = p_DefinedObjectSet;
		}

		//
		// Constructor associated with the following production(s)
		// ReferencedObjects -> ParameterizedObjectSet

		//

		public ReferencedObjects (ParameterizedObjectSet p_ParameterizedObjectSet) : base ((uint) ProductionID._ReferencedObjects_ID, (uint) production_kind.g_ReferencedObjects_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ParameterizedObjectSet = p_ParameterizedObjectSet;
		}

		public ReferencedObjects () { }

		// Copy constructor

		public ReferencedObjects (ReferencedObjects p_ReferencedObjects) : base (p_ReferencedObjects.id, p_ReferencedObjects.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ReferencedObjects.appInfo;
			switch ((production_kind) p_ReferencedObjects.kind)
			{
				case production_kind.g_ReferencedObjects_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinedObject = (p_ReferencedObjects.m_DefinedObject != null) ? new DefinedObject (p_ReferencedObjects.m_DefinedObject) : null) != null) m_DefinedObject.parent = this;
					break;
				case production_kind.g_ReferencedObjects_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ParameterizedObject = (p_ReferencedObjects.m_ParameterizedObject != null) ? new ParameterizedObject (p_ReferencedObjects.m_ParameterizedObject) : null) != null) m_ParameterizedObject.parent = this;
					break;
				case production_kind.g_ReferencedObjects_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinedObjectSet = (p_ReferencedObjects.m_DefinedObjectSet != null) ? new DefinedObjectSet (p_ReferencedObjects.m_DefinedObjectSet) : null) != null) m_DefinedObjectSet.parent = this;
					break;
				case production_kind.g_ReferencedObjects_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ParameterizedObjectSet = (p_ReferencedObjects.m_ParameterizedObjectSet != null) ? new ParameterizedObjectSet (p_ReferencedObjects.m_ParameterizedObjectSet) : null) != null) m_ParameterizedObjectSet.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ReferencedObjects" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ReferencedObjects (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DefinedObject?.Dispose ();
			m_ParameterizedObject?.Dispose ();
			m_DefinedObjectSet?.Dispose ();
			m_ParameterizedObjectSet?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ReferencedObjects

		// Content changing function(s) associated with production(s) of syntax rule ReferencedObjects

		//
		// Content changing function associated with following production(s)
		// ReferencedObjects -> DefinedObject

		//

		public void change(DefinedObject p_DefinedObject)
		{
			_init ();
			this.kind = (uint) production_kind.g_ReferencedObjects_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinedObject = p_DefinedObject;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ReferencedObjects -> ParameterizedObject

		//

		public void change(ParameterizedObject p_ParameterizedObject)
		{
			_init ();
			this.kind = (uint) production_kind.g_ReferencedObjects_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ParameterizedObject = p_ParameterizedObject;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ReferencedObjects -> DefinedObjectSet

		//

		public void change(DefinedObjectSet p_DefinedObjectSet)
		{
			_init ();
			this.kind = (uint) production_kind.g_ReferencedObjects_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinedObjectSet = p_DefinedObjectSet;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ReferencedObjects -> ParameterizedObjectSet

		//

		public void change(ParameterizedObjectSet p_ParameterizedObjectSet)
		{
			_init ();
			this.kind = (uint) production_kind.g_ReferencedObjects_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ParameterizedObjectSet = p_ParameterizedObjectSet;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ReferencedObjects
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DefinedObject != null) && m_DefinedObject.checkInclusion (element) ||
				(m_ParameterizedObject != null) && m_ParameterizedObject.checkInclusion (element) ||
				(m_DefinedObjectSet != null) && m_DefinedObjectSet.checkInclusion (element) ||
				(m_ParameterizedObjectSet != null) && m_ParameterizedObjectSet.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ReferencedObjects

		//
		// emit production tree node associated with any production of syntax rule ReferencedObjects
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ReferencedObjects_1:
					// emit syntax tree node associated with production
					// ReferencedObjects: DefinedObject

					s += m_DefinedObject.Emit (depth - 1);
				break;
				case production_kind.g_ReferencedObjects_2:
					// emit syntax tree node associated with production
					// ReferencedObjects: ParameterizedObject

					s += m_ParameterizedObject.Emit (depth - 1);
				break;
				case production_kind.g_ReferencedObjects_3:
					// emit syntax tree node associated with production
					// ReferencedObjects: DefinedObjectSet

					s += m_DefinedObjectSet.Emit (depth - 1);
				break;
				case production_kind.g_ReferencedObjects_4:
					// emit syntax tree node associated with production
					// ReferencedObjects: ParameterizedObjectSet

					s += m_ParameterizedObjectSet.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ReferencedObjects
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ReferencedObjects (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ReferencedObjects_1:
					// emit syntax tree node associated with production
					// ReferencedObjects: DefinedObject

					s += m_DefinedObject.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ReferencedObjects_2:
					// emit syntax tree node associated with production
					// ReferencedObjects: ParameterizedObject

					s += m_ParameterizedObject.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ReferencedObjects_3:
					// emit syntax tree node associated with production
					// ReferencedObjects: DefinedObjectSet

					s += m_DefinedObjectSet.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ReferencedObjects_4:
					// emit syntax tree node associated with production
					// ReferencedObjects: ParameterizedObjectSet

					s += m_ParameterizedObjectSet.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ReferencedObjects

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ReferencedObjects with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ReferencedObjects.production_kind kind = (ReferencedObjects.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ReferencedObjects.production_kind.g_ReferencedObjects_1:
					// traverse syntax tree node associated with production
					// ReferencedObjects: DefinedObject

						m_DefinedObject.Visit (visitor, appData);
				break;
				case ReferencedObjects.production_kind.g_ReferencedObjects_2:
					// traverse syntax tree node associated with production
					// ReferencedObjects: ParameterizedObject

						m_ParameterizedObject.Visit (visitor, appData);
				break;
				case ReferencedObjects.production_kind.g_ReferencedObjects_3:
					// traverse syntax tree node associated with production
					// ReferencedObjects: DefinedObjectSet

						m_DefinedObjectSet.Visit (visitor, appData);
				break;
				case ReferencedObjects.production_kind.g_ReferencedObjects_4:
					// traverse syntax tree node associated with production
					// ReferencedObjects: ParameterizedObjectSet

						m_ParameterizedObjectSet.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DefinedObject?.reparent (this);
			m_ParameterizedObject?.reparent (this);
			m_DefinedObjectSet?.reparent (this);
			m_ParameterizedObjectSet?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ReferencedObjects
		//

		public void _init ()
		{
			m_DefinedObject = null;
			m_ParameterizedObject = null;
			m_DefinedObjectSet = null;
			m_ParameterizedObjectSet = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ReferencedObjects

		// counter of all nodes associated with syntax rule ReferencedObjects
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ReferencedObjects
		[DataMember (Name = "m_DefinedObject")] public DefinedObject m_DefinedObject { get; private set; }
		[DataMember (Name = "m_ParameterizedObject")] public ParameterizedObject m_ParameterizedObject { get; private set; }
		[DataMember (Name = "m_DefinedObjectSet")] public DefinedObjectSet m_DefinedObjectSet { get; private set; }
		[DataMember (Name = "m_ParameterizedObjectSet")] public ParameterizedObjectSet m_ParameterizedObjectSet { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ReferencedObjects

		// delegate function (callback) prototype associated with syntax rule ReferencedObjects
		public delegate bool ReferencedObjects_Callback (SyntaxTreeCallbackReason reason, ReferencedObjects.production_kind kind, ReferencedObjects p_ReferencedObjects);

		// event associated with syntax rule ReferencedObjects
		public event ReferencedObjects_Callback ReferencedObjects_Event;

		// event trigger associated with syntax rule ReferencedObjects
		public bool Raise_ReferencedObjects_Event (SyntaxTreeCallbackReason reason, ReferencedObjects.production_kind kind, ReferencedObjects p_ReferencedObjects)
		{
			bool? status = ReferencedObjects_Event?.Invoke (reason, kind, p_ReferencedObjects);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ReferencedObjects
		//
		// traverse syntax tree node associated with any production of syntax rule ReferencedObjects
		//

		public void Traverse (ReferencedObjects p_ReferencedObjects)
		{
			if (p_ReferencedObjects.isLocked())
				return;
			p_ReferencedObjects.dolock();
			ReferencedObjects.production_kind kind = (ReferencedObjects.production_kind) p_ReferencedObjects.kind;
			p_ReferencedObjects.turn_reset ();
			if (Raise_ReferencedObjects_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ReferencedObjects))
			switch (kind)
			{
				case ReferencedObjects.production_kind.g_ReferencedObjects_1:
					// traverse syntax tree node associated with production
					// ReferencedObjects: DefinedObject

					if (Raise_ReferencedObjects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedObjects))
						Traverse (p_ReferencedObjects.m_DefinedObject);
					p_ReferencedObjects.turn_inc ();
					Raise_ReferencedObjects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedObjects);
				break;
				case ReferencedObjects.production_kind.g_ReferencedObjects_2:
					// traverse syntax tree node associated with production
					// ReferencedObjects: ParameterizedObject

					if (Raise_ReferencedObjects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedObjects))
						Traverse (p_ReferencedObjects.m_ParameterizedObject);
					p_ReferencedObjects.turn_inc ();
					Raise_ReferencedObjects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedObjects);
				break;
				case ReferencedObjects.production_kind.g_ReferencedObjects_3:
					// traverse syntax tree node associated with production
					// ReferencedObjects: DefinedObjectSet

					if (Raise_ReferencedObjects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedObjects))
						Traverse (p_ReferencedObjects.m_DefinedObjectSet);
					p_ReferencedObjects.turn_inc ();
					Raise_ReferencedObjects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedObjects);
				break;
				case ReferencedObjects.production_kind.g_ReferencedObjects_4:
					// traverse syntax tree node associated with production
					// ReferencedObjects: ParameterizedObjectSet

					if (Raise_ReferencedObjects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedObjects))
						Traverse (p_ReferencedObjects.m_ParameterizedObjectSet);
					p_ReferencedObjects.turn_inc ();
					Raise_ReferencedObjects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedObjects);
				break;
			}
			Raise_ReferencedObjects_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ReferencedObjects);
			p_ReferencedObjects.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ReferencedObjects
		//

		public void TraverseCommon (ReferencedObjects p_ReferencedObjects)
		{
			ReferencedObjects.production_kind kind = (ReferencedObjects.production_kind) p_ReferencedObjects.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ReferencedObjects))
			switch (kind)
			{
				case ReferencedObjects.production_kind.g_ReferencedObjects_1:
					// traverse syntax tree node associated with production
					// ReferencedObjects: DefinedObject

						TraverseCommon (p_ReferencedObjects.m_DefinedObject);
				break;
				case ReferencedObjects.production_kind.g_ReferencedObjects_2:
					// traverse syntax tree node associated with production
					// ReferencedObjects: ParameterizedObject

						TraverseCommon (p_ReferencedObjects.m_ParameterizedObject);
				break;
				case ReferencedObjects.production_kind.g_ReferencedObjects_3:
					// traverse syntax tree node associated with production
					// ReferencedObjects: DefinedObjectSet

						TraverseCommon (p_ReferencedObjects.m_DefinedObjectSet);
				break;
				case ReferencedObjects.production_kind.g_ReferencedObjects_4:
					// traverse syntax tree node associated with production
					// ReferencedObjects: ParameterizedObjectSet

						TraverseCommon (p_ReferencedObjects.m_ParameterizedObjectSet);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ReferencedObjects);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ReferencedObjects

		//
		// create syntax tree node associated with production
		// ReferencedObjects: DefinedObject

		//

		public ReferencedObjects ReferencedObjects_1 (DefinedObject p_DefinedObject)
		{
			ReferencedObjects p_ReferencedObjects_ref = new ReferencedObjects(p_DefinedObject);
			p_DefinedObject.parent = p_ReferencedObjects_ref;
			Raise_ReferencedObjects_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ReferencedObjects.production_kind.g_ReferencedObjects_1, p_ReferencedObjects_ref);
			return p_ReferencedObjects_ref;
		}

		//
		// create syntax tree node associated with production
		// ReferencedObjects: ParameterizedObject

		//

		public ReferencedObjects ReferencedObjects_2 (ParameterizedObject p_ParameterizedObject)
		{
			ReferencedObjects p_ReferencedObjects_ref = new ReferencedObjects(p_ParameterizedObject);
			p_ParameterizedObject.parent = p_ReferencedObjects_ref;
			Raise_ReferencedObjects_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ReferencedObjects.production_kind.g_ReferencedObjects_2, p_ReferencedObjects_ref);
			return p_ReferencedObjects_ref;
		}

		//
		// create syntax tree node associated with production
		// ReferencedObjects: DefinedObjectSet

		//

		public ReferencedObjects ReferencedObjects_3 (DefinedObjectSet p_DefinedObjectSet)
		{
			ReferencedObjects p_ReferencedObjects_ref = new ReferencedObjects(p_DefinedObjectSet);
			p_DefinedObjectSet.parent = p_ReferencedObjects_ref;
			Raise_ReferencedObjects_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ReferencedObjects.production_kind.g_ReferencedObjects_3, p_ReferencedObjects_ref);
			return p_ReferencedObjects_ref;
		}

		//
		// create syntax tree node associated with production
		// ReferencedObjects: ParameterizedObjectSet

		//

		public ReferencedObjects ReferencedObjects_4 (ParameterizedObjectSet p_ParameterizedObjectSet)
		{
			ReferencedObjects p_ReferencedObjects_ref = new ReferencedObjects(p_ParameterizedObjectSet);
			p_ParameterizedObjectSet.parent = p_ReferencedObjects_ref;
			Raise_ReferencedObjects_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ReferencedObjects.production_kind.g_ReferencedObjects_4, p_ReferencedObjects_ref);
			return p_ReferencedObjects_ref;
		}
		#endregion
	};
}
