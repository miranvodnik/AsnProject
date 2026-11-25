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
	// class associated with syntax rule XMLObjectClassFieldValue
	//

	[DataContract]
	public class	XMLObjectClassFieldValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLObjectClassFieldValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLObjectClassFieldValue
		{
			g_XMLObjectClassFieldValue_1 = 1,	// XMLOpenTypeFieldVal

			g_XMLObjectClassFieldValue_2 = 2,	// XMLFixedTypeFieldVal

		};
		#endregion
		#region production markers associated with the syntax rule XMLObjectClassFieldValue

		// markers associated with production: XMLObjectClassFieldValue -> XMLOpenTypeFieldVal

		public enum production_marker_1 : ushort
		{
			m_XMLOpenTypeFieldVal,
			final
		};

		// markers associated with production: XMLObjectClassFieldValue -> XMLFixedTypeFieldVal

		public enum production_marker_2 : ushort
		{
			m_XMLFixedTypeFieldVal,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLObjectClassFieldValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLObjectClassFieldValue

		//
		// Constructor associated with the following production(s)
		// XMLObjectClassFieldValue -> XMLOpenTypeFieldVal

		//

		public XMLObjectClassFieldValue (XMLOpenTypeFieldVal p_XMLOpenTypeFieldVal) : base ((uint) ProductionID._XMLObjectClassFieldValue_ID, (uint) production_kind.g_XMLObjectClassFieldValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLOpenTypeFieldVal = p_XMLOpenTypeFieldVal;
		}

		//
		// Constructor associated with the following production(s)
		// XMLObjectClassFieldValue -> XMLFixedTypeFieldVal

		//

		public XMLObjectClassFieldValue (XMLFixedTypeFieldVal p_XMLFixedTypeFieldVal) : base ((uint) ProductionID._XMLObjectClassFieldValue_ID, (uint) production_kind.g_XMLObjectClassFieldValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLFixedTypeFieldVal = p_XMLFixedTypeFieldVal;
		}

		public XMLObjectClassFieldValue () { }

		// Copy constructor

		public XMLObjectClassFieldValue (XMLObjectClassFieldValue p_XMLObjectClassFieldValue) : base (p_XMLObjectClassFieldValue.id, p_XMLObjectClassFieldValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLObjectClassFieldValue.appInfo;
			switch ((production_kind) p_XMLObjectClassFieldValue.kind)
			{
				case production_kind.g_XMLObjectClassFieldValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLOpenTypeFieldVal = (p_XMLObjectClassFieldValue.m_XMLOpenTypeFieldVal != null) ? new XMLOpenTypeFieldVal (p_XMLObjectClassFieldValue.m_XMLOpenTypeFieldVal) : null) != null) m_XMLOpenTypeFieldVal.parent = this;
					break;
				case production_kind.g_XMLObjectClassFieldValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLFixedTypeFieldVal = (p_XMLObjectClassFieldValue.m_XMLFixedTypeFieldVal != null) ? new XMLFixedTypeFieldVal (p_XMLObjectClassFieldValue.m_XMLFixedTypeFieldVal) : null) != null) m_XMLFixedTypeFieldVal.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLObjectClassFieldValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLObjectClassFieldValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLOpenTypeFieldVal?.Dispose ();
			m_XMLFixedTypeFieldVal?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLObjectClassFieldValue

		// Content changing function(s) associated with production(s) of syntax rule XMLObjectClassFieldValue

		//
		// Content changing function associated with following production(s)
		// XMLObjectClassFieldValue -> XMLOpenTypeFieldVal

		//

		public void change(XMLOpenTypeFieldVal p_XMLOpenTypeFieldVal)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLObjectClassFieldValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLOpenTypeFieldVal = p_XMLOpenTypeFieldVal;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLObjectClassFieldValue -> XMLFixedTypeFieldVal

		//

		public void change(XMLFixedTypeFieldVal p_XMLFixedTypeFieldVal)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLObjectClassFieldValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLFixedTypeFieldVal = p_XMLFixedTypeFieldVal;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLObjectClassFieldValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLOpenTypeFieldVal != null) && m_XMLOpenTypeFieldVal.checkInclusion (element) ||
				(m_XMLFixedTypeFieldVal != null) && m_XMLFixedTypeFieldVal.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLObjectClassFieldValue

		//
		// emit production tree node associated with any production of syntax rule XMLObjectClassFieldValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLObjectClassFieldValue_1:
					// emit syntax tree node associated with production
					// XMLObjectClassFieldValue: XMLOpenTypeFieldVal

					s += m_XMLOpenTypeFieldVal.Emit (depth - 1);
				break;
				case production_kind.g_XMLObjectClassFieldValue_2:
					// emit syntax tree node associated with production
					// XMLObjectClassFieldValue: XMLFixedTypeFieldVal

					s += m_XMLFixedTypeFieldVal.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLObjectClassFieldValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLObjectClassFieldValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLObjectClassFieldValue_1:
					// emit syntax tree node associated with production
					// XMLObjectClassFieldValue: XMLOpenTypeFieldVal

					s += m_XMLOpenTypeFieldVal.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLObjectClassFieldValue_2:
					// emit syntax tree node associated with production
					// XMLObjectClassFieldValue: XMLFixedTypeFieldVal

					s += m_XMLFixedTypeFieldVal.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLObjectClassFieldValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLObjectClassFieldValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLObjectClassFieldValue.production_kind kind = (XMLObjectClassFieldValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLObjectClassFieldValue.production_kind.g_XMLObjectClassFieldValue_1:
					// traverse syntax tree node associated with production
					// XMLObjectClassFieldValue: XMLOpenTypeFieldVal

						m_XMLOpenTypeFieldVal.Visit (visitor, appData);
				break;
				case XMLObjectClassFieldValue.production_kind.g_XMLObjectClassFieldValue_2:
					// traverse syntax tree node associated with production
					// XMLObjectClassFieldValue: XMLFixedTypeFieldVal

						m_XMLFixedTypeFieldVal.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_XMLOpenTypeFieldVal?.reparent (this);
			m_XMLFixedTypeFieldVal?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLObjectClassFieldValue
		//

		public void _init ()
		{
			m_XMLOpenTypeFieldVal = null;
			m_XMLFixedTypeFieldVal = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLObjectClassFieldValue

		// counter of all nodes associated with syntax rule XMLObjectClassFieldValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLObjectClassFieldValue
		[DataMember (Name = "m_XMLOpenTypeFieldVal")] public XMLOpenTypeFieldVal m_XMLOpenTypeFieldVal { get; private set; }
		[DataMember (Name = "m_XMLFixedTypeFieldVal")] public XMLFixedTypeFieldVal m_XMLFixedTypeFieldVal { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLObjectClassFieldValue

		// delegate function (callback) prototype associated with syntax rule XMLObjectClassFieldValue
		public delegate bool XMLObjectClassFieldValue_Callback (SyntaxTreeCallbackReason reason, XMLObjectClassFieldValue.production_kind kind, XMLObjectClassFieldValue p_XMLObjectClassFieldValue);

		// event associated with syntax rule XMLObjectClassFieldValue
		public event XMLObjectClassFieldValue_Callback XMLObjectClassFieldValue_Event;

		// event trigger associated with syntax rule XMLObjectClassFieldValue
		public bool Raise_XMLObjectClassFieldValue_Event (SyntaxTreeCallbackReason reason, XMLObjectClassFieldValue.production_kind kind, XMLObjectClassFieldValue p_XMLObjectClassFieldValue)
		{
			bool? status = XMLObjectClassFieldValue_Event?.Invoke (reason, kind, p_XMLObjectClassFieldValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLObjectClassFieldValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLObjectClassFieldValue
		//

		public void Traverse (XMLObjectClassFieldValue p_XMLObjectClassFieldValue)
		{
			if (p_XMLObjectClassFieldValue.isLocked())
				return;
			p_XMLObjectClassFieldValue.dolock();
			XMLObjectClassFieldValue.production_kind kind = (XMLObjectClassFieldValue.production_kind) p_XMLObjectClassFieldValue.kind;
			p_XMLObjectClassFieldValue.turn_reset ();
			if (Raise_XMLObjectClassFieldValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLObjectClassFieldValue))
			switch (kind)
			{
				case XMLObjectClassFieldValue.production_kind.g_XMLObjectClassFieldValue_1:
					// traverse syntax tree node associated with production
					// XMLObjectClassFieldValue: XMLOpenTypeFieldVal

					if (Raise_XMLObjectClassFieldValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLObjectClassFieldValue))
						Traverse (p_XMLObjectClassFieldValue.m_XMLOpenTypeFieldVal);
					p_XMLObjectClassFieldValue.turn_inc ();
					Raise_XMLObjectClassFieldValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLObjectClassFieldValue);
				break;
				case XMLObjectClassFieldValue.production_kind.g_XMLObjectClassFieldValue_2:
					// traverse syntax tree node associated with production
					// XMLObjectClassFieldValue: XMLFixedTypeFieldVal

					if (Raise_XMLObjectClassFieldValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLObjectClassFieldValue))
						Traverse (p_XMLObjectClassFieldValue.m_XMLFixedTypeFieldVal);
					p_XMLObjectClassFieldValue.turn_inc ();
					Raise_XMLObjectClassFieldValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLObjectClassFieldValue);
				break;
			}
			Raise_XMLObjectClassFieldValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLObjectClassFieldValue);
			p_XMLObjectClassFieldValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLObjectClassFieldValue
		//

		public void TraverseCommon (XMLObjectClassFieldValue p_XMLObjectClassFieldValue)
		{
			XMLObjectClassFieldValue.production_kind kind = (XMLObjectClassFieldValue.production_kind) p_XMLObjectClassFieldValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLObjectClassFieldValue))
			switch (kind)
			{
				case XMLObjectClassFieldValue.production_kind.g_XMLObjectClassFieldValue_1:
					// traverse syntax tree node associated with production
					// XMLObjectClassFieldValue: XMLOpenTypeFieldVal

						TraverseCommon (p_XMLObjectClassFieldValue.m_XMLOpenTypeFieldVal);
				break;
				case XMLObjectClassFieldValue.production_kind.g_XMLObjectClassFieldValue_2:
					// traverse syntax tree node associated with production
					// XMLObjectClassFieldValue: XMLFixedTypeFieldVal

						TraverseCommon (p_XMLObjectClassFieldValue.m_XMLFixedTypeFieldVal);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLObjectClassFieldValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLObjectClassFieldValue

		//
		// create syntax tree node associated with production
		// XMLObjectClassFieldValue: XMLOpenTypeFieldVal

		//

		public XMLObjectClassFieldValue XMLObjectClassFieldValue_1 (XMLOpenTypeFieldVal p_XMLOpenTypeFieldVal)
		{
			XMLObjectClassFieldValue p_XMLObjectClassFieldValue_ref = new XMLObjectClassFieldValue(p_XMLOpenTypeFieldVal);
			p_XMLOpenTypeFieldVal.parent = p_XMLObjectClassFieldValue_ref;
			Raise_XMLObjectClassFieldValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLObjectClassFieldValue.production_kind.g_XMLObjectClassFieldValue_1, p_XMLObjectClassFieldValue_ref);
			return p_XMLObjectClassFieldValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLObjectClassFieldValue: XMLFixedTypeFieldVal

		//

		public XMLObjectClassFieldValue XMLObjectClassFieldValue_2 (XMLFixedTypeFieldVal p_XMLFixedTypeFieldVal)
		{
			XMLObjectClassFieldValue p_XMLObjectClassFieldValue_ref = new XMLObjectClassFieldValue(p_XMLFixedTypeFieldVal);
			p_XMLFixedTypeFieldVal.parent = p_XMLObjectClassFieldValue_ref;
			Raise_XMLObjectClassFieldValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLObjectClassFieldValue.production_kind.g_XMLObjectClassFieldValue_2, p_XMLObjectClassFieldValue_ref);
			return p_XMLObjectClassFieldValue_ref;
		}
		#endregion
	};
}
