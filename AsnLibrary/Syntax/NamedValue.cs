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
	// class associated with syntax rule NamedValue
	//

	[DataContract]
	public class	NamedValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NamedValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NamedValue
		{
			g_NamedValue_1 = 1,	// identifier-token Value

		};
		#endregion
		#region production markers associated with the syntax rule NamedValue

		// markers associated with production: NamedValue -> identifier-token Value

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NamedValue

		// Constructor declaration(s) associated with production(s) of syntax rule NamedValue

		//
		// Constructor associated with the following production(s)
		// NamedValue -> identifier-token Value

		//

		public NamedValue (identifier_token p_identifier_token, Value p_Value) : base ((uint) ProductionID._NamedValue_ID, (uint) production_kind.g_NamedValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_identifier_token = p_identifier_token;
			children[1] = m_Value = p_Value;
		}

		public NamedValue () { }

		// Copy constructor

		public NamedValue (NamedValue p_NamedValue) : base (p_NamedValue.id, p_NamedValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NamedValue.appInfo;
			switch ((production_kind) p_NamedValue.kind)
			{
				case production_kind.g_NamedValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_identifier_token = (p_NamedValue.m_identifier_token != null) ? new identifier_token (p_NamedValue.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [1] = m_Value = (p_NamedValue.m_Value != null) ? new Value (p_NamedValue.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NamedValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NamedValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();
			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NamedValue

		// Content changing function(s) associated with production(s) of syntax rule NamedValue

		//
		// Content changing function associated with following production(s)
		// NamedValue -> identifier-token Value

		//

		public void change(identifier_token p_identifier_token, Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_NamedValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_identifier_token = p_identifier_token;
			children [1] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NamedValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NamedValue

		//
		// emit production tree node associated with any production of syntax rule NamedValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NamedValue_1:
					// emit syntax tree node associated with production
					// NamedValue: identifier-token Value

					s += m_identifier_token.Emit (depth - 1);
					s += " ";
					s += m_Value.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NamedValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NamedValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NamedValue_1:
					// emit syntax tree node associated with production
					// NamedValue: identifier-token Value

					s += m_identifier_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_Value.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NamedValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NamedValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NamedValue.production_kind kind = (NamedValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NamedValue.production_kind.g_NamedValue_1:
					// traverse syntax tree node associated with production
					// NamedValue: identifier-token Value

						m_identifier_token.Visit (visitor, appData);
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
			m_Value?.reparent (this);
		}

		//
		// initialize object associated with syntax rule NamedValue
		//

		public void _init ()
		{
			m_identifier_token = null;
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NamedValue

		// counter of all nodes associated with syntax rule NamedValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NamedValue
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NamedValue

		// delegate function (callback) prototype associated with syntax rule NamedValue
		public delegate bool NamedValue_Callback (SyntaxTreeCallbackReason reason, NamedValue.production_kind kind, NamedValue p_NamedValue);

		// event associated with syntax rule NamedValue
		public event NamedValue_Callback NamedValue_Event;

		// event trigger associated with syntax rule NamedValue
		public bool Raise_NamedValue_Event (SyntaxTreeCallbackReason reason, NamedValue.production_kind kind, NamedValue p_NamedValue)
		{
			bool? status = NamedValue_Event?.Invoke (reason, kind, p_NamedValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NamedValue
		//
		// traverse syntax tree node associated with any production of syntax rule NamedValue
		//

		public void Traverse (NamedValue p_NamedValue)
		{
			if (p_NamedValue.isLocked())
				return;
			p_NamedValue.dolock();
			NamedValue.production_kind kind = (NamedValue.production_kind) p_NamedValue.kind;
			p_NamedValue.turn_reset ();
			if (Raise_NamedValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NamedValue))
			switch (kind)
			{
				case NamedValue.production_kind.g_NamedValue_1:
					// traverse syntax tree node associated with production
					// NamedValue: identifier-token Value

					if (Raise_NamedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedValue))
						Traverse (p_NamedValue.m_identifier_token);
					p_NamedValue.turn_inc ();
					if (Raise_NamedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedValue))
						Traverse (p_NamedValue.m_Value);
					p_NamedValue.turn_inc ();
					Raise_NamedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedValue);
				break;
			}
			Raise_NamedValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NamedValue);
			p_NamedValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NamedValue
		//

		public void TraverseCommon (NamedValue p_NamedValue)
		{
			NamedValue.production_kind kind = (NamedValue.production_kind) p_NamedValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NamedValue))
			switch (kind)
			{
				case NamedValue.production_kind.g_NamedValue_1:
					// traverse syntax tree node associated with production
					// NamedValue: identifier-token Value

						TraverseCommon (p_NamedValue.m_identifier_token);
						TraverseCommon (p_NamedValue.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NamedValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NamedValue

		//
		// create syntax tree node associated with production
		// NamedValue: identifier-token Value

		//

		public NamedValue NamedValue_1 (identifier_token p_identifier_token, Value p_Value)
		{
			NamedValue p_NamedValue_ref = new NamedValue(p_identifier_token, p_Value);
			p_identifier_token.parent = p_NamedValue_ref;
			p_Value.parent = p_NamedValue_ref;
			Raise_NamedValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NamedValue.production_kind.g_NamedValue_1, p_NamedValue_ref);
			return p_NamedValue_ref;
		}
		#endregion
	};
}
