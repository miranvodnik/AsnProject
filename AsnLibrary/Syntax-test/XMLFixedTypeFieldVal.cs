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
	// class associated with syntax rule XMLFixedTypeFieldVal
	//

	[DataContract]
	public class	XMLFixedTypeFieldVal : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLFixedTypeFieldVal
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLFixedTypeFieldVal
		{
			g_XMLFixedTypeFieldVal_1 = 1,	// XMLBuiltinValue

		};
		#endregion
		#region production markers associated with the syntax rule XMLFixedTypeFieldVal

		// markers associated with production: XMLFixedTypeFieldVal -> XMLBuiltinValue

		public enum production_marker_1 : ushort
		{
			m_XMLBuiltinValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLFixedTypeFieldVal

		// Constructor declaration(s) associated with production(s) of syntax rule XMLFixedTypeFieldVal

		//
		// Constructor associated with the following production(s)
		// XMLFixedTypeFieldVal -> XMLBuiltinValue

		//

		public XMLFixedTypeFieldVal (XMLBuiltinValue p_XMLBuiltinValue) : base ((uint) ProductionID._XMLFixedTypeFieldVal_ID, (uint) production_kind.g_XMLFixedTypeFieldVal_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLBuiltinValue = p_XMLBuiltinValue;
		}

		public XMLFixedTypeFieldVal () { }

		// Copy constructor

		public XMLFixedTypeFieldVal (XMLFixedTypeFieldVal p_XMLFixedTypeFieldVal) : base (p_XMLFixedTypeFieldVal.id, p_XMLFixedTypeFieldVal.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLFixedTypeFieldVal.appInfo;
			switch ((production_kind) p_XMLFixedTypeFieldVal.kind)
			{
				case production_kind.g_XMLFixedTypeFieldVal_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLBuiltinValue = (p_XMLFixedTypeFieldVal.m_XMLBuiltinValue != null) ? new XMLBuiltinValue (p_XMLFixedTypeFieldVal.m_XMLBuiltinValue) : null) != null) m_XMLBuiltinValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLFixedTypeFieldVal" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLFixedTypeFieldVal (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLBuiltinValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLFixedTypeFieldVal

		// Content changing function(s) associated with production(s) of syntax rule XMLFixedTypeFieldVal

		//
		// Content changing function associated with following production(s)
		// XMLFixedTypeFieldVal -> XMLBuiltinValue

		//

		public void change(XMLBuiltinValue p_XMLBuiltinValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLFixedTypeFieldVal_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLBuiltinValue = p_XMLBuiltinValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLFixedTypeFieldVal
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLBuiltinValue != null) && m_XMLBuiltinValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLFixedTypeFieldVal

		//
		// emit production tree node associated with any production of syntax rule XMLFixedTypeFieldVal
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLFixedTypeFieldVal_1:
					// emit syntax tree node associated with production
					// XMLFixedTypeFieldVal: XMLBuiltinValue

					s += m_XMLBuiltinValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLFixedTypeFieldVal
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLFixedTypeFieldVal (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLFixedTypeFieldVal_1:
					// emit syntax tree node associated with production
					// XMLFixedTypeFieldVal: XMLBuiltinValue

					s += m_XMLBuiltinValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLFixedTypeFieldVal

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLFixedTypeFieldVal with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLFixedTypeFieldVal.production_kind kind = (XMLFixedTypeFieldVal.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLFixedTypeFieldVal.production_kind.g_XMLFixedTypeFieldVal_1:
					// traverse syntax tree node associated with production
					// XMLFixedTypeFieldVal: XMLBuiltinValue

						m_XMLBuiltinValue.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_XMLBuiltinValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLFixedTypeFieldVal
		//

		public void _init ()
		{
			m_XMLBuiltinValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLFixedTypeFieldVal

		// counter of all nodes associated with syntax rule XMLFixedTypeFieldVal
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLFixedTypeFieldVal
		[DataMember (Name = "m_XMLBuiltinValue")] public XMLBuiltinValue m_XMLBuiltinValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLFixedTypeFieldVal

		// delegate function (callback) prototype associated with syntax rule XMLFixedTypeFieldVal
		public delegate bool XMLFixedTypeFieldVal_Callback (SyntaxTreeCallbackReason reason, XMLFixedTypeFieldVal.production_kind kind, XMLFixedTypeFieldVal p_XMLFixedTypeFieldVal);

		// event associated with syntax rule XMLFixedTypeFieldVal
		public event XMLFixedTypeFieldVal_Callback XMLFixedTypeFieldVal_Event;

		// event trigger associated with syntax rule XMLFixedTypeFieldVal
		public bool Raise_XMLFixedTypeFieldVal_Event (SyntaxTreeCallbackReason reason, XMLFixedTypeFieldVal.production_kind kind, XMLFixedTypeFieldVal p_XMLFixedTypeFieldVal)
		{
			bool? status = XMLFixedTypeFieldVal_Event?.Invoke (reason, kind, p_XMLFixedTypeFieldVal);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLFixedTypeFieldVal
		//
		// traverse syntax tree node associated with any production of syntax rule XMLFixedTypeFieldVal
		//

		public void Traverse (XMLFixedTypeFieldVal p_XMLFixedTypeFieldVal)
		{
			if (p_XMLFixedTypeFieldVal.isLocked())
				return;
			p_XMLFixedTypeFieldVal.dolock();
			XMLFixedTypeFieldVal.production_kind kind = (XMLFixedTypeFieldVal.production_kind) p_XMLFixedTypeFieldVal.kind;
			p_XMLFixedTypeFieldVal.turn_reset ();
			if (Raise_XMLFixedTypeFieldVal_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLFixedTypeFieldVal))
			switch (kind)
			{
				case XMLFixedTypeFieldVal.production_kind.g_XMLFixedTypeFieldVal_1:
					// traverse syntax tree node associated with production
					// XMLFixedTypeFieldVal: XMLBuiltinValue

					if (Raise_XMLFixedTypeFieldVal_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLFixedTypeFieldVal))
						Traverse (p_XMLFixedTypeFieldVal.m_XMLBuiltinValue);
					p_XMLFixedTypeFieldVal.turn_inc ();
					Raise_XMLFixedTypeFieldVal_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLFixedTypeFieldVal);
				break;
			}
			Raise_XMLFixedTypeFieldVal_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLFixedTypeFieldVal);
			p_XMLFixedTypeFieldVal.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLFixedTypeFieldVal
		//

		public void TraverseCommon (XMLFixedTypeFieldVal p_XMLFixedTypeFieldVal)
		{
			XMLFixedTypeFieldVal.production_kind kind = (XMLFixedTypeFieldVal.production_kind) p_XMLFixedTypeFieldVal.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLFixedTypeFieldVal))
			switch (kind)
			{
				case XMLFixedTypeFieldVal.production_kind.g_XMLFixedTypeFieldVal_1:
					// traverse syntax tree node associated with production
					// XMLFixedTypeFieldVal: XMLBuiltinValue

						TraverseCommon (p_XMLFixedTypeFieldVal.m_XMLBuiltinValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLFixedTypeFieldVal);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLFixedTypeFieldVal

		//
		// create syntax tree node associated with production
		// XMLFixedTypeFieldVal: XMLBuiltinValue

		//

		public XMLFixedTypeFieldVal XMLFixedTypeFieldVal_1 (XMLBuiltinValue p_XMLBuiltinValue)
		{
			XMLFixedTypeFieldVal p_XMLFixedTypeFieldVal_ref = new XMLFixedTypeFieldVal(p_XMLBuiltinValue);
			p_XMLBuiltinValue.parent = p_XMLFixedTypeFieldVal_ref;
			Raise_XMLFixedTypeFieldVal_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLFixedTypeFieldVal.production_kind.g_XMLFixedTypeFieldVal_1, p_XMLFixedTypeFieldVal_ref);
			return p_XMLFixedTypeFieldVal_ref;
		}
		#endregion
	};
}
