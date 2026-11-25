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
	// class associated with syntax rule RootElementSetSpec
	//

	[DataContract]
	public class	RootElementSetSpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule RootElementSetSpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule RootElementSetSpec
		{
			g_RootElementSetSpec_1 = 1,	// ElementSetSpec

		};
		#endregion
		#region production markers associated with the syntax rule RootElementSetSpec

		// markers associated with production: RootElementSetSpec -> ElementSetSpec

		public enum production_marker_1 : ushort
		{
			m_ElementSetSpec,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule RootElementSetSpec

		// Constructor declaration(s) associated with production(s) of syntax rule RootElementSetSpec

		//
		// Constructor associated with the following production(s)
		// RootElementSetSpec -> ElementSetSpec

		//

		public RootElementSetSpec (ElementSetSpec p_ElementSetSpec) : base ((uint) ProductionID._RootElementSetSpec_ID, (uint) production_kind.g_RootElementSetSpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ElementSetSpec = p_ElementSetSpec;
		}

		public RootElementSetSpec () { }

		// Copy constructor

		public RootElementSetSpec (RootElementSetSpec p_RootElementSetSpec) : base (p_RootElementSetSpec.id, p_RootElementSetSpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_RootElementSetSpec.appInfo;
			switch ((production_kind) p_RootElementSetSpec.kind)
			{
				case production_kind.g_RootElementSetSpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ElementSetSpec = (p_RootElementSetSpec.m_ElementSetSpec != null) ? new ElementSetSpec (p_RootElementSetSpec.m_ElementSetSpec) : null) != null) m_ElementSetSpec.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "RootElementSetSpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new RootElementSetSpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ElementSetSpec?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule RootElementSetSpec

		// Content changing function(s) associated with production(s) of syntax rule RootElementSetSpec

		//
		// Content changing function associated with following production(s)
		// RootElementSetSpec -> ElementSetSpec

		//

		public void change(ElementSetSpec p_ElementSetSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_RootElementSetSpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ElementSetSpec = p_ElementSetSpec;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule RootElementSetSpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ElementSetSpec != null) && m_ElementSetSpec.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule RootElementSetSpec

		//
		// emit production tree node associated with any production of syntax rule RootElementSetSpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_RootElementSetSpec_1:
					// emit syntax tree node associated with production
					// RootElementSetSpec: ElementSetSpec

					s += m_ElementSetSpec.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule RootElementSetSpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "RootElementSetSpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_RootElementSetSpec_1:
					// emit syntax tree node associated with production
					// RootElementSetSpec: ElementSetSpec

					s += m_ElementSetSpec.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule RootElementSetSpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule RootElementSetSpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			RootElementSetSpec.production_kind kind = (RootElementSetSpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case RootElementSetSpec.production_kind.g_RootElementSetSpec_1:
					// traverse syntax tree node associated with production
					// RootElementSetSpec: ElementSetSpec

						m_ElementSetSpec.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ElementSetSpec?.reparent (this);
		}

		//
		// initialize object associated with syntax rule RootElementSetSpec
		//

		public void _init ()
		{
			m_ElementSetSpec = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule RootElementSetSpec

		// counter of all nodes associated with syntax rule RootElementSetSpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule RootElementSetSpec
		[DataMember (Name = "m_ElementSetSpec")] public ElementSetSpec m_ElementSetSpec { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule RootElementSetSpec

		// delegate function (callback) prototype associated with syntax rule RootElementSetSpec
		public delegate bool RootElementSetSpec_Callback (SyntaxTreeCallbackReason reason, RootElementSetSpec.production_kind kind, RootElementSetSpec p_RootElementSetSpec);

		// event associated with syntax rule RootElementSetSpec
		public event RootElementSetSpec_Callback RootElementSetSpec_Event;

		// event trigger associated with syntax rule RootElementSetSpec
		public bool Raise_RootElementSetSpec_Event (SyntaxTreeCallbackReason reason, RootElementSetSpec.production_kind kind, RootElementSetSpec p_RootElementSetSpec)
		{
			bool? status = RootElementSetSpec_Event?.Invoke (reason, kind, p_RootElementSetSpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule RootElementSetSpec
		//
		// traverse syntax tree node associated with any production of syntax rule RootElementSetSpec
		//

		public void Traverse (RootElementSetSpec p_RootElementSetSpec)
		{
			if (p_RootElementSetSpec.isLocked())
				return;
			p_RootElementSetSpec.dolock();
			RootElementSetSpec.production_kind kind = (RootElementSetSpec.production_kind) p_RootElementSetSpec.kind;
			p_RootElementSetSpec.turn_reset ();
			if (Raise_RootElementSetSpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_RootElementSetSpec))
			switch (kind)
			{
				case RootElementSetSpec.production_kind.g_RootElementSetSpec_1:
					// traverse syntax tree node associated with production
					// RootElementSetSpec: ElementSetSpec

					if (Raise_RootElementSetSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RootElementSetSpec))
						Traverse (p_RootElementSetSpec.m_ElementSetSpec);
					p_RootElementSetSpec.turn_inc ();
					Raise_RootElementSetSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RootElementSetSpec);
				break;
			}
			Raise_RootElementSetSpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_RootElementSetSpec);
			p_RootElementSetSpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule RootElementSetSpec
		//

		public void TraverseCommon (RootElementSetSpec p_RootElementSetSpec)
		{
			RootElementSetSpec.production_kind kind = (RootElementSetSpec.production_kind) p_RootElementSetSpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_RootElementSetSpec))
			switch (kind)
			{
				case RootElementSetSpec.production_kind.g_RootElementSetSpec_1:
					// traverse syntax tree node associated with production
					// RootElementSetSpec: ElementSetSpec

						TraverseCommon (p_RootElementSetSpec.m_ElementSetSpec);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_RootElementSetSpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule RootElementSetSpec

		//
		// create syntax tree node associated with production
		// RootElementSetSpec: ElementSetSpec

		//

		public RootElementSetSpec RootElementSetSpec_1 (ElementSetSpec p_ElementSetSpec)
		{
			RootElementSetSpec p_RootElementSetSpec_ref = new RootElementSetSpec(p_ElementSetSpec);
			p_ElementSetSpec.parent = p_RootElementSetSpec_ref;
			Raise_RootElementSetSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RootElementSetSpec.production_kind.g_RootElementSetSpec_1, p_RootElementSetSpec_ref);
			return p_RootElementSetSpec_ref;
		}
		#endregion
	};
}
