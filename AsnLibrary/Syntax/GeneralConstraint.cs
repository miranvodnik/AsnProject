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
	// class associated with syntax rule GeneralConstraint
	//

	[DataContract]
	public class	GeneralConstraint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule GeneralConstraint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule GeneralConstraint
		{
			g_GeneralConstraint_1 = 1,	// UserDefinedConstraint

			g_GeneralConstraint_2 = 2,	// TableConstraint

			g_GeneralConstraint_3 = 3,	// ContentsConstraint

		};
		#endregion
		#region production markers associated with the syntax rule GeneralConstraint

		// markers associated with production: GeneralConstraint -> UserDefinedConstraint

		public enum production_marker_1 : ushort
		{
			m_UserDefinedConstraint,
			final
		};

		// markers associated with production: GeneralConstraint -> TableConstraint

		public enum production_marker_2 : ushort
		{
			m_TableConstraint,
			final
		};

		// markers associated with production: GeneralConstraint -> ContentsConstraint

		public enum production_marker_3 : ushort
		{
			m_ContentsConstraint,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule GeneralConstraint

		// Constructor declaration(s) associated with production(s) of syntax rule GeneralConstraint

		//
		// Constructor associated with the following production(s)
		// GeneralConstraint -> UserDefinedConstraint

		//

		public GeneralConstraint (UserDefinedConstraint p_UserDefinedConstraint) : base ((uint) ProductionID._GeneralConstraint_ID, (uint) production_kind.g_GeneralConstraint_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_UserDefinedConstraint = p_UserDefinedConstraint;
		}

		//
		// Constructor associated with the following production(s)
		// GeneralConstraint -> TableConstraint

		//

		public GeneralConstraint (TableConstraint p_TableConstraint) : base ((uint) ProductionID._GeneralConstraint_ID, (uint) production_kind.g_GeneralConstraint_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TableConstraint = p_TableConstraint;
		}

		//
		// Constructor associated with the following production(s)
		// GeneralConstraint -> ContentsConstraint

		//

		public GeneralConstraint (ContentsConstraint p_ContentsConstraint) : base ((uint) ProductionID._GeneralConstraint_ID, (uint) production_kind.g_GeneralConstraint_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ContentsConstraint = p_ContentsConstraint;
		}

		public GeneralConstraint () { }

		// Copy constructor

		public GeneralConstraint (GeneralConstraint p_GeneralConstraint) : base (p_GeneralConstraint.id, p_GeneralConstraint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_GeneralConstraint.appInfo;
			switch ((production_kind) p_GeneralConstraint.kind)
			{
				case production_kind.g_GeneralConstraint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UserDefinedConstraint = (p_GeneralConstraint.m_UserDefinedConstraint != null) ? new UserDefinedConstraint (p_GeneralConstraint.m_UserDefinedConstraint) : null) != null) m_UserDefinedConstraint.parent = this;
					break;
				case production_kind.g_GeneralConstraint_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TableConstraint = (p_GeneralConstraint.m_TableConstraint != null) ? new TableConstraint (p_GeneralConstraint.m_TableConstraint) : null) != null) m_TableConstraint.parent = this;
					break;
				case production_kind.g_GeneralConstraint_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ContentsConstraint = (p_GeneralConstraint.m_ContentsConstraint != null) ? new ContentsConstraint (p_GeneralConstraint.m_ContentsConstraint) : null) != null) m_ContentsConstraint.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "GeneralConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new GeneralConstraint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_UserDefinedConstraint?.Dispose ();
			m_TableConstraint?.Dispose ();
			m_ContentsConstraint?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule GeneralConstraint

		// Content changing function(s) associated with production(s) of syntax rule GeneralConstraint

		//
		// Content changing function associated with following production(s)
		// GeneralConstraint -> UserDefinedConstraint

		//

		public void change(UserDefinedConstraint p_UserDefinedConstraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_GeneralConstraint_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_UserDefinedConstraint = p_UserDefinedConstraint;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// GeneralConstraint -> TableConstraint

		//

		public void change(TableConstraint p_TableConstraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_GeneralConstraint_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TableConstraint = p_TableConstraint;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// GeneralConstraint -> ContentsConstraint

		//

		public void change(ContentsConstraint p_ContentsConstraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_GeneralConstraint_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ContentsConstraint = p_ContentsConstraint;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule GeneralConstraint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_UserDefinedConstraint != null) && m_UserDefinedConstraint.checkInclusion (element) ||
				(m_TableConstraint != null) && m_TableConstraint.checkInclusion (element) ||
				(m_ContentsConstraint != null) && m_ContentsConstraint.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule GeneralConstraint

		//
		// emit production tree node associated with any production of syntax rule GeneralConstraint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_GeneralConstraint_1:
					// emit syntax tree node associated with production
					// GeneralConstraint: UserDefinedConstraint

					s += m_UserDefinedConstraint.Emit (depth - 1);
				break;
				case production_kind.g_GeneralConstraint_2:
					// emit syntax tree node associated with production
					// GeneralConstraint: TableConstraint

					s += m_TableConstraint.Emit (depth - 1);
				break;
				case production_kind.g_GeneralConstraint_3:
					// emit syntax tree node associated with production
					// GeneralConstraint: ContentsConstraint

					s += m_ContentsConstraint.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule GeneralConstraint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "GeneralConstraint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_GeneralConstraint_1:
					// emit syntax tree node associated with production
					// GeneralConstraint: UserDefinedConstraint

					s += m_UserDefinedConstraint.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_GeneralConstraint_2:
					// emit syntax tree node associated with production
					// GeneralConstraint: TableConstraint

					s += m_TableConstraint.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_GeneralConstraint_3:
					// emit syntax tree node associated with production
					// GeneralConstraint: ContentsConstraint

					s += m_ContentsConstraint.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule GeneralConstraint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule GeneralConstraint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			GeneralConstraint.production_kind kind = (GeneralConstraint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case GeneralConstraint.production_kind.g_GeneralConstraint_1:
					// traverse syntax tree node associated with production
					// GeneralConstraint: UserDefinedConstraint

						m_UserDefinedConstraint.Visit (visitor, appData);
				break;
				case GeneralConstraint.production_kind.g_GeneralConstraint_2:
					// traverse syntax tree node associated with production
					// GeneralConstraint: TableConstraint

						m_TableConstraint.Visit (visitor, appData);
				break;
				case GeneralConstraint.production_kind.g_GeneralConstraint_3:
					// traverse syntax tree node associated with production
					// GeneralConstraint: ContentsConstraint

						m_ContentsConstraint.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_UserDefinedConstraint?.reparent (this);
			m_TableConstraint?.reparent (this);
			m_ContentsConstraint?.reparent (this);
		}

		//
		// initialize object associated with syntax rule GeneralConstraint
		//

		public void _init ()
		{
			m_UserDefinedConstraint = null;
			m_TableConstraint = null;
			m_ContentsConstraint = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule GeneralConstraint

		// counter of all nodes associated with syntax rule GeneralConstraint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule GeneralConstraint
		[DataMember (Name = "m_UserDefinedConstraint")] public UserDefinedConstraint m_UserDefinedConstraint { get; private set; }
		[DataMember (Name = "m_TableConstraint")] public TableConstraint m_TableConstraint { get; private set; }
		[DataMember (Name = "m_ContentsConstraint")] public ContentsConstraint m_ContentsConstraint { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule GeneralConstraint

		// delegate function (callback) prototype associated with syntax rule GeneralConstraint
		public delegate bool GeneralConstraint_Callback (SyntaxTreeCallbackReason reason, GeneralConstraint.production_kind kind, GeneralConstraint p_GeneralConstraint);

		// event associated with syntax rule GeneralConstraint
		public event GeneralConstraint_Callback GeneralConstraint_Event;

		// event trigger associated with syntax rule GeneralConstraint
		public bool Raise_GeneralConstraint_Event (SyntaxTreeCallbackReason reason, GeneralConstraint.production_kind kind, GeneralConstraint p_GeneralConstraint)
		{
			bool? status = GeneralConstraint_Event?.Invoke (reason, kind, p_GeneralConstraint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule GeneralConstraint
		//
		// traverse syntax tree node associated with any production of syntax rule GeneralConstraint
		//

		public void Traverse (GeneralConstraint p_GeneralConstraint)
		{
			if (p_GeneralConstraint.isLocked())
				return;
			p_GeneralConstraint.dolock();
			GeneralConstraint.production_kind kind = (GeneralConstraint.production_kind) p_GeneralConstraint.kind;
			p_GeneralConstraint.turn_reset ();
			if (Raise_GeneralConstraint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_GeneralConstraint))
			switch (kind)
			{
				case GeneralConstraint.production_kind.g_GeneralConstraint_1:
					// traverse syntax tree node associated with production
					// GeneralConstraint: UserDefinedConstraint

					if (Raise_GeneralConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_GeneralConstraint))
						Traverse (p_GeneralConstraint.m_UserDefinedConstraint);
					p_GeneralConstraint.turn_inc ();
					Raise_GeneralConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_GeneralConstraint);
				break;
				case GeneralConstraint.production_kind.g_GeneralConstraint_2:
					// traverse syntax tree node associated with production
					// GeneralConstraint: TableConstraint

					if (Raise_GeneralConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_GeneralConstraint))
						Traverse (p_GeneralConstraint.m_TableConstraint);
					p_GeneralConstraint.turn_inc ();
					Raise_GeneralConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_GeneralConstraint);
				break;
				case GeneralConstraint.production_kind.g_GeneralConstraint_3:
					// traverse syntax tree node associated with production
					// GeneralConstraint: ContentsConstraint

					if (Raise_GeneralConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_GeneralConstraint))
						Traverse (p_GeneralConstraint.m_ContentsConstraint);
					p_GeneralConstraint.turn_inc ();
					Raise_GeneralConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_GeneralConstraint);
				break;
			}
			Raise_GeneralConstraint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_GeneralConstraint);
			p_GeneralConstraint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule GeneralConstraint
		//

		public void TraverseCommon (GeneralConstraint p_GeneralConstraint)
		{
			GeneralConstraint.production_kind kind = (GeneralConstraint.production_kind) p_GeneralConstraint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_GeneralConstraint))
			switch (kind)
			{
				case GeneralConstraint.production_kind.g_GeneralConstraint_1:
					// traverse syntax tree node associated with production
					// GeneralConstraint: UserDefinedConstraint

						TraverseCommon (p_GeneralConstraint.m_UserDefinedConstraint);
				break;
				case GeneralConstraint.production_kind.g_GeneralConstraint_2:
					// traverse syntax tree node associated with production
					// GeneralConstraint: TableConstraint

						TraverseCommon (p_GeneralConstraint.m_TableConstraint);
				break;
				case GeneralConstraint.production_kind.g_GeneralConstraint_3:
					// traverse syntax tree node associated with production
					// GeneralConstraint: ContentsConstraint

						TraverseCommon (p_GeneralConstraint.m_ContentsConstraint);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_GeneralConstraint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule GeneralConstraint

		//
		// create syntax tree node associated with production
		// GeneralConstraint: UserDefinedConstraint

		//

		public GeneralConstraint GeneralConstraint_1 (UserDefinedConstraint p_UserDefinedConstraint)
		{
			GeneralConstraint p_GeneralConstraint_ref = new GeneralConstraint(p_UserDefinedConstraint);
			p_UserDefinedConstraint.parent = p_GeneralConstraint_ref;
			Raise_GeneralConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, GeneralConstraint.production_kind.g_GeneralConstraint_1, p_GeneralConstraint_ref);
			return p_GeneralConstraint_ref;
		}

		//
		// create syntax tree node associated with production
		// GeneralConstraint: TableConstraint

		//

		public GeneralConstraint GeneralConstraint_2 (TableConstraint p_TableConstraint)
		{
			GeneralConstraint p_GeneralConstraint_ref = new GeneralConstraint(p_TableConstraint);
			p_TableConstraint.parent = p_GeneralConstraint_ref;
			Raise_GeneralConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, GeneralConstraint.production_kind.g_GeneralConstraint_2, p_GeneralConstraint_ref);
			return p_GeneralConstraint_ref;
		}

		//
		// create syntax tree node associated with production
		// GeneralConstraint: ContentsConstraint

		//

		public GeneralConstraint GeneralConstraint_3 (ContentsConstraint p_ContentsConstraint)
		{
			GeneralConstraint p_GeneralConstraint_ref = new GeneralConstraint(p_ContentsConstraint);
			p_ContentsConstraint.parent = p_GeneralConstraint_ref;
			Raise_GeneralConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, GeneralConstraint.production_kind.g_GeneralConstraint_3, p_GeneralConstraint_ref);
			return p_GeneralConstraint_ref;
		}
		#endregion
	};
}
