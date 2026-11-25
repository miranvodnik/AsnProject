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
	// class associated with syntax rule ValueAssignment
	//

	[DataContract]
	public class	ValueAssignment : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ValueAssignment
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ValueAssignment
		{
			g_ValueAssignment_1 = 1,	// valuereference-token Type "::=" Value

		};
		#endregion
		#region production markers associated with the syntax rule ValueAssignment

		// markers associated with production: ValueAssignment -> valuereference-token Type "::=" Value

		public enum production_marker_1 : ushort
		{
			m_valuereference_token,
			m_Type,
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ValueAssignment

		// Constructor declaration(s) associated with production(s) of syntax rule ValueAssignment

		//
		// Constructor associated with the following production(s)
		// ValueAssignment -> valuereference-token Type "::=" Value

		//

		public ValueAssignment (valuereference_token p_valuereference_token, Type p_Type, SyntaxTreeToken p_token, Value p_Value) : base ((uint) ProductionID._ValueAssignment_ID, (uint) production_kind.g_ValueAssignment_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_valuereference_token = p_valuereference_token;
			children[1] = m_Type = p_Type;
			children[2] = m_assignment_sign = p_token;
			children[3] = m_Value = p_Value;
		}

		public ValueAssignment () { }

		// Copy constructor

		public ValueAssignment (ValueAssignment p_ValueAssignment) : base (p_ValueAssignment.id, p_ValueAssignment.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ValueAssignment.appInfo;
			switch ((production_kind) p_ValueAssignment.kind)
			{
				case production_kind.g_ValueAssignment_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_valuereference_token = (p_ValueAssignment.m_valuereference_token != null) ? new valuereference_token (p_ValueAssignment.m_valuereference_token) : null) != null) m_valuereference_token.parent = this;
					if ((children [1] = m_Type = (p_ValueAssignment.m_Type != null) ? new Type (p_ValueAssignment.m_Type) : null) != null) m_Type.parent = this;
					if ((children [2] = m_assignment_sign = (p_ValueAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_ValueAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [3] = m_Value = (p_ValueAssignment.m_Value != null) ? new Value (p_ValueAssignment.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ValueAssignment" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ValueAssignment (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_valuereference_token?.Dispose ();
			m_Type?.Dispose ();
			m_assignment_sign?.Dispose ();
			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ValueAssignment

		// Content changing function(s) associated with production(s) of syntax rule ValueAssignment

		//
		// Content changing function associated with following production(s)
		// ValueAssignment -> valuereference-token Type "::=" Value

		//

		public void change(valuereference_token p_valuereference_token, Type p_Type, SyntaxTreeToken p_token, Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_ValueAssignment_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_valuereference_token = p_valuereference_token;
			children [1] = m_Type = p_Type;
			children [2] = m_assignment_sign = p_token;
			children [3] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ValueAssignment
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_valuereference_token != null) && m_valuereference_token.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_assignment_sign != null) && m_assignment_sign.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ValueAssignment

		//
		// emit production tree node associated with any production of syntax rule ValueAssignment
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ValueAssignment_1:
					// emit syntax tree node associated with production
					// ValueAssignment: valuereference-token Type "::=" Value

					s += m_valuereference_token.Emit (depth - 1);
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
		// emit production tree node associated with any production of syntax rule ValueAssignment
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ValueAssignment (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ValueAssignment_1:
					// emit syntax tree node associated with production
					// ValueAssignment: valuereference-token Type "::=" Value

					s += m_valuereference_token.EmitProductionTree (depth - 1);
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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ValueAssignment

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ValueAssignment with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ValueAssignment.production_kind kind = (ValueAssignment.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ValueAssignment.production_kind.g_ValueAssignment_1:
					// traverse syntax tree node associated with production
					// ValueAssignment: valuereference-token Type "::=" Value

						m_valuereference_token.Visit (visitor, appData);
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
			m_Type?.reparent (this);
			m_assignment_sign?.reparent (this);
			m_Value?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ValueAssignment
		//

		public void _init ()
		{
			m_valuereference_token = null;
			m_Type = null;
			m_assignment_sign = null;
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ValueAssignment

		// counter of all nodes associated with syntax rule ValueAssignment
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ValueAssignment
		[DataMember (Name = "m_valuereference_token")] public valuereference_token m_valuereference_token { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_assignment_sign")] public SyntaxTreeToken m_assignment_sign { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }

		public enum __p1_markers
		{
			m1 = 2,
			m2 = 3,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ValueAssignment

		// delegate function (callback) prototype associated with syntax rule ValueAssignment
		public delegate bool ValueAssignment_Callback (SyntaxTreeCallbackReason reason, ValueAssignment.production_kind kind, ValueAssignment p_ValueAssignment);

		// event associated with syntax rule ValueAssignment
		public event ValueAssignment_Callback ValueAssignment_Event;

		// event trigger associated with syntax rule ValueAssignment
		public bool Raise_ValueAssignment_Event (SyntaxTreeCallbackReason reason, ValueAssignment.production_kind kind, ValueAssignment p_ValueAssignment)
		{
			bool? status = ValueAssignment_Event?.Invoke (reason, kind, p_ValueAssignment);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ValueAssignment
		//
		// traverse syntax tree node associated with any production of syntax rule ValueAssignment
		//

		public void Traverse (ValueAssignment p_ValueAssignment)
		{
			if (p_ValueAssignment.isLocked())
				return;
			p_ValueAssignment.dolock();
			ValueAssignment.production_kind kind = (ValueAssignment.production_kind) p_ValueAssignment.kind;
			p_ValueAssignment.turn_reset ();
			if (Raise_ValueAssignment_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ValueAssignment))
			switch (kind)
			{
				case ValueAssignment.production_kind.g_ValueAssignment_1:
					// traverse syntax tree node associated with production
					// ValueAssignment: valuereference-token Type "::=" Value

					if (Raise_ValueAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueAssignment))
						Traverse (p_ValueAssignment.m_valuereference_token);
					p_ValueAssignment.turn_inc ();
					if (Raise_ValueAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueAssignment))
						Traverse (p_ValueAssignment.m_Type);
					p_ValueAssignment.turn_inc ();
					if (Raise_ValueAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueAssignment))
						Traverse (p_ValueAssignment.m_Value);
					p_ValueAssignment.turn_inc ();
					Raise_ValueAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueAssignment);
				break;
			}
			Raise_ValueAssignment_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ValueAssignment);
			p_ValueAssignment.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ValueAssignment
		//

		public void TraverseCommon (ValueAssignment p_ValueAssignment)
		{
			ValueAssignment.production_kind kind = (ValueAssignment.production_kind) p_ValueAssignment.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ValueAssignment))
			switch (kind)
			{
				case ValueAssignment.production_kind.g_ValueAssignment_1:
					// traverse syntax tree node associated with production
					// ValueAssignment: valuereference-token Type "::=" Value

						TraverseCommon (p_ValueAssignment.m_valuereference_token);
						TraverseCommon (p_ValueAssignment.m_Type);
						TraverseCommon (p_ValueAssignment.m_assignment_sign);
						TraverseCommon (p_ValueAssignment.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ValueAssignment);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ValueAssignment

		//
		// create syntax tree node associated with production
		// ValueAssignment: valuereference-token Type "::=" Value

		//

		public ValueAssignment ValueAssignment_1 (valuereference_token p_valuereference_token, Type p_Type, SyntaxTreeToken p_token, Value p_Value)
		{
			ValueAssignment p_ValueAssignment_ref = new ValueAssignment(p_valuereference_token, p_Type, p_token, p_Value);
			p_valuereference_token.parent = p_ValueAssignment_ref;
			p_Type.parent = p_ValueAssignment_ref;
			p_token.parent = p_ValueAssignment_ref;
			p_Value.parent = p_ValueAssignment_ref;
			Raise_ValueAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ValueAssignment.production_kind.g_ValueAssignment_1, p_ValueAssignment_ref);
			return p_ValueAssignment_ref;
		}
		#endregion
	};
}
