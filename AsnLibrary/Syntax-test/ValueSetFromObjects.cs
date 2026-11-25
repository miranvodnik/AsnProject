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
	// class associated with syntax rule ValueSetFromObjects
	//

	[DataContract]
	public class	ValueSetFromObjects : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ValueSetFromObjects
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ValueSetFromObjects
		{
			g_ValueSetFromObjects_1 = 1,	// ReferencedObjects "." FieldName

		};
		#endregion
		#region production markers associated with the syntax rule ValueSetFromObjects

		// markers associated with production: ValueSetFromObjects -> ReferencedObjects "." FieldName

		public enum production_marker_1 : ushort
		{
			m_ReferencedObjects,
			m_FieldName,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ValueSetFromObjects

		// Constructor declaration(s) associated with production(s) of syntax rule ValueSetFromObjects

		//
		// Constructor associated with the following production(s)
		// ValueSetFromObjects -> ReferencedObjects "." FieldName

		//

		public ValueSetFromObjects (ReferencedObjects p_ReferencedObjects, SyntaxTreeToken p_token, FieldName p_FieldName) : base ((uint) ProductionID._ValueSetFromObjects_ID, (uint) production_kind.g_ValueSetFromObjects_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_ReferencedObjects = p_ReferencedObjects;
			children[1] = m_dot = p_token;
			children[2] = m_FieldName = p_FieldName;
		}

		public ValueSetFromObjects () { }

		// Copy constructor

		public ValueSetFromObjects (ValueSetFromObjects p_ValueSetFromObjects) : base (p_ValueSetFromObjects.id, p_ValueSetFromObjects.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ValueSetFromObjects.appInfo;
			switch ((production_kind) p_ValueSetFromObjects.kind)
			{
				case production_kind.g_ValueSetFromObjects_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_ReferencedObjects = (p_ValueSetFromObjects.m_ReferencedObjects != null) ? new ReferencedObjects (p_ValueSetFromObjects.m_ReferencedObjects) : null) != null) m_ReferencedObjects.parent = this;
					if ((children [1] = m_dot = (p_ValueSetFromObjects.m_dot != null) ? new SyntaxTreeToken (p_ValueSetFromObjects.m_dot) : null) != null) m_dot.parent = this;
					if ((children [2] = m_FieldName = (p_ValueSetFromObjects.m_FieldName != null) ? new FieldName (p_ValueSetFromObjects.m_FieldName) : null) != null) m_FieldName.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ValueSetFromObjects" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ValueSetFromObjects (this); }

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
		#region Content changing and inclusion checking methods associated with the syntax rule ValueSetFromObjects

		// Content changing function(s) associated with production(s) of syntax rule ValueSetFromObjects

		//
		// Content changing function associated with following production(s)
		// ValueSetFromObjects -> ReferencedObjects "." FieldName

		//

		public void change(ReferencedObjects p_ReferencedObjects, SyntaxTreeToken p_token, FieldName p_FieldName)
		{
			_init ();
			this.kind = (uint) production_kind.g_ValueSetFromObjects_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_ReferencedObjects = p_ReferencedObjects;
			children [1] = m_dot = p_token;
			children [2] = m_FieldName = p_FieldName;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ValueSetFromObjects
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
		#region Syntax tree emit methods associated with the syntax rule ValueSetFromObjects

		//
		// emit production tree node associated with any production of syntax rule ValueSetFromObjects
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ValueSetFromObjects_1:
					// emit syntax tree node associated with production
					// ValueSetFromObjects: ReferencedObjects "." FieldName

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
		// emit production tree node associated with any production of syntax rule ValueSetFromObjects
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ValueSetFromObjects (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ValueSetFromObjects_1:
					// emit syntax tree node associated with production
					// ValueSetFromObjects: ReferencedObjects "." FieldName

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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ValueSetFromObjects

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ValueSetFromObjects with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ValueSetFromObjects.production_kind kind = (ValueSetFromObjects.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ValueSetFromObjects.production_kind.g_ValueSetFromObjects_1:
					// traverse syntax tree node associated with production
					// ValueSetFromObjects: ReferencedObjects "." FieldName

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
		// initialize object associated with syntax rule ValueSetFromObjects
		//

		public void _init ()
		{
			m_ReferencedObjects = null;
			m_dot = null;
			m_FieldName = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ValueSetFromObjects

		// counter of all nodes associated with syntax rule ValueSetFromObjects
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ValueSetFromObjects
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
		#region delegates and events associated with the syntax rule ValueSetFromObjects

		// delegate function (callback) prototype associated with syntax rule ValueSetFromObjects
		public delegate bool ValueSetFromObjects_Callback (SyntaxTreeCallbackReason reason, ValueSetFromObjects.production_kind kind, ValueSetFromObjects p_ValueSetFromObjects);

		// event associated with syntax rule ValueSetFromObjects
		public event ValueSetFromObjects_Callback ValueSetFromObjects_Event;

		// event trigger associated with syntax rule ValueSetFromObjects
		public bool Raise_ValueSetFromObjects_Event (SyntaxTreeCallbackReason reason, ValueSetFromObjects.production_kind kind, ValueSetFromObjects p_ValueSetFromObjects)
		{
			bool? status = ValueSetFromObjects_Event?.Invoke (reason, kind, p_ValueSetFromObjects);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ValueSetFromObjects
		//
		// traverse syntax tree node associated with any production of syntax rule ValueSetFromObjects
		//

		public void Traverse (ValueSetFromObjects p_ValueSetFromObjects)
		{
			if (p_ValueSetFromObjects.isLocked())
				return;
			p_ValueSetFromObjects.dolock();
			ValueSetFromObjects.production_kind kind = (ValueSetFromObjects.production_kind) p_ValueSetFromObjects.kind;
			p_ValueSetFromObjects.turn_reset ();
			if (Raise_ValueSetFromObjects_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ValueSetFromObjects))
			switch (kind)
			{
				case ValueSetFromObjects.production_kind.g_ValueSetFromObjects_1:
					// traverse syntax tree node associated with production
					// ValueSetFromObjects: ReferencedObjects "." FieldName

					if (Raise_ValueSetFromObjects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueSetFromObjects))
						Traverse (p_ValueSetFromObjects.m_ReferencedObjects);
					p_ValueSetFromObjects.turn_inc ();
					if (Raise_ValueSetFromObjects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueSetFromObjects))
						Traverse (p_ValueSetFromObjects.m_FieldName);
					p_ValueSetFromObjects.turn_inc ();
					Raise_ValueSetFromObjects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueSetFromObjects);
				break;
			}
			Raise_ValueSetFromObjects_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ValueSetFromObjects);
			p_ValueSetFromObjects.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ValueSetFromObjects
		//

		public void TraverseCommon (ValueSetFromObjects p_ValueSetFromObjects)
		{
			ValueSetFromObjects.production_kind kind = (ValueSetFromObjects.production_kind) p_ValueSetFromObjects.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ValueSetFromObjects))
			switch (kind)
			{
				case ValueSetFromObjects.production_kind.g_ValueSetFromObjects_1:
					// traverse syntax tree node associated with production
					// ValueSetFromObjects: ReferencedObjects "." FieldName

						TraverseCommon (p_ValueSetFromObjects.m_ReferencedObjects);
						TraverseCommon (p_ValueSetFromObjects.m_dot);
						TraverseCommon (p_ValueSetFromObjects.m_FieldName);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ValueSetFromObjects);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ValueSetFromObjects

		//
		// create syntax tree node associated with production
		// ValueSetFromObjects: ReferencedObjects "." FieldName

		//

		public ValueSetFromObjects ValueSetFromObjects_1 (ReferencedObjects p_ReferencedObjects, SyntaxTreeToken p_token, FieldName p_FieldName)
		{
			ValueSetFromObjects p_ValueSetFromObjects_ref = new ValueSetFromObjects(p_ReferencedObjects, p_token, p_FieldName);
			p_ReferencedObjects.parent = p_ValueSetFromObjects_ref;
			p_token.parent = p_ValueSetFromObjects_ref;
			p_FieldName.parent = p_ValueSetFromObjects_ref;
			Raise_ValueSetFromObjects_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ValueSetFromObjects.production_kind.g_ValueSetFromObjects_1, p_ValueSetFromObjects_ref);
			return p_ValueSetFromObjects_ref;
		}
		#endregion
	};
}
