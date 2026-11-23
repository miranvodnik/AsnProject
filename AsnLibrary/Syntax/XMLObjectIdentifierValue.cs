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
	// class associated with syntax rule XMLObjectIdentifierValue
	//

	[DataContract]
	public class	XMLObjectIdentifierValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLObjectIdentifierValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLObjectIdentifierValue
		{
			g_XMLObjectIdentifierValue_1 = 1,	// XMLObjIdComponentList

		};
		#endregion
		#region production markers associated with the syntax rule XMLObjectIdentifierValue

		// markers associated with production: XMLObjectIdentifierValue -> XMLObjIdComponentList

		public enum production_marker_1 : ushort
		{
			m_XMLObjIdComponentList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLObjectIdentifierValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLObjectIdentifierValue

		//
		// Constructor associated with the following production(s)
		// XMLObjectIdentifierValue -> XMLObjIdComponentList

		//

		public XMLObjectIdentifierValue (XMLObjIdComponentList p_XMLObjIdComponentList) : base ((uint) ProductionID._XMLObjectIdentifierValue_ID, (uint) production_kind.g_XMLObjectIdentifierValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLObjIdComponentList = p_XMLObjIdComponentList;
		}

		public XMLObjectIdentifierValue () { }

		// Copy constructor

		public XMLObjectIdentifierValue (XMLObjectIdentifierValue p_XMLObjectIdentifierValue) : base (p_XMLObjectIdentifierValue.id, p_XMLObjectIdentifierValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLObjectIdentifierValue.appInfo;
			switch ((production_kind) p_XMLObjectIdentifierValue.kind)
			{
				case production_kind.g_XMLObjectIdentifierValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLObjIdComponentList = (p_XMLObjectIdentifierValue.m_XMLObjIdComponentList != null) ? new XMLObjIdComponentList (p_XMLObjectIdentifierValue.m_XMLObjIdComponentList) : null) != null) m_XMLObjIdComponentList.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLObjectIdentifierValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLObjectIdentifierValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLObjIdComponentList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLObjectIdentifierValue

		// Content changing function(s) associated with production(s) of syntax rule XMLObjectIdentifierValue

		//
		// Content changing function associated with following production(s)
		// XMLObjectIdentifierValue -> XMLObjIdComponentList

		//

		public void change(XMLObjIdComponentList p_XMLObjIdComponentList)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLObjectIdentifierValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLObjIdComponentList = p_XMLObjIdComponentList;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLObjectIdentifierValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLObjIdComponentList != null) && m_XMLObjIdComponentList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLObjectIdentifierValue

		//
		// emit production tree node associated with any production of syntax rule XMLObjectIdentifierValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLObjectIdentifierValue_1:
					// emit syntax tree node associated with production
					// XMLObjectIdentifierValue: XMLObjIdComponentList

					s += m_XMLObjIdComponentList.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLObjectIdentifierValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLObjectIdentifierValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLObjectIdentifierValue_1:
					// emit syntax tree node associated with production
					// XMLObjectIdentifierValue: XMLObjIdComponentList

					s += m_XMLObjIdComponentList.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLObjectIdentifierValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLObjectIdentifierValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLObjectIdentifierValue.production_kind kind = (XMLObjectIdentifierValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLObjectIdentifierValue.production_kind.g_XMLObjectIdentifierValue_1:
					// traverse syntax tree node associated with production
					// XMLObjectIdentifierValue: XMLObjIdComponentList

						m_XMLObjIdComponentList.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_XMLObjIdComponentList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLObjectIdentifierValue
		//

		public void _init ()
		{
			m_XMLObjIdComponentList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLObjectIdentifierValue

		// counter of all nodes associated with syntax rule XMLObjectIdentifierValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLObjectIdentifierValue
		[DataMember (Name = "m_XMLObjIdComponentList")] public XMLObjIdComponentList m_XMLObjIdComponentList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLObjectIdentifierValue

		// delegate function (callback) prototype associated with syntax rule XMLObjectIdentifierValue
		public delegate bool XMLObjectIdentifierValue_Callback (SyntaxTreeCallbackReason reason, XMLObjectIdentifierValue.production_kind kind, XMLObjectIdentifierValue p_XMLObjectIdentifierValue);

		// event associated with syntax rule XMLObjectIdentifierValue
		public event XMLObjectIdentifierValue_Callback XMLObjectIdentifierValue_Event;

		// event trigger associated with syntax rule XMLObjectIdentifierValue
		public bool Raise_XMLObjectIdentifierValue_Event (SyntaxTreeCallbackReason reason, XMLObjectIdentifierValue.production_kind kind, XMLObjectIdentifierValue p_XMLObjectIdentifierValue)
		{
			bool? status = XMLObjectIdentifierValue_Event?.Invoke (reason, kind, p_XMLObjectIdentifierValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLObjectIdentifierValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLObjectIdentifierValue
		//

		public void Traverse (XMLObjectIdentifierValue p_XMLObjectIdentifierValue)
		{
			if (p_XMLObjectIdentifierValue.isLocked())
				return;
			p_XMLObjectIdentifierValue.dolock();
			XMLObjectIdentifierValue.production_kind kind = (XMLObjectIdentifierValue.production_kind) p_XMLObjectIdentifierValue.kind;
			p_XMLObjectIdentifierValue.turn_reset ();
			if (Raise_XMLObjectIdentifierValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLObjectIdentifierValue))
			switch (kind)
			{
				case XMLObjectIdentifierValue.production_kind.g_XMLObjectIdentifierValue_1:
					// traverse syntax tree node associated with production
					// XMLObjectIdentifierValue: XMLObjIdComponentList

					if (Raise_XMLObjectIdentifierValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLObjectIdentifierValue))
						Traverse (p_XMLObjectIdentifierValue.m_XMLObjIdComponentList);
					p_XMLObjectIdentifierValue.turn_inc ();
					Raise_XMLObjectIdentifierValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLObjectIdentifierValue);
				break;
			}
			Raise_XMLObjectIdentifierValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLObjectIdentifierValue);
			p_XMLObjectIdentifierValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLObjectIdentifierValue
		//

		public void TraverseCommon (XMLObjectIdentifierValue p_XMLObjectIdentifierValue)
		{
			XMLObjectIdentifierValue.production_kind kind = (XMLObjectIdentifierValue.production_kind) p_XMLObjectIdentifierValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLObjectIdentifierValue))
			switch (kind)
			{
				case XMLObjectIdentifierValue.production_kind.g_XMLObjectIdentifierValue_1:
					// traverse syntax tree node associated with production
					// XMLObjectIdentifierValue: XMLObjIdComponentList

						TraverseCommon (p_XMLObjectIdentifierValue.m_XMLObjIdComponentList);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLObjectIdentifierValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLObjectIdentifierValue

		//
		// create syntax tree node associated with production
		// XMLObjectIdentifierValue: XMLObjIdComponentList

		//

		public XMLObjectIdentifierValue XMLObjectIdentifierValue_1 (XMLObjIdComponentList p_XMLObjIdComponentList)
		{
			XMLObjectIdentifierValue p_XMLObjectIdentifierValue_ref = new XMLObjectIdentifierValue(p_XMLObjIdComponentList);
			p_XMLObjIdComponentList.parent = p_XMLObjectIdentifierValue_ref;
			Raise_XMLObjectIdentifierValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLObjectIdentifierValue.production_kind.g_XMLObjectIdentifierValue_1, p_XMLObjectIdentifierValue_ref);
			return p_XMLObjectIdentifierValue_ref;
		}
		#endregion
	};
}
