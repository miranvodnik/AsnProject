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
	// class associated with syntax rule Constraint
	//

	[DataContract]
	public class	Constraint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Constraint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Constraint
		{
			g_Constraint_1 = 1,	// "(" ConstraintSpec ExceptionSpec ")"

		};
		#endregion
		#region production markers associated with the syntax rule Constraint

		// markers associated with production: Constraint -> "(" ConstraintSpec ExceptionSpec ")"

		public enum production_marker_1 : ushort
		{
			m_ConstraintSpec,
			m_ExceptionSpec,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Constraint

		// Constructor declaration(s) associated with production(s) of syntax rule Constraint

		//
		// Constructor associated with the following production(s)
		// Constraint -> "(" ConstraintSpec ExceptionSpec ")"

		//

		public Constraint (SyntaxTreeToken p_token, ConstraintSpec p_ConstraintSpec, ExceptionSpec p_ExceptionSpec, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._Constraint_ID, (uint) production_kind.g_Constraint_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_left_round_bracket = p_token;
			children[1] = m_ConstraintSpec = p_ConstraintSpec;
			children[2] = m_ExceptionSpec = p_ExceptionSpec;
			children[3] = m_right_round_bracket = p_token_1;
		}

		public Constraint () { }

		// Copy constructor

		public Constraint (Constraint p_Constraint) : base (p_Constraint.id, p_Constraint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Constraint.appInfo;
			switch ((production_kind) p_Constraint.kind)
			{
				case production_kind.g_Constraint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_left_round_bracket = (p_Constraint.m_left_round_bracket != null) ? new SyntaxTreeToken (p_Constraint.m_left_round_bracket) : null) != null) m_left_round_bracket.parent = this;
					if ((children [1] = m_ConstraintSpec = (p_Constraint.m_ConstraintSpec != null) ? new ConstraintSpec (p_Constraint.m_ConstraintSpec) : null) != null) m_ConstraintSpec.parent = this;
					if ((children [2] = m_ExceptionSpec = (p_Constraint.m_ExceptionSpec != null) ? new ExceptionSpec (p_Constraint.m_ExceptionSpec) : null) != null) m_ExceptionSpec.parent = this;
					if ((children [3] = m_right_round_bracket = (p_Constraint.m_right_round_bracket != null) ? new SyntaxTreeToken (p_Constraint.m_right_round_bracket) : null) != null) m_right_round_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Constraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Constraint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_round_bracket?.Dispose ();
			m_ConstraintSpec?.Dispose ();
			m_ExceptionSpec?.Dispose ();
			m_right_round_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Constraint

		// Content changing function(s) associated with production(s) of syntax rule Constraint

		//
		// Content changing function associated with following production(s)
		// Constraint -> "(" ConstraintSpec ExceptionSpec ")"

		//

		public void change(SyntaxTreeToken p_token, ConstraintSpec p_ConstraintSpec, ExceptionSpec p_ExceptionSpec, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_Constraint_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_left_round_bracket = p_token;
			children [1] = m_ConstraintSpec = p_ConstraintSpec;
			children [2] = m_ExceptionSpec = p_ExceptionSpec;
			children [3] = m_right_round_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Constraint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_round_bracket != null) && m_left_round_bracket.checkInclusion (element) ||
				(m_ConstraintSpec != null) && m_ConstraintSpec.checkInclusion (element) ||
				(m_ExceptionSpec != null) && m_ExceptionSpec.checkInclusion (element) ||
				(m_right_round_bracket != null) && m_right_round_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Constraint

		//
		// emit production tree node associated with any production of syntax rule Constraint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Constraint_1:
					// emit syntax tree node associated with production
					// Constraint: "(" ConstraintSpec ExceptionSpec ")"

					s += m_left_round_bracket.Emit (depth - 1);
					s += " ";
					s += m_ConstraintSpec.Emit (depth - 1);
					s += " ";
					s += m_ExceptionSpec.Emit (depth - 1);
					s += " ";
					s += m_right_round_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Constraint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Constraint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Constraint_1:
					// emit syntax tree node associated with production
					// Constraint: "(" ConstraintSpec ExceptionSpec ")"

					s += "left_round_bracket";
					s += ' ';
					s += m_ConstraintSpec.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ExceptionSpec.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_round_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Constraint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Constraint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Constraint.production_kind kind = (Constraint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Constraint.production_kind.g_Constraint_1:
					// traverse syntax tree node associated with production
					// Constraint: "(" ConstraintSpec ExceptionSpec ")"

						m_left_round_bracket.Visit (visitor, appData);
						m_ConstraintSpec.Visit (visitor, appData);
						m_ExceptionSpec.Visit (visitor, appData);
						m_right_round_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_left_round_bracket?.reparent (this);
			m_ConstraintSpec?.reparent (this);
			m_ExceptionSpec?.reparent (this);
			m_right_round_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Constraint
		//

		public void _init ()
		{
			m_left_round_bracket = null;
			m_ConstraintSpec = null;
			m_ExceptionSpec = null;
			m_right_round_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Constraint

		// counter of all nodes associated with syntax rule Constraint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Constraint
		[DataMember (Name = "m_left_round_bracket")] public SyntaxTreeToken m_left_round_bracket { get; private set; }
		[DataMember (Name = "m_ConstraintSpec")] public ConstraintSpec m_ConstraintSpec { get; private set; }
		[DataMember (Name = "m_ExceptionSpec")] public ExceptionSpec m_ExceptionSpec { get; private set; }
		[DataMember (Name = "m_right_round_bracket")] public SyntaxTreeToken m_right_round_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Constraint

		// delegate function (callback) prototype associated with syntax rule Constraint
		public delegate bool Constraint_Callback (SyntaxTreeCallbackReason reason, Constraint.production_kind kind, Constraint p_Constraint);

		// event associated with syntax rule Constraint
		public event Constraint_Callback Constraint_Event;

		// event trigger associated with syntax rule Constraint
		public bool Raise_Constraint_Event (SyntaxTreeCallbackReason reason, Constraint.production_kind kind, Constraint p_Constraint)
		{
			bool? status = Constraint_Event?.Invoke (reason, kind, p_Constraint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Constraint
		//
		// traverse syntax tree node associated with any production of syntax rule Constraint
		//

		public void Traverse (Constraint p_Constraint)
		{
			if (p_Constraint.isLocked())
				return;
			p_Constraint.dolock();
			Constraint.production_kind kind = (Constraint.production_kind) p_Constraint.kind;
			p_Constraint.turn_reset ();
			if (Raise_Constraint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Constraint))
			switch (kind)
			{
				case Constraint.production_kind.g_Constraint_1:
					// traverse syntax tree node associated with production
					// Constraint: "(" ConstraintSpec ExceptionSpec ")"

					if (Raise_Constraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Constraint))
						Traverse (p_Constraint.m_ConstraintSpec);
					p_Constraint.turn_inc ();
					if (Raise_Constraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Constraint))
						Traverse (p_Constraint.m_ExceptionSpec);
					p_Constraint.turn_inc ();
					Raise_Constraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Constraint);
				break;
			}
			Raise_Constraint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Constraint);
			p_Constraint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Constraint
		//

		public void TraverseCommon (Constraint p_Constraint)
		{
			Constraint.production_kind kind = (Constraint.production_kind) p_Constraint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Constraint))
			switch (kind)
			{
				case Constraint.production_kind.g_Constraint_1:
					// traverse syntax tree node associated with production
					// Constraint: "(" ConstraintSpec ExceptionSpec ")"

						TraverseCommon (p_Constraint.m_left_round_bracket);
						TraverseCommon (p_Constraint.m_ConstraintSpec);
						TraverseCommon (p_Constraint.m_ExceptionSpec);
						TraverseCommon (p_Constraint.m_right_round_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Constraint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Constraint

		//
		// create syntax tree node associated with production
		// Constraint: "(" ConstraintSpec ExceptionSpec ")"

		//

		public Constraint Constraint_1 (SyntaxTreeToken p_token, ConstraintSpec p_ConstraintSpec, ExceptionSpec p_ExceptionSpec, SyntaxTreeToken p_token_1)
		{
			Constraint p_Constraint_ref = new Constraint(p_token, p_ConstraintSpec, p_ExceptionSpec, p_token_1);
			p_token.parent = p_Constraint_ref;
			p_ConstraintSpec.parent = p_Constraint_ref;
			p_ExceptionSpec.parent = p_Constraint_ref;
			p_token_1.parent = p_Constraint_ref;
			Raise_Constraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Constraint.production_kind.g_Constraint_1, p_Constraint_ref);
			return p_Constraint_ref;
		}
		#endregion
	};
}
