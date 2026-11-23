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
	// class associated with syntax rule SymbolsImported
	//

	[DataContract]
	public class	SymbolsImported : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SymbolsImported
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SymbolsImported
		{
			g_SymbolsImported_1 = 1,	// SymbolsFromModuleList

			g_SymbolsImported_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule SymbolsImported

		// markers associated with production: SymbolsImported -> SymbolsFromModuleList

		public enum production_marker_1 : ushort
		{
			m_SymbolsFromModuleList,
			final
		};

		// markers associated with production: SymbolsImported -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SymbolsImported

		// Constructor declaration(s) associated with production(s) of syntax rule SymbolsImported

		//
		// Constructor associated with the following production(s)
		// SymbolsImported -> SymbolsFromModuleList

		//

		public SymbolsImported (SymbolsFromModuleList p_SymbolsFromModuleList) : base ((uint) ProductionID._SymbolsImported_ID, (uint) production_kind.g_SymbolsImported_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SymbolsFromModuleList = p_SymbolsFromModuleList;
		}

		//
		// Constructor associated with the following production(s)
		// SymbolsImported -> %empty

		//

		public SymbolsImported () : base ((uint) ProductionID._SymbolsImported_ID, (uint) production_kind.g_SymbolsImported_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public SymbolsImported (SymbolsImported p_SymbolsImported) : base (p_SymbolsImported.id, p_SymbolsImported.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SymbolsImported.appInfo;
			switch ((production_kind) p_SymbolsImported.kind)
			{
				case production_kind.g_SymbolsImported_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SymbolsFromModuleList = (p_SymbolsImported.m_SymbolsFromModuleList != null) ? new SymbolsFromModuleList (p_SymbolsImported.m_SymbolsFromModuleList) : null) != null) m_SymbolsFromModuleList.parent = this;
					break;
				case production_kind.g_SymbolsImported_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "SymbolsImported" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SymbolsImported (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SymbolsFromModuleList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SymbolsImported

		// Content changing function(s) associated with production(s) of syntax rule SymbolsImported

		//
		// Content changing function associated with following production(s)
		// SymbolsImported -> SymbolsFromModuleList

		//

		public void change(SymbolsFromModuleList p_SymbolsFromModuleList)
		{
			_init ();
			this.kind = (uint) production_kind.g_SymbolsImported_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SymbolsFromModuleList = p_SymbolsFromModuleList;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SymbolsImported -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_SymbolsImported_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SymbolsImported
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SymbolsFromModuleList != null) && m_SymbolsFromModuleList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SymbolsImported

		//
		// emit production tree node associated with any production of syntax rule SymbolsImported
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SymbolsImported_1:
					// emit syntax tree node associated with production
					// SymbolsImported: SymbolsFromModuleList

					s += m_SymbolsFromModuleList.Emit (depth - 1);
				break;
				case production_kind.g_SymbolsImported_2:
					// emit syntax tree node associated with production
					// SymbolsImported: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SymbolsImported
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SymbolsImported (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SymbolsImported_1:
					// emit syntax tree node associated with production
					// SymbolsImported: SymbolsFromModuleList

					s += m_SymbolsFromModuleList.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_SymbolsImported_2:
					// emit syntax tree node associated with production
					// SymbolsImported: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SymbolsImported

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SymbolsImported with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SymbolsImported.production_kind kind = (SymbolsImported.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SymbolsImported.production_kind.g_SymbolsImported_1:
					// traverse syntax tree node associated with production
					// SymbolsImported: SymbolsFromModuleList

						m_SymbolsFromModuleList.Visit (visitor, appData);
				break;
				case SymbolsImported.production_kind.g_SymbolsImported_2:
					// traverse syntax tree node associated with production
					// SymbolsImported: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SymbolsFromModuleList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SymbolsImported
		//

		public void _init ()
		{
			m_SymbolsFromModuleList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SymbolsImported

		// counter of all nodes associated with syntax rule SymbolsImported
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SymbolsImported
		[DataMember (Name = "m_SymbolsFromModuleList")] public SymbolsFromModuleList m_SymbolsFromModuleList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SymbolsImported

		// delegate function (callback) prototype associated with syntax rule SymbolsImported
		public delegate bool SymbolsImported_Callback (SyntaxTreeCallbackReason reason, SymbolsImported.production_kind kind, SymbolsImported p_SymbolsImported);

		// event associated with syntax rule SymbolsImported
		public event SymbolsImported_Callback SymbolsImported_Event;

		// event trigger associated with syntax rule SymbolsImported
		public bool Raise_SymbolsImported_Event (SyntaxTreeCallbackReason reason, SymbolsImported.production_kind kind, SymbolsImported p_SymbolsImported)
		{
			bool? status = SymbolsImported_Event?.Invoke (reason, kind, p_SymbolsImported);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SymbolsImported
		//
		// traverse syntax tree node associated with any production of syntax rule SymbolsImported
		//

		public void Traverse (SymbolsImported p_SymbolsImported)
		{
			if (p_SymbolsImported.isLocked())
				return;
			p_SymbolsImported.dolock();
			SymbolsImported.production_kind kind = (SymbolsImported.production_kind) p_SymbolsImported.kind;
			p_SymbolsImported.turn_reset ();
			if (Raise_SymbolsImported_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SymbolsImported))
			switch (kind)
			{
				case SymbolsImported.production_kind.g_SymbolsImported_1:
					// traverse syntax tree node associated with production
					// SymbolsImported: SymbolsFromModuleList

					if (Raise_SymbolsImported_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SymbolsImported))
						Traverse (p_SymbolsImported.m_SymbolsFromModuleList);
					p_SymbolsImported.turn_inc ();
					Raise_SymbolsImported_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SymbolsImported);
				break;
				case SymbolsImported.production_kind.g_SymbolsImported_2:
					// traverse syntax tree node associated with production
					// SymbolsImported: %empty

				break;
			}
			Raise_SymbolsImported_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SymbolsImported);
			p_SymbolsImported.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SymbolsImported
		//

		public void TraverseCommon (SymbolsImported p_SymbolsImported)
		{
			SymbolsImported.production_kind kind = (SymbolsImported.production_kind) p_SymbolsImported.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SymbolsImported))
			switch (kind)
			{
				case SymbolsImported.production_kind.g_SymbolsImported_1:
					// traverse syntax tree node associated with production
					// SymbolsImported: SymbolsFromModuleList

						TraverseCommon (p_SymbolsImported.m_SymbolsFromModuleList);
				break;
				case SymbolsImported.production_kind.g_SymbolsImported_2:
					// traverse syntax tree node associated with production
					// SymbolsImported: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SymbolsImported);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SymbolsImported

		//
		// create syntax tree node associated with production
		// SymbolsImported: SymbolsFromModuleList

		//

		public SymbolsImported SymbolsImported_1 (SymbolsFromModuleList p_SymbolsFromModuleList)
		{
			SymbolsImported p_SymbolsImported_ref = new SymbolsImported(p_SymbolsFromModuleList);
			p_SymbolsFromModuleList.parent = p_SymbolsImported_ref;
			Raise_SymbolsImported_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SymbolsImported.production_kind.g_SymbolsImported_1, p_SymbolsImported_ref);
			return p_SymbolsImported_ref;
		}

		//
		// create syntax tree node associated with production
		// SymbolsImported: %empty

		//

		public SymbolsImported SymbolsImported_2 ()
		{
			SymbolsImported p_SymbolsImported_ref = new SymbolsImported();
			Raise_SymbolsImported_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SymbolsImported.production_kind.g_SymbolsImported_2, p_SymbolsImported_ref);
			return p_SymbolsImported_ref;
		}
		#endregion
	};
}
