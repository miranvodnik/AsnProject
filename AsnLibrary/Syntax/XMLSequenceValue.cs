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
	// class associated with syntax rule XMLSequenceValue
	//

	[DataContract]
	public class	XMLSequenceValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLSequenceValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLSequenceValue
		{
			g_XMLSequenceValue_1 = 1,	// XMLComponentValueList

			g_XMLSequenceValue_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule XMLSequenceValue

		// markers associated with production: XMLSequenceValue -> XMLComponentValueList

		public enum production_marker_1 : ushort
		{
			m_XMLComponentValueList,
			final
		};

		// markers associated with production: XMLSequenceValue -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLSequenceValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLSequenceValue

		//
		// Constructor associated with the following production(s)
		// XMLSequenceValue -> XMLComponentValueList

		//

		public XMLSequenceValue (XMLComponentValueList p_XMLComponentValueList) : base ((uint) ProductionID._XMLSequenceValue_ID, (uint) production_kind.g_XMLSequenceValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLComponentValueList = p_XMLComponentValueList;
		}

		//
		// Constructor associated with the following production(s)
		// XMLSequenceValue -> %empty

		//

		public XMLSequenceValue () : base ((uint) ProductionID._XMLSequenceValue_ID, (uint) production_kind.g_XMLSequenceValue_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public XMLSequenceValue (XMLSequenceValue p_XMLSequenceValue) : base (p_XMLSequenceValue.id, p_XMLSequenceValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLSequenceValue.appInfo;
			switch ((production_kind) p_XMLSequenceValue.kind)
			{
				case production_kind.g_XMLSequenceValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLComponentValueList = (p_XMLSequenceValue.m_XMLComponentValueList != null) ? new XMLComponentValueList (p_XMLSequenceValue.m_XMLComponentValueList) : null) != null) m_XMLComponentValueList.parent = this;
					break;
				case production_kind.g_XMLSequenceValue_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "XMLSequenceValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLSequenceValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLComponentValueList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLSequenceValue

		// Content changing function(s) associated with production(s) of syntax rule XMLSequenceValue

		//
		// Content changing function associated with following production(s)
		// XMLSequenceValue -> XMLComponentValueList

		//

		public void change(XMLComponentValueList p_XMLComponentValueList)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLSequenceValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLComponentValueList = p_XMLComponentValueList;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLSequenceValue -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLSequenceValue_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLSequenceValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLComponentValueList != null) && m_XMLComponentValueList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLSequenceValue

		//
		// emit production tree node associated with any production of syntax rule XMLSequenceValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLSequenceValue_1:
					// emit syntax tree node associated with production
					// XMLSequenceValue: XMLComponentValueList

					s += m_XMLComponentValueList.Emit (depth - 1);
				break;
				case production_kind.g_XMLSequenceValue_2:
					// emit syntax tree node associated with production
					// XMLSequenceValue: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLSequenceValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLSequenceValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLSequenceValue_1:
					// emit syntax tree node associated with production
					// XMLSequenceValue: XMLComponentValueList

					s += m_XMLComponentValueList.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLSequenceValue_2:
					// emit syntax tree node associated with production
					// XMLSequenceValue: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLSequenceValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLSequenceValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLSequenceValue.production_kind kind = (XMLSequenceValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLSequenceValue.production_kind.g_XMLSequenceValue_1:
					// traverse syntax tree node associated with production
					// XMLSequenceValue: XMLComponentValueList

						m_XMLComponentValueList.Visit (visitor, appData);
				break;
				case XMLSequenceValue.production_kind.g_XMLSequenceValue_2:
					// traverse syntax tree node associated with production
					// XMLSequenceValue: %empty

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
		// initialize object associated with syntax rule XMLSequenceValue
		//

		public void _init ()
		{
			m_XMLComponentValueList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLSequenceValue

		// counter of all nodes associated with syntax rule XMLSequenceValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLSequenceValue
		[DataMember (Name = "m_XMLComponentValueList")] public XMLComponentValueList m_XMLComponentValueList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLSequenceValue

		// delegate function (callback) prototype associated with syntax rule XMLSequenceValue
		public delegate bool XMLSequenceValue_Callback (SyntaxTreeCallbackReason reason, XMLSequenceValue.production_kind kind, XMLSequenceValue p_XMLSequenceValue);

		// event associated with syntax rule XMLSequenceValue
		public event XMLSequenceValue_Callback XMLSequenceValue_Event;

		// event trigger associated with syntax rule XMLSequenceValue
		public bool Raise_XMLSequenceValue_Event (SyntaxTreeCallbackReason reason, XMLSequenceValue.production_kind kind, XMLSequenceValue p_XMLSequenceValue)
		{
			bool? status = XMLSequenceValue_Event?.Invoke (reason, kind, p_XMLSequenceValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLSequenceValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLSequenceValue
		//

		public void Traverse (XMLSequenceValue p_XMLSequenceValue)
		{
			if (p_XMLSequenceValue.isLocked())
				return;
			p_XMLSequenceValue.dolock();
			XMLSequenceValue.production_kind kind = (XMLSequenceValue.production_kind) p_XMLSequenceValue.kind;
			p_XMLSequenceValue.turn_reset ();
			if (Raise_XMLSequenceValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLSequenceValue))
			switch (kind)
			{
				case XMLSequenceValue.production_kind.g_XMLSequenceValue_1:
					// traverse syntax tree node associated with production
					// XMLSequenceValue: XMLComponentValueList

					if (Raise_XMLSequenceValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLSequenceValue))
						Traverse (p_XMLSequenceValue.m_XMLComponentValueList);
					p_XMLSequenceValue.turn_inc ();
					Raise_XMLSequenceValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLSequenceValue);
				break;
				case XMLSequenceValue.production_kind.g_XMLSequenceValue_2:
					// traverse syntax tree node associated with production
					// XMLSequenceValue: %empty

				break;
			}
			Raise_XMLSequenceValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLSequenceValue);
			p_XMLSequenceValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLSequenceValue
		//

		public void TraverseCommon (XMLSequenceValue p_XMLSequenceValue)
		{
			XMLSequenceValue.production_kind kind = (XMLSequenceValue.production_kind) p_XMLSequenceValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLSequenceValue))
			switch (kind)
			{
				case XMLSequenceValue.production_kind.g_XMLSequenceValue_1:
					// traverse syntax tree node associated with production
					// XMLSequenceValue: XMLComponentValueList

						TraverseCommon (p_XMLSequenceValue.m_XMLComponentValueList);
				break;
				case XMLSequenceValue.production_kind.g_XMLSequenceValue_2:
					// traverse syntax tree node associated with production
					// XMLSequenceValue: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLSequenceValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLSequenceValue

		//
		// create syntax tree node associated with production
		// XMLSequenceValue: XMLComponentValueList

		//

		public XMLSequenceValue XMLSequenceValue_1 (XMLComponentValueList p_XMLComponentValueList)
		{
			XMLSequenceValue p_XMLSequenceValue_ref = new XMLSequenceValue(p_XMLComponentValueList);
			p_XMLComponentValueList.parent = p_XMLSequenceValue_ref;
			Raise_XMLSequenceValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLSequenceValue.production_kind.g_XMLSequenceValue_1, p_XMLSequenceValue_ref);
			return p_XMLSequenceValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLSequenceValue: %empty

		//

		public XMLSequenceValue XMLSequenceValue_2 ()
		{
			XMLSequenceValue p_XMLSequenceValue_ref = new XMLSequenceValue();
			Raise_XMLSequenceValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLSequenceValue.production_kind.g_XMLSequenceValue_2, p_XMLSequenceValue_ref);
			return p_XMLSequenceValue_ref;
		}
		#endregion
	};
}
