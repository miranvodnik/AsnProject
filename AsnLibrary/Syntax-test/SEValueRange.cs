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
	// class associated with syntax rule SEValueRange
	//

	[DataContract]
	public class	SEValueRange : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SEValueRange
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SEValueRange
		{
			g_SEValueRange_1 = 1,	// ValueRange

		};
		#endregion
		#region production markers associated with the syntax rule SEValueRange

		// markers associated with production: SEValueRange -> ValueRange

		public enum production_marker_1 : ushort
		{
			m_ValueRange,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SEValueRange

		// Constructor declaration(s) associated with production(s) of syntax rule SEValueRange

		//
		// Constructor associated with the following production(s)
		// SEValueRange -> ValueRange

		//

		public SEValueRange (ValueRange p_ValueRange) : base ((uint) ProductionID._SEValueRange_ID, (uint) production_kind.g_SEValueRange_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ValueRange = p_ValueRange;
		}

		public SEValueRange () { }

		// Copy constructor

		public SEValueRange (SEValueRange p_SEValueRange) : base (p_SEValueRange.id, p_SEValueRange.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SEValueRange.appInfo;
			switch ((production_kind) p_SEValueRange.kind)
			{
				case production_kind.g_SEValueRange_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ValueRange = (p_SEValueRange.m_ValueRange != null) ? new ValueRange (p_SEValueRange.m_ValueRange) : null) != null) m_ValueRange.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SEValueRange" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SEValueRange (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ValueRange?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SEValueRange

		// Content changing function(s) associated with production(s) of syntax rule SEValueRange

		//
		// Content changing function associated with following production(s)
		// SEValueRange -> ValueRange

		//

		public void change(ValueRange p_ValueRange)
		{
			_init ();
			this.kind = (uint) production_kind.g_SEValueRange_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ValueRange = p_ValueRange;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SEValueRange
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ValueRange != null) && m_ValueRange.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SEValueRange

		//
		// emit production tree node associated with any production of syntax rule SEValueRange
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SEValueRange_1:
					// emit syntax tree node associated with production
					// SEValueRange: ValueRange

					s += m_ValueRange.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SEValueRange
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SEValueRange (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SEValueRange_1:
					// emit syntax tree node associated with production
					// SEValueRange: ValueRange

					s += m_ValueRange.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SEValueRange

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SEValueRange with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SEValueRange.production_kind kind = (SEValueRange.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SEValueRange.production_kind.g_SEValueRange_1:
					// traverse syntax tree node associated with production
					// SEValueRange: ValueRange

						m_ValueRange.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ValueRange?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SEValueRange
		//

		public void _init ()
		{
			m_ValueRange = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SEValueRange

		// counter of all nodes associated with syntax rule SEValueRange
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SEValueRange
		[DataMember (Name = "m_ValueRange")] public ValueRange m_ValueRange { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SEValueRange

		// delegate function (callback) prototype associated with syntax rule SEValueRange
		public delegate bool SEValueRange_Callback (SyntaxTreeCallbackReason reason, SEValueRange.production_kind kind, SEValueRange p_SEValueRange);

		// event associated with syntax rule SEValueRange
		public event SEValueRange_Callback SEValueRange_Event;

		// event trigger associated with syntax rule SEValueRange
		public bool Raise_SEValueRange_Event (SyntaxTreeCallbackReason reason, SEValueRange.production_kind kind, SEValueRange p_SEValueRange)
		{
			bool? status = SEValueRange_Event?.Invoke (reason, kind, p_SEValueRange);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SEValueRange
		//
		// traverse syntax tree node associated with any production of syntax rule SEValueRange
		//

		public void Traverse (SEValueRange p_SEValueRange)
		{
			if (p_SEValueRange.isLocked())
				return;
			p_SEValueRange.dolock();
			SEValueRange.production_kind kind = (SEValueRange.production_kind) p_SEValueRange.kind;
			p_SEValueRange.turn_reset ();
			if (Raise_SEValueRange_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SEValueRange))
			switch (kind)
			{
				case SEValueRange.production_kind.g_SEValueRange_1:
					// traverse syntax tree node associated with production
					// SEValueRange: ValueRange

					if (Raise_SEValueRange_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SEValueRange))
						Traverse (p_SEValueRange.m_ValueRange);
					p_SEValueRange.turn_inc ();
					Raise_SEValueRange_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SEValueRange);
				break;
			}
			Raise_SEValueRange_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SEValueRange);
			p_SEValueRange.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SEValueRange
		//

		public void TraverseCommon (SEValueRange p_SEValueRange)
		{
			SEValueRange.production_kind kind = (SEValueRange.production_kind) p_SEValueRange.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SEValueRange))
			switch (kind)
			{
				case SEValueRange.production_kind.g_SEValueRange_1:
					// traverse syntax tree node associated with production
					// SEValueRange: ValueRange

						TraverseCommon (p_SEValueRange.m_ValueRange);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SEValueRange);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SEValueRange

		//
		// create syntax tree node associated with production
		// SEValueRange: ValueRange

		//

		public SEValueRange SEValueRange_1 (ValueRange p_ValueRange)
		{
			SEValueRange p_SEValueRange_ref = new SEValueRange(p_ValueRange);
			p_ValueRange.parent = p_SEValueRange_ref;
			Raise_SEValueRange_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SEValueRange.production_kind.g_SEValueRange_1, p_SEValueRange_ref);
			return p_SEValueRange_ref;
		}
		#endregion
	};
}
