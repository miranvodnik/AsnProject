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
	// class associated with syntax rule XMLEmbeddedPDVValue
	//

	[DataContract]
	public class	XMLEmbeddedPDVValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLEmbeddedPDVValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLEmbeddedPDVValue
		{
			g_XMLEmbeddedPDVValue_1 = 1,	// XMLSequenceValue

		};
		#endregion
		#region production markers associated with the syntax rule XMLEmbeddedPDVValue

		// markers associated with production: XMLEmbeddedPDVValue -> XMLSequenceValue

		public enum production_marker_1 : ushort
		{
			m_XMLSequenceValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLEmbeddedPDVValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLEmbeddedPDVValue

		//
		// Constructor associated with the following production(s)
		// XMLEmbeddedPDVValue -> XMLSequenceValue

		//

		public XMLEmbeddedPDVValue (XMLSequenceValue p_XMLSequenceValue) : base ((uint) ProductionID._XMLEmbeddedPDVValue_ID, (uint) production_kind.g_XMLEmbeddedPDVValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLSequenceValue = p_XMLSequenceValue;
		}

		public XMLEmbeddedPDVValue () { }

		// Copy constructor

		public XMLEmbeddedPDVValue (XMLEmbeddedPDVValue p_XMLEmbeddedPDVValue) : base (p_XMLEmbeddedPDVValue.id, p_XMLEmbeddedPDVValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLEmbeddedPDVValue.appInfo;
			switch ((production_kind) p_XMLEmbeddedPDVValue.kind)
			{
				case production_kind.g_XMLEmbeddedPDVValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLSequenceValue = (p_XMLEmbeddedPDVValue.m_XMLSequenceValue != null) ? new XMLSequenceValue (p_XMLEmbeddedPDVValue.m_XMLSequenceValue) : null) != null) m_XMLSequenceValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLEmbeddedPDVValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLEmbeddedPDVValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLSequenceValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLEmbeddedPDVValue

		// Content changing function(s) associated with production(s) of syntax rule XMLEmbeddedPDVValue

		//
		// Content changing function associated with following production(s)
		// XMLEmbeddedPDVValue -> XMLSequenceValue

		//

		public void change(XMLSequenceValue p_XMLSequenceValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLEmbeddedPDVValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLSequenceValue = p_XMLSequenceValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLEmbeddedPDVValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLSequenceValue != null) && m_XMLSequenceValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLEmbeddedPDVValue

		//
		// emit production tree node associated with any production of syntax rule XMLEmbeddedPDVValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLEmbeddedPDVValue_1:
					// emit syntax tree node associated with production
					// XMLEmbeddedPDVValue: XMLSequenceValue

					s += m_XMLSequenceValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLEmbeddedPDVValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLEmbeddedPDVValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLEmbeddedPDVValue_1:
					// emit syntax tree node associated with production
					// XMLEmbeddedPDVValue: XMLSequenceValue

					s += m_XMLSequenceValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLEmbeddedPDVValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLEmbeddedPDVValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLEmbeddedPDVValue.production_kind kind = (XMLEmbeddedPDVValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLEmbeddedPDVValue.production_kind.g_XMLEmbeddedPDVValue_1:
					// traverse syntax tree node associated with production
					// XMLEmbeddedPDVValue: XMLSequenceValue

						m_XMLSequenceValue.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_XMLSequenceValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLEmbeddedPDVValue
		//

		public void _init ()
		{
			m_XMLSequenceValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLEmbeddedPDVValue

		// counter of all nodes associated with syntax rule XMLEmbeddedPDVValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLEmbeddedPDVValue
		[DataMember (Name = "m_XMLSequenceValue")] public XMLSequenceValue m_XMLSequenceValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLEmbeddedPDVValue

		// delegate function (callback) prototype associated with syntax rule XMLEmbeddedPDVValue
		public delegate bool XMLEmbeddedPDVValue_Callback (SyntaxTreeCallbackReason reason, XMLEmbeddedPDVValue.production_kind kind, XMLEmbeddedPDVValue p_XMLEmbeddedPDVValue);

		// event associated with syntax rule XMLEmbeddedPDVValue
		public event XMLEmbeddedPDVValue_Callback XMLEmbeddedPDVValue_Event;

		// event trigger associated with syntax rule XMLEmbeddedPDVValue
		public bool Raise_XMLEmbeddedPDVValue_Event (SyntaxTreeCallbackReason reason, XMLEmbeddedPDVValue.production_kind kind, XMLEmbeddedPDVValue p_XMLEmbeddedPDVValue)
		{
			bool? status = XMLEmbeddedPDVValue_Event?.Invoke (reason, kind, p_XMLEmbeddedPDVValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLEmbeddedPDVValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLEmbeddedPDVValue
		//

		public void Traverse (XMLEmbeddedPDVValue p_XMLEmbeddedPDVValue)
		{
			if (p_XMLEmbeddedPDVValue.isLocked())
				return;
			p_XMLEmbeddedPDVValue.dolock();
			XMLEmbeddedPDVValue.production_kind kind = (XMLEmbeddedPDVValue.production_kind) p_XMLEmbeddedPDVValue.kind;
			p_XMLEmbeddedPDVValue.turn_reset ();
			if (Raise_XMLEmbeddedPDVValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLEmbeddedPDVValue))
			switch (kind)
			{
				case XMLEmbeddedPDVValue.production_kind.g_XMLEmbeddedPDVValue_1:
					// traverse syntax tree node associated with production
					// XMLEmbeddedPDVValue: XMLSequenceValue

					if (Raise_XMLEmbeddedPDVValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLEmbeddedPDVValue))
						Traverse (p_XMLEmbeddedPDVValue.m_XMLSequenceValue);
					p_XMLEmbeddedPDVValue.turn_inc ();
					Raise_XMLEmbeddedPDVValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLEmbeddedPDVValue);
				break;
			}
			Raise_XMLEmbeddedPDVValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLEmbeddedPDVValue);
			p_XMLEmbeddedPDVValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLEmbeddedPDVValue
		//

		public void TraverseCommon (XMLEmbeddedPDVValue p_XMLEmbeddedPDVValue)
		{
			XMLEmbeddedPDVValue.production_kind kind = (XMLEmbeddedPDVValue.production_kind) p_XMLEmbeddedPDVValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLEmbeddedPDVValue))
			switch (kind)
			{
				case XMLEmbeddedPDVValue.production_kind.g_XMLEmbeddedPDVValue_1:
					// traverse syntax tree node associated with production
					// XMLEmbeddedPDVValue: XMLSequenceValue

						TraverseCommon (p_XMLEmbeddedPDVValue.m_XMLSequenceValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLEmbeddedPDVValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLEmbeddedPDVValue

		//
		// create syntax tree node associated with production
		// XMLEmbeddedPDVValue: XMLSequenceValue

		//

		public XMLEmbeddedPDVValue XMLEmbeddedPDVValue_1 (XMLSequenceValue p_XMLSequenceValue)
		{
			XMLEmbeddedPDVValue p_XMLEmbeddedPDVValue_ref = new XMLEmbeddedPDVValue(p_XMLSequenceValue);
			p_XMLSequenceValue.parent = p_XMLEmbeddedPDVValue_ref;
			Raise_XMLEmbeddedPDVValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLEmbeddedPDVValue.production_kind.g_XMLEmbeddedPDVValue_1, p_XMLEmbeddedPDVValue_ref);
			return p_XMLEmbeddedPDVValue_ref;
		}
		#endregion
	};
}
