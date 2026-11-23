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
	// class associated with syntax rule XMLValueOrEmpty
	//

	[DataContract]
	public class	XMLValueOrEmpty : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLValueOrEmpty
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLValueOrEmpty
		{
			g_XMLValueOrEmpty_1 = 1,	// XMLValue

			g_XMLValueOrEmpty_2 = 2,	// "<" NonParameterizedTypeName "/>"

		};
		#endregion
		#region production markers associated with the syntax rule XMLValueOrEmpty

		// markers associated with production: XMLValueOrEmpty -> XMLValue

		public enum production_marker_1 : ushort
		{
			m_XMLValue,
			final
		};

		// markers associated with production: XMLValueOrEmpty -> "<" NonParameterizedTypeName "/>"

		public enum production_marker_2 : ushort
		{
			m_NonParameterizedTypeName,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLValueOrEmpty

		// Constructor declaration(s) associated with production(s) of syntax rule XMLValueOrEmpty

		//
		// Constructor associated with the following production(s)
		// XMLValueOrEmpty -> XMLValue

		//

		public XMLValueOrEmpty (XMLValue p_XMLValue) : base ((uint) ProductionID._XMLValueOrEmpty_ID, (uint) production_kind.g_XMLValueOrEmpty_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLValue = p_XMLValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLValueOrEmpty -> "<" NonParameterizedTypeName "/>"

		//

		public XMLValueOrEmpty (SyntaxTreeToken p_token, NonParameterizedTypeName p_NonParameterizedTypeName, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._XMLValueOrEmpty_ID, (uint) production_kind.g_XMLValueOrEmpty_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_less_sign = p_token;
			children[1] = m_NonParameterizedTypeName = p_NonParameterizedTypeName;
			children[2] = m_xml_single_tag_end_item = p_token_1;
		}

		public XMLValueOrEmpty () { }

		// Copy constructor

		public XMLValueOrEmpty (XMLValueOrEmpty p_XMLValueOrEmpty) : base (p_XMLValueOrEmpty.id, p_XMLValueOrEmpty.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLValueOrEmpty.appInfo;
			switch ((production_kind) p_XMLValueOrEmpty.kind)
			{
				case production_kind.g_XMLValueOrEmpty_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLValue = (p_XMLValueOrEmpty.m_XMLValue != null) ? new XMLValue (p_XMLValueOrEmpty.m_XMLValue) : null) != null) m_XMLValue.parent = this;
					break;
				case production_kind.g_XMLValueOrEmpty_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_less_sign = (p_XMLValueOrEmpty.m_less_sign != null) ? new SyntaxTreeToken (p_XMLValueOrEmpty.m_less_sign) : null) != null) m_less_sign.parent = this;
					if ((children [1] = m_NonParameterizedTypeName = (p_XMLValueOrEmpty.m_NonParameterizedTypeName != null) ? new NonParameterizedTypeName (p_XMLValueOrEmpty.m_NonParameterizedTypeName) : null) != null) m_NonParameterizedTypeName.parent = this;
					if ((children [2] = m_xml_single_tag_end_item = (p_XMLValueOrEmpty.m_xml_single_tag_end_item != null) ? new SyntaxTreeToken (p_XMLValueOrEmpty.m_xml_single_tag_end_item) : null) != null) m_xml_single_tag_end_item.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLValueOrEmpty" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLValueOrEmpty (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLValue?.Dispose ();
			m_less_sign?.Dispose ();
			m_NonParameterizedTypeName?.Dispose ();
			m_xml_single_tag_end_item?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLValueOrEmpty

		// Content changing function(s) associated with production(s) of syntax rule XMLValueOrEmpty

		//
		// Content changing function associated with following production(s)
		// XMLValueOrEmpty -> XMLValue

		//

		public void change(XMLValue p_XMLValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLValueOrEmpty_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLValue = p_XMLValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLValueOrEmpty -> "<" NonParameterizedTypeName "/>"

		//

		public void change(SyntaxTreeToken p_token, NonParameterizedTypeName p_NonParameterizedTypeName, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLValueOrEmpty_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_less_sign = p_token;
			children [1] = m_NonParameterizedTypeName = p_NonParameterizedTypeName;
			children [2] = m_xml_single_tag_end_item = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLValueOrEmpty
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLValue != null) && m_XMLValue.checkInclusion (element) ||
				(m_less_sign != null) && m_less_sign.checkInclusion (element) ||
				(m_NonParameterizedTypeName != null) && m_NonParameterizedTypeName.checkInclusion (element) ||
				(m_xml_single_tag_end_item != null) && m_xml_single_tag_end_item.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLValueOrEmpty

		//
		// emit production tree node associated with any production of syntax rule XMLValueOrEmpty
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLValueOrEmpty_1:
					// emit syntax tree node associated with production
					// XMLValueOrEmpty: XMLValue

					s += m_XMLValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLValueOrEmpty_2:
					// emit syntax tree node associated with production
					// XMLValueOrEmpty: "<" NonParameterizedTypeName "/>"

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
		// emit production tree node associated with any production of syntax rule XMLValueOrEmpty
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLValueOrEmpty (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLValueOrEmpty_1:
					// emit syntax tree node associated with production
					// XMLValueOrEmpty: XMLValue

					s += m_XMLValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLValueOrEmpty_2:
					// emit syntax tree node associated with production
					// XMLValueOrEmpty: "<" NonParameterizedTypeName "/>"

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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLValueOrEmpty

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLValueOrEmpty with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLValueOrEmpty.production_kind kind = (XMLValueOrEmpty.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLValueOrEmpty.production_kind.g_XMLValueOrEmpty_1:
					// traverse syntax tree node associated with production
					// XMLValueOrEmpty: XMLValue

						m_XMLValue.Visit (visitor, appData);
				break;
				case XMLValueOrEmpty.production_kind.g_XMLValueOrEmpty_2:
					// traverse syntax tree node associated with production
					// XMLValueOrEmpty: "<" NonParameterizedTypeName "/>"

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

			m_XMLValue?.reparent (this);
			m_less_sign?.reparent (this);
			m_NonParameterizedTypeName?.reparent (this);
			m_xml_single_tag_end_item?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLValueOrEmpty
		//

		public void _init ()
		{
			m_XMLValue = null;
			m_less_sign = null;
			m_NonParameterizedTypeName = null;
			m_xml_single_tag_end_item = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLValueOrEmpty

		// counter of all nodes associated with syntax rule XMLValueOrEmpty
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLValueOrEmpty
		[DataMember (Name = "m_XMLValue")] public XMLValue m_XMLValue { get; private set; }
		[DataMember (Name = "m_less_sign")] public SyntaxTreeToken m_less_sign { get; private set; }
		[DataMember (Name = "m_NonParameterizedTypeName")] public NonParameterizedTypeName m_NonParameterizedTypeName { get; private set; }
		[DataMember (Name = "m_xml_single_tag_end_item")] public SyntaxTreeToken m_xml_single_tag_end_item { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLValueOrEmpty

		// delegate function (callback) prototype associated with syntax rule XMLValueOrEmpty
		public delegate bool XMLValueOrEmpty_Callback (SyntaxTreeCallbackReason reason, XMLValueOrEmpty.production_kind kind, XMLValueOrEmpty p_XMLValueOrEmpty);

		// event associated with syntax rule XMLValueOrEmpty
		public event XMLValueOrEmpty_Callback XMLValueOrEmpty_Event;

		// event trigger associated with syntax rule XMLValueOrEmpty
		public bool Raise_XMLValueOrEmpty_Event (SyntaxTreeCallbackReason reason, XMLValueOrEmpty.production_kind kind, XMLValueOrEmpty p_XMLValueOrEmpty)
		{
			bool? status = XMLValueOrEmpty_Event?.Invoke (reason, kind, p_XMLValueOrEmpty);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLValueOrEmpty
		//
		// traverse syntax tree node associated with any production of syntax rule XMLValueOrEmpty
		//

		public void Traverse (XMLValueOrEmpty p_XMLValueOrEmpty)
		{
			if (p_XMLValueOrEmpty.isLocked())
				return;
			p_XMLValueOrEmpty.dolock();
			XMLValueOrEmpty.production_kind kind = (XMLValueOrEmpty.production_kind) p_XMLValueOrEmpty.kind;
			p_XMLValueOrEmpty.turn_reset ();
			if (Raise_XMLValueOrEmpty_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLValueOrEmpty))
			switch (kind)
			{
				case XMLValueOrEmpty.production_kind.g_XMLValueOrEmpty_1:
					// traverse syntax tree node associated with production
					// XMLValueOrEmpty: XMLValue

					if (Raise_XMLValueOrEmpty_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLValueOrEmpty))
						Traverse (p_XMLValueOrEmpty.m_XMLValue);
					p_XMLValueOrEmpty.turn_inc ();
					Raise_XMLValueOrEmpty_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLValueOrEmpty);
				break;
				case XMLValueOrEmpty.production_kind.g_XMLValueOrEmpty_2:
					// traverse syntax tree node associated with production
					// XMLValueOrEmpty: "<" NonParameterizedTypeName "/>"

					if (Raise_XMLValueOrEmpty_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLValueOrEmpty))
						Traverse (p_XMLValueOrEmpty.m_NonParameterizedTypeName);
					p_XMLValueOrEmpty.turn_inc ();
					Raise_XMLValueOrEmpty_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLValueOrEmpty);
				break;
			}
			Raise_XMLValueOrEmpty_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLValueOrEmpty);
			p_XMLValueOrEmpty.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLValueOrEmpty
		//

		public void TraverseCommon (XMLValueOrEmpty p_XMLValueOrEmpty)
		{
			XMLValueOrEmpty.production_kind kind = (XMLValueOrEmpty.production_kind) p_XMLValueOrEmpty.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLValueOrEmpty))
			switch (kind)
			{
				case XMLValueOrEmpty.production_kind.g_XMLValueOrEmpty_1:
					// traverse syntax tree node associated with production
					// XMLValueOrEmpty: XMLValue

						TraverseCommon (p_XMLValueOrEmpty.m_XMLValue);
				break;
				case XMLValueOrEmpty.production_kind.g_XMLValueOrEmpty_2:
					// traverse syntax tree node associated with production
					// XMLValueOrEmpty: "<" NonParameterizedTypeName "/>"

						TraverseCommon (p_XMLValueOrEmpty.m_less_sign);
						TraverseCommon (p_XMLValueOrEmpty.m_NonParameterizedTypeName);
						TraverseCommon (p_XMLValueOrEmpty.m_xml_single_tag_end_item);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLValueOrEmpty);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLValueOrEmpty

		//
		// create syntax tree node associated with production
		// XMLValueOrEmpty: XMLValue

		//

		public XMLValueOrEmpty XMLValueOrEmpty_1 (XMLValue p_XMLValue)
		{
			XMLValueOrEmpty p_XMLValueOrEmpty_ref = new XMLValueOrEmpty(p_XMLValue);
			p_XMLValue.parent = p_XMLValueOrEmpty_ref;
			Raise_XMLValueOrEmpty_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLValueOrEmpty.production_kind.g_XMLValueOrEmpty_1, p_XMLValueOrEmpty_ref);
			return p_XMLValueOrEmpty_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLValueOrEmpty: "<" NonParameterizedTypeName "/>"

		//

		public XMLValueOrEmpty XMLValueOrEmpty_2 (SyntaxTreeToken p_token, NonParameterizedTypeName p_NonParameterizedTypeName, SyntaxTreeToken p_token_1)
		{
			XMLValueOrEmpty p_XMLValueOrEmpty_ref = new XMLValueOrEmpty(p_token, p_NonParameterizedTypeName, p_token_1);
			p_token.parent = p_XMLValueOrEmpty_ref;
			p_NonParameterizedTypeName.parent = p_XMLValueOrEmpty_ref;
			p_token_1.parent = p_XMLValueOrEmpty_ref;
			Raise_XMLValueOrEmpty_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLValueOrEmpty.production_kind.g_XMLValueOrEmpty_2, p_XMLValueOrEmpty_ref);
			return p_XMLValueOrEmpty_ref;
		}
		#endregion
	};
}
