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
	// class associated with syntax rule XMLEnumeratedValue
	//

	[DataContract]
	public class	XMLEnumeratedValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLEnumeratedValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLEnumeratedValue
		{
			g_XMLEnumeratedValue_1 = 1,	// EmptyElementEnumerated

			g_XMLEnumeratedValue_2 = 2,	// TextEnumerated

		};
		#endregion
		#region production markers associated with the syntax rule XMLEnumeratedValue

		// markers associated with production: XMLEnumeratedValue -> EmptyElementEnumerated

		public enum production_marker_1 : ushort
		{
			m_EmptyElementEnumerated,
			final
		};

		// markers associated with production: XMLEnumeratedValue -> TextEnumerated

		public enum production_marker_2 : ushort
		{
			m_TextEnumerated,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLEnumeratedValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLEnumeratedValue

		//
		// Constructor associated with the following production(s)
		// XMLEnumeratedValue -> EmptyElementEnumerated

		//

		public XMLEnumeratedValue (EmptyElementEnumerated p_EmptyElementEnumerated) : base ((uint) ProductionID._XMLEnumeratedValue_ID, (uint) production_kind.g_XMLEnumeratedValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_EmptyElementEnumerated = p_EmptyElementEnumerated;
		}

		//
		// Constructor associated with the following production(s)
		// XMLEnumeratedValue -> TextEnumerated

		//

		public XMLEnumeratedValue (TextEnumerated p_TextEnumerated) : base ((uint) ProductionID._XMLEnumeratedValue_ID, (uint) production_kind.g_XMLEnumeratedValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TextEnumerated = p_TextEnumerated;
		}

		public XMLEnumeratedValue () { }

		// Copy constructor

		public XMLEnumeratedValue (XMLEnumeratedValue p_XMLEnumeratedValue) : base (p_XMLEnumeratedValue.id, p_XMLEnumeratedValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLEnumeratedValue.appInfo;
			switch ((production_kind) p_XMLEnumeratedValue.kind)
			{
				case production_kind.g_XMLEnumeratedValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EmptyElementEnumerated = (p_XMLEnumeratedValue.m_EmptyElementEnumerated != null) ? new EmptyElementEnumerated (p_XMLEnumeratedValue.m_EmptyElementEnumerated) : null) != null) m_EmptyElementEnumerated.parent = this;
					break;
				case production_kind.g_XMLEnumeratedValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TextEnumerated = (p_XMLEnumeratedValue.m_TextEnumerated != null) ? new TextEnumerated (p_XMLEnumeratedValue.m_TextEnumerated) : null) != null) m_TextEnumerated.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLEnumeratedValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLEnumeratedValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_EmptyElementEnumerated?.Dispose ();
			m_TextEnumerated?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLEnumeratedValue

		// Content changing function(s) associated with production(s) of syntax rule XMLEnumeratedValue

		//
		// Content changing function associated with following production(s)
		// XMLEnumeratedValue -> EmptyElementEnumerated

		//

		public void change(EmptyElementEnumerated p_EmptyElementEnumerated)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLEnumeratedValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_EmptyElementEnumerated = p_EmptyElementEnumerated;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLEnumeratedValue -> TextEnumerated

		//

		public void change(TextEnumerated p_TextEnumerated)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLEnumeratedValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TextEnumerated = p_TextEnumerated;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLEnumeratedValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_EmptyElementEnumerated != null) && m_EmptyElementEnumerated.checkInclusion (element) ||
				(m_TextEnumerated != null) && m_TextEnumerated.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLEnumeratedValue

		//
		// emit production tree node associated with any production of syntax rule XMLEnumeratedValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLEnumeratedValue_1:
					// emit syntax tree node associated with production
					// XMLEnumeratedValue: EmptyElementEnumerated

					s += m_EmptyElementEnumerated.Emit (depth - 1);
				break;
				case production_kind.g_XMLEnumeratedValue_2:
					// emit syntax tree node associated with production
					// XMLEnumeratedValue: TextEnumerated

					s += m_TextEnumerated.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLEnumeratedValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLEnumeratedValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLEnumeratedValue_1:
					// emit syntax tree node associated with production
					// XMLEnumeratedValue: EmptyElementEnumerated

					s += m_EmptyElementEnumerated.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLEnumeratedValue_2:
					// emit syntax tree node associated with production
					// XMLEnumeratedValue: TextEnumerated

					s += m_TextEnumerated.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLEnumeratedValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLEnumeratedValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLEnumeratedValue.production_kind kind = (XMLEnumeratedValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLEnumeratedValue.production_kind.g_XMLEnumeratedValue_1:
					// traverse syntax tree node associated with production
					// XMLEnumeratedValue: EmptyElementEnumerated

						m_EmptyElementEnumerated.Visit (visitor, appData);
				break;
				case XMLEnumeratedValue.production_kind.g_XMLEnumeratedValue_2:
					// traverse syntax tree node associated with production
					// XMLEnumeratedValue: TextEnumerated

						m_TextEnumerated.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_EmptyElementEnumerated?.reparent (this);
			m_TextEnumerated?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLEnumeratedValue
		//

		public void _init ()
		{
			m_EmptyElementEnumerated = null;
			m_TextEnumerated = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLEnumeratedValue

		// counter of all nodes associated with syntax rule XMLEnumeratedValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLEnumeratedValue
		[DataMember (Name = "m_EmptyElementEnumerated")] public EmptyElementEnumerated m_EmptyElementEnumerated { get; private set; }
		[DataMember (Name = "m_TextEnumerated")] public TextEnumerated m_TextEnumerated { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLEnumeratedValue

		// delegate function (callback) prototype associated with syntax rule XMLEnumeratedValue
		public delegate bool XMLEnumeratedValue_Callback (SyntaxTreeCallbackReason reason, XMLEnumeratedValue.production_kind kind, XMLEnumeratedValue p_XMLEnumeratedValue);

		// event associated with syntax rule XMLEnumeratedValue
		public event XMLEnumeratedValue_Callback XMLEnumeratedValue_Event;

		// event trigger associated with syntax rule XMLEnumeratedValue
		public bool Raise_XMLEnumeratedValue_Event (SyntaxTreeCallbackReason reason, XMLEnumeratedValue.production_kind kind, XMLEnumeratedValue p_XMLEnumeratedValue)
		{
			bool? status = XMLEnumeratedValue_Event?.Invoke (reason, kind, p_XMLEnumeratedValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLEnumeratedValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLEnumeratedValue
		//

		public void Traverse (XMLEnumeratedValue p_XMLEnumeratedValue)
		{
			if (p_XMLEnumeratedValue.isLocked())
				return;
			p_XMLEnumeratedValue.dolock();
			XMLEnumeratedValue.production_kind kind = (XMLEnumeratedValue.production_kind) p_XMLEnumeratedValue.kind;
			p_XMLEnumeratedValue.turn_reset ();
			if (Raise_XMLEnumeratedValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLEnumeratedValue))
			switch (kind)
			{
				case XMLEnumeratedValue.production_kind.g_XMLEnumeratedValue_1:
					// traverse syntax tree node associated with production
					// XMLEnumeratedValue: EmptyElementEnumerated

					if (Raise_XMLEnumeratedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLEnumeratedValue))
						Traverse (p_XMLEnumeratedValue.m_EmptyElementEnumerated);
					p_XMLEnumeratedValue.turn_inc ();
					Raise_XMLEnumeratedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLEnumeratedValue);
				break;
				case XMLEnumeratedValue.production_kind.g_XMLEnumeratedValue_2:
					// traverse syntax tree node associated with production
					// XMLEnumeratedValue: TextEnumerated

					if (Raise_XMLEnumeratedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLEnumeratedValue))
						Traverse (p_XMLEnumeratedValue.m_TextEnumerated);
					p_XMLEnumeratedValue.turn_inc ();
					Raise_XMLEnumeratedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLEnumeratedValue);
				break;
			}
			Raise_XMLEnumeratedValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLEnumeratedValue);
			p_XMLEnumeratedValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLEnumeratedValue
		//

		public void TraverseCommon (XMLEnumeratedValue p_XMLEnumeratedValue)
		{
			XMLEnumeratedValue.production_kind kind = (XMLEnumeratedValue.production_kind) p_XMLEnumeratedValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLEnumeratedValue))
			switch (kind)
			{
				case XMLEnumeratedValue.production_kind.g_XMLEnumeratedValue_1:
					// traverse syntax tree node associated with production
					// XMLEnumeratedValue: EmptyElementEnumerated

						TraverseCommon (p_XMLEnumeratedValue.m_EmptyElementEnumerated);
				break;
				case XMLEnumeratedValue.production_kind.g_XMLEnumeratedValue_2:
					// traverse syntax tree node associated with production
					// XMLEnumeratedValue: TextEnumerated

						TraverseCommon (p_XMLEnumeratedValue.m_TextEnumerated);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLEnumeratedValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLEnumeratedValue

		//
		// create syntax tree node associated with production
		// XMLEnumeratedValue: EmptyElementEnumerated

		//

		public XMLEnumeratedValue XMLEnumeratedValue_1 (EmptyElementEnumerated p_EmptyElementEnumerated)
		{
			XMLEnumeratedValue p_XMLEnumeratedValue_ref = new XMLEnumeratedValue(p_EmptyElementEnumerated);
			p_EmptyElementEnumerated.parent = p_XMLEnumeratedValue_ref;
			Raise_XMLEnumeratedValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLEnumeratedValue.production_kind.g_XMLEnumeratedValue_1, p_XMLEnumeratedValue_ref);
			return p_XMLEnumeratedValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLEnumeratedValue: TextEnumerated

		//

		public XMLEnumeratedValue XMLEnumeratedValue_2 (TextEnumerated p_TextEnumerated)
		{
			XMLEnumeratedValue p_XMLEnumeratedValue_ref = new XMLEnumeratedValue(p_TextEnumerated);
			p_TextEnumerated.parent = p_XMLEnumeratedValue_ref;
			Raise_XMLEnumeratedValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLEnumeratedValue.production_kind.g_XMLEnumeratedValue_2, p_XMLEnumeratedValue_ref);
			return p_XMLEnumeratedValue_ref;
		}
		#endregion
	};
}
