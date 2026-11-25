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
	// class associated with syntax rule MC-ModuleIdentifier
	//

	[DataContract]
	public class	MC_ModuleIdentifier : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MC-ModuleIdentifier
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MC-ModuleIdentifier
		{
			g_MC_ModuleIdentifier_1 = 1,	// Value

			g_MC_ModuleIdentifier_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule MC-ModuleIdentifier

		// markers associated with production: MC-ModuleIdentifier -> Value

		public enum production_marker_1 : ushort
		{
			m_Value,
			final
		};

		// markers associated with production: MC-ModuleIdentifier -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MC-ModuleIdentifier

		// Constructor declaration(s) associated with production(s) of syntax rule MC-ModuleIdentifier

		//
		// Constructor associated with the following production(s)
		// MC-ModuleIdentifier -> Value

		//

		public MC_ModuleIdentifier (Value p_Value) : base ((uint) ProductionID._MC_ModuleIdentifier_ID, (uint) production_kind.g_MC_ModuleIdentifier_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Value = p_Value;
		}

		//
		// Constructor associated with the following production(s)
		// MC-ModuleIdentifier -> %empty

		//

		public MC_ModuleIdentifier () : base ((uint) ProductionID._MC_ModuleIdentifier_ID, (uint) production_kind.g_MC_ModuleIdentifier_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public MC_ModuleIdentifier (MC_ModuleIdentifier p_MC_ModuleIdentifier) : base (p_MC_ModuleIdentifier.id, p_MC_ModuleIdentifier.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MC_ModuleIdentifier.appInfo;
			switch ((production_kind) p_MC_ModuleIdentifier.kind)
			{
				case production_kind.g_MC_ModuleIdentifier_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Value = (p_MC_ModuleIdentifier.m_Value != null) ? new Value (p_MC_ModuleIdentifier.m_Value) : null) != null) m_Value.parent = this;
					break;
				case production_kind.g_MC_ModuleIdentifier_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "MC_ModuleIdentifier" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MC_ModuleIdentifier (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MC-ModuleIdentifier

		// Content changing function(s) associated with production(s) of syntax rule MC-ModuleIdentifier

		//
		// Content changing function associated with following production(s)
		// MC-ModuleIdentifier -> Value

		//

		public void change(Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_ModuleIdentifier_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MC-ModuleIdentifier -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_ModuleIdentifier_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MC-ModuleIdentifier
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MC-ModuleIdentifier

		//
		// emit production tree node associated with any production of syntax rule MC-ModuleIdentifier
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MC_ModuleIdentifier_1:
					// emit syntax tree node associated with production
					// MC-ModuleIdentifier: Value

					s += m_Value.Emit (depth - 1);
				break;
				case production_kind.g_MC_ModuleIdentifier_2:
					// emit syntax tree node associated with production
					// MC-ModuleIdentifier: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MC-ModuleIdentifier
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MC_ModuleIdentifier (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MC_ModuleIdentifier_1:
					// emit syntax tree node associated with production
					// MC-ModuleIdentifier: Value

					s += m_Value.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MC_ModuleIdentifier_2:
					// emit syntax tree node associated with production
					// MC-ModuleIdentifier: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MC-ModuleIdentifier

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MC-ModuleIdentifier with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MC_ModuleIdentifier.production_kind kind = (MC_ModuleIdentifier.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MC_ModuleIdentifier.production_kind.g_MC_ModuleIdentifier_1:
					// traverse syntax tree node associated with production
					// MC-ModuleIdentifier: Value

						m_Value.Visit (visitor, appData);
				break;
				case MC_ModuleIdentifier.production_kind.g_MC_ModuleIdentifier_2:
					// traverse syntax tree node associated with production
					// MC-ModuleIdentifier: %empty

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
		// initialize object associated with syntax rule MC-ModuleIdentifier
		//

		public void _init ()
		{
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MC-ModuleIdentifier

		// counter of all nodes associated with syntax rule MC-ModuleIdentifier
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MC-ModuleIdentifier
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MC-ModuleIdentifier

		// delegate function (callback) prototype associated with syntax rule MC-ModuleIdentifier
		public delegate bool MC_ModuleIdentifier_Callback (SyntaxTreeCallbackReason reason, MC_ModuleIdentifier.production_kind kind, MC_ModuleIdentifier p_MC_ModuleIdentifier);

		// event associated with syntax rule MC-ModuleIdentifier
		public event MC_ModuleIdentifier_Callback MC_ModuleIdentifier_Event;

		// event trigger associated with syntax rule MC-ModuleIdentifier
		public bool Raise_MC_ModuleIdentifier_Event (SyntaxTreeCallbackReason reason, MC_ModuleIdentifier.production_kind kind, MC_ModuleIdentifier p_MC_ModuleIdentifier)
		{
			bool? status = MC_ModuleIdentifier_Event?.Invoke (reason, kind, p_MC_ModuleIdentifier);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MC-ModuleIdentifier
		//
		// traverse syntax tree node associated with any production of syntax rule MC-ModuleIdentifier
		//

		public void Traverse (MC_ModuleIdentifier p_MC_ModuleIdentifier)
		{
			if (p_MC_ModuleIdentifier.isLocked())
				return;
			p_MC_ModuleIdentifier.dolock();
			MC_ModuleIdentifier.production_kind kind = (MC_ModuleIdentifier.production_kind) p_MC_ModuleIdentifier.kind;
			p_MC_ModuleIdentifier.turn_reset ();
			if (Raise_MC_ModuleIdentifier_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MC_ModuleIdentifier))
			switch (kind)
			{
				case MC_ModuleIdentifier.production_kind.g_MC_ModuleIdentifier_1:
					// traverse syntax tree node associated with production
					// MC-ModuleIdentifier: Value

					if (Raise_MC_ModuleIdentifier_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_ModuleIdentifier))
						Traverse (p_MC_ModuleIdentifier.m_Value);
					p_MC_ModuleIdentifier.turn_inc ();
					Raise_MC_ModuleIdentifier_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_ModuleIdentifier);
				break;
				case MC_ModuleIdentifier.production_kind.g_MC_ModuleIdentifier_2:
					// traverse syntax tree node associated with production
					// MC-ModuleIdentifier: %empty

				break;
			}
			Raise_MC_ModuleIdentifier_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MC_ModuleIdentifier);
			p_MC_ModuleIdentifier.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MC-ModuleIdentifier
		//

		public void TraverseCommon (MC_ModuleIdentifier p_MC_ModuleIdentifier)
		{
			MC_ModuleIdentifier.production_kind kind = (MC_ModuleIdentifier.production_kind) p_MC_ModuleIdentifier.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MC_ModuleIdentifier))
			switch (kind)
			{
				case MC_ModuleIdentifier.production_kind.g_MC_ModuleIdentifier_1:
					// traverse syntax tree node associated with production
					// MC-ModuleIdentifier: Value

						TraverseCommon (p_MC_ModuleIdentifier.m_Value);
				break;
				case MC_ModuleIdentifier.production_kind.g_MC_ModuleIdentifier_2:
					// traverse syntax tree node associated with production
					// MC-ModuleIdentifier: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MC_ModuleIdentifier);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MC-ModuleIdentifier

		//
		// create syntax tree node associated with production
		// MC-ModuleIdentifier: Value

		//

		public MC_ModuleIdentifier MC_ModuleIdentifier_1 (Value p_Value)
		{
			MC_ModuleIdentifier p_MC_ModuleIdentifier_ref = new MC_ModuleIdentifier(p_Value);
			p_Value.parent = p_MC_ModuleIdentifier_ref;
			Raise_MC_ModuleIdentifier_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_ModuleIdentifier.production_kind.g_MC_ModuleIdentifier_1, p_MC_ModuleIdentifier_ref);
			return p_MC_ModuleIdentifier_ref;
		}

		//
		// create syntax tree node associated with production
		// MC-ModuleIdentifier: %empty

		//

		public MC_ModuleIdentifier MC_ModuleIdentifier_2 ()
		{
			MC_ModuleIdentifier p_MC_ModuleIdentifier_ref = new MC_ModuleIdentifier();
			Raise_MC_ModuleIdentifier_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_ModuleIdentifier.production_kind.g_MC_ModuleIdentifier_2, p_MC_ModuleIdentifier_ref);
			return p_MC_ModuleIdentifier_ref;
		}
		#endregion
	};
}
