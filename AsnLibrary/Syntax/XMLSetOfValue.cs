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
	// class associated with syntax rule XMLSetOfValue
	//

	[DataContract]
	public class	XMLSetOfValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLSetOfValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLSetOfValue
		{
			g_XMLSetOfValue_1 = 1,	// XMLValueList

			g_XMLSetOfValue_2 = 2,	// XMLDelimitedItemList

			g_XMLSetOfValue_3 = 3,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule XMLSetOfValue

		// markers associated with production: XMLSetOfValue -> XMLValueList

		public enum production_marker_1 : ushort
		{
			m_XMLValueList,
			final
		};

		// markers associated with production: XMLSetOfValue -> XMLDelimitedItemList

		public enum production_marker_2 : ushort
		{
			m_XMLDelimitedItemList,
			final
		};

		// markers associated with production: XMLSetOfValue -> %empty

		public enum production_marker_3 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLSetOfValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLSetOfValue

		//
		// Constructor associated with the following production(s)
		// XMLSetOfValue -> XMLValueList

		//

		public XMLSetOfValue (XMLValueList p_XMLValueList) : base ((uint) ProductionID._XMLSetOfValue_ID, (uint) production_kind.g_XMLSetOfValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLValueList = p_XMLValueList;
		}

		//
		// Constructor associated with the following production(s)
		// XMLSetOfValue -> XMLDelimitedItemList

		//

		public XMLSetOfValue (XMLDelimitedItemList p_XMLDelimitedItemList) : base ((uint) ProductionID._XMLSetOfValue_ID, (uint) production_kind.g_XMLSetOfValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLDelimitedItemList = p_XMLDelimitedItemList;
		}

		//
		// Constructor associated with the following production(s)
		// XMLSetOfValue -> %empty

		//

		public XMLSetOfValue () : base ((uint) ProductionID._XMLSetOfValue_ID, (uint) production_kind.g_XMLSetOfValue_3)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public XMLSetOfValue (XMLSetOfValue p_XMLSetOfValue) : base (p_XMLSetOfValue.id, p_XMLSetOfValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLSetOfValue.appInfo;
			switch ((production_kind) p_XMLSetOfValue.kind)
			{
				case production_kind.g_XMLSetOfValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLValueList = (p_XMLSetOfValue.m_XMLValueList != null) ? new XMLValueList (p_XMLSetOfValue.m_XMLValueList) : null) != null) m_XMLValueList.parent = this;
					break;
				case production_kind.g_XMLSetOfValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLDelimitedItemList = (p_XMLSetOfValue.m_XMLDelimitedItemList != null) ? new XMLDelimitedItemList (p_XMLSetOfValue.m_XMLDelimitedItemList) : null) != null) m_XMLDelimitedItemList.parent = this;
					break;
				case production_kind.g_XMLSetOfValue_3:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "XMLSetOfValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLSetOfValue (this); }

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
		#region Content changing and inclusion checking methods associated with the syntax rule XMLSetOfValue

		// Content changing function(s) associated with production(s) of syntax rule XMLSetOfValue

		//
		// Content changing function associated with following production(s)
		// XMLSetOfValue -> XMLValueList

		//

		public void change(XMLValueList p_XMLValueList)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLSetOfValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLValueList = p_XMLValueList;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLSetOfValue -> XMLDelimitedItemList

		//

		public void change(XMLDelimitedItemList p_XMLDelimitedItemList)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLSetOfValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLDelimitedItemList = p_XMLDelimitedItemList;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLSetOfValue -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLSetOfValue_3;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLSetOfValue
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
		#region Syntax tree emit methods associated with the syntax rule XMLSetOfValue

		//
		// emit production tree node associated with any production of syntax rule XMLSetOfValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLSetOfValue_1:
					// emit syntax tree node associated with production
					// XMLSetOfValue: XMLValueList

					s += m_XMLValueList.Emit (depth - 1);
				break;
				case production_kind.g_XMLSetOfValue_2:
					// emit syntax tree node associated with production
					// XMLSetOfValue: XMLDelimitedItemList

					s += m_XMLDelimitedItemList.Emit (depth - 1);
				break;
				case production_kind.g_XMLSetOfValue_3:
					// emit syntax tree node associated with production
					// XMLSetOfValue: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLSetOfValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLSetOfValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLSetOfValue_1:
					// emit syntax tree node associated with production
					// XMLSetOfValue: XMLValueList

					s += m_XMLValueList.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLSetOfValue_2:
					// emit syntax tree node associated with production
					// XMLSetOfValue: XMLDelimitedItemList

					s += m_XMLDelimitedItemList.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLSetOfValue_3:
					// emit syntax tree node associated with production
					// XMLSetOfValue: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLSetOfValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLSetOfValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLSetOfValue.production_kind kind = (XMLSetOfValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLSetOfValue.production_kind.g_XMLSetOfValue_1:
					// traverse syntax tree node associated with production
					// XMLSetOfValue: XMLValueList

						m_XMLValueList.Visit (visitor, appData);
				break;
				case XMLSetOfValue.production_kind.g_XMLSetOfValue_2:
					// traverse syntax tree node associated with production
					// XMLSetOfValue: XMLDelimitedItemList

						m_XMLDelimitedItemList.Visit (visitor, appData);
				break;
				case XMLSetOfValue.production_kind.g_XMLSetOfValue_3:
					// traverse syntax tree node associated with production
					// XMLSetOfValue: %empty

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
		// initialize object associated with syntax rule XMLSetOfValue
		//

		public void _init ()
		{
			m_XMLValueList = null;
			m_XMLDelimitedItemList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLSetOfValue

		// counter of all nodes associated with syntax rule XMLSetOfValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLSetOfValue
		[DataMember (Name = "m_XMLValueList")] public XMLValueList m_XMLValueList { get; private set; }
		[DataMember (Name = "m_XMLDelimitedItemList")] public XMLDelimitedItemList m_XMLDelimitedItemList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLSetOfValue

		// delegate function (callback) prototype associated with syntax rule XMLSetOfValue
		public delegate bool XMLSetOfValue_Callback (SyntaxTreeCallbackReason reason, XMLSetOfValue.production_kind kind, XMLSetOfValue p_XMLSetOfValue);

		// event associated with syntax rule XMLSetOfValue
		public event XMLSetOfValue_Callback XMLSetOfValue_Event;

		// event trigger associated with syntax rule XMLSetOfValue
		public bool Raise_XMLSetOfValue_Event (SyntaxTreeCallbackReason reason, XMLSetOfValue.production_kind kind, XMLSetOfValue p_XMLSetOfValue)
		{
			bool? status = XMLSetOfValue_Event?.Invoke (reason, kind, p_XMLSetOfValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLSetOfValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLSetOfValue
		//

		public void Traverse (XMLSetOfValue p_XMLSetOfValue)
		{
			if (p_XMLSetOfValue.isLocked())
				return;
			p_XMLSetOfValue.dolock();
			XMLSetOfValue.production_kind kind = (XMLSetOfValue.production_kind) p_XMLSetOfValue.kind;
			p_XMLSetOfValue.turn_reset ();
			if (Raise_XMLSetOfValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLSetOfValue))
			switch (kind)
			{
				case XMLSetOfValue.production_kind.g_XMLSetOfValue_1:
					// traverse syntax tree node associated with production
					// XMLSetOfValue: XMLValueList

					if (Raise_XMLSetOfValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLSetOfValue))
						Traverse (p_XMLSetOfValue.m_XMLValueList);
					p_XMLSetOfValue.turn_inc ();
					Raise_XMLSetOfValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLSetOfValue);
				break;
				case XMLSetOfValue.production_kind.g_XMLSetOfValue_2:
					// traverse syntax tree node associated with production
					// XMLSetOfValue: XMLDelimitedItemList

					if (Raise_XMLSetOfValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLSetOfValue))
						Traverse (p_XMLSetOfValue.m_XMLDelimitedItemList);
					p_XMLSetOfValue.turn_inc ();
					Raise_XMLSetOfValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLSetOfValue);
				break;
				case XMLSetOfValue.production_kind.g_XMLSetOfValue_3:
					// traverse syntax tree node associated with production
					// XMLSetOfValue: %empty

				break;
			}
			Raise_XMLSetOfValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLSetOfValue);
			p_XMLSetOfValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLSetOfValue
		//

		public void TraverseCommon (XMLSetOfValue p_XMLSetOfValue)
		{
			XMLSetOfValue.production_kind kind = (XMLSetOfValue.production_kind) p_XMLSetOfValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLSetOfValue))
			switch (kind)
			{
				case XMLSetOfValue.production_kind.g_XMLSetOfValue_1:
					// traverse syntax tree node associated with production
					// XMLSetOfValue: XMLValueList

						TraverseCommon (p_XMLSetOfValue.m_XMLValueList);
				break;
				case XMLSetOfValue.production_kind.g_XMLSetOfValue_2:
					// traverse syntax tree node associated with production
					// XMLSetOfValue: XMLDelimitedItemList

						TraverseCommon (p_XMLSetOfValue.m_XMLDelimitedItemList);
				break;
				case XMLSetOfValue.production_kind.g_XMLSetOfValue_3:
					// traverse syntax tree node associated with production
					// XMLSetOfValue: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLSetOfValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLSetOfValue

		//
		// create syntax tree node associated with production
		// XMLSetOfValue: XMLValueList

		//

		public XMLSetOfValue XMLSetOfValue_1 (XMLValueList p_XMLValueList)
		{
			XMLSetOfValue p_XMLSetOfValue_ref = new XMLSetOfValue(p_XMLValueList);
			p_XMLValueList.parent = p_XMLSetOfValue_ref;
			Raise_XMLSetOfValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLSetOfValue.production_kind.g_XMLSetOfValue_1, p_XMLSetOfValue_ref);
			return p_XMLSetOfValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLSetOfValue: XMLDelimitedItemList

		//

		public XMLSetOfValue XMLSetOfValue_2 (XMLDelimitedItemList p_XMLDelimitedItemList)
		{
			XMLSetOfValue p_XMLSetOfValue_ref = new XMLSetOfValue(p_XMLDelimitedItemList);
			p_XMLDelimitedItemList.parent = p_XMLSetOfValue_ref;
			Raise_XMLSetOfValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLSetOfValue.production_kind.g_XMLSetOfValue_2, p_XMLSetOfValue_ref);
			return p_XMLSetOfValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLSetOfValue: %empty

		//

		public XMLSetOfValue XMLSetOfValue_3 ()
		{
			XMLSetOfValue p_XMLSetOfValue_ref = new XMLSetOfValue();
			Raise_XMLSetOfValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLSetOfValue.production_kind.g_XMLSetOfValue_3, p_XMLSetOfValue_ref);
			return p_XMLSetOfValue_ref;
		}
		#endregion
	};
}
