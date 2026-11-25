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
	// class associated with syntax rule UNIQUE-optional
	//

	[DataContract]
	public class	UNIQUE_optional : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule UNIQUE-optional
		public enum production_kind : ushort	// enumerated production(s) of syntax rule UNIQUE-optional
		{
			g_UNIQUE_optional_1 = 1,	// %empty

			g_UNIQUE_optional_2 = 2,	// UNIQUE

		};
		#endregion
		#region production markers associated with the syntax rule UNIQUE-optional

		// markers associated with production: UNIQUE-optional -> %empty

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: UNIQUE-optional -> UNIQUE

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule UNIQUE-optional

		// Constructor declaration(s) associated with production(s) of syntax rule UNIQUE-optional

		//
		// Constructor associated with the following production(s)
		// UNIQUE-optional -> %empty

		//

		public UNIQUE_optional () : base ((uint) ProductionID._UNIQUE_optional_ID, (uint) production_kind.g_UNIQUE_optional_1)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		//
		// Constructor associated with the following production(s)
		// UNIQUE-optional -> UNIQUE

		//

		public UNIQUE_optional (SyntaxTreeToken p_token) : base ((uint) ProductionID._UNIQUE_optional_ID, (uint) production_kind.g_UNIQUE_optional_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_UNIQUE = p_token;
		}

		// Copy constructor

		public UNIQUE_optional (UNIQUE_optional p_UNIQUE_optional) : base (p_UNIQUE_optional.id, p_UNIQUE_optional.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_UNIQUE_optional.appInfo;
			switch ((production_kind) p_UNIQUE_optional.kind)
			{
				case production_kind.g_UNIQUE_optional_1:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				case production_kind.g_UNIQUE_optional_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UNIQUE = (p_UNIQUE_optional.m_UNIQUE != null) ? new SyntaxTreeToken (p_UNIQUE_optional.m_UNIQUE) : null) != null) m_UNIQUE.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "UNIQUE_optional" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new UNIQUE_optional (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_UNIQUE?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule UNIQUE-optional

		// Content changing function(s) associated with production(s) of syntax rule UNIQUE-optional

		//
		// Content changing function associated with following production(s)
		// UNIQUE-optional -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_UNIQUE_optional_1;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// UNIQUE-optional -> UNIQUE

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_UNIQUE_optional_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_UNIQUE = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule UNIQUE-optional
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_UNIQUE != null) && m_UNIQUE.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule UNIQUE-optional

		//
		// emit production tree node associated with any production of syntax rule UNIQUE-optional
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_UNIQUE_optional_1:
					// emit syntax tree node associated with production
					// UNIQUE-optional: %empty

				break;
				case production_kind.g_UNIQUE_optional_2:
					// emit syntax tree node associated with production
					// UNIQUE-optional: UNIQUE

					s += m_UNIQUE.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule UNIQUE-optional
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "UNIQUE_optional (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_UNIQUE_optional_1:
					// emit syntax tree node associated with production
					// UNIQUE-optional: %empty

				break;
				case production_kind.g_UNIQUE_optional_2:
					// emit syntax tree node associated with production
					// UNIQUE-optional: UNIQUE

					s += "UNIQUE";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule UNIQUE-optional

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule UNIQUE-optional with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			UNIQUE_optional.production_kind kind = (UNIQUE_optional.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case UNIQUE_optional.production_kind.g_UNIQUE_optional_1:
					// traverse syntax tree node associated with production
					// UNIQUE-optional: %empty

				break;
				case UNIQUE_optional.production_kind.g_UNIQUE_optional_2:
					// traverse syntax tree node associated with production
					// UNIQUE-optional: UNIQUE

						m_UNIQUE.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_UNIQUE?.reparent (this);
		}

		//
		// initialize object associated with syntax rule UNIQUE-optional
		//

		public void _init ()
		{
			m_UNIQUE = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule UNIQUE-optional

		// counter of all nodes associated with syntax rule UNIQUE-optional
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule UNIQUE-optional
		[DataMember (Name = "m_UNIQUE")] public SyntaxTreeToken m_UNIQUE { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule UNIQUE-optional

		// delegate function (callback) prototype associated with syntax rule UNIQUE-optional
		public delegate bool UNIQUE_optional_Callback (SyntaxTreeCallbackReason reason, UNIQUE_optional.production_kind kind, UNIQUE_optional p_UNIQUE_optional);

		// event associated with syntax rule UNIQUE-optional
		public event UNIQUE_optional_Callback UNIQUE_optional_Event;

		// event trigger associated with syntax rule UNIQUE-optional
		public bool Raise_UNIQUE_optional_Event (SyntaxTreeCallbackReason reason, UNIQUE_optional.production_kind kind, UNIQUE_optional p_UNIQUE_optional)
		{
			bool? status = UNIQUE_optional_Event?.Invoke (reason, kind, p_UNIQUE_optional);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule UNIQUE-optional
		//
		// traverse syntax tree node associated with any production of syntax rule UNIQUE-optional
		//

		public void Traverse (UNIQUE_optional p_UNIQUE_optional)
		{
			if (p_UNIQUE_optional.isLocked())
				return;
			p_UNIQUE_optional.dolock();
			UNIQUE_optional.production_kind kind = (UNIQUE_optional.production_kind) p_UNIQUE_optional.kind;
			p_UNIQUE_optional.turn_reset ();
			if (Raise_UNIQUE_optional_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_UNIQUE_optional))
			switch (kind)
			{
				case UNIQUE_optional.production_kind.g_UNIQUE_optional_1:
					// traverse syntax tree node associated with production
					// UNIQUE-optional: %empty

				break;
				case UNIQUE_optional.production_kind.g_UNIQUE_optional_2:
					// traverse syntax tree node associated with production
					// UNIQUE-optional: UNIQUE

				break;
			}
			Raise_UNIQUE_optional_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_UNIQUE_optional);
			p_UNIQUE_optional.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule UNIQUE-optional
		//

		public void TraverseCommon (UNIQUE_optional p_UNIQUE_optional)
		{
			UNIQUE_optional.production_kind kind = (UNIQUE_optional.production_kind) p_UNIQUE_optional.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_UNIQUE_optional))
			switch (kind)
			{
				case UNIQUE_optional.production_kind.g_UNIQUE_optional_1:
					// traverse syntax tree node associated with production
					// UNIQUE-optional: %empty

				break;
				case UNIQUE_optional.production_kind.g_UNIQUE_optional_2:
					// traverse syntax tree node associated with production
					// UNIQUE-optional: UNIQUE

						TraverseCommon (p_UNIQUE_optional.m_UNIQUE);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_UNIQUE_optional);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule UNIQUE-optional

		//
		// create syntax tree node associated with production
		// UNIQUE-optional: %empty

		//

		public UNIQUE_optional UNIQUE_optional_1 ()
		{
			UNIQUE_optional p_UNIQUE_optional_ref = new UNIQUE_optional();
			Raise_UNIQUE_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UNIQUE_optional.production_kind.g_UNIQUE_optional_1, p_UNIQUE_optional_ref);
			return p_UNIQUE_optional_ref;
		}

		//
		// create syntax tree node associated with production
		// UNIQUE-optional: UNIQUE

		//

		public UNIQUE_optional UNIQUE_optional_2 (SyntaxTreeToken p_token)
		{
			UNIQUE_optional p_UNIQUE_optional_ref = new UNIQUE_optional(p_token);
			p_token.parent = p_UNIQUE_optional_ref;
			Raise_UNIQUE_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UNIQUE_optional.production_kind.g_UNIQUE_optional_2, p_UNIQUE_optional_ref);
			return p_UNIQUE_optional_ref;
		}
		#endregion
	};
}
