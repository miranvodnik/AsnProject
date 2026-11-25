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
	// class associated with syntax rule XMLSetValue
	//

	[DataContract]
	public class	XMLSetValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLSetValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLSetValue
		{
			g_XMLSetValue_1 = 1,	// XMLComponentValueList

			g_XMLSetValue_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule XMLSetValue

		// markers associated with production: XMLSetValue -> XMLComponentValueList

		public enum production_marker_1 : ushort
		{
			m_XMLComponentValueList,
			final
		};

		// markers associated with production: XMLSetValue -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLSetValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLSetValue

		//
		// Constructor associated with the following production(s)
		// XMLSetValue -> XMLComponentValueList

		//

		public XMLSetValue (XMLComponentValueList p_XMLComponentValueList) : base ((uint) ProductionID._XMLSetValue_ID, (uint) production_kind.g_XMLSetValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLComponentValueList = p_XMLComponentValueList;
		}

		//
		// Constructor associated with the following production(s)
		// XMLSetValue -> %empty

		//

		public XMLSetValue () : base ((uint) ProductionID._XMLSetValue_ID, (uint) production_kind.g_XMLSetValue_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public XMLSetValue (XMLSetValue p_XMLSetValue) : base (p_XMLSetValue.id, p_XMLSetValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLSetValue.appInfo;
			switch ((production_kind) p_XMLSetValue.kind)
			{
				case production_kind.g_XMLSetValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLComponentValueList = (p_XMLSetValue.m_XMLComponentValueList != null) ? new XMLComponentValueList (p_XMLSetValue.m_XMLComponentValueList) : null) != null) m_XMLComponentValueList.parent = this;
					break;
				case production_kind.g_XMLSetValue_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "XMLSetValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLSetValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLComponentValueList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLSetValue

		// Content changing function(s) associated with production(s) of syntax rule XMLSetValue

		//
		// Content changing function associated with following production(s)
		// XMLSetValue -> XMLComponentValueList

		//

		public void change(XMLComponentValueList p_XMLComponentValueList)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLSetValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLComponentValueList = p_XMLComponentValueList;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLSetValue -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLSetValue_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLSetValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLComponentValueList != null) && m_XMLComponentValueList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLSetValue

		//
		// emit production tree node associated with any production of syntax rule XMLSetValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLSetValue_1:
					// emit syntax tree node associated with production
					// XMLSetValue: XMLComponentValueList

					s += m_XMLComponentValueList.Emit (depth - 1);
				break;
				case production_kind.g_XMLSetValue_2:
					// emit syntax tree node associated with production
					// XMLSetValue: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLSetValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLSetValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLSetValue_1:
					// emit syntax tree node associated with production
					// XMLSetValue: XMLComponentValueList

					s += m_XMLComponentValueList.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLSetValue_2:
					// emit syntax tree node associated with production
					// XMLSetValue: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLSetValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLSetValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLSetValue.production_kind kind = (XMLSetValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLSetValue.production_kind.g_XMLSetValue_1:
					// traverse syntax tree node associated with production
					// XMLSetValue: XMLComponentValueList

						m_XMLComponentValueList.Visit (visitor, appData);
				break;
				case XMLSetValue.production_kind.g_XMLSetValue_2:
					// traverse syntax tree node associated with production
					// XMLSetValue: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_XMLComponentValueList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLSetValue
		//

		public void _init ()
		{
			m_XMLComponentValueList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLSetValue

		// counter of all nodes associated with syntax rule XMLSetValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLSetValue
		[DataMember (Name = "m_XMLComponentValueList")] public XMLComponentValueList m_XMLComponentValueList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLSetValue

		// delegate function (callback) prototype associated with syntax rule XMLSetValue
		public delegate bool XMLSetValue_Callback (SyntaxTreeCallbackReason reason, XMLSetValue.production_kind kind, XMLSetValue p_XMLSetValue);

		// event associated with syntax rule XMLSetValue
		public event XMLSetValue_Callback XMLSetValue_Event;

		// event trigger associated with syntax rule XMLSetValue
		public bool Raise_XMLSetValue_Event (SyntaxTreeCallbackReason reason, XMLSetValue.production_kind kind, XMLSetValue p_XMLSetValue)
		{
			bool? status = XMLSetValue_Event?.Invoke (reason, kind, p_XMLSetValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLSetValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLSetValue
		//

		public void Traverse (XMLSetValue p_XMLSetValue)
		{
			if (p_XMLSetValue.isLocked())
				return;
			p_XMLSetValue.dolock();
			XMLSetValue.production_kind kind = (XMLSetValue.production_kind) p_XMLSetValue.kind;
			p_XMLSetValue.turn_reset ();
			if (Raise_XMLSetValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLSetValue))
			switch (kind)
			{
				case XMLSetValue.production_kind.g_XMLSetValue_1:
					// traverse syntax tree node associated with production
					// XMLSetValue: XMLComponentValueList

					if (Raise_XMLSetValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLSetValue))
						Traverse (p_XMLSetValue.m_XMLComponentValueList);
					p_XMLSetValue.turn_inc ();
					Raise_XMLSetValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLSetValue);
				break;
				case XMLSetValue.production_kind.g_XMLSetValue_2:
					// traverse syntax tree node associated with production
					// XMLSetValue: %empty

				break;
			}
			Raise_XMLSetValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLSetValue);
			p_XMLSetValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLSetValue
		//

		public void TraverseCommon (XMLSetValue p_XMLSetValue)
		{
			XMLSetValue.production_kind kind = (XMLSetValue.production_kind) p_XMLSetValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLSetValue))
			switch (kind)
			{
				case XMLSetValue.production_kind.g_XMLSetValue_1:
					// traverse syntax tree node associated with production
					// XMLSetValue: XMLComponentValueList

						TraverseCommon (p_XMLSetValue.m_XMLComponentValueList);
				break;
				case XMLSetValue.production_kind.g_XMLSetValue_2:
					// traverse syntax tree node associated with production
					// XMLSetValue: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLSetValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLSetValue

		//
		// create syntax tree node associated with production
		// XMLSetValue: XMLComponentValueList

		//

		public XMLSetValue XMLSetValue_1 (XMLComponentValueList p_XMLComponentValueList)
		{
			XMLSetValue p_XMLSetValue_ref = new XMLSetValue(p_XMLComponentValueList);
			p_XMLComponentValueList.parent = p_XMLSetValue_ref;
			Raise_XMLSetValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLSetValue.production_kind.g_XMLSetValue_1, p_XMLSetValue_ref);
			return p_XMLSetValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLSetValue: %empty

		//

		public XMLSetValue XMLSetValue_2 ()
		{
			XMLSetValue p_XMLSetValue_ref = new XMLSetValue();
			Raise_XMLSetValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLSetValue.production_kind.g_XMLSetValue_2, p_XMLSetValue_ref);
			return p_XMLSetValue_ref;
		}
		#endregion
	};
}
