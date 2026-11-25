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
	// class associated with syntax rule NumericRealValue
	//

	[DataContract]
	public class	NumericRealValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NumericRealValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NumericRealValue
		{
			g_NumericRealValue_1 = 1,	// realnumber

			g_NumericRealValue_2 = 2,	// "-" realnumber

			g_NumericRealValue_3 = 3,	// SequenceValue

		};
		#endregion
		#region production markers associated with the syntax rule NumericRealValue

		// markers associated with production: NumericRealValue -> realnumber

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: NumericRealValue -> "-" realnumber

		public enum production_marker_2 : ushort
		{
			final
		};

		// markers associated with production: NumericRealValue -> SequenceValue

		public enum production_marker_3 : ushort
		{
			m_SequenceValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NumericRealValue

		// Constructor declaration(s) associated with production(s) of syntax rule NumericRealValue

		//
		// Constructor associated with the following production(s)
		// NumericRealValue -> realnumber

		//

		public NumericRealValue (SyntaxTreeToken p_token) : base ((uint) ProductionID._NumericRealValue_ID, (uint) production_kind.g_NumericRealValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_realnumber = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// NumericRealValue -> "-" realnumber

		//

		public NumericRealValue (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._NumericRealValue_ID, (uint) production_kind.g_NumericRealValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_minus_sign = p_token;
			children[1] = m_realnumber = p_token_1;
		}

		//
		// Constructor associated with the following production(s)
		// NumericRealValue -> SequenceValue

		//

		public NumericRealValue (SequenceValue p_SequenceValue) : base ((uint) ProductionID._NumericRealValue_ID, (uint) production_kind.g_NumericRealValue_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SequenceValue = p_SequenceValue;
		}

		public NumericRealValue () { }

		// Copy constructor

		public NumericRealValue (NumericRealValue p_NumericRealValue) : base (p_NumericRealValue.id, p_NumericRealValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NumericRealValue.appInfo;
			switch ((production_kind) p_NumericRealValue.kind)
			{
				case production_kind.g_NumericRealValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_realnumber = (p_NumericRealValue.m_realnumber != null) ? new SyntaxTreeToken (p_NumericRealValue.m_realnumber) : null) != null) m_realnumber.parent = this;
					break;
				case production_kind.g_NumericRealValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_minus_sign = (p_NumericRealValue.m_minus_sign != null) ? new SyntaxTreeToken (p_NumericRealValue.m_minus_sign) : null) != null) m_minus_sign.parent = this;
					if ((children [1] = m_realnumber = (p_NumericRealValue.m_realnumber != null) ? new SyntaxTreeToken (p_NumericRealValue.m_realnumber) : null) != null) m_realnumber.parent = this;
					break;
				case production_kind.g_NumericRealValue_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SequenceValue = (p_NumericRealValue.m_SequenceValue != null) ? new SequenceValue (p_NumericRealValue.m_SequenceValue) : null) != null) m_SequenceValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NumericRealValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NumericRealValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_realnumber?.Dispose ();
			m_minus_sign?.Dispose ();
			m_SequenceValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NumericRealValue

		// Content changing function(s) associated with production(s) of syntax rule NumericRealValue

		//
		// Content changing function associated with following production(s)
		// NumericRealValue -> realnumber

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_NumericRealValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_realnumber = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// NumericRealValue -> "-" realnumber

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_NumericRealValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_minus_sign = p_token;
			children [1] = m_realnumber = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// NumericRealValue -> SequenceValue

		//

		public void change(SequenceValue p_SequenceValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_NumericRealValue_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SequenceValue = p_SequenceValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NumericRealValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_realnumber != null) && m_realnumber.checkInclusion (element) ||
				(m_minus_sign != null) && m_minus_sign.checkInclusion (element) ||
				(m_SequenceValue != null) && m_SequenceValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NumericRealValue

		//
		// emit production tree node associated with any production of syntax rule NumericRealValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NumericRealValue_1:
					// emit syntax tree node associated with production
					// NumericRealValue: realnumber

					s += m_realnumber.Emit (depth - 1);
				break;
				case production_kind.g_NumericRealValue_2:
					// emit syntax tree node associated with production
					// NumericRealValue: "-" realnumber

					s += m_minus_sign.Emit (depth - 1);
					s += " ";
					s += m_realnumber.Emit (depth - 1);
				break;
				case production_kind.g_NumericRealValue_3:
					// emit syntax tree node associated with production
					// NumericRealValue: SequenceValue

					s += m_SequenceValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NumericRealValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NumericRealValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NumericRealValue_1:
					// emit syntax tree node associated with production
					// NumericRealValue: realnumber

					s += "realnumber";
				break;
				case production_kind.g_NumericRealValue_2:
					// emit syntax tree node associated with production
					// NumericRealValue: "-" realnumber

					s += "minus_sign";
					s += ' ';
					s += "realnumber";
				break;
				case production_kind.g_NumericRealValue_3:
					// emit syntax tree node associated with production
					// NumericRealValue: SequenceValue

					s += m_SequenceValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NumericRealValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NumericRealValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NumericRealValue.production_kind kind = (NumericRealValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NumericRealValue.production_kind.g_NumericRealValue_1:
					// traverse syntax tree node associated with production
					// NumericRealValue: realnumber

						m_realnumber.Visit (visitor, appData);
				break;
				case NumericRealValue.production_kind.g_NumericRealValue_2:
					// traverse syntax tree node associated with production
					// NumericRealValue: "-" realnumber

						m_minus_sign.Visit (visitor, appData);
						m_realnumber.Visit (visitor, appData);
				break;
				case NumericRealValue.production_kind.g_NumericRealValue_3:
					// traverse syntax tree node associated with production
					// NumericRealValue: SequenceValue

						m_SequenceValue.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_realnumber?.reparent (this);
			m_minus_sign?.reparent (this);
			m_SequenceValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule NumericRealValue
		//

		public void _init ()
		{
			m_realnumber = null;
			m_minus_sign = null;
			m_SequenceValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NumericRealValue

		// counter of all nodes associated with syntax rule NumericRealValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NumericRealValue
		[DataMember (Name = "m_realnumber")] public SyntaxTreeToken m_realnumber { get; private set; }
		[DataMember (Name = "m_minus_sign")] public SyntaxTreeToken m_minus_sign { get; private set; }
		[DataMember (Name = "m_SequenceValue")] public SequenceValue m_SequenceValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NumericRealValue

		// delegate function (callback) prototype associated with syntax rule NumericRealValue
		public delegate bool NumericRealValue_Callback (SyntaxTreeCallbackReason reason, NumericRealValue.production_kind kind, NumericRealValue p_NumericRealValue);

		// event associated with syntax rule NumericRealValue
		public event NumericRealValue_Callback NumericRealValue_Event;

		// event trigger associated with syntax rule NumericRealValue
		public bool Raise_NumericRealValue_Event (SyntaxTreeCallbackReason reason, NumericRealValue.production_kind kind, NumericRealValue p_NumericRealValue)
		{
			bool? status = NumericRealValue_Event?.Invoke (reason, kind, p_NumericRealValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NumericRealValue
		//
		// traverse syntax tree node associated with any production of syntax rule NumericRealValue
		//

		public void Traverse (NumericRealValue p_NumericRealValue)
		{
			if (p_NumericRealValue.isLocked())
				return;
			p_NumericRealValue.dolock();
			NumericRealValue.production_kind kind = (NumericRealValue.production_kind) p_NumericRealValue.kind;
			p_NumericRealValue.turn_reset ();
			if (Raise_NumericRealValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NumericRealValue))
			switch (kind)
			{
				case NumericRealValue.production_kind.g_NumericRealValue_1:
					// traverse syntax tree node associated with production
					// NumericRealValue: realnumber

				break;
				case NumericRealValue.production_kind.g_NumericRealValue_2:
					// traverse syntax tree node associated with production
					// NumericRealValue: "-" realnumber

				break;
				case NumericRealValue.production_kind.g_NumericRealValue_3:
					// traverse syntax tree node associated with production
					// NumericRealValue: SequenceValue

					if (Raise_NumericRealValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NumericRealValue))
						Traverse (p_NumericRealValue.m_SequenceValue);
					p_NumericRealValue.turn_inc ();
					Raise_NumericRealValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NumericRealValue);
				break;
			}
			Raise_NumericRealValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NumericRealValue);
			p_NumericRealValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NumericRealValue
		//

		public void TraverseCommon (NumericRealValue p_NumericRealValue)
		{
			NumericRealValue.production_kind kind = (NumericRealValue.production_kind) p_NumericRealValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NumericRealValue))
			switch (kind)
			{
				case NumericRealValue.production_kind.g_NumericRealValue_1:
					// traverse syntax tree node associated with production
					// NumericRealValue: realnumber

						TraverseCommon (p_NumericRealValue.m_realnumber);
				break;
				case NumericRealValue.production_kind.g_NumericRealValue_2:
					// traverse syntax tree node associated with production
					// NumericRealValue: "-" realnumber

						TraverseCommon (p_NumericRealValue.m_minus_sign);
						TraverseCommon (p_NumericRealValue.m_realnumber);
				break;
				case NumericRealValue.production_kind.g_NumericRealValue_3:
					// traverse syntax tree node associated with production
					// NumericRealValue: SequenceValue

						TraverseCommon (p_NumericRealValue.m_SequenceValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NumericRealValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NumericRealValue

		//
		// create syntax tree node associated with production
		// NumericRealValue: realnumber

		//

		public NumericRealValue NumericRealValue_1 (SyntaxTreeToken p_token)
		{
			NumericRealValue p_NumericRealValue_ref = new NumericRealValue(p_token);
			p_token.parent = p_NumericRealValue_ref;
			Raise_NumericRealValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NumericRealValue.production_kind.g_NumericRealValue_1, p_NumericRealValue_ref);
			return p_NumericRealValue_ref;
		}

		//
		// create syntax tree node associated with production
		// NumericRealValue: "-" realnumber

		//

		public NumericRealValue NumericRealValue_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			NumericRealValue p_NumericRealValue_ref = new NumericRealValue(p_token, p_token_1);
			p_token.parent = p_NumericRealValue_ref;
			p_token_1.parent = p_NumericRealValue_ref;
			Raise_NumericRealValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NumericRealValue.production_kind.g_NumericRealValue_2, p_NumericRealValue_ref);
			return p_NumericRealValue_ref;
		}

		//
		// create syntax tree node associated with production
		// NumericRealValue: SequenceValue

		//

		public NumericRealValue NumericRealValue_3 (SequenceValue p_SequenceValue)
		{
			NumericRealValue p_NumericRealValue_ref = new NumericRealValue(p_SequenceValue);
			p_SequenceValue.parent = p_NumericRealValue_ref;
			Raise_NumericRealValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NumericRealValue.production_kind.g_NumericRealValue_3, p_NumericRealValue_ref);
			return p_NumericRealValue_ref;
		}
		#endregion
	};
}
