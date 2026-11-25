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
	// class associated with syntax rule IntersectionMark
	//

	[DataContract]
	public class	IntersectionMark : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule IntersectionMark
		public enum production_kind : ushort	// enumerated production(s) of syntax rule IntersectionMark
		{
			g_IntersectionMark_1 = 1,	// "^"

			g_IntersectionMark_2 = 2,	// INTERSECTION

		};
		#endregion
		#region production markers associated with the syntax rule IntersectionMark

		// markers associated with production: IntersectionMark -> "^"

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: IntersectionMark -> INTERSECTION

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule IntersectionMark

		// Constructor declaration(s) associated with production(s) of syntax rule IntersectionMark

		//
		// Constructor associated with the following production(s)
		// IntersectionMark -> "^"

		// IntersectionMark -> INTERSECTION

		//

		public IntersectionMark (SyntaxTreeToken p_token, int kind) : base ((uint) ProductionID._IntersectionMark_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_IntersectionMark_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_accent_sign = p_token;
				break;
			case production_kind.g_IntersectionMark_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_INTERSECTION = p_token;
				break;
			default:
				{
					string[] args = new string[] { "IntersectionMark" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		public IntersectionMark () { }

		// Copy constructor

		public IntersectionMark (IntersectionMark p_IntersectionMark) : base (p_IntersectionMark.id, p_IntersectionMark.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_IntersectionMark.appInfo;
			switch ((production_kind) p_IntersectionMark.kind)
			{
				case production_kind.g_IntersectionMark_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_accent_sign = (p_IntersectionMark.m_accent_sign != null) ? new SyntaxTreeToken (p_IntersectionMark.m_accent_sign) : null) != null) m_accent_sign.parent = this;
					break;
				case production_kind.g_IntersectionMark_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_INTERSECTION = (p_IntersectionMark.m_INTERSECTION != null) ? new SyntaxTreeToken (p_IntersectionMark.m_INTERSECTION) : null) != null) m_INTERSECTION.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "IntersectionMark" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new IntersectionMark (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_accent_sign?.Dispose ();
			m_INTERSECTION?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule IntersectionMark

		// Content changing function(s) associated with production(s) of syntax rule IntersectionMark

		//
		// Content changing function associated with following production(s)
		// IntersectionMark -> "^"

		// IntersectionMark -> INTERSECTION

		//

		public void change(SyntaxTreeToken p_token, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_IntersectionMark_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_accent_sign = p_token;
				break;
			case production_kind.g_IntersectionMark_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_INTERSECTION = p_token;
				break;
			default:
				{
					string[] args = new string[] { "IntersectionMark" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule IntersectionMark
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_accent_sign != null) && m_accent_sign.checkInclusion (element) ||
				(m_INTERSECTION != null) && m_INTERSECTION.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule IntersectionMark

		//
		// emit production tree node associated with any production of syntax rule IntersectionMark
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_IntersectionMark_1:
					// emit syntax tree node associated with production
					// IntersectionMark: "^"

					s += m_accent_sign.Emit (depth - 1);
				break;
				case production_kind.g_IntersectionMark_2:
					// emit syntax tree node associated with production
					// IntersectionMark: INTERSECTION

					s += m_INTERSECTION.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule IntersectionMark
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "IntersectionMark (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_IntersectionMark_1:
					// emit syntax tree node associated with production
					// IntersectionMark: "^"

					s += "accent_sign";
				break;
				case production_kind.g_IntersectionMark_2:
					// emit syntax tree node associated with production
					// IntersectionMark: INTERSECTION

					s += "INTERSECTION";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule IntersectionMark

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule IntersectionMark with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			IntersectionMark.production_kind kind = (IntersectionMark.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case IntersectionMark.production_kind.g_IntersectionMark_1:
					// traverse syntax tree node associated with production
					// IntersectionMark: "^"

						m_accent_sign.Visit (visitor, appData);
				break;
				case IntersectionMark.production_kind.g_IntersectionMark_2:
					// traverse syntax tree node associated with production
					// IntersectionMark: INTERSECTION

						m_INTERSECTION.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_accent_sign?.reparent (this);
			m_INTERSECTION?.reparent (this);
		}

		//
		// initialize object associated with syntax rule IntersectionMark
		//

		public void _init ()
		{
			m_accent_sign = null;
			m_INTERSECTION = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule IntersectionMark

		// counter of all nodes associated with syntax rule IntersectionMark
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule IntersectionMark
		[DataMember (Name = "m_accent_sign")] public SyntaxTreeToken m_accent_sign { get; private set; }
		[DataMember (Name = "m_INTERSECTION")] public SyntaxTreeToken m_INTERSECTION { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule IntersectionMark

		// delegate function (callback) prototype associated with syntax rule IntersectionMark
		public delegate bool IntersectionMark_Callback (SyntaxTreeCallbackReason reason, IntersectionMark.production_kind kind, IntersectionMark p_IntersectionMark);

		// event associated with syntax rule IntersectionMark
		public event IntersectionMark_Callback IntersectionMark_Event;

		// event trigger associated with syntax rule IntersectionMark
		public bool Raise_IntersectionMark_Event (SyntaxTreeCallbackReason reason, IntersectionMark.production_kind kind, IntersectionMark p_IntersectionMark)
		{
			bool? status = IntersectionMark_Event?.Invoke (reason, kind, p_IntersectionMark);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule IntersectionMark
		//
		// traverse syntax tree node associated with any production of syntax rule IntersectionMark
		//

		public void Traverse (IntersectionMark p_IntersectionMark)
		{
			if (p_IntersectionMark.isLocked())
				return;
			p_IntersectionMark.dolock();
			IntersectionMark.production_kind kind = (IntersectionMark.production_kind) p_IntersectionMark.kind;
			p_IntersectionMark.turn_reset ();
			if (Raise_IntersectionMark_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_IntersectionMark))
			switch (kind)
			{
				case IntersectionMark.production_kind.g_IntersectionMark_1:
					// traverse syntax tree node associated with production
					// IntersectionMark: "^"

				break;
				case IntersectionMark.production_kind.g_IntersectionMark_2:
					// traverse syntax tree node associated with production
					// IntersectionMark: INTERSECTION

				break;
			}
			Raise_IntersectionMark_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_IntersectionMark);
			p_IntersectionMark.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule IntersectionMark
		//

		public void TraverseCommon (IntersectionMark p_IntersectionMark)
		{
			IntersectionMark.production_kind kind = (IntersectionMark.production_kind) p_IntersectionMark.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_IntersectionMark))
			switch (kind)
			{
				case IntersectionMark.production_kind.g_IntersectionMark_1:
					// traverse syntax tree node associated with production
					// IntersectionMark: "^"

						TraverseCommon (p_IntersectionMark.m_accent_sign);
				break;
				case IntersectionMark.production_kind.g_IntersectionMark_2:
					// traverse syntax tree node associated with production
					// IntersectionMark: INTERSECTION

						TraverseCommon (p_IntersectionMark.m_INTERSECTION);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_IntersectionMark);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule IntersectionMark

		//
		// create syntax tree node associated with production
		// IntersectionMark: "^"

		//

		public IntersectionMark IntersectionMark_1 (SyntaxTreeToken p_token)
		{
			IntersectionMark p_IntersectionMark_ref = new IntersectionMark(p_token, 1);
			p_token.parent = p_IntersectionMark_ref;
			Raise_IntersectionMark_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, IntersectionMark.production_kind.g_IntersectionMark_1, p_IntersectionMark_ref);
			return p_IntersectionMark_ref;
		}

		//
		// create syntax tree node associated with production
		// IntersectionMark: INTERSECTION

		//

		public IntersectionMark IntersectionMark_2 (SyntaxTreeToken p_token)
		{
			IntersectionMark p_IntersectionMark_ref = new IntersectionMark(p_token, 2);
			p_token.parent = p_IntersectionMark_ref;
			Raise_IntersectionMark_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, IntersectionMark.production_kind.g_IntersectionMark_2, p_IntersectionMark_ref);
			return p_IntersectionMark_ref;
		}
		#endregion
	};
}
