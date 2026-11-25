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
	// class associated with syntax rule AC-Defvalue
	//

	[DataContract]
	public class	AC_Defvalue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-Defvalue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-Defvalue
		{
			g_AC_Defvalue_1 = 1,	// Value

			g_AC_Defvalue_2 = 2,	// "{" AC-BitsValue "}"

		};
		#endregion
		#region production markers associated with the syntax rule AC-Defvalue

		// markers associated with production: AC-Defvalue -> Value

		public enum production_marker_1 : ushort
		{
			m_Value,
			final
		};

		// markers associated with production: AC-Defvalue -> "{" AC-BitsValue "}"

		public enum production_marker_2 : ushort
		{
			m_AC_BitsValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-Defvalue

		// Constructor declaration(s) associated with production(s) of syntax rule AC-Defvalue

		//
		// Constructor associated with the following production(s)
		// AC-Defvalue -> Value

		//

		public AC_Defvalue (Value p_Value) : base ((uint) ProductionID._AC_Defvalue_ID, (uint) production_kind.g_AC_Defvalue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Value = p_Value;
		}

		//
		// Constructor associated with the following production(s)
		// AC-Defvalue -> "{" AC-BitsValue "}"

		//

		public AC_Defvalue (SyntaxTreeToken p_token, AC_BitsValue p_AC_BitsValue, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._AC_Defvalue_ID, (uint) production_kind.g_AC_Defvalue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_AC_BitsValue = p_AC_BitsValue;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		public AC_Defvalue () { }

		// Copy constructor

		public AC_Defvalue (AC_Defvalue p_AC_Defvalue) : base (p_AC_Defvalue.id, p_AC_Defvalue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_Defvalue.appInfo;
			switch ((production_kind) p_AC_Defvalue.kind)
			{
				case production_kind.g_AC_Defvalue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Value = (p_AC_Defvalue.m_Value != null) ? new Value (p_AC_Defvalue.m_Value) : null) != null) m_Value.parent = this;
					break;
				case production_kind.g_AC_Defvalue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_AC_Defvalue.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_AC_Defvalue.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_AC_BitsValue = (p_AC_Defvalue.m_AC_BitsValue != null) ? new AC_BitsValue (p_AC_Defvalue.m_AC_BitsValue) : null) != null) m_AC_BitsValue.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_AC_Defvalue.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_AC_Defvalue.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AC_Defvalue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_Defvalue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Value?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_AC_BitsValue?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-Defvalue

		// Content changing function(s) associated with production(s) of syntax rule AC-Defvalue

		//
		// Content changing function associated with following production(s)
		// AC-Defvalue -> Value

		//

		public void change(Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_Defvalue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AC-Defvalue -> "{" AC-BitsValue "}"

		//

		public void change(SyntaxTreeToken p_token, AC_BitsValue p_AC_BitsValue, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_Defvalue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_AC_BitsValue = p_AC_BitsValue;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-Defvalue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_AC_BitsValue != null) && m_AC_BitsValue.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-Defvalue

		//
		// emit production tree node associated with any production of syntax rule AC-Defvalue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_Defvalue_1:
					// emit syntax tree node associated with production
					// AC-Defvalue: Value

					s += m_Value.Emit (depth - 1);
				break;
				case production_kind.g_AC_Defvalue_2:
					// emit syntax tree node associated with production
					// AC-Defvalue: "{" AC-BitsValue "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_AC_BitsValue.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-Defvalue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_Defvalue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_Defvalue_1:
					// emit syntax tree node associated with production
					// AC-Defvalue: Value

					s += m_Value.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_AC_Defvalue_2:
					// emit syntax tree node associated with production
					// AC-Defvalue: "{" AC-BitsValue "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_AC_BitsValue.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-Defvalue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Defvalue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_Defvalue.production_kind kind = (AC_Defvalue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_Defvalue.production_kind.g_AC_Defvalue_1:
					// traverse syntax tree node associated with production
					// AC-Defvalue: Value

						m_Value.Visit (visitor, appData);
				break;
				case AC_Defvalue.production_kind.g_AC_Defvalue_2:
					// traverse syntax tree node associated with production
					// AC-Defvalue: "{" AC-BitsValue "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_AC_BitsValue.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Value?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_AC_BitsValue?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AC-Defvalue
		//

		public void _init ()
		{
			m_Value = null;
			m_left_curly_bracket = null;
			m_AC_BitsValue = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-Defvalue

		// counter of all nodes associated with syntax rule AC-Defvalue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-Defvalue
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_AC_BitsValue")] public AC_BitsValue m_AC_BitsValue { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-Defvalue

		// delegate function (callback) prototype associated with syntax rule AC-Defvalue
		public delegate bool AC_Defvalue_Callback (SyntaxTreeCallbackReason reason, AC_Defvalue.production_kind kind, AC_Defvalue p_AC_Defvalue);

		// event associated with syntax rule AC-Defvalue
		public event AC_Defvalue_Callback AC_Defvalue_Event;

		// event trigger associated with syntax rule AC-Defvalue
		public bool Raise_AC_Defvalue_Event (SyntaxTreeCallbackReason reason, AC_Defvalue.production_kind kind, AC_Defvalue p_AC_Defvalue)
		{
			bool? status = AC_Defvalue_Event?.Invoke (reason, kind, p_AC_Defvalue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-Defvalue
		//
		// traverse syntax tree node associated with any production of syntax rule AC-Defvalue
		//

		public void Traverse (AC_Defvalue p_AC_Defvalue)
		{
			if (p_AC_Defvalue.isLocked())
				return;
			p_AC_Defvalue.dolock();
			AC_Defvalue.production_kind kind = (AC_Defvalue.production_kind) p_AC_Defvalue.kind;
			p_AC_Defvalue.turn_reset ();
			if (Raise_AC_Defvalue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_Defvalue))
			switch (kind)
			{
				case AC_Defvalue.production_kind.g_AC_Defvalue_1:
					// traverse syntax tree node associated with production
					// AC-Defvalue: Value

					if (Raise_AC_Defvalue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Defvalue))
						Traverse (p_AC_Defvalue.m_Value);
					p_AC_Defvalue.turn_inc ();
					Raise_AC_Defvalue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Defvalue);
				break;
				case AC_Defvalue.production_kind.g_AC_Defvalue_2:
					// traverse syntax tree node associated with production
					// AC-Defvalue: "{" AC-BitsValue "}"

					if (Raise_AC_Defvalue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Defvalue))
						Traverse (p_AC_Defvalue.m_AC_BitsValue);
					p_AC_Defvalue.turn_inc ();
					Raise_AC_Defvalue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Defvalue);
				break;
			}
			Raise_AC_Defvalue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_Defvalue);
			p_AC_Defvalue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Defvalue
		//

		public void TraverseCommon (AC_Defvalue p_AC_Defvalue)
		{
			AC_Defvalue.production_kind kind = (AC_Defvalue.production_kind) p_AC_Defvalue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_Defvalue))
			switch (kind)
			{
				case AC_Defvalue.production_kind.g_AC_Defvalue_1:
					// traverse syntax tree node associated with production
					// AC-Defvalue: Value

						TraverseCommon (p_AC_Defvalue.m_Value);
				break;
				case AC_Defvalue.production_kind.g_AC_Defvalue_2:
					// traverse syntax tree node associated with production
					// AC-Defvalue: "{" AC-BitsValue "}"

						TraverseCommon (p_AC_Defvalue.m_left_curly_bracket);
						TraverseCommon (p_AC_Defvalue.m_AC_BitsValue);
						TraverseCommon (p_AC_Defvalue.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_Defvalue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-Defvalue

		//
		// create syntax tree node associated with production
		// AC-Defvalue: Value

		//

		public AC_Defvalue AC_Defvalue_1 (Value p_Value)
		{
			AC_Defvalue p_AC_Defvalue_ref = new AC_Defvalue(p_Value);
			p_Value.parent = p_AC_Defvalue_ref;
			Raise_AC_Defvalue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_Defvalue.production_kind.g_AC_Defvalue_1, p_AC_Defvalue_ref);
			return p_AC_Defvalue_ref;
		}

		//
		// create syntax tree node associated with production
		// AC-Defvalue: "{" AC-BitsValue "}"

		//

		public AC_Defvalue AC_Defvalue_2 (SyntaxTreeToken p_token, AC_BitsValue p_AC_BitsValue, SyntaxTreeToken p_token_1)
		{
			AC_Defvalue p_AC_Defvalue_ref = new AC_Defvalue(p_token, p_AC_BitsValue, p_token_1);
			p_token.parent = p_AC_Defvalue_ref;
			p_AC_BitsValue.parent = p_AC_Defvalue_ref;
			p_token_1.parent = p_AC_Defvalue_ref;
			Raise_AC_Defvalue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_Defvalue.production_kind.g_AC_Defvalue_2, p_AC_Defvalue_ref);
			return p_AC_Defvalue_ref;
		}
		#endregion
	};
}
