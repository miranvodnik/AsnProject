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
	// class associated with syntax rule SymbolsExported
	//

	[DataContract]
	public class	SymbolsExported : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SymbolsExported
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SymbolsExported
		{
			g_SymbolsExported_1 = 1,	// SymbolList

			g_SymbolsExported_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule SymbolsExported

		// markers associated with production: SymbolsExported -> SymbolList

		public enum production_marker_1 : ushort
		{
			m_SymbolList,
			final
		};

		// markers associated with production: SymbolsExported -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SymbolsExported

		// Constructor declaration(s) associated with production(s) of syntax rule SymbolsExported

		//
		// Constructor associated with the following production(s)
		// SymbolsExported -> SymbolList

		//

		public SymbolsExported (SymbolList p_SymbolList) : base ((uint) ProductionID._SymbolsExported_ID, (uint) production_kind.g_SymbolsExported_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SymbolList = p_SymbolList;
		}

		//
		// Constructor associated with the following production(s)
		// SymbolsExported -> %empty

		//

		public SymbolsExported () : base ((uint) ProductionID._SymbolsExported_ID, (uint) production_kind.g_SymbolsExported_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public SymbolsExported (SymbolsExported p_SymbolsExported) : base (p_SymbolsExported.id, p_SymbolsExported.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SymbolsExported.appInfo;
			switch ((production_kind) p_SymbolsExported.kind)
			{
				case production_kind.g_SymbolsExported_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SymbolList = (p_SymbolsExported.m_SymbolList != null) ? new SymbolList (p_SymbolsExported.m_SymbolList) : null) != null) m_SymbolList.parent = this;
					break;
				case production_kind.g_SymbolsExported_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "SymbolsExported" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SymbolsExported (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SymbolList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SymbolsExported

		// Content changing function(s) associated with production(s) of syntax rule SymbolsExported

		//
		// Content changing function associated with following production(s)
		// SymbolsExported -> SymbolList

		//

		public void change(SymbolList p_SymbolList)
		{
			_init ();
			this.kind = (uint) production_kind.g_SymbolsExported_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SymbolList = p_SymbolList;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SymbolsExported -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_SymbolsExported_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SymbolsExported
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SymbolList != null) && m_SymbolList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SymbolsExported

		//
		// emit production tree node associated with any production of syntax rule SymbolsExported
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SymbolsExported_1:
					// emit syntax tree node associated with production
					// SymbolsExported: SymbolList

					s += m_SymbolList.Emit (depth - 1);
				break;
				case production_kind.g_SymbolsExported_2:
					// emit syntax tree node associated with production
					// SymbolsExported: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SymbolsExported
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SymbolsExported (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SymbolsExported_1:
					// emit syntax tree node associated with production
					// SymbolsExported: SymbolList

					s += m_SymbolList.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_SymbolsExported_2:
					// emit syntax tree node associated with production
					// SymbolsExported: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SymbolsExported

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SymbolsExported with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SymbolsExported.production_kind kind = (SymbolsExported.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SymbolsExported.production_kind.g_SymbolsExported_1:
					// traverse syntax tree node associated with production
					// SymbolsExported: SymbolList

						m_SymbolList.Visit (visitor, appData);
				break;
				case SymbolsExported.production_kind.g_SymbolsExported_2:
					// traverse syntax tree node associated with production
					// SymbolsExported: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SymbolList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SymbolsExported
		//

		public void _init ()
		{
			m_SymbolList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SymbolsExported

		// counter of all nodes associated with syntax rule SymbolsExported
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SymbolsExported
		[DataMember (Name = "m_SymbolList")] public SymbolList m_SymbolList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SymbolsExported

		// delegate function (callback) prototype associated with syntax rule SymbolsExported
		public delegate bool SymbolsExported_Callback (SyntaxTreeCallbackReason reason, SymbolsExported.production_kind kind, SymbolsExported p_SymbolsExported);

		// event associated with syntax rule SymbolsExported
		public event SymbolsExported_Callback SymbolsExported_Event;

		// event trigger associated with syntax rule SymbolsExported
		public bool Raise_SymbolsExported_Event (SyntaxTreeCallbackReason reason, SymbolsExported.production_kind kind, SymbolsExported p_SymbolsExported)
		{
			bool? status = SymbolsExported_Event?.Invoke (reason, kind, p_SymbolsExported);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SymbolsExported
		//
		// traverse syntax tree node associated with any production of syntax rule SymbolsExported
		//

		public void Traverse (SymbolsExported p_SymbolsExported)
		{
			if (p_SymbolsExported.isLocked())
				return;
			p_SymbolsExported.dolock();
			SymbolsExported.production_kind kind = (SymbolsExported.production_kind) p_SymbolsExported.kind;
			p_SymbolsExported.turn_reset ();
			if (Raise_SymbolsExported_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SymbolsExported))
			switch (kind)
			{
				case SymbolsExported.production_kind.g_SymbolsExported_1:
					// traverse syntax tree node associated with production
					// SymbolsExported: SymbolList

					if (Raise_SymbolsExported_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SymbolsExported))
						Traverse (p_SymbolsExported.m_SymbolList);
					p_SymbolsExported.turn_inc ();
					Raise_SymbolsExported_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SymbolsExported);
				break;
				case SymbolsExported.production_kind.g_SymbolsExported_2:
					// traverse syntax tree node associated with production
					// SymbolsExported: %empty

				break;
			}
			Raise_SymbolsExported_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SymbolsExported);
			p_SymbolsExported.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SymbolsExported
		//

		public void TraverseCommon (SymbolsExported p_SymbolsExported)
		{
			SymbolsExported.production_kind kind = (SymbolsExported.production_kind) p_SymbolsExported.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SymbolsExported))
			switch (kind)
			{
				case SymbolsExported.production_kind.g_SymbolsExported_1:
					// traverse syntax tree node associated with production
					// SymbolsExported: SymbolList

						TraverseCommon (p_SymbolsExported.m_SymbolList);
				break;
				case SymbolsExported.production_kind.g_SymbolsExported_2:
					// traverse syntax tree node associated with production
					// SymbolsExported: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SymbolsExported);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SymbolsExported

		//
		// create syntax tree node associated with production
		// SymbolsExported: SymbolList

		//

		public SymbolsExported SymbolsExported_1 (SymbolList p_SymbolList)
		{
			SymbolsExported p_SymbolsExported_ref = new SymbolsExported(p_SymbolList);
			p_SymbolList.parent = p_SymbolsExported_ref;
			Raise_SymbolsExported_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SymbolsExported.production_kind.g_SymbolsExported_1, p_SymbolsExported_ref);
			return p_SymbolsExported_ref;
		}

		//
		// create syntax tree node associated with production
		// SymbolsExported: %empty

		//

		public SymbolsExported SymbolsExported_2 ()
		{
			SymbolsExported p_SymbolsExported_ref = new SymbolsExported();
			Raise_SymbolsExported_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SymbolsExported.production_kind.g_SymbolsExported_2, p_SymbolsExported_ref);
			return p_SymbolsExported_ref;
		}
		#endregion
	};
}
