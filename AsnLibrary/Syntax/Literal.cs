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
	// class associated with syntax rule Literal
	//

	[DataContract]
	public class	Literal : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Literal
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Literal
		{
			g_Literal_1 = 1,	// typereference-token

			g_Literal_2 = 2,	// keyword

			g_Literal_3 = 3,	// ","

		};
		#endregion
		#region production markers associated with the syntax rule Literal

		// markers associated with production: Literal -> typereference-token

		public enum production_marker_1 : ushort
		{
			m_typereference_token,
			final
		};

		// markers associated with production: Literal -> keyword

		public enum production_marker_2 : ushort
		{
			m_keyword,
			final
		};

		// markers associated with production: Literal -> ","

		public enum production_marker_3 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Literal

		// Constructor declaration(s) associated with production(s) of syntax rule Literal

		//
		// Constructor associated with the following production(s)
		// Literal -> typereference-token

		//

		public Literal (typereference_token p_typereference_token) : base ((uint) ProductionID._Literal_ID, (uint) production_kind.g_Literal_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_typereference_token = p_typereference_token;
		}

		//
		// Constructor associated with the following production(s)
		// Literal -> keyword

		//

		public Literal (keyword p_keyword) : base ((uint) ProductionID._Literal_ID, (uint) production_kind.g_Literal_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_keyword = p_keyword;
		}

		//
		// Constructor associated with the following production(s)
		// Literal -> ","

		//

		public Literal (SyntaxTreeToken p_token) : base ((uint) ProductionID._Literal_ID, (uint) production_kind.g_Literal_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_comma = p_token;
		}

		public Literal () { }

		// Copy constructor

		public Literal (Literal p_Literal) : base (p_Literal.id, p_Literal.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Literal.appInfo;
			switch ((production_kind) p_Literal.kind)
			{
				case production_kind.g_Literal_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_typereference_token = (p_Literal.m_typereference_token != null) ? new typereference_token (p_Literal.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					break;
				case production_kind.g_Literal_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_keyword = (p_Literal.m_keyword != null) ? new keyword (p_Literal.m_keyword) : null) != null) m_keyword.parent = this;
					break;
				case production_kind.g_Literal_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_comma = (p_Literal.m_comma != null) ? new SyntaxTreeToken (p_Literal.m_comma) : null) != null) m_comma.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Literal" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Literal (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_typereference_token?.Dispose ();
			m_keyword?.Dispose ();
			m_comma?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Literal

		// Content changing function(s) associated with production(s) of syntax rule Literal

		//
		// Content changing function associated with following production(s)
		// Literal -> typereference-token

		//

		public void change(typereference_token p_typereference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_Literal_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_typereference_token = p_typereference_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Literal -> keyword

		//

		public void change(keyword p_keyword)
		{
			_init ();
			this.kind = (uint) production_kind.g_Literal_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_keyword = p_keyword;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Literal -> ","

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_Literal_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_comma = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Literal
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_typereference_token != null) && m_typereference_token.checkInclusion (element) ||
				(m_keyword != null) && m_keyword.checkInclusion (element) ||
				(m_comma != null) && m_comma.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Literal

		//
		// emit production tree node associated with any production of syntax rule Literal
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Literal_1:
					// emit syntax tree node associated with production
					// Literal: typereference-token

					s += m_typereference_token.Emit (depth - 1);
				break;
				case production_kind.g_Literal_2:
					// emit syntax tree node associated with production
					// Literal: keyword

					s += m_keyword.Emit (depth - 1);
				break;
				case production_kind.g_Literal_3:
					// emit syntax tree node associated with production
					// Literal: ","

					s += m_comma.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Literal
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Literal (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Literal_1:
					// emit syntax tree node associated with production
					// Literal: typereference-token

					s += m_typereference_token.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Literal_2:
					// emit syntax tree node associated with production
					// Literal: keyword

					s += m_keyword.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Literal_3:
					// emit syntax tree node associated with production
					// Literal: ","

					s += "comma";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Literal

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Literal with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Literal.production_kind kind = (Literal.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Literal.production_kind.g_Literal_1:
					// traverse syntax tree node associated with production
					// Literal: typereference-token

						m_typereference_token.Visit (visitor, appData);
				break;
				case Literal.production_kind.g_Literal_2:
					// traverse syntax tree node associated with production
					// Literal: keyword

						m_keyword.Visit (visitor, appData);
				break;
				case Literal.production_kind.g_Literal_3:
					// traverse syntax tree node associated with production
					// Literal: ","

						m_comma.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_typereference_token?.reparent (this);
			m_keyword?.reparent (this);
			m_comma?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Literal
		//

		public void _init ()
		{
			m_typereference_token = null;
			m_keyword = null;
			m_comma = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Literal

		// counter of all nodes associated with syntax rule Literal
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Literal
		[DataMember (Name = "m_typereference_token")] public typereference_token m_typereference_token { get; private set; }
		[DataMember (Name = "m_keyword")] public keyword m_keyword { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Literal

		// delegate function (callback) prototype associated with syntax rule Literal
		public delegate bool Literal_Callback (SyntaxTreeCallbackReason reason, Literal.production_kind kind, Literal p_Literal);

		// event associated with syntax rule Literal
		public event Literal_Callback Literal_Event;

		// event trigger associated with syntax rule Literal
		public bool Raise_Literal_Event (SyntaxTreeCallbackReason reason, Literal.production_kind kind, Literal p_Literal)
		{
			bool? status = Literal_Event?.Invoke (reason, kind, p_Literal);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Literal
		//
		// traverse syntax tree node associated with any production of syntax rule Literal
		//

		public void Traverse (Literal p_Literal)
		{
			if (p_Literal.isLocked())
				return;
			p_Literal.dolock();
			Literal.production_kind kind = (Literal.production_kind) p_Literal.kind;
			p_Literal.turn_reset ();
			if (Raise_Literal_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Literal))
			switch (kind)
			{
				case Literal.production_kind.g_Literal_1:
					// traverse syntax tree node associated with production
					// Literal: typereference-token

					if (Raise_Literal_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Literal))
						Traverse (p_Literal.m_typereference_token);
					p_Literal.turn_inc ();
					Raise_Literal_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Literal);
				break;
				case Literal.production_kind.g_Literal_2:
					// traverse syntax tree node associated with production
					// Literal: keyword

					if (Raise_Literal_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Literal))
						Traverse (p_Literal.m_keyword);
					p_Literal.turn_inc ();
					Raise_Literal_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Literal);
				break;
				case Literal.production_kind.g_Literal_3:
					// traverse syntax tree node associated with production
					// Literal: ","

				break;
			}
			Raise_Literal_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Literal);
			p_Literal.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Literal
		//

		public void TraverseCommon (Literal p_Literal)
		{
			Literal.production_kind kind = (Literal.production_kind) p_Literal.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Literal))
			switch (kind)
			{
				case Literal.production_kind.g_Literal_1:
					// traverse syntax tree node associated with production
					// Literal: typereference-token

						TraverseCommon (p_Literal.m_typereference_token);
				break;
				case Literal.production_kind.g_Literal_2:
					// traverse syntax tree node associated with production
					// Literal: keyword

						TraverseCommon (p_Literal.m_keyword);
				break;
				case Literal.production_kind.g_Literal_3:
					// traverse syntax tree node associated with production
					// Literal: ","

						TraverseCommon (p_Literal.m_comma);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Literal);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Literal

		//
		// create syntax tree node associated with production
		// Literal: typereference-token

		//

		public Literal Literal_1 (typereference_token p_typereference_token)
		{
			Literal p_Literal_ref = new Literal(p_typereference_token);
			p_typereference_token.parent = p_Literal_ref;
			Raise_Literal_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Literal.production_kind.g_Literal_1, p_Literal_ref);
			return p_Literal_ref;
		}

		//
		// create syntax tree node associated with production
		// Literal: keyword

		//

		public Literal Literal_2 (keyword p_keyword)
		{
			Literal p_Literal_ref = new Literal(p_keyword);
			p_keyword.parent = p_Literal_ref;
			Raise_Literal_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Literal.production_kind.g_Literal_2, p_Literal_ref);
			return p_Literal_ref;
		}

		//
		// create syntax tree node associated with production
		// Literal: ","

		//

		public Literal Literal_3 (SyntaxTreeToken p_token)
		{
			Literal p_Literal_ref = new Literal(p_token);
			p_token.parent = p_Literal_ref;
			Raise_Literal_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Literal.production_kind.g_Literal_3, p_Literal_ref);
			return p_Literal_ref;
		}
		#endregion
	};
}
