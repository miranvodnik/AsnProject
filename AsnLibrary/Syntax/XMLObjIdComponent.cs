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
	// class associated with syntax rule XMLObjIdComponent
	//

	[DataContract]
	public class	XMLObjIdComponent : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLObjIdComponent
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLObjIdComponent
		{
			g_XMLObjIdComponent_1 = 1,	// NameForm

			g_XMLObjIdComponent_2 = 2,	// XMLNumberForm

			g_XMLObjIdComponent_3 = 3,	// XMLNameAndNumberForm

		};
		#endregion
		#region production markers associated with the syntax rule XMLObjIdComponent

		// markers associated with production: XMLObjIdComponent -> NameForm

		public enum production_marker_1 : ushort
		{
			m_NameForm,
			final
		};

		// markers associated with production: XMLObjIdComponent -> XMLNumberForm

		public enum production_marker_2 : ushort
		{
			m_XMLNumberForm,
			final
		};

		// markers associated with production: XMLObjIdComponent -> XMLNameAndNumberForm

		public enum production_marker_3 : ushort
		{
			m_XMLNameAndNumberForm,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLObjIdComponent

		// Constructor declaration(s) associated with production(s) of syntax rule XMLObjIdComponent

		//
		// Constructor associated with the following production(s)
		// XMLObjIdComponent -> NameForm

		//

		public XMLObjIdComponent (NameForm p_NameForm) : base ((uint) ProductionID._XMLObjIdComponent_ID, (uint) production_kind.g_XMLObjIdComponent_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NameForm = p_NameForm;
		}

		//
		// Constructor associated with the following production(s)
		// XMLObjIdComponent -> XMLNumberForm

		//

		public XMLObjIdComponent (XMLNumberForm p_XMLNumberForm) : base ((uint) ProductionID._XMLObjIdComponent_ID, (uint) production_kind.g_XMLObjIdComponent_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLNumberForm = p_XMLNumberForm;
		}

		//
		// Constructor associated with the following production(s)
		// XMLObjIdComponent -> XMLNameAndNumberForm

		//

		public XMLObjIdComponent (XMLNameAndNumberForm p_XMLNameAndNumberForm) : base ((uint) ProductionID._XMLObjIdComponent_ID, (uint) production_kind.g_XMLObjIdComponent_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLNameAndNumberForm = p_XMLNameAndNumberForm;
		}

		public XMLObjIdComponent () { }

		// Copy constructor

		public XMLObjIdComponent (XMLObjIdComponent p_XMLObjIdComponent) : base (p_XMLObjIdComponent.id, p_XMLObjIdComponent.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLObjIdComponent.appInfo;
			switch ((production_kind) p_XMLObjIdComponent.kind)
			{
				case production_kind.g_XMLObjIdComponent_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NameForm = (p_XMLObjIdComponent.m_NameForm != null) ? new NameForm (p_XMLObjIdComponent.m_NameForm) : null) != null) m_NameForm.parent = this;
					break;
				case production_kind.g_XMLObjIdComponent_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLNumberForm = (p_XMLObjIdComponent.m_XMLNumberForm != null) ? new XMLNumberForm (p_XMLObjIdComponent.m_XMLNumberForm) : null) != null) m_XMLNumberForm.parent = this;
					break;
				case production_kind.g_XMLObjIdComponent_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLNameAndNumberForm = (p_XMLObjIdComponent.m_XMLNameAndNumberForm != null) ? new XMLNameAndNumberForm (p_XMLObjIdComponent.m_XMLNameAndNumberForm) : null) != null) m_XMLNameAndNumberForm.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLObjIdComponent" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLObjIdComponent (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_NameForm?.Dispose ();
			m_XMLNumberForm?.Dispose ();
			m_XMLNameAndNumberForm?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLObjIdComponent

		// Content changing function(s) associated with production(s) of syntax rule XMLObjIdComponent

		//
		// Content changing function associated with following production(s)
		// XMLObjIdComponent -> NameForm

		//

		public void change(NameForm p_NameForm)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLObjIdComponent_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NameForm = p_NameForm;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLObjIdComponent -> XMLNumberForm

		//

		public void change(XMLNumberForm p_XMLNumberForm)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLObjIdComponent_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLNumberForm = p_XMLNumberForm;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLObjIdComponent -> XMLNameAndNumberForm

		//

		public void change(XMLNameAndNumberForm p_XMLNameAndNumberForm)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLObjIdComponent_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLNameAndNumberForm = p_XMLNameAndNumberForm;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLObjIdComponent
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_NameForm != null) && m_NameForm.checkInclusion (element) ||
				(m_XMLNumberForm != null) && m_XMLNumberForm.checkInclusion (element) ||
				(m_XMLNameAndNumberForm != null) && m_XMLNameAndNumberForm.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLObjIdComponent

		//
		// emit production tree node associated with any production of syntax rule XMLObjIdComponent
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLObjIdComponent_1:
					// emit syntax tree node associated with production
					// XMLObjIdComponent: NameForm

					s += m_NameForm.Emit (depth - 1);
				break;
				case production_kind.g_XMLObjIdComponent_2:
					// emit syntax tree node associated with production
					// XMLObjIdComponent: XMLNumberForm

					s += m_XMLNumberForm.Emit (depth - 1);
				break;
				case production_kind.g_XMLObjIdComponent_3:
					// emit syntax tree node associated with production
					// XMLObjIdComponent: XMLNameAndNumberForm

					s += m_XMLNameAndNumberForm.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLObjIdComponent
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLObjIdComponent (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLObjIdComponent_1:
					// emit syntax tree node associated with production
					// XMLObjIdComponent: NameForm

					s += m_NameForm.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLObjIdComponent_2:
					// emit syntax tree node associated with production
					// XMLObjIdComponent: XMLNumberForm

					s += m_XMLNumberForm.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLObjIdComponent_3:
					// emit syntax tree node associated with production
					// XMLObjIdComponent: XMLNameAndNumberForm

					s += m_XMLNameAndNumberForm.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLObjIdComponent

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLObjIdComponent with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLObjIdComponent.production_kind kind = (XMLObjIdComponent.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLObjIdComponent.production_kind.g_XMLObjIdComponent_1:
					// traverse syntax tree node associated with production
					// XMLObjIdComponent: NameForm

						m_NameForm.Visit (visitor, appData);
				break;
				case XMLObjIdComponent.production_kind.g_XMLObjIdComponent_2:
					// traverse syntax tree node associated with production
					// XMLObjIdComponent: XMLNumberForm

						m_XMLNumberForm.Visit (visitor, appData);
				break;
				case XMLObjIdComponent.production_kind.g_XMLObjIdComponent_3:
					// traverse syntax tree node associated with production
					// XMLObjIdComponent: XMLNameAndNumberForm

						m_XMLNameAndNumberForm.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_NameForm?.reparent (this);
			m_XMLNumberForm?.reparent (this);
			m_XMLNameAndNumberForm?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLObjIdComponent
		//

		public void _init ()
		{
			m_NameForm = null;
			m_XMLNumberForm = null;
			m_XMLNameAndNumberForm = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLObjIdComponent

		// counter of all nodes associated with syntax rule XMLObjIdComponent
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLObjIdComponent
		[DataMember (Name = "m_NameForm")] public NameForm m_NameForm { get; private set; }
		[DataMember (Name = "m_XMLNumberForm")] public XMLNumberForm m_XMLNumberForm { get; private set; }
		[DataMember (Name = "m_XMLNameAndNumberForm")] public XMLNameAndNumberForm m_XMLNameAndNumberForm { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLObjIdComponent

		// delegate function (callback) prototype associated with syntax rule XMLObjIdComponent
		public delegate bool XMLObjIdComponent_Callback (SyntaxTreeCallbackReason reason, XMLObjIdComponent.production_kind kind, XMLObjIdComponent p_XMLObjIdComponent);

		// event associated with syntax rule XMLObjIdComponent
		public event XMLObjIdComponent_Callback XMLObjIdComponent_Event;

		// event trigger associated with syntax rule XMLObjIdComponent
		public bool Raise_XMLObjIdComponent_Event (SyntaxTreeCallbackReason reason, XMLObjIdComponent.production_kind kind, XMLObjIdComponent p_XMLObjIdComponent)
		{
			bool? status = XMLObjIdComponent_Event?.Invoke (reason, kind, p_XMLObjIdComponent);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLObjIdComponent
		//
		// traverse syntax tree node associated with any production of syntax rule XMLObjIdComponent
		//

		public void Traverse (XMLObjIdComponent p_XMLObjIdComponent)
		{
			if (p_XMLObjIdComponent.isLocked())
				return;
			p_XMLObjIdComponent.dolock();
			XMLObjIdComponent.production_kind kind = (XMLObjIdComponent.production_kind) p_XMLObjIdComponent.kind;
			p_XMLObjIdComponent.turn_reset ();
			if (Raise_XMLObjIdComponent_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLObjIdComponent))
			switch (kind)
			{
				case XMLObjIdComponent.production_kind.g_XMLObjIdComponent_1:
					// traverse syntax tree node associated with production
					// XMLObjIdComponent: NameForm

					if (Raise_XMLObjIdComponent_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLObjIdComponent))
						Traverse (p_XMLObjIdComponent.m_NameForm);
					p_XMLObjIdComponent.turn_inc ();
					Raise_XMLObjIdComponent_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLObjIdComponent);
				break;
				case XMLObjIdComponent.production_kind.g_XMLObjIdComponent_2:
					// traverse syntax tree node associated with production
					// XMLObjIdComponent: XMLNumberForm

					if (Raise_XMLObjIdComponent_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLObjIdComponent))
						Traverse (p_XMLObjIdComponent.m_XMLNumberForm);
					p_XMLObjIdComponent.turn_inc ();
					Raise_XMLObjIdComponent_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLObjIdComponent);
				break;
				case XMLObjIdComponent.production_kind.g_XMLObjIdComponent_3:
					// traverse syntax tree node associated with production
					// XMLObjIdComponent: XMLNameAndNumberForm

					if (Raise_XMLObjIdComponent_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLObjIdComponent))
						Traverse (p_XMLObjIdComponent.m_XMLNameAndNumberForm);
					p_XMLObjIdComponent.turn_inc ();
					Raise_XMLObjIdComponent_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLObjIdComponent);
				break;
			}
			Raise_XMLObjIdComponent_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLObjIdComponent);
			p_XMLObjIdComponent.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLObjIdComponent
		//

		public void TraverseCommon (XMLObjIdComponent p_XMLObjIdComponent)
		{
			XMLObjIdComponent.production_kind kind = (XMLObjIdComponent.production_kind) p_XMLObjIdComponent.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLObjIdComponent))
			switch (kind)
			{
				case XMLObjIdComponent.production_kind.g_XMLObjIdComponent_1:
					// traverse syntax tree node associated with production
					// XMLObjIdComponent: NameForm

						TraverseCommon (p_XMLObjIdComponent.m_NameForm);
				break;
				case XMLObjIdComponent.production_kind.g_XMLObjIdComponent_2:
					// traverse syntax tree node associated with production
					// XMLObjIdComponent: XMLNumberForm

						TraverseCommon (p_XMLObjIdComponent.m_XMLNumberForm);
				break;
				case XMLObjIdComponent.production_kind.g_XMLObjIdComponent_3:
					// traverse syntax tree node associated with production
					// XMLObjIdComponent: XMLNameAndNumberForm

						TraverseCommon (p_XMLObjIdComponent.m_XMLNameAndNumberForm);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLObjIdComponent);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLObjIdComponent

		//
		// create syntax tree node associated with production
		// XMLObjIdComponent: NameForm

		//

		public XMLObjIdComponent XMLObjIdComponent_1 (NameForm p_NameForm)
		{
			XMLObjIdComponent p_XMLObjIdComponent_ref = new XMLObjIdComponent(p_NameForm);
			p_NameForm.parent = p_XMLObjIdComponent_ref;
			Raise_XMLObjIdComponent_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLObjIdComponent.production_kind.g_XMLObjIdComponent_1, p_XMLObjIdComponent_ref);
			return p_XMLObjIdComponent_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLObjIdComponent: XMLNumberForm

		//

		public XMLObjIdComponent XMLObjIdComponent_2 (XMLNumberForm p_XMLNumberForm)
		{
			XMLObjIdComponent p_XMLObjIdComponent_ref = new XMLObjIdComponent(p_XMLNumberForm);
			p_XMLNumberForm.parent = p_XMLObjIdComponent_ref;
			Raise_XMLObjIdComponent_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLObjIdComponent.production_kind.g_XMLObjIdComponent_2, p_XMLObjIdComponent_ref);
			return p_XMLObjIdComponent_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLObjIdComponent: XMLNameAndNumberForm

		//

		public XMLObjIdComponent XMLObjIdComponent_3 (XMLNameAndNumberForm p_XMLNameAndNumberForm)
		{
			XMLObjIdComponent p_XMLObjIdComponent_ref = new XMLObjIdComponent(p_XMLNameAndNumberForm);
			p_XMLNameAndNumberForm.parent = p_XMLObjIdComponent_ref;
			Raise_XMLObjIdComponent_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLObjIdComponent.production_kind.g_XMLObjIdComponent_3, p_XMLObjIdComponent_ref);
			return p_XMLObjIdComponent_ref;
		}
		#endregion
	};
}
