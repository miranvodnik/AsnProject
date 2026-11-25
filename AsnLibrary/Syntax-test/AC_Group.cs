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
	// class associated with syntax rule AC-Group
	//

	[DataContract]
	public class	AC_Group : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-Group
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-Group
		{
			g_AC_Group_1 = 1,	// Value

		};
		#endregion
		#region production markers associated with the syntax rule AC-Group

		// markers associated with production: AC-Group -> Value

		public enum production_marker_1 : ushort
		{
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-Group

		// Constructor declaration(s) associated with production(s) of syntax rule AC-Group

		//
		// Constructor associated with the following production(s)
		// AC-Group -> Value

		//

		public AC_Group (Value p_Value) : base ((uint) ProductionID._AC_Group_ID, (uint) production_kind.g_AC_Group_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Value = p_Value;
		}

		public AC_Group () { }

		// Copy constructor

		public AC_Group (AC_Group p_AC_Group) : base (p_AC_Group.id, p_AC_Group.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_Group.appInfo;
			switch ((production_kind) p_AC_Group.kind)
			{
				case production_kind.g_AC_Group_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Value = (p_AC_Group.m_Value != null) ? new Value (p_AC_Group.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AC_Group" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_Group (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-Group

		// Content changing function(s) associated with production(s) of syntax rule AC-Group

		//
		// Content changing function associated with following production(s)
		// AC-Group -> Value

		//

		public void change(Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_Group_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-Group
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-Group

		//
		// emit production tree node associated with any production of syntax rule AC-Group
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_Group_1:
					// emit syntax tree node associated with production
					// AC-Group: Value

					s += m_Value.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-Group
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_Group (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_Group_1:
					// emit syntax tree node associated with production
					// AC-Group: Value

					s += m_Value.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-Group

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Group with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_Group.production_kind kind = (AC_Group.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_Group.production_kind.g_AC_Group_1:
					// traverse syntax tree node associated with production
					// AC-Group: Value

						m_Value.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Value?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AC-Group
		//

		public void _init ()
		{
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-Group

		// counter of all nodes associated with syntax rule AC-Group
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-Group
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-Group

		// delegate function (callback) prototype associated with syntax rule AC-Group
		public delegate bool AC_Group_Callback (SyntaxTreeCallbackReason reason, AC_Group.production_kind kind, AC_Group p_AC_Group);

		// event associated with syntax rule AC-Group
		public event AC_Group_Callback AC_Group_Event;

		// event trigger associated with syntax rule AC-Group
		public bool Raise_AC_Group_Event (SyntaxTreeCallbackReason reason, AC_Group.production_kind kind, AC_Group p_AC_Group)
		{
			bool? status = AC_Group_Event?.Invoke (reason, kind, p_AC_Group);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-Group
		//
		// traverse syntax tree node associated with any production of syntax rule AC-Group
		//

		public void Traverse (AC_Group p_AC_Group)
		{
			if (p_AC_Group.isLocked())
				return;
			p_AC_Group.dolock();
			AC_Group.production_kind kind = (AC_Group.production_kind) p_AC_Group.kind;
			p_AC_Group.turn_reset ();
			if (Raise_AC_Group_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_Group))
			switch (kind)
			{
				case AC_Group.production_kind.g_AC_Group_1:
					// traverse syntax tree node associated with production
					// AC-Group: Value

					if (Raise_AC_Group_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Group))
						Traverse (p_AC_Group.m_Value);
					p_AC_Group.turn_inc ();
					Raise_AC_Group_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Group);
				break;
			}
			Raise_AC_Group_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_Group);
			p_AC_Group.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Group
		//

		public void TraverseCommon (AC_Group p_AC_Group)
		{
			AC_Group.production_kind kind = (AC_Group.production_kind) p_AC_Group.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_Group))
			switch (kind)
			{
				case AC_Group.production_kind.g_AC_Group_1:
					// traverse syntax tree node associated with production
					// AC-Group: Value

						TraverseCommon (p_AC_Group.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_Group);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-Group

		//
		// create syntax tree node associated with production
		// AC-Group: Value

		//

		public AC_Group AC_Group_1 (Value p_Value)
		{
			AC_Group p_AC_Group_ref = new AC_Group(p_Value);
			p_Value.parent = p_AC_Group_ref;
			Raise_AC_Group_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_Group.production_kind.g_AC_Group_1, p_AC_Group_ref);
			return p_AC_Group_ref;
		}
		#endregion
	};
}
