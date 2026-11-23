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
	// class associated with syntax rule XMLValueAssignment
	//

	[DataContract]
	public class	XMLValueAssignment : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLValueAssignment
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLValueAssignment
		{
			g_XMLValueAssignment_1 = 1,	// valuereference-token "::=" XMLTypedValue

		};
		#endregion
		#region production markers associated with the syntax rule XMLValueAssignment

		// markers associated with production: XMLValueAssignment -> valuereference-token "::=" XMLTypedValue

		public enum production_marker_1 : ushort
		{
			m_valuereference_token,
			m_XMLTypedValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLValueAssignment

		// Constructor declaration(s) associated with production(s) of syntax rule XMLValueAssignment

		//
		// Constructor associated with the following production(s)
		// XMLValueAssignment -> valuereference-token "::=" XMLTypedValue

		//

		public XMLValueAssignment (valuereference_token p_valuereference_token, SyntaxTreeToken p_token, XMLTypedValue p_XMLTypedValue) : base ((uint) ProductionID._XMLValueAssignment_ID, (uint) production_kind.g_XMLValueAssignment_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_valuereference_token = p_valuereference_token;
			children[1] = m_assignment_sign = p_token;
			children[2] = m_XMLTypedValue = p_XMLTypedValue;
		}

		public XMLValueAssignment () { }

		// Copy constructor

		public XMLValueAssignment (XMLValueAssignment p_XMLValueAssignment) : base (p_XMLValueAssignment.id, p_XMLValueAssignment.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLValueAssignment.appInfo;
			switch ((production_kind) p_XMLValueAssignment.kind)
			{
				case production_kind.g_XMLValueAssignment_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_valuereference_token = (p_XMLValueAssignment.m_valuereference_token != null) ? new valuereference_token (p_XMLValueAssignment.m_valuereference_token) : null) != null) m_valuereference_token.parent = this;
					if ((children [1] = m_assignment_sign = (p_XMLValueAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_XMLValueAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [2] = m_XMLTypedValue = (p_XMLValueAssignment.m_XMLTypedValue != null) ? new XMLTypedValue (p_XMLValueAssignment.m_XMLTypedValue) : null) != null) m_XMLTypedValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLValueAssignment" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLValueAssignment (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_valuereference_token?.Dispose ();
			m_assignment_sign?.Dispose ();
			m_XMLTypedValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLValueAssignment

		// Content changing function(s) associated with production(s) of syntax rule XMLValueAssignment

		//
		// Content changing function associated with following production(s)
		// XMLValueAssignment -> valuereference-token "::=" XMLTypedValue

		//

		public void change(valuereference_token p_valuereference_token, SyntaxTreeToken p_token, XMLTypedValue p_XMLTypedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLValueAssignment_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_valuereference_token = p_valuereference_token;
			children [1] = m_assignment_sign = p_token;
			children [2] = m_XMLTypedValue = p_XMLTypedValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLValueAssignment
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_valuereference_token != null) && m_valuereference_token.checkInclusion (element) ||
				(m_assignment_sign != null) && m_assignment_sign.checkInclusion (element) ||
				(m_XMLTypedValue != null) && m_XMLTypedValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLValueAssignment

		//
		// emit production tree node associated with any production of syntax rule XMLValueAssignment
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLValueAssignment_1:
					// emit syntax tree node associated with production
					// XMLValueAssignment: valuereference-token "::=" XMLTypedValue

					s += m_valuereference_token.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_XMLTypedValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLValueAssignment
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLValueAssignment (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLValueAssignment_1:
					// emit syntax tree node associated with production
					// XMLValueAssignment: valuereference-token "::=" XMLTypedValue

					s += m_valuereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_XMLTypedValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLValueAssignment

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLValueAssignment with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLValueAssignment.production_kind kind = (XMLValueAssignment.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLValueAssignment.production_kind.g_XMLValueAssignment_1:
					// traverse syntax tree node associated with production
					// XMLValueAssignment: valuereference-token "::=" XMLTypedValue

						m_valuereference_token.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_XMLTypedValue.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_valuereference_token?.reparent (this);
			m_assignment_sign?.reparent (this);
			m_XMLTypedValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLValueAssignment
		//

		public void _init ()
		{
			m_valuereference_token = null;
			m_assignment_sign = null;
			m_XMLTypedValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLValueAssignment

		// counter of all nodes associated with syntax rule XMLValueAssignment
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLValueAssignment
		[DataMember (Name = "m_valuereference_token")] public valuereference_token m_valuereference_token { get; private set; }
		[DataMember (Name = "m_assignment_sign")] public SyntaxTreeToken m_assignment_sign { get; private set; }
		[DataMember (Name = "m_XMLTypedValue")] public XMLTypedValue m_XMLTypedValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLValueAssignment

		// delegate function (callback) prototype associated with syntax rule XMLValueAssignment
		public delegate bool XMLValueAssignment_Callback (SyntaxTreeCallbackReason reason, XMLValueAssignment.production_kind kind, XMLValueAssignment p_XMLValueAssignment);

		// event associated with syntax rule XMLValueAssignment
		public event XMLValueAssignment_Callback XMLValueAssignment_Event;

		// event trigger associated with syntax rule XMLValueAssignment
		public bool Raise_XMLValueAssignment_Event (SyntaxTreeCallbackReason reason, XMLValueAssignment.production_kind kind, XMLValueAssignment p_XMLValueAssignment)
		{
			bool? status = XMLValueAssignment_Event?.Invoke (reason, kind, p_XMLValueAssignment);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLValueAssignment
		//
		// traverse syntax tree node associated with any production of syntax rule XMLValueAssignment
		//

		public void Traverse (XMLValueAssignment p_XMLValueAssignment)
		{
			if (p_XMLValueAssignment.isLocked())
				return;
			p_XMLValueAssignment.dolock();
			XMLValueAssignment.production_kind kind = (XMLValueAssignment.production_kind) p_XMLValueAssignment.kind;
			p_XMLValueAssignment.turn_reset ();
			if (Raise_XMLValueAssignment_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLValueAssignment))
			switch (kind)
			{
				case XMLValueAssignment.production_kind.g_XMLValueAssignment_1:
					// traverse syntax tree node associated with production
					// XMLValueAssignment: valuereference-token "::=" XMLTypedValue

					if (Raise_XMLValueAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLValueAssignment))
						Traverse (p_XMLValueAssignment.m_valuereference_token);
					p_XMLValueAssignment.turn_inc ();
					if (Raise_XMLValueAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLValueAssignment))
						Traverse (p_XMLValueAssignment.m_XMLTypedValue);
					p_XMLValueAssignment.turn_inc ();
					Raise_XMLValueAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLValueAssignment);
				break;
			}
			Raise_XMLValueAssignment_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLValueAssignment);
			p_XMLValueAssignment.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLValueAssignment
		//

		public void TraverseCommon (XMLValueAssignment p_XMLValueAssignment)
		{
			XMLValueAssignment.production_kind kind = (XMLValueAssignment.production_kind) p_XMLValueAssignment.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLValueAssignment))
			switch (kind)
			{
				case XMLValueAssignment.production_kind.g_XMLValueAssignment_1:
					// traverse syntax tree node associated with production
					// XMLValueAssignment: valuereference-token "::=" XMLTypedValue

						TraverseCommon (p_XMLValueAssignment.m_valuereference_token);
						TraverseCommon (p_XMLValueAssignment.m_assignment_sign);
						TraverseCommon (p_XMLValueAssignment.m_XMLTypedValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLValueAssignment);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLValueAssignment

		//
		// create syntax tree node associated with production
		// XMLValueAssignment: valuereference-token "::=" XMLTypedValue

		//

		public XMLValueAssignment XMLValueAssignment_1 (valuereference_token p_valuereference_token, SyntaxTreeToken p_token, XMLTypedValue p_XMLTypedValue)
		{
			XMLValueAssignment p_XMLValueAssignment_ref = new XMLValueAssignment(p_valuereference_token, p_token, p_XMLTypedValue);
			p_valuereference_token.parent = p_XMLValueAssignment_ref;
			p_token.parent = p_XMLValueAssignment_ref;
			p_XMLTypedValue.parent = p_XMLValueAssignment_ref;
			Raise_XMLValueAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLValueAssignment.production_kind.g_XMLValueAssignment_1, p_XMLValueAssignment_ref);
			return p_XMLValueAssignment_ref;
		}
		#endregion
	};
}
