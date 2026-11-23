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
	// class associated with syntax rule UpperEndValue
	//

	[DataContract]
	public class	UpperEndValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule UpperEndValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule UpperEndValue
		{
			g_UpperEndValue_1 = 1,	// Value

			g_UpperEndValue_2 = 2,	// MAX

		};
		#endregion
		#region production markers associated with the syntax rule UpperEndValue

		// markers associated with production: UpperEndValue -> Value

		public enum production_marker_1 : ushort
		{
			m_Value,
			final
		};

		// markers associated with production: UpperEndValue -> MAX

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule UpperEndValue

		// Constructor declaration(s) associated with production(s) of syntax rule UpperEndValue

		//
		// Constructor associated with the following production(s)
		// UpperEndValue -> Value

		//

		public UpperEndValue (Value p_Value) : base ((uint) ProductionID._UpperEndValue_ID, (uint) production_kind.g_UpperEndValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Value = p_Value;
		}

		//
		// Constructor associated with the following production(s)
		// UpperEndValue -> MAX

		//

		public UpperEndValue (SyntaxTreeToken p_token) : base ((uint) ProductionID._UpperEndValue_ID, (uint) production_kind.g_UpperEndValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_MAX = p_token;
		}

		public UpperEndValue () { }

		// Copy constructor

		public UpperEndValue (UpperEndValue p_UpperEndValue) : base (p_UpperEndValue.id, p_UpperEndValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_UpperEndValue.appInfo;
			switch ((production_kind) p_UpperEndValue.kind)
			{
				case production_kind.g_UpperEndValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Value = (p_UpperEndValue.m_Value != null) ? new Value (p_UpperEndValue.m_Value) : null) != null) m_Value.parent = this;
					break;
				case production_kind.g_UpperEndValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MAX = (p_UpperEndValue.m_MAX != null) ? new SyntaxTreeToken (p_UpperEndValue.m_MAX) : null) != null) m_MAX.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "UpperEndValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new UpperEndValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Value?.Dispose ();
			m_MAX?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule UpperEndValue

		// Content changing function(s) associated with production(s) of syntax rule UpperEndValue

		//
		// Content changing function associated with following production(s)
		// UpperEndValue -> Value

		//

		public void change(Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_UpperEndValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// UpperEndValue -> MAX

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_UpperEndValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_MAX = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule UpperEndValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				(m_MAX != null) && m_MAX.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule UpperEndValue

		//
		// emit production tree node associated with any production of syntax rule UpperEndValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_UpperEndValue_1:
					// emit syntax tree node associated with production
					// UpperEndValue: Value

					s += m_Value.Emit (depth - 1);
				break;
				case production_kind.g_UpperEndValue_2:
					// emit syntax tree node associated with production
					// UpperEndValue: MAX

					s += m_MAX.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule UpperEndValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "UpperEndValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_UpperEndValue_1:
					// emit syntax tree node associated with production
					// UpperEndValue: Value

					s += m_Value.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_UpperEndValue_2:
					// emit syntax tree node associated with production
					// UpperEndValue: MAX

					s += "MAX";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule UpperEndValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule UpperEndValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			UpperEndValue.production_kind kind = (UpperEndValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case UpperEndValue.production_kind.g_UpperEndValue_1:
					// traverse syntax tree node associated with production
					// UpperEndValue: Value

						m_Value.Visit (visitor, appData);
				break;
				case UpperEndValue.production_kind.g_UpperEndValue_2:
					// traverse syntax tree node associated with production
					// UpperEndValue: MAX

						m_MAX.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Value?.reparent (this);
			m_MAX?.reparent (this);
		}

		//
		// initialize object associated with syntax rule UpperEndValue
		//

		public void _init ()
		{
			m_Value = null;
			m_MAX = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule UpperEndValue

		// counter of all nodes associated with syntax rule UpperEndValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule UpperEndValue
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		[DataMember (Name = "m_MAX")] public SyntaxTreeToken m_MAX { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule UpperEndValue

		// delegate function (callback) prototype associated with syntax rule UpperEndValue
		public delegate bool UpperEndValue_Callback (SyntaxTreeCallbackReason reason, UpperEndValue.production_kind kind, UpperEndValue p_UpperEndValue);

		// event associated with syntax rule UpperEndValue
		public event UpperEndValue_Callback UpperEndValue_Event;

		// event trigger associated with syntax rule UpperEndValue
		public bool Raise_UpperEndValue_Event (SyntaxTreeCallbackReason reason, UpperEndValue.production_kind kind, UpperEndValue p_UpperEndValue)
		{
			bool? status = UpperEndValue_Event?.Invoke (reason, kind, p_UpperEndValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule UpperEndValue
		//
		// traverse syntax tree node associated with any production of syntax rule UpperEndValue
		//

		public void Traverse (UpperEndValue p_UpperEndValue)
		{
			if (p_UpperEndValue.isLocked())
				return;
			p_UpperEndValue.dolock();
			UpperEndValue.production_kind kind = (UpperEndValue.production_kind) p_UpperEndValue.kind;
			p_UpperEndValue.turn_reset ();
			if (Raise_UpperEndValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_UpperEndValue))
			switch (kind)
			{
				case UpperEndValue.production_kind.g_UpperEndValue_1:
					// traverse syntax tree node associated with production
					// UpperEndValue: Value

					if (Raise_UpperEndValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UpperEndValue))
						Traverse (p_UpperEndValue.m_Value);
					p_UpperEndValue.turn_inc ();
					Raise_UpperEndValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UpperEndValue);
				break;
				case UpperEndValue.production_kind.g_UpperEndValue_2:
					// traverse syntax tree node associated with production
					// UpperEndValue: MAX

				break;
			}
			Raise_UpperEndValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_UpperEndValue);
			p_UpperEndValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule UpperEndValue
		//

		public void TraverseCommon (UpperEndValue p_UpperEndValue)
		{
			UpperEndValue.production_kind kind = (UpperEndValue.production_kind) p_UpperEndValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_UpperEndValue))
			switch (kind)
			{
				case UpperEndValue.production_kind.g_UpperEndValue_1:
					// traverse syntax tree node associated with production
					// UpperEndValue: Value

						TraverseCommon (p_UpperEndValue.m_Value);
				break;
				case UpperEndValue.production_kind.g_UpperEndValue_2:
					// traverse syntax tree node associated with production
					// UpperEndValue: MAX

						TraverseCommon (p_UpperEndValue.m_MAX);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_UpperEndValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule UpperEndValue

		//
		// create syntax tree node associated with production
		// UpperEndValue: Value

		//

		public UpperEndValue UpperEndValue_1 (Value p_Value)
		{
			UpperEndValue p_UpperEndValue_ref = new UpperEndValue(p_Value);
			p_Value.parent = p_UpperEndValue_ref;
			Raise_UpperEndValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UpperEndValue.production_kind.g_UpperEndValue_1, p_UpperEndValue_ref);
			return p_UpperEndValue_ref;
		}

		//
		// create syntax tree node associated with production
		// UpperEndValue: MAX

		//

		public UpperEndValue UpperEndValue_2 (SyntaxTreeToken p_token)
		{
			UpperEndValue p_UpperEndValue_ref = new UpperEndValue(p_token);
			p_token.parent = p_UpperEndValue_ref;
			Raise_UpperEndValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UpperEndValue.production_kind.g_UpperEndValue_2, p_UpperEndValue_ref);
			return p_UpperEndValue_ref;
		}
		#endregion
	};
}
