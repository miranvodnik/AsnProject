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
	// class associated with syntax rule ContentsConstraint
	//

	[DataContract]
	public class	ContentsConstraint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ContentsConstraint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ContentsConstraint
		{
			g_ContentsConstraint_1 = 1,	// CONTAINING Type

			g_ContentsConstraint_2 = 2,	// ENCODED BY Value

			g_ContentsConstraint_3 = 3,	// CONTAINING Type ENCODED BY Value

		};
		#endregion
		#region production markers associated with the syntax rule ContentsConstraint

		// markers associated with production: ContentsConstraint -> CONTAINING Type

		public enum production_marker_1 : ushort
		{
			m_Type,
			final
		};

		// markers associated with production: ContentsConstraint -> ENCODED BY Value

		public enum production_marker_2 : ushort
		{
			m_Value,
			final
		};

		// markers associated with production: ContentsConstraint -> CONTAINING Type ENCODED BY Value

		public enum production_marker_3 : ushort
		{
			m_Type,
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ContentsConstraint

		// Constructor declaration(s) associated with production(s) of syntax rule ContentsConstraint

		//
		// Constructor associated with the following production(s)
		// ContentsConstraint -> CONTAINING Type

		//

		public ContentsConstraint (SyntaxTreeToken p_token, Type p_Type) : base ((uint) ProductionID._ContentsConstraint_ID, (uint) production_kind.g_ContentsConstraint_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_CONTAINING = p_token;
			children[1] = m_Type = p_Type;
		}

		//
		// Constructor associated with the following production(s)
		// ContentsConstraint -> ENCODED BY Value

		//

		public ContentsConstraint (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, Value p_Value) : base ((uint) ProductionID._ContentsConstraint_ID, (uint) production_kind.g_ContentsConstraint_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_ENCODED = p_token;
			children[1] = m_BY = p_token_1;
			children[2] = m_Value = p_Value;
		}

		//
		// Constructor associated with the following production(s)
		// ContentsConstraint -> CONTAINING Type ENCODED BY Value

		//

		public ContentsConstraint (SyntaxTreeToken p_token, Type p_Type, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, Value p_Value) : base ((uint) ProductionID._ContentsConstraint_ID, (uint) production_kind.g_ContentsConstraint_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children[0] = m_CONTAINING = p_token;
			children[1] = m_Type = p_Type;
			children[2] = m_ENCODED = p_token_1;
			children[3] = m_BY = p_token_2;
			children[4] = m_Value = p_Value;
		}

		public ContentsConstraint () { }

		// Copy constructor

		public ContentsConstraint (ContentsConstraint p_ContentsConstraint) : base (p_ContentsConstraint.id, p_ContentsConstraint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ContentsConstraint.appInfo;
			switch ((production_kind) p_ContentsConstraint.kind)
			{
				case production_kind.g_ContentsConstraint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_CONTAINING = (p_ContentsConstraint.m_CONTAINING != null) ? new SyntaxTreeToken (p_ContentsConstraint.m_CONTAINING) : null) != null) m_CONTAINING.parent = this;
					if ((children [1] = m_Type = (p_ContentsConstraint.m_Type != null) ? new Type (p_ContentsConstraint.m_Type) : null) != null) m_Type.parent = this;
					break;
				case production_kind.g_ContentsConstraint_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_ENCODED = (p_ContentsConstraint.m_ENCODED != null) ? new SyntaxTreeToken (p_ContentsConstraint.m_ENCODED) : null) != null) m_ENCODED.parent = this;
					if ((children [1] = m_BY = (p_ContentsConstraint.m_BY != null) ? new SyntaxTreeToken (p_ContentsConstraint.m_BY) : null) != null) m_BY.parent = this;
					if ((children [2] = m_Value = (p_ContentsConstraint.m_Value != null) ? new Value (p_ContentsConstraint.m_Value) : null) != null) m_Value.parent = this;
					break;
				case production_kind.g_ContentsConstraint_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_CONTAINING = (p_ContentsConstraint.m_CONTAINING != null) ? new SyntaxTreeToken (p_ContentsConstraint.m_CONTAINING) : null) != null) m_CONTAINING.parent = this;
					if ((children [1] = m_Type = (p_ContentsConstraint.m_Type != null) ? new Type (p_ContentsConstraint.m_Type) : null) != null) m_Type.parent = this;
					if ((children [2] = m_ENCODED = (p_ContentsConstraint.m_ENCODED != null) ? new SyntaxTreeToken (p_ContentsConstraint.m_ENCODED) : null) != null) m_ENCODED.parent = this;
					if ((children [3] = m_BY = (p_ContentsConstraint.m_BY != null) ? new SyntaxTreeToken (p_ContentsConstraint.m_BY) : null) != null) m_BY.parent = this;
					if ((children [4] = m_Value = (p_ContentsConstraint.m_Value != null) ? new Value (p_ContentsConstraint.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ContentsConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ContentsConstraint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_CONTAINING?.Dispose ();
			m_Type?.Dispose ();
			m_ENCODED?.Dispose ();
			m_BY?.Dispose ();
			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ContentsConstraint

		// Content changing function(s) associated with production(s) of syntax rule ContentsConstraint

		//
		// Content changing function associated with following production(s)
		// ContentsConstraint -> CONTAINING Type

		//

		public void change(SyntaxTreeToken p_token, Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_ContentsConstraint_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_CONTAINING = p_token;
			children [1] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ContentsConstraint -> ENCODED BY Value

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_ContentsConstraint_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_ENCODED = p_token;
			children [1] = m_BY = p_token_1;
			children [2] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ContentsConstraint -> CONTAINING Type ENCODED BY Value

		//

		public void change(SyntaxTreeToken p_token, Type p_Type, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_ContentsConstraint_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children [0] = m_CONTAINING = p_token;
			children [1] = m_Type = p_Type;
			children [2] = m_ENCODED = p_token_1;
			children [3] = m_BY = p_token_2;
			children [4] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ContentsConstraint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_CONTAINING != null) && m_CONTAINING.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_ENCODED != null) && m_ENCODED.checkInclusion (element) ||
				(m_BY != null) && m_BY.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ContentsConstraint

		//
		// emit production tree node associated with any production of syntax rule ContentsConstraint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ContentsConstraint_1:
					// emit syntax tree node associated with production
					// ContentsConstraint: CONTAINING Type

					s += m_CONTAINING.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
				break;
				case production_kind.g_ContentsConstraint_2:
					// emit syntax tree node associated with production
					// ContentsConstraint: ENCODED BY Value

					s += m_ENCODED.Emit (depth - 1);
					s += " ";
					s += m_BY.Emit (depth - 1);
					s += " ";
					s += m_Value.Emit (depth - 1);
				break;
				case production_kind.g_ContentsConstraint_3:
					// emit syntax tree node associated with production
					// ContentsConstraint: CONTAINING Type ENCODED BY Value

					s += m_CONTAINING.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
					s += " ";
					s += m_ENCODED.Emit (depth - 1);
					s += " ";
					s += m_BY.Emit (depth - 1);
					s += " ";
					s += m_Value.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ContentsConstraint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ContentsConstraint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ContentsConstraint_1:
					// emit syntax tree node associated with production
					// ContentsConstraint: CONTAINING Type

					s += "CONTAINING";
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ContentsConstraint_2:
					// emit syntax tree node associated with production
					// ContentsConstraint: ENCODED BY Value

					s += "ENCODED";
					s += ' ';
					s += "BY";
					s += ' ';
					s += m_Value.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ContentsConstraint_3:
					// emit syntax tree node associated with production
					// ContentsConstraint: CONTAINING Type ENCODED BY Value

					s += "CONTAINING";
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
					s += ' ';
					s += "ENCODED";
					s += ' ';
					s += "BY";
					s += ' ';
					s += m_Value.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ContentsConstraint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ContentsConstraint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ContentsConstraint.production_kind kind = (ContentsConstraint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ContentsConstraint.production_kind.g_ContentsConstraint_1:
					// traverse syntax tree node associated with production
					// ContentsConstraint: CONTAINING Type

						m_CONTAINING.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
				break;
				case ContentsConstraint.production_kind.g_ContentsConstraint_2:
					// traverse syntax tree node associated with production
					// ContentsConstraint: ENCODED BY Value

						m_ENCODED.Visit (visitor, appData);
						m_BY.Visit (visitor, appData);
						m_Value.Visit (visitor, appData);
				break;
				case ContentsConstraint.production_kind.g_ContentsConstraint_3:
					// traverse syntax tree node associated with production
					// ContentsConstraint: CONTAINING Type ENCODED BY Value

						m_CONTAINING.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
						m_ENCODED.Visit (visitor, appData);
						m_BY.Visit (visitor, appData);
						m_Value.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_CONTAINING?.reparent (this);
			m_Type?.reparent (this);
			m_ENCODED?.reparent (this);
			m_BY?.reparent (this);
			m_Value?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ContentsConstraint
		//

		public void _init ()
		{
			m_CONTAINING = null;
			m_Type = null;
			m_ENCODED = null;
			m_BY = null;
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ContentsConstraint

		// counter of all nodes associated with syntax rule ContentsConstraint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ContentsConstraint
		[DataMember (Name = "m_CONTAINING")] public SyntaxTreeToken m_CONTAINING { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_ENCODED")] public SyntaxTreeToken m_ENCODED { get; private set; }
		[DataMember (Name = "m_BY")] public SyntaxTreeToken m_BY { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ContentsConstraint

		// delegate function (callback) prototype associated with syntax rule ContentsConstraint
		public delegate bool ContentsConstraint_Callback (SyntaxTreeCallbackReason reason, ContentsConstraint.production_kind kind, ContentsConstraint p_ContentsConstraint);

		// event associated with syntax rule ContentsConstraint
		public event ContentsConstraint_Callback ContentsConstraint_Event;

		// event trigger associated with syntax rule ContentsConstraint
		public bool Raise_ContentsConstraint_Event (SyntaxTreeCallbackReason reason, ContentsConstraint.production_kind kind, ContentsConstraint p_ContentsConstraint)
		{
			bool? status = ContentsConstraint_Event?.Invoke (reason, kind, p_ContentsConstraint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ContentsConstraint
		//
		// traverse syntax tree node associated with any production of syntax rule ContentsConstraint
		//

		public void Traverse (ContentsConstraint p_ContentsConstraint)
		{
			if (p_ContentsConstraint.isLocked())
				return;
			p_ContentsConstraint.dolock();
			ContentsConstraint.production_kind kind = (ContentsConstraint.production_kind) p_ContentsConstraint.kind;
			p_ContentsConstraint.turn_reset ();
			if (Raise_ContentsConstraint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ContentsConstraint))
			switch (kind)
			{
				case ContentsConstraint.production_kind.g_ContentsConstraint_1:
					// traverse syntax tree node associated with production
					// ContentsConstraint: CONTAINING Type

					if (Raise_ContentsConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ContentsConstraint))
						Traverse (p_ContentsConstraint.m_Type);
					p_ContentsConstraint.turn_inc ();
					Raise_ContentsConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ContentsConstraint);
				break;
				case ContentsConstraint.production_kind.g_ContentsConstraint_2:
					// traverse syntax tree node associated with production
					// ContentsConstraint: ENCODED BY Value

					if (Raise_ContentsConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ContentsConstraint))
						Traverse (p_ContentsConstraint.m_Value);
					p_ContentsConstraint.turn_inc ();
					Raise_ContentsConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ContentsConstraint);
				break;
				case ContentsConstraint.production_kind.g_ContentsConstraint_3:
					// traverse syntax tree node associated with production
					// ContentsConstraint: CONTAINING Type ENCODED BY Value

					if (Raise_ContentsConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ContentsConstraint))
						Traverse (p_ContentsConstraint.m_Type);
					p_ContentsConstraint.turn_inc ();
					if (Raise_ContentsConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ContentsConstraint))
						Traverse (p_ContentsConstraint.m_Value);
					p_ContentsConstraint.turn_inc ();
					Raise_ContentsConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ContentsConstraint);
				break;
			}
			Raise_ContentsConstraint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ContentsConstraint);
			p_ContentsConstraint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ContentsConstraint
		//

		public void TraverseCommon (ContentsConstraint p_ContentsConstraint)
		{
			ContentsConstraint.production_kind kind = (ContentsConstraint.production_kind) p_ContentsConstraint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ContentsConstraint))
			switch (kind)
			{
				case ContentsConstraint.production_kind.g_ContentsConstraint_1:
					// traverse syntax tree node associated with production
					// ContentsConstraint: CONTAINING Type

						TraverseCommon (p_ContentsConstraint.m_CONTAINING);
						TraverseCommon (p_ContentsConstraint.m_Type);
				break;
				case ContentsConstraint.production_kind.g_ContentsConstraint_2:
					// traverse syntax tree node associated with production
					// ContentsConstraint: ENCODED BY Value

						TraverseCommon (p_ContentsConstraint.m_ENCODED);
						TraverseCommon (p_ContentsConstraint.m_BY);
						TraverseCommon (p_ContentsConstraint.m_Value);
				break;
				case ContentsConstraint.production_kind.g_ContentsConstraint_3:
					// traverse syntax tree node associated with production
					// ContentsConstraint: CONTAINING Type ENCODED BY Value

						TraverseCommon (p_ContentsConstraint.m_CONTAINING);
						TraverseCommon (p_ContentsConstraint.m_Type);
						TraverseCommon (p_ContentsConstraint.m_ENCODED);
						TraverseCommon (p_ContentsConstraint.m_BY);
						TraverseCommon (p_ContentsConstraint.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ContentsConstraint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ContentsConstraint

		//
		// create syntax tree node associated with production
		// ContentsConstraint: CONTAINING Type

		//

		public ContentsConstraint ContentsConstraint_1 (SyntaxTreeToken p_token, Type p_Type)
		{
			ContentsConstraint p_ContentsConstraint_ref = new ContentsConstraint(p_token, p_Type);
			p_token.parent = p_ContentsConstraint_ref;
			p_Type.parent = p_ContentsConstraint_ref;
			Raise_ContentsConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ContentsConstraint.production_kind.g_ContentsConstraint_1, p_ContentsConstraint_ref);
			return p_ContentsConstraint_ref;
		}

		//
		// create syntax tree node associated with production
		// ContentsConstraint: ENCODED BY Value

		//

		public ContentsConstraint ContentsConstraint_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, Value p_Value)
		{
			ContentsConstraint p_ContentsConstraint_ref = new ContentsConstraint(p_token, p_token_1, p_Value);
			p_token.parent = p_ContentsConstraint_ref;
			p_token_1.parent = p_ContentsConstraint_ref;
			p_Value.parent = p_ContentsConstraint_ref;
			Raise_ContentsConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ContentsConstraint.production_kind.g_ContentsConstraint_2, p_ContentsConstraint_ref);
			return p_ContentsConstraint_ref;
		}

		//
		// create syntax tree node associated with production
		// ContentsConstraint: CONTAINING Type ENCODED BY Value

		//

		public ContentsConstraint ContentsConstraint_3 (SyntaxTreeToken p_token, Type p_Type, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, Value p_Value)
		{
			ContentsConstraint p_ContentsConstraint_ref = new ContentsConstraint(p_token, p_Type, p_token_1, p_token_2, p_Value);
			p_token.parent = p_ContentsConstraint_ref;
			p_Type.parent = p_ContentsConstraint_ref;
			p_token_1.parent = p_ContentsConstraint_ref;
			p_token_2.parent = p_ContentsConstraint_ref;
			p_Value.parent = p_ContentsConstraint_ref;
			Raise_ContentsConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ContentsConstraint.production_kind.g_ContentsConstraint_3, p_ContentsConstraint_ref);
			return p_ContentsConstraint_ref;
		}
		#endregion
	};
}
