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
	// class associated with syntax rule NameForm
	//

	[DataContract]
	public class	NameForm : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NameForm
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NameForm
		{
			g_NameForm_1 = 1,	// identifier-token

		};
		#endregion
		#region production markers associated with the syntax rule NameForm

		// markers associated with production: NameForm -> identifier-token

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NameForm

		// Constructor declaration(s) associated with production(s) of syntax rule NameForm

		//
		// Constructor associated with the following production(s)
		// NameForm -> identifier-token

		//

		public NameForm (identifier_token p_identifier_token) : base ((uint) ProductionID._NameForm_ID, (uint) production_kind.g_NameForm_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_identifier_token = p_identifier_token;
		}

		public NameForm () { }

		// Copy constructor

		public NameForm (NameForm p_NameForm) : base (p_NameForm.id, p_NameForm.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NameForm.appInfo;
			switch ((production_kind) p_NameForm.kind)
			{
				case production_kind.g_NameForm_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_identifier_token = (p_NameForm.m_identifier_token != null) ? new identifier_token (p_NameForm.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NameForm" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NameForm (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NameForm

		// Content changing function(s) associated with production(s) of syntax rule NameForm

		//
		// Content changing function associated with following production(s)
		// NameForm -> identifier-token

		//

		public void change(identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_NameForm_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NameForm
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NameForm

		//
		// emit production tree node associated with any production of syntax rule NameForm
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NameForm_1:
					// emit syntax tree node associated with production
					// NameForm: identifier-token

					s += m_identifier_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NameForm
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NameForm (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NameForm_1:
					// emit syntax tree node associated with production
					// NameForm: identifier-token

					s += m_identifier_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NameForm

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NameForm with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NameForm.production_kind kind = (NameForm.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NameForm.production_kind.g_NameForm_1:
					// traverse syntax tree node associated with production
					// NameForm: identifier-token

						m_identifier_token.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_identifier_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule NameForm
		//

		public void _init ()
		{
			m_identifier_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NameForm

		// counter of all nodes associated with syntax rule NameForm
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NameForm
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NameForm

		// delegate function (callback) prototype associated with syntax rule NameForm
		public delegate bool NameForm_Callback (SyntaxTreeCallbackReason reason, NameForm.production_kind kind, NameForm p_NameForm);

		// event associated with syntax rule NameForm
		public event NameForm_Callback NameForm_Event;

		// event trigger associated with syntax rule NameForm
		public bool Raise_NameForm_Event (SyntaxTreeCallbackReason reason, NameForm.production_kind kind, NameForm p_NameForm)
		{
			bool? status = NameForm_Event?.Invoke (reason, kind, p_NameForm);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NameForm
		//
		// traverse syntax tree node associated with any production of syntax rule NameForm
		//

		public void Traverse (NameForm p_NameForm)
		{
			if (p_NameForm.isLocked())
				return;
			p_NameForm.dolock();
			NameForm.production_kind kind = (NameForm.production_kind) p_NameForm.kind;
			p_NameForm.turn_reset ();
			if (Raise_NameForm_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NameForm))
			switch (kind)
			{
				case NameForm.production_kind.g_NameForm_1:
					// traverse syntax tree node associated with production
					// NameForm: identifier-token

					if (Raise_NameForm_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NameForm))
						Traverse (p_NameForm.m_identifier_token);
					p_NameForm.turn_inc ();
					Raise_NameForm_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NameForm);
				break;
			}
			Raise_NameForm_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NameForm);
			p_NameForm.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NameForm
		//

		public void TraverseCommon (NameForm p_NameForm)
		{
			NameForm.production_kind kind = (NameForm.production_kind) p_NameForm.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NameForm))
			switch (kind)
			{
				case NameForm.production_kind.g_NameForm_1:
					// traverse syntax tree node associated with production
					// NameForm: identifier-token

						TraverseCommon (p_NameForm.m_identifier_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NameForm);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NameForm

		//
		// create syntax tree node associated with production
		// NameForm: identifier-token

		//

		public NameForm NameForm_1 (identifier_token p_identifier_token)
		{
			NameForm p_NameForm_ref = new NameForm(p_identifier_token);
			p_identifier_token.parent = p_NameForm_ref;
			Raise_NameForm_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NameForm.production_kind.g_NameForm_1, p_NameForm_ref);
			return p_NameForm_ref;
		}
		#endregion
	};
}
