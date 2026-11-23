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
	// class associated with syntax rule DurationRange
	//

	[DataContract]
	public class	DurationRange : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DurationRange
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DurationRange
		{
			g_DurationRange_1 = 1,	// ValueRange

		};
		#endregion
		#region production markers associated with the syntax rule DurationRange

		// markers associated with production: DurationRange -> ValueRange

		public enum production_marker_1 : ushort
		{
			m_ValueRange,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DurationRange

		// Constructor declaration(s) associated with production(s) of syntax rule DurationRange

		//
		// Constructor associated with the following production(s)
		// DurationRange -> ValueRange

		//

		public DurationRange (ValueRange p_ValueRange) : base ((uint) ProductionID._DurationRange_ID, (uint) production_kind.g_DurationRange_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ValueRange = p_ValueRange;
		}

		public DurationRange () { }

		// Copy constructor

		public DurationRange (DurationRange p_DurationRange) : base (p_DurationRange.id, p_DurationRange.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DurationRange.appInfo;
			switch ((production_kind) p_DurationRange.kind)
			{
				case production_kind.g_DurationRange_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ValueRange = (p_DurationRange.m_ValueRange != null) ? new ValueRange (p_DurationRange.m_ValueRange) : null) != null) m_ValueRange.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DurationRange" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DurationRange (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ValueRange?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DurationRange

		// Content changing function(s) associated with production(s) of syntax rule DurationRange

		//
		// Content changing function associated with following production(s)
		// DurationRange -> ValueRange

		//

		public void change(ValueRange p_ValueRange)
		{
			_init ();
			this.kind = (uint) production_kind.g_DurationRange_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ValueRange = p_ValueRange;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DurationRange
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ValueRange != null) && m_ValueRange.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DurationRange

		//
		// emit production tree node associated with any production of syntax rule DurationRange
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DurationRange_1:
					// emit syntax tree node associated with production
					// DurationRange: ValueRange

					s += m_ValueRange.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DurationRange
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DurationRange (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DurationRange_1:
					// emit syntax tree node associated with production
					// DurationRange: ValueRange

					s += m_ValueRange.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DurationRange

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DurationRange with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DurationRange.production_kind kind = (DurationRange.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DurationRange.production_kind.g_DurationRange_1:
					// traverse syntax tree node associated with production
					// DurationRange: ValueRange

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
		// initialize object associated with syntax rule DurationRange
		//

		public void _init ()
		{
			m_ValueRange = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DurationRange

		// counter of all nodes associated with syntax rule DurationRange
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DurationRange
		[DataMember (Name = "m_ValueRange")] public ValueRange m_ValueRange { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DurationRange

		// delegate function (callback) prototype associated with syntax rule DurationRange
		public delegate bool DurationRange_Callback (SyntaxTreeCallbackReason reason, DurationRange.production_kind kind, DurationRange p_DurationRange);

		// event associated with syntax rule DurationRange
		public event DurationRange_Callback DurationRange_Event;

		// event trigger associated with syntax rule DurationRange
		public bool Raise_DurationRange_Event (SyntaxTreeCallbackReason reason, DurationRange.production_kind kind, DurationRange p_DurationRange)
		{
			bool? status = DurationRange_Event?.Invoke (reason, kind, p_DurationRange);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DurationRange
		//
		// traverse syntax tree node associated with any production of syntax rule DurationRange
		//

		public void Traverse (DurationRange p_DurationRange)
		{
			if (p_DurationRange.isLocked())
				return;
			p_DurationRange.dolock();
			DurationRange.production_kind kind = (DurationRange.production_kind) p_DurationRange.kind;
			p_DurationRange.turn_reset ();
			if (Raise_DurationRange_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DurationRange))
			switch (kind)
			{
				case DurationRange.production_kind.g_DurationRange_1:
					// traverse syntax tree node associated with production
					// DurationRange: ValueRange

					if (Raise_DurationRange_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DurationRange))
						Traverse (p_DurationRange.m_ValueRange);
					p_DurationRange.turn_inc ();
					Raise_DurationRange_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DurationRange);
				break;
			}
			Raise_DurationRange_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DurationRange);
			p_DurationRange.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DurationRange
		//

		public void TraverseCommon (DurationRange p_DurationRange)
		{
			DurationRange.production_kind kind = (DurationRange.production_kind) p_DurationRange.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DurationRange))
			switch (kind)
			{
				case DurationRange.production_kind.g_DurationRange_1:
					// traverse syntax tree node associated with production
					// DurationRange: ValueRange

						TraverseCommon (p_DurationRange.m_ValueRange);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DurationRange);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DurationRange

		//
		// create syntax tree node associated with production
		// DurationRange: ValueRange

		//

		public DurationRange DurationRange_1 (ValueRange p_ValueRange)
		{
			DurationRange p_DurationRange_ref = new DurationRange(p_ValueRange);
			p_ValueRange.parent = p_DurationRange_ref;
			Raise_DurationRange_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DurationRange.production_kind.g_DurationRange_1, p_DurationRange_ref);
			return p_DurationRange_ref;
		}
		#endregion
	};
}
