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
	// class associated with syntax rule AC-Module
	//

	[DataContract]
	public class	AC_Module : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-Module
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-Module
		{
			g_AC_Module_1 = 1,	// SUPPORTS AC-ModuleName INCLUDES "{" AC-Groups "}" AC-VariationPart

		};
		#endregion
		#region production markers associated with the syntax rule AC-Module

		// markers associated with production: AC-Module -> SUPPORTS AC-ModuleName INCLUDES "{" AC-Groups "}" AC-VariationPart

		public enum production_marker_1 : ushort
		{
			m_AC_ModuleName,
			m_AC_Groups,
			m_AC_VariationPart,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-Module

		// Constructor declaration(s) associated with production(s) of syntax rule AC-Module

		//
		// Constructor associated with the following production(s)
		// AC-Module -> SUPPORTS AC-ModuleName INCLUDES "{" AC-Groups "}" AC-VariationPart

		//

		public AC_Module (SyntaxTreeToken p_token, AC_ModuleName p_AC_ModuleName, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, AC_Groups p_AC_Groups, SyntaxTreeToken p_token_3, AC_VariationPart p_AC_VariationPart) : base ((uint) ProductionID._AC_Module_ID, (uint) production_kind.g_AC_Module_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children[0] = m_SUPPORTS = p_token;
			children[1] = m_AC_ModuleName = p_AC_ModuleName;
			children[2] = m_INCLUDES = p_token_1;
			children[3] = m_left_curly_bracket = p_token_2;
			children[4] = m_AC_Groups = p_AC_Groups;
			children[5] = m_right_curly_bracket = p_token_3;
			children[6] = m_AC_VariationPart = p_AC_VariationPart;
		}

		public AC_Module () { }

		// Copy constructor

		public AC_Module (AC_Module p_AC_Module) : base (p_AC_Module.id, p_AC_Module.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_Module.appInfo;
			switch ((production_kind) p_AC_Module.kind)
			{
				case production_kind.g_AC_Module_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
					if ((children [0] = m_SUPPORTS = (p_AC_Module.m_SUPPORTS != null) ? new SyntaxTreeToken (p_AC_Module.m_SUPPORTS) : null) != null) m_SUPPORTS.parent = this;
					if ((children [1] = m_AC_ModuleName = (p_AC_Module.m_AC_ModuleName != null) ? new AC_ModuleName (p_AC_Module.m_AC_ModuleName) : null) != null) m_AC_ModuleName.parent = this;
					if ((children [2] = m_INCLUDES = (p_AC_Module.m_INCLUDES != null) ? new SyntaxTreeToken (p_AC_Module.m_INCLUDES) : null) != null) m_INCLUDES.parent = this;
					if ((children [3] = m_left_curly_bracket = (p_AC_Module.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_AC_Module.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [4] = m_AC_Groups = (p_AC_Module.m_AC_Groups != null) ? new AC_Groups (p_AC_Module.m_AC_Groups) : null) != null) m_AC_Groups.parent = this;
					if ((children [5] = m_right_curly_bracket = (p_AC_Module.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_AC_Module.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					if ((children [6] = m_AC_VariationPart = (p_AC_Module.m_AC_VariationPart != null) ? new AC_VariationPart (p_AC_Module.m_AC_VariationPart) : null) != null) m_AC_VariationPart.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AC_Module" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_Module (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SUPPORTS?.Dispose ();
			m_AC_ModuleName?.Dispose ();
			m_INCLUDES?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_AC_Groups?.Dispose ();
			m_right_curly_bracket?.Dispose ();
			m_AC_VariationPart?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-Module

		// Content changing function(s) associated with production(s) of syntax rule AC-Module

		//
		// Content changing function associated with following production(s)
		// AC-Module -> SUPPORTS AC-ModuleName INCLUDES "{" AC-Groups "}" AC-VariationPart

		//

		public void change(SyntaxTreeToken p_token, AC_ModuleName p_AC_ModuleName, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, AC_Groups p_AC_Groups, SyntaxTreeToken p_token_3, AC_VariationPart p_AC_VariationPart)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_Module_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children [0] = m_SUPPORTS = p_token;
			children [1] = m_AC_ModuleName = p_AC_ModuleName;
			children [2] = m_INCLUDES = p_token_1;
			children [3] = m_left_curly_bracket = p_token_2;
			children [4] = m_AC_Groups = p_AC_Groups;
			children [5] = m_right_curly_bracket = p_token_3;
			children [6] = m_AC_VariationPart = p_AC_VariationPart;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-Module
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SUPPORTS != null) && m_SUPPORTS.checkInclusion (element) ||
				(m_AC_ModuleName != null) && m_AC_ModuleName.checkInclusion (element) ||
				(m_INCLUDES != null) && m_INCLUDES.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_AC_Groups != null) && m_AC_Groups.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				(m_AC_VariationPart != null) && m_AC_VariationPart.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-Module

		//
		// emit production tree node associated with any production of syntax rule AC-Module
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_Module_1:
					// emit syntax tree node associated with production
					// AC-Module: SUPPORTS AC-ModuleName INCLUDES "{" AC-Groups "}" AC-VariationPart

					s += m_SUPPORTS.Emit (depth - 1);
					s += " ";
					s += m_AC_ModuleName.Emit (depth - 1);
					s += " ";
					s += m_INCLUDES.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_AC_Groups.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_AC_VariationPart.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-Module
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_Module (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_Module_1:
					// emit syntax tree node associated with production
					// AC-Module: SUPPORTS AC-ModuleName INCLUDES "{" AC-Groups "}" AC-VariationPart

					s += "SUPPORTS";
					s += ' ';
					s += m_AC_ModuleName.EmitProductionTree (depth - 1);
					s += ' ';
					s += "INCLUDES";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_AC_Groups.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
					s += ' ';
					s += m_AC_VariationPart.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-Module

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Module with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_Module.production_kind kind = (AC_Module.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_Module.production_kind.g_AC_Module_1:
					// traverse syntax tree node associated with production
					// AC-Module: SUPPORTS AC-ModuleName INCLUDES "{" AC-Groups "}" AC-VariationPart

						m_SUPPORTS.Visit (visitor, appData);
						m_AC_ModuleName.Visit (visitor, appData);
						m_INCLUDES.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_AC_Groups.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
						m_AC_VariationPart.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SUPPORTS?.reparent (this);
			m_AC_ModuleName?.reparent (this);
			m_INCLUDES?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_AC_Groups?.reparent (this);
			m_right_curly_bracket?.reparent (this);
			m_AC_VariationPart?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AC-Module
		//

		public void _init ()
		{
			m_SUPPORTS = null;
			m_AC_ModuleName = null;
			m_INCLUDES = null;
			m_left_curly_bracket = null;
			m_AC_Groups = null;
			m_right_curly_bracket = null;
			m_AC_VariationPart = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-Module

		// counter of all nodes associated with syntax rule AC-Module
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-Module
		[DataMember (Name = "m_SUPPORTS")] public SyntaxTreeToken m_SUPPORTS { get; private set; }
		[DataMember (Name = "m_AC_ModuleName")] public AC_ModuleName m_AC_ModuleName { get; private set; }
		[DataMember (Name = "m_INCLUDES")] public SyntaxTreeToken m_INCLUDES { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_AC_Groups")] public AC_Groups m_AC_Groups { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		[DataMember (Name = "m_AC_VariationPart")] public AC_VariationPart m_AC_VariationPart { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-Module

		// delegate function (callback) prototype associated with syntax rule AC-Module
		public delegate bool AC_Module_Callback (SyntaxTreeCallbackReason reason, AC_Module.production_kind kind, AC_Module p_AC_Module);

		// event associated with syntax rule AC-Module
		public event AC_Module_Callback AC_Module_Event;

		// event trigger associated with syntax rule AC-Module
		public bool Raise_AC_Module_Event (SyntaxTreeCallbackReason reason, AC_Module.production_kind kind, AC_Module p_AC_Module)
		{
			bool? status = AC_Module_Event?.Invoke (reason, kind, p_AC_Module);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-Module
		//
		// traverse syntax tree node associated with any production of syntax rule AC-Module
		//

		public void Traverse (AC_Module p_AC_Module)
		{
			if (p_AC_Module.isLocked())
				return;
			p_AC_Module.dolock();
			AC_Module.production_kind kind = (AC_Module.production_kind) p_AC_Module.kind;
			p_AC_Module.turn_reset ();
			if (Raise_AC_Module_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_Module))
			switch (kind)
			{
				case AC_Module.production_kind.g_AC_Module_1:
					// traverse syntax tree node associated with production
					// AC-Module: SUPPORTS AC-ModuleName INCLUDES "{" AC-Groups "}" AC-VariationPart

					if (Raise_AC_Module_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Module))
						Traverse (p_AC_Module.m_AC_ModuleName);
					p_AC_Module.turn_inc ();
					if (Raise_AC_Module_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Module))
						Traverse (p_AC_Module.m_AC_Groups);
					p_AC_Module.turn_inc ();
					if (Raise_AC_Module_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Module))
						Traverse (p_AC_Module.m_AC_VariationPart);
					p_AC_Module.turn_inc ();
					Raise_AC_Module_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Module);
				break;
			}
			Raise_AC_Module_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_Module);
			p_AC_Module.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Module
		//

		public void TraverseCommon (AC_Module p_AC_Module)
		{
			AC_Module.production_kind kind = (AC_Module.production_kind) p_AC_Module.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_Module))
			switch (kind)
			{
				case AC_Module.production_kind.g_AC_Module_1:
					// traverse syntax tree node associated with production
					// AC-Module: SUPPORTS AC-ModuleName INCLUDES "{" AC-Groups "}" AC-VariationPart

						TraverseCommon (p_AC_Module.m_SUPPORTS);
						TraverseCommon (p_AC_Module.m_AC_ModuleName);
						TraverseCommon (p_AC_Module.m_INCLUDES);
						TraverseCommon (p_AC_Module.m_left_curly_bracket);
						TraverseCommon (p_AC_Module.m_AC_Groups);
						TraverseCommon (p_AC_Module.m_right_curly_bracket);
						TraverseCommon (p_AC_Module.m_AC_VariationPart);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_Module);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-Module

		//
		// create syntax tree node associated with production
		// AC-Module: SUPPORTS AC-ModuleName INCLUDES "{" AC-Groups "}" AC-VariationPart

		//

		public AC_Module AC_Module_1 (SyntaxTreeToken p_token, AC_ModuleName p_AC_ModuleName, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, AC_Groups p_AC_Groups, SyntaxTreeToken p_token_3, AC_VariationPart p_AC_VariationPart)
		{
			AC_Module p_AC_Module_ref = new AC_Module(p_token, p_AC_ModuleName, p_token_1, p_token_2, p_AC_Groups, p_token_3, p_AC_VariationPart);
			p_token.parent = p_AC_Module_ref;
			p_AC_ModuleName.parent = p_AC_Module_ref;
			p_token_1.parent = p_AC_Module_ref;
			p_token_2.parent = p_AC_Module_ref;
			p_AC_Groups.parent = p_AC_Module_ref;
			p_token_3.parent = p_AC_Module_ref;
			p_AC_VariationPart.parent = p_AC_Module_ref;
			Raise_AC_Module_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_Module.production_kind.g_AC_Module_1, p_AC_Module_ref);
			return p_AC_Module_ref;
		}
		#endregion
	};
}
