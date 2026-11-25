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
	// class associated with syntax rule EmptyElementEnumerated
	//

	[DataContract]
	public class	EmptyElementEnumerated : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule EmptyElementEnumerated
		public enum production_kind : ushort	// enumerated production(s) of syntax rule EmptyElementEnumerated
		{
			g_EmptyElementEnumerated_1 = 1,	// "<" identifier-token "/>"

		};
		#endregion
		#region production markers associated with the syntax rule EmptyElementEnumerated

		// markers associated with production: EmptyElementEnumerated -> "<" identifier-token "/>"

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule EmptyElementEnumerated

		// Constructor declaration(s) associated with production(s) of syntax rule EmptyElementEnumerated

		//
		// Constructor associated with the following production(s)
		// EmptyElementEnumerated -> "<" identifier-token "/>"

		//

		public EmptyElementEnumerated (SyntaxTreeToken p_token, identifier_token p_identifier_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._EmptyElementEnumerated_ID, (uint) production_kind.g_EmptyElementEnumerated_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_less_sign = p_token;
			children[1] = m_identifier_token = p_identifier_token;
			children[2] = m_xml_single_tag_end_item = p_token_1;
		}

		public EmptyElementEnumerated () { }

		// Copy constructor

		public EmptyElementEnumerated (EmptyElementEnumerated p_EmptyElementEnumerated) : base (p_EmptyElementEnumerated.id, p_EmptyElementEnumerated.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_EmptyElementEnumerated.appInfo;
			switch ((production_kind) p_EmptyElementEnumerated.kind)
			{
				case production_kind.g_EmptyElementEnumerated_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_less_sign = (p_EmptyElementEnumerated.m_less_sign != null) ? new SyntaxTreeToken (p_EmptyElementEnumerated.m_less_sign) : null) != null) m_less_sign.parent = this;
					if ((children [1] = m_identifier_token = (p_EmptyElementEnumerated.m_identifier_token != null) ? new identifier_token (p_EmptyElementEnumerated.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [2] = m_xml_single_tag_end_item = (p_EmptyElementEnumerated.m_xml_single_tag_end_item != null) ? new SyntaxTreeToken (p_EmptyElementEnumerated.m_xml_single_tag_end_item) : null) != null) m_xml_single_tag_end_item.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "EmptyElementEnumerated" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new EmptyElementEnumerated (this); }

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
		#region Content changing and inclusion checking methods associated with the syntax rule EmptyElementEnumerated

		// Content changing function(s) associated with production(s) of syntax rule EmptyElementEnumerated

		//
		// Content changing function associated with following production(s)
		// EmptyElementEnumerated -> "<" identifier-token "/>"

		//

		public void change(SyntaxTreeToken p_token, identifier_token p_identifier_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_EmptyElementEnumerated_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_less_sign = p_token;
			children [1] = m_identifier_token = p_identifier_token;
			children [2] = m_xml_single_tag_end_item = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule EmptyElementEnumerated
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
		#region Syntax tree emit methods associated with the syntax rule EmptyElementEnumerated

		//
		// emit production tree node associated with any production of syntax rule EmptyElementEnumerated
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_EmptyElementEnumerated_1:
					// emit syntax tree node associated with production
					// EmptyElementEnumerated: "<" identifier-token "/>"

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
		// emit production tree node associated with any production of syntax rule EmptyElementEnumerated
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "EmptyElementEnumerated (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_EmptyElementEnumerated_1:
					// emit syntax tree node associated with production
					// EmptyElementEnumerated: "<" identifier-token "/>"

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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule EmptyElementEnumerated

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule EmptyElementEnumerated with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			EmptyElementEnumerated.production_kind kind = (EmptyElementEnumerated.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case EmptyElementEnumerated.production_kind.g_EmptyElementEnumerated_1:
					// traverse syntax tree node associated with production
					// EmptyElementEnumerated: "<" identifier-token "/>"

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
		// initialize object associated with syntax rule EmptyElementEnumerated
		//

		public void _init ()
		{
			m_less_sign = null;
			m_identifier_token = null;
			m_xml_single_tag_end_item = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule EmptyElementEnumerated

		// counter of all nodes associated with syntax rule EmptyElementEnumerated
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule EmptyElementEnumerated
		[DataMember (Name = "m_less_sign")] public SyntaxTreeToken m_less_sign { get; private set; }
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_xml_single_tag_end_item")] public SyntaxTreeToken m_xml_single_tag_end_item { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule EmptyElementEnumerated

		// delegate function (callback) prototype associated with syntax rule EmptyElementEnumerated
		public delegate bool EmptyElementEnumerated_Callback (SyntaxTreeCallbackReason reason, EmptyElementEnumerated.production_kind kind, EmptyElementEnumerated p_EmptyElementEnumerated);

		// event associated with syntax rule EmptyElementEnumerated
		public event EmptyElementEnumerated_Callback EmptyElementEnumerated_Event;

		// event trigger associated with syntax rule EmptyElementEnumerated
		public bool Raise_EmptyElementEnumerated_Event (SyntaxTreeCallbackReason reason, EmptyElementEnumerated.production_kind kind, EmptyElementEnumerated p_EmptyElementEnumerated)
		{
			bool? status = EmptyElementEnumerated_Event?.Invoke (reason, kind, p_EmptyElementEnumerated);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule EmptyElementEnumerated
		//
		// traverse syntax tree node associated with any production of syntax rule EmptyElementEnumerated
		//

		public void Traverse (EmptyElementEnumerated p_EmptyElementEnumerated)
		{
			if (p_EmptyElementEnumerated.isLocked())
				return;
			p_EmptyElementEnumerated.dolock();
			EmptyElementEnumerated.production_kind kind = (EmptyElementEnumerated.production_kind) p_EmptyElementEnumerated.kind;
			p_EmptyElementEnumerated.turn_reset ();
			if (Raise_EmptyElementEnumerated_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_EmptyElementEnumerated))
			switch (kind)
			{
				case EmptyElementEnumerated.production_kind.g_EmptyElementEnumerated_1:
					// traverse syntax tree node associated with production
					// EmptyElementEnumerated: "<" identifier-token "/>"

					if (Raise_EmptyElementEnumerated_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EmptyElementEnumerated))
						Traverse (p_EmptyElementEnumerated.m_identifier_token);
					p_EmptyElementEnumerated.turn_inc ();
					Raise_EmptyElementEnumerated_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EmptyElementEnumerated);
				break;
			}
			Raise_EmptyElementEnumerated_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_EmptyElementEnumerated);
			p_EmptyElementEnumerated.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule EmptyElementEnumerated
		//

		public void TraverseCommon (EmptyElementEnumerated p_EmptyElementEnumerated)
		{
			EmptyElementEnumerated.production_kind kind = (EmptyElementEnumerated.production_kind) p_EmptyElementEnumerated.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_EmptyElementEnumerated))
			switch (kind)
			{
				case EmptyElementEnumerated.production_kind.g_EmptyElementEnumerated_1:
					// traverse syntax tree node associated with production
					// EmptyElementEnumerated: "<" identifier-token "/>"

						TraverseCommon (p_EmptyElementEnumerated.m_less_sign);
						TraverseCommon (p_EmptyElementEnumerated.m_identifier_token);
						TraverseCommon (p_EmptyElementEnumerated.m_xml_single_tag_end_item);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_EmptyElementEnumerated);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule EmptyElementEnumerated

		//
		// create syntax tree node associated with production
		// EmptyElementEnumerated: "<" identifier-token "/>"

		//

		public EmptyElementEnumerated EmptyElementEnumerated_1 (SyntaxTreeToken p_token, identifier_token p_identifier_token, SyntaxTreeToken p_token_1)
		{
			EmptyElementEnumerated p_EmptyElementEnumerated_ref = new EmptyElementEnumerated(p_token, p_identifier_token, p_token_1);
			p_token.parent = p_EmptyElementEnumerated_ref;
			p_identifier_token.parent = p_EmptyElementEnumerated_ref;
			p_token_1.parent = p_EmptyElementEnumerated_ref;
			Raise_EmptyElementEnumerated_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EmptyElementEnumerated.production_kind.g_EmptyElementEnumerated_1, p_EmptyElementEnumerated_ref);
			return p_EmptyElementEnumerated_ref;
		}
		#endregion
	};
}
