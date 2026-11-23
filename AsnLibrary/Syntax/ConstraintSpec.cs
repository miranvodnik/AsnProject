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
	// class associated with syntax rule ConstraintSpec
	//

	[DataContract]
	public class	ConstraintSpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ConstraintSpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ConstraintSpec
		{
			g_ConstraintSpec_1 = 1,	// SubtypeConstraint

			g_ConstraintSpec_2 = 2,	// GeneralConstraint

		};
		#endregion
		#region production markers associated with the syntax rule ConstraintSpec

		// markers associated with production: ConstraintSpec -> SubtypeConstraint

		public enum production_marker_1 : ushort
		{
			m_SubtypeConstraint,
			final
		};

		// markers associated with production: ConstraintSpec -> GeneralConstraint

		public enum production_marker_2 : ushort
		{
			m_GeneralConstraint,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ConstraintSpec

		// Constructor declaration(s) associated with production(s) of syntax rule ConstraintSpec

		//
		// Constructor associated with the following production(s)
		// ConstraintSpec -> SubtypeConstraint

		//

		public ConstraintSpec (SubtypeConstraint p_SubtypeConstraint) : base ((uint) ProductionID._ConstraintSpec_ID, (uint) production_kind.g_ConstraintSpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SubtypeConstraint = p_SubtypeConstraint;
		}

		//
		// Constructor associated with the following production(s)
		// ConstraintSpec -> GeneralConstraint

		//

		public ConstraintSpec (GeneralConstraint p_GeneralConstraint) : base ((uint) ProductionID._ConstraintSpec_ID, (uint) production_kind.g_ConstraintSpec_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_GeneralConstraint = p_GeneralConstraint;
		}

		public ConstraintSpec () { }

		// Copy constructor

		public ConstraintSpec (ConstraintSpec p_ConstraintSpec) : base (p_ConstraintSpec.id, p_ConstraintSpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ConstraintSpec.appInfo;
			switch ((production_kind) p_ConstraintSpec.kind)
			{
				case production_kind.g_ConstraintSpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SubtypeConstraint = (p_ConstraintSpec.m_SubtypeConstraint != null) ? new SubtypeConstraint (p_ConstraintSpec.m_SubtypeConstraint) : null) != null) m_SubtypeConstraint.parent = this;
					break;
				case production_kind.g_ConstraintSpec_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_GeneralConstraint = (p_ConstraintSpec.m_GeneralConstraint != null) ? new GeneralConstraint (p_ConstraintSpec.m_GeneralConstraint) : null) != null) m_GeneralConstraint.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ConstraintSpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ConstraintSpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SubtypeConstraint?.Dispose ();
			m_GeneralConstraint?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ConstraintSpec

		// Content changing function(s) associated with production(s) of syntax rule ConstraintSpec

		//
		// Content changing function associated with following production(s)
		// ConstraintSpec -> SubtypeConstraint

		//

		public void change(SubtypeConstraint p_SubtypeConstraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_ConstraintSpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SubtypeConstraint = p_SubtypeConstraint;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ConstraintSpec -> GeneralConstraint

		//

		public void change(GeneralConstraint p_GeneralConstraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_ConstraintSpec_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_GeneralConstraint = p_GeneralConstraint;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ConstraintSpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SubtypeConstraint != null) && m_SubtypeConstraint.checkInclusion (element) ||
				(m_GeneralConstraint != null) && m_GeneralConstraint.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ConstraintSpec

		//
		// emit production tree node associated with any production of syntax rule ConstraintSpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ConstraintSpec_1:
					// emit syntax tree node associated with production
					// ConstraintSpec: SubtypeConstraint

					s += m_SubtypeConstraint.Emit (depth - 1);
				break;
				case production_kind.g_ConstraintSpec_2:
					// emit syntax tree node associated with production
					// ConstraintSpec: GeneralConstraint

					s += m_GeneralConstraint.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ConstraintSpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ConstraintSpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ConstraintSpec_1:
					// emit syntax tree node associated with production
					// ConstraintSpec: SubtypeConstraint

					s += m_SubtypeConstraint.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ConstraintSpec_2:
					// emit syntax tree node associated with production
					// ConstraintSpec: GeneralConstraint

					s += m_GeneralConstraint.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ConstraintSpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ConstraintSpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ConstraintSpec.production_kind kind = (ConstraintSpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ConstraintSpec.production_kind.g_ConstraintSpec_1:
					// traverse syntax tree node associated with production
					// ConstraintSpec: SubtypeConstraint

						m_SubtypeConstraint.Visit (visitor, appData);
				break;
				case ConstraintSpec.production_kind.g_ConstraintSpec_2:
					// traverse syntax tree node associated with production
					// ConstraintSpec: GeneralConstraint

						m_GeneralConstraint.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SubtypeConstraint?.reparent (this);
			m_GeneralConstraint?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ConstraintSpec
		//

		public void _init ()
		{
			m_SubtypeConstraint = null;
			m_GeneralConstraint = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ConstraintSpec

		// counter of all nodes associated with syntax rule ConstraintSpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ConstraintSpec
		[DataMember (Name = "m_SubtypeConstraint")] public SubtypeConstraint m_SubtypeConstraint { get; private set; }
		[DataMember (Name = "m_GeneralConstraint")] public GeneralConstraint m_GeneralConstraint { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ConstraintSpec

		// delegate function (callback) prototype associated with syntax rule ConstraintSpec
		public delegate bool ConstraintSpec_Callback (SyntaxTreeCallbackReason reason, ConstraintSpec.production_kind kind, ConstraintSpec p_ConstraintSpec);

		// event associated with syntax rule ConstraintSpec
		public event ConstraintSpec_Callback ConstraintSpec_Event;

		// event trigger associated with syntax rule ConstraintSpec
		public bool Raise_ConstraintSpec_Event (SyntaxTreeCallbackReason reason, ConstraintSpec.production_kind kind, ConstraintSpec p_ConstraintSpec)
		{
			bool? status = ConstraintSpec_Event?.Invoke (reason, kind, p_ConstraintSpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ConstraintSpec
		//
		// traverse syntax tree node associated with any production of syntax rule ConstraintSpec
		//

		public void Traverse (ConstraintSpec p_ConstraintSpec)
		{
			if (p_ConstraintSpec.isLocked())
				return;
			p_ConstraintSpec.dolock();
			ConstraintSpec.production_kind kind = (ConstraintSpec.production_kind) p_ConstraintSpec.kind;
			p_ConstraintSpec.turn_reset ();
			if (Raise_ConstraintSpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ConstraintSpec))
			switch (kind)
			{
				case ConstraintSpec.production_kind.g_ConstraintSpec_1:
					// traverse syntax tree node associated with production
					// ConstraintSpec: SubtypeConstraint

					if (Raise_ConstraintSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ConstraintSpec))
						Traverse (p_ConstraintSpec.m_SubtypeConstraint);
					p_ConstraintSpec.turn_inc ();
					Raise_ConstraintSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ConstraintSpec);
				break;
				case ConstraintSpec.production_kind.g_ConstraintSpec_2:
					// traverse syntax tree node associated with production
					// ConstraintSpec: GeneralConstraint

					if (Raise_ConstraintSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ConstraintSpec))
						Traverse (p_ConstraintSpec.m_GeneralConstraint);
					p_ConstraintSpec.turn_inc ();
					Raise_ConstraintSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ConstraintSpec);
				break;
			}
			Raise_ConstraintSpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ConstraintSpec);
			p_ConstraintSpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ConstraintSpec
		//

		public void TraverseCommon (ConstraintSpec p_ConstraintSpec)
		{
			ConstraintSpec.production_kind kind = (ConstraintSpec.production_kind) p_ConstraintSpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ConstraintSpec))
			switch (kind)
			{
				case ConstraintSpec.production_kind.g_ConstraintSpec_1:
					// traverse syntax tree node associated with production
					// ConstraintSpec: SubtypeConstraint

						TraverseCommon (p_ConstraintSpec.m_SubtypeConstraint);
				break;
				case ConstraintSpec.production_kind.g_ConstraintSpec_2:
					// traverse syntax tree node associated with production
					// ConstraintSpec: GeneralConstraint

						TraverseCommon (p_ConstraintSpec.m_GeneralConstraint);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ConstraintSpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ConstraintSpec

		//
		// create syntax tree node associated with production
		// ConstraintSpec: SubtypeConstraint

		//

		public ConstraintSpec ConstraintSpec_1 (SubtypeConstraint p_SubtypeConstraint)
		{
			ConstraintSpec p_ConstraintSpec_ref = new ConstraintSpec(p_SubtypeConstraint);
			p_SubtypeConstraint.parent = p_ConstraintSpec_ref;
			Raise_ConstraintSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ConstraintSpec.production_kind.g_ConstraintSpec_1, p_ConstraintSpec_ref);
			return p_ConstraintSpec_ref;
		}

		//
		// create syntax tree node associated with production
		// ConstraintSpec: GeneralConstraint

		//

		public ConstraintSpec ConstraintSpec_2 (GeneralConstraint p_GeneralConstraint)
		{
			ConstraintSpec p_ConstraintSpec_ref = new ConstraintSpec(p_GeneralConstraint);
			p_GeneralConstraint.parent = p_ConstraintSpec_ref;
			Raise_ConstraintSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ConstraintSpec.production_kind.g_ConstraintSpec_2, p_ConstraintSpec_ref);
			return p_ConstraintSpec_ref;
		}
		#endregion
	};
}
