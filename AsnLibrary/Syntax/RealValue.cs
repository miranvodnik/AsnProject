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
	// class associated with syntax rule RealValue
	//

	[DataContract]
	public class	RealValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule RealValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule RealValue
		{
			g_RealValue_1 = 1,	// NumericRealValue

			g_RealValue_2 = 2,	// SpecialRealValue

		};
		#endregion
		#region production markers associated with the syntax rule RealValue

		// markers associated with production: RealValue -> NumericRealValue

		public enum production_marker_1 : ushort
		{
			m_NumericRealValue,
			final
		};

		// markers associated with production: RealValue -> SpecialRealValue

		public enum production_marker_2 : ushort
		{
			m_SpecialRealValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule RealValue

		// Constructor declaration(s) associated with production(s) of syntax rule RealValue

		//
		// Constructor associated with the following production(s)
		// RealValue -> NumericRealValue

		//

		public RealValue (NumericRealValue p_NumericRealValue) : base ((uint) ProductionID._RealValue_ID, (uint) production_kind.g_RealValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NumericRealValue = p_NumericRealValue;
		}

		//
		// Constructor associated with the following production(s)
		// RealValue -> SpecialRealValue

		//

		public RealValue (SpecialRealValue p_SpecialRealValue) : base ((uint) ProductionID._RealValue_ID, (uint) production_kind.g_RealValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SpecialRealValue = p_SpecialRealValue;
		}

		public RealValue () { }

		// Copy constructor

		public RealValue (RealValue p_RealValue) : base (p_RealValue.id, p_RealValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_RealValue.appInfo;
			switch ((production_kind) p_RealValue.kind)
			{
				case production_kind.g_RealValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NumericRealValue = (p_RealValue.m_NumericRealValue != null) ? new NumericRealValue (p_RealValue.m_NumericRealValue) : null) != null) m_NumericRealValue.parent = this;
					break;
				case production_kind.g_RealValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SpecialRealValue = (p_RealValue.m_SpecialRealValue != null) ? new SpecialRealValue (p_RealValue.m_SpecialRealValue) : null) != null) m_SpecialRealValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "RealValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new RealValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_NumericRealValue?.Dispose ();
			m_SpecialRealValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule RealValue

		// Content changing function(s) associated with production(s) of syntax rule RealValue

		//
		// Content changing function associated with following production(s)
		// RealValue -> NumericRealValue

		//

		public void change(NumericRealValue p_NumericRealValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_RealValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NumericRealValue = p_NumericRealValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// RealValue -> SpecialRealValue

		//

		public void change(SpecialRealValue p_SpecialRealValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_RealValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SpecialRealValue = p_SpecialRealValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule RealValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_NumericRealValue != null) && m_NumericRealValue.checkInclusion (element) ||
				(m_SpecialRealValue != null) && m_SpecialRealValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule RealValue

		//
		// emit production tree node associated with any production of syntax rule RealValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_RealValue_1:
					// emit syntax tree node associated with production
					// RealValue: NumericRealValue

					s += m_NumericRealValue.Emit (depth - 1);
				break;
				case production_kind.g_RealValue_2:
					// emit syntax tree node associated with production
					// RealValue: SpecialRealValue

					s += m_SpecialRealValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule RealValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "RealValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_RealValue_1:
					// emit syntax tree node associated with production
					// RealValue: NumericRealValue

					s += m_NumericRealValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_RealValue_2:
					// emit syntax tree node associated with production
					// RealValue: SpecialRealValue

					s += m_SpecialRealValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule RealValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule RealValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			RealValue.production_kind kind = (RealValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case RealValue.production_kind.g_RealValue_1:
					// traverse syntax tree node associated with production
					// RealValue: NumericRealValue

						m_NumericRealValue.Visit (visitor, appData);
				break;
				case RealValue.production_kind.g_RealValue_2:
					// traverse syntax tree node associated with production
					// RealValue: SpecialRealValue

						m_SpecialRealValue.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_NumericRealValue?.reparent (this);
			m_SpecialRealValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule RealValue
		//

		public void _init ()
		{
			m_NumericRealValue = null;
			m_SpecialRealValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule RealValue

		// counter of all nodes associated with syntax rule RealValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule RealValue
		[DataMember (Name = "m_NumericRealValue")] public NumericRealValue m_NumericRealValue { get; private set; }
		[DataMember (Name = "m_SpecialRealValue")] public SpecialRealValue m_SpecialRealValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule RealValue

		// delegate function (callback) prototype associated with syntax rule RealValue
		public delegate bool RealValue_Callback (SyntaxTreeCallbackReason reason, RealValue.production_kind kind, RealValue p_RealValue);

		// event associated with syntax rule RealValue
		public event RealValue_Callback RealValue_Event;

		// event trigger associated with syntax rule RealValue
		public bool Raise_RealValue_Event (SyntaxTreeCallbackReason reason, RealValue.production_kind kind, RealValue p_RealValue)
		{
			bool? status = RealValue_Event?.Invoke (reason, kind, p_RealValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule RealValue
		//
		// traverse syntax tree node associated with any production of syntax rule RealValue
		//

		public void Traverse (RealValue p_RealValue)
		{
			if (p_RealValue.isLocked())
				return;
			p_RealValue.dolock();
			RealValue.production_kind kind = (RealValue.production_kind) p_RealValue.kind;
			p_RealValue.turn_reset ();
			if (Raise_RealValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_RealValue))
			switch (kind)
			{
				case RealValue.production_kind.g_RealValue_1:
					// traverse syntax tree node associated with production
					// RealValue: NumericRealValue

					if (Raise_RealValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RealValue))
						Traverse (p_RealValue.m_NumericRealValue);
					p_RealValue.turn_inc ();
					Raise_RealValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RealValue);
				break;
				case RealValue.production_kind.g_RealValue_2:
					// traverse syntax tree node associated with production
					// RealValue: SpecialRealValue

					if (Raise_RealValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RealValue))
						Traverse (p_RealValue.m_SpecialRealValue);
					p_RealValue.turn_inc ();
					Raise_RealValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RealValue);
				break;
			}
			Raise_RealValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_RealValue);
			p_RealValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule RealValue
		//

		public void TraverseCommon (RealValue p_RealValue)
		{
			RealValue.production_kind kind = (RealValue.production_kind) p_RealValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_RealValue))
			switch (kind)
			{
				case RealValue.production_kind.g_RealValue_1:
					// traverse syntax tree node associated with production
					// RealValue: NumericRealValue

						TraverseCommon (p_RealValue.m_NumericRealValue);
				break;
				case RealValue.production_kind.g_RealValue_2:
					// traverse syntax tree node associated with production
					// RealValue: SpecialRealValue

						TraverseCommon (p_RealValue.m_SpecialRealValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_RealValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule RealValue

		//
		// create syntax tree node associated with production
		// RealValue: NumericRealValue

		//

		public RealValue RealValue_1 (NumericRealValue p_NumericRealValue)
		{
			RealValue p_RealValue_ref = new RealValue(p_NumericRealValue);
			p_NumericRealValue.parent = p_RealValue_ref;
			Raise_RealValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RealValue.production_kind.g_RealValue_1, p_RealValue_ref);
			return p_RealValue_ref;
		}

		//
		// create syntax tree node associated with production
		// RealValue: SpecialRealValue

		//

		public RealValue RealValue_2 (SpecialRealValue p_SpecialRealValue)
		{
			RealValue p_RealValue_ref = new RealValue(p_SpecialRealValue);
			p_SpecialRealValue.parent = p_RealValue_ref;
			Raise_RealValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RealValue.production_kind.g_RealValue_2, p_RealValue_ref);
			return p_RealValue_ref;
		}
		#endregion
	};
}
