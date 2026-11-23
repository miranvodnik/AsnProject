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
	// class associated with syntax rule ObjIdComponents
	//

	[DataContract]
	public class	ObjIdComponents : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjIdComponents
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjIdComponents
		{
			g_ObjIdComponents_1 = 1,	// NameForm

			g_ObjIdComponents_2 = 2,	// NumberForm

			g_ObjIdComponents_3 = 3,	// NameAndNumberForm

		};
		#endregion
		#region production markers associated with the syntax rule ObjIdComponents

		// markers associated with production: ObjIdComponents -> NameForm

		public enum production_marker_1 : ushort
		{
			m_NameForm,
			final
		};

		// markers associated with production: ObjIdComponents -> NumberForm

		public enum production_marker_2 : ushort
		{
			m_NumberForm,
			final
		};

		// markers associated with production: ObjIdComponents -> NameAndNumberForm

		public enum production_marker_3 : ushort
		{
			m_NameAndNumberForm,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjIdComponents

		// Constructor declaration(s) associated with production(s) of syntax rule ObjIdComponents

		//
		// Constructor associated with the following production(s)
		// ObjIdComponents -> NameForm

		//

		public ObjIdComponents (NameForm p_NameForm) : base ((uint) ProductionID._ObjIdComponents_ID, (uint) production_kind.g_ObjIdComponents_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NameForm = p_NameForm;
		}

		//
		// Constructor associated with the following production(s)
		// ObjIdComponents -> NumberForm

		//

		public ObjIdComponents (NumberForm p_NumberForm) : base ((uint) ProductionID._ObjIdComponents_ID, (uint) production_kind.g_ObjIdComponents_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NumberForm = p_NumberForm;
		}

		//
		// Constructor associated with the following production(s)
		// ObjIdComponents -> NameAndNumberForm

		//

		public ObjIdComponents (NameAndNumberForm p_NameAndNumberForm) : base ((uint) ProductionID._ObjIdComponents_ID, (uint) production_kind.g_ObjIdComponents_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NameAndNumberForm = p_NameAndNumberForm;
		}

		public ObjIdComponents () { }

		// Copy constructor

		public ObjIdComponents (ObjIdComponents p_ObjIdComponents) : base (p_ObjIdComponents.id, p_ObjIdComponents.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjIdComponents.appInfo;
			switch ((production_kind) p_ObjIdComponents.kind)
			{
				case production_kind.g_ObjIdComponents_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NameForm = (p_ObjIdComponents.m_NameForm != null) ? new NameForm (p_ObjIdComponents.m_NameForm) : null) != null) m_NameForm.parent = this;
					break;
				case production_kind.g_ObjIdComponents_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NumberForm = (p_ObjIdComponents.m_NumberForm != null) ? new NumberForm (p_ObjIdComponents.m_NumberForm) : null) != null) m_NumberForm.parent = this;
					break;
				case production_kind.g_ObjIdComponents_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NameAndNumberForm = (p_ObjIdComponents.m_NameAndNumberForm != null) ? new NameAndNumberForm (p_ObjIdComponents.m_NameAndNumberForm) : null) != null) m_NameAndNumberForm.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjIdComponents" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjIdComponents (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_NameForm?.Dispose ();
			m_NumberForm?.Dispose ();
			m_NameAndNumberForm?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjIdComponents

		// Content changing function(s) associated with production(s) of syntax rule ObjIdComponents

		//
		// Content changing function associated with following production(s)
		// ObjIdComponents -> NameForm

		//

		public void change(NameForm p_NameForm)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjIdComponents_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NameForm = p_NameForm;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ObjIdComponents -> NumberForm

		//

		public void change(NumberForm p_NumberForm)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjIdComponents_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NumberForm = p_NumberForm;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ObjIdComponents -> NameAndNumberForm

		//

		public void change(NameAndNumberForm p_NameAndNumberForm)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjIdComponents_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NameAndNumberForm = p_NameAndNumberForm;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjIdComponents
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_NameForm != null) && m_NameForm.checkInclusion (element) ||
				(m_NumberForm != null) && m_NumberForm.checkInclusion (element) ||
				(m_NameAndNumberForm != null) && m_NameAndNumberForm.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjIdComponents

		//
		// emit production tree node associated with any production of syntax rule ObjIdComponents
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjIdComponents_1:
					// emit syntax tree node associated with production
					// ObjIdComponents: NameForm

					s += m_NameForm.Emit (depth - 1);
				break;
				case production_kind.g_ObjIdComponents_2:
					// emit syntax tree node associated with production
					// ObjIdComponents: NumberForm

					s += m_NumberForm.Emit (depth - 1);
				break;
				case production_kind.g_ObjIdComponents_3:
					// emit syntax tree node associated with production
					// ObjIdComponents: NameAndNumberForm

					s += m_NameAndNumberForm.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjIdComponents
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjIdComponents (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjIdComponents_1:
					// emit syntax tree node associated with production
					// ObjIdComponents: NameForm

					s += m_NameForm.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ObjIdComponents_2:
					// emit syntax tree node associated with production
					// ObjIdComponents: NumberForm

					s += m_NumberForm.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ObjIdComponents_3:
					// emit syntax tree node associated with production
					// ObjIdComponents: NameAndNumberForm

					s += m_NameAndNumberForm.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjIdComponents

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjIdComponents with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjIdComponents.production_kind kind = (ObjIdComponents.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjIdComponents.production_kind.g_ObjIdComponents_1:
					// traverse syntax tree node associated with production
					// ObjIdComponents: NameForm

						m_NameForm.Visit (visitor, appData);
				break;
				case ObjIdComponents.production_kind.g_ObjIdComponents_2:
					// traverse syntax tree node associated with production
					// ObjIdComponents: NumberForm

						m_NumberForm.Visit (visitor, appData);
				break;
				case ObjIdComponents.production_kind.g_ObjIdComponents_3:
					// traverse syntax tree node associated with production
					// ObjIdComponents: NameAndNumberForm

						m_NameAndNumberForm.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_NameForm?.reparent (this);
			m_NumberForm?.reparent (this);
			m_NameAndNumberForm?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjIdComponents
		//

		public void _init ()
		{
			m_NameForm = null;
			m_NumberForm = null;
			m_NameAndNumberForm = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjIdComponents

		// counter of all nodes associated with syntax rule ObjIdComponents
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjIdComponents
		[DataMember (Name = "m_NameForm")] public NameForm m_NameForm { get; private set; }
		[DataMember (Name = "m_NumberForm")] public NumberForm m_NumberForm { get; private set; }
		[DataMember (Name = "m_NameAndNumberForm")] public NameAndNumberForm m_NameAndNumberForm { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjIdComponents

		// delegate function (callback) prototype associated with syntax rule ObjIdComponents
		public delegate bool ObjIdComponents_Callback (SyntaxTreeCallbackReason reason, ObjIdComponents.production_kind kind, ObjIdComponents p_ObjIdComponents);

		// event associated with syntax rule ObjIdComponents
		public event ObjIdComponents_Callback ObjIdComponents_Event;

		// event trigger associated with syntax rule ObjIdComponents
		public bool Raise_ObjIdComponents_Event (SyntaxTreeCallbackReason reason, ObjIdComponents.production_kind kind, ObjIdComponents p_ObjIdComponents)
		{
			bool? status = ObjIdComponents_Event?.Invoke (reason, kind, p_ObjIdComponents);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjIdComponents
		//
		// traverse syntax tree node associated with any production of syntax rule ObjIdComponents
		//

		public void Traverse (ObjIdComponents p_ObjIdComponents)
		{
			if (p_ObjIdComponents.isLocked())
				return;
			p_ObjIdComponents.dolock();
			ObjIdComponents.production_kind kind = (ObjIdComponents.production_kind) p_ObjIdComponents.kind;
			p_ObjIdComponents.turn_reset ();
			if (Raise_ObjIdComponents_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjIdComponents))
			switch (kind)
			{
				case ObjIdComponents.production_kind.g_ObjIdComponents_1:
					// traverse syntax tree node associated with production
					// ObjIdComponents: NameForm

					if (Raise_ObjIdComponents_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjIdComponents))
						Traverse (p_ObjIdComponents.m_NameForm);
					p_ObjIdComponents.turn_inc ();
					Raise_ObjIdComponents_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjIdComponents);
				break;
				case ObjIdComponents.production_kind.g_ObjIdComponents_2:
					// traverse syntax tree node associated with production
					// ObjIdComponents: NumberForm

					if (Raise_ObjIdComponents_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjIdComponents))
						Traverse (p_ObjIdComponents.m_NumberForm);
					p_ObjIdComponents.turn_inc ();
					Raise_ObjIdComponents_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjIdComponents);
				break;
				case ObjIdComponents.production_kind.g_ObjIdComponents_3:
					// traverse syntax tree node associated with production
					// ObjIdComponents: NameAndNumberForm

					if (Raise_ObjIdComponents_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjIdComponents))
						Traverse (p_ObjIdComponents.m_NameAndNumberForm);
					p_ObjIdComponents.turn_inc ();
					Raise_ObjIdComponents_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjIdComponents);
				break;
			}
			Raise_ObjIdComponents_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjIdComponents);
			p_ObjIdComponents.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjIdComponents
		//

		public void TraverseCommon (ObjIdComponents p_ObjIdComponents)
		{
			ObjIdComponents.production_kind kind = (ObjIdComponents.production_kind) p_ObjIdComponents.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjIdComponents))
			switch (kind)
			{
				case ObjIdComponents.production_kind.g_ObjIdComponents_1:
					// traverse syntax tree node associated with production
					// ObjIdComponents: NameForm

						TraverseCommon (p_ObjIdComponents.m_NameForm);
				break;
				case ObjIdComponents.production_kind.g_ObjIdComponents_2:
					// traverse syntax tree node associated with production
					// ObjIdComponents: NumberForm

						TraverseCommon (p_ObjIdComponents.m_NumberForm);
				break;
				case ObjIdComponents.production_kind.g_ObjIdComponents_3:
					// traverse syntax tree node associated with production
					// ObjIdComponents: NameAndNumberForm

						TraverseCommon (p_ObjIdComponents.m_NameAndNumberForm);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjIdComponents);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjIdComponents

		//
		// create syntax tree node associated with production
		// ObjIdComponents: NameForm

		//

		public ObjIdComponents ObjIdComponents_1 (NameForm p_NameForm)
		{
			ObjIdComponents p_ObjIdComponents_ref = new ObjIdComponents(p_NameForm);
			p_NameForm.parent = p_ObjIdComponents_ref;
			Raise_ObjIdComponents_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjIdComponents.production_kind.g_ObjIdComponents_1, p_ObjIdComponents_ref);
			return p_ObjIdComponents_ref;
		}

		//
		// create syntax tree node associated with production
		// ObjIdComponents: NumberForm

		//

		public ObjIdComponents ObjIdComponents_2 (NumberForm p_NumberForm)
		{
			ObjIdComponents p_ObjIdComponents_ref = new ObjIdComponents(p_NumberForm);
			p_NumberForm.parent = p_ObjIdComponents_ref;
			Raise_ObjIdComponents_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjIdComponents.production_kind.g_ObjIdComponents_2, p_ObjIdComponents_ref);
			return p_ObjIdComponents_ref;
		}

		//
		// create syntax tree node associated with production
		// ObjIdComponents: NameAndNumberForm

		//

		public ObjIdComponents ObjIdComponents_3 (NameAndNumberForm p_NameAndNumberForm)
		{
			ObjIdComponents p_ObjIdComponents_ref = new ObjIdComponents(p_NameAndNumberForm);
			p_NameAndNumberForm.parent = p_ObjIdComponents_ref;
			Raise_ObjIdComponents_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjIdComponents.production_kind.g_ObjIdComponents_3, p_ObjIdComponents_ref);
			return p_ObjIdComponents_ref;
		}
		#endregion
	};
}
