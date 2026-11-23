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
	// class associated with syntax rule Group
	//

	[DataContract]
	public class	Group : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Group
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Group
		{
			g_Group_1 = 1,	// number

		};
		#endregion
		#region production markers associated with the syntax rule Group

		// markers associated with production: Group -> number

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Group

		// Constructor declaration(s) associated with production(s) of syntax rule Group

		//
		// Constructor associated with the following production(s)
		// Group -> number

		//

		public Group (SyntaxTreeToken p_token) : base ((uint) ProductionID._Group_ID, (uint) production_kind.g_Group_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_number = p_token;
		}

		public Group () { }

		// Copy constructor

		public Group (Group p_Group) : base (p_Group.id, p_Group.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Group.appInfo;
			switch ((production_kind) p_Group.kind)
			{
				case production_kind.g_Group_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_number = (p_Group.m_number != null) ? new SyntaxTreeToken (p_Group.m_number) : null) != null) m_number.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Group" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Group (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_number?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Group

		// Content changing function(s) associated with production(s) of syntax rule Group

		//
		// Content changing function associated with following production(s)
		// Group -> number

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_Group_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_number = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Group
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_number != null) && m_number.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Group

		//
		// emit production tree node associated with any production of syntax rule Group
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Group_1:
					// emit syntax tree node associated with production
					// Group: number

					s += m_number.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Group
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Group (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Group_1:
					// emit syntax tree node associated with production
					// Group: number

					s += "number";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Group

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Group with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Group.production_kind kind = (Group.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Group.production_kind.g_Group_1:
					// traverse syntax tree node associated with production
					// Group: number

						m_number.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_number?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Group
		//

		public void _init ()
		{
			m_number = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Group

		// counter of all nodes associated with syntax rule Group
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Group
		[DataMember (Name = "m_number")] public SyntaxTreeToken m_number { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Group

		// delegate function (callback) prototype associated with syntax rule Group
		public delegate bool Group_Callback (SyntaxTreeCallbackReason reason, Group.production_kind kind, Group p_Group);

		// event associated with syntax rule Group
		public event Group_Callback Group_Event;

		// event trigger associated with syntax rule Group
		public bool Raise_Group_Event (SyntaxTreeCallbackReason reason, Group.production_kind kind, Group p_Group)
		{
			bool? status = Group_Event?.Invoke (reason, kind, p_Group);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Group
		//
		// traverse syntax tree node associated with any production of syntax rule Group
		//

		public void Traverse (Group p_Group)
		{
			if (p_Group.isLocked())
				return;
			p_Group.dolock();
			Group.production_kind kind = (Group.production_kind) p_Group.kind;
			p_Group.turn_reset ();
			if (Raise_Group_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Group))
			switch (kind)
			{
				case Group.production_kind.g_Group_1:
					// traverse syntax tree node associated with production
					// Group: number

				break;
			}
			Raise_Group_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Group);
			p_Group.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Group
		//

		public void TraverseCommon (Group p_Group)
		{
			Group.production_kind kind = (Group.production_kind) p_Group.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Group))
			switch (kind)
			{
				case Group.production_kind.g_Group_1:
					// traverse syntax tree node associated with production
					// Group: number

						TraverseCommon (p_Group.m_number);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Group);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Group

		//
		// create syntax tree node associated with production
		// Group: number

		//

		public Group Group_1 (SyntaxTreeToken p_token)
		{
			Group p_Group_ref = new Group(p_token);
			p_token.parent = p_Group_ref;
			Raise_Group_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Group.production_kind.g_Group_1, p_Group_ref);
			return p_Group_ref;
		}
		#endregion
	};
}
