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
	// class associated with syntax rule RelativeOIDComponents
	//

	[DataContract]
	public class	RelativeOIDComponents : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule RelativeOIDComponents
		public enum production_kind : ushort	// enumerated production(s) of syntax rule RelativeOIDComponents
		{
			g_RelativeOIDComponents_1 = 1,	// NumberForm

			g_RelativeOIDComponents_2 = 2,	// NameAndNumberForm

		};
		#endregion
		#region production markers associated with the syntax rule RelativeOIDComponents

		// markers associated with production: RelativeOIDComponents -> NumberForm

		public enum production_marker_1 : ushort
		{
			m_NumberForm,
			final
		};

		// markers associated with production: RelativeOIDComponents -> NameAndNumberForm

		public enum production_marker_2 : ushort
		{
			m_NameAndNumberForm,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule RelativeOIDComponents

		// Constructor declaration(s) associated with production(s) of syntax rule RelativeOIDComponents

		//
		// Constructor associated with the following production(s)
		// RelativeOIDComponents -> NumberForm

		//

		public RelativeOIDComponents (NumberForm p_NumberForm) : base ((uint) ProductionID._RelativeOIDComponents_ID, (uint) production_kind.g_RelativeOIDComponents_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NumberForm = p_NumberForm;
		}

		//
		// Constructor associated with the following production(s)
		// RelativeOIDComponents -> NameAndNumberForm

		//

		public RelativeOIDComponents (NameAndNumberForm p_NameAndNumberForm) : base ((uint) ProductionID._RelativeOIDComponents_ID, (uint) production_kind.g_RelativeOIDComponents_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NameAndNumberForm = p_NameAndNumberForm;
		}

		public RelativeOIDComponents () { }

		// Copy constructor

		public RelativeOIDComponents (RelativeOIDComponents p_RelativeOIDComponents) : base (p_RelativeOIDComponents.id, p_RelativeOIDComponents.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_RelativeOIDComponents.appInfo;
			switch ((production_kind) p_RelativeOIDComponents.kind)
			{
				case production_kind.g_RelativeOIDComponents_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NumberForm = (p_RelativeOIDComponents.m_NumberForm != null) ? new NumberForm (p_RelativeOIDComponents.m_NumberForm) : null) != null) m_NumberForm.parent = this;
					break;
				case production_kind.g_RelativeOIDComponents_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NameAndNumberForm = (p_RelativeOIDComponents.m_NameAndNumberForm != null) ? new NameAndNumberForm (p_RelativeOIDComponents.m_NameAndNumberForm) : null) != null) m_NameAndNumberForm.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "RelativeOIDComponents" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new RelativeOIDComponents (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_NumberForm?.Dispose ();
			m_NameAndNumberForm?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule RelativeOIDComponents

		// Content changing function(s) associated with production(s) of syntax rule RelativeOIDComponents

		//
		// Content changing function associated with following production(s)
		// RelativeOIDComponents -> NumberForm

		//

		public void change(NumberForm p_NumberForm)
		{
			_init ();
			this.kind = (uint) production_kind.g_RelativeOIDComponents_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NumberForm = p_NumberForm;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// RelativeOIDComponents -> NameAndNumberForm

		//

		public void change(NameAndNumberForm p_NameAndNumberForm)
		{
			_init ();
			this.kind = (uint) production_kind.g_RelativeOIDComponents_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NameAndNumberForm = p_NameAndNumberForm;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule RelativeOIDComponents
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_NumberForm != null) && m_NumberForm.checkInclusion (element) ||
				(m_NameAndNumberForm != null) && m_NameAndNumberForm.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule RelativeOIDComponents

		//
		// emit production tree node associated with any production of syntax rule RelativeOIDComponents
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_RelativeOIDComponents_1:
					// emit syntax tree node associated with production
					// RelativeOIDComponents: NumberForm

					s += m_NumberForm.Emit (depth - 1);
				break;
				case production_kind.g_RelativeOIDComponents_2:
					// emit syntax tree node associated with production
					// RelativeOIDComponents: NameAndNumberForm

					s += m_NameAndNumberForm.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule RelativeOIDComponents
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "RelativeOIDComponents (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_RelativeOIDComponents_1:
					// emit syntax tree node associated with production
					// RelativeOIDComponents: NumberForm

					s += m_NumberForm.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_RelativeOIDComponents_2:
					// emit syntax tree node associated with production
					// RelativeOIDComponents: NameAndNumberForm

					s += m_NameAndNumberForm.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule RelativeOIDComponents

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule RelativeOIDComponents with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			RelativeOIDComponents.production_kind kind = (RelativeOIDComponents.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case RelativeOIDComponents.production_kind.g_RelativeOIDComponents_1:
					// traverse syntax tree node associated with production
					// RelativeOIDComponents: NumberForm

						m_NumberForm.Visit (visitor, appData);
				break;
				case RelativeOIDComponents.production_kind.g_RelativeOIDComponents_2:
					// traverse syntax tree node associated with production
					// RelativeOIDComponents: NameAndNumberForm

						m_NameAndNumberForm.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_NumberForm?.reparent (this);
			m_NameAndNumberForm?.reparent (this);
		}

		//
		// initialize object associated with syntax rule RelativeOIDComponents
		//

		public void _init ()
		{
			m_NumberForm = null;
			m_NameAndNumberForm = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule RelativeOIDComponents

		// counter of all nodes associated with syntax rule RelativeOIDComponents
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule RelativeOIDComponents
		[DataMember (Name = "m_NumberForm")] public NumberForm m_NumberForm { get; private set; }
		[DataMember (Name = "m_NameAndNumberForm")] public NameAndNumberForm m_NameAndNumberForm { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule RelativeOIDComponents

		// delegate function (callback) prototype associated with syntax rule RelativeOIDComponents
		public delegate bool RelativeOIDComponents_Callback (SyntaxTreeCallbackReason reason, RelativeOIDComponents.production_kind kind, RelativeOIDComponents p_RelativeOIDComponents);

		// event associated with syntax rule RelativeOIDComponents
		public event RelativeOIDComponents_Callback RelativeOIDComponents_Event;

		// event trigger associated with syntax rule RelativeOIDComponents
		public bool Raise_RelativeOIDComponents_Event (SyntaxTreeCallbackReason reason, RelativeOIDComponents.production_kind kind, RelativeOIDComponents p_RelativeOIDComponents)
		{
			bool? status = RelativeOIDComponents_Event?.Invoke (reason, kind, p_RelativeOIDComponents);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule RelativeOIDComponents
		//
		// traverse syntax tree node associated with any production of syntax rule RelativeOIDComponents
		//

		public void Traverse (RelativeOIDComponents p_RelativeOIDComponents)
		{
			if (p_RelativeOIDComponents.isLocked())
				return;
			p_RelativeOIDComponents.dolock();
			RelativeOIDComponents.production_kind kind = (RelativeOIDComponents.production_kind) p_RelativeOIDComponents.kind;
			p_RelativeOIDComponents.turn_reset ();
			if (Raise_RelativeOIDComponents_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_RelativeOIDComponents))
			switch (kind)
			{
				case RelativeOIDComponents.production_kind.g_RelativeOIDComponents_1:
					// traverse syntax tree node associated with production
					// RelativeOIDComponents: NumberForm

					if (Raise_RelativeOIDComponents_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RelativeOIDComponents))
						Traverse (p_RelativeOIDComponents.m_NumberForm);
					p_RelativeOIDComponents.turn_inc ();
					Raise_RelativeOIDComponents_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RelativeOIDComponents);
				break;
				case RelativeOIDComponents.production_kind.g_RelativeOIDComponents_2:
					// traverse syntax tree node associated with production
					// RelativeOIDComponents: NameAndNumberForm

					if (Raise_RelativeOIDComponents_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RelativeOIDComponents))
						Traverse (p_RelativeOIDComponents.m_NameAndNumberForm);
					p_RelativeOIDComponents.turn_inc ();
					Raise_RelativeOIDComponents_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RelativeOIDComponents);
				break;
			}
			Raise_RelativeOIDComponents_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_RelativeOIDComponents);
			p_RelativeOIDComponents.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule RelativeOIDComponents
		//

		public void TraverseCommon (RelativeOIDComponents p_RelativeOIDComponents)
		{
			RelativeOIDComponents.production_kind kind = (RelativeOIDComponents.production_kind) p_RelativeOIDComponents.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_RelativeOIDComponents))
			switch (kind)
			{
				case RelativeOIDComponents.production_kind.g_RelativeOIDComponents_1:
					// traverse syntax tree node associated with production
					// RelativeOIDComponents: NumberForm

						TraverseCommon (p_RelativeOIDComponents.m_NumberForm);
				break;
				case RelativeOIDComponents.production_kind.g_RelativeOIDComponents_2:
					// traverse syntax tree node associated with production
					// RelativeOIDComponents: NameAndNumberForm

						TraverseCommon (p_RelativeOIDComponents.m_NameAndNumberForm);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_RelativeOIDComponents);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule RelativeOIDComponents

		//
		// create syntax tree node associated with production
		// RelativeOIDComponents: NumberForm

		//

		public RelativeOIDComponents RelativeOIDComponents_1 (NumberForm p_NumberForm)
		{
			RelativeOIDComponents p_RelativeOIDComponents_ref = new RelativeOIDComponents(p_NumberForm);
			p_NumberForm.parent = p_RelativeOIDComponents_ref;
			Raise_RelativeOIDComponents_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RelativeOIDComponents.production_kind.g_RelativeOIDComponents_1, p_RelativeOIDComponents_ref);
			return p_RelativeOIDComponents_ref;
		}

		//
		// create syntax tree node associated with production
		// RelativeOIDComponents: NameAndNumberForm

		//

		public RelativeOIDComponents RelativeOIDComponents_2 (NameAndNumberForm p_NameAndNumberForm)
		{
			RelativeOIDComponents p_RelativeOIDComponents_ref = new RelativeOIDComponents(p_NameAndNumberForm);
			p_NameAndNumberForm.parent = p_RelativeOIDComponents_ref;
			Raise_RelativeOIDComponents_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RelativeOIDComponents.production_kind.g_RelativeOIDComponents_2, p_RelativeOIDComponents_ref);
			return p_RelativeOIDComponents_ref;
		}
		#endregion
	};
}
