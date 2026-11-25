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
	// class associated with syntax rule ParamGovernor
	//

	[DataContract]
	public class	ParamGovernor : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ParamGovernor
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ParamGovernor
		{
			g_ParamGovernor_1 = 1,	// Governor

			g_ParamGovernor_2 = 2,	// DummyGovernor

		};
		#endregion
		#region production markers associated with the syntax rule ParamGovernor

		// markers associated with production: ParamGovernor -> Governor

		public enum production_marker_1 : ushort
		{
			m_Governor,
			final
		};

		// markers associated with production: ParamGovernor -> DummyGovernor

		public enum production_marker_2 : ushort
		{
			m_DummyGovernor,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ParamGovernor

		// Constructor declaration(s) associated with production(s) of syntax rule ParamGovernor

		//
		// Constructor associated with the following production(s)
		// ParamGovernor -> Governor

		//

		public ParamGovernor (Governor p_Governor) : base ((uint) ProductionID._ParamGovernor_ID, (uint) production_kind.g_ParamGovernor_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Governor = p_Governor;
		}

		//
		// Constructor associated with the following production(s)
		// ParamGovernor -> DummyGovernor

		//

		public ParamGovernor (DummyGovernor p_DummyGovernor) : base ((uint) ProductionID._ParamGovernor_ID, (uint) production_kind.g_ParamGovernor_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DummyGovernor = p_DummyGovernor;
		}

		public ParamGovernor () { }

		// Copy constructor

		public ParamGovernor (ParamGovernor p_ParamGovernor) : base (p_ParamGovernor.id, p_ParamGovernor.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ParamGovernor.appInfo;
			switch ((production_kind) p_ParamGovernor.kind)
			{
				case production_kind.g_ParamGovernor_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Governor = (p_ParamGovernor.m_Governor != null) ? new Governor (p_ParamGovernor.m_Governor) : null) != null) m_Governor.parent = this;
					break;
				case production_kind.g_ParamGovernor_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DummyGovernor = (p_ParamGovernor.m_DummyGovernor != null) ? new DummyGovernor (p_ParamGovernor.m_DummyGovernor) : null) != null) m_DummyGovernor.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ParamGovernor" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ParamGovernor (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Governor?.Dispose ();
			m_DummyGovernor?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ParamGovernor

		// Content changing function(s) associated with production(s) of syntax rule ParamGovernor

		//
		// Content changing function associated with following production(s)
		// ParamGovernor -> Governor

		//

		public void change(Governor p_Governor)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParamGovernor_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Governor = p_Governor;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ParamGovernor -> DummyGovernor

		//

		public void change(DummyGovernor p_DummyGovernor)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParamGovernor_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DummyGovernor = p_DummyGovernor;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ParamGovernor
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Governor != null) && m_Governor.checkInclusion (element) ||
				(m_DummyGovernor != null) && m_DummyGovernor.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ParamGovernor

		//
		// emit production tree node associated with any production of syntax rule ParamGovernor
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ParamGovernor_1:
					// emit syntax tree node associated with production
					// ParamGovernor: Governor

					s += m_Governor.Emit (depth - 1);
				break;
				case production_kind.g_ParamGovernor_2:
					// emit syntax tree node associated with production
					// ParamGovernor: DummyGovernor

					s += m_DummyGovernor.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ParamGovernor
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ParamGovernor (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ParamGovernor_1:
					// emit syntax tree node associated with production
					// ParamGovernor: Governor

					s += m_Governor.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ParamGovernor_2:
					// emit syntax tree node associated with production
					// ParamGovernor: DummyGovernor

					s += m_DummyGovernor.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ParamGovernor

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ParamGovernor with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ParamGovernor.production_kind kind = (ParamGovernor.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ParamGovernor.production_kind.g_ParamGovernor_1:
					// traverse syntax tree node associated with production
					// ParamGovernor: Governor

						m_Governor.Visit (visitor, appData);
				break;
				case ParamGovernor.production_kind.g_ParamGovernor_2:
					// traverse syntax tree node associated with production
					// ParamGovernor: DummyGovernor

						m_DummyGovernor.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Governor?.reparent (this);
			m_DummyGovernor?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ParamGovernor
		//

		public void _init ()
		{
			m_Governor = null;
			m_DummyGovernor = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ParamGovernor

		// counter of all nodes associated with syntax rule ParamGovernor
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ParamGovernor
		[DataMember (Name = "m_Governor")] public Governor m_Governor { get; private set; }
		[DataMember (Name = "m_DummyGovernor")] public DummyGovernor m_DummyGovernor { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ParamGovernor

		// delegate function (callback) prototype associated with syntax rule ParamGovernor
		public delegate bool ParamGovernor_Callback (SyntaxTreeCallbackReason reason, ParamGovernor.production_kind kind, ParamGovernor p_ParamGovernor);

		// event associated with syntax rule ParamGovernor
		public event ParamGovernor_Callback ParamGovernor_Event;

		// event trigger associated with syntax rule ParamGovernor
		public bool Raise_ParamGovernor_Event (SyntaxTreeCallbackReason reason, ParamGovernor.production_kind kind, ParamGovernor p_ParamGovernor)
		{
			bool? status = ParamGovernor_Event?.Invoke (reason, kind, p_ParamGovernor);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ParamGovernor
		//
		// traverse syntax tree node associated with any production of syntax rule ParamGovernor
		//

		public void Traverse (ParamGovernor p_ParamGovernor)
		{
			if (p_ParamGovernor.isLocked())
				return;
			p_ParamGovernor.dolock();
			ParamGovernor.production_kind kind = (ParamGovernor.production_kind) p_ParamGovernor.kind;
			p_ParamGovernor.turn_reset ();
			if (Raise_ParamGovernor_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ParamGovernor))
			switch (kind)
			{
				case ParamGovernor.production_kind.g_ParamGovernor_1:
					// traverse syntax tree node associated with production
					// ParamGovernor: Governor

					if (Raise_ParamGovernor_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParamGovernor))
						Traverse (p_ParamGovernor.m_Governor);
					p_ParamGovernor.turn_inc ();
					Raise_ParamGovernor_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParamGovernor);
				break;
				case ParamGovernor.production_kind.g_ParamGovernor_2:
					// traverse syntax tree node associated with production
					// ParamGovernor: DummyGovernor

					if (Raise_ParamGovernor_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParamGovernor))
						Traverse (p_ParamGovernor.m_DummyGovernor);
					p_ParamGovernor.turn_inc ();
					Raise_ParamGovernor_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParamGovernor);
				break;
			}
			Raise_ParamGovernor_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ParamGovernor);
			p_ParamGovernor.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ParamGovernor
		//

		public void TraverseCommon (ParamGovernor p_ParamGovernor)
		{
			ParamGovernor.production_kind kind = (ParamGovernor.production_kind) p_ParamGovernor.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ParamGovernor))
			switch (kind)
			{
				case ParamGovernor.production_kind.g_ParamGovernor_1:
					// traverse syntax tree node associated with production
					// ParamGovernor: Governor

						TraverseCommon (p_ParamGovernor.m_Governor);
				break;
				case ParamGovernor.production_kind.g_ParamGovernor_2:
					// traverse syntax tree node associated with production
					// ParamGovernor: DummyGovernor

						TraverseCommon (p_ParamGovernor.m_DummyGovernor);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ParamGovernor);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ParamGovernor

		//
		// create syntax tree node associated with production
		// ParamGovernor: Governor

		//

		public ParamGovernor ParamGovernor_1 (Governor p_Governor)
		{
			ParamGovernor p_ParamGovernor_ref = new ParamGovernor(p_Governor);
			p_Governor.parent = p_ParamGovernor_ref;
			Raise_ParamGovernor_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParamGovernor.production_kind.g_ParamGovernor_1, p_ParamGovernor_ref);
			return p_ParamGovernor_ref;
		}

		//
		// create syntax tree node associated with production
		// ParamGovernor: DummyGovernor

		//

		public ParamGovernor ParamGovernor_2 (DummyGovernor p_DummyGovernor)
		{
			ParamGovernor p_ParamGovernor_ref = new ParamGovernor(p_DummyGovernor);
			p_DummyGovernor.parent = p_ParamGovernor_ref;
			Raise_ParamGovernor_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParamGovernor.production_kind.g_ParamGovernor_2, p_ParamGovernor_ref);
			return p_ParamGovernor_ref;
		}
		#endregion
	};
}
