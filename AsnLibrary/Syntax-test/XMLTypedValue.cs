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
	// class associated with syntax rule XMLTypedValue
	//

	[DataContract]
	public class	XMLTypedValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLTypedValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLTypedValue
		{
			g_XMLTypedValue_1 = 1,	// "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

			g_XMLTypedValue_2 = 2,	// "<" NonParameterizedTypeName "/>"

		};
		#endregion
		#region production markers associated with the syntax rule XMLTypedValue

		// markers associated with production: XMLTypedValue -> "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

		public enum production_marker_1 : ushort
		{
			m_NonParameterizedTypeName,
			m_XMLValue,
			m_NonParameterizedTypeName_1,
			final
		};

		// markers associated with production: XMLTypedValue -> "<" NonParameterizedTypeName "/>"

		public enum production_marker_2 : ushort
		{
			m_NonParameterizedTypeName,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLTypedValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLTypedValue

		//
		// Constructor associated with the following production(s)
		// XMLTypedValue -> "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

		//

		public XMLTypedValue (SyntaxTreeToken p_token, NonParameterizedTypeName p_NonParameterizedTypeName, SyntaxTreeToken p_token_1, XMLValue p_XMLValue, SyntaxTreeToken p_token_2, NonParameterizedTypeName p_NonParameterizedTypeName_1, SyntaxTreeToken p_token_3) : base ((uint) ProductionID._XMLTypedValue_ID, (uint) production_kind.g_XMLTypedValue_1)
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
		// XMLTypedValue -> "<" NonParameterizedTypeName "/>"

		//

		public XMLTypedValue (SyntaxTreeToken p_token, NonParameterizedTypeName p_NonParameterizedTypeName, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._XMLTypedValue_ID, (uint) production_kind.g_XMLTypedValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_less_sign = p_token;
			children[1] = m_NonParameterizedTypeName = p_NonParameterizedTypeName;
			children[2] = m_xml_single_tag_end_item = p_token_1;
		}

		public XMLTypedValue () { }

		// Copy constructor

		public XMLTypedValue (XMLTypedValue p_XMLTypedValue) : base (p_XMLTypedValue.id, p_XMLTypedValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLTypedValue.appInfo;
			switch ((production_kind) p_XMLTypedValue.kind)
			{
				case production_kind.g_XMLTypedValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
					if ((children [0] = m_less_sign = (p_XMLTypedValue.m_less_sign != null) ? new SyntaxTreeToken (p_XMLTypedValue.m_less_sign) : null) != null) m_less_sign.parent = this;
					if ((children [1] = m_NonParameterizedTypeName = (p_XMLTypedValue.m_NonParameterizedTypeName != null) ? new NonParameterizedTypeName (p_XMLTypedValue.m_NonParameterizedTypeName) : null) != null) m_NonParameterizedTypeName.parent = this;
					if ((children [2] = m_greater_sign = (p_XMLTypedValue.m_greater_sign != null) ? new SyntaxTreeToken (p_XMLTypedValue.m_greater_sign) : null) != null) m_greater_sign.parent = this;
					if ((children [3] = m_XMLValue = (p_XMLTypedValue.m_XMLValue != null) ? new XMLValue (p_XMLTypedValue.m_XMLValue) : null) != null) m_XMLValue.parent = this;
					if ((children [4] = m_xml_end_tag_start_item = (p_XMLTypedValue.m_xml_end_tag_start_item != null) ? new SyntaxTreeToken (p_XMLTypedValue.m_xml_end_tag_start_item) : null) != null) m_xml_end_tag_start_item.parent = this;
					if ((children [5] = m_NonParameterizedTypeName_1 = (p_XMLTypedValue.m_NonParameterizedTypeName_1 != null) ? new NonParameterizedTypeName (p_XMLTypedValue.m_NonParameterizedTypeName_1) : null) != null) m_NonParameterizedTypeName_1.parent = this;
					if ((children [6] = m_greater_sign_1 = (p_XMLTypedValue.m_greater_sign_1 != null) ? new SyntaxTreeToken (p_XMLTypedValue.m_greater_sign_1) : null) != null) m_greater_sign_1.parent = this;
					break;
				case production_kind.g_XMLTypedValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_less_sign = (p_XMLTypedValue.m_less_sign != null) ? new SyntaxTreeToken (p_XMLTypedValue.m_less_sign) : null) != null) m_less_sign.parent = this;
					if ((children [1] = m_NonParameterizedTypeName = (p_XMLTypedValue.m_NonParameterizedTypeName != null) ? new NonParameterizedTypeName (p_XMLTypedValue.m_NonParameterizedTypeName) : null) != null) m_NonParameterizedTypeName.parent = this;
					if ((children [2] = m_xml_single_tag_end_item = (p_XMLTypedValue.m_xml_single_tag_end_item != null) ? new SyntaxTreeToken (p_XMLTypedValue.m_xml_single_tag_end_item) : null) != null) m_xml_single_tag_end_item.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLTypedValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLTypedValue (this); }

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
			m_xml_single_tag_end_item?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLTypedValue

		// Content changing function(s) associated with production(s) of syntax rule XMLTypedValue

		//
		// Content changing function associated with following production(s)
		// XMLTypedValue -> "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

		//

		public void change(SyntaxTreeToken p_token, NonParameterizedTypeName p_NonParameterizedTypeName, SyntaxTreeToken p_token_1, XMLValue p_XMLValue, SyntaxTreeToken p_token_2, NonParameterizedTypeName p_NonParameterizedTypeName_1, SyntaxTreeToken p_token_3)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLTypedValue_1;
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
		// XMLTypedValue -> "<" NonParameterizedTypeName "/>"

		//

		public void change(SyntaxTreeToken p_token, NonParameterizedTypeName p_NonParameterizedTypeName, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLTypedValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_less_sign = p_token;
			children [1] = m_NonParameterizedTypeName = p_NonParameterizedTypeName;
			children [2] = m_xml_single_tag_end_item = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLTypedValue
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
				(m_xml_single_tag_end_item != null) && m_xml_single_tag_end_item.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLTypedValue

		//
		// emit production tree node associated with any production of syntax rule XMLTypedValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLTypedValue_1:
					// emit syntax tree node associated with production
					// XMLTypedValue: "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

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
				case production_kind.g_XMLTypedValue_2:
					// emit syntax tree node associated with production
					// XMLTypedValue: "<" NonParameterizedTypeName "/>"

					s += m_less_sign.Emit (depth - 1);
					s += " ";
					s += m_NonParameterizedTypeName.Emit (depth - 1);
					s += " ";
					s += m_xml_single_tag_end_item.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLTypedValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLTypedValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLTypedValue_1:
					// emit syntax tree node associated with production
					// XMLTypedValue: "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

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
				case production_kind.g_XMLTypedValue_2:
					// emit syntax tree node associated with production
					// XMLTypedValue: "<" NonParameterizedTypeName "/>"

					s += "less_sign";
					s += ' ';
					s += m_NonParameterizedTypeName.EmitProductionTree (depth - 1);
					s += ' ';
					s += "xml_single_tag_end_item";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLTypedValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLTypedValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLTypedValue.production_kind kind = (XMLTypedValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLTypedValue.production_kind.g_XMLTypedValue_1:
					// traverse syntax tree node associated with production
					// XMLTypedValue: "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

						m_less_sign.Visit (visitor, appData);
						m_NonParameterizedTypeName.Visit (visitor, appData);
						m_greater_sign.Visit (visitor, appData);
						m_XMLValue.Visit (visitor, appData);
						m_xml_end_tag_start_item.Visit (visitor, appData);
						m_NonParameterizedTypeName_1.Visit (visitor, appData);
						m_greater_sign_1.Visit (visitor, appData);
				break;
				case XMLTypedValue.production_kind.g_XMLTypedValue_2:
					// traverse syntax tree node associated with production
					// XMLTypedValue: "<" NonParameterizedTypeName "/>"

						m_less_sign.Visit (visitor, appData);
						m_NonParameterizedTypeName.Visit (visitor, appData);
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
			m_NonParameterizedTypeName?.reparent (this);
			m_NonParameterizedTypeName_1?.reparent (this);

			m_greater_sign?.reparent (this);
			m_greater_sign_1?.reparent (this);

			m_XMLValue?.reparent (this);
			m_xml_end_tag_start_item?.reparent (this);
			m_xml_single_tag_end_item?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLTypedValue
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
			m_xml_single_tag_end_item = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLTypedValue

		// counter of all nodes associated with syntax rule XMLTypedValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLTypedValue
		[DataMember (Name = "m_less_sign")] public SyntaxTreeToken m_less_sign { get; private set; }
		[DataMember (Name = "m_NonParameterizedTypeName")] public NonParameterizedTypeName m_NonParameterizedTypeName { get; private set; }
		[DataMember (Name = "m_NonParameterizedTypeName_1")] public NonParameterizedTypeName m_NonParameterizedTypeName_1 { get; private set; }
		[DataMember (Name = "m_greater_sign")] public SyntaxTreeToken m_greater_sign { get; private set; }
		[DataMember (Name = "m_greater_sign_1")] public SyntaxTreeToken m_greater_sign_1 { get; private set; }
		[DataMember (Name = "m_XMLValue")] public XMLValue m_XMLValue { get; private set; }
		[DataMember (Name = "m_xml_end_tag_start_item")] public SyntaxTreeToken m_xml_end_tag_start_item { get; private set; }
		[DataMember (Name = "m_xml_single_tag_end_item")] public SyntaxTreeToken m_xml_single_tag_end_item { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLTypedValue

		// delegate function (callback) prototype associated with syntax rule XMLTypedValue
		public delegate bool XMLTypedValue_Callback (SyntaxTreeCallbackReason reason, XMLTypedValue.production_kind kind, XMLTypedValue p_XMLTypedValue);

		// event associated with syntax rule XMLTypedValue
		public event XMLTypedValue_Callback XMLTypedValue_Event;

		// event trigger associated with syntax rule XMLTypedValue
		public bool Raise_XMLTypedValue_Event (SyntaxTreeCallbackReason reason, XMLTypedValue.production_kind kind, XMLTypedValue p_XMLTypedValue)
		{
			bool? status = XMLTypedValue_Event?.Invoke (reason, kind, p_XMLTypedValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLTypedValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLTypedValue
		//

		public void Traverse (XMLTypedValue p_XMLTypedValue)
		{
			if (p_XMLTypedValue.isLocked())
				return;
			p_XMLTypedValue.dolock();
			XMLTypedValue.production_kind kind = (XMLTypedValue.production_kind) p_XMLTypedValue.kind;
			p_XMLTypedValue.turn_reset ();
			if (Raise_XMLTypedValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLTypedValue))
			switch (kind)
			{
				case XMLTypedValue.production_kind.g_XMLTypedValue_1:
					// traverse syntax tree node associated with production
					// XMLTypedValue: "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

					if (Raise_XMLTypedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLTypedValue))
						Traverse (p_XMLTypedValue.m_NonParameterizedTypeName);
					p_XMLTypedValue.turn_inc ();
					if (Raise_XMLTypedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLTypedValue))
						Traverse (p_XMLTypedValue.m_XMLValue);
					p_XMLTypedValue.turn_inc ();
					if (Raise_XMLTypedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLTypedValue))
						Traverse (p_XMLTypedValue.m_NonParameterizedTypeName_1);
					p_XMLTypedValue.turn_inc ();
					Raise_XMLTypedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLTypedValue);
				break;
				case XMLTypedValue.production_kind.g_XMLTypedValue_2:
					// traverse syntax tree node associated with production
					// XMLTypedValue: "<" NonParameterizedTypeName "/>"

					if (Raise_XMLTypedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLTypedValue))
						Traverse (p_XMLTypedValue.m_NonParameterizedTypeName);
					p_XMLTypedValue.turn_inc ();
					Raise_XMLTypedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLTypedValue);
				break;
			}
			Raise_XMLTypedValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLTypedValue);
			p_XMLTypedValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLTypedValue
		//

		public void TraverseCommon (XMLTypedValue p_XMLTypedValue)
		{
			XMLTypedValue.production_kind kind = (XMLTypedValue.production_kind) p_XMLTypedValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLTypedValue))
			switch (kind)
			{
				case XMLTypedValue.production_kind.g_XMLTypedValue_1:
					// traverse syntax tree node associated with production
					// XMLTypedValue: "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

						TraverseCommon (p_XMLTypedValue.m_less_sign);
						TraverseCommon (p_XMLTypedValue.m_NonParameterizedTypeName);
						TraverseCommon (p_XMLTypedValue.m_greater_sign);
						TraverseCommon (p_XMLTypedValue.m_XMLValue);
						TraverseCommon (p_XMLTypedValue.m_xml_end_tag_start_item);
						TraverseCommon (p_XMLTypedValue.m_NonParameterizedTypeName_1);
						TraverseCommon (p_XMLTypedValue.m_greater_sign_1);
				break;
				case XMLTypedValue.production_kind.g_XMLTypedValue_2:
					// traverse syntax tree node associated with production
					// XMLTypedValue: "<" NonParameterizedTypeName "/>"

						TraverseCommon (p_XMLTypedValue.m_less_sign);
						TraverseCommon (p_XMLTypedValue.m_NonParameterizedTypeName);
						TraverseCommon (p_XMLTypedValue.m_xml_single_tag_end_item);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLTypedValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLTypedValue

		//
		// create syntax tree node associated with production
		// XMLTypedValue: "<" NonParameterizedTypeName ">" XMLValue "</" NonParameterizedTypeName ">"

		//

		public XMLTypedValue XMLTypedValue_1 (SyntaxTreeToken p_token, NonParameterizedTypeName p_NonParameterizedTypeName, SyntaxTreeToken p_token_1, XMLValue p_XMLValue, SyntaxTreeToken p_token_2, NonParameterizedTypeName p_NonParameterizedTypeName_1, SyntaxTreeToken p_token_3)
		{
			XMLTypedValue p_XMLTypedValue_ref = new XMLTypedValue(p_token, p_NonParameterizedTypeName, p_token_1, p_XMLValue, p_token_2, p_NonParameterizedTypeName_1, p_token_3);
			p_token.parent = p_XMLTypedValue_ref;
			p_NonParameterizedTypeName.parent = p_XMLTypedValue_ref;
			p_token_1.parent = p_XMLTypedValue_ref;
			p_XMLValue.parent = p_XMLTypedValue_ref;
			p_token_2.parent = p_XMLTypedValue_ref;
			p_NonParameterizedTypeName_1.parent = p_XMLTypedValue_ref;
			p_token_3.parent = p_XMLTypedValue_ref;
			Raise_XMLTypedValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLTypedValue.production_kind.g_XMLTypedValue_1, p_XMLTypedValue_ref);
			return p_XMLTypedValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLTypedValue: "<" NonParameterizedTypeName "/>"

		//

		public XMLTypedValue XMLTypedValue_2 (SyntaxTreeToken p_token, NonParameterizedTypeName p_NonParameterizedTypeName, SyntaxTreeToken p_token_1)
		{
			XMLTypedValue p_XMLTypedValue_ref = new XMLTypedValue(p_token, p_NonParameterizedTypeName, p_token_1);
			p_token.parent = p_XMLTypedValue_ref;
			p_NonParameterizedTypeName.parent = p_XMLTypedValue_ref;
			p_token_1.parent = p_XMLTypedValue_ref;
			Raise_XMLTypedValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLTypedValue.production_kind.g_XMLTypedValue_2, p_XMLTypedValue_ref);
			return p_XMLTypedValue_ref;
		}
		#endregion
	};
}
