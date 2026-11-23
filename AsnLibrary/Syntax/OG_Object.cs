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
	// class associated with syntax rule OG-Object
	//

	[DataContract]
	public class	OG_Object : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OG-Object
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OG-Object
		{
			g_OG_Object_1 = 1,	// Value

		};
		#endregion
		#region production markers associated with the syntax rule OG-Object

		// markers associated with production: OG-Object -> Value

		public enum production_marker_1 : ushort
		{
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OG-Object

		// Constructor declaration(s) associated with production(s) of syntax rule OG-Object

		//
		// Constructor associated with the following production(s)
		// OG-Object -> Value

		//

		public OG_Object (Value p_Value) : base ((uint) ProductionID._OG_Object_ID, (uint) production_kind.g_OG_Object_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Value = p_Value;
		}

		public OG_Object () { }

		// Copy constructor

		public OG_Object (OG_Object p_OG_Object) : base (p_OG_Object.id, p_OG_Object.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OG_Object.appInfo;
			switch ((production_kind) p_OG_Object.kind)
			{
				case production_kind.g_OG_Object_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Value = (p_OG_Object.m_Value != null) ? new Value (p_OG_Object.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "OG_Object" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OG_Object (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OG-Object

		// Content changing function(s) associated with production(s) of syntax rule OG-Object

		//
		// Content changing function associated with following production(s)
		// OG-Object -> Value

		//

		public void change(Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_OG_Object_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OG-Object
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OG-Object

		//
		// emit production tree node associated with any production of syntax rule OG-Object
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_OG_Object_1:
					// emit syntax tree node associated with production
					// OG-Object: Value

					s += m_Value.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OG-Object
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "OG_Object (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_OG_Object_1:
					// emit syntax tree node associated with production
					// OG-Object: Value

					s += m_Value.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OG-Object

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OG-Object with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			OG_Object.production_kind kind = (OG_Object.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case OG_Object.production_kind.g_OG_Object_1:
					// traverse syntax tree node associated with production
					// OG-Object: Value

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
		// initialize object associated with syntax rule OG-Object
		//

		public void _init ()
		{
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OG-Object

		// counter of all nodes associated with syntax rule OG-Object
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OG-Object
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OG-Object

		// delegate function (callback) prototype associated with syntax rule OG-Object
		public delegate bool OG_Object_Callback (SyntaxTreeCallbackReason reason, OG_Object.production_kind kind, OG_Object p_OG_Object);

		// event associated with syntax rule OG-Object
		public event OG_Object_Callback OG_Object_Event;

		// event trigger associated with syntax rule OG-Object
		public bool Raise_OG_Object_Event (SyntaxTreeCallbackReason reason, OG_Object.production_kind kind, OG_Object p_OG_Object)
		{
			bool? status = OG_Object_Event?.Invoke (reason, kind, p_OG_Object);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OG-Object
		//
		// traverse syntax tree node associated with any production of syntax rule OG-Object
		//

		public void Traverse (OG_Object p_OG_Object)
		{
			if (p_OG_Object.isLocked())
				return;
			p_OG_Object.dolock();
			OG_Object.production_kind kind = (OG_Object.production_kind) p_OG_Object.kind;
			p_OG_Object.turn_reset ();
			if (Raise_OG_Object_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_OG_Object))
			switch (kind)
			{
				case OG_Object.production_kind.g_OG_Object_1:
					// traverse syntax tree node associated with production
					// OG-Object: Value

					if (Raise_OG_Object_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OG_Object))
						Traverse (p_OG_Object.m_Value);
					p_OG_Object.turn_inc ();
					Raise_OG_Object_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OG_Object);
				break;
			}
			Raise_OG_Object_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_OG_Object);
			p_OG_Object.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OG-Object
		//

		public void TraverseCommon (OG_Object p_OG_Object)
		{
			OG_Object.production_kind kind = (OG_Object.production_kind) p_OG_Object.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_OG_Object))
			switch (kind)
			{
				case OG_Object.production_kind.g_OG_Object_1:
					// traverse syntax tree node associated with production
					// OG-Object: Value

						TraverseCommon (p_OG_Object.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_OG_Object);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OG-Object

		//
		// create syntax tree node associated with production
		// OG-Object: Value

		//

		public OG_Object OG_Object_1 (Value p_Value)
		{
			OG_Object p_OG_Object_ref = new OG_Object(p_Value);
			p_Value.parent = p_OG_Object_ref;
			Raise_OG_Object_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OG_Object.production_kind.g_OG_Object_1, p_OG_Object_ref);
			return p_OG_Object_ref;
		}
		#endregion
	};
}
