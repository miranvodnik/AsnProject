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
	// class associated with syntax rule ChoiceValue
	//

	[DataContract]
	public class	ChoiceValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ChoiceValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ChoiceValue
		{
			g_ChoiceValue_1 = 1,	// identifier-token ":" Value

		};
		#endregion
		#region production markers associated with the syntax rule ChoiceValue

		// markers associated with production: ChoiceValue -> identifier-token ":" Value

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ChoiceValue

		// Constructor declaration(s) associated with production(s) of syntax rule ChoiceValue

		//
		// Constructor associated with the following production(s)
		// ChoiceValue -> identifier-token ":" Value

		//

		public ChoiceValue (identifier_token p_identifier_token, SyntaxTreeToken p_token, Value p_Value) : base ((uint) ProductionID._ChoiceValue_ID, (uint) production_kind.g_ChoiceValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_identifier_token = p_identifier_token;
			children[1] = m_colon = p_token;
			children[2] = m_Value = p_Value;
		}

		public ChoiceValue () { }

		// Copy constructor

		public ChoiceValue (ChoiceValue p_ChoiceValue) : base (p_ChoiceValue.id, p_ChoiceValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ChoiceValue.appInfo;
			switch ((production_kind) p_ChoiceValue.kind)
			{
				case production_kind.g_ChoiceValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_identifier_token = (p_ChoiceValue.m_identifier_token != null) ? new identifier_token (p_ChoiceValue.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [1] = m_colon = (p_ChoiceValue.m_colon != null) ? new SyntaxTreeToken (p_ChoiceValue.m_colon) : null) != null) m_colon.parent = this;
					if ((children [2] = m_Value = (p_ChoiceValue.m_Value != null) ? new Value (p_ChoiceValue.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ChoiceValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ChoiceValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();
			m_colon?.Dispose ();
			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ChoiceValue

		// Content changing function(s) associated with production(s) of syntax rule ChoiceValue

		//
		// Content changing function associated with following production(s)
		// ChoiceValue -> identifier-token ":" Value

		//

		public void change(identifier_token p_identifier_token, SyntaxTreeToken p_token, Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_ChoiceValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_identifier_token = p_identifier_token;
			children [1] = m_colon = p_token;
			children [2] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ChoiceValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				(m_colon != null) && m_colon.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ChoiceValue

		//
		// emit production tree node associated with any production of syntax rule ChoiceValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ChoiceValue_1:
					// emit syntax tree node associated with production
					// ChoiceValue: identifier-token ":" Value

					s += m_identifier_token.Emit (depth - 1);
					s += " ";
					s += m_colon.Emit (depth - 1);
					s += " ";
					s += m_Value.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ChoiceValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ChoiceValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ChoiceValue_1:
					// emit syntax tree node associated with production
					// ChoiceValue: identifier-token ":" Value

					s += m_identifier_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "colon";
					s += ' ';
					s += m_Value.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ChoiceValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ChoiceValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ChoiceValue.production_kind kind = (ChoiceValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ChoiceValue.production_kind.g_ChoiceValue_1:
					// traverse syntax tree node associated with production
					// ChoiceValue: identifier-token ":" Value

						m_identifier_token.Visit (visitor, appData);
						m_colon.Visit (visitor, appData);
						m_Value.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_identifier_token?.reparent (this);
			m_colon?.reparent (this);
			m_Value?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ChoiceValue
		//

		public void _init ()
		{
			m_identifier_token = null;
			m_colon = null;
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ChoiceValue

		// counter of all nodes associated with syntax rule ChoiceValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ChoiceValue
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_colon")] public SyntaxTreeToken m_colon { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ChoiceValue

		// delegate function (callback) prototype associated with syntax rule ChoiceValue
		public delegate bool ChoiceValue_Callback (SyntaxTreeCallbackReason reason, ChoiceValue.production_kind kind, ChoiceValue p_ChoiceValue);

		// event associated with syntax rule ChoiceValue
		public event ChoiceValue_Callback ChoiceValue_Event;

		// event trigger associated with syntax rule ChoiceValue
		public bool Raise_ChoiceValue_Event (SyntaxTreeCallbackReason reason, ChoiceValue.production_kind kind, ChoiceValue p_ChoiceValue)
		{
			bool? status = ChoiceValue_Event?.Invoke (reason, kind, p_ChoiceValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ChoiceValue
		//
		// traverse syntax tree node associated with any production of syntax rule ChoiceValue
		//

		public void Traverse (ChoiceValue p_ChoiceValue)
		{
			if (p_ChoiceValue.isLocked())
				return;
			p_ChoiceValue.dolock();
			ChoiceValue.production_kind kind = (ChoiceValue.production_kind) p_ChoiceValue.kind;
			p_ChoiceValue.turn_reset ();
			if (Raise_ChoiceValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ChoiceValue))
			switch (kind)
			{
				case ChoiceValue.production_kind.g_ChoiceValue_1:
					// traverse syntax tree node associated with production
					// ChoiceValue: identifier-token ":" Value

					if (Raise_ChoiceValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ChoiceValue))
						Traverse (p_ChoiceValue.m_identifier_token);
					p_ChoiceValue.turn_inc ();
					if (Raise_ChoiceValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ChoiceValue))
						Traverse (p_ChoiceValue.m_Value);
					p_ChoiceValue.turn_inc ();
					Raise_ChoiceValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ChoiceValue);
				break;
			}
			Raise_ChoiceValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ChoiceValue);
			p_ChoiceValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ChoiceValue
		//

		public void TraverseCommon (ChoiceValue p_ChoiceValue)
		{
			ChoiceValue.production_kind kind = (ChoiceValue.production_kind) p_ChoiceValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ChoiceValue))
			switch (kind)
			{
				case ChoiceValue.production_kind.g_ChoiceValue_1:
					// traverse syntax tree node associated with production
					// ChoiceValue: identifier-token ":" Value

						TraverseCommon (p_ChoiceValue.m_identifier_token);
						TraverseCommon (p_ChoiceValue.m_colon);
						TraverseCommon (p_ChoiceValue.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ChoiceValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ChoiceValue

		//
		// create syntax tree node associated with production
		// ChoiceValue: identifier-token ":" Value

		//

		public ChoiceValue ChoiceValue_1 (identifier_token p_identifier_token, SyntaxTreeToken p_token, Value p_Value)
		{
			ChoiceValue p_ChoiceValue_ref = new ChoiceValue(p_identifier_token, p_token, p_Value);
			p_identifier_token.parent = p_ChoiceValue_ref;
			p_token.parent = p_ChoiceValue_ref;
			p_Value.parent = p_ChoiceValue_ref;
			Raise_ChoiceValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ChoiceValue.production_kind.g_ChoiceValue_1, p_ChoiceValue_ref);
			return p_ChoiceValue_ref;
		}
		#endregion
	};
}
