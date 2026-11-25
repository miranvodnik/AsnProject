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
	// class associated with syntax rule ValueConstraint
	//

	[DataContract]
	public class	ValueConstraint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ValueConstraint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ValueConstraint
		{
			g_ValueConstraint_1 = 1,	// Constraint

			g_ValueConstraint_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule ValueConstraint

		// markers associated with production: ValueConstraint -> Constraint

		public enum production_marker_1 : ushort
		{
			m_Constraint,
			final
		};

		// markers associated with production: ValueConstraint -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ValueConstraint

		// Constructor declaration(s) associated with production(s) of syntax rule ValueConstraint

		//
		// Constructor associated with the following production(s)
		// ValueConstraint -> Constraint

		//

		public ValueConstraint (Constraint p_Constraint) : base ((uint) ProductionID._ValueConstraint_ID, (uint) production_kind.g_ValueConstraint_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Constraint = p_Constraint;
		}

		//
		// Constructor associated with the following production(s)
		// ValueConstraint -> %empty

		//

		public ValueConstraint () : base ((uint) ProductionID._ValueConstraint_ID, (uint) production_kind.g_ValueConstraint_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public ValueConstraint (ValueConstraint p_ValueConstraint) : base (p_ValueConstraint.id, p_ValueConstraint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ValueConstraint.appInfo;
			switch ((production_kind) p_ValueConstraint.kind)
			{
				case production_kind.g_ValueConstraint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Constraint = (p_ValueConstraint.m_Constraint != null) ? new Constraint (p_ValueConstraint.m_Constraint) : null) != null) m_Constraint.parent = this;
					break;
				case production_kind.g_ValueConstraint_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "ValueConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ValueConstraint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Constraint?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ValueConstraint

		// Content changing function(s) associated with production(s) of syntax rule ValueConstraint

		//
		// Content changing function associated with following production(s)
		// ValueConstraint -> Constraint

		//

		public void change(Constraint p_Constraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_ValueConstraint_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Constraint = p_Constraint;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ValueConstraint -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_ValueConstraint_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ValueConstraint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Constraint != null) && m_Constraint.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ValueConstraint

		//
		// emit production tree node associated with any production of syntax rule ValueConstraint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ValueConstraint_1:
					// emit syntax tree node associated with production
					// ValueConstraint: Constraint

					s += m_Constraint.Emit (depth - 1);
				break;
				case production_kind.g_ValueConstraint_2:
					// emit syntax tree node associated with production
					// ValueConstraint: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ValueConstraint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ValueConstraint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ValueConstraint_1:
					// emit syntax tree node associated with production
					// ValueConstraint: Constraint

					s += m_Constraint.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ValueConstraint_2:
					// emit syntax tree node associated with production
					// ValueConstraint: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ValueConstraint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ValueConstraint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ValueConstraint.production_kind kind = (ValueConstraint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ValueConstraint.production_kind.g_ValueConstraint_1:
					// traverse syntax tree node associated with production
					// ValueConstraint: Constraint

						m_Constraint.Visit (visitor, appData);
				break;
				case ValueConstraint.production_kind.g_ValueConstraint_2:
					// traverse syntax tree node associated with production
					// ValueConstraint: %empty

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
		// initialize object associated with syntax rule ValueConstraint
		//

		public void _init ()
		{
			m_Constraint = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ValueConstraint

		// counter of all nodes associated with syntax rule ValueConstraint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ValueConstraint
		[DataMember (Name = "m_Constraint")] public Constraint m_Constraint { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ValueConstraint

		// delegate function (callback) prototype associated with syntax rule ValueConstraint
		public delegate bool ValueConstraint_Callback (SyntaxTreeCallbackReason reason, ValueConstraint.production_kind kind, ValueConstraint p_ValueConstraint);

		// event associated with syntax rule ValueConstraint
		public event ValueConstraint_Callback ValueConstraint_Event;

		// event trigger associated with syntax rule ValueConstraint
		public bool Raise_ValueConstraint_Event (SyntaxTreeCallbackReason reason, ValueConstraint.production_kind kind, ValueConstraint p_ValueConstraint)
		{
			bool? status = ValueConstraint_Event?.Invoke (reason, kind, p_ValueConstraint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ValueConstraint
		//
		// traverse syntax tree node associated with any production of syntax rule ValueConstraint
		//

		public void Traverse (ValueConstraint p_ValueConstraint)
		{
			if (p_ValueConstraint.isLocked())
				return;
			p_ValueConstraint.dolock();
			ValueConstraint.production_kind kind = (ValueConstraint.production_kind) p_ValueConstraint.kind;
			p_ValueConstraint.turn_reset ();
			if (Raise_ValueConstraint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ValueConstraint))
			switch (kind)
			{
				case ValueConstraint.production_kind.g_ValueConstraint_1:
					// traverse syntax tree node associated with production
					// ValueConstraint: Constraint

					if (Raise_ValueConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueConstraint))
						Traverse (p_ValueConstraint.m_Constraint);
					p_ValueConstraint.turn_inc ();
					Raise_ValueConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueConstraint);
				break;
				case ValueConstraint.production_kind.g_ValueConstraint_2:
					// traverse syntax tree node associated with production
					// ValueConstraint: %empty

				break;
			}
			Raise_ValueConstraint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ValueConstraint);
			p_ValueConstraint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ValueConstraint
		//

		public void TraverseCommon (ValueConstraint p_ValueConstraint)
		{
			ValueConstraint.production_kind kind = (ValueConstraint.production_kind) p_ValueConstraint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ValueConstraint))
			switch (kind)
			{
				case ValueConstraint.production_kind.g_ValueConstraint_1:
					// traverse syntax tree node associated with production
					// ValueConstraint: Constraint

						TraverseCommon (p_ValueConstraint.m_Constraint);
				break;
				case ValueConstraint.production_kind.g_ValueConstraint_2:
					// traverse syntax tree node associated with production
					// ValueConstraint: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ValueConstraint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ValueConstraint

		//
		// create syntax tree node associated with production
		// ValueConstraint: Constraint

		//

		public ValueConstraint ValueConstraint_1 (Constraint p_Constraint)
		{
			ValueConstraint p_ValueConstraint_ref = new ValueConstraint(p_Constraint);
			p_Constraint.parent = p_ValueConstraint_ref;
			Raise_ValueConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ValueConstraint.production_kind.g_ValueConstraint_1, p_ValueConstraint_ref);
			return p_ValueConstraint_ref;
		}

		//
		// create syntax tree node associated with production
		// ValueConstraint: %empty

		//

		public ValueConstraint ValueConstraint_2 ()
		{
			ValueConstraint p_ValueConstraint_ref = new ValueConstraint();
			Raise_ValueConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ValueConstraint.production_kind.g_ValueConstraint_2, p_ValueConstraint_ref);
			return p_ValueConstraint_ref;
		}
		#endregion
	};
}
