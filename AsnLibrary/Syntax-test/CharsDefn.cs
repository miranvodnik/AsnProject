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
	// class associated with syntax rule CharsDefn
	//

	[DataContract]
	public class	CharsDefn : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule CharsDefn
		public enum production_kind : ushort	// enumerated production(s) of syntax rule CharsDefn
		{
			g_CharsDefn_1 = 1,	// cstring

			g_CharsDefn_2 = 2,	// Quadruple

			g_CharsDefn_3 = 3,	// Tuple

			g_CharsDefn_4 = 4,	// DefinedValue

		};
		#endregion
		#region production markers associated with the syntax rule CharsDefn

		// markers associated with production: CharsDefn -> cstring

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: CharsDefn -> Quadruple

		public enum production_marker_2 : ushort
		{
			m_Quadruple,
			final
		};

		// markers associated with production: CharsDefn -> Tuple

		public enum production_marker_3 : ushort
		{
			m_Tuple,
			final
		};

		// markers associated with production: CharsDefn -> DefinedValue

		public enum production_marker_4 : ushort
		{
			m_DefinedValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule CharsDefn

		// Constructor declaration(s) associated with production(s) of syntax rule CharsDefn

		//
		// Constructor associated with the following production(s)
		// CharsDefn -> cstring

		//

		public CharsDefn (SyntaxTreeToken p_token) : base ((uint) ProductionID._CharsDefn_ID, (uint) production_kind.g_CharsDefn_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_cstring = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// CharsDefn -> Quadruple

		//

		public CharsDefn (Quadruple p_Quadruple) : base ((uint) ProductionID._CharsDefn_ID, (uint) production_kind.g_CharsDefn_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Quadruple = p_Quadruple;
		}

		//
		// Constructor associated with the following production(s)
		// CharsDefn -> Tuple

		//

		public CharsDefn (Tuple p_Tuple) : base ((uint) ProductionID._CharsDefn_ID, (uint) production_kind.g_CharsDefn_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Tuple = p_Tuple;
		}

		//
		// Constructor associated with the following production(s)
		// CharsDefn -> DefinedValue

		//

		public CharsDefn (DefinedValue p_DefinedValue) : base ((uint) ProductionID._CharsDefn_ID, (uint) production_kind.g_CharsDefn_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinedValue = p_DefinedValue;
		}

		public CharsDefn () { }

		// Copy constructor

		public CharsDefn (CharsDefn p_CharsDefn) : base (p_CharsDefn.id, p_CharsDefn.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_CharsDefn.appInfo;
			switch ((production_kind) p_CharsDefn.kind)
			{
				case production_kind.g_CharsDefn_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_cstring = (p_CharsDefn.m_cstring != null) ? new SyntaxTreeToken (p_CharsDefn.m_cstring) : null) != null) m_cstring.parent = this;
					break;
				case production_kind.g_CharsDefn_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Quadruple = (p_CharsDefn.m_Quadruple != null) ? new Quadruple (p_CharsDefn.m_Quadruple) : null) != null) m_Quadruple.parent = this;
					break;
				case production_kind.g_CharsDefn_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Tuple = (p_CharsDefn.m_Tuple != null) ? new Tuple (p_CharsDefn.m_Tuple) : null) != null) m_Tuple.parent = this;
					break;
				case production_kind.g_CharsDefn_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinedValue = (p_CharsDefn.m_DefinedValue != null) ? new DefinedValue (p_CharsDefn.m_DefinedValue) : null) != null) m_DefinedValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "CharsDefn" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new CharsDefn (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_cstring?.Dispose ();
			m_Quadruple?.Dispose ();
			m_Tuple?.Dispose ();
			m_DefinedValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule CharsDefn

		// Content changing function(s) associated with production(s) of syntax rule CharsDefn

		//
		// Content changing function associated with following production(s)
		// CharsDefn -> cstring

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_CharsDefn_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_cstring = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// CharsDefn -> Quadruple

		//

		public void change(Quadruple p_Quadruple)
		{
			_init ();
			this.kind = (uint) production_kind.g_CharsDefn_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Quadruple = p_Quadruple;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// CharsDefn -> Tuple

		//

		public void change(Tuple p_Tuple)
		{
			_init ();
			this.kind = (uint) production_kind.g_CharsDefn_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Tuple = p_Tuple;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// CharsDefn -> DefinedValue

		//

		public void change(DefinedValue p_DefinedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_CharsDefn_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinedValue = p_DefinedValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule CharsDefn
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				(m_Quadruple != null) && m_Quadruple.checkInclusion (element) ||
				(m_Tuple != null) && m_Tuple.checkInclusion (element) ||
				(m_DefinedValue != null) && m_DefinedValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule CharsDefn

		//
		// emit production tree node associated with any production of syntax rule CharsDefn
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_CharsDefn_1:
					// emit syntax tree node associated with production
					// CharsDefn: cstring

					s += m_cstring.Emit (depth - 1);
				break;
				case production_kind.g_CharsDefn_2:
					// emit syntax tree node associated with production
					// CharsDefn: Quadruple

					s += m_Quadruple.Emit (depth - 1);
				break;
				case production_kind.g_CharsDefn_3:
					// emit syntax tree node associated with production
					// CharsDefn: Tuple

					s += m_Tuple.Emit (depth - 1);
				break;
				case production_kind.g_CharsDefn_4:
					// emit syntax tree node associated with production
					// CharsDefn: DefinedValue

					s += m_DefinedValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule CharsDefn
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "CharsDefn (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_CharsDefn_1:
					// emit syntax tree node associated with production
					// CharsDefn: cstring

					s += "cstring";
				break;
				case production_kind.g_CharsDefn_2:
					// emit syntax tree node associated with production
					// CharsDefn: Quadruple

					s += m_Quadruple.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_CharsDefn_3:
					// emit syntax tree node associated with production
					// CharsDefn: Tuple

					s += m_Tuple.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_CharsDefn_4:
					// emit syntax tree node associated with production
					// CharsDefn: DefinedValue

					s += m_DefinedValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule CharsDefn

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule CharsDefn with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			CharsDefn.production_kind kind = (CharsDefn.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case CharsDefn.production_kind.g_CharsDefn_1:
					// traverse syntax tree node associated with production
					// CharsDefn: cstring

						m_cstring.Visit (visitor, appData);
				break;
				case CharsDefn.production_kind.g_CharsDefn_2:
					// traverse syntax tree node associated with production
					// CharsDefn: Quadruple

						m_Quadruple.Visit (visitor, appData);
				break;
				case CharsDefn.production_kind.g_CharsDefn_3:
					// traverse syntax tree node associated with production
					// CharsDefn: Tuple

						m_Tuple.Visit (visitor, appData);
				break;
				case CharsDefn.production_kind.g_CharsDefn_4:
					// traverse syntax tree node associated with production
					// CharsDefn: DefinedValue

						m_DefinedValue.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_cstring?.reparent (this);
			m_Quadruple?.reparent (this);
			m_Tuple?.reparent (this);
			m_DefinedValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule CharsDefn
		//

		public void _init ()
		{
			m_cstring = null;
			m_Quadruple = null;
			m_Tuple = null;
			m_DefinedValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule CharsDefn

		// counter of all nodes associated with syntax rule CharsDefn
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule CharsDefn
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		[DataMember (Name = "m_Quadruple")] public Quadruple m_Quadruple { get; private set; }
		[DataMember (Name = "m_Tuple")] public Tuple m_Tuple { get; private set; }
		[DataMember (Name = "m_DefinedValue")] public DefinedValue m_DefinedValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule CharsDefn

		// delegate function (callback) prototype associated with syntax rule CharsDefn
		public delegate bool CharsDefn_Callback (SyntaxTreeCallbackReason reason, CharsDefn.production_kind kind, CharsDefn p_CharsDefn);

		// event associated with syntax rule CharsDefn
		public event CharsDefn_Callback CharsDefn_Event;

		// event trigger associated with syntax rule CharsDefn
		public bool Raise_CharsDefn_Event (SyntaxTreeCallbackReason reason, CharsDefn.production_kind kind, CharsDefn p_CharsDefn)
		{
			bool? status = CharsDefn_Event?.Invoke (reason, kind, p_CharsDefn);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule CharsDefn
		//
		// traverse syntax tree node associated with any production of syntax rule CharsDefn
		//

		public void Traverse (CharsDefn p_CharsDefn)
		{
			if (p_CharsDefn.isLocked())
				return;
			p_CharsDefn.dolock();
			CharsDefn.production_kind kind = (CharsDefn.production_kind) p_CharsDefn.kind;
			p_CharsDefn.turn_reset ();
			if (Raise_CharsDefn_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_CharsDefn))
			switch (kind)
			{
				case CharsDefn.production_kind.g_CharsDefn_1:
					// traverse syntax tree node associated with production
					// CharsDefn: cstring

				break;
				case CharsDefn.production_kind.g_CharsDefn_2:
					// traverse syntax tree node associated with production
					// CharsDefn: Quadruple

					if (Raise_CharsDefn_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_CharsDefn))
						Traverse (p_CharsDefn.m_Quadruple);
					p_CharsDefn.turn_inc ();
					Raise_CharsDefn_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_CharsDefn);
				break;
				case CharsDefn.production_kind.g_CharsDefn_3:
					// traverse syntax tree node associated with production
					// CharsDefn: Tuple

					if (Raise_CharsDefn_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_CharsDefn))
						Traverse (p_CharsDefn.m_Tuple);
					p_CharsDefn.turn_inc ();
					Raise_CharsDefn_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_CharsDefn);
				break;
				case CharsDefn.production_kind.g_CharsDefn_4:
					// traverse syntax tree node associated with production
					// CharsDefn: DefinedValue

					if (Raise_CharsDefn_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_CharsDefn))
						Traverse (p_CharsDefn.m_DefinedValue);
					p_CharsDefn.turn_inc ();
					Raise_CharsDefn_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_CharsDefn);
				break;
			}
			Raise_CharsDefn_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_CharsDefn);
			p_CharsDefn.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule CharsDefn
		//

		public void TraverseCommon (CharsDefn p_CharsDefn)
		{
			CharsDefn.production_kind kind = (CharsDefn.production_kind) p_CharsDefn.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_CharsDefn))
			switch (kind)
			{
				case CharsDefn.production_kind.g_CharsDefn_1:
					// traverse syntax tree node associated with production
					// CharsDefn: cstring

						TraverseCommon (p_CharsDefn.m_cstring);
				break;
				case CharsDefn.production_kind.g_CharsDefn_2:
					// traverse syntax tree node associated with production
					// CharsDefn: Quadruple

						TraverseCommon (p_CharsDefn.m_Quadruple);
				break;
				case CharsDefn.production_kind.g_CharsDefn_3:
					// traverse syntax tree node associated with production
					// CharsDefn: Tuple

						TraverseCommon (p_CharsDefn.m_Tuple);
				break;
				case CharsDefn.production_kind.g_CharsDefn_4:
					// traverse syntax tree node associated with production
					// CharsDefn: DefinedValue

						TraverseCommon (p_CharsDefn.m_DefinedValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_CharsDefn);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule CharsDefn

		//
		// create syntax tree node associated with production
		// CharsDefn: cstring

		//

		public CharsDefn CharsDefn_1 (SyntaxTreeToken p_token)
		{
			CharsDefn p_CharsDefn_ref = new CharsDefn(p_token);
			p_token.parent = p_CharsDefn_ref;
			Raise_CharsDefn_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, CharsDefn.production_kind.g_CharsDefn_1, p_CharsDefn_ref);
			return p_CharsDefn_ref;
		}

		//
		// create syntax tree node associated with production
		// CharsDefn: Quadruple

		//

		public CharsDefn CharsDefn_2 (Quadruple p_Quadruple)
		{
			CharsDefn p_CharsDefn_ref = new CharsDefn(p_Quadruple);
			p_Quadruple.parent = p_CharsDefn_ref;
			Raise_CharsDefn_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, CharsDefn.production_kind.g_CharsDefn_2, p_CharsDefn_ref);
			return p_CharsDefn_ref;
		}

		//
		// create syntax tree node associated with production
		// CharsDefn: Tuple

		//

		public CharsDefn CharsDefn_3 (Tuple p_Tuple)
		{
			CharsDefn p_CharsDefn_ref = new CharsDefn(p_Tuple);
			p_Tuple.parent = p_CharsDefn_ref;
			Raise_CharsDefn_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, CharsDefn.production_kind.g_CharsDefn_3, p_CharsDefn_ref);
			return p_CharsDefn_ref;
		}

		//
		// create syntax tree node associated with production
		// CharsDefn: DefinedValue

		//

		public CharsDefn CharsDefn_4 (DefinedValue p_DefinedValue)
		{
			CharsDefn p_CharsDefn_ref = new CharsDefn(p_DefinedValue);
			p_DefinedValue.parent = p_CharsDefn_ref;
			Raise_CharsDefn_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, CharsDefn.production_kind.g_CharsDefn_4, p_CharsDefn_ref);
			return p_CharsDefn_ref;
		}
		#endregion
	};
}
