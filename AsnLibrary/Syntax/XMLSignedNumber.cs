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
	// class associated with syntax rule XMLSignedNumber
	//

	[DataContract]
	public class	XMLSignedNumber : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLSignedNumber
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLSignedNumber
		{
			g_XMLSignedNumber_1 = 1,	// number

			g_XMLSignedNumber_2 = 2,	// "-" number

		};
		#endregion
		#region production markers associated with the syntax rule XMLSignedNumber

		// markers associated with production: XMLSignedNumber -> number

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: XMLSignedNumber -> "-" number

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLSignedNumber

		// Constructor declaration(s) associated with production(s) of syntax rule XMLSignedNumber

		//
		// Constructor associated with the following production(s)
		// XMLSignedNumber -> number

		//

		public XMLSignedNumber (SyntaxTreeToken p_token) : base ((uint) ProductionID._XMLSignedNumber_ID, (uint) production_kind.g_XMLSignedNumber_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_number = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// XMLSignedNumber -> "-" number

		//

		public XMLSignedNumber (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._XMLSignedNumber_ID, (uint) production_kind.g_XMLSignedNumber_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_minus_sign = p_token;
			children[1] = m_number = p_token_1;
		}

		public XMLSignedNumber () { }

		// Copy constructor

		public XMLSignedNumber (XMLSignedNumber p_XMLSignedNumber) : base (p_XMLSignedNumber.id, p_XMLSignedNumber.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLSignedNumber.appInfo;
			switch ((production_kind) p_XMLSignedNumber.kind)
			{
				case production_kind.g_XMLSignedNumber_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_number = (p_XMLSignedNumber.m_number != null) ? new SyntaxTreeToken (p_XMLSignedNumber.m_number) : null) != null) m_number.parent = this;
					break;
				case production_kind.g_XMLSignedNumber_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_minus_sign = (p_XMLSignedNumber.m_minus_sign != null) ? new SyntaxTreeToken (p_XMLSignedNumber.m_minus_sign) : null) != null) m_minus_sign.parent = this;
					if ((children [1] = m_number = (p_XMLSignedNumber.m_number != null) ? new SyntaxTreeToken (p_XMLSignedNumber.m_number) : null) != null) m_number.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLSignedNumber" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLSignedNumber (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_number?.Dispose ();
			m_minus_sign?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLSignedNumber

		// Content changing function(s) associated with production(s) of syntax rule XMLSignedNumber

		//
		// Content changing function associated with following production(s)
		// XMLSignedNumber -> number

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLSignedNumber_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_number = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLSignedNumber -> "-" number

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLSignedNumber_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_minus_sign = p_token;
			children [1] = m_number = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLSignedNumber
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_number != null) && m_number.checkInclusion (element) ||
				(m_minus_sign != null) && m_minus_sign.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLSignedNumber

		//
		// emit production tree node associated with any production of syntax rule XMLSignedNumber
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLSignedNumber_1:
					// emit syntax tree node associated with production
					// XMLSignedNumber: number

					s += m_number.Emit (depth - 1);
				break;
				case production_kind.g_XMLSignedNumber_2:
					// emit syntax tree node associated with production
					// XMLSignedNumber: "-" number

					s += m_minus_sign.Emit (depth - 1);
					s += " ";
					s += m_number.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLSignedNumber
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLSignedNumber (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLSignedNumber_1:
					// emit syntax tree node associated with production
					// XMLSignedNumber: number

					s += "number";
				break;
				case production_kind.g_XMLSignedNumber_2:
					// emit syntax tree node associated with production
					// XMLSignedNumber: "-" number

					s += "minus_sign";
					s += ' ';
					s += "number";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLSignedNumber

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLSignedNumber with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLSignedNumber.production_kind kind = (XMLSignedNumber.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLSignedNumber.production_kind.g_XMLSignedNumber_1:
					// traverse syntax tree node associated with production
					// XMLSignedNumber: number

						m_number.Visit (visitor, appData);
				break;
				case XMLSignedNumber.production_kind.g_XMLSignedNumber_2:
					// traverse syntax tree node associated with production
					// XMLSignedNumber: "-" number

						m_minus_sign.Visit (visitor, appData);
						m_number.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_number?.reparent (this);
			m_minus_sign?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLSignedNumber
		//

		public void _init ()
		{
			m_number = null;
			m_minus_sign = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLSignedNumber

		// counter of all nodes associated with syntax rule XMLSignedNumber
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLSignedNumber
		[DataMember (Name = "m_number")] public SyntaxTreeToken m_number { get; private set; }
		[DataMember (Name = "m_minus_sign")] public SyntaxTreeToken m_minus_sign { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLSignedNumber

		// delegate function (callback) prototype associated with syntax rule XMLSignedNumber
		public delegate bool XMLSignedNumber_Callback (SyntaxTreeCallbackReason reason, XMLSignedNumber.production_kind kind, XMLSignedNumber p_XMLSignedNumber);

		// event associated with syntax rule XMLSignedNumber
		public event XMLSignedNumber_Callback XMLSignedNumber_Event;

		// event trigger associated with syntax rule XMLSignedNumber
		public bool Raise_XMLSignedNumber_Event (SyntaxTreeCallbackReason reason, XMLSignedNumber.production_kind kind, XMLSignedNumber p_XMLSignedNumber)
		{
			bool? status = XMLSignedNumber_Event?.Invoke (reason, kind, p_XMLSignedNumber);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLSignedNumber
		//
		// traverse syntax tree node associated with any production of syntax rule XMLSignedNumber
		//

		public void Traverse (XMLSignedNumber p_XMLSignedNumber)
		{
			if (p_XMLSignedNumber.isLocked())
				return;
			p_XMLSignedNumber.dolock();
			XMLSignedNumber.production_kind kind = (XMLSignedNumber.production_kind) p_XMLSignedNumber.kind;
			p_XMLSignedNumber.turn_reset ();
			if (Raise_XMLSignedNumber_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLSignedNumber))
			switch (kind)
			{
				case XMLSignedNumber.production_kind.g_XMLSignedNumber_1:
					// traverse syntax tree node associated with production
					// XMLSignedNumber: number

				break;
				case XMLSignedNumber.production_kind.g_XMLSignedNumber_2:
					// traverse syntax tree node associated with production
					// XMLSignedNumber: "-" number

				break;
			}
			Raise_XMLSignedNumber_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLSignedNumber);
			p_XMLSignedNumber.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLSignedNumber
		//

		public void TraverseCommon (XMLSignedNumber p_XMLSignedNumber)
		{
			XMLSignedNumber.production_kind kind = (XMLSignedNumber.production_kind) p_XMLSignedNumber.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLSignedNumber))
			switch (kind)
			{
				case XMLSignedNumber.production_kind.g_XMLSignedNumber_1:
					// traverse syntax tree node associated with production
					// XMLSignedNumber: number

						TraverseCommon (p_XMLSignedNumber.m_number);
				break;
				case XMLSignedNumber.production_kind.g_XMLSignedNumber_2:
					// traverse syntax tree node associated with production
					// XMLSignedNumber: "-" number

						TraverseCommon (p_XMLSignedNumber.m_minus_sign);
						TraverseCommon (p_XMLSignedNumber.m_number);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLSignedNumber);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLSignedNumber

		//
		// create syntax tree node associated with production
		// XMLSignedNumber: number

		//

		public XMLSignedNumber XMLSignedNumber_1 (SyntaxTreeToken p_token)
		{
			XMLSignedNumber p_XMLSignedNumber_ref = new XMLSignedNumber(p_token);
			p_token.parent = p_XMLSignedNumber_ref;
			Raise_XMLSignedNumber_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLSignedNumber.production_kind.g_XMLSignedNumber_1, p_XMLSignedNumber_ref);
			return p_XMLSignedNumber_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLSignedNumber: "-" number

		//

		public XMLSignedNumber XMLSignedNumber_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			XMLSignedNumber p_XMLSignedNumber_ref = new XMLSignedNumber(p_token, p_token_1);
			p_token.parent = p_XMLSignedNumber_ref;
			p_token_1.parent = p_XMLSignedNumber_ref;
			Raise_XMLSignedNumber_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLSignedNumber.production_kind.g_XMLSignedNumber_2, p_XMLSignedNumber_ref);
			return p_XMLSignedNumber_ref;
		}
		#endregion
	};
}
