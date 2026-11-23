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
	// class associated with syntax rule NumberForm
	//

	[DataContract]
	public class	NumberForm : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NumberForm
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NumberForm
		{
			g_NumberForm_1 = 1,	// number

			g_NumberForm_2 = 2,	// DefinedValue

		};
		#endregion
		#region production markers associated with the syntax rule NumberForm

		// markers associated with production: NumberForm -> number

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: NumberForm -> DefinedValue

		public enum production_marker_2 : ushort
		{
			m_DefinedValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NumberForm

		// Constructor declaration(s) associated with production(s) of syntax rule NumberForm

		//
		// Constructor associated with the following production(s)
		// NumberForm -> number

		//

		public NumberForm (SyntaxTreeToken p_token) : base ((uint) ProductionID._NumberForm_ID, (uint) production_kind.g_NumberForm_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_number = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// NumberForm -> DefinedValue

		//

		public NumberForm (DefinedValue p_DefinedValue) : base ((uint) ProductionID._NumberForm_ID, (uint) production_kind.g_NumberForm_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinedValue = p_DefinedValue;
		}

		public NumberForm () { }

		// Copy constructor

		public NumberForm (NumberForm p_NumberForm) : base (p_NumberForm.id, p_NumberForm.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NumberForm.appInfo;
			switch ((production_kind) p_NumberForm.kind)
			{
				case production_kind.g_NumberForm_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_number = (p_NumberForm.m_number != null) ? new SyntaxTreeToken (p_NumberForm.m_number) : null) != null) m_number.parent = this;
					break;
				case production_kind.g_NumberForm_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinedValue = (p_NumberForm.m_DefinedValue != null) ? new DefinedValue (p_NumberForm.m_DefinedValue) : null) != null) m_DefinedValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NumberForm" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NumberForm (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_number?.Dispose ();
			m_DefinedValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NumberForm

		// Content changing function(s) associated with production(s) of syntax rule NumberForm

		//
		// Content changing function associated with following production(s)
		// NumberForm -> number

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_NumberForm_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_number = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// NumberForm -> DefinedValue

		//

		public void change(DefinedValue p_DefinedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_NumberForm_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinedValue = p_DefinedValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NumberForm
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_number != null) && m_number.checkInclusion (element) ||
				(m_DefinedValue != null) && m_DefinedValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NumberForm

		//
		// emit production tree node associated with any production of syntax rule NumberForm
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NumberForm_1:
					// emit syntax tree node associated with production
					// NumberForm: number

					s += m_number.Emit (depth - 1);
				break;
				case production_kind.g_NumberForm_2:
					// emit syntax tree node associated with production
					// NumberForm: DefinedValue

					s += m_DefinedValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NumberForm
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NumberForm (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NumberForm_1:
					// emit syntax tree node associated with production
					// NumberForm: number

					s += "number";
				break;
				case production_kind.g_NumberForm_2:
					// emit syntax tree node associated with production
					// NumberForm: DefinedValue

					s += m_DefinedValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NumberForm

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NumberForm with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NumberForm.production_kind kind = (NumberForm.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NumberForm.production_kind.g_NumberForm_1:
					// traverse syntax tree node associated with production
					// NumberForm: number

						m_number.Visit (visitor, appData);
				break;
				case NumberForm.production_kind.g_NumberForm_2:
					// traverse syntax tree node associated with production
					// NumberForm: DefinedValue

						m_DefinedValue.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_number?.reparent (this);
			m_DefinedValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule NumberForm
		//

		public void _init ()
		{
			m_number = null;
			m_DefinedValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NumberForm

		// counter of all nodes associated with syntax rule NumberForm
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NumberForm
		[DataMember (Name = "m_number")] public SyntaxTreeToken m_number { get; private set; }
		[DataMember (Name = "m_DefinedValue")] public DefinedValue m_DefinedValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NumberForm

		// delegate function (callback) prototype associated with syntax rule NumberForm
		public delegate bool NumberForm_Callback (SyntaxTreeCallbackReason reason, NumberForm.production_kind kind, NumberForm p_NumberForm);

		// event associated with syntax rule NumberForm
		public event NumberForm_Callback NumberForm_Event;

		// event trigger associated with syntax rule NumberForm
		public bool Raise_NumberForm_Event (SyntaxTreeCallbackReason reason, NumberForm.production_kind kind, NumberForm p_NumberForm)
		{
			bool? status = NumberForm_Event?.Invoke (reason, kind, p_NumberForm);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NumberForm
		//
		// traverse syntax tree node associated with any production of syntax rule NumberForm
		//

		public void Traverse (NumberForm p_NumberForm)
		{
			if (p_NumberForm.isLocked())
				return;
			p_NumberForm.dolock();
			NumberForm.production_kind kind = (NumberForm.production_kind) p_NumberForm.kind;
			p_NumberForm.turn_reset ();
			if (Raise_NumberForm_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NumberForm))
			switch (kind)
			{
				case NumberForm.production_kind.g_NumberForm_1:
					// traverse syntax tree node associated with production
					// NumberForm: number

				break;
				case NumberForm.production_kind.g_NumberForm_2:
					// traverse syntax tree node associated with production
					// NumberForm: DefinedValue

					if (Raise_NumberForm_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NumberForm))
						Traverse (p_NumberForm.m_DefinedValue);
					p_NumberForm.turn_inc ();
					Raise_NumberForm_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NumberForm);
				break;
			}
			Raise_NumberForm_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NumberForm);
			p_NumberForm.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NumberForm
		//

		public void TraverseCommon (NumberForm p_NumberForm)
		{
			NumberForm.production_kind kind = (NumberForm.production_kind) p_NumberForm.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NumberForm))
			switch (kind)
			{
				case NumberForm.production_kind.g_NumberForm_1:
					// traverse syntax tree node associated with production
					// NumberForm: number

						TraverseCommon (p_NumberForm.m_number);
				break;
				case NumberForm.production_kind.g_NumberForm_2:
					// traverse syntax tree node associated with production
					// NumberForm: DefinedValue

						TraverseCommon (p_NumberForm.m_DefinedValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NumberForm);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NumberForm

		//
		// create syntax tree node associated with production
		// NumberForm: number

		//

		public NumberForm NumberForm_1 (SyntaxTreeToken p_token)
		{
			NumberForm p_NumberForm_ref = new NumberForm(p_token);
			p_token.parent = p_NumberForm_ref;
			Raise_NumberForm_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NumberForm.production_kind.g_NumberForm_1, p_NumberForm_ref);
			return p_NumberForm_ref;
		}

		//
		// create syntax tree node associated with production
		// NumberForm: DefinedValue

		//

		public NumberForm NumberForm_2 (DefinedValue p_DefinedValue)
		{
			NumberForm p_NumberForm_ref = new NumberForm(p_DefinedValue);
			p_DefinedValue.parent = p_NumberForm_ref;
			Raise_NumberForm_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NumberForm.production_kind.g_NumberForm_2, p_NumberForm_ref);
			return p_NumberForm_ref;
		}
		#endregion
	};
}
