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
	// class associated with syntax rule SingleTypeConstraint
	//

	[DataContract]
	public class	SingleTypeConstraint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SingleTypeConstraint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SingleTypeConstraint
		{
			g_SingleTypeConstraint_1 = 1,	// Constraint

		};
		#endregion
		#region production markers associated with the syntax rule SingleTypeConstraint

		// markers associated with production: SingleTypeConstraint -> Constraint

		public enum production_marker_1 : ushort
		{
			m_Constraint,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SingleTypeConstraint

		// Constructor declaration(s) associated with production(s) of syntax rule SingleTypeConstraint

		//
		// Constructor associated with the following production(s)
		// SingleTypeConstraint -> Constraint

		//

		public SingleTypeConstraint (Constraint p_Constraint) : base ((uint) ProductionID._SingleTypeConstraint_ID, (uint) production_kind.g_SingleTypeConstraint_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Constraint = p_Constraint;
		}

		public SingleTypeConstraint () { }

		// Copy constructor

		public SingleTypeConstraint (SingleTypeConstraint p_SingleTypeConstraint) : base (p_SingleTypeConstraint.id, p_SingleTypeConstraint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SingleTypeConstraint.appInfo;
			switch ((production_kind) p_SingleTypeConstraint.kind)
			{
				case production_kind.g_SingleTypeConstraint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Constraint = (p_SingleTypeConstraint.m_Constraint != null) ? new Constraint (p_SingleTypeConstraint.m_Constraint) : null) != null) m_Constraint.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SingleTypeConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SingleTypeConstraint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Constraint?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SingleTypeConstraint

		// Content changing function(s) associated with production(s) of syntax rule SingleTypeConstraint

		//
		// Content changing function associated with following production(s)
		// SingleTypeConstraint -> Constraint

		//

		public void change(Constraint p_Constraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_SingleTypeConstraint_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Constraint = p_Constraint;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SingleTypeConstraint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Constraint != null) && m_Constraint.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SingleTypeConstraint

		//
		// emit production tree node associated with any production of syntax rule SingleTypeConstraint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SingleTypeConstraint_1:
					// emit syntax tree node associated with production
					// SingleTypeConstraint: Constraint

					s += m_Constraint.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SingleTypeConstraint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SingleTypeConstraint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SingleTypeConstraint_1:
					// emit syntax tree node associated with production
					// SingleTypeConstraint: Constraint

					s += m_Constraint.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SingleTypeConstraint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SingleTypeConstraint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SingleTypeConstraint.production_kind kind = (SingleTypeConstraint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SingleTypeConstraint.production_kind.g_SingleTypeConstraint_1:
					// traverse syntax tree node associated with production
					// SingleTypeConstraint: Constraint

						m_Constraint.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Constraint?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SingleTypeConstraint
		//

		public void _init ()
		{
			m_Constraint = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SingleTypeConstraint

		// counter of all nodes associated with syntax rule SingleTypeConstraint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SingleTypeConstraint
		[DataMember (Name = "m_Constraint")] public Constraint m_Constraint { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SingleTypeConstraint

		// delegate function (callback) prototype associated with syntax rule SingleTypeConstraint
		public delegate bool SingleTypeConstraint_Callback (SyntaxTreeCallbackReason reason, SingleTypeConstraint.production_kind kind, SingleTypeConstraint p_SingleTypeConstraint);

		// event associated with syntax rule SingleTypeConstraint
		public event SingleTypeConstraint_Callback SingleTypeConstraint_Event;

		// event trigger associated with syntax rule SingleTypeConstraint
		public bool Raise_SingleTypeConstraint_Event (SyntaxTreeCallbackReason reason, SingleTypeConstraint.production_kind kind, SingleTypeConstraint p_SingleTypeConstraint)
		{
			bool? status = SingleTypeConstraint_Event?.Invoke (reason, kind, p_SingleTypeConstraint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SingleTypeConstraint
		//
		// traverse syntax tree node associated with any production of syntax rule SingleTypeConstraint
		//

		public void Traverse (SingleTypeConstraint p_SingleTypeConstraint)
		{
			if (p_SingleTypeConstraint.isLocked())
				return;
			p_SingleTypeConstraint.dolock();
			SingleTypeConstraint.production_kind kind = (SingleTypeConstraint.production_kind) p_SingleTypeConstraint.kind;
			p_SingleTypeConstraint.turn_reset ();
			if (Raise_SingleTypeConstraint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SingleTypeConstraint))
			switch (kind)
			{
				case SingleTypeConstraint.production_kind.g_SingleTypeConstraint_1:
					// traverse syntax tree node associated with production
					// SingleTypeConstraint: Constraint

					if (Raise_SingleTypeConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SingleTypeConstraint))
						Traverse (p_SingleTypeConstraint.m_Constraint);
					p_SingleTypeConstraint.turn_inc ();
					Raise_SingleTypeConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SingleTypeConstraint);
				break;
			}
			Raise_SingleTypeConstraint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SingleTypeConstraint);
			p_SingleTypeConstraint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SingleTypeConstraint
		//

		public void TraverseCommon (SingleTypeConstraint p_SingleTypeConstraint)
		{
			SingleTypeConstraint.production_kind kind = (SingleTypeConstraint.production_kind) p_SingleTypeConstraint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SingleTypeConstraint))
			switch (kind)
			{
				case SingleTypeConstraint.production_kind.g_SingleTypeConstraint_1:
					// traverse syntax tree node associated with production
					// SingleTypeConstraint: Constraint

						TraverseCommon (p_SingleTypeConstraint.m_Constraint);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SingleTypeConstraint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SingleTypeConstraint

		//
		// create syntax tree node associated with production
		// SingleTypeConstraint: Constraint

		//

		public SingleTypeConstraint SingleTypeConstraint_1 (Constraint p_Constraint)
		{
			SingleTypeConstraint p_SingleTypeConstraint_ref = new SingleTypeConstraint(p_Constraint);
			p_Constraint.parent = p_SingleTypeConstraint_ref;
			Raise_SingleTypeConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SingleTypeConstraint.production_kind.g_SingleTypeConstraint_1, p_SingleTypeConstraint_ref);
			return p_SingleTypeConstraint_ref;
		}
		#endregion
	};
}
