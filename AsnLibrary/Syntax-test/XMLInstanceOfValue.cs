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
	// class associated with syntax rule XMLInstanceOfValue
	//

	[DataContract]
	public class	XMLInstanceOfValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLInstanceOfValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLInstanceOfValue
		{
			g_XMLInstanceOfValue_1 = 1,	// XMLValue

		};
		#endregion
		#region production markers associated with the syntax rule XMLInstanceOfValue

		// markers associated with production: XMLInstanceOfValue -> XMLValue

		public enum production_marker_1 : ushort
		{
			m_XMLValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLInstanceOfValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLInstanceOfValue

		//
		// Constructor associated with the following production(s)
		// XMLInstanceOfValue -> XMLValue

		//

		public XMLInstanceOfValue (XMLValue p_XMLValue) : base ((uint) ProductionID._XMLInstanceOfValue_ID, (uint) production_kind.g_XMLInstanceOfValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLValue = p_XMLValue;
		}

		public XMLInstanceOfValue () { }

		// Copy constructor

		public XMLInstanceOfValue (XMLInstanceOfValue p_XMLInstanceOfValue) : base (p_XMLInstanceOfValue.id, p_XMLInstanceOfValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLInstanceOfValue.appInfo;
			switch ((production_kind) p_XMLInstanceOfValue.kind)
			{
				case production_kind.g_XMLInstanceOfValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLValue = (p_XMLInstanceOfValue.m_XMLValue != null) ? new XMLValue (p_XMLInstanceOfValue.m_XMLValue) : null) != null) m_XMLValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLInstanceOfValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLInstanceOfValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLInstanceOfValue

		// Content changing function(s) associated with production(s) of syntax rule XMLInstanceOfValue

		//
		// Content changing function associated with following production(s)
		// XMLInstanceOfValue -> XMLValue

		//

		public void change(XMLValue p_XMLValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLInstanceOfValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLValue = p_XMLValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLInstanceOfValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLValue != null) && m_XMLValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLInstanceOfValue

		//
		// emit production tree node associated with any production of syntax rule XMLInstanceOfValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLInstanceOfValue_1:
					// emit syntax tree node associated with production
					// XMLInstanceOfValue: XMLValue

					s += m_XMLValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLInstanceOfValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLInstanceOfValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLInstanceOfValue_1:
					// emit syntax tree node associated with production
					// XMLInstanceOfValue: XMLValue

					s += m_XMLValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLInstanceOfValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLInstanceOfValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLInstanceOfValue.production_kind kind = (XMLInstanceOfValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLInstanceOfValue.production_kind.g_XMLInstanceOfValue_1:
					// traverse syntax tree node associated with production
					// XMLInstanceOfValue: XMLValue

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
		// initialize object associated with syntax rule XMLInstanceOfValue
		//

		public void _init ()
		{
			m_XMLValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLInstanceOfValue

		// counter of all nodes associated with syntax rule XMLInstanceOfValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLInstanceOfValue
		[DataMember (Name = "m_XMLValue")] public XMLValue m_XMLValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLInstanceOfValue

		// delegate function (callback) prototype associated with syntax rule XMLInstanceOfValue
		public delegate bool XMLInstanceOfValue_Callback (SyntaxTreeCallbackReason reason, XMLInstanceOfValue.production_kind kind, XMLInstanceOfValue p_XMLInstanceOfValue);

		// event associated with syntax rule XMLInstanceOfValue
		public event XMLInstanceOfValue_Callback XMLInstanceOfValue_Event;

		// event trigger associated with syntax rule XMLInstanceOfValue
		public bool Raise_XMLInstanceOfValue_Event (SyntaxTreeCallbackReason reason, XMLInstanceOfValue.production_kind kind, XMLInstanceOfValue p_XMLInstanceOfValue)
		{
			bool? status = XMLInstanceOfValue_Event?.Invoke (reason, kind, p_XMLInstanceOfValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLInstanceOfValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLInstanceOfValue
		//

		public void Traverse (XMLInstanceOfValue p_XMLInstanceOfValue)
		{
			if (p_XMLInstanceOfValue.isLocked())
				return;
			p_XMLInstanceOfValue.dolock();
			XMLInstanceOfValue.production_kind kind = (XMLInstanceOfValue.production_kind) p_XMLInstanceOfValue.kind;
			p_XMLInstanceOfValue.turn_reset ();
			if (Raise_XMLInstanceOfValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLInstanceOfValue))
			switch (kind)
			{
				case XMLInstanceOfValue.production_kind.g_XMLInstanceOfValue_1:
					// traverse syntax tree node associated with production
					// XMLInstanceOfValue: XMLValue

					if (Raise_XMLInstanceOfValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLInstanceOfValue))
						Traverse (p_XMLInstanceOfValue.m_XMLValue);
					p_XMLInstanceOfValue.turn_inc ();
					Raise_XMLInstanceOfValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLInstanceOfValue);
				break;
			}
			Raise_XMLInstanceOfValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLInstanceOfValue);
			p_XMLInstanceOfValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLInstanceOfValue
		//

		public void TraverseCommon (XMLInstanceOfValue p_XMLInstanceOfValue)
		{
			XMLInstanceOfValue.production_kind kind = (XMLInstanceOfValue.production_kind) p_XMLInstanceOfValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLInstanceOfValue))
			switch (kind)
			{
				case XMLInstanceOfValue.production_kind.g_XMLInstanceOfValue_1:
					// traverse syntax tree node associated with production
					// XMLInstanceOfValue: XMLValue

						TraverseCommon (p_XMLInstanceOfValue.m_XMLValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLInstanceOfValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLInstanceOfValue

		//
		// create syntax tree node associated with production
		// XMLInstanceOfValue: XMLValue

		//

		public XMLInstanceOfValue XMLInstanceOfValue_1 (XMLValue p_XMLValue)
		{
			XMLInstanceOfValue p_XMLInstanceOfValue_ref = new XMLInstanceOfValue(p_XMLValue);
			p_XMLValue.parent = p_XMLInstanceOfValue_ref;
			Raise_XMLInstanceOfValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLInstanceOfValue.production_kind.g_XMLInstanceOfValue_1, p_XMLInstanceOfValue_ref);
			return p_XMLInstanceOfValue_ref;
		}
		#endregion
	};
}
