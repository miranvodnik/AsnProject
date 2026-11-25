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
	// class associated with syntax rule TextInteger
	//

	[DataContract]
	public class	TextInteger : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TextInteger
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TextInteger
		{
			g_TextInteger_1 = 1,	// identifier-token

		};
		#endregion
		#region production markers associated with the syntax rule TextInteger

		// markers associated with production: TextInteger -> identifier-token

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TextInteger

		// Constructor declaration(s) associated with production(s) of syntax rule TextInteger

		//
		// Constructor associated with the following production(s)
		// TextInteger -> identifier-token

		//

		public TextInteger (identifier_token p_identifier_token) : base ((uint) ProductionID._TextInteger_ID, (uint) production_kind.g_TextInteger_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_identifier_token = p_identifier_token;
		}

		public TextInteger () { }

		// Copy constructor

		public TextInteger (TextInteger p_TextInteger) : base (p_TextInteger.id, p_TextInteger.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TextInteger.appInfo;
			switch ((production_kind) p_TextInteger.kind)
			{
				case production_kind.g_TextInteger_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_identifier_token = (p_TextInteger.m_identifier_token != null) ? new identifier_token (p_TextInteger.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TextInteger" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TextInteger (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TextInteger

		// Content changing function(s) associated with production(s) of syntax rule TextInteger

		//
		// Content changing function associated with following production(s)
		// TextInteger -> identifier-token

		//

		public void change(identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_TextInteger_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TextInteger
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TextInteger

		//
		// emit production tree node associated with any production of syntax rule TextInteger
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TextInteger_1:
					// emit syntax tree node associated with production
					// TextInteger: identifier-token

					s += m_identifier_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TextInteger
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TextInteger (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TextInteger_1:
					// emit syntax tree node associated with production
					// TextInteger: identifier-token

					s += m_identifier_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TextInteger

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TextInteger with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TextInteger.production_kind kind = (TextInteger.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TextInteger.production_kind.g_TextInteger_1:
					// traverse syntax tree node associated with production
					// TextInteger: identifier-token

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
		// initialize object associated with syntax rule TextInteger
		//

		public void _init ()
		{
			m_identifier_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TextInteger

		// counter of all nodes associated with syntax rule TextInteger
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TextInteger
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TextInteger

		// delegate function (callback) prototype associated with syntax rule TextInteger
		public delegate bool TextInteger_Callback (SyntaxTreeCallbackReason reason, TextInteger.production_kind kind, TextInteger p_TextInteger);

		// event associated with syntax rule TextInteger
		public event TextInteger_Callback TextInteger_Event;

		// event trigger associated with syntax rule TextInteger
		public bool Raise_TextInteger_Event (SyntaxTreeCallbackReason reason, TextInteger.production_kind kind, TextInteger p_TextInteger)
		{
			bool? status = TextInteger_Event?.Invoke (reason, kind, p_TextInteger);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TextInteger
		//
		// traverse syntax tree node associated with any production of syntax rule TextInteger
		//

		public void Traverse (TextInteger p_TextInteger)
		{
			if (p_TextInteger.isLocked())
				return;
			p_TextInteger.dolock();
			TextInteger.production_kind kind = (TextInteger.production_kind) p_TextInteger.kind;
			p_TextInteger.turn_reset ();
			if (Raise_TextInteger_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TextInteger))
			switch (kind)
			{
				case TextInteger.production_kind.g_TextInteger_1:
					// traverse syntax tree node associated with production
					// TextInteger: identifier-token

					if (Raise_TextInteger_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TextInteger))
						Traverse (p_TextInteger.m_identifier_token);
					p_TextInteger.turn_inc ();
					Raise_TextInteger_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TextInteger);
				break;
			}
			Raise_TextInteger_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TextInteger);
			p_TextInteger.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TextInteger
		//

		public void TraverseCommon (TextInteger p_TextInteger)
		{
			TextInteger.production_kind kind = (TextInteger.production_kind) p_TextInteger.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TextInteger))
			switch (kind)
			{
				case TextInteger.production_kind.g_TextInteger_1:
					// traverse syntax tree node associated with production
					// TextInteger: identifier-token

						TraverseCommon (p_TextInteger.m_identifier_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TextInteger);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TextInteger

		//
		// create syntax tree node associated with production
		// TextInteger: identifier-token

		//

		public TextInteger TextInteger_1 (identifier_token p_identifier_token)
		{
			TextInteger p_TextInteger_ref = new TextInteger(p_identifier_token);
			p_identifier_token.parent = p_TextInteger_ref;
			Raise_TextInteger_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TextInteger.production_kind.g_TextInteger_1, p_TextInteger_ref);
			return p_TextInteger_ref;
		}
		#endregion
	};
}
