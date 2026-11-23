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
	// class associated with syntax rule RecurrenceRange
	//

	[DataContract]
	public class	RecurrenceRange : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule RecurrenceRange
		public enum production_kind : ushort	// enumerated production(s) of syntax rule RecurrenceRange
		{
			g_RecurrenceRange_1 = 1,	// ValueRange

		};
		#endregion
		#region production markers associated with the syntax rule RecurrenceRange

		// markers associated with production: RecurrenceRange -> ValueRange

		public enum production_marker_1 : ushort
		{
			m_ValueRange,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule RecurrenceRange

		// Constructor declaration(s) associated with production(s) of syntax rule RecurrenceRange

		//
		// Constructor associated with the following production(s)
		// RecurrenceRange -> ValueRange

		//

		public RecurrenceRange (ValueRange p_ValueRange) : base ((uint) ProductionID._RecurrenceRange_ID, (uint) production_kind.g_RecurrenceRange_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ValueRange = p_ValueRange;
		}

		public RecurrenceRange () { }

		// Copy constructor

		public RecurrenceRange (RecurrenceRange p_RecurrenceRange) : base (p_RecurrenceRange.id, p_RecurrenceRange.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_RecurrenceRange.appInfo;
			switch ((production_kind) p_RecurrenceRange.kind)
			{
				case production_kind.g_RecurrenceRange_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ValueRange = (p_RecurrenceRange.m_ValueRange != null) ? new ValueRange (p_RecurrenceRange.m_ValueRange) : null) != null) m_ValueRange.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "RecurrenceRange" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new RecurrenceRange (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ValueRange?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule RecurrenceRange

		// Content changing function(s) associated with production(s) of syntax rule RecurrenceRange

		//
		// Content changing function associated with following production(s)
		// RecurrenceRange -> ValueRange

		//

		public void change(ValueRange p_ValueRange)
		{
			_init ();
			this.kind = (uint) production_kind.g_RecurrenceRange_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ValueRange = p_ValueRange;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule RecurrenceRange
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ValueRange != null) && m_ValueRange.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule RecurrenceRange

		//
		// emit production tree node associated with any production of syntax rule RecurrenceRange
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_RecurrenceRange_1:
					// emit syntax tree node associated with production
					// RecurrenceRange: ValueRange

					s += m_ValueRange.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule RecurrenceRange
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "RecurrenceRange (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_RecurrenceRange_1:
					// emit syntax tree node associated with production
					// RecurrenceRange: ValueRange

					s += m_ValueRange.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule RecurrenceRange

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule RecurrenceRange with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			RecurrenceRange.production_kind kind = (RecurrenceRange.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case RecurrenceRange.production_kind.g_RecurrenceRange_1:
					// traverse syntax tree node associated with production
					// RecurrenceRange: ValueRange

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
		// initialize object associated with syntax rule RecurrenceRange
		//

		public void _init ()
		{
			m_ValueRange = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule RecurrenceRange

		// counter of all nodes associated with syntax rule RecurrenceRange
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule RecurrenceRange
		[DataMember (Name = "m_ValueRange")] public ValueRange m_ValueRange { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule RecurrenceRange

		// delegate function (callback) prototype associated with syntax rule RecurrenceRange
		public delegate bool RecurrenceRange_Callback (SyntaxTreeCallbackReason reason, RecurrenceRange.production_kind kind, RecurrenceRange p_RecurrenceRange);

		// event associated with syntax rule RecurrenceRange
		public event RecurrenceRange_Callback RecurrenceRange_Event;

		// event trigger associated with syntax rule RecurrenceRange
		public bool Raise_RecurrenceRange_Event (SyntaxTreeCallbackReason reason, RecurrenceRange.production_kind kind, RecurrenceRange p_RecurrenceRange)
		{
			bool? status = RecurrenceRange_Event?.Invoke (reason, kind, p_RecurrenceRange);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule RecurrenceRange
		//
		// traverse syntax tree node associated with any production of syntax rule RecurrenceRange
		//

		public void Traverse (RecurrenceRange p_RecurrenceRange)
		{
			if (p_RecurrenceRange.isLocked())
				return;
			p_RecurrenceRange.dolock();
			RecurrenceRange.production_kind kind = (RecurrenceRange.production_kind) p_RecurrenceRange.kind;
			p_RecurrenceRange.turn_reset ();
			if (Raise_RecurrenceRange_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_RecurrenceRange))
			switch (kind)
			{
				case RecurrenceRange.production_kind.g_RecurrenceRange_1:
					// traverse syntax tree node associated with production
					// RecurrenceRange: ValueRange

					if (Raise_RecurrenceRange_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RecurrenceRange))
						Traverse (p_RecurrenceRange.m_ValueRange);
					p_RecurrenceRange.turn_inc ();
					Raise_RecurrenceRange_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RecurrenceRange);
				break;
			}
			Raise_RecurrenceRange_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_RecurrenceRange);
			p_RecurrenceRange.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule RecurrenceRange
		//

		public void TraverseCommon (RecurrenceRange p_RecurrenceRange)
		{
			RecurrenceRange.production_kind kind = (RecurrenceRange.production_kind) p_RecurrenceRange.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_RecurrenceRange))
			switch (kind)
			{
				case RecurrenceRange.production_kind.g_RecurrenceRange_1:
					// traverse syntax tree node associated with production
					// RecurrenceRange: ValueRange

						TraverseCommon (p_RecurrenceRange.m_ValueRange);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_RecurrenceRange);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule RecurrenceRange

		//
		// create syntax tree node associated with production
		// RecurrenceRange: ValueRange

		//

		public RecurrenceRange RecurrenceRange_1 (ValueRange p_ValueRange)
		{
			RecurrenceRange p_RecurrenceRange_ref = new RecurrenceRange(p_ValueRange);
			p_ValueRange.parent = p_RecurrenceRange_ref;
			Raise_RecurrenceRange_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RecurrenceRange.production_kind.g_RecurrenceRange_1, p_RecurrenceRange_ref);
			return p_RecurrenceRange_ref;
		}
		#endregion
	};
}
