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
	// class associated with syntax rule EmbeddedPDVValue
	//

	[DataContract]
	public class	EmbeddedPDVValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule EmbeddedPDVValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule EmbeddedPDVValue
		{
			g_EmbeddedPDVValue_1 = 1,	// SequenceValue

		};
		#endregion
		#region production markers associated with the syntax rule EmbeddedPDVValue

		// markers associated with production: EmbeddedPDVValue -> SequenceValue

		public enum production_marker_1 : ushort
		{
			m_SequenceValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule EmbeddedPDVValue

		// Constructor declaration(s) associated with production(s) of syntax rule EmbeddedPDVValue

		//
		// Constructor associated with the following production(s)
		// EmbeddedPDVValue -> SequenceValue

		//

		public EmbeddedPDVValue (SequenceValue p_SequenceValue) : base ((uint) ProductionID._EmbeddedPDVValue_ID, (uint) production_kind.g_EmbeddedPDVValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SequenceValue = p_SequenceValue;
		}

		public EmbeddedPDVValue () { }

		// Copy constructor

		public EmbeddedPDVValue (EmbeddedPDVValue p_EmbeddedPDVValue) : base (p_EmbeddedPDVValue.id, p_EmbeddedPDVValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_EmbeddedPDVValue.appInfo;
			switch ((production_kind) p_EmbeddedPDVValue.kind)
			{
				case production_kind.g_EmbeddedPDVValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SequenceValue = (p_EmbeddedPDVValue.m_SequenceValue != null) ? new SequenceValue (p_EmbeddedPDVValue.m_SequenceValue) : null) != null) m_SequenceValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "EmbeddedPDVValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new EmbeddedPDVValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SequenceValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule EmbeddedPDVValue

		// Content changing function(s) associated with production(s) of syntax rule EmbeddedPDVValue

		//
		// Content changing function associated with following production(s)
		// EmbeddedPDVValue -> SequenceValue

		//

		public void change(SequenceValue p_SequenceValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_EmbeddedPDVValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SequenceValue = p_SequenceValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule EmbeddedPDVValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SequenceValue != null) && m_SequenceValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule EmbeddedPDVValue

		//
		// emit production tree node associated with any production of syntax rule EmbeddedPDVValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_EmbeddedPDVValue_1:
					// emit syntax tree node associated with production
					// EmbeddedPDVValue: SequenceValue

					s += m_SequenceValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule EmbeddedPDVValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "EmbeddedPDVValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_EmbeddedPDVValue_1:
					// emit syntax tree node associated with production
					// EmbeddedPDVValue: SequenceValue

					s += m_SequenceValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule EmbeddedPDVValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule EmbeddedPDVValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			EmbeddedPDVValue.production_kind kind = (EmbeddedPDVValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case EmbeddedPDVValue.production_kind.g_EmbeddedPDVValue_1:
					// traverse syntax tree node associated with production
					// EmbeddedPDVValue: SequenceValue

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
		// initialize object associated with syntax rule EmbeddedPDVValue
		//

		public void _init ()
		{
			m_SequenceValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule EmbeddedPDVValue

		// counter of all nodes associated with syntax rule EmbeddedPDVValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule EmbeddedPDVValue
		[DataMember (Name = "m_SequenceValue")] public SequenceValue m_SequenceValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule EmbeddedPDVValue

		// delegate function (callback) prototype associated with syntax rule EmbeddedPDVValue
		public delegate bool EmbeddedPDVValue_Callback (SyntaxTreeCallbackReason reason, EmbeddedPDVValue.production_kind kind, EmbeddedPDVValue p_EmbeddedPDVValue);

		// event associated with syntax rule EmbeddedPDVValue
		public event EmbeddedPDVValue_Callback EmbeddedPDVValue_Event;

		// event trigger associated with syntax rule EmbeddedPDVValue
		public bool Raise_EmbeddedPDVValue_Event (SyntaxTreeCallbackReason reason, EmbeddedPDVValue.production_kind kind, EmbeddedPDVValue p_EmbeddedPDVValue)
		{
			bool? status = EmbeddedPDVValue_Event?.Invoke (reason, kind, p_EmbeddedPDVValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule EmbeddedPDVValue
		//
		// traverse syntax tree node associated with any production of syntax rule EmbeddedPDVValue
		//

		public void Traverse (EmbeddedPDVValue p_EmbeddedPDVValue)
		{
			if (p_EmbeddedPDVValue.isLocked())
				return;
			p_EmbeddedPDVValue.dolock();
			EmbeddedPDVValue.production_kind kind = (EmbeddedPDVValue.production_kind) p_EmbeddedPDVValue.kind;
			p_EmbeddedPDVValue.turn_reset ();
			if (Raise_EmbeddedPDVValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_EmbeddedPDVValue))
			switch (kind)
			{
				case EmbeddedPDVValue.production_kind.g_EmbeddedPDVValue_1:
					// traverse syntax tree node associated with production
					// EmbeddedPDVValue: SequenceValue

					if (Raise_EmbeddedPDVValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EmbeddedPDVValue))
						Traverse (p_EmbeddedPDVValue.m_SequenceValue);
					p_EmbeddedPDVValue.turn_inc ();
					Raise_EmbeddedPDVValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EmbeddedPDVValue);
				break;
			}
			Raise_EmbeddedPDVValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_EmbeddedPDVValue);
			p_EmbeddedPDVValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule EmbeddedPDVValue
		//

		public void TraverseCommon (EmbeddedPDVValue p_EmbeddedPDVValue)
		{
			EmbeddedPDVValue.production_kind kind = (EmbeddedPDVValue.production_kind) p_EmbeddedPDVValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_EmbeddedPDVValue))
			switch (kind)
			{
				case EmbeddedPDVValue.production_kind.g_EmbeddedPDVValue_1:
					// traverse syntax tree node associated with production
					// EmbeddedPDVValue: SequenceValue

						TraverseCommon (p_EmbeddedPDVValue.m_SequenceValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_EmbeddedPDVValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule EmbeddedPDVValue

		//
		// create syntax tree node associated with production
		// EmbeddedPDVValue: SequenceValue

		//

		public EmbeddedPDVValue EmbeddedPDVValue_1 (SequenceValue p_SequenceValue)
		{
			EmbeddedPDVValue p_EmbeddedPDVValue_ref = new EmbeddedPDVValue(p_SequenceValue);
			p_SequenceValue.parent = p_EmbeddedPDVValue_ref;
			Raise_EmbeddedPDVValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EmbeddedPDVValue.production_kind.g_EmbeddedPDVValue_1, p_EmbeddedPDVValue_ref);
			return p_EmbeddedPDVValue_ref;
		}
		#endregion
	};
}
