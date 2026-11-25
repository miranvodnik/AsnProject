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
	// class associated with syntax rule SizeConstraint
	//

	[DataContract]
	public class	SizeConstraint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SizeConstraint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SizeConstraint
		{
			g_SizeConstraint_1 = 1,	// SIZE Constraint

		};
		#endregion
		#region production markers associated with the syntax rule SizeConstraint

		// markers associated with production: SizeConstraint -> SIZE Constraint

		public enum production_marker_1 : ushort
		{
			m_Constraint,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SizeConstraint

		// Constructor declaration(s) associated with production(s) of syntax rule SizeConstraint

		//
		// Constructor associated with the following production(s)
		// SizeConstraint -> SIZE Constraint

		//

		public SizeConstraint (SyntaxTreeToken p_token, Constraint p_Constraint) : base ((uint) ProductionID._SizeConstraint_ID, (uint) production_kind.g_SizeConstraint_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_SIZE = p_token;
			children[1] = m_Constraint = p_Constraint;
		}

		public SizeConstraint () { }

		// Copy constructor

		public SizeConstraint (SizeConstraint p_SizeConstraint) : base (p_SizeConstraint.id, p_SizeConstraint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SizeConstraint.appInfo;
			switch ((production_kind) p_SizeConstraint.kind)
			{
				case production_kind.g_SizeConstraint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_SIZE = (p_SizeConstraint.m_SIZE != null) ? new SyntaxTreeToken (p_SizeConstraint.m_SIZE) : null) != null) m_SIZE.parent = this;
					if ((children [1] = m_Constraint = (p_SizeConstraint.m_Constraint != null) ? new Constraint (p_SizeConstraint.m_Constraint) : null) != null) m_Constraint.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SizeConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SizeConstraint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SIZE?.Dispose ();
			m_Constraint?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SizeConstraint

		// Content changing function(s) associated with production(s) of syntax rule SizeConstraint

		//
		// Content changing function associated with following production(s)
		// SizeConstraint -> SIZE Constraint

		//

		public void change(SyntaxTreeToken p_token, Constraint p_Constraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_SizeConstraint_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_SIZE = p_token;
			children [1] = m_Constraint = p_Constraint;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SizeConstraint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SIZE != null) && m_SIZE.checkInclusion (element) ||
				(m_Constraint != null) && m_Constraint.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SizeConstraint

		//
		// emit production tree node associated with any production of syntax rule SizeConstraint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SizeConstraint_1:
					// emit syntax tree node associated with production
					// SizeConstraint: SIZE Constraint

					s += m_SIZE.Emit (depth - 1);
					s += " ";
					s += m_Constraint.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SizeConstraint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SizeConstraint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SizeConstraint_1:
					// emit syntax tree node associated with production
					// SizeConstraint: SIZE Constraint

					s += "SIZE";
					s += ' ';
					s += m_Constraint.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SizeConstraint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SizeConstraint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SizeConstraint.production_kind kind = (SizeConstraint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SizeConstraint.production_kind.g_SizeConstraint_1:
					// traverse syntax tree node associated with production
					// SizeConstraint: SIZE Constraint

						m_SIZE.Visit (visitor, appData);
						m_Constraint.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SIZE?.reparent (this);
			m_Constraint?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SizeConstraint
		//

		public void _init ()
		{
			m_SIZE = null;
			m_Constraint = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SizeConstraint

		// counter of all nodes associated with syntax rule SizeConstraint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SizeConstraint
		[DataMember (Name = "m_SIZE")] public SyntaxTreeToken m_SIZE { get; private set; }
		[DataMember (Name = "m_Constraint")] public Constraint m_Constraint { get; private set; }

		public enum __size_markers
		{
			push_governor = 0,
			pop_governor = 1,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SizeConstraint

		// delegate function (callback) prototype associated with syntax rule SizeConstraint
		public delegate bool SizeConstraint_Callback (SyntaxTreeCallbackReason reason, SizeConstraint.production_kind kind, SizeConstraint p_SizeConstraint);

		// event associated with syntax rule SizeConstraint
		public event SizeConstraint_Callback SizeConstraint_Event;

		// event trigger associated with syntax rule SizeConstraint
		public bool Raise_SizeConstraint_Event (SyntaxTreeCallbackReason reason, SizeConstraint.production_kind kind, SizeConstraint p_SizeConstraint)
		{
			bool? status = SizeConstraint_Event?.Invoke (reason, kind, p_SizeConstraint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SizeConstraint
		//
		// traverse syntax tree node associated with any production of syntax rule SizeConstraint
		//

		public void Traverse (SizeConstraint p_SizeConstraint)
		{
			if (p_SizeConstraint.isLocked())
				return;
			p_SizeConstraint.dolock();
			SizeConstraint.production_kind kind = (SizeConstraint.production_kind) p_SizeConstraint.kind;
			p_SizeConstraint.turn_reset ();
			if (Raise_SizeConstraint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SizeConstraint))
			switch (kind)
			{
				case SizeConstraint.production_kind.g_SizeConstraint_1:
					// traverse syntax tree node associated with production
					// SizeConstraint: SIZE Constraint

					if (Raise_SizeConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SizeConstraint))
						Traverse (p_SizeConstraint.m_Constraint);
					p_SizeConstraint.turn_inc ();
					Raise_SizeConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SizeConstraint);
				break;
			}
			Raise_SizeConstraint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SizeConstraint);
			p_SizeConstraint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SizeConstraint
		//

		public void TraverseCommon (SizeConstraint p_SizeConstraint)
		{
			SizeConstraint.production_kind kind = (SizeConstraint.production_kind) p_SizeConstraint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SizeConstraint))
			switch (kind)
			{
				case SizeConstraint.production_kind.g_SizeConstraint_1:
					// traverse syntax tree node associated with production
					// SizeConstraint: SIZE Constraint

						TraverseCommon (p_SizeConstraint.m_SIZE);
						TraverseCommon (p_SizeConstraint.m_Constraint);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SizeConstraint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SizeConstraint

		//
		// create syntax tree node associated with production
		// SizeConstraint: SIZE Constraint

		//

		public SizeConstraint SizeConstraint_1 (SyntaxTreeToken p_token, Constraint p_Constraint)
		{
			SizeConstraint p_SizeConstraint_ref = new SizeConstraint(p_token, p_Constraint);
			p_token.parent = p_SizeConstraint_ref;
			p_Constraint.parent = p_SizeConstraint_ref;
			Raise_SizeConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SizeConstraint.production_kind.g_SizeConstraint_1, p_SizeConstraint_ref);
			return p_SizeConstraint_ref;
		}
		#endregion
	};
}
