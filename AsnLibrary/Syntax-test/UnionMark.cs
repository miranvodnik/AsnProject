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
	// class associated with syntax rule UnionMark
	//

	[DataContract]
	public class	UnionMark : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule UnionMark
		public enum production_kind : ushort	// enumerated production(s) of syntax rule UnionMark
		{
			g_UnionMark_1 = 1,	// "|"

			g_UnionMark_2 = 2,	// UNION

		};
		#endregion
		#region production markers associated with the syntax rule UnionMark

		// markers associated with production: UnionMark -> "|"

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: UnionMark -> UNION

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule UnionMark

		// Constructor declaration(s) associated with production(s) of syntax rule UnionMark

		//
		// Constructor associated with the following production(s)
		// UnionMark -> "|"

		// UnionMark -> UNION

		//

		public UnionMark (SyntaxTreeToken p_token, int kind) : base ((uint) ProductionID._UnionMark_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_UnionMark_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_vertical_bar = p_token;
				break;
			case production_kind.g_UnionMark_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_UNION = p_token;
				break;
			default:
				{
					string[] args = new string[] { "UnionMark" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		public UnionMark () { }

		// Copy constructor

		public UnionMark (UnionMark p_UnionMark) : base (p_UnionMark.id, p_UnionMark.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_UnionMark.appInfo;
			switch ((production_kind) p_UnionMark.kind)
			{
				case production_kind.g_UnionMark_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_vertical_bar = (p_UnionMark.m_vertical_bar != null) ? new SyntaxTreeToken (p_UnionMark.m_vertical_bar) : null) != null) m_vertical_bar.parent = this;
					break;
				case production_kind.g_UnionMark_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UNION = (p_UnionMark.m_UNION != null) ? new SyntaxTreeToken (p_UnionMark.m_UNION) : null) != null) m_UNION.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "UnionMark" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new UnionMark (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_vertical_bar?.Dispose ();
			m_UNION?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule UnionMark

		// Content changing function(s) associated with production(s) of syntax rule UnionMark

		//
		// Content changing function associated with following production(s)
		// UnionMark -> "|"

		// UnionMark -> UNION

		//

		public void change(SyntaxTreeToken p_token, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_UnionMark_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_vertical_bar = p_token;
				break;
			case production_kind.g_UnionMark_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_UNION = p_token;
				break;
			default:
				{
					string[] args = new string[] { "UnionMark" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule UnionMark
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_vertical_bar != null) && m_vertical_bar.checkInclusion (element) ||
				(m_UNION != null) && m_UNION.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule UnionMark

		//
		// emit production tree node associated with any production of syntax rule UnionMark
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_UnionMark_1:
					// emit syntax tree node associated with production
					// UnionMark: "|"

					s += m_vertical_bar.Emit (depth - 1);
				break;
				case production_kind.g_UnionMark_2:
					// emit syntax tree node associated with production
					// UnionMark: UNION

					s += m_UNION.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule UnionMark
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "UnionMark (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_UnionMark_1:
					// emit syntax tree node associated with production
					// UnionMark: "|"

					s += "vertical_bar";
				break;
				case production_kind.g_UnionMark_2:
					// emit syntax tree node associated with production
					// UnionMark: UNION

					s += "UNION";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule UnionMark

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule UnionMark with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			UnionMark.production_kind kind = (UnionMark.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case UnionMark.production_kind.g_UnionMark_1:
					// traverse syntax tree node associated with production
					// UnionMark: "|"

						m_vertical_bar.Visit (visitor, appData);
				break;
				case UnionMark.production_kind.g_UnionMark_2:
					// traverse syntax tree node associated with production
					// UnionMark: UNION

						m_UNION.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_vertical_bar?.reparent (this);
			m_UNION?.reparent (this);
		}

		//
		// initialize object associated with syntax rule UnionMark
		//

		public void _init ()
		{
			m_vertical_bar = null;
			m_UNION = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule UnionMark

		// counter of all nodes associated with syntax rule UnionMark
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule UnionMark
		[DataMember (Name = "m_vertical_bar")] public SyntaxTreeToken m_vertical_bar { get; private set; }
		[DataMember (Name = "m_UNION")] public SyntaxTreeToken m_UNION { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule UnionMark

		// delegate function (callback) prototype associated with syntax rule UnionMark
		public delegate bool UnionMark_Callback (SyntaxTreeCallbackReason reason, UnionMark.production_kind kind, UnionMark p_UnionMark);

		// event associated with syntax rule UnionMark
		public event UnionMark_Callback UnionMark_Event;

		// event trigger associated with syntax rule UnionMark
		public bool Raise_UnionMark_Event (SyntaxTreeCallbackReason reason, UnionMark.production_kind kind, UnionMark p_UnionMark)
		{
			bool? status = UnionMark_Event?.Invoke (reason, kind, p_UnionMark);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule UnionMark
		//
		// traverse syntax tree node associated with any production of syntax rule UnionMark
		//

		public void Traverse (UnionMark p_UnionMark)
		{
			if (p_UnionMark.isLocked())
				return;
			p_UnionMark.dolock();
			UnionMark.production_kind kind = (UnionMark.production_kind) p_UnionMark.kind;
			p_UnionMark.turn_reset ();
			if (Raise_UnionMark_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_UnionMark))
			switch (kind)
			{
				case UnionMark.production_kind.g_UnionMark_1:
					// traverse syntax tree node associated with production
					// UnionMark: "|"

				break;
				case UnionMark.production_kind.g_UnionMark_2:
					// traverse syntax tree node associated with production
					// UnionMark: UNION

				break;
			}
			Raise_UnionMark_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_UnionMark);
			p_UnionMark.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule UnionMark
		//

		public void TraverseCommon (UnionMark p_UnionMark)
		{
			UnionMark.production_kind kind = (UnionMark.production_kind) p_UnionMark.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_UnionMark))
			switch (kind)
			{
				case UnionMark.production_kind.g_UnionMark_1:
					// traverse syntax tree node associated with production
					// UnionMark: "|"

						TraverseCommon (p_UnionMark.m_vertical_bar);
				break;
				case UnionMark.production_kind.g_UnionMark_2:
					// traverse syntax tree node associated with production
					// UnionMark: UNION

						TraverseCommon (p_UnionMark.m_UNION);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_UnionMark);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule UnionMark

		//
		// create syntax tree node associated with production
		// UnionMark: "|"

		//

		public UnionMark UnionMark_1 (SyntaxTreeToken p_token)
		{
			UnionMark p_UnionMark_ref = new UnionMark(p_token, 1);
			p_token.parent = p_UnionMark_ref;
			Raise_UnionMark_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UnionMark.production_kind.g_UnionMark_1, p_UnionMark_ref);
			return p_UnionMark_ref;
		}

		//
		// create syntax tree node associated with production
		// UnionMark: UNION

		//

		public UnionMark UnionMark_2 (SyntaxTreeToken p_token)
		{
			UnionMark p_UnionMark_ref = new UnionMark(p_token, 2);
			p_token.parent = p_UnionMark_ref;
			Raise_UnionMark_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UnionMark.production_kind.g_UnionMark_2, p_UnionMark_ref);
			return p_UnionMark_ref;
		}
		#endregion
	};
}
