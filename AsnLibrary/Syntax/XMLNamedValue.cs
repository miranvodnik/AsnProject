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
	// class associated with syntax rule XMLNamedValue
	//

	[DataContract]
	public class	XMLNamedValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLNamedValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLNamedValue
		{
			g_XMLNamedValue_1 = 1,	// "<" identifier-token ">" XMLValue "</" identifier-token ">"

		};
		#endregion
		#region production markers associated with the syntax rule XMLNamedValue

		// markers associated with production: XMLNamedValue -> "<" identifier-token ">" XMLValue "</" identifier-token ">"

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			m_XMLValue,
			m_identifier_token_1,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLNamedValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLNamedValue

		//
		// Constructor associated with the following production(s)
		// XMLNamedValue -> "<" identifier-token ">" XMLValue "</" identifier-token ">"

		//

		public XMLNamedValue (SyntaxTreeToken p_token, identifier_token p_identifier_token, SyntaxTreeToken p_token_1, XMLValue p_XMLValue, SyntaxTreeToken p_token_2, identifier_token p_identifier_token_1, SyntaxTreeToken p_token_3) : base ((uint) ProductionID._XMLNamedValue_ID, (uint) production_kind.g_XMLNamedValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children[0] = m_less_sign = p_token;
			children[1] = m_identifier_token = p_identifier_token;
			children[2] = m_greater_sign = p_token_1;
			children[3] = m_XMLValue = p_XMLValue;
			children[4] = m_xml_end_tag_start_item = p_token_2;
			children[5] = m_identifier_token_1 = p_identifier_token_1;
			children[6] = m_greater_sign_1 = p_token_3;
		}

		public XMLNamedValue () { }

		// Copy constructor

		public XMLNamedValue (XMLNamedValue p_XMLNamedValue) : base (p_XMLNamedValue.id, p_XMLNamedValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLNamedValue.appInfo;
			switch ((production_kind) p_XMLNamedValue.kind)
			{
				case production_kind.g_XMLNamedValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
					if ((children [0] = m_less_sign = (p_XMLNamedValue.m_less_sign != null) ? new SyntaxTreeToken (p_XMLNamedValue.m_less_sign) : null) != null) m_less_sign.parent = this;
					if ((children [1] = m_identifier_token = (p_XMLNamedValue.m_identifier_token != null) ? new identifier_token (p_XMLNamedValue.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [2] = m_greater_sign = (p_XMLNamedValue.m_greater_sign != null) ? new SyntaxTreeToken (p_XMLNamedValue.m_greater_sign) : null) != null) m_greater_sign.parent = this;
					if ((children [3] = m_XMLValue = (p_XMLNamedValue.m_XMLValue != null) ? new XMLValue (p_XMLNamedValue.m_XMLValue) : null) != null) m_XMLValue.parent = this;
					if ((children [4] = m_xml_end_tag_start_item = (p_XMLNamedValue.m_xml_end_tag_start_item != null) ? new SyntaxTreeToken (p_XMLNamedValue.m_xml_end_tag_start_item) : null) != null) m_xml_end_tag_start_item.parent = this;
					if ((children [5] = m_identifier_token_1 = (p_XMLNamedValue.m_identifier_token_1 != null) ? new identifier_token (p_XMLNamedValue.m_identifier_token_1) : null) != null) m_identifier_token_1.parent = this;
					if ((children [6] = m_greater_sign_1 = (p_XMLNamedValue.m_greater_sign_1 != null) ? new SyntaxTreeToken (p_XMLNamedValue.m_greater_sign_1) : null) != null) m_greater_sign_1.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLNamedValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLNamedValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_less_sign?.Dispose ();
			m_identifier_token?.Dispose ();
			m_identifier_token_1?.Dispose ();
			m_greater_sign?.Dispose ();
			m_greater_sign_1?.Dispose ();
			m_XMLValue?.Dispose ();
			m_xml_end_tag_start_item?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLNamedValue

		// Content changing function(s) associated with production(s) of syntax rule XMLNamedValue

		//
		// Content changing function associated with following production(s)
		// XMLNamedValue -> "<" identifier-token ">" XMLValue "</" identifier-token ">"

		//

		public void change(SyntaxTreeToken p_token, identifier_token p_identifier_token, SyntaxTreeToken p_token_1, XMLValue p_XMLValue, SyntaxTreeToken p_token_2, identifier_token p_identifier_token_1, SyntaxTreeToken p_token_3)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLNamedValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children [0] = m_less_sign = p_token;
			children [1] = m_identifier_token = p_identifier_token;
			children [2] = m_greater_sign = p_token_1;
			children [3] = m_XMLValue = p_XMLValue;
			children [4] = m_xml_end_tag_start_item = p_token_2;
			children [5] = m_identifier_token_1 = p_identifier_token_1;
			children [6] = m_greater_sign_1 = p_token_3;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLNamedValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_less_sign != null) && m_less_sign.checkInclusion (element) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				(m_identifier_token_1 != null) && m_identifier_token_1.checkInclusion (element) ||
				(m_greater_sign != null) && m_greater_sign.checkInclusion (element) ||
				(m_greater_sign_1 != null) && m_greater_sign_1.checkInclusion (element) ||
				(m_XMLValue != null) && m_XMLValue.checkInclusion (element) ||
				(m_xml_end_tag_start_item != null) && m_xml_end_tag_start_item.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLNamedValue

		//
		// emit production tree node associated with any production of syntax rule XMLNamedValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLNamedValue_1:
					// emit syntax tree node associated with production
					// XMLNamedValue: "<" identifier-token ">" XMLValue "</" identifier-token ">"

					s += m_less_sign.Emit (depth - 1);
					s += " ";
					s += m_identifier_token.Emit (depth - 1);
					s += " ";
					s += m_greater_sign.Emit (depth - 1);
					s += " ";
					s += m_XMLValue.Emit (depth - 1);
					s += " ";
					s += m_xml_end_tag_start_item.Emit (depth - 1);
					s += " ";
					s += m_identifier_token_1.Emit (depth - 1);
					s += " ";
					s += m_greater_sign_1.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLNamedValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLNamedValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLNamedValue_1:
					// emit syntax tree node associated with production
					// XMLNamedValue: "<" identifier-token ">" XMLValue "</" identifier-token ">"

					s += "less_sign";
					s += ' ';
					s += m_identifier_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "greater_sign";
					s += ' ';
					s += m_XMLValue.EmitProductionTree (depth - 1);
					s += ' ';
					s += "xml_end_tag_start_item";
					s += ' ';
					s += m_identifier_token_1.EmitProductionTree (depth - 1);
					s += ' ';
					s += "greater_sign";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLNamedValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLNamedValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLNamedValue.production_kind kind = (XMLNamedValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLNamedValue.production_kind.g_XMLNamedValue_1:
					// traverse syntax tree node associated with production
					// XMLNamedValue: "<" identifier-token ">" XMLValue "</" identifier-token ">"

						m_less_sign.Visit (visitor, appData);
						m_identifier_token.Visit (visitor, appData);
						m_greater_sign.Visit (visitor, appData);
						m_XMLValue.Visit (visitor, appData);
						m_xml_end_tag_start_item.Visit (visitor, appData);
						m_identifier_token_1.Visit (visitor, appData);
						m_greater_sign_1.Visit (visitor, appData);
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
			m_identifier_token_1?.reparent (this);

			m_greater_sign?.reparent (this);
			m_greater_sign_1?.reparent (this);

			m_XMLValue?.reparent (this);
			m_xml_end_tag_start_item?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLNamedValue
		//

		public void _init ()
		{
			m_less_sign = null;
			m_identifier_token = null;
			m_identifier_token_1 = null;
			m_greater_sign = null;
			m_greater_sign_1 = null;
			m_XMLValue = null;
			m_xml_end_tag_start_item = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLNamedValue

		// counter of all nodes associated with syntax rule XMLNamedValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLNamedValue
		[DataMember (Name = "m_less_sign")] public SyntaxTreeToken m_less_sign { get; private set; }
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_identifier_token_1")] public identifier_token m_identifier_token_1 { get; private set; }
		[DataMember (Name = "m_greater_sign")] public SyntaxTreeToken m_greater_sign { get; private set; }
		[DataMember (Name = "m_greater_sign_1")] public SyntaxTreeToken m_greater_sign_1 { get; private set; }
		[DataMember (Name = "m_XMLValue")] public XMLValue m_XMLValue { get; private set; }
		[DataMember (Name = "m_xml_end_tag_start_item")] public SyntaxTreeToken m_xml_end_tag_start_item { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLNamedValue

		// delegate function (callback) prototype associated with syntax rule XMLNamedValue
		public delegate bool XMLNamedValue_Callback (SyntaxTreeCallbackReason reason, XMLNamedValue.production_kind kind, XMLNamedValue p_XMLNamedValue);

		// event associated with syntax rule XMLNamedValue
		public event XMLNamedValue_Callback XMLNamedValue_Event;

		// event trigger associated with syntax rule XMLNamedValue
		public bool Raise_XMLNamedValue_Event (SyntaxTreeCallbackReason reason, XMLNamedValue.production_kind kind, XMLNamedValue p_XMLNamedValue)
		{
			bool? status = XMLNamedValue_Event?.Invoke (reason, kind, p_XMLNamedValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLNamedValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLNamedValue
		//

		public void Traverse (XMLNamedValue p_XMLNamedValue)
		{
			if (p_XMLNamedValue.isLocked())
				return;
			p_XMLNamedValue.dolock();
			XMLNamedValue.production_kind kind = (XMLNamedValue.production_kind) p_XMLNamedValue.kind;
			p_XMLNamedValue.turn_reset ();
			if (Raise_XMLNamedValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLNamedValue))
			switch (kind)
			{
				case XMLNamedValue.production_kind.g_XMLNamedValue_1:
					// traverse syntax tree node associated with production
					// XMLNamedValue: "<" identifier-token ">" XMLValue "</" identifier-token ">"

					if (Raise_XMLNamedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLNamedValue))
						Traverse (p_XMLNamedValue.m_identifier_token);
					p_XMLNamedValue.turn_inc ();
					if (Raise_XMLNamedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLNamedValue))
						Traverse (p_XMLNamedValue.m_XMLValue);
					p_XMLNamedValue.turn_inc ();
					if (Raise_XMLNamedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLNamedValue))
						Traverse (p_XMLNamedValue.m_identifier_token_1);
					p_XMLNamedValue.turn_inc ();
					Raise_XMLNamedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLNamedValue);
				break;
			}
			Raise_XMLNamedValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLNamedValue);
			p_XMLNamedValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLNamedValue
		//

		public void TraverseCommon (XMLNamedValue p_XMLNamedValue)
		{
			XMLNamedValue.production_kind kind = (XMLNamedValue.production_kind) p_XMLNamedValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLNamedValue))
			switch (kind)
			{
				case XMLNamedValue.production_kind.g_XMLNamedValue_1:
					// traverse syntax tree node associated with production
					// XMLNamedValue: "<" identifier-token ">" XMLValue "</" identifier-token ">"

						TraverseCommon (p_XMLNamedValue.m_less_sign);
						TraverseCommon (p_XMLNamedValue.m_identifier_token);
						TraverseCommon (p_XMLNamedValue.m_greater_sign);
						TraverseCommon (p_XMLNamedValue.m_XMLValue);
						TraverseCommon (p_XMLNamedValue.m_xml_end_tag_start_item);
						TraverseCommon (p_XMLNamedValue.m_identifier_token_1);
						TraverseCommon (p_XMLNamedValue.m_greater_sign_1);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLNamedValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLNamedValue

		//
		// create syntax tree node associated with production
		// XMLNamedValue: "<" identifier-token ">" XMLValue "</" identifier-token ">"

		//

		public XMLNamedValue XMLNamedValue_1 (SyntaxTreeToken p_token, identifier_token p_identifier_token, SyntaxTreeToken p_token_1, XMLValue p_XMLValue, SyntaxTreeToken p_token_2, identifier_token p_identifier_token_1, SyntaxTreeToken p_token_3)
		{
			XMLNamedValue p_XMLNamedValue_ref = new XMLNamedValue(p_token, p_identifier_token, p_token_1, p_XMLValue, p_token_2, p_identifier_token_1, p_token_3);
			p_token.parent = p_XMLNamedValue_ref;
			p_identifier_token.parent = p_XMLNamedValue_ref;
			p_token_1.parent = p_XMLNamedValue_ref;
			p_XMLValue.parent = p_XMLNamedValue_ref;
			p_token_2.parent = p_XMLNamedValue_ref;
			p_identifier_token_1.parent = p_XMLNamedValue_ref;
			p_token_3.parent = p_XMLNamedValue_ref;
			Raise_XMLNamedValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLNamedValue.production_kind.g_XMLNamedValue_1, p_XMLNamedValue_ref);
			return p_XMLNamedValue_ref;
		}
		#endregion
	};
}
