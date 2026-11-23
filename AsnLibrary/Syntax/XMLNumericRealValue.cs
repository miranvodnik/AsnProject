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
	// class associated with syntax rule XMLNumericRealValue
	//

	[DataContract]
	public class	XMLNumericRealValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLNumericRealValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLNumericRealValue
		{
			g_XMLNumericRealValue_1 = 1,	// realnumber

			g_XMLNumericRealValue_2 = 2,	// "-" realnumber

		};
		#endregion
		#region production markers associated with the syntax rule XMLNumericRealValue

		// markers associated with production: XMLNumericRealValue -> realnumber

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: XMLNumericRealValue -> "-" realnumber

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLNumericRealValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLNumericRealValue

		//
		// Constructor associated with the following production(s)
		// XMLNumericRealValue -> realnumber

		//

		public XMLNumericRealValue (SyntaxTreeToken p_token) : base ((uint) ProductionID._XMLNumericRealValue_ID, (uint) production_kind.g_XMLNumericRealValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_realnumber = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// XMLNumericRealValue -> "-" realnumber

		//

		public XMLNumericRealValue (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._XMLNumericRealValue_ID, (uint) production_kind.g_XMLNumericRealValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_minus_sign = p_token;
			children[1] = m_realnumber = p_token_1;
		}

		public XMLNumericRealValue () { }

		// Copy constructor

		public XMLNumericRealValue (XMLNumericRealValue p_XMLNumericRealValue) : base (p_XMLNumericRealValue.id, p_XMLNumericRealValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLNumericRealValue.appInfo;
			switch ((production_kind) p_XMLNumericRealValue.kind)
			{
				case production_kind.g_XMLNumericRealValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_realnumber = (p_XMLNumericRealValue.m_realnumber != null) ? new SyntaxTreeToken (p_XMLNumericRealValue.m_realnumber) : null) != null) m_realnumber.parent = this;
					break;
				case production_kind.g_XMLNumericRealValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_minus_sign = (p_XMLNumericRealValue.m_minus_sign != null) ? new SyntaxTreeToken (p_XMLNumericRealValue.m_minus_sign) : null) != null) m_minus_sign.parent = this;
					if ((children [1] = m_realnumber = (p_XMLNumericRealValue.m_realnumber != null) ? new SyntaxTreeToken (p_XMLNumericRealValue.m_realnumber) : null) != null) m_realnumber.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLNumericRealValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLNumericRealValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_realnumber?.Dispose ();
			m_minus_sign?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLNumericRealValue

		// Content changing function(s) associated with production(s) of syntax rule XMLNumericRealValue

		//
		// Content changing function associated with following production(s)
		// XMLNumericRealValue -> realnumber

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLNumericRealValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_realnumber = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLNumericRealValue -> "-" realnumber

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLNumericRealValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_minus_sign = p_token;
			children [1] = m_realnumber = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLNumericRealValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_realnumber != null) && m_realnumber.checkInclusion (element) ||
				(m_minus_sign != null) && m_minus_sign.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLNumericRealValue

		//
		// emit production tree node associated with any production of syntax rule XMLNumericRealValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLNumericRealValue_1:
					// emit syntax tree node associated with production
					// XMLNumericRealValue: realnumber

					s += m_realnumber.Emit (depth - 1);
				break;
				case production_kind.g_XMLNumericRealValue_2:
					// emit syntax tree node associated with production
					// XMLNumericRealValue: "-" realnumber

					s += m_minus_sign.Emit (depth - 1);
					s += " ";
					s += m_realnumber.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLNumericRealValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLNumericRealValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLNumericRealValue_1:
					// emit syntax tree node associated with production
					// XMLNumericRealValue: realnumber

					s += "realnumber";
				break;
				case production_kind.g_XMLNumericRealValue_2:
					// emit syntax tree node associated with production
					// XMLNumericRealValue: "-" realnumber

					s += "minus_sign";
					s += ' ';
					s += "realnumber";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLNumericRealValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLNumericRealValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLNumericRealValue.production_kind kind = (XMLNumericRealValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLNumericRealValue.production_kind.g_XMLNumericRealValue_1:
					// traverse syntax tree node associated with production
					// XMLNumericRealValue: realnumber

						m_realnumber.Visit (visitor, appData);
				break;
				case XMLNumericRealValue.production_kind.g_XMLNumericRealValue_2:
					// traverse syntax tree node associated with production
					// XMLNumericRealValue: "-" realnumber

						m_minus_sign.Visit (visitor, appData);
						m_realnumber.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_realnumber?.reparent (this);
			m_minus_sign?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLNumericRealValue
		//

		public void _init ()
		{
			m_realnumber = null;
			m_minus_sign = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLNumericRealValue

		// counter of all nodes associated with syntax rule XMLNumericRealValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLNumericRealValue
		[DataMember (Name = "m_realnumber")] public SyntaxTreeToken m_realnumber { get; private set; }
		[DataMember (Name = "m_minus_sign")] public SyntaxTreeToken m_minus_sign { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLNumericRealValue

		// delegate function (callback) prototype associated with syntax rule XMLNumericRealValue
		public delegate bool XMLNumericRealValue_Callback (SyntaxTreeCallbackReason reason, XMLNumericRealValue.production_kind kind, XMLNumericRealValue p_XMLNumericRealValue);

		// event associated with syntax rule XMLNumericRealValue
		public event XMLNumericRealValue_Callback XMLNumericRealValue_Event;

		// event trigger associated with syntax rule XMLNumericRealValue
		public bool Raise_XMLNumericRealValue_Event (SyntaxTreeCallbackReason reason, XMLNumericRealValue.production_kind kind, XMLNumericRealValue p_XMLNumericRealValue)
		{
			bool? status = XMLNumericRealValue_Event?.Invoke (reason, kind, p_XMLNumericRealValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLNumericRealValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLNumericRealValue
		//

		public void Traverse (XMLNumericRealValue p_XMLNumericRealValue)
		{
			if (p_XMLNumericRealValue.isLocked())
				return;
			p_XMLNumericRealValue.dolock();
			XMLNumericRealValue.production_kind kind = (XMLNumericRealValue.production_kind) p_XMLNumericRealValue.kind;
			p_XMLNumericRealValue.turn_reset ();
			if (Raise_XMLNumericRealValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLNumericRealValue))
			switch (kind)
			{
				case XMLNumericRealValue.production_kind.g_XMLNumericRealValue_1:
					// traverse syntax tree node associated with production
					// XMLNumericRealValue: realnumber

				break;
				case XMLNumericRealValue.production_kind.g_XMLNumericRealValue_2:
					// traverse syntax tree node associated with production
					// XMLNumericRealValue: "-" realnumber

				break;
			}
			Raise_XMLNumericRealValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLNumericRealValue);
			p_XMLNumericRealValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLNumericRealValue
		//

		public void TraverseCommon (XMLNumericRealValue p_XMLNumericRealValue)
		{
			XMLNumericRealValue.production_kind kind = (XMLNumericRealValue.production_kind) p_XMLNumericRealValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLNumericRealValue))
			switch (kind)
			{
				case XMLNumericRealValue.production_kind.g_XMLNumericRealValue_1:
					// traverse syntax tree node associated with production
					// XMLNumericRealValue: realnumber

						TraverseCommon (p_XMLNumericRealValue.m_realnumber);
				break;
				case XMLNumericRealValue.production_kind.g_XMLNumericRealValue_2:
					// traverse syntax tree node associated with production
					// XMLNumericRealValue: "-" realnumber

						TraverseCommon (p_XMLNumericRealValue.m_minus_sign);
						TraverseCommon (p_XMLNumericRealValue.m_realnumber);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLNumericRealValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLNumericRealValue

		//
		// create syntax tree node associated with production
		// XMLNumericRealValue: realnumber

		//

		public XMLNumericRealValue XMLNumericRealValue_1 (SyntaxTreeToken p_token)
		{
			XMLNumericRealValue p_XMLNumericRealValue_ref = new XMLNumericRealValue(p_token);
			p_token.parent = p_XMLNumericRealValue_ref;
			Raise_XMLNumericRealValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLNumericRealValue.production_kind.g_XMLNumericRealValue_1, p_XMLNumericRealValue_ref);
			return p_XMLNumericRealValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLNumericRealValue: "-" realnumber

		//

		public XMLNumericRealValue XMLNumericRealValue_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			XMLNumericRealValue p_XMLNumericRealValue_ref = new XMLNumericRealValue(p_token, p_token_1);
			p_token.parent = p_XMLNumericRealValue_ref;
			p_token_1.parent = p_XMLNumericRealValue_ref;
			Raise_XMLNumericRealValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLNumericRealValue.production_kind.g_XMLNumericRealValue_2, p_XMLNumericRealValue_ref);
			return p_XMLNumericRealValue_ref;
		}
		#endregion
	};
}
