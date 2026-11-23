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
	// class associated with syntax rule XMLPrefixedValue
	//

	[DataContract]
	public class	XMLPrefixedValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLPrefixedValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLPrefixedValue
		{
			g_XMLPrefixedValue_1 = 1,	// XMLValue

		};
		#endregion
		#region production markers associated with the syntax rule XMLPrefixedValue

		// markers associated with production: XMLPrefixedValue -> XMLValue

		public enum production_marker_1 : ushort
		{
			m_XMLValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLPrefixedValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLPrefixedValue

		//
		// Constructor associated with the following production(s)
		// XMLPrefixedValue -> XMLValue

		//

		public XMLPrefixedValue (XMLValue p_XMLValue) : base ((uint) ProductionID._XMLPrefixedValue_ID, (uint) production_kind.g_XMLPrefixedValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLValue = p_XMLValue;
		}

		public XMLPrefixedValue () { }

		// Copy constructor

		public XMLPrefixedValue (XMLPrefixedValue p_XMLPrefixedValue) : base (p_XMLPrefixedValue.id, p_XMLPrefixedValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLPrefixedValue.appInfo;
			switch ((production_kind) p_XMLPrefixedValue.kind)
			{
				case production_kind.g_XMLPrefixedValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLValue = (p_XMLPrefixedValue.m_XMLValue != null) ? new XMLValue (p_XMLPrefixedValue.m_XMLValue) : null) != null) m_XMLValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLPrefixedValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLPrefixedValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLPrefixedValue

		// Content changing function(s) associated with production(s) of syntax rule XMLPrefixedValue

		//
		// Content changing function associated with following production(s)
		// XMLPrefixedValue -> XMLValue

		//

		public void change(XMLValue p_XMLValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLPrefixedValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLValue = p_XMLValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLPrefixedValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLValue != null) && m_XMLValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLPrefixedValue

		//
		// emit production tree node associated with any production of syntax rule XMLPrefixedValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLPrefixedValue_1:
					// emit syntax tree node associated with production
					// XMLPrefixedValue: XMLValue

					s += m_XMLValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLPrefixedValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLPrefixedValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLPrefixedValue_1:
					// emit syntax tree node associated with production
					// XMLPrefixedValue: XMLValue

					s += m_XMLValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLPrefixedValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLPrefixedValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLPrefixedValue.production_kind kind = (XMLPrefixedValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLPrefixedValue.production_kind.g_XMLPrefixedValue_1:
					// traverse syntax tree node associated with production
					// XMLPrefixedValue: XMLValue

						m_XMLValue.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_XMLValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLPrefixedValue
		//

		public void _init ()
		{
			m_XMLValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLPrefixedValue

		// counter of all nodes associated with syntax rule XMLPrefixedValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLPrefixedValue
		[DataMember (Name = "m_XMLValue")] public XMLValue m_XMLValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLPrefixedValue

		// delegate function (callback) prototype associated with syntax rule XMLPrefixedValue
		public delegate bool XMLPrefixedValue_Callback (SyntaxTreeCallbackReason reason, XMLPrefixedValue.production_kind kind, XMLPrefixedValue p_XMLPrefixedValue);

		// event associated with syntax rule XMLPrefixedValue
		public event XMLPrefixedValue_Callback XMLPrefixedValue_Event;

		// event trigger associated with syntax rule XMLPrefixedValue
		public bool Raise_XMLPrefixedValue_Event (SyntaxTreeCallbackReason reason, XMLPrefixedValue.production_kind kind, XMLPrefixedValue p_XMLPrefixedValue)
		{
			bool? status = XMLPrefixedValue_Event?.Invoke (reason, kind, p_XMLPrefixedValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLPrefixedValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLPrefixedValue
		//

		public void Traverse (XMLPrefixedValue p_XMLPrefixedValue)
		{
			if (p_XMLPrefixedValue.isLocked())
				return;
			p_XMLPrefixedValue.dolock();
			XMLPrefixedValue.production_kind kind = (XMLPrefixedValue.production_kind) p_XMLPrefixedValue.kind;
			p_XMLPrefixedValue.turn_reset ();
			if (Raise_XMLPrefixedValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLPrefixedValue))
			switch (kind)
			{
				case XMLPrefixedValue.production_kind.g_XMLPrefixedValue_1:
					// traverse syntax tree node associated with production
					// XMLPrefixedValue: XMLValue

					if (Raise_XMLPrefixedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLPrefixedValue))
						Traverse (p_XMLPrefixedValue.m_XMLValue);
					p_XMLPrefixedValue.turn_inc ();
					Raise_XMLPrefixedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLPrefixedValue);
				break;
			}
			Raise_XMLPrefixedValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLPrefixedValue);
			p_XMLPrefixedValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLPrefixedValue
		//

		public void TraverseCommon (XMLPrefixedValue p_XMLPrefixedValue)
		{
			XMLPrefixedValue.production_kind kind = (XMLPrefixedValue.production_kind) p_XMLPrefixedValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLPrefixedValue))
			switch (kind)
			{
				case XMLPrefixedValue.production_kind.g_XMLPrefixedValue_1:
					// traverse syntax tree node associated with production
					// XMLPrefixedValue: XMLValue

						TraverseCommon (p_XMLPrefixedValue.m_XMLValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLPrefixedValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLPrefixedValue

		//
		// create syntax tree node associated with production
		// XMLPrefixedValue: XMLValue

		//

		public XMLPrefixedValue XMLPrefixedValue_1 (XMLValue p_XMLValue)
		{
			XMLPrefixedValue p_XMLPrefixedValue_ref = new XMLPrefixedValue(p_XMLValue);
			p_XMLValue.parent = p_XMLPrefixedValue_ref;
			Raise_XMLPrefixedValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLPrefixedValue.production_kind.g_XMLPrefixedValue_1, p_XMLPrefixedValue_ref);
			return p_XMLPrefixedValue_ref;
		}
		#endregion
	};
}
