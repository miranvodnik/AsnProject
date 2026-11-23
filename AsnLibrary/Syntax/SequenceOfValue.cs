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
	// class associated with syntax rule SequenceOfValue
	//

	[DataContract]
	public class	SequenceOfValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SequenceOfValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SequenceOfValue
		{
			g_SequenceOfValue_1 = 1,	// "{" ValueList "}"

			g_SequenceOfValue_2 = 2,	// "{" NamedValueList "}"

			g_SequenceOfValue_3 = 3,	// "{" "}"

		};
		#endregion
		#region production markers associated with the syntax rule SequenceOfValue

		// markers associated with production: SequenceOfValue -> "{" ValueList "}"

		public enum production_marker_1 : ushort
		{
			m_ValueList,
			final
		};

		// markers associated with production: SequenceOfValue -> "{" NamedValueList "}"

		public enum production_marker_2 : ushort
		{
			m_NamedValueList,
			final
		};

		// markers associated with production: SequenceOfValue -> "{" "}"

		public enum production_marker_3 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SequenceOfValue

		// Constructor declaration(s) associated with production(s) of syntax rule SequenceOfValue

		//
		// Constructor associated with the following production(s)
		// SequenceOfValue -> "{" ValueList "}"

		//

		public SequenceOfValue (SyntaxTreeToken p_token, ValueList p_ValueList, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._SequenceOfValue_ID, (uint) production_kind.g_SequenceOfValue_1)
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
		// SequenceOfValue -> "{" NamedValueList "}"

		//

		public SequenceOfValue (SyntaxTreeToken p_token, NamedValueList p_NamedValueList, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._SequenceOfValue_ID, (uint) production_kind.g_SequenceOfValue_2)
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
		// SequenceOfValue -> "{" "}"

		//

		public SequenceOfValue (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._SequenceOfValue_ID, (uint) production_kind.g_SequenceOfValue_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_right_curly_bracket = p_token_1;
		}

		public SequenceOfValue () { }

		// Copy constructor

		public SequenceOfValue (SequenceOfValue p_SequenceOfValue) : base (p_SequenceOfValue.id, p_SequenceOfValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SequenceOfValue.appInfo;
			switch ((production_kind) p_SequenceOfValue.kind)
			{
				case production_kind.g_SequenceOfValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_SequenceOfValue.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_SequenceOfValue.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_ValueList = (p_SequenceOfValue.m_ValueList != null) ? new ValueList (p_SequenceOfValue.m_ValueList) : null) != null) m_ValueList.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_SequenceOfValue.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_SequenceOfValue.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				case production_kind.g_SequenceOfValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_SequenceOfValue.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_SequenceOfValue.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_NamedValueList = (p_SequenceOfValue.m_NamedValueList != null) ? new NamedValueList (p_SequenceOfValue.m_NamedValueList) : null) != null) m_NamedValueList.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_SequenceOfValue.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_SequenceOfValue.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				case production_kind.g_SequenceOfValue_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_left_curly_bracket = (p_SequenceOfValue.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_SequenceOfValue.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_right_curly_bracket = (p_SequenceOfValue.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_SequenceOfValue.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SequenceOfValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SequenceOfValue (this); }

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
		#region Content changing and inclusion checking methods associated with the syntax rule SequenceOfValue

		// Content changing function(s) associated with production(s) of syntax rule SequenceOfValue

		//
		// Content changing function associated with following production(s)
		// SequenceOfValue -> "{" ValueList "}"

		//

		public void change(SyntaxTreeToken p_token, ValueList p_ValueList, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_SequenceOfValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_ValueList = p_ValueList;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SequenceOfValue -> "{" NamedValueList "}"

		//

		public void change(SyntaxTreeToken p_token, NamedValueList p_NamedValueList, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_SequenceOfValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_NamedValueList = p_NamedValueList;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SequenceOfValue -> "{" "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_SequenceOfValue_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SequenceOfValue
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
		#region Syntax tree emit methods associated with the syntax rule SequenceOfValue

		//
		// emit production tree node associated with any production of syntax rule SequenceOfValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SequenceOfValue_1:
					// emit syntax tree node associated with production
					// SequenceOfValue: "{" ValueList "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_ValueList.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
				case production_kind.g_SequenceOfValue_2:
					// emit syntax tree node associated with production
					// SequenceOfValue: "{" NamedValueList "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_NamedValueList.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
				case production_kind.g_SequenceOfValue_3:
					// emit syntax tree node associated with production
					// SequenceOfValue: "{" "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SequenceOfValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SequenceOfValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SequenceOfValue_1:
					// emit syntax tree node associated with production
					// SequenceOfValue: "{" ValueList "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_ValueList.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
				case production_kind.g_SequenceOfValue_2:
					// emit syntax tree node associated with production
					// SequenceOfValue: "{" NamedValueList "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_NamedValueList.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
				case production_kind.g_SequenceOfValue_3:
					// emit syntax tree node associated with production
					// SequenceOfValue: "{" "}"

					s += "left_curly_bracket";
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SequenceOfValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SequenceOfValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SequenceOfValue.production_kind kind = (SequenceOfValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SequenceOfValue.production_kind.g_SequenceOfValue_1:
					// traverse syntax tree node associated with production
					// SequenceOfValue: "{" ValueList "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_ValueList.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
				case SequenceOfValue.production_kind.g_SequenceOfValue_2:
					// traverse syntax tree node associated with production
					// SequenceOfValue: "{" NamedValueList "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_NamedValueList.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
				case SequenceOfValue.production_kind.g_SequenceOfValue_3:
					// traverse syntax tree node associated with production
					// SequenceOfValue: "{" "}"

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
		// initialize object associated with syntax rule SequenceOfValue
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_ValueList = null;
			m_right_curly_bracket = null;
			m_NamedValueList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SequenceOfValue

		// counter of all nodes associated with syntax rule SequenceOfValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SequenceOfValue
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_ValueList")] public ValueList m_ValueList { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		[DataMember (Name = "m_NamedValueList")] public NamedValueList m_NamedValueList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SequenceOfValue

		// delegate function (callback) prototype associated with syntax rule SequenceOfValue
		public delegate bool SequenceOfValue_Callback (SyntaxTreeCallbackReason reason, SequenceOfValue.production_kind kind, SequenceOfValue p_SequenceOfValue);

		// event associated with syntax rule SequenceOfValue
		public event SequenceOfValue_Callback SequenceOfValue_Event;

		// event trigger associated with syntax rule SequenceOfValue
		public bool Raise_SequenceOfValue_Event (SyntaxTreeCallbackReason reason, SequenceOfValue.production_kind kind, SequenceOfValue p_SequenceOfValue)
		{
			bool? status = SequenceOfValue_Event?.Invoke (reason, kind, p_SequenceOfValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SequenceOfValue
		//
		// traverse syntax tree node associated with any production of syntax rule SequenceOfValue
		//

		public void Traverse (SequenceOfValue p_SequenceOfValue)
		{
			if (p_SequenceOfValue.isLocked())
				return;
			p_SequenceOfValue.dolock();
			SequenceOfValue.production_kind kind = (SequenceOfValue.production_kind) p_SequenceOfValue.kind;
			p_SequenceOfValue.turn_reset ();
			if (Raise_SequenceOfValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SequenceOfValue))
			switch (kind)
			{
				case SequenceOfValue.production_kind.g_SequenceOfValue_1:
					// traverse syntax tree node associated with production
					// SequenceOfValue: "{" ValueList "}"

					if (Raise_SequenceOfValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SequenceOfValue))
						Traverse (p_SequenceOfValue.m_ValueList);
					p_SequenceOfValue.turn_inc ();
					Raise_SequenceOfValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SequenceOfValue);
				break;
				case SequenceOfValue.production_kind.g_SequenceOfValue_2:
					// traverse syntax tree node associated with production
					// SequenceOfValue: "{" NamedValueList "}"

					if (Raise_SequenceOfValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SequenceOfValue))
						Traverse (p_SequenceOfValue.m_NamedValueList);
					p_SequenceOfValue.turn_inc ();
					Raise_SequenceOfValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SequenceOfValue);
				break;
				case SequenceOfValue.production_kind.g_SequenceOfValue_3:
					// traverse syntax tree node associated with production
					// SequenceOfValue: "{" "}"

				break;
			}
			Raise_SequenceOfValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SequenceOfValue);
			p_SequenceOfValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SequenceOfValue
		//

		public void TraverseCommon (SequenceOfValue p_SequenceOfValue)
		{
			SequenceOfValue.production_kind kind = (SequenceOfValue.production_kind) p_SequenceOfValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SequenceOfValue))
			switch (kind)
			{
				case SequenceOfValue.production_kind.g_SequenceOfValue_1:
					// traverse syntax tree node associated with production
					// SequenceOfValue: "{" ValueList "}"

						TraverseCommon (p_SequenceOfValue.m_left_curly_bracket);
						TraverseCommon (p_SequenceOfValue.m_ValueList);
						TraverseCommon (p_SequenceOfValue.m_right_curly_bracket);
				break;
				case SequenceOfValue.production_kind.g_SequenceOfValue_2:
					// traverse syntax tree node associated with production
					// SequenceOfValue: "{" NamedValueList "}"

						TraverseCommon (p_SequenceOfValue.m_left_curly_bracket);
						TraverseCommon (p_SequenceOfValue.m_NamedValueList);
						TraverseCommon (p_SequenceOfValue.m_right_curly_bracket);
				break;
				case SequenceOfValue.production_kind.g_SequenceOfValue_3:
					// traverse syntax tree node associated with production
					// SequenceOfValue: "{" "}"

						TraverseCommon (p_SequenceOfValue.m_left_curly_bracket);
						TraverseCommon (p_SequenceOfValue.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SequenceOfValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SequenceOfValue

		//
		// create syntax tree node associated with production
		// SequenceOfValue: "{" ValueList "}"

		//

		public SequenceOfValue SequenceOfValue_1 (SyntaxTreeToken p_token, ValueList p_ValueList, SyntaxTreeToken p_token_1)
		{
			SequenceOfValue p_SequenceOfValue_ref = new SequenceOfValue(p_token, p_ValueList, p_token_1);
			p_token.parent = p_SequenceOfValue_ref;
			p_ValueList.parent = p_SequenceOfValue_ref;
			p_token_1.parent = p_SequenceOfValue_ref;
			Raise_SequenceOfValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SequenceOfValue.production_kind.g_SequenceOfValue_1, p_SequenceOfValue_ref);
			return p_SequenceOfValue_ref;
		}

		//
		// create syntax tree node associated with production
		// SequenceOfValue: "{" NamedValueList "}"

		//

		public SequenceOfValue SequenceOfValue_2 (SyntaxTreeToken p_token, NamedValueList p_NamedValueList, SyntaxTreeToken p_token_1)
		{
			SequenceOfValue p_SequenceOfValue_ref = new SequenceOfValue(p_token, p_NamedValueList, p_token_1);
			p_token.parent = p_SequenceOfValue_ref;
			p_NamedValueList.parent = p_SequenceOfValue_ref;
			p_token_1.parent = p_SequenceOfValue_ref;
			Raise_SequenceOfValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SequenceOfValue.production_kind.g_SequenceOfValue_2, p_SequenceOfValue_ref);
			return p_SequenceOfValue_ref;
		}

		//
		// create syntax tree node associated with production
		// SequenceOfValue: "{" "}"

		//

		public SequenceOfValue SequenceOfValue_3 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			SequenceOfValue p_SequenceOfValue_ref = new SequenceOfValue(p_token, p_token_1);
			p_token.parent = p_SequenceOfValue_ref;
			p_token_1.parent = p_SequenceOfValue_ref;
			Raise_SequenceOfValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SequenceOfValue.production_kind.g_SequenceOfValue_3, p_SequenceOfValue_ref);
			return p_SequenceOfValue_ref;
		}
		#endregion
	};
}
