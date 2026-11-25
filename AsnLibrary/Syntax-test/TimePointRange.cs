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
	// class associated with syntax rule TimePointRange
	//

	[DataContract]
	public class	TimePointRange : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TimePointRange
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TimePointRange
		{
			g_TimePointRange_1 = 1,	// ValueRange

		};
		#endregion
		#region production markers associated with the syntax rule TimePointRange

		// markers associated with production: TimePointRange -> ValueRange

		public enum production_marker_1 : ushort
		{
			m_ValueRange,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TimePointRange

		// Constructor declaration(s) associated with production(s) of syntax rule TimePointRange

		//
		// Constructor associated with the following production(s)
		// TimePointRange -> ValueRange

		//

		public TimePointRange (ValueRange p_ValueRange) : base ((uint) ProductionID._TimePointRange_ID, (uint) production_kind.g_TimePointRange_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ValueRange = p_ValueRange;
		}

		public TimePointRange () { }

		// Copy constructor

		public TimePointRange (TimePointRange p_TimePointRange) : base (p_TimePointRange.id, p_TimePointRange.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TimePointRange.appInfo;
			switch ((production_kind) p_TimePointRange.kind)
			{
				case production_kind.g_TimePointRange_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ValueRange = (p_TimePointRange.m_ValueRange != null) ? new ValueRange (p_TimePointRange.m_ValueRange) : null) != null) m_ValueRange.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TimePointRange" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TimePointRange (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ValueRange?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TimePointRange

		// Content changing function(s) associated with production(s) of syntax rule TimePointRange

		//
		// Content changing function associated with following production(s)
		// TimePointRange -> ValueRange

		//

		public void change(ValueRange p_ValueRange)
		{
			_init ();
			this.kind = (uint) production_kind.g_TimePointRange_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ValueRange = p_ValueRange;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TimePointRange
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ValueRange != null) && m_ValueRange.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TimePointRange

		//
		// emit production tree node associated with any production of syntax rule TimePointRange
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TimePointRange_1:
					// emit syntax tree node associated with production
					// TimePointRange: ValueRange

					s += m_ValueRange.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TimePointRange
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TimePointRange (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TimePointRange_1:
					// emit syntax tree node associated with production
					// TimePointRange: ValueRange

					s += m_ValueRange.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TimePointRange

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TimePointRange with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TimePointRange.production_kind kind = (TimePointRange.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TimePointRange.production_kind.g_TimePointRange_1:
					// traverse syntax tree node associated with production
					// TimePointRange: ValueRange

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
		// initialize object associated with syntax rule TimePointRange
		//

		public void _init ()
		{
			m_ValueRange = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TimePointRange

		// counter of all nodes associated with syntax rule TimePointRange
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TimePointRange
		[DataMember (Name = "m_ValueRange")] public ValueRange m_ValueRange { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TimePointRange

		// delegate function (callback) prototype associated with syntax rule TimePointRange
		public delegate bool TimePointRange_Callback (SyntaxTreeCallbackReason reason, TimePointRange.production_kind kind, TimePointRange p_TimePointRange);

		// event associated with syntax rule TimePointRange
		public event TimePointRange_Callback TimePointRange_Event;

		// event trigger associated with syntax rule TimePointRange
		public bool Raise_TimePointRange_Event (SyntaxTreeCallbackReason reason, TimePointRange.production_kind kind, TimePointRange p_TimePointRange)
		{
			bool? status = TimePointRange_Event?.Invoke (reason, kind, p_TimePointRange);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TimePointRange
		//
		// traverse syntax tree node associated with any production of syntax rule TimePointRange
		//

		public void Traverse (TimePointRange p_TimePointRange)
		{
			if (p_TimePointRange.isLocked())
				return;
			p_TimePointRange.dolock();
			TimePointRange.production_kind kind = (TimePointRange.production_kind) p_TimePointRange.kind;
			p_TimePointRange.turn_reset ();
			if (Raise_TimePointRange_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TimePointRange))
			switch (kind)
			{
				case TimePointRange.production_kind.g_TimePointRange_1:
					// traverse syntax tree node associated with production
					// TimePointRange: ValueRange

					if (Raise_TimePointRange_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TimePointRange))
						Traverse (p_TimePointRange.m_ValueRange);
					p_TimePointRange.turn_inc ();
					Raise_TimePointRange_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TimePointRange);
				break;
			}
			Raise_TimePointRange_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TimePointRange);
			p_TimePointRange.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TimePointRange
		//

		public void TraverseCommon (TimePointRange p_TimePointRange)
		{
			TimePointRange.production_kind kind = (TimePointRange.production_kind) p_TimePointRange.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TimePointRange))
			switch (kind)
			{
				case TimePointRange.production_kind.g_TimePointRange_1:
					// traverse syntax tree node associated with production
					// TimePointRange: ValueRange

						TraverseCommon (p_TimePointRange.m_ValueRange);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TimePointRange);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TimePointRange

		//
		// create syntax tree node associated with production
		// TimePointRange: ValueRange

		//

		public TimePointRange TimePointRange_1 (ValueRange p_ValueRange)
		{
			TimePointRange p_TimePointRange_ref = new TimePointRange(p_ValueRange);
			p_ValueRange.parent = p_TimePointRange_ref;
			Raise_TimePointRange_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TimePointRange.production_kind.g_TimePointRange_1, p_TimePointRange_ref);
			return p_TimePointRange_ref;
		}
		#endregion
	};
}
