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
	// class associated with syntax rule EmptyElementInteger
	//

	[DataContract]
	public class	EmptyElementInteger : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule EmptyElementInteger
		public enum production_kind : ushort	// enumerated production(s) of syntax rule EmptyElementInteger
		{
			g_EmptyElementInteger_1 = 1,	// %empty

			g_EmptyElementInteger_2 = 2,	// "<" identifier-token "/>"

		};
		#endregion
		#region production markers associated with the syntax rule EmptyElementInteger

		// markers associated with production: EmptyElementInteger -> %empty

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: EmptyElementInteger -> "<" identifier-token "/>"

		public enum production_marker_2 : ushort
		{
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule EmptyElementInteger

		// Constructor declaration(s) associated with production(s) of syntax rule EmptyElementInteger

		//
		// Constructor associated with the following production(s)
		// EmptyElementInteger -> %empty

		//

		public EmptyElementInteger () : base ((uint) ProductionID._EmptyElementInteger_ID, (uint) production_kind.g_EmptyElementInteger_1)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		//
		// Constructor associated with the following production(s)
		// EmptyElementInteger -> "<" identifier-token "/>"

		//

		public EmptyElementInteger (SyntaxTreeToken p_token, identifier_token p_identifier_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._EmptyElementInteger_ID, (uint) production_kind.g_EmptyElementInteger_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_less_sign = p_token;
			children[1] = m_identifier_token = p_identifier_token;
			children[2] = m_xml_single_tag_end_item = p_token_1;
		}

		// Copy constructor

		public EmptyElementInteger (EmptyElementInteger p_EmptyElementInteger) : base (p_EmptyElementInteger.id, p_EmptyElementInteger.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_EmptyElementInteger.appInfo;
			switch ((production_kind) p_EmptyElementInteger.kind)
			{
				case production_kind.g_EmptyElementInteger_1:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				case production_kind.g_EmptyElementInteger_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_less_sign = (p_EmptyElementInteger.m_less_sign != null) ? new SyntaxTreeToken (p_EmptyElementInteger.m_less_sign) : null) != null) m_less_sign.parent = this;
					if ((children [1] = m_identifier_token = (p_EmptyElementInteger.m_identifier_token != null) ? new identifier_token (p_EmptyElementInteger.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [2] = m_xml_single_tag_end_item = (p_EmptyElementInteger.m_xml_single_tag_end_item != null) ? new SyntaxTreeToken (p_EmptyElementInteger.m_xml_single_tag_end_item) : null) != null) m_xml_single_tag_end_item.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "EmptyElementInteger" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new EmptyElementInteger (this); }

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
		#region Content changing and inclusion checking methods associated with the syntax rule EmptyElementInteger

		// Content changing function(s) associated with production(s) of syntax rule EmptyElementInteger

		//
		// Content changing function associated with following production(s)
		// EmptyElementInteger -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_EmptyElementInteger_1;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// EmptyElementInteger -> "<" identifier-token "/>"

		//

		public void change(SyntaxTreeToken p_token, identifier_token p_identifier_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_EmptyElementInteger_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_less_sign = p_token;
			children [1] = m_identifier_token = p_identifier_token;
			children [2] = m_xml_single_tag_end_item = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule EmptyElementInteger
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
		#region Syntax tree emit methods associated with the syntax rule EmptyElementInteger

		//
		// emit production tree node associated with any production of syntax rule EmptyElementInteger
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_EmptyElementInteger_1:
					// emit syntax tree node associated with production
					// EmptyElementInteger: %empty

				break;
				case production_kind.g_EmptyElementInteger_2:
					// emit syntax tree node associated with production
					// EmptyElementInteger: "<" identifier-token "/>"

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
		// emit production tree node associated with any production of syntax rule EmptyElementInteger
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "EmptyElementInteger (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_EmptyElementInteger_1:
					// emit syntax tree node associated with production
					// EmptyElementInteger: %empty

				break;
				case production_kind.g_EmptyElementInteger_2:
					// emit syntax tree node associated with production
					// EmptyElementInteger: "<" identifier-token "/>"

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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule EmptyElementInteger

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule EmptyElementInteger with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			EmptyElementInteger.production_kind kind = (EmptyElementInteger.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case EmptyElementInteger.production_kind.g_EmptyElementInteger_1:
					// traverse syntax tree node associated with production
					// EmptyElementInteger: %empty

				break;
				case EmptyElementInteger.production_kind.g_EmptyElementInteger_2:
					// traverse syntax tree node associated with production
					// EmptyElementInteger: "<" identifier-token "/>"

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
		// initialize object associated with syntax rule EmptyElementInteger
		//

		public void _init ()
		{
			m_less_sign = null;
			m_identifier_token = null;
			m_xml_single_tag_end_item = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule EmptyElementInteger

		// counter of all nodes associated with syntax rule EmptyElementInteger
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule EmptyElementInteger
		[DataMember (Name = "m_less_sign")] public SyntaxTreeToken m_less_sign { get; private set; }
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_xml_single_tag_end_item")] public SyntaxTreeToken m_xml_single_tag_end_item { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule EmptyElementInteger

		// delegate function (callback) prototype associated with syntax rule EmptyElementInteger
		public delegate bool EmptyElementInteger_Callback (SyntaxTreeCallbackReason reason, EmptyElementInteger.production_kind kind, EmptyElementInteger p_EmptyElementInteger);

		// event associated with syntax rule EmptyElementInteger
		public event EmptyElementInteger_Callback EmptyElementInteger_Event;

		// event trigger associated with syntax rule EmptyElementInteger
		public bool Raise_EmptyElementInteger_Event (SyntaxTreeCallbackReason reason, EmptyElementInteger.production_kind kind, EmptyElementInteger p_EmptyElementInteger)
		{
			bool? status = EmptyElementInteger_Event?.Invoke (reason, kind, p_EmptyElementInteger);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule EmptyElementInteger
		//
		// traverse syntax tree node associated with any production of syntax rule EmptyElementInteger
		//

		public void Traverse (EmptyElementInteger p_EmptyElementInteger)
		{
			if (p_EmptyElementInteger.isLocked())
				return;
			p_EmptyElementInteger.dolock();
			EmptyElementInteger.production_kind kind = (EmptyElementInteger.production_kind) p_EmptyElementInteger.kind;
			p_EmptyElementInteger.turn_reset ();
			if (Raise_EmptyElementInteger_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_EmptyElementInteger))
			switch (kind)
			{
				case EmptyElementInteger.production_kind.g_EmptyElementInteger_1:
					// traverse syntax tree node associated with production
					// EmptyElementInteger: %empty

				break;
				case EmptyElementInteger.production_kind.g_EmptyElementInteger_2:
					// traverse syntax tree node associated with production
					// EmptyElementInteger: "<" identifier-token "/>"

					if (Raise_EmptyElementInteger_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EmptyElementInteger))
						Traverse (p_EmptyElementInteger.m_identifier_token);
					p_EmptyElementInteger.turn_inc ();
					Raise_EmptyElementInteger_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EmptyElementInteger);
				break;
			}
			Raise_EmptyElementInteger_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_EmptyElementInteger);
			p_EmptyElementInteger.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule EmptyElementInteger
		//

		public void TraverseCommon (EmptyElementInteger p_EmptyElementInteger)
		{
			EmptyElementInteger.production_kind kind = (EmptyElementInteger.production_kind) p_EmptyElementInteger.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_EmptyElementInteger))
			switch (kind)
			{
				case EmptyElementInteger.production_kind.g_EmptyElementInteger_1:
					// traverse syntax tree node associated with production
					// EmptyElementInteger: %empty

				break;
				case EmptyElementInteger.production_kind.g_EmptyElementInteger_2:
					// traverse syntax tree node associated with production
					// EmptyElementInteger: "<" identifier-token "/>"

						TraverseCommon (p_EmptyElementInteger.m_less_sign);
						TraverseCommon (p_EmptyElementInteger.m_identifier_token);
						TraverseCommon (p_EmptyElementInteger.m_xml_single_tag_end_item);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_EmptyElementInteger);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule EmptyElementInteger

		//
		// create syntax tree node associated with production
		// EmptyElementInteger: %empty

		//

		public EmptyElementInteger EmptyElementInteger_1 ()
		{
			EmptyElementInteger p_EmptyElementInteger_ref = new EmptyElementInteger();
			Raise_EmptyElementInteger_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EmptyElementInteger.production_kind.g_EmptyElementInteger_1, p_EmptyElementInteger_ref);
			return p_EmptyElementInteger_ref;
		}

		//
		// create syntax tree node associated with production
		// EmptyElementInteger: "<" identifier-token "/>"

		//

		public EmptyElementInteger EmptyElementInteger_2 (SyntaxTreeToken p_token, identifier_token p_identifier_token, SyntaxTreeToken p_token_1)
		{
			EmptyElementInteger p_EmptyElementInteger_ref = new EmptyElementInteger(p_token, p_identifier_token, p_token_1);
			p_token.parent = p_EmptyElementInteger_ref;
			p_identifier_token.parent = p_EmptyElementInteger_ref;
			p_token_1.parent = p_EmptyElementInteger_ref;
			Raise_EmptyElementInteger_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EmptyElementInteger.production_kind.g_EmptyElementInteger_2, p_EmptyElementInteger_ref);
			return p_EmptyElementInteger_ref;
		}
		#endregion
	};
}
