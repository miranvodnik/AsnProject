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
	// class associated with syntax rule XMLSequenceOfValue
	//

	[DataContract]
	public class	XMLSequenceOfValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLSequenceOfValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLSequenceOfValue
		{
			g_XMLSequenceOfValue_1 = 1,	// XMLValueList

			g_XMLSequenceOfValue_2 = 2,	// XMLDelimitedItemList

			g_XMLSequenceOfValue_3 = 3,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule XMLSequenceOfValue

		// markers associated with production: XMLSequenceOfValue -> XMLValueList

		public enum production_marker_1 : ushort
		{
			m_XMLValueList,
			final
		};

		// markers associated with production: XMLSequenceOfValue -> XMLDelimitedItemList

		public enum production_marker_2 : ushort
		{
			m_XMLDelimitedItemList,
			final
		};

		// markers associated with production: XMLSequenceOfValue -> %empty

		public enum production_marker_3 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLSequenceOfValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLSequenceOfValue

		//
		// Constructor associated with the following production(s)
		// XMLSequenceOfValue -> XMLValueList

		//

		public XMLSequenceOfValue (XMLValueList p_XMLValueList) : base ((uint) ProductionID._XMLSequenceOfValue_ID, (uint) production_kind.g_XMLSequenceOfValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLValueList = p_XMLValueList;
		}

		//
		// Constructor associated with the following production(s)
		// XMLSequenceOfValue -> XMLDelimitedItemList

		//

		public XMLSequenceOfValue (XMLDelimitedItemList p_XMLDelimitedItemList) : base ((uint) ProductionID._XMLSequenceOfValue_ID, (uint) production_kind.g_XMLSequenceOfValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLDelimitedItemList = p_XMLDelimitedItemList;
		}

		//
		// Constructor associated with the following production(s)
		// XMLSequenceOfValue -> %empty

		//

		public XMLSequenceOfValue () : base ((uint) ProductionID._XMLSequenceOfValue_ID, (uint) production_kind.g_XMLSequenceOfValue_3)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public XMLSequenceOfValue (XMLSequenceOfValue p_XMLSequenceOfValue) : base (p_XMLSequenceOfValue.id, p_XMLSequenceOfValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLSequenceOfValue.appInfo;
			switch ((production_kind) p_XMLSequenceOfValue.kind)
			{
				case production_kind.g_XMLSequenceOfValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLValueList = (p_XMLSequenceOfValue.m_XMLValueList != null) ? new XMLValueList (p_XMLSequenceOfValue.m_XMLValueList) : null) != null) m_XMLValueList.parent = this;
					break;
				case production_kind.g_XMLSequenceOfValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLDelimitedItemList = (p_XMLSequenceOfValue.m_XMLDelimitedItemList != null) ? new XMLDelimitedItemList (p_XMLSequenceOfValue.m_XMLDelimitedItemList) : null) != null) m_XMLDelimitedItemList.parent = this;
					break;
				case production_kind.g_XMLSequenceOfValue_3:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "XMLSequenceOfValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLSequenceOfValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLValueList?.Dispose ();
			m_XMLDelimitedItemList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLSequenceOfValue

		// Content changing function(s) associated with production(s) of syntax rule XMLSequenceOfValue

		//
		// Content changing function associated with following production(s)
		// XMLSequenceOfValue -> XMLValueList

		//

		public void change(XMLValueList p_XMLValueList)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLSequenceOfValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLValueList = p_XMLValueList;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLSequenceOfValue -> XMLDelimitedItemList

		//

		public void change(XMLDelimitedItemList p_XMLDelimitedItemList)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLSequenceOfValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLDelimitedItemList = p_XMLDelimitedItemList;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLSequenceOfValue -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLSequenceOfValue_3;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLSequenceOfValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLValueList != null) && m_XMLValueList.checkInclusion (element) ||
				(m_XMLDelimitedItemList != null) && m_XMLDelimitedItemList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLSequenceOfValue

		//
		// emit production tree node associated with any production of syntax rule XMLSequenceOfValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLSequenceOfValue_1:
					// emit syntax tree node associated with production
					// XMLSequenceOfValue: XMLValueList

					s += m_XMLValueList.Emit (depth - 1);
				break;
				case production_kind.g_XMLSequenceOfValue_2:
					// emit syntax tree node associated with production
					// XMLSequenceOfValue: XMLDelimitedItemList

					s += m_XMLDelimitedItemList.Emit (depth - 1);
				break;
				case production_kind.g_XMLSequenceOfValue_3:
					// emit syntax tree node associated with production
					// XMLSequenceOfValue: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLSequenceOfValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLSequenceOfValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLSequenceOfValue_1:
					// emit syntax tree node associated with production
					// XMLSequenceOfValue: XMLValueList

					s += m_XMLValueList.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLSequenceOfValue_2:
					// emit syntax tree node associated with production
					// XMLSequenceOfValue: XMLDelimitedItemList

					s += m_XMLDelimitedItemList.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLSequenceOfValue_3:
					// emit syntax tree node associated with production
					// XMLSequenceOfValue: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLSequenceOfValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLSequenceOfValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLSequenceOfValue.production_kind kind = (XMLSequenceOfValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLSequenceOfValue.production_kind.g_XMLSequenceOfValue_1:
					// traverse syntax tree node associated with production
					// XMLSequenceOfValue: XMLValueList

						m_XMLValueList.Visit (visitor, appData);
				break;
				case XMLSequenceOfValue.production_kind.g_XMLSequenceOfValue_2:
					// traverse syntax tree node associated with production
					// XMLSequenceOfValue: XMLDelimitedItemList

						m_XMLDelimitedItemList.Visit (visitor, appData);
				break;
				case XMLSequenceOfValue.production_kind.g_XMLSequenceOfValue_3:
					// traverse syntax tree node associated with production
					// XMLSequenceOfValue: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_XMLValueList?.reparent (this);
			m_XMLDelimitedItemList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLSequenceOfValue
		//

		public void _init ()
		{
			m_XMLValueList = null;
			m_XMLDelimitedItemList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLSequenceOfValue

		// counter of all nodes associated with syntax rule XMLSequenceOfValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLSequenceOfValue
		[DataMember (Name = "m_XMLValueList")] public XMLValueList m_XMLValueList { get; private set; }
		[DataMember (Name = "m_XMLDelimitedItemList")] public XMLDelimitedItemList m_XMLDelimitedItemList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLSequenceOfValue

		// delegate function (callback) prototype associated with syntax rule XMLSequenceOfValue
		public delegate bool XMLSequenceOfValue_Callback (SyntaxTreeCallbackReason reason, XMLSequenceOfValue.production_kind kind, XMLSequenceOfValue p_XMLSequenceOfValue);

		// event associated with syntax rule XMLSequenceOfValue
		public event XMLSequenceOfValue_Callback XMLSequenceOfValue_Event;

		// event trigger associated with syntax rule XMLSequenceOfValue
		public bool Raise_XMLSequenceOfValue_Event (SyntaxTreeCallbackReason reason, XMLSequenceOfValue.production_kind kind, XMLSequenceOfValue p_XMLSequenceOfValue)
		{
			bool? status = XMLSequenceOfValue_Event?.Invoke (reason, kind, p_XMLSequenceOfValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLSequenceOfValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLSequenceOfValue
		//

		public void Traverse (XMLSequenceOfValue p_XMLSequenceOfValue)
		{
			if (p_XMLSequenceOfValue.isLocked())
				return;
			p_XMLSequenceOfValue.dolock();
			XMLSequenceOfValue.production_kind kind = (XMLSequenceOfValue.production_kind) p_XMLSequenceOfValue.kind;
			p_XMLSequenceOfValue.turn_reset ();
			if (Raise_XMLSequenceOfValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLSequenceOfValue))
			switch (kind)
			{
				case XMLSequenceOfValue.production_kind.g_XMLSequenceOfValue_1:
					// traverse syntax tree node associated with production
					// XMLSequenceOfValue: XMLValueList

					if (Raise_XMLSequenceOfValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLSequenceOfValue))
						Traverse (p_XMLSequenceOfValue.m_XMLValueList);
					p_XMLSequenceOfValue.turn_inc ();
					Raise_XMLSequenceOfValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLSequenceOfValue);
				break;
				case XMLSequenceOfValue.production_kind.g_XMLSequenceOfValue_2:
					// traverse syntax tree node associated with production
					// XMLSequenceOfValue: XMLDelimitedItemList

					if (Raise_XMLSequenceOfValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLSequenceOfValue))
						Traverse (p_XMLSequenceOfValue.m_XMLDelimitedItemList);
					p_XMLSequenceOfValue.turn_inc ();
					Raise_XMLSequenceOfValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLSequenceOfValue);
				break;
				case XMLSequenceOfValue.production_kind.g_XMLSequenceOfValue_3:
					// traverse syntax tree node associated with production
					// XMLSequenceOfValue: %empty

				break;
			}
			Raise_XMLSequenceOfValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLSequenceOfValue);
			p_XMLSequenceOfValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLSequenceOfValue
		//

		public void TraverseCommon (XMLSequenceOfValue p_XMLSequenceOfValue)
		{
			XMLSequenceOfValue.production_kind kind = (XMLSequenceOfValue.production_kind) p_XMLSequenceOfValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLSequenceOfValue))
			switch (kind)
			{
				case XMLSequenceOfValue.production_kind.g_XMLSequenceOfValue_1:
					// traverse syntax tree node associated with production
					// XMLSequenceOfValue: XMLValueList

						TraverseCommon (p_XMLSequenceOfValue.m_XMLValueList);
				break;
				case XMLSequenceOfValue.production_kind.g_XMLSequenceOfValue_2:
					// traverse syntax tree node associated with production
					// XMLSequenceOfValue: XMLDelimitedItemList

						TraverseCommon (p_XMLSequenceOfValue.m_XMLDelimitedItemList);
				break;
				case XMLSequenceOfValue.production_kind.g_XMLSequenceOfValue_3:
					// traverse syntax tree node associated with production
					// XMLSequenceOfValue: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLSequenceOfValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLSequenceOfValue

		//
		// create syntax tree node associated with production
		// XMLSequenceOfValue: XMLValueList

		//

		public XMLSequenceOfValue XMLSequenceOfValue_1 (XMLValueList p_XMLValueList)
		{
			XMLSequenceOfValue p_XMLSequenceOfValue_ref = new XMLSequenceOfValue(p_XMLValueList);
			p_XMLValueList.parent = p_XMLSequenceOfValue_ref;
			Raise_XMLSequenceOfValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLSequenceOfValue.production_kind.g_XMLSequenceOfValue_1, p_XMLSequenceOfValue_ref);
			return p_XMLSequenceOfValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLSequenceOfValue: XMLDelimitedItemList

		//

		public XMLSequenceOfValue XMLSequenceOfValue_2 (XMLDelimitedItemList p_XMLDelimitedItemList)
		{
			XMLSequenceOfValue p_XMLSequenceOfValue_ref = new XMLSequenceOfValue(p_XMLDelimitedItemList);
			p_XMLDelimitedItemList.parent = p_XMLSequenceOfValue_ref;
			Raise_XMLSequenceOfValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLSequenceOfValue.production_kind.g_XMLSequenceOfValue_2, p_XMLSequenceOfValue_ref);
			return p_XMLSequenceOfValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLSequenceOfValue: %empty

		//

		public XMLSequenceOfValue XMLSequenceOfValue_3 ()
		{
			XMLSequenceOfValue p_XMLSequenceOfValue_ref = new XMLSequenceOfValue();
			Raise_XMLSequenceOfValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLSequenceOfValue.production_kind.g_XMLSequenceOfValue_3, p_XMLSequenceOfValue_ref);
			return p_XMLSequenceOfValue_ref;
		}
		#endregion
	};
}
