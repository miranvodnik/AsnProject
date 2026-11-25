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
	// class associated with syntax rule XMLBitStringValue
	//

	[DataContract]
	public class	XMLBitStringValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLBitStringValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLBitStringValue
		{
			g_XMLBitStringValue_1 = 1,	// XMLTypedValue

			g_XMLBitStringValue_2 = 2,	// xmlbstring

			g_XMLBitStringValue_3 = 3,	// XMLIdentifierList

			g_XMLBitStringValue_4 = 4,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule XMLBitStringValue

		// markers associated with production: XMLBitStringValue -> XMLTypedValue

		public enum production_marker_1 : ushort
		{
			m_XMLTypedValue,
			final
		};

		// markers associated with production: XMLBitStringValue -> xmlbstring

		public enum production_marker_2 : ushort
		{
			final
		};

		// markers associated with production: XMLBitStringValue -> XMLIdentifierList

		public enum production_marker_3 : ushort
		{
			m_XMLIdentifierList,
			final
		};

		// markers associated with production: XMLBitStringValue -> %empty

		public enum production_marker_4 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLBitStringValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLBitStringValue

		//
		// Constructor associated with the following production(s)
		// XMLBitStringValue -> XMLTypedValue

		//

		public XMLBitStringValue (XMLTypedValue p_XMLTypedValue) : base ((uint) ProductionID._XMLBitStringValue_ID, (uint) production_kind.g_XMLBitStringValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLTypedValue = p_XMLTypedValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBitStringValue -> xmlbstring

		//

		public XMLBitStringValue (SyntaxTreeToken p_token) : base ((uint) ProductionID._XMLBitStringValue_ID, (uint) production_kind.g_XMLBitStringValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_xmlbstring = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBitStringValue -> XMLIdentifierList

		//

		public XMLBitStringValue (XMLIdentifierList p_XMLIdentifierList) : base ((uint) ProductionID._XMLBitStringValue_ID, (uint) production_kind.g_XMLBitStringValue_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLIdentifierList = p_XMLIdentifierList;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBitStringValue -> %empty

		//

		public XMLBitStringValue () : base ((uint) ProductionID._XMLBitStringValue_ID, (uint) production_kind.g_XMLBitStringValue_4)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public XMLBitStringValue (XMLBitStringValue p_XMLBitStringValue) : base (p_XMLBitStringValue.id, p_XMLBitStringValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLBitStringValue.appInfo;
			switch ((production_kind) p_XMLBitStringValue.kind)
			{
				case production_kind.g_XMLBitStringValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLTypedValue = (p_XMLBitStringValue.m_XMLTypedValue != null) ? new XMLTypedValue (p_XMLBitStringValue.m_XMLTypedValue) : null) != null) m_XMLTypedValue.parent = this;
					break;
				case production_kind.g_XMLBitStringValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_xmlbstring = (p_XMLBitStringValue.m_xmlbstring != null) ? new SyntaxTreeToken (p_XMLBitStringValue.m_xmlbstring) : null) != null) m_xmlbstring.parent = this;
					break;
				case production_kind.g_XMLBitStringValue_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLIdentifierList = (p_XMLBitStringValue.m_XMLIdentifierList != null) ? new XMLIdentifierList (p_XMLBitStringValue.m_XMLIdentifierList) : null) != null) m_XMLIdentifierList.parent = this;
					break;
				case production_kind.g_XMLBitStringValue_4:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "XMLBitStringValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLBitStringValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLTypedValue?.Dispose ();
			m_xmlbstring?.Dispose ();
			m_XMLIdentifierList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLBitStringValue

		// Content changing function(s) associated with production(s) of syntax rule XMLBitStringValue

		//
		// Content changing function associated with following production(s)
		// XMLBitStringValue -> XMLTypedValue

		//

		public void change(XMLTypedValue p_XMLTypedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBitStringValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLTypedValue = p_XMLTypedValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBitStringValue -> xmlbstring

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBitStringValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_xmlbstring = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBitStringValue -> XMLIdentifierList

		//

		public void change(XMLIdentifierList p_XMLIdentifierList)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBitStringValue_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLIdentifierList = p_XMLIdentifierList;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBitStringValue -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBitStringValue_4;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLBitStringValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLTypedValue != null) && m_XMLTypedValue.checkInclusion (element) ||
				(m_xmlbstring != null) && m_xmlbstring.checkInclusion (element) ||
				(m_XMLIdentifierList != null) && m_XMLIdentifierList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLBitStringValue

		//
		// emit production tree node associated with any production of syntax rule XMLBitStringValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLBitStringValue_1:
					// emit syntax tree node associated with production
					// XMLBitStringValue: XMLTypedValue

					s += m_XMLTypedValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBitStringValue_2:
					// emit syntax tree node associated with production
					// XMLBitStringValue: xmlbstring

					s += m_xmlbstring.Emit (depth - 1);
				break;
				case production_kind.g_XMLBitStringValue_3:
					// emit syntax tree node associated with production
					// XMLBitStringValue: XMLIdentifierList

					s += m_XMLIdentifierList.Emit (depth - 1);
				break;
				case production_kind.g_XMLBitStringValue_4:
					// emit syntax tree node associated with production
					// XMLBitStringValue: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLBitStringValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLBitStringValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLBitStringValue_1:
					// emit syntax tree node associated with production
					// XMLBitStringValue: XMLTypedValue

					s += m_XMLTypedValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBitStringValue_2:
					// emit syntax tree node associated with production
					// XMLBitStringValue: xmlbstring

					s += "xmlbstring";
				break;
				case production_kind.g_XMLBitStringValue_3:
					// emit syntax tree node associated with production
					// XMLBitStringValue: XMLIdentifierList

					s += m_XMLIdentifierList.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBitStringValue_4:
					// emit syntax tree node associated with production
					// XMLBitStringValue: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLBitStringValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLBitStringValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLBitStringValue.production_kind kind = (XMLBitStringValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLBitStringValue.production_kind.g_XMLBitStringValue_1:
					// traverse syntax tree node associated with production
					// XMLBitStringValue: XMLTypedValue

						m_XMLTypedValue.Visit (visitor, appData);
				break;
				case XMLBitStringValue.production_kind.g_XMLBitStringValue_2:
					// traverse syntax tree node associated with production
					// XMLBitStringValue: xmlbstring

						m_xmlbstring.Visit (visitor, appData);
				break;
				case XMLBitStringValue.production_kind.g_XMLBitStringValue_3:
					// traverse syntax tree node associated with production
					// XMLBitStringValue: XMLIdentifierList

						m_XMLIdentifierList.Visit (visitor, appData);
				break;
				case XMLBitStringValue.production_kind.g_XMLBitStringValue_4:
					// traverse syntax tree node associated with production
					// XMLBitStringValue: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_XMLTypedValue?.reparent (this);
			m_xmlbstring?.reparent (this);
			m_XMLIdentifierList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLBitStringValue
		//

		public void _init ()
		{
			m_XMLTypedValue = null;
			m_xmlbstring = null;
			m_XMLIdentifierList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLBitStringValue

		// counter of all nodes associated with syntax rule XMLBitStringValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLBitStringValue
		[DataMember (Name = "m_XMLTypedValue")] public XMLTypedValue m_XMLTypedValue { get; private set; }
		[DataMember (Name = "m_xmlbstring")] public SyntaxTreeToken m_xmlbstring { get; private set; }
		[DataMember (Name = "m_XMLIdentifierList")] public XMLIdentifierList m_XMLIdentifierList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLBitStringValue

		// delegate function (callback) prototype associated with syntax rule XMLBitStringValue
		public delegate bool XMLBitStringValue_Callback (SyntaxTreeCallbackReason reason, XMLBitStringValue.production_kind kind, XMLBitStringValue p_XMLBitStringValue);

		// event associated with syntax rule XMLBitStringValue
		public event XMLBitStringValue_Callback XMLBitStringValue_Event;

		// event trigger associated with syntax rule XMLBitStringValue
		public bool Raise_XMLBitStringValue_Event (SyntaxTreeCallbackReason reason, XMLBitStringValue.production_kind kind, XMLBitStringValue p_XMLBitStringValue)
		{
			bool? status = XMLBitStringValue_Event?.Invoke (reason, kind, p_XMLBitStringValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLBitStringValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLBitStringValue
		//

		public void Traverse (XMLBitStringValue p_XMLBitStringValue)
		{
			if (p_XMLBitStringValue.isLocked())
				return;
			p_XMLBitStringValue.dolock();
			XMLBitStringValue.production_kind kind = (XMLBitStringValue.production_kind) p_XMLBitStringValue.kind;
			p_XMLBitStringValue.turn_reset ();
			if (Raise_XMLBitStringValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLBitStringValue))
			switch (kind)
			{
				case XMLBitStringValue.production_kind.g_XMLBitStringValue_1:
					// traverse syntax tree node associated with production
					// XMLBitStringValue: XMLTypedValue

					if (Raise_XMLBitStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBitStringValue))
						Traverse (p_XMLBitStringValue.m_XMLTypedValue);
					p_XMLBitStringValue.turn_inc ();
					Raise_XMLBitStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBitStringValue);
				break;
				case XMLBitStringValue.production_kind.g_XMLBitStringValue_2:
					// traverse syntax tree node associated with production
					// XMLBitStringValue: xmlbstring

				break;
				case XMLBitStringValue.production_kind.g_XMLBitStringValue_3:
					// traverse syntax tree node associated with production
					// XMLBitStringValue: XMLIdentifierList

					if (Raise_XMLBitStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBitStringValue))
						Traverse (p_XMLBitStringValue.m_XMLIdentifierList);
					p_XMLBitStringValue.turn_inc ();
					Raise_XMLBitStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBitStringValue);
				break;
				case XMLBitStringValue.production_kind.g_XMLBitStringValue_4:
					// traverse syntax tree node associated with production
					// XMLBitStringValue: %empty

				break;
			}
			Raise_XMLBitStringValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLBitStringValue);
			p_XMLBitStringValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLBitStringValue
		//

		public void TraverseCommon (XMLBitStringValue p_XMLBitStringValue)
		{
			XMLBitStringValue.production_kind kind = (XMLBitStringValue.production_kind) p_XMLBitStringValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLBitStringValue))
			switch (kind)
			{
				case XMLBitStringValue.production_kind.g_XMLBitStringValue_1:
					// traverse syntax tree node associated with production
					// XMLBitStringValue: XMLTypedValue

						TraverseCommon (p_XMLBitStringValue.m_XMLTypedValue);
				break;
				case XMLBitStringValue.production_kind.g_XMLBitStringValue_2:
					// traverse syntax tree node associated with production
					// XMLBitStringValue: xmlbstring

						TraverseCommon (p_XMLBitStringValue.m_xmlbstring);
				break;
				case XMLBitStringValue.production_kind.g_XMLBitStringValue_3:
					// traverse syntax tree node associated with production
					// XMLBitStringValue: XMLIdentifierList

						TraverseCommon (p_XMLBitStringValue.m_XMLIdentifierList);
				break;
				case XMLBitStringValue.production_kind.g_XMLBitStringValue_4:
					// traverse syntax tree node associated with production
					// XMLBitStringValue: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLBitStringValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLBitStringValue

		//
		// create syntax tree node associated with production
		// XMLBitStringValue: XMLTypedValue

		//

		public XMLBitStringValue XMLBitStringValue_1 (XMLTypedValue p_XMLTypedValue)
		{
			XMLBitStringValue p_XMLBitStringValue_ref = new XMLBitStringValue(p_XMLTypedValue);
			p_XMLTypedValue.parent = p_XMLBitStringValue_ref;
			Raise_XMLBitStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBitStringValue.production_kind.g_XMLBitStringValue_1, p_XMLBitStringValue_ref);
			return p_XMLBitStringValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBitStringValue: xmlbstring

		//

		public XMLBitStringValue XMLBitStringValue_2 (SyntaxTreeToken p_token)
		{
			XMLBitStringValue p_XMLBitStringValue_ref = new XMLBitStringValue(p_token);
			p_token.parent = p_XMLBitStringValue_ref;
			Raise_XMLBitStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBitStringValue.production_kind.g_XMLBitStringValue_2, p_XMLBitStringValue_ref);
			return p_XMLBitStringValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBitStringValue: XMLIdentifierList

		//

		public XMLBitStringValue XMLBitStringValue_3 (XMLIdentifierList p_XMLIdentifierList)
		{
			XMLBitStringValue p_XMLBitStringValue_ref = new XMLBitStringValue(p_XMLIdentifierList);
			p_XMLIdentifierList.parent = p_XMLBitStringValue_ref;
			Raise_XMLBitStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBitStringValue.production_kind.g_XMLBitStringValue_3, p_XMLBitStringValue_ref);
			return p_XMLBitStringValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBitStringValue: %empty

		//

		public XMLBitStringValue XMLBitStringValue_4 ()
		{
			XMLBitStringValue p_XMLBitStringValue_ref = new XMLBitStringValue();
			Raise_XMLBitStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBitStringValue.production_kind.g_XMLBitStringValue_4, p_XMLBitStringValue_ref);
			return p_XMLBitStringValue_ref;
		}
		#endregion
	};
}
