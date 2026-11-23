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
	// class associated with syntax rule ParameterizedObjectAssignment
	//

	[DataContract]
	public class	ParameterizedObjectAssignment : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ParameterizedObjectAssignment
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ParameterizedObjectAssignment
		{
			g_ParameterizedObjectAssignment_1 = 1,	// objectreference-token ParameterList DefinedObjectClass "::=" Object

		};
		#endregion
		#region production markers associated with the syntax rule ParameterizedObjectAssignment

		// markers associated with production: ParameterizedObjectAssignment -> objectreference-token ParameterList DefinedObjectClass "::=" Object

		public enum production_marker_1 : ushort
		{
			m_objectreference_token,
			m_ParameterList,
			m_DefinedObjectClass,
			m_Object,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ParameterizedObjectAssignment

		// Constructor declaration(s) associated with production(s) of syntax rule ParameterizedObjectAssignment

		//
		// Constructor associated with the following production(s)
		// ParameterizedObjectAssignment -> objectreference-token ParameterList DefinedObjectClass "::=" Object

		//

		public ParameterizedObjectAssignment (objectreference_token p_objectreference_token, ParameterList p_ParameterList, DefinedObjectClass p_DefinedObjectClass, SyntaxTreeToken p_token, Object p_Object) : base ((uint) ProductionID._ParameterizedObjectAssignment_ID, (uint) production_kind.g_ParameterizedObjectAssignment_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children[0] = m_objectreference_token = p_objectreference_token;
			children[1] = m_ParameterList = p_ParameterList;
			children[2] = m_DefinedObjectClass = p_DefinedObjectClass;
			children[3] = m_assignment_sign = p_token;
			children[4] = m_Object = p_Object;
		}

		public ParameterizedObjectAssignment () { }

		// Copy constructor

		public ParameterizedObjectAssignment (ParameterizedObjectAssignment p_ParameterizedObjectAssignment) : base (p_ParameterizedObjectAssignment.id, p_ParameterizedObjectAssignment.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ParameterizedObjectAssignment.appInfo;
			switch ((production_kind) p_ParameterizedObjectAssignment.kind)
			{
				case production_kind.g_ParameterizedObjectAssignment_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_objectreference_token = (p_ParameterizedObjectAssignment.m_objectreference_token != null) ? new objectreference_token (p_ParameterizedObjectAssignment.m_objectreference_token) : null) != null) m_objectreference_token.parent = this;
					if ((children [1] = m_ParameterList = (p_ParameterizedObjectAssignment.m_ParameterList != null) ? new ParameterList (p_ParameterizedObjectAssignment.m_ParameterList) : null) != null) m_ParameterList.parent = this;
					if ((children [2] = m_DefinedObjectClass = (p_ParameterizedObjectAssignment.m_DefinedObjectClass != null) ? new DefinedObjectClass (p_ParameterizedObjectAssignment.m_DefinedObjectClass) : null) != null) m_DefinedObjectClass.parent = this;
					if ((children [3] = m_assignment_sign = (p_ParameterizedObjectAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_ParameterizedObjectAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [4] = m_Object = (p_ParameterizedObjectAssignment.m_Object != null) ? new Object (p_ParameterizedObjectAssignment.m_Object) : null) != null) m_Object.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ParameterizedObjectAssignment" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ParameterizedObjectAssignment (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_objectreference_token?.Dispose ();
			m_ParameterList?.Dispose ();
			m_DefinedObjectClass?.Dispose ();
			m_assignment_sign?.Dispose ();
			m_Object?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ParameterizedObjectAssignment

		// Content changing function(s) associated with production(s) of syntax rule ParameterizedObjectAssignment

		//
		// Content changing function associated with following production(s)
		// ParameterizedObjectAssignment -> objectreference-token ParameterList DefinedObjectClass "::=" Object

		//

		public void change(objectreference_token p_objectreference_token, ParameterList p_ParameterList, DefinedObjectClass p_DefinedObjectClass, SyntaxTreeToken p_token, Object p_Object)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedObjectAssignment_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children [0] = m_objectreference_token = p_objectreference_token;
			children [1] = m_ParameterList = p_ParameterList;
			children [2] = m_DefinedObjectClass = p_DefinedObjectClass;
			children [3] = m_assignment_sign = p_token;
			children [4] = m_Object = p_Object;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ParameterizedObjectAssignment
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_objectreference_token != null) && m_objectreference_token.checkInclusion (element) ||
				(m_ParameterList != null) && m_ParameterList.checkInclusion (element) ||
				(m_DefinedObjectClass != null) && m_DefinedObjectClass.checkInclusion (element) ||
				(m_assignment_sign != null) && m_assignment_sign.checkInclusion (element) ||
				(m_Object != null) && m_Object.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ParameterizedObjectAssignment

		//
		// emit production tree node associated with any production of syntax rule ParameterizedObjectAssignment
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ParameterizedObjectAssignment_1:
					// emit syntax tree node associated with production
					// ParameterizedObjectAssignment: objectreference-token ParameterList DefinedObjectClass "::=" Object

					s += m_objectreference_token.Emit (depth - 1);
					s += " ";
					s += m_ParameterList.Emit (depth - 1);
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
		// emit production tree node associated with any production of syntax rule ParameterizedObjectAssignment
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ParameterizedObjectAssignment (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ParameterizedObjectAssignment_1:
					// emit syntax tree node associated with production
					// ParameterizedObjectAssignment: objectreference-token ParameterList DefinedObjectClass "::=" Object

					s += m_objectreference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ParameterList.EmitProductionTree (depth - 1);
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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ParameterizedObjectAssignment

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedObjectAssignment with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ParameterizedObjectAssignment.production_kind kind = (ParameterizedObjectAssignment.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ParameterizedObjectAssignment.production_kind.g_ParameterizedObjectAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedObjectAssignment: objectreference-token ParameterList DefinedObjectClass "::=" Object

						m_objectreference_token.Visit (visitor, appData);
						m_ParameterList.Visit (visitor, appData);
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
			m_ParameterList?.reparent (this);
			m_DefinedObjectClass?.reparent (this);
			m_assignment_sign?.reparent (this);
			m_Object?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ParameterizedObjectAssignment
		//

		public void _init ()
		{
			m_objectreference_token = null;
			m_ParameterList = null;
			m_DefinedObjectClass = null;
			m_assignment_sign = null;
			m_Object = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ParameterizedObjectAssignment

		// counter of all nodes associated with syntax rule ParameterizedObjectAssignment
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ParameterizedObjectAssignment
		[DataMember (Name = "m_objectreference_token")] public objectreference_token m_objectreference_token { get; private set; }
		[DataMember (Name = "m_ParameterList")] public ParameterList m_ParameterList { get; private set; }
		[DataMember (Name = "m_DefinedObjectClass")] public DefinedObjectClass m_DefinedObjectClass { get; private set; }
		[DataMember (Name = "m_assignment_sign")] public SyntaxTreeToken m_assignment_sign { get; private set; }
		[DataMember (Name = "m_Object")] public Object m_Object { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ParameterizedObjectAssignment

		// delegate function (callback) prototype associated with syntax rule ParameterizedObjectAssignment
		public delegate bool ParameterizedObjectAssignment_Callback (SyntaxTreeCallbackReason reason, ParameterizedObjectAssignment.production_kind kind, ParameterizedObjectAssignment p_ParameterizedObjectAssignment);

		// event associated with syntax rule ParameterizedObjectAssignment
		public event ParameterizedObjectAssignment_Callback ParameterizedObjectAssignment_Event;

		// event trigger associated with syntax rule ParameterizedObjectAssignment
		public bool Raise_ParameterizedObjectAssignment_Event (SyntaxTreeCallbackReason reason, ParameterizedObjectAssignment.production_kind kind, ParameterizedObjectAssignment p_ParameterizedObjectAssignment)
		{
			bool? status = ParameterizedObjectAssignment_Event?.Invoke (reason, kind, p_ParameterizedObjectAssignment);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ParameterizedObjectAssignment
		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedObjectAssignment
		//

		public void Traverse (ParameterizedObjectAssignment p_ParameterizedObjectAssignment)
		{
			if (p_ParameterizedObjectAssignment.isLocked())
				return;
			p_ParameterizedObjectAssignment.dolock();
			ParameterizedObjectAssignment.production_kind kind = (ParameterizedObjectAssignment.production_kind) p_ParameterizedObjectAssignment.kind;
			p_ParameterizedObjectAssignment.turn_reset ();
			if (Raise_ParameterizedObjectAssignment_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ParameterizedObjectAssignment))
			switch (kind)
			{
				case ParameterizedObjectAssignment.production_kind.g_ParameterizedObjectAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedObjectAssignment: objectreference-token ParameterList DefinedObjectClass "::=" Object

					if (Raise_ParameterizedObjectAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectAssignment))
						Traverse (p_ParameterizedObjectAssignment.m_objectreference_token);
					p_ParameterizedObjectAssignment.turn_inc ();
					if (Raise_ParameterizedObjectAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectAssignment))
						Traverse (p_ParameterizedObjectAssignment.m_ParameterList);
					p_ParameterizedObjectAssignment.turn_inc ();
					if (Raise_ParameterizedObjectAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectAssignment))
						Traverse (p_ParameterizedObjectAssignment.m_DefinedObjectClass);
					p_ParameterizedObjectAssignment.turn_inc ();
					if (Raise_ParameterizedObjectAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectAssignment))
						Traverse (p_ParameterizedObjectAssignment.m_Object);
					p_ParameterizedObjectAssignment.turn_inc ();
					Raise_ParameterizedObjectAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectAssignment);
				break;
			}
			Raise_ParameterizedObjectAssignment_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ParameterizedObjectAssignment);
			p_ParameterizedObjectAssignment.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedObjectAssignment
		//

		public void TraverseCommon (ParameterizedObjectAssignment p_ParameterizedObjectAssignment)
		{
			ParameterizedObjectAssignment.production_kind kind = (ParameterizedObjectAssignment.production_kind) p_ParameterizedObjectAssignment.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ParameterizedObjectAssignment))
			switch (kind)
			{
				case ParameterizedObjectAssignment.production_kind.g_ParameterizedObjectAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedObjectAssignment: objectreference-token ParameterList DefinedObjectClass "::=" Object

						TraverseCommon (p_ParameterizedObjectAssignment.m_objectreference_token);
						TraverseCommon (p_ParameterizedObjectAssignment.m_ParameterList);
						TraverseCommon (p_ParameterizedObjectAssignment.m_DefinedObjectClass);
						TraverseCommon (p_ParameterizedObjectAssignment.m_assignment_sign);
						TraverseCommon (p_ParameterizedObjectAssignment.m_Object);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ParameterizedObjectAssignment);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ParameterizedObjectAssignment

		//
		// create syntax tree node associated with production
		// ParameterizedObjectAssignment: objectreference-token ParameterList DefinedObjectClass "::=" Object

		//

		public ParameterizedObjectAssignment ParameterizedObjectAssignment_1 (objectreference_token p_objectreference_token, ParameterList p_ParameterList, DefinedObjectClass p_DefinedObjectClass, SyntaxTreeToken p_token, Object p_Object)
		{
			ParameterizedObjectAssignment p_ParameterizedObjectAssignment_ref = new ParameterizedObjectAssignment(p_objectreference_token, p_ParameterList, p_DefinedObjectClass, p_token, p_Object);
			p_objectreference_token.parent = p_ParameterizedObjectAssignment_ref;
			p_ParameterList.parent = p_ParameterizedObjectAssignment_ref;
			p_DefinedObjectClass.parent = p_ParameterizedObjectAssignment_ref;
			p_token.parent = p_ParameterizedObjectAssignment_ref;
			p_Object.parent = p_ParameterizedObjectAssignment_ref;
			Raise_ParameterizedObjectAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedObjectAssignment.production_kind.g_ParameterizedObjectAssignment_1, p_ParameterizedObjectAssignment_ref);
			return p_ParameterizedObjectAssignment_ref;
		}
		#endregion
	};
}
