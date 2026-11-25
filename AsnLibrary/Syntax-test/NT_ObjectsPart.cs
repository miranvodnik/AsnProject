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
	// class associated with syntax rule NT-ObjectsPart
	//

	[DataContract]
	public class	NT_ObjectsPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NT-ObjectsPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NT-ObjectsPart
		{
			g_NT_ObjectsPart_1 = 1,	// OBJECTS "{" NT-Objects "}"

			g_NT_ObjectsPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule NT-ObjectsPart

		// markers associated with production: NT-ObjectsPart -> OBJECTS "{" NT-Objects "}"

		public enum production_marker_1 : ushort
		{
			m_NT_Objects,
			final
		};

		// markers associated with production: NT-ObjectsPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NT-ObjectsPart

		// Constructor declaration(s) associated with production(s) of syntax rule NT-ObjectsPart

		//
		// Constructor associated with the following production(s)
		// NT-ObjectsPart -> OBJECTS "{" NT-Objects "}"

		//

		public NT_ObjectsPart (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, NT_Objects p_NT_Objects, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._NT_ObjectsPart_ID, (uint) production_kind.g_NT_ObjectsPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_OBJECTS = p_token;
			children[1] = m_left_curly_bracket = p_token_1;
			children[2] = m_NT_Objects = p_NT_Objects;
			children[3] = m_right_curly_bracket = p_token_2;
		}

		//
		// Constructor associated with the following production(s)
		// NT-ObjectsPart -> %empty

		//

		public NT_ObjectsPart () : base ((uint) ProductionID._NT_ObjectsPart_ID, (uint) production_kind.g_NT_ObjectsPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public NT_ObjectsPart (NT_ObjectsPart p_NT_ObjectsPart) : base (p_NT_ObjectsPart.id, p_NT_ObjectsPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NT_ObjectsPart.appInfo;
			switch ((production_kind) p_NT_ObjectsPart.kind)
			{
				case production_kind.g_NT_ObjectsPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_OBJECTS = (p_NT_ObjectsPart.m_OBJECTS != null) ? new SyntaxTreeToken (p_NT_ObjectsPart.m_OBJECTS) : null) != null) m_OBJECTS.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_NT_ObjectsPart.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_NT_ObjectsPart.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_NT_Objects = (p_NT_ObjectsPart.m_NT_Objects != null) ? new NT_Objects (p_NT_ObjectsPart.m_NT_Objects) : null) != null) m_NT_Objects.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_NT_ObjectsPart.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_NT_ObjectsPart.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				case production_kind.g_NT_ObjectsPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "NT_ObjectsPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NT_ObjectsPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_OBJECTS?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_NT_Objects?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NT-ObjectsPart

		// Content changing function(s) associated with production(s) of syntax rule NT-ObjectsPart

		//
		// Content changing function associated with following production(s)
		// NT-ObjectsPart -> OBJECTS "{" NT-Objects "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, NT_Objects p_NT_Objects, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_NT_ObjectsPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_OBJECTS = p_token;
			children [1] = m_left_curly_bracket = p_token_1;
			children [2] = m_NT_Objects = p_NT_Objects;
			children [3] = m_right_curly_bracket = p_token_2;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// NT-ObjectsPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_NT_ObjectsPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NT-ObjectsPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_OBJECTS != null) && m_OBJECTS.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_NT_Objects != null) && m_NT_Objects.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NT-ObjectsPart

		//
		// emit production tree node associated with any production of syntax rule NT-ObjectsPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NT_ObjectsPart_1:
					// emit syntax tree node associated with production
					// NT-ObjectsPart: OBJECTS "{" NT-Objects "}"

					s += m_OBJECTS.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_NT_Objects.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
				case production_kind.g_NT_ObjectsPart_2:
					// emit syntax tree node associated with production
					// NT-ObjectsPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NT-ObjectsPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NT_ObjectsPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NT_ObjectsPart_1:
					// emit syntax tree node associated with production
					// NT-ObjectsPart: OBJECTS "{" NT-Objects "}"

					s += "OBJECTS";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_NT_Objects.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
				case production_kind.g_NT_ObjectsPart_2:
					// emit syntax tree node associated with production
					// NT-ObjectsPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NT-ObjectsPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NT-ObjectsPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NT_ObjectsPart.production_kind kind = (NT_ObjectsPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NT_ObjectsPart.production_kind.g_NT_ObjectsPart_1:
					// traverse syntax tree node associated with production
					// NT-ObjectsPart: OBJECTS "{" NT-Objects "}"

						m_OBJECTS.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_NT_Objects.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
				case NT_ObjectsPart.production_kind.g_NT_ObjectsPart_2:
					// traverse syntax tree node associated with production
					// NT-ObjectsPart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_OBJECTS?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_NT_Objects?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule NT-ObjectsPart
		//

		public void _init ()
		{
			m_OBJECTS = null;
			m_left_curly_bracket = null;
			m_NT_Objects = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NT-ObjectsPart

		// counter of all nodes associated with syntax rule NT-ObjectsPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NT-ObjectsPart
		[DataMember (Name = "m_OBJECTS")] public SyntaxTreeToken m_OBJECTS { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_NT_Objects")] public NT_Objects m_NT_Objects { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NT-ObjectsPart

		// delegate function (callback) prototype associated with syntax rule NT-ObjectsPart
		public delegate bool NT_ObjectsPart_Callback (SyntaxTreeCallbackReason reason, NT_ObjectsPart.production_kind kind, NT_ObjectsPart p_NT_ObjectsPart);

		// event associated with syntax rule NT-ObjectsPart
		public event NT_ObjectsPart_Callback NT_ObjectsPart_Event;

		// event trigger associated with syntax rule NT-ObjectsPart
		public bool Raise_NT_ObjectsPart_Event (SyntaxTreeCallbackReason reason, NT_ObjectsPart.production_kind kind, NT_ObjectsPart p_NT_ObjectsPart)
		{
			bool? status = NT_ObjectsPart_Event?.Invoke (reason, kind, p_NT_ObjectsPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NT-ObjectsPart
		//
		// traverse syntax tree node associated with any production of syntax rule NT-ObjectsPart
		//

		public void Traverse (NT_ObjectsPart p_NT_ObjectsPart)
		{
			if (p_NT_ObjectsPart.isLocked())
				return;
			p_NT_ObjectsPart.dolock();
			NT_ObjectsPart.production_kind kind = (NT_ObjectsPart.production_kind) p_NT_ObjectsPart.kind;
			p_NT_ObjectsPart.turn_reset ();
			if (Raise_NT_ObjectsPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NT_ObjectsPart))
			switch (kind)
			{
				case NT_ObjectsPart.production_kind.g_NT_ObjectsPart_1:
					// traverse syntax tree node associated with production
					// NT-ObjectsPart: OBJECTS "{" NT-Objects "}"

					if (Raise_NT_ObjectsPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NT_ObjectsPart))
						Traverse (p_NT_ObjectsPart.m_NT_Objects);
					p_NT_ObjectsPart.turn_inc ();
					Raise_NT_ObjectsPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NT_ObjectsPart);
				break;
				case NT_ObjectsPart.production_kind.g_NT_ObjectsPart_2:
					// traverse syntax tree node associated with production
					// NT-ObjectsPart: %empty

				break;
			}
			Raise_NT_ObjectsPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NT_ObjectsPart);
			p_NT_ObjectsPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NT-ObjectsPart
		//

		public void TraverseCommon (NT_ObjectsPart p_NT_ObjectsPart)
		{
			NT_ObjectsPart.production_kind kind = (NT_ObjectsPart.production_kind) p_NT_ObjectsPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NT_ObjectsPart))
			switch (kind)
			{
				case NT_ObjectsPart.production_kind.g_NT_ObjectsPart_1:
					// traverse syntax tree node associated with production
					// NT-ObjectsPart: OBJECTS "{" NT-Objects "}"

						TraverseCommon (p_NT_ObjectsPart.m_OBJECTS);
						TraverseCommon (p_NT_ObjectsPart.m_left_curly_bracket);
						TraverseCommon (p_NT_ObjectsPart.m_NT_Objects);
						TraverseCommon (p_NT_ObjectsPart.m_right_curly_bracket);
				break;
				case NT_ObjectsPart.production_kind.g_NT_ObjectsPart_2:
					// traverse syntax tree node associated with production
					// NT-ObjectsPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NT_ObjectsPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NT-ObjectsPart

		//
		// create syntax tree node associated with production
		// NT-ObjectsPart: OBJECTS "{" NT-Objects "}"

		//

		public NT_ObjectsPart NT_ObjectsPart_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, NT_Objects p_NT_Objects, SyntaxTreeToken p_token_2)
		{
			NT_ObjectsPart p_NT_ObjectsPart_ref = new NT_ObjectsPart(p_token, p_token_1, p_NT_Objects, p_token_2);
			p_token.parent = p_NT_ObjectsPart_ref;
			p_token_1.parent = p_NT_ObjectsPart_ref;
			p_NT_Objects.parent = p_NT_ObjectsPart_ref;
			p_token_2.parent = p_NT_ObjectsPart_ref;
			Raise_NT_ObjectsPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NT_ObjectsPart.production_kind.g_NT_ObjectsPart_1, p_NT_ObjectsPart_ref);
			return p_NT_ObjectsPart_ref;
		}

		//
		// create syntax tree node associated with production
		// NT-ObjectsPart: %empty

		//

		public NT_ObjectsPart NT_ObjectsPart_2 ()
		{
			NT_ObjectsPart p_NT_ObjectsPart_ref = new NT_ObjectsPart();
			Raise_NT_ObjectsPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NT_ObjectsPart.production_kind.g_NT_ObjectsPart_2, p_NT_ObjectsPart_ref);
			return p_NT_ObjectsPart_ref;
		}
		#endregion
	};
}
