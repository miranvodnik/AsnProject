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
	// class associated with syntax rule TypeAssignment
	//

	[DataContract]
	public class	TypeAssignment : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TypeAssignment
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TypeAssignment
		{
			g_TypeAssignment_1 = 1,	// typereference-token "::=" Type

		};
		#endregion
		#region production markers associated with the syntax rule TypeAssignment

		// markers associated with production: TypeAssignment -> typereference-token "::=" Type

		public enum production_marker_1 : ushort
		{
			m_typereference_token,
			m_Type,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TypeAssignment

		// Constructor declaration(s) associated with production(s) of syntax rule TypeAssignment

		//
		// Constructor associated with the following production(s)
		// TypeAssignment -> typereference-token "::=" Type

		//

		public TypeAssignment (typereference_token p_typereference_token, SyntaxTreeToken p_token, Type p_Type) : base ((uint) ProductionID._TypeAssignment_ID, (uint) production_kind.g_TypeAssignment_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_typereference_token = p_typereference_token;
			children[1] = m_assignment_sign = p_token;
			children[2] = m_Type = p_Type;
		}

		public TypeAssignment () { }

		// Copy constructor

		public TypeAssignment (TypeAssignment p_TypeAssignment) : base (p_TypeAssignment.id, p_TypeAssignment.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TypeAssignment.appInfo;
			switch ((production_kind) p_TypeAssignment.kind)
			{
				case production_kind.g_TypeAssignment_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_typereference_token = (p_TypeAssignment.m_typereference_token != null) ? new typereference_token (p_TypeAssignment.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					if ((children [1] = m_assignment_sign = (p_TypeAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_TypeAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [2] = m_Type = (p_TypeAssignment.m_Type != null) ? new Type (p_TypeAssignment.m_Type) : null) != null) m_Type.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TypeAssignment" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TypeAssignment (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_typereference_token?.Dispose ();
			m_assignment_sign?.Dispose ();
			m_Type?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TypeAssignment

		// Content changing function(s) associated with production(s) of syntax rule TypeAssignment

		//
		// Content changing function associated with following production(s)
		// TypeAssignment -> typereference-token "::=" Type

		//

		public void change(typereference_token p_typereference_token, SyntaxTreeToken p_token, Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_TypeAssignment_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_typereference_token = p_typereference_token;
			children [1] = m_assignment_sign = p_token;
			children [2] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TypeAssignment
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_typereference_token != null) && m_typereference_token.checkInclusion (element) ||
				(m_assignment_sign != null) && m_assignment_sign.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TypeAssignment

		//
		// emit production tree node associated with any production of syntax rule TypeAssignment
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TypeAssignment_1:
					// emit syntax tree node associated with production
					// TypeAssignment: typereference-token "::=" Type

					s += m_typereference_token.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TypeAssignment
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TypeAssignment (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TypeAssignment_1:
					// emit syntax tree node associated with production
					// TypeAssignment: typereference-token "::=" Type

					s += m_typereference_token.EmitProductionTree (depth - 1);
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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TypeAssignment

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TypeAssignment with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TypeAssignment.production_kind kind = (TypeAssignment.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TypeAssignment.production_kind.g_TypeAssignment_1:
					// traverse syntax tree node associated with production
					// TypeAssignment: typereference-token "::=" Type

						m_typereference_token.Visit (visitor, appData);
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
			m_assignment_sign?.reparent (this);
			m_Type?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TypeAssignment
		//

		public void _init ()
		{
			m_typereference_token = null;
			m_assignment_sign = null;
			m_Type = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TypeAssignment

		// counter of all nodes associated with syntax rule TypeAssignment
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TypeAssignment
		[DataMember (Name = "m_typereference_token")] public typereference_token m_typereference_token { get; private set; }
		[DataMember (Name = "m_assignment_sign")] public SyntaxTreeToken m_assignment_sign { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TypeAssignment

		// delegate function (callback) prototype associated with syntax rule TypeAssignment
		public delegate bool TypeAssignment_Callback (SyntaxTreeCallbackReason reason, TypeAssignment.production_kind kind, TypeAssignment p_TypeAssignment);

		// event associated with syntax rule TypeAssignment
		public event TypeAssignment_Callback TypeAssignment_Event;

		// event trigger associated with syntax rule TypeAssignment
		public bool Raise_TypeAssignment_Event (SyntaxTreeCallbackReason reason, TypeAssignment.production_kind kind, TypeAssignment p_TypeAssignment)
		{
			bool? status = TypeAssignment_Event?.Invoke (reason, kind, p_TypeAssignment);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TypeAssignment
		//
		// traverse syntax tree node associated with any production of syntax rule TypeAssignment
		//

		public void Traverse (TypeAssignment p_TypeAssignment)
		{
			if (p_TypeAssignment.isLocked())
				return;
			p_TypeAssignment.dolock();
			TypeAssignment.production_kind kind = (TypeAssignment.production_kind) p_TypeAssignment.kind;
			p_TypeAssignment.turn_reset ();
			if (Raise_TypeAssignment_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TypeAssignment))
			switch (kind)
			{
				case TypeAssignment.production_kind.g_TypeAssignment_1:
					// traverse syntax tree node associated with production
					// TypeAssignment: typereference-token "::=" Type

					if (Raise_TypeAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeAssignment))
						Traverse (p_TypeAssignment.m_typereference_token);
					p_TypeAssignment.turn_inc ();
					if (Raise_TypeAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeAssignment))
						Traverse (p_TypeAssignment.m_Type);
					p_TypeAssignment.turn_inc ();
					Raise_TypeAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeAssignment);
				break;
			}
			Raise_TypeAssignment_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TypeAssignment);
			p_TypeAssignment.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TypeAssignment
		//

		public void TraverseCommon (TypeAssignment p_TypeAssignment)
		{
			TypeAssignment.production_kind kind = (TypeAssignment.production_kind) p_TypeAssignment.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TypeAssignment))
			switch (kind)
			{
				case TypeAssignment.production_kind.g_TypeAssignment_1:
					// traverse syntax tree node associated with production
					// TypeAssignment: typereference-token "::=" Type

						TraverseCommon (p_TypeAssignment.m_typereference_token);
						TraverseCommon (p_TypeAssignment.m_assignment_sign);
						TraverseCommon (p_TypeAssignment.m_Type);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TypeAssignment);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TypeAssignment

		//
		// create syntax tree node associated with production
		// TypeAssignment: typereference-token "::=" Type

		//

		public TypeAssignment TypeAssignment_1 (typereference_token p_typereference_token, SyntaxTreeToken p_token, Type p_Type)
		{
			TypeAssignment p_TypeAssignment_ref = new TypeAssignment(p_typereference_token, p_token, p_Type);
			p_typereference_token.parent = p_TypeAssignment_ref;
			p_token.parent = p_TypeAssignment_ref;
			p_Type.parent = p_TypeAssignment_ref;
			Raise_TypeAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeAssignment.production_kind.g_TypeAssignment_1, p_TypeAssignment_ref);
			return p_TypeAssignment_ref;
		}
		#endregion
	};
}
