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
	// class associated with syntax rule XMLSpecialRealValue
	//

	[DataContract]
	public class	XMLSpecialRealValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLSpecialRealValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLSpecialRealValue
		{
			g_XMLSpecialRealValue_1 = 1,	// EmptyElementReal

			g_XMLSpecialRealValue_2 = 2,	// TextReal

		};
		#endregion
		#region production markers associated with the syntax rule XMLSpecialRealValue

		// markers associated with production: XMLSpecialRealValue -> EmptyElementReal

		public enum production_marker_1 : ushort
		{
			m_EmptyElementReal,
			final
		};

		// markers associated with production: XMLSpecialRealValue -> TextReal

		public enum production_marker_2 : ushort
		{
			m_TextReal,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLSpecialRealValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLSpecialRealValue

		//
		// Constructor associated with the following production(s)
		// XMLSpecialRealValue -> EmptyElementReal

		//

		public XMLSpecialRealValue (EmptyElementReal p_EmptyElementReal) : base ((uint) ProductionID._XMLSpecialRealValue_ID, (uint) production_kind.g_XMLSpecialRealValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_EmptyElementReal = p_EmptyElementReal;
		}

		//
		// Constructor associated with the following production(s)
		// XMLSpecialRealValue -> TextReal

		//

		public XMLSpecialRealValue (TextReal p_TextReal) : base ((uint) ProductionID._XMLSpecialRealValue_ID, (uint) production_kind.g_XMLSpecialRealValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TextReal = p_TextReal;
		}

		public XMLSpecialRealValue () { }

		// Copy constructor

		public XMLSpecialRealValue (XMLSpecialRealValue p_XMLSpecialRealValue) : base (p_XMLSpecialRealValue.id, p_XMLSpecialRealValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLSpecialRealValue.appInfo;
			switch ((production_kind) p_XMLSpecialRealValue.kind)
			{
				case production_kind.g_XMLSpecialRealValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EmptyElementReal = (p_XMLSpecialRealValue.m_EmptyElementReal != null) ? new EmptyElementReal (p_XMLSpecialRealValue.m_EmptyElementReal) : null) != null) m_EmptyElementReal.parent = this;
					break;
				case production_kind.g_XMLSpecialRealValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TextReal = (p_XMLSpecialRealValue.m_TextReal != null) ? new TextReal (p_XMLSpecialRealValue.m_TextReal) : null) != null) m_TextReal.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLSpecialRealValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLSpecialRealValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_EmptyElementReal?.Dispose ();
			m_TextReal?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLSpecialRealValue

		// Content changing function(s) associated with production(s) of syntax rule XMLSpecialRealValue

		//
		// Content changing function associated with following production(s)
		// XMLSpecialRealValue -> EmptyElementReal

		//

		public void change(EmptyElementReal p_EmptyElementReal)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLSpecialRealValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_EmptyElementReal = p_EmptyElementReal;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLSpecialRealValue -> TextReal

		//

		public void change(TextReal p_TextReal)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLSpecialRealValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TextReal = p_TextReal;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLSpecialRealValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_EmptyElementReal != null) && m_EmptyElementReal.checkInclusion (element) ||
				(m_TextReal != null) && m_TextReal.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLSpecialRealValue

		//
		// emit production tree node associated with any production of syntax rule XMLSpecialRealValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLSpecialRealValue_1:
					// emit syntax tree node associated with production
					// XMLSpecialRealValue: EmptyElementReal

					s += m_EmptyElementReal.Emit (depth - 1);
				break;
				case production_kind.g_XMLSpecialRealValue_2:
					// emit syntax tree node associated with production
					// XMLSpecialRealValue: TextReal

					s += m_TextReal.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLSpecialRealValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLSpecialRealValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLSpecialRealValue_1:
					// emit syntax tree node associated with production
					// XMLSpecialRealValue: EmptyElementReal

					s += m_EmptyElementReal.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLSpecialRealValue_2:
					// emit syntax tree node associated with production
					// XMLSpecialRealValue: TextReal

					s += m_TextReal.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLSpecialRealValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLSpecialRealValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLSpecialRealValue.production_kind kind = (XMLSpecialRealValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLSpecialRealValue.production_kind.g_XMLSpecialRealValue_1:
					// traverse syntax tree node associated with production
					// XMLSpecialRealValue: EmptyElementReal

						m_EmptyElementReal.Visit (visitor, appData);
				break;
				case XMLSpecialRealValue.production_kind.g_XMLSpecialRealValue_2:
					// traverse syntax tree node associated with production
					// XMLSpecialRealValue: TextReal

						m_TextReal.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_EmptyElementReal?.reparent (this);
			m_TextReal?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLSpecialRealValue
		//

		public void _init ()
		{
			m_EmptyElementReal = null;
			m_TextReal = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLSpecialRealValue

		// counter of all nodes associated with syntax rule XMLSpecialRealValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLSpecialRealValue
		[DataMember (Name = "m_EmptyElementReal")] public EmptyElementReal m_EmptyElementReal { get; private set; }
		[DataMember (Name = "m_TextReal")] public TextReal m_TextReal { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLSpecialRealValue

		// delegate function (callback) prototype associated with syntax rule XMLSpecialRealValue
		public delegate bool XMLSpecialRealValue_Callback (SyntaxTreeCallbackReason reason, XMLSpecialRealValue.production_kind kind, XMLSpecialRealValue p_XMLSpecialRealValue);

		// event associated with syntax rule XMLSpecialRealValue
		public event XMLSpecialRealValue_Callback XMLSpecialRealValue_Event;

		// event trigger associated with syntax rule XMLSpecialRealValue
		public bool Raise_XMLSpecialRealValue_Event (SyntaxTreeCallbackReason reason, XMLSpecialRealValue.production_kind kind, XMLSpecialRealValue p_XMLSpecialRealValue)
		{
			bool? status = XMLSpecialRealValue_Event?.Invoke (reason, kind, p_XMLSpecialRealValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLSpecialRealValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLSpecialRealValue
		//

		public void Traverse (XMLSpecialRealValue p_XMLSpecialRealValue)
		{
			if (p_XMLSpecialRealValue.isLocked())
				return;
			p_XMLSpecialRealValue.dolock();
			XMLSpecialRealValue.production_kind kind = (XMLSpecialRealValue.production_kind) p_XMLSpecialRealValue.kind;
			p_XMLSpecialRealValue.turn_reset ();
			if (Raise_XMLSpecialRealValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLSpecialRealValue))
			switch (kind)
			{
				case XMLSpecialRealValue.production_kind.g_XMLSpecialRealValue_1:
					// traverse syntax tree node associated with production
					// XMLSpecialRealValue: EmptyElementReal

					if (Raise_XMLSpecialRealValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLSpecialRealValue))
						Traverse (p_XMLSpecialRealValue.m_EmptyElementReal);
					p_XMLSpecialRealValue.turn_inc ();
					Raise_XMLSpecialRealValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLSpecialRealValue);
				break;
				case XMLSpecialRealValue.production_kind.g_XMLSpecialRealValue_2:
					// traverse syntax tree node associated with production
					// XMLSpecialRealValue: TextReal

					if (Raise_XMLSpecialRealValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLSpecialRealValue))
						Traverse (p_XMLSpecialRealValue.m_TextReal);
					p_XMLSpecialRealValue.turn_inc ();
					Raise_XMLSpecialRealValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLSpecialRealValue);
				break;
			}
			Raise_XMLSpecialRealValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLSpecialRealValue);
			p_XMLSpecialRealValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLSpecialRealValue
		//

		public void TraverseCommon (XMLSpecialRealValue p_XMLSpecialRealValue)
		{
			XMLSpecialRealValue.production_kind kind = (XMLSpecialRealValue.production_kind) p_XMLSpecialRealValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLSpecialRealValue))
			switch (kind)
			{
				case XMLSpecialRealValue.production_kind.g_XMLSpecialRealValue_1:
					// traverse syntax tree node associated with production
					// XMLSpecialRealValue: EmptyElementReal

						TraverseCommon (p_XMLSpecialRealValue.m_EmptyElementReal);
				break;
				case XMLSpecialRealValue.production_kind.g_XMLSpecialRealValue_2:
					// traverse syntax tree node associated with production
					// XMLSpecialRealValue: TextReal

						TraverseCommon (p_XMLSpecialRealValue.m_TextReal);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLSpecialRealValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLSpecialRealValue

		//
		// create syntax tree node associated with production
		// XMLSpecialRealValue: EmptyElementReal

		//

		public XMLSpecialRealValue XMLSpecialRealValue_1 (EmptyElementReal p_EmptyElementReal)
		{
			XMLSpecialRealValue p_XMLSpecialRealValue_ref = new XMLSpecialRealValue(p_EmptyElementReal);
			p_EmptyElementReal.parent = p_XMLSpecialRealValue_ref;
			Raise_XMLSpecialRealValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLSpecialRealValue.production_kind.g_XMLSpecialRealValue_1, p_XMLSpecialRealValue_ref);
			return p_XMLSpecialRealValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLSpecialRealValue: TextReal

		//

		public XMLSpecialRealValue XMLSpecialRealValue_2 (TextReal p_TextReal)
		{
			XMLSpecialRealValue p_XMLSpecialRealValue_ref = new XMLSpecialRealValue(p_TextReal);
			p_TextReal.parent = p_XMLSpecialRealValue_ref;
			Raise_XMLSpecialRealValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLSpecialRealValue.production_kind.g_XMLSpecialRealValue_2, p_XMLSpecialRealValue_ref);
			return p_XMLSpecialRealValue_ref;
		}
		#endregion
	};
}
