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
	// class associated with syntax rule ParameterizedValueAssignment
	//

	[DataContract]
	public class	ParameterizedValueAssignment : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ParameterizedValueAssignment
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ParameterizedValueAssignment
		{
			g_ParameterizedValueAssignment_1 = 1,	// valuereference-token ParameterList Type "::=" Value

		};
		#endregion
		#region production markers associated with the syntax rule ParameterizedValueAssignment

		// markers associated with production: ParameterizedValueAssignment -> valuereference-token ParameterList Type "::=" Value

		public enum production_marker_1 : ushort
		{
			m_valuereference_token,
			m_ParameterList,
			m_Type,
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ParameterizedValueAssignment

		// Constructor declaration(s) associated with production(s) of syntax rule ParameterizedValueAssignment

		//
		// Constructor associated with the following production(s)
		// ParameterizedValueAssignment -> valuereference-token ParameterList Type "::=" Value

		//

		public ParameterizedValueAssignment (valuereference_token p_valuereference_token, ParameterList p_ParameterList, Type p_Type, SyntaxTreeToken p_token, Value p_Value) : base ((uint) ProductionID._ParameterizedValueAssignment_ID, (uint) production_kind.g_ParameterizedValueAssignment_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children[0] = m_valuereference_token = p_valuereference_token;
			children[1] = m_ParameterList = p_ParameterList;
			children[2] = m_Type = p_Type;
			children[3] = m_assignment_sign = p_token;
			children[4] = m_Value = p_Value;
		}

		public ParameterizedValueAssignment () { }

		// Copy constructor

		public ParameterizedValueAssignment (ParameterizedValueAssignment p_ParameterizedValueAssignment) : base (p_ParameterizedValueAssignment.id, p_ParameterizedValueAssignment.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ParameterizedValueAssignment.appInfo;
			switch ((production_kind) p_ParameterizedValueAssignment.kind)
			{
				case production_kind.g_ParameterizedValueAssignment_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_valuereference_token = (p_ParameterizedValueAssignment.m_valuereference_token != null) ? new valuereference_token (p_ParameterizedValueAssignment.m_valuereference_token) : null) != null) m_valuereference_token.parent = this;
					if ((children [1] = m_ParameterList = (p_ParameterizedValueAssignment.m_ParameterList != null) ? new ParameterList (p_ParameterizedValueAssignment.m_ParameterList) : null) != null) m_ParameterList.parent = this;
					if ((children [2] = m_Type = (p_ParameterizedValueAssignment.m_Type != null) ? new Type (p_ParameterizedValueAssignment.m_Type) : null) != null) m_Type.parent = this;
					if ((children [3] = m_assignment_sign = (p_ParameterizedValueAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_ParameterizedValueAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [4] = m_Value = (p_ParameterizedValueAssignment.m_Value != null) ? new Value (p_ParameterizedValueAssignment.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ParameterizedValueAssignment" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ParameterizedValueAssignment (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_valuereference_token?.Dispose ();
			m_ParameterList?.Dispose ();
			m_Type?.Dispose ();
			m_assignment_sign?.Dispose ();
			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ParameterizedValueAssignment

		// Content changing function(s) associated with production(s) of syntax rule ParameterizedValueAssignment

		//
		// Content changing function associated with following production(s)
		// ParameterizedValueAssignment -> valuereference-token ParameterList Type "::=" Value

		//

		public void change(valuereference_token p_valuereference_token, ParameterList p_ParameterList, Type p_Type, SyntaxTreeToken p_token, Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedValueAssignment_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children [0] = m_valuereference_token = p_valuereference_token;
			children [1] = m_ParameterList = p_ParameterList;
			children [2] = m_Type = p_Type;
			children [3] = m_assignment_sign = p_token;
			children [4] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ParameterizedValueAssignment
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_valuereference_token != null) && m_valuereference_token.checkInclusion (element) ||
				(m_ParameterList != null) && m_ParameterList.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_assignment_sign != null) && m_assignment_sign.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ParameterizedValueAssignment

		//
		// emit production tree node associated with any production of syntax rule ParameterizedValueAssignment
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ParameterizedValueAssignment_1:
					// emit syntax tree node associated with production
					// ParameterizedValueAssignment: valuereference-token ParameterList Type "::=" Value

					s += m_valuereference_token.Emit (depth - 1);
					s += " ";
					s += m_ParameterList.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_Value.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ParameterizedValueAssignment
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ParameterizedValueAssignment (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ParameterizedValueAssignment_1:
					// emit syntax tree node associated with production
					// ParameterizedValueAssignment: valuereference-token ParameterList Type "::=" Value

					s += m_valuereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ParameterList.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_Value.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ParameterizedValueAssignment

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedValueAssignment with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ParameterizedValueAssignment.production_kind kind = (ParameterizedValueAssignment.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ParameterizedValueAssignment.production_kind.g_ParameterizedValueAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedValueAssignment: valuereference-token ParameterList Type "::=" Value

						m_valuereference_token.Visit (visitor, appData);
						m_ParameterList.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_Value.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_valuereference_token?.reparent (this);
			m_ParameterList?.reparent (this);
			m_Type?.reparent (this);
			m_assignment_sign?.reparent (this);
			m_Value?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ParameterizedValueAssignment
		//

		public void _init ()
		{
			m_valuereference_token = null;
			m_ParameterList = null;
			m_Type = null;
			m_assignment_sign = null;
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ParameterizedValueAssignment

		// counter of all nodes associated with syntax rule ParameterizedValueAssignment
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ParameterizedValueAssignment
		[DataMember (Name = "m_valuereference_token")] public valuereference_token m_valuereference_token { get; private set; }
		[DataMember (Name = "m_ParameterList")] public ParameterList m_ParameterList { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_assignment_sign")] public SyntaxTreeToken m_assignment_sign { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ParameterizedValueAssignment

		// delegate function (callback) prototype associated with syntax rule ParameterizedValueAssignment
		public delegate bool ParameterizedValueAssignment_Callback (SyntaxTreeCallbackReason reason, ParameterizedValueAssignment.production_kind kind, ParameterizedValueAssignment p_ParameterizedValueAssignment);

		// event associated with syntax rule ParameterizedValueAssignment
		public event ParameterizedValueAssignment_Callback ParameterizedValueAssignment_Event;

		// event trigger associated with syntax rule ParameterizedValueAssignment
		public bool Raise_ParameterizedValueAssignment_Event (SyntaxTreeCallbackReason reason, ParameterizedValueAssignment.production_kind kind, ParameterizedValueAssignment p_ParameterizedValueAssignment)
		{
			bool? status = ParameterizedValueAssignment_Event?.Invoke (reason, kind, p_ParameterizedValueAssignment);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ParameterizedValueAssignment
		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedValueAssignment
		//

		public void Traverse (ParameterizedValueAssignment p_ParameterizedValueAssignment)
		{
			if (p_ParameterizedValueAssignment.isLocked())
				return;
			p_ParameterizedValueAssignment.dolock();
			ParameterizedValueAssignment.production_kind kind = (ParameterizedValueAssignment.production_kind) p_ParameterizedValueAssignment.kind;
			p_ParameterizedValueAssignment.turn_reset ();
			if (Raise_ParameterizedValueAssignment_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ParameterizedValueAssignment))
			switch (kind)
			{
				case ParameterizedValueAssignment.production_kind.g_ParameterizedValueAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedValueAssignment: valuereference-token ParameterList Type "::=" Value

					if (Raise_ParameterizedValueAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedValueAssignment))
						Traverse (p_ParameterizedValueAssignment.m_valuereference_token);
					p_ParameterizedValueAssignment.turn_inc ();
					if (Raise_ParameterizedValueAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedValueAssignment))
						Traverse (p_ParameterizedValueAssignment.m_ParameterList);
					p_ParameterizedValueAssignment.turn_inc ();
					if (Raise_ParameterizedValueAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedValueAssignment))
						Traverse (p_ParameterizedValueAssignment.m_Type);
					p_ParameterizedValueAssignment.turn_inc ();
					if (Raise_ParameterizedValueAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedValueAssignment))
						Traverse (p_ParameterizedValueAssignment.m_Value);
					p_ParameterizedValueAssignment.turn_inc ();
					Raise_ParameterizedValueAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedValueAssignment);
				break;
			}
			Raise_ParameterizedValueAssignment_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ParameterizedValueAssignment);
			p_ParameterizedValueAssignment.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedValueAssignment
		//

		public void TraverseCommon (ParameterizedValueAssignment p_ParameterizedValueAssignment)
		{
			ParameterizedValueAssignment.production_kind kind = (ParameterizedValueAssignment.production_kind) p_ParameterizedValueAssignment.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ParameterizedValueAssignment))
			switch (kind)
			{
				case ParameterizedValueAssignment.production_kind.g_ParameterizedValueAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedValueAssignment: valuereference-token ParameterList Type "::=" Value

						TraverseCommon (p_ParameterizedValueAssignment.m_valuereference_token);
						TraverseCommon (p_ParameterizedValueAssignment.m_ParameterList);
						TraverseCommon (p_ParameterizedValueAssignment.m_Type);
						TraverseCommon (p_ParameterizedValueAssignment.m_assignment_sign);
						TraverseCommon (p_ParameterizedValueAssignment.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ParameterizedValueAssignment);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ParameterizedValueAssignment

		//
		// create syntax tree node associated with production
		// ParameterizedValueAssignment: valuereference-token ParameterList Type "::=" Value

		//

		public ParameterizedValueAssignment ParameterizedValueAssignment_1 (valuereference_token p_valuereference_token, ParameterList p_ParameterList, Type p_Type, SyntaxTreeToken p_token, Value p_Value)
		{
			ParameterizedValueAssignment p_ParameterizedValueAssignment_ref = new ParameterizedValueAssignment(p_valuereference_token, p_ParameterList, p_Type, p_token, p_Value);
			p_valuereference_token.parent = p_ParameterizedValueAssignment_ref;
			p_ParameterList.parent = p_ParameterizedValueAssignment_ref;
			p_Type.parent = p_ParameterizedValueAssignment_ref;
			p_token.parent = p_ParameterizedValueAssignment_ref;
			p_Value.parent = p_ParameterizedValueAssignment_ref;
			Raise_ParameterizedValueAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedValueAssignment.production_kind.g_ParameterizedValueAssignment_1, p_ParameterizedValueAssignment_ref);
			return p_ParameterizedValueAssignment_ref;
		}
		#endregion
	};
}
