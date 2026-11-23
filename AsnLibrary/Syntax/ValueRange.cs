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
	// class associated with syntax rule ValueRange
	//

	[DataContract]
	public class	ValueRange : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ValueRange
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ValueRange
		{
			g_ValueRange_1 = 1,	// LowerEndpoint "." "." UpperEndpoint

		};
		#endregion
		#region production markers associated with the syntax rule ValueRange

		// markers associated with production: ValueRange -> LowerEndpoint "." "." UpperEndpoint

		public enum production_marker_1 : ushort
		{
			m_LowerEndpoint,
			m_UpperEndpoint,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ValueRange

		// Constructor declaration(s) associated with production(s) of syntax rule ValueRange

		//
		// Constructor associated with the following production(s)
		// ValueRange -> LowerEndpoint "." "." UpperEndpoint

		//

		public ValueRange (LowerEndpoint p_LowerEndpoint, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, UpperEndpoint p_UpperEndpoint) : base ((uint) ProductionID._ValueRange_ID, (uint) production_kind.g_ValueRange_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_LowerEndpoint = p_LowerEndpoint;
			children[1] = m_dot = p_token;
			children[2] = m_dot_1 = p_token_1;
			children[3] = m_UpperEndpoint = p_UpperEndpoint;
		}

		public ValueRange () { }

		// Copy constructor

		public ValueRange (ValueRange p_ValueRange) : base (p_ValueRange.id, p_ValueRange.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ValueRange.appInfo;
			switch ((production_kind) p_ValueRange.kind)
			{
				case production_kind.g_ValueRange_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_LowerEndpoint = (p_ValueRange.m_LowerEndpoint != null) ? new LowerEndpoint (p_ValueRange.m_LowerEndpoint) : null) != null) m_LowerEndpoint.parent = this;
					if ((children [1] = m_dot = (p_ValueRange.m_dot != null) ? new SyntaxTreeToken (p_ValueRange.m_dot) : null) != null) m_dot.parent = this;
					if ((children [2] = m_dot_1 = (p_ValueRange.m_dot_1 != null) ? new SyntaxTreeToken (p_ValueRange.m_dot_1) : null) != null) m_dot_1.parent = this;
					if ((children [3] = m_UpperEndpoint = (p_ValueRange.m_UpperEndpoint != null) ? new UpperEndpoint (p_ValueRange.m_UpperEndpoint) : null) != null) m_UpperEndpoint.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ValueRange" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ValueRange (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_LowerEndpoint?.Dispose ();
			m_dot?.Dispose ();
			m_dot_1?.Dispose ();
			m_UpperEndpoint?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ValueRange

		// Content changing function(s) associated with production(s) of syntax rule ValueRange

		//
		// Content changing function associated with following production(s)
		// ValueRange -> LowerEndpoint "." "." UpperEndpoint

		//

		public void change(LowerEndpoint p_LowerEndpoint, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, UpperEndpoint p_UpperEndpoint)
		{
			_init ();
			this.kind = (uint) production_kind.g_ValueRange_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_LowerEndpoint = p_LowerEndpoint;
			children [1] = m_dot = p_token;
			children [2] = m_dot_1 = p_token_1;
			children [3] = m_UpperEndpoint = p_UpperEndpoint;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ValueRange
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_LowerEndpoint != null) && m_LowerEndpoint.checkInclusion (element) ||
				(m_dot != null) && m_dot.checkInclusion (element) ||
				(m_dot_1 != null) && m_dot_1.checkInclusion (element) ||
				(m_UpperEndpoint != null) && m_UpperEndpoint.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ValueRange

		//
		// emit production tree node associated with any production of syntax rule ValueRange
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ValueRange_1:
					// emit syntax tree node associated with production
					// ValueRange: LowerEndpoint "." "." UpperEndpoint

					s += m_LowerEndpoint.Emit (depth - 1);
					s += " ";
					s += m_dot.Emit (depth - 1);
					s += " ";
					s += m_dot_1.Emit (depth - 1);
					s += " ";
					s += m_UpperEndpoint.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ValueRange
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ValueRange (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ValueRange_1:
					// emit syntax tree node associated with production
					// ValueRange: LowerEndpoint "." "." UpperEndpoint

					s += m_LowerEndpoint.EmitProductionTree (depth - 1);
					s += ' ';
					s += "dot";
					s += ' ';
					s += "dot";
					s += ' ';
					s += m_UpperEndpoint.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ValueRange

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ValueRange with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ValueRange.production_kind kind = (ValueRange.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ValueRange.production_kind.g_ValueRange_1:
					// traverse syntax tree node associated with production
					// ValueRange: LowerEndpoint "." "." UpperEndpoint

						m_LowerEndpoint.Visit (visitor, appData);
						m_dot.Visit (visitor, appData);
						m_dot_1.Visit (visitor, appData);
						m_UpperEndpoint.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_LowerEndpoint?.reparent (this);
			m_dot?.reparent (this);
			m_dot_1?.reparent (this);

			m_UpperEndpoint?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ValueRange
		//

		public void _init ()
		{
			m_LowerEndpoint = null;
			m_dot = null;
			m_dot_1 = null;
			m_UpperEndpoint = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ValueRange

		// counter of all nodes associated with syntax rule ValueRange
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ValueRange
		[DataMember (Name = "m_LowerEndpoint")] public LowerEndpoint m_LowerEndpoint { get; private set; }
		[DataMember (Name = "m_dot")] public SyntaxTreeToken m_dot { get; private set; }
		[DataMember (Name = "m_dot_1")] public SyntaxTreeToken m_dot_1 { get; private set; }
		[DataMember (Name = "m_UpperEndpoint")] public UpperEndpoint m_UpperEndpoint { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ValueRange

		// delegate function (callback) prototype associated with syntax rule ValueRange
		public delegate bool ValueRange_Callback (SyntaxTreeCallbackReason reason, ValueRange.production_kind kind, ValueRange p_ValueRange);

		// event associated with syntax rule ValueRange
		public event ValueRange_Callback ValueRange_Event;

		// event trigger associated with syntax rule ValueRange
		public bool Raise_ValueRange_Event (SyntaxTreeCallbackReason reason, ValueRange.production_kind kind, ValueRange p_ValueRange)
		{
			bool? status = ValueRange_Event?.Invoke (reason, kind, p_ValueRange);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ValueRange
		//
		// traverse syntax tree node associated with any production of syntax rule ValueRange
		//

		public void Traverse (ValueRange p_ValueRange)
		{
			if (p_ValueRange.isLocked())
				return;
			p_ValueRange.dolock();
			ValueRange.production_kind kind = (ValueRange.production_kind) p_ValueRange.kind;
			p_ValueRange.turn_reset ();
			if (Raise_ValueRange_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ValueRange))
			switch (kind)
			{
				case ValueRange.production_kind.g_ValueRange_1:
					// traverse syntax tree node associated with production
					// ValueRange: LowerEndpoint "." "." UpperEndpoint

					if (Raise_ValueRange_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueRange))
						Traverse (p_ValueRange.m_LowerEndpoint);
					p_ValueRange.turn_inc ();
					if (Raise_ValueRange_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueRange))
						Traverse (p_ValueRange.m_UpperEndpoint);
					p_ValueRange.turn_inc ();
					Raise_ValueRange_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueRange);
				break;
			}
			Raise_ValueRange_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ValueRange);
			p_ValueRange.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ValueRange
		//

		public void TraverseCommon (ValueRange p_ValueRange)
		{
			ValueRange.production_kind kind = (ValueRange.production_kind) p_ValueRange.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ValueRange))
			switch (kind)
			{
				case ValueRange.production_kind.g_ValueRange_1:
					// traverse syntax tree node associated with production
					// ValueRange: LowerEndpoint "." "." UpperEndpoint

						TraverseCommon (p_ValueRange.m_LowerEndpoint);
						TraverseCommon (p_ValueRange.m_dot);
						TraverseCommon (p_ValueRange.m_dot_1);
						TraverseCommon (p_ValueRange.m_UpperEndpoint);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ValueRange);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ValueRange

		//
		// create syntax tree node associated with production
		// ValueRange: LowerEndpoint "." "." UpperEndpoint

		//

		public ValueRange ValueRange_1 (LowerEndpoint p_LowerEndpoint, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, UpperEndpoint p_UpperEndpoint)
		{
			ValueRange p_ValueRange_ref = new ValueRange(p_LowerEndpoint, p_token, p_token_1, p_UpperEndpoint);
			p_LowerEndpoint.parent = p_ValueRange_ref;
			p_token.parent = p_ValueRange_ref;
			p_token_1.parent = p_ValueRange_ref;
			p_UpperEndpoint.parent = p_ValueRange_ref;
			Raise_ValueRange_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ValueRange.production_kind.g_ValueRange_1, p_ValueRange_ref);
			return p_ValueRange_ref;
		}
		#endregion
	};
}
