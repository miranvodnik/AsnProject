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
	// class associated with syntax rule Symbol
	//

	[DataContract]
	public class	Symbol : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Symbol
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Symbol
		{
			g_Symbol_1 = 1,	// Reference

			g_Symbol_2 = 2,	// ParameterizedReference

			g_Symbol_3 = 3,	// MacroName

		};
		#endregion
		#region production markers associated with the syntax rule Symbol

		// markers associated with production: Symbol -> Reference

		public enum production_marker_1 : ushort
		{
			m_Reference,
			final
		};

		// markers associated with production: Symbol -> ParameterizedReference

		public enum production_marker_2 : ushort
		{
			m_ParameterizedReference,
			final
		};

		// markers associated with production: Symbol -> MacroName

		public enum production_marker_3 : ushort
		{
			m_MacroName,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Symbol

		// Constructor declaration(s) associated with production(s) of syntax rule Symbol

		//
		// Constructor associated with the following production(s)
		// Symbol -> Reference

		//

		public Symbol (Reference p_Reference) : base ((uint) ProductionID._Symbol_ID, (uint) production_kind.g_Symbol_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Reference = p_Reference;
		}

		//
		// Constructor associated with the following production(s)
		// Symbol -> ParameterizedReference

		//

		public Symbol (ParameterizedReference p_ParameterizedReference) : base ((uint) ProductionID._Symbol_ID, (uint) production_kind.g_Symbol_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ParameterizedReference = p_ParameterizedReference;
		}

		//
		// Constructor associated with the following production(s)
		// Symbol -> MacroName

		//

		public Symbol (MacroName p_MacroName) : base ((uint) ProductionID._Symbol_ID, (uint) production_kind.g_Symbol_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_MacroName = p_MacroName;
		}

		public Symbol () { }

		// Copy constructor

		public Symbol (Symbol p_Symbol) : base (p_Symbol.id, p_Symbol.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Symbol.appInfo;
			switch ((production_kind) p_Symbol.kind)
			{
				case production_kind.g_Symbol_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Reference = (p_Symbol.m_Reference != null) ? new Reference (p_Symbol.m_Reference) : null) != null) m_Reference.parent = this;
					break;
				case production_kind.g_Symbol_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ParameterizedReference = (p_Symbol.m_ParameterizedReference != null) ? new ParameterizedReference (p_Symbol.m_ParameterizedReference) : null) != null) m_ParameterizedReference.parent = this;
					break;
				case production_kind.g_Symbol_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MacroName = (p_Symbol.m_MacroName != null) ? new MacroName (p_Symbol.m_MacroName) : null) != null) m_MacroName.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Symbol" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Symbol (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Reference?.Dispose ();
			m_ParameterizedReference?.Dispose ();
			m_MacroName?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Symbol

		// Content changing function(s) associated with production(s) of syntax rule Symbol

		//
		// Content changing function associated with following production(s)
		// Symbol -> Reference

		//

		public void change(Reference p_Reference)
		{
			_init ();
			this.kind = (uint) production_kind.g_Symbol_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Reference = p_Reference;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Symbol -> ParameterizedReference

		//

		public void change(ParameterizedReference p_ParameterizedReference)
		{
			_init ();
			this.kind = (uint) production_kind.g_Symbol_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ParameterizedReference = p_ParameterizedReference;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Symbol -> MacroName

		//

		public void change(MacroName p_MacroName)
		{
			_init ();
			this.kind = (uint) production_kind.g_Symbol_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_MacroName = p_MacroName;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Symbol
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Reference != null) && m_Reference.checkInclusion (element) ||
				(m_ParameterizedReference != null) && m_ParameterizedReference.checkInclusion (element) ||
				(m_MacroName != null) && m_MacroName.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Symbol

		//
		// emit production tree node associated with any production of syntax rule Symbol
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Symbol_1:
					// emit syntax tree node associated with production
					// Symbol: Reference

					s += m_Reference.Emit (depth - 1);
				break;
				case production_kind.g_Symbol_2:
					// emit syntax tree node associated with production
					// Symbol: ParameterizedReference

					s += m_ParameterizedReference.Emit (depth - 1);
				break;
				case production_kind.g_Symbol_3:
					// emit syntax tree node associated with production
					// Symbol: MacroName

					s += m_MacroName.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Symbol
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Symbol (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Symbol_1:
					// emit syntax tree node associated with production
					// Symbol: Reference

					s += m_Reference.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Symbol_2:
					// emit syntax tree node associated with production
					// Symbol: ParameterizedReference

					s += m_ParameterizedReference.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Symbol_3:
					// emit syntax tree node associated with production
					// Symbol: MacroName

					s += m_MacroName.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Symbol

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Symbol with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Symbol.production_kind kind = (Symbol.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Symbol.production_kind.g_Symbol_1:
					// traverse syntax tree node associated with production
					// Symbol: Reference

						m_Reference.Visit (visitor, appData);
				break;
				case Symbol.production_kind.g_Symbol_2:
					// traverse syntax tree node associated with production
					// Symbol: ParameterizedReference

						m_ParameterizedReference.Visit (visitor, appData);
				break;
				case Symbol.production_kind.g_Symbol_3:
					// traverse syntax tree node associated with production
					// Symbol: MacroName

						m_MacroName.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Reference?.reparent (this);
			m_ParameterizedReference?.reparent (this);
			m_MacroName?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Symbol
		//

		public void _init ()
		{
			m_Reference = null;
			m_ParameterizedReference = null;
			m_MacroName = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Symbol

		// counter of all nodes associated with syntax rule Symbol
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Symbol
		[DataMember (Name = "m_Reference")] public Reference m_Reference { get; private set; }
		[DataMember (Name = "m_ParameterizedReference")] public ParameterizedReference m_ParameterizedReference { get; private set; }
		[DataMember (Name = "m_MacroName")] public MacroName m_MacroName { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Symbol

		// delegate function (callback) prototype associated with syntax rule Symbol
		public delegate bool Symbol_Callback (SyntaxTreeCallbackReason reason, Symbol.production_kind kind, Symbol p_Symbol);

		// event associated with syntax rule Symbol
		public event Symbol_Callback Symbol_Event;

		// event trigger associated with syntax rule Symbol
		public bool Raise_Symbol_Event (SyntaxTreeCallbackReason reason, Symbol.production_kind kind, Symbol p_Symbol)
		{
			bool? status = Symbol_Event?.Invoke (reason, kind, p_Symbol);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Symbol
		//
		// traverse syntax tree node associated with any production of syntax rule Symbol
		//

		public void Traverse (Symbol p_Symbol)
		{
			if (p_Symbol.isLocked())
				return;
			p_Symbol.dolock();
			Symbol.production_kind kind = (Symbol.production_kind) p_Symbol.kind;
			p_Symbol.turn_reset ();
			if (Raise_Symbol_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Symbol))
			switch (kind)
			{
				case Symbol.production_kind.g_Symbol_1:
					// traverse syntax tree node associated with production
					// Symbol: Reference

					if (Raise_Symbol_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Symbol))
						Traverse (p_Symbol.m_Reference);
					p_Symbol.turn_inc ();
					Raise_Symbol_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Symbol);
				break;
				case Symbol.production_kind.g_Symbol_2:
					// traverse syntax tree node associated with production
					// Symbol: ParameterizedReference

					if (Raise_Symbol_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Symbol))
						Traverse (p_Symbol.m_ParameterizedReference);
					p_Symbol.turn_inc ();
					Raise_Symbol_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Symbol);
				break;
				case Symbol.production_kind.g_Symbol_3:
					// traverse syntax tree node associated with production
					// Symbol: MacroName

					if (Raise_Symbol_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Symbol))
						Traverse (p_Symbol.m_MacroName);
					p_Symbol.turn_inc ();
					Raise_Symbol_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Symbol);
				break;
			}
			Raise_Symbol_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Symbol);
			p_Symbol.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Symbol
		//

		public void TraverseCommon (Symbol p_Symbol)
		{
			Symbol.production_kind kind = (Symbol.production_kind) p_Symbol.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Symbol))
			switch (kind)
			{
				case Symbol.production_kind.g_Symbol_1:
					// traverse syntax tree node associated with production
					// Symbol: Reference

						TraverseCommon (p_Symbol.m_Reference);
				break;
				case Symbol.production_kind.g_Symbol_2:
					// traverse syntax tree node associated with production
					// Symbol: ParameterizedReference

						TraverseCommon (p_Symbol.m_ParameterizedReference);
				break;
				case Symbol.production_kind.g_Symbol_3:
					// traverse syntax tree node associated with production
					// Symbol: MacroName

						TraverseCommon (p_Symbol.m_MacroName);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Symbol);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Symbol

		//
		// create syntax tree node associated with production
		// Symbol: Reference

		//

		public Symbol Symbol_1 (Reference p_Reference)
		{
			Symbol p_Symbol_ref = new Symbol(p_Reference);
			p_Reference.parent = p_Symbol_ref;
			Raise_Symbol_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Symbol.production_kind.g_Symbol_1, p_Symbol_ref);
			return p_Symbol_ref;
		}

		//
		// create syntax tree node associated with production
		// Symbol: ParameterizedReference

		//

		public Symbol Symbol_2 (ParameterizedReference p_ParameterizedReference)
		{
			Symbol p_Symbol_ref = new Symbol(p_ParameterizedReference);
			p_ParameterizedReference.parent = p_Symbol_ref;
			Raise_Symbol_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Symbol.production_kind.g_Symbol_2, p_Symbol_ref);
			return p_Symbol_ref;
		}

		//
		// create syntax tree node associated with production
		// Symbol: MacroName

		//

		public Symbol Symbol_3 (MacroName p_MacroName)
		{
			Symbol p_Symbol_ref = new Symbol(p_MacroName);
			p_MacroName.parent = p_Symbol_ref;
			Raise_Symbol_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Symbol.production_kind.g_Symbol_3, p_Symbol_ref);
			return p_Symbol_ref;
		}
		#endregion
	};
}
