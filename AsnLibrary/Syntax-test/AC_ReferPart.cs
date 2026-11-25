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
	// class associated with syntax rule AC-ReferPart
	//

	[DataContract]
	public class	AC_ReferPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-ReferPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-ReferPart
		{
			g_AC_ReferPart_1 = 1,	// REFERENCE cstring

			g_AC_ReferPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule AC-ReferPart

		// markers associated with production: AC-ReferPart -> REFERENCE cstring

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: AC-ReferPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-ReferPart

		// Constructor declaration(s) associated with production(s) of syntax rule AC-ReferPart

		//
		// Constructor associated with the following production(s)
		// AC-ReferPart -> REFERENCE cstring

		//

		public AC_ReferPart (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._AC_ReferPart_ID, (uint) production_kind.g_AC_ReferPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_REFERENCE = p_token;
			children[1] = m_cstring = p_token_1;
		}

		//
		// Constructor associated with the following production(s)
		// AC-ReferPart -> %empty

		//

		public AC_ReferPart () : base ((uint) ProductionID._AC_ReferPart_ID, (uint) production_kind.g_AC_ReferPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public AC_ReferPart (AC_ReferPart p_AC_ReferPart) : base (p_AC_ReferPart.id, p_AC_ReferPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_ReferPart.appInfo;
			switch ((production_kind) p_AC_ReferPart.kind)
			{
				case production_kind.g_AC_ReferPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_REFERENCE = (p_AC_ReferPart.m_REFERENCE != null) ? new SyntaxTreeToken (p_AC_ReferPart.m_REFERENCE) : null) != null) m_REFERENCE.parent = this;
					if ((children [1] = m_cstring = (p_AC_ReferPart.m_cstring != null) ? new SyntaxTreeToken (p_AC_ReferPart.m_cstring) : null) != null) m_cstring.parent = this;
					break;
				case production_kind.g_AC_ReferPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "AC_ReferPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_ReferPart (this); }

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
		#region Content changing and inclusion checking methods associated with the syntax rule AC-ReferPart

		// Content changing function(s) associated with production(s) of syntax rule AC-ReferPart

		//
		// Content changing function associated with following production(s)
		// AC-ReferPart -> REFERENCE cstring

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_ReferPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_REFERENCE = p_token;
			children [1] = m_cstring = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AC-ReferPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_ReferPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-ReferPart
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
		#region Syntax tree emit methods associated with the syntax rule AC-ReferPart

		//
		// emit production tree node associated with any production of syntax rule AC-ReferPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_ReferPart_1:
					// emit syntax tree node associated with production
					// AC-ReferPart: REFERENCE cstring

					s += m_REFERENCE.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
				break;
				case production_kind.g_AC_ReferPart_2:
					// emit syntax tree node associated with production
					// AC-ReferPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-ReferPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_ReferPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_ReferPart_1:
					// emit syntax tree node associated with production
					// AC-ReferPart: REFERENCE cstring

					s += "REFERENCE";
					s += ' ';
					s += "cstring";
				break;
				case production_kind.g_AC_ReferPart_2:
					// emit syntax tree node associated with production
					// AC-ReferPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-ReferPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-ReferPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_ReferPart.production_kind kind = (AC_ReferPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_ReferPart.production_kind.g_AC_ReferPart_1:
					// traverse syntax tree node associated with production
					// AC-ReferPart: REFERENCE cstring

						m_REFERENCE.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
				break;
				case AC_ReferPart.production_kind.g_AC_ReferPart_2:
					// traverse syntax tree node associated with production
					// AC-ReferPart: %empty

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
		// initialize object associated with syntax rule AC-ReferPart
		//

		public void _init ()
		{
			m_REFERENCE = null;
			m_cstring = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-ReferPart

		// counter of all nodes associated with syntax rule AC-ReferPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-ReferPart
		[DataMember (Name = "m_REFERENCE")] public SyntaxTreeToken m_REFERENCE { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-ReferPart

		// delegate function (callback) prototype associated with syntax rule AC-ReferPart
		public delegate bool AC_ReferPart_Callback (SyntaxTreeCallbackReason reason, AC_ReferPart.production_kind kind, AC_ReferPart p_AC_ReferPart);

		// event associated with syntax rule AC-ReferPart
		public event AC_ReferPart_Callback AC_ReferPart_Event;

		// event trigger associated with syntax rule AC-ReferPart
		public bool Raise_AC_ReferPart_Event (SyntaxTreeCallbackReason reason, AC_ReferPart.production_kind kind, AC_ReferPart p_AC_ReferPart)
		{
			bool? status = AC_ReferPart_Event?.Invoke (reason, kind, p_AC_ReferPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-ReferPart
		//
		// traverse syntax tree node associated with any production of syntax rule AC-ReferPart
		//

		public void Traverse (AC_ReferPart p_AC_ReferPart)
		{
			if (p_AC_ReferPart.isLocked())
				return;
			p_AC_ReferPart.dolock();
			AC_ReferPart.production_kind kind = (AC_ReferPart.production_kind) p_AC_ReferPart.kind;
			p_AC_ReferPart.turn_reset ();
			if (Raise_AC_ReferPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_ReferPart))
			switch (kind)
			{
				case AC_ReferPart.production_kind.g_AC_ReferPart_1:
					// traverse syntax tree node associated with production
					// AC-ReferPart: REFERENCE cstring

				break;
				case AC_ReferPart.production_kind.g_AC_ReferPart_2:
					// traverse syntax tree node associated with production
					// AC-ReferPart: %empty

				break;
			}
			Raise_AC_ReferPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_ReferPart);
			p_AC_ReferPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-ReferPart
		//

		public void TraverseCommon (AC_ReferPart p_AC_ReferPart)
		{
			AC_ReferPart.production_kind kind = (AC_ReferPart.production_kind) p_AC_ReferPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_ReferPart))
			switch (kind)
			{
				case AC_ReferPart.production_kind.g_AC_ReferPart_1:
					// traverse syntax tree node associated with production
					// AC-ReferPart: REFERENCE cstring

						TraverseCommon (p_AC_ReferPart.m_REFERENCE);
						TraverseCommon (p_AC_ReferPart.m_cstring);
				break;
				case AC_ReferPart.production_kind.g_AC_ReferPart_2:
					// traverse syntax tree node associated with production
					// AC-ReferPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_ReferPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-ReferPart

		//
		// create syntax tree node associated with production
		// AC-ReferPart: REFERENCE cstring

		//

		public AC_ReferPart AC_ReferPart_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			AC_ReferPart p_AC_ReferPart_ref = new AC_ReferPart(p_token, p_token_1);
			p_token.parent = p_AC_ReferPart_ref;
			p_token_1.parent = p_AC_ReferPart_ref;
			Raise_AC_ReferPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_ReferPart.production_kind.g_AC_ReferPart_1, p_AC_ReferPart_ref);
			return p_AC_ReferPart_ref;
		}

		//
		// create syntax tree node associated with production
		// AC-ReferPart: %empty

		//

		public AC_ReferPart AC_ReferPart_2 ()
		{
			AC_ReferPart p_AC_ReferPart_ref = new AC_ReferPart();
			Raise_AC_ReferPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_ReferPart.production_kind.g_AC_ReferPart_2, p_AC_ReferPart_ref);
			return p_AC_ReferPart_ref;
		}
		#endregion
	};
}
