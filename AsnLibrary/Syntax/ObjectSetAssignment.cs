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
	// class associated with syntax rule ObjectSetAssignment
	//

	[DataContract]
	public class	ObjectSetAssignment : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectSetAssignment
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectSetAssignment
		{
			g_ObjectSetAssignment_1 = 1,	// objectsetreference-token DefinedObjectClass "::=" ObjectSet

		};
		#endregion
		#region production markers associated with the syntax rule ObjectSetAssignment

		// markers associated with production: ObjectSetAssignment -> objectsetreference-token DefinedObjectClass "::=" ObjectSet

		public enum production_marker_1 : ushort
		{
			m_objectsetreference_token,
			m_DefinedObjectClass,
			m_ObjectSet,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectSetAssignment

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectSetAssignment

		//
		// Constructor associated with the following production(s)
		// ObjectSetAssignment -> objectsetreference-token DefinedObjectClass "::=" ObjectSet

		//

		public ObjectSetAssignment (objectsetreference_token p_objectsetreference_token, DefinedObjectClass p_DefinedObjectClass, SyntaxTreeToken p_token, ObjectSet p_ObjectSet) : base ((uint) ProductionID._ObjectSetAssignment_ID, (uint) production_kind.g_ObjectSetAssignment_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_objectsetreference_token = p_objectsetreference_token;
			children[1] = m_DefinedObjectClass = p_DefinedObjectClass;
			children[2] = m_assignment_sign = p_token;
			children[3] = m_ObjectSet = p_ObjectSet;
		}

		public ObjectSetAssignment () { }

		// Copy constructor

		public ObjectSetAssignment (ObjectSetAssignment p_ObjectSetAssignment) : base (p_ObjectSetAssignment.id, p_ObjectSetAssignment.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectSetAssignment.appInfo;
			switch ((production_kind) p_ObjectSetAssignment.kind)
			{
				case production_kind.g_ObjectSetAssignment_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_objectsetreference_token = (p_ObjectSetAssignment.m_objectsetreference_token != null) ? new objectsetreference_token (p_ObjectSetAssignment.m_objectsetreference_token) : null) != null) m_objectsetreference_token.parent = this;
					if ((children [1] = m_DefinedObjectClass = (p_ObjectSetAssignment.m_DefinedObjectClass != null) ? new DefinedObjectClass (p_ObjectSetAssignment.m_DefinedObjectClass) : null) != null) m_DefinedObjectClass.parent = this;
					if ((children [2] = m_assignment_sign = (p_ObjectSetAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_ObjectSetAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [3] = m_ObjectSet = (p_ObjectSetAssignment.m_ObjectSet != null) ? new ObjectSet (p_ObjectSetAssignment.m_ObjectSet) : null) != null) m_ObjectSet.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectSetAssignment" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectSetAssignment (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_objectsetreference_token?.Dispose ();
			m_DefinedObjectClass?.Dispose ();
			m_assignment_sign?.Dispose ();
			m_ObjectSet?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectSetAssignment

		// Content changing function(s) associated with production(s) of syntax rule ObjectSetAssignment

		//
		// Content changing function associated with following production(s)
		// ObjectSetAssignment -> objectsetreference-token DefinedObjectClass "::=" ObjectSet

		//

		public void change(objectsetreference_token p_objectsetreference_token, DefinedObjectClass p_DefinedObjectClass, SyntaxTreeToken p_token, ObjectSet p_ObjectSet)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectSetAssignment_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_objectsetreference_token = p_objectsetreference_token;
			children [1] = m_DefinedObjectClass = p_DefinedObjectClass;
			children [2] = m_assignment_sign = p_token;
			children [3] = m_ObjectSet = p_ObjectSet;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectSetAssignment
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_objectsetreference_token != null) && m_objectsetreference_token.checkInclusion (element) ||
				(m_DefinedObjectClass != null) && m_DefinedObjectClass.checkInclusion (element) ||
				(m_assignment_sign != null) && m_assignment_sign.checkInclusion (element) ||
				(m_ObjectSet != null) && m_ObjectSet.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectSetAssignment

		//
		// emit production tree node associated with any production of syntax rule ObjectSetAssignment
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectSetAssignment_1:
					// emit syntax tree node associated with production
					// ObjectSetAssignment: objectsetreference-token DefinedObjectClass "::=" ObjectSet

					s += m_objectsetreference_token.Emit (depth - 1);
					s += " ";
					s += m_DefinedObjectClass.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_ObjectSet.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectSetAssignment
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectSetAssignment (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectSetAssignment_1:
					// emit syntax tree node associated with production
					// ObjectSetAssignment: objectsetreference-token DefinedObjectClass "::=" ObjectSet

					s += m_objectsetreference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_DefinedObjectClass.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_ObjectSet.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectSetAssignment

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetAssignment with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectSetAssignment.production_kind kind = (ObjectSetAssignment.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectSetAssignment.production_kind.g_ObjectSetAssignment_1:
					// traverse syntax tree node associated with production
					// ObjectSetAssignment: objectsetreference-token DefinedObjectClass "::=" ObjectSet

						m_objectsetreference_token.Visit (visitor, appData);
						m_DefinedObjectClass.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_ObjectSet.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_objectsetreference_token?.reparent (this);
			m_DefinedObjectClass?.reparent (this);
			m_assignment_sign?.reparent (this);
			m_ObjectSet?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectSetAssignment
		//

		public void _init ()
		{
			m_objectsetreference_token = null;
			m_DefinedObjectClass = null;
			m_assignment_sign = null;
			m_ObjectSet = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectSetAssignment

		// counter of all nodes associated with syntax rule ObjectSetAssignment
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectSetAssignment
		[DataMember (Name = "m_objectsetreference_token")] public objectsetreference_token m_objectsetreference_token { get; private set; }
		[DataMember (Name = "m_DefinedObjectClass")] public DefinedObjectClass m_DefinedObjectClass { get; private set; }
		[DataMember (Name = "m_assignment_sign")] public SyntaxTreeToken m_assignment_sign { get; private set; }
		[DataMember (Name = "m_ObjectSet")] public ObjectSet m_ObjectSet { get; private set; }

		public enum __object_set_markers
		{
			push_governor = 2,
			pop_governor = 3,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectSetAssignment

		// delegate function (callback) prototype associated with syntax rule ObjectSetAssignment
		public delegate bool ObjectSetAssignment_Callback (SyntaxTreeCallbackReason reason, ObjectSetAssignment.production_kind kind, ObjectSetAssignment p_ObjectSetAssignment);

		// event associated with syntax rule ObjectSetAssignment
		public event ObjectSetAssignment_Callback ObjectSetAssignment_Event;

		// event trigger associated with syntax rule ObjectSetAssignment
		public bool Raise_ObjectSetAssignment_Event (SyntaxTreeCallbackReason reason, ObjectSetAssignment.production_kind kind, ObjectSetAssignment p_ObjectSetAssignment)
		{
			bool? status = ObjectSetAssignment_Event?.Invoke (reason, kind, p_ObjectSetAssignment);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectSetAssignment
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetAssignment
		//

		public void Traverse (ObjectSetAssignment p_ObjectSetAssignment)
		{
			if (p_ObjectSetAssignment.isLocked())
				return;
			p_ObjectSetAssignment.dolock();
			ObjectSetAssignment.production_kind kind = (ObjectSetAssignment.production_kind) p_ObjectSetAssignment.kind;
			p_ObjectSetAssignment.turn_reset ();
			if (Raise_ObjectSetAssignment_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectSetAssignment))
			switch (kind)
			{
				case ObjectSetAssignment.production_kind.g_ObjectSetAssignment_1:
					// traverse syntax tree node associated with production
					// ObjectSetAssignment: objectsetreference-token DefinedObjectClass "::=" ObjectSet

					if (Raise_ObjectSetAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetAssignment))
						Traverse (p_ObjectSetAssignment.m_objectsetreference_token);
					p_ObjectSetAssignment.turn_inc ();
					if (Raise_ObjectSetAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetAssignment))
						Traverse (p_ObjectSetAssignment.m_DefinedObjectClass);
					p_ObjectSetAssignment.turn_inc ();
					if (Raise_ObjectSetAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetAssignment))
						Traverse (p_ObjectSetAssignment.m_ObjectSet);
					p_ObjectSetAssignment.turn_inc ();
					Raise_ObjectSetAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetAssignment);
				break;
			}
			Raise_ObjectSetAssignment_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectSetAssignment);
			p_ObjectSetAssignment.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetAssignment
		//

		public void TraverseCommon (ObjectSetAssignment p_ObjectSetAssignment)
		{
			ObjectSetAssignment.production_kind kind = (ObjectSetAssignment.production_kind) p_ObjectSetAssignment.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectSetAssignment))
			switch (kind)
			{
				case ObjectSetAssignment.production_kind.g_ObjectSetAssignment_1:
					// traverse syntax tree node associated with production
					// ObjectSetAssignment: objectsetreference-token DefinedObjectClass "::=" ObjectSet

						TraverseCommon (p_ObjectSetAssignment.m_objectsetreference_token);
						TraverseCommon (p_ObjectSetAssignment.m_DefinedObjectClass);
						TraverseCommon (p_ObjectSetAssignment.m_assignment_sign);
						TraverseCommon (p_ObjectSetAssignment.m_ObjectSet);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectSetAssignment);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectSetAssignment

		//
		// create syntax tree node associated with production
		// ObjectSetAssignment: objectsetreference-token DefinedObjectClass "::=" ObjectSet

		//

		public ObjectSetAssignment ObjectSetAssignment_1 (objectsetreference_token p_objectsetreference_token, DefinedObjectClass p_DefinedObjectClass, SyntaxTreeToken p_token, ObjectSet p_ObjectSet)
		{
			ObjectSetAssignment p_ObjectSetAssignment_ref = new ObjectSetAssignment(p_objectsetreference_token, p_DefinedObjectClass, p_token, p_ObjectSet);
			p_objectsetreference_token.parent = p_ObjectSetAssignment_ref;
			p_DefinedObjectClass.parent = p_ObjectSetAssignment_ref;
			p_token.parent = p_ObjectSetAssignment_ref;
			p_ObjectSet.parent = p_ObjectSetAssignment_ref;
			Raise_ObjectSetAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectSetAssignment.production_kind.g_ObjectSetAssignment_1, p_ObjectSetAssignment_ref);
			return p_ObjectSetAssignment_ref;
		}
		#endregion
	};
}
