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
	// class associated with syntax rule SyntaxList
	//

	[DataContract]
	public class	SyntaxList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SyntaxList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SyntaxList
		{
			g_SyntaxList_1 = 1,	// "{" TokenOrGroupSpecBase-set "}"

		};
		#endregion
		#region production markers associated with the syntax rule SyntaxList

		// markers associated with production: SyntaxList -> "{" TokenOrGroupSpecBase-set "}"

		public enum production_marker_1 : ushort
		{
			m_TokenOrGroupSpecBase_set,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SyntaxList

		// Constructor declaration(s) associated with production(s) of syntax rule SyntaxList

		//
		// Constructor associated with the following production(s)
		// SyntaxList -> "{" TokenOrGroupSpecBase-set "}"

		//

		public SyntaxList (SyntaxTreeToken p_token, TokenOrGroupSpecBase_set p_TokenOrGroupSpecBase_set, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._SyntaxList_ID, (uint) production_kind.g_SyntaxList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_TokenOrGroupSpecBase_set = p_TokenOrGroupSpecBase_set;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		public SyntaxList () { }

		// Copy constructor

		public SyntaxList (SyntaxList p_SyntaxList) : base (p_SyntaxList.id, p_SyntaxList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SyntaxList.appInfo;
			switch ((production_kind) p_SyntaxList.kind)
			{
				case production_kind.g_SyntaxList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_SyntaxList.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_SyntaxList.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_TokenOrGroupSpecBase_set = (p_SyntaxList.m_TokenOrGroupSpecBase_set != null) ? new TokenOrGroupSpecBase_set (p_SyntaxList.m_TokenOrGroupSpecBase_set) : null) != null) m_TokenOrGroupSpecBase_set.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_SyntaxList.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_SyntaxList.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SyntaxList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SyntaxList (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_curly_bracket?.Dispose ();
			m_TokenOrGroupSpecBase_set?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SyntaxList

		// Content changing function(s) associated with production(s) of syntax rule SyntaxList

		//
		// Content changing function associated with following production(s)
		// SyntaxList -> "{" TokenOrGroupSpecBase-set "}"

		//

		public void change(SyntaxTreeToken p_token, TokenOrGroupSpecBase_set p_TokenOrGroupSpecBase_set, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_SyntaxList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_TokenOrGroupSpecBase_set = p_TokenOrGroupSpecBase_set;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SyntaxList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_TokenOrGroupSpecBase_set != null) && m_TokenOrGroupSpecBase_set.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SyntaxList

		//
		// emit production tree node associated with any production of syntax rule SyntaxList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SyntaxList_1:
					// emit syntax tree node associated with production
					// SyntaxList: "{" TokenOrGroupSpecBase-set "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_TokenOrGroupSpecBase_set.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SyntaxList
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SyntaxList (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SyntaxList_1:
					// emit syntax tree node associated with production
					// SyntaxList: "{" TokenOrGroupSpecBase-set "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_TokenOrGroupSpecBase_set.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SyntaxList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SyntaxList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SyntaxList.production_kind kind = (SyntaxList.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SyntaxList.production_kind.g_SyntaxList_1:
					// traverse syntax tree node associated with production
					// SyntaxList: "{" TokenOrGroupSpecBase-set "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_TokenOrGroupSpecBase_set.Visit (visitor, appData);
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
			m_TokenOrGroupSpecBase_set?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SyntaxList
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_TokenOrGroupSpecBase_set = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SyntaxList

		// counter of all nodes associated with syntax rule SyntaxList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SyntaxList
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_TokenOrGroupSpecBase_set")] public TokenOrGroupSpecBase_set m_TokenOrGroupSpecBase_set { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SyntaxList

		// delegate function (callback) prototype associated with syntax rule SyntaxList
		public delegate bool SyntaxList_Callback (SyntaxTreeCallbackReason reason, SyntaxList.production_kind kind, SyntaxList p_SyntaxList);

		// event associated with syntax rule SyntaxList
		public event SyntaxList_Callback SyntaxList_Event;

		// event trigger associated with syntax rule SyntaxList
		public bool Raise_SyntaxList_Event (SyntaxTreeCallbackReason reason, SyntaxList.production_kind kind, SyntaxList p_SyntaxList)
		{
			bool? status = SyntaxList_Event?.Invoke (reason, kind, p_SyntaxList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SyntaxList
		//
		// traverse syntax tree node associated with any production of syntax rule SyntaxList
		//

		public void Traverse (SyntaxList p_SyntaxList)
		{
			if (p_SyntaxList.isLocked())
				return;
			p_SyntaxList.dolock();
			SyntaxList.production_kind kind = (SyntaxList.production_kind) p_SyntaxList.kind;
			p_SyntaxList.turn_reset ();
			if (Raise_SyntaxList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SyntaxList))
			switch (kind)
			{
				case SyntaxList.production_kind.g_SyntaxList_1:
					// traverse syntax tree node associated with production
					// SyntaxList: "{" TokenOrGroupSpecBase-set "}"

					if (Raise_SyntaxList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SyntaxList))
						Traverse (p_SyntaxList.m_TokenOrGroupSpecBase_set);
					p_SyntaxList.turn_inc ();
					Raise_SyntaxList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SyntaxList);
				break;
			}
			Raise_SyntaxList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SyntaxList);
			p_SyntaxList.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SyntaxList
		//

		public void TraverseCommon (SyntaxList p_SyntaxList)
		{
			SyntaxList.production_kind kind = (SyntaxList.production_kind) p_SyntaxList.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SyntaxList))
			switch (kind)
			{
				case SyntaxList.production_kind.g_SyntaxList_1:
					// traverse syntax tree node associated with production
					// SyntaxList: "{" TokenOrGroupSpecBase-set "}"

						TraverseCommon (p_SyntaxList.m_left_curly_bracket);
						TraverseCommon (p_SyntaxList.m_TokenOrGroupSpecBase_set);
						TraverseCommon (p_SyntaxList.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SyntaxList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SyntaxList

		//
		// create syntax tree node associated with production
		// SyntaxList: "{" TokenOrGroupSpecBase-set "}"

		//

		public SyntaxList SyntaxList_1 (SyntaxTreeToken p_token, TokenOrGroupSpecBase_set p_TokenOrGroupSpecBase_set, SyntaxTreeToken p_token_1)
		{
			SyntaxList p_SyntaxList_ref = new SyntaxList(p_token, p_TokenOrGroupSpecBase_set, p_token_1);
			p_token.parent = p_SyntaxList_ref;
			p_TokenOrGroupSpecBase_set.parent = p_SyntaxList_ref;
			p_token_1.parent = p_SyntaxList_ref;
			Raise_SyntaxList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SyntaxList.production_kind.g_SyntaxList_1, p_SyntaxList_ref);
			return p_SyntaxList_ref;
		}
		#endregion
	};
}
