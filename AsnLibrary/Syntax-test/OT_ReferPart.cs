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
	// class associated with syntax rule OT-ReferPart
	//

	[DataContract]
	public class	OT_ReferPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OT-ReferPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OT-ReferPart
		{
			g_OT_ReferPart_1 = 1,	// REFERENCE cstring

			g_OT_ReferPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule OT-ReferPart

		// markers associated with production: OT-ReferPart -> REFERENCE cstring

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: OT-ReferPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OT-ReferPart

		// Constructor declaration(s) associated with production(s) of syntax rule OT-ReferPart

		//
		// Constructor associated with the following production(s)
		// OT-ReferPart -> REFERENCE cstring

		//

		public OT_ReferPart (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._OT_ReferPart_ID, (uint) production_kind.g_OT_ReferPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_REFERENCE = p_token;
			children[1] = m_cstring = p_token_1;
		}

		//
		// Constructor associated with the following production(s)
		// OT-ReferPart -> %empty

		//

		public OT_ReferPart () : base ((uint) ProductionID._OT_ReferPart_ID, (uint) production_kind.g_OT_ReferPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public OT_ReferPart (OT_ReferPart p_OT_ReferPart) : base (p_OT_ReferPart.id, p_OT_ReferPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OT_ReferPart.appInfo;
			switch ((production_kind) p_OT_ReferPart.kind)
			{
				case production_kind.g_OT_ReferPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_REFERENCE = (p_OT_ReferPart.m_REFERENCE != null) ? new SyntaxTreeToken (p_OT_ReferPart.m_REFERENCE) : null) != null) m_REFERENCE.parent = this;
					if ((children [1] = m_cstring = (p_OT_ReferPart.m_cstring != null) ? new SyntaxTreeToken (p_OT_ReferPart.m_cstring) : null) != null) m_cstring.parent = this;
					break;
				case production_kind.g_OT_ReferPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "OT_ReferPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OT_ReferPart (this); }

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
		#region Content changing and inclusion checking methods associated with the syntax rule OT-ReferPart

		// Content changing function(s) associated with production(s) of syntax rule OT-ReferPart

		//
		// Content changing function associated with following production(s)
		// OT-ReferPart -> REFERENCE cstring

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_ReferPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_REFERENCE = p_token;
			children [1] = m_cstring = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// OT-ReferPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_ReferPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OT-ReferPart
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
		#region Syntax tree emit methods associated with the syntax rule OT-ReferPart

		//
		// emit production tree node associated with any production of syntax rule OT-ReferPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_OT_ReferPart_1:
					// emit syntax tree node associated with production
					// OT-ReferPart: REFERENCE cstring

					s += m_REFERENCE.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
				break;
				case production_kind.g_OT_ReferPart_2:
					// emit syntax tree node associated with production
					// OT-ReferPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OT-ReferPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "OT_ReferPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_OT_ReferPart_1:
					// emit syntax tree node associated with production
					// OT-ReferPart: REFERENCE cstring

					s += "REFERENCE";
					s += ' ';
					s += "cstring";
				break;
				case production_kind.g_OT_ReferPart_2:
					// emit syntax tree node associated with production
					// OT-ReferPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OT-ReferPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OT-ReferPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			OT_ReferPart.production_kind kind = (OT_ReferPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case OT_ReferPart.production_kind.g_OT_ReferPart_1:
					// traverse syntax tree node associated with production
					// OT-ReferPart: REFERENCE cstring

						m_REFERENCE.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
				break;
				case OT_ReferPart.production_kind.g_OT_ReferPart_2:
					// traverse syntax tree node associated with production
					// OT-ReferPart: %empty

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
		// initialize object associated with syntax rule OT-ReferPart
		//

		public void _init ()
		{
			m_REFERENCE = null;
			m_cstring = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OT-ReferPart

		// counter of all nodes associated with syntax rule OT-ReferPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OT-ReferPart
		[DataMember (Name = "m_REFERENCE")] public SyntaxTreeToken m_REFERENCE { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OT-ReferPart

		// delegate function (callback) prototype associated with syntax rule OT-ReferPart
		public delegate bool OT_ReferPart_Callback (SyntaxTreeCallbackReason reason, OT_ReferPart.production_kind kind, OT_ReferPart p_OT_ReferPart);

		// event associated with syntax rule OT-ReferPart
		public event OT_ReferPart_Callback OT_ReferPart_Event;

		// event trigger associated with syntax rule OT-ReferPart
		public bool Raise_OT_ReferPart_Event (SyntaxTreeCallbackReason reason, OT_ReferPart.production_kind kind, OT_ReferPart p_OT_ReferPart)
		{
			bool? status = OT_ReferPart_Event?.Invoke (reason, kind, p_OT_ReferPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OT-ReferPart
		//
		// traverse syntax tree node associated with any production of syntax rule OT-ReferPart
		//

		public void Traverse (OT_ReferPart p_OT_ReferPart)
		{
			if (p_OT_ReferPart.isLocked())
				return;
			p_OT_ReferPart.dolock();
			OT_ReferPart.production_kind kind = (OT_ReferPart.production_kind) p_OT_ReferPart.kind;
			p_OT_ReferPart.turn_reset ();
			if (Raise_OT_ReferPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_OT_ReferPart))
			switch (kind)
			{
				case OT_ReferPart.production_kind.g_OT_ReferPart_1:
					// traverse syntax tree node associated with production
					// OT-ReferPart: REFERENCE cstring

				break;
				case OT_ReferPart.production_kind.g_OT_ReferPart_2:
					// traverse syntax tree node associated with production
					// OT-ReferPart: %empty

				break;
			}
			Raise_OT_ReferPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_OT_ReferPart);
			p_OT_ReferPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OT-ReferPart
		//

		public void TraverseCommon (OT_ReferPart p_OT_ReferPart)
		{
			OT_ReferPart.production_kind kind = (OT_ReferPart.production_kind) p_OT_ReferPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_OT_ReferPart))
			switch (kind)
			{
				case OT_ReferPart.production_kind.g_OT_ReferPart_1:
					// traverse syntax tree node associated with production
					// OT-ReferPart: REFERENCE cstring

						TraverseCommon (p_OT_ReferPart.m_REFERENCE);
						TraverseCommon (p_OT_ReferPart.m_cstring);
				break;
				case OT_ReferPart.production_kind.g_OT_ReferPart_2:
					// traverse syntax tree node associated with production
					// OT-ReferPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_OT_ReferPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OT-ReferPart

		//
		// create syntax tree node associated with production
		// OT-ReferPart: REFERENCE cstring

		//

		public OT_ReferPart OT_ReferPart_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			OT_ReferPart p_OT_ReferPart_ref = new OT_ReferPart(p_token, p_token_1);
			p_token.parent = p_OT_ReferPart_ref;
			p_token_1.parent = p_OT_ReferPart_ref;
			Raise_OT_ReferPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_ReferPart.production_kind.g_OT_ReferPart_1, p_OT_ReferPart_ref);
			return p_OT_ReferPart_ref;
		}

		//
		// create syntax tree node associated with production
		// OT-ReferPart: %empty

		//

		public OT_ReferPart OT_ReferPart_2 ()
		{
			OT_ReferPart p_OT_ReferPart_ref = new OT_ReferPart();
			Raise_OT_ReferPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_ReferPart.production_kind.g_OT_ReferPart_2, p_OT_ReferPart_ref);
			return p_OT_ReferPart_ref;
		}
		#endregion
	};
}
