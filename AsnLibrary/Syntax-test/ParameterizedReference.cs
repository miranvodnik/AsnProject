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
	// class associated with syntax rule ParameterizedReference
	//

	[DataContract]
	public class	ParameterizedReference : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ParameterizedReference
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ParameterizedReference
		{
			g_ParameterizedReference_1 = 1,	// Reference

			g_ParameterizedReference_2 = 2,	// Reference "{" "}"

		};
		#endregion
		#region production markers associated with the syntax rule ParameterizedReference

		// markers associated with production: ParameterizedReference -> Reference

		public enum production_marker_1 : ushort
		{
			m_Reference,
			final
		};

		// markers associated with production: ParameterizedReference -> Reference "{" "}"

		public enum production_marker_2 : ushort
		{
			m_Reference,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ParameterizedReference

		// Constructor declaration(s) associated with production(s) of syntax rule ParameterizedReference

		//
		// Constructor associated with the following production(s)
		// ParameterizedReference -> Reference

		//

		public ParameterizedReference (Reference p_Reference) : base ((uint) ProductionID._ParameterizedReference_ID, (uint) production_kind.g_ParameterizedReference_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Reference = p_Reference;
		}

		//
		// Constructor associated with the following production(s)
		// ParameterizedReference -> Reference "{" "}"

		//

		public ParameterizedReference (Reference p_Reference, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._ParameterizedReference_ID, (uint) production_kind.g_ParameterizedReference_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_Reference = p_Reference;
			children[1] = m_left_curly_bracket = p_token;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		public ParameterizedReference () { }

		// Copy constructor

		public ParameterizedReference (ParameterizedReference p_ParameterizedReference) : base (p_ParameterizedReference.id, p_ParameterizedReference.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ParameterizedReference.appInfo;
			switch ((production_kind) p_ParameterizedReference.kind)
			{
				case production_kind.g_ParameterizedReference_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Reference = (p_ParameterizedReference.m_Reference != null) ? new Reference (p_ParameterizedReference.m_Reference) : null) != null) m_Reference.parent = this;
					break;
				case production_kind.g_ParameterizedReference_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_Reference = (p_ParameterizedReference.m_Reference != null) ? new Reference (p_ParameterizedReference.m_Reference) : null) != null) m_Reference.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_ParameterizedReference.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_ParameterizedReference.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_ParameterizedReference.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_ParameterizedReference.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ParameterizedReference" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ParameterizedReference (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Reference?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ParameterizedReference

		// Content changing function(s) associated with production(s) of syntax rule ParameterizedReference

		//
		// Content changing function associated with following production(s)
		// ParameterizedReference -> Reference

		//

		public void change(Reference p_Reference)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedReference_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Reference = p_Reference;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ParameterizedReference -> Reference "{" "}"

		//

		public void change(Reference p_Reference, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedReference_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_Reference = p_Reference;
			children [1] = m_left_curly_bracket = p_token;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ParameterizedReference
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Reference != null) && m_Reference.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ParameterizedReference

		//
		// emit production tree node associated with any production of syntax rule ParameterizedReference
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ParameterizedReference_1:
					// emit syntax tree node associated with production
					// ParameterizedReference: Reference

					s += m_Reference.Emit (depth - 1);
				break;
				case production_kind.g_ParameterizedReference_2:
					// emit syntax tree node associated with production
					// ParameterizedReference: Reference "{" "}"

					s += m_Reference.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ParameterizedReference
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ParameterizedReference (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ParameterizedReference_1:
					// emit syntax tree node associated with production
					// ParameterizedReference: Reference

					s += m_Reference.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ParameterizedReference_2:
					// emit syntax tree node associated with production
					// ParameterizedReference: Reference "{" "}"

					s += m_Reference.EmitProductionTree (depth - 1);
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ParameterizedReference

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedReference with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ParameterizedReference.production_kind kind = (ParameterizedReference.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ParameterizedReference.production_kind.g_ParameterizedReference_1:
					// traverse syntax tree node associated with production
					// ParameterizedReference: Reference

						m_Reference.Visit (visitor, appData);
				break;
				case ParameterizedReference.production_kind.g_ParameterizedReference_2:
					// traverse syntax tree node associated with production
					// ParameterizedReference: Reference "{" "}"

						m_Reference.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Reference?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ParameterizedReference
		//

		public void _init ()
		{
			m_Reference = null;
			m_left_curly_bracket = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ParameterizedReference

		// counter of all nodes associated with syntax rule ParameterizedReference
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ParameterizedReference
		[DataMember (Name = "m_Reference")] public Reference m_Reference { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ParameterizedReference

		// delegate function (callback) prototype associated with syntax rule ParameterizedReference
		public delegate bool ParameterizedReference_Callback (SyntaxTreeCallbackReason reason, ParameterizedReference.production_kind kind, ParameterizedReference p_ParameterizedReference);

		// event associated with syntax rule ParameterizedReference
		public event ParameterizedReference_Callback ParameterizedReference_Event;

		// event trigger associated with syntax rule ParameterizedReference
		public bool Raise_ParameterizedReference_Event (SyntaxTreeCallbackReason reason, ParameterizedReference.production_kind kind, ParameterizedReference p_ParameterizedReference)
		{
			bool? status = ParameterizedReference_Event?.Invoke (reason, kind, p_ParameterizedReference);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ParameterizedReference
		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedReference
		//

		public void Traverse (ParameterizedReference p_ParameterizedReference)
		{
			if (p_ParameterizedReference.isLocked())
				return;
			p_ParameterizedReference.dolock();
			ParameterizedReference.production_kind kind = (ParameterizedReference.production_kind) p_ParameterizedReference.kind;
			p_ParameterizedReference.turn_reset ();
			if (Raise_ParameterizedReference_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ParameterizedReference))
			switch (kind)
			{
				case ParameterizedReference.production_kind.g_ParameterizedReference_1:
					// traverse syntax tree node associated with production
					// ParameterizedReference: Reference

					if (Raise_ParameterizedReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedReference))
						Traverse (p_ParameterizedReference.m_Reference);
					p_ParameterizedReference.turn_inc ();
					Raise_ParameterizedReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedReference);
				break;
				case ParameterizedReference.production_kind.g_ParameterizedReference_2:
					// traverse syntax tree node associated with production
					// ParameterizedReference: Reference "{" "}"

					if (Raise_ParameterizedReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedReference))
						Traverse (p_ParameterizedReference.m_Reference);
					p_ParameterizedReference.turn_inc ();
					Raise_ParameterizedReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedReference);
				break;
			}
			Raise_ParameterizedReference_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ParameterizedReference);
			p_ParameterizedReference.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedReference
		//

		public void TraverseCommon (ParameterizedReference p_ParameterizedReference)
		{
			ParameterizedReference.production_kind kind = (ParameterizedReference.production_kind) p_ParameterizedReference.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ParameterizedReference))
			switch (kind)
			{
				case ParameterizedReference.production_kind.g_ParameterizedReference_1:
					// traverse syntax tree node associated with production
					// ParameterizedReference: Reference

						TraverseCommon (p_ParameterizedReference.m_Reference);
				break;
				case ParameterizedReference.production_kind.g_ParameterizedReference_2:
					// traverse syntax tree node associated with production
					// ParameterizedReference: Reference "{" "}"

						TraverseCommon (p_ParameterizedReference.m_Reference);
						TraverseCommon (p_ParameterizedReference.m_left_curly_bracket);
						TraverseCommon (p_ParameterizedReference.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ParameterizedReference);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ParameterizedReference

		//
		// create syntax tree node associated with production
		// ParameterizedReference: Reference

		//

		public ParameterizedReference ParameterizedReference_1 (Reference p_Reference)
		{
			ParameterizedReference p_ParameterizedReference_ref = new ParameterizedReference(p_Reference);
			p_Reference.parent = p_ParameterizedReference_ref;
			Raise_ParameterizedReference_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedReference.production_kind.g_ParameterizedReference_1, p_ParameterizedReference_ref);
			return p_ParameterizedReference_ref;
		}

		//
		// create syntax tree node associated with production
		// ParameterizedReference: Reference "{" "}"

		//

		public ParameterizedReference ParameterizedReference_2 (Reference p_Reference, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			ParameterizedReference p_ParameterizedReference_ref = new ParameterizedReference(p_Reference, p_token, p_token_1);
			p_Reference.parent = p_ParameterizedReference_ref;
			p_token.parent = p_ParameterizedReference_ref;
			p_token_1.parent = p_ParameterizedReference_ref;
			Raise_ParameterizedReference_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedReference.production_kind.g_ParameterizedReference_2, p_ParameterizedReference_ref);
			return p_ParameterizedReference_ref;
		}
		#endregion
	};
}
