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
	// class associated with syntax rule ParameterizedObjectSetAssignment
	//

	[DataContract]
	public class	ParameterizedObjectSetAssignment : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ParameterizedObjectSetAssignment
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ParameterizedObjectSetAssignment
		{
			g_ParameterizedObjectSetAssignment_1 = 1,	// objectsetreference-token ParameterList DefinedObjectClass "::=" ObjectSet

		};
		#endregion
		#region production markers associated with the syntax rule ParameterizedObjectSetAssignment

		// markers associated with production: ParameterizedObjectSetAssignment -> objectsetreference-token ParameterList DefinedObjectClass "::=" ObjectSet

		public enum production_marker_1 : ushort
		{
			m_objectsetreference_token,
			m_ParameterList,
			m_DefinedObjectClass,
			m_ObjectSet,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ParameterizedObjectSetAssignment

		// Constructor declaration(s) associated with production(s) of syntax rule ParameterizedObjectSetAssignment

		//
		// Constructor associated with the following production(s)
		// ParameterizedObjectSetAssignment -> objectsetreference-token ParameterList DefinedObjectClass "::=" ObjectSet

		//

		public ParameterizedObjectSetAssignment (objectsetreference_token p_objectsetreference_token, ParameterList p_ParameterList, DefinedObjectClass p_DefinedObjectClass, SyntaxTreeToken p_token, ObjectSet p_ObjectSet) : base ((uint) ProductionID._ParameterizedObjectSetAssignment_ID, (uint) production_kind.g_ParameterizedObjectSetAssignment_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children[0] = m_objectsetreference_token = p_objectsetreference_token;
			children[1] = m_ParameterList = p_ParameterList;
			children[2] = m_DefinedObjectClass = p_DefinedObjectClass;
			children[3] = m_assignment_sign = p_token;
			children[4] = m_ObjectSet = p_ObjectSet;
		}

		public ParameterizedObjectSetAssignment () { }

		// Copy constructor

		public ParameterizedObjectSetAssignment (ParameterizedObjectSetAssignment p_ParameterizedObjectSetAssignment) : base (p_ParameterizedObjectSetAssignment.id, p_ParameterizedObjectSetAssignment.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ParameterizedObjectSetAssignment.appInfo;
			switch ((production_kind) p_ParameterizedObjectSetAssignment.kind)
			{
				case production_kind.g_ParameterizedObjectSetAssignment_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_objectsetreference_token = (p_ParameterizedObjectSetAssignment.m_objectsetreference_token != null) ? new objectsetreference_token (p_ParameterizedObjectSetAssignment.m_objectsetreference_token) : null) != null) m_objectsetreference_token.parent = this;
					if ((children [1] = m_ParameterList = (p_ParameterizedObjectSetAssignment.m_ParameterList != null) ? new ParameterList (p_ParameterizedObjectSetAssignment.m_ParameterList) : null) != null) m_ParameterList.parent = this;
					if ((children [2] = m_DefinedObjectClass = (p_ParameterizedObjectSetAssignment.m_DefinedObjectClass != null) ? new DefinedObjectClass (p_ParameterizedObjectSetAssignment.m_DefinedObjectClass) : null) != null) m_DefinedObjectClass.parent = this;
					if ((children [3] = m_assignment_sign = (p_ParameterizedObjectSetAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_ParameterizedObjectSetAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [4] = m_ObjectSet = (p_ParameterizedObjectSetAssignment.m_ObjectSet != null) ? new ObjectSet (p_ParameterizedObjectSetAssignment.m_ObjectSet) : null) != null) m_ObjectSet.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ParameterizedObjectSetAssignment" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ParameterizedObjectSetAssignment (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_objectsetreference_token?.Dispose ();
			m_ParameterList?.Dispose ();
			m_DefinedObjectClass?.Dispose ();
			m_assignment_sign?.Dispose ();
			m_ObjectSet?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ParameterizedObjectSetAssignment

		// Content changing function(s) associated with production(s) of syntax rule ParameterizedObjectSetAssignment

		//
		// Content changing function associated with following production(s)
		// ParameterizedObjectSetAssignment -> objectsetreference-token ParameterList DefinedObjectClass "::=" ObjectSet

		//

		public void change(objectsetreference_token p_objectsetreference_token, ParameterList p_ParameterList, DefinedObjectClass p_DefinedObjectClass, SyntaxTreeToken p_token, ObjectSet p_ObjectSet)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedObjectSetAssignment_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children [0] = m_objectsetreference_token = p_objectsetreference_token;
			children [1] = m_ParameterList = p_ParameterList;
			children [2] = m_DefinedObjectClass = p_DefinedObjectClass;
			children [3] = m_assignment_sign = p_token;
			children [4] = m_ObjectSet = p_ObjectSet;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ParameterizedObjectSetAssignment
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_objectsetreference_token != null) && m_objectsetreference_token.checkInclusion (element) ||
				(m_ParameterList != null) && m_ParameterList.checkInclusion (element) ||
				(m_DefinedObjectClass != null) && m_DefinedObjectClass.checkInclusion (element) ||
				(m_assignment_sign != null) && m_assignment_sign.checkInclusion (element) ||
				(m_ObjectSet != null) && m_ObjectSet.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ParameterizedObjectSetAssignment

		//
		// emit production tree node associated with any production of syntax rule ParameterizedObjectSetAssignment
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ParameterizedObjectSetAssignment_1:
					// emit syntax tree node associated with production
					// ParameterizedObjectSetAssignment: objectsetreference-token ParameterList DefinedObjectClass "::=" ObjectSet

					s += m_objectsetreference_token.Emit (depth - 1);
					s += " ";
					s += m_ParameterList.Emit (depth - 1);
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
		// emit production tree node associated with any production of syntax rule ParameterizedObjectSetAssignment
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ParameterizedObjectSetAssignment (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ParameterizedObjectSetAssignment_1:
					// emit syntax tree node associated with production
					// ParameterizedObjectSetAssignment: objectsetreference-token ParameterList DefinedObjectClass "::=" ObjectSet

					s += m_objectsetreference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ParameterList.EmitProductionTree (depth - 1);
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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ParameterizedObjectSetAssignment

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedObjectSetAssignment with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ParameterizedObjectSetAssignment.production_kind kind = (ParameterizedObjectSetAssignment.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ParameterizedObjectSetAssignment.production_kind.g_ParameterizedObjectSetAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedObjectSetAssignment: objectsetreference-token ParameterList DefinedObjectClass "::=" ObjectSet

						m_objectsetreference_token.Visit (visitor, appData);
						m_ParameterList.Visit (visitor, appData);
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
			m_ParameterList?.reparent (this);
			m_DefinedObjectClass?.reparent (this);
			m_assignment_sign?.reparent (this);
			m_ObjectSet?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ParameterizedObjectSetAssignment
		//

		public void _init ()
		{
			m_objectsetreference_token = null;
			m_ParameterList = null;
			m_DefinedObjectClass = null;
			m_assignment_sign = null;
			m_ObjectSet = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ParameterizedObjectSetAssignment

		// counter of all nodes associated with syntax rule ParameterizedObjectSetAssignment
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ParameterizedObjectSetAssignment
		[DataMember (Name = "m_objectsetreference_token")] public objectsetreference_token m_objectsetreference_token { get; private set; }
		[DataMember (Name = "m_ParameterList")] public ParameterList m_ParameterList { get; private set; }
		[DataMember (Name = "m_DefinedObjectClass")] public DefinedObjectClass m_DefinedObjectClass { get; private set; }
		[DataMember (Name = "m_assignment_sign")] public SyntaxTreeToken m_assignment_sign { get; private set; }
		[DataMember (Name = "m_ObjectSet")] public ObjectSet m_ObjectSet { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ParameterizedObjectSetAssignment

		// delegate function (callback) prototype associated with syntax rule ParameterizedObjectSetAssignment
		public delegate bool ParameterizedObjectSetAssignment_Callback (SyntaxTreeCallbackReason reason, ParameterizedObjectSetAssignment.production_kind kind, ParameterizedObjectSetAssignment p_ParameterizedObjectSetAssignment);

		// event associated with syntax rule ParameterizedObjectSetAssignment
		public event ParameterizedObjectSetAssignment_Callback ParameterizedObjectSetAssignment_Event;

		// event trigger associated with syntax rule ParameterizedObjectSetAssignment
		public bool Raise_ParameterizedObjectSetAssignment_Event (SyntaxTreeCallbackReason reason, ParameterizedObjectSetAssignment.production_kind kind, ParameterizedObjectSetAssignment p_ParameterizedObjectSetAssignment)
		{
			bool? status = ParameterizedObjectSetAssignment_Event?.Invoke (reason, kind, p_ParameterizedObjectSetAssignment);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ParameterizedObjectSetAssignment
		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedObjectSetAssignment
		//

		public void Traverse (ParameterizedObjectSetAssignment p_ParameterizedObjectSetAssignment)
		{
			if (p_ParameterizedObjectSetAssignment.isLocked())
				return;
			p_ParameterizedObjectSetAssignment.dolock();
			ParameterizedObjectSetAssignment.production_kind kind = (ParameterizedObjectSetAssignment.production_kind) p_ParameterizedObjectSetAssignment.kind;
			p_ParameterizedObjectSetAssignment.turn_reset ();
			if (Raise_ParameterizedObjectSetAssignment_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ParameterizedObjectSetAssignment))
			switch (kind)
			{
				case ParameterizedObjectSetAssignment.production_kind.g_ParameterizedObjectSetAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedObjectSetAssignment: objectsetreference-token ParameterList DefinedObjectClass "::=" ObjectSet

					if (Raise_ParameterizedObjectSetAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectSetAssignment))
						Traverse (p_ParameterizedObjectSetAssignment.m_objectsetreference_token);
					p_ParameterizedObjectSetAssignment.turn_inc ();
					if (Raise_ParameterizedObjectSetAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectSetAssignment))
						Traverse (p_ParameterizedObjectSetAssignment.m_ParameterList);
					p_ParameterizedObjectSetAssignment.turn_inc ();
					if (Raise_ParameterizedObjectSetAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectSetAssignment))
						Traverse (p_ParameterizedObjectSetAssignment.m_DefinedObjectClass);
					p_ParameterizedObjectSetAssignment.turn_inc ();
					if (Raise_ParameterizedObjectSetAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectSetAssignment))
						Traverse (p_ParameterizedObjectSetAssignment.m_ObjectSet);
					p_ParameterizedObjectSetAssignment.turn_inc ();
					Raise_ParameterizedObjectSetAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectSetAssignment);
				break;
			}
			Raise_ParameterizedObjectSetAssignment_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ParameterizedObjectSetAssignment);
			p_ParameterizedObjectSetAssignment.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedObjectSetAssignment
		//

		public void TraverseCommon (ParameterizedObjectSetAssignment p_ParameterizedObjectSetAssignment)
		{
			ParameterizedObjectSetAssignment.production_kind kind = (ParameterizedObjectSetAssignment.production_kind) p_ParameterizedObjectSetAssignment.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ParameterizedObjectSetAssignment))
			switch (kind)
			{
				case ParameterizedObjectSetAssignment.production_kind.g_ParameterizedObjectSetAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedObjectSetAssignment: objectsetreference-token ParameterList DefinedObjectClass "::=" ObjectSet

						TraverseCommon (p_ParameterizedObjectSetAssignment.m_objectsetreference_token);
						TraverseCommon (p_ParameterizedObjectSetAssignment.m_ParameterList);
						TraverseCommon (p_ParameterizedObjectSetAssignment.m_DefinedObjectClass);
						TraverseCommon (p_ParameterizedObjectSetAssignment.m_assignment_sign);
						TraverseCommon (p_ParameterizedObjectSetAssignment.m_ObjectSet);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ParameterizedObjectSetAssignment);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ParameterizedObjectSetAssignment

		//
		// create syntax tree node associated with production
		// ParameterizedObjectSetAssignment: objectsetreference-token ParameterList DefinedObjectClass "::=" ObjectSet

		//

		public ParameterizedObjectSetAssignment ParameterizedObjectSetAssignment_1 (objectsetreference_token p_objectsetreference_token, ParameterList p_ParameterList, DefinedObjectClass p_DefinedObjectClass, SyntaxTreeToken p_token, ObjectSet p_ObjectSet)
		{
			ParameterizedObjectSetAssignment p_ParameterizedObjectSetAssignment_ref = new ParameterizedObjectSetAssignment(p_objectsetreference_token, p_ParameterList, p_DefinedObjectClass, p_token, p_ObjectSet);
			p_objectsetreference_token.parent = p_ParameterizedObjectSetAssignment_ref;
			p_ParameterList.parent = p_ParameterizedObjectSetAssignment_ref;
			p_DefinedObjectClass.parent = p_ParameterizedObjectSetAssignment_ref;
			p_token.parent = p_ParameterizedObjectSetAssignment_ref;
			p_ObjectSet.parent = p_ParameterizedObjectSetAssignment_ref;
			Raise_ParameterizedObjectSetAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedObjectSetAssignment.production_kind.g_ParameterizedObjectSetAssignment_1, p_ParameterizedObjectSetAssignment_ref);
			return p_ParameterizedObjectSetAssignment_ref;
		}
		#endregion
	};
}
