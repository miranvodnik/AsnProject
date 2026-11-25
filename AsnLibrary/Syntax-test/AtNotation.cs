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
	// class associated with syntax rule AtNotation
	//

	[DataContract]
	public class	AtNotation : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AtNotation
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AtNotation
		{
			g_AtNotation_1 = 1,	// "@" ComponentIdList

			g_AtNotation_2 = 2,	// "@" Level ComponentIdList

		};
		#endregion
		#region production markers associated with the syntax rule AtNotation

		// markers associated with production: AtNotation -> "@" ComponentIdList

		public enum production_marker_1 : ushort
		{
			m_ComponentIdList,
			final
		};

		// markers associated with production: AtNotation -> "@" Level ComponentIdList

		public enum production_marker_2 : ushort
		{
			m_Level,
			m_ComponentIdList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AtNotation

		// Constructor declaration(s) associated with production(s) of syntax rule AtNotation

		//
		// Constructor associated with the following production(s)
		// AtNotation -> "@" ComponentIdList

		//

		public AtNotation (SyntaxTreeToken p_token, ComponentIdList p_ComponentIdList) : base ((uint) ProductionID._AtNotation_ID, (uint) production_kind.g_AtNotation_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_at_sign = p_token;
			children[1] = m_ComponentIdList = p_ComponentIdList;
		}

		//
		// Constructor associated with the following production(s)
		// AtNotation -> "@" Level ComponentIdList

		//

		public AtNotation (SyntaxTreeToken p_token, Level p_Level, ComponentIdList p_ComponentIdList) : base ((uint) ProductionID._AtNotation_ID, (uint) production_kind.g_AtNotation_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_at_sign = p_token;
			children[1] = m_Level = p_Level;
			children[2] = m_ComponentIdList = p_ComponentIdList;
		}

		public AtNotation () { }

		// Copy constructor

		public AtNotation (AtNotation p_AtNotation) : base (p_AtNotation.id, p_AtNotation.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AtNotation.appInfo;
			switch ((production_kind) p_AtNotation.kind)
			{
				case production_kind.g_AtNotation_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_at_sign = (p_AtNotation.m_at_sign != null) ? new SyntaxTreeToken (p_AtNotation.m_at_sign) : null) != null) m_at_sign.parent = this;
					if ((children [1] = m_ComponentIdList = (p_AtNotation.m_ComponentIdList != null) ? new ComponentIdList (p_AtNotation.m_ComponentIdList) : null) != null) m_ComponentIdList.parent = this;
					break;
				case production_kind.g_AtNotation_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_at_sign = (p_AtNotation.m_at_sign != null) ? new SyntaxTreeToken (p_AtNotation.m_at_sign) : null) != null) m_at_sign.parent = this;
					if ((children [1] = m_Level = (p_AtNotation.m_Level != null) ? new Level (p_AtNotation.m_Level) : null) != null) m_Level.parent = this;
					if ((children [2] = m_ComponentIdList = (p_AtNotation.m_ComponentIdList != null) ? new ComponentIdList (p_AtNotation.m_ComponentIdList) : null) != null) m_ComponentIdList.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AtNotation" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AtNotation (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_at_sign?.Dispose ();
			m_ComponentIdList?.Dispose ();
			m_Level?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AtNotation

		// Content changing function(s) associated with production(s) of syntax rule AtNotation

		//
		// Content changing function associated with following production(s)
		// AtNotation -> "@" ComponentIdList

		//

		public void change(SyntaxTreeToken p_token, ComponentIdList p_ComponentIdList)
		{
			_init ();
			this.kind = (uint) production_kind.g_AtNotation_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_at_sign = p_token;
			children [1] = m_ComponentIdList = p_ComponentIdList;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AtNotation -> "@" Level ComponentIdList

		//

		public void change(SyntaxTreeToken p_token, Level p_Level, ComponentIdList p_ComponentIdList)
		{
			_init ();
			this.kind = (uint) production_kind.g_AtNotation_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_at_sign = p_token;
			children [1] = m_Level = p_Level;
			children [2] = m_ComponentIdList = p_ComponentIdList;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AtNotation
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_at_sign != null) && m_at_sign.checkInclusion (element) ||
				(m_ComponentIdList != null) && m_ComponentIdList.checkInclusion (element) ||
				(m_Level != null) && m_Level.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AtNotation

		//
		// emit production tree node associated with any production of syntax rule AtNotation
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AtNotation_1:
					// emit syntax tree node associated with production
					// AtNotation: "@" ComponentIdList

					s += m_at_sign.Emit (depth - 1);
					s += " ";
					s += m_ComponentIdList.Emit (depth - 1);
				break;
				case production_kind.g_AtNotation_2:
					// emit syntax tree node associated with production
					// AtNotation: "@" Level ComponentIdList

					s += m_at_sign.Emit (depth - 1);
					s += " ";
					s += m_Level.Emit (depth - 1);
					s += " ";
					s += m_ComponentIdList.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AtNotation
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AtNotation (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AtNotation_1:
					// emit syntax tree node associated with production
					// AtNotation: "@" ComponentIdList

					s += "at_sign";
					s += ' ';
					s += m_ComponentIdList.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_AtNotation_2:
					// emit syntax tree node associated with production
					// AtNotation: "@" Level ComponentIdList

					s += "at_sign";
					s += ' ';
					s += m_Level.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ComponentIdList.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AtNotation

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AtNotation with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AtNotation.production_kind kind = (AtNotation.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AtNotation.production_kind.g_AtNotation_1:
					// traverse syntax tree node associated with production
					// AtNotation: "@" ComponentIdList

						m_at_sign.Visit (visitor, appData);
						m_ComponentIdList.Visit (visitor, appData);
				break;
				case AtNotation.production_kind.g_AtNotation_2:
					// traverse syntax tree node associated with production
					// AtNotation: "@" Level ComponentIdList

						m_at_sign.Visit (visitor, appData);
						m_Level.Visit (visitor, appData);
						m_ComponentIdList.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_at_sign?.reparent (this);
			m_ComponentIdList?.reparent (this);
			m_Level?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AtNotation
		//

		public void _init ()
		{
			m_at_sign = null;
			m_ComponentIdList = null;
			m_Level = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AtNotation

		// counter of all nodes associated with syntax rule AtNotation
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AtNotation
		[DataMember (Name = "m_at_sign")] public SyntaxTreeToken m_at_sign { get; private set; }
		[DataMember (Name = "m_ComponentIdList")] public ComponentIdList m_ComponentIdList { get; private set; }
		[DataMember (Name = "m_Level")] public Level m_Level { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AtNotation

		// delegate function (callback) prototype associated with syntax rule AtNotation
		public delegate bool AtNotation_Callback (SyntaxTreeCallbackReason reason, AtNotation.production_kind kind, AtNotation p_AtNotation);

		// event associated with syntax rule AtNotation
		public event AtNotation_Callback AtNotation_Event;

		// event trigger associated with syntax rule AtNotation
		public bool Raise_AtNotation_Event (SyntaxTreeCallbackReason reason, AtNotation.production_kind kind, AtNotation p_AtNotation)
		{
			bool? status = AtNotation_Event?.Invoke (reason, kind, p_AtNotation);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AtNotation
		//
		// traverse syntax tree node associated with any production of syntax rule AtNotation
		//

		public void Traverse (AtNotation p_AtNotation)
		{
			if (p_AtNotation.isLocked())
				return;
			p_AtNotation.dolock();
			AtNotation.production_kind kind = (AtNotation.production_kind) p_AtNotation.kind;
			p_AtNotation.turn_reset ();
			if (Raise_AtNotation_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AtNotation))
			switch (kind)
			{
				case AtNotation.production_kind.g_AtNotation_1:
					// traverse syntax tree node associated with production
					// AtNotation: "@" ComponentIdList

					if (Raise_AtNotation_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AtNotation))
						Traverse (p_AtNotation.m_ComponentIdList);
					p_AtNotation.turn_inc ();
					Raise_AtNotation_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AtNotation);
				break;
				case AtNotation.production_kind.g_AtNotation_2:
					// traverse syntax tree node associated with production
					// AtNotation: "@" Level ComponentIdList

					if (Raise_AtNotation_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AtNotation))
						Traverse (p_AtNotation.m_Level);
					p_AtNotation.turn_inc ();
					if (Raise_AtNotation_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AtNotation))
						Traverse (p_AtNotation.m_ComponentIdList);
					p_AtNotation.turn_inc ();
					Raise_AtNotation_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AtNotation);
				break;
			}
			Raise_AtNotation_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AtNotation);
			p_AtNotation.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AtNotation
		//

		public void TraverseCommon (AtNotation p_AtNotation)
		{
			AtNotation.production_kind kind = (AtNotation.production_kind) p_AtNotation.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AtNotation))
			switch (kind)
			{
				case AtNotation.production_kind.g_AtNotation_1:
					// traverse syntax tree node associated with production
					// AtNotation: "@" ComponentIdList

						TraverseCommon (p_AtNotation.m_at_sign);
						TraverseCommon (p_AtNotation.m_ComponentIdList);
				break;
				case AtNotation.production_kind.g_AtNotation_2:
					// traverse syntax tree node associated with production
					// AtNotation: "@" Level ComponentIdList

						TraverseCommon (p_AtNotation.m_at_sign);
						TraverseCommon (p_AtNotation.m_Level);
						TraverseCommon (p_AtNotation.m_ComponentIdList);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AtNotation);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AtNotation

		//
		// create syntax tree node associated with production
		// AtNotation: "@" ComponentIdList

		//

		public AtNotation AtNotation_1 (SyntaxTreeToken p_token, ComponentIdList p_ComponentIdList)
		{
			AtNotation p_AtNotation_ref = new AtNotation(p_token, p_ComponentIdList);
			p_token.parent = p_AtNotation_ref;
			p_ComponentIdList.parent = p_AtNotation_ref;
			Raise_AtNotation_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AtNotation.production_kind.g_AtNotation_1, p_AtNotation_ref);
			return p_AtNotation_ref;
		}

		//
		// create syntax tree node associated with production
		// AtNotation: "@" Level ComponentIdList

		//

		public AtNotation AtNotation_2 (SyntaxTreeToken p_token, Level p_Level, ComponentIdList p_ComponentIdList)
		{
			AtNotation p_AtNotation_ref = new AtNotation(p_token, p_Level, p_ComponentIdList);
			p_token.parent = p_AtNotation_ref;
			p_Level.parent = p_AtNotation_ref;
			p_ComponentIdList.parent = p_AtNotation_ref;
			Raise_AtNotation_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AtNotation.production_kind.g_AtNotation_2, p_AtNotation_ref);
			return p_AtNotation_ref;
		}
		#endregion
	};
}
