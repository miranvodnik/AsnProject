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
	// class associated with syntax rule NT-ReferPart
	//

	[DataContract]
	public class	NT_ReferPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NT-ReferPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NT-ReferPart
		{
			g_NT_ReferPart_1 = 1,	// REFERENCE cstring

			g_NT_ReferPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule NT-ReferPart

		// markers associated with production: NT-ReferPart -> REFERENCE cstring

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: NT-ReferPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NT-ReferPart

		// Constructor declaration(s) associated with production(s) of syntax rule NT-ReferPart

		//
		// Constructor associated with the following production(s)
		// NT-ReferPart -> REFERENCE cstring

		//

		public NT_ReferPart (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._NT_ReferPart_ID, (uint) production_kind.g_NT_ReferPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_REFERENCE = p_token;
			children[1] = m_cstring = p_token_1;
		}

		//
		// Constructor associated with the following production(s)
		// NT-ReferPart -> %empty

		//

		public NT_ReferPart () : base ((uint) ProductionID._NT_ReferPart_ID, (uint) production_kind.g_NT_ReferPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public NT_ReferPart (NT_ReferPart p_NT_ReferPart) : base (p_NT_ReferPart.id, p_NT_ReferPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NT_ReferPart.appInfo;
			switch ((production_kind) p_NT_ReferPart.kind)
			{
				case production_kind.g_NT_ReferPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_REFERENCE = (p_NT_ReferPart.m_REFERENCE != null) ? new SyntaxTreeToken (p_NT_ReferPart.m_REFERENCE) : null) != null) m_REFERENCE.parent = this;
					if ((children [1] = m_cstring = (p_NT_ReferPart.m_cstring != null) ? new SyntaxTreeToken (p_NT_ReferPart.m_cstring) : null) != null) m_cstring.parent = this;
					break;
				case production_kind.g_NT_ReferPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "NT_ReferPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NT_ReferPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_REFERENCE?.Dispose ();
			m_cstring?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NT-ReferPart

		// Content changing function(s) associated with production(s) of syntax rule NT-ReferPart

		//
		// Content changing function associated with following production(s)
		// NT-ReferPart -> REFERENCE cstring

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_NT_ReferPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_REFERENCE = p_token;
			children [1] = m_cstring = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// NT-ReferPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_NT_ReferPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NT-ReferPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_REFERENCE != null) && m_REFERENCE.checkInclusion (element) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NT-ReferPart

		//
		// emit production tree node associated with any production of syntax rule NT-ReferPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NT_ReferPart_1:
					// emit syntax tree node associated with production
					// NT-ReferPart: REFERENCE cstring

					s += m_REFERENCE.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
				break;
				case production_kind.g_NT_ReferPart_2:
					// emit syntax tree node associated with production
					// NT-ReferPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NT-ReferPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NT_ReferPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NT_ReferPart_1:
					// emit syntax tree node associated with production
					// NT-ReferPart: REFERENCE cstring

					s += "REFERENCE";
					s += ' ';
					s += "cstring";
				break;
				case production_kind.g_NT_ReferPart_2:
					// emit syntax tree node associated with production
					// NT-ReferPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NT-ReferPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NT-ReferPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NT_ReferPart.production_kind kind = (NT_ReferPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NT_ReferPart.production_kind.g_NT_ReferPart_1:
					// traverse syntax tree node associated with production
					// NT-ReferPart: REFERENCE cstring

						m_REFERENCE.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
				break;
				case NT_ReferPart.production_kind.g_NT_ReferPart_2:
					// traverse syntax tree node associated with production
					// NT-ReferPart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_REFERENCE?.reparent (this);
			m_cstring?.reparent (this);
		}

		//
		// initialize object associated with syntax rule NT-ReferPart
		//

		public void _init ()
		{
			m_REFERENCE = null;
			m_cstring = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NT-ReferPart

		// counter of all nodes associated with syntax rule NT-ReferPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NT-ReferPart
		[DataMember (Name = "m_REFERENCE")] public SyntaxTreeToken m_REFERENCE { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NT-ReferPart

		// delegate function (callback) prototype associated with syntax rule NT-ReferPart
		public delegate bool NT_ReferPart_Callback (SyntaxTreeCallbackReason reason, NT_ReferPart.production_kind kind, NT_ReferPart p_NT_ReferPart);

		// event associated with syntax rule NT-ReferPart
		public event NT_ReferPart_Callback NT_ReferPart_Event;

		// event trigger associated with syntax rule NT-ReferPart
		public bool Raise_NT_ReferPart_Event (SyntaxTreeCallbackReason reason, NT_ReferPart.production_kind kind, NT_ReferPart p_NT_ReferPart)
		{
			bool? status = NT_ReferPart_Event?.Invoke (reason, kind, p_NT_ReferPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NT-ReferPart
		//
		// traverse syntax tree node associated with any production of syntax rule NT-ReferPart
		//

		public void Traverse (NT_ReferPart p_NT_ReferPart)
		{
			if (p_NT_ReferPart.isLocked())
				return;
			p_NT_ReferPart.dolock();
			NT_ReferPart.production_kind kind = (NT_ReferPart.production_kind) p_NT_ReferPart.kind;
			p_NT_ReferPart.turn_reset ();
			if (Raise_NT_ReferPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NT_ReferPart))
			switch (kind)
			{
				case NT_ReferPart.production_kind.g_NT_ReferPart_1:
					// traverse syntax tree node associated with production
					// NT-ReferPart: REFERENCE cstring

				break;
				case NT_ReferPart.production_kind.g_NT_ReferPart_2:
					// traverse syntax tree node associated with production
					// NT-ReferPart: %empty

				break;
			}
			Raise_NT_ReferPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NT_ReferPart);
			p_NT_ReferPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NT-ReferPart
		//

		public void TraverseCommon (NT_ReferPart p_NT_ReferPart)
		{
			NT_ReferPart.production_kind kind = (NT_ReferPart.production_kind) p_NT_ReferPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NT_ReferPart))
			switch (kind)
			{
				case NT_ReferPart.production_kind.g_NT_ReferPart_1:
					// traverse syntax tree node associated with production
					// NT-ReferPart: REFERENCE cstring

						TraverseCommon (p_NT_ReferPart.m_REFERENCE);
						TraverseCommon (p_NT_ReferPart.m_cstring);
				break;
				case NT_ReferPart.production_kind.g_NT_ReferPart_2:
					// traverse syntax tree node associated with production
					// NT-ReferPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NT_ReferPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NT-ReferPart

		//
		// create syntax tree node associated with production
		// NT-ReferPart: REFERENCE cstring

		//

		public NT_ReferPart NT_ReferPart_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			NT_ReferPart p_NT_ReferPart_ref = new NT_ReferPart(p_token, p_token_1);
			p_token.parent = p_NT_ReferPart_ref;
			p_token_1.parent = p_NT_ReferPart_ref;
			Raise_NT_ReferPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NT_ReferPart.production_kind.g_NT_ReferPart_1, p_NT_ReferPart_ref);
			return p_NT_ReferPart_ref;
		}

		//
		// create syntax tree node associated with production
		// NT-ReferPart: %empty

		//

		public NT_ReferPart NT_ReferPart_2 ()
		{
			NT_ReferPart p_NT_ReferPart_ref = new NT_ReferPart();
			Raise_NT_ReferPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NT_ReferPart.production_kind.g_NT_ReferPart_2, p_NT_ReferPart_ref);
			return p_NT_ReferPart_ref;
		}
		#endregion
	};
}
