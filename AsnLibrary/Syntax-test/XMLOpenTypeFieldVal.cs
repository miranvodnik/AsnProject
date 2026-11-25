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
	// class associated with syntax rule XMLOpenTypeFieldVal
	//

	[DataContract]
	public class	XMLOpenTypeFieldVal : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLOpenTypeFieldVal
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLOpenTypeFieldVal
		{
			g_XMLOpenTypeFieldVal_1 = 1,	// XMLTypedValue

			g_XMLOpenTypeFieldVal_2 = 2,	// xmlhstring

		};
		#endregion
		#region production markers associated with the syntax rule XMLOpenTypeFieldVal

		// markers associated with production: XMLOpenTypeFieldVal -> XMLTypedValue

		public enum production_marker_1 : ushort
		{
			m_XMLTypedValue,
			final
		};

		// markers associated with production: XMLOpenTypeFieldVal -> xmlhstring

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLOpenTypeFieldVal

		// Constructor declaration(s) associated with production(s) of syntax rule XMLOpenTypeFieldVal

		//
		// Constructor associated with the following production(s)
		// XMLOpenTypeFieldVal -> XMLTypedValue

		//

		public XMLOpenTypeFieldVal (XMLTypedValue p_XMLTypedValue) : base ((uint) ProductionID._XMLOpenTypeFieldVal_ID, (uint) production_kind.g_XMLOpenTypeFieldVal_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLTypedValue = p_XMLTypedValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLOpenTypeFieldVal -> xmlhstring

		//

		public XMLOpenTypeFieldVal (SyntaxTreeToken p_token) : base ((uint) ProductionID._XMLOpenTypeFieldVal_ID, (uint) production_kind.g_XMLOpenTypeFieldVal_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_xmlhstring = p_token;
		}

		public XMLOpenTypeFieldVal () { }

		// Copy constructor

		public XMLOpenTypeFieldVal (XMLOpenTypeFieldVal p_XMLOpenTypeFieldVal) : base (p_XMLOpenTypeFieldVal.id, p_XMLOpenTypeFieldVal.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLOpenTypeFieldVal.appInfo;
			switch ((production_kind) p_XMLOpenTypeFieldVal.kind)
			{
				case production_kind.g_XMLOpenTypeFieldVal_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLTypedValue = (p_XMLOpenTypeFieldVal.m_XMLTypedValue != null) ? new XMLTypedValue (p_XMLOpenTypeFieldVal.m_XMLTypedValue) : null) != null) m_XMLTypedValue.parent = this;
					break;
				case production_kind.g_XMLOpenTypeFieldVal_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_xmlhstring = (p_XMLOpenTypeFieldVal.m_xmlhstring != null) ? new SyntaxTreeToken (p_XMLOpenTypeFieldVal.m_xmlhstring) : null) != null) m_xmlhstring.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLOpenTypeFieldVal" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLOpenTypeFieldVal (this); }

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
		#region Content changing and inclusion checking methods associated with the syntax rule XMLOpenTypeFieldVal

		// Content changing function(s) associated with production(s) of syntax rule XMLOpenTypeFieldVal

		//
		// Content changing function associated with following production(s)
		// XMLOpenTypeFieldVal -> XMLTypedValue

		//

		public void change(XMLTypedValue p_XMLTypedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLOpenTypeFieldVal_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLTypedValue = p_XMLTypedValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLOpenTypeFieldVal -> xmlhstring

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLOpenTypeFieldVal_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_xmlhstring = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLOpenTypeFieldVal
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
		#region Syntax tree emit methods associated with the syntax rule XMLOpenTypeFieldVal

		//
		// emit production tree node associated with any production of syntax rule XMLOpenTypeFieldVal
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLOpenTypeFieldVal_1:
					// emit syntax tree node associated with production
					// XMLOpenTypeFieldVal: XMLTypedValue

					s += m_XMLTypedValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLOpenTypeFieldVal_2:
					// emit syntax tree node associated with production
					// XMLOpenTypeFieldVal: xmlhstring

					s += m_xmlhstring.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLOpenTypeFieldVal
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLOpenTypeFieldVal (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLOpenTypeFieldVal_1:
					// emit syntax tree node associated with production
					// XMLOpenTypeFieldVal: XMLTypedValue

					s += m_XMLTypedValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLOpenTypeFieldVal_2:
					// emit syntax tree node associated with production
					// XMLOpenTypeFieldVal: xmlhstring

					s += "xmlhstring";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLOpenTypeFieldVal

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLOpenTypeFieldVal with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLOpenTypeFieldVal.production_kind kind = (XMLOpenTypeFieldVal.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLOpenTypeFieldVal.production_kind.g_XMLOpenTypeFieldVal_1:
					// traverse syntax tree node associated with production
					// XMLOpenTypeFieldVal: XMLTypedValue

						m_XMLTypedValue.Visit (visitor, appData);
				break;
				case XMLOpenTypeFieldVal.production_kind.g_XMLOpenTypeFieldVal_2:
					// traverse syntax tree node associated with production
					// XMLOpenTypeFieldVal: xmlhstring

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
		// initialize object associated with syntax rule XMLOpenTypeFieldVal
		//

		public void _init ()
		{
			m_XMLTypedValue = null;
			m_xmlhstring = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLOpenTypeFieldVal

		// counter of all nodes associated with syntax rule XMLOpenTypeFieldVal
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLOpenTypeFieldVal
		[DataMember (Name = "m_XMLTypedValue")] public XMLTypedValue m_XMLTypedValue { get; private set; }
		[DataMember (Name = "m_xmlhstring")] public SyntaxTreeToken m_xmlhstring { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLOpenTypeFieldVal

		// delegate function (callback) prototype associated with syntax rule XMLOpenTypeFieldVal
		public delegate bool XMLOpenTypeFieldVal_Callback (SyntaxTreeCallbackReason reason, XMLOpenTypeFieldVal.production_kind kind, XMLOpenTypeFieldVal p_XMLOpenTypeFieldVal);

		// event associated with syntax rule XMLOpenTypeFieldVal
		public event XMLOpenTypeFieldVal_Callback XMLOpenTypeFieldVal_Event;

		// event trigger associated with syntax rule XMLOpenTypeFieldVal
		public bool Raise_XMLOpenTypeFieldVal_Event (SyntaxTreeCallbackReason reason, XMLOpenTypeFieldVal.production_kind kind, XMLOpenTypeFieldVal p_XMLOpenTypeFieldVal)
		{
			bool? status = XMLOpenTypeFieldVal_Event?.Invoke (reason, kind, p_XMLOpenTypeFieldVal);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLOpenTypeFieldVal
		//
		// traverse syntax tree node associated with any production of syntax rule XMLOpenTypeFieldVal
		//

		public void Traverse (XMLOpenTypeFieldVal p_XMLOpenTypeFieldVal)
		{
			if (p_XMLOpenTypeFieldVal.isLocked())
				return;
			p_XMLOpenTypeFieldVal.dolock();
			XMLOpenTypeFieldVal.production_kind kind = (XMLOpenTypeFieldVal.production_kind) p_XMLOpenTypeFieldVal.kind;
			p_XMLOpenTypeFieldVal.turn_reset ();
			if (Raise_XMLOpenTypeFieldVal_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLOpenTypeFieldVal))
			switch (kind)
			{
				case XMLOpenTypeFieldVal.production_kind.g_XMLOpenTypeFieldVal_1:
					// traverse syntax tree node associated with production
					// XMLOpenTypeFieldVal: XMLTypedValue

					if (Raise_XMLOpenTypeFieldVal_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLOpenTypeFieldVal))
						Traverse (p_XMLOpenTypeFieldVal.m_XMLTypedValue);
					p_XMLOpenTypeFieldVal.turn_inc ();
					Raise_XMLOpenTypeFieldVal_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLOpenTypeFieldVal);
				break;
				case XMLOpenTypeFieldVal.production_kind.g_XMLOpenTypeFieldVal_2:
					// traverse syntax tree node associated with production
					// XMLOpenTypeFieldVal: xmlhstring

				break;
			}
			Raise_XMLOpenTypeFieldVal_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLOpenTypeFieldVal);
			p_XMLOpenTypeFieldVal.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLOpenTypeFieldVal
		//

		public void TraverseCommon (XMLOpenTypeFieldVal p_XMLOpenTypeFieldVal)
		{
			XMLOpenTypeFieldVal.production_kind kind = (XMLOpenTypeFieldVal.production_kind) p_XMLOpenTypeFieldVal.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLOpenTypeFieldVal))
			switch (kind)
			{
				case XMLOpenTypeFieldVal.production_kind.g_XMLOpenTypeFieldVal_1:
					// traverse syntax tree node associated with production
					// XMLOpenTypeFieldVal: XMLTypedValue

						TraverseCommon (p_XMLOpenTypeFieldVal.m_XMLTypedValue);
				break;
				case XMLOpenTypeFieldVal.production_kind.g_XMLOpenTypeFieldVal_2:
					// traverse syntax tree node associated with production
					// XMLOpenTypeFieldVal: xmlhstring

						TraverseCommon (p_XMLOpenTypeFieldVal.m_xmlhstring);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLOpenTypeFieldVal);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLOpenTypeFieldVal

		//
		// create syntax tree node associated with production
		// XMLOpenTypeFieldVal: XMLTypedValue

		//

		public XMLOpenTypeFieldVal XMLOpenTypeFieldVal_1 (XMLTypedValue p_XMLTypedValue)
		{
			XMLOpenTypeFieldVal p_XMLOpenTypeFieldVal_ref = new XMLOpenTypeFieldVal(p_XMLTypedValue);
			p_XMLTypedValue.parent = p_XMLOpenTypeFieldVal_ref;
			Raise_XMLOpenTypeFieldVal_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLOpenTypeFieldVal.production_kind.g_XMLOpenTypeFieldVal_1, p_XMLOpenTypeFieldVal_ref);
			return p_XMLOpenTypeFieldVal_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLOpenTypeFieldVal: xmlhstring

		//

		public XMLOpenTypeFieldVal XMLOpenTypeFieldVal_2 (SyntaxTreeToken p_token)
		{
			XMLOpenTypeFieldVal p_XMLOpenTypeFieldVal_ref = new XMLOpenTypeFieldVal(p_token);
			p_token.parent = p_XMLOpenTypeFieldVal_ref;
			Raise_XMLOpenTypeFieldVal_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLOpenTypeFieldVal.production_kind.g_XMLOpenTypeFieldVal_2, p_XMLOpenTypeFieldVal_ref);
			return p_XMLOpenTypeFieldVal_ref;
		}
		#endregion
	};
}
