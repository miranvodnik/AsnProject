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
	// class associated with syntax rule ParameterizedObjectClassAssignment
	//

	[DataContract]
	public class	ParameterizedObjectClassAssignment : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ParameterizedObjectClassAssignment
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ParameterizedObjectClassAssignment
		{
			g_ParameterizedObjectClassAssignment_1 = 1,	// objectclassreference-token ParameterList "::=" ObjectClass

		};
		#endregion
		#region production markers associated with the syntax rule ParameterizedObjectClassAssignment

		// markers associated with production: ParameterizedObjectClassAssignment -> objectclassreference-token ParameterList "::=" ObjectClass

		public enum production_marker_1 : ushort
		{
			m_objectclassreference_token,
			m_ParameterList,
			m_ObjectClass,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ParameterizedObjectClassAssignment

		// Constructor declaration(s) associated with production(s) of syntax rule ParameterizedObjectClassAssignment

		//
		// Constructor associated with the following production(s)
		// ParameterizedObjectClassAssignment -> objectclassreference-token ParameterList "::=" ObjectClass

		//

		public ParameterizedObjectClassAssignment (objectclassreference_token p_objectclassreference_token, ParameterList p_ParameterList, SyntaxTreeToken p_token, ObjectClass p_ObjectClass) : base ((uint) ProductionID._ParameterizedObjectClassAssignment_ID, (uint) production_kind.g_ParameterizedObjectClassAssignment_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_objectclassreference_token = p_objectclassreference_token;
			children[1] = m_ParameterList = p_ParameterList;
			children[2] = m_assignment_sign = p_token;
			children[3] = m_ObjectClass = p_ObjectClass;
		}

		public ParameterizedObjectClassAssignment () { }

		// Copy constructor

		public ParameterizedObjectClassAssignment (ParameterizedObjectClassAssignment p_ParameterizedObjectClassAssignment) : base (p_ParameterizedObjectClassAssignment.id, p_ParameterizedObjectClassAssignment.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ParameterizedObjectClassAssignment.appInfo;
			switch ((production_kind) p_ParameterizedObjectClassAssignment.kind)
			{
				case production_kind.g_ParameterizedObjectClassAssignment_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_objectclassreference_token = (p_ParameterizedObjectClassAssignment.m_objectclassreference_token != null) ? new objectclassreference_token (p_ParameterizedObjectClassAssignment.m_objectclassreference_token) : null) != null) m_objectclassreference_token.parent = this;
					if ((children [1] = m_ParameterList = (p_ParameterizedObjectClassAssignment.m_ParameterList != null) ? new ParameterList (p_ParameterizedObjectClassAssignment.m_ParameterList) : null) != null) m_ParameterList.parent = this;
					if ((children [2] = m_assignment_sign = (p_ParameterizedObjectClassAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_ParameterizedObjectClassAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [3] = m_ObjectClass = (p_ParameterizedObjectClassAssignment.m_ObjectClass != null) ? new ObjectClass (p_ParameterizedObjectClassAssignment.m_ObjectClass) : null) != null) m_ObjectClass.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ParameterizedObjectClassAssignment" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ParameterizedObjectClassAssignment (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_objectclassreference_token?.Dispose ();
			m_ParameterList?.Dispose ();
			m_assignment_sign?.Dispose ();
			m_ObjectClass?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ParameterizedObjectClassAssignment

		// Content changing function(s) associated with production(s) of syntax rule ParameterizedObjectClassAssignment

		//
		// Content changing function associated with following production(s)
		// ParameterizedObjectClassAssignment -> objectclassreference-token ParameterList "::=" ObjectClass

		//

		public void change(objectclassreference_token p_objectclassreference_token, ParameterList p_ParameterList, SyntaxTreeToken p_token, ObjectClass p_ObjectClass)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedObjectClassAssignment_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_objectclassreference_token = p_objectclassreference_token;
			children [1] = m_ParameterList = p_ParameterList;
			children [2] = m_assignment_sign = p_token;
			children [3] = m_ObjectClass = p_ObjectClass;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ParameterizedObjectClassAssignment
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_objectclassreference_token != null) && m_objectclassreference_token.checkInclusion (element) ||
				(m_ParameterList != null) && m_ParameterList.checkInclusion (element) ||
				(m_assignment_sign != null) && m_assignment_sign.checkInclusion (element) ||
				(m_ObjectClass != null) && m_ObjectClass.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ParameterizedObjectClassAssignment

		//
		// emit production tree node associated with any production of syntax rule ParameterizedObjectClassAssignment
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ParameterizedObjectClassAssignment_1:
					// emit syntax tree node associated with production
					// ParameterizedObjectClassAssignment: objectclassreference-token ParameterList "::=" ObjectClass

					s += m_objectclassreference_token.Emit (depth - 1);
					s += " ";
					s += m_ParameterList.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_ObjectClass.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ParameterizedObjectClassAssignment
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ParameterizedObjectClassAssignment (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ParameterizedObjectClassAssignment_1:
					// emit syntax tree node associated with production
					// ParameterizedObjectClassAssignment: objectclassreference-token ParameterList "::=" ObjectClass

					s += m_objectclassreference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ParameterList.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_ObjectClass.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ParameterizedObjectClassAssignment

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedObjectClassAssignment with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ParameterizedObjectClassAssignment.production_kind kind = (ParameterizedObjectClassAssignment.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ParameterizedObjectClassAssignment.production_kind.g_ParameterizedObjectClassAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedObjectClassAssignment: objectclassreference-token ParameterList "::=" ObjectClass

						m_objectclassreference_token.Visit (visitor, appData);
						m_ParameterList.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_ObjectClass.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_objectclassreference_token?.reparent (this);
			m_ParameterList?.reparent (this);
			m_assignment_sign?.reparent (this);
			m_ObjectClass?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ParameterizedObjectClassAssignment
		//

		public void _init ()
		{
			m_objectclassreference_token = null;
			m_ParameterList = null;
			m_assignment_sign = null;
			m_ObjectClass = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ParameterizedObjectClassAssignment

		// counter of all nodes associated with syntax rule ParameterizedObjectClassAssignment
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ParameterizedObjectClassAssignment
		[DataMember (Name = "m_objectclassreference_token")] public objectclassreference_token m_objectclassreference_token { get; private set; }
		[DataMember (Name = "m_ParameterList")] public ParameterList m_ParameterList { get; private set; }
		[DataMember (Name = "m_assignment_sign")] public SyntaxTreeToken m_assignment_sign { get; private set; }
		[DataMember (Name = "m_ObjectClass")] public ObjectClass m_ObjectClass { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ParameterizedObjectClassAssignment

		// delegate function (callback) prototype associated with syntax rule ParameterizedObjectClassAssignment
		public delegate bool ParameterizedObjectClassAssignment_Callback (SyntaxTreeCallbackReason reason, ParameterizedObjectClassAssignment.production_kind kind, ParameterizedObjectClassAssignment p_ParameterizedObjectClassAssignment);

		// event associated with syntax rule ParameterizedObjectClassAssignment
		public event ParameterizedObjectClassAssignment_Callback ParameterizedObjectClassAssignment_Event;

		// event trigger associated with syntax rule ParameterizedObjectClassAssignment
		public bool Raise_ParameterizedObjectClassAssignment_Event (SyntaxTreeCallbackReason reason, ParameterizedObjectClassAssignment.production_kind kind, ParameterizedObjectClassAssignment p_ParameterizedObjectClassAssignment)
		{
			bool? status = ParameterizedObjectClassAssignment_Event?.Invoke (reason, kind, p_ParameterizedObjectClassAssignment);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ParameterizedObjectClassAssignment
		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedObjectClassAssignment
		//

		public void Traverse (ParameterizedObjectClassAssignment p_ParameterizedObjectClassAssignment)
		{
			if (p_ParameterizedObjectClassAssignment.isLocked())
				return;
			p_ParameterizedObjectClassAssignment.dolock();
			ParameterizedObjectClassAssignment.production_kind kind = (ParameterizedObjectClassAssignment.production_kind) p_ParameterizedObjectClassAssignment.kind;
			p_ParameterizedObjectClassAssignment.turn_reset ();
			if (Raise_ParameterizedObjectClassAssignment_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ParameterizedObjectClassAssignment))
			switch (kind)
			{
				case ParameterizedObjectClassAssignment.production_kind.g_ParameterizedObjectClassAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedObjectClassAssignment: objectclassreference-token ParameterList "::=" ObjectClass

					if (Raise_ParameterizedObjectClassAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectClassAssignment))
						Traverse (p_ParameterizedObjectClassAssignment.m_objectclassreference_token);
					p_ParameterizedObjectClassAssignment.turn_inc ();
					if (Raise_ParameterizedObjectClassAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectClassAssignment))
						Traverse (p_ParameterizedObjectClassAssignment.m_ParameterList);
					p_ParameterizedObjectClassAssignment.turn_inc ();
					if (Raise_ParameterizedObjectClassAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectClassAssignment))
						Traverse (p_ParameterizedObjectClassAssignment.m_ObjectClass);
					p_ParameterizedObjectClassAssignment.turn_inc ();
					Raise_ParameterizedObjectClassAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectClassAssignment);
				break;
			}
			Raise_ParameterizedObjectClassAssignment_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ParameterizedObjectClassAssignment);
			p_ParameterizedObjectClassAssignment.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedObjectClassAssignment
		//

		public void TraverseCommon (ParameterizedObjectClassAssignment p_ParameterizedObjectClassAssignment)
		{
			ParameterizedObjectClassAssignment.production_kind kind = (ParameterizedObjectClassAssignment.production_kind) p_ParameterizedObjectClassAssignment.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ParameterizedObjectClassAssignment))
			switch (kind)
			{
				case ParameterizedObjectClassAssignment.production_kind.g_ParameterizedObjectClassAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedObjectClassAssignment: objectclassreference-token ParameterList "::=" ObjectClass

						TraverseCommon (p_ParameterizedObjectClassAssignment.m_objectclassreference_token);
						TraverseCommon (p_ParameterizedObjectClassAssignment.m_ParameterList);
						TraverseCommon (p_ParameterizedObjectClassAssignment.m_assignment_sign);
						TraverseCommon (p_ParameterizedObjectClassAssignment.m_ObjectClass);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ParameterizedObjectClassAssignment);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ParameterizedObjectClassAssignment

		//
		// create syntax tree node associated with production
		// ParameterizedObjectClassAssignment: objectclassreference-token ParameterList "::=" ObjectClass

		//

		public ParameterizedObjectClassAssignment ParameterizedObjectClassAssignment_1 (objectclassreference_token p_objectclassreference_token, ParameterList p_ParameterList, SyntaxTreeToken p_token, ObjectClass p_ObjectClass)
		{
			ParameterizedObjectClassAssignment p_ParameterizedObjectClassAssignment_ref = new ParameterizedObjectClassAssignment(p_objectclassreference_token, p_ParameterList, p_token, p_ObjectClass);
			p_objectclassreference_token.parent = p_ParameterizedObjectClassAssignment_ref;
			p_ParameterList.parent = p_ParameterizedObjectClassAssignment_ref;
			p_token.parent = p_ParameterizedObjectClassAssignment_ref;
			p_ObjectClass.parent = p_ParameterizedObjectClassAssignment_ref;
			Raise_ParameterizedObjectClassAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedObjectClassAssignment.production_kind.g_ParameterizedObjectClassAssignment_1, p_ParameterizedObjectClassAssignment_ref);
			return p_ParameterizedObjectClassAssignment_ref;
		}
		#endregion
	};
}
