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
	// class associated with syntax rule XMLRealValue
	//

	[DataContract]
	public class	XMLRealValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLRealValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLRealValue
		{
			g_XMLRealValue_1 = 1,	// XMLNumericRealValue

			g_XMLRealValue_2 = 2,	// XMLSpecialRealValue

		};
		#endregion
		#region production markers associated with the syntax rule XMLRealValue

		// markers associated with production: XMLRealValue -> XMLNumericRealValue

		public enum production_marker_1 : ushort
		{
			m_XMLNumericRealValue,
			final
		};

		// markers associated with production: XMLRealValue -> XMLSpecialRealValue

		public enum production_marker_2 : ushort
		{
			m_XMLSpecialRealValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLRealValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLRealValue

		//
		// Constructor associated with the following production(s)
		// XMLRealValue -> XMLNumericRealValue

		//

		public XMLRealValue (XMLNumericRealValue p_XMLNumericRealValue) : base ((uint) ProductionID._XMLRealValue_ID, (uint) production_kind.g_XMLRealValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLNumericRealValue = p_XMLNumericRealValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLRealValue -> XMLSpecialRealValue

		//

		public XMLRealValue (XMLSpecialRealValue p_XMLSpecialRealValue) : base ((uint) ProductionID._XMLRealValue_ID, (uint) production_kind.g_XMLRealValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLSpecialRealValue = p_XMLSpecialRealValue;
		}

		public XMLRealValue () { }

		// Copy constructor

		public XMLRealValue (XMLRealValue p_XMLRealValue) : base (p_XMLRealValue.id, p_XMLRealValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLRealValue.appInfo;
			switch ((production_kind) p_XMLRealValue.kind)
			{
				case production_kind.g_XMLRealValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLNumericRealValue = (p_XMLRealValue.m_XMLNumericRealValue != null) ? new XMLNumericRealValue (p_XMLRealValue.m_XMLNumericRealValue) : null) != null) m_XMLNumericRealValue.parent = this;
					break;
				case production_kind.g_XMLRealValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLSpecialRealValue = (p_XMLRealValue.m_XMLSpecialRealValue != null) ? new XMLSpecialRealValue (p_XMLRealValue.m_XMLSpecialRealValue) : null) != null) m_XMLSpecialRealValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLRealValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLRealValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLNumericRealValue?.Dispose ();
			m_XMLSpecialRealValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLRealValue

		// Content changing function(s) associated with production(s) of syntax rule XMLRealValue

		//
		// Content changing function associated with following production(s)
		// XMLRealValue -> XMLNumericRealValue

		//

		public void change(XMLNumericRealValue p_XMLNumericRealValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLRealValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLNumericRealValue = p_XMLNumericRealValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLRealValue -> XMLSpecialRealValue

		//

		public void change(XMLSpecialRealValue p_XMLSpecialRealValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLRealValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLSpecialRealValue = p_XMLSpecialRealValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLRealValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLNumericRealValue != null) && m_XMLNumericRealValue.checkInclusion (element) ||
				(m_XMLSpecialRealValue != null) && m_XMLSpecialRealValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLRealValue

		//
		// emit production tree node associated with any production of syntax rule XMLRealValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLRealValue_1:
					// emit syntax tree node associated with production
					// XMLRealValue: XMLNumericRealValue

					s += m_XMLNumericRealValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLRealValue_2:
					// emit syntax tree node associated with production
					// XMLRealValue: XMLSpecialRealValue

					s += m_XMLSpecialRealValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLRealValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLRealValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLRealValue_1:
					// emit syntax tree node associated with production
					// XMLRealValue: XMLNumericRealValue

					s += m_XMLNumericRealValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLRealValue_2:
					// emit syntax tree node associated with production
					// XMLRealValue: XMLSpecialRealValue

					s += m_XMLSpecialRealValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLRealValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLRealValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLRealValue.production_kind kind = (XMLRealValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLRealValue.production_kind.g_XMLRealValue_1:
					// traverse syntax tree node associated with production
					// XMLRealValue: XMLNumericRealValue

						m_XMLNumericRealValue.Visit (visitor, appData);
				break;
				case XMLRealValue.production_kind.g_XMLRealValue_2:
					// traverse syntax tree node associated with production
					// XMLRealValue: XMLSpecialRealValue

						m_XMLSpecialRealValue.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_XMLNumericRealValue?.reparent (this);
			m_XMLSpecialRealValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLRealValue
		//

		public void _init ()
		{
			m_XMLNumericRealValue = null;
			m_XMLSpecialRealValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLRealValue

		// counter of all nodes associated with syntax rule XMLRealValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLRealValue
		[DataMember (Name = "m_XMLNumericRealValue")] public XMLNumericRealValue m_XMLNumericRealValue { get; private set; }
		[DataMember (Name = "m_XMLSpecialRealValue")] public XMLSpecialRealValue m_XMLSpecialRealValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLRealValue

		// delegate function (callback) prototype associated with syntax rule XMLRealValue
		public delegate bool XMLRealValue_Callback (SyntaxTreeCallbackReason reason, XMLRealValue.production_kind kind, XMLRealValue p_XMLRealValue);

		// event associated with syntax rule XMLRealValue
		public event XMLRealValue_Callback XMLRealValue_Event;

		// event trigger associated with syntax rule XMLRealValue
		public bool Raise_XMLRealValue_Event (SyntaxTreeCallbackReason reason, XMLRealValue.production_kind kind, XMLRealValue p_XMLRealValue)
		{
			bool? status = XMLRealValue_Event?.Invoke (reason, kind, p_XMLRealValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLRealValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLRealValue
		//

		public void Traverse (XMLRealValue p_XMLRealValue)
		{
			if (p_XMLRealValue.isLocked())
				return;
			p_XMLRealValue.dolock();
			XMLRealValue.production_kind kind = (XMLRealValue.production_kind) p_XMLRealValue.kind;
			p_XMLRealValue.turn_reset ();
			if (Raise_XMLRealValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLRealValue))
			switch (kind)
			{
				case XMLRealValue.production_kind.g_XMLRealValue_1:
					// traverse syntax tree node associated with production
					// XMLRealValue: XMLNumericRealValue

					if (Raise_XMLRealValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLRealValue))
						Traverse (p_XMLRealValue.m_XMLNumericRealValue);
					p_XMLRealValue.turn_inc ();
					Raise_XMLRealValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLRealValue);
				break;
				case XMLRealValue.production_kind.g_XMLRealValue_2:
					// traverse syntax tree node associated with production
					// XMLRealValue: XMLSpecialRealValue

					if (Raise_XMLRealValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLRealValue))
						Traverse (p_XMLRealValue.m_XMLSpecialRealValue);
					p_XMLRealValue.turn_inc ();
					Raise_XMLRealValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLRealValue);
				break;
			}
			Raise_XMLRealValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLRealValue);
			p_XMLRealValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLRealValue
		//

		public void TraverseCommon (XMLRealValue p_XMLRealValue)
		{
			XMLRealValue.production_kind kind = (XMLRealValue.production_kind) p_XMLRealValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLRealValue))
			switch (kind)
			{
				case XMLRealValue.production_kind.g_XMLRealValue_1:
					// traverse syntax tree node associated with production
					// XMLRealValue: XMLNumericRealValue

						TraverseCommon (p_XMLRealValue.m_XMLNumericRealValue);
				break;
				case XMLRealValue.production_kind.g_XMLRealValue_2:
					// traverse syntax tree node associated with production
					// XMLRealValue: XMLSpecialRealValue

						TraverseCommon (p_XMLRealValue.m_XMLSpecialRealValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLRealValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLRealValue

		//
		// create syntax tree node associated with production
		// XMLRealValue: XMLNumericRealValue

		//

		public XMLRealValue XMLRealValue_1 (XMLNumericRealValue p_XMLNumericRealValue)
		{
			XMLRealValue p_XMLRealValue_ref = new XMLRealValue(p_XMLNumericRealValue);
			p_XMLNumericRealValue.parent = p_XMLRealValue_ref;
			Raise_XMLRealValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLRealValue.production_kind.g_XMLRealValue_1, p_XMLRealValue_ref);
			return p_XMLRealValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLRealValue: XMLSpecialRealValue

		//

		public XMLRealValue XMLRealValue_2 (XMLSpecialRealValue p_XMLSpecialRealValue)
		{
			XMLRealValue p_XMLRealValue_ref = new XMLRealValue(p_XMLSpecialRealValue);
			p_XMLSpecialRealValue.parent = p_XMLRealValue_ref;
			Raise_XMLRealValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLRealValue.production_kind.g_XMLRealValue_2, p_XMLRealValue_ref);
			return p_XMLRealValue_ref;
		}
		#endregion
	};
}
