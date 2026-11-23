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
	// class associated with syntax rule ComponentRelationConstraint
	//

	[DataContract]
	public class	ComponentRelationConstraint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ComponentRelationConstraint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ComponentRelationConstraint
		{
			g_ComponentRelationConstraint_1 = 1,	// "{" DefinedObjectSet "}" "{" AtNotation-set "}"

		};
		#endregion
		#region production markers associated with the syntax rule ComponentRelationConstraint

		// markers associated with production: ComponentRelationConstraint -> "{" DefinedObjectSet "}" "{" AtNotation-set "}"

		public enum production_marker_1 : ushort
		{
			m_DefinedObjectSet,
			m_AtNotation_set,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ComponentRelationConstraint

		// Constructor declaration(s) associated with production(s) of syntax rule ComponentRelationConstraint

		//
		// Constructor associated with the following production(s)
		// ComponentRelationConstraint -> "{" DefinedObjectSet "}" "{" AtNotation-set "}"

		//

		public ComponentRelationConstraint (SyntaxTreeToken p_token, DefinedObjectSet p_DefinedObjectSet, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, AtNotation_set p_AtNotation_set, SyntaxTreeToken p_token_3) : base ((uint) ProductionID._ComponentRelationConstraint_ID, (uint) production_kind.g_ComponentRelationConstraint_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 6);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_DefinedObjectSet = p_DefinedObjectSet;
			children[2] = m_right_curly_bracket = p_token_1;
			children[3] = m_left_curly_bracket_1 = p_token_2;
			children[4] = m_AtNotation_set = p_AtNotation_set;
			children[5] = m_right_curly_bracket_1 = p_token_3;
		}

		public ComponentRelationConstraint () { }

		// Copy constructor

		public ComponentRelationConstraint (ComponentRelationConstraint p_ComponentRelationConstraint) : base (p_ComponentRelationConstraint.id, p_ComponentRelationConstraint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ComponentRelationConstraint.appInfo;
			switch ((production_kind) p_ComponentRelationConstraint.kind)
			{
				case production_kind.g_ComponentRelationConstraint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 6);
					if ((children [0] = m_left_curly_bracket = (p_ComponentRelationConstraint.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_ComponentRelationConstraint.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_DefinedObjectSet = (p_ComponentRelationConstraint.m_DefinedObjectSet != null) ? new DefinedObjectSet (p_ComponentRelationConstraint.m_DefinedObjectSet) : null) != null) m_DefinedObjectSet.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_ComponentRelationConstraint.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_ComponentRelationConstraint.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					if ((children [3] = m_left_curly_bracket_1 = (p_ComponentRelationConstraint.m_left_curly_bracket_1 != null) ? new SyntaxTreeToken (p_ComponentRelationConstraint.m_left_curly_bracket_1) : null) != null) m_left_curly_bracket_1.parent = this;
					if ((children [4] = m_AtNotation_set = (p_ComponentRelationConstraint.m_AtNotation_set != null) ? new AtNotation_set (p_ComponentRelationConstraint.m_AtNotation_set) : null) != null) m_AtNotation_set.parent = this;
					if ((children [5] = m_right_curly_bracket_1 = (p_ComponentRelationConstraint.m_right_curly_bracket_1 != null) ? new SyntaxTreeToken (p_ComponentRelationConstraint.m_right_curly_bracket_1) : null) != null) m_right_curly_bracket_1.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ComponentRelationConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ComponentRelationConstraint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_curly_bracket?.Dispose ();
			m_left_curly_bracket_1?.Dispose ();
			m_DefinedObjectSet?.Dispose ();
			m_right_curly_bracket?.Dispose ();
			m_right_curly_bracket_1?.Dispose ();
			m_AtNotation_set?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ComponentRelationConstraint

		// Content changing function(s) associated with production(s) of syntax rule ComponentRelationConstraint

		//
		// Content changing function associated with following production(s)
		// ComponentRelationConstraint -> "{" DefinedObjectSet "}" "{" AtNotation-set "}"

		//

		public void change(SyntaxTreeToken p_token, DefinedObjectSet p_DefinedObjectSet, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, AtNotation_set p_AtNotation_set, SyntaxTreeToken p_token_3)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentRelationConstraint_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 6);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_DefinedObjectSet = p_DefinedObjectSet;
			children [2] = m_right_curly_bracket = p_token_1;
			children [3] = m_left_curly_bracket_1 = p_token_2;
			children [4] = m_AtNotation_set = p_AtNotation_set;
			children [5] = m_right_curly_bracket_1 = p_token_3;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ComponentRelationConstraint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_left_curly_bracket_1 != null) && m_left_curly_bracket_1.checkInclusion (element) ||
				(m_DefinedObjectSet != null) && m_DefinedObjectSet.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				(m_right_curly_bracket_1 != null) && m_right_curly_bracket_1.checkInclusion (element) ||
				(m_AtNotation_set != null) && m_AtNotation_set.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ComponentRelationConstraint

		//
		// emit production tree node associated with any production of syntax rule ComponentRelationConstraint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ComponentRelationConstraint_1:
					// emit syntax tree node associated with production
					// ComponentRelationConstraint: "{" DefinedObjectSet "}" "{" AtNotation-set "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_DefinedObjectSet.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket_1.Emit (depth - 1);
					s += " ";
					s += m_AtNotation_set.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket_1.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ComponentRelationConstraint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ComponentRelationConstraint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ComponentRelationConstraint_1:
					// emit syntax tree node associated with production
					// ComponentRelationConstraint: "{" DefinedObjectSet "}" "{" AtNotation-set "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_DefinedObjectSet.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_AtNotation_set.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ComponentRelationConstraint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ComponentRelationConstraint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ComponentRelationConstraint.production_kind kind = (ComponentRelationConstraint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ComponentRelationConstraint.production_kind.g_ComponentRelationConstraint_1:
					// traverse syntax tree node associated with production
					// ComponentRelationConstraint: "{" DefinedObjectSet "}" "{" AtNotation-set "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_DefinedObjectSet.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
						m_left_curly_bracket_1.Visit (visitor, appData);
						m_AtNotation_set.Visit (visitor, appData);
						m_right_curly_bracket_1.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_left_curly_bracket?.reparent (this);
			m_left_curly_bracket_1?.reparent (this);

			m_DefinedObjectSet?.reparent (this);
			m_right_curly_bracket?.reparent (this);
			m_right_curly_bracket_1?.reparent (this);

			m_AtNotation_set?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ComponentRelationConstraint
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_left_curly_bracket_1 = null;
			m_DefinedObjectSet = null;
			m_right_curly_bracket = null;
			m_right_curly_bracket_1 = null;
			m_AtNotation_set = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ComponentRelationConstraint

		// counter of all nodes associated with syntax rule ComponentRelationConstraint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ComponentRelationConstraint
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_left_curly_bracket_1")] public SyntaxTreeToken m_left_curly_bracket_1 { get; private set; }
		[DataMember (Name = "m_DefinedObjectSet")] public DefinedObjectSet m_DefinedObjectSet { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		[DataMember (Name = "m_right_curly_bracket_1")] public SyntaxTreeToken m_right_curly_bracket_1 { get; private set; }
		[DataMember (Name = "m_AtNotation_set")] public AtNotation_set m_AtNotation_set { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ComponentRelationConstraint

		// delegate function (callback) prototype associated with syntax rule ComponentRelationConstraint
		public delegate bool ComponentRelationConstraint_Callback (SyntaxTreeCallbackReason reason, ComponentRelationConstraint.production_kind kind, ComponentRelationConstraint p_ComponentRelationConstraint);

		// event associated with syntax rule ComponentRelationConstraint
		public event ComponentRelationConstraint_Callback ComponentRelationConstraint_Event;

		// event trigger associated with syntax rule ComponentRelationConstraint
		public bool Raise_ComponentRelationConstraint_Event (SyntaxTreeCallbackReason reason, ComponentRelationConstraint.production_kind kind, ComponentRelationConstraint p_ComponentRelationConstraint)
		{
			bool? status = ComponentRelationConstraint_Event?.Invoke (reason, kind, p_ComponentRelationConstraint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ComponentRelationConstraint
		//
		// traverse syntax tree node associated with any production of syntax rule ComponentRelationConstraint
		//

		public void Traverse (ComponentRelationConstraint p_ComponentRelationConstraint)
		{
			if (p_ComponentRelationConstraint.isLocked())
				return;
			p_ComponentRelationConstraint.dolock();
			ComponentRelationConstraint.production_kind kind = (ComponentRelationConstraint.production_kind) p_ComponentRelationConstraint.kind;
			p_ComponentRelationConstraint.turn_reset ();
			if (Raise_ComponentRelationConstraint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ComponentRelationConstraint))
			switch (kind)
			{
				case ComponentRelationConstraint.production_kind.g_ComponentRelationConstraint_1:
					// traverse syntax tree node associated with production
					// ComponentRelationConstraint: "{" DefinedObjectSet "}" "{" AtNotation-set "}"

					if (Raise_ComponentRelationConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentRelationConstraint))
						Traverse (p_ComponentRelationConstraint.m_DefinedObjectSet);
					p_ComponentRelationConstraint.turn_inc ();
					if (Raise_ComponentRelationConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentRelationConstraint))
						Traverse (p_ComponentRelationConstraint.m_AtNotation_set);
					p_ComponentRelationConstraint.turn_inc ();
					Raise_ComponentRelationConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentRelationConstraint);
				break;
			}
			Raise_ComponentRelationConstraint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ComponentRelationConstraint);
			p_ComponentRelationConstraint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ComponentRelationConstraint
		//

		public void TraverseCommon (ComponentRelationConstraint p_ComponentRelationConstraint)
		{
			ComponentRelationConstraint.production_kind kind = (ComponentRelationConstraint.production_kind) p_ComponentRelationConstraint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ComponentRelationConstraint))
			switch (kind)
			{
				case ComponentRelationConstraint.production_kind.g_ComponentRelationConstraint_1:
					// traverse syntax tree node associated with production
					// ComponentRelationConstraint: "{" DefinedObjectSet "}" "{" AtNotation-set "}"

						TraverseCommon (p_ComponentRelationConstraint.m_left_curly_bracket);
						TraverseCommon (p_ComponentRelationConstraint.m_DefinedObjectSet);
						TraverseCommon (p_ComponentRelationConstraint.m_right_curly_bracket);
						TraverseCommon (p_ComponentRelationConstraint.m_left_curly_bracket_1);
						TraverseCommon (p_ComponentRelationConstraint.m_AtNotation_set);
						TraverseCommon (p_ComponentRelationConstraint.m_right_curly_bracket_1);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ComponentRelationConstraint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ComponentRelationConstraint

		//
		// create syntax tree node associated with production
		// ComponentRelationConstraint: "{" DefinedObjectSet "}" "{" AtNotation-set "}"

		//

		public ComponentRelationConstraint ComponentRelationConstraint_1 (SyntaxTreeToken p_token, DefinedObjectSet p_DefinedObjectSet, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, AtNotation_set p_AtNotation_set, SyntaxTreeToken p_token_3)
		{
			ComponentRelationConstraint p_ComponentRelationConstraint_ref = new ComponentRelationConstraint(p_token, p_DefinedObjectSet, p_token_1, p_token_2, p_AtNotation_set, p_token_3);
			p_token.parent = p_ComponentRelationConstraint_ref;
			p_DefinedObjectSet.parent = p_ComponentRelationConstraint_ref;
			p_token_1.parent = p_ComponentRelationConstraint_ref;
			p_token_2.parent = p_ComponentRelationConstraint_ref;
			p_AtNotation_set.parent = p_ComponentRelationConstraint_ref;
			p_token_3.parent = p_ComponentRelationConstraint_ref;
			Raise_ComponentRelationConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentRelationConstraint.production_kind.g_ComponentRelationConstraint_1, p_ComponentRelationConstraint_ref);
			return p_ComponentRelationConstraint_ref;
		}
		#endregion
	};
}
