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
	// class associated with syntax rule XMLIdentifierList
	//

	[DataContract]
	public class	XMLIdentifierList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLIdentifierList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLIdentifierList
		{
			g_XMLIdentifierList_1 = 1,	// EmptyElementList

			g_XMLIdentifierList_2 = 2,	// TextList

		};
		#endregion
		#region production markers associated with the syntax rule XMLIdentifierList

		// markers associated with production: XMLIdentifierList -> EmptyElementList

		public enum production_marker_1 : ushort
		{
			m_EmptyElementList,
			final
		};

		// markers associated with production: XMLIdentifierList -> TextList

		public enum production_marker_2 : ushort
		{
			m_TextList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLIdentifierList

		// Constructor declaration(s) associated with production(s) of syntax rule XMLIdentifierList

		//
		// Constructor associated with the following production(s)
		// XMLIdentifierList -> EmptyElementList

		//

		public XMLIdentifierList (EmptyElementList p_EmptyElementList) : base ((uint) ProductionID._XMLIdentifierList_ID, (uint) production_kind.g_XMLIdentifierList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_EmptyElementList = p_EmptyElementList;
		}

		//
		// Constructor associated with the following production(s)
		// XMLIdentifierList -> TextList

		//

		public XMLIdentifierList (TextList p_TextList) : base ((uint) ProductionID._XMLIdentifierList_ID, (uint) production_kind.g_XMLIdentifierList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TextList = p_TextList;
		}

		public XMLIdentifierList () { }

		// Copy constructor

		public XMLIdentifierList (XMLIdentifierList p_XMLIdentifierList) : base (p_XMLIdentifierList.id, p_XMLIdentifierList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLIdentifierList.appInfo;
			switch ((production_kind) p_XMLIdentifierList.kind)
			{
				case production_kind.g_XMLIdentifierList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EmptyElementList = (p_XMLIdentifierList.m_EmptyElementList != null) ? new EmptyElementList (p_XMLIdentifierList.m_EmptyElementList) : null) != null) m_EmptyElementList.parent = this;
					break;
				case production_kind.g_XMLIdentifierList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TextList = (p_XMLIdentifierList.m_TextList != null) ? new TextList (p_XMLIdentifierList.m_TextList) : null) != null) m_TextList.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLIdentifierList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLIdentifierList (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_EmptyElementList?.Dispose ();
			m_TextList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLIdentifierList

		// Content changing function(s) associated with production(s) of syntax rule XMLIdentifierList

		//
		// Content changing function associated with following production(s)
		// XMLIdentifierList -> EmptyElementList

		//

		public void change(EmptyElementList p_EmptyElementList)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLIdentifierList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_EmptyElementList = p_EmptyElementList;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLIdentifierList -> TextList

		//

		public void change(TextList p_TextList)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLIdentifierList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TextList = p_TextList;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLIdentifierList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_EmptyElementList != null) && m_EmptyElementList.checkInclusion (element) ||
				(m_TextList != null) && m_TextList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLIdentifierList

		//
		// emit production tree node associated with any production of syntax rule XMLIdentifierList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLIdentifierList_1:
					// emit syntax tree node associated with production
					// XMLIdentifierList: EmptyElementList

					s += m_EmptyElementList.Emit (depth - 1);
				break;
				case production_kind.g_XMLIdentifierList_2:
					// emit syntax tree node associated with production
					// XMLIdentifierList: TextList

					s += m_TextList.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLIdentifierList
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLIdentifierList (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLIdentifierList_1:
					// emit syntax tree node associated with production
					// XMLIdentifierList: EmptyElementList

					s += m_EmptyElementList.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLIdentifierList_2:
					// emit syntax tree node associated with production
					// XMLIdentifierList: TextList

					s += m_TextList.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLIdentifierList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLIdentifierList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLIdentifierList.production_kind kind = (XMLIdentifierList.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLIdentifierList.production_kind.g_XMLIdentifierList_1:
					// traverse syntax tree node associated with production
					// XMLIdentifierList: EmptyElementList

						m_EmptyElementList.Visit (visitor, appData);
				break;
				case XMLIdentifierList.production_kind.g_XMLIdentifierList_2:
					// traverse syntax tree node associated with production
					// XMLIdentifierList: TextList

						m_TextList.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_EmptyElementList?.reparent (this);
			m_TextList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLIdentifierList
		//

		public void _init ()
		{
			m_EmptyElementList = null;
			m_TextList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLIdentifierList

		// counter of all nodes associated with syntax rule XMLIdentifierList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLIdentifierList
		[DataMember (Name = "m_EmptyElementList")] public EmptyElementList m_EmptyElementList { get; private set; }
		[DataMember (Name = "m_TextList")] public TextList m_TextList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLIdentifierList

		// delegate function (callback) prototype associated with syntax rule XMLIdentifierList
		public delegate bool XMLIdentifierList_Callback (SyntaxTreeCallbackReason reason, XMLIdentifierList.production_kind kind, XMLIdentifierList p_XMLIdentifierList);

		// event associated with syntax rule XMLIdentifierList
		public event XMLIdentifierList_Callback XMLIdentifierList_Event;

		// event trigger associated with syntax rule XMLIdentifierList
		public bool Raise_XMLIdentifierList_Event (SyntaxTreeCallbackReason reason, XMLIdentifierList.production_kind kind, XMLIdentifierList p_XMLIdentifierList)
		{
			bool? status = XMLIdentifierList_Event?.Invoke (reason, kind, p_XMLIdentifierList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLIdentifierList
		//
		// traverse syntax tree node associated with any production of syntax rule XMLIdentifierList
		//

		public void Traverse (XMLIdentifierList p_XMLIdentifierList)
		{
			if (p_XMLIdentifierList.isLocked())
				return;
			p_XMLIdentifierList.dolock();
			XMLIdentifierList.production_kind kind = (XMLIdentifierList.production_kind) p_XMLIdentifierList.kind;
			p_XMLIdentifierList.turn_reset ();
			if (Raise_XMLIdentifierList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLIdentifierList))
			switch (kind)
			{
				case XMLIdentifierList.production_kind.g_XMLIdentifierList_1:
					// traverse syntax tree node associated with production
					// XMLIdentifierList: EmptyElementList

					if (Raise_XMLIdentifierList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLIdentifierList))
						Traverse (p_XMLIdentifierList.m_EmptyElementList);
					p_XMLIdentifierList.turn_inc ();
					Raise_XMLIdentifierList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLIdentifierList);
				break;
				case XMLIdentifierList.production_kind.g_XMLIdentifierList_2:
					// traverse syntax tree node associated with production
					// XMLIdentifierList: TextList

					if (Raise_XMLIdentifierList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLIdentifierList))
						Traverse (p_XMLIdentifierList.m_TextList);
					p_XMLIdentifierList.turn_inc ();
					Raise_XMLIdentifierList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLIdentifierList);
				break;
			}
			Raise_XMLIdentifierList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLIdentifierList);
			p_XMLIdentifierList.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLIdentifierList
		//

		public void TraverseCommon (XMLIdentifierList p_XMLIdentifierList)
		{
			XMLIdentifierList.production_kind kind = (XMLIdentifierList.production_kind) p_XMLIdentifierList.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLIdentifierList))
			switch (kind)
			{
				case XMLIdentifierList.production_kind.g_XMLIdentifierList_1:
					// traverse syntax tree node associated with production
					// XMLIdentifierList: EmptyElementList

						TraverseCommon (p_XMLIdentifierList.m_EmptyElementList);
				break;
				case XMLIdentifierList.production_kind.g_XMLIdentifierList_2:
					// traverse syntax tree node associated with production
					// XMLIdentifierList: TextList

						TraverseCommon (p_XMLIdentifierList.m_TextList);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLIdentifierList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLIdentifierList

		//
		// create syntax tree node associated with production
		// XMLIdentifierList: EmptyElementList

		//

		public XMLIdentifierList XMLIdentifierList_1 (EmptyElementList p_EmptyElementList)
		{
			XMLIdentifierList p_XMLIdentifierList_ref = new XMLIdentifierList(p_EmptyElementList);
			p_EmptyElementList.parent = p_XMLIdentifierList_ref;
			Raise_XMLIdentifierList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLIdentifierList.production_kind.g_XMLIdentifierList_1, p_XMLIdentifierList_ref);
			return p_XMLIdentifierList_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLIdentifierList: TextList

		//

		public XMLIdentifierList XMLIdentifierList_2 (TextList p_TextList)
		{
			XMLIdentifierList p_XMLIdentifierList_ref = new XMLIdentifierList(p_TextList);
			p_TextList.parent = p_XMLIdentifierList_ref;
			Raise_XMLIdentifierList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLIdentifierList.production_kind.g_XMLIdentifierList_2, p_XMLIdentifierList_ref);
			return p_XMLIdentifierList_ref;
		}
		#endregion
	};
}
