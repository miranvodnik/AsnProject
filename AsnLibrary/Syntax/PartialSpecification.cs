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
	// class associated with syntax rule PartialSpecification
	//

	[DataContract]
	public class	PartialSpecification : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule PartialSpecification
		public enum production_kind : ushort	// enumerated production(s) of syntax rule PartialSpecification
		{
			g_PartialSpecification_1 = 1,	// "{" "." "." "." "," TypeConstraints "}"

		};
		#endregion
		#region production markers associated with the syntax rule PartialSpecification

		// markers associated with production: PartialSpecification -> "{" "." "." "." "," TypeConstraints "}"

		public enum production_marker_1 : ushort
		{
			m_TypeConstraints,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule PartialSpecification

		// Constructor declaration(s) associated with production(s) of syntax rule PartialSpecification

		//
		// Constructor associated with the following production(s)
		// PartialSpecification -> "{" "." "." "." "," TypeConstraints "}"

		//

		public PartialSpecification (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, SyntaxTreeToken p_token_4, TypeConstraints p_TypeConstraints, SyntaxTreeToken p_token_5) : base ((uint) ProductionID._PartialSpecification_ID, (uint) production_kind.g_PartialSpecification_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_dot = p_token_1;
			children[2] = m_dot_1 = p_token_2;
			children[3] = m_dot_2 = p_token_3;
			children[4] = m_comma = p_token_4;
			children[5] = m_TypeConstraints = p_TypeConstraints;
			children[6] = m_right_curly_bracket = p_token_5;
		}

		public PartialSpecification () { }

		// Copy constructor

		public PartialSpecification (PartialSpecification p_PartialSpecification) : base (p_PartialSpecification.id, p_PartialSpecification.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_PartialSpecification.appInfo;
			switch ((production_kind) p_PartialSpecification.kind)
			{
				case production_kind.g_PartialSpecification_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
					if ((children [0] = m_left_curly_bracket = (p_PartialSpecification.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_PartialSpecification.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_dot = (p_PartialSpecification.m_dot != null) ? new SyntaxTreeToken (p_PartialSpecification.m_dot) : null) != null) m_dot.parent = this;
					if ((children [2] = m_dot_1 = (p_PartialSpecification.m_dot_1 != null) ? new SyntaxTreeToken (p_PartialSpecification.m_dot_1) : null) != null) m_dot_1.parent = this;
					if ((children [3] = m_dot_2 = (p_PartialSpecification.m_dot_2 != null) ? new SyntaxTreeToken (p_PartialSpecification.m_dot_2) : null) != null) m_dot_2.parent = this;
					if ((children [4] = m_comma = (p_PartialSpecification.m_comma != null) ? new SyntaxTreeToken (p_PartialSpecification.m_comma) : null) != null) m_comma.parent = this;
					if ((children [5] = m_TypeConstraints = (p_PartialSpecification.m_TypeConstraints != null) ? new TypeConstraints (p_PartialSpecification.m_TypeConstraints) : null) != null) m_TypeConstraints.parent = this;
					if ((children [6] = m_right_curly_bracket = (p_PartialSpecification.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_PartialSpecification.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "PartialSpecification" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new PartialSpecification (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_curly_bracket?.Dispose ();
			m_dot?.Dispose ();
			m_dot_1?.Dispose ();
			m_dot_2?.Dispose ();
			m_comma?.Dispose ();
			m_TypeConstraints?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule PartialSpecification

		// Content changing function(s) associated with production(s) of syntax rule PartialSpecification

		//
		// Content changing function associated with following production(s)
		// PartialSpecification -> "{" "." "." "." "," TypeConstraints "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, SyntaxTreeToken p_token_4, TypeConstraints p_TypeConstraints, SyntaxTreeToken p_token_5)
		{
			_init ();
			this.kind = (uint) production_kind.g_PartialSpecification_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_dot = p_token_1;
			children [2] = m_dot_1 = p_token_2;
			children [3] = m_dot_2 = p_token_3;
			children [4] = m_comma = p_token_4;
			children [5] = m_TypeConstraints = p_TypeConstraints;
			children [6] = m_right_curly_bracket = p_token_5;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule PartialSpecification
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_dot != null) && m_dot.checkInclusion (element) ||
				(m_dot_1 != null) && m_dot_1.checkInclusion (element) ||
				(m_dot_2 != null) && m_dot_2.checkInclusion (element) ||
				(m_comma != null) && m_comma.checkInclusion (element) ||
				(m_TypeConstraints != null) && m_TypeConstraints.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule PartialSpecification

		//
		// emit production tree node associated with any production of syntax rule PartialSpecification
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_PartialSpecification_1:
					// emit syntax tree node associated with production
					// PartialSpecification: "{" "." "." "." "," TypeConstraints "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_dot.Emit (depth - 1);
					s += " ";
					s += m_dot_1.Emit (depth - 1);
					s += " ";
					s += m_dot_2.Emit (depth - 1);
					s += " ";
					s += m_comma.Emit (depth - 1);
					s += " ";
					s += m_TypeConstraints.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule PartialSpecification
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "PartialSpecification (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_PartialSpecification_1:
					// emit syntax tree node associated with production
					// PartialSpecification: "{" "." "." "." "," TypeConstraints "}"

					s += "left_curly_bracket";
					s += ' ';
					s += "dot";
					s += ' ';
					s += "dot";
					s += ' ';
					s += "dot";
					s += ' ';
					s += "comma";
					s += ' ';
					s += m_TypeConstraints.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule PartialSpecification

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule PartialSpecification with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			PartialSpecification.production_kind kind = (PartialSpecification.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case PartialSpecification.production_kind.g_PartialSpecification_1:
					// traverse syntax tree node associated with production
					// PartialSpecification: "{" "." "." "." "," TypeConstraints "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_dot.Visit (visitor, appData);
						m_dot_1.Visit (visitor, appData);
						m_dot_2.Visit (visitor, appData);
						m_comma.Visit (visitor, appData);
						m_TypeConstraints.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_left_curly_bracket?.reparent (this);
			m_dot?.reparent (this);
			m_dot_1?.reparent (this);

			m_dot_2?.reparent (this);

			m_comma?.reparent (this);
			m_TypeConstraints?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule PartialSpecification
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_dot = null;
			m_dot_1 = null;
			m_dot_2 = null;
			m_comma = null;
			m_TypeConstraints = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule PartialSpecification

		// counter of all nodes associated with syntax rule PartialSpecification
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule PartialSpecification
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_dot")] public SyntaxTreeToken m_dot { get; private set; }
		[DataMember (Name = "m_dot_1")] public SyntaxTreeToken m_dot_1 { get; private set; }
		[DataMember (Name = "m_dot_2")] public SyntaxTreeToken m_dot_2 { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		[DataMember (Name = "m_TypeConstraints")] public TypeConstraints m_TypeConstraints { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule PartialSpecification

		// delegate function (callback) prototype associated with syntax rule PartialSpecification
		public delegate bool PartialSpecification_Callback (SyntaxTreeCallbackReason reason, PartialSpecification.production_kind kind, PartialSpecification p_PartialSpecification);

		// event associated with syntax rule PartialSpecification
		public event PartialSpecification_Callback PartialSpecification_Event;

		// event trigger associated with syntax rule PartialSpecification
		public bool Raise_PartialSpecification_Event (SyntaxTreeCallbackReason reason, PartialSpecification.production_kind kind, PartialSpecification p_PartialSpecification)
		{
			bool? status = PartialSpecification_Event?.Invoke (reason, kind, p_PartialSpecification);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule PartialSpecification
		//
		// traverse syntax tree node associated with any production of syntax rule PartialSpecification
		//

		public void Traverse (PartialSpecification p_PartialSpecification)
		{
			if (p_PartialSpecification.isLocked())
				return;
			p_PartialSpecification.dolock();
			PartialSpecification.production_kind kind = (PartialSpecification.production_kind) p_PartialSpecification.kind;
			p_PartialSpecification.turn_reset ();
			if (Raise_PartialSpecification_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_PartialSpecification))
			switch (kind)
			{
				case PartialSpecification.production_kind.g_PartialSpecification_1:
					// traverse syntax tree node associated with production
					// PartialSpecification: "{" "." "." "." "," TypeConstraints "}"

					if (Raise_PartialSpecification_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PartialSpecification))
						Traverse (p_PartialSpecification.m_TypeConstraints);
					p_PartialSpecification.turn_inc ();
					Raise_PartialSpecification_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PartialSpecification);
				break;
			}
			Raise_PartialSpecification_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_PartialSpecification);
			p_PartialSpecification.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule PartialSpecification
		//

		public void TraverseCommon (PartialSpecification p_PartialSpecification)
		{
			PartialSpecification.production_kind kind = (PartialSpecification.production_kind) p_PartialSpecification.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_PartialSpecification))
			switch (kind)
			{
				case PartialSpecification.production_kind.g_PartialSpecification_1:
					// traverse syntax tree node associated with production
					// PartialSpecification: "{" "." "." "." "," TypeConstraints "}"

						TraverseCommon (p_PartialSpecification.m_left_curly_bracket);
						TraverseCommon (p_PartialSpecification.m_dot);
						TraverseCommon (p_PartialSpecification.m_dot_1);
						TraverseCommon (p_PartialSpecification.m_dot_2);
						TraverseCommon (p_PartialSpecification.m_comma);
						TraverseCommon (p_PartialSpecification.m_TypeConstraints);
						TraverseCommon (p_PartialSpecification.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_PartialSpecification);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule PartialSpecification

		//
		// create syntax tree node associated with production
		// PartialSpecification: "{" "." "." "." "," TypeConstraints "}"

		//

		public PartialSpecification PartialSpecification_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, SyntaxTreeToken p_token_4, TypeConstraints p_TypeConstraints, SyntaxTreeToken p_token_5)
		{
			PartialSpecification p_PartialSpecification_ref = new PartialSpecification(p_token, p_token_1, p_token_2, p_token_3, p_token_4, p_TypeConstraints, p_token_5);
			p_token.parent = p_PartialSpecification_ref;
			p_token_1.parent = p_PartialSpecification_ref;
			p_token_2.parent = p_PartialSpecification_ref;
			p_token_3.parent = p_PartialSpecification_ref;
			p_token_4.parent = p_PartialSpecification_ref;
			p_TypeConstraints.parent = p_PartialSpecification_ref;
			p_token_5.parent = p_PartialSpecification_ref;
			Raise_PartialSpecification_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, PartialSpecification.production_kind.g_PartialSpecification_1, p_PartialSpecification_ref);
			return p_PartialSpecification_ref;
		}
		#endregion
	};
}
