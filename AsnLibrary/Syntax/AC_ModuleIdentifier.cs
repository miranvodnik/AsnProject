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
	// class associated with syntax rule AC-ModuleIdentifier
	//

	[DataContract]
	public class	AC_ModuleIdentifier : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-ModuleIdentifier
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-ModuleIdentifier
		{
			g_AC_ModuleIdentifier_1 = 1,	// Value

			g_AC_ModuleIdentifier_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule AC-ModuleIdentifier

		// markers associated with production: AC-ModuleIdentifier -> Value

		public enum production_marker_1 : ushort
		{
			m_Value,
			final
		};

		// markers associated with production: AC-ModuleIdentifier -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-ModuleIdentifier

		// Constructor declaration(s) associated with production(s) of syntax rule AC-ModuleIdentifier

		//
		// Constructor associated with the following production(s)
		// AC-ModuleIdentifier -> Value

		//

		public AC_ModuleIdentifier (Value p_Value) : base ((uint) ProductionID._AC_ModuleIdentifier_ID, (uint) production_kind.g_AC_ModuleIdentifier_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Value = p_Value;
		}

		//
		// Constructor associated with the following production(s)
		// AC-ModuleIdentifier -> %empty

		//

		public AC_ModuleIdentifier () : base ((uint) ProductionID._AC_ModuleIdentifier_ID, (uint) production_kind.g_AC_ModuleIdentifier_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public AC_ModuleIdentifier (AC_ModuleIdentifier p_AC_ModuleIdentifier) : base (p_AC_ModuleIdentifier.id, p_AC_ModuleIdentifier.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_ModuleIdentifier.appInfo;
			switch ((production_kind) p_AC_ModuleIdentifier.kind)
			{
				case production_kind.g_AC_ModuleIdentifier_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Value = (p_AC_ModuleIdentifier.m_Value != null) ? new Value (p_AC_ModuleIdentifier.m_Value) : null) != null) m_Value.parent = this;
					break;
				case production_kind.g_AC_ModuleIdentifier_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "AC_ModuleIdentifier" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_ModuleIdentifier (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-ModuleIdentifier

		// Content changing function(s) associated with production(s) of syntax rule AC-ModuleIdentifier

		//
		// Content changing function associated with following production(s)
		// AC-ModuleIdentifier -> Value

		//

		public void change(Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_ModuleIdentifier_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AC-ModuleIdentifier -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_ModuleIdentifier_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-ModuleIdentifier
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-ModuleIdentifier

		//
		// emit production tree node associated with any production of syntax rule AC-ModuleIdentifier
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_ModuleIdentifier_1:
					// emit syntax tree node associated with production
					// AC-ModuleIdentifier: Value

					s += m_Value.Emit (depth - 1);
				break;
				case production_kind.g_AC_ModuleIdentifier_2:
					// emit syntax tree node associated with production
					// AC-ModuleIdentifier: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-ModuleIdentifier
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_ModuleIdentifier (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_ModuleIdentifier_1:
					// emit syntax tree node associated with production
					// AC-ModuleIdentifier: Value

					s += m_Value.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_AC_ModuleIdentifier_2:
					// emit syntax tree node associated with production
					// AC-ModuleIdentifier: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-ModuleIdentifier

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-ModuleIdentifier with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_ModuleIdentifier.production_kind kind = (AC_ModuleIdentifier.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_ModuleIdentifier.production_kind.g_AC_ModuleIdentifier_1:
					// traverse syntax tree node associated with production
					// AC-ModuleIdentifier: Value

						m_Value.Visit (visitor, appData);
				break;
				case AC_ModuleIdentifier.production_kind.g_AC_ModuleIdentifier_2:
					// traverse syntax tree node associated with production
					// AC-ModuleIdentifier: %empty

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
		// initialize object associated with syntax rule AC-ModuleIdentifier
		//

		public void _init ()
		{
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-ModuleIdentifier

		// counter of all nodes associated with syntax rule AC-ModuleIdentifier
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-ModuleIdentifier
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-ModuleIdentifier

		// delegate function (callback) prototype associated with syntax rule AC-ModuleIdentifier
		public delegate bool AC_ModuleIdentifier_Callback (SyntaxTreeCallbackReason reason, AC_ModuleIdentifier.production_kind kind, AC_ModuleIdentifier p_AC_ModuleIdentifier);

		// event associated with syntax rule AC-ModuleIdentifier
		public event AC_ModuleIdentifier_Callback AC_ModuleIdentifier_Event;

		// event trigger associated with syntax rule AC-ModuleIdentifier
		public bool Raise_AC_ModuleIdentifier_Event (SyntaxTreeCallbackReason reason, AC_ModuleIdentifier.production_kind kind, AC_ModuleIdentifier p_AC_ModuleIdentifier)
		{
			bool? status = AC_ModuleIdentifier_Event?.Invoke (reason, kind, p_AC_ModuleIdentifier);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-ModuleIdentifier
		//
		// traverse syntax tree node associated with any production of syntax rule AC-ModuleIdentifier
		//

		public void Traverse (AC_ModuleIdentifier p_AC_ModuleIdentifier)
		{
			if (p_AC_ModuleIdentifier.isLocked())
				return;
			p_AC_ModuleIdentifier.dolock();
			AC_ModuleIdentifier.production_kind kind = (AC_ModuleIdentifier.production_kind) p_AC_ModuleIdentifier.kind;
			p_AC_ModuleIdentifier.turn_reset ();
			if (Raise_AC_ModuleIdentifier_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_ModuleIdentifier))
			switch (kind)
			{
				case AC_ModuleIdentifier.production_kind.g_AC_ModuleIdentifier_1:
					// traverse syntax tree node associated with production
					// AC-ModuleIdentifier: Value

					if (Raise_AC_ModuleIdentifier_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_ModuleIdentifier))
						Traverse (p_AC_ModuleIdentifier.m_Value);
					p_AC_ModuleIdentifier.turn_inc ();
					Raise_AC_ModuleIdentifier_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_ModuleIdentifier);
				break;
				case AC_ModuleIdentifier.production_kind.g_AC_ModuleIdentifier_2:
					// traverse syntax tree node associated with production
					// AC-ModuleIdentifier: %empty

				break;
			}
			Raise_AC_ModuleIdentifier_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_ModuleIdentifier);
			p_AC_ModuleIdentifier.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-ModuleIdentifier
		//

		public void TraverseCommon (AC_ModuleIdentifier p_AC_ModuleIdentifier)
		{
			AC_ModuleIdentifier.production_kind kind = (AC_ModuleIdentifier.production_kind) p_AC_ModuleIdentifier.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_ModuleIdentifier))
			switch (kind)
			{
				case AC_ModuleIdentifier.production_kind.g_AC_ModuleIdentifier_1:
					// traverse syntax tree node associated with production
					// AC-ModuleIdentifier: Value

						TraverseCommon (p_AC_ModuleIdentifier.m_Value);
				break;
				case AC_ModuleIdentifier.production_kind.g_AC_ModuleIdentifier_2:
					// traverse syntax tree node associated with production
					// AC-ModuleIdentifier: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_ModuleIdentifier);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-ModuleIdentifier

		//
		// create syntax tree node associated with production
		// AC-ModuleIdentifier: Value

		//

		public AC_ModuleIdentifier AC_ModuleIdentifier_1 (Value p_Value)
		{
			AC_ModuleIdentifier p_AC_ModuleIdentifier_ref = new AC_ModuleIdentifier(p_Value);
			p_Value.parent = p_AC_ModuleIdentifier_ref;
			Raise_AC_ModuleIdentifier_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_ModuleIdentifier.production_kind.g_AC_ModuleIdentifier_1, p_AC_ModuleIdentifier_ref);
			return p_AC_ModuleIdentifier_ref;
		}

		//
		// create syntax tree node associated with production
		// AC-ModuleIdentifier: %empty

		//

		public AC_ModuleIdentifier AC_ModuleIdentifier_2 ()
		{
			AC_ModuleIdentifier p_AC_ModuleIdentifier_ref = new AC_ModuleIdentifier();
			Raise_AC_ModuleIdentifier_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_ModuleIdentifier.production_kind.g_AC_ModuleIdentifier_2, p_AC_ModuleIdentifier_ref);
			return p_AC_ModuleIdentifier_ref;
		}
		#endregion
	};
}
