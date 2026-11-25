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
	// class associated with syntax rule XMLDelimitedItem
	//

	[DataContract]
	public class	XMLDelimitedItem : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLDelimitedItem
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLDelimitedItem
		{
			g_XMLDelimitedItem_1 = 1,	// "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

			g_XMLDelimitedItem_2 = 2,	// "<" identifier-token ">" XMLValue "</" identifier-token ">"

		};
		#endregion
		#region production markers associated with the syntax rule XMLDelimitedItem

		// markers associated with production: XMLDelimitedItem -> "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

		public enum production_marker_1 : ushort
		{
			m_NonParameterizedTypeName,
			m_XMLValue,
			m_NonParameterizedTypeName_1,
			final
		};

		// markers associated with production: XMLDelimitedItem -> "<" identifier-token ">" XMLValue "</" identifier-token ">"

		public enum production_marker_2 : ushort
		{
			m_identifier_token,
			m_XMLValue,
			m_identifier_token_1,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLDelimitedItem

		// Constructor declaration(s) associated with production(s) of syntax rule XMLDelimitedItem

		//
		// Constructor associated with the following production(s)
		// XMLDelimitedItem -> "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

		//

		public XMLDelimitedItem (SyntaxTreeToken p_token, NonParameterizedTypeName p_NonParameterizedTypeName, SyntaxTreeToken p_token_1, XMLValue p_XMLValue, SyntaxTreeToken p_token_2, NonParameterizedTypeName p_NonParameterizedTypeName_1, SyntaxTreeToken p_token_3) : base ((uint) ProductionID._XMLDelimitedItem_ID, (uint) production_kind.g_XMLDelimitedItem_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children[0] = m_less_sign = p_token;
			children[1] = m_NonParameterizedTypeName = p_NonParameterizedTypeName;
			children[2] = m_greater_sign = p_token_1;
			children[3] = m_XMLValue = p_XMLValue;
			children[4] = m_xml_end_tag_start_item = p_token_2;
			children[5] = m_NonParameterizedTypeName_1 = p_NonParameterizedTypeName_1;
			children[6] = m_greater_sign_1 = p_token_3;
		}

		//
		// Constructor associated with the following production(s)
		// XMLDelimitedItem -> "<" identifier-token ">" XMLValue "</" identifier-token ">"

		//

		public XMLDelimitedItem (SyntaxTreeToken p_token, identifier_token p_identifier_token, SyntaxTreeToken p_token_1, XMLValue p_XMLValue, SyntaxTreeToken p_token_2, identifier_token p_identifier_token_1, SyntaxTreeToken p_token_3) : base ((uint) ProductionID._XMLDelimitedItem_ID, (uint) production_kind.g_XMLDelimitedItem_2)
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

		public XMLDelimitedItem () { }

		// Copy constructor

		public XMLDelimitedItem (XMLDelimitedItem p_XMLDelimitedItem) : base (p_XMLDelimitedItem.id, p_XMLDelimitedItem.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLDelimitedItem.appInfo;
			switch ((production_kind) p_XMLDelimitedItem.kind)
			{
				case production_kind.g_XMLDelimitedItem_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
					if ((children [0] = m_less_sign = (p_XMLDelimitedItem.m_less_sign != null) ? new SyntaxTreeToken (p_XMLDelimitedItem.m_less_sign) : null) != null) m_less_sign.parent = this;
					if ((children [1] = m_NonParameterizedTypeName = (p_XMLDelimitedItem.m_NonParameterizedTypeName != null) ? new NonParameterizedTypeName (p_XMLDelimitedItem.m_NonParameterizedTypeName) : null) != null) m_NonParameterizedTypeName.parent = this;
					if ((children [2] = m_greater_sign = (p_XMLDelimitedItem.m_greater_sign != null) ? new SyntaxTreeToken (p_XMLDelimitedItem.m_greater_sign) : null) != null) m_greater_sign.parent = this;
					if ((children [3] = m_XMLValue = (p_XMLDelimitedItem.m_XMLValue != null) ? new XMLValue (p_XMLDelimitedItem.m_XMLValue) : null) != null) m_XMLValue.parent = this;
					if ((children [4] = m_xml_end_tag_start_item = (p_XMLDelimitedItem.m_xml_end_tag_start_item != null) ? new SyntaxTreeToken (p_XMLDelimitedItem.m_xml_end_tag_start_item) : null) != null) m_xml_end_tag_start_item.parent = this;
					if ((children [5] = m_NonParameterizedTypeName_1 = (p_XMLDelimitedItem.m_NonParameterizedTypeName_1 != null) ? new NonParameterizedTypeName (p_XMLDelimitedItem.m_NonParameterizedTypeName_1) : null) != null) m_NonParameterizedTypeName_1.parent = this;
					if ((children [6] = m_greater_sign_1 = (p_XMLDelimitedItem.m_greater_sign_1 != null) ? new SyntaxTreeToken (p_XMLDelimitedItem.m_greater_sign_1) : null) != null) m_greater_sign_1.parent = this;
					break;
				case production_kind.g_XMLDelimitedItem_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
					if ((children [0] = m_less_sign = (p_XMLDelimitedItem.m_less_sign != null) ? new SyntaxTreeToken (p_XMLDelimitedItem.m_less_sign) : null) != null) m_less_sign.parent = this;
					if ((children [1] = m_identifier_token = (p_XMLDelimitedItem.m_identifier_token != null) ? new identifier_token (p_XMLDelimitedItem.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [2] = m_greater_sign = (p_XMLDelimitedItem.m_greater_sign != null) ? new SyntaxTreeToken (p_XMLDelimitedItem.m_greater_sign) : null) != null) m_greater_sign.parent = this;
					if ((children [3] = m_XMLValue = (p_XMLDelimitedItem.m_XMLValue != null) ? new XMLValue (p_XMLDelimitedItem.m_XMLValue) : null) != null) m_XMLValue.parent = this;
					if ((children [4] = m_xml_end_tag_start_item = (p_XMLDelimitedItem.m_xml_end_tag_start_item != null) ? new SyntaxTreeToken (p_XMLDelimitedItem.m_xml_end_tag_start_item) : null) != null) m_xml_end_tag_start_item.parent = this;
					if ((children [5] = m_identifier_token_1 = (p_XMLDelimitedItem.m_identifier_token_1 != null) ? new identifier_token (p_XMLDelimitedItem.m_identifier_token_1) : null) != null) m_identifier_token_1.parent = this;
					if ((children [6] = m_greater_sign_1 = (p_XMLDelimitedItem.m_greater_sign_1 != null) ? new SyntaxTreeToken (p_XMLDelimitedItem.m_greater_sign_1) : null) != null) m_greater_sign_1.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLDelimitedItem" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLDelimitedItem (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_less_sign?.Dispose ();
			m_NonParameterizedTypeName?.Dispose ();
			m_NonParameterizedTypeName_1?.Dispose ();
			m_greater_sign?.Dispose ();
			m_greater_sign_1?.Dispose ();
			m_XMLValue?.Dispose ();
			m_xml_end_tag_start_item?.Dispose ();
			m_identifier_token?.Dispose ();
			m_identifier_token_1?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLDelimitedItem

		// Content changing function(s) associated with production(s) of syntax rule XMLDelimitedItem

		//
		// Content changing function associated with following production(s)
		// XMLDelimitedItem -> "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

		//

		public void change(SyntaxTreeToken p_token, NonParameterizedTypeName p_NonParameterizedTypeName, SyntaxTreeToken p_token_1, XMLValue p_XMLValue, SyntaxTreeToken p_token_2, NonParameterizedTypeName p_NonParameterizedTypeName_1, SyntaxTreeToken p_token_3)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLDelimitedItem_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children [0] = m_less_sign = p_token;
			children [1] = m_NonParameterizedTypeName = p_NonParameterizedTypeName;
			children [2] = m_greater_sign = p_token_1;
			children [3] = m_XMLValue = p_XMLValue;
			children [4] = m_xml_end_tag_start_item = p_token_2;
			children [5] = m_NonParameterizedTypeName_1 = p_NonParameterizedTypeName_1;
			children [6] = m_greater_sign_1 = p_token_3;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLDelimitedItem -> "<" identifier-token ">" XMLValue "</" identifier-token ">"

		//

		public void change(SyntaxTreeToken p_token, identifier_token p_identifier_token, SyntaxTreeToken p_token_1, XMLValue p_XMLValue, SyntaxTreeToken p_token_2, identifier_token p_identifier_token_1, SyntaxTreeToken p_token_3)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLDelimitedItem_2;
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
		// check if node 'element' is included within syntax tree associated with syntax rule XMLDelimitedItem
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_less_sign != null) && m_less_sign.checkInclusion (element) ||
				(m_NonParameterizedTypeName != null) && m_NonParameterizedTypeName.checkInclusion (element) ||
				(m_NonParameterizedTypeName_1 != null) && m_NonParameterizedTypeName_1.checkInclusion (element) ||
				(m_greater_sign != null) && m_greater_sign.checkInclusion (element) ||
				(m_greater_sign_1 != null) && m_greater_sign_1.checkInclusion (element) ||
				(m_XMLValue != null) && m_XMLValue.checkInclusion (element) ||
				(m_xml_end_tag_start_item != null) && m_xml_end_tag_start_item.checkInclusion (element) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				(m_identifier_token_1 != null) && m_identifier_token_1.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLDelimitedItem

		//
		// emit production tree node associated with any production of syntax rule XMLDelimitedItem
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLDelimitedItem_1:
					// emit syntax tree node associated with production
					// XMLDelimitedItem: "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

					s += m_less_sign.Emit (depth - 1);
					s += " ";
					s += m_NonParameterizedTypeName.Emit (depth - 1);
					s += " ";
					s += m_greater_sign.Emit (depth - 1);
					s += " ";
					s += m_XMLValue.Emit (depth - 1);
					s += " ";
					s += m_xml_end_tag_start_item.Emit (depth - 1);
					s += " ";
					s += m_NonParameterizedTypeName_1.Emit (depth - 1);
					s += " ";
					s += m_greater_sign_1.Emit (depth - 1);
				break;
				case production_kind.g_XMLDelimitedItem_2:
					// emit syntax tree node associated with production
					// XMLDelimitedItem: "<" identifier-token ">" XMLValue "</" identifier-token ">"

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
		// emit production tree node associated with any production of syntax rule XMLDelimitedItem
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLDelimitedItem (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLDelimitedItem_1:
					// emit syntax tree node associated with production
					// XMLDelimitedItem: "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

					s += "less_sign";
					s += ' ';
					s += m_NonParameterizedTypeName.EmitProductionTree (depth - 1);
					s += ' ';
					s += "greater_sign";
					s += ' ';
					s += m_XMLValue.EmitProductionTree (depth - 1);
					s += ' ';
					s += "xml_end_tag_start_item";
					s += ' ';
					s += m_NonParameterizedTypeName_1.EmitProductionTree (depth - 1);
					s += ' ';
					s += "greater_sign";
				break;
				case production_kind.g_XMLDelimitedItem_2:
					// emit syntax tree node associated with production
					// XMLDelimitedItem: "<" identifier-token ">" XMLValue "</" identifier-token ">"

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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLDelimitedItem

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLDelimitedItem with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLDelimitedItem.production_kind kind = (XMLDelimitedItem.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLDelimitedItem.production_kind.g_XMLDelimitedItem_1:
					// traverse syntax tree node associated with production
					// XMLDelimitedItem: "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

						m_less_sign.Visit (visitor, appData);
						m_NonParameterizedTypeName.Visit (visitor, appData);
						m_greater_sign.Visit (visitor, appData);
						m_XMLValue.Visit (visitor, appData);
						m_xml_end_tag_start_item.Visit (visitor, appData);
						m_NonParameterizedTypeName_1.Visit (visitor, appData);
						m_greater_sign_1.Visit (visitor, appData);
				break;
				case XMLDelimitedItem.production_kind.g_XMLDelimitedItem_2:
					// traverse syntax tree node associated with production
					// XMLDelimitedItem: "<" identifier-token ">" XMLValue "</" identifier-token ">"

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
			m_NonParameterizedTypeName?.reparent (this);
			m_NonParameterizedTypeName_1?.reparent (this);

			m_greater_sign?.reparent (this);
			m_greater_sign_1?.reparent (this);

			m_XMLValue?.reparent (this);
			m_xml_end_tag_start_item?.reparent (this);
			m_identifier_token?.reparent (this);
			m_identifier_token_1?.reparent (this);

		}

		//
		// initialize object associated with syntax rule XMLDelimitedItem
		//

		public void _init ()
		{
			m_less_sign = null;
			m_NonParameterizedTypeName = null;
			m_NonParameterizedTypeName_1 = null;
			m_greater_sign = null;
			m_greater_sign_1 = null;
			m_XMLValue = null;
			m_xml_end_tag_start_item = null;
			m_identifier_token = null;
			m_identifier_token_1 = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLDelimitedItem

		// counter of all nodes associated with syntax rule XMLDelimitedItem
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLDelimitedItem
		[DataMember (Name = "m_less_sign")] public SyntaxTreeToken m_less_sign { get; private set; }
		[DataMember (Name = "m_NonParameterizedTypeName")] public NonParameterizedTypeName m_NonParameterizedTypeName { get; private set; }
		[DataMember (Name = "m_NonParameterizedTypeName_1")] public NonParameterizedTypeName m_NonParameterizedTypeName_1 { get; private set; }
		[DataMember (Name = "m_greater_sign")] public SyntaxTreeToken m_greater_sign { get; private set; }
		[DataMember (Name = "m_greater_sign_1")] public SyntaxTreeToken m_greater_sign_1 { get; private set; }
		[DataMember (Name = "m_XMLValue")] public XMLValue m_XMLValue { get; private set; }
		[DataMember (Name = "m_xml_end_tag_start_item")] public SyntaxTreeToken m_xml_end_tag_start_item { get; private set; }
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_identifier_token_1")] public identifier_token m_identifier_token_1 { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLDelimitedItem

		// delegate function (callback) prototype associated with syntax rule XMLDelimitedItem
		public delegate bool XMLDelimitedItem_Callback (SyntaxTreeCallbackReason reason, XMLDelimitedItem.production_kind kind, XMLDelimitedItem p_XMLDelimitedItem);

		// event associated with syntax rule XMLDelimitedItem
		public event XMLDelimitedItem_Callback XMLDelimitedItem_Event;

		// event trigger associated with syntax rule XMLDelimitedItem
		public bool Raise_XMLDelimitedItem_Event (SyntaxTreeCallbackReason reason, XMLDelimitedItem.production_kind kind, XMLDelimitedItem p_XMLDelimitedItem)
		{
			bool? status = XMLDelimitedItem_Event?.Invoke (reason, kind, p_XMLDelimitedItem);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLDelimitedItem
		//
		// traverse syntax tree node associated with any production of syntax rule XMLDelimitedItem
		//

		public void Traverse (XMLDelimitedItem p_XMLDelimitedItem)
		{
			if (p_XMLDelimitedItem.isLocked())
				return;
			p_XMLDelimitedItem.dolock();
			XMLDelimitedItem.production_kind kind = (XMLDelimitedItem.production_kind) p_XMLDelimitedItem.kind;
			p_XMLDelimitedItem.turn_reset ();
			if (Raise_XMLDelimitedItem_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLDelimitedItem))
			switch (kind)
			{
				case XMLDelimitedItem.production_kind.g_XMLDelimitedItem_1:
					// traverse syntax tree node associated with production
					// XMLDelimitedItem: "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

					if (Raise_XMLDelimitedItem_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLDelimitedItem))
						Traverse (p_XMLDelimitedItem.m_NonParameterizedTypeName);
					p_XMLDelimitedItem.turn_inc ();
					if (Raise_XMLDelimitedItem_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLDelimitedItem))
						Traverse (p_XMLDelimitedItem.m_XMLValue);
					p_XMLDelimitedItem.turn_inc ();
					if (Raise_XMLDelimitedItem_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLDelimitedItem))
						Traverse (p_XMLDelimitedItem.m_NonParameterizedTypeName_1);
					p_XMLDelimitedItem.turn_inc ();
					Raise_XMLDelimitedItem_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLDelimitedItem);
				break;
				case XMLDelimitedItem.production_kind.g_XMLDelimitedItem_2:
					// traverse syntax tree node associated with production
					// XMLDelimitedItem: "<" identifier-token ">" XMLValue "</" identifier-token ">"

					if (Raise_XMLDelimitedItem_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLDelimitedItem))
						Traverse (p_XMLDelimitedItem.m_identifier_token);
					p_XMLDelimitedItem.turn_inc ();
					if (Raise_XMLDelimitedItem_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLDelimitedItem))
						Traverse (p_XMLDelimitedItem.m_XMLValue);
					p_XMLDelimitedItem.turn_inc ();
					if (Raise_XMLDelimitedItem_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLDelimitedItem))
						Traverse (p_XMLDelimitedItem.m_identifier_token_1);
					p_XMLDelimitedItem.turn_inc ();
					Raise_XMLDelimitedItem_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLDelimitedItem);
				break;
			}
			Raise_XMLDelimitedItem_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLDelimitedItem);
			p_XMLDelimitedItem.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLDelimitedItem
		//

		public void TraverseCommon (XMLDelimitedItem p_XMLDelimitedItem)
		{
			XMLDelimitedItem.production_kind kind = (XMLDelimitedItem.production_kind) p_XMLDelimitedItem.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLDelimitedItem))
			switch (kind)
			{
				case XMLDelimitedItem.production_kind.g_XMLDelimitedItem_1:
					// traverse syntax tree node associated with production
					// XMLDelimitedItem: "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

						TraverseCommon (p_XMLDelimitedItem.m_less_sign);
						TraverseCommon (p_XMLDelimitedItem.m_NonParameterizedTypeName);
						TraverseCommon (p_XMLDelimitedItem.m_greater_sign);
						TraverseCommon (p_XMLDelimitedItem.m_XMLValue);
						TraverseCommon (p_XMLDelimitedItem.m_xml_end_tag_start_item);
						TraverseCommon (p_XMLDelimitedItem.m_NonParameterizedTypeName_1);
						TraverseCommon (p_XMLDelimitedItem.m_greater_sign_1);
				break;
				case XMLDelimitedItem.production_kind.g_XMLDelimitedItem_2:
					// traverse syntax tree node associated with production
					// XMLDelimitedItem: "<" identifier-token ">" XMLValue "</" identifier-token ">"

						TraverseCommon (p_XMLDelimitedItem.m_less_sign);
						TraverseCommon (p_XMLDelimitedItem.m_identifier_token);
						TraverseCommon (p_XMLDelimitedItem.m_greater_sign);
						TraverseCommon (p_XMLDelimitedItem.m_XMLValue);
						TraverseCommon (p_XMLDelimitedItem.m_xml_end_tag_start_item);
						TraverseCommon (p_XMLDelimitedItem.m_identifier_token_1);
						TraverseCommon (p_XMLDelimitedItem.m_greater_sign_1);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLDelimitedItem);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLDelimitedItem

		//
		// create syntax tree node associated with production
		// XMLDelimitedItem: "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

		//

		public XMLDelimitedItem XMLDelimitedItem_1 (SyntaxTreeToken p_token, NonParameterizedTypeName p_NonParameterizedTypeName, SyntaxTreeToken p_token_1, XMLValue p_XMLValue, SyntaxTreeToken p_token_2, NonParameterizedTypeName p_NonParameterizedTypeName_1, SyntaxTreeToken p_token_3)
		{
			XMLDelimitedItem p_XMLDelimitedItem_ref = new XMLDelimitedItem(p_token, p_NonParameterizedTypeName, p_token_1, p_XMLValue, p_token_2, p_NonParameterizedTypeName_1, p_token_3);
			p_token.parent = p_XMLDelimitedItem_ref;
			p_NonParameterizedTypeName.parent = p_XMLDelimitedItem_ref;
			p_token_1.parent = p_XMLDelimitedItem_ref;
			p_XMLValue.parent = p_XMLDelimitedItem_ref;
			p_token_2.parent = p_XMLDelimitedItem_ref;
			p_NonParameterizedTypeName_1.parent = p_XMLDelimitedItem_ref;
			p_token_3.parent = p_XMLDelimitedItem_ref;
			Raise_XMLDelimitedItem_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLDelimitedItem.production_kind.g_XMLDelimitedItem_1, p_XMLDelimitedItem_ref);
			return p_XMLDelimitedItem_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLDelimitedItem: "<" identifier-token ">" XMLValue "</" identifier-token ">"

		//

		public XMLDelimitedItem XMLDelimitedItem_2 (SyntaxTreeToken p_token, identifier_token p_identifier_token, SyntaxTreeToken p_token_1, XMLValue p_XMLValue, SyntaxTreeToken p_token_2, identifier_token p_identifier_token_1, SyntaxTreeToken p_token_3)
		{
			XMLDelimitedItem p_XMLDelimitedItem_ref = new XMLDelimitedItem(p_token, p_identifier_token, p_token_1, p_XMLValue, p_token_2, p_identifier_token_1, p_token_3);
			p_token.parent = p_XMLDelimitedItem_ref;
			p_identifier_token.parent = p_XMLDelimitedItem_ref;
			p_token_1.parent = p_XMLDelimitedItem_ref;
			p_XMLValue.parent = p_XMLDelimitedItem_ref;
			p_token_2.parent = p_XMLDelimitedItem_ref;
			p_identifier_token_1.parent = p_XMLDelimitedItem_ref;
			p_token_3.parent = p_XMLDelimitedItem_ref;
			Raise_XMLDelimitedItem_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLDelimitedItem.production_kind.g_XMLDelimitedItem_2, p_XMLDelimitedItem_ref);
			return p_XMLDelimitedItem_ref;
		}
		#endregion
	};
}
