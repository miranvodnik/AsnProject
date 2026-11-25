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
	// class associated with syntax rule OT-UnitsPart
	//

	[DataContract]
	public class	OT_UnitsPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OT-UnitsPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OT-UnitsPart
		{
			g_OT_UnitsPart_1 = 1,	// UNITS cstring

			g_OT_UnitsPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule OT-UnitsPart

		// markers associated with production: OT-UnitsPart -> UNITS cstring

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: OT-UnitsPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OT-UnitsPart

		// Constructor declaration(s) associated with production(s) of syntax rule OT-UnitsPart

		//
		// Constructor associated with the following production(s)
		// OT-UnitsPart -> UNITS cstring

		//

		public OT_UnitsPart (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._OT_UnitsPart_ID, (uint) production_kind.g_OT_UnitsPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_UNITS = p_token;
			children[1] = m_cstring = p_token_1;
		}

		//
		// Constructor associated with the following production(s)
		// OT-UnitsPart -> %empty

		//

		public OT_UnitsPart () : base ((uint) ProductionID._OT_UnitsPart_ID, (uint) production_kind.g_OT_UnitsPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public OT_UnitsPart (OT_UnitsPart p_OT_UnitsPart) : base (p_OT_UnitsPart.id, p_OT_UnitsPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OT_UnitsPart.appInfo;
			switch ((production_kind) p_OT_UnitsPart.kind)
			{
				case production_kind.g_OT_UnitsPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_UNITS = (p_OT_UnitsPart.m_UNITS != null) ? new SyntaxTreeToken (p_OT_UnitsPart.m_UNITS) : null) != null) m_UNITS.parent = this;
					if ((children [1] = m_cstring = (p_OT_UnitsPart.m_cstring != null) ? new SyntaxTreeToken (p_OT_UnitsPart.m_cstring) : null) != null) m_cstring.parent = this;
					break;
				case production_kind.g_OT_UnitsPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "OT_UnitsPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OT_UnitsPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_UNITS?.Dispose ();
			m_cstring?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OT-UnitsPart

		// Content changing function(s) associated with production(s) of syntax rule OT-UnitsPart

		//
		// Content changing function associated with following production(s)
		// OT-UnitsPart -> UNITS cstring

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_UnitsPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_UNITS = p_token;
			children [1] = m_cstring = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// OT-UnitsPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_UnitsPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OT-UnitsPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_UNITS != null) && m_UNITS.checkInclusion (element) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OT-UnitsPart

		//
		// emit production tree node associated with any production of syntax rule OT-UnitsPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_OT_UnitsPart_1:
					// emit syntax tree node associated with production
					// OT-UnitsPart: UNITS cstring

					s += m_UNITS.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
				break;
				case production_kind.g_OT_UnitsPart_2:
					// emit syntax tree node associated with production
					// OT-UnitsPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OT-UnitsPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "OT_UnitsPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_OT_UnitsPart_1:
					// emit syntax tree node associated with production
					// OT-UnitsPart: UNITS cstring

					s += "UNITS";
					s += ' ';
					s += "cstring";
				break;
				case production_kind.g_OT_UnitsPart_2:
					// emit syntax tree node associated with production
					// OT-UnitsPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OT-UnitsPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OT-UnitsPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			OT_UnitsPart.production_kind kind = (OT_UnitsPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case OT_UnitsPart.production_kind.g_OT_UnitsPart_1:
					// traverse syntax tree node associated with production
					// OT-UnitsPart: UNITS cstring

						m_UNITS.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
				break;
				case OT_UnitsPart.production_kind.g_OT_UnitsPart_2:
					// traverse syntax tree node associated with production
					// OT-UnitsPart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_UNITS?.reparent (this);
			m_cstring?.reparent (this);
		}

		//
		// initialize object associated with syntax rule OT-UnitsPart
		//

		public void _init ()
		{
			m_UNITS = null;
			m_cstring = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OT-UnitsPart

		// counter of all nodes associated with syntax rule OT-UnitsPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OT-UnitsPart
		[DataMember (Name = "m_UNITS")] public SyntaxTreeToken m_UNITS { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OT-UnitsPart

		// delegate function (callback) prototype associated with syntax rule OT-UnitsPart
		public delegate bool OT_UnitsPart_Callback (SyntaxTreeCallbackReason reason, OT_UnitsPart.production_kind kind, OT_UnitsPart p_OT_UnitsPart);

		// event associated with syntax rule OT-UnitsPart
		public event OT_UnitsPart_Callback OT_UnitsPart_Event;

		// event trigger associated with syntax rule OT-UnitsPart
		public bool Raise_OT_UnitsPart_Event (SyntaxTreeCallbackReason reason, OT_UnitsPart.production_kind kind, OT_UnitsPart p_OT_UnitsPart)
		{
			bool? status = OT_UnitsPart_Event?.Invoke (reason, kind, p_OT_UnitsPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OT-UnitsPart
		//
		// traverse syntax tree node associated with any production of syntax rule OT-UnitsPart
		//

		public void Traverse (OT_UnitsPart p_OT_UnitsPart)
		{
			if (p_OT_UnitsPart.isLocked())
				return;
			p_OT_UnitsPart.dolock();
			OT_UnitsPart.production_kind kind = (OT_UnitsPart.production_kind) p_OT_UnitsPart.kind;
			p_OT_UnitsPart.turn_reset ();
			if (Raise_OT_UnitsPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_OT_UnitsPart))
			switch (kind)
			{
				case OT_UnitsPart.production_kind.g_OT_UnitsPart_1:
					// traverse syntax tree node associated with production
					// OT-UnitsPart: UNITS cstring

				break;
				case OT_UnitsPart.production_kind.g_OT_UnitsPart_2:
					// traverse syntax tree node associated with production
					// OT-UnitsPart: %empty

				break;
			}
			Raise_OT_UnitsPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_OT_UnitsPart);
			p_OT_UnitsPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OT-UnitsPart
		//

		public void TraverseCommon (OT_UnitsPart p_OT_UnitsPart)
		{
			OT_UnitsPart.production_kind kind = (OT_UnitsPart.production_kind) p_OT_UnitsPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_OT_UnitsPart))
			switch (kind)
			{
				case OT_UnitsPart.production_kind.g_OT_UnitsPart_1:
					// traverse syntax tree node associated with production
					// OT-UnitsPart: UNITS cstring

						TraverseCommon (p_OT_UnitsPart.m_UNITS);
						TraverseCommon (p_OT_UnitsPart.m_cstring);
				break;
				case OT_UnitsPart.production_kind.g_OT_UnitsPart_2:
					// traverse syntax tree node associated with production
					// OT-UnitsPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_OT_UnitsPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OT-UnitsPart

		//
		// create syntax tree node associated with production
		// OT-UnitsPart: UNITS cstring

		//

		public OT_UnitsPart OT_UnitsPart_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			OT_UnitsPart p_OT_UnitsPart_ref = new OT_UnitsPart(p_token, p_token_1);
			p_token.parent = p_OT_UnitsPart_ref;
			p_token_1.parent = p_OT_UnitsPart_ref;
			Raise_OT_UnitsPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_UnitsPart.production_kind.g_OT_UnitsPart_1, p_OT_UnitsPart_ref);
			return p_OT_UnitsPart_ref;
		}

		//
		// create syntax tree node associated with production
		// OT-UnitsPart: %empty

		//

		public OT_UnitsPart OT_UnitsPart_2 ()
		{
			OT_UnitsPart p_OT_UnitsPart_ref = new OT_UnitsPart();
			Raise_OT_UnitsPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_UnitsPart.production_kind.g_OT_UnitsPart_2, p_OT_UnitsPart_ref);
			return p_OT_UnitsPart_ref;
		}
		#endregion
	};
}
