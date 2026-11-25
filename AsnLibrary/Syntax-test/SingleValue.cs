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
	// class associated with syntax rule SingleValue
	//

	[DataContract]
	public class	SingleValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SingleValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SingleValue
		{
			g_SingleValue_1 = 1,	// Value

		};
		#endregion
		#region production markers associated with the syntax rule SingleValue

		// markers associated with production: SingleValue -> Value

		public enum production_marker_1 : ushort
		{
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SingleValue

		// Constructor declaration(s) associated with production(s) of syntax rule SingleValue

		//
		// Constructor associated with the following production(s)
		// SingleValue -> Value

		//

		public SingleValue (Value p_Value) : base ((uint) ProductionID._SingleValue_ID, (uint) production_kind.g_SingleValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Value = p_Value;
		}

		public SingleValue () { }

		// Copy constructor

		public SingleValue (SingleValue p_SingleValue) : base (p_SingleValue.id, p_SingleValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SingleValue.appInfo;
			switch ((production_kind) p_SingleValue.kind)
			{
				case production_kind.g_SingleValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Value = (p_SingleValue.m_Value != null) ? new Value (p_SingleValue.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SingleValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SingleValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SingleValue

		// Content changing function(s) associated with production(s) of syntax rule SingleValue

		//
		// Content changing function associated with following production(s)
		// SingleValue -> Value

		//

		public void change(Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_SingleValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SingleValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SingleValue

		//
		// emit production tree node associated with any production of syntax rule SingleValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SingleValue_1:
					// emit syntax tree node associated with production
					// SingleValue: Value

					s += m_Value.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SingleValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SingleValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SingleValue_1:
					// emit syntax tree node associated with production
					// SingleValue: Value

					s += m_Value.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SingleValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SingleValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SingleValue.production_kind kind = (SingleValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SingleValue.production_kind.g_SingleValue_1:
					// traverse syntax tree node associated with production
					// SingleValue: Value

						m_Value.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Value?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SingleValue
		//

		public void _init ()
		{
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SingleValue

		// counter of all nodes associated with syntax rule SingleValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SingleValue
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SingleValue

		// delegate function (callback) prototype associated with syntax rule SingleValue
		public delegate bool SingleValue_Callback (SyntaxTreeCallbackReason reason, SingleValue.production_kind kind, SingleValue p_SingleValue);

		// event associated with syntax rule SingleValue
		public event SingleValue_Callback SingleValue_Event;

		// event trigger associated with syntax rule SingleValue
		public bool Raise_SingleValue_Event (SyntaxTreeCallbackReason reason, SingleValue.production_kind kind, SingleValue p_SingleValue)
		{
			bool? status = SingleValue_Event?.Invoke (reason, kind, p_SingleValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SingleValue
		//
		// traverse syntax tree node associated with any production of syntax rule SingleValue
		//

		public void Traverse (SingleValue p_SingleValue)
		{
			if (p_SingleValue.isLocked())
				return;
			p_SingleValue.dolock();
			SingleValue.production_kind kind = (SingleValue.production_kind) p_SingleValue.kind;
			p_SingleValue.turn_reset ();
			if (Raise_SingleValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SingleValue))
			switch (kind)
			{
				case SingleValue.production_kind.g_SingleValue_1:
					// traverse syntax tree node associated with production
					// SingleValue: Value

					if (Raise_SingleValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SingleValue))
						Traverse (p_SingleValue.m_Value);
					p_SingleValue.turn_inc ();
					Raise_SingleValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SingleValue);
				break;
			}
			Raise_SingleValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SingleValue);
			p_SingleValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SingleValue
		//

		public void TraverseCommon (SingleValue p_SingleValue)
		{
			SingleValue.production_kind kind = (SingleValue.production_kind) p_SingleValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SingleValue))
			switch (kind)
			{
				case SingleValue.production_kind.g_SingleValue_1:
					// traverse syntax tree node associated with production
					// SingleValue: Value

						TraverseCommon (p_SingleValue.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SingleValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SingleValue

		//
		// create syntax tree node associated with production
		// SingleValue: Value

		//

		public SingleValue SingleValue_1 (Value p_Value)
		{
			SingleValue p_SingleValue_ref = new SingleValue(p_Value);
			p_Value.parent = p_SingleValue_ref;
			Raise_SingleValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SingleValue.production_kind.g_SingleValue_1, p_SingleValue_ref);
			return p_SingleValue_ref;
		}
		#endregion
	};
}
