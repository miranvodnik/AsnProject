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
	// class associated with syntax rule DefinitiveNumberForm
	//

	[DataContract]
	public class	DefinitiveNumberForm : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DefinitiveNumberForm
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DefinitiveNumberForm
		{
			g_DefinitiveNumberForm_1 = 1,	// number

		};
		#endregion
		#region production markers associated with the syntax rule DefinitiveNumberForm

		// markers associated with production: DefinitiveNumberForm -> number

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DefinitiveNumberForm

		// Constructor declaration(s) associated with production(s) of syntax rule DefinitiveNumberForm

		//
		// Constructor associated with the following production(s)
		// DefinitiveNumberForm -> number

		//

		public DefinitiveNumberForm (SyntaxTreeToken p_token) : base ((uint) ProductionID._DefinitiveNumberForm_ID, (uint) production_kind.g_DefinitiveNumberForm_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_number = p_token;
		}

		public DefinitiveNumberForm () { }

		// Copy constructor

		public DefinitiveNumberForm (DefinitiveNumberForm p_DefinitiveNumberForm) : base (p_DefinitiveNumberForm.id, p_DefinitiveNumberForm.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DefinitiveNumberForm.appInfo;
			switch ((production_kind) p_DefinitiveNumberForm.kind)
			{
				case production_kind.g_DefinitiveNumberForm_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_number = (p_DefinitiveNumberForm.m_number != null) ? new SyntaxTreeToken (p_DefinitiveNumberForm.m_number) : null) != null) m_number.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DefinitiveNumberForm" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DefinitiveNumberForm (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_number?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DefinitiveNumberForm

		// Content changing function(s) associated with production(s) of syntax rule DefinitiveNumberForm

		//
		// Content changing function associated with following production(s)
		// DefinitiveNumberForm -> number

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinitiveNumberForm_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_number = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DefinitiveNumberForm
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_number != null) && m_number.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DefinitiveNumberForm

		//
		// emit production tree node associated with any production of syntax rule DefinitiveNumberForm
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DefinitiveNumberForm_1:
					// emit syntax tree node associated with production
					// DefinitiveNumberForm: number

					s += m_number.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DefinitiveNumberForm
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DefinitiveNumberForm (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DefinitiveNumberForm_1:
					// emit syntax tree node associated with production
					// DefinitiveNumberForm: number

					s += "number";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DefinitiveNumberForm

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveNumberForm with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DefinitiveNumberForm.production_kind kind = (DefinitiveNumberForm.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DefinitiveNumberForm.production_kind.g_DefinitiveNumberForm_1:
					// traverse syntax tree node associated with production
					// DefinitiveNumberForm: number

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
		// initialize object associated with syntax rule DefinitiveNumberForm
		//

		public void _init ()
		{
			m_number = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DefinitiveNumberForm

		// counter of all nodes associated with syntax rule DefinitiveNumberForm
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DefinitiveNumberForm
		[DataMember (Name = "m_number")] public SyntaxTreeToken m_number { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DefinitiveNumberForm

		// delegate function (callback) prototype associated with syntax rule DefinitiveNumberForm
		public delegate bool DefinitiveNumberForm_Callback (SyntaxTreeCallbackReason reason, DefinitiveNumberForm.production_kind kind, DefinitiveNumberForm p_DefinitiveNumberForm);

		// event associated with syntax rule DefinitiveNumberForm
		public event DefinitiveNumberForm_Callback DefinitiveNumberForm_Event;

		// event trigger associated with syntax rule DefinitiveNumberForm
		public bool Raise_DefinitiveNumberForm_Event (SyntaxTreeCallbackReason reason, DefinitiveNumberForm.production_kind kind, DefinitiveNumberForm p_DefinitiveNumberForm)
		{
			bool? status = DefinitiveNumberForm_Event?.Invoke (reason, kind, p_DefinitiveNumberForm);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DefinitiveNumberForm
		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveNumberForm
		//

		public void Traverse (DefinitiveNumberForm p_DefinitiveNumberForm)
		{
			if (p_DefinitiveNumberForm.isLocked())
				return;
			p_DefinitiveNumberForm.dolock();
			DefinitiveNumberForm.production_kind kind = (DefinitiveNumberForm.production_kind) p_DefinitiveNumberForm.kind;
			p_DefinitiveNumberForm.turn_reset ();
			if (Raise_DefinitiveNumberForm_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DefinitiveNumberForm))
			switch (kind)
			{
				case DefinitiveNumberForm.production_kind.g_DefinitiveNumberForm_1:
					// traverse syntax tree node associated with production
					// DefinitiveNumberForm: number

				break;
			}
			Raise_DefinitiveNumberForm_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DefinitiveNumberForm);
			p_DefinitiveNumberForm.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveNumberForm
		//

		public void TraverseCommon (DefinitiveNumberForm p_DefinitiveNumberForm)
		{
			DefinitiveNumberForm.production_kind kind = (DefinitiveNumberForm.production_kind) p_DefinitiveNumberForm.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DefinitiveNumberForm))
			switch (kind)
			{
				case DefinitiveNumberForm.production_kind.g_DefinitiveNumberForm_1:
					// traverse syntax tree node associated with production
					// DefinitiveNumberForm: number

						TraverseCommon (p_DefinitiveNumberForm.m_number);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DefinitiveNumberForm);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DefinitiveNumberForm

		//
		// create syntax tree node associated with production
		// DefinitiveNumberForm: number

		//

		public DefinitiveNumberForm DefinitiveNumberForm_1 (SyntaxTreeToken p_token)
		{
			DefinitiveNumberForm p_DefinitiveNumberForm_ref = new DefinitiveNumberForm(p_token);
			p_token.parent = p_DefinitiveNumberForm_ref;
			Raise_DefinitiveNumberForm_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinitiveNumberForm.production_kind.g_DefinitiveNumberForm_1, p_DefinitiveNumberForm_ref);
			return p_DefinitiveNumberForm_ref;
		}
		#endregion
	};
}
