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
	// class associated with syntax rule ObjectSetFromObjects
	//

	[DataContract]
	public class	ObjectSetFromObjects : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectSetFromObjects
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectSetFromObjects
		{
			g_ObjectSetFromObjects_1 = 1,	// ReferencedObjects "." FieldName

		};
		#endregion
		#region production markers associated with the syntax rule ObjectSetFromObjects

		// markers associated with production: ObjectSetFromObjects -> ReferencedObjects "." FieldName

		public enum production_marker_1 : ushort
		{
			m_ReferencedObjects,
			m_FieldName,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectSetFromObjects

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectSetFromObjects

		//
		// Constructor associated with the following production(s)
		// ObjectSetFromObjects -> ReferencedObjects "." FieldName

		//

		public ObjectSetFromObjects (ReferencedObjects p_ReferencedObjects, SyntaxTreeToken p_token, FieldName p_FieldName) : base ((uint) ProductionID._ObjectSetFromObjects_ID, (uint) production_kind.g_ObjectSetFromObjects_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_ReferencedObjects = p_ReferencedObjects;
			children[1] = m_dot = p_token;
			children[2] = m_FieldName = p_FieldName;
		}

		public ObjectSetFromObjects () { }

		// Copy constructor

		public ObjectSetFromObjects (ObjectSetFromObjects p_ObjectSetFromObjects) : base (p_ObjectSetFromObjects.id, p_ObjectSetFromObjects.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectSetFromObjects.appInfo;
			switch ((production_kind) p_ObjectSetFromObjects.kind)
			{
				case production_kind.g_ObjectSetFromObjects_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_ReferencedObjects = (p_ObjectSetFromObjects.m_ReferencedObjects != null) ? new ReferencedObjects (p_ObjectSetFromObjects.m_ReferencedObjects) : null) != null) m_ReferencedObjects.parent = this;
					if ((children [1] = m_dot = (p_ObjectSetFromObjects.m_dot != null) ? new SyntaxTreeToken (p_ObjectSetFromObjects.m_dot) : null) != null) m_dot.parent = this;
					if ((children [2] = m_FieldName = (p_ObjectSetFromObjects.m_FieldName != null) ? new FieldName (p_ObjectSetFromObjects.m_FieldName) : null) != null) m_FieldName.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectSetFromObjects" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectSetFromObjects (this); }

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
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectSetFromObjects

		// Content changing function(s) associated with production(s) of syntax rule ObjectSetFromObjects

		//
		// Content changing function associated with following production(s)
		// ObjectSetFromObjects -> ReferencedObjects "." FieldName

		//

		public void change(ReferencedObjects p_ReferencedObjects, SyntaxTreeToken p_token, FieldName p_FieldName)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectSetFromObjects_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_ReferencedObjects = p_ReferencedObjects;
			children [1] = m_dot = p_token;
			children [2] = m_FieldName = p_FieldName;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectSetFromObjects
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
		#region Syntax tree emit methods associated with the syntax rule ObjectSetFromObjects

		//
		// emit production tree node associated with any production of syntax rule ObjectSetFromObjects
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectSetFromObjects_1:
					// emit syntax tree node associated with production
					// ObjectSetFromObjects: ReferencedObjects "." FieldName

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
		// emit production tree node associated with any production of syntax rule ObjectSetFromObjects
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectSetFromObjects (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectSetFromObjects_1:
					// emit syntax tree node associated with production
					// ObjectSetFromObjects: ReferencedObjects "." FieldName

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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectSetFromObjects

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetFromObjects with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectSetFromObjects.production_kind kind = (ObjectSetFromObjects.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectSetFromObjects.production_kind.g_ObjectSetFromObjects_1:
					// traverse syntax tree node associated with production
					// ObjectSetFromObjects: ReferencedObjects "." FieldName

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
		// initialize object associated with syntax rule ObjectSetFromObjects
		//

		public void _init ()
		{
			m_ReferencedObjects = null;
			m_dot = null;
			m_FieldName = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectSetFromObjects

		// counter of all nodes associated with syntax rule ObjectSetFromObjects
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectSetFromObjects
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
		#region delegates and events associated with the syntax rule ObjectSetFromObjects

		// delegate function (callback) prototype associated with syntax rule ObjectSetFromObjects
		public delegate bool ObjectSetFromObjects_Callback (SyntaxTreeCallbackReason reason, ObjectSetFromObjects.production_kind kind, ObjectSetFromObjects p_ObjectSetFromObjects);

		// event associated with syntax rule ObjectSetFromObjects
		public event ObjectSetFromObjects_Callback ObjectSetFromObjects_Event;

		// event trigger associated with syntax rule ObjectSetFromObjects
		public bool Raise_ObjectSetFromObjects_Event (SyntaxTreeCallbackReason reason, ObjectSetFromObjects.production_kind kind, ObjectSetFromObjects p_ObjectSetFromObjects)
		{
			bool? status = ObjectSetFromObjects_Event?.Invoke (reason, kind, p_ObjectSetFromObjects);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectSetFromObjects
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetFromObjects
		//

		public void Traverse (ObjectSetFromObjects p_ObjectSetFromObjects)
		{
			if (p_ObjectSetFromObjects.isLocked())
				return;
			p_ObjectSetFromObjects.dolock();
			ObjectSetFromObjects.production_kind kind = (ObjectSetFromObjects.production_kind) p_ObjectSetFromObjects.kind;
			p_ObjectSetFromObjects.turn_reset ();
			if (Raise_ObjectSetFromObjects_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectSetFromObjects))
			switch (kind)
			{
				case ObjectSetFromObjects.production_kind.g_ObjectSetFromObjects_1:
					// traverse syntax tree node associated with production
					// ObjectSetFromObjects: ReferencedObjects "." FieldName

					if (Raise_ObjectSetFromObjects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetFromObjects))
						Traverse (p_ObjectSetFromObjects.m_ReferencedObjects);
					p_ObjectSetFromObjects.turn_inc ();
					if (Raise_ObjectSetFromObjects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetFromObjects))
						Traverse (p_ObjectSetFromObjects.m_FieldName);
					p_ObjectSetFromObjects.turn_inc ();
					Raise_ObjectSetFromObjects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetFromObjects);
				break;
			}
			Raise_ObjectSetFromObjects_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectSetFromObjects);
			p_ObjectSetFromObjects.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetFromObjects
		//

		public void TraverseCommon (ObjectSetFromObjects p_ObjectSetFromObjects)
		{
			ObjectSetFromObjects.production_kind kind = (ObjectSetFromObjects.production_kind) p_ObjectSetFromObjects.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectSetFromObjects))
			switch (kind)
			{
				case ObjectSetFromObjects.production_kind.g_ObjectSetFromObjects_1:
					// traverse syntax tree node associated with production
					// ObjectSetFromObjects: ReferencedObjects "." FieldName

						TraverseCommon (p_ObjectSetFromObjects.m_ReferencedObjects);
						TraverseCommon (p_ObjectSetFromObjects.m_dot);
						TraverseCommon (p_ObjectSetFromObjects.m_FieldName);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectSetFromObjects);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectSetFromObjects

		//
		// create syntax tree node associated with production
		// ObjectSetFromObjects: ReferencedObjects "." FieldName

		//

		public ObjectSetFromObjects ObjectSetFromObjects_1 (ReferencedObjects p_ReferencedObjects, SyntaxTreeToken p_token, FieldName p_FieldName)
		{
			ObjectSetFromObjects p_ObjectSetFromObjects_ref = new ObjectSetFromObjects(p_ReferencedObjects, p_token, p_FieldName);
			p_ReferencedObjects.parent = p_ObjectSetFromObjects_ref;
			p_token.parent = p_ObjectSetFromObjects_ref;
			p_FieldName.parent = p_ObjectSetFromObjects_ref;
			Raise_ObjectSetFromObjects_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectSetFromObjects.production_kind.g_ObjectSetFromObjects_1, p_ObjectSetFromObjects_ref);
			return p_ObjectSetFromObjects_ref;
		}
		#endregion
	};
}
