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
	// class associated with syntax rule NT-Object
	//

	[DataContract]
	public class	NT_Object : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NT-Object
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NT-Object
		{
			g_NT_Object_1 = 1,	// Value

		};
		#endregion
		#region production markers associated with the syntax rule NT-Object

		// markers associated with production: NT-Object -> Value

		public enum production_marker_1 : ushort
		{
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NT-Object

		// Constructor declaration(s) associated with production(s) of syntax rule NT-Object

		//
		// Constructor associated with the following production(s)
		// NT-Object -> Value

		//

		public NT_Object (Value p_Value) : base ((uint) ProductionID._NT_Object_ID, (uint) production_kind.g_NT_Object_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Value = p_Value;
		}

		public NT_Object () { }

		// Copy constructor

		public NT_Object (NT_Object p_NT_Object) : base (p_NT_Object.id, p_NT_Object.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NT_Object.appInfo;
			switch ((production_kind) p_NT_Object.kind)
			{
				case production_kind.g_NT_Object_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Value = (p_NT_Object.m_Value != null) ? new Value (p_NT_Object.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NT_Object" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NT_Object (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NT-Object

		// Content changing function(s) associated with production(s) of syntax rule NT-Object

		//
		// Content changing function associated with following production(s)
		// NT-Object -> Value

		//

		public void change(Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_NT_Object_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NT-Object
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NT-Object

		//
		// emit production tree node associated with any production of syntax rule NT-Object
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NT_Object_1:
					// emit syntax tree node associated with production
					// NT-Object: Value

					s += m_Value.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NT-Object
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NT_Object (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NT_Object_1:
					// emit syntax tree node associated with production
					// NT-Object: Value

					s += m_Value.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NT-Object

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NT-Object with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NT_Object.production_kind kind = (NT_Object.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NT_Object.production_kind.g_NT_Object_1:
					// traverse syntax tree node associated with production
					// NT-Object: Value

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
		// initialize object associated with syntax rule NT-Object
		//

		public void _init ()
		{
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NT-Object

		// counter of all nodes associated with syntax rule NT-Object
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NT-Object
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NT-Object

		// delegate function (callback) prototype associated with syntax rule NT-Object
		public delegate bool NT_Object_Callback (SyntaxTreeCallbackReason reason, NT_Object.production_kind kind, NT_Object p_NT_Object);

		// event associated with syntax rule NT-Object
		public event NT_Object_Callback NT_Object_Event;

		// event trigger associated with syntax rule NT-Object
		public bool Raise_NT_Object_Event (SyntaxTreeCallbackReason reason, NT_Object.production_kind kind, NT_Object p_NT_Object)
		{
			bool? status = NT_Object_Event?.Invoke (reason, kind, p_NT_Object);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NT-Object
		//
		// traverse syntax tree node associated with any production of syntax rule NT-Object
		//

		public void Traverse (NT_Object p_NT_Object)
		{
			if (p_NT_Object.isLocked())
				return;
			p_NT_Object.dolock();
			NT_Object.production_kind kind = (NT_Object.production_kind) p_NT_Object.kind;
			p_NT_Object.turn_reset ();
			if (Raise_NT_Object_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NT_Object))
			switch (kind)
			{
				case NT_Object.production_kind.g_NT_Object_1:
					// traverse syntax tree node associated with production
					// NT-Object: Value

					if (Raise_NT_Object_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NT_Object))
						Traverse (p_NT_Object.m_Value);
					p_NT_Object.turn_inc ();
					Raise_NT_Object_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NT_Object);
				break;
			}
			Raise_NT_Object_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NT_Object);
			p_NT_Object.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NT-Object
		//

		public void TraverseCommon (NT_Object p_NT_Object)
		{
			NT_Object.production_kind kind = (NT_Object.production_kind) p_NT_Object.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NT_Object))
			switch (kind)
			{
				case NT_Object.production_kind.g_NT_Object_1:
					// traverse syntax tree node associated with production
					// NT-Object: Value

						TraverseCommon (p_NT_Object.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NT_Object);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NT-Object

		//
		// create syntax tree node associated with production
		// NT-Object: Value

		//

		public NT_Object NT_Object_1 (Value p_Value)
		{
			NT_Object p_NT_Object_ref = new NT_Object(p_Value);
			p_Value.parent = p_NT_Object_ref;
			Raise_NT_Object_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NT_Object.production_kind.g_NT_Object_1, p_NT_Object_ref);
			return p_NT_Object_ref;
		}
		#endregion
	};
}
