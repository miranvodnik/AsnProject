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
	// class associated with syntax rule PresenceConstraint
	//

	[DataContract]
	public class	PresenceConstraint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule PresenceConstraint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule PresenceConstraint
		{
			g_PresenceConstraint_1 = 1,	// PRESENT

			g_PresenceConstraint_2 = 2,	// ABSENT

			g_PresenceConstraint_3 = 3,	// OPTIONAL

			g_PresenceConstraint_4 = 4,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule PresenceConstraint

		// markers associated with production: PresenceConstraint -> PRESENT

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: PresenceConstraint -> ABSENT

		public enum production_marker_2 : ushort
		{
			final
		};

		// markers associated with production: PresenceConstraint -> OPTIONAL

		public enum production_marker_3 : ushort
		{
			final
		};

		// markers associated with production: PresenceConstraint -> %empty

		public enum production_marker_4 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule PresenceConstraint

		// Constructor declaration(s) associated with production(s) of syntax rule PresenceConstraint

		//
		// Constructor associated with the following production(s)
		// PresenceConstraint -> PRESENT

		// PresenceConstraint -> ABSENT

		// PresenceConstraint -> OPTIONAL

		//

		public PresenceConstraint (SyntaxTreeToken p_token, int kind) : base ((uint) ProductionID._PresenceConstraint_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_PresenceConstraint_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_PRESENT = p_token;
				break;
			case production_kind.g_PresenceConstraint_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_ABSENT = p_token;
				break;
			case production_kind.g_PresenceConstraint_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_OPTIONAL = p_token;
				break;
			default:
				{
					string[] args = new string[] { "PresenceConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		//
		// Constructor associated with the following production(s)
		// PresenceConstraint -> %empty

		//

		public PresenceConstraint () : base ((uint) ProductionID._PresenceConstraint_ID, (uint) production_kind.g_PresenceConstraint_4)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public PresenceConstraint (PresenceConstraint p_PresenceConstraint) : base (p_PresenceConstraint.id, p_PresenceConstraint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_PresenceConstraint.appInfo;
			switch ((production_kind) p_PresenceConstraint.kind)
			{
				case production_kind.g_PresenceConstraint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_PRESENT = (p_PresenceConstraint.m_PRESENT != null) ? new SyntaxTreeToken (p_PresenceConstraint.m_PRESENT) : null) != null) m_PRESENT.parent = this;
					break;
				case production_kind.g_PresenceConstraint_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ABSENT = (p_PresenceConstraint.m_ABSENT != null) ? new SyntaxTreeToken (p_PresenceConstraint.m_ABSENT) : null) != null) m_ABSENT.parent = this;
					break;
				case production_kind.g_PresenceConstraint_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OPTIONAL = (p_PresenceConstraint.m_OPTIONAL != null) ? new SyntaxTreeToken (p_PresenceConstraint.m_OPTIONAL) : null) != null) m_OPTIONAL.parent = this;
					break;
				case production_kind.g_PresenceConstraint_4:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "PresenceConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new PresenceConstraint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_PRESENT?.Dispose ();
			m_ABSENT?.Dispose ();
			m_OPTIONAL?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule PresenceConstraint

		// Content changing function(s) associated with production(s) of syntax rule PresenceConstraint

		//
		// Content changing function associated with following production(s)
		// PresenceConstraint -> PRESENT

		// PresenceConstraint -> ABSENT

		// PresenceConstraint -> OPTIONAL

		//

		public void change(SyntaxTreeToken p_token, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_PresenceConstraint_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_PRESENT = p_token;
				break;
			case production_kind.g_PresenceConstraint_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_ABSENT = p_token;
				break;
			case production_kind.g_PresenceConstraint_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_OPTIONAL = p_token;
				break;
			default:
				{
					string[] args = new string[] { "PresenceConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// PresenceConstraint -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_PresenceConstraint_4;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule PresenceConstraint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_PRESENT != null) && m_PRESENT.checkInclusion (element) ||
				(m_ABSENT != null) && m_ABSENT.checkInclusion (element) ||
				(m_OPTIONAL != null) && m_OPTIONAL.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule PresenceConstraint

		//
		// emit production tree node associated with any production of syntax rule PresenceConstraint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_PresenceConstraint_1:
					// emit syntax tree node associated with production
					// PresenceConstraint: PRESENT

					s += m_PRESENT.Emit (depth - 1);
				break;
				case production_kind.g_PresenceConstraint_2:
					// emit syntax tree node associated with production
					// PresenceConstraint: ABSENT

					s += m_ABSENT.Emit (depth - 1);
				break;
				case production_kind.g_PresenceConstraint_3:
					// emit syntax tree node associated with production
					// PresenceConstraint: OPTIONAL

					s += m_OPTIONAL.Emit (depth - 1);
				break;
				case production_kind.g_PresenceConstraint_4:
					// emit syntax tree node associated with production
					// PresenceConstraint: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule PresenceConstraint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "PresenceConstraint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_PresenceConstraint_1:
					// emit syntax tree node associated with production
					// PresenceConstraint: PRESENT

					s += "PRESENT";
				break;
				case production_kind.g_PresenceConstraint_2:
					// emit syntax tree node associated with production
					// PresenceConstraint: ABSENT

					s += "ABSENT";
				break;
				case production_kind.g_PresenceConstraint_3:
					// emit syntax tree node associated with production
					// PresenceConstraint: OPTIONAL

					s += "OPTIONAL";
				break;
				case production_kind.g_PresenceConstraint_4:
					// emit syntax tree node associated with production
					// PresenceConstraint: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule PresenceConstraint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule PresenceConstraint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			PresenceConstraint.production_kind kind = (PresenceConstraint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case PresenceConstraint.production_kind.g_PresenceConstraint_1:
					// traverse syntax tree node associated with production
					// PresenceConstraint: PRESENT

						m_PRESENT.Visit (visitor, appData);
				break;
				case PresenceConstraint.production_kind.g_PresenceConstraint_2:
					// traverse syntax tree node associated with production
					// PresenceConstraint: ABSENT

						m_ABSENT.Visit (visitor, appData);
				break;
				case PresenceConstraint.production_kind.g_PresenceConstraint_3:
					// traverse syntax tree node associated with production
					// PresenceConstraint: OPTIONAL

						m_OPTIONAL.Visit (visitor, appData);
				break;
				case PresenceConstraint.production_kind.g_PresenceConstraint_4:
					// traverse syntax tree node associated with production
					// PresenceConstraint: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_PRESENT?.reparent (this);
			m_ABSENT?.reparent (this);
			m_OPTIONAL?.reparent (this);
		}

		//
		// initialize object associated with syntax rule PresenceConstraint
		//

		public void _init ()
		{
			m_PRESENT = null;
			m_ABSENT = null;
			m_OPTIONAL = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule PresenceConstraint

		// counter of all nodes associated with syntax rule PresenceConstraint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule PresenceConstraint
		[DataMember (Name = "m_PRESENT")] public SyntaxTreeToken m_PRESENT { get; private set; }
		[DataMember (Name = "m_ABSENT")] public SyntaxTreeToken m_ABSENT { get; private set; }
		[DataMember (Name = "m_OPTIONAL")] public SyntaxTreeToken m_OPTIONAL { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule PresenceConstraint

		// delegate function (callback) prototype associated with syntax rule PresenceConstraint
		public delegate bool PresenceConstraint_Callback (SyntaxTreeCallbackReason reason, PresenceConstraint.production_kind kind, PresenceConstraint p_PresenceConstraint);

		// event associated with syntax rule PresenceConstraint
		public event PresenceConstraint_Callback PresenceConstraint_Event;

		// event trigger associated with syntax rule PresenceConstraint
		public bool Raise_PresenceConstraint_Event (SyntaxTreeCallbackReason reason, PresenceConstraint.production_kind kind, PresenceConstraint p_PresenceConstraint)
		{
			bool? status = PresenceConstraint_Event?.Invoke (reason, kind, p_PresenceConstraint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule PresenceConstraint
		//
		// traverse syntax tree node associated with any production of syntax rule PresenceConstraint
		//

		public void Traverse (PresenceConstraint p_PresenceConstraint)
		{
			if (p_PresenceConstraint.isLocked())
				return;
			p_PresenceConstraint.dolock();
			PresenceConstraint.production_kind kind = (PresenceConstraint.production_kind) p_PresenceConstraint.kind;
			p_PresenceConstraint.turn_reset ();
			if (Raise_PresenceConstraint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_PresenceConstraint))
			switch (kind)
			{
				case PresenceConstraint.production_kind.g_PresenceConstraint_1:
					// traverse syntax tree node associated with production
					// PresenceConstraint: PRESENT

				break;
				case PresenceConstraint.production_kind.g_PresenceConstraint_2:
					// traverse syntax tree node associated with production
					// PresenceConstraint: ABSENT

				break;
				case PresenceConstraint.production_kind.g_PresenceConstraint_3:
					// traverse syntax tree node associated with production
					// PresenceConstraint: OPTIONAL

				break;
				case PresenceConstraint.production_kind.g_PresenceConstraint_4:
					// traverse syntax tree node associated with production
					// PresenceConstraint: %empty

				break;
			}
			Raise_PresenceConstraint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_PresenceConstraint);
			p_PresenceConstraint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule PresenceConstraint
		//

		public void TraverseCommon (PresenceConstraint p_PresenceConstraint)
		{
			PresenceConstraint.production_kind kind = (PresenceConstraint.production_kind) p_PresenceConstraint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_PresenceConstraint))
			switch (kind)
			{
				case PresenceConstraint.production_kind.g_PresenceConstraint_1:
					// traverse syntax tree node associated with production
					// PresenceConstraint: PRESENT

						TraverseCommon (p_PresenceConstraint.m_PRESENT);
				break;
				case PresenceConstraint.production_kind.g_PresenceConstraint_2:
					// traverse syntax tree node associated with production
					// PresenceConstraint: ABSENT

						TraverseCommon (p_PresenceConstraint.m_ABSENT);
				break;
				case PresenceConstraint.production_kind.g_PresenceConstraint_3:
					// traverse syntax tree node associated with production
					// PresenceConstraint: OPTIONAL

						TraverseCommon (p_PresenceConstraint.m_OPTIONAL);
				break;
				case PresenceConstraint.production_kind.g_PresenceConstraint_4:
					// traverse syntax tree node associated with production
					// PresenceConstraint: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_PresenceConstraint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule PresenceConstraint

		//
		// create syntax tree node associated with production
		// PresenceConstraint: PRESENT

		//

		public PresenceConstraint PresenceConstraint_1 (SyntaxTreeToken p_token)
		{
			PresenceConstraint p_PresenceConstraint_ref = new PresenceConstraint(p_token, 1);
			p_token.parent = p_PresenceConstraint_ref;
			Raise_PresenceConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, PresenceConstraint.production_kind.g_PresenceConstraint_1, p_PresenceConstraint_ref);
			return p_PresenceConstraint_ref;
		}

		//
		// create syntax tree node associated with production
		// PresenceConstraint: ABSENT

		//

		public PresenceConstraint PresenceConstraint_2 (SyntaxTreeToken p_token)
		{
			PresenceConstraint p_PresenceConstraint_ref = new PresenceConstraint(p_token, 2);
			p_token.parent = p_PresenceConstraint_ref;
			Raise_PresenceConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, PresenceConstraint.production_kind.g_PresenceConstraint_2, p_PresenceConstraint_ref);
			return p_PresenceConstraint_ref;
		}

		//
		// create syntax tree node associated with production
		// PresenceConstraint: OPTIONAL

		//

		public PresenceConstraint PresenceConstraint_3 (SyntaxTreeToken p_token)
		{
			PresenceConstraint p_PresenceConstraint_ref = new PresenceConstraint(p_token, 3);
			p_token.parent = p_PresenceConstraint_ref;
			Raise_PresenceConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, PresenceConstraint.production_kind.g_PresenceConstraint_3, p_PresenceConstraint_ref);
			return p_PresenceConstraint_ref;
		}

		//
		// create syntax tree node associated with production
		// PresenceConstraint: %empty

		//

		public PresenceConstraint PresenceConstraint_4 ()
		{
			PresenceConstraint p_PresenceConstraint_ref = new PresenceConstraint();
			Raise_PresenceConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, PresenceConstraint.production_kind.g_PresenceConstraint_4, p_PresenceConstraint_ref);
			return p_PresenceConstraint_ref;
		}
		#endregion
	};
}
