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
	// class associated with syntax rule XMLValue
	//

	[DataContract]
	public class	XMLValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLValue
		{
			g_XMLValue_1 = 1,	// XMLBuiltinValue

			g_XMLValue_2 = 2,	// XMLObjectClassFieldValue

		};
		#endregion
		#region production markers associated with the syntax rule XMLValue

		// markers associated with production: XMLValue -> XMLBuiltinValue

		public enum production_marker_1 : ushort
		{
			m_XMLBuiltinValue,
			final
		};

		// markers associated with production: XMLValue -> XMLObjectClassFieldValue

		public enum production_marker_2 : ushort
		{
			m_XMLObjectClassFieldValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLValue

		//
		// Constructor associated with the following production(s)
		// XMLValue -> XMLBuiltinValue

		//

		public XMLValue (XMLBuiltinValue p_XMLBuiltinValue) : base ((uint) ProductionID._XMLValue_ID, (uint) production_kind.g_XMLValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLBuiltinValue = p_XMLBuiltinValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLValue -> XMLObjectClassFieldValue

		//

		public XMLValue (XMLObjectClassFieldValue p_XMLObjectClassFieldValue) : base ((uint) ProductionID._XMLValue_ID, (uint) production_kind.g_XMLValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLObjectClassFieldValue = p_XMLObjectClassFieldValue;
		}

		public XMLValue () { }

		// Copy constructor

		public XMLValue (XMLValue p_XMLValue) : base (p_XMLValue.id, p_XMLValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLValue.appInfo;
			switch ((production_kind) p_XMLValue.kind)
			{
				case production_kind.g_XMLValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLBuiltinValue = (p_XMLValue.m_XMLBuiltinValue != null) ? new XMLBuiltinValue (p_XMLValue.m_XMLBuiltinValue) : null) != null) m_XMLBuiltinValue.parent = this;
					break;
				case production_kind.g_XMLValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLObjectClassFieldValue = (p_XMLValue.m_XMLObjectClassFieldValue != null) ? new XMLObjectClassFieldValue (p_XMLValue.m_XMLObjectClassFieldValue) : null) != null) m_XMLObjectClassFieldValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLBuiltinValue?.Dispose ();
			m_XMLObjectClassFieldValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLValue

		// Content changing function(s) associated with production(s) of syntax rule XMLValue

		//
		// Content changing function associated with following production(s)
		// XMLValue -> XMLBuiltinValue

		//

		public void change(XMLBuiltinValue p_XMLBuiltinValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLBuiltinValue = p_XMLBuiltinValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLValue -> XMLObjectClassFieldValue

		//

		public void change(XMLObjectClassFieldValue p_XMLObjectClassFieldValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLObjectClassFieldValue = p_XMLObjectClassFieldValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLBuiltinValue != null) && m_XMLBuiltinValue.checkInclusion (element) ||
				(m_XMLObjectClassFieldValue != null) && m_XMLObjectClassFieldValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLValue

		//
		// emit production tree node associated with any production of syntax rule XMLValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLValue_1:
					// emit syntax tree node associated with production
					// XMLValue: XMLBuiltinValue

					s += m_XMLBuiltinValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLValue_2:
					// emit syntax tree node associated with production
					// XMLValue: XMLObjectClassFieldValue

					s += m_XMLObjectClassFieldValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLValue_1:
					// emit syntax tree node associated with production
					// XMLValue: XMLBuiltinValue

					s += m_XMLBuiltinValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLValue_2:
					// emit syntax tree node associated with production
					// XMLValue: XMLObjectClassFieldValue

					s += m_XMLObjectClassFieldValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLValue.production_kind kind = (XMLValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLValue.production_kind.g_XMLValue_1:
					// traverse syntax tree node associated with production
					// XMLValue: XMLBuiltinValue

						m_XMLBuiltinValue.Visit (visitor, appData);
				break;
				case XMLValue.production_kind.g_XMLValue_2:
					// traverse syntax tree node associated with production
					// XMLValue: XMLObjectClassFieldValue

						m_XMLObjectClassFieldValue.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_XMLBuiltinValue?.reparent (this);
			m_XMLObjectClassFieldValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLValue
		//

		public void _init ()
		{
			m_XMLBuiltinValue = null;
			m_XMLObjectClassFieldValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLValue

		// counter of all nodes associated with syntax rule XMLValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLValue
		[DataMember (Name = "m_XMLBuiltinValue")] public XMLBuiltinValue m_XMLBuiltinValue { get; private set; }
		[DataMember (Name = "m_XMLObjectClassFieldValue")] public XMLObjectClassFieldValue m_XMLObjectClassFieldValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLValue

		// delegate function (callback) prototype associated with syntax rule XMLValue
		public delegate bool XMLValue_Callback (SyntaxTreeCallbackReason reason, XMLValue.production_kind kind, XMLValue p_XMLValue);

		// event associated with syntax rule XMLValue
		public event XMLValue_Callback XMLValue_Event;

		// event trigger associated with syntax rule XMLValue
		public bool Raise_XMLValue_Event (SyntaxTreeCallbackReason reason, XMLValue.production_kind kind, XMLValue p_XMLValue)
		{
			bool? status = XMLValue_Event?.Invoke (reason, kind, p_XMLValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLValue
		//

		public void Traverse (XMLValue p_XMLValue)
		{
			if (p_XMLValue.isLocked())
				return;
			p_XMLValue.dolock();
			XMLValue.production_kind kind = (XMLValue.production_kind) p_XMLValue.kind;
			p_XMLValue.turn_reset ();
			if (Raise_XMLValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLValue))
			switch (kind)
			{
				case XMLValue.production_kind.g_XMLValue_1:
					// traverse syntax tree node associated with production
					// XMLValue: XMLBuiltinValue

					if (Raise_XMLValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLValue))
						Traverse (p_XMLValue.m_XMLBuiltinValue);
					p_XMLValue.turn_inc ();
					Raise_XMLValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLValue);
				break;
				case XMLValue.production_kind.g_XMLValue_2:
					// traverse syntax tree node associated with production
					// XMLValue: XMLObjectClassFieldValue

					if (Raise_XMLValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLValue))
						Traverse (p_XMLValue.m_XMLObjectClassFieldValue);
					p_XMLValue.turn_inc ();
					Raise_XMLValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLValue);
				break;
			}
			Raise_XMLValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLValue);
			p_XMLValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLValue
		//

		public void TraverseCommon (XMLValue p_XMLValue)
		{
			XMLValue.production_kind kind = (XMLValue.production_kind) p_XMLValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLValue))
			switch (kind)
			{
				case XMLValue.production_kind.g_XMLValue_1:
					// traverse syntax tree node associated with production
					// XMLValue: XMLBuiltinValue

						TraverseCommon (p_XMLValue.m_XMLBuiltinValue);
				break;
				case XMLValue.production_kind.g_XMLValue_2:
					// traverse syntax tree node associated with production
					// XMLValue: XMLObjectClassFieldValue

						TraverseCommon (p_XMLValue.m_XMLObjectClassFieldValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLValue

		//
		// create syntax tree node associated with production
		// XMLValue: XMLBuiltinValue

		//

		public XMLValue XMLValue_1 (XMLBuiltinValue p_XMLBuiltinValue)
		{
			XMLValue p_XMLValue_ref = new XMLValue(p_XMLBuiltinValue);
			p_XMLBuiltinValue.parent = p_XMLValue_ref;
			Raise_XMLValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLValue.production_kind.g_XMLValue_1, p_XMLValue_ref);
			return p_XMLValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLValue: XMLObjectClassFieldValue

		//

		public XMLValue XMLValue_2 (XMLObjectClassFieldValue p_XMLObjectClassFieldValue)
		{
			XMLValue p_XMLValue_ref = new XMLValue(p_XMLObjectClassFieldValue);
			p_XMLObjectClassFieldValue.parent = p_XMLValue_ref;
			Raise_XMLValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLValue.production_kind.g_XMLValue_2, p_XMLValue_ref);
			return p_XMLValue_ref;
		}
		#endregion
	};
}
