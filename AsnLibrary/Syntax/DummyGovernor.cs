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
	// class associated with syntax rule DummyGovernor
	//

	[DataContract]
	public class	DummyGovernor : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DummyGovernor
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DummyGovernor
		{
			g_DummyGovernor_1 = 1,	// DummyReference

		};
		#endregion
		#region production markers associated with the syntax rule DummyGovernor

		// markers associated with production: DummyGovernor -> DummyReference

		public enum production_marker_1 : ushort
		{
			m_DummyReference,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DummyGovernor

		// Constructor declaration(s) associated with production(s) of syntax rule DummyGovernor

		//
		// Constructor associated with the following production(s)
		// DummyGovernor -> DummyReference

		//

		public DummyGovernor (DummyReference p_DummyReference) : base ((uint) ProductionID._DummyGovernor_ID, (uint) production_kind.g_DummyGovernor_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DummyReference = p_DummyReference;
		}

		public DummyGovernor () { }

		// Copy constructor

		public DummyGovernor (DummyGovernor p_DummyGovernor) : base (p_DummyGovernor.id, p_DummyGovernor.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DummyGovernor.appInfo;
			switch ((production_kind) p_DummyGovernor.kind)
			{
				case production_kind.g_DummyGovernor_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DummyReference = (p_DummyGovernor.m_DummyReference != null) ? new DummyReference (p_DummyGovernor.m_DummyReference) : null) != null) m_DummyReference.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DummyGovernor" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DummyGovernor (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DummyReference?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DummyGovernor

		// Content changing function(s) associated with production(s) of syntax rule DummyGovernor

		//
		// Content changing function associated with following production(s)
		// DummyGovernor -> DummyReference

		//

		public void change(DummyReference p_DummyReference)
		{
			_init ();
			this.kind = (uint) production_kind.g_DummyGovernor_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DummyReference = p_DummyReference;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DummyGovernor
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DummyReference != null) && m_DummyReference.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DummyGovernor

		//
		// emit production tree node associated with any production of syntax rule DummyGovernor
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DummyGovernor_1:
					// emit syntax tree node associated with production
					// DummyGovernor: DummyReference

					s += m_DummyReference.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DummyGovernor
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DummyGovernor (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DummyGovernor_1:
					// emit syntax tree node associated with production
					// DummyGovernor: DummyReference

					s += m_DummyReference.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DummyGovernor

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DummyGovernor with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DummyGovernor.production_kind kind = (DummyGovernor.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DummyGovernor.production_kind.g_DummyGovernor_1:
					// traverse syntax tree node associated with production
					// DummyGovernor: DummyReference

						m_DummyReference.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DummyReference?.reparent (this);
		}

		//
		// initialize object associated with syntax rule DummyGovernor
		//

		public void _init ()
		{
			m_DummyReference = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DummyGovernor

		// counter of all nodes associated with syntax rule DummyGovernor
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DummyGovernor
		[DataMember (Name = "m_DummyReference")] public DummyReference m_DummyReference { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DummyGovernor

		// delegate function (callback) prototype associated with syntax rule DummyGovernor
		public delegate bool DummyGovernor_Callback (SyntaxTreeCallbackReason reason, DummyGovernor.production_kind kind, DummyGovernor p_DummyGovernor);

		// event associated with syntax rule DummyGovernor
		public event DummyGovernor_Callback DummyGovernor_Event;

		// event trigger associated with syntax rule DummyGovernor
		public bool Raise_DummyGovernor_Event (SyntaxTreeCallbackReason reason, DummyGovernor.production_kind kind, DummyGovernor p_DummyGovernor)
		{
			bool? status = DummyGovernor_Event?.Invoke (reason, kind, p_DummyGovernor);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DummyGovernor
		//
		// traverse syntax tree node associated with any production of syntax rule DummyGovernor
		//

		public void Traverse (DummyGovernor p_DummyGovernor)
		{
			if (p_DummyGovernor.isLocked())
				return;
			p_DummyGovernor.dolock();
			DummyGovernor.production_kind kind = (DummyGovernor.production_kind) p_DummyGovernor.kind;
			p_DummyGovernor.turn_reset ();
			if (Raise_DummyGovernor_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DummyGovernor))
			switch (kind)
			{
				case DummyGovernor.production_kind.g_DummyGovernor_1:
					// traverse syntax tree node associated with production
					// DummyGovernor: DummyReference

					if (Raise_DummyGovernor_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DummyGovernor))
						Traverse (p_DummyGovernor.m_DummyReference);
					p_DummyGovernor.turn_inc ();
					Raise_DummyGovernor_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DummyGovernor);
				break;
			}
			Raise_DummyGovernor_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DummyGovernor);
			p_DummyGovernor.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DummyGovernor
		//

		public void TraverseCommon (DummyGovernor p_DummyGovernor)
		{
			DummyGovernor.production_kind kind = (DummyGovernor.production_kind) p_DummyGovernor.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DummyGovernor))
			switch (kind)
			{
				case DummyGovernor.production_kind.g_DummyGovernor_1:
					// traverse syntax tree node associated with production
					// DummyGovernor: DummyReference

						TraverseCommon (p_DummyGovernor.m_DummyReference);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DummyGovernor);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DummyGovernor

		//
		// create syntax tree node associated with production
		// DummyGovernor: DummyReference

		//

		public DummyGovernor DummyGovernor_1 (DummyReference p_DummyReference)
		{
			DummyGovernor p_DummyGovernor_ref = new DummyGovernor(p_DummyReference);
			p_DummyReference.parent = p_DummyGovernor_ref;
			Raise_DummyGovernor_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DummyGovernor.production_kind.g_DummyGovernor_1, p_DummyGovernor_ref);
			return p_DummyGovernor_ref;
		}
		#endregion
	};
}
