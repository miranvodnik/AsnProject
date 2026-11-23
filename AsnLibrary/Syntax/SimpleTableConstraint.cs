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
	// class associated with syntax rule SimpleTableConstraint
	//

	[DataContract]
	public class	SimpleTableConstraint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SimpleTableConstraint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SimpleTableConstraint
		{
			g_SimpleTableConstraint_1 = 1,	// ObjectSet

		};
		#endregion
		#region production markers associated with the syntax rule SimpleTableConstraint

		// markers associated with production: SimpleTableConstraint -> ObjectSet

		public enum production_marker_1 : ushort
		{
			m_ObjectSet,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SimpleTableConstraint

		// Constructor declaration(s) associated with production(s) of syntax rule SimpleTableConstraint

		//
		// Constructor associated with the following production(s)
		// SimpleTableConstraint -> ObjectSet

		//

		public SimpleTableConstraint (ObjectSet p_ObjectSet) : base ((uint) ProductionID._SimpleTableConstraint_ID, (uint) production_kind.g_SimpleTableConstraint_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjectSet = p_ObjectSet;
		}

		public SimpleTableConstraint () { }

		// Copy constructor

		public SimpleTableConstraint (SimpleTableConstraint p_SimpleTableConstraint) : base (p_SimpleTableConstraint.id, p_SimpleTableConstraint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SimpleTableConstraint.appInfo;
			switch ((production_kind) p_SimpleTableConstraint.kind)
			{
				case production_kind.g_SimpleTableConstraint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectSet = (p_SimpleTableConstraint.m_ObjectSet != null) ? new ObjectSet (p_SimpleTableConstraint.m_ObjectSet) : null) != null) m_ObjectSet.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SimpleTableConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SimpleTableConstraint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ObjectSet?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SimpleTableConstraint

		// Content changing function(s) associated with production(s) of syntax rule SimpleTableConstraint

		//
		// Content changing function associated with following production(s)
		// SimpleTableConstraint -> ObjectSet

		//

		public void change(ObjectSet p_ObjectSet)
		{
			_init ();
			this.kind = (uint) production_kind.g_SimpleTableConstraint_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjectSet = p_ObjectSet;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SimpleTableConstraint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ObjectSet != null) && m_ObjectSet.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SimpleTableConstraint

		//
		// emit production tree node associated with any production of syntax rule SimpleTableConstraint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SimpleTableConstraint_1:
					// emit syntax tree node associated with production
					// SimpleTableConstraint: ObjectSet

					s += m_ObjectSet.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SimpleTableConstraint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SimpleTableConstraint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SimpleTableConstraint_1:
					// emit syntax tree node associated with production
					// SimpleTableConstraint: ObjectSet

					s += m_ObjectSet.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SimpleTableConstraint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SimpleTableConstraint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SimpleTableConstraint.production_kind kind = (SimpleTableConstraint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SimpleTableConstraint.production_kind.g_SimpleTableConstraint_1:
					// traverse syntax tree node associated with production
					// SimpleTableConstraint: ObjectSet

						m_ObjectSet.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ObjectSet?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SimpleTableConstraint
		//

		public void _init ()
		{
			m_ObjectSet = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SimpleTableConstraint

		// counter of all nodes associated with syntax rule SimpleTableConstraint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SimpleTableConstraint
		[DataMember (Name = "m_ObjectSet")] public ObjectSet m_ObjectSet { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SimpleTableConstraint

		// delegate function (callback) prototype associated with syntax rule SimpleTableConstraint
		public delegate bool SimpleTableConstraint_Callback (SyntaxTreeCallbackReason reason, SimpleTableConstraint.production_kind kind, SimpleTableConstraint p_SimpleTableConstraint);

		// event associated with syntax rule SimpleTableConstraint
		public event SimpleTableConstraint_Callback SimpleTableConstraint_Event;

		// event trigger associated with syntax rule SimpleTableConstraint
		public bool Raise_SimpleTableConstraint_Event (SyntaxTreeCallbackReason reason, SimpleTableConstraint.production_kind kind, SimpleTableConstraint p_SimpleTableConstraint)
		{
			bool? status = SimpleTableConstraint_Event?.Invoke (reason, kind, p_SimpleTableConstraint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SimpleTableConstraint
		//
		// traverse syntax tree node associated with any production of syntax rule SimpleTableConstraint
		//

		public void Traverse (SimpleTableConstraint p_SimpleTableConstraint)
		{
			if (p_SimpleTableConstraint.isLocked())
				return;
			p_SimpleTableConstraint.dolock();
			SimpleTableConstraint.production_kind kind = (SimpleTableConstraint.production_kind) p_SimpleTableConstraint.kind;
			p_SimpleTableConstraint.turn_reset ();
			if (Raise_SimpleTableConstraint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SimpleTableConstraint))
			switch (kind)
			{
				case SimpleTableConstraint.production_kind.g_SimpleTableConstraint_1:
					// traverse syntax tree node associated with production
					// SimpleTableConstraint: ObjectSet

					if (Raise_SimpleTableConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SimpleTableConstraint))
						Traverse (p_SimpleTableConstraint.m_ObjectSet);
					p_SimpleTableConstraint.turn_inc ();
					Raise_SimpleTableConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SimpleTableConstraint);
				break;
			}
			Raise_SimpleTableConstraint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SimpleTableConstraint);
			p_SimpleTableConstraint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SimpleTableConstraint
		//

		public void TraverseCommon (SimpleTableConstraint p_SimpleTableConstraint)
		{
			SimpleTableConstraint.production_kind kind = (SimpleTableConstraint.production_kind) p_SimpleTableConstraint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SimpleTableConstraint))
			switch (kind)
			{
				case SimpleTableConstraint.production_kind.g_SimpleTableConstraint_1:
					// traverse syntax tree node associated with production
					// SimpleTableConstraint: ObjectSet

						TraverseCommon (p_SimpleTableConstraint.m_ObjectSet);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SimpleTableConstraint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SimpleTableConstraint

		//
		// create syntax tree node associated with production
		// SimpleTableConstraint: ObjectSet

		//

		public SimpleTableConstraint SimpleTableConstraint_1 (ObjectSet p_ObjectSet)
		{
			SimpleTableConstraint p_SimpleTableConstraint_ref = new SimpleTableConstraint(p_ObjectSet);
			p_ObjectSet.parent = p_SimpleTableConstraint_ref;
			Raise_SimpleTableConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SimpleTableConstraint.production_kind.g_SimpleTableConstraint_1, p_SimpleTableConstraint_ref);
			return p_SimpleTableConstraint_ref;
		}
		#endregion
	};
}
