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
	// class associated with syntax rule XMLNullValue
	//

	[DataContract]
	public class	XMLNullValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLNullValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLNullValue
		{
			g_XMLNullValue_1 = 1,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule XMLNullValue

		// markers associated with production: XMLNullValue -> %empty

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLNullValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLNullValue

		//
		// Constructor associated with the following production(s)
		// XMLNullValue -> %empty

		//

		public XMLNullValue () : base ((uint) ProductionID._XMLNullValue_ID, (uint) production_kind.g_XMLNullValue_1)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public XMLNullValue (XMLNullValue p_XMLNullValue) : base (p_XMLNullValue.id, p_XMLNullValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLNullValue.appInfo;
			switch ((production_kind) p_XMLNullValue.kind)
			{
				case production_kind.g_XMLNullValue_1:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "XMLNullValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLNullValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;


			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLNullValue

		// Content changing function(s) associated with production(s) of syntax rule XMLNullValue

		//
		// Content changing function associated with following production(s)
		// XMLNullValue -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLNullValue_1;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLNullValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLNullValue

		//
		// emit production tree node associated with any production of syntax rule XMLNullValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLNullValue_1:
					// emit syntax tree node associated with production
					// XMLNullValue: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLNullValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLNullValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLNullValue_1:
					// emit syntax tree node associated with production
					// XMLNullValue: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLNullValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLNullValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLNullValue.production_kind kind = (XMLNullValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLNullValue.production_kind.g_XMLNullValue_1:
					// traverse syntax tree node associated with production
					// XMLNullValue: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

		}

		//
		// initialize object associated with syntax rule XMLNullValue
		//

		public void _init ()
		{
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLNullValue

		// counter of all nodes associated with syntax rule XMLNullValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLNullValue
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLNullValue

		// delegate function (callback) prototype associated with syntax rule XMLNullValue
		public delegate bool XMLNullValue_Callback (SyntaxTreeCallbackReason reason, XMLNullValue.production_kind kind, XMLNullValue p_XMLNullValue);

		// event associated with syntax rule XMLNullValue
		public event XMLNullValue_Callback XMLNullValue_Event;

		// event trigger associated with syntax rule XMLNullValue
		public bool Raise_XMLNullValue_Event (SyntaxTreeCallbackReason reason, XMLNullValue.production_kind kind, XMLNullValue p_XMLNullValue)
		{
			bool? status = XMLNullValue_Event?.Invoke (reason, kind, p_XMLNullValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLNullValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLNullValue
		//

		public void Traverse (XMLNullValue p_XMLNullValue)
		{
			if (p_XMLNullValue.isLocked())
				return;
			p_XMLNullValue.dolock();
			XMLNullValue.production_kind kind = (XMLNullValue.production_kind) p_XMLNullValue.kind;
			p_XMLNullValue.turn_reset ();
			if (Raise_XMLNullValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLNullValue))
			switch (kind)
			{
				case XMLNullValue.production_kind.g_XMLNullValue_1:
					// traverse syntax tree node associated with production
					// XMLNullValue: %empty

				break;
			}
			Raise_XMLNullValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLNullValue);
			p_XMLNullValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLNullValue
		//

		public void TraverseCommon (XMLNullValue p_XMLNullValue)
		{
			XMLNullValue.production_kind kind = (XMLNullValue.production_kind) p_XMLNullValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLNullValue))
			switch (kind)
			{
				case XMLNullValue.production_kind.g_XMLNullValue_1:
					// traverse syntax tree node associated with production
					// XMLNullValue: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLNullValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLNullValue

		//
		// create syntax tree node associated with production
		// XMLNullValue: %empty

		//

		public XMLNullValue XMLNullValue_1 ()
		{
			XMLNullValue p_XMLNullValue_ref = new XMLNullValue();
			Raise_XMLNullValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLNullValue.production_kind.g_XMLNullValue_1, p_XMLNullValue_ref);
			return p_XMLNullValue_ref;
		}
		#endregion
	};
}
