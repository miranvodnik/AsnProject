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
	// class associated with syntax rule TypeFromObject
	//

	[DataContract]
	public class	TypeFromObject : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TypeFromObject
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TypeFromObject
		{
			g_TypeFromObject_1 = 1,	// ReferencedObjects "." FieldName

		};
		#endregion
		#region production markers associated with the syntax rule TypeFromObject

		// markers associated with production: TypeFromObject -> ReferencedObjects "." FieldName

		public enum production_marker_1 : ushort
		{
			m_ReferencedObjects,
			m_FieldName,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TypeFromObject

		// Constructor declaration(s) associated with production(s) of syntax rule TypeFromObject

		//
		// Constructor associated with the following production(s)
		// TypeFromObject -> ReferencedObjects "." FieldName

		//

		public TypeFromObject (ReferencedObjects p_ReferencedObjects, SyntaxTreeToken p_token, FieldName p_FieldName) : base ((uint) ProductionID._TypeFromObject_ID, (uint) production_kind.g_TypeFromObject_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_ReferencedObjects = p_ReferencedObjects;
			children[1] = m_dot = p_token;
			children[2] = m_FieldName = p_FieldName;
		}

		public TypeFromObject () { }

		// Copy constructor

		public TypeFromObject (TypeFromObject p_TypeFromObject) : base (p_TypeFromObject.id, p_TypeFromObject.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TypeFromObject.appInfo;
			switch ((production_kind) p_TypeFromObject.kind)
			{
				case production_kind.g_TypeFromObject_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_ReferencedObjects = (p_TypeFromObject.m_ReferencedObjects != null) ? new ReferencedObjects (p_TypeFromObject.m_ReferencedObjects) : null) != null) m_ReferencedObjects.parent = this;
					if ((children [1] = m_dot = (p_TypeFromObject.m_dot != null) ? new SyntaxTreeToken (p_TypeFromObject.m_dot) : null) != null) m_dot.parent = this;
					if ((children [2] = m_FieldName = (p_TypeFromObject.m_FieldName != null) ? new FieldName (p_TypeFromObject.m_FieldName) : null) != null) m_FieldName.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TypeFromObject" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TypeFromObject (this); }

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
		#region Content changing and inclusion checking methods associated with the syntax rule TypeFromObject

		// Content changing function(s) associated with production(s) of syntax rule TypeFromObject

		//
		// Content changing function associated with following production(s)
		// TypeFromObject -> ReferencedObjects "." FieldName

		//

		public void change(ReferencedObjects p_ReferencedObjects, SyntaxTreeToken p_token, FieldName p_FieldName)
		{
			_init ();
			this.kind = (uint) production_kind.g_TypeFromObject_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_ReferencedObjects = p_ReferencedObjects;
			children [1] = m_dot = p_token;
			children [2] = m_FieldName = p_FieldName;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TypeFromObject
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
		#region Syntax tree emit methods associated with the syntax rule TypeFromObject

		//
		// emit production tree node associated with any production of syntax rule TypeFromObject
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TypeFromObject_1:
					// emit syntax tree node associated with production
					// TypeFromObject: ReferencedObjects "." FieldName

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
		// emit production tree node associated with any production of syntax rule TypeFromObject
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TypeFromObject (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TypeFromObject_1:
					// emit syntax tree node associated with production
					// TypeFromObject: ReferencedObjects "." FieldName

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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TypeFromObject

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TypeFromObject with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TypeFromObject.production_kind kind = (TypeFromObject.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TypeFromObject.production_kind.g_TypeFromObject_1:
					// traverse syntax tree node associated with production
					// TypeFromObject: ReferencedObjects "." FieldName

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
		// initialize object associated with syntax rule TypeFromObject
		//

		public void _init ()
		{
			m_ReferencedObjects = null;
			m_dot = null;
			m_FieldName = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TypeFromObject

		// counter of all nodes associated with syntax rule TypeFromObject
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TypeFromObject
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
		#region delegates and events associated with the syntax rule TypeFromObject

		// delegate function (callback) prototype associated with syntax rule TypeFromObject
		public delegate bool TypeFromObject_Callback (SyntaxTreeCallbackReason reason, TypeFromObject.production_kind kind, TypeFromObject p_TypeFromObject);

		// event associated with syntax rule TypeFromObject
		public event TypeFromObject_Callback TypeFromObject_Event;

		// event trigger associated with syntax rule TypeFromObject
		public bool Raise_TypeFromObject_Event (SyntaxTreeCallbackReason reason, TypeFromObject.production_kind kind, TypeFromObject p_TypeFromObject)
		{
			bool? status = TypeFromObject_Event?.Invoke (reason, kind, p_TypeFromObject);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TypeFromObject
		//
		// traverse syntax tree node associated with any production of syntax rule TypeFromObject
		//

		public void Traverse (TypeFromObject p_TypeFromObject)
		{
			if (p_TypeFromObject.isLocked())
				return;
			p_TypeFromObject.dolock();
			TypeFromObject.production_kind kind = (TypeFromObject.production_kind) p_TypeFromObject.kind;
			p_TypeFromObject.turn_reset ();
			if (Raise_TypeFromObject_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TypeFromObject))
			switch (kind)
			{
				case TypeFromObject.production_kind.g_TypeFromObject_1:
					// traverse syntax tree node associated with production
					// TypeFromObject: ReferencedObjects "." FieldName

					if (Raise_TypeFromObject_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeFromObject))
						Traverse (p_TypeFromObject.m_ReferencedObjects);
					p_TypeFromObject.turn_inc ();
					if (Raise_TypeFromObject_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeFromObject))
						Traverse (p_TypeFromObject.m_FieldName);
					p_TypeFromObject.turn_inc ();
					Raise_TypeFromObject_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeFromObject);
				break;
			}
			Raise_TypeFromObject_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TypeFromObject);
			p_TypeFromObject.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TypeFromObject
		//

		public void TraverseCommon (TypeFromObject p_TypeFromObject)
		{
			TypeFromObject.production_kind kind = (TypeFromObject.production_kind) p_TypeFromObject.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TypeFromObject))
			switch (kind)
			{
				case TypeFromObject.production_kind.g_TypeFromObject_1:
					// traverse syntax tree node associated with production
					// TypeFromObject: ReferencedObjects "." FieldName

						TraverseCommon (p_TypeFromObject.m_ReferencedObjects);
						TraverseCommon (p_TypeFromObject.m_dot);
						TraverseCommon (p_TypeFromObject.m_FieldName);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TypeFromObject);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TypeFromObject

		//
		// create syntax tree node associated with production
		// TypeFromObject: ReferencedObjects "." FieldName

		//

		public TypeFromObject TypeFromObject_1 (ReferencedObjects p_ReferencedObjects, SyntaxTreeToken p_token, FieldName p_FieldName)
		{
			TypeFromObject p_TypeFromObject_ref = new TypeFromObject(p_ReferencedObjects, p_token, p_FieldName);
			p_ReferencedObjects.parent = p_TypeFromObject_ref;
			p_token.parent = p_TypeFromObject_ref;
			p_FieldName.parent = p_TypeFromObject_ref;
			Raise_TypeFromObject_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeFromObject.production_kind.g_TypeFromObject_1, p_TypeFromObject_ref);
			return p_TypeFromObject_ref;
		}
		#endregion
	};
}
