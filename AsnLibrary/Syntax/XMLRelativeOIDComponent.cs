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
	// class associated with syntax rule XMLRelativeOIDComponent
	//

	[DataContract]
	public class	XMLRelativeOIDComponent : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLRelativeOIDComponent
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLRelativeOIDComponent
		{
			g_XMLRelativeOIDComponent_1 = 1,	// XMLNumberForm

			g_XMLRelativeOIDComponent_2 = 2,	// XMLNameAndNumberForm

		};
		#endregion
		#region production markers associated with the syntax rule XMLRelativeOIDComponent

		// markers associated with production: XMLRelativeOIDComponent -> XMLNumberForm

		public enum production_marker_1 : ushort
		{
			m_XMLNumberForm,
			final
		};

		// markers associated with production: XMLRelativeOIDComponent -> XMLNameAndNumberForm

		public enum production_marker_2 : ushort
		{
			m_XMLNameAndNumberForm,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLRelativeOIDComponent

		// Constructor declaration(s) associated with production(s) of syntax rule XMLRelativeOIDComponent

		//
		// Constructor associated with the following production(s)
		// XMLRelativeOIDComponent -> XMLNumberForm

		//

		public XMLRelativeOIDComponent (XMLNumberForm p_XMLNumberForm) : base ((uint) ProductionID._XMLRelativeOIDComponent_ID, (uint) production_kind.g_XMLRelativeOIDComponent_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLNumberForm = p_XMLNumberForm;
		}

		//
		// Constructor associated with the following production(s)
		// XMLRelativeOIDComponent -> XMLNameAndNumberForm

		//

		public XMLRelativeOIDComponent (XMLNameAndNumberForm p_XMLNameAndNumberForm) : base ((uint) ProductionID._XMLRelativeOIDComponent_ID, (uint) production_kind.g_XMLRelativeOIDComponent_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLNameAndNumberForm = p_XMLNameAndNumberForm;
		}

		public XMLRelativeOIDComponent () { }

		// Copy constructor

		public XMLRelativeOIDComponent (XMLRelativeOIDComponent p_XMLRelativeOIDComponent) : base (p_XMLRelativeOIDComponent.id, p_XMLRelativeOIDComponent.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLRelativeOIDComponent.appInfo;
			switch ((production_kind) p_XMLRelativeOIDComponent.kind)
			{
				case production_kind.g_XMLRelativeOIDComponent_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLNumberForm = (p_XMLRelativeOIDComponent.m_XMLNumberForm != null) ? new XMLNumberForm (p_XMLRelativeOIDComponent.m_XMLNumberForm) : null) != null) m_XMLNumberForm.parent = this;
					break;
				case production_kind.g_XMLRelativeOIDComponent_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLNameAndNumberForm = (p_XMLRelativeOIDComponent.m_XMLNameAndNumberForm != null) ? new XMLNameAndNumberForm (p_XMLRelativeOIDComponent.m_XMLNameAndNumberForm) : null) != null) m_XMLNameAndNumberForm.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLRelativeOIDComponent" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLRelativeOIDComponent (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLNumberForm?.Dispose ();
			m_XMLNameAndNumberForm?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLRelativeOIDComponent

		// Content changing function(s) associated with production(s) of syntax rule XMLRelativeOIDComponent

		//
		// Content changing function associated with following production(s)
		// XMLRelativeOIDComponent -> XMLNumberForm

		//

		public void change(XMLNumberForm p_XMLNumberForm)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLRelativeOIDComponent_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLNumberForm = p_XMLNumberForm;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLRelativeOIDComponent -> XMLNameAndNumberForm

		//

		public void change(XMLNameAndNumberForm p_XMLNameAndNumberForm)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLRelativeOIDComponent_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLNameAndNumberForm = p_XMLNameAndNumberForm;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLRelativeOIDComponent
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLNumberForm != null) && m_XMLNumberForm.checkInclusion (element) ||
				(m_XMLNameAndNumberForm != null) && m_XMLNameAndNumberForm.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLRelativeOIDComponent

		//
		// emit production tree node associated with any production of syntax rule XMLRelativeOIDComponent
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLRelativeOIDComponent_1:
					// emit syntax tree node associated with production
					// XMLRelativeOIDComponent: XMLNumberForm

					s += m_XMLNumberForm.Emit (depth - 1);
				break;
				case production_kind.g_XMLRelativeOIDComponent_2:
					// emit syntax tree node associated with production
					// XMLRelativeOIDComponent: XMLNameAndNumberForm

					s += m_XMLNameAndNumberForm.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLRelativeOIDComponent
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLRelativeOIDComponent (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLRelativeOIDComponent_1:
					// emit syntax tree node associated with production
					// XMLRelativeOIDComponent: XMLNumberForm

					s += m_XMLNumberForm.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLRelativeOIDComponent_2:
					// emit syntax tree node associated with production
					// XMLRelativeOIDComponent: XMLNameAndNumberForm

					s += m_XMLNameAndNumberForm.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLRelativeOIDComponent

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLRelativeOIDComponent with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLRelativeOIDComponent.production_kind kind = (XMLRelativeOIDComponent.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLRelativeOIDComponent.production_kind.g_XMLRelativeOIDComponent_1:
					// traverse syntax tree node associated with production
					// XMLRelativeOIDComponent: XMLNumberForm

						m_XMLNumberForm.Visit (visitor, appData);
				break;
				case XMLRelativeOIDComponent.production_kind.g_XMLRelativeOIDComponent_2:
					// traverse syntax tree node associated with production
					// XMLRelativeOIDComponent: XMLNameAndNumberForm

						m_XMLNameAndNumberForm.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_XMLNumberForm?.reparent (this);
			m_XMLNameAndNumberForm?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLRelativeOIDComponent
		//

		public void _init ()
		{
			m_XMLNumberForm = null;
			m_XMLNameAndNumberForm = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLRelativeOIDComponent

		// counter of all nodes associated with syntax rule XMLRelativeOIDComponent
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLRelativeOIDComponent
		[DataMember (Name = "m_XMLNumberForm")] public XMLNumberForm m_XMLNumberForm { get; private set; }
		[DataMember (Name = "m_XMLNameAndNumberForm")] public XMLNameAndNumberForm m_XMLNameAndNumberForm { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLRelativeOIDComponent

		// delegate function (callback) prototype associated with syntax rule XMLRelativeOIDComponent
		public delegate bool XMLRelativeOIDComponent_Callback (SyntaxTreeCallbackReason reason, XMLRelativeOIDComponent.production_kind kind, XMLRelativeOIDComponent p_XMLRelativeOIDComponent);

		// event associated with syntax rule XMLRelativeOIDComponent
		public event XMLRelativeOIDComponent_Callback XMLRelativeOIDComponent_Event;

		// event trigger associated with syntax rule XMLRelativeOIDComponent
		public bool Raise_XMLRelativeOIDComponent_Event (SyntaxTreeCallbackReason reason, XMLRelativeOIDComponent.production_kind kind, XMLRelativeOIDComponent p_XMLRelativeOIDComponent)
		{
			bool? status = XMLRelativeOIDComponent_Event?.Invoke (reason, kind, p_XMLRelativeOIDComponent);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLRelativeOIDComponent
		//
		// traverse syntax tree node associated with any production of syntax rule XMLRelativeOIDComponent
		//

		public void Traverse (XMLRelativeOIDComponent p_XMLRelativeOIDComponent)
		{
			if (p_XMLRelativeOIDComponent.isLocked())
				return;
			p_XMLRelativeOIDComponent.dolock();
			XMLRelativeOIDComponent.production_kind kind = (XMLRelativeOIDComponent.production_kind) p_XMLRelativeOIDComponent.kind;
			p_XMLRelativeOIDComponent.turn_reset ();
			if (Raise_XMLRelativeOIDComponent_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLRelativeOIDComponent))
			switch (kind)
			{
				case XMLRelativeOIDComponent.production_kind.g_XMLRelativeOIDComponent_1:
					// traverse syntax tree node associated with production
					// XMLRelativeOIDComponent: XMLNumberForm

					if (Raise_XMLRelativeOIDComponent_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLRelativeOIDComponent))
						Traverse (p_XMLRelativeOIDComponent.m_XMLNumberForm);
					p_XMLRelativeOIDComponent.turn_inc ();
					Raise_XMLRelativeOIDComponent_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLRelativeOIDComponent);
				break;
				case XMLRelativeOIDComponent.production_kind.g_XMLRelativeOIDComponent_2:
					// traverse syntax tree node associated with production
					// XMLRelativeOIDComponent: XMLNameAndNumberForm

					if (Raise_XMLRelativeOIDComponent_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLRelativeOIDComponent))
						Traverse (p_XMLRelativeOIDComponent.m_XMLNameAndNumberForm);
					p_XMLRelativeOIDComponent.turn_inc ();
					Raise_XMLRelativeOIDComponent_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLRelativeOIDComponent);
				break;
			}
			Raise_XMLRelativeOIDComponent_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLRelativeOIDComponent);
			p_XMLRelativeOIDComponent.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLRelativeOIDComponent
		//

		public void TraverseCommon (XMLRelativeOIDComponent p_XMLRelativeOIDComponent)
		{
			XMLRelativeOIDComponent.production_kind kind = (XMLRelativeOIDComponent.production_kind) p_XMLRelativeOIDComponent.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLRelativeOIDComponent))
			switch (kind)
			{
				case XMLRelativeOIDComponent.production_kind.g_XMLRelativeOIDComponent_1:
					// traverse syntax tree node associated with production
					// XMLRelativeOIDComponent: XMLNumberForm

						TraverseCommon (p_XMLRelativeOIDComponent.m_XMLNumberForm);
				break;
				case XMLRelativeOIDComponent.production_kind.g_XMLRelativeOIDComponent_2:
					// traverse syntax tree node associated with production
					// XMLRelativeOIDComponent: XMLNameAndNumberForm

						TraverseCommon (p_XMLRelativeOIDComponent.m_XMLNameAndNumberForm);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLRelativeOIDComponent);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLRelativeOIDComponent

		//
		// create syntax tree node associated with production
		// XMLRelativeOIDComponent: XMLNumberForm

		//

		public XMLRelativeOIDComponent XMLRelativeOIDComponent_1 (XMLNumberForm p_XMLNumberForm)
		{
			XMLRelativeOIDComponent p_XMLRelativeOIDComponent_ref = new XMLRelativeOIDComponent(p_XMLNumberForm);
			p_XMLNumberForm.parent = p_XMLRelativeOIDComponent_ref;
			Raise_XMLRelativeOIDComponent_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLRelativeOIDComponent.production_kind.g_XMLRelativeOIDComponent_1, p_XMLRelativeOIDComponent_ref);
			return p_XMLRelativeOIDComponent_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLRelativeOIDComponent: XMLNameAndNumberForm

		//

		public XMLRelativeOIDComponent XMLRelativeOIDComponent_2 (XMLNameAndNumberForm p_XMLNameAndNumberForm)
		{
			XMLRelativeOIDComponent p_XMLRelativeOIDComponent_ref = new XMLRelativeOIDComponent(p_XMLNameAndNumberForm);
			p_XMLNameAndNumberForm.parent = p_XMLRelativeOIDComponent_ref;
			Raise_XMLRelativeOIDComponent_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLRelativeOIDComponent.production_kind.g_XMLRelativeOIDComponent_2, p_XMLRelativeOIDComponent_ref);
			return p_XMLRelativeOIDComponent_ref;
		}
		#endregion
	};
}
