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
	// class associated with syntax rule XMLRestrictedCharacterStringValue
	//

	[DataContract]
	public class	XMLRestrictedCharacterStringValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLRestrictedCharacterStringValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLRestrictedCharacterStringValue
		{
			g_XMLRestrictedCharacterStringValue_1 = 1,	// xmlcstring

		};
		#endregion
		#region production markers associated with the syntax rule XMLRestrictedCharacterStringValue

		// markers associated with production: XMLRestrictedCharacterStringValue -> xmlcstring

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLRestrictedCharacterStringValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLRestrictedCharacterStringValue

		//
		// Constructor associated with the following production(s)
		// XMLRestrictedCharacterStringValue -> xmlcstring

		//

		public XMLRestrictedCharacterStringValue (SyntaxTreeToken p_token) : base ((uint) ProductionID._XMLRestrictedCharacterStringValue_ID, (uint) production_kind.g_XMLRestrictedCharacterStringValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_xmlcstring = p_token;
		}

		public XMLRestrictedCharacterStringValue () { }

		// Copy constructor

		public XMLRestrictedCharacterStringValue (XMLRestrictedCharacterStringValue p_XMLRestrictedCharacterStringValue) : base (p_XMLRestrictedCharacterStringValue.id, p_XMLRestrictedCharacterStringValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLRestrictedCharacterStringValue.appInfo;
			switch ((production_kind) p_XMLRestrictedCharacterStringValue.kind)
			{
				case production_kind.g_XMLRestrictedCharacterStringValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_xmlcstring = (p_XMLRestrictedCharacterStringValue.m_xmlcstring != null) ? new SyntaxTreeToken (p_XMLRestrictedCharacterStringValue.m_xmlcstring) : null) != null) m_xmlcstring.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLRestrictedCharacterStringValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLRestrictedCharacterStringValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_xmlcstring?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLRestrictedCharacterStringValue

		// Content changing function(s) associated with production(s) of syntax rule XMLRestrictedCharacterStringValue

		//
		// Content changing function associated with following production(s)
		// XMLRestrictedCharacterStringValue -> xmlcstring

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLRestrictedCharacterStringValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_xmlcstring = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLRestrictedCharacterStringValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_xmlcstring != null) && m_xmlcstring.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLRestrictedCharacterStringValue

		//
		// emit production tree node associated with any production of syntax rule XMLRestrictedCharacterStringValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLRestrictedCharacterStringValue_1:
					// emit syntax tree node associated with production
					// XMLRestrictedCharacterStringValue: xmlcstring

					s += m_xmlcstring.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLRestrictedCharacterStringValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLRestrictedCharacterStringValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLRestrictedCharacterStringValue_1:
					// emit syntax tree node associated with production
					// XMLRestrictedCharacterStringValue: xmlcstring

					s += "xmlcstring";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLRestrictedCharacterStringValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLRestrictedCharacterStringValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLRestrictedCharacterStringValue.production_kind kind = (XMLRestrictedCharacterStringValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLRestrictedCharacterStringValue.production_kind.g_XMLRestrictedCharacterStringValue_1:
					// traverse syntax tree node associated with production
					// XMLRestrictedCharacterStringValue: xmlcstring

						m_xmlcstring.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_xmlcstring?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLRestrictedCharacterStringValue
		//

		public void _init ()
		{
			m_xmlcstring = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLRestrictedCharacterStringValue

		// counter of all nodes associated with syntax rule XMLRestrictedCharacterStringValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLRestrictedCharacterStringValue
		[DataMember (Name = "m_xmlcstring")] public SyntaxTreeToken m_xmlcstring { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLRestrictedCharacterStringValue

		// delegate function (callback) prototype associated with syntax rule XMLRestrictedCharacterStringValue
		public delegate bool XMLRestrictedCharacterStringValue_Callback (SyntaxTreeCallbackReason reason, XMLRestrictedCharacterStringValue.production_kind kind, XMLRestrictedCharacterStringValue p_XMLRestrictedCharacterStringValue);

		// event associated with syntax rule XMLRestrictedCharacterStringValue
		public event XMLRestrictedCharacterStringValue_Callback XMLRestrictedCharacterStringValue_Event;

		// event trigger associated with syntax rule XMLRestrictedCharacterStringValue
		public bool Raise_XMLRestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason reason, XMLRestrictedCharacterStringValue.production_kind kind, XMLRestrictedCharacterStringValue p_XMLRestrictedCharacterStringValue)
		{
			bool? status = XMLRestrictedCharacterStringValue_Event?.Invoke (reason, kind, p_XMLRestrictedCharacterStringValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLRestrictedCharacterStringValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLRestrictedCharacterStringValue
		//

		public void Traverse (XMLRestrictedCharacterStringValue p_XMLRestrictedCharacterStringValue)
		{
			if (p_XMLRestrictedCharacterStringValue.isLocked())
				return;
			p_XMLRestrictedCharacterStringValue.dolock();
			XMLRestrictedCharacterStringValue.production_kind kind = (XMLRestrictedCharacterStringValue.production_kind) p_XMLRestrictedCharacterStringValue.kind;
			p_XMLRestrictedCharacterStringValue.turn_reset ();
			if (Raise_XMLRestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLRestrictedCharacterStringValue))
			switch (kind)
			{
				case XMLRestrictedCharacterStringValue.production_kind.g_XMLRestrictedCharacterStringValue_1:
					// traverse syntax tree node associated with production
					// XMLRestrictedCharacterStringValue: xmlcstring

				break;
			}
			Raise_XMLRestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLRestrictedCharacterStringValue);
			p_XMLRestrictedCharacterStringValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLRestrictedCharacterStringValue
		//

		public void TraverseCommon (XMLRestrictedCharacterStringValue p_XMLRestrictedCharacterStringValue)
		{
			XMLRestrictedCharacterStringValue.production_kind kind = (XMLRestrictedCharacterStringValue.production_kind) p_XMLRestrictedCharacterStringValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLRestrictedCharacterStringValue))
			switch (kind)
			{
				case XMLRestrictedCharacterStringValue.production_kind.g_XMLRestrictedCharacterStringValue_1:
					// traverse syntax tree node associated with production
					// XMLRestrictedCharacterStringValue: xmlcstring

						TraverseCommon (p_XMLRestrictedCharacterStringValue.m_xmlcstring);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLRestrictedCharacterStringValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLRestrictedCharacterStringValue

		//
		// create syntax tree node associated with production
		// XMLRestrictedCharacterStringValue: xmlcstring

		//

		public XMLRestrictedCharacterStringValue XMLRestrictedCharacterStringValue_1 (SyntaxTreeToken p_token)
		{
			XMLRestrictedCharacterStringValue p_XMLRestrictedCharacterStringValue_ref = new XMLRestrictedCharacterStringValue(p_token);
			p_token.parent = p_XMLRestrictedCharacterStringValue_ref;
			Raise_XMLRestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLRestrictedCharacterStringValue.production_kind.g_XMLRestrictedCharacterStringValue_1, p_XMLRestrictedCharacterStringValue_ref);
			return p_XMLRestrictedCharacterStringValue_ref;
		}
		#endregion
	};
}
