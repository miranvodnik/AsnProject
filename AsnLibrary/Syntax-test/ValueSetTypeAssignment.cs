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
	// class associated with syntax rule ValueSetTypeAssignment
	//

	[DataContract]
	public class	ValueSetTypeAssignment : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ValueSetTypeAssignment
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ValueSetTypeAssignment
		{
			g_ValueSetTypeAssignment_1 = 1,	// typereference-token Type "::=" ValueSet

		};
		#endregion
		#region production markers associated with the syntax rule ValueSetTypeAssignment

		// markers associated with production: ValueSetTypeAssignment -> typereference-token Type "::=" ValueSet

		public enum production_marker_1 : ushort
		{
			m_typereference_token,
			m_Type,
			m_ValueSet,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ValueSetTypeAssignment

		// Constructor declaration(s) associated with production(s) of syntax rule ValueSetTypeAssignment

		//
		// Constructor associated with the following production(s)
		// ValueSetTypeAssignment -> typereference-token Type "::=" ValueSet

		//

		public ValueSetTypeAssignment (typereference_token p_typereference_token, Type p_Type, SyntaxTreeToken p_token, ValueSet p_ValueSet) : base ((uint) ProductionID._ValueSetTypeAssignment_ID, (uint) production_kind.g_ValueSetTypeAssignment_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_typereference_token = p_typereference_token;
			children[1] = m_Type = p_Type;
			children[2] = m_assignment_sign = p_token;
			children[3] = m_ValueSet = p_ValueSet;
		}

		public ValueSetTypeAssignment () { }

		// Copy constructor

		public ValueSetTypeAssignment (ValueSetTypeAssignment p_ValueSetTypeAssignment) : base (p_ValueSetTypeAssignment.id, p_ValueSetTypeAssignment.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ValueSetTypeAssignment.appInfo;
			switch ((production_kind) p_ValueSetTypeAssignment.kind)
			{
				case production_kind.g_ValueSetTypeAssignment_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_typereference_token = (p_ValueSetTypeAssignment.m_typereference_token != null) ? new typereference_token (p_ValueSetTypeAssignment.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					if ((children [1] = m_Type = (p_ValueSetTypeAssignment.m_Type != null) ? new Type (p_ValueSetTypeAssignment.m_Type) : null) != null) m_Type.parent = this;
					if ((children [2] = m_assignment_sign = (p_ValueSetTypeAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_ValueSetTypeAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [3] = m_ValueSet = (p_ValueSetTypeAssignment.m_ValueSet != null) ? new ValueSet (p_ValueSetTypeAssignment.m_ValueSet) : null) != null) m_ValueSet.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ValueSetTypeAssignment" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ValueSetTypeAssignment (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_typereference_token?.Dispose ();
			m_Type?.Dispose ();
			m_assignment_sign?.Dispose ();
			m_ValueSet?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ValueSetTypeAssignment

		// Content changing function(s) associated with production(s) of syntax rule ValueSetTypeAssignment

		//
		// Content changing function associated with following production(s)
		// ValueSetTypeAssignment -> typereference-token Type "::=" ValueSet

		//

		public void change(typereference_token p_typereference_token, Type p_Type, SyntaxTreeToken p_token, ValueSet p_ValueSet)
		{
			_init ();
			this.kind = (uint) production_kind.g_ValueSetTypeAssignment_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_typereference_token = p_typereference_token;
			children [1] = m_Type = p_Type;
			children [2] = m_assignment_sign = p_token;
			children [3] = m_ValueSet = p_ValueSet;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ValueSetTypeAssignment
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_typereference_token != null) && m_typereference_token.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_assignment_sign != null) && m_assignment_sign.checkInclusion (element) ||
				(m_ValueSet != null) && m_ValueSet.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ValueSetTypeAssignment

		//
		// emit production tree node associated with any production of syntax rule ValueSetTypeAssignment
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ValueSetTypeAssignment_1:
					// emit syntax tree node associated with production
					// ValueSetTypeAssignment: typereference-token Type "::=" ValueSet

					s += m_typereference_token.Emit (depth - 1);
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
		// emit production tree node associated with any production of syntax rule ValueSetTypeAssignment
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ValueSetTypeAssignment (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ValueSetTypeAssignment_1:
					// emit syntax tree node associated with production
					// ValueSetTypeAssignment: typereference-token Type "::=" ValueSet

					s += m_typereference_token.EmitProductionTree (depth - 1);
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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ValueSetTypeAssignment

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ValueSetTypeAssignment with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ValueSetTypeAssignment.production_kind kind = (ValueSetTypeAssignment.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ValueSetTypeAssignment.production_kind.g_ValueSetTypeAssignment_1:
					// traverse syntax tree node associated with production
					// ValueSetTypeAssignment: typereference-token Type "::=" ValueSet

						m_typereference_token.Visit (visitor, appData);
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
			m_Type?.reparent (this);
			m_assignment_sign?.reparent (this);
			m_ValueSet?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ValueSetTypeAssignment
		//

		public void _init ()
		{
			m_typereference_token = null;
			m_Type = null;
			m_assignment_sign = null;
			m_ValueSet = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ValueSetTypeAssignment

		// counter of all nodes associated with syntax rule ValueSetTypeAssignment
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ValueSetTypeAssignment
		[DataMember (Name = "m_typereference_token")] public typereference_token m_typereference_token { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_assignment_sign")] public SyntaxTreeToken m_assignment_sign { get; private set; }
		[DataMember (Name = "m_ValueSet")] public ValueSet m_ValueSet { get; private set; }

		public enum __p1_markers
		{
			m1 = 2,
			m2 = 3,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ValueSetTypeAssignment

		// delegate function (callback) prototype associated with syntax rule ValueSetTypeAssignment
		public delegate bool ValueSetTypeAssignment_Callback (SyntaxTreeCallbackReason reason, ValueSetTypeAssignment.production_kind kind, ValueSetTypeAssignment p_ValueSetTypeAssignment);

		// event associated with syntax rule ValueSetTypeAssignment
		public event ValueSetTypeAssignment_Callback ValueSetTypeAssignment_Event;

		// event trigger associated with syntax rule ValueSetTypeAssignment
		public bool Raise_ValueSetTypeAssignment_Event (SyntaxTreeCallbackReason reason, ValueSetTypeAssignment.production_kind kind, ValueSetTypeAssignment p_ValueSetTypeAssignment)
		{
			bool? status = ValueSetTypeAssignment_Event?.Invoke (reason, kind, p_ValueSetTypeAssignment);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ValueSetTypeAssignment
		//
		// traverse syntax tree node associated with any production of syntax rule ValueSetTypeAssignment
		//

		public void Traverse (ValueSetTypeAssignment p_ValueSetTypeAssignment)
		{
			if (p_ValueSetTypeAssignment.isLocked())
				return;
			p_ValueSetTypeAssignment.dolock();
			ValueSetTypeAssignment.production_kind kind = (ValueSetTypeAssignment.production_kind) p_ValueSetTypeAssignment.kind;
			p_ValueSetTypeAssignment.turn_reset ();
			if (Raise_ValueSetTypeAssignment_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ValueSetTypeAssignment))
			switch (kind)
			{
				case ValueSetTypeAssignment.production_kind.g_ValueSetTypeAssignment_1:
					// traverse syntax tree node associated with production
					// ValueSetTypeAssignment: typereference-token Type "::=" ValueSet

					if (Raise_ValueSetTypeAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueSetTypeAssignment))
						Traverse (p_ValueSetTypeAssignment.m_typereference_token);
					p_ValueSetTypeAssignment.turn_inc ();
					if (Raise_ValueSetTypeAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueSetTypeAssignment))
						Traverse (p_ValueSetTypeAssignment.m_Type);
					p_ValueSetTypeAssignment.turn_inc ();
					if (Raise_ValueSetTypeAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueSetTypeAssignment))
						Traverse (p_ValueSetTypeAssignment.m_ValueSet);
					p_ValueSetTypeAssignment.turn_inc ();
					Raise_ValueSetTypeAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueSetTypeAssignment);
				break;
			}
			Raise_ValueSetTypeAssignment_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ValueSetTypeAssignment);
			p_ValueSetTypeAssignment.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ValueSetTypeAssignment
		//

		public void TraverseCommon (ValueSetTypeAssignment p_ValueSetTypeAssignment)
		{
			ValueSetTypeAssignment.production_kind kind = (ValueSetTypeAssignment.production_kind) p_ValueSetTypeAssignment.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ValueSetTypeAssignment))
			switch (kind)
			{
				case ValueSetTypeAssignment.production_kind.g_ValueSetTypeAssignment_1:
					// traverse syntax tree node associated with production
					// ValueSetTypeAssignment: typereference-token Type "::=" ValueSet

						TraverseCommon (p_ValueSetTypeAssignment.m_typereference_token);
						TraverseCommon (p_ValueSetTypeAssignment.m_Type);
						TraverseCommon (p_ValueSetTypeAssignment.m_assignment_sign);
						TraverseCommon (p_ValueSetTypeAssignment.m_ValueSet);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ValueSetTypeAssignment);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ValueSetTypeAssignment

		//
		// create syntax tree node associated with production
		// ValueSetTypeAssignment: typereference-token Type "::=" ValueSet

		//

		public ValueSetTypeAssignment ValueSetTypeAssignment_1 (typereference_token p_typereference_token, Type p_Type, SyntaxTreeToken p_token, ValueSet p_ValueSet)
		{
			ValueSetTypeAssignment p_ValueSetTypeAssignment_ref = new ValueSetTypeAssignment(p_typereference_token, p_Type, p_token, p_ValueSet);
			p_typereference_token.parent = p_ValueSetTypeAssignment_ref;
			p_Type.parent = p_ValueSetTypeAssignment_ref;
			p_token.parent = p_ValueSetTypeAssignment_ref;
			p_ValueSet.parent = p_ValueSetTypeAssignment_ref;
			Raise_ValueSetTypeAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ValueSetTypeAssignment.production_kind.g_ValueSetTypeAssignment_1, p_ValueSetTypeAssignment_ref);
			return p_ValueSetTypeAssignment_ref;
		}
		#endregion
	};
}
