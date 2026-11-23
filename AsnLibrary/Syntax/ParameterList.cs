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
	// class associated with syntax rule ParameterList
	//

	[DataContract]
	public class	ParameterList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ParameterList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ParameterList
		{
			g_ParameterList_1 = 1,	// "{" Parameter-set "}"

		};
		#endregion
		#region production markers associated with the syntax rule ParameterList

		// markers associated with production: ParameterList -> "{" Parameter-set "}"

		public enum production_marker_1 : ushort
		{
			m_Parameter_set,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ParameterList

		// Constructor declaration(s) associated with production(s) of syntax rule ParameterList

		//
		// Constructor associated with the following production(s)
		// ParameterList -> "{" Parameter-set "}"

		//

		public ParameterList (SyntaxTreeToken p_token, Parameter_set p_Parameter_set, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._ParameterList_ID, (uint) production_kind.g_ParameterList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_Parameter_set = p_Parameter_set;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		public ParameterList () { }

		// Copy constructor

		public ParameterList (ParameterList p_ParameterList) : base (p_ParameterList.id, p_ParameterList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ParameterList.appInfo;
			switch ((production_kind) p_ParameterList.kind)
			{
				case production_kind.g_ParameterList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_ParameterList.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_ParameterList.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_Parameter_set = (p_ParameterList.m_Parameter_set != null) ? new Parameter_set (p_ParameterList.m_Parameter_set) : null) != null) m_Parameter_set.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_ParameterList.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_ParameterList.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ParameterList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ParameterList (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_curly_bracket?.Dispose ();
			m_Parameter_set?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ParameterList

		// Content changing function(s) associated with production(s) of syntax rule ParameterList

		//
		// Content changing function associated with following production(s)
		// ParameterList -> "{" Parameter-set "}"

		//

		public void change(SyntaxTreeToken p_token, Parameter_set p_Parameter_set, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_Parameter_set = p_Parameter_set;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ParameterList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_Parameter_set != null) && m_Parameter_set.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ParameterList

		//
		// emit production tree node associated with any production of syntax rule ParameterList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ParameterList_1:
					// emit syntax tree node associated with production
					// ParameterList: "{" Parameter-set "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_Parameter_set.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ParameterList
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ParameterList (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ParameterList_1:
					// emit syntax tree node associated with production
					// ParameterList: "{" Parameter-set "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_Parameter_set.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ParameterList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ParameterList.production_kind kind = (ParameterList.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ParameterList.production_kind.g_ParameterList_1:
					// traverse syntax tree node associated with production
					// ParameterList: "{" Parameter-set "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_Parameter_set.Visit (visitor, appData);
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
			m_Parameter_set?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ParameterList
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_Parameter_set = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ParameterList

		// counter of all nodes associated with syntax rule ParameterList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ParameterList
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_Parameter_set")] public Parameter_set m_Parameter_set { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ParameterList

		// delegate function (callback) prototype associated with syntax rule ParameterList
		public delegate bool ParameterList_Callback (SyntaxTreeCallbackReason reason, ParameterList.production_kind kind, ParameterList p_ParameterList);

		// event associated with syntax rule ParameterList
		public event ParameterList_Callback ParameterList_Event;

		// event trigger associated with syntax rule ParameterList
		public bool Raise_ParameterList_Event (SyntaxTreeCallbackReason reason, ParameterList.production_kind kind, ParameterList p_ParameterList)
		{
			bool? status = ParameterList_Event?.Invoke (reason, kind, p_ParameterList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ParameterList
		//
		// traverse syntax tree node associated with any production of syntax rule ParameterList
		//

		public void Traverse (ParameterList p_ParameterList)
		{
			if (p_ParameterList.isLocked())
				return;
			p_ParameterList.dolock();
			ParameterList.production_kind kind = (ParameterList.production_kind) p_ParameterList.kind;
			p_ParameterList.turn_reset ();
			if (Raise_ParameterList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ParameterList))
			switch (kind)
			{
				case ParameterList.production_kind.g_ParameterList_1:
					// traverse syntax tree node associated with production
					// ParameterList: "{" Parameter-set "}"

					if (Raise_ParameterList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterList))
						Traverse (p_ParameterList.m_Parameter_set);
					p_ParameterList.turn_inc ();
					Raise_ParameterList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterList);
				break;
			}
			Raise_ParameterList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ParameterList);
			p_ParameterList.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterList
		//

		public void TraverseCommon (ParameterList p_ParameterList)
		{
			ParameterList.production_kind kind = (ParameterList.production_kind) p_ParameterList.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ParameterList))
			switch (kind)
			{
				case ParameterList.production_kind.g_ParameterList_1:
					// traverse syntax tree node associated with production
					// ParameterList: "{" Parameter-set "}"

						TraverseCommon (p_ParameterList.m_left_curly_bracket);
						TraverseCommon (p_ParameterList.m_Parameter_set);
						TraverseCommon (p_ParameterList.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ParameterList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ParameterList

		//
		// create syntax tree node associated with production
		// ParameterList: "{" Parameter-set "}"

		//

		public ParameterList ParameterList_1 (SyntaxTreeToken p_token, Parameter_set p_Parameter_set, SyntaxTreeToken p_token_1)
		{
			ParameterList p_ParameterList_ref = new ParameterList(p_token, p_Parameter_set, p_token_1);
			p_token.parent = p_ParameterList_ref;
			p_Parameter_set.parent = p_ParameterList_ref;
			p_token_1.parent = p_ParameterList_ref;
			Raise_ParameterList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterList.production_kind.g_ParameterList_1, p_ParameterList_ref);
			return p_ParameterList_ref;
		}
		#endregion
	};
}
