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
	// class associated with syntax rule SelectionOption
	//

	[DataContract]
	public class	SelectionOption : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SelectionOption
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SelectionOption
		{
			g_SelectionOption_1 = 1,	// %empty

			g_SelectionOption_2 = 2,	// WITH SUCCESSORS

			g_SelectionOption_3 = 3,	// WITH DESCENDANTS

		};
		#endregion
		#region production markers associated with the syntax rule SelectionOption

		// markers associated with production: SelectionOption -> %empty

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: SelectionOption -> WITH SUCCESSORS

		public enum production_marker_2 : ushort
		{
			final
		};

		// markers associated with production: SelectionOption -> WITH DESCENDANTS

		public enum production_marker_3 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SelectionOption

		// Constructor declaration(s) associated with production(s) of syntax rule SelectionOption

		//
		// Constructor associated with the following production(s)
		// SelectionOption -> %empty

		//

		public SelectionOption () : base ((uint) ProductionID._SelectionOption_ID, (uint) production_kind.g_SelectionOption_1)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		//
		// Constructor associated with the following production(s)
		// SelectionOption -> WITH SUCCESSORS

		// SelectionOption -> WITH DESCENDANTS

		//

		public SelectionOption (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, int kind) : base ((uint) ProductionID._SelectionOption_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_SelectionOption_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
				children[0] = m_WITH = p_token;
				children[1] = m_SUCCESSORS = p_token_1;
				break;
			case production_kind.g_SelectionOption_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
				children[0] = m_WITH = p_token;
				children[1] = m_DESCENDANTS = p_token_1;
				break;
			default:
				{
					string[] args = new string[] { "SelectionOption" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Copy constructor

		public SelectionOption (SelectionOption p_SelectionOption) : base (p_SelectionOption.id, p_SelectionOption.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SelectionOption.appInfo;
			switch ((production_kind) p_SelectionOption.kind)
			{
				case production_kind.g_SelectionOption_1:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				case production_kind.g_SelectionOption_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_WITH = (p_SelectionOption.m_WITH != null) ? new SyntaxTreeToken (p_SelectionOption.m_WITH) : null) != null) m_WITH.parent = this;
					if ((children [1] = m_SUCCESSORS = (p_SelectionOption.m_SUCCESSORS != null) ? new SyntaxTreeToken (p_SelectionOption.m_SUCCESSORS) : null) != null) m_SUCCESSORS.parent = this;
					break;
				case production_kind.g_SelectionOption_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_WITH = (p_SelectionOption.m_WITH != null) ? new SyntaxTreeToken (p_SelectionOption.m_WITH) : null) != null) m_WITH.parent = this;
					if ((children [1] = m_DESCENDANTS = (p_SelectionOption.m_DESCENDANTS != null) ? new SyntaxTreeToken (p_SelectionOption.m_DESCENDANTS) : null) != null) m_DESCENDANTS.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SelectionOption" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SelectionOption (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_WITH?.Dispose ();
			m_SUCCESSORS?.Dispose ();
			m_DESCENDANTS?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SelectionOption

		// Content changing function(s) associated with production(s) of syntax rule SelectionOption

		//
		// Content changing function associated with following production(s)
		// SelectionOption -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_SelectionOption_1;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SelectionOption -> WITH SUCCESSORS

		// SelectionOption -> WITH DESCENDANTS

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_SelectionOption_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
				children [0] = m_WITH = p_token;
				children [1] = m_SUCCESSORS = p_token_1;
				break;
			case production_kind.g_SelectionOption_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
				children [0] = m_WITH = p_token;
				children [1] = m_DESCENDANTS = p_token_1;
				break;
			default:
				{
					string[] args = new string[] { "SelectionOption" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SelectionOption
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_WITH != null) && m_WITH.checkInclusion (element) ||
				(m_SUCCESSORS != null) && m_SUCCESSORS.checkInclusion (element) ||
				(m_DESCENDANTS != null) && m_DESCENDANTS.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SelectionOption

		//
		// emit production tree node associated with any production of syntax rule SelectionOption
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SelectionOption_1:
					// emit syntax tree node associated with production
					// SelectionOption: %empty

				break;
				case production_kind.g_SelectionOption_2:
					// emit syntax tree node associated with production
					// SelectionOption: WITH SUCCESSORS

					s += m_WITH.Emit (depth - 1);
					s += " ";
					s += m_SUCCESSORS.Emit (depth - 1);
				break;
				case production_kind.g_SelectionOption_3:
					// emit syntax tree node associated with production
					// SelectionOption: WITH DESCENDANTS

					s += m_WITH.Emit (depth - 1);
					s += " ";
					s += m_DESCENDANTS.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SelectionOption
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SelectionOption (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SelectionOption_1:
					// emit syntax tree node associated with production
					// SelectionOption: %empty

				break;
				case production_kind.g_SelectionOption_2:
					// emit syntax tree node associated with production
					// SelectionOption: WITH SUCCESSORS

					s += "WITH";
					s += ' ';
					s += "SUCCESSORS";
				break;
				case production_kind.g_SelectionOption_3:
					// emit syntax tree node associated with production
					// SelectionOption: WITH DESCENDANTS

					s += "WITH";
					s += ' ';
					s += "DESCENDANTS";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SelectionOption

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SelectionOption with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SelectionOption.production_kind kind = (SelectionOption.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SelectionOption.production_kind.g_SelectionOption_1:
					// traverse syntax tree node associated with production
					// SelectionOption: %empty

				break;
				case SelectionOption.production_kind.g_SelectionOption_2:
					// traverse syntax tree node associated with production
					// SelectionOption: WITH SUCCESSORS

						m_WITH.Visit (visitor, appData);
						m_SUCCESSORS.Visit (visitor, appData);
				break;
				case SelectionOption.production_kind.g_SelectionOption_3:
					// traverse syntax tree node associated with production
					// SelectionOption: WITH DESCENDANTS

						m_WITH.Visit (visitor, appData);
						m_DESCENDANTS.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_WITH?.reparent (this);
			m_SUCCESSORS?.reparent (this);
			m_DESCENDANTS?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SelectionOption
		//

		public void _init ()
		{
			m_WITH = null;
			m_SUCCESSORS = null;
			m_DESCENDANTS = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SelectionOption

		// counter of all nodes associated with syntax rule SelectionOption
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SelectionOption
		[DataMember (Name = "m_WITH")] public SyntaxTreeToken m_WITH { get; private set; }
		[DataMember (Name = "m_SUCCESSORS")] public SyntaxTreeToken m_SUCCESSORS { get; private set; }
		[DataMember (Name = "m_DESCENDANTS")] public SyntaxTreeToken m_DESCENDANTS { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SelectionOption

		// delegate function (callback) prototype associated with syntax rule SelectionOption
		public delegate bool SelectionOption_Callback (SyntaxTreeCallbackReason reason, SelectionOption.production_kind kind, SelectionOption p_SelectionOption);

		// event associated with syntax rule SelectionOption
		public event SelectionOption_Callback SelectionOption_Event;

		// event trigger associated with syntax rule SelectionOption
		public bool Raise_SelectionOption_Event (SyntaxTreeCallbackReason reason, SelectionOption.production_kind kind, SelectionOption p_SelectionOption)
		{
			bool? status = SelectionOption_Event?.Invoke (reason, kind, p_SelectionOption);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SelectionOption
		//
		// traverse syntax tree node associated with any production of syntax rule SelectionOption
		//

		public void Traverse (SelectionOption p_SelectionOption)
		{
			if (p_SelectionOption.isLocked())
				return;
			p_SelectionOption.dolock();
			SelectionOption.production_kind kind = (SelectionOption.production_kind) p_SelectionOption.kind;
			p_SelectionOption.turn_reset ();
			if (Raise_SelectionOption_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SelectionOption))
			switch (kind)
			{
				case SelectionOption.production_kind.g_SelectionOption_1:
					// traverse syntax tree node associated with production
					// SelectionOption: %empty

				break;
				case SelectionOption.production_kind.g_SelectionOption_2:
					// traverse syntax tree node associated with production
					// SelectionOption: WITH SUCCESSORS

				break;
				case SelectionOption.production_kind.g_SelectionOption_3:
					// traverse syntax tree node associated with production
					// SelectionOption: WITH DESCENDANTS

				break;
			}
			Raise_SelectionOption_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SelectionOption);
			p_SelectionOption.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SelectionOption
		//

		public void TraverseCommon (SelectionOption p_SelectionOption)
		{
			SelectionOption.production_kind kind = (SelectionOption.production_kind) p_SelectionOption.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SelectionOption))
			switch (kind)
			{
				case SelectionOption.production_kind.g_SelectionOption_1:
					// traverse syntax tree node associated with production
					// SelectionOption: %empty

				break;
				case SelectionOption.production_kind.g_SelectionOption_2:
					// traverse syntax tree node associated with production
					// SelectionOption: WITH SUCCESSORS

						TraverseCommon (p_SelectionOption.m_WITH);
						TraverseCommon (p_SelectionOption.m_SUCCESSORS);
				break;
				case SelectionOption.production_kind.g_SelectionOption_3:
					// traverse syntax tree node associated with production
					// SelectionOption: WITH DESCENDANTS

						TraverseCommon (p_SelectionOption.m_WITH);
						TraverseCommon (p_SelectionOption.m_DESCENDANTS);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SelectionOption);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SelectionOption

		//
		// create syntax tree node associated with production
		// SelectionOption: %empty

		//

		public SelectionOption SelectionOption_1 ()
		{
			SelectionOption p_SelectionOption_ref = new SelectionOption();
			Raise_SelectionOption_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SelectionOption.production_kind.g_SelectionOption_1, p_SelectionOption_ref);
			return p_SelectionOption_ref;
		}

		//
		// create syntax tree node associated with production
		// SelectionOption: WITH SUCCESSORS

		//

		public SelectionOption SelectionOption_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			SelectionOption p_SelectionOption_ref = new SelectionOption(p_token, p_token_1, 2);
			p_token.parent = p_SelectionOption_ref;
			p_token_1.parent = p_SelectionOption_ref;
			Raise_SelectionOption_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SelectionOption.production_kind.g_SelectionOption_2, p_SelectionOption_ref);
			return p_SelectionOption_ref;
		}

		//
		// create syntax tree node associated with production
		// SelectionOption: WITH DESCENDANTS

		//

		public SelectionOption SelectionOption_3 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			SelectionOption p_SelectionOption_ref = new SelectionOption(p_token, p_token_1, 3);
			p_token.parent = p_SelectionOption_ref;
			p_token_1.parent = p_SelectionOption_ref;
			Raise_SelectionOption_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SelectionOption.production_kind.g_SelectionOption_3, p_SelectionOption_ref);
			return p_SelectionOption_ref;
		}
		#endregion
	};
}
