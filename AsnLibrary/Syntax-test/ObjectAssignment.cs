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
	// class associated with syntax rule ObjectAssignment
	//

	[DataContract]
	public class	ObjectAssignment : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectAssignment
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectAssignment
		{
			g_ObjectAssignment_1 = 1,	// objectreference-token DefinedObjectClass "::=" Object

		};
		#endregion
		#region production markers associated with the syntax rule ObjectAssignment

		// markers associated with production: ObjectAssignment -> objectreference-token DefinedObjectClass "::=" Object

		public enum production_marker_1 : ushort
		{
			m_objectreference_token,
			m_DefinedObjectClass,
			m_Object,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectAssignment

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectAssignment

		//
		// Constructor associated with the following production(s)
		// ObjectAssignment -> objectreference-token DefinedObjectClass "::=" Object

		//

		public ObjectAssignment (objectreference_token p_objectreference_token, DefinedObjectClass p_DefinedObjectClass, SyntaxTreeToken p_token, Object p_Object) : base ((uint) ProductionID._ObjectAssignment_ID, (uint) production_kind.g_ObjectAssignment_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_objectreference_token = p_objectreference_token;
			children[1] = m_DefinedObjectClass = p_DefinedObjectClass;
			children[2] = m_assignment_sign = p_token;
			children[3] = m_Object = p_Object;
		}

		public ObjectAssignment () { }

		// Copy constructor

		public ObjectAssignment (ObjectAssignment p_ObjectAssignment) : base (p_ObjectAssignment.id, p_ObjectAssignment.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectAssignment.appInfo;
			switch ((production_kind) p_ObjectAssignment.kind)
			{
				case production_kind.g_ObjectAssignment_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_objectreference_token = (p_ObjectAssignment.m_objectreference_token != null) ? new objectreference_token (p_ObjectAssignment.m_objectreference_token) : null) != null) m_objectreference_token.parent = this;
					if ((children [1] = m_DefinedObjectClass = (p_ObjectAssignment.m_DefinedObjectClass != null) ? new DefinedObjectClass (p_ObjectAssignment.m_DefinedObjectClass) : null) != null) m_DefinedObjectClass.parent = this;
					if ((children [2] = m_assignment_sign = (p_ObjectAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_ObjectAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [3] = m_Object = (p_ObjectAssignment.m_Object != null) ? new Object (p_ObjectAssignment.m_Object) : null) != null) m_Object.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectAssignment" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectAssignment (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_objectreference_token?.Dispose ();
			m_DefinedObjectClass?.Dispose ();
			m_assignment_sign?.Dispose ();
			m_Object?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectAssignment

		// Content changing function(s) associated with production(s) of syntax rule ObjectAssignment

		//
		// Content changing function associated with following production(s)
		// ObjectAssignment -> objectreference-token DefinedObjectClass "::=" Object

		//

		public void change(objectreference_token p_objectreference_token, DefinedObjectClass p_DefinedObjectClass, SyntaxTreeToken p_token, Object p_Object)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectAssignment_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_objectreference_token = p_objectreference_token;
			children [1] = m_DefinedObjectClass = p_DefinedObjectClass;
			children [2] = m_assignment_sign = p_token;
			children [3] = m_Object = p_Object;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectAssignment
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_objectreference_token != null) && m_objectreference_token.checkInclusion (element) ||
				(m_DefinedObjectClass != null) && m_DefinedObjectClass.checkInclusion (element) ||
				(m_assignment_sign != null) && m_assignment_sign.checkInclusion (element) ||
				(m_Object != null) && m_Object.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectAssignment

		//
		// emit production tree node associated with any production of syntax rule ObjectAssignment
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectAssignment_1:
					// emit syntax tree node associated with production
					// ObjectAssignment: objectreference-token DefinedObjectClass "::=" Object

					s += m_objectreference_token.Emit (depth - 1);
					s += " ";
					s += m_DefinedObjectClass.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_Object.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectAssignment
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectAssignment (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectAssignment_1:
					// emit syntax tree node associated with production
					// ObjectAssignment: objectreference-token DefinedObjectClass "::=" Object

					s += m_objectreference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_DefinedObjectClass.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_Object.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectAssignment

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectAssignment with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectAssignment.production_kind kind = (ObjectAssignment.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectAssignment.production_kind.g_ObjectAssignment_1:
					// traverse syntax tree node associated with production
					// ObjectAssignment: objectreference-token DefinedObjectClass "::=" Object

						m_objectreference_token.Visit (visitor, appData);
						m_DefinedObjectClass.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_Object.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_objectreference_token?.reparent (this);
			m_DefinedObjectClass?.reparent (this);
			m_assignment_sign?.reparent (this);
			m_Object?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectAssignment
		//

		public void _init ()
		{
			m_objectreference_token = null;
			m_DefinedObjectClass = null;
			m_assignment_sign = null;
			m_Object = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectAssignment

		// counter of all nodes associated with syntax rule ObjectAssignment
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectAssignment
		[DataMember (Name = "m_objectreference_token")] public objectreference_token m_objectreference_token { get; private set; }
		[DataMember (Name = "m_DefinedObjectClass")] public DefinedObjectClass m_DefinedObjectClass { get; private set; }
		[DataMember (Name = "m_assignment_sign")] public SyntaxTreeToken m_assignment_sign { get; private set; }
		[DataMember (Name = "m_Object")] public Object m_Object { get; private set; }

		public enum __object_markers
		{
			push_governor = 2,
			pop_governor = 3,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectAssignment

		// delegate function (callback) prototype associated with syntax rule ObjectAssignment
		public delegate bool ObjectAssignment_Callback (SyntaxTreeCallbackReason reason, ObjectAssignment.production_kind kind, ObjectAssignment p_ObjectAssignment);

		// event associated with syntax rule ObjectAssignment
		public event ObjectAssignment_Callback ObjectAssignment_Event;

		// event trigger associated with syntax rule ObjectAssignment
		public bool Raise_ObjectAssignment_Event (SyntaxTreeCallbackReason reason, ObjectAssignment.production_kind kind, ObjectAssignment p_ObjectAssignment)
		{
			bool? status = ObjectAssignment_Event?.Invoke (reason, kind, p_ObjectAssignment);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectAssignment
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectAssignment
		//

		public void Traverse (ObjectAssignment p_ObjectAssignment)
		{
			if (p_ObjectAssignment.isLocked())
				return;
			p_ObjectAssignment.dolock();
			ObjectAssignment.production_kind kind = (ObjectAssignment.production_kind) p_ObjectAssignment.kind;
			p_ObjectAssignment.turn_reset ();
			if (Raise_ObjectAssignment_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectAssignment))
			switch (kind)
			{
				case ObjectAssignment.production_kind.g_ObjectAssignment_1:
					// traverse syntax tree node associated with production
					// ObjectAssignment: objectreference-token DefinedObjectClass "::=" Object

					if (Raise_ObjectAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectAssignment))
						Traverse (p_ObjectAssignment.m_objectreference_token);
					p_ObjectAssignment.turn_inc ();
					if (Raise_ObjectAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectAssignment))
						Traverse (p_ObjectAssignment.m_DefinedObjectClass);
					p_ObjectAssignment.turn_inc ();
					if (Raise_ObjectAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectAssignment))
						Traverse (p_ObjectAssignment.m_Object);
					p_ObjectAssignment.turn_inc ();
					Raise_ObjectAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectAssignment);
				break;
			}
			Raise_ObjectAssignment_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectAssignment);
			p_ObjectAssignment.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectAssignment
		//

		public void TraverseCommon (ObjectAssignment p_ObjectAssignment)
		{
			ObjectAssignment.production_kind kind = (ObjectAssignment.production_kind) p_ObjectAssignment.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectAssignment))
			switch (kind)
			{
				case ObjectAssignment.production_kind.g_ObjectAssignment_1:
					// traverse syntax tree node associated with production
					// ObjectAssignment: objectreference-token DefinedObjectClass "::=" Object

						TraverseCommon (p_ObjectAssignment.m_objectreference_token);
						TraverseCommon (p_ObjectAssignment.m_DefinedObjectClass);
						TraverseCommon (p_ObjectAssignment.m_assignment_sign);
						TraverseCommon (p_ObjectAssignment.m_Object);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectAssignment);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectAssignment

		//
		// create syntax tree node associated with production
		// ObjectAssignment: objectreference-token DefinedObjectClass "::=" Object

		//

		public ObjectAssignment ObjectAssignment_1 (objectreference_token p_objectreference_token, DefinedObjectClass p_DefinedObjectClass, SyntaxTreeToken p_token, Object p_Object)
		{
			ObjectAssignment p_ObjectAssignment_ref = new ObjectAssignment(p_objectreference_token, p_DefinedObjectClass, p_token, p_Object);
			p_objectreference_token.parent = p_ObjectAssignment_ref;
			p_DefinedObjectClass.parent = p_ObjectAssignment_ref;
			p_token.parent = p_ObjectAssignment_ref;
			p_Object.parent = p_ObjectAssignment_ref;
			Raise_ObjectAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectAssignment.production_kind.g_ObjectAssignment_1, p_ObjectAssignment_ref);
			return p_ObjectAssignment_ref;
		}
		#endregion
	};
}
