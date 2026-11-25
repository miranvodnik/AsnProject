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
	// class associated with syntax rule identifier-token-optional
	//

	[DataContract]
	public class	identifier_token_optional : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule identifier-token-optional
		public enum production_kind : ushort	// enumerated production(s) of syntax rule identifier-token-optional
		{
			g_identifier_token_optional_1 = 1,	// %empty

			g_identifier_token_optional_2 = 2,	// identifier-token

		};
		#endregion
		#region production markers associated with the syntax rule identifier-token-optional

		// markers associated with production: identifier-token-optional -> %empty

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: identifier-token-optional -> identifier-token

		public enum production_marker_2 : ushort
		{
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule identifier-token-optional

		// Constructor declaration(s) associated with production(s) of syntax rule identifier-token-optional

		//
		// Constructor associated with the following production(s)
		// identifier-token-optional -> %empty

		//

		public identifier_token_optional () : base ((uint) ProductionID._identifier_token_optional_ID, (uint) production_kind.g_identifier_token_optional_1)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		//
		// Constructor associated with the following production(s)
		// identifier-token-optional -> identifier-token

		//

		public identifier_token_optional (identifier_token p_identifier_token) : base ((uint) ProductionID._identifier_token_optional_ID, (uint) production_kind.g_identifier_token_optional_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_identifier_token = p_identifier_token;
		}

		// Copy constructor

		public identifier_token_optional (identifier_token_optional p_identifier_token_optional) : base (p_identifier_token_optional.id, p_identifier_token_optional.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_identifier_token_optional.appInfo;
			switch ((production_kind) p_identifier_token_optional.kind)
			{
				case production_kind.g_identifier_token_optional_1:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				case production_kind.g_identifier_token_optional_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_identifier_token = (p_identifier_token_optional.m_identifier_token != null) ? new identifier_token (p_identifier_token_optional.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "identifier_token_optional" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new identifier_token_optional (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule identifier-token-optional

		// Content changing function(s) associated with production(s) of syntax rule identifier-token-optional

		//
		// Content changing function associated with following production(s)
		// identifier-token-optional -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_identifier_token_optional_1;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// identifier-token-optional -> identifier-token

		//

		public void change(identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_identifier_token_optional_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule identifier-token-optional
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule identifier-token-optional

		//
		// emit production tree node associated with any production of syntax rule identifier-token-optional
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_identifier_token_optional_1:
					// emit syntax tree node associated with production
					// identifier-token-optional: %empty

				break;
				case production_kind.g_identifier_token_optional_2:
					// emit syntax tree node associated with production
					// identifier-token-optional: identifier-token

					s += m_identifier_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule identifier-token-optional
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "identifier_token_optional (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_identifier_token_optional_1:
					// emit syntax tree node associated with production
					// identifier-token-optional: %empty

				break;
				case production_kind.g_identifier_token_optional_2:
					// emit syntax tree node associated with production
					// identifier-token-optional: identifier-token

					s += m_identifier_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule identifier-token-optional

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule identifier-token-optional with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			identifier_token_optional.production_kind kind = (identifier_token_optional.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case identifier_token_optional.production_kind.g_identifier_token_optional_1:
					// traverse syntax tree node associated with production
					// identifier-token-optional: %empty

				break;
				case identifier_token_optional.production_kind.g_identifier_token_optional_2:
					// traverse syntax tree node associated with production
					// identifier-token-optional: identifier-token

						m_identifier_token.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_identifier_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule identifier-token-optional
		//

		public void _init ()
		{
			m_identifier_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule identifier-token-optional

		// counter of all nodes associated with syntax rule identifier-token-optional
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule identifier-token-optional
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule identifier-token-optional

		// delegate function (callback) prototype associated with syntax rule identifier-token-optional
		public delegate bool identifier_token_optional_Callback (SyntaxTreeCallbackReason reason, identifier_token_optional.production_kind kind, identifier_token_optional p_identifier_token_optional);

		// event associated with syntax rule identifier-token-optional
		public event identifier_token_optional_Callback identifier_token_optional_Event;

		// event trigger associated with syntax rule identifier-token-optional
		public bool Raise_identifier_token_optional_Event (SyntaxTreeCallbackReason reason, identifier_token_optional.production_kind kind, identifier_token_optional p_identifier_token_optional)
		{
			bool? status = identifier_token_optional_Event?.Invoke (reason, kind, p_identifier_token_optional);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule identifier-token-optional
		//
		// traverse syntax tree node associated with any production of syntax rule identifier-token-optional
		//

		public void Traverse (identifier_token_optional p_identifier_token_optional)
		{
			if (p_identifier_token_optional.isLocked())
				return;
			p_identifier_token_optional.dolock();
			identifier_token_optional.production_kind kind = (identifier_token_optional.production_kind) p_identifier_token_optional.kind;
			p_identifier_token_optional.turn_reset ();
			if (Raise_identifier_token_optional_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_identifier_token_optional))
			switch (kind)
			{
				case identifier_token_optional.production_kind.g_identifier_token_optional_1:
					// traverse syntax tree node associated with production
					// identifier-token-optional: %empty

				break;
				case identifier_token_optional.production_kind.g_identifier_token_optional_2:
					// traverse syntax tree node associated with production
					// identifier-token-optional: identifier-token

					if (Raise_identifier_token_optional_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_identifier_token_optional))
						Traverse (p_identifier_token_optional.m_identifier_token);
					p_identifier_token_optional.turn_inc ();
					Raise_identifier_token_optional_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_identifier_token_optional);
				break;
			}
			Raise_identifier_token_optional_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_identifier_token_optional);
			p_identifier_token_optional.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule identifier-token-optional
		//

		public void TraverseCommon (identifier_token_optional p_identifier_token_optional)
		{
			identifier_token_optional.production_kind kind = (identifier_token_optional.production_kind) p_identifier_token_optional.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_identifier_token_optional))
			switch (kind)
			{
				case identifier_token_optional.production_kind.g_identifier_token_optional_1:
					// traverse syntax tree node associated with production
					// identifier-token-optional: %empty

				break;
				case identifier_token_optional.production_kind.g_identifier_token_optional_2:
					// traverse syntax tree node associated with production
					// identifier-token-optional: identifier-token

						TraverseCommon (p_identifier_token_optional.m_identifier_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_identifier_token_optional);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule identifier-token-optional

		//
		// create syntax tree node associated with production
		// identifier-token-optional: %empty

		//

		public identifier_token_optional identifier_token_optional_1 ()
		{
			identifier_token_optional p_identifier_token_optional_ref = new identifier_token_optional();
			Raise_identifier_token_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, identifier_token_optional.production_kind.g_identifier_token_optional_1, p_identifier_token_optional_ref);
			return p_identifier_token_optional_ref;
		}

		//
		// create syntax tree node associated with production
		// identifier-token-optional: identifier-token

		//

		public identifier_token_optional identifier_token_optional_2 (identifier_token p_identifier_token)
		{
			identifier_token_optional p_identifier_token_optional_ref = new identifier_token_optional(p_identifier_token);
			p_identifier_token.parent = p_identifier_token_optional_ref;
			Raise_identifier_token_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, identifier_token_optional.production_kind.g_identifier_token_optional_2, p_identifier_token_optional_ref);
			return p_identifier_token_optional_ref;
		}
		#endregion
	};
}
