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
	// class associated with syntax rule SetValue
	//

	[DataContract]
	public class	SetValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SetValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SetValue
		{
			g_SetValue_1 = 1,	// "{" ComponentValueList-optional "}"

		};
		#endregion
		#region production markers associated with the syntax rule SetValue

		// markers associated with production: SetValue -> "{" ComponentValueList-optional "}"

		public enum production_marker_1 : ushort
		{
			m_ComponentValueList_optional,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SetValue

		// Constructor declaration(s) associated with production(s) of syntax rule SetValue

		//
		// Constructor associated with the following production(s)
		// SetValue -> "{" ComponentValueList-optional "}"

		//

		public SetValue (SyntaxTreeToken p_token, ComponentValueList_optional p_ComponentValueList_optional, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._SetValue_ID, (uint) production_kind.g_SetValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_ComponentValueList_optional = p_ComponentValueList_optional;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		public SetValue () { }

		// Copy constructor

		public SetValue (SetValue p_SetValue) : base (p_SetValue.id, p_SetValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SetValue.appInfo;
			switch ((production_kind) p_SetValue.kind)
			{
				case production_kind.g_SetValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_SetValue.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_SetValue.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_ComponentValueList_optional = (p_SetValue.m_ComponentValueList_optional != null) ? new ComponentValueList_optional (p_SetValue.m_ComponentValueList_optional) : null) != null) m_ComponentValueList_optional.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_SetValue.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_SetValue.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SetValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SetValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_curly_bracket?.Dispose ();
			m_ComponentValueList_optional?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SetValue

		// Content changing function(s) associated with production(s) of syntax rule SetValue

		//
		// Content changing function associated with following production(s)
		// SetValue -> "{" ComponentValueList-optional "}"

		//

		public void change(SyntaxTreeToken p_token, ComponentValueList_optional p_ComponentValueList_optional, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_SetValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_ComponentValueList_optional = p_ComponentValueList_optional;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SetValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_ComponentValueList_optional != null) && m_ComponentValueList_optional.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SetValue

		//
		// emit production tree node associated with any production of syntax rule SetValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SetValue_1:
					// emit syntax tree node associated with production
					// SetValue: "{" ComponentValueList-optional "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_ComponentValueList_optional.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SetValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SetValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SetValue_1:
					// emit syntax tree node associated with production
					// SetValue: "{" ComponentValueList-optional "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_ComponentValueList_optional.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SetValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SetValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SetValue.production_kind kind = (SetValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SetValue.production_kind.g_SetValue_1:
					// traverse syntax tree node associated with production
					// SetValue: "{" ComponentValueList-optional "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_ComponentValueList_optional.Visit (visitor, appData);
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
			m_ComponentValueList_optional?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SetValue
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_ComponentValueList_optional = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SetValue

		// counter of all nodes associated with syntax rule SetValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SetValue
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_ComponentValueList_optional")] public ComponentValueList_optional m_ComponentValueList_optional { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SetValue

		// delegate function (callback) prototype associated with syntax rule SetValue
		public delegate bool SetValue_Callback (SyntaxTreeCallbackReason reason, SetValue.production_kind kind, SetValue p_SetValue);

		// event associated with syntax rule SetValue
		public event SetValue_Callback SetValue_Event;

		// event trigger associated with syntax rule SetValue
		public bool Raise_SetValue_Event (SyntaxTreeCallbackReason reason, SetValue.production_kind kind, SetValue p_SetValue)
		{
			bool? status = SetValue_Event?.Invoke (reason, kind, p_SetValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SetValue
		//
		// traverse syntax tree node associated with any production of syntax rule SetValue
		//

		public void Traverse (SetValue p_SetValue)
		{
			if (p_SetValue.isLocked())
				return;
			p_SetValue.dolock();
			SetValue.production_kind kind = (SetValue.production_kind) p_SetValue.kind;
			p_SetValue.turn_reset ();
			if (Raise_SetValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SetValue))
			switch (kind)
			{
				case SetValue.production_kind.g_SetValue_1:
					// traverse syntax tree node associated with production
					// SetValue: "{" ComponentValueList-optional "}"

					if (Raise_SetValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SetValue))
						Traverse (p_SetValue.m_ComponentValueList_optional);
					p_SetValue.turn_inc ();
					Raise_SetValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SetValue);
				break;
			}
			Raise_SetValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SetValue);
			p_SetValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SetValue
		//

		public void TraverseCommon (SetValue p_SetValue)
		{
			SetValue.production_kind kind = (SetValue.production_kind) p_SetValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SetValue))
			switch (kind)
			{
				case SetValue.production_kind.g_SetValue_1:
					// traverse syntax tree node associated with production
					// SetValue: "{" ComponentValueList-optional "}"

						TraverseCommon (p_SetValue.m_left_curly_bracket);
						TraverseCommon (p_SetValue.m_ComponentValueList_optional);
						TraverseCommon (p_SetValue.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SetValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SetValue

		//
		// create syntax tree node associated with production
		// SetValue: "{" ComponentValueList-optional "}"

		//

		public SetValue SetValue_1 (SyntaxTreeToken p_token, ComponentValueList_optional p_ComponentValueList_optional, SyntaxTreeToken p_token_1)
		{
			SetValue p_SetValue_ref = new SetValue(p_token, p_ComponentValueList_optional, p_token_1);
			p_token.parent = p_SetValue_ref;
			p_ComponentValueList_optional.parent = p_SetValue_ref;
			p_token_1.parent = p_SetValue_ref;
			Raise_SetValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SetValue.production_kind.g_SetValue_1, p_SetValue_ref);
			return p_SetValue_ref;
		}
		#endregion
	};
}
