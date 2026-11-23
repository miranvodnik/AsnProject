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
	// class associated with syntax rule DefinitiveObjIdComponent
	//

	[DataContract]
	public class	DefinitiveObjIdComponent : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DefinitiveObjIdComponent
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DefinitiveObjIdComponent
		{
			g_DefinitiveObjIdComponent_1 = 1,	// NameForm

			g_DefinitiveObjIdComponent_2 = 2,	// DefinitiveNumberForm

			g_DefinitiveObjIdComponent_3 = 3,	// DefinitiveNameAndNumberForm

		};
		#endregion
		#region production markers associated with the syntax rule DefinitiveObjIdComponent

		// markers associated with production: DefinitiveObjIdComponent -> NameForm

		public enum production_marker_1 : ushort
		{
			m_NameForm,
			final
		};

		// markers associated with production: DefinitiveObjIdComponent -> DefinitiveNumberForm

		public enum production_marker_2 : ushort
		{
			m_DefinitiveNumberForm,
			final
		};

		// markers associated with production: DefinitiveObjIdComponent -> DefinitiveNameAndNumberForm

		public enum production_marker_3 : ushort
		{
			m_DefinitiveNameAndNumberForm,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DefinitiveObjIdComponent

		// Constructor declaration(s) associated with production(s) of syntax rule DefinitiveObjIdComponent

		//
		// Constructor associated with the following production(s)
		// DefinitiveObjIdComponent -> NameForm

		//

		public DefinitiveObjIdComponent (NameForm p_NameForm) : base ((uint) ProductionID._DefinitiveObjIdComponent_ID, (uint) production_kind.g_DefinitiveObjIdComponent_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NameForm = p_NameForm;
		}

		//
		// Constructor associated with the following production(s)
		// DefinitiveObjIdComponent -> DefinitiveNumberForm

		//

		public DefinitiveObjIdComponent (DefinitiveNumberForm p_DefinitiveNumberForm) : base ((uint) ProductionID._DefinitiveObjIdComponent_ID, (uint) production_kind.g_DefinitiveObjIdComponent_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinitiveNumberForm = p_DefinitiveNumberForm;
		}

		//
		// Constructor associated with the following production(s)
		// DefinitiveObjIdComponent -> DefinitiveNameAndNumberForm

		//

		public DefinitiveObjIdComponent (DefinitiveNameAndNumberForm p_DefinitiveNameAndNumberForm) : base ((uint) ProductionID._DefinitiveObjIdComponent_ID, (uint) production_kind.g_DefinitiveObjIdComponent_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinitiveNameAndNumberForm = p_DefinitiveNameAndNumberForm;
		}

		public DefinitiveObjIdComponent () { }

		// Copy constructor

		public DefinitiveObjIdComponent (DefinitiveObjIdComponent p_DefinitiveObjIdComponent) : base (p_DefinitiveObjIdComponent.id, p_DefinitiveObjIdComponent.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DefinitiveObjIdComponent.appInfo;
			switch ((production_kind) p_DefinitiveObjIdComponent.kind)
			{
				case production_kind.g_DefinitiveObjIdComponent_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NameForm = (p_DefinitiveObjIdComponent.m_NameForm != null) ? new NameForm (p_DefinitiveObjIdComponent.m_NameForm) : null) != null) m_NameForm.parent = this;
					break;
				case production_kind.g_DefinitiveObjIdComponent_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinitiveNumberForm = (p_DefinitiveObjIdComponent.m_DefinitiveNumberForm != null) ? new DefinitiveNumberForm (p_DefinitiveObjIdComponent.m_DefinitiveNumberForm) : null) != null) m_DefinitiveNumberForm.parent = this;
					break;
				case production_kind.g_DefinitiveObjIdComponent_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinitiveNameAndNumberForm = (p_DefinitiveObjIdComponent.m_DefinitiveNameAndNumberForm != null) ? new DefinitiveNameAndNumberForm (p_DefinitiveObjIdComponent.m_DefinitiveNameAndNumberForm) : null) != null) m_DefinitiveNameAndNumberForm.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DefinitiveObjIdComponent" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DefinitiveObjIdComponent (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_NameForm?.Dispose ();
			m_DefinitiveNumberForm?.Dispose ();
			m_DefinitiveNameAndNumberForm?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DefinitiveObjIdComponent

		// Content changing function(s) associated with production(s) of syntax rule DefinitiveObjIdComponent

		//
		// Content changing function associated with following production(s)
		// DefinitiveObjIdComponent -> NameForm

		//

		public void change(NameForm p_NameForm)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinitiveObjIdComponent_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NameForm = p_NameForm;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// DefinitiveObjIdComponent -> DefinitiveNumberForm

		//

		public void change(DefinitiveNumberForm p_DefinitiveNumberForm)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinitiveObjIdComponent_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinitiveNumberForm = p_DefinitiveNumberForm;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// DefinitiveObjIdComponent -> DefinitiveNameAndNumberForm

		//

		public void change(DefinitiveNameAndNumberForm p_DefinitiveNameAndNumberForm)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinitiveObjIdComponent_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinitiveNameAndNumberForm = p_DefinitiveNameAndNumberForm;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DefinitiveObjIdComponent
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_NameForm != null) && m_NameForm.checkInclusion (element) ||
				(m_DefinitiveNumberForm != null) && m_DefinitiveNumberForm.checkInclusion (element) ||
				(m_DefinitiveNameAndNumberForm != null) && m_DefinitiveNameAndNumberForm.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DefinitiveObjIdComponent

		//
		// emit production tree node associated with any production of syntax rule DefinitiveObjIdComponent
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DefinitiveObjIdComponent_1:
					// emit syntax tree node associated with production
					// DefinitiveObjIdComponent: NameForm

					s += m_NameForm.Emit (depth - 1);
				break;
				case production_kind.g_DefinitiveObjIdComponent_2:
					// emit syntax tree node associated with production
					// DefinitiveObjIdComponent: DefinitiveNumberForm

					s += m_DefinitiveNumberForm.Emit (depth - 1);
				break;
				case production_kind.g_DefinitiveObjIdComponent_3:
					// emit syntax tree node associated with production
					// DefinitiveObjIdComponent: DefinitiveNameAndNumberForm

					s += m_DefinitiveNameAndNumberForm.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DefinitiveObjIdComponent
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DefinitiveObjIdComponent (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DefinitiveObjIdComponent_1:
					// emit syntax tree node associated with production
					// DefinitiveObjIdComponent: NameForm

					s += m_NameForm.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_DefinitiveObjIdComponent_2:
					// emit syntax tree node associated with production
					// DefinitiveObjIdComponent: DefinitiveNumberForm

					s += m_DefinitiveNumberForm.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_DefinitiveObjIdComponent_3:
					// emit syntax tree node associated with production
					// DefinitiveObjIdComponent: DefinitiveNameAndNumberForm

					s += m_DefinitiveNameAndNumberForm.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DefinitiveObjIdComponent

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveObjIdComponent with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DefinitiveObjIdComponent.production_kind kind = (DefinitiveObjIdComponent.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DefinitiveObjIdComponent.production_kind.g_DefinitiveObjIdComponent_1:
					// traverse syntax tree node associated with production
					// DefinitiveObjIdComponent: NameForm

						m_NameForm.Visit (visitor, appData);
				break;
				case DefinitiveObjIdComponent.production_kind.g_DefinitiveObjIdComponent_2:
					// traverse syntax tree node associated with production
					// DefinitiveObjIdComponent: DefinitiveNumberForm

						m_DefinitiveNumberForm.Visit (visitor, appData);
				break;
				case DefinitiveObjIdComponent.production_kind.g_DefinitiveObjIdComponent_3:
					// traverse syntax tree node associated with production
					// DefinitiveObjIdComponent: DefinitiveNameAndNumberForm

						m_DefinitiveNameAndNumberForm.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_NameForm?.reparent (this);
			m_DefinitiveNumberForm?.reparent (this);
			m_DefinitiveNameAndNumberForm?.reparent (this);
		}

		//
		// initialize object associated with syntax rule DefinitiveObjIdComponent
		//

		public void _init ()
		{
			m_NameForm = null;
			m_DefinitiveNumberForm = null;
			m_DefinitiveNameAndNumberForm = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DefinitiveObjIdComponent

		// counter of all nodes associated with syntax rule DefinitiveObjIdComponent
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DefinitiveObjIdComponent
		[DataMember (Name = "m_NameForm")] public NameForm m_NameForm { get; private set; }
		[DataMember (Name = "m_DefinitiveNumberForm")] public DefinitiveNumberForm m_DefinitiveNumberForm { get; private set; }
		[DataMember (Name = "m_DefinitiveNameAndNumberForm")] public DefinitiveNameAndNumberForm m_DefinitiveNameAndNumberForm { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DefinitiveObjIdComponent

		// delegate function (callback) prototype associated with syntax rule DefinitiveObjIdComponent
		public delegate bool DefinitiveObjIdComponent_Callback (SyntaxTreeCallbackReason reason, DefinitiveObjIdComponent.production_kind kind, DefinitiveObjIdComponent p_DefinitiveObjIdComponent);

		// event associated with syntax rule DefinitiveObjIdComponent
		public event DefinitiveObjIdComponent_Callback DefinitiveObjIdComponent_Event;

		// event trigger associated with syntax rule DefinitiveObjIdComponent
		public bool Raise_DefinitiveObjIdComponent_Event (SyntaxTreeCallbackReason reason, DefinitiveObjIdComponent.production_kind kind, DefinitiveObjIdComponent p_DefinitiveObjIdComponent)
		{
			bool? status = DefinitiveObjIdComponent_Event?.Invoke (reason, kind, p_DefinitiveObjIdComponent);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DefinitiveObjIdComponent
		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveObjIdComponent
		//

		public void Traverse (DefinitiveObjIdComponent p_DefinitiveObjIdComponent)
		{
			if (p_DefinitiveObjIdComponent.isLocked())
				return;
			p_DefinitiveObjIdComponent.dolock();
			DefinitiveObjIdComponent.production_kind kind = (DefinitiveObjIdComponent.production_kind) p_DefinitiveObjIdComponent.kind;
			p_DefinitiveObjIdComponent.turn_reset ();
			if (Raise_DefinitiveObjIdComponent_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DefinitiveObjIdComponent))
			switch (kind)
			{
				case DefinitiveObjIdComponent.production_kind.g_DefinitiveObjIdComponent_1:
					// traverse syntax tree node associated with production
					// DefinitiveObjIdComponent: NameForm

					if (Raise_DefinitiveObjIdComponent_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinitiveObjIdComponent))
						Traverse (p_DefinitiveObjIdComponent.m_NameForm);
					p_DefinitiveObjIdComponent.turn_inc ();
					Raise_DefinitiveObjIdComponent_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinitiveObjIdComponent);
				break;
				case DefinitiveObjIdComponent.production_kind.g_DefinitiveObjIdComponent_2:
					// traverse syntax tree node associated with production
					// DefinitiveObjIdComponent: DefinitiveNumberForm

					if (Raise_DefinitiveObjIdComponent_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinitiveObjIdComponent))
						Traverse (p_DefinitiveObjIdComponent.m_DefinitiveNumberForm);
					p_DefinitiveObjIdComponent.turn_inc ();
					Raise_DefinitiveObjIdComponent_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinitiveObjIdComponent);
				break;
				case DefinitiveObjIdComponent.production_kind.g_DefinitiveObjIdComponent_3:
					// traverse syntax tree node associated with production
					// DefinitiveObjIdComponent: DefinitiveNameAndNumberForm

					if (Raise_DefinitiveObjIdComponent_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinitiveObjIdComponent))
						Traverse (p_DefinitiveObjIdComponent.m_DefinitiveNameAndNumberForm);
					p_DefinitiveObjIdComponent.turn_inc ();
					Raise_DefinitiveObjIdComponent_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinitiveObjIdComponent);
				break;
			}
			Raise_DefinitiveObjIdComponent_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DefinitiveObjIdComponent);
			p_DefinitiveObjIdComponent.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveObjIdComponent
		//

		public void TraverseCommon (DefinitiveObjIdComponent p_DefinitiveObjIdComponent)
		{
			DefinitiveObjIdComponent.production_kind kind = (DefinitiveObjIdComponent.production_kind) p_DefinitiveObjIdComponent.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DefinitiveObjIdComponent))
			switch (kind)
			{
				case DefinitiveObjIdComponent.production_kind.g_DefinitiveObjIdComponent_1:
					// traverse syntax tree node associated with production
					// DefinitiveObjIdComponent: NameForm

						TraverseCommon (p_DefinitiveObjIdComponent.m_NameForm);
				break;
				case DefinitiveObjIdComponent.production_kind.g_DefinitiveObjIdComponent_2:
					// traverse syntax tree node associated with production
					// DefinitiveObjIdComponent: DefinitiveNumberForm

						TraverseCommon (p_DefinitiveObjIdComponent.m_DefinitiveNumberForm);
				break;
				case DefinitiveObjIdComponent.production_kind.g_DefinitiveObjIdComponent_3:
					// traverse syntax tree node associated with production
					// DefinitiveObjIdComponent: DefinitiveNameAndNumberForm

						TraverseCommon (p_DefinitiveObjIdComponent.m_DefinitiveNameAndNumberForm);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DefinitiveObjIdComponent);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DefinitiveObjIdComponent

		//
		// create syntax tree node associated with production
		// DefinitiveObjIdComponent: NameForm

		//

		public DefinitiveObjIdComponent DefinitiveObjIdComponent_1 (NameForm p_NameForm)
		{
			DefinitiveObjIdComponent p_DefinitiveObjIdComponent_ref = new DefinitiveObjIdComponent(p_NameForm);
			p_NameForm.parent = p_DefinitiveObjIdComponent_ref;
			Raise_DefinitiveObjIdComponent_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinitiveObjIdComponent.production_kind.g_DefinitiveObjIdComponent_1, p_DefinitiveObjIdComponent_ref);
			return p_DefinitiveObjIdComponent_ref;
		}

		//
		// create syntax tree node associated with production
		// DefinitiveObjIdComponent: DefinitiveNumberForm

		//

		public DefinitiveObjIdComponent DefinitiveObjIdComponent_2 (DefinitiveNumberForm p_DefinitiveNumberForm)
		{
			DefinitiveObjIdComponent p_DefinitiveObjIdComponent_ref = new DefinitiveObjIdComponent(p_DefinitiveNumberForm);
			p_DefinitiveNumberForm.parent = p_DefinitiveObjIdComponent_ref;
			Raise_DefinitiveObjIdComponent_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinitiveObjIdComponent.production_kind.g_DefinitiveObjIdComponent_2, p_DefinitiveObjIdComponent_ref);
			return p_DefinitiveObjIdComponent_ref;
		}

		//
		// create syntax tree node associated with production
		// DefinitiveObjIdComponent: DefinitiveNameAndNumberForm

		//

		public DefinitiveObjIdComponent DefinitiveObjIdComponent_3 (DefinitiveNameAndNumberForm p_DefinitiveNameAndNumberForm)
		{
			DefinitiveObjIdComponent p_DefinitiveObjIdComponent_ref = new DefinitiveObjIdComponent(p_DefinitiveNameAndNumberForm);
			p_DefinitiveNameAndNumberForm.parent = p_DefinitiveObjIdComponent_ref;
			Raise_DefinitiveObjIdComponent_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinitiveObjIdComponent.production_kind.g_DefinitiveObjIdComponent_3, p_DefinitiveObjIdComponent_ref);
			return p_DefinitiveObjIdComponent_ref;
		}
		#endregion
	};
}
