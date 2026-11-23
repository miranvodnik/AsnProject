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
	// class associated with syntax rule SymbolsFromModule
	//

	[DataContract]
	public class	SymbolsFromModule : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SymbolsFromModule
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SymbolsFromModule
		{
			g_SymbolsFromModule_1 = 1,	// SymbolList FROM GlobalModuleReference identifier-token-optional SelectionOption

		};
		#endregion
		#region production markers associated with the syntax rule SymbolsFromModule

		// markers associated with production: SymbolsFromModule -> SymbolList FROM GlobalModuleReference identifier-token-optional SelectionOption

		public enum production_marker_1 : ushort
		{
			m_SymbolList,
			m_GlobalModuleReference,
			m_identifier_token_optional,
			m_SelectionOption,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SymbolsFromModule

		// Constructor declaration(s) associated with production(s) of syntax rule SymbolsFromModule

		//
		// Constructor associated with the following production(s)
		// SymbolsFromModule -> SymbolList FROM GlobalModuleReference identifier-token-optional SelectionOption

		//

		public SymbolsFromModule (SymbolList p_SymbolList, SyntaxTreeToken p_token, GlobalModuleReference p_GlobalModuleReference, identifier_token_optional p_identifier_token_optional, SelectionOption p_SelectionOption) : base ((uint) ProductionID._SymbolsFromModule_ID, (uint) production_kind.g_SymbolsFromModule_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children[0] = m_SymbolList = p_SymbolList;
			children[1] = m_FROM = p_token;
			children[2] = m_GlobalModuleReference = p_GlobalModuleReference;
			children[3] = m_identifier_token_optional = p_identifier_token_optional;
			children[4] = m_SelectionOption = p_SelectionOption;
		}

		public SymbolsFromModule () { }

		// Copy constructor

		public SymbolsFromModule (SymbolsFromModule p_SymbolsFromModule) : base (p_SymbolsFromModule.id, p_SymbolsFromModule.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SymbolsFromModule.appInfo;
			switch ((production_kind) p_SymbolsFromModule.kind)
			{
				case production_kind.g_SymbolsFromModule_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_SymbolList = (p_SymbolsFromModule.m_SymbolList != null) ? new SymbolList (p_SymbolsFromModule.m_SymbolList) : null) != null) m_SymbolList.parent = this;
					if ((children [1] = m_FROM = (p_SymbolsFromModule.m_FROM != null) ? new SyntaxTreeToken (p_SymbolsFromModule.m_FROM) : null) != null) m_FROM.parent = this;
					if ((children [2] = m_GlobalModuleReference = (p_SymbolsFromModule.m_GlobalModuleReference != null) ? new GlobalModuleReference (p_SymbolsFromModule.m_GlobalModuleReference) : null) != null) m_GlobalModuleReference.parent = this;
					if ((children [3] = m_identifier_token_optional = (p_SymbolsFromModule.m_identifier_token_optional != null) ? new identifier_token_optional (p_SymbolsFromModule.m_identifier_token_optional) : null) != null) m_identifier_token_optional.parent = this;
					if ((children [4] = m_SelectionOption = (p_SymbolsFromModule.m_SelectionOption != null) ? new SelectionOption (p_SymbolsFromModule.m_SelectionOption) : null) != null) m_SelectionOption.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SymbolsFromModule" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SymbolsFromModule (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SymbolList?.Dispose ();
			m_FROM?.Dispose ();
			m_GlobalModuleReference?.Dispose ();
			m_identifier_token_optional?.Dispose ();
			m_SelectionOption?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SymbolsFromModule

		// Content changing function(s) associated with production(s) of syntax rule SymbolsFromModule

		//
		// Content changing function associated with following production(s)
		// SymbolsFromModule -> SymbolList FROM GlobalModuleReference identifier-token-optional SelectionOption

		//

		public void change(SymbolList p_SymbolList, SyntaxTreeToken p_token, GlobalModuleReference p_GlobalModuleReference, identifier_token_optional p_identifier_token_optional, SelectionOption p_SelectionOption)
		{
			_init ();
			this.kind = (uint) production_kind.g_SymbolsFromModule_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children [0] = m_SymbolList = p_SymbolList;
			children [1] = m_FROM = p_token;
			children [2] = m_GlobalModuleReference = p_GlobalModuleReference;
			children [3] = m_identifier_token_optional = p_identifier_token_optional;
			children [4] = m_SelectionOption = p_SelectionOption;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SymbolsFromModule
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SymbolList != null) && m_SymbolList.checkInclusion (element) ||
				(m_FROM != null) && m_FROM.checkInclusion (element) ||
				(m_GlobalModuleReference != null) && m_GlobalModuleReference.checkInclusion (element) ||
				(m_identifier_token_optional != null) && m_identifier_token_optional.checkInclusion (element) ||
				(m_SelectionOption != null) && m_SelectionOption.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SymbolsFromModule

		//
		// emit production tree node associated with any production of syntax rule SymbolsFromModule
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SymbolsFromModule_1:
					// emit syntax tree node associated with production
					// SymbolsFromModule: SymbolList FROM GlobalModuleReference identifier-token-optional SelectionOption

					s += m_SymbolList.Emit (depth - 1);
					s += " ";
					s += m_FROM.Emit (depth - 1);
					s += " ";
					s += m_GlobalModuleReference.Emit (depth - 1);
					s += " ";
					s += m_identifier_token_optional.Emit (depth - 1);
					s += " ";
					s += m_SelectionOption.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SymbolsFromModule
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SymbolsFromModule (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SymbolsFromModule_1:
					// emit syntax tree node associated with production
					// SymbolsFromModule: SymbolList FROM GlobalModuleReference identifier-token-optional SelectionOption

					s += m_SymbolList.EmitProductionTree (depth - 1);
					s += ' ';
					s += "FROM";
					s += ' ';
					s += m_GlobalModuleReference.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_identifier_token_optional.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_SelectionOption.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SymbolsFromModule

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SymbolsFromModule with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SymbolsFromModule.production_kind kind = (SymbolsFromModule.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SymbolsFromModule.production_kind.g_SymbolsFromModule_1:
					// traverse syntax tree node associated with production
					// SymbolsFromModule: SymbolList FROM GlobalModuleReference identifier-token-optional SelectionOption

						m_SymbolList.Visit (visitor, appData);
						m_FROM.Visit (visitor, appData);
						m_GlobalModuleReference.Visit (visitor, appData);
						m_identifier_token_optional.Visit (visitor, appData);
						m_SelectionOption.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SymbolList?.reparent (this);
			m_FROM?.reparent (this);
			m_GlobalModuleReference?.reparent (this);
			m_identifier_token_optional?.reparent (this);
			m_SelectionOption?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SymbolsFromModule
		//

		public void _init ()
		{
			m_SymbolList = null;
			m_FROM = null;
			m_GlobalModuleReference = null;
			m_identifier_token_optional = null;
			m_SelectionOption = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SymbolsFromModule

		// counter of all nodes associated with syntax rule SymbolsFromModule
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SymbolsFromModule
		[DataMember (Name = "m_SymbolList")] public SymbolList m_SymbolList { get; private set; }
		[DataMember (Name = "m_FROM")] public SyntaxTreeToken m_FROM { get; private set; }
		[DataMember (Name = "m_GlobalModuleReference")] public GlobalModuleReference m_GlobalModuleReference { get; private set; }
		[DataMember (Name = "m_identifier_token_optional")] public identifier_token_optional m_identifier_token_optional { get; private set; }
		[DataMember (Name = "m_SelectionOption")] public SelectionOption m_SelectionOption { get; private set; }

		public enum __p1_markers
		{
			m1 = 1,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SymbolsFromModule

		// delegate function (callback) prototype associated with syntax rule SymbolsFromModule
		public delegate bool SymbolsFromModule_Callback (SyntaxTreeCallbackReason reason, SymbolsFromModule.production_kind kind, SymbolsFromModule p_SymbolsFromModule);

		// event associated with syntax rule SymbolsFromModule
		public event SymbolsFromModule_Callback SymbolsFromModule_Event;

		// event trigger associated with syntax rule SymbolsFromModule
		public bool Raise_SymbolsFromModule_Event (SyntaxTreeCallbackReason reason, SymbolsFromModule.production_kind kind, SymbolsFromModule p_SymbolsFromModule)
		{
			bool? status = SymbolsFromModule_Event?.Invoke (reason, kind, p_SymbolsFromModule);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SymbolsFromModule
		//
		// traverse syntax tree node associated with any production of syntax rule SymbolsFromModule
		//

		public void Traverse (SymbolsFromModule p_SymbolsFromModule)
		{
			if (p_SymbolsFromModule.isLocked())
				return;
			p_SymbolsFromModule.dolock();
			SymbolsFromModule.production_kind kind = (SymbolsFromModule.production_kind) p_SymbolsFromModule.kind;
			p_SymbolsFromModule.turn_reset ();
			if (Raise_SymbolsFromModule_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SymbolsFromModule))
			switch (kind)
			{
				case SymbolsFromModule.production_kind.g_SymbolsFromModule_1:
					// traverse syntax tree node associated with production
					// SymbolsFromModule: SymbolList FROM GlobalModuleReference identifier-token-optional SelectionOption

					if (Raise_SymbolsFromModule_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SymbolsFromModule))
						Traverse (p_SymbolsFromModule.m_SymbolList);
					p_SymbolsFromModule.turn_inc ();
					if (Raise_SymbolsFromModule_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SymbolsFromModule))
						Traverse (p_SymbolsFromModule.m_GlobalModuleReference);
					p_SymbolsFromModule.turn_inc ();
					if (Raise_SymbolsFromModule_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SymbolsFromModule))
						Traverse (p_SymbolsFromModule.m_identifier_token_optional);
					p_SymbolsFromModule.turn_inc ();
					if (Raise_SymbolsFromModule_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SymbolsFromModule))
						Traverse (p_SymbolsFromModule.m_SelectionOption);
					p_SymbolsFromModule.turn_inc ();
					Raise_SymbolsFromModule_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SymbolsFromModule);
				break;
			}
			Raise_SymbolsFromModule_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SymbolsFromModule);
			p_SymbolsFromModule.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SymbolsFromModule
		//

		public void TraverseCommon (SymbolsFromModule p_SymbolsFromModule)
		{
			SymbolsFromModule.production_kind kind = (SymbolsFromModule.production_kind) p_SymbolsFromModule.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SymbolsFromModule))
			switch (kind)
			{
				case SymbolsFromModule.production_kind.g_SymbolsFromModule_1:
					// traverse syntax tree node associated with production
					// SymbolsFromModule: SymbolList FROM GlobalModuleReference identifier-token-optional SelectionOption

						TraverseCommon (p_SymbolsFromModule.m_SymbolList);
						TraverseCommon (p_SymbolsFromModule.m_FROM);
						TraverseCommon (p_SymbolsFromModule.m_GlobalModuleReference);
						TraverseCommon (p_SymbolsFromModule.m_identifier_token_optional);
						TraverseCommon (p_SymbolsFromModule.m_SelectionOption);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SymbolsFromModule);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SymbolsFromModule

		//
		// create syntax tree node associated with production
		// SymbolsFromModule: SymbolList FROM GlobalModuleReference identifier-token-optional SelectionOption

		//

		public SymbolsFromModule SymbolsFromModule_1 (SymbolList p_SymbolList, SyntaxTreeToken p_token, GlobalModuleReference p_GlobalModuleReference, identifier_token_optional p_identifier_token_optional, SelectionOption p_SelectionOption)
		{
			SymbolsFromModule p_SymbolsFromModule_ref = new SymbolsFromModule(p_SymbolList, p_token, p_GlobalModuleReference, p_identifier_token_optional, p_SelectionOption);
			p_SymbolList.parent = p_SymbolsFromModule_ref;
			p_token.parent = p_SymbolsFromModule_ref;
			p_GlobalModuleReference.parent = p_SymbolsFromModule_ref;
			p_identifier_token_optional.parent = p_SymbolsFromModule_ref;
			p_SelectionOption.parent = p_SymbolsFromModule_ref;
			Raise_SymbolsFromModule_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SymbolsFromModule.production_kind.g_SymbolsFromModule_1, p_SymbolsFromModule_ref);
			return p_SymbolsFromModule_ref;
		}
		#endregion
	};
}
