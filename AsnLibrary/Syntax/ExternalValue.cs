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
	// class associated with syntax rule ExternalValue
	//

	[DataContract]
	public class	ExternalValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExternalValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExternalValue
		{
			g_ExternalValue_1 = 1,	// SequenceValue

		};
		#endregion
		#region production markers associated with the syntax rule ExternalValue

		// markers associated with production: ExternalValue -> SequenceValue

		public enum production_marker_1 : ushort
		{
			m_SequenceValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExternalValue

		// Constructor declaration(s) associated with production(s) of syntax rule ExternalValue

		//
		// Constructor associated with the following production(s)
		// ExternalValue -> SequenceValue

		//

		public ExternalValue (SequenceValue p_SequenceValue) : base ((uint) ProductionID._ExternalValue_ID, (uint) production_kind.g_ExternalValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SequenceValue = p_SequenceValue;
		}

		public ExternalValue () { }

		// Copy constructor

		public ExternalValue (ExternalValue p_ExternalValue) : base (p_ExternalValue.id, p_ExternalValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExternalValue.appInfo;
			switch ((production_kind) p_ExternalValue.kind)
			{
				case production_kind.g_ExternalValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SequenceValue = (p_ExternalValue.m_SequenceValue != null) ? new SequenceValue (p_ExternalValue.m_SequenceValue) : null) != null) m_SequenceValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ExternalValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExternalValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SequenceValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExternalValue

		// Content changing function(s) associated with production(s) of syntax rule ExternalValue

		//
		// Content changing function associated with following production(s)
		// ExternalValue -> SequenceValue

		//

		public void change(SequenceValue p_SequenceValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExternalValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SequenceValue = p_SequenceValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExternalValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SequenceValue != null) && m_SequenceValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExternalValue

		//
		// emit production tree node associated with any production of syntax rule ExternalValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ExternalValue_1:
					// emit syntax tree node associated with production
					// ExternalValue: SequenceValue

					s += m_SequenceValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExternalValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ExternalValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ExternalValue_1:
					// emit syntax tree node associated with production
					// ExternalValue: SequenceValue

					s += m_SequenceValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExternalValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExternalValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ExternalValue.production_kind kind = (ExternalValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ExternalValue.production_kind.g_ExternalValue_1:
					// traverse syntax tree node associated with production
					// ExternalValue: SequenceValue

						m_SequenceValue.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SequenceValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ExternalValue
		//

		public void _init ()
		{
			m_SequenceValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExternalValue

		// counter of all nodes associated with syntax rule ExternalValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExternalValue
		[DataMember (Name = "m_SequenceValue")] public SequenceValue m_SequenceValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExternalValue

		// delegate function (callback) prototype associated with syntax rule ExternalValue
		public delegate bool ExternalValue_Callback (SyntaxTreeCallbackReason reason, ExternalValue.production_kind kind, ExternalValue p_ExternalValue);

		// event associated with syntax rule ExternalValue
		public event ExternalValue_Callback ExternalValue_Event;

		// event trigger associated with syntax rule ExternalValue
		public bool Raise_ExternalValue_Event (SyntaxTreeCallbackReason reason, ExternalValue.production_kind kind, ExternalValue p_ExternalValue)
		{
			bool? status = ExternalValue_Event?.Invoke (reason, kind, p_ExternalValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExternalValue
		//
		// traverse syntax tree node associated with any production of syntax rule ExternalValue
		//

		public void Traverse (ExternalValue p_ExternalValue)
		{
			if (p_ExternalValue.isLocked())
				return;
			p_ExternalValue.dolock();
			ExternalValue.production_kind kind = (ExternalValue.production_kind) p_ExternalValue.kind;
			p_ExternalValue.turn_reset ();
			if (Raise_ExternalValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ExternalValue))
			switch (kind)
			{
				case ExternalValue.production_kind.g_ExternalValue_1:
					// traverse syntax tree node associated with production
					// ExternalValue: SequenceValue

					if (Raise_ExternalValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExternalValue))
						Traverse (p_ExternalValue.m_SequenceValue);
					p_ExternalValue.turn_inc ();
					Raise_ExternalValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExternalValue);
				break;
			}
			Raise_ExternalValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ExternalValue);
			p_ExternalValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExternalValue
		//

		public void TraverseCommon (ExternalValue p_ExternalValue)
		{
			ExternalValue.production_kind kind = (ExternalValue.production_kind) p_ExternalValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ExternalValue))
			switch (kind)
			{
				case ExternalValue.production_kind.g_ExternalValue_1:
					// traverse syntax tree node associated with production
					// ExternalValue: SequenceValue

						TraverseCommon (p_ExternalValue.m_SequenceValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ExternalValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExternalValue

		//
		// create syntax tree node associated with production
		// ExternalValue: SequenceValue

		//

		public ExternalValue ExternalValue_1 (SequenceValue p_SequenceValue)
		{
			ExternalValue p_ExternalValue_ref = new ExternalValue(p_SequenceValue);
			p_SequenceValue.parent = p_ExternalValue_ref;
			Raise_ExternalValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExternalValue.production_kind.g_ExternalValue_1, p_ExternalValue_ref);
			return p_ExternalValue_ref;
		}
		#endregion
	};
}
