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
	// class associated with syntax rule SequenceValue
	//

	[DataContract]
	public class	SequenceValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SequenceValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SequenceValue
		{
			g_SequenceValue_1 = 1,	// "{" ComponentValueList-optional "}"

		};
		#endregion
		#region production markers associated with the syntax rule SequenceValue

		// markers associated with production: SequenceValue -> "{" ComponentValueList-optional "}"

		public enum production_marker_1 : ushort
		{
			m_ComponentValueList_optional,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SequenceValue

		// Constructor declaration(s) associated with production(s) of syntax rule SequenceValue

		//
		// Constructor associated with the following production(s)
		// SequenceValue -> "{" ComponentValueList-optional "}"

		//

		public SequenceValue (SyntaxTreeToken p_token, ComponentValueList_optional p_ComponentValueList_optional, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._SequenceValue_ID, (uint) production_kind.g_SequenceValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_ComponentValueList_optional = p_ComponentValueList_optional;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		public SequenceValue () { }

		// Copy constructor

		public SequenceValue (SequenceValue p_SequenceValue) : base (p_SequenceValue.id, p_SequenceValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SequenceValue.appInfo;
			switch ((production_kind) p_SequenceValue.kind)
			{
				case production_kind.g_SequenceValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_SequenceValue.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_SequenceValue.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_ComponentValueList_optional = (p_SequenceValue.m_ComponentValueList_optional != null) ? new ComponentValueList_optional (p_SequenceValue.m_ComponentValueList_optional) : null) != null) m_ComponentValueList_optional.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_SequenceValue.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_SequenceValue.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SequenceValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SequenceValue (this); }

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
		#region Content changing and inclusion checking methods associated with the syntax rule SequenceValue

		// Content changing function(s) associated with production(s) of syntax rule SequenceValue

		//
		// Content changing function associated with following production(s)
		// SequenceValue -> "{" ComponentValueList-optional "}"

		//

		public void change(SyntaxTreeToken p_token, ComponentValueList_optional p_ComponentValueList_optional, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_SequenceValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_ComponentValueList_optional = p_ComponentValueList_optional;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SequenceValue
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
		#region Syntax tree emit methods associated with the syntax rule SequenceValue

		//
		// emit production tree node associated with any production of syntax rule SequenceValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SequenceValue_1:
					// emit syntax tree node associated with production
					// SequenceValue: "{" ComponentValueList-optional "}"

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
		// emit production tree node associated with any production of syntax rule SequenceValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SequenceValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SequenceValue_1:
					// emit syntax tree node associated with production
					// SequenceValue: "{" ComponentValueList-optional "}"

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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SequenceValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SequenceValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SequenceValue.production_kind kind = (SequenceValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SequenceValue.production_kind.g_SequenceValue_1:
					// traverse syntax tree node associated with production
					// SequenceValue: "{" ComponentValueList-optional "}"

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
		// initialize object associated with syntax rule SequenceValue
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_ComponentValueList_optional = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SequenceValue

		// counter of all nodes associated with syntax rule SequenceValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SequenceValue
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_ComponentValueList_optional")] public ComponentValueList_optional m_ComponentValueList_optional { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SequenceValue

		// delegate function (callback) prototype associated with syntax rule SequenceValue
		public delegate bool SequenceValue_Callback (SyntaxTreeCallbackReason reason, SequenceValue.production_kind kind, SequenceValue p_SequenceValue);

		// event associated with syntax rule SequenceValue
		public event SequenceValue_Callback SequenceValue_Event;

		// event trigger associated with syntax rule SequenceValue
		public bool Raise_SequenceValue_Event (SyntaxTreeCallbackReason reason, SequenceValue.production_kind kind, SequenceValue p_SequenceValue)
		{
			bool? status = SequenceValue_Event?.Invoke (reason, kind, p_SequenceValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SequenceValue
		//
		// traverse syntax tree node associated with any production of syntax rule SequenceValue
		//

		public void Traverse (SequenceValue p_SequenceValue)
		{
			if (p_SequenceValue.isLocked())
				return;
			p_SequenceValue.dolock();
			SequenceValue.production_kind kind = (SequenceValue.production_kind) p_SequenceValue.kind;
			p_SequenceValue.turn_reset ();
			if (Raise_SequenceValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SequenceValue))
			switch (kind)
			{
				case SequenceValue.production_kind.g_SequenceValue_1:
					// traverse syntax tree node associated with production
					// SequenceValue: "{" ComponentValueList-optional "}"

					if (Raise_SequenceValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SequenceValue))
						Traverse (p_SequenceValue.m_ComponentValueList_optional);
					p_SequenceValue.turn_inc ();
					Raise_SequenceValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SequenceValue);
				break;
			}
			Raise_SequenceValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SequenceValue);
			p_SequenceValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SequenceValue
		//

		public void TraverseCommon (SequenceValue p_SequenceValue)
		{
			SequenceValue.production_kind kind = (SequenceValue.production_kind) p_SequenceValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SequenceValue))
			switch (kind)
			{
				case SequenceValue.production_kind.g_SequenceValue_1:
					// traverse syntax tree node associated with production
					// SequenceValue: "{" ComponentValueList-optional "}"

						TraverseCommon (p_SequenceValue.m_left_curly_bracket);
						TraverseCommon (p_SequenceValue.m_ComponentValueList_optional);
						TraverseCommon (p_SequenceValue.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SequenceValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SequenceValue

		//
		// create syntax tree node associated with production
		// SequenceValue: "{" ComponentValueList-optional "}"

		//

		public SequenceValue SequenceValue_1 (SyntaxTreeToken p_token, ComponentValueList_optional p_ComponentValueList_optional, SyntaxTreeToken p_token_1)
		{
			SequenceValue p_SequenceValue_ref = new SequenceValue(p_token, p_ComponentValueList_optional, p_token_1);
			p_token.parent = p_SequenceValue_ref;
			p_ComponentValueList_optional.parent = p_SequenceValue_ref;
			p_token_1.parent = p_SequenceValue_ref;
			Raise_SequenceValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SequenceValue.production_kind.g_SequenceValue_1, p_SequenceValue_ref);
			return p_SequenceValue_ref;
		}
		#endregion
	};
}
