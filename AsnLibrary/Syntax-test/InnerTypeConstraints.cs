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
	// class associated with syntax rule InnerTypeConstraints
	//

	[DataContract]
	public class	InnerTypeConstraints : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule InnerTypeConstraints
		public enum production_kind : ushort	// enumerated production(s) of syntax rule InnerTypeConstraints
		{
			g_InnerTypeConstraints_1 = 1,	// WITH COMPONENT SingleTypeConstraint

			g_InnerTypeConstraints_2 = 2,	// WITH COMPONENTS MultipleTypeConstraints

		};
		#endregion
		#region production markers associated with the syntax rule InnerTypeConstraints

		// markers associated with production: InnerTypeConstraints -> WITH COMPONENT SingleTypeConstraint

		public enum production_marker_1 : ushort
		{
			m_SingleTypeConstraint,
			final
		};

		// markers associated with production: InnerTypeConstraints -> WITH COMPONENTS MultipleTypeConstraints

		public enum production_marker_2 : ushort
		{
			m_MultipleTypeConstraints,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule InnerTypeConstraints

		// Constructor declaration(s) associated with production(s) of syntax rule InnerTypeConstraints

		//
		// Constructor associated with the following production(s)
		// InnerTypeConstraints -> WITH COMPONENT SingleTypeConstraint

		//

		public InnerTypeConstraints (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SingleTypeConstraint p_SingleTypeConstraint) : base ((uint) ProductionID._InnerTypeConstraints_ID, (uint) production_kind.g_InnerTypeConstraints_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_WITH = p_token;
			children[1] = m_COMPONENT = p_token_1;
			children[2] = m_SingleTypeConstraint = p_SingleTypeConstraint;
		}

		//
		// Constructor associated with the following production(s)
		// InnerTypeConstraints -> WITH COMPONENTS MultipleTypeConstraints

		//

		public InnerTypeConstraints (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, MultipleTypeConstraints p_MultipleTypeConstraints) : base ((uint) ProductionID._InnerTypeConstraints_ID, (uint) production_kind.g_InnerTypeConstraints_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_WITH = p_token;
			children[1] = m_COMPONENTS = p_token_1;
			children[2] = m_MultipleTypeConstraints = p_MultipleTypeConstraints;
		}

		public InnerTypeConstraints () { }

		// Copy constructor

		public InnerTypeConstraints (InnerTypeConstraints p_InnerTypeConstraints) : base (p_InnerTypeConstraints.id, p_InnerTypeConstraints.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_InnerTypeConstraints.appInfo;
			switch ((production_kind) p_InnerTypeConstraints.kind)
			{
				case production_kind.g_InnerTypeConstraints_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_WITH = (p_InnerTypeConstraints.m_WITH != null) ? new SyntaxTreeToken (p_InnerTypeConstraints.m_WITH) : null) != null) m_WITH.parent = this;
					if ((children [1] = m_COMPONENT = (p_InnerTypeConstraints.m_COMPONENT != null) ? new SyntaxTreeToken (p_InnerTypeConstraints.m_COMPONENT) : null) != null) m_COMPONENT.parent = this;
					if ((children [2] = m_SingleTypeConstraint = (p_InnerTypeConstraints.m_SingleTypeConstraint != null) ? new SingleTypeConstraint (p_InnerTypeConstraints.m_SingleTypeConstraint) : null) != null) m_SingleTypeConstraint.parent = this;
					break;
				case production_kind.g_InnerTypeConstraints_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_WITH = (p_InnerTypeConstraints.m_WITH != null) ? new SyntaxTreeToken (p_InnerTypeConstraints.m_WITH) : null) != null) m_WITH.parent = this;
					if ((children [1] = m_COMPONENTS = (p_InnerTypeConstraints.m_COMPONENTS != null) ? new SyntaxTreeToken (p_InnerTypeConstraints.m_COMPONENTS) : null) != null) m_COMPONENTS.parent = this;
					if ((children [2] = m_MultipleTypeConstraints = (p_InnerTypeConstraints.m_MultipleTypeConstraints != null) ? new MultipleTypeConstraints (p_InnerTypeConstraints.m_MultipleTypeConstraints) : null) != null) m_MultipleTypeConstraints.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "InnerTypeConstraints" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new InnerTypeConstraints (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_WITH?.Dispose ();
			m_COMPONENT?.Dispose ();
			m_SingleTypeConstraint?.Dispose ();
			m_COMPONENTS?.Dispose ();
			m_MultipleTypeConstraints?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule InnerTypeConstraints

		// Content changing function(s) associated with production(s) of syntax rule InnerTypeConstraints

		//
		// Content changing function associated with following production(s)
		// InnerTypeConstraints -> WITH COMPONENT SingleTypeConstraint

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SingleTypeConstraint p_SingleTypeConstraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_InnerTypeConstraints_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_WITH = p_token;
			children [1] = m_COMPONENT = p_token_1;
			children [2] = m_SingleTypeConstraint = p_SingleTypeConstraint;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// InnerTypeConstraints -> WITH COMPONENTS MultipleTypeConstraints

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, MultipleTypeConstraints p_MultipleTypeConstraints)
		{
			_init ();
			this.kind = (uint) production_kind.g_InnerTypeConstraints_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_WITH = p_token;
			children [1] = m_COMPONENTS = p_token_1;
			children [2] = m_MultipleTypeConstraints = p_MultipleTypeConstraints;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule InnerTypeConstraints
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_WITH != null) && m_WITH.checkInclusion (element) ||
				(m_COMPONENT != null) && m_COMPONENT.checkInclusion (element) ||
				(m_SingleTypeConstraint != null) && m_SingleTypeConstraint.checkInclusion (element) ||
				(m_COMPONENTS != null) && m_COMPONENTS.checkInclusion (element) ||
				(m_MultipleTypeConstraints != null) && m_MultipleTypeConstraints.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule InnerTypeConstraints

		//
		// emit production tree node associated with any production of syntax rule InnerTypeConstraints
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_InnerTypeConstraints_1:
					// emit syntax tree node associated with production
					// InnerTypeConstraints: WITH COMPONENT SingleTypeConstraint

					s += m_WITH.Emit (depth - 1);
					s += " ";
					s += m_COMPONENT.Emit (depth - 1);
					s += " ";
					s += m_SingleTypeConstraint.Emit (depth - 1);
				break;
				case production_kind.g_InnerTypeConstraints_2:
					// emit syntax tree node associated with production
					// InnerTypeConstraints: WITH COMPONENTS MultipleTypeConstraints

					s += m_WITH.Emit (depth - 1);
					s += " ";
					s += m_COMPONENTS.Emit (depth - 1);
					s += " ";
					s += m_MultipleTypeConstraints.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule InnerTypeConstraints
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "InnerTypeConstraints (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_InnerTypeConstraints_1:
					// emit syntax tree node associated with production
					// InnerTypeConstraints: WITH COMPONENT SingleTypeConstraint

					s += "WITH";
					s += ' ';
					s += "COMPONENT";
					s += ' ';
					s += m_SingleTypeConstraint.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_InnerTypeConstraints_2:
					// emit syntax tree node associated with production
					// InnerTypeConstraints: WITH COMPONENTS MultipleTypeConstraints

					s += "WITH";
					s += ' ';
					s += "COMPONENTS";
					s += ' ';
					s += m_MultipleTypeConstraints.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule InnerTypeConstraints

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule InnerTypeConstraints with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			InnerTypeConstraints.production_kind kind = (InnerTypeConstraints.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case InnerTypeConstraints.production_kind.g_InnerTypeConstraints_1:
					// traverse syntax tree node associated with production
					// InnerTypeConstraints: WITH COMPONENT SingleTypeConstraint

						m_WITH.Visit (visitor, appData);
						m_COMPONENT.Visit (visitor, appData);
						m_SingleTypeConstraint.Visit (visitor, appData);
				break;
				case InnerTypeConstraints.production_kind.g_InnerTypeConstraints_2:
					// traverse syntax tree node associated with production
					// InnerTypeConstraints: WITH COMPONENTS MultipleTypeConstraints

						m_WITH.Visit (visitor, appData);
						m_COMPONENTS.Visit (visitor, appData);
						m_MultipleTypeConstraints.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_WITH?.reparent (this);
			m_COMPONENT?.reparent (this);
			m_SingleTypeConstraint?.reparent (this);
			m_COMPONENTS?.reparent (this);
			m_MultipleTypeConstraints?.reparent (this);
		}

		//
		// initialize object associated with syntax rule InnerTypeConstraints
		//

		public void _init ()
		{
			m_WITH = null;
			m_COMPONENT = null;
			m_SingleTypeConstraint = null;
			m_COMPONENTS = null;
			m_MultipleTypeConstraints = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule InnerTypeConstraints

		// counter of all nodes associated with syntax rule InnerTypeConstraints
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule InnerTypeConstraints
		[DataMember (Name = "m_WITH")] public SyntaxTreeToken m_WITH { get; private set; }
		[DataMember (Name = "m_COMPONENT")] public SyntaxTreeToken m_COMPONENT { get; private set; }
		[DataMember (Name = "m_SingleTypeConstraint")] public SingleTypeConstraint m_SingleTypeConstraint { get; private set; }
		[DataMember (Name = "m_COMPONENTS")] public SyntaxTreeToken m_COMPONENTS { get; private set; }
		[DataMember (Name = "m_MultipleTypeConstraints")] public MultipleTypeConstraints m_MultipleTypeConstraints { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule InnerTypeConstraints

		// delegate function (callback) prototype associated with syntax rule InnerTypeConstraints
		public delegate bool InnerTypeConstraints_Callback (SyntaxTreeCallbackReason reason, InnerTypeConstraints.production_kind kind, InnerTypeConstraints p_InnerTypeConstraints);

		// event associated with syntax rule InnerTypeConstraints
		public event InnerTypeConstraints_Callback InnerTypeConstraints_Event;

		// event trigger associated with syntax rule InnerTypeConstraints
		public bool Raise_InnerTypeConstraints_Event (SyntaxTreeCallbackReason reason, InnerTypeConstraints.production_kind kind, InnerTypeConstraints p_InnerTypeConstraints)
		{
			bool? status = InnerTypeConstraints_Event?.Invoke (reason, kind, p_InnerTypeConstraints);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule InnerTypeConstraints
		//
		// traverse syntax tree node associated with any production of syntax rule InnerTypeConstraints
		//

		public void Traverse (InnerTypeConstraints p_InnerTypeConstraints)
		{
			if (p_InnerTypeConstraints.isLocked())
				return;
			p_InnerTypeConstraints.dolock();
			InnerTypeConstraints.production_kind kind = (InnerTypeConstraints.production_kind) p_InnerTypeConstraints.kind;
			p_InnerTypeConstraints.turn_reset ();
			if (Raise_InnerTypeConstraints_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_InnerTypeConstraints))
			switch (kind)
			{
				case InnerTypeConstraints.production_kind.g_InnerTypeConstraints_1:
					// traverse syntax tree node associated with production
					// InnerTypeConstraints: WITH COMPONENT SingleTypeConstraint

					if (Raise_InnerTypeConstraints_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_InnerTypeConstraints))
						Traverse (p_InnerTypeConstraints.m_SingleTypeConstraint);
					p_InnerTypeConstraints.turn_inc ();
					Raise_InnerTypeConstraints_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_InnerTypeConstraints);
				break;
				case InnerTypeConstraints.production_kind.g_InnerTypeConstraints_2:
					// traverse syntax tree node associated with production
					// InnerTypeConstraints: WITH COMPONENTS MultipleTypeConstraints

					if (Raise_InnerTypeConstraints_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_InnerTypeConstraints))
						Traverse (p_InnerTypeConstraints.m_MultipleTypeConstraints);
					p_InnerTypeConstraints.turn_inc ();
					Raise_InnerTypeConstraints_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_InnerTypeConstraints);
				break;
			}
			Raise_InnerTypeConstraints_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_InnerTypeConstraints);
			p_InnerTypeConstraints.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule InnerTypeConstraints
		//

		public void TraverseCommon (InnerTypeConstraints p_InnerTypeConstraints)
		{
			InnerTypeConstraints.production_kind kind = (InnerTypeConstraints.production_kind) p_InnerTypeConstraints.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_InnerTypeConstraints))
			switch (kind)
			{
				case InnerTypeConstraints.production_kind.g_InnerTypeConstraints_1:
					// traverse syntax tree node associated with production
					// InnerTypeConstraints: WITH COMPONENT SingleTypeConstraint

						TraverseCommon (p_InnerTypeConstraints.m_WITH);
						TraverseCommon (p_InnerTypeConstraints.m_COMPONENT);
						TraverseCommon (p_InnerTypeConstraints.m_SingleTypeConstraint);
				break;
				case InnerTypeConstraints.production_kind.g_InnerTypeConstraints_2:
					// traverse syntax tree node associated with production
					// InnerTypeConstraints: WITH COMPONENTS MultipleTypeConstraints

						TraverseCommon (p_InnerTypeConstraints.m_WITH);
						TraverseCommon (p_InnerTypeConstraints.m_COMPONENTS);
						TraverseCommon (p_InnerTypeConstraints.m_MultipleTypeConstraints);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_InnerTypeConstraints);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule InnerTypeConstraints

		//
		// create syntax tree node associated with production
		// InnerTypeConstraints: WITH COMPONENT SingleTypeConstraint

		//

		public InnerTypeConstraints InnerTypeConstraints_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SingleTypeConstraint p_SingleTypeConstraint)
		{
			InnerTypeConstraints p_InnerTypeConstraints_ref = new InnerTypeConstraints(p_token, p_token_1, p_SingleTypeConstraint);
			p_token.parent = p_InnerTypeConstraints_ref;
			p_token_1.parent = p_InnerTypeConstraints_ref;
			p_SingleTypeConstraint.parent = p_InnerTypeConstraints_ref;
			Raise_InnerTypeConstraints_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, InnerTypeConstraints.production_kind.g_InnerTypeConstraints_1, p_InnerTypeConstraints_ref);
			return p_InnerTypeConstraints_ref;
		}

		//
		// create syntax tree node associated with production
		// InnerTypeConstraints: WITH COMPONENTS MultipleTypeConstraints

		//

		public InnerTypeConstraints InnerTypeConstraints_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, MultipleTypeConstraints p_MultipleTypeConstraints)
		{
			InnerTypeConstraints p_InnerTypeConstraints_ref = new InnerTypeConstraints(p_token, p_token_1, p_MultipleTypeConstraints);
			p_token.parent = p_InnerTypeConstraints_ref;
			p_token_1.parent = p_InnerTypeConstraints_ref;
			p_MultipleTypeConstraints.parent = p_InnerTypeConstraints_ref;
			Raise_InnerTypeConstraints_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, InnerTypeConstraints.production_kind.g_InnerTypeConstraints_2, p_InnerTypeConstraints_ref);
			return p_InnerTypeConstraints_ref;
		}
		#endregion
	};
}
