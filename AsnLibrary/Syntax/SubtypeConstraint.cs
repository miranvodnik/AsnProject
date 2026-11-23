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
	// class associated with syntax rule SubtypeConstraint
	//

	[DataContract]
	public class	SubtypeConstraint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SubtypeConstraint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SubtypeConstraint
		{
			g_SubtypeConstraint_1 = 1,	// ElementSetSpecs

		};
		#endregion
		#region production markers associated with the syntax rule SubtypeConstraint

		// markers associated with production: SubtypeConstraint -> ElementSetSpecs

		public enum production_marker_1 : ushort
		{
			m_ElementSetSpecs,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SubtypeConstraint

		// Constructor declaration(s) associated with production(s) of syntax rule SubtypeConstraint

		//
		// Constructor associated with the following production(s)
		// SubtypeConstraint -> ElementSetSpecs

		//

		public SubtypeConstraint (ElementSetSpecs p_ElementSetSpecs) : base ((uint) ProductionID._SubtypeConstraint_ID, (uint) production_kind.g_SubtypeConstraint_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ElementSetSpecs = p_ElementSetSpecs;
		}

		public SubtypeConstraint () { }

		// Copy constructor

		public SubtypeConstraint (SubtypeConstraint p_SubtypeConstraint) : base (p_SubtypeConstraint.id, p_SubtypeConstraint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SubtypeConstraint.appInfo;
			switch ((production_kind) p_SubtypeConstraint.kind)
			{
				case production_kind.g_SubtypeConstraint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ElementSetSpecs = (p_SubtypeConstraint.m_ElementSetSpecs != null) ? new ElementSetSpecs (p_SubtypeConstraint.m_ElementSetSpecs) : null) != null) m_ElementSetSpecs.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SubtypeConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SubtypeConstraint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ElementSetSpecs?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SubtypeConstraint

		// Content changing function(s) associated with production(s) of syntax rule SubtypeConstraint

		//
		// Content changing function associated with following production(s)
		// SubtypeConstraint -> ElementSetSpecs

		//

		public void change(ElementSetSpecs p_ElementSetSpecs)
		{
			_init ();
			this.kind = (uint) production_kind.g_SubtypeConstraint_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ElementSetSpecs = p_ElementSetSpecs;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SubtypeConstraint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ElementSetSpecs != null) && m_ElementSetSpecs.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SubtypeConstraint

		//
		// emit production tree node associated with any production of syntax rule SubtypeConstraint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SubtypeConstraint_1:
					// emit syntax tree node associated with production
					// SubtypeConstraint: ElementSetSpecs

					s += m_ElementSetSpecs.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SubtypeConstraint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SubtypeConstraint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SubtypeConstraint_1:
					// emit syntax tree node associated with production
					// SubtypeConstraint: ElementSetSpecs

					s += m_ElementSetSpecs.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SubtypeConstraint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SubtypeConstraint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SubtypeConstraint.production_kind kind = (SubtypeConstraint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SubtypeConstraint.production_kind.g_SubtypeConstraint_1:
					// traverse syntax tree node associated with production
					// SubtypeConstraint: ElementSetSpecs

						m_ElementSetSpecs.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ElementSetSpecs?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SubtypeConstraint
		//

		public void _init ()
		{
			m_ElementSetSpecs = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SubtypeConstraint

		// counter of all nodes associated with syntax rule SubtypeConstraint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SubtypeConstraint
		[DataMember (Name = "m_ElementSetSpecs")] public ElementSetSpecs m_ElementSetSpecs { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SubtypeConstraint

		// delegate function (callback) prototype associated with syntax rule SubtypeConstraint
		public delegate bool SubtypeConstraint_Callback (SyntaxTreeCallbackReason reason, SubtypeConstraint.production_kind kind, SubtypeConstraint p_SubtypeConstraint);

		// event associated with syntax rule SubtypeConstraint
		public event SubtypeConstraint_Callback SubtypeConstraint_Event;

		// event trigger associated with syntax rule SubtypeConstraint
		public bool Raise_SubtypeConstraint_Event (SyntaxTreeCallbackReason reason, SubtypeConstraint.production_kind kind, SubtypeConstraint p_SubtypeConstraint)
		{
			bool? status = SubtypeConstraint_Event?.Invoke (reason, kind, p_SubtypeConstraint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SubtypeConstraint
		//
		// traverse syntax tree node associated with any production of syntax rule SubtypeConstraint
		//

		public void Traverse (SubtypeConstraint p_SubtypeConstraint)
		{
			if (p_SubtypeConstraint.isLocked())
				return;
			p_SubtypeConstraint.dolock();
			SubtypeConstraint.production_kind kind = (SubtypeConstraint.production_kind) p_SubtypeConstraint.kind;
			p_SubtypeConstraint.turn_reset ();
			if (Raise_SubtypeConstraint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SubtypeConstraint))
			switch (kind)
			{
				case SubtypeConstraint.production_kind.g_SubtypeConstraint_1:
					// traverse syntax tree node associated with production
					// SubtypeConstraint: ElementSetSpecs

					if (Raise_SubtypeConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeConstraint))
						Traverse (p_SubtypeConstraint.m_ElementSetSpecs);
					p_SubtypeConstraint.turn_inc ();
					Raise_SubtypeConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeConstraint);
				break;
			}
			Raise_SubtypeConstraint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SubtypeConstraint);
			p_SubtypeConstraint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SubtypeConstraint
		//

		public void TraverseCommon (SubtypeConstraint p_SubtypeConstraint)
		{
			SubtypeConstraint.production_kind kind = (SubtypeConstraint.production_kind) p_SubtypeConstraint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SubtypeConstraint))
			switch (kind)
			{
				case SubtypeConstraint.production_kind.g_SubtypeConstraint_1:
					// traverse syntax tree node associated with production
					// SubtypeConstraint: ElementSetSpecs

						TraverseCommon (p_SubtypeConstraint.m_ElementSetSpecs);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SubtypeConstraint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SubtypeConstraint

		//
		// create syntax tree node associated with production
		// SubtypeConstraint: ElementSetSpecs

		//

		public SubtypeConstraint SubtypeConstraint_1 (ElementSetSpecs p_ElementSetSpecs)
		{
			SubtypeConstraint p_SubtypeConstraint_ref = new SubtypeConstraint(p_ElementSetSpecs);
			p_ElementSetSpecs.parent = p_SubtypeConstraint_ref;
			Raise_SubtypeConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SubtypeConstraint.production_kind.g_SubtypeConstraint_1, p_SubtypeConstraint_ref);
			return p_SubtypeConstraint_ref;
		}
		#endregion
	};
}
