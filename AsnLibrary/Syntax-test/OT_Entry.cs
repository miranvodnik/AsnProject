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
	// class associated with syntax rule OT-Entry
	//

	[DataContract]
	public class	OT_Entry : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OT-Entry
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OT-Entry
		{
			g_OT_Entry_1 = 1,	// Value

		};
		#endregion
		#region production markers associated with the syntax rule OT-Entry

		// markers associated with production: OT-Entry -> Value

		public enum production_marker_1 : ushort
		{
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OT-Entry

		// Constructor declaration(s) associated with production(s) of syntax rule OT-Entry

		//
		// Constructor associated with the following production(s)
		// OT-Entry -> Value

		//

		public OT_Entry (Value p_Value) : base ((uint) ProductionID._OT_Entry_ID, (uint) production_kind.g_OT_Entry_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Value = p_Value;
		}

		public OT_Entry () { }

		// Copy constructor

		public OT_Entry (OT_Entry p_OT_Entry) : base (p_OT_Entry.id, p_OT_Entry.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OT_Entry.appInfo;
			switch ((production_kind) p_OT_Entry.kind)
			{
				case production_kind.g_OT_Entry_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Value = (p_OT_Entry.m_Value != null) ? new Value (p_OT_Entry.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "OT_Entry" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OT_Entry (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OT-Entry

		// Content changing function(s) associated with production(s) of syntax rule OT-Entry

		//
		// Content changing function associated with following production(s)
		// OT-Entry -> Value

		//

		public void change(Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_Entry_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OT-Entry
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OT-Entry

		//
		// emit production tree node associated with any production of syntax rule OT-Entry
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_OT_Entry_1:
					// emit syntax tree node associated with production
					// OT-Entry: Value

					s += m_Value.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OT-Entry
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "OT_Entry (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_OT_Entry_1:
					// emit syntax tree node associated with production
					// OT-Entry: Value

					s += m_Value.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OT-Entry

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OT-Entry with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			OT_Entry.production_kind kind = (OT_Entry.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case OT_Entry.production_kind.g_OT_Entry_1:
					// traverse syntax tree node associated with production
					// OT-Entry: Value

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
		// initialize object associated with syntax rule OT-Entry
		//

		public void _init ()
		{
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OT-Entry

		// counter of all nodes associated with syntax rule OT-Entry
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OT-Entry
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OT-Entry

		// delegate function (callback) prototype associated with syntax rule OT-Entry
		public delegate bool OT_Entry_Callback (SyntaxTreeCallbackReason reason, OT_Entry.production_kind kind, OT_Entry p_OT_Entry);

		// event associated with syntax rule OT-Entry
		public event OT_Entry_Callback OT_Entry_Event;

		// event trigger associated with syntax rule OT-Entry
		public bool Raise_OT_Entry_Event (SyntaxTreeCallbackReason reason, OT_Entry.production_kind kind, OT_Entry p_OT_Entry)
		{
			bool? status = OT_Entry_Event?.Invoke (reason, kind, p_OT_Entry);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OT-Entry
		//
		// traverse syntax tree node associated with any production of syntax rule OT-Entry
		//

		public void Traverse (OT_Entry p_OT_Entry)
		{
			if (p_OT_Entry.isLocked())
				return;
			p_OT_Entry.dolock();
			OT_Entry.production_kind kind = (OT_Entry.production_kind) p_OT_Entry.kind;
			p_OT_Entry.turn_reset ();
			if (Raise_OT_Entry_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_OT_Entry))
			switch (kind)
			{
				case OT_Entry.production_kind.g_OT_Entry_1:
					// traverse syntax tree node associated with production
					// OT-Entry: Value

					if (Raise_OT_Entry_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_Entry))
						Traverse (p_OT_Entry.m_Value);
					p_OT_Entry.turn_inc ();
					Raise_OT_Entry_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_Entry);
				break;
			}
			Raise_OT_Entry_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_OT_Entry);
			p_OT_Entry.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OT-Entry
		//

		public void TraverseCommon (OT_Entry p_OT_Entry)
		{
			OT_Entry.production_kind kind = (OT_Entry.production_kind) p_OT_Entry.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_OT_Entry))
			switch (kind)
			{
				case OT_Entry.production_kind.g_OT_Entry_1:
					// traverse syntax tree node associated with production
					// OT-Entry: Value

						TraverseCommon (p_OT_Entry.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_OT_Entry);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OT-Entry

		//
		// create syntax tree node associated with production
		// OT-Entry: Value

		//

		public OT_Entry OT_Entry_1 (Value p_Value)
		{
			OT_Entry p_OT_Entry_ref = new OT_Entry(p_Value);
			p_Value.parent = p_OT_Entry_ref;
			Raise_OT_Entry_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_Entry.production_kind.g_OT_Entry_1, p_OT_Entry_ref);
			return p_OT_Entry_ref;
		}
		#endregion
	};
}
