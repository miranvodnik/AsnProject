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
	// class associated with syntax rule XMLUnrestrictedCharacterStringValue
	//

	[DataContract]
	public class	XMLUnrestrictedCharacterStringValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLUnrestrictedCharacterStringValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLUnrestrictedCharacterStringValue
		{
			g_XMLUnrestrictedCharacterStringValue_1 = 1,	// XMLSequenceValue

		};
		#endregion
		#region production markers associated with the syntax rule XMLUnrestrictedCharacterStringValue

		// markers associated with production: XMLUnrestrictedCharacterStringValue -> XMLSequenceValue

		public enum production_marker_1 : ushort
		{
			m_XMLSequenceValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLUnrestrictedCharacterStringValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLUnrestrictedCharacterStringValue

		//
		// Constructor associated with the following production(s)
		// XMLUnrestrictedCharacterStringValue -> XMLSequenceValue

		//

		public XMLUnrestrictedCharacterStringValue (XMLSequenceValue p_XMLSequenceValue) : base ((uint) ProductionID._XMLUnrestrictedCharacterStringValue_ID, (uint) production_kind.g_XMLUnrestrictedCharacterStringValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLSequenceValue = p_XMLSequenceValue;
		}

		public XMLUnrestrictedCharacterStringValue () { }

		// Copy constructor

		public XMLUnrestrictedCharacterStringValue (XMLUnrestrictedCharacterStringValue p_XMLUnrestrictedCharacterStringValue) : base (p_XMLUnrestrictedCharacterStringValue.id, p_XMLUnrestrictedCharacterStringValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLUnrestrictedCharacterStringValue.appInfo;
			switch ((production_kind) p_XMLUnrestrictedCharacterStringValue.kind)
			{
				case production_kind.g_XMLUnrestrictedCharacterStringValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLSequenceValue = (p_XMLUnrestrictedCharacterStringValue.m_XMLSequenceValue != null) ? new XMLSequenceValue (p_XMLUnrestrictedCharacterStringValue.m_XMLSequenceValue) : null) != null) m_XMLSequenceValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLUnrestrictedCharacterStringValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLUnrestrictedCharacterStringValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLSequenceValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLUnrestrictedCharacterStringValue

		// Content changing function(s) associated with production(s) of syntax rule XMLUnrestrictedCharacterStringValue

		//
		// Content changing function associated with following production(s)
		// XMLUnrestrictedCharacterStringValue -> XMLSequenceValue

		//

		public void change(XMLSequenceValue p_XMLSequenceValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLUnrestrictedCharacterStringValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLSequenceValue = p_XMLSequenceValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLUnrestrictedCharacterStringValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLSequenceValue != null) && m_XMLSequenceValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLUnrestrictedCharacterStringValue

		//
		// emit production tree node associated with any production of syntax rule XMLUnrestrictedCharacterStringValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLUnrestrictedCharacterStringValue_1:
					// emit syntax tree node associated with production
					// XMLUnrestrictedCharacterStringValue: XMLSequenceValue

					s += m_XMLSequenceValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLUnrestrictedCharacterStringValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLUnrestrictedCharacterStringValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLUnrestrictedCharacterStringValue_1:
					// emit syntax tree node associated with production
					// XMLUnrestrictedCharacterStringValue: XMLSequenceValue

					s += m_XMLSequenceValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLUnrestrictedCharacterStringValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLUnrestrictedCharacterStringValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLUnrestrictedCharacterStringValue.production_kind kind = (XMLUnrestrictedCharacterStringValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLUnrestrictedCharacterStringValue.production_kind.g_XMLUnrestrictedCharacterStringValue_1:
					// traverse syntax tree node associated with production
					// XMLUnrestrictedCharacterStringValue: XMLSequenceValue

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
		// initialize object associated with syntax rule XMLUnrestrictedCharacterStringValue
		//

		public void _init ()
		{
			m_XMLSequenceValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLUnrestrictedCharacterStringValue

		// counter of all nodes associated with syntax rule XMLUnrestrictedCharacterStringValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLUnrestrictedCharacterStringValue
		[DataMember (Name = "m_XMLSequenceValue")] public XMLSequenceValue m_XMLSequenceValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLUnrestrictedCharacterStringValue

		// delegate function (callback) prototype associated with syntax rule XMLUnrestrictedCharacterStringValue
		public delegate bool XMLUnrestrictedCharacterStringValue_Callback (SyntaxTreeCallbackReason reason, XMLUnrestrictedCharacterStringValue.production_kind kind, XMLUnrestrictedCharacterStringValue p_XMLUnrestrictedCharacterStringValue);

		// event associated with syntax rule XMLUnrestrictedCharacterStringValue
		public event XMLUnrestrictedCharacterStringValue_Callback XMLUnrestrictedCharacterStringValue_Event;

		// event trigger associated with syntax rule XMLUnrestrictedCharacterStringValue
		public bool Raise_XMLUnrestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason reason, XMLUnrestrictedCharacterStringValue.production_kind kind, XMLUnrestrictedCharacterStringValue p_XMLUnrestrictedCharacterStringValue)
		{
			bool? status = XMLUnrestrictedCharacterStringValue_Event?.Invoke (reason, kind, p_XMLUnrestrictedCharacterStringValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLUnrestrictedCharacterStringValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLUnrestrictedCharacterStringValue
		//

		public void Traverse (XMLUnrestrictedCharacterStringValue p_XMLUnrestrictedCharacterStringValue)
		{
			if (p_XMLUnrestrictedCharacterStringValue.isLocked())
				return;
			p_XMLUnrestrictedCharacterStringValue.dolock();
			XMLUnrestrictedCharacterStringValue.production_kind kind = (XMLUnrestrictedCharacterStringValue.production_kind) p_XMLUnrestrictedCharacterStringValue.kind;
			p_XMLUnrestrictedCharacterStringValue.turn_reset ();
			if (Raise_XMLUnrestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLUnrestrictedCharacterStringValue))
			switch (kind)
			{
				case XMLUnrestrictedCharacterStringValue.production_kind.g_XMLUnrestrictedCharacterStringValue_1:
					// traverse syntax tree node associated with production
					// XMLUnrestrictedCharacterStringValue: XMLSequenceValue

					if (Raise_XMLUnrestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLUnrestrictedCharacterStringValue))
						Traverse (p_XMLUnrestrictedCharacterStringValue.m_XMLSequenceValue);
					p_XMLUnrestrictedCharacterStringValue.turn_inc ();
					Raise_XMLUnrestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLUnrestrictedCharacterStringValue);
				break;
			}
			Raise_XMLUnrestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLUnrestrictedCharacterStringValue);
			p_XMLUnrestrictedCharacterStringValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLUnrestrictedCharacterStringValue
		//

		public void TraverseCommon (XMLUnrestrictedCharacterStringValue p_XMLUnrestrictedCharacterStringValue)
		{
			XMLUnrestrictedCharacterStringValue.production_kind kind = (XMLUnrestrictedCharacterStringValue.production_kind) p_XMLUnrestrictedCharacterStringValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLUnrestrictedCharacterStringValue))
			switch (kind)
			{
				case XMLUnrestrictedCharacterStringValue.production_kind.g_XMLUnrestrictedCharacterStringValue_1:
					// traverse syntax tree node associated with production
					// XMLUnrestrictedCharacterStringValue: XMLSequenceValue

						TraverseCommon (p_XMLUnrestrictedCharacterStringValue.m_XMLSequenceValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLUnrestrictedCharacterStringValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLUnrestrictedCharacterStringValue

		//
		// create syntax tree node associated with production
		// XMLUnrestrictedCharacterStringValue: XMLSequenceValue

		//

		public XMLUnrestrictedCharacterStringValue XMLUnrestrictedCharacterStringValue_1 (XMLSequenceValue p_XMLSequenceValue)
		{
			XMLUnrestrictedCharacterStringValue p_XMLUnrestrictedCharacterStringValue_ref = new XMLUnrestrictedCharacterStringValue(p_XMLSequenceValue);
			p_XMLSequenceValue.parent = p_XMLUnrestrictedCharacterStringValue_ref;
			Raise_XMLUnrestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLUnrestrictedCharacterStringValue.production_kind.g_XMLUnrestrictedCharacterStringValue_1, p_XMLUnrestrictedCharacterStringValue_ref);
			return p_XMLUnrestrictedCharacterStringValue_ref;
		}
		#endregion
	};
}
