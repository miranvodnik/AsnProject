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
	// class associated with syntax rule TT-DescrPart
	//

	[DataContract]
	public class	TT_DescrPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TT-DescrPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TT-DescrPart
		{
			g_TT_DescrPart_1 = 1,	// DESCRIPTION cstring

			g_TT_DescrPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule TT-DescrPart

		// markers associated with production: TT-DescrPart -> DESCRIPTION cstring

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: TT-DescrPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TT-DescrPart

		// Constructor declaration(s) associated with production(s) of syntax rule TT-DescrPart

		//
		// Constructor associated with the following production(s)
		// TT-DescrPart -> DESCRIPTION cstring

		//

		public TT_DescrPart (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._TT_DescrPart_ID, (uint) production_kind.g_TT_DescrPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_DESCRIPTION = p_token;
			children[1] = m_cstring = p_token_1;
		}

		//
		// Constructor associated with the following production(s)
		// TT-DescrPart -> %empty

		//

		public TT_DescrPart () : base ((uint) ProductionID._TT_DescrPart_ID, (uint) production_kind.g_TT_DescrPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public TT_DescrPart (TT_DescrPart p_TT_DescrPart) : base (p_TT_DescrPart.id, p_TT_DescrPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TT_DescrPart.appInfo;
			switch ((production_kind) p_TT_DescrPart.kind)
			{
				case production_kind.g_TT_DescrPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_DESCRIPTION = (p_TT_DescrPart.m_DESCRIPTION != null) ? new SyntaxTreeToken (p_TT_DescrPart.m_DESCRIPTION) : null) != null) m_DESCRIPTION.parent = this;
					if ((children [1] = m_cstring = (p_TT_DescrPart.m_cstring != null) ? new SyntaxTreeToken (p_TT_DescrPart.m_cstring) : null) != null) m_cstring.parent = this;
					break;
				case production_kind.g_TT_DescrPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "TT_DescrPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TT_DescrPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DESCRIPTION?.Dispose ();
			m_cstring?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TT-DescrPart

		// Content changing function(s) associated with production(s) of syntax rule TT-DescrPart

		//
		// Content changing function associated with following production(s)
		// TT-DescrPart -> DESCRIPTION cstring

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_TT_DescrPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_DESCRIPTION = p_token;
			children [1] = m_cstring = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TT-DescrPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_TT_DescrPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TT-DescrPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DESCRIPTION != null) && m_DESCRIPTION.checkInclusion (element) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TT-DescrPart

		//
		// emit production tree node associated with any production of syntax rule TT-DescrPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TT_DescrPart_1:
					// emit syntax tree node associated with production
					// TT-DescrPart: DESCRIPTION cstring

					s += m_DESCRIPTION.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
				break;
				case production_kind.g_TT_DescrPart_2:
					// emit syntax tree node associated with production
					// TT-DescrPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TT-DescrPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TT_DescrPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TT_DescrPart_1:
					// emit syntax tree node associated with production
					// TT-DescrPart: DESCRIPTION cstring

					s += "DESCRIPTION";
					s += ' ';
					s += "cstring";
				break;
				case production_kind.g_TT_DescrPart_2:
					// emit syntax tree node associated with production
					// TT-DescrPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TT-DescrPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TT-DescrPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TT_DescrPart.production_kind kind = (TT_DescrPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TT_DescrPart.production_kind.g_TT_DescrPart_1:
					// traverse syntax tree node associated with production
					// TT-DescrPart: DESCRIPTION cstring

						m_DESCRIPTION.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
				break;
				case TT_DescrPart.production_kind.g_TT_DescrPart_2:
					// traverse syntax tree node associated with production
					// TT-DescrPart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DESCRIPTION?.reparent (this);
			m_cstring?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TT-DescrPart
		//

		public void _init ()
		{
			m_DESCRIPTION = null;
			m_cstring = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TT-DescrPart

		// counter of all nodes associated with syntax rule TT-DescrPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TT-DescrPart
		[DataMember (Name = "m_DESCRIPTION")] public SyntaxTreeToken m_DESCRIPTION { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TT-DescrPart

		// delegate function (callback) prototype associated with syntax rule TT-DescrPart
		public delegate bool TT_DescrPart_Callback (SyntaxTreeCallbackReason reason, TT_DescrPart.production_kind kind, TT_DescrPart p_TT_DescrPart);

		// event associated with syntax rule TT-DescrPart
		public event TT_DescrPart_Callback TT_DescrPart_Event;

		// event trigger associated with syntax rule TT-DescrPart
		public bool Raise_TT_DescrPart_Event (SyntaxTreeCallbackReason reason, TT_DescrPart.production_kind kind, TT_DescrPart p_TT_DescrPart)
		{
			bool? status = TT_DescrPart_Event?.Invoke (reason, kind, p_TT_DescrPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TT-DescrPart
		//
		// traverse syntax tree node associated with any production of syntax rule TT-DescrPart
		//

		public void Traverse (TT_DescrPart p_TT_DescrPart)
		{
			if (p_TT_DescrPart.isLocked())
				return;
			p_TT_DescrPart.dolock();
			TT_DescrPart.production_kind kind = (TT_DescrPart.production_kind) p_TT_DescrPart.kind;
			p_TT_DescrPart.turn_reset ();
			if (Raise_TT_DescrPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TT_DescrPart))
			switch (kind)
			{
				case TT_DescrPart.production_kind.g_TT_DescrPart_1:
					// traverse syntax tree node associated with production
					// TT-DescrPart: DESCRIPTION cstring

				break;
				case TT_DescrPart.production_kind.g_TT_DescrPart_2:
					// traverse syntax tree node associated with production
					// TT-DescrPart: %empty

				break;
			}
			Raise_TT_DescrPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TT_DescrPart);
			p_TT_DescrPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TT-DescrPart
		//

		public void TraverseCommon (TT_DescrPart p_TT_DescrPart)
		{
			TT_DescrPart.production_kind kind = (TT_DescrPart.production_kind) p_TT_DescrPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TT_DescrPart))
			switch (kind)
			{
				case TT_DescrPart.production_kind.g_TT_DescrPart_1:
					// traverse syntax tree node associated with production
					// TT-DescrPart: DESCRIPTION cstring

						TraverseCommon (p_TT_DescrPart.m_DESCRIPTION);
						TraverseCommon (p_TT_DescrPart.m_cstring);
				break;
				case TT_DescrPart.production_kind.g_TT_DescrPart_2:
					// traverse syntax tree node associated with production
					// TT-DescrPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TT_DescrPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TT-DescrPart

		//
		// create syntax tree node associated with production
		// TT-DescrPart: DESCRIPTION cstring

		//

		public TT_DescrPart TT_DescrPart_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			TT_DescrPart p_TT_DescrPart_ref = new TT_DescrPart(p_token, p_token_1);
			p_token.parent = p_TT_DescrPart_ref;
			p_token_1.parent = p_TT_DescrPart_ref;
			Raise_TT_DescrPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TT_DescrPart.production_kind.g_TT_DescrPart_1, p_TT_DescrPart_ref);
			return p_TT_DescrPart_ref;
		}

		//
		// create syntax tree node associated with production
		// TT-DescrPart: %empty

		//

		public TT_DescrPart TT_DescrPart_2 ()
		{
			TT_DescrPart p_TT_DescrPart_ref = new TT_DescrPart();
			Raise_TT_DescrPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TT_DescrPart.production_kind.g_TT_DescrPart_2, p_TT_DescrPart_ref);
			return p_TT_DescrPart_ref;
		}
		#endregion
	};
}
