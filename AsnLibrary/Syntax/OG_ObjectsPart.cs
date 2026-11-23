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
	// class associated with syntax rule OG-ObjectsPart
	//

	[DataContract]
	public class	OG_ObjectsPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OG-ObjectsPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OG-ObjectsPart
		{
			g_OG_ObjectsPart_1 = 1,	// OBJECTS "{" OG-Objects "}"

		};
		#endregion
		#region production markers associated with the syntax rule OG-ObjectsPart

		// markers associated with production: OG-ObjectsPart -> OBJECTS "{" OG-Objects "}"

		public enum production_marker_1 : ushort
		{
			m_OG_Objects,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OG-ObjectsPart

		// Constructor declaration(s) associated with production(s) of syntax rule OG-ObjectsPart

		//
		// Constructor associated with the following production(s)
		// OG-ObjectsPart -> OBJECTS "{" OG-Objects "}"

		//

		public OG_ObjectsPart (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, OG_Objects p_OG_Objects, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._OG_ObjectsPart_ID, (uint) production_kind.g_OG_ObjectsPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_OBJECTS = p_token;
			children[1] = m_left_curly_bracket = p_token_1;
			children[2] = m_OG_Objects = p_OG_Objects;
			children[3] = m_right_curly_bracket = p_token_2;
		}

		public OG_ObjectsPart () { }

		// Copy constructor

		public OG_ObjectsPart (OG_ObjectsPart p_OG_ObjectsPart) : base (p_OG_ObjectsPart.id, p_OG_ObjectsPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OG_ObjectsPart.appInfo;
			switch ((production_kind) p_OG_ObjectsPart.kind)
			{
				case production_kind.g_OG_ObjectsPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_OBJECTS = (p_OG_ObjectsPart.m_OBJECTS != null) ? new SyntaxTreeToken (p_OG_ObjectsPart.m_OBJECTS) : null) != null) m_OBJECTS.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_OG_ObjectsPart.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_OG_ObjectsPart.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_OG_Objects = (p_OG_ObjectsPart.m_OG_Objects != null) ? new OG_Objects (p_OG_ObjectsPart.m_OG_Objects) : null) != null) m_OG_Objects.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_OG_ObjectsPart.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_OG_ObjectsPart.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "OG_ObjectsPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OG_ObjectsPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_OBJECTS?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_OG_Objects?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OG-ObjectsPart

		// Content changing function(s) associated with production(s) of syntax rule OG-ObjectsPart

		//
		// Content changing function associated with following production(s)
		// OG-ObjectsPart -> OBJECTS "{" OG-Objects "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, OG_Objects p_OG_Objects, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_OG_ObjectsPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_OBJECTS = p_token;
			children [1] = m_left_curly_bracket = p_token_1;
			children [2] = m_OG_Objects = p_OG_Objects;
			children [3] = m_right_curly_bracket = p_token_2;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OG-ObjectsPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_OBJECTS != null) && m_OBJECTS.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_OG_Objects != null) && m_OG_Objects.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OG-ObjectsPart

		//
		// emit production tree node associated with any production of syntax rule OG-ObjectsPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_OG_ObjectsPart_1:
					// emit syntax tree node associated with production
					// OG-ObjectsPart: OBJECTS "{" OG-Objects "}"

					s += m_OBJECTS.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_OG_Objects.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OG-ObjectsPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "OG_ObjectsPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_OG_ObjectsPart_1:
					// emit syntax tree node associated with production
					// OG-ObjectsPart: OBJECTS "{" OG-Objects "}"

					s += "OBJECTS";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_OG_Objects.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OG-ObjectsPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OG-ObjectsPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			OG_ObjectsPart.production_kind kind = (OG_ObjectsPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case OG_ObjectsPart.production_kind.g_OG_ObjectsPart_1:
					// traverse syntax tree node associated with production
					// OG-ObjectsPart: OBJECTS "{" OG-Objects "}"

						m_OBJECTS.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_OG_Objects.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
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
			m_OG_Objects?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule OG-ObjectsPart
		//

		public void _init ()
		{
			m_OBJECTS = null;
			m_left_curly_bracket = null;
			m_OG_Objects = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OG-ObjectsPart

		// counter of all nodes associated with syntax rule OG-ObjectsPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OG-ObjectsPart
		[DataMember (Name = "m_OBJECTS")] public SyntaxTreeToken m_OBJECTS { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_OG_Objects")] public OG_Objects m_OG_Objects { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OG-ObjectsPart

		// delegate function (callback) prototype associated with syntax rule OG-ObjectsPart
		public delegate bool OG_ObjectsPart_Callback (SyntaxTreeCallbackReason reason, OG_ObjectsPart.production_kind kind, OG_ObjectsPart p_OG_ObjectsPart);

		// event associated with syntax rule OG-ObjectsPart
		public event OG_ObjectsPart_Callback OG_ObjectsPart_Event;

		// event trigger associated with syntax rule OG-ObjectsPart
		public bool Raise_OG_ObjectsPart_Event (SyntaxTreeCallbackReason reason, OG_ObjectsPart.production_kind kind, OG_ObjectsPart p_OG_ObjectsPart)
		{
			bool? status = OG_ObjectsPart_Event?.Invoke (reason, kind, p_OG_ObjectsPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OG-ObjectsPart
		//
		// traverse syntax tree node associated with any production of syntax rule OG-ObjectsPart
		//

		public void Traverse (OG_ObjectsPart p_OG_ObjectsPart)
		{
			if (p_OG_ObjectsPart.isLocked())
				return;
			p_OG_ObjectsPart.dolock();
			OG_ObjectsPart.production_kind kind = (OG_ObjectsPart.production_kind) p_OG_ObjectsPart.kind;
			p_OG_ObjectsPart.turn_reset ();
			if (Raise_OG_ObjectsPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_OG_ObjectsPart))
			switch (kind)
			{
				case OG_ObjectsPart.production_kind.g_OG_ObjectsPart_1:
					// traverse syntax tree node associated with production
					// OG-ObjectsPart: OBJECTS "{" OG-Objects "}"

					if (Raise_OG_ObjectsPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OG_ObjectsPart))
						Traverse (p_OG_ObjectsPart.m_OG_Objects);
					p_OG_ObjectsPart.turn_inc ();
					Raise_OG_ObjectsPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OG_ObjectsPart);
				break;
			}
			Raise_OG_ObjectsPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_OG_ObjectsPart);
			p_OG_ObjectsPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OG-ObjectsPart
		//

		public void TraverseCommon (OG_ObjectsPart p_OG_ObjectsPart)
		{
			OG_ObjectsPart.production_kind kind = (OG_ObjectsPart.production_kind) p_OG_ObjectsPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_OG_ObjectsPart))
			switch (kind)
			{
				case OG_ObjectsPart.production_kind.g_OG_ObjectsPart_1:
					// traverse syntax tree node associated with production
					// OG-ObjectsPart: OBJECTS "{" OG-Objects "}"

						TraverseCommon (p_OG_ObjectsPart.m_OBJECTS);
						TraverseCommon (p_OG_ObjectsPart.m_left_curly_bracket);
						TraverseCommon (p_OG_ObjectsPart.m_OG_Objects);
						TraverseCommon (p_OG_ObjectsPart.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_OG_ObjectsPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OG-ObjectsPart

		//
		// create syntax tree node associated with production
		// OG-ObjectsPart: OBJECTS "{" OG-Objects "}"

		//

		public OG_ObjectsPart OG_ObjectsPart_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, OG_Objects p_OG_Objects, SyntaxTreeToken p_token_2)
		{
			OG_ObjectsPart p_OG_ObjectsPart_ref = new OG_ObjectsPart(p_token, p_token_1, p_OG_Objects, p_token_2);
			p_token.parent = p_OG_ObjectsPart_ref;
			p_token_1.parent = p_OG_ObjectsPart_ref;
			p_OG_Objects.parent = p_OG_ObjectsPart_ref;
			p_token_2.parent = p_OG_ObjectsPart_ref;
			Raise_OG_ObjectsPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OG_ObjectsPart.production_kind.g_OG_ObjectsPart_1, p_OG_ObjectsPart_ref);
			return p_OG_ObjectsPart_ref;
		}
		#endregion
	};
}
