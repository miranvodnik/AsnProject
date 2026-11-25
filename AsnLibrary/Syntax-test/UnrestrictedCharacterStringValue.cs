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
	// class associated with syntax rule UnrestrictedCharacterStringValue
	//

	[DataContract]
	public class	UnrestrictedCharacterStringValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule UnrestrictedCharacterStringValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule UnrestrictedCharacterStringValue
		{
			g_UnrestrictedCharacterStringValue_1 = 1,	// SequenceValue

		};
		#endregion
		#region production markers associated with the syntax rule UnrestrictedCharacterStringValue

		// markers associated with production: UnrestrictedCharacterStringValue -> SequenceValue

		public enum production_marker_1 : ushort
		{
			m_SequenceValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule UnrestrictedCharacterStringValue

		// Constructor declaration(s) associated with production(s) of syntax rule UnrestrictedCharacterStringValue

		//
		// Constructor associated with the following production(s)
		// UnrestrictedCharacterStringValue -> SequenceValue

		//

		public UnrestrictedCharacterStringValue (SequenceValue p_SequenceValue) : base ((uint) ProductionID._UnrestrictedCharacterStringValue_ID, (uint) production_kind.g_UnrestrictedCharacterStringValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SequenceValue = p_SequenceValue;
		}

		public UnrestrictedCharacterStringValue () { }

		// Copy constructor

		public UnrestrictedCharacterStringValue (UnrestrictedCharacterStringValue p_UnrestrictedCharacterStringValue) : base (p_UnrestrictedCharacterStringValue.id, p_UnrestrictedCharacterStringValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_UnrestrictedCharacterStringValue.appInfo;
			switch ((production_kind) p_UnrestrictedCharacterStringValue.kind)
			{
				case production_kind.g_UnrestrictedCharacterStringValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SequenceValue = (p_UnrestrictedCharacterStringValue.m_SequenceValue != null) ? new SequenceValue (p_UnrestrictedCharacterStringValue.m_SequenceValue) : null) != null) m_SequenceValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "UnrestrictedCharacterStringValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new UnrestrictedCharacterStringValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SequenceValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule UnrestrictedCharacterStringValue

		// Content changing function(s) associated with production(s) of syntax rule UnrestrictedCharacterStringValue

		//
		// Content changing function associated with following production(s)
		// UnrestrictedCharacterStringValue -> SequenceValue

		//

		public void change(SequenceValue p_SequenceValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_UnrestrictedCharacterStringValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SequenceValue = p_SequenceValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule UnrestrictedCharacterStringValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SequenceValue != null) && m_SequenceValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule UnrestrictedCharacterStringValue

		//
		// emit production tree node associated with any production of syntax rule UnrestrictedCharacterStringValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_UnrestrictedCharacterStringValue_1:
					// emit syntax tree node associated with production
					// UnrestrictedCharacterStringValue: SequenceValue

					s += m_SequenceValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule UnrestrictedCharacterStringValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "UnrestrictedCharacterStringValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_UnrestrictedCharacterStringValue_1:
					// emit syntax tree node associated with production
					// UnrestrictedCharacterStringValue: SequenceValue

					s += m_SequenceValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule UnrestrictedCharacterStringValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule UnrestrictedCharacterStringValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			UnrestrictedCharacterStringValue.production_kind kind = (UnrestrictedCharacterStringValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case UnrestrictedCharacterStringValue.production_kind.g_UnrestrictedCharacterStringValue_1:
					// traverse syntax tree node associated with production
					// UnrestrictedCharacterStringValue: SequenceValue

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
		// initialize object associated with syntax rule UnrestrictedCharacterStringValue
		//

		public void _init ()
		{
			m_SequenceValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule UnrestrictedCharacterStringValue

		// counter of all nodes associated with syntax rule UnrestrictedCharacterStringValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule UnrestrictedCharacterStringValue
		[DataMember (Name = "m_SequenceValue")] public SequenceValue m_SequenceValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule UnrestrictedCharacterStringValue

		// delegate function (callback) prototype associated with syntax rule UnrestrictedCharacterStringValue
		public delegate bool UnrestrictedCharacterStringValue_Callback (SyntaxTreeCallbackReason reason, UnrestrictedCharacterStringValue.production_kind kind, UnrestrictedCharacterStringValue p_UnrestrictedCharacterStringValue);

		// event associated with syntax rule UnrestrictedCharacterStringValue
		public event UnrestrictedCharacterStringValue_Callback UnrestrictedCharacterStringValue_Event;

		// event trigger associated with syntax rule UnrestrictedCharacterStringValue
		public bool Raise_UnrestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason reason, UnrestrictedCharacterStringValue.production_kind kind, UnrestrictedCharacterStringValue p_UnrestrictedCharacterStringValue)
		{
			bool? status = UnrestrictedCharacterStringValue_Event?.Invoke (reason, kind, p_UnrestrictedCharacterStringValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule UnrestrictedCharacterStringValue
		//
		// traverse syntax tree node associated with any production of syntax rule UnrestrictedCharacterStringValue
		//

		public void Traverse (UnrestrictedCharacterStringValue p_UnrestrictedCharacterStringValue)
		{
			if (p_UnrestrictedCharacterStringValue.isLocked())
				return;
			p_UnrestrictedCharacterStringValue.dolock();
			UnrestrictedCharacterStringValue.production_kind kind = (UnrestrictedCharacterStringValue.production_kind) p_UnrestrictedCharacterStringValue.kind;
			p_UnrestrictedCharacterStringValue.turn_reset ();
			if (Raise_UnrestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_UnrestrictedCharacterStringValue))
			switch (kind)
			{
				case UnrestrictedCharacterStringValue.production_kind.g_UnrestrictedCharacterStringValue_1:
					// traverse syntax tree node associated with production
					// UnrestrictedCharacterStringValue: SequenceValue

					if (Raise_UnrestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UnrestrictedCharacterStringValue))
						Traverse (p_UnrestrictedCharacterStringValue.m_SequenceValue);
					p_UnrestrictedCharacterStringValue.turn_inc ();
					Raise_UnrestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UnrestrictedCharacterStringValue);
				break;
			}
			Raise_UnrestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_UnrestrictedCharacterStringValue);
			p_UnrestrictedCharacterStringValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule UnrestrictedCharacterStringValue
		//

		public void TraverseCommon (UnrestrictedCharacterStringValue p_UnrestrictedCharacterStringValue)
		{
			UnrestrictedCharacterStringValue.production_kind kind = (UnrestrictedCharacterStringValue.production_kind) p_UnrestrictedCharacterStringValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_UnrestrictedCharacterStringValue))
			switch (kind)
			{
				case UnrestrictedCharacterStringValue.production_kind.g_UnrestrictedCharacterStringValue_1:
					// traverse syntax tree node associated with production
					// UnrestrictedCharacterStringValue: SequenceValue

						TraverseCommon (p_UnrestrictedCharacterStringValue.m_SequenceValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_UnrestrictedCharacterStringValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule UnrestrictedCharacterStringValue

		//
		// create syntax tree node associated with production
		// UnrestrictedCharacterStringValue: SequenceValue

		//

		public UnrestrictedCharacterStringValue UnrestrictedCharacterStringValue_1 (SequenceValue p_SequenceValue)
		{
			UnrestrictedCharacterStringValue p_UnrestrictedCharacterStringValue_ref = new UnrestrictedCharacterStringValue(p_SequenceValue);
			p_SequenceValue.parent = p_UnrestrictedCharacterStringValue_ref;
			Raise_UnrestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UnrestrictedCharacterStringValue.production_kind.g_UnrestrictedCharacterStringValue_1, p_UnrestrictedCharacterStringValue_ref);
			return p_UnrestrictedCharacterStringValue_ref;
		}
		#endregion
	};
}
