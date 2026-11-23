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
	// class associated with syntax rule ParameterizedValueSetTypeAssignment
	//

	[DataContract]
	public class	ParameterizedValueSetTypeAssignment : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ParameterizedValueSetTypeAssignment
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ParameterizedValueSetTypeAssignment
		{
			g_ParameterizedValueSetTypeAssignment_1 = 1,	// typereference-token ParameterList Type "::=" ValueSet

		};
		#endregion
		#region production markers associated with the syntax rule ParameterizedValueSetTypeAssignment

		// markers associated with production: ParameterizedValueSetTypeAssignment -> typereference-token ParameterList Type "::=" ValueSet

		public enum production_marker_1 : ushort
		{
			m_typereference_token,
			m_ParameterList,
			m_Type,
			m_ValueSet,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ParameterizedValueSetTypeAssignment

		// Constructor declaration(s) associated with production(s) of syntax rule ParameterizedValueSetTypeAssignment

		//
		// Constructor associated with the following production(s)
		// ParameterizedValueSetTypeAssignment -> typereference-token ParameterList Type "::=" ValueSet

		//

		public ParameterizedValueSetTypeAssignment (typereference_token p_typereference_token, ParameterList p_ParameterList, Type p_Type, SyntaxTreeToken p_token, ValueSet p_ValueSet) : base ((uint) ProductionID._ParameterizedValueSetTypeAssignment_ID, (uint) production_kind.g_ParameterizedValueSetTypeAssignment_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children[0] = m_typereference_token = p_typereference_token;
			children[1] = m_ParameterList = p_ParameterList;
			children[2] = m_Type = p_Type;
			children[3] = m_assignment_sign = p_token;
			children[4] = m_ValueSet = p_ValueSet;
		}

		public ParameterizedValueSetTypeAssignment () { }

		// Copy constructor

		public ParameterizedValueSetTypeAssignment (ParameterizedValueSetTypeAssignment p_ParameterizedValueSetTypeAssignment) : base (p_ParameterizedValueSetTypeAssignment.id, p_ParameterizedValueSetTypeAssignment.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ParameterizedValueSetTypeAssignment.appInfo;
			switch ((production_kind) p_ParameterizedValueSetTypeAssignment.kind)
			{
				case production_kind.g_ParameterizedValueSetTypeAssignment_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_typereference_token = (p_ParameterizedValueSetTypeAssignment.m_typereference_token != null) ? new typereference_token (p_ParameterizedValueSetTypeAssignment.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					if ((children [1] = m_ParameterList = (p_ParameterizedValueSetTypeAssignment.m_ParameterList != null) ? new ParameterList (p_ParameterizedValueSetTypeAssignment.m_ParameterList) : null) != null) m_ParameterList.parent = this;
					if ((children [2] = m_Type = (p_ParameterizedValueSetTypeAssignment.m_Type != null) ? new Type (p_ParameterizedValueSetTypeAssignment.m_Type) : null) != null) m_Type.parent = this;
					if ((children [3] = m_assignment_sign = (p_ParameterizedValueSetTypeAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_ParameterizedValueSetTypeAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [4] = m_ValueSet = (p_ParameterizedValueSetTypeAssignment.m_ValueSet != null) ? new ValueSet (p_ParameterizedValueSetTypeAssignment.m_ValueSet) : null) != null) m_ValueSet.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ParameterizedValueSetTypeAssignment" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ParameterizedValueSetTypeAssignment (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_typereference_token?.Dispose ();
			m_ParameterList?.Dispose ();
			m_Type?.Dispose ();
			m_assignment_sign?.Dispose ();
			m_ValueSet?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ParameterizedValueSetTypeAssignment

		// Content changing function(s) associated with production(s) of syntax rule ParameterizedValueSetTypeAssignment

		//
		// Content changing function associated with following production(s)
		// ParameterizedValueSetTypeAssignment -> typereference-token ParameterList Type "::=" ValueSet

		//

		public void change(typereference_token p_typereference_token, ParameterList p_ParameterList, Type p_Type, SyntaxTreeToken p_token, ValueSet p_ValueSet)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedValueSetTypeAssignment_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children [0] = m_typereference_token = p_typereference_token;
			children [1] = m_ParameterList = p_ParameterList;
			children [2] = m_Type = p_Type;
			children [3] = m_assignment_sign = p_token;
			children [4] = m_ValueSet = p_ValueSet;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ParameterizedValueSetTypeAssignment
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_typereference_token != null) && m_typereference_token.checkInclusion (element) ||
				(m_ParameterList != null) && m_ParameterList.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_assignment_sign != null) && m_assignment_sign.checkInclusion (element) ||
				(m_ValueSet != null) && m_ValueSet.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ParameterizedValueSetTypeAssignment

		//
		// emit production tree node associated with any production of syntax rule ParameterizedValueSetTypeAssignment
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ParameterizedValueSetTypeAssignment_1:
					// emit syntax tree node associated with production
					// ParameterizedValueSetTypeAssignment: typereference-token ParameterList Type "::=" ValueSet

					s += m_typereference_token.Emit (depth - 1);
					s += " ";
					s += m_ParameterList.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_ValueSet.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ParameterizedValueSetTypeAssignment
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ParameterizedValueSetTypeAssignment (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ParameterizedValueSetTypeAssignment_1:
					// emit syntax tree node associated with production
					// ParameterizedValueSetTypeAssignment: typereference-token ParameterList Type "::=" ValueSet

					s += m_typereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ParameterList.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_ValueSet.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ParameterizedValueSetTypeAssignment

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedValueSetTypeAssignment with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ParameterizedValueSetTypeAssignment.production_kind kind = (ParameterizedValueSetTypeAssignment.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ParameterizedValueSetTypeAssignment.production_kind.g_ParameterizedValueSetTypeAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedValueSetTypeAssignment: typereference-token ParameterList Type "::=" ValueSet

						m_typereference_token.Visit (visitor, appData);
						m_ParameterList.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_ValueSet.Visit (visitor, appData);
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
			m_Type?.reparent (this);
			m_assignment_sign?.reparent (this);
			m_ValueSet?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ParameterizedValueSetTypeAssignment
		//

		public void _init ()
		{
			m_typereference_token = null;
			m_ParameterList = null;
			m_Type = null;
			m_assignment_sign = null;
			m_ValueSet = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ParameterizedValueSetTypeAssignment

		// counter of all nodes associated with syntax rule ParameterizedValueSetTypeAssignment
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ParameterizedValueSetTypeAssignment
		[DataMember (Name = "m_typereference_token")] public typereference_token m_typereference_token { get; private set; }
		[DataMember (Name = "m_ParameterList")] public ParameterList m_ParameterList { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_assignment_sign")] public SyntaxTreeToken m_assignment_sign { get; private set; }
		[DataMember (Name = "m_ValueSet")] public ValueSet m_ValueSet { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ParameterizedValueSetTypeAssignment

		// delegate function (callback) prototype associated with syntax rule ParameterizedValueSetTypeAssignment
		public delegate bool ParameterizedValueSetTypeAssignment_Callback (SyntaxTreeCallbackReason reason, ParameterizedValueSetTypeAssignment.production_kind kind, ParameterizedValueSetTypeAssignment p_ParameterizedValueSetTypeAssignment);

		// event associated with syntax rule ParameterizedValueSetTypeAssignment
		public event ParameterizedValueSetTypeAssignment_Callback ParameterizedValueSetTypeAssignment_Event;

		// event trigger associated with syntax rule ParameterizedValueSetTypeAssignment
		public bool Raise_ParameterizedValueSetTypeAssignment_Event (SyntaxTreeCallbackReason reason, ParameterizedValueSetTypeAssignment.production_kind kind, ParameterizedValueSetTypeAssignment p_ParameterizedValueSetTypeAssignment)
		{
			bool? status = ParameterizedValueSetTypeAssignment_Event?.Invoke (reason, kind, p_ParameterizedValueSetTypeAssignment);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ParameterizedValueSetTypeAssignment
		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedValueSetTypeAssignment
		//

		public void Traverse (ParameterizedValueSetTypeAssignment p_ParameterizedValueSetTypeAssignment)
		{
			if (p_ParameterizedValueSetTypeAssignment.isLocked())
				return;
			p_ParameterizedValueSetTypeAssignment.dolock();
			ParameterizedValueSetTypeAssignment.production_kind kind = (ParameterizedValueSetTypeAssignment.production_kind) p_ParameterizedValueSetTypeAssignment.kind;
			p_ParameterizedValueSetTypeAssignment.turn_reset ();
			if (Raise_ParameterizedValueSetTypeAssignment_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ParameterizedValueSetTypeAssignment))
			switch (kind)
			{
				case ParameterizedValueSetTypeAssignment.production_kind.g_ParameterizedValueSetTypeAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedValueSetTypeAssignment: typereference-token ParameterList Type "::=" ValueSet

					if (Raise_ParameterizedValueSetTypeAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedValueSetTypeAssignment))
						Traverse (p_ParameterizedValueSetTypeAssignment.m_typereference_token);
					p_ParameterizedValueSetTypeAssignment.turn_inc ();
					if (Raise_ParameterizedValueSetTypeAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedValueSetTypeAssignment))
						Traverse (p_ParameterizedValueSetTypeAssignment.m_ParameterList);
					p_ParameterizedValueSetTypeAssignment.turn_inc ();
					if (Raise_ParameterizedValueSetTypeAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedValueSetTypeAssignment))
						Traverse (p_ParameterizedValueSetTypeAssignment.m_Type);
					p_ParameterizedValueSetTypeAssignment.turn_inc ();
					if (Raise_ParameterizedValueSetTypeAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedValueSetTypeAssignment))
						Traverse (p_ParameterizedValueSetTypeAssignment.m_ValueSet);
					p_ParameterizedValueSetTypeAssignment.turn_inc ();
					Raise_ParameterizedValueSetTypeAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedValueSetTypeAssignment);
				break;
			}
			Raise_ParameterizedValueSetTypeAssignment_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ParameterizedValueSetTypeAssignment);
			p_ParameterizedValueSetTypeAssignment.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedValueSetTypeAssignment
		//

		public void TraverseCommon (ParameterizedValueSetTypeAssignment p_ParameterizedValueSetTypeAssignment)
		{
			ParameterizedValueSetTypeAssignment.production_kind kind = (ParameterizedValueSetTypeAssignment.production_kind) p_ParameterizedValueSetTypeAssignment.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ParameterizedValueSetTypeAssignment))
			switch (kind)
			{
				case ParameterizedValueSetTypeAssignment.production_kind.g_ParameterizedValueSetTypeAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedValueSetTypeAssignment: typereference-token ParameterList Type "::=" ValueSet

						TraverseCommon (p_ParameterizedValueSetTypeAssignment.m_typereference_token);
						TraverseCommon (p_ParameterizedValueSetTypeAssignment.m_ParameterList);
						TraverseCommon (p_ParameterizedValueSetTypeAssignment.m_Type);
						TraverseCommon (p_ParameterizedValueSetTypeAssignment.m_assignment_sign);
						TraverseCommon (p_ParameterizedValueSetTypeAssignment.m_ValueSet);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ParameterizedValueSetTypeAssignment);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ParameterizedValueSetTypeAssignment

		//
		// create syntax tree node associated with production
		// ParameterizedValueSetTypeAssignment: typereference-token ParameterList Type "::=" ValueSet

		//

		public ParameterizedValueSetTypeAssignment ParameterizedValueSetTypeAssignment_1 (typereference_token p_typereference_token, ParameterList p_ParameterList, Type p_Type, SyntaxTreeToken p_token, ValueSet p_ValueSet)
		{
			ParameterizedValueSetTypeAssignment p_ParameterizedValueSetTypeAssignment_ref = new ParameterizedValueSetTypeAssignment(p_typereference_token, p_ParameterList, p_Type, p_token, p_ValueSet);
			p_typereference_token.parent = p_ParameterizedValueSetTypeAssignment_ref;
			p_ParameterList.parent = p_ParameterizedValueSetTypeAssignment_ref;
			p_Type.parent = p_ParameterizedValueSetTypeAssignment_ref;
			p_token.parent = p_ParameterizedValueSetTypeAssignment_ref;
			p_ValueSet.parent = p_ParameterizedValueSetTypeAssignment_ref;
			Raise_ParameterizedValueSetTypeAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedValueSetTypeAssignment.production_kind.g_ParameterizedValueSetTypeAssignment_1, p_ParameterizedValueSetTypeAssignment_ref);
			return p_ParameterizedValueSetTypeAssignment_ref;
		}
		#endregion
	};
}
