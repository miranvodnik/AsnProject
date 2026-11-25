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
	// class associated with syntax rule ExtensionAdditionGroup
	//

	[DataContract]
	public class	ExtensionAdditionGroup : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExtensionAdditionGroup
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExtensionAdditionGroup
		{
			g_ExtensionAdditionGroup_1 = 1,	// "[" "[" VersionNumber ComponentTypeList "]" "]"

		};
		#endregion
		#region production markers associated with the syntax rule ExtensionAdditionGroup

		// markers associated with production: ExtensionAdditionGroup -> "[" "[" VersionNumber ComponentTypeList "]" "]"

		public enum production_marker_1 : ushort
		{
			m_VersionNumber,
			m_ComponentTypeList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExtensionAdditionGroup

		// Constructor declaration(s) associated with production(s) of syntax rule ExtensionAdditionGroup

		//
		// Constructor associated with the following production(s)
		// ExtensionAdditionGroup -> "[" "[" VersionNumber ComponentTypeList "]" "]"

		//

		public ExtensionAdditionGroup (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, VersionNumber p_VersionNumber, ComponentTypeList p_ComponentTypeList, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3) : base ((uint) ProductionID._ExtensionAdditionGroup_ID, (uint) production_kind.g_ExtensionAdditionGroup_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 6);
			children[0] = m_left_square_bracket = p_token;
			children[1] = m_left_square_bracket_1 = p_token_1;
			children[2] = m_VersionNumber = p_VersionNumber;
			children[3] = m_ComponentTypeList = p_ComponentTypeList;
			children[4] = m_right_square_bracket = p_token_2;
			children[5] = m_right_square_bracket_1 = p_token_3;
		}

		public ExtensionAdditionGroup () { }

		// Copy constructor

		public ExtensionAdditionGroup (ExtensionAdditionGroup p_ExtensionAdditionGroup) : base (p_ExtensionAdditionGroup.id, p_ExtensionAdditionGroup.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExtensionAdditionGroup.appInfo;
			switch ((production_kind) p_ExtensionAdditionGroup.kind)
			{
				case production_kind.g_ExtensionAdditionGroup_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 6);
					if ((children [0] = m_left_square_bracket = (p_ExtensionAdditionGroup.m_left_square_bracket != null) ? new SyntaxTreeToken (p_ExtensionAdditionGroup.m_left_square_bracket) : null) != null) m_left_square_bracket.parent = this;
					if ((children [1] = m_left_square_bracket_1 = (p_ExtensionAdditionGroup.m_left_square_bracket_1 != null) ? new SyntaxTreeToken (p_ExtensionAdditionGroup.m_left_square_bracket_1) : null) != null) m_left_square_bracket_1.parent = this;
					if ((children [2] = m_VersionNumber = (p_ExtensionAdditionGroup.m_VersionNumber != null) ? new VersionNumber (p_ExtensionAdditionGroup.m_VersionNumber) : null) != null) m_VersionNumber.parent = this;
					if ((children [3] = m_ComponentTypeList = (p_ExtensionAdditionGroup.m_ComponentTypeList != null) ? new ComponentTypeList (p_ExtensionAdditionGroup.m_ComponentTypeList) : null) != null) m_ComponentTypeList.parent = this;
					if ((children [4] = m_right_square_bracket = (p_ExtensionAdditionGroup.m_right_square_bracket != null) ? new SyntaxTreeToken (p_ExtensionAdditionGroup.m_right_square_bracket) : null) != null) m_right_square_bracket.parent = this;
					if ((children [5] = m_right_square_bracket_1 = (p_ExtensionAdditionGroup.m_right_square_bracket_1 != null) ? new SyntaxTreeToken (p_ExtensionAdditionGroup.m_right_square_bracket_1) : null) != null) m_right_square_bracket_1.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ExtensionAdditionGroup" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExtensionAdditionGroup (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_square_bracket?.Dispose ();
			m_left_square_bracket_1?.Dispose ();
			m_VersionNumber?.Dispose ();
			m_ComponentTypeList?.Dispose ();
			m_right_square_bracket?.Dispose ();
			m_right_square_bracket_1?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExtensionAdditionGroup

		// Content changing function(s) associated with production(s) of syntax rule ExtensionAdditionGroup

		//
		// Content changing function associated with following production(s)
		// ExtensionAdditionGroup -> "[" "[" VersionNumber ComponentTypeList "]" "]"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, VersionNumber p_VersionNumber, ComponentTypeList p_ComponentTypeList, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExtensionAdditionGroup_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 6);
			children [0] = m_left_square_bracket = p_token;
			children [1] = m_left_square_bracket_1 = p_token_1;
			children [2] = m_VersionNumber = p_VersionNumber;
			children [3] = m_ComponentTypeList = p_ComponentTypeList;
			children [4] = m_right_square_bracket = p_token_2;
			children [5] = m_right_square_bracket_1 = p_token_3;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExtensionAdditionGroup
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_square_bracket != null) && m_left_square_bracket.checkInclusion (element) ||
				(m_left_square_bracket_1 != null) && m_left_square_bracket_1.checkInclusion (element) ||
				(m_VersionNumber != null) && m_VersionNumber.checkInclusion (element) ||
				(m_ComponentTypeList != null) && m_ComponentTypeList.checkInclusion (element) ||
				(m_right_square_bracket != null) && m_right_square_bracket.checkInclusion (element) ||
				(m_right_square_bracket_1 != null) && m_right_square_bracket_1.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExtensionAdditionGroup

		//
		// emit production tree node associated with any production of syntax rule ExtensionAdditionGroup
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ExtensionAdditionGroup_1:
					// emit syntax tree node associated with production
					// ExtensionAdditionGroup: "[" "[" VersionNumber ComponentTypeList "]" "]"

					s += m_left_square_bracket.Emit (depth - 1);
					s += " ";
					s += m_left_square_bracket_1.Emit (depth - 1);
					s += " ";
					s += m_VersionNumber.Emit (depth - 1);
					s += " ";
					s += m_ComponentTypeList.Emit (depth - 1);
					s += " ";
					s += m_right_square_bracket.Emit (depth - 1);
					s += " ";
					s += m_right_square_bracket_1.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExtensionAdditionGroup
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ExtensionAdditionGroup (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ExtensionAdditionGroup_1:
					// emit syntax tree node associated with production
					// ExtensionAdditionGroup: "[" "[" VersionNumber ComponentTypeList "]" "]"

					s += "left_square_bracket";
					s += ' ';
					s += "left_square_bracket";
					s += ' ';
					s += m_VersionNumber.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ComponentTypeList.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_square_bracket";
					s += ' ';
					s += "right_square_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExtensionAdditionGroup

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditionGroup with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ExtensionAdditionGroup.production_kind kind = (ExtensionAdditionGroup.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ExtensionAdditionGroup.production_kind.g_ExtensionAdditionGroup_1:
					// traverse syntax tree node associated with production
					// ExtensionAdditionGroup: "[" "[" VersionNumber ComponentTypeList "]" "]"

						m_left_square_bracket.Visit (visitor, appData);
						m_left_square_bracket_1.Visit (visitor, appData);
						m_VersionNumber.Visit (visitor, appData);
						m_ComponentTypeList.Visit (visitor, appData);
						m_right_square_bracket.Visit (visitor, appData);
						m_right_square_bracket_1.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_left_square_bracket?.reparent (this);
			m_left_square_bracket_1?.reparent (this);

			m_VersionNumber?.reparent (this);
			m_ComponentTypeList?.reparent (this);
			m_right_square_bracket?.reparent (this);
			m_right_square_bracket_1?.reparent (this);

		}

		//
		// initialize object associated with syntax rule ExtensionAdditionGroup
		//

		public void _init ()
		{
			m_left_square_bracket = null;
			m_left_square_bracket_1 = null;
			m_VersionNumber = null;
			m_ComponentTypeList = null;
			m_right_square_bracket = null;
			m_right_square_bracket_1 = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExtensionAdditionGroup

		// counter of all nodes associated with syntax rule ExtensionAdditionGroup
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExtensionAdditionGroup
		[DataMember (Name = "m_left_square_bracket")] public SyntaxTreeToken m_left_square_bracket { get; private set; }
		[DataMember (Name = "m_left_square_bracket_1")] public SyntaxTreeToken m_left_square_bracket_1 { get; private set; }
		[DataMember (Name = "m_VersionNumber")] public VersionNumber m_VersionNumber { get; private set; }
		[DataMember (Name = "m_ComponentTypeList")] public ComponentTypeList m_ComponentTypeList { get; private set; }
		[DataMember (Name = "m_right_square_bracket")] public SyntaxTreeToken m_right_square_bracket { get; private set; }
		[DataMember (Name = "m_right_square_bracket_1")] public SyntaxTreeToken m_right_square_bracket_1 { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExtensionAdditionGroup

		// delegate function (callback) prototype associated with syntax rule ExtensionAdditionGroup
		public delegate bool ExtensionAdditionGroup_Callback (SyntaxTreeCallbackReason reason, ExtensionAdditionGroup.production_kind kind, ExtensionAdditionGroup p_ExtensionAdditionGroup);

		// event associated with syntax rule ExtensionAdditionGroup
		public event ExtensionAdditionGroup_Callback ExtensionAdditionGroup_Event;

		// event trigger associated with syntax rule ExtensionAdditionGroup
		public bool Raise_ExtensionAdditionGroup_Event (SyntaxTreeCallbackReason reason, ExtensionAdditionGroup.production_kind kind, ExtensionAdditionGroup p_ExtensionAdditionGroup)
		{
			bool? status = ExtensionAdditionGroup_Event?.Invoke (reason, kind, p_ExtensionAdditionGroup);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExtensionAdditionGroup
		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditionGroup
		//

		public void Traverse (ExtensionAdditionGroup p_ExtensionAdditionGroup)
		{
			if (p_ExtensionAdditionGroup.isLocked())
				return;
			p_ExtensionAdditionGroup.dolock();
			ExtensionAdditionGroup.production_kind kind = (ExtensionAdditionGroup.production_kind) p_ExtensionAdditionGroup.kind;
			p_ExtensionAdditionGroup.turn_reset ();
			if (Raise_ExtensionAdditionGroup_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ExtensionAdditionGroup))
			switch (kind)
			{
				case ExtensionAdditionGroup.production_kind.g_ExtensionAdditionGroup_1:
					// traverse syntax tree node associated with production
					// ExtensionAdditionGroup: "[" "[" VersionNumber ComponentTypeList "]" "]"

					if (Raise_ExtensionAdditionGroup_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAdditionGroup))
						Traverse (p_ExtensionAdditionGroup.m_VersionNumber);
					p_ExtensionAdditionGroup.turn_inc ();
					if (Raise_ExtensionAdditionGroup_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAdditionGroup))
						Traverse (p_ExtensionAdditionGroup.m_ComponentTypeList);
					p_ExtensionAdditionGroup.turn_inc ();
					Raise_ExtensionAdditionGroup_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAdditionGroup);
				break;
			}
			Raise_ExtensionAdditionGroup_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ExtensionAdditionGroup);
			p_ExtensionAdditionGroup.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditionGroup
		//

		public void TraverseCommon (ExtensionAdditionGroup p_ExtensionAdditionGroup)
		{
			ExtensionAdditionGroup.production_kind kind = (ExtensionAdditionGroup.production_kind) p_ExtensionAdditionGroup.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ExtensionAdditionGroup))
			switch (kind)
			{
				case ExtensionAdditionGroup.production_kind.g_ExtensionAdditionGroup_1:
					// traverse syntax tree node associated with production
					// ExtensionAdditionGroup: "[" "[" VersionNumber ComponentTypeList "]" "]"

						TraverseCommon (p_ExtensionAdditionGroup.m_left_square_bracket);
						TraverseCommon (p_ExtensionAdditionGroup.m_left_square_bracket_1);
						TraverseCommon (p_ExtensionAdditionGroup.m_VersionNumber);
						TraverseCommon (p_ExtensionAdditionGroup.m_ComponentTypeList);
						TraverseCommon (p_ExtensionAdditionGroup.m_right_square_bracket);
						TraverseCommon (p_ExtensionAdditionGroup.m_right_square_bracket_1);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ExtensionAdditionGroup);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExtensionAdditionGroup

		//
		// create syntax tree node associated with production
		// ExtensionAdditionGroup: "[" "[" VersionNumber ComponentTypeList "]" "]"

		//

		public ExtensionAdditionGroup ExtensionAdditionGroup_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, VersionNumber p_VersionNumber, ComponentTypeList p_ComponentTypeList, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3)
		{
			ExtensionAdditionGroup p_ExtensionAdditionGroup_ref = new ExtensionAdditionGroup(p_token, p_token_1, p_VersionNumber, p_ComponentTypeList, p_token_2, p_token_3);
			p_token.parent = p_ExtensionAdditionGroup_ref;
			p_token_1.parent = p_ExtensionAdditionGroup_ref;
			p_VersionNumber.parent = p_ExtensionAdditionGroup_ref;
			p_ComponentTypeList.parent = p_ExtensionAdditionGroup_ref;
			p_token_2.parent = p_ExtensionAdditionGroup_ref;
			p_token_3.parent = p_ExtensionAdditionGroup_ref;
			Raise_ExtensionAdditionGroup_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExtensionAdditionGroup.production_kind.g_ExtensionAdditionGroup_1, p_ExtensionAdditionGroup_ref);
			return p_ExtensionAdditionGroup_ref;
		}
		#endregion
	};
}
