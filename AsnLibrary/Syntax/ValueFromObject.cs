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
	// class associated with syntax rule ValueFromObject
	//

	[DataContract]
	public class	ValueFromObject : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ValueFromObject
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ValueFromObject
		{
			g_ValueFromObject_1 = 1,	// ReferencedObjects "." FieldName

		};
		#endregion
		#region production markers associated with the syntax rule ValueFromObject

		// markers associated with production: ValueFromObject -> ReferencedObjects "." FieldName

		public enum production_marker_1 : ushort
		{
			m_ReferencedObjects,
			m_FieldName,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ValueFromObject

		// Constructor declaration(s) associated with production(s) of syntax rule ValueFromObject

		//
		// Constructor associated with the following production(s)
		// ValueFromObject -> ReferencedObjects "." FieldName

		//

		public ValueFromObject (ReferencedObjects p_ReferencedObjects, SyntaxTreeToken p_token, FieldName p_FieldName) : base ((uint) ProductionID._ValueFromObject_ID, (uint) production_kind.g_ValueFromObject_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_ReferencedObjects = p_ReferencedObjects;
			children[1] = m_dot = p_token;
			children[2] = m_FieldName = p_FieldName;
		}

		public ValueFromObject () { }

		// Copy constructor

		public ValueFromObject (ValueFromObject p_ValueFromObject) : base (p_ValueFromObject.id, p_ValueFromObject.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ValueFromObject.appInfo;
			switch ((production_kind) p_ValueFromObject.kind)
			{
				case production_kind.g_ValueFromObject_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_ReferencedObjects = (p_ValueFromObject.m_ReferencedObjects != null) ? new ReferencedObjects (p_ValueFromObject.m_ReferencedObjects) : null) != null) m_ReferencedObjects.parent = this;
					if ((children [1] = m_dot = (p_ValueFromObject.m_dot != null) ? new SyntaxTreeToken (p_ValueFromObject.m_dot) : null) != null) m_dot.parent = this;
					if ((children [2] = m_FieldName = (p_ValueFromObject.m_FieldName != null) ? new FieldName (p_ValueFromObject.m_FieldName) : null) != null) m_FieldName.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ValueFromObject" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ValueFromObject (this); }

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
		#region Content changing and inclusion checking methods associated with the syntax rule ValueFromObject

		// Content changing function(s) associated with production(s) of syntax rule ValueFromObject

		//
		// Content changing function associated with following production(s)
		// ValueFromObject -> ReferencedObjects "." FieldName

		//

		public void change(ReferencedObjects p_ReferencedObjects, SyntaxTreeToken p_token, FieldName p_FieldName)
		{
			_init ();
			this.kind = (uint) production_kind.g_ValueFromObject_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_ReferencedObjects = p_ReferencedObjects;
			children [1] = m_dot = p_token;
			children [2] = m_FieldName = p_FieldName;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ValueFromObject
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
		#region Syntax tree emit methods associated with the syntax rule ValueFromObject

		//
		// emit production tree node associated with any production of syntax rule ValueFromObject
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ValueFromObject_1:
					// emit syntax tree node associated with production
					// ValueFromObject: ReferencedObjects "." FieldName

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
		// emit production tree node associated with any production of syntax rule ValueFromObject
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ValueFromObject (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ValueFromObject_1:
					// emit syntax tree node associated with production
					// ValueFromObject: ReferencedObjects "." FieldName

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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ValueFromObject

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ValueFromObject with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ValueFromObject.production_kind kind = (ValueFromObject.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ValueFromObject.production_kind.g_ValueFromObject_1:
					// traverse syntax tree node associated with production
					// ValueFromObject: ReferencedObjects "." FieldName

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
		// initialize object associated with syntax rule ValueFromObject
		//

		public void _init ()
		{
			m_ReferencedObjects = null;
			m_dot = null;
			m_FieldName = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ValueFromObject

		// counter of all nodes associated with syntax rule ValueFromObject
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ValueFromObject
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
		#region delegates and events associated with the syntax rule ValueFromObject

		// delegate function (callback) prototype associated with syntax rule ValueFromObject
		public delegate bool ValueFromObject_Callback (SyntaxTreeCallbackReason reason, ValueFromObject.production_kind kind, ValueFromObject p_ValueFromObject);

		// event associated with syntax rule ValueFromObject
		public event ValueFromObject_Callback ValueFromObject_Event;

		// event trigger associated with syntax rule ValueFromObject
		public bool Raise_ValueFromObject_Event (SyntaxTreeCallbackReason reason, ValueFromObject.production_kind kind, ValueFromObject p_ValueFromObject)
		{
			bool? status = ValueFromObject_Event?.Invoke (reason, kind, p_ValueFromObject);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ValueFromObject
		//
		// traverse syntax tree node associated with any production of syntax rule ValueFromObject
		//

		public void Traverse (ValueFromObject p_ValueFromObject)
		{
			if (p_ValueFromObject.isLocked())
				return;
			p_ValueFromObject.dolock();
			ValueFromObject.production_kind kind = (ValueFromObject.production_kind) p_ValueFromObject.kind;
			p_ValueFromObject.turn_reset ();
			if (Raise_ValueFromObject_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ValueFromObject))
			switch (kind)
			{
				case ValueFromObject.production_kind.g_ValueFromObject_1:
					// traverse syntax tree node associated with production
					// ValueFromObject: ReferencedObjects "." FieldName

					if (Raise_ValueFromObject_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueFromObject))
						Traverse (p_ValueFromObject.m_ReferencedObjects);
					p_ValueFromObject.turn_inc ();
					if (Raise_ValueFromObject_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueFromObject))
						Traverse (p_ValueFromObject.m_FieldName);
					p_ValueFromObject.turn_inc ();
					Raise_ValueFromObject_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueFromObject);
				break;
			}
			Raise_ValueFromObject_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ValueFromObject);
			p_ValueFromObject.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ValueFromObject
		//

		public void TraverseCommon (ValueFromObject p_ValueFromObject)
		{
			ValueFromObject.production_kind kind = (ValueFromObject.production_kind) p_ValueFromObject.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ValueFromObject))
			switch (kind)
			{
				case ValueFromObject.production_kind.g_ValueFromObject_1:
					// traverse syntax tree node associated with production
					// ValueFromObject: ReferencedObjects "." FieldName

						TraverseCommon (p_ValueFromObject.m_ReferencedObjects);
						TraverseCommon (p_ValueFromObject.m_dot);
						TraverseCommon (p_ValueFromObject.m_FieldName);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ValueFromObject);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ValueFromObject

		//
		// create syntax tree node associated with production
		// ValueFromObject: ReferencedObjects "." FieldName

		//

		public ValueFromObject ValueFromObject_1 (ReferencedObjects p_ReferencedObjects, SyntaxTreeToken p_token, FieldName p_FieldName)
		{
			ValueFromObject p_ValueFromObject_ref = new ValueFromObject(p_ReferencedObjects, p_token, p_FieldName);
			p_ReferencedObjects.parent = p_ValueFromObject_ref;
			p_token.parent = p_ValueFromObject_ref;
			p_FieldName.parent = p_ValueFromObject_ref;
			Raise_ValueFromObject_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ValueFromObject.production_kind.g_ValueFromObject_1, p_ValueFromObject_ref);
			return p_ValueFromObject_ref;
		}
		#endregion
	};
}
