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
	// class associated with syntax rule Imports
	//

	[DataContract]
	public class	Imports : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Imports
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Imports
		{
			g_Imports_1 = 1,	// IMPORTS SymbolsImported ";"

			g_Imports_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule Imports

		// markers associated with production: Imports -> IMPORTS SymbolsImported ";"

		public enum production_marker_1 : ushort
		{
			m_SymbolsImported,
			final
		};

		// markers associated with production: Imports -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Imports

		// Constructor declaration(s) associated with production(s) of syntax rule Imports

		//
		// Constructor associated with the following production(s)
		// Imports -> IMPORTS SymbolsImported ";"

		//

		public Imports (SyntaxTreeToken p_token, SymbolsImported p_SymbolsImported, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._Imports_ID, (uint) production_kind.g_Imports_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_IMPORTS = p_token;
			children[1] = m_SymbolsImported = p_SymbolsImported;
			children[2] = m_semicolon = p_token_1;
		}

		//
		// Constructor associated with the following production(s)
		// Imports -> %empty

		//

		public Imports () : base ((uint) ProductionID._Imports_ID, (uint) production_kind.g_Imports_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public Imports (Imports p_Imports) : base (p_Imports.id, p_Imports.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Imports.appInfo;
			switch ((production_kind) p_Imports.kind)
			{
				case production_kind.g_Imports_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_IMPORTS = (p_Imports.m_IMPORTS != null) ? new SyntaxTreeToken (p_Imports.m_IMPORTS) : null) != null) m_IMPORTS.parent = this;
					if ((children [1] = m_SymbolsImported = (p_Imports.m_SymbolsImported != null) ? new SymbolsImported (p_Imports.m_SymbolsImported) : null) != null) m_SymbolsImported.parent = this;
					if ((children [2] = m_semicolon = (p_Imports.m_semicolon != null) ? new SyntaxTreeToken (p_Imports.m_semicolon) : null) != null) m_semicolon.parent = this;
					break;
				case production_kind.g_Imports_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "Imports" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Imports (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_IMPORTS?.Dispose ();
			m_SymbolsImported?.Dispose ();
			m_semicolon?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Imports

		// Content changing function(s) associated with production(s) of syntax rule Imports

		//
		// Content changing function associated with following production(s)
		// Imports -> IMPORTS SymbolsImported ";"

		//

		public void change(SyntaxTreeToken p_token, SymbolsImported p_SymbolsImported, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_Imports_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_IMPORTS = p_token;
			children [1] = m_SymbolsImported = p_SymbolsImported;
			children [2] = m_semicolon = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Imports -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_Imports_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Imports
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_IMPORTS != null) && m_IMPORTS.checkInclusion (element) ||
				(m_SymbolsImported != null) && m_SymbolsImported.checkInclusion (element) ||
				(m_semicolon != null) && m_semicolon.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Imports

		//
		// emit production tree node associated with any production of syntax rule Imports
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Imports_1:
					// emit syntax tree node associated with production
					// Imports: IMPORTS SymbolsImported ";"

					s += m_IMPORTS.Emit (depth - 1);
					s += " ";
					s += m_SymbolsImported.Emit (depth - 1);
					s += " ";
					s += m_semicolon.Emit (depth - 1);
				break;
				case production_kind.g_Imports_2:
					// emit syntax tree node associated with production
					// Imports: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Imports
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Imports (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Imports_1:
					// emit syntax tree node associated with production
					// Imports: IMPORTS SymbolsImported ";"

					s += "IMPORTS";
					s += ' ';
					s += m_SymbolsImported.EmitProductionTree (depth - 1);
					s += ' ';
					s += "semicolon";
				break;
				case production_kind.g_Imports_2:
					// emit syntax tree node associated with production
					// Imports: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Imports

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Imports with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Imports.production_kind kind = (Imports.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Imports.production_kind.g_Imports_1:
					// traverse syntax tree node associated with production
					// Imports: IMPORTS SymbolsImported ";"

						m_IMPORTS.Visit (visitor, appData);
						m_SymbolsImported.Visit (visitor, appData);
						m_semicolon.Visit (visitor, appData);
				break;
				case Imports.production_kind.g_Imports_2:
					// traverse syntax tree node associated with production
					// Imports: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_IMPORTS?.reparent (this);
			m_SymbolsImported?.reparent (this);
			m_semicolon?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Imports
		//

		public void _init ()
		{
			m_IMPORTS = null;
			m_SymbolsImported = null;
			m_semicolon = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Imports

		// counter of all nodes associated with syntax rule Imports
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Imports
		[DataMember (Name = "m_IMPORTS")] public SyntaxTreeToken m_IMPORTS { get; private set; }
		[DataMember (Name = "m_SymbolsImported")] public SymbolsImported m_SymbolsImported { get; private set; }
		[DataMember (Name = "m_semicolon")] public SyntaxTreeToken m_semicolon { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Imports

		// delegate function (callback) prototype associated with syntax rule Imports
		public delegate bool Imports_Callback (SyntaxTreeCallbackReason reason, Imports.production_kind kind, Imports p_Imports);

		// event associated with syntax rule Imports
		public event Imports_Callback Imports_Event;

		// event trigger associated with syntax rule Imports
		public bool Raise_Imports_Event (SyntaxTreeCallbackReason reason, Imports.production_kind kind, Imports p_Imports)
		{
			bool? status = Imports_Event?.Invoke (reason, kind, p_Imports);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Imports
		//
		// traverse syntax tree node associated with any production of syntax rule Imports
		//

		public void Traverse (Imports p_Imports)
		{
			if (p_Imports.isLocked())
				return;
			p_Imports.dolock();
			Imports.production_kind kind = (Imports.production_kind) p_Imports.kind;
			p_Imports.turn_reset ();
			if (Raise_Imports_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Imports))
			switch (kind)
			{
				case Imports.production_kind.g_Imports_1:
					// traverse syntax tree node associated with production
					// Imports: IMPORTS SymbolsImported ";"

					if (Raise_Imports_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Imports))
						Traverse (p_Imports.m_SymbolsImported);
					p_Imports.turn_inc ();
					Raise_Imports_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Imports);
				break;
				case Imports.production_kind.g_Imports_2:
					// traverse syntax tree node associated with production
					// Imports: %empty

				break;
			}
			Raise_Imports_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Imports);
			p_Imports.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Imports
		//

		public void TraverseCommon (Imports p_Imports)
		{
			Imports.production_kind kind = (Imports.production_kind) p_Imports.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Imports))
			switch (kind)
			{
				case Imports.production_kind.g_Imports_1:
					// traverse syntax tree node associated with production
					// Imports: IMPORTS SymbolsImported ";"

						TraverseCommon (p_Imports.m_IMPORTS);
						TraverseCommon (p_Imports.m_SymbolsImported);
						TraverseCommon (p_Imports.m_semicolon);
				break;
				case Imports.production_kind.g_Imports_2:
					// traverse syntax tree node associated with production
					// Imports: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Imports);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Imports

		//
		// create syntax tree node associated with production
		// Imports: IMPORTS SymbolsImported ";"

		//

		public Imports Imports_1 (SyntaxTreeToken p_token, SymbolsImported p_SymbolsImported, SyntaxTreeToken p_token_1)
		{
			Imports p_Imports_ref = new Imports(p_token, p_SymbolsImported, p_token_1);
			p_token.parent = p_Imports_ref;
			p_SymbolsImported.parent = p_Imports_ref;
			p_token_1.parent = p_Imports_ref;
			Raise_Imports_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Imports.production_kind.g_Imports_1, p_Imports_ref);
			return p_Imports_ref;
		}

		//
		// create syntax tree node associated with production
		// Imports: %empty

		//

		public Imports Imports_2 ()
		{
			Imports p_Imports_ref = new Imports();
			Raise_Imports_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Imports.production_kind.g_Imports_2, p_Imports_ref);
			return p_Imports_ref;
		}
		#endregion
	};
}
