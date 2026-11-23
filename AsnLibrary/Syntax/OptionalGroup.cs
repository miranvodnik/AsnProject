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
	// class associated with syntax rule OptionalGroup
	//

	[DataContract]
	public class	OptionalGroup : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OptionalGroup
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OptionalGroup
		{
			g_OptionalGroup_1 = 1,	// LiteralSet "[" TokenOrGroupSpecBase-set "]"

		};
		#endregion
		#region production markers associated with the syntax rule OptionalGroup

		// markers associated with production: OptionalGroup -> LiteralSet "[" TokenOrGroupSpecBase-set "]"

		public enum production_marker_1 : ushort
		{
			m_LiteralSet,
			m_TokenOrGroupSpecBase_set,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OptionalGroup

		// Constructor declaration(s) associated with production(s) of syntax rule OptionalGroup

		//
		// Constructor associated with the following production(s)
		// OptionalGroup -> LiteralSet "[" TokenOrGroupSpecBase-set "]"

		//

		public OptionalGroup (LiteralSet p_LiteralSet, SyntaxTreeToken p_token, TokenOrGroupSpecBase_set p_TokenOrGroupSpecBase_set, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._OptionalGroup_ID, (uint) production_kind.g_OptionalGroup_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_LiteralSet = p_LiteralSet;
			children[1] = m_left_square_bracket = p_token;
			children[2] = m_TokenOrGroupSpecBase_set = p_TokenOrGroupSpecBase_set;
			children[3] = m_right_square_bracket = p_token_1;
		}

		public OptionalGroup () { }

		// Copy constructor

		public OptionalGroup (OptionalGroup p_OptionalGroup) : base (p_OptionalGroup.id, p_OptionalGroup.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OptionalGroup.appInfo;
			switch ((production_kind) p_OptionalGroup.kind)
			{
				case production_kind.g_OptionalGroup_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_LiteralSet = (p_OptionalGroup.m_LiteralSet != null) ? new LiteralSet (p_OptionalGroup.m_LiteralSet) : null) != null) m_LiteralSet.parent = this;
					if ((children [1] = m_left_square_bracket = (p_OptionalGroup.m_left_square_bracket != null) ? new SyntaxTreeToken (p_OptionalGroup.m_left_square_bracket) : null) != null) m_left_square_bracket.parent = this;
					if ((children [2] = m_TokenOrGroupSpecBase_set = (p_OptionalGroup.m_TokenOrGroupSpecBase_set != null) ? new TokenOrGroupSpecBase_set (p_OptionalGroup.m_TokenOrGroupSpecBase_set) : null) != null) m_TokenOrGroupSpecBase_set.parent = this;
					if ((children [3] = m_right_square_bracket = (p_OptionalGroup.m_right_square_bracket != null) ? new SyntaxTreeToken (p_OptionalGroup.m_right_square_bracket) : null) != null) m_right_square_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "OptionalGroup" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OptionalGroup (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_LiteralSet?.Dispose ();
			m_left_square_bracket?.Dispose ();
			m_TokenOrGroupSpecBase_set?.Dispose ();
			m_right_square_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OptionalGroup

		// Content changing function(s) associated with production(s) of syntax rule OptionalGroup

		//
		// Content changing function associated with following production(s)
		// OptionalGroup -> LiteralSet "[" TokenOrGroupSpecBase-set "]"

		//

		public void change(LiteralSet p_LiteralSet, SyntaxTreeToken p_token, TokenOrGroupSpecBase_set p_TokenOrGroupSpecBase_set, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_OptionalGroup_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_LiteralSet = p_LiteralSet;
			children [1] = m_left_square_bracket = p_token;
			children [2] = m_TokenOrGroupSpecBase_set = p_TokenOrGroupSpecBase_set;
			children [3] = m_right_square_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OptionalGroup
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_LiteralSet != null) && m_LiteralSet.checkInclusion (element) ||
				(m_left_square_bracket != null) && m_left_square_bracket.checkInclusion (element) ||
				(m_TokenOrGroupSpecBase_set != null) && m_TokenOrGroupSpecBase_set.checkInclusion (element) ||
				(m_right_square_bracket != null) && m_right_square_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OptionalGroup

		//
		// emit production tree node associated with any production of syntax rule OptionalGroup
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_OptionalGroup_1:
					// emit syntax tree node associated with production
					// OptionalGroup: LiteralSet "[" TokenOrGroupSpecBase-set "]"

					s += m_LiteralSet.Emit (depth - 1);
					s += " ";
					s += m_left_square_bracket.Emit (depth - 1);
					s += " ";
					s += m_TokenOrGroupSpecBase_set.Emit (depth - 1);
					s += " ";
					s += m_right_square_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OptionalGroup
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "OptionalGroup (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_OptionalGroup_1:
					// emit syntax tree node associated with production
					// OptionalGroup: LiteralSet "[" TokenOrGroupSpecBase-set "]"

					s += m_LiteralSet.EmitProductionTree (depth - 1);
					s += ' ';
					s += "left_square_bracket";
					s += ' ';
					s += m_TokenOrGroupSpecBase_set.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_square_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OptionalGroup

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OptionalGroup with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			OptionalGroup.production_kind kind = (OptionalGroup.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case OptionalGroup.production_kind.g_OptionalGroup_1:
					// traverse syntax tree node associated with production
					// OptionalGroup: LiteralSet "[" TokenOrGroupSpecBase-set "]"

						m_LiteralSet.Visit (visitor, appData);
						m_left_square_bracket.Visit (visitor, appData);
						m_TokenOrGroupSpecBase_set.Visit (visitor, appData);
						m_right_square_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_LiteralSet?.reparent (this);
			m_left_square_bracket?.reparent (this);
			m_TokenOrGroupSpecBase_set?.reparent (this);
			m_right_square_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule OptionalGroup
		//

		public void _init ()
		{
			m_LiteralSet = null;
			m_left_square_bracket = null;
			m_TokenOrGroupSpecBase_set = null;
			m_right_square_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OptionalGroup

		// counter of all nodes associated with syntax rule OptionalGroup
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OptionalGroup
		[DataMember (Name = "m_LiteralSet")] public LiteralSet m_LiteralSet { get; private set; }
		[DataMember (Name = "m_left_square_bracket")] public SyntaxTreeToken m_left_square_bracket { get; private set; }
		[DataMember (Name = "m_TokenOrGroupSpecBase_set")] public TokenOrGroupSpecBase_set m_TokenOrGroupSpecBase_set { get; private set; }
		[DataMember (Name = "m_right_square_bracket")] public SyntaxTreeToken m_right_square_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OptionalGroup

		// delegate function (callback) prototype associated with syntax rule OptionalGroup
		public delegate bool OptionalGroup_Callback (SyntaxTreeCallbackReason reason, OptionalGroup.production_kind kind, OptionalGroup p_OptionalGroup);

		// event associated with syntax rule OptionalGroup
		public event OptionalGroup_Callback OptionalGroup_Event;

		// event trigger associated with syntax rule OptionalGroup
		public bool Raise_OptionalGroup_Event (SyntaxTreeCallbackReason reason, OptionalGroup.production_kind kind, OptionalGroup p_OptionalGroup)
		{
			bool? status = OptionalGroup_Event?.Invoke (reason, kind, p_OptionalGroup);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OptionalGroup
		//
		// traverse syntax tree node associated with any production of syntax rule OptionalGroup
		//

		public void Traverse (OptionalGroup p_OptionalGroup)
		{
			if (p_OptionalGroup.isLocked())
				return;
			p_OptionalGroup.dolock();
			OptionalGroup.production_kind kind = (OptionalGroup.production_kind) p_OptionalGroup.kind;
			p_OptionalGroup.turn_reset ();
			if (Raise_OptionalGroup_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_OptionalGroup))
			switch (kind)
			{
				case OptionalGroup.production_kind.g_OptionalGroup_1:
					// traverse syntax tree node associated with production
					// OptionalGroup: LiteralSet "[" TokenOrGroupSpecBase-set "]"

					if (Raise_OptionalGroup_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OptionalGroup))
						Traverse (p_OptionalGroup.m_LiteralSet);
					p_OptionalGroup.turn_inc ();
					if (Raise_OptionalGroup_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OptionalGroup))
						Traverse (p_OptionalGroup.m_TokenOrGroupSpecBase_set);
					p_OptionalGroup.turn_inc ();
					Raise_OptionalGroup_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OptionalGroup);
				break;
			}
			Raise_OptionalGroup_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_OptionalGroup);
			p_OptionalGroup.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OptionalGroup
		//

		public void TraverseCommon (OptionalGroup p_OptionalGroup)
		{
			OptionalGroup.production_kind kind = (OptionalGroup.production_kind) p_OptionalGroup.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_OptionalGroup))
			switch (kind)
			{
				case OptionalGroup.production_kind.g_OptionalGroup_1:
					// traverse syntax tree node associated with production
					// OptionalGroup: LiteralSet "[" TokenOrGroupSpecBase-set "]"

						TraverseCommon (p_OptionalGroup.m_LiteralSet);
						TraverseCommon (p_OptionalGroup.m_left_square_bracket);
						TraverseCommon (p_OptionalGroup.m_TokenOrGroupSpecBase_set);
						TraverseCommon (p_OptionalGroup.m_right_square_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_OptionalGroup);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OptionalGroup

		//
		// create syntax tree node associated with production
		// OptionalGroup: LiteralSet "[" TokenOrGroupSpecBase-set "]"

		//

		public OptionalGroup OptionalGroup_1 (LiteralSet p_LiteralSet, SyntaxTreeToken p_token, TokenOrGroupSpecBase_set p_TokenOrGroupSpecBase_set, SyntaxTreeToken p_token_1)
		{
			OptionalGroup p_OptionalGroup_ref = new OptionalGroup(p_LiteralSet, p_token, p_TokenOrGroupSpecBase_set, p_token_1);
			p_LiteralSet.parent = p_OptionalGroup_ref;
			p_token.parent = p_OptionalGroup_ref;
			p_TokenOrGroupSpecBase_set.parent = p_OptionalGroup_ref;
			p_token_1.parent = p_OptionalGroup_ref;
			Raise_OptionalGroup_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OptionalGroup.production_kind.g_OptionalGroup_1, p_OptionalGroup_ref);
			return p_OptionalGroup_ref;
		}
		#endregion
	};
}
