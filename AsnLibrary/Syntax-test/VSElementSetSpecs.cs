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
	// class associated with syntax rule VSElementSetSpecs
	//

	[DataContract]
	public class	VSElementSetSpecs : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule VSElementSetSpecs
		public enum production_kind : ushort	// enumerated production(s) of syntax rule VSElementSetSpecs
		{
			g_VSElementSetSpecs_1 = 1,	// ElementSetSpecs

		};
		#endregion
		#region production markers associated with the syntax rule VSElementSetSpecs

		// markers associated with production: VSElementSetSpecs -> ElementSetSpecs

		public enum production_marker_1 : ushort
		{
			m_ElementSetSpecs,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule VSElementSetSpecs

		// Constructor declaration(s) associated with production(s) of syntax rule VSElementSetSpecs

		//
		// Constructor associated with the following production(s)
		// VSElementSetSpecs -> ElementSetSpecs

		//

		public VSElementSetSpecs (ElementSetSpecs p_ElementSetSpecs) : base ((uint) ProductionID._VSElementSetSpecs_ID, (uint) production_kind.g_VSElementSetSpecs_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ElementSetSpecs = p_ElementSetSpecs;
		}

		public VSElementSetSpecs () { }

		// Copy constructor

		public VSElementSetSpecs (VSElementSetSpecs p_VSElementSetSpecs) : base (p_VSElementSetSpecs.id, p_VSElementSetSpecs.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_VSElementSetSpecs.appInfo;
			switch ((production_kind) p_VSElementSetSpecs.kind)
			{
				case production_kind.g_VSElementSetSpecs_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ElementSetSpecs = (p_VSElementSetSpecs.m_ElementSetSpecs != null) ? new ElementSetSpecs (p_VSElementSetSpecs.m_ElementSetSpecs) : null) != null) m_ElementSetSpecs.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "VSElementSetSpecs" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new VSElementSetSpecs (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ElementSetSpecs?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule VSElementSetSpecs

		// Content changing function(s) associated with production(s) of syntax rule VSElementSetSpecs

		//
		// Content changing function associated with following production(s)
		// VSElementSetSpecs -> ElementSetSpecs

		//

		public void change(ElementSetSpecs p_ElementSetSpecs)
		{
			_init ();
			this.kind = (uint) production_kind.g_VSElementSetSpecs_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ElementSetSpecs = p_ElementSetSpecs;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule VSElementSetSpecs
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ElementSetSpecs != null) && m_ElementSetSpecs.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule VSElementSetSpecs

		//
		// emit production tree node associated with any production of syntax rule VSElementSetSpecs
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_VSElementSetSpecs_1:
					// emit syntax tree node associated with production
					// VSElementSetSpecs: ElementSetSpecs

					s += m_ElementSetSpecs.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule VSElementSetSpecs
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "VSElementSetSpecs (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_VSElementSetSpecs_1:
					// emit syntax tree node associated with production
					// VSElementSetSpecs: ElementSetSpecs

					s += m_ElementSetSpecs.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule VSElementSetSpecs

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule VSElementSetSpecs with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			VSElementSetSpecs.production_kind kind = (VSElementSetSpecs.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case VSElementSetSpecs.production_kind.g_VSElementSetSpecs_1:
					// traverse syntax tree node associated with production
					// VSElementSetSpecs: ElementSetSpecs

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
		// initialize object associated with syntax rule VSElementSetSpecs
		//

		public void _init ()
		{
			m_ElementSetSpecs = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule VSElementSetSpecs

		// counter of all nodes associated with syntax rule VSElementSetSpecs
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule VSElementSetSpecs
		[DataMember (Name = "m_ElementSetSpecs")] public ElementSetSpecs m_ElementSetSpecs { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule VSElementSetSpecs

		// delegate function (callback) prototype associated with syntax rule VSElementSetSpecs
		public delegate bool VSElementSetSpecs_Callback (SyntaxTreeCallbackReason reason, VSElementSetSpecs.production_kind kind, VSElementSetSpecs p_VSElementSetSpecs);

		// event associated with syntax rule VSElementSetSpecs
		public event VSElementSetSpecs_Callback VSElementSetSpecs_Event;

		// event trigger associated with syntax rule VSElementSetSpecs
		public bool Raise_VSElementSetSpecs_Event (SyntaxTreeCallbackReason reason, VSElementSetSpecs.production_kind kind, VSElementSetSpecs p_VSElementSetSpecs)
		{
			bool? status = VSElementSetSpecs_Event?.Invoke (reason, kind, p_VSElementSetSpecs);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule VSElementSetSpecs
		//
		// traverse syntax tree node associated with any production of syntax rule VSElementSetSpecs
		//

		public void Traverse (VSElementSetSpecs p_VSElementSetSpecs)
		{
			if (p_VSElementSetSpecs.isLocked())
				return;
			p_VSElementSetSpecs.dolock();
			VSElementSetSpecs.production_kind kind = (VSElementSetSpecs.production_kind) p_VSElementSetSpecs.kind;
			p_VSElementSetSpecs.turn_reset ();
			if (Raise_VSElementSetSpecs_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_VSElementSetSpecs))
			switch (kind)
			{
				case VSElementSetSpecs.production_kind.g_VSElementSetSpecs_1:
					// traverse syntax tree node associated with production
					// VSElementSetSpecs: ElementSetSpecs

					if (Raise_VSElementSetSpecs_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_VSElementSetSpecs))
						Traverse (p_VSElementSetSpecs.m_ElementSetSpecs);
					p_VSElementSetSpecs.turn_inc ();
					Raise_VSElementSetSpecs_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_VSElementSetSpecs);
				break;
			}
			Raise_VSElementSetSpecs_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_VSElementSetSpecs);
			p_VSElementSetSpecs.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule VSElementSetSpecs
		//

		public void TraverseCommon (VSElementSetSpecs p_VSElementSetSpecs)
		{
			VSElementSetSpecs.production_kind kind = (VSElementSetSpecs.production_kind) p_VSElementSetSpecs.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_VSElementSetSpecs))
			switch (kind)
			{
				case VSElementSetSpecs.production_kind.g_VSElementSetSpecs_1:
					// traverse syntax tree node associated with production
					// VSElementSetSpecs: ElementSetSpecs

						TraverseCommon (p_VSElementSetSpecs.m_ElementSetSpecs);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_VSElementSetSpecs);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule VSElementSetSpecs

		//
		// create syntax tree node associated with production
		// VSElementSetSpecs: ElementSetSpecs

		//

		public VSElementSetSpecs VSElementSetSpecs_1 (ElementSetSpecs p_ElementSetSpecs)
		{
			VSElementSetSpecs p_VSElementSetSpecs_ref = new VSElementSetSpecs(p_ElementSetSpecs);
			p_ElementSetSpecs.parent = p_VSElementSetSpecs_ref;
			Raise_VSElementSetSpecs_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, VSElementSetSpecs.production_kind.g_VSElementSetSpecs_1, p_VSElementSetSpecs_ref);
			return p_VSElementSetSpecs_ref;
		}
		#endregion
	};
}
