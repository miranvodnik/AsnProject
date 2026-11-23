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
	// class associated with syntax rule TextBoolean
	//

	[DataContract]
	public class	TextBoolean : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TextBoolean
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TextBoolean
		{
			g_TextBoolean_1 = 1,	// extended-true

			g_TextBoolean_2 = 2,	// extended-false

		};
		#endregion
		#region production markers associated with the syntax rule TextBoolean

		// markers associated with production: TextBoolean -> extended-true

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: TextBoolean -> extended-false

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TextBoolean

		// Constructor declaration(s) associated with production(s) of syntax rule TextBoolean

		//
		// Constructor associated with the following production(s)
		// TextBoolean -> extended-true

		// TextBoolean -> extended-false

		//

		public TextBoolean (SyntaxTreeToken p_token, int kind) : base ((uint) ProductionID._TextBoolean_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_TextBoolean_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_extended_true = p_token;
				break;
			case production_kind.g_TextBoolean_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_extended_false = p_token;
				break;
			default:
				{
					string[] args = new string[] { "TextBoolean" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		public TextBoolean () { }

		// Copy constructor

		public TextBoolean (TextBoolean p_TextBoolean) : base (p_TextBoolean.id, p_TextBoolean.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TextBoolean.appInfo;
			switch ((production_kind) p_TextBoolean.kind)
			{
				case production_kind.g_TextBoolean_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_extended_true = (p_TextBoolean.m_extended_true != null) ? new SyntaxTreeToken (p_TextBoolean.m_extended_true) : null) != null) m_extended_true.parent = this;
					break;
				case production_kind.g_TextBoolean_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_extended_false = (p_TextBoolean.m_extended_false != null) ? new SyntaxTreeToken (p_TextBoolean.m_extended_false) : null) != null) m_extended_false.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TextBoolean" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TextBoolean (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_extended_true?.Dispose ();
			m_extended_false?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TextBoolean

		// Content changing function(s) associated with production(s) of syntax rule TextBoolean

		//
		// Content changing function associated with following production(s)
		// TextBoolean -> extended-true

		// TextBoolean -> extended-false

		//

		public void change(SyntaxTreeToken p_token, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_TextBoolean_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_extended_true = p_token;
				break;
			case production_kind.g_TextBoolean_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_extended_false = p_token;
				break;
			default:
				{
					string[] args = new string[] { "TextBoolean" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TextBoolean
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_extended_true != null) && m_extended_true.checkInclusion (element) ||
				(m_extended_false != null) && m_extended_false.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TextBoolean

		//
		// emit production tree node associated with any production of syntax rule TextBoolean
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TextBoolean_1:
					// emit syntax tree node associated with production
					// TextBoolean: extended-true

					s += m_extended_true.Emit (depth - 1);
				break;
				case production_kind.g_TextBoolean_2:
					// emit syntax tree node associated with production
					// TextBoolean: extended-false

					s += m_extended_false.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TextBoolean
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TextBoolean (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TextBoolean_1:
					// emit syntax tree node associated with production
					// TextBoolean: extended-true

					s += "extended_true";
				break;
				case production_kind.g_TextBoolean_2:
					// emit syntax tree node associated with production
					// TextBoolean: extended-false

					s += "extended_false";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TextBoolean

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TextBoolean with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TextBoolean.production_kind kind = (TextBoolean.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TextBoolean.production_kind.g_TextBoolean_1:
					// traverse syntax tree node associated with production
					// TextBoolean: extended-true

						m_extended_true.Visit (visitor, appData);
				break;
				case TextBoolean.production_kind.g_TextBoolean_2:
					// traverse syntax tree node associated with production
					// TextBoolean: extended-false

						m_extended_false.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_extended_true?.reparent (this);
			m_extended_false?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TextBoolean
		//

		public void _init ()
		{
			m_extended_true = null;
			m_extended_false = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TextBoolean

		// counter of all nodes associated with syntax rule TextBoolean
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TextBoolean
		[DataMember (Name = "m_extended_true")] public SyntaxTreeToken m_extended_true { get; private set; }
		[DataMember (Name = "m_extended_false")] public SyntaxTreeToken m_extended_false { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TextBoolean

		// delegate function (callback) prototype associated with syntax rule TextBoolean
		public delegate bool TextBoolean_Callback (SyntaxTreeCallbackReason reason, TextBoolean.production_kind kind, TextBoolean p_TextBoolean);

		// event associated with syntax rule TextBoolean
		public event TextBoolean_Callback TextBoolean_Event;

		// event trigger associated with syntax rule TextBoolean
		public bool Raise_TextBoolean_Event (SyntaxTreeCallbackReason reason, TextBoolean.production_kind kind, TextBoolean p_TextBoolean)
		{
			bool? status = TextBoolean_Event?.Invoke (reason, kind, p_TextBoolean);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TextBoolean
		//
		// traverse syntax tree node associated with any production of syntax rule TextBoolean
		//

		public void Traverse (TextBoolean p_TextBoolean)
		{
			if (p_TextBoolean.isLocked())
				return;
			p_TextBoolean.dolock();
			TextBoolean.production_kind kind = (TextBoolean.production_kind) p_TextBoolean.kind;
			p_TextBoolean.turn_reset ();
			if (Raise_TextBoolean_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TextBoolean))
			switch (kind)
			{
				case TextBoolean.production_kind.g_TextBoolean_1:
					// traverse syntax tree node associated with production
					// TextBoolean: extended-true

				break;
				case TextBoolean.production_kind.g_TextBoolean_2:
					// traverse syntax tree node associated with production
					// TextBoolean: extended-false

				break;
			}
			Raise_TextBoolean_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TextBoolean);
			p_TextBoolean.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TextBoolean
		//

		public void TraverseCommon (TextBoolean p_TextBoolean)
		{
			TextBoolean.production_kind kind = (TextBoolean.production_kind) p_TextBoolean.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TextBoolean))
			switch (kind)
			{
				case TextBoolean.production_kind.g_TextBoolean_1:
					// traverse syntax tree node associated with production
					// TextBoolean: extended-true

						TraverseCommon (p_TextBoolean.m_extended_true);
				break;
				case TextBoolean.production_kind.g_TextBoolean_2:
					// traverse syntax tree node associated with production
					// TextBoolean: extended-false

						TraverseCommon (p_TextBoolean.m_extended_false);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TextBoolean);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TextBoolean

		//
		// create syntax tree node associated with production
		// TextBoolean: extended-true

		//

		public TextBoolean TextBoolean_1 (SyntaxTreeToken p_token)
		{
			TextBoolean p_TextBoolean_ref = new TextBoolean(p_token, 1);
			p_token.parent = p_TextBoolean_ref;
			Raise_TextBoolean_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TextBoolean.production_kind.g_TextBoolean_1, p_TextBoolean_ref);
			return p_TextBoolean_ref;
		}

		//
		// create syntax tree node associated with production
		// TextBoolean: extended-false

		//

		public TextBoolean TextBoolean_2 (SyntaxTreeToken p_token)
		{
			TextBoolean p_TextBoolean_ref = new TextBoolean(p_token, 2);
			p_token.parent = p_TextBoolean_ref;
			Raise_TextBoolean_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TextBoolean.production_kind.g_TextBoolean_2, p_TextBoolean_ref);
			return p_TextBoolean_ref;
		}
		#endregion
	};
}
