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
	// class associated with syntax rule SetType
	//

	[DataContract]
	public class	SetType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SetType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SetType
		{
			g_SetType_1 = 1,	// SET "{" ComponentTypeLists-optional "}"

		};
		#endregion
		#region production markers associated with the syntax rule SetType

		// markers associated with production: SetType -> SET "{" ComponentTypeLists-optional "}"

		public enum production_marker_1 : ushort
		{
			m_ComponentTypeLists_optional,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SetType

		// Constructor declaration(s) associated with production(s) of syntax rule SetType

		//
		// Constructor associated with the following production(s)
		// SetType -> SET "{" ComponentTypeLists-optional "}"

		//

		public SetType (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, ComponentTypeLists_optional p_ComponentTypeLists_optional, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._SetType_ID, (uint) production_kind.g_SetType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_SET = p_token;
			children[1] = m_left_curly_bracket = p_token_1;
			children[2] = m_ComponentTypeLists_optional = p_ComponentTypeLists_optional;
			children[3] = m_right_curly_bracket = p_token_2;
		}

		public SetType () { }

		// Copy constructor

		public SetType (SetType p_SetType) : base (p_SetType.id, p_SetType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SetType.appInfo;
			switch ((production_kind) p_SetType.kind)
			{
				case production_kind.g_SetType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_SET = (p_SetType.m_SET != null) ? new SyntaxTreeToken (p_SetType.m_SET) : null) != null) m_SET.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_SetType.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_SetType.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_ComponentTypeLists_optional = (p_SetType.m_ComponentTypeLists_optional != null) ? new ComponentTypeLists_optional (p_SetType.m_ComponentTypeLists_optional) : null) != null) m_ComponentTypeLists_optional.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_SetType.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_SetType.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SetType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SetType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SET?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_ComponentTypeLists_optional?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SetType

		// Content changing function(s) associated with production(s) of syntax rule SetType

		//
		// Content changing function associated with following production(s)
		// SetType -> SET "{" ComponentTypeLists-optional "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, ComponentTypeLists_optional p_ComponentTypeLists_optional, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_SetType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_SET = p_token;
			children [1] = m_left_curly_bracket = p_token_1;
			children [2] = m_ComponentTypeLists_optional = p_ComponentTypeLists_optional;
			children [3] = m_right_curly_bracket = p_token_2;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SetType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SET != null) && m_SET.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_ComponentTypeLists_optional != null) && m_ComponentTypeLists_optional.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SetType

		//
		// emit production tree node associated with any production of syntax rule SetType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SetType_1:
					// emit syntax tree node associated with production
					// SetType: SET "{" ComponentTypeLists-optional "}"

					s += m_SET.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_ComponentTypeLists_optional.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SetType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SetType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SetType_1:
					// emit syntax tree node associated with production
					// SetType: SET "{" ComponentTypeLists-optional "}"

					s += "SET";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_ComponentTypeLists_optional.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SetType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SetType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SetType.production_kind kind = (SetType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SetType.production_kind.g_SetType_1:
					// traverse syntax tree node associated with production
					// SetType: SET "{" ComponentTypeLists-optional "}"

						m_SET.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_ComponentTypeLists_optional.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SET?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_ComponentTypeLists_optional?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SetType
		//

		public void _init ()
		{
			m_SET = null;
			m_left_curly_bracket = null;
			m_ComponentTypeLists_optional = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SetType

		// counter of all nodes associated with syntax rule SetType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SetType
		[DataMember (Name = "m_SET")] public SyntaxTreeToken m_SET { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_ComponentTypeLists_optional")] public ComponentTypeLists_optional m_ComponentTypeLists_optional { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SetType

		// delegate function (callback) prototype associated with syntax rule SetType
		public delegate bool SetType_Callback (SyntaxTreeCallbackReason reason, SetType.production_kind kind, SetType p_SetType);

		// event associated with syntax rule SetType
		public event SetType_Callback SetType_Event;

		// event trigger associated with syntax rule SetType
		public bool Raise_SetType_Event (SyntaxTreeCallbackReason reason, SetType.production_kind kind, SetType p_SetType)
		{
			bool? status = SetType_Event?.Invoke (reason, kind, p_SetType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SetType
		//
		// traverse syntax tree node associated with any production of syntax rule SetType
		//

		public void Traverse (SetType p_SetType)
		{
			if (p_SetType.isLocked())
				return;
			p_SetType.dolock();
			SetType.production_kind kind = (SetType.production_kind) p_SetType.kind;
			p_SetType.turn_reset ();
			if (Raise_SetType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SetType))
			switch (kind)
			{
				case SetType.production_kind.g_SetType_1:
					// traverse syntax tree node associated with production
					// SetType: SET "{" ComponentTypeLists-optional "}"

					if (Raise_SetType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SetType))
						Traverse (p_SetType.m_ComponentTypeLists_optional);
					p_SetType.turn_inc ();
					Raise_SetType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SetType);
				break;
			}
			Raise_SetType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SetType);
			p_SetType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SetType
		//

		public void TraverseCommon (SetType p_SetType)
		{
			SetType.production_kind kind = (SetType.production_kind) p_SetType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SetType))
			switch (kind)
			{
				case SetType.production_kind.g_SetType_1:
					// traverse syntax tree node associated with production
					// SetType: SET "{" ComponentTypeLists-optional "}"

						TraverseCommon (p_SetType.m_SET);
						TraverseCommon (p_SetType.m_left_curly_bracket);
						TraverseCommon (p_SetType.m_ComponentTypeLists_optional);
						TraverseCommon (p_SetType.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SetType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SetType

		//
		// create syntax tree node associated with production
		// SetType: SET "{" ComponentTypeLists-optional "}"

		//

		public SetType SetType_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, ComponentTypeLists_optional p_ComponentTypeLists_optional, SyntaxTreeToken p_token_2)
		{
			SetType p_SetType_ref = new SetType(p_token, p_token_1, p_ComponentTypeLists_optional, p_token_2);
			p_token.parent = p_SetType_ref;
			p_token_1.parent = p_SetType_ref;
			p_ComponentTypeLists_optional.parent = p_SetType_ref;
			p_token_2.parent = p_SetType_ref;
			Raise_SetType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SetType.production_kind.g_SetType_1, p_SetType_ref);
			return p_SetType_ref;
		}
		#endregion
	};
}
