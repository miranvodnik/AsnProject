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
	// class associated with syntax rule TC-DisplayPart
	//

	[DataContract]
	public class	TC_DisplayPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TC-DisplayPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TC-DisplayPart
		{
			g_TC_DisplayPart_1 = 1,	// DISPLAY-HINT cstring

			g_TC_DisplayPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule TC-DisplayPart

		// markers associated with production: TC-DisplayPart -> DISPLAY-HINT cstring

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: TC-DisplayPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TC-DisplayPart

		// Constructor declaration(s) associated with production(s) of syntax rule TC-DisplayPart

		//
		// Constructor associated with the following production(s)
		// TC-DisplayPart -> DISPLAY-HINT cstring

		//

		public TC_DisplayPart (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._TC_DisplayPart_ID, (uint) production_kind.g_TC_DisplayPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_DISPLAY_HINT = p_token;
			children[1] = m_cstring = p_token_1;
		}

		//
		// Constructor associated with the following production(s)
		// TC-DisplayPart -> %empty

		//

		public TC_DisplayPart () : base ((uint) ProductionID._TC_DisplayPart_ID, (uint) production_kind.g_TC_DisplayPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public TC_DisplayPart (TC_DisplayPart p_TC_DisplayPart) : base (p_TC_DisplayPart.id, p_TC_DisplayPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TC_DisplayPart.appInfo;
			switch ((production_kind) p_TC_DisplayPart.kind)
			{
				case production_kind.g_TC_DisplayPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_DISPLAY_HINT = (p_TC_DisplayPart.m_DISPLAY_HINT != null) ? new SyntaxTreeToken (p_TC_DisplayPart.m_DISPLAY_HINT) : null) != null) m_DISPLAY_HINT.parent = this;
					if ((children [1] = m_cstring = (p_TC_DisplayPart.m_cstring != null) ? new SyntaxTreeToken (p_TC_DisplayPart.m_cstring) : null) != null) m_cstring.parent = this;
					break;
				case production_kind.g_TC_DisplayPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "TC_DisplayPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TC_DisplayPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DISPLAY_HINT?.Dispose ();
			m_cstring?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TC-DisplayPart

		// Content changing function(s) associated with production(s) of syntax rule TC-DisplayPart

		//
		// Content changing function associated with following production(s)
		// TC-DisplayPart -> DISPLAY-HINT cstring

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_TC_DisplayPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_DISPLAY_HINT = p_token;
			children [1] = m_cstring = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TC-DisplayPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_TC_DisplayPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TC-DisplayPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DISPLAY_HINT != null) && m_DISPLAY_HINT.checkInclusion (element) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TC-DisplayPart

		//
		// emit production tree node associated with any production of syntax rule TC-DisplayPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TC_DisplayPart_1:
					// emit syntax tree node associated with production
					// TC-DisplayPart: DISPLAY-HINT cstring

					s += m_DISPLAY_HINT.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
				break;
				case production_kind.g_TC_DisplayPart_2:
					// emit syntax tree node associated with production
					// TC-DisplayPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TC-DisplayPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TC_DisplayPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TC_DisplayPart_1:
					// emit syntax tree node associated with production
					// TC-DisplayPart: DISPLAY-HINT cstring

					s += "DISPLAY_HINT";
					s += ' ';
					s += "cstring";
				break;
				case production_kind.g_TC_DisplayPart_2:
					// emit syntax tree node associated with production
					// TC-DisplayPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TC-DisplayPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TC-DisplayPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TC_DisplayPart.production_kind kind = (TC_DisplayPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TC_DisplayPart.production_kind.g_TC_DisplayPart_1:
					// traverse syntax tree node associated with production
					// TC-DisplayPart: DISPLAY-HINT cstring

						m_DISPLAY_HINT.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
				break;
				case TC_DisplayPart.production_kind.g_TC_DisplayPart_2:
					// traverse syntax tree node associated with production
					// TC-DisplayPart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DISPLAY_HINT?.reparent (this);
			m_cstring?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TC-DisplayPart
		//

		public void _init ()
		{
			m_DISPLAY_HINT = null;
			m_cstring = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TC-DisplayPart

		// counter of all nodes associated with syntax rule TC-DisplayPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TC-DisplayPart
		[DataMember (Name = "m_DISPLAY_HINT")] public SyntaxTreeToken m_DISPLAY_HINT { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TC-DisplayPart

		// delegate function (callback) prototype associated with syntax rule TC-DisplayPart
		public delegate bool TC_DisplayPart_Callback (SyntaxTreeCallbackReason reason, TC_DisplayPart.production_kind kind, TC_DisplayPart p_TC_DisplayPart);

		// event associated with syntax rule TC-DisplayPart
		public event TC_DisplayPart_Callback TC_DisplayPart_Event;

		// event trigger associated with syntax rule TC-DisplayPart
		public bool Raise_TC_DisplayPart_Event (SyntaxTreeCallbackReason reason, TC_DisplayPart.production_kind kind, TC_DisplayPart p_TC_DisplayPart)
		{
			bool? status = TC_DisplayPart_Event?.Invoke (reason, kind, p_TC_DisplayPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TC-DisplayPart
		//
		// traverse syntax tree node associated with any production of syntax rule TC-DisplayPart
		//

		public void Traverse (TC_DisplayPart p_TC_DisplayPart)
		{
			if (p_TC_DisplayPart.isLocked())
				return;
			p_TC_DisplayPart.dolock();
			TC_DisplayPart.production_kind kind = (TC_DisplayPart.production_kind) p_TC_DisplayPart.kind;
			p_TC_DisplayPart.turn_reset ();
			if (Raise_TC_DisplayPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TC_DisplayPart))
			switch (kind)
			{
				case TC_DisplayPart.production_kind.g_TC_DisplayPart_1:
					// traverse syntax tree node associated with production
					// TC-DisplayPart: DISPLAY-HINT cstring

				break;
				case TC_DisplayPart.production_kind.g_TC_DisplayPart_2:
					// traverse syntax tree node associated with production
					// TC-DisplayPart: %empty

				break;
			}
			Raise_TC_DisplayPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TC_DisplayPart);
			p_TC_DisplayPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TC-DisplayPart
		//

		public void TraverseCommon (TC_DisplayPart p_TC_DisplayPart)
		{
			TC_DisplayPart.production_kind kind = (TC_DisplayPart.production_kind) p_TC_DisplayPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TC_DisplayPart))
			switch (kind)
			{
				case TC_DisplayPart.production_kind.g_TC_DisplayPart_1:
					// traverse syntax tree node associated with production
					// TC-DisplayPart: DISPLAY-HINT cstring

						TraverseCommon (p_TC_DisplayPart.m_DISPLAY_HINT);
						TraverseCommon (p_TC_DisplayPart.m_cstring);
				break;
				case TC_DisplayPart.production_kind.g_TC_DisplayPart_2:
					// traverse syntax tree node associated with production
					// TC-DisplayPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TC_DisplayPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TC-DisplayPart

		//
		// create syntax tree node associated with production
		// TC-DisplayPart: DISPLAY-HINT cstring

		//

		public TC_DisplayPart TC_DisplayPart_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			TC_DisplayPart p_TC_DisplayPart_ref = new TC_DisplayPart(p_token, p_token_1);
			p_token.parent = p_TC_DisplayPart_ref;
			p_token_1.parent = p_TC_DisplayPart_ref;
			Raise_TC_DisplayPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TC_DisplayPart.production_kind.g_TC_DisplayPart_1, p_TC_DisplayPart_ref);
			return p_TC_DisplayPart_ref;
		}

		//
		// create syntax tree node associated with production
		// TC-DisplayPart: %empty

		//

		public TC_DisplayPart TC_DisplayPart_2 ()
		{
			TC_DisplayPart p_TC_DisplayPart_ref = new TC_DisplayPart();
			Raise_TC_DisplayPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TC_DisplayPart.production_kind.g_TC_DisplayPart_2, p_TC_DisplayPart_ref);
			return p_TC_DisplayPart_ref;
		}
		#endregion
	};
}
