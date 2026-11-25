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
	// class associated with syntax rule ParameterizedTypeAssignment
	//

	[DataContract]
	public class	ParameterizedTypeAssignment : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ParameterizedTypeAssignment
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ParameterizedTypeAssignment
		{
			g_ParameterizedTypeAssignment_1 = 1,	// typereference-token ParameterList "::=" Type

		};
		#endregion
		#region production markers associated with the syntax rule ParameterizedTypeAssignment

		// markers associated with production: ParameterizedTypeAssignment -> typereference-token ParameterList "::=" Type

		public enum production_marker_1 : ushort
		{
			m_typereference_token,
			m_ParameterList,
			m_Type,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ParameterizedTypeAssignment

		// Constructor declaration(s) associated with production(s) of syntax rule ParameterizedTypeAssignment

		//
		// Constructor associated with the following production(s)
		// ParameterizedTypeAssignment -> typereference-token ParameterList "::=" Type

		//

		public ParameterizedTypeAssignment (typereference_token p_typereference_token, ParameterList p_ParameterList, SyntaxTreeToken p_token, Type p_Type) : base ((uint) ProductionID._ParameterizedTypeAssignment_ID, (uint) production_kind.g_ParameterizedTypeAssignment_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_typereference_token = p_typereference_token;
			children[1] = m_ParameterList = p_ParameterList;
			children[2] = m_assignment_sign = p_token;
			children[3] = m_Type = p_Type;
		}

		public ParameterizedTypeAssignment () { }

		// Copy constructor

		public ParameterizedTypeAssignment (ParameterizedTypeAssignment p_ParameterizedTypeAssignment) : base (p_ParameterizedTypeAssignment.id, p_ParameterizedTypeAssignment.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ParameterizedTypeAssignment.appInfo;
			switch ((production_kind) p_ParameterizedTypeAssignment.kind)
			{
				case production_kind.g_ParameterizedTypeAssignment_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_typereference_token = (p_ParameterizedTypeAssignment.m_typereference_token != null) ? new typereference_token (p_ParameterizedTypeAssignment.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					if ((children [1] = m_ParameterList = (p_ParameterizedTypeAssignment.m_ParameterList != null) ? new ParameterList (p_ParameterizedTypeAssignment.m_ParameterList) : null) != null) m_ParameterList.parent = this;
					if ((children [2] = m_assignment_sign = (p_ParameterizedTypeAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_ParameterizedTypeAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [3] = m_Type = (p_ParameterizedTypeAssignment.m_Type != null) ? new Type (p_ParameterizedTypeAssignment.m_Type) : null) != null) m_Type.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ParameterizedTypeAssignment" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ParameterizedTypeAssignment (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_typereference_token?.Dispose ();
			m_ParameterList?.Dispose ();
			m_assignment_sign?.Dispose ();
			m_Type?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ParameterizedTypeAssignment

		// Content changing function(s) associated with production(s) of syntax rule ParameterizedTypeAssignment

		//
		// Content changing function associated with following production(s)
		// ParameterizedTypeAssignment -> typereference-token ParameterList "::=" Type

		//

		public void change(typereference_token p_typereference_token, ParameterList p_ParameterList, SyntaxTreeToken p_token, Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedTypeAssignment_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_typereference_token = p_typereference_token;
			children [1] = m_ParameterList = p_ParameterList;
			children [2] = m_assignment_sign = p_token;
			children [3] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ParameterizedTypeAssignment
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_typereference_token != null) && m_typereference_token.checkInclusion (element) ||
				(m_ParameterList != null) && m_ParameterList.checkInclusion (element) ||
				(m_assignment_sign != null) && m_assignment_sign.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ParameterizedTypeAssignment

		//
		// emit production tree node associated with any production of syntax rule ParameterizedTypeAssignment
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ParameterizedTypeAssignment_1:
					// emit syntax tree node associated with production
					// ParameterizedTypeAssignment: typereference-token ParameterList "::=" Type

					s += m_typereference_token.Emit (depth - 1);
					s += " ";
					s += m_ParameterList.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ParameterizedTypeAssignment
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ParameterizedTypeAssignment (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ParameterizedTypeAssignment_1:
					// emit syntax tree node associated with production
					// ParameterizedTypeAssignment: typereference-token ParameterList "::=" Type

					s += m_typereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ParameterList.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ParameterizedTypeAssignment

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedTypeAssignment with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ParameterizedTypeAssignment.production_kind kind = (ParameterizedTypeAssignment.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ParameterizedTypeAssignment.production_kind.g_ParameterizedTypeAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedTypeAssignment: typereference-token ParameterList "::=" Type

						m_typereference_token.Visit (visitor, appData);
						m_ParameterList.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_typereference_token?.reparent (this);
			m_ParameterList?.reparent (this);
			m_assignment_sign?.reparent (this);
			m_Type?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ParameterizedTypeAssignment
		//

		public void _init ()
		{
			m_typereference_token = null;
			m_ParameterList = null;
			m_assignment_sign = null;
			m_Type = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ParameterizedTypeAssignment

		// counter of all nodes associated with syntax rule ParameterizedTypeAssignment
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ParameterizedTypeAssignment
		[DataMember (Name = "m_typereference_token")] public typereference_token m_typereference_token { get; private set; }
		[DataMember (Name = "m_ParameterList")] public ParameterList m_ParameterList { get; private set; }
		[DataMember (Name = "m_assignment_sign")] public SyntaxTreeToken m_assignment_sign { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ParameterizedTypeAssignment

		// delegate function (callback) prototype associated with syntax rule ParameterizedTypeAssignment
		public delegate bool ParameterizedTypeAssignment_Callback (SyntaxTreeCallbackReason reason, ParameterizedTypeAssignment.production_kind kind, ParameterizedTypeAssignment p_ParameterizedTypeAssignment);

		// event associated with syntax rule ParameterizedTypeAssignment
		public event ParameterizedTypeAssignment_Callback ParameterizedTypeAssignment_Event;

		// event trigger associated with syntax rule ParameterizedTypeAssignment
		public bool Raise_ParameterizedTypeAssignment_Event (SyntaxTreeCallbackReason reason, ParameterizedTypeAssignment.production_kind kind, ParameterizedTypeAssignment p_ParameterizedTypeAssignment)
		{
			bool? status = ParameterizedTypeAssignment_Event?.Invoke (reason, kind, p_ParameterizedTypeAssignment);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ParameterizedTypeAssignment
		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedTypeAssignment
		//

		public void Traverse (ParameterizedTypeAssignment p_ParameterizedTypeAssignment)
		{
			if (p_ParameterizedTypeAssignment.isLocked())
				return;
			p_ParameterizedTypeAssignment.dolock();
			ParameterizedTypeAssignment.production_kind kind = (ParameterizedTypeAssignment.production_kind) p_ParameterizedTypeAssignment.kind;
			p_ParameterizedTypeAssignment.turn_reset ();
			if (Raise_ParameterizedTypeAssignment_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ParameterizedTypeAssignment))
			switch (kind)
			{
				case ParameterizedTypeAssignment.production_kind.g_ParameterizedTypeAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedTypeAssignment: typereference-token ParameterList "::=" Type

					if (Raise_ParameterizedTypeAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedTypeAssignment))
						Traverse (p_ParameterizedTypeAssignment.m_typereference_token);
					p_ParameterizedTypeAssignment.turn_inc ();
					if (Raise_ParameterizedTypeAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedTypeAssignment))
						Traverse (p_ParameterizedTypeAssignment.m_ParameterList);
					p_ParameterizedTypeAssignment.turn_inc ();
					if (Raise_ParameterizedTypeAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedTypeAssignment))
						Traverse (p_ParameterizedTypeAssignment.m_Type);
					p_ParameterizedTypeAssignment.turn_inc ();
					Raise_ParameterizedTypeAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedTypeAssignment);
				break;
			}
			Raise_ParameterizedTypeAssignment_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ParameterizedTypeAssignment);
			p_ParameterizedTypeAssignment.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedTypeAssignment
		//

		public void TraverseCommon (ParameterizedTypeAssignment p_ParameterizedTypeAssignment)
		{
			ParameterizedTypeAssignment.production_kind kind = (ParameterizedTypeAssignment.production_kind) p_ParameterizedTypeAssignment.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ParameterizedTypeAssignment))
			switch (kind)
			{
				case ParameterizedTypeAssignment.production_kind.g_ParameterizedTypeAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedTypeAssignment: typereference-token ParameterList "::=" Type

						TraverseCommon (p_ParameterizedTypeAssignment.m_typereference_token);
						TraverseCommon (p_ParameterizedTypeAssignment.m_ParameterList);
						TraverseCommon (p_ParameterizedTypeAssignment.m_assignment_sign);
						TraverseCommon (p_ParameterizedTypeAssignment.m_Type);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ParameterizedTypeAssignment);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ParameterizedTypeAssignment

		//
		// create syntax tree node associated with production
		// ParameterizedTypeAssignment: typereference-token ParameterList "::=" Type

		//

		public ParameterizedTypeAssignment ParameterizedTypeAssignment_1 (typereference_token p_typereference_token, ParameterList p_ParameterList, SyntaxTreeToken p_token, Type p_Type)
		{
			ParameterizedTypeAssignment p_ParameterizedTypeAssignment_ref = new ParameterizedTypeAssignment(p_typereference_token, p_ParameterList, p_token, p_Type);
			p_typereference_token.parent = p_ParameterizedTypeAssignment_ref;
			p_ParameterList.parent = p_ParameterizedTypeAssignment_ref;
			p_token.parent = p_ParameterizedTypeAssignment_ref;
			p_Type.parent = p_ParameterizedTypeAssignment_ref;
			Raise_ParameterizedTypeAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedTypeAssignment.production_kind.g_ParameterizedTypeAssignment_1, p_ParameterizedTypeAssignment_ref);
			return p_ParameterizedTypeAssignment_ref;
		}
		#endregion
	};
}
