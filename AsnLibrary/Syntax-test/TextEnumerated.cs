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
	// class associated with syntax rule TextEnumerated
	//

	[DataContract]
	public class	TextEnumerated : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TextEnumerated
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TextEnumerated
		{
			g_TextEnumerated_1 = 1,	// identifier-token

		};
		#endregion
		#region production markers associated with the syntax rule TextEnumerated

		// markers associated with production: TextEnumerated -> identifier-token

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TextEnumerated

		// Constructor declaration(s) associated with production(s) of syntax rule TextEnumerated

		//
		// Constructor associated with the following production(s)
		// TextEnumerated -> identifier-token

		//

		public TextEnumerated (identifier_token p_identifier_token) : base ((uint) ProductionID._TextEnumerated_ID, (uint) production_kind.g_TextEnumerated_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_identifier_token = p_identifier_token;
		}

		public TextEnumerated () { }

		// Copy constructor

		public TextEnumerated (TextEnumerated p_TextEnumerated) : base (p_TextEnumerated.id, p_TextEnumerated.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TextEnumerated.appInfo;
			switch ((production_kind) p_TextEnumerated.kind)
			{
				case production_kind.g_TextEnumerated_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_identifier_token = (p_TextEnumerated.m_identifier_token != null) ? new identifier_token (p_TextEnumerated.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TextEnumerated" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TextEnumerated (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TextEnumerated

		// Content changing function(s) associated with production(s) of syntax rule TextEnumerated

		//
		// Content changing function associated with following production(s)
		// TextEnumerated -> identifier-token

		//

		public void change(identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_TextEnumerated_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TextEnumerated
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TextEnumerated

		//
		// emit production tree node associated with any production of syntax rule TextEnumerated
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TextEnumerated_1:
					// emit syntax tree node associated with production
					// TextEnumerated: identifier-token

					s += m_identifier_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TextEnumerated
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TextEnumerated (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TextEnumerated_1:
					// emit syntax tree node associated with production
					// TextEnumerated: identifier-token

					s += m_identifier_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TextEnumerated

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TextEnumerated with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TextEnumerated.production_kind kind = (TextEnumerated.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TextEnumerated.production_kind.g_TextEnumerated_1:
					// traverse syntax tree node associated with production
					// TextEnumerated: identifier-token

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
		// initialize object associated with syntax rule TextEnumerated
		//

		public void _init ()
		{
			m_identifier_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TextEnumerated

		// counter of all nodes associated with syntax rule TextEnumerated
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TextEnumerated
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TextEnumerated

		// delegate function (callback) prototype associated with syntax rule TextEnumerated
		public delegate bool TextEnumerated_Callback (SyntaxTreeCallbackReason reason, TextEnumerated.production_kind kind, TextEnumerated p_TextEnumerated);

		// event associated with syntax rule TextEnumerated
		public event TextEnumerated_Callback TextEnumerated_Event;

		// event trigger associated with syntax rule TextEnumerated
		public bool Raise_TextEnumerated_Event (SyntaxTreeCallbackReason reason, TextEnumerated.production_kind kind, TextEnumerated p_TextEnumerated)
		{
			bool? status = TextEnumerated_Event?.Invoke (reason, kind, p_TextEnumerated);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TextEnumerated
		//
		// traverse syntax tree node associated with any production of syntax rule TextEnumerated
		//

		public void Traverse (TextEnumerated p_TextEnumerated)
		{
			if (p_TextEnumerated.isLocked())
				return;
			p_TextEnumerated.dolock();
			TextEnumerated.production_kind kind = (TextEnumerated.production_kind) p_TextEnumerated.kind;
			p_TextEnumerated.turn_reset ();
			if (Raise_TextEnumerated_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TextEnumerated))
			switch (kind)
			{
				case TextEnumerated.production_kind.g_TextEnumerated_1:
					// traverse syntax tree node associated with production
					// TextEnumerated: identifier-token

					if (Raise_TextEnumerated_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TextEnumerated))
						Traverse (p_TextEnumerated.m_identifier_token);
					p_TextEnumerated.turn_inc ();
					Raise_TextEnumerated_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TextEnumerated);
				break;
			}
			Raise_TextEnumerated_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TextEnumerated);
			p_TextEnumerated.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TextEnumerated
		//

		public void TraverseCommon (TextEnumerated p_TextEnumerated)
		{
			TextEnumerated.production_kind kind = (TextEnumerated.production_kind) p_TextEnumerated.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TextEnumerated))
			switch (kind)
			{
				case TextEnumerated.production_kind.g_TextEnumerated_1:
					// traverse syntax tree node associated with production
					// TextEnumerated: identifier-token

						TraverseCommon (p_TextEnumerated.m_identifier_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TextEnumerated);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TextEnumerated

		//
		// create syntax tree node associated with production
		// TextEnumerated: identifier-token

		//

		public TextEnumerated TextEnumerated_1 (identifier_token p_identifier_token)
		{
			TextEnumerated p_TextEnumerated_ref = new TextEnumerated(p_identifier_token);
			p_identifier_token.parent = p_TextEnumerated_ref;
			Raise_TextEnumerated_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TextEnumerated.production_kind.g_TextEnumerated_1, p_TextEnumerated_ref);
			return p_TextEnumerated_ref;
		}
		#endregion
	};
}
