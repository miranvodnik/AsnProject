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
	// class associated with syntax rule XMLExternalValue
	//

	[DataContract]
	public class	XMLExternalValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLExternalValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLExternalValue
		{
			g_XMLExternalValue_1 = 1,	// XMLSequenceValue

		};
		#endregion
		#region production markers associated with the syntax rule XMLExternalValue

		// markers associated with production: XMLExternalValue -> XMLSequenceValue

		public enum production_marker_1 : ushort
		{
			m_XMLSequenceValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLExternalValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLExternalValue

		//
		// Constructor associated with the following production(s)
		// XMLExternalValue -> XMLSequenceValue

		//

		public XMLExternalValue (XMLSequenceValue p_XMLSequenceValue) : base ((uint) ProductionID._XMLExternalValue_ID, (uint) production_kind.g_XMLExternalValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLSequenceValue = p_XMLSequenceValue;
		}

		public XMLExternalValue () { }

		// Copy constructor

		public XMLExternalValue (XMLExternalValue p_XMLExternalValue) : base (p_XMLExternalValue.id, p_XMLExternalValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLExternalValue.appInfo;
			switch ((production_kind) p_XMLExternalValue.kind)
			{
				case production_kind.g_XMLExternalValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLSequenceValue = (p_XMLExternalValue.m_XMLSequenceValue != null) ? new XMLSequenceValue (p_XMLExternalValue.m_XMLSequenceValue) : null) != null) m_XMLSequenceValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLExternalValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLExternalValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLSequenceValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLExternalValue

		// Content changing function(s) associated with production(s) of syntax rule XMLExternalValue

		//
		// Content changing function associated with following production(s)
		// XMLExternalValue -> XMLSequenceValue

		//

		public void change(XMLSequenceValue p_XMLSequenceValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLExternalValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLSequenceValue = p_XMLSequenceValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLExternalValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLSequenceValue != null) && m_XMLSequenceValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLExternalValue

		//
		// emit production tree node associated with any production of syntax rule XMLExternalValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLExternalValue_1:
					// emit syntax tree node associated with production
					// XMLExternalValue: XMLSequenceValue

					s += m_XMLSequenceValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLExternalValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLExternalValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLExternalValue_1:
					// emit syntax tree node associated with production
					// XMLExternalValue: XMLSequenceValue

					s += m_XMLSequenceValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLExternalValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLExternalValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLExternalValue.production_kind kind = (XMLExternalValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLExternalValue.production_kind.g_XMLExternalValue_1:
					// traverse syntax tree node associated with production
					// XMLExternalValue: XMLSequenceValue

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
		// initialize object associated with syntax rule XMLExternalValue
		//

		public void _init ()
		{
			m_XMLSequenceValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLExternalValue

		// counter of all nodes associated with syntax rule XMLExternalValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLExternalValue
		[DataMember (Name = "m_XMLSequenceValue")] public XMLSequenceValue m_XMLSequenceValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLExternalValue

		// delegate function (callback) prototype associated with syntax rule XMLExternalValue
		public delegate bool XMLExternalValue_Callback (SyntaxTreeCallbackReason reason, XMLExternalValue.production_kind kind, XMLExternalValue p_XMLExternalValue);

		// event associated with syntax rule XMLExternalValue
		public event XMLExternalValue_Callback XMLExternalValue_Event;

		// event trigger associated with syntax rule XMLExternalValue
		public bool Raise_XMLExternalValue_Event (SyntaxTreeCallbackReason reason, XMLExternalValue.production_kind kind, XMLExternalValue p_XMLExternalValue)
		{
			bool? status = XMLExternalValue_Event?.Invoke (reason, kind, p_XMLExternalValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLExternalValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLExternalValue
		//

		public void Traverse (XMLExternalValue p_XMLExternalValue)
		{
			if (p_XMLExternalValue.isLocked())
				return;
			p_XMLExternalValue.dolock();
			XMLExternalValue.production_kind kind = (XMLExternalValue.production_kind) p_XMLExternalValue.kind;
			p_XMLExternalValue.turn_reset ();
			if (Raise_XMLExternalValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLExternalValue))
			switch (kind)
			{
				case XMLExternalValue.production_kind.g_XMLExternalValue_1:
					// traverse syntax tree node associated with production
					// XMLExternalValue: XMLSequenceValue

					if (Raise_XMLExternalValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLExternalValue))
						Traverse (p_XMLExternalValue.m_XMLSequenceValue);
					p_XMLExternalValue.turn_inc ();
					Raise_XMLExternalValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLExternalValue);
				break;
			}
			Raise_XMLExternalValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLExternalValue);
			p_XMLExternalValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLExternalValue
		//

		public void TraverseCommon (XMLExternalValue p_XMLExternalValue)
		{
			XMLExternalValue.production_kind kind = (XMLExternalValue.production_kind) p_XMLExternalValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLExternalValue))
			switch (kind)
			{
				case XMLExternalValue.production_kind.g_XMLExternalValue_1:
					// traverse syntax tree node associated with production
					// XMLExternalValue: XMLSequenceValue

						TraverseCommon (p_XMLExternalValue.m_XMLSequenceValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLExternalValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLExternalValue

		//
		// create syntax tree node associated with production
		// XMLExternalValue: XMLSequenceValue

		//

		public XMLExternalValue XMLExternalValue_1 (XMLSequenceValue p_XMLSequenceValue)
		{
			XMLExternalValue p_XMLExternalValue_ref = new XMLExternalValue(p_XMLSequenceValue);
			p_XMLSequenceValue.parent = p_XMLExternalValue_ref;
			Raise_XMLExternalValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLExternalValue.production_kind.g_XMLExternalValue_1, p_XMLExternalValue_ref);
			return p_XMLExternalValue_ref;
		}
		#endregion
	};
}
