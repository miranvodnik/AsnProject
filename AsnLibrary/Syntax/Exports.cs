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
	// class associated with syntax rule Exports
	//

	[DataContract]
	public class	Exports : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Exports
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Exports
		{
			g_Exports_1 = 1,	// EXPORTS SymbolsExported ";"

			g_Exports_2 = 2,	// EXPORTS ALL ";"

			g_Exports_3 = 3,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule Exports

		// markers associated with production: Exports -> EXPORTS SymbolsExported ";"

		public enum production_marker_1 : ushort
		{
			m_SymbolsExported,
			final
		};

		// markers associated with production: Exports -> EXPORTS ALL ";"

		public enum production_marker_2 : ushort
		{
			final
		};

		// markers associated with production: Exports -> %empty

		public enum production_marker_3 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Exports

		// Constructor declaration(s) associated with production(s) of syntax rule Exports

		//
		// Constructor associated with the following production(s)
		// Exports -> EXPORTS SymbolsExported ";"

		//

		public Exports (SyntaxTreeToken p_token, SymbolsExported p_SymbolsExported, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._Exports_ID, (uint) production_kind.g_Exports_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_EXPORTS = p_token;
			children[1] = m_SymbolsExported = p_SymbolsExported;
			children[2] = m_semicolon = p_token_1;
		}

		//
		// Constructor associated with the following production(s)
		// Exports -> EXPORTS ALL ";"

		//

		public Exports (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._Exports_ID, (uint) production_kind.g_Exports_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_EXPORTS = p_token;
			children[1] = m_ALL = p_token_1;
			children[2] = m_semicolon = p_token_2;
		}

		//
		// Constructor associated with the following production(s)
		// Exports -> %empty

		//

		public Exports () : base ((uint) ProductionID._Exports_ID, (uint) production_kind.g_Exports_3)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public Exports (Exports p_Exports) : base (p_Exports.id, p_Exports.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Exports.appInfo;
			switch ((production_kind) p_Exports.kind)
			{
				case production_kind.g_Exports_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_EXPORTS = (p_Exports.m_EXPORTS != null) ? new SyntaxTreeToken (p_Exports.m_EXPORTS) : null) != null) m_EXPORTS.parent = this;
					if ((children [1] = m_SymbolsExported = (p_Exports.m_SymbolsExported != null) ? new SymbolsExported (p_Exports.m_SymbolsExported) : null) != null) m_SymbolsExported.parent = this;
					if ((children [2] = m_semicolon = (p_Exports.m_semicolon != null) ? new SyntaxTreeToken (p_Exports.m_semicolon) : null) != null) m_semicolon.parent = this;
					break;
				case production_kind.g_Exports_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_EXPORTS = (p_Exports.m_EXPORTS != null) ? new SyntaxTreeToken (p_Exports.m_EXPORTS) : null) != null) m_EXPORTS.parent = this;
					if ((children [1] = m_ALL = (p_Exports.m_ALL != null) ? new SyntaxTreeToken (p_Exports.m_ALL) : null) != null) m_ALL.parent = this;
					if ((children [2] = m_semicolon = (p_Exports.m_semicolon != null) ? new SyntaxTreeToken (p_Exports.m_semicolon) : null) != null) m_semicolon.parent = this;
					break;
				case production_kind.g_Exports_3:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "Exports" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Exports (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_EXPORTS?.Dispose ();
			m_SymbolsExported?.Dispose ();
			m_semicolon?.Dispose ();
			m_ALL?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Exports

		// Content changing function(s) associated with production(s) of syntax rule Exports

		//
		// Content changing function associated with following production(s)
		// Exports -> EXPORTS SymbolsExported ";"

		//

		public void change(SyntaxTreeToken p_token, SymbolsExported p_SymbolsExported, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_Exports_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_EXPORTS = p_token;
			children [1] = m_SymbolsExported = p_SymbolsExported;
			children [2] = m_semicolon = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Exports -> EXPORTS ALL ";"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_Exports_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_EXPORTS = p_token;
			children [1] = m_ALL = p_token_1;
			children [2] = m_semicolon = p_token_2;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Exports -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_Exports_3;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Exports
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_EXPORTS != null) && m_EXPORTS.checkInclusion (element) ||
				(m_SymbolsExported != null) && m_SymbolsExported.checkInclusion (element) ||
				(m_semicolon != null) && m_semicolon.checkInclusion (element) ||
				(m_ALL != null) && m_ALL.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Exports

		//
		// emit production tree node associated with any production of syntax rule Exports
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Exports_1:
					// emit syntax tree node associated with production
					// Exports: EXPORTS SymbolsExported ";"

					s += m_EXPORTS.Emit (depth - 1);
					s += " ";
					s += m_SymbolsExported.Emit (depth - 1);
					s += " ";
					s += m_semicolon.Emit (depth - 1);
				break;
				case production_kind.g_Exports_2:
					// emit syntax tree node associated with production
					// Exports: EXPORTS ALL ";"

					s += m_EXPORTS.Emit (depth - 1);
					s += " ";
					s += m_ALL.Emit (depth - 1);
					s += " ";
					s += m_semicolon.Emit (depth - 1);
				break;
				case production_kind.g_Exports_3:
					// emit syntax tree node associated with production
					// Exports: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Exports
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Exports (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Exports_1:
					// emit syntax tree node associated with production
					// Exports: EXPORTS SymbolsExported ";"

					s += "EXPORTS";
					s += ' ';
					s += m_SymbolsExported.EmitProductionTree (depth - 1);
					s += ' ';
					s += "semicolon";
				break;
				case production_kind.g_Exports_2:
					// emit syntax tree node associated with production
					// Exports: EXPORTS ALL ";"

					s += "EXPORTS";
					s += ' ';
					s += "ALL";
					s += ' ';
					s += "semicolon";
				break;
				case production_kind.g_Exports_3:
					// emit syntax tree node associated with production
					// Exports: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Exports

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Exports with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Exports.production_kind kind = (Exports.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Exports.production_kind.g_Exports_1:
					// traverse syntax tree node associated with production
					// Exports: EXPORTS SymbolsExported ";"

						m_EXPORTS.Visit (visitor, appData);
						m_SymbolsExported.Visit (visitor, appData);
						m_semicolon.Visit (visitor, appData);
				break;
				case Exports.production_kind.g_Exports_2:
					// traverse syntax tree node associated with production
					// Exports: EXPORTS ALL ";"

						m_EXPORTS.Visit (visitor, appData);
						m_ALL.Visit (visitor, appData);
						m_semicolon.Visit (visitor, appData);
				break;
				case Exports.production_kind.g_Exports_3:
					// traverse syntax tree node associated with production
					// Exports: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_EXPORTS?.reparent (this);
			m_SymbolsExported?.reparent (this);
			m_semicolon?.reparent (this);
			m_ALL?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Exports
		//

		public void _init ()
		{
			m_EXPORTS = null;
			m_SymbolsExported = null;
			m_semicolon = null;
			m_ALL = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Exports

		// counter of all nodes associated with syntax rule Exports
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Exports
		[DataMember (Name = "m_EXPORTS")] public SyntaxTreeToken m_EXPORTS { get; private set; }
		[DataMember (Name = "m_SymbolsExported")] public SymbolsExported m_SymbolsExported { get; private set; }
		[DataMember (Name = "m_semicolon")] public SyntaxTreeToken m_semicolon { get; private set; }
		[DataMember (Name = "m_ALL")] public SyntaxTreeToken m_ALL { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Exports

		// delegate function (callback) prototype associated with syntax rule Exports
		public delegate bool Exports_Callback (SyntaxTreeCallbackReason reason, Exports.production_kind kind, Exports p_Exports);

		// event associated with syntax rule Exports
		public event Exports_Callback Exports_Event;

		// event trigger associated with syntax rule Exports
		public bool Raise_Exports_Event (SyntaxTreeCallbackReason reason, Exports.production_kind kind, Exports p_Exports)
		{
			bool? status = Exports_Event?.Invoke (reason, kind, p_Exports);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Exports
		//
		// traverse syntax tree node associated with any production of syntax rule Exports
		//

		public void Traverse (Exports p_Exports)
		{
			if (p_Exports.isLocked())
				return;
			p_Exports.dolock();
			Exports.production_kind kind = (Exports.production_kind) p_Exports.kind;
			p_Exports.turn_reset ();
			if (Raise_Exports_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Exports))
			switch (kind)
			{
				case Exports.production_kind.g_Exports_1:
					// traverse syntax tree node associated with production
					// Exports: EXPORTS SymbolsExported ";"

					if (Raise_Exports_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Exports))
						Traverse (p_Exports.m_SymbolsExported);
					p_Exports.turn_inc ();
					Raise_Exports_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Exports);
				break;
				case Exports.production_kind.g_Exports_2:
					// traverse syntax tree node associated with production
					// Exports: EXPORTS ALL ";"

				break;
				case Exports.production_kind.g_Exports_3:
					// traverse syntax tree node associated with production
					// Exports: %empty

				break;
			}
			Raise_Exports_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Exports);
			p_Exports.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Exports
		//

		public void TraverseCommon (Exports p_Exports)
		{
			Exports.production_kind kind = (Exports.production_kind) p_Exports.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Exports))
			switch (kind)
			{
				case Exports.production_kind.g_Exports_1:
					// traverse syntax tree node associated with production
					// Exports: EXPORTS SymbolsExported ";"

						TraverseCommon (p_Exports.m_EXPORTS);
						TraverseCommon (p_Exports.m_SymbolsExported);
						TraverseCommon (p_Exports.m_semicolon);
				break;
				case Exports.production_kind.g_Exports_2:
					// traverse syntax tree node associated with production
					// Exports: EXPORTS ALL ";"

						TraverseCommon (p_Exports.m_EXPORTS);
						TraverseCommon (p_Exports.m_ALL);
						TraverseCommon (p_Exports.m_semicolon);
				break;
				case Exports.production_kind.g_Exports_3:
					// traverse syntax tree node associated with production
					// Exports: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Exports);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Exports

		//
		// create syntax tree node associated with production
		// Exports: EXPORTS SymbolsExported ";"

		//

		public Exports Exports_1 (SyntaxTreeToken p_token, SymbolsExported p_SymbolsExported, SyntaxTreeToken p_token_1)
		{
			Exports p_Exports_ref = new Exports(p_token, p_SymbolsExported, p_token_1);
			p_token.parent = p_Exports_ref;
			p_SymbolsExported.parent = p_Exports_ref;
			p_token_1.parent = p_Exports_ref;
			Raise_Exports_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Exports.production_kind.g_Exports_1, p_Exports_ref);
			return p_Exports_ref;
		}

		//
		// create syntax tree node associated with production
		// Exports: EXPORTS ALL ";"

		//

		public Exports Exports_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			Exports p_Exports_ref = new Exports(p_token, p_token_1, p_token_2);
			p_token.parent = p_Exports_ref;
			p_token_1.parent = p_Exports_ref;
			p_token_2.parent = p_Exports_ref;
			Raise_Exports_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Exports.production_kind.g_Exports_2, p_Exports_ref);
			return p_Exports_ref;
		}

		//
		// create syntax tree node associated with production
		// Exports: %empty

		//

		public Exports Exports_3 ()
		{
			Exports p_Exports_ref = new Exports();
			Raise_Exports_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Exports.production_kind.g_Exports_3, p_Exports_ref);
			return p_Exports_ref;
		}
		#endregion
	};
}
