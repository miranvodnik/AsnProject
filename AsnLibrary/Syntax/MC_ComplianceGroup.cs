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
	// class associated with syntax rule MC-ComplianceGroup
	//

	[DataContract]
	public class	MC_ComplianceGroup : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MC-ComplianceGroup
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MC-ComplianceGroup
		{
			g_MC_ComplianceGroup_1 = 1,	// GROUP Value DESCRIPTION cstring

		};
		#endregion
		#region production markers associated with the syntax rule MC-ComplianceGroup

		// markers associated with production: MC-ComplianceGroup -> GROUP Value DESCRIPTION cstring

		public enum production_marker_1 : ushort
		{
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MC-ComplianceGroup

		// Constructor declaration(s) associated with production(s) of syntax rule MC-ComplianceGroup

		//
		// Constructor associated with the following production(s)
		// MC-ComplianceGroup -> GROUP Value DESCRIPTION cstring

		//

		public MC_ComplianceGroup (SyntaxTreeToken p_token, Value p_Value, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._MC_ComplianceGroup_ID, (uint) production_kind.g_MC_ComplianceGroup_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_GROUP = p_token;
			children[1] = m_Value = p_Value;
			children[2] = m_DESCRIPTION = p_token_1;
			children[3] = m_cstring = p_token_2;
		}

		public MC_ComplianceGroup () { }

		// Copy constructor

		public MC_ComplianceGroup (MC_ComplianceGroup p_MC_ComplianceGroup) : base (p_MC_ComplianceGroup.id, p_MC_ComplianceGroup.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MC_ComplianceGroup.appInfo;
			switch ((production_kind) p_MC_ComplianceGroup.kind)
			{
				case production_kind.g_MC_ComplianceGroup_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_GROUP = (p_MC_ComplianceGroup.m_GROUP != null) ? new SyntaxTreeToken (p_MC_ComplianceGroup.m_GROUP) : null) != null) m_GROUP.parent = this;
					if ((children [1] = m_Value = (p_MC_ComplianceGroup.m_Value != null) ? new Value (p_MC_ComplianceGroup.m_Value) : null) != null) m_Value.parent = this;
					if ((children [2] = m_DESCRIPTION = (p_MC_ComplianceGroup.m_DESCRIPTION != null) ? new SyntaxTreeToken (p_MC_ComplianceGroup.m_DESCRIPTION) : null) != null) m_DESCRIPTION.parent = this;
					if ((children [3] = m_cstring = (p_MC_ComplianceGroup.m_cstring != null) ? new SyntaxTreeToken (p_MC_ComplianceGroup.m_cstring) : null) != null) m_cstring.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "MC_ComplianceGroup" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MC_ComplianceGroup (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_GROUP?.Dispose ();
			m_Value?.Dispose ();
			m_DESCRIPTION?.Dispose ();
			m_cstring?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MC-ComplianceGroup

		// Content changing function(s) associated with production(s) of syntax rule MC-ComplianceGroup

		//
		// Content changing function associated with following production(s)
		// MC-ComplianceGroup -> GROUP Value DESCRIPTION cstring

		//

		public void change(SyntaxTreeToken p_token, Value p_Value, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_ComplianceGroup_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_GROUP = p_token;
			children [1] = m_Value = p_Value;
			children [2] = m_DESCRIPTION = p_token_1;
			children [3] = m_cstring = p_token_2;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MC-ComplianceGroup
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_GROUP != null) && m_GROUP.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				(m_DESCRIPTION != null) && m_DESCRIPTION.checkInclusion (element) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MC-ComplianceGroup

		//
		// emit production tree node associated with any production of syntax rule MC-ComplianceGroup
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MC_ComplianceGroup_1:
					// emit syntax tree node associated with production
					// MC-ComplianceGroup: GROUP Value DESCRIPTION cstring

					s += m_GROUP.Emit (depth - 1);
					s += " ";
					s += m_Value.Emit (depth - 1);
					s += " ";
					s += m_DESCRIPTION.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MC-ComplianceGroup
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MC_ComplianceGroup (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MC_ComplianceGroup_1:
					// emit syntax tree node associated with production
					// MC-ComplianceGroup: GROUP Value DESCRIPTION cstring

					s += "GROUP";
					s += ' ';
					s += m_Value.EmitProductionTree (depth - 1);
					s += ' ';
					s += "DESCRIPTION";
					s += ' ';
					s += "cstring";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MC-ComplianceGroup

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MC-ComplianceGroup with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MC_ComplianceGroup.production_kind kind = (MC_ComplianceGroup.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MC_ComplianceGroup.production_kind.g_MC_ComplianceGroup_1:
					// traverse syntax tree node associated with production
					// MC-ComplianceGroup: GROUP Value DESCRIPTION cstring

						m_GROUP.Visit (visitor, appData);
						m_Value.Visit (visitor, appData);
						m_DESCRIPTION.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_GROUP?.reparent (this);
			m_Value?.reparent (this);
			m_DESCRIPTION?.reparent (this);
			m_cstring?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MC-ComplianceGroup
		//

		public void _init ()
		{
			m_GROUP = null;
			m_Value = null;
			m_DESCRIPTION = null;
			m_cstring = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MC-ComplianceGroup

		// counter of all nodes associated with syntax rule MC-ComplianceGroup
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MC-ComplianceGroup
		[DataMember (Name = "m_GROUP")] public SyntaxTreeToken m_GROUP { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		[DataMember (Name = "m_DESCRIPTION")] public SyntaxTreeToken m_DESCRIPTION { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MC-ComplianceGroup

		// delegate function (callback) prototype associated with syntax rule MC-ComplianceGroup
		public delegate bool MC_ComplianceGroup_Callback (SyntaxTreeCallbackReason reason, MC_ComplianceGroup.production_kind kind, MC_ComplianceGroup p_MC_ComplianceGroup);

		// event associated with syntax rule MC-ComplianceGroup
		public event MC_ComplianceGroup_Callback MC_ComplianceGroup_Event;

		// event trigger associated with syntax rule MC-ComplianceGroup
		public bool Raise_MC_ComplianceGroup_Event (SyntaxTreeCallbackReason reason, MC_ComplianceGroup.production_kind kind, MC_ComplianceGroup p_MC_ComplianceGroup)
		{
			bool? status = MC_ComplianceGroup_Event?.Invoke (reason, kind, p_MC_ComplianceGroup);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MC-ComplianceGroup
		//
		// traverse syntax tree node associated with any production of syntax rule MC-ComplianceGroup
		//

		public void Traverse (MC_ComplianceGroup p_MC_ComplianceGroup)
		{
			if (p_MC_ComplianceGroup.isLocked())
				return;
			p_MC_ComplianceGroup.dolock();
			MC_ComplianceGroup.production_kind kind = (MC_ComplianceGroup.production_kind) p_MC_ComplianceGroup.kind;
			p_MC_ComplianceGroup.turn_reset ();
			if (Raise_MC_ComplianceGroup_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MC_ComplianceGroup))
			switch (kind)
			{
				case MC_ComplianceGroup.production_kind.g_MC_ComplianceGroup_1:
					// traverse syntax tree node associated with production
					// MC-ComplianceGroup: GROUP Value DESCRIPTION cstring

					if (Raise_MC_ComplianceGroup_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_ComplianceGroup))
						Traverse (p_MC_ComplianceGroup.m_Value);
					p_MC_ComplianceGroup.turn_inc ();
					Raise_MC_ComplianceGroup_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_ComplianceGroup);
				break;
			}
			Raise_MC_ComplianceGroup_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MC_ComplianceGroup);
			p_MC_ComplianceGroup.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MC-ComplianceGroup
		//

		public void TraverseCommon (MC_ComplianceGroup p_MC_ComplianceGroup)
		{
			MC_ComplianceGroup.production_kind kind = (MC_ComplianceGroup.production_kind) p_MC_ComplianceGroup.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MC_ComplianceGroup))
			switch (kind)
			{
				case MC_ComplianceGroup.production_kind.g_MC_ComplianceGroup_1:
					// traverse syntax tree node associated with production
					// MC-ComplianceGroup: GROUP Value DESCRIPTION cstring

						TraverseCommon (p_MC_ComplianceGroup.m_GROUP);
						TraverseCommon (p_MC_ComplianceGroup.m_Value);
						TraverseCommon (p_MC_ComplianceGroup.m_DESCRIPTION);
						TraverseCommon (p_MC_ComplianceGroup.m_cstring);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MC_ComplianceGroup);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MC-ComplianceGroup

		//
		// create syntax tree node associated with production
		// MC-ComplianceGroup: GROUP Value DESCRIPTION cstring

		//

		public MC_ComplianceGroup MC_ComplianceGroup_1 (SyntaxTreeToken p_token, Value p_Value, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			MC_ComplianceGroup p_MC_ComplianceGroup_ref = new MC_ComplianceGroup(p_token, p_Value, p_token_1, p_token_2);
			p_token.parent = p_MC_ComplianceGroup_ref;
			p_Value.parent = p_MC_ComplianceGroup_ref;
			p_token_1.parent = p_MC_ComplianceGroup_ref;
			p_token_2.parent = p_MC_ComplianceGroup_ref;
			Raise_MC_ComplianceGroup_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_ComplianceGroup.production_kind.g_MC_ComplianceGroup_1, p_MC_ComplianceGroup_ref);
			return p_MC_ComplianceGroup_ref;
		}
		#endregion
	};
}
