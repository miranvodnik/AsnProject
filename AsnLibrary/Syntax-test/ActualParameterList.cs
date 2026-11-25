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
	// class associated with syntax rule ActualParameterList
	//

	[DataContract]
	public class	ActualParameterList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ActualParameterList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ActualParameterList
		{
			g_ActualParameterList_1 = 1,	// "{" ActualParameter-set "}"

		};
		#endregion
		#region production markers associated with the syntax rule ActualParameterList

		// markers associated with production: ActualParameterList -> "{" ActualParameter-set "}"

		public enum production_marker_1 : ushort
		{
			m_ActualParameter_set,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ActualParameterList

		// Constructor declaration(s) associated with production(s) of syntax rule ActualParameterList

		//
		// Constructor associated with the following production(s)
		// ActualParameterList -> "{" ActualParameter-set "}"

		//

		public ActualParameterList (SyntaxTreeToken p_token, ActualParameter_set p_ActualParameter_set, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._ActualParameterList_ID, (uint) production_kind.g_ActualParameterList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_ActualParameter_set = p_ActualParameter_set;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		public ActualParameterList () { }

		// Copy constructor

		public ActualParameterList (ActualParameterList p_ActualParameterList) : base (p_ActualParameterList.id, p_ActualParameterList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ActualParameterList.appInfo;
			switch ((production_kind) p_ActualParameterList.kind)
			{
				case production_kind.g_ActualParameterList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_ActualParameterList.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_ActualParameterList.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_ActualParameter_set = (p_ActualParameterList.m_ActualParameter_set != null) ? new ActualParameter_set (p_ActualParameterList.m_ActualParameter_set) : null) != null) m_ActualParameter_set.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_ActualParameterList.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_ActualParameterList.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ActualParameterList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ActualParameterList (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_curly_bracket?.Dispose ();
			m_ActualParameter_set?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ActualParameterList

		// Content changing function(s) associated with production(s) of syntax rule ActualParameterList

		//
		// Content changing function associated with following production(s)
		// ActualParameterList -> "{" ActualParameter-set "}"

		//

		public void change(SyntaxTreeToken p_token, ActualParameter_set p_ActualParameter_set, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_ActualParameterList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_ActualParameter_set = p_ActualParameter_set;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ActualParameterList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_ActualParameter_set != null) && m_ActualParameter_set.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ActualParameterList

		//
		// emit production tree node associated with any production of syntax rule ActualParameterList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ActualParameterList_1:
					// emit syntax tree node associated with production
					// ActualParameterList: "{" ActualParameter-set "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_ActualParameter_set.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ActualParameterList
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ActualParameterList (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ActualParameterList_1:
					// emit syntax tree node associated with production
					// ActualParameterList: "{" ActualParameter-set "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_ActualParameter_set.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ActualParameterList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ActualParameterList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ActualParameterList.production_kind kind = (ActualParameterList.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ActualParameterList.production_kind.g_ActualParameterList_1:
					// traverse syntax tree node associated with production
					// ActualParameterList: "{" ActualParameter-set "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_ActualParameter_set.Visit (visitor, appData);
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
			m_ActualParameter_set?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ActualParameterList
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_ActualParameter_set = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ActualParameterList

		// counter of all nodes associated with syntax rule ActualParameterList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ActualParameterList
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_ActualParameter_set")] public ActualParameter_set m_ActualParameter_set { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ActualParameterList

		// delegate function (callback) prototype associated with syntax rule ActualParameterList
		public delegate bool ActualParameterList_Callback (SyntaxTreeCallbackReason reason, ActualParameterList.production_kind kind, ActualParameterList p_ActualParameterList);

		// event associated with syntax rule ActualParameterList
		public event ActualParameterList_Callback ActualParameterList_Event;

		// event trigger associated with syntax rule ActualParameterList
		public bool Raise_ActualParameterList_Event (SyntaxTreeCallbackReason reason, ActualParameterList.production_kind kind, ActualParameterList p_ActualParameterList)
		{
			bool? status = ActualParameterList_Event?.Invoke (reason, kind, p_ActualParameterList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ActualParameterList
		//
		// traverse syntax tree node associated with any production of syntax rule ActualParameterList
		//

		public void Traverse (ActualParameterList p_ActualParameterList)
		{
			if (p_ActualParameterList.isLocked())
				return;
			p_ActualParameterList.dolock();
			ActualParameterList.production_kind kind = (ActualParameterList.production_kind) p_ActualParameterList.kind;
			p_ActualParameterList.turn_reset ();
			if (Raise_ActualParameterList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ActualParameterList))
			switch (kind)
			{
				case ActualParameterList.production_kind.g_ActualParameterList_1:
					// traverse syntax tree node associated with production
					// ActualParameterList: "{" ActualParameter-set "}"

					if (Raise_ActualParameterList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ActualParameterList))
						Traverse (p_ActualParameterList.m_ActualParameter_set);
					p_ActualParameterList.turn_inc ();
					Raise_ActualParameterList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ActualParameterList);
				break;
			}
			Raise_ActualParameterList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ActualParameterList);
			p_ActualParameterList.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ActualParameterList
		//

		public void TraverseCommon (ActualParameterList p_ActualParameterList)
		{
			ActualParameterList.production_kind kind = (ActualParameterList.production_kind) p_ActualParameterList.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ActualParameterList))
			switch (kind)
			{
				case ActualParameterList.production_kind.g_ActualParameterList_1:
					// traverse syntax tree node associated with production
					// ActualParameterList: "{" ActualParameter-set "}"

						TraverseCommon (p_ActualParameterList.m_left_curly_bracket);
						TraverseCommon (p_ActualParameterList.m_ActualParameter_set);
						TraverseCommon (p_ActualParameterList.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ActualParameterList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ActualParameterList

		//
		// create syntax tree node associated with production
		// ActualParameterList: "{" ActualParameter-set "}"

		//

		public ActualParameterList ActualParameterList_1 (SyntaxTreeToken p_token, ActualParameter_set p_ActualParameter_set, SyntaxTreeToken p_token_1)
		{
			ActualParameterList p_ActualParameterList_ref = new ActualParameterList(p_token, p_ActualParameter_set, p_token_1);
			p_token.parent = p_ActualParameterList_ref;
			p_ActualParameter_set.parent = p_ActualParameterList_ref;
			p_token_1.parent = p_ActualParameterList_ref;
			Raise_ActualParameterList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ActualParameterList.production_kind.g_ActualParameterList_1, p_ActualParameterList_ref);
			return p_ActualParameterList_ref;
		}
		#endregion
	};
}
