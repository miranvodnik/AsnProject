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
	// class associated with syntax rule OG-ReferPart
	//

	[DataContract]
	public class	OG_ReferPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OG-ReferPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OG-ReferPart
		{
			g_OG_ReferPart_1 = 1,	// REFERENCE cstring

			g_OG_ReferPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule OG-ReferPart

		// markers associated with production: OG-ReferPart -> REFERENCE cstring

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: OG-ReferPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OG-ReferPart

		// Constructor declaration(s) associated with production(s) of syntax rule OG-ReferPart

		//
		// Constructor associated with the following production(s)
		// OG-ReferPart -> REFERENCE cstring

		//

		public OG_ReferPart (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._OG_ReferPart_ID, (uint) production_kind.g_OG_ReferPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_REFERENCE = p_token;
			children[1] = m_cstring = p_token_1;
		}

		//
		// Constructor associated with the following production(s)
		// OG-ReferPart -> %empty

		//

		public OG_ReferPart () : base ((uint) ProductionID._OG_ReferPart_ID, (uint) production_kind.g_OG_ReferPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public OG_ReferPart (OG_ReferPart p_OG_ReferPart) : base (p_OG_ReferPart.id, p_OG_ReferPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OG_ReferPart.appInfo;
			switch ((production_kind) p_OG_ReferPart.kind)
			{
				case production_kind.g_OG_ReferPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_REFERENCE = (p_OG_ReferPart.m_REFERENCE != null) ? new SyntaxTreeToken (p_OG_ReferPart.m_REFERENCE) : null) != null) m_REFERENCE.parent = this;
					if ((children [1] = m_cstring = (p_OG_ReferPart.m_cstring != null) ? new SyntaxTreeToken (p_OG_ReferPart.m_cstring) : null) != null) m_cstring.parent = this;
					break;
				case production_kind.g_OG_ReferPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "OG_ReferPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OG_ReferPart (this); }

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
		#region Content changing and inclusion checking methods associated with the syntax rule OG-ReferPart

		// Content changing function(s) associated with production(s) of syntax rule OG-ReferPart

		//
		// Content changing function associated with following production(s)
		// OG-ReferPart -> REFERENCE cstring

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_OG_ReferPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_REFERENCE = p_token;
			children [1] = m_cstring = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// OG-ReferPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_OG_ReferPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OG-ReferPart
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
		#region Syntax tree emit methods associated with the syntax rule OG-ReferPart

		//
		// emit production tree node associated with any production of syntax rule OG-ReferPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_OG_ReferPart_1:
					// emit syntax tree node associated with production
					// OG-ReferPart: REFERENCE cstring

					s += m_REFERENCE.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
				break;
				case production_kind.g_OG_ReferPart_2:
					// emit syntax tree node associated with production
					// OG-ReferPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OG-ReferPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "OG_ReferPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_OG_ReferPart_1:
					// emit syntax tree node associated with production
					// OG-ReferPart: REFERENCE cstring

					s += "REFERENCE";
					s += ' ';
					s += "cstring";
				break;
				case production_kind.g_OG_ReferPart_2:
					// emit syntax tree node associated with production
					// OG-ReferPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OG-ReferPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OG-ReferPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			OG_ReferPart.production_kind kind = (OG_ReferPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case OG_ReferPart.production_kind.g_OG_ReferPart_1:
					// traverse syntax tree node associated with production
					// OG-ReferPart: REFERENCE cstring

						m_REFERENCE.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
				break;
				case OG_ReferPart.production_kind.g_OG_ReferPart_2:
					// traverse syntax tree node associated with production
					// OG-ReferPart: %empty

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
		// initialize object associated with syntax rule OG-ReferPart
		//

		public void _init ()
		{
			m_REFERENCE = null;
			m_cstring = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OG-ReferPart

		// counter of all nodes associated with syntax rule OG-ReferPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OG-ReferPart
		[DataMember (Name = "m_REFERENCE")] public SyntaxTreeToken m_REFERENCE { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OG-ReferPart

		// delegate function (callback) prototype associated with syntax rule OG-ReferPart
		public delegate bool OG_ReferPart_Callback (SyntaxTreeCallbackReason reason, OG_ReferPart.production_kind kind, OG_ReferPart p_OG_ReferPart);

		// event associated with syntax rule OG-ReferPart
		public event OG_ReferPart_Callback OG_ReferPart_Event;

		// event trigger associated with syntax rule OG-ReferPart
		public bool Raise_OG_ReferPart_Event (SyntaxTreeCallbackReason reason, OG_ReferPart.production_kind kind, OG_ReferPart p_OG_ReferPart)
		{
			bool? status = OG_ReferPart_Event?.Invoke (reason, kind, p_OG_ReferPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OG-ReferPart
		//
		// traverse syntax tree node associated with any production of syntax rule OG-ReferPart
		//

		public void Traverse (OG_ReferPart p_OG_ReferPart)
		{
			if (p_OG_ReferPart.isLocked())
				return;
			p_OG_ReferPart.dolock();
			OG_ReferPart.production_kind kind = (OG_ReferPart.production_kind) p_OG_ReferPart.kind;
			p_OG_ReferPart.turn_reset ();
			if (Raise_OG_ReferPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_OG_ReferPart))
			switch (kind)
			{
				case OG_ReferPart.production_kind.g_OG_ReferPart_1:
					// traverse syntax tree node associated with production
					// OG-ReferPart: REFERENCE cstring

				break;
				case OG_ReferPart.production_kind.g_OG_ReferPart_2:
					// traverse syntax tree node associated with production
					// OG-ReferPart: %empty

				break;
			}
			Raise_OG_ReferPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_OG_ReferPart);
			p_OG_ReferPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OG-ReferPart
		//

		public void TraverseCommon (OG_ReferPart p_OG_ReferPart)
		{
			OG_ReferPart.production_kind kind = (OG_ReferPart.production_kind) p_OG_ReferPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_OG_ReferPart))
			switch (kind)
			{
				case OG_ReferPart.production_kind.g_OG_ReferPart_1:
					// traverse syntax tree node associated with production
					// OG-ReferPart: REFERENCE cstring

						TraverseCommon (p_OG_ReferPart.m_REFERENCE);
						TraverseCommon (p_OG_ReferPart.m_cstring);
				break;
				case OG_ReferPart.production_kind.g_OG_ReferPart_2:
					// traverse syntax tree node associated with production
					// OG-ReferPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_OG_ReferPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OG-ReferPart

		//
		// create syntax tree node associated with production
		// OG-ReferPart: REFERENCE cstring

		//

		public OG_ReferPart OG_ReferPart_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			OG_ReferPart p_OG_ReferPart_ref = new OG_ReferPart(p_token, p_token_1);
			p_token.parent = p_OG_ReferPart_ref;
			p_token_1.parent = p_OG_ReferPart_ref;
			Raise_OG_ReferPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OG_ReferPart.production_kind.g_OG_ReferPart_1, p_OG_ReferPart_ref);
			return p_OG_ReferPart_ref;
		}

		//
		// create syntax tree node associated with production
		// OG-ReferPart: %empty

		//

		public OG_ReferPart OG_ReferPart_2 ()
		{
			OG_ReferPart p_OG_ReferPart_ref = new OG_ReferPart();
			Raise_OG_ReferPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OG_ReferPart.production_kind.g_OG_ReferPart_2, p_OG_ReferPart_ref);
			return p_OG_ReferPart_ref;
		}
		#endregion
	};
}
