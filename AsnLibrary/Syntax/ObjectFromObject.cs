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
	// class associated with syntax rule ObjectFromObject
	//

	[DataContract]
	public class	ObjectFromObject : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectFromObject
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectFromObject
		{
			g_ObjectFromObject_1 = 1,	// ReferencedObjects "." FieldName

		};
		#endregion
		#region production markers associated with the syntax rule ObjectFromObject

		// markers associated with production: ObjectFromObject -> ReferencedObjects "." FieldName

		public enum production_marker_1 : ushort
		{
			m_ReferencedObjects,
			m_FieldName,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectFromObject

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectFromObject

		//
		// Constructor associated with the following production(s)
		// ObjectFromObject -> ReferencedObjects "." FieldName

		//

		public ObjectFromObject (ReferencedObjects p_ReferencedObjects, SyntaxTreeToken p_token, FieldName p_FieldName) : base ((uint) ProductionID._ObjectFromObject_ID, (uint) production_kind.g_ObjectFromObject_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_ReferencedObjects = p_ReferencedObjects;
			children[1] = m_dot = p_token;
			children[2] = m_FieldName = p_FieldName;
		}

		public ObjectFromObject () { }

		// Copy constructor

		public ObjectFromObject (ObjectFromObject p_ObjectFromObject) : base (p_ObjectFromObject.id, p_ObjectFromObject.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectFromObject.appInfo;
			switch ((production_kind) p_ObjectFromObject.kind)
			{
				case production_kind.g_ObjectFromObject_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_ReferencedObjects = (p_ObjectFromObject.m_ReferencedObjects != null) ? new ReferencedObjects (p_ObjectFromObject.m_ReferencedObjects) : null) != null) m_ReferencedObjects.parent = this;
					if ((children [1] = m_dot = (p_ObjectFromObject.m_dot != null) ? new SyntaxTreeToken (p_ObjectFromObject.m_dot) : null) != null) m_dot.parent = this;
					if ((children [2] = m_FieldName = (p_ObjectFromObject.m_FieldName != null) ? new FieldName (p_ObjectFromObject.m_FieldName) : null) != null) m_FieldName.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectFromObject" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectFromObject (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ReferencedObjects?.Dispose ();
			m_dot?.Dispose ();
			m_FieldName?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectFromObject

		// Content changing function(s) associated with production(s) of syntax rule ObjectFromObject

		//
		// Content changing function associated with following production(s)
		// ObjectFromObject -> ReferencedObjects "." FieldName

		//

		public void change(ReferencedObjects p_ReferencedObjects, SyntaxTreeToken p_token, FieldName p_FieldName)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectFromObject_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_ReferencedObjects = p_ReferencedObjects;
			children [1] = m_dot = p_token;
			children [2] = m_FieldName = p_FieldName;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectFromObject
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ReferencedObjects != null) && m_ReferencedObjects.checkInclusion (element) ||
				(m_dot != null) && m_dot.checkInclusion (element) ||
				(m_FieldName != null) && m_FieldName.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectFromObject

		//
		// emit production tree node associated with any production of syntax rule ObjectFromObject
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectFromObject_1:
					// emit syntax tree node associated with production
					// ObjectFromObject: ReferencedObjects "." FieldName

					s += m_ReferencedObjects.Emit (depth - 1);
					s += " ";
					s += m_dot.Emit (depth - 1);
					s += " ";
					s += m_FieldName.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectFromObject
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectFromObject (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectFromObject_1:
					// emit syntax tree node associated with production
					// ObjectFromObject: ReferencedObjects "." FieldName

					s += m_ReferencedObjects.EmitProductionTree (depth - 1);
					s += ' ';
					s += "dot";
					s += ' ';
					s += m_FieldName.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectFromObject

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectFromObject with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectFromObject.production_kind kind = (ObjectFromObject.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectFromObject.production_kind.g_ObjectFromObject_1:
					// traverse syntax tree node associated with production
					// ObjectFromObject: ReferencedObjects "." FieldName

						m_ReferencedObjects.Visit (visitor, appData);
						m_dot.Visit (visitor, appData);
						m_FieldName.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ReferencedObjects?.reparent (this);
			m_dot?.reparent (this);
			m_FieldName?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectFromObject
		//

		public void _init ()
		{
			m_ReferencedObjects = null;
			m_dot = null;
			m_FieldName = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectFromObject

		// counter of all nodes associated with syntax rule ObjectFromObject
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectFromObject
		[DataMember (Name = "m_ReferencedObjects")] public ReferencedObjects m_ReferencedObjects { get; private set; }
		[DataMember (Name = "m_dot")] public SyntaxTreeToken m_dot { get; private set; }
		[DataMember (Name = "m_FieldName")] public FieldName m_FieldName { get; private set; }

		public enum __p1_markers
		{
			m1 = 1,
			m2 = 2,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectFromObject

		// delegate function (callback) prototype associated with syntax rule ObjectFromObject
		public delegate bool ObjectFromObject_Callback (SyntaxTreeCallbackReason reason, ObjectFromObject.production_kind kind, ObjectFromObject p_ObjectFromObject);

		// event associated with syntax rule ObjectFromObject
		public event ObjectFromObject_Callback ObjectFromObject_Event;

		// event trigger associated with syntax rule ObjectFromObject
		public bool Raise_ObjectFromObject_Event (SyntaxTreeCallbackReason reason, ObjectFromObject.production_kind kind, ObjectFromObject p_ObjectFromObject)
		{
			bool? status = ObjectFromObject_Event?.Invoke (reason, kind, p_ObjectFromObject);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectFromObject
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectFromObject
		//

		public void Traverse (ObjectFromObject p_ObjectFromObject)
		{
			if (p_ObjectFromObject.isLocked())
				return;
			p_ObjectFromObject.dolock();
			ObjectFromObject.production_kind kind = (ObjectFromObject.production_kind) p_ObjectFromObject.kind;
			p_ObjectFromObject.turn_reset ();
			if (Raise_ObjectFromObject_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectFromObject))
			switch (kind)
			{
				case ObjectFromObject.production_kind.g_ObjectFromObject_1:
					// traverse syntax tree node associated with production
					// ObjectFromObject: ReferencedObjects "." FieldName

					if (Raise_ObjectFromObject_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectFromObject))
						Traverse (p_ObjectFromObject.m_ReferencedObjects);
					p_ObjectFromObject.turn_inc ();
					if (Raise_ObjectFromObject_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectFromObject))
						Traverse (p_ObjectFromObject.m_FieldName);
					p_ObjectFromObject.turn_inc ();
					Raise_ObjectFromObject_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectFromObject);
				break;
			}
			Raise_ObjectFromObject_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectFromObject);
			p_ObjectFromObject.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectFromObject
		//

		public void TraverseCommon (ObjectFromObject p_ObjectFromObject)
		{
			ObjectFromObject.production_kind kind = (ObjectFromObject.production_kind) p_ObjectFromObject.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectFromObject))
			switch (kind)
			{
				case ObjectFromObject.production_kind.g_ObjectFromObject_1:
					// traverse syntax tree node associated with production
					// ObjectFromObject: ReferencedObjects "." FieldName

						TraverseCommon (p_ObjectFromObject.m_ReferencedObjects);
						TraverseCommon (p_ObjectFromObject.m_dot);
						TraverseCommon (p_ObjectFromObject.m_FieldName);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectFromObject);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectFromObject

		//
		// create syntax tree node associated with production
		// ObjectFromObject: ReferencedObjects "." FieldName

		//

		public ObjectFromObject ObjectFromObject_1 (ReferencedObjects p_ReferencedObjects, SyntaxTreeToken p_token, FieldName p_FieldName)
		{
			ObjectFromObject p_ObjectFromObject_ref = new ObjectFromObject(p_ReferencedObjects, p_token, p_FieldName);
			p_ReferencedObjects.parent = p_ObjectFromObject_ref;
			p_token.parent = p_ObjectFromObject_ref;
			p_FieldName.parent = p_ObjectFromObject_ref;
			Raise_ObjectFromObject_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectFromObject.production_kind.g_ObjectFromObject_1, p_ObjectFromObject_ref);
			return p_ObjectFromObject_ref;
		}
		#endregion
	};
}
