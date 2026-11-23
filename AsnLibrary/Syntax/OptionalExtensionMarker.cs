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
	// class associated with syntax rule OptionalExtensionMarker
	//

	[DataContract]
	public class	OptionalExtensionMarker : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OptionalExtensionMarker
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OptionalExtensionMarker
		{
			g_OptionalExtensionMarker_1 = 1,	// "," "." "." "."

			g_OptionalExtensionMarker_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule OptionalExtensionMarker

		// markers associated with production: OptionalExtensionMarker -> "," "." "." "."

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: OptionalExtensionMarker -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OptionalExtensionMarker

		// Constructor declaration(s) associated with production(s) of syntax rule OptionalExtensionMarker

		//
		// Constructor associated with the following production(s)
		// OptionalExtensionMarker -> "," "." "." "."

		//

		public OptionalExtensionMarker (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3) : base ((uint) ProductionID._OptionalExtensionMarker_ID, (uint) production_kind.g_OptionalExtensionMarker_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_comma = p_token;
			children[1] = m_dot = p_token_1;
			children[2] = m_dot_1 = p_token_2;
			children[3] = m_dot_2 = p_token_3;
		}

		//
		// Constructor associated with the following production(s)
		// OptionalExtensionMarker -> %empty

		//

		public OptionalExtensionMarker () : base ((uint) ProductionID._OptionalExtensionMarker_ID, (uint) production_kind.g_OptionalExtensionMarker_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public OptionalExtensionMarker (OptionalExtensionMarker p_OptionalExtensionMarker) : base (p_OptionalExtensionMarker.id, p_OptionalExtensionMarker.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OptionalExtensionMarker.appInfo;
			switch ((production_kind) p_OptionalExtensionMarker.kind)
			{
				case production_kind.g_OptionalExtensionMarker_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_comma = (p_OptionalExtensionMarker.m_comma != null) ? new SyntaxTreeToken (p_OptionalExtensionMarker.m_comma) : null) != null) m_comma.parent = this;
					if ((children [1] = m_dot = (p_OptionalExtensionMarker.m_dot != null) ? new SyntaxTreeToken (p_OptionalExtensionMarker.m_dot) : null) != null) m_dot.parent = this;
					if ((children [2] = m_dot_1 = (p_OptionalExtensionMarker.m_dot_1 != null) ? new SyntaxTreeToken (p_OptionalExtensionMarker.m_dot_1) : null) != null) m_dot_1.parent = this;
					if ((children [3] = m_dot_2 = (p_OptionalExtensionMarker.m_dot_2 != null) ? new SyntaxTreeToken (p_OptionalExtensionMarker.m_dot_2) : null) != null) m_dot_2.parent = this;
					break;
				case production_kind.g_OptionalExtensionMarker_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "OptionalExtensionMarker" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OptionalExtensionMarker (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_comma?.Dispose ();
			m_dot?.Dispose ();
			m_dot_1?.Dispose ();
			m_dot_2?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OptionalExtensionMarker

		// Content changing function(s) associated with production(s) of syntax rule OptionalExtensionMarker

		//
		// Content changing function associated with following production(s)
		// OptionalExtensionMarker -> "," "." "." "."

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3)
		{
			_init ();
			this.kind = (uint) production_kind.g_OptionalExtensionMarker_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_comma = p_token;
			children [1] = m_dot = p_token_1;
			children [2] = m_dot_1 = p_token_2;
			children [3] = m_dot_2 = p_token_3;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// OptionalExtensionMarker -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_OptionalExtensionMarker_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OptionalExtensionMarker
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_comma != null) && m_comma.checkInclusion (element) ||
				(m_dot != null) && m_dot.checkInclusion (element) ||
				(m_dot_1 != null) && m_dot_1.checkInclusion (element) ||
				(m_dot_2 != null) && m_dot_2.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OptionalExtensionMarker

		//
		// emit production tree node associated with any production of syntax rule OptionalExtensionMarker
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_OptionalExtensionMarker_1:
					// emit syntax tree node associated with production
					// OptionalExtensionMarker: "," "." "." "."

					s += m_comma.Emit (depth - 1);
					s += " ";
					s += m_dot.Emit (depth - 1);
					s += " ";
					s += m_dot_1.Emit (depth - 1);
					s += " ";
					s += m_dot_2.Emit (depth - 1);
				break;
				case production_kind.g_OptionalExtensionMarker_2:
					// emit syntax tree node associated with production
					// OptionalExtensionMarker: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OptionalExtensionMarker
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "OptionalExtensionMarker (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_OptionalExtensionMarker_1:
					// emit syntax tree node associated with production
					// OptionalExtensionMarker: "," "." "." "."

					s += "comma";
					s += ' ';
					s += "dot";
					s += ' ';
					s += "dot";
					s += ' ';
					s += "dot";
				break;
				case production_kind.g_OptionalExtensionMarker_2:
					// emit syntax tree node associated with production
					// OptionalExtensionMarker: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OptionalExtensionMarker

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OptionalExtensionMarker with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			OptionalExtensionMarker.production_kind kind = (OptionalExtensionMarker.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case OptionalExtensionMarker.production_kind.g_OptionalExtensionMarker_1:
					// traverse syntax tree node associated with production
					// OptionalExtensionMarker: "," "." "." "."

						m_comma.Visit (visitor, appData);
						m_dot.Visit (visitor, appData);
						m_dot_1.Visit (visitor, appData);
						m_dot_2.Visit (visitor, appData);
				break;
				case OptionalExtensionMarker.production_kind.g_OptionalExtensionMarker_2:
					// traverse syntax tree node associated with production
					// OptionalExtensionMarker: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_comma?.reparent (this);
			m_dot?.reparent (this);
			m_dot_1?.reparent (this);

			m_dot_2?.reparent (this);

		}

		//
		// initialize object associated with syntax rule OptionalExtensionMarker
		//

		public void _init ()
		{
			m_comma = null;
			m_dot = null;
			m_dot_1 = null;
			m_dot_2 = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OptionalExtensionMarker

		// counter of all nodes associated with syntax rule OptionalExtensionMarker
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OptionalExtensionMarker
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		[DataMember (Name = "m_dot")] public SyntaxTreeToken m_dot { get; private set; }
		[DataMember (Name = "m_dot_1")] public SyntaxTreeToken m_dot_1 { get; private set; }
		[DataMember (Name = "m_dot_2")] public SyntaxTreeToken m_dot_2 { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OptionalExtensionMarker

		// delegate function (callback) prototype associated with syntax rule OptionalExtensionMarker
		public delegate bool OptionalExtensionMarker_Callback (SyntaxTreeCallbackReason reason, OptionalExtensionMarker.production_kind kind, OptionalExtensionMarker p_OptionalExtensionMarker);

		// event associated with syntax rule OptionalExtensionMarker
		public event OptionalExtensionMarker_Callback OptionalExtensionMarker_Event;

		// event trigger associated with syntax rule OptionalExtensionMarker
		public bool Raise_OptionalExtensionMarker_Event (SyntaxTreeCallbackReason reason, OptionalExtensionMarker.production_kind kind, OptionalExtensionMarker p_OptionalExtensionMarker)
		{
			bool? status = OptionalExtensionMarker_Event?.Invoke (reason, kind, p_OptionalExtensionMarker);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OptionalExtensionMarker
		//
		// traverse syntax tree node associated with any production of syntax rule OptionalExtensionMarker
		//

		public void Traverse (OptionalExtensionMarker p_OptionalExtensionMarker)
		{
			if (p_OptionalExtensionMarker.isLocked())
				return;
			p_OptionalExtensionMarker.dolock();
			OptionalExtensionMarker.production_kind kind = (OptionalExtensionMarker.production_kind) p_OptionalExtensionMarker.kind;
			p_OptionalExtensionMarker.turn_reset ();
			if (Raise_OptionalExtensionMarker_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_OptionalExtensionMarker))
			switch (kind)
			{
				case OptionalExtensionMarker.production_kind.g_OptionalExtensionMarker_1:
					// traverse syntax tree node associated with production
					// OptionalExtensionMarker: "," "." "." "."

				break;
				case OptionalExtensionMarker.production_kind.g_OptionalExtensionMarker_2:
					// traverse syntax tree node associated with production
					// OptionalExtensionMarker: %empty

				break;
			}
			Raise_OptionalExtensionMarker_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_OptionalExtensionMarker);
			p_OptionalExtensionMarker.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OptionalExtensionMarker
		//

		public void TraverseCommon (OptionalExtensionMarker p_OptionalExtensionMarker)
		{
			OptionalExtensionMarker.production_kind kind = (OptionalExtensionMarker.production_kind) p_OptionalExtensionMarker.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_OptionalExtensionMarker))
			switch (kind)
			{
				case OptionalExtensionMarker.production_kind.g_OptionalExtensionMarker_1:
					// traverse syntax tree node associated with production
					// OptionalExtensionMarker: "," "." "." "."

						TraverseCommon (p_OptionalExtensionMarker.m_comma);
						TraverseCommon (p_OptionalExtensionMarker.m_dot);
						TraverseCommon (p_OptionalExtensionMarker.m_dot_1);
						TraverseCommon (p_OptionalExtensionMarker.m_dot_2);
				break;
				case OptionalExtensionMarker.production_kind.g_OptionalExtensionMarker_2:
					// traverse syntax tree node associated with production
					// OptionalExtensionMarker: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_OptionalExtensionMarker);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OptionalExtensionMarker

		//
		// create syntax tree node associated with production
		// OptionalExtensionMarker: "," "." "." "."

		//

		public OptionalExtensionMarker OptionalExtensionMarker_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3)
		{
			OptionalExtensionMarker p_OptionalExtensionMarker_ref = new OptionalExtensionMarker(p_token, p_token_1, p_token_2, p_token_3);
			p_token.parent = p_OptionalExtensionMarker_ref;
			p_token_1.parent = p_OptionalExtensionMarker_ref;
			p_token_2.parent = p_OptionalExtensionMarker_ref;
			p_token_3.parent = p_OptionalExtensionMarker_ref;
			Raise_OptionalExtensionMarker_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OptionalExtensionMarker.production_kind.g_OptionalExtensionMarker_1, p_OptionalExtensionMarker_ref);
			return p_OptionalExtensionMarker_ref;
		}

		//
		// create syntax tree node associated with production
		// OptionalExtensionMarker: %empty

		//

		public OptionalExtensionMarker OptionalExtensionMarker_2 ()
		{
			OptionalExtensionMarker p_OptionalExtensionMarker_ref = new OptionalExtensionMarker();
			Raise_OptionalExtensionMarker_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OptionalExtensionMarker.production_kind.g_OptionalExtensionMarker_2, p_OptionalExtensionMarker_ref);
			return p_OptionalExtensionMarker_ref;
		}
		#endregion
	};
}
