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
	// class associated with syntax rule AdditionalElementSetSpec
	//

	[DataContract]
	public class	AdditionalElementSetSpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AdditionalElementSetSpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AdditionalElementSetSpec
		{
			g_AdditionalElementSetSpec_1 = 1,	// ElementSetSpec

		};
		#endregion
		#region production markers associated with the syntax rule AdditionalElementSetSpec

		// markers associated with production: AdditionalElementSetSpec -> ElementSetSpec

		public enum production_marker_1 : ushort
		{
			m_ElementSetSpec,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AdditionalElementSetSpec

		// Constructor declaration(s) associated with production(s) of syntax rule AdditionalElementSetSpec

		//
		// Constructor associated with the following production(s)
		// AdditionalElementSetSpec -> ElementSetSpec

		//

		public AdditionalElementSetSpec (ElementSetSpec p_ElementSetSpec) : base ((uint) ProductionID._AdditionalElementSetSpec_ID, (uint) production_kind.g_AdditionalElementSetSpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ElementSetSpec = p_ElementSetSpec;
		}

		public AdditionalElementSetSpec () { }

		// Copy constructor

		public AdditionalElementSetSpec (AdditionalElementSetSpec p_AdditionalElementSetSpec) : base (p_AdditionalElementSetSpec.id, p_AdditionalElementSetSpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AdditionalElementSetSpec.appInfo;
			switch ((production_kind) p_AdditionalElementSetSpec.kind)
			{
				case production_kind.g_AdditionalElementSetSpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ElementSetSpec = (p_AdditionalElementSetSpec.m_ElementSetSpec != null) ? new ElementSetSpec (p_AdditionalElementSetSpec.m_ElementSetSpec) : null) != null) m_ElementSetSpec.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AdditionalElementSetSpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AdditionalElementSetSpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ElementSetSpec?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AdditionalElementSetSpec

		// Content changing function(s) associated with production(s) of syntax rule AdditionalElementSetSpec

		//
		// Content changing function associated with following production(s)
		// AdditionalElementSetSpec -> ElementSetSpec

		//

		public void change(ElementSetSpec p_ElementSetSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_AdditionalElementSetSpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ElementSetSpec = p_ElementSetSpec;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AdditionalElementSetSpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ElementSetSpec != null) && m_ElementSetSpec.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AdditionalElementSetSpec

		//
		// emit production tree node associated with any production of syntax rule AdditionalElementSetSpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AdditionalElementSetSpec_1:
					// emit syntax tree node associated with production
					// AdditionalElementSetSpec: ElementSetSpec

					s += m_ElementSetSpec.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AdditionalElementSetSpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AdditionalElementSetSpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AdditionalElementSetSpec_1:
					// emit syntax tree node associated with production
					// AdditionalElementSetSpec: ElementSetSpec

					s += m_ElementSetSpec.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AdditionalElementSetSpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AdditionalElementSetSpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AdditionalElementSetSpec.production_kind kind = (AdditionalElementSetSpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AdditionalElementSetSpec.production_kind.g_AdditionalElementSetSpec_1:
					// traverse syntax tree node associated with production
					// AdditionalElementSetSpec: ElementSetSpec

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
		// initialize object associated with syntax rule AdditionalElementSetSpec
		//

		public void _init ()
		{
			m_ElementSetSpec = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AdditionalElementSetSpec

		// counter of all nodes associated with syntax rule AdditionalElementSetSpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AdditionalElementSetSpec
		[DataMember (Name = "m_ElementSetSpec")] public ElementSetSpec m_ElementSetSpec { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AdditionalElementSetSpec

		// delegate function (callback) prototype associated with syntax rule AdditionalElementSetSpec
		public delegate bool AdditionalElementSetSpec_Callback (SyntaxTreeCallbackReason reason, AdditionalElementSetSpec.production_kind kind, AdditionalElementSetSpec p_AdditionalElementSetSpec);

		// event associated with syntax rule AdditionalElementSetSpec
		public event AdditionalElementSetSpec_Callback AdditionalElementSetSpec_Event;

		// event trigger associated with syntax rule AdditionalElementSetSpec
		public bool Raise_AdditionalElementSetSpec_Event (SyntaxTreeCallbackReason reason, AdditionalElementSetSpec.production_kind kind, AdditionalElementSetSpec p_AdditionalElementSetSpec)
		{
			bool? status = AdditionalElementSetSpec_Event?.Invoke (reason, kind, p_AdditionalElementSetSpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AdditionalElementSetSpec
		//
		// traverse syntax tree node associated with any production of syntax rule AdditionalElementSetSpec
		//

		public void Traverse (AdditionalElementSetSpec p_AdditionalElementSetSpec)
		{
			if (p_AdditionalElementSetSpec.isLocked())
				return;
			p_AdditionalElementSetSpec.dolock();
			AdditionalElementSetSpec.production_kind kind = (AdditionalElementSetSpec.production_kind) p_AdditionalElementSetSpec.kind;
			p_AdditionalElementSetSpec.turn_reset ();
			if (Raise_AdditionalElementSetSpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AdditionalElementSetSpec))
			switch (kind)
			{
				case AdditionalElementSetSpec.production_kind.g_AdditionalElementSetSpec_1:
					// traverse syntax tree node associated with production
					// AdditionalElementSetSpec: ElementSetSpec

					if (Raise_AdditionalElementSetSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AdditionalElementSetSpec))
						Traverse (p_AdditionalElementSetSpec.m_ElementSetSpec);
					p_AdditionalElementSetSpec.turn_inc ();
					Raise_AdditionalElementSetSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AdditionalElementSetSpec);
				break;
			}
			Raise_AdditionalElementSetSpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AdditionalElementSetSpec);
			p_AdditionalElementSetSpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AdditionalElementSetSpec
		//

		public void TraverseCommon (AdditionalElementSetSpec p_AdditionalElementSetSpec)
		{
			AdditionalElementSetSpec.production_kind kind = (AdditionalElementSetSpec.production_kind) p_AdditionalElementSetSpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AdditionalElementSetSpec))
			switch (kind)
			{
				case AdditionalElementSetSpec.production_kind.g_AdditionalElementSetSpec_1:
					// traverse syntax tree node associated with production
					// AdditionalElementSetSpec: ElementSetSpec

						TraverseCommon (p_AdditionalElementSetSpec.m_ElementSetSpec);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AdditionalElementSetSpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AdditionalElementSetSpec

		//
		// create syntax tree node associated with production
		// AdditionalElementSetSpec: ElementSetSpec

		//

		public AdditionalElementSetSpec AdditionalElementSetSpec_1 (ElementSetSpec p_ElementSetSpec)
		{
			AdditionalElementSetSpec p_AdditionalElementSetSpec_ref = new AdditionalElementSetSpec(p_ElementSetSpec);
			p_ElementSetSpec.parent = p_AdditionalElementSetSpec_ref;
			Raise_AdditionalElementSetSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AdditionalElementSetSpec.production_kind.g_AdditionalElementSetSpec_1, p_AdditionalElementSetSpec_ref);
			return p_AdditionalElementSetSpec_ref;
		}
		#endregion
	};
}
