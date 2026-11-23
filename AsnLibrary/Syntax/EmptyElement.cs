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
	// class associated with syntax rule EmptyElement
	//

	[DataContract]
	public class	EmptyElement : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule EmptyElement
		public enum production_kind : ushort	// enumerated production(s) of syntax rule EmptyElement
		{
			g_EmptyElement_1 = 1,	// "<" identifier-token "/>"

		};
		#endregion
		#region production markers associated with the syntax rule EmptyElement

		// markers associated with production: EmptyElement -> "<" identifier-token "/>"

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule EmptyElement

		// Constructor declaration(s) associated with production(s) of syntax rule EmptyElement

		//
		// Constructor associated with the following production(s)
		// EmptyElement -> "<" identifier-token "/>"

		//

		public EmptyElement (SyntaxTreeToken p_token, identifier_token p_identifier_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._EmptyElement_ID, (uint) production_kind.g_EmptyElement_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_less_sign = p_token;
			children[1] = m_identifier_token = p_identifier_token;
			children[2] = m_xml_single_tag_end_item = p_token_1;
		}

		public EmptyElement () { }

		// Copy constructor

		public EmptyElement (EmptyElement p_EmptyElement) : base (p_EmptyElement.id, p_EmptyElement.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_EmptyElement.appInfo;
			switch ((production_kind) p_EmptyElement.kind)
			{
				case production_kind.g_EmptyElement_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_less_sign = (p_EmptyElement.m_less_sign != null) ? new SyntaxTreeToken (p_EmptyElement.m_less_sign) : null) != null) m_less_sign.parent = this;
					if ((children [1] = m_identifier_token = (p_EmptyElement.m_identifier_token != null) ? new identifier_token (p_EmptyElement.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [2] = m_xml_single_tag_end_item = (p_EmptyElement.m_xml_single_tag_end_item != null) ? new SyntaxTreeToken (p_EmptyElement.m_xml_single_tag_end_item) : null) != null) m_xml_single_tag_end_item.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "EmptyElement" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new EmptyElement (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_less_sign?.Dispose ();
			m_identifier_token?.Dispose ();
			m_xml_single_tag_end_item?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule EmptyElement

		// Content changing function(s) associated with production(s) of syntax rule EmptyElement

		//
		// Content changing function associated with following production(s)
		// EmptyElement -> "<" identifier-token "/>"

		//

		public void change(SyntaxTreeToken p_token, identifier_token p_identifier_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_EmptyElement_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_less_sign = p_token;
			children [1] = m_identifier_token = p_identifier_token;
			children [2] = m_xml_single_tag_end_item = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule EmptyElement
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_less_sign != null) && m_less_sign.checkInclusion (element) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				(m_xml_single_tag_end_item != null) && m_xml_single_tag_end_item.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule EmptyElement

		//
		// emit production tree node associated with any production of syntax rule EmptyElement
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_EmptyElement_1:
					// emit syntax tree node associated with production
					// EmptyElement: "<" identifier-token "/>"

					s += m_less_sign.Emit (depth - 1);
					s += " ";
					s += m_identifier_token.Emit (depth - 1);
					s += " ";
					s += m_xml_single_tag_end_item.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule EmptyElement
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "EmptyElement (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_EmptyElement_1:
					// emit syntax tree node associated with production
					// EmptyElement: "<" identifier-token "/>"

					s += "less_sign";
					s += ' ';
					s += m_identifier_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "xml_single_tag_end_item";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule EmptyElement

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule EmptyElement with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			EmptyElement.production_kind kind = (EmptyElement.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case EmptyElement.production_kind.g_EmptyElement_1:
					// traverse syntax tree node associated with production
					// EmptyElement: "<" identifier-token "/>"

						m_less_sign.Visit (visitor, appData);
						m_identifier_token.Visit (visitor, appData);
						m_xml_single_tag_end_item.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_less_sign?.reparent (this);
			m_identifier_token?.reparent (this);
			m_xml_single_tag_end_item?.reparent (this);
		}

		//
		// initialize object associated with syntax rule EmptyElement
		//

		public void _init ()
		{
			m_less_sign = null;
			m_identifier_token = null;
			m_xml_single_tag_end_item = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule EmptyElement

		// counter of all nodes associated with syntax rule EmptyElement
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule EmptyElement
		[DataMember (Name = "m_less_sign")] public SyntaxTreeToken m_less_sign { get; private set; }
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_xml_single_tag_end_item")] public SyntaxTreeToken m_xml_single_tag_end_item { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule EmptyElement

		// delegate function (callback) prototype associated with syntax rule EmptyElement
		public delegate bool EmptyElement_Callback (SyntaxTreeCallbackReason reason, EmptyElement.production_kind kind, EmptyElement p_EmptyElement);

		// event associated with syntax rule EmptyElement
		public event EmptyElement_Callback EmptyElement_Event;

		// event trigger associated with syntax rule EmptyElement
		public bool Raise_EmptyElement_Event (SyntaxTreeCallbackReason reason, EmptyElement.production_kind kind, EmptyElement p_EmptyElement)
		{
			bool? status = EmptyElement_Event?.Invoke (reason, kind, p_EmptyElement);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule EmptyElement
		//
		// traverse syntax tree node associated with any production of syntax rule EmptyElement
		//

		public void Traverse (EmptyElement p_EmptyElement)
		{
			if (p_EmptyElement.isLocked())
				return;
			p_EmptyElement.dolock();
			EmptyElement.production_kind kind = (EmptyElement.production_kind) p_EmptyElement.kind;
			p_EmptyElement.turn_reset ();
			if (Raise_EmptyElement_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_EmptyElement))
			switch (kind)
			{
				case EmptyElement.production_kind.g_EmptyElement_1:
					// traverse syntax tree node associated with production
					// EmptyElement: "<" identifier-token "/>"

					if (Raise_EmptyElement_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EmptyElement))
						Traverse (p_EmptyElement.m_identifier_token);
					p_EmptyElement.turn_inc ();
					Raise_EmptyElement_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EmptyElement);
				break;
			}
			Raise_EmptyElement_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_EmptyElement);
			p_EmptyElement.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule EmptyElement
		//

		public void TraverseCommon (EmptyElement p_EmptyElement)
		{
			EmptyElement.production_kind kind = (EmptyElement.production_kind) p_EmptyElement.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_EmptyElement))
			switch (kind)
			{
				case EmptyElement.production_kind.g_EmptyElement_1:
					// traverse syntax tree node associated with production
					// EmptyElement: "<" identifier-token "/>"

						TraverseCommon (p_EmptyElement.m_less_sign);
						TraverseCommon (p_EmptyElement.m_identifier_token);
						TraverseCommon (p_EmptyElement.m_xml_single_tag_end_item);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_EmptyElement);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule EmptyElement

		//
		// create syntax tree node associated with production
		// EmptyElement: "<" identifier-token "/>"

		//

		public EmptyElement EmptyElement_1 (SyntaxTreeToken p_token, identifier_token p_identifier_token, SyntaxTreeToken p_token_1)
		{
			EmptyElement p_EmptyElement_ref = new EmptyElement(p_token, p_identifier_token, p_token_1);
			p_token.parent = p_EmptyElement_ref;
			p_identifier_token.parent = p_EmptyElement_ref;
			p_token_1.parent = p_EmptyElement_ref;
			Raise_EmptyElement_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EmptyElement.production_kind.g_EmptyElement_1, p_EmptyElement_ref);
			return p_EmptyElement_ref;
		}
		#endregion
	};
}
