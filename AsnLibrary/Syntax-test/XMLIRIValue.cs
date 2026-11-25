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
	// class associated with syntax rule XMLIRIValue
	//

	[DataContract]
	public class	XMLIRIValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLIRIValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLIRIValue
		{
			g_XMLIRIValue_1 = 1,	// ArcList

		};
		#endregion
		#region production markers associated with the syntax rule XMLIRIValue

		// markers associated with production: XMLIRIValue -> ArcList

		public enum production_marker_1 : ushort
		{
			m_ArcList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLIRIValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLIRIValue

		//
		// Constructor associated with the following production(s)
		// XMLIRIValue -> ArcList

		//

		public XMLIRIValue (ArcList p_ArcList) : base ((uint) ProductionID._XMLIRIValue_ID, (uint) production_kind.g_XMLIRIValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ArcList = p_ArcList;
		}

		public XMLIRIValue () { }

		// Copy constructor

		public XMLIRIValue (XMLIRIValue p_XMLIRIValue) : base (p_XMLIRIValue.id, p_XMLIRIValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLIRIValue.appInfo;
			switch ((production_kind) p_XMLIRIValue.kind)
			{
				case production_kind.g_XMLIRIValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ArcList = (p_XMLIRIValue.m_ArcList != null) ? new ArcList (p_XMLIRIValue.m_ArcList) : null) != null) m_ArcList.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLIRIValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLIRIValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ArcList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLIRIValue

		// Content changing function(s) associated with production(s) of syntax rule XMLIRIValue

		//
		// Content changing function associated with following production(s)
		// XMLIRIValue -> ArcList

		//

		public void change(ArcList p_ArcList)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLIRIValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ArcList = p_ArcList;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLIRIValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ArcList != null) && m_ArcList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLIRIValue

		//
		// emit production tree node associated with any production of syntax rule XMLIRIValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLIRIValue_1:
					// emit syntax tree node associated with production
					// XMLIRIValue: ArcList

					s += m_ArcList.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLIRIValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLIRIValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLIRIValue_1:
					// emit syntax tree node associated with production
					// XMLIRIValue: ArcList

					s += m_ArcList.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLIRIValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLIRIValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLIRIValue.production_kind kind = (XMLIRIValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLIRIValue.production_kind.g_XMLIRIValue_1:
					// traverse syntax tree node associated with production
					// XMLIRIValue: ArcList

						m_ArcList.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ArcList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLIRIValue
		//

		public void _init ()
		{
			m_ArcList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLIRIValue

		// counter of all nodes associated with syntax rule XMLIRIValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLIRIValue
		[DataMember (Name = "m_ArcList")] public ArcList m_ArcList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLIRIValue

		// delegate function (callback) prototype associated with syntax rule XMLIRIValue
		public delegate bool XMLIRIValue_Callback (SyntaxTreeCallbackReason reason, XMLIRIValue.production_kind kind, XMLIRIValue p_XMLIRIValue);

		// event associated with syntax rule XMLIRIValue
		public event XMLIRIValue_Callback XMLIRIValue_Event;

		// event trigger associated with syntax rule XMLIRIValue
		public bool Raise_XMLIRIValue_Event (SyntaxTreeCallbackReason reason, XMLIRIValue.production_kind kind, XMLIRIValue p_XMLIRIValue)
		{
			bool? status = XMLIRIValue_Event?.Invoke (reason, kind, p_XMLIRIValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLIRIValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLIRIValue
		//

		public void Traverse (XMLIRIValue p_XMLIRIValue)
		{
			if (p_XMLIRIValue.isLocked())
				return;
			p_XMLIRIValue.dolock();
			XMLIRIValue.production_kind kind = (XMLIRIValue.production_kind) p_XMLIRIValue.kind;
			p_XMLIRIValue.turn_reset ();
			if (Raise_XMLIRIValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLIRIValue))
			switch (kind)
			{
				case XMLIRIValue.production_kind.g_XMLIRIValue_1:
					// traverse syntax tree node associated with production
					// XMLIRIValue: ArcList

					if (Raise_XMLIRIValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLIRIValue))
						Traverse (p_XMLIRIValue.m_ArcList);
					p_XMLIRIValue.turn_inc ();
					Raise_XMLIRIValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLIRIValue);
				break;
			}
			Raise_XMLIRIValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLIRIValue);
			p_XMLIRIValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLIRIValue
		//

		public void TraverseCommon (XMLIRIValue p_XMLIRIValue)
		{
			XMLIRIValue.production_kind kind = (XMLIRIValue.production_kind) p_XMLIRIValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLIRIValue))
			switch (kind)
			{
				case XMLIRIValue.production_kind.g_XMLIRIValue_1:
					// traverse syntax tree node associated with production
					// XMLIRIValue: ArcList

						TraverseCommon (p_XMLIRIValue.m_ArcList);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLIRIValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLIRIValue

		//
		// create syntax tree node associated with production
		// XMLIRIValue: ArcList

		//

		public XMLIRIValue XMLIRIValue_1 (ArcList p_ArcList)
		{
			XMLIRIValue p_XMLIRIValue_ref = new XMLIRIValue(p_ArcList);
			p_ArcList.parent = p_XMLIRIValue_ref;
			Raise_XMLIRIValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLIRIValue.production_kind.g_XMLIRIValue_1, p_XMLIRIValue_ref);
			return p_XMLIRIValue_ref;
		}
		#endregion
	};
}
