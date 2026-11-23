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
	// class associated with syntax rule XMLRelativeOIDValue
	//

	[DataContract]
	public class	XMLRelativeOIDValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLRelativeOIDValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLRelativeOIDValue
		{
			g_XMLRelativeOIDValue_1 = 1,	// XMLRelativeOIDComponentList

		};
		#endregion
		#region production markers associated with the syntax rule XMLRelativeOIDValue

		// markers associated with production: XMLRelativeOIDValue -> XMLRelativeOIDComponentList

		public enum production_marker_1 : ushort
		{
			m_XMLRelativeOIDComponentList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLRelativeOIDValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLRelativeOIDValue

		//
		// Constructor associated with the following production(s)
		// XMLRelativeOIDValue -> XMLRelativeOIDComponentList

		//

		public XMLRelativeOIDValue (XMLRelativeOIDComponentList p_XMLRelativeOIDComponentList) : base ((uint) ProductionID._XMLRelativeOIDValue_ID, (uint) production_kind.g_XMLRelativeOIDValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLRelativeOIDComponentList = p_XMLRelativeOIDComponentList;
		}

		public XMLRelativeOIDValue () { }

		// Copy constructor

		public XMLRelativeOIDValue (XMLRelativeOIDValue p_XMLRelativeOIDValue) : base (p_XMLRelativeOIDValue.id, p_XMLRelativeOIDValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLRelativeOIDValue.appInfo;
			switch ((production_kind) p_XMLRelativeOIDValue.kind)
			{
				case production_kind.g_XMLRelativeOIDValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLRelativeOIDComponentList = (p_XMLRelativeOIDValue.m_XMLRelativeOIDComponentList != null) ? new XMLRelativeOIDComponentList (p_XMLRelativeOIDValue.m_XMLRelativeOIDComponentList) : null) != null) m_XMLRelativeOIDComponentList.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLRelativeOIDValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLRelativeOIDValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLRelativeOIDComponentList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLRelativeOIDValue

		// Content changing function(s) associated with production(s) of syntax rule XMLRelativeOIDValue

		//
		// Content changing function associated with following production(s)
		// XMLRelativeOIDValue -> XMLRelativeOIDComponentList

		//

		public void change(XMLRelativeOIDComponentList p_XMLRelativeOIDComponentList)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLRelativeOIDValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLRelativeOIDComponentList = p_XMLRelativeOIDComponentList;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLRelativeOIDValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLRelativeOIDComponentList != null) && m_XMLRelativeOIDComponentList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLRelativeOIDValue

		//
		// emit production tree node associated with any production of syntax rule XMLRelativeOIDValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLRelativeOIDValue_1:
					// emit syntax tree node associated with production
					// XMLRelativeOIDValue: XMLRelativeOIDComponentList

					s += m_XMLRelativeOIDComponentList.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLRelativeOIDValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLRelativeOIDValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLRelativeOIDValue_1:
					// emit syntax tree node associated with production
					// XMLRelativeOIDValue: XMLRelativeOIDComponentList

					s += m_XMLRelativeOIDComponentList.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLRelativeOIDValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLRelativeOIDValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLRelativeOIDValue.production_kind kind = (XMLRelativeOIDValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLRelativeOIDValue.production_kind.g_XMLRelativeOIDValue_1:
					// traverse syntax tree node associated with production
					// XMLRelativeOIDValue: XMLRelativeOIDComponentList

						m_XMLRelativeOIDComponentList.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_XMLRelativeOIDComponentList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLRelativeOIDValue
		//

		public void _init ()
		{
			m_XMLRelativeOIDComponentList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLRelativeOIDValue

		// counter of all nodes associated with syntax rule XMLRelativeOIDValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLRelativeOIDValue
		[DataMember (Name = "m_XMLRelativeOIDComponentList")] public XMLRelativeOIDComponentList m_XMLRelativeOIDComponentList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLRelativeOIDValue

		// delegate function (callback) prototype associated with syntax rule XMLRelativeOIDValue
		public delegate bool XMLRelativeOIDValue_Callback (SyntaxTreeCallbackReason reason, XMLRelativeOIDValue.production_kind kind, XMLRelativeOIDValue p_XMLRelativeOIDValue);

		// event associated with syntax rule XMLRelativeOIDValue
		public event XMLRelativeOIDValue_Callback XMLRelativeOIDValue_Event;

		// event trigger associated with syntax rule XMLRelativeOIDValue
		public bool Raise_XMLRelativeOIDValue_Event (SyntaxTreeCallbackReason reason, XMLRelativeOIDValue.production_kind kind, XMLRelativeOIDValue p_XMLRelativeOIDValue)
		{
			bool? status = XMLRelativeOIDValue_Event?.Invoke (reason, kind, p_XMLRelativeOIDValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLRelativeOIDValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLRelativeOIDValue
		//

		public void Traverse (XMLRelativeOIDValue p_XMLRelativeOIDValue)
		{
			if (p_XMLRelativeOIDValue.isLocked())
				return;
			p_XMLRelativeOIDValue.dolock();
			XMLRelativeOIDValue.production_kind kind = (XMLRelativeOIDValue.production_kind) p_XMLRelativeOIDValue.kind;
			p_XMLRelativeOIDValue.turn_reset ();
			if (Raise_XMLRelativeOIDValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLRelativeOIDValue))
			switch (kind)
			{
				case XMLRelativeOIDValue.production_kind.g_XMLRelativeOIDValue_1:
					// traverse syntax tree node associated with production
					// XMLRelativeOIDValue: XMLRelativeOIDComponentList

					if (Raise_XMLRelativeOIDValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLRelativeOIDValue))
						Traverse (p_XMLRelativeOIDValue.m_XMLRelativeOIDComponentList);
					p_XMLRelativeOIDValue.turn_inc ();
					Raise_XMLRelativeOIDValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLRelativeOIDValue);
				break;
			}
			Raise_XMLRelativeOIDValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLRelativeOIDValue);
			p_XMLRelativeOIDValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLRelativeOIDValue
		//

		public void TraverseCommon (XMLRelativeOIDValue p_XMLRelativeOIDValue)
		{
			XMLRelativeOIDValue.production_kind kind = (XMLRelativeOIDValue.production_kind) p_XMLRelativeOIDValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLRelativeOIDValue))
			switch (kind)
			{
				case XMLRelativeOIDValue.production_kind.g_XMLRelativeOIDValue_1:
					// traverse syntax tree node associated with production
					// XMLRelativeOIDValue: XMLRelativeOIDComponentList

						TraverseCommon (p_XMLRelativeOIDValue.m_XMLRelativeOIDComponentList);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLRelativeOIDValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLRelativeOIDValue

		//
		// create syntax tree node associated with production
		// XMLRelativeOIDValue: XMLRelativeOIDComponentList

		//

		public XMLRelativeOIDValue XMLRelativeOIDValue_1 (XMLRelativeOIDComponentList p_XMLRelativeOIDComponentList)
		{
			XMLRelativeOIDValue p_XMLRelativeOIDValue_ref = new XMLRelativeOIDValue(p_XMLRelativeOIDComponentList);
			p_XMLRelativeOIDComponentList.parent = p_XMLRelativeOIDValue_ref;
			Raise_XMLRelativeOIDValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLRelativeOIDValue.production_kind.g_XMLRelativeOIDValue_1, p_XMLRelativeOIDValue_ref);
			return p_XMLRelativeOIDValue_ref;
		}
		#endregion
	};
}
