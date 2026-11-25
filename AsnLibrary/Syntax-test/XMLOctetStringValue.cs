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
	// class associated with syntax rule XMLOctetStringValue
	//

	[DataContract]
	public class	XMLOctetStringValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLOctetStringValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLOctetStringValue
		{
			g_XMLOctetStringValue_1 = 1,	// XMLTypedValue

			g_XMLOctetStringValue_2 = 2,	// xmlhstring

		};
		#endregion
		#region production markers associated with the syntax rule XMLOctetStringValue

		// markers associated with production: XMLOctetStringValue -> XMLTypedValue

		public enum production_marker_1 : ushort
		{
			m_XMLTypedValue,
			final
		};

		// markers associated with production: XMLOctetStringValue -> xmlhstring

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLOctetStringValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLOctetStringValue

		//
		// Constructor associated with the following production(s)
		// XMLOctetStringValue -> XMLTypedValue

		//

		public XMLOctetStringValue (XMLTypedValue p_XMLTypedValue) : base ((uint) ProductionID._XMLOctetStringValue_ID, (uint) production_kind.g_XMLOctetStringValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLTypedValue = p_XMLTypedValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLOctetStringValue -> xmlhstring

		//

		public XMLOctetStringValue (SyntaxTreeToken p_token) : base ((uint) ProductionID._XMLOctetStringValue_ID, (uint) production_kind.g_XMLOctetStringValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_xmlhstring = p_token;
		}

		public XMLOctetStringValue () { }

		// Copy constructor

		public XMLOctetStringValue (XMLOctetStringValue p_XMLOctetStringValue) : base (p_XMLOctetStringValue.id, p_XMLOctetStringValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLOctetStringValue.appInfo;
			switch ((production_kind) p_XMLOctetStringValue.kind)
			{
				case production_kind.g_XMLOctetStringValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLTypedValue = (p_XMLOctetStringValue.m_XMLTypedValue != null) ? new XMLTypedValue (p_XMLOctetStringValue.m_XMLTypedValue) : null) != null) m_XMLTypedValue.parent = this;
					break;
				case production_kind.g_XMLOctetStringValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_xmlhstring = (p_XMLOctetStringValue.m_xmlhstring != null) ? new SyntaxTreeToken (p_XMLOctetStringValue.m_xmlhstring) : null) != null) m_xmlhstring.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLOctetStringValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLOctetStringValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLTypedValue?.Dispose ();
			m_xmlhstring?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLOctetStringValue

		// Content changing function(s) associated with production(s) of syntax rule XMLOctetStringValue

		//
		// Content changing function associated with following production(s)
		// XMLOctetStringValue -> XMLTypedValue

		//

		public void change(XMLTypedValue p_XMLTypedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLOctetStringValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLTypedValue = p_XMLTypedValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLOctetStringValue -> xmlhstring

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLOctetStringValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_xmlhstring = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLOctetStringValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLTypedValue != null) && m_XMLTypedValue.checkInclusion (element) ||
				(m_xmlhstring != null) && m_xmlhstring.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLOctetStringValue

		//
		// emit production tree node associated with any production of syntax rule XMLOctetStringValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLOctetStringValue_1:
					// emit syntax tree node associated with production
					// XMLOctetStringValue: XMLTypedValue

					s += m_XMLTypedValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLOctetStringValue_2:
					// emit syntax tree node associated with production
					// XMLOctetStringValue: xmlhstring

					s += m_xmlhstring.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLOctetStringValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLOctetStringValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLOctetStringValue_1:
					// emit syntax tree node associated with production
					// XMLOctetStringValue: XMLTypedValue

					s += m_XMLTypedValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLOctetStringValue_2:
					// emit syntax tree node associated with production
					// XMLOctetStringValue: xmlhstring

					s += "xmlhstring";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLOctetStringValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLOctetStringValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLOctetStringValue.production_kind kind = (XMLOctetStringValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLOctetStringValue.production_kind.g_XMLOctetStringValue_1:
					// traverse syntax tree node associated with production
					// XMLOctetStringValue: XMLTypedValue

						m_XMLTypedValue.Visit (visitor, appData);
				break;
				case XMLOctetStringValue.production_kind.g_XMLOctetStringValue_2:
					// traverse syntax tree node associated with production
					// XMLOctetStringValue: xmlhstring

						m_xmlhstring.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_XMLTypedValue?.reparent (this);
			m_xmlhstring?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLOctetStringValue
		//

		public void _init ()
		{
			m_XMLTypedValue = null;
			m_xmlhstring = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLOctetStringValue

		// counter of all nodes associated with syntax rule XMLOctetStringValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLOctetStringValue
		[DataMember (Name = "m_XMLTypedValue")] public XMLTypedValue m_XMLTypedValue { get; private set; }
		[DataMember (Name = "m_xmlhstring")] public SyntaxTreeToken m_xmlhstring { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLOctetStringValue

		// delegate function (callback) prototype associated with syntax rule XMLOctetStringValue
		public delegate bool XMLOctetStringValue_Callback (SyntaxTreeCallbackReason reason, XMLOctetStringValue.production_kind kind, XMLOctetStringValue p_XMLOctetStringValue);

		// event associated with syntax rule XMLOctetStringValue
		public event XMLOctetStringValue_Callback XMLOctetStringValue_Event;

		// event trigger associated with syntax rule XMLOctetStringValue
		public bool Raise_XMLOctetStringValue_Event (SyntaxTreeCallbackReason reason, XMLOctetStringValue.production_kind kind, XMLOctetStringValue p_XMLOctetStringValue)
		{
			bool? status = XMLOctetStringValue_Event?.Invoke (reason, kind, p_XMLOctetStringValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLOctetStringValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLOctetStringValue
		//

		public void Traverse (XMLOctetStringValue p_XMLOctetStringValue)
		{
			if (p_XMLOctetStringValue.isLocked())
				return;
			p_XMLOctetStringValue.dolock();
			XMLOctetStringValue.production_kind kind = (XMLOctetStringValue.production_kind) p_XMLOctetStringValue.kind;
			p_XMLOctetStringValue.turn_reset ();
			if (Raise_XMLOctetStringValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLOctetStringValue))
			switch (kind)
			{
				case XMLOctetStringValue.production_kind.g_XMLOctetStringValue_1:
					// traverse syntax tree node associated with production
					// XMLOctetStringValue: XMLTypedValue

					if (Raise_XMLOctetStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLOctetStringValue))
						Traverse (p_XMLOctetStringValue.m_XMLTypedValue);
					p_XMLOctetStringValue.turn_inc ();
					Raise_XMLOctetStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLOctetStringValue);
				break;
				case XMLOctetStringValue.production_kind.g_XMLOctetStringValue_2:
					// traverse syntax tree node associated with production
					// XMLOctetStringValue: xmlhstring

				break;
			}
			Raise_XMLOctetStringValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLOctetStringValue);
			p_XMLOctetStringValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLOctetStringValue
		//

		public void TraverseCommon (XMLOctetStringValue p_XMLOctetStringValue)
		{
			XMLOctetStringValue.production_kind kind = (XMLOctetStringValue.production_kind) p_XMLOctetStringValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLOctetStringValue))
			switch (kind)
			{
				case XMLOctetStringValue.production_kind.g_XMLOctetStringValue_1:
					// traverse syntax tree node associated with production
					// XMLOctetStringValue: XMLTypedValue

						TraverseCommon (p_XMLOctetStringValue.m_XMLTypedValue);
				break;
				case XMLOctetStringValue.production_kind.g_XMLOctetStringValue_2:
					// traverse syntax tree node associated with production
					// XMLOctetStringValue: xmlhstring

						TraverseCommon (p_XMLOctetStringValue.m_xmlhstring);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLOctetStringValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLOctetStringValue

		//
		// create syntax tree node associated with production
		// XMLOctetStringValue: XMLTypedValue

		//

		public XMLOctetStringValue XMLOctetStringValue_1 (XMLTypedValue p_XMLTypedValue)
		{
			XMLOctetStringValue p_XMLOctetStringValue_ref = new XMLOctetStringValue(p_XMLTypedValue);
			p_XMLTypedValue.parent = p_XMLOctetStringValue_ref;
			Raise_XMLOctetStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLOctetStringValue.production_kind.g_XMLOctetStringValue_1, p_XMLOctetStringValue_ref);
			return p_XMLOctetStringValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLOctetStringValue: xmlhstring

		//

		public XMLOctetStringValue XMLOctetStringValue_2 (SyntaxTreeToken p_token)
		{
			XMLOctetStringValue p_XMLOctetStringValue_ref = new XMLOctetStringValue(p_token);
			p_token.parent = p_XMLOctetStringValue_ref;
			Raise_XMLOctetStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLOctetStringValue.production_kind.g_XMLOctetStringValue_2, p_XMLOctetStringValue_ref);
			return p_XMLOctetStringValue_ref;
		}
		#endregion
	};
}
