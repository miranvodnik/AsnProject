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
	// class associated with syntax rule OT-Defvalue
	//

	[DataContract]
	public class	OT_Defvalue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OT-Defvalue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OT-Defvalue
		{
			g_OT_Defvalue_1 = 1,	// Value

			g_OT_Defvalue_2 = 2,	// "{" OT-BitsValue "}"

		};
		#endregion
		#region production markers associated with the syntax rule OT-Defvalue

		// markers associated with production: OT-Defvalue -> Value

		public enum production_marker_1 : ushort
		{
			m_Value,
			final
		};

		// markers associated with production: OT-Defvalue -> "{" OT-BitsValue "}"

		public enum production_marker_2 : ushort
		{
			m_OT_BitsValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OT-Defvalue

		// Constructor declaration(s) associated with production(s) of syntax rule OT-Defvalue

		//
		// Constructor associated with the following production(s)
		// OT-Defvalue -> Value

		//

		public OT_Defvalue (Value p_Value) : base ((uint) ProductionID._OT_Defvalue_ID, (uint) production_kind.g_OT_Defvalue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Value = p_Value;
		}

		//
		// Constructor associated with the following production(s)
		// OT-Defvalue -> "{" OT-BitsValue "}"

		//

		public OT_Defvalue (SyntaxTreeToken p_token, OT_BitsValue p_OT_BitsValue, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._OT_Defvalue_ID, (uint) production_kind.g_OT_Defvalue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_OT_BitsValue = p_OT_BitsValue;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		public OT_Defvalue () { }

		// Copy constructor

		public OT_Defvalue (OT_Defvalue p_OT_Defvalue) : base (p_OT_Defvalue.id, p_OT_Defvalue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OT_Defvalue.appInfo;
			switch ((production_kind) p_OT_Defvalue.kind)
			{
				case production_kind.g_OT_Defvalue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Value = (p_OT_Defvalue.m_Value != null) ? new Value (p_OT_Defvalue.m_Value) : null) != null) m_Value.parent = this;
					break;
				case production_kind.g_OT_Defvalue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_OT_Defvalue.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_OT_Defvalue.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_OT_BitsValue = (p_OT_Defvalue.m_OT_BitsValue != null) ? new OT_BitsValue (p_OT_Defvalue.m_OT_BitsValue) : null) != null) m_OT_BitsValue.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_OT_Defvalue.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_OT_Defvalue.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "OT_Defvalue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OT_Defvalue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Value?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_OT_BitsValue?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OT-Defvalue

		// Content changing function(s) associated with production(s) of syntax rule OT-Defvalue

		//
		// Content changing function associated with following production(s)
		// OT-Defvalue -> Value

		//

		public void change(Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_Defvalue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// OT-Defvalue -> "{" OT-BitsValue "}"

		//

		public void change(SyntaxTreeToken p_token, OT_BitsValue p_OT_BitsValue, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_Defvalue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_OT_BitsValue = p_OT_BitsValue;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OT-Defvalue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_OT_BitsValue != null) && m_OT_BitsValue.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OT-Defvalue

		//
		// emit production tree node associated with any production of syntax rule OT-Defvalue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_OT_Defvalue_1:
					// emit syntax tree node associated with production
					// OT-Defvalue: Value

					s += m_Value.Emit (depth - 1);
				break;
				case production_kind.g_OT_Defvalue_2:
					// emit syntax tree node associated with production
					// OT-Defvalue: "{" OT-BitsValue "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_OT_BitsValue.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OT-Defvalue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "OT_Defvalue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_OT_Defvalue_1:
					// emit syntax tree node associated with production
					// OT-Defvalue: Value

					s += m_Value.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_OT_Defvalue_2:
					// emit syntax tree node associated with production
					// OT-Defvalue: "{" OT-BitsValue "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_OT_BitsValue.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OT-Defvalue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OT-Defvalue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			OT_Defvalue.production_kind kind = (OT_Defvalue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case OT_Defvalue.production_kind.g_OT_Defvalue_1:
					// traverse syntax tree node associated with production
					// OT-Defvalue: Value

						m_Value.Visit (visitor, appData);
				break;
				case OT_Defvalue.production_kind.g_OT_Defvalue_2:
					// traverse syntax tree node associated with production
					// OT-Defvalue: "{" OT-BitsValue "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_OT_BitsValue.Visit (visitor, appData);
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
			m_OT_BitsValue?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule OT-Defvalue
		//

		public void _init ()
		{
			m_Value = null;
			m_left_curly_bracket = null;
			m_OT_BitsValue = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OT-Defvalue

		// counter of all nodes associated with syntax rule OT-Defvalue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OT-Defvalue
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_OT_BitsValue")] public OT_BitsValue m_OT_BitsValue { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OT-Defvalue

		// delegate function (callback) prototype associated with syntax rule OT-Defvalue
		public delegate bool OT_Defvalue_Callback (SyntaxTreeCallbackReason reason, OT_Defvalue.production_kind kind, OT_Defvalue p_OT_Defvalue);

		// event associated with syntax rule OT-Defvalue
		public event OT_Defvalue_Callback OT_Defvalue_Event;

		// event trigger associated with syntax rule OT-Defvalue
		public bool Raise_OT_Defvalue_Event (SyntaxTreeCallbackReason reason, OT_Defvalue.production_kind kind, OT_Defvalue p_OT_Defvalue)
		{
			bool? status = OT_Defvalue_Event?.Invoke (reason, kind, p_OT_Defvalue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OT-Defvalue
		//
		// traverse syntax tree node associated with any production of syntax rule OT-Defvalue
		//

		public void Traverse (OT_Defvalue p_OT_Defvalue)
		{
			if (p_OT_Defvalue.isLocked())
				return;
			p_OT_Defvalue.dolock();
			OT_Defvalue.production_kind kind = (OT_Defvalue.production_kind) p_OT_Defvalue.kind;
			p_OT_Defvalue.turn_reset ();
			if (Raise_OT_Defvalue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_OT_Defvalue))
			switch (kind)
			{
				case OT_Defvalue.production_kind.g_OT_Defvalue_1:
					// traverse syntax tree node associated with production
					// OT-Defvalue: Value

					if (Raise_OT_Defvalue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_Defvalue))
						Traverse (p_OT_Defvalue.m_Value);
					p_OT_Defvalue.turn_inc ();
					Raise_OT_Defvalue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_Defvalue);
				break;
				case OT_Defvalue.production_kind.g_OT_Defvalue_2:
					// traverse syntax tree node associated with production
					// OT-Defvalue: "{" OT-BitsValue "}"

					if (Raise_OT_Defvalue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_Defvalue))
						Traverse (p_OT_Defvalue.m_OT_BitsValue);
					p_OT_Defvalue.turn_inc ();
					Raise_OT_Defvalue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_Defvalue);
				break;
			}
			Raise_OT_Defvalue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_OT_Defvalue);
			p_OT_Defvalue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OT-Defvalue
		//

		public void TraverseCommon (OT_Defvalue p_OT_Defvalue)
		{
			OT_Defvalue.production_kind kind = (OT_Defvalue.production_kind) p_OT_Defvalue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_OT_Defvalue))
			switch (kind)
			{
				case OT_Defvalue.production_kind.g_OT_Defvalue_1:
					// traverse syntax tree node associated with production
					// OT-Defvalue: Value

						TraverseCommon (p_OT_Defvalue.m_Value);
				break;
				case OT_Defvalue.production_kind.g_OT_Defvalue_2:
					// traverse syntax tree node associated with production
					// OT-Defvalue: "{" OT-BitsValue "}"

						TraverseCommon (p_OT_Defvalue.m_left_curly_bracket);
						TraverseCommon (p_OT_Defvalue.m_OT_BitsValue);
						TraverseCommon (p_OT_Defvalue.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_OT_Defvalue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OT-Defvalue

		//
		// create syntax tree node associated with production
		// OT-Defvalue: Value

		//

		public OT_Defvalue OT_Defvalue_1 (Value p_Value)
		{
			OT_Defvalue p_OT_Defvalue_ref = new OT_Defvalue(p_Value);
			p_Value.parent = p_OT_Defvalue_ref;
			Raise_OT_Defvalue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_Defvalue.production_kind.g_OT_Defvalue_1, p_OT_Defvalue_ref);
			return p_OT_Defvalue_ref;
		}

		//
		// create syntax tree node associated with production
		// OT-Defvalue: "{" OT-BitsValue "}"

		//

		public OT_Defvalue OT_Defvalue_2 (SyntaxTreeToken p_token, OT_BitsValue p_OT_BitsValue, SyntaxTreeToken p_token_1)
		{
			OT_Defvalue p_OT_Defvalue_ref = new OT_Defvalue(p_token, p_OT_BitsValue, p_token_1);
			p_token.parent = p_OT_Defvalue_ref;
			p_OT_BitsValue.parent = p_OT_Defvalue_ref;
			p_token_1.parent = p_OT_Defvalue_ref;
			Raise_OT_Defvalue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_Defvalue.production_kind.g_OT_Defvalue_2, p_OT_Defvalue_ref);
			return p_OT_Defvalue_ref;
		}
		#endregion
	};
}
