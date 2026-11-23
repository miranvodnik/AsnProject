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
	// class associated with syntax rule SpecialRealValue
	//

	[DataContract]
	public class	SpecialRealValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SpecialRealValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SpecialRealValue
		{
			g_SpecialRealValue_1 = 1,	// PLUS-INFINITY

			g_SpecialRealValue_2 = 2,	// MINUS-INFINITY

			g_SpecialRealValue_3 = 3,	// NOT-A-NUMBER

		};
		#endregion
		#region production markers associated with the syntax rule SpecialRealValue

		// markers associated with production: SpecialRealValue -> PLUS-INFINITY

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: SpecialRealValue -> MINUS-INFINITY

		public enum production_marker_2 : ushort
		{
			final
		};

		// markers associated with production: SpecialRealValue -> NOT-A-NUMBER

		public enum production_marker_3 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SpecialRealValue

		// Constructor declaration(s) associated with production(s) of syntax rule SpecialRealValue

		//
		// Constructor associated with the following production(s)
		// SpecialRealValue -> PLUS-INFINITY

		// SpecialRealValue -> MINUS-INFINITY

		// SpecialRealValue -> NOT-A-NUMBER

		//

		public SpecialRealValue (SyntaxTreeToken p_token, int kind) : base ((uint) ProductionID._SpecialRealValue_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_SpecialRealValue_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_PLUS_INFINITY = p_token;
				break;
			case production_kind.g_SpecialRealValue_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_MINUS_INFINITY = p_token;
				break;
			case production_kind.g_SpecialRealValue_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_NOT_A_NUMBER = p_token;
				break;
			default:
				{
					string[] args = new string[] { "SpecialRealValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		public SpecialRealValue () { }

		// Copy constructor

		public SpecialRealValue (SpecialRealValue p_SpecialRealValue) : base (p_SpecialRealValue.id, p_SpecialRealValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SpecialRealValue.appInfo;
			switch ((production_kind) p_SpecialRealValue.kind)
			{
				case production_kind.g_SpecialRealValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_PLUS_INFINITY = (p_SpecialRealValue.m_PLUS_INFINITY != null) ? new SyntaxTreeToken (p_SpecialRealValue.m_PLUS_INFINITY) : null) != null) m_PLUS_INFINITY.parent = this;
					break;
				case production_kind.g_SpecialRealValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MINUS_INFINITY = (p_SpecialRealValue.m_MINUS_INFINITY != null) ? new SyntaxTreeToken (p_SpecialRealValue.m_MINUS_INFINITY) : null) != null) m_MINUS_INFINITY.parent = this;
					break;
				case production_kind.g_SpecialRealValue_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NOT_A_NUMBER = (p_SpecialRealValue.m_NOT_A_NUMBER != null) ? new SyntaxTreeToken (p_SpecialRealValue.m_NOT_A_NUMBER) : null) != null) m_NOT_A_NUMBER.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SpecialRealValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SpecialRealValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_PLUS_INFINITY?.Dispose ();
			m_MINUS_INFINITY?.Dispose ();
			m_NOT_A_NUMBER?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SpecialRealValue

		// Content changing function(s) associated with production(s) of syntax rule SpecialRealValue

		//
		// Content changing function associated with following production(s)
		// SpecialRealValue -> PLUS-INFINITY

		// SpecialRealValue -> MINUS-INFINITY

		// SpecialRealValue -> NOT-A-NUMBER

		//

		public void change(SyntaxTreeToken p_token, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_SpecialRealValue_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_PLUS_INFINITY = p_token;
				break;
			case production_kind.g_SpecialRealValue_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_MINUS_INFINITY = p_token;
				break;
			case production_kind.g_SpecialRealValue_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_NOT_A_NUMBER = p_token;
				break;
			default:
				{
					string[] args = new string[] { "SpecialRealValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SpecialRealValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_PLUS_INFINITY != null) && m_PLUS_INFINITY.checkInclusion (element) ||
				(m_MINUS_INFINITY != null) && m_MINUS_INFINITY.checkInclusion (element) ||
				(m_NOT_A_NUMBER != null) && m_NOT_A_NUMBER.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SpecialRealValue

		//
		// emit production tree node associated with any production of syntax rule SpecialRealValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SpecialRealValue_1:
					// emit syntax tree node associated with production
					// SpecialRealValue: PLUS-INFINITY

					s += m_PLUS_INFINITY.Emit (depth - 1);
				break;
				case production_kind.g_SpecialRealValue_2:
					// emit syntax tree node associated with production
					// SpecialRealValue: MINUS-INFINITY

					s += m_MINUS_INFINITY.Emit (depth - 1);
				break;
				case production_kind.g_SpecialRealValue_3:
					// emit syntax tree node associated with production
					// SpecialRealValue: NOT-A-NUMBER

					s += m_NOT_A_NUMBER.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SpecialRealValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SpecialRealValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SpecialRealValue_1:
					// emit syntax tree node associated with production
					// SpecialRealValue: PLUS-INFINITY

					s += "PLUS_INFINITY";
				break;
				case production_kind.g_SpecialRealValue_2:
					// emit syntax tree node associated with production
					// SpecialRealValue: MINUS-INFINITY

					s += "MINUS_INFINITY";
				break;
				case production_kind.g_SpecialRealValue_3:
					// emit syntax tree node associated with production
					// SpecialRealValue: NOT-A-NUMBER

					s += "NOT_A_NUMBER";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SpecialRealValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SpecialRealValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SpecialRealValue.production_kind kind = (SpecialRealValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SpecialRealValue.production_kind.g_SpecialRealValue_1:
					// traverse syntax tree node associated with production
					// SpecialRealValue: PLUS-INFINITY

						m_PLUS_INFINITY.Visit (visitor, appData);
				break;
				case SpecialRealValue.production_kind.g_SpecialRealValue_2:
					// traverse syntax tree node associated with production
					// SpecialRealValue: MINUS-INFINITY

						m_MINUS_INFINITY.Visit (visitor, appData);
				break;
				case SpecialRealValue.production_kind.g_SpecialRealValue_3:
					// traverse syntax tree node associated with production
					// SpecialRealValue: NOT-A-NUMBER

						m_NOT_A_NUMBER.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_PLUS_INFINITY?.reparent (this);
			m_MINUS_INFINITY?.reparent (this);
			m_NOT_A_NUMBER?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SpecialRealValue
		//

		public void _init ()
		{
			m_PLUS_INFINITY = null;
			m_MINUS_INFINITY = null;
			m_NOT_A_NUMBER = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SpecialRealValue

		// counter of all nodes associated with syntax rule SpecialRealValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SpecialRealValue
		[DataMember (Name = "m_PLUS_INFINITY")] public SyntaxTreeToken m_PLUS_INFINITY { get; private set; }
		[DataMember (Name = "m_MINUS_INFINITY")] public SyntaxTreeToken m_MINUS_INFINITY { get; private set; }
		[DataMember (Name = "m_NOT_A_NUMBER")] public SyntaxTreeToken m_NOT_A_NUMBER { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SpecialRealValue

		// delegate function (callback) prototype associated with syntax rule SpecialRealValue
		public delegate bool SpecialRealValue_Callback (SyntaxTreeCallbackReason reason, SpecialRealValue.production_kind kind, SpecialRealValue p_SpecialRealValue);

		// event associated with syntax rule SpecialRealValue
		public event SpecialRealValue_Callback SpecialRealValue_Event;

		// event trigger associated with syntax rule SpecialRealValue
		public bool Raise_SpecialRealValue_Event (SyntaxTreeCallbackReason reason, SpecialRealValue.production_kind kind, SpecialRealValue p_SpecialRealValue)
		{
			bool? status = SpecialRealValue_Event?.Invoke (reason, kind, p_SpecialRealValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SpecialRealValue
		//
		// traverse syntax tree node associated with any production of syntax rule SpecialRealValue
		//

		public void Traverse (SpecialRealValue p_SpecialRealValue)
		{
			if (p_SpecialRealValue.isLocked())
				return;
			p_SpecialRealValue.dolock();
			SpecialRealValue.production_kind kind = (SpecialRealValue.production_kind) p_SpecialRealValue.kind;
			p_SpecialRealValue.turn_reset ();
			if (Raise_SpecialRealValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SpecialRealValue))
			switch (kind)
			{
				case SpecialRealValue.production_kind.g_SpecialRealValue_1:
					// traverse syntax tree node associated with production
					// SpecialRealValue: PLUS-INFINITY

				break;
				case SpecialRealValue.production_kind.g_SpecialRealValue_2:
					// traverse syntax tree node associated with production
					// SpecialRealValue: MINUS-INFINITY

				break;
				case SpecialRealValue.production_kind.g_SpecialRealValue_3:
					// traverse syntax tree node associated with production
					// SpecialRealValue: NOT-A-NUMBER

				break;
			}
			Raise_SpecialRealValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SpecialRealValue);
			p_SpecialRealValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SpecialRealValue
		//

		public void TraverseCommon (SpecialRealValue p_SpecialRealValue)
		{
			SpecialRealValue.production_kind kind = (SpecialRealValue.production_kind) p_SpecialRealValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SpecialRealValue))
			switch (kind)
			{
				case SpecialRealValue.production_kind.g_SpecialRealValue_1:
					// traverse syntax tree node associated with production
					// SpecialRealValue: PLUS-INFINITY

						TraverseCommon (p_SpecialRealValue.m_PLUS_INFINITY);
				break;
				case SpecialRealValue.production_kind.g_SpecialRealValue_2:
					// traverse syntax tree node associated with production
					// SpecialRealValue: MINUS-INFINITY

						TraverseCommon (p_SpecialRealValue.m_MINUS_INFINITY);
				break;
				case SpecialRealValue.production_kind.g_SpecialRealValue_3:
					// traverse syntax tree node associated with production
					// SpecialRealValue: NOT-A-NUMBER

						TraverseCommon (p_SpecialRealValue.m_NOT_A_NUMBER);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SpecialRealValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SpecialRealValue

		//
		// create syntax tree node associated with production
		// SpecialRealValue: PLUS-INFINITY

		//

		public SpecialRealValue SpecialRealValue_1 (SyntaxTreeToken p_token)
		{
			SpecialRealValue p_SpecialRealValue_ref = new SpecialRealValue(p_token, 1);
			p_token.parent = p_SpecialRealValue_ref;
			Raise_SpecialRealValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SpecialRealValue.production_kind.g_SpecialRealValue_1, p_SpecialRealValue_ref);
			return p_SpecialRealValue_ref;
		}

		//
		// create syntax tree node associated with production
		// SpecialRealValue: MINUS-INFINITY

		//

		public SpecialRealValue SpecialRealValue_2 (SyntaxTreeToken p_token)
		{
			SpecialRealValue p_SpecialRealValue_ref = new SpecialRealValue(p_token, 2);
			p_token.parent = p_SpecialRealValue_ref;
			Raise_SpecialRealValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SpecialRealValue.production_kind.g_SpecialRealValue_2, p_SpecialRealValue_ref);
			return p_SpecialRealValue_ref;
		}

		//
		// create syntax tree node associated with production
		// SpecialRealValue: NOT-A-NUMBER

		//

		public SpecialRealValue SpecialRealValue_3 (SyntaxTreeToken p_token)
		{
			SpecialRealValue p_SpecialRealValue_ref = new SpecialRealValue(p_token, 3);
			p_token.parent = p_SpecialRealValue_ref;
			Raise_SpecialRealValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SpecialRealValue.production_kind.g_SpecialRealValue_3, p_SpecialRealValue_ref);
			return p_SpecialRealValue_ref;
		}
		#endregion
	};
}
