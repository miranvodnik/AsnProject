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
	// class associated with syntax rule OT-Index
	//

	[DataContract]
	public class	OT_Index : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OT-Index
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OT-Index
		{
			g_OT_Index_1 = 1,	// Value

		};
		#endregion
		#region production markers associated with the syntax rule OT-Index

		// markers associated with production: OT-Index -> Value

		public enum production_marker_1 : ushort
		{
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OT-Index

		// Constructor declaration(s) associated with production(s) of syntax rule OT-Index

		//
		// Constructor associated with the following production(s)
		// OT-Index -> Value

		//

		public OT_Index (Value p_Value) : base ((uint) ProductionID._OT_Index_ID, (uint) production_kind.g_OT_Index_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Value = p_Value;
		}

		public OT_Index () { }

		// Copy constructor

		public OT_Index (OT_Index p_OT_Index) : base (p_OT_Index.id, p_OT_Index.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OT_Index.appInfo;
			switch ((production_kind) p_OT_Index.kind)
			{
				case production_kind.g_OT_Index_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Value = (p_OT_Index.m_Value != null) ? new Value (p_OT_Index.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "OT_Index" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OT_Index (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OT-Index

		// Content changing function(s) associated with production(s) of syntax rule OT-Index

		//
		// Content changing function associated with following production(s)
		// OT-Index -> Value

		//

		public void change(Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_Index_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OT-Index
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OT-Index

		//
		// emit production tree node associated with any production of syntax rule OT-Index
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_OT_Index_1:
					// emit syntax tree node associated with production
					// OT-Index: Value

					s += m_Value.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OT-Index
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "OT_Index (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_OT_Index_1:
					// emit syntax tree node associated with production
					// OT-Index: Value

					s += m_Value.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OT-Index

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OT-Index with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			OT_Index.production_kind kind = (OT_Index.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case OT_Index.production_kind.g_OT_Index_1:
					// traverse syntax tree node associated with production
					// OT-Index: Value

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
		// initialize object associated with syntax rule OT-Index
		//

		public void _init ()
		{
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OT-Index

		// counter of all nodes associated with syntax rule OT-Index
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OT-Index
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OT-Index

		// delegate function (callback) prototype associated with syntax rule OT-Index
		public delegate bool OT_Index_Callback (SyntaxTreeCallbackReason reason, OT_Index.production_kind kind, OT_Index p_OT_Index);

		// event associated with syntax rule OT-Index
		public event OT_Index_Callback OT_Index_Event;

		// event trigger associated with syntax rule OT-Index
		public bool Raise_OT_Index_Event (SyntaxTreeCallbackReason reason, OT_Index.production_kind kind, OT_Index p_OT_Index)
		{
			bool? status = OT_Index_Event?.Invoke (reason, kind, p_OT_Index);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OT-Index
		//
		// traverse syntax tree node associated with any production of syntax rule OT-Index
		//

		public void Traverse (OT_Index p_OT_Index)
		{
			if (p_OT_Index.isLocked())
				return;
			p_OT_Index.dolock();
			OT_Index.production_kind kind = (OT_Index.production_kind) p_OT_Index.kind;
			p_OT_Index.turn_reset ();
			if (Raise_OT_Index_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_OT_Index))
			switch (kind)
			{
				case OT_Index.production_kind.g_OT_Index_1:
					// traverse syntax tree node associated with production
					// OT-Index: Value

					if (Raise_OT_Index_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_Index))
						Traverse (p_OT_Index.m_Value);
					p_OT_Index.turn_inc ();
					Raise_OT_Index_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_Index);
				break;
			}
			Raise_OT_Index_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_OT_Index);
			p_OT_Index.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OT-Index
		//

		public void TraverseCommon (OT_Index p_OT_Index)
		{
			OT_Index.production_kind kind = (OT_Index.production_kind) p_OT_Index.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_OT_Index))
			switch (kind)
			{
				case OT_Index.production_kind.g_OT_Index_1:
					// traverse syntax tree node associated with production
					// OT-Index: Value

						TraverseCommon (p_OT_Index.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_OT_Index);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OT-Index

		//
		// create syntax tree node associated with production
		// OT-Index: Value

		//

		public OT_Index OT_Index_1 (Value p_Value)
		{
			OT_Index p_OT_Index_ref = new OT_Index(p_Value);
			p_Value.parent = p_OT_Index_ref;
			Raise_OT_Index_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_Index.production_kind.g_OT_Index_1, p_OT_Index_ref);
			return p_OT_Index_ref;
		}
		#endregion
	};
}
