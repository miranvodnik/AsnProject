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
	// class associated with syntax rule XMLTimeValue
	//

	[DataContract]
	public class	XMLTimeValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLTimeValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLTimeValue
		{
			g_XMLTimeValue_1 = 1,	// xmltstring

		};
		#endregion
		#region production markers associated with the syntax rule XMLTimeValue

		// markers associated with production: XMLTimeValue -> xmltstring

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLTimeValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLTimeValue

		//
		// Constructor associated with the following production(s)
		// XMLTimeValue -> xmltstring

		//

		public XMLTimeValue (SyntaxTreeToken p_token) : base ((uint) ProductionID._XMLTimeValue_ID, (uint) production_kind.g_XMLTimeValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_xmltstring = p_token;
		}

		public XMLTimeValue () { }

		// Copy constructor

		public XMLTimeValue (XMLTimeValue p_XMLTimeValue) : base (p_XMLTimeValue.id, p_XMLTimeValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLTimeValue.appInfo;
			switch ((production_kind) p_XMLTimeValue.kind)
			{
				case production_kind.g_XMLTimeValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_xmltstring = (p_XMLTimeValue.m_xmltstring != null) ? new SyntaxTreeToken (p_XMLTimeValue.m_xmltstring) : null) != null) m_xmltstring.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLTimeValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLTimeValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_xmltstring?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLTimeValue

		// Content changing function(s) associated with production(s) of syntax rule XMLTimeValue

		//
		// Content changing function associated with following production(s)
		// XMLTimeValue -> xmltstring

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLTimeValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_xmltstring = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLTimeValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_xmltstring != null) && m_xmltstring.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLTimeValue

		//
		// emit production tree node associated with any production of syntax rule XMLTimeValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLTimeValue_1:
					// emit syntax tree node associated with production
					// XMLTimeValue: xmltstring

					s += m_xmltstring.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLTimeValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLTimeValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLTimeValue_1:
					// emit syntax tree node associated with production
					// XMLTimeValue: xmltstring

					s += "xmltstring";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLTimeValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLTimeValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLTimeValue.production_kind kind = (XMLTimeValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLTimeValue.production_kind.g_XMLTimeValue_1:
					// traverse syntax tree node associated with production
					// XMLTimeValue: xmltstring

						m_xmltstring.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_xmltstring?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLTimeValue
		//

		public void _init ()
		{
			m_xmltstring = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLTimeValue

		// counter of all nodes associated with syntax rule XMLTimeValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLTimeValue
		[DataMember (Name = "m_xmltstring")] public SyntaxTreeToken m_xmltstring { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLTimeValue

		// delegate function (callback) prototype associated with syntax rule XMLTimeValue
		public delegate bool XMLTimeValue_Callback (SyntaxTreeCallbackReason reason, XMLTimeValue.production_kind kind, XMLTimeValue p_XMLTimeValue);

		// event associated with syntax rule XMLTimeValue
		public event XMLTimeValue_Callback XMLTimeValue_Event;

		// event trigger associated with syntax rule XMLTimeValue
		public bool Raise_XMLTimeValue_Event (SyntaxTreeCallbackReason reason, XMLTimeValue.production_kind kind, XMLTimeValue p_XMLTimeValue)
		{
			bool? status = XMLTimeValue_Event?.Invoke (reason, kind, p_XMLTimeValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLTimeValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLTimeValue
		//

		public void Traverse (XMLTimeValue p_XMLTimeValue)
		{
			if (p_XMLTimeValue.isLocked())
				return;
			p_XMLTimeValue.dolock();
			XMLTimeValue.production_kind kind = (XMLTimeValue.production_kind) p_XMLTimeValue.kind;
			p_XMLTimeValue.turn_reset ();
			if (Raise_XMLTimeValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLTimeValue))
			switch (kind)
			{
				case XMLTimeValue.production_kind.g_XMLTimeValue_1:
					// traverse syntax tree node associated with production
					// XMLTimeValue: xmltstring

				break;
			}
			Raise_XMLTimeValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLTimeValue);
			p_XMLTimeValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLTimeValue
		//

		public void TraverseCommon (XMLTimeValue p_XMLTimeValue)
		{
			XMLTimeValue.production_kind kind = (XMLTimeValue.production_kind) p_XMLTimeValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLTimeValue))
			switch (kind)
			{
				case XMLTimeValue.production_kind.g_XMLTimeValue_1:
					// traverse syntax tree node associated with production
					// XMLTimeValue: xmltstring

						TraverseCommon (p_XMLTimeValue.m_xmltstring);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLTimeValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLTimeValue

		//
		// create syntax tree node associated with production
		// XMLTimeValue: xmltstring

		//

		public XMLTimeValue XMLTimeValue_1 (SyntaxTreeToken p_token)
		{
			XMLTimeValue p_XMLTimeValue_ref = new XMLTimeValue(p_token);
			p_token.parent = p_XMLTimeValue_ref;
			Raise_XMLTimeValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLTimeValue.production_kind.g_XMLTimeValue_1, p_XMLTimeValue_ref);
			return p_XMLTimeValue_ref;
		}
		#endregion
	};
}
