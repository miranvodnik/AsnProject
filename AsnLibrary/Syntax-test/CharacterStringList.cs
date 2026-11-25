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
	// class associated with syntax rule CharacterStringList
	//

	[DataContract]
	public class	CharacterStringList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule CharacterStringList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule CharacterStringList
		{
			g_CharacterStringList_1 = 1,	// "{" CharSyms "}"

		};
		#endregion
		#region production markers associated with the syntax rule CharacterStringList

		// markers associated with production: CharacterStringList -> "{" CharSyms "}"

		public enum production_marker_1 : ushort
		{
			m_CharSyms,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule CharacterStringList

		// Constructor declaration(s) associated with production(s) of syntax rule CharacterStringList

		//
		// Constructor associated with the following production(s)
		// CharacterStringList -> "{" CharSyms "}"

		//

		public CharacterStringList (SyntaxTreeToken p_token, CharSyms p_CharSyms, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._CharacterStringList_ID, (uint) production_kind.g_CharacterStringList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_CharSyms = p_CharSyms;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		public CharacterStringList () { }

		// Copy constructor

		public CharacterStringList (CharacterStringList p_CharacterStringList) : base (p_CharacterStringList.id, p_CharacterStringList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_CharacterStringList.appInfo;
			switch ((production_kind) p_CharacterStringList.kind)
			{
				case production_kind.g_CharacterStringList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_CharacterStringList.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_CharacterStringList.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_CharSyms = (p_CharacterStringList.m_CharSyms != null) ? new CharSyms (p_CharacterStringList.m_CharSyms) : null) != null) m_CharSyms.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_CharacterStringList.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_CharacterStringList.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "CharacterStringList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new CharacterStringList (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_curly_bracket?.Dispose ();
			m_CharSyms?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule CharacterStringList

		// Content changing function(s) associated with production(s) of syntax rule CharacterStringList

		//
		// Content changing function associated with following production(s)
		// CharacterStringList -> "{" CharSyms "}"

		//

		public void change(SyntaxTreeToken p_token, CharSyms p_CharSyms, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_CharacterStringList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_CharSyms = p_CharSyms;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule CharacterStringList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_CharSyms != null) && m_CharSyms.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule CharacterStringList

		//
		// emit production tree node associated with any production of syntax rule CharacterStringList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_CharacterStringList_1:
					// emit syntax tree node associated with production
					// CharacterStringList: "{" CharSyms "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_CharSyms.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule CharacterStringList
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "CharacterStringList (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_CharacterStringList_1:
					// emit syntax tree node associated with production
					// CharacterStringList: "{" CharSyms "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_CharSyms.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule CharacterStringList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule CharacterStringList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			CharacterStringList.production_kind kind = (CharacterStringList.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case CharacterStringList.production_kind.g_CharacterStringList_1:
					// traverse syntax tree node associated with production
					// CharacterStringList: "{" CharSyms "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_CharSyms.Visit (visitor, appData);
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
			m_CharSyms?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule CharacterStringList
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_CharSyms = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule CharacterStringList

		// counter of all nodes associated with syntax rule CharacterStringList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule CharacterStringList
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_CharSyms")] public CharSyms m_CharSyms { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule CharacterStringList

		// delegate function (callback) prototype associated with syntax rule CharacterStringList
		public delegate bool CharacterStringList_Callback (SyntaxTreeCallbackReason reason, CharacterStringList.production_kind kind, CharacterStringList p_CharacterStringList);

		// event associated with syntax rule CharacterStringList
		public event CharacterStringList_Callback CharacterStringList_Event;

		// event trigger associated with syntax rule CharacterStringList
		public bool Raise_CharacterStringList_Event (SyntaxTreeCallbackReason reason, CharacterStringList.production_kind kind, CharacterStringList p_CharacterStringList)
		{
			bool? status = CharacterStringList_Event?.Invoke (reason, kind, p_CharacterStringList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule CharacterStringList
		//
		// traverse syntax tree node associated with any production of syntax rule CharacterStringList
		//

		public void Traverse (CharacterStringList p_CharacterStringList)
		{
			if (p_CharacterStringList.isLocked())
				return;
			p_CharacterStringList.dolock();
			CharacterStringList.production_kind kind = (CharacterStringList.production_kind) p_CharacterStringList.kind;
			p_CharacterStringList.turn_reset ();
			if (Raise_CharacterStringList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_CharacterStringList))
			switch (kind)
			{
				case CharacterStringList.production_kind.g_CharacterStringList_1:
					// traverse syntax tree node associated with production
					// CharacterStringList: "{" CharSyms "}"

					if (Raise_CharacterStringList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_CharacterStringList))
						Traverse (p_CharacterStringList.m_CharSyms);
					p_CharacterStringList.turn_inc ();
					Raise_CharacterStringList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_CharacterStringList);
				break;
			}
			Raise_CharacterStringList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_CharacterStringList);
			p_CharacterStringList.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule CharacterStringList
		//

		public void TraverseCommon (CharacterStringList p_CharacterStringList)
		{
			CharacterStringList.production_kind kind = (CharacterStringList.production_kind) p_CharacterStringList.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_CharacterStringList))
			switch (kind)
			{
				case CharacterStringList.production_kind.g_CharacterStringList_1:
					// traverse syntax tree node associated with production
					// CharacterStringList: "{" CharSyms "}"

						TraverseCommon (p_CharacterStringList.m_left_curly_bracket);
						TraverseCommon (p_CharacterStringList.m_CharSyms);
						TraverseCommon (p_CharacterStringList.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_CharacterStringList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule CharacterStringList

		//
		// create syntax tree node associated with production
		// CharacterStringList: "{" CharSyms "}"

		//

		public CharacterStringList CharacterStringList_1 (SyntaxTreeToken p_token, CharSyms p_CharSyms, SyntaxTreeToken p_token_1)
		{
			CharacterStringList p_CharacterStringList_ref = new CharacterStringList(p_token, p_CharSyms, p_token_1);
			p_token.parent = p_CharacterStringList_ref;
			p_CharSyms.parent = p_CharacterStringList_ref;
			p_token_1.parent = p_CharacterStringList_ref;
			Raise_CharacterStringList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, CharacterStringList.production_kind.g_CharacterStringList_1, p_CharacterStringList_ref);
			return p_CharacterStringList_ref;
		}
		#endregion
	};
}
