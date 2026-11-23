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
	// class associated with syntax rule LowerEndValue
	//

	[DataContract]
	public class	LowerEndValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule LowerEndValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule LowerEndValue
		{
			g_LowerEndValue_1 = 1,	// Value

			g_LowerEndValue_2 = 2,	// MIN

		};
		#endregion
		#region production markers associated with the syntax rule LowerEndValue

		// markers associated with production: LowerEndValue -> Value

		public enum production_marker_1 : ushort
		{
			m_Value,
			final
		};

		// markers associated with production: LowerEndValue -> MIN

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule LowerEndValue

		// Constructor declaration(s) associated with production(s) of syntax rule LowerEndValue

		//
		// Constructor associated with the following production(s)
		// LowerEndValue -> Value

		//

		public LowerEndValue (Value p_Value) : base ((uint) ProductionID._LowerEndValue_ID, (uint) production_kind.g_LowerEndValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Value = p_Value;
		}

		//
		// Constructor associated with the following production(s)
		// LowerEndValue -> MIN

		//

		public LowerEndValue (SyntaxTreeToken p_token) : base ((uint) ProductionID._LowerEndValue_ID, (uint) production_kind.g_LowerEndValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_MIN = p_token;
		}

		public LowerEndValue () { }

		// Copy constructor

		public LowerEndValue (LowerEndValue p_LowerEndValue) : base (p_LowerEndValue.id, p_LowerEndValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_LowerEndValue.appInfo;
			switch ((production_kind) p_LowerEndValue.kind)
			{
				case production_kind.g_LowerEndValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Value = (p_LowerEndValue.m_Value != null) ? new Value (p_LowerEndValue.m_Value) : null) != null) m_Value.parent = this;
					break;
				case production_kind.g_LowerEndValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MIN = (p_LowerEndValue.m_MIN != null) ? new SyntaxTreeToken (p_LowerEndValue.m_MIN) : null) != null) m_MIN.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "LowerEndValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new LowerEndValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Value?.Dispose ();
			m_MIN?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule LowerEndValue

		// Content changing function(s) associated with production(s) of syntax rule LowerEndValue

		//
		// Content changing function associated with following production(s)
		// LowerEndValue -> Value

		//

		public void change(Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_LowerEndValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// LowerEndValue -> MIN

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_LowerEndValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_MIN = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule LowerEndValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				(m_MIN != null) && m_MIN.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule LowerEndValue

		//
		// emit production tree node associated with any production of syntax rule LowerEndValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_LowerEndValue_1:
					// emit syntax tree node associated with production
					// LowerEndValue: Value

					s += m_Value.Emit (depth - 1);
				break;
				case production_kind.g_LowerEndValue_2:
					// emit syntax tree node associated with production
					// LowerEndValue: MIN

					s += m_MIN.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule LowerEndValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "LowerEndValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_LowerEndValue_1:
					// emit syntax tree node associated with production
					// LowerEndValue: Value

					s += m_Value.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_LowerEndValue_2:
					// emit syntax tree node associated with production
					// LowerEndValue: MIN

					s += "MIN";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule LowerEndValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule LowerEndValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			LowerEndValue.production_kind kind = (LowerEndValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case LowerEndValue.production_kind.g_LowerEndValue_1:
					// traverse syntax tree node associated with production
					// LowerEndValue: Value

						m_Value.Visit (visitor, appData);
				break;
				case LowerEndValue.production_kind.g_LowerEndValue_2:
					// traverse syntax tree node associated with production
					// LowerEndValue: MIN

						m_MIN.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Value?.reparent (this);
			m_MIN?.reparent (this);
		}

		//
		// initialize object associated with syntax rule LowerEndValue
		//

		public void _init ()
		{
			m_Value = null;
			m_MIN = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule LowerEndValue

		// counter of all nodes associated with syntax rule LowerEndValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule LowerEndValue
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		[DataMember (Name = "m_MIN")] public SyntaxTreeToken m_MIN { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule LowerEndValue

		// delegate function (callback) prototype associated with syntax rule LowerEndValue
		public delegate bool LowerEndValue_Callback (SyntaxTreeCallbackReason reason, LowerEndValue.production_kind kind, LowerEndValue p_LowerEndValue);

		// event associated with syntax rule LowerEndValue
		public event LowerEndValue_Callback LowerEndValue_Event;

		// event trigger associated with syntax rule LowerEndValue
		public bool Raise_LowerEndValue_Event (SyntaxTreeCallbackReason reason, LowerEndValue.production_kind kind, LowerEndValue p_LowerEndValue)
		{
			bool? status = LowerEndValue_Event?.Invoke (reason, kind, p_LowerEndValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule LowerEndValue
		//
		// traverse syntax tree node associated with any production of syntax rule LowerEndValue
		//

		public void Traverse (LowerEndValue p_LowerEndValue)
		{
			if (p_LowerEndValue.isLocked())
				return;
			p_LowerEndValue.dolock();
			LowerEndValue.production_kind kind = (LowerEndValue.production_kind) p_LowerEndValue.kind;
			p_LowerEndValue.turn_reset ();
			if (Raise_LowerEndValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_LowerEndValue))
			switch (kind)
			{
				case LowerEndValue.production_kind.g_LowerEndValue_1:
					// traverse syntax tree node associated with production
					// LowerEndValue: Value

					if (Raise_LowerEndValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_LowerEndValue))
						Traverse (p_LowerEndValue.m_Value);
					p_LowerEndValue.turn_inc ();
					Raise_LowerEndValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_LowerEndValue);
				break;
				case LowerEndValue.production_kind.g_LowerEndValue_2:
					// traverse syntax tree node associated with production
					// LowerEndValue: MIN

				break;
			}
			Raise_LowerEndValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_LowerEndValue);
			p_LowerEndValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule LowerEndValue
		//

		public void TraverseCommon (LowerEndValue p_LowerEndValue)
		{
			LowerEndValue.production_kind kind = (LowerEndValue.production_kind) p_LowerEndValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_LowerEndValue))
			switch (kind)
			{
				case LowerEndValue.production_kind.g_LowerEndValue_1:
					// traverse syntax tree node associated with production
					// LowerEndValue: Value

						TraverseCommon (p_LowerEndValue.m_Value);
				break;
				case LowerEndValue.production_kind.g_LowerEndValue_2:
					// traverse syntax tree node associated with production
					// LowerEndValue: MIN

						TraverseCommon (p_LowerEndValue.m_MIN);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_LowerEndValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule LowerEndValue

		//
		// create syntax tree node associated with production
		// LowerEndValue: Value

		//

		public LowerEndValue LowerEndValue_1 (Value p_Value)
		{
			LowerEndValue p_LowerEndValue_ref = new LowerEndValue(p_Value);
			p_Value.parent = p_LowerEndValue_ref;
			Raise_LowerEndValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, LowerEndValue.production_kind.g_LowerEndValue_1, p_LowerEndValue_ref);
			return p_LowerEndValue_ref;
		}

		//
		// create syntax tree node associated with production
		// LowerEndValue: MIN

		//

		public LowerEndValue LowerEndValue_2 (SyntaxTreeToken p_token)
		{
			LowerEndValue p_LowerEndValue_ref = new LowerEndValue(p_token);
			p_token.parent = p_LowerEndValue_ref;
			Raise_LowerEndValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, LowerEndValue.production_kind.g_LowerEndValue_2, p_LowerEndValue_ref);
			return p_LowerEndValue_ref;
		}
		#endregion
	};
}
