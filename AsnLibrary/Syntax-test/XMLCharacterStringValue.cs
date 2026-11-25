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
	// class associated with syntax rule XMLCharacterStringValue
	//

	[DataContract]
	public class	XMLCharacterStringValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLCharacterStringValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLCharacterStringValue
		{
			g_XMLCharacterStringValue_1 = 1,	// XMLRestrictedCharacterStringValue

			g_XMLCharacterStringValue_2 = 2,	// XMLUnrestrictedCharacterStringValue

		};
		#endregion
		#region production markers associated with the syntax rule XMLCharacterStringValue

		// markers associated with production: XMLCharacterStringValue -> XMLRestrictedCharacterStringValue

		public enum production_marker_1 : ushort
		{
			m_XMLRestrictedCharacterStringValue,
			final
		};

		// markers associated with production: XMLCharacterStringValue -> XMLUnrestrictedCharacterStringValue

		public enum production_marker_2 : ushort
		{
			m_XMLUnrestrictedCharacterStringValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLCharacterStringValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLCharacterStringValue

		//
		// Constructor associated with the following production(s)
		// XMLCharacterStringValue -> XMLRestrictedCharacterStringValue

		//

		public XMLCharacterStringValue (XMLRestrictedCharacterStringValue p_XMLRestrictedCharacterStringValue) : base ((uint) ProductionID._XMLCharacterStringValue_ID, (uint) production_kind.g_XMLCharacterStringValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLRestrictedCharacterStringValue = p_XMLRestrictedCharacterStringValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLCharacterStringValue -> XMLUnrestrictedCharacterStringValue

		//

		public XMLCharacterStringValue (XMLUnrestrictedCharacterStringValue p_XMLUnrestrictedCharacterStringValue) : base ((uint) ProductionID._XMLCharacterStringValue_ID, (uint) production_kind.g_XMLCharacterStringValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLUnrestrictedCharacterStringValue = p_XMLUnrestrictedCharacterStringValue;
		}

		public XMLCharacterStringValue () { }

		// Copy constructor

		public XMLCharacterStringValue (XMLCharacterStringValue p_XMLCharacterStringValue) : base (p_XMLCharacterStringValue.id, p_XMLCharacterStringValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLCharacterStringValue.appInfo;
			switch ((production_kind) p_XMLCharacterStringValue.kind)
			{
				case production_kind.g_XMLCharacterStringValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLRestrictedCharacterStringValue = (p_XMLCharacterStringValue.m_XMLRestrictedCharacterStringValue != null) ? new XMLRestrictedCharacterStringValue (p_XMLCharacterStringValue.m_XMLRestrictedCharacterStringValue) : null) != null) m_XMLRestrictedCharacterStringValue.parent = this;
					break;
				case production_kind.g_XMLCharacterStringValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLUnrestrictedCharacterStringValue = (p_XMLCharacterStringValue.m_XMLUnrestrictedCharacterStringValue != null) ? new XMLUnrestrictedCharacterStringValue (p_XMLCharacterStringValue.m_XMLUnrestrictedCharacterStringValue) : null) != null) m_XMLUnrestrictedCharacterStringValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLCharacterStringValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLCharacterStringValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLRestrictedCharacterStringValue?.Dispose ();
			m_XMLUnrestrictedCharacterStringValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLCharacterStringValue

		// Content changing function(s) associated with production(s) of syntax rule XMLCharacterStringValue

		//
		// Content changing function associated with following production(s)
		// XMLCharacterStringValue -> XMLRestrictedCharacterStringValue

		//

		public void change(XMLRestrictedCharacterStringValue p_XMLRestrictedCharacterStringValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLCharacterStringValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLRestrictedCharacterStringValue = p_XMLRestrictedCharacterStringValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLCharacterStringValue -> XMLUnrestrictedCharacterStringValue

		//

		public void change(XMLUnrestrictedCharacterStringValue p_XMLUnrestrictedCharacterStringValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLCharacterStringValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLUnrestrictedCharacterStringValue = p_XMLUnrestrictedCharacterStringValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLCharacterStringValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLRestrictedCharacterStringValue != null) && m_XMLRestrictedCharacterStringValue.checkInclusion (element) ||
				(m_XMLUnrestrictedCharacterStringValue != null) && m_XMLUnrestrictedCharacterStringValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLCharacterStringValue

		//
		// emit production tree node associated with any production of syntax rule XMLCharacterStringValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLCharacterStringValue_1:
					// emit syntax tree node associated with production
					// XMLCharacterStringValue: XMLRestrictedCharacterStringValue

					s += m_XMLRestrictedCharacterStringValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLCharacterStringValue_2:
					// emit syntax tree node associated with production
					// XMLCharacterStringValue: XMLUnrestrictedCharacterStringValue

					s += m_XMLUnrestrictedCharacterStringValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLCharacterStringValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLCharacterStringValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLCharacterStringValue_1:
					// emit syntax tree node associated with production
					// XMLCharacterStringValue: XMLRestrictedCharacterStringValue

					s += m_XMLRestrictedCharacterStringValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLCharacterStringValue_2:
					// emit syntax tree node associated with production
					// XMLCharacterStringValue: XMLUnrestrictedCharacterStringValue

					s += m_XMLUnrestrictedCharacterStringValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLCharacterStringValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLCharacterStringValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLCharacterStringValue.production_kind kind = (XMLCharacterStringValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLCharacterStringValue.production_kind.g_XMLCharacterStringValue_1:
					// traverse syntax tree node associated with production
					// XMLCharacterStringValue: XMLRestrictedCharacterStringValue

						m_XMLRestrictedCharacterStringValue.Visit (visitor, appData);
				break;
				case XMLCharacterStringValue.production_kind.g_XMLCharacterStringValue_2:
					// traverse syntax tree node associated with production
					// XMLCharacterStringValue: XMLUnrestrictedCharacterStringValue

						m_XMLUnrestrictedCharacterStringValue.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_XMLRestrictedCharacterStringValue?.reparent (this);
			m_XMLUnrestrictedCharacterStringValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLCharacterStringValue
		//

		public void _init ()
		{
			m_XMLRestrictedCharacterStringValue = null;
			m_XMLUnrestrictedCharacterStringValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLCharacterStringValue

		// counter of all nodes associated with syntax rule XMLCharacterStringValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLCharacterStringValue
		[DataMember (Name = "m_XMLRestrictedCharacterStringValue")] public XMLRestrictedCharacterStringValue m_XMLRestrictedCharacterStringValue { get; private set; }
		[DataMember (Name = "m_XMLUnrestrictedCharacterStringValue")] public XMLUnrestrictedCharacterStringValue m_XMLUnrestrictedCharacterStringValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLCharacterStringValue

		// delegate function (callback) prototype associated with syntax rule XMLCharacterStringValue
		public delegate bool XMLCharacterStringValue_Callback (SyntaxTreeCallbackReason reason, XMLCharacterStringValue.production_kind kind, XMLCharacterStringValue p_XMLCharacterStringValue);

		// event associated with syntax rule XMLCharacterStringValue
		public event XMLCharacterStringValue_Callback XMLCharacterStringValue_Event;

		// event trigger associated with syntax rule XMLCharacterStringValue
		public bool Raise_XMLCharacterStringValue_Event (SyntaxTreeCallbackReason reason, XMLCharacterStringValue.production_kind kind, XMLCharacterStringValue p_XMLCharacterStringValue)
		{
			bool? status = XMLCharacterStringValue_Event?.Invoke (reason, kind, p_XMLCharacterStringValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLCharacterStringValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLCharacterStringValue
		//

		public void Traverse (XMLCharacterStringValue p_XMLCharacterStringValue)
		{
			if (p_XMLCharacterStringValue.isLocked())
				return;
			p_XMLCharacterStringValue.dolock();
			XMLCharacterStringValue.production_kind kind = (XMLCharacterStringValue.production_kind) p_XMLCharacterStringValue.kind;
			p_XMLCharacterStringValue.turn_reset ();
			if (Raise_XMLCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLCharacterStringValue))
			switch (kind)
			{
				case XMLCharacterStringValue.production_kind.g_XMLCharacterStringValue_1:
					// traverse syntax tree node associated with production
					// XMLCharacterStringValue: XMLRestrictedCharacterStringValue

					if (Raise_XMLCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLCharacterStringValue))
						Traverse (p_XMLCharacterStringValue.m_XMLRestrictedCharacterStringValue);
					p_XMLCharacterStringValue.turn_inc ();
					Raise_XMLCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLCharacterStringValue);
				break;
				case XMLCharacterStringValue.production_kind.g_XMLCharacterStringValue_2:
					// traverse syntax tree node associated with production
					// XMLCharacterStringValue: XMLUnrestrictedCharacterStringValue

					if (Raise_XMLCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLCharacterStringValue))
						Traverse (p_XMLCharacterStringValue.m_XMLUnrestrictedCharacterStringValue);
					p_XMLCharacterStringValue.turn_inc ();
					Raise_XMLCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLCharacterStringValue);
				break;
			}
			Raise_XMLCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLCharacterStringValue);
			p_XMLCharacterStringValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLCharacterStringValue
		//

		public void TraverseCommon (XMLCharacterStringValue p_XMLCharacterStringValue)
		{
			XMLCharacterStringValue.production_kind kind = (XMLCharacterStringValue.production_kind) p_XMLCharacterStringValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLCharacterStringValue))
			switch (kind)
			{
				case XMLCharacterStringValue.production_kind.g_XMLCharacterStringValue_1:
					// traverse syntax tree node associated with production
					// XMLCharacterStringValue: XMLRestrictedCharacterStringValue

						TraverseCommon (p_XMLCharacterStringValue.m_XMLRestrictedCharacterStringValue);
				break;
				case XMLCharacterStringValue.production_kind.g_XMLCharacterStringValue_2:
					// traverse syntax tree node associated with production
					// XMLCharacterStringValue: XMLUnrestrictedCharacterStringValue

						TraverseCommon (p_XMLCharacterStringValue.m_XMLUnrestrictedCharacterStringValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLCharacterStringValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLCharacterStringValue

		//
		// create syntax tree node associated with production
		// XMLCharacterStringValue: XMLRestrictedCharacterStringValue

		//

		public XMLCharacterStringValue XMLCharacterStringValue_1 (XMLRestrictedCharacterStringValue p_XMLRestrictedCharacterStringValue)
		{
			XMLCharacterStringValue p_XMLCharacterStringValue_ref = new XMLCharacterStringValue(p_XMLRestrictedCharacterStringValue);
			p_XMLRestrictedCharacterStringValue.parent = p_XMLCharacterStringValue_ref;
			Raise_XMLCharacterStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLCharacterStringValue.production_kind.g_XMLCharacterStringValue_1, p_XMLCharacterStringValue_ref);
			return p_XMLCharacterStringValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLCharacterStringValue: XMLUnrestrictedCharacterStringValue

		//

		public XMLCharacterStringValue XMLCharacterStringValue_2 (XMLUnrestrictedCharacterStringValue p_XMLUnrestrictedCharacterStringValue)
		{
			XMLCharacterStringValue p_XMLCharacterStringValue_ref = new XMLCharacterStringValue(p_XMLUnrestrictedCharacterStringValue);
			p_XMLUnrestrictedCharacterStringValue.parent = p_XMLCharacterStringValue_ref;
			Raise_XMLCharacterStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLCharacterStringValue.production_kind.g_XMLCharacterStringValue_2, p_XMLCharacterStringValue_ref);
			return p_XMLCharacterStringValue_ref;
		}
		#endregion
	};
}
