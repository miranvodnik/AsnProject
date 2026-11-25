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
	// class associated with syntax rule SetOfValue
	//

	[DataContract]
	public class	SetOfValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SetOfValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SetOfValue
		{
			g_SetOfValue_1 = 1,	// "{" ValueList "}"

			g_SetOfValue_2 = 2,	// "{" NamedValueList "}"

			g_SetOfValue_3 = 3,	// "{" "}"

		};
		#endregion
		#region production markers associated with the syntax rule SetOfValue

		// markers associated with production: SetOfValue -> "{" ValueList "}"

		public enum production_marker_1 : ushort
		{
			m_ValueList,
			final
		};

		// markers associated with production: SetOfValue -> "{" NamedValueList "}"

		public enum production_marker_2 : ushort
		{
			m_NamedValueList,
			final
		};

		// markers associated with production: SetOfValue -> "{" "}"

		public enum production_marker_3 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SetOfValue

		// Constructor declaration(s) associated with production(s) of syntax rule SetOfValue

		//
		// Constructor associated with the following production(s)
		// SetOfValue -> "{" ValueList "}"

		//

		public SetOfValue (SyntaxTreeToken p_token, ValueList p_ValueList, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._SetOfValue_ID, (uint) production_kind.g_SetOfValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_ValueList = p_ValueList;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		//
		// Constructor associated with the following production(s)
		// SetOfValue -> "{" NamedValueList "}"

		//

		public SetOfValue (SyntaxTreeToken p_token, NamedValueList p_NamedValueList, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._SetOfValue_ID, (uint) production_kind.g_SetOfValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_NamedValueList = p_NamedValueList;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		//
		// Constructor associated with the following production(s)
		// SetOfValue -> "{" "}"

		//

		public SetOfValue (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._SetOfValue_ID, (uint) production_kind.g_SetOfValue_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_right_curly_bracket = p_token_1;
		}

		public SetOfValue () { }

		// Copy constructor

		public SetOfValue (SetOfValue p_SetOfValue) : base (p_SetOfValue.id, p_SetOfValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SetOfValue.appInfo;
			switch ((production_kind) p_SetOfValue.kind)
			{
				case production_kind.g_SetOfValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_SetOfValue.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_SetOfValue.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_ValueList = (p_SetOfValue.m_ValueList != null) ? new ValueList (p_SetOfValue.m_ValueList) : null) != null) m_ValueList.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_SetOfValue.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_SetOfValue.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				case production_kind.g_SetOfValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_SetOfValue.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_SetOfValue.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_NamedValueList = (p_SetOfValue.m_NamedValueList != null) ? new NamedValueList (p_SetOfValue.m_NamedValueList) : null) != null) m_NamedValueList.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_SetOfValue.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_SetOfValue.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				case production_kind.g_SetOfValue_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_left_curly_bracket = (p_SetOfValue.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_SetOfValue.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_right_curly_bracket = (p_SetOfValue.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_SetOfValue.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SetOfValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SetOfValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_curly_bracket?.Dispose ();
			m_ValueList?.Dispose ();
			m_right_curly_bracket?.Dispose ();
			m_NamedValueList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SetOfValue

		// Content changing function(s) associated with production(s) of syntax rule SetOfValue

		//
		// Content changing function associated with following production(s)
		// SetOfValue -> "{" ValueList "}"

		//

		public void change(SyntaxTreeToken p_token, ValueList p_ValueList, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_SetOfValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_ValueList = p_ValueList;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SetOfValue -> "{" NamedValueList "}"

		//

		public void change(SyntaxTreeToken p_token, NamedValueList p_NamedValueList, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_SetOfValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_NamedValueList = p_NamedValueList;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SetOfValue -> "{" "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_SetOfValue_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SetOfValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_ValueList != null) && m_ValueList.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				(m_NamedValueList != null) && m_NamedValueList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SetOfValue

		//
		// emit production tree node associated with any production of syntax rule SetOfValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SetOfValue_1:
					// emit syntax tree node associated with production
					// SetOfValue: "{" ValueList "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_ValueList.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
				case production_kind.g_SetOfValue_2:
					// emit syntax tree node associated with production
					// SetOfValue: "{" NamedValueList "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_NamedValueList.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
				case production_kind.g_SetOfValue_3:
					// emit syntax tree node associated with production
					// SetOfValue: "{" "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SetOfValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SetOfValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SetOfValue_1:
					// emit syntax tree node associated with production
					// SetOfValue: "{" ValueList "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_ValueList.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
				case production_kind.g_SetOfValue_2:
					// emit syntax tree node associated with production
					// SetOfValue: "{" NamedValueList "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_NamedValueList.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
				case production_kind.g_SetOfValue_3:
					// emit syntax tree node associated with production
					// SetOfValue: "{" "}"

					s += "left_curly_bracket";
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SetOfValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SetOfValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SetOfValue.production_kind kind = (SetOfValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SetOfValue.production_kind.g_SetOfValue_1:
					// traverse syntax tree node associated with production
					// SetOfValue: "{" ValueList "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_ValueList.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
				case SetOfValue.production_kind.g_SetOfValue_2:
					// traverse syntax tree node associated with production
					// SetOfValue: "{" NamedValueList "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_NamedValueList.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
				case SetOfValue.production_kind.g_SetOfValue_3:
					// traverse syntax tree node associated with production
					// SetOfValue: "{" "}"

						m_left_curly_bracket.Visit (visitor, appData);
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
			m_ValueList?.reparent (this);
			m_right_curly_bracket?.reparent (this);
			m_NamedValueList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SetOfValue
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_ValueList = null;
			m_right_curly_bracket = null;
			m_NamedValueList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SetOfValue

		// counter of all nodes associated with syntax rule SetOfValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SetOfValue
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_ValueList")] public ValueList m_ValueList { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		[DataMember (Name = "m_NamedValueList")] public NamedValueList m_NamedValueList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SetOfValue

		// delegate function (callback) prototype associated with syntax rule SetOfValue
		public delegate bool SetOfValue_Callback (SyntaxTreeCallbackReason reason, SetOfValue.production_kind kind, SetOfValue p_SetOfValue);

		// event associated with syntax rule SetOfValue
		public event SetOfValue_Callback SetOfValue_Event;

		// event trigger associated with syntax rule SetOfValue
		public bool Raise_SetOfValue_Event (SyntaxTreeCallbackReason reason, SetOfValue.production_kind kind, SetOfValue p_SetOfValue)
		{
			bool? status = SetOfValue_Event?.Invoke (reason, kind, p_SetOfValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SetOfValue
		//
		// traverse syntax tree node associated with any production of syntax rule SetOfValue
		//

		public void Traverse (SetOfValue p_SetOfValue)
		{
			if (p_SetOfValue.isLocked())
				return;
			p_SetOfValue.dolock();
			SetOfValue.production_kind kind = (SetOfValue.production_kind) p_SetOfValue.kind;
			p_SetOfValue.turn_reset ();
			if (Raise_SetOfValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SetOfValue))
			switch (kind)
			{
				case SetOfValue.production_kind.g_SetOfValue_1:
					// traverse syntax tree node associated with production
					// SetOfValue: "{" ValueList "}"

					if (Raise_SetOfValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SetOfValue))
						Traverse (p_SetOfValue.m_ValueList);
					p_SetOfValue.turn_inc ();
					Raise_SetOfValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SetOfValue);
				break;
				case SetOfValue.production_kind.g_SetOfValue_2:
					// traverse syntax tree node associated with production
					// SetOfValue: "{" NamedValueList "}"

					if (Raise_SetOfValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SetOfValue))
						Traverse (p_SetOfValue.m_NamedValueList);
					p_SetOfValue.turn_inc ();
					Raise_SetOfValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SetOfValue);
				break;
				case SetOfValue.production_kind.g_SetOfValue_3:
					// traverse syntax tree node associated with production
					// SetOfValue: "{" "}"

				break;
			}
			Raise_SetOfValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SetOfValue);
			p_SetOfValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SetOfValue
		//

		public void TraverseCommon (SetOfValue p_SetOfValue)
		{
			SetOfValue.production_kind kind = (SetOfValue.production_kind) p_SetOfValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SetOfValue))
			switch (kind)
			{
				case SetOfValue.production_kind.g_SetOfValue_1:
					// traverse syntax tree node associated with production
					// SetOfValue: "{" ValueList "}"

						TraverseCommon (p_SetOfValue.m_left_curly_bracket);
						TraverseCommon (p_SetOfValue.m_ValueList);
						TraverseCommon (p_SetOfValue.m_right_curly_bracket);
				break;
				case SetOfValue.production_kind.g_SetOfValue_2:
					// traverse syntax tree node associated with production
					// SetOfValue: "{" NamedValueList "}"

						TraverseCommon (p_SetOfValue.m_left_curly_bracket);
						TraverseCommon (p_SetOfValue.m_NamedValueList);
						TraverseCommon (p_SetOfValue.m_right_curly_bracket);
				break;
				case SetOfValue.production_kind.g_SetOfValue_3:
					// traverse syntax tree node associated with production
					// SetOfValue: "{" "}"

						TraverseCommon (p_SetOfValue.m_left_curly_bracket);
						TraverseCommon (p_SetOfValue.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SetOfValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SetOfValue

		//
		// create syntax tree node associated with production
		// SetOfValue: "{" ValueList "}"

		//

		public SetOfValue SetOfValue_1 (SyntaxTreeToken p_token, ValueList p_ValueList, SyntaxTreeToken p_token_1)
		{
			SetOfValue p_SetOfValue_ref = new SetOfValue(p_token, p_ValueList, p_token_1);
			p_token.parent = p_SetOfValue_ref;
			p_ValueList.parent = p_SetOfValue_ref;
			p_token_1.parent = p_SetOfValue_ref;
			Raise_SetOfValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SetOfValue.production_kind.g_SetOfValue_1, p_SetOfValue_ref);
			return p_SetOfValue_ref;
		}

		//
		// create syntax tree node associated with production
		// SetOfValue: "{" NamedValueList "}"

		//

		public SetOfValue SetOfValue_2 (SyntaxTreeToken p_token, NamedValueList p_NamedValueList, SyntaxTreeToken p_token_1)
		{
			SetOfValue p_SetOfValue_ref = new SetOfValue(p_token, p_NamedValueList, p_token_1);
			p_token.parent = p_SetOfValue_ref;
			p_NamedValueList.parent = p_SetOfValue_ref;
			p_token_1.parent = p_SetOfValue_ref;
			Raise_SetOfValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SetOfValue.production_kind.g_SetOfValue_2, p_SetOfValue_ref);
			return p_SetOfValue_ref;
		}

		//
		// create syntax tree node associated with production
		// SetOfValue: "{" "}"

		//

		public SetOfValue SetOfValue_3 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			SetOfValue p_SetOfValue_ref = new SetOfValue(p_token, p_token_1);
			p_token.parent = p_SetOfValue_ref;
			p_token_1.parent = p_SetOfValue_ref;
			Raise_SetOfValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SetOfValue.production_kind.g_SetOfValue_3, p_SetOfValue_ref);
			return p_SetOfValue_ref;
		}
		#endregion
	};
}
