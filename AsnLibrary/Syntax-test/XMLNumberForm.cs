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
	// class associated with syntax rule XMLNumberForm
	//

	[DataContract]
	public class	XMLNumberForm : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLNumberForm
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLNumberForm
		{
			g_XMLNumberForm_1 = 1,	// number

		};
		#endregion
		#region production markers associated with the syntax rule XMLNumberForm

		// markers associated with production: XMLNumberForm -> number

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLNumberForm

		// Constructor declaration(s) associated with production(s) of syntax rule XMLNumberForm

		//
		// Constructor associated with the following production(s)
		// XMLNumberForm -> number

		//

		public XMLNumberForm (SyntaxTreeToken p_token) : base ((uint) ProductionID._XMLNumberForm_ID, (uint) production_kind.g_XMLNumberForm_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_number = p_token;
		}

		public XMLNumberForm () { }

		// Copy constructor

		public XMLNumberForm (XMLNumberForm p_XMLNumberForm) : base (p_XMLNumberForm.id, p_XMLNumberForm.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLNumberForm.appInfo;
			switch ((production_kind) p_XMLNumberForm.kind)
			{
				case production_kind.g_XMLNumberForm_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_number = (p_XMLNumberForm.m_number != null) ? new SyntaxTreeToken (p_XMLNumberForm.m_number) : null) != null) m_number.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLNumberForm" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLNumberForm (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_number?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLNumberForm

		// Content changing function(s) associated with production(s) of syntax rule XMLNumberForm

		//
		// Content changing function associated with following production(s)
		// XMLNumberForm -> number

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLNumberForm_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_number = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLNumberForm
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_number != null) && m_number.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLNumberForm

		//
		// emit production tree node associated with any production of syntax rule XMLNumberForm
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLNumberForm_1:
					// emit syntax tree node associated with production
					// XMLNumberForm: number

					s += m_number.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLNumberForm
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLNumberForm (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLNumberForm_1:
					// emit syntax tree node associated with production
					// XMLNumberForm: number

					s += "number";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLNumberForm

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLNumberForm with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLNumberForm.production_kind kind = (XMLNumberForm.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLNumberForm.production_kind.g_XMLNumberForm_1:
					// traverse syntax tree node associated with production
					// XMLNumberForm: number

						m_number.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_number?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLNumberForm
		//

		public void _init ()
		{
			m_number = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLNumberForm

		// counter of all nodes associated with syntax rule XMLNumberForm
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLNumberForm
		[DataMember (Name = "m_number")] public SyntaxTreeToken m_number { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLNumberForm

		// delegate function (callback) prototype associated with syntax rule XMLNumberForm
		public delegate bool XMLNumberForm_Callback (SyntaxTreeCallbackReason reason, XMLNumberForm.production_kind kind, XMLNumberForm p_XMLNumberForm);

		// event associated with syntax rule XMLNumberForm
		public event XMLNumberForm_Callback XMLNumberForm_Event;

		// event trigger associated with syntax rule XMLNumberForm
		public bool Raise_XMLNumberForm_Event (SyntaxTreeCallbackReason reason, XMLNumberForm.production_kind kind, XMLNumberForm p_XMLNumberForm)
		{
			bool? status = XMLNumberForm_Event?.Invoke (reason, kind, p_XMLNumberForm);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLNumberForm
		//
		// traverse syntax tree node associated with any production of syntax rule XMLNumberForm
		//

		public void Traverse (XMLNumberForm p_XMLNumberForm)
		{
			if (p_XMLNumberForm.isLocked())
				return;
			p_XMLNumberForm.dolock();
			XMLNumberForm.production_kind kind = (XMLNumberForm.production_kind) p_XMLNumberForm.kind;
			p_XMLNumberForm.turn_reset ();
			if (Raise_XMLNumberForm_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLNumberForm))
			switch (kind)
			{
				case XMLNumberForm.production_kind.g_XMLNumberForm_1:
					// traverse syntax tree node associated with production
					// XMLNumberForm: number

				break;
			}
			Raise_XMLNumberForm_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLNumberForm);
			p_XMLNumberForm.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLNumberForm
		//

		public void TraverseCommon (XMLNumberForm p_XMLNumberForm)
		{
			XMLNumberForm.production_kind kind = (XMLNumberForm.production_kind) p_XMLNumberForm.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLNumberForm))
			switch (kind)
			{
				case XMLNumberForm.production_kind.g_XMLNumberForm_1:
					// traverse syntax tree node associated with production
					// XMLNumberForm: number

						TraverseCommon (p_XMLNumberForm.m_number);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLNumberForm);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLNumberForm

		//
		// create syntax tree node associated with production
		// XMLNumberForm: number

		//

		public XMLNumberForm XMLNumberForm_1 (SyntaxTreeToken p_token)
		{
			XMLNumberForm p_XMLNumberForm_ref = new XMLNumberForm(p_token);
			p_token.parent = p_XMLNumberForm_ref;
			Raise_XMLNumberForm_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLNumberForm.production_kind.g_XMLNumberForm_1, p_XMLNumberForm_ref);
			return p_XMLNumberForm_ref;
		}
		#endregion
	};
}
