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
	// class associated with syntax rule UserDefinedConstraint
	//

	[DataContract]
	public class	UserDefinedConstraint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule UserDefinedConstraint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule UserDefinedConstraint
		{
			g_UserDefinedConstraint_1 = 1,	// CONSTRAINED BY "{" "}"

			g_UserDefinedConstraint_2 = 2,	// CONSTRAINED BY "{" UserDefinedConstraintParameter-set "}"

		};
		#endregion
		#region production markers associated with the syntax rule UserDefinedConstraint

		// markers associated with production: UserDefinedConstraint -> CONSTRAINED BY "{" "}"

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: UserDefinedConstraint -> CONSTRAINED BY "{" UserDefinedConstraintParameter-set "}"

		public enum production_marker_2 : ushort
		{
			m_UserDefinedConstraintParameter_set,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule UserDefinedConstraint

		// Constructor declaration(s) associated with production(s) of syntax rule UserDefinedConstraint

		//
		// Constructor associated with the following production(s)
		// UserDefinedConstraint -> CONSTRAINED BY "{" "}"

		//

		public UserDefinedConstraint (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3) : base ((uint) ProductionID._UserDefinedConstraint_ID, (uint) production_kind.g_UserDefinedConstraint_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_CONSTRAINED = p_token;
			children[1] = m_BY = p_token_1;
			children[2] = m_left_curly_bracket = p_token_2;
			children[3] = m_right_curly_bracket = p_token_3;
		}

		//
		// Constructor associated with the following production(s)
		// UserDefinedConstraint -> CONSTRAINED BY "{" UserDefinedConstraintParameter-set "}"

		//

		public UserDefinedConstraint (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, UserDefinedConstraintParameter_set p_UserDefinedConstraintParameter_set, SyntaxTreeToken p_token_3) : base ((uint) ProductionID._UserDefinedConstraint_ID, (uint) production_kind.g_UserDefinedConstraint_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children[0] = m_CONSTRAINED = p_token;
			children[1] = m_BY = p_token_1;
			children[2] = m_left_curly_bracket = p_token_2;
			children[3] = m_UserDefinedConstraintParameter_set = p_UserDefinedConstraintParameter_set;
			children[4] = m_right_curly_bracket = p_token_3;
		}

		public UserDefinedConstraint () { }

		// Copy constructor

		public UserDefinedConstraint (UserDefinedConstraint p_UserDefinedConstraint) : base (p_UserDefinedConstraint.id, p_UserDefinedConstraint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_UserDefinedConstraint.appInfo;
			switch ((production_kind) p_UserDefinedConstraint.kind)
			{
				case production_kind.g_UserDefinedConstraint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_CONSTRAINED = (p_UserDefinedConstraint.m_CONSTRAINED != null) ? new SyntaxTreeToken (p_UserDefinedConstraint.m_CONSTRAINED) : null) != null) m_CONSTRAINED.parent = this;
					if ((children [1] = m_BY = (p_UserDefinedConstraint.m_BY != null) ? new SyntaxTreeToken (p_UserDefinedConstraint.m_BY) : null) != null) m_BY.parent = this;
					if ((children [2] = m_left_curly_bracket = (p_UserDefinedConstraint.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_UserDefinedConstraint.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_UserDefinedConstraint.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_UserDefinedConstraint.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				case production_kind.g_UserDefinedConstraint_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_CONSTRAINED = (p_UserDefinedConstraint.m_CONSTRAINED != null) ? new SyntaxTreeToken (p_UserDefinedConstraint.m_CONSTRAINED) : null) != null) m_CONSTRAINED.parent = this;
					if ((children [1] = m_BY = (p_UserDefinedConstraint.m_BY != null) ? new SyntaxTreeToken (p_UserDefinedConstraint.m_BY) : null) != null) m_BY.parent = this;
					if ((children [2] = m_left_curly_bracket = (p_UserDefinedConstraint.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_UserDefinedConstraint.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [3] = m_UserDefinedConstraintParameter_set = (p_UserDefinedConstraint.m_UserDefinedConstraintParameter_set != null) ? new UserDefinedConstraintParameter_set (p_UserDefinedConstraint.m_UserDefinedConstraintParameter_set) : null) != null) m_UserDefinedConstraintParameter_set.parent = this;
					if ((children [4] = m_right_curly_bracket = (p_UserDefinedConstraint.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_UserDefinedConstraint.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "UserDefinedConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new UserDefinedConstraint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_CONSTRAINED?.Dispose ();
			m_BY?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_right_curly_bracket?.Dispose ();
			m_UserDefinedConstraintParameter_set?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule UserDefinedConstraint

		// Content changing function(s) associated with production(s) of syntax rule UserDefinedConstraint

		//
		// Content changing function associated with following production(s)
		// UserDefinedConstraint -> CONSTRAINED BY "{" "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3)
		{
			_init ();
			this.kind = (uint) production_kind.g_UserDefinedConstraint_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_CONSTRAINED = p_token;
			children [1] = m_BY = p_token_1;
			children [2] = m_left_curly_bracket = p_token_2;
			children [3] = m_right_curly_bracket = p_token_3;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// UserDefinedConstraint -> CONSTRAINED BY "{" UserDefinedConstraintParameter-set "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, UserDefinedConstraintParameter_set p_UserDefinedConstraintParameter_set, SyntaxTreeToken p_token_3)
		{
			_init ();
			this.kind = (uint) production_kind.g_UserDefinedConstraint_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children [0] = m_CONSTRAINED = p_token;
			children [1] = m_BY = p_token_1;
			children [2] = m_left_curly_bracket = p_token_2;
			children [3] = m_UserDefinedConstraintParameter_set = p_UserDefinedConstraintParameter_set;
			children [4] = m_right_curly_bracket = p_token_3;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule UserDefinedConstraint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_CONSTRAINED != null) && m_CONSTRAINED.checkInclusion (element) ||
				(m_BY != null) && m_BY.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				(m_UserDefinedConstraintParameter_set != null) && m_UserDefinedConstraintParameter_set.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule UserDefinedConstraint

		//
		// emit production tree node associated with any production of syntax rule UserDefinedConstraint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_UserDefinedConstraint_1:
					// emit syntax tree node associated with production
					// UserDefinedConstraint: CONSTRAINED BY "{" "}"

					s += m_CONSTRAINED.Emit (depth - 1);
					s += " ";
					s += m_BY.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
				case production_kind.g_UserDefinedConstraint_2:
					// emit syntax tree node associated with production
					// UserDefinedConstraint: CONSTRAINED BY "{" UserDefinedConstraintParameter-set "}"

					s += m_CONSTRAINED.Emit (depth - 1);
					s += " ";
					s += m_BY.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_UserDefinedConstraintParameter_set.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule UserDefinedConstraint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "UserDefinedConstraint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_UserDefinedConstraint_1:
					// emit syntax tree node associated with production
					// UserDefinedConstraint: CONSTRAINED BY "{" "}"

					s += "CONSTRAINED";
					s += ' ';
					s += "BY";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += "right_curly_bracket";
				break;
				case production_kind.g_UserDefinedConstraint_2:
					// emit syntax tree node associated with production
					// UserDefinedConstraint: CONSTRAINED BY "{" UserDefinedConstraintParameter-set "}"

					s += "CONSTRAINED";
					s += ' ';
					s += "BY";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_UserDefinedConstraintParameter_set.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule UserDefinedConstraint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule UserDefinedConstraint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			UserDefinedConstraint.production_kind kind = (UserDefinedConstraint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case UserDefinedConstraint.production_kind.g_UserDefinedConstraint_1:
					// traverse syntax tree node associated with production
					// UserDefinedConstraint: CONSTRAINED BY "{" "}"

						m_CONSTRAINED.Visit (visitor, appData);
						m_BY.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
				case UserDefinedConstraint.production_kind.g_UserDefinedConstraint_2:
					// traverse syntax tree node associated with production
					// UserDefinedConstraint: CONSTRAINED BY "{" UserDefinedConstraintParameter-set "}"

						m_CONSTRAINED.Visit (visitor, appData);
						m_BY.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_UserDefinedConstraintParameter_set.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_CONSTRAINED?.reparent (this);
			m_BY?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_right_curly_bracket?.reparent (this);
			m_UserDefinedConstraintParameter_set?.reparent (this);
		}

		//
		// initialize object associated with syntax rule UserDefinedConstraint
		//

		public void _init ()
		{
			m_CONSTRAINED = null;
			m_BY = null;
			m_left_curly_bracket = null;
			m_right_curly_bracket = null;
			m_UserDefinedConstraintParameter_set = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule UserDefinedConstraint

		// counter of all nodes associated with syntax rule UserDefinedConstraint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule UserDefinedConstraint
		[DataMember (Name = "m_CONSTRAINED")] public SyntaxTreeToken m_CONSTRAINED { get; private set; }
		[DataMember (Name = "m_BY")] public SyntaxTreeToken m_BY { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		[DataMember (Name = "m_UserDefinedConstraintParameter_set")] public UserDefinedConstraintParameter_set m_UserDefinedConstraintParameter_set { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule UserDefinedConstraint

		// delegate function (callback) prototype associated with syntax rule UserDefinedConstraint
		public delegate bool UserDefinedConstraint_Callback (SyntaxTreeCallbackReason reason, UserDefinedConstraint.production_kind kind, UserDefinedConstraint p_UserDefinedConstraint);

		// event associated with syntax rule UserDefinedConstraint
		public event UserDefinedConstraint_Callback UserDefinedConstraint_Event;

		// event trigger associated with syntax rule UserDefinedConstraint
		public bool Raise_UserDefinedConstraint_Event (SyntaxTreeCallbackReason reason, UserDefinedConstraint.production_kind kind, UserDefinedConstraint p_UserDefinedConstraint)
		{
			bool? status = UserDefinedConstraint_Event?.Invoke (reason, kind, p_UserDefinedConstraint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule UserDefinedConstraint
		//
		// traverse syntax tree node associated with any production of syntax rule UserDefinedConstraint
		//

		public void Traverse (UserDefinedConstraint p_UserDefinedConstraint)
		{
			if (p_UserDefinedConstraint.isLocked())
				return;
			p_UserDefinedConstraint.dolock();
			UserDefinedConstraint.production_kind kind = (UserDefinedConstraint.production_kind) p_UserDefinedConstraint.kind;
			p_UserDefinedConstraint.turn_reset ();
			if (Raise_UserDefinedConstraint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_UserDefinedConstraint))
			switch (kind)
			{
				case UserDefinedConstraint.production_kind.g_UserDefinedConstraint_1:
					// traverse syntax tree node associated with production
					// UserDefinedConstraint: CONSTRAINED BY "{" "}"

				break;
				case UserDefinedConstraint.production_kind.g_UserDefinedConstraint_2:
					// traverse syntax tree node associated with production
					// UserDefinedConstraint: CONSTRAINED BY "{" UserDefinedConstraintParameter-set "}"

					if (Raise_UserDefinedConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UserDefinedConstraint))
						Traverse (p_UserDefinedConstraint.m_UserDefinedConstraintParameter_set);
					p_UserDefinedConstraint.turn_inc ();
					Raise_UserDefinedConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UserDefinedConstraint);
				break;
			}
			Raise_UserDefinedConstraint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_UserDefinedConstraint);
			p_UserDefinedConstraint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule UserDefinedConstraint
		//

		public void TraverseCommon (UserDefinedConstraint p_UserDefinedConstraint)
		{
			UserDefinedConstraint.production_kind kind = (UserDefinedConstraint.production_kind) p_UserDefinedConstraint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_UserDefinedConstraint))
			switch (kind)
			{
				case UserDefinedConstraint.production_kind.g_UserDefinedConstraint_1:
					// traverse syntax tree node associated with production
					// UserDefinedConstraint: CONSTRAINED BY "{" "}"

						TraverseCommon (p_UserDefinedConstraint.m_CONSTRAINED);
						TraverseCommon (p_UserDefinedConstraint.m_BY);
						TraverseCommon (p_UserDefinedConstraint.m_left_curly_bracket);
						TraverseCommon (p_UserDefinedConstraint.m_right_curly_bracket);
				break;
				case UserDefinedConstraint.production_kind.g_UserDefinedConstraint_2:
					// traverse syntax tree node associated with production
					// UserDefinedConstraint: CONSTRAINED BY "{" UserDefinedConstraintParameter-set "}"

						TraverseCommon (p_UserDefinedConstraint.m_CONSTRAINED);
						TraverseCommon (p_UserDefinedConstraint.m_BY);
						TraverseCommon (p_UserDefinedConstraint.m_left_curly_bracket);
						TraverseCommon (p_UserDefinedConstraint.m_UserDefinedConstraintParameter_set);
						TraverseCommon (p_UserDefinedConstraint.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_UserDefinedConstraint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule UserDefinedConstraint

		//
		// create syntax tree node associated with production
		// UserDefinedConstraint: CONSTRAINED BY "{" "}"

		//

		public UserDefinedConstraint UserDefinedConstraint_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3)
		{
			UserDefinedConstraint p_UserDefinedConstraint_ref = new UserDefinedConstraint(p_token, p_token_1, p_token_2, p_token_3);
			p_token.parent = p_UserDefinedConstraint_ref;
			p_token_1.parent = p_UserDefinedConstraint_ref;
			p_token_2.parent = p_UserDefinedConstraint_ref;
			p_token_3.parent = p_UserDefinedConstraint_ref;
			Raise_UserDefinedConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UserDefinedConstraint.production_kind.g_UserDefinedConstraint_1, p_UserDefinedConstraint_ref);
			return p_UserDefinedConstraint_ref;
		}

		//
		// create syntax tree node associated with production
		// UserDefinedConstraint: CONSTRAINED BY "{" UserDefinedConstraintParameter-set "}"

		//

		public UserDefinedConstraint UserDefinedConstraint_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, UserDefinedConstraintParameter_set p_UserDefinedConstraintParameter_set, SyntaxTreeToken p_token_3)
		{
			UserDefinedConstraint p_UserDefinedConstraint_ref = new UserDefinedConstraint(p_token, p_token_1, p_token_2, p_UserDefinedConstraintParameter_set, p_token_3);
			p_token.parent = p_UserDefinedConstraint_ref;
			p_token_1.parent = p_UserDefinedConstraint_ref;
			p_token_2.parent = p_UserDefinedConstraint_ref;
			p_UserDefinedConstraintParameter_set.parent = p_UserDefinedConstraint_ref;
			p_token_3.parent = p_UserDefinedConstraint_ref;
			Raise_UserDefinedConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UserDefinedConstraint.production_kind.g_UserDefinedConstraint_2, p_UserDefinedConstraint_ref);
			return p_UserDefinedConstraint_ref;
		}
		#endregion
	};
}
