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
	// class associated with syntax rule DefinitiveOID
	//

	[DataContract]
	public class	DefinitiveOID : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DefinitiveOID
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DefinitiveOID
		{
			g_DefinitiveOID_1 = 1,	// "{" DefinitiveObjIdComponentList "}"

		};
		#endregion
		#region production markers associated with the syntax rule DefinitiveOID

		// markers associated with production: DefinitiveOID -> "{" DefinitiveObjIdComponentList "}"

		public enum production_marker_1 : ushort
		{
			m_DefinitiveObjIdComponentList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DefinitiveOID

		// Constructor declaration(s) associated with production(s) of syntax rule DefinitiveOID

		//
		// Constructor associated with the following production(s)
		// DefinitiveOID -> "{" DefinitiveObjIdComponentList "}"

		//

		public DefinitiveOID (SyntaxTreeToken p_token, DefinitiveObjIdComponentList p_DefinitiveObjIdComponentList, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._DefinitiveOID_ID, (uint) production_kind.g_DefinitiveOID_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_DefinitiveObjIdComponentList = p_DefinitiveObjIdComponentList;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		public DefinitiveOID () { }

		// Copy constructor

		public DefinitiveOID (DefinitiveOID p_DefinitiveOID) : base (p_DefinitiveOID.id, p_DefinitiveOID.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DefinitiveOID.appInfo;
			switch ((production_kind) p_DefinitiveOID.kind)
			{
				case production_kind.g_DefinitiveOID_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_DefinitiveOID.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_DefinitiveOID.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_DefinitiveObjIdComponentList = (p_DefinitiveOID.m_DefinitiveObjIdComponentList != null) ? new DefinitiveObjIdComponentList (p_DefinitiveOID.m_DefinitiveObjIdComponentList) : null) != null) m_DefinitiveObjIdComponentList.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_DefinitiveOID.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_DefinitiveOID.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DefinitiveOID" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DefinitiveOID (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_curly_bracket?.Dispose ();
			m_DefinitiveObjIdComponentList?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DefinitiveOID

		// Content changing function(s) associated with production(s) of syntax rule DefinitiveOID

		//
		// Content changing function associated with following production(s)
		// DefinitiveOID -> "{" DefinitiveObjIdComponentList "}"

		//

		public void change(SyntaxTreeToken p_token, DefinitiveObjIdComponentList p_DefinitiveObjIdComponentList, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinitiveOID_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_DefinitiveObjIdComponentList = p_DefinitiveObjIdComponentList;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DefinitiveOID
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_DefinitiveObjIdComponentList != null) && m_DefinitiveObjIdComponentList.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DefinitiveOID

		//
		// emit production tree node associated with any production of syntax rule DefinitiveOID
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DefinitiveOID_1:
					// emit syntax tree node associated with production
					// DefinitiveOID: "{" DefinitiveObjIdComponentList "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_DefinitiveObjIdComponentList.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DefinitiveOID
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DefinitiveOID (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DefinitiveOID_1:
					// emit syntax tree node associated with production
					// DefinitiveOID: "{" DefinitiveObjIdComponentList "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_DefinitiveObjIdComponentList.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DefinitiveOID

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveOID with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DefinitiveOID.production_kind kind = (DefinitiveOID.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DefinitiveOID.production_kind.g_DefinitiveOID_1:
					// traverse syntax tree node associated with production
					// DefinitiveOID: "{" DefinitiveObjIdComponentList "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_DefinitiveObjIdComponentList.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_left_curly_bracket?.reparent (this);
			m_DefinitiveObjIdComponentList?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule DefinitiveOID
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_DefinitiveObjIdComponentList = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DefinitiveOID

		// counter of all nodes associated with syntax rule DefinitiveOID
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DefinitiveOID
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_DefinitiveObjIdComponentList")] public DefinitiveObjIdComponentList m_DefinitiveObjIdComponentList { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DefinitiveOID

		// delegate function (callback) prototype associated with syntax rule DefinitiveOID
		public delegate bool DefinitiveOID_Callback (SyntaxTreeCallbackReason reason, DefinitiveOID.production_kind kind, DefinitiveOID p_DefinitiveOID);

		// event associated with syntax rule DefinitiveOID
		public event DefinitiveOID_Callback DefinitiveOID_Event;

		// event trigger associated with syntax rule DefinitiveOID
		public bool Raise_DefinitiveOID_Event (SyntaxTreeCallbackReason reason, DefinitiveOID.production_kind kind, DefinitiveOID p_DefinitiveOID)
		{
			bool? status = DefinitiveOID_Event?.Invoke (reason, kind, p_DefinitiveOID);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DefinitiveOID
		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveOID
		//

		public void Traverse (DefinitiveOID p_DefinitiveOID)
		{
			if (p_DefinitiveOID.isLocked())
				return;
			p_DefinitiveOID.dolock();
			DefinitiveOID.production_kind kind = (DefinitiveOID.production_kind) p_DefinitiveOID.kind;
			p_DefinitiveOID.turn_reset ();
			if (Raise_DefinitiveOID_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DefinitiveOID))
			switch (kind)
			{
				case DefinitiveOID.production_kind.g_DefinitiveOID_1:
					// traverse syntax tree node associated with production
					// DefinitiveOID: "{" DefinitiveObjIdComponentList "}"

					if (Raise_DefinitiveOID_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinitiveOID))
						Traverse (p_DefinitiveOID.m_DefinitiveObjIdComponentList);
					p_DefinitiveOID.turn_inc ();
					Raise_DefinitiveOID_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinitiveOID);
				break;
			}
			Raise_DefinitiveOID_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DefinitiveOID);
			p_DefinitiveOID.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveOID
		//

		public void TraverseCommon (DefinitiveOID p_DefinitiveOID)
		{
			DefinitiveOID.production_kind kind = (DefinitiveOID.production_kind) p_DefinitiveOID.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DefinitiveOID))
			switch (kind)
			{
				case DefinitiveOID.production_kind.g_DefinitiveOID_1:
					// traverse syntax tree node associated with production
					// DefinitiveOID: "{" DefinitiveObjIdComponentList "}"

						TraverseCommon (p_DefinitiveOID.m_left_curly_bracket);
						TraverseCommon (p_DefinitiveOID.m_DefinitiveObjIdComponentList);
						TraverseCommon (p_DefinitiveOID.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DefinitiveOID);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DefinitiveOID

		//
		// create syntax tree node associated with production
		// DefinitiveOID: "{" DefinitiveObjIdComponentList "}"

		//

		public DefinitiveOID DefinitiveOID_1 (SyntaxTreeToken p_token, DefinitiveObjIdComponentList p_DefinitiveObjIdComponentList, SyntaxTreeToken p_token_1)
		{
			DefinitiveOID p_DefinitiveOID_ref = new DefinitiveOID(p_token, p_DefinitiveObjIdComponentList, p_token_1);
			p_token.parent = p_DefinitiveOID_ref;
			p_DefinitiveObjIdComponentList.parent = p_DefinitiveOID_ref;
			p_token_1.parent = p_DefinitiveOID_ref;
			Raise_DefinitiveOID_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinitiveOID.production_kind.g_DefinitiveOID_1, p_DefinitiveOID_ref);
			return p_DefinitiveOID_ref;
		}
		#endregion
	};
}
