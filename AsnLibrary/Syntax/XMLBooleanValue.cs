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
	// class associated with syntax rule XMLBooleanValue
	//

	[DataContract]
	public class	XMLBooleanValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLBooleanValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLBooleanValue
		{
			g_XMLBooleanValue_1 = 1,	// EmptyElementBoolean

			g_XMLBooleanValue_2 = 2,	// TextBoolean

		};
		#endregion
		#region production markers associated with the syntax rule XMLBooleanValue

		// markers associated with production: XMLBooleanValue -> EmptyElementBoolean

		public enum production_marker_1 : ushort
		{
			m_EmptyElementBoolean,
			final
		};

		// markers associated with production: XMLBooleanValue -> TextBoolean

		public enum production_marker_2 : ushort
		{
			m_TextBoolean,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLBooleanValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLBooleanValue

		//
		// Constructor associated with the following production(s)
		// XMLBooleanValue -> EmptyElementBoolean

		//

		public XMLBooleanValue (EmptyElementBoolean p_EmptyElementBoolean) : base ((uint) ProductionID._XMLBooleanValue_ID, (uint) production_kind.g_XMLBooleanValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_EmptyElementBoolean = p_EmptyElementBoolean;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBooleanValue -> TextBoolean

		//

		public XMLBooleanValue (TextBoolean p_TextBoolean) : base ((uint) ProductionID._XMLBooleanValue_ID, (uint) production_kind.g_XMLBooleanValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TextBoolean = p_TextBoolean;
		}

		public XMLBooleanValue () { }

		// Copy constructor

		public XMLBooleanValue (XMLBooleanValue p_XMLBooleanValue) : base (p_XMLBooleanValue.id, p_XMLBooleanValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLBooleanValue.appInfo;
			switch ((production_kind) p_XMLBooleanValue.kind)
			{
				case production_kind.g_XMLBooleanValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EmptyElementBoolean = (p_XMLBooleanValue.m_EmptyElementBoolean != null) ? new EmptyElementBoolean (p_XMLBooleanValue.m_EmptyElementBoolean) : null) != null) m_EmptyElementBoolean.parent = this;
					break;
				case production_kind.g_XMLBooleanValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TextBoolean = (p_XMLBooleanValue.m_TextBoolean != null) ? new TextBoolean (p_XMLBooleanValue.m_TextBoolean) : null) != null) m_TextBoolean.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLBooleanValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLBooleanValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_EmptyElementBoolean?.Dispose ();
			m_TextBoolean?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLBooleanValue

		// Content changing function(s) associated with production(s) of syntax rule XMLBooleanValue

		//
		// Content changing function associated with following production(s)
		// XMLBooleanValue -> EmptyElementBoolean

		//

		public void change(EmptyElementBoolean p_EmptyElementBoolean)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBooleanValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_EmptyElementBoolean = p_EmptyElementBoolean;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBooleanValue -> TextBoolean

		//

		public void change(TextBoolean p_TextBoolean)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBooleanValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TextBoolean = p_TextBoolean;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLBooleanValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_EmptyElementBoolean != null) && m_EmptyElementBoolean.checkInclusion (element) ||
				(m_TextBoolean != null) && m_TextBoolean.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLBooleanValue

		//
		// emit production tree node associated with any production of syntax rule XMLBooleanValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLBooleanValue_1:
					// emit syntax tree node associated with production
					// XMLBooleanValue: EmptyElementBoolean

					s += m_EmptyElementBoolean.Emit (depth - 1);
				break;
				case production_kind.g_XMLBooleanValue_2:
					// emit syntax tree node associated with production
					// XMLBooleanValue: TextBoolean

					s += m_TextBoolean.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLBooleanValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLBooleanValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLBooleanValue_1:
					// emit syntax tree node associated with production
					// XMLBooleanValue: EmptyElementBoolean

					s += m_EmptyElementBoolean.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBooleanValue_2:
					// emit syntax tree node associated with production
					// XMLBooleanValue: TextBoolean

					s += m_TextBoolean.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLBooleanValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLBooleanValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLBooleanValue.production_kind kind = (XMLBooleanValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLBooleanValue.production_kind.g_XMLBooleanValue_1:
					// traverse syntax tree node associated with production
					// XMLBooleanValue: EmptyElementBoolean

						m_EmptyElementBoolean.Visit (visitor, appData);
				break;
				case XMLBooleanValue.production_kind.g_XMLBooleanValue_2:
					// traverse syntax tree node associated with production
					// XMLBooleanValue: TextBoolean

						m_TextBoolean.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_EmptyElementBoolean?.reparent (this);
			m_TextBoolean?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLBooleanValue
		//

		public void _init ()
		{
			m_EmptyElementBoolean = null;
			m_TextBoolean = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLBooleanValue

		// counter of all nodes associated with syntax rule XMLBooleanValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLBooleanValue
		[DataMember (Name = "m_EmptyElementBoolean")] public EmptyElementBoolean m_EmptyElementBoolean { get; private set; }
		[DataMember (Name = "m_TextBoolean")] public TextBoolean m_TextBoolean { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLBooleanValue

		// delegate function (callback) prototype associated with syntax rule XMLBooleanValue
		public delegate bool XMLBooleanValue_Callback (SyntaxTreeCallbackReason reason, XMLBooleanValue.production_kind kind, XMLBooleanValue p_XMLBooleanValue);

		// event associated with syntax rule XMLBooleanValue
		public event XMLBooleanValue_Callback XMLBooleanValue_Event;

		// event trigger associated with syntax rule XMLBooleanValue
		public bool Raise_XMLBooleanValue_Event (SyntaxTreeCallbackReason reason, XMLBooleanValue.production_kind kind, XMLBooleanValue p_XMLBooleanValue)
		{
			bool? status = XMLBooleanValue_Event?.Invoke (reason, kind, p_XMLBooleanValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLBooleanValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLBooleanValue
		//

		public void Traverse (XMLBooleanValue p_XMLBooleanValue)
		{
			if (p_XMLBooleanValue.isLocked())
				return;
			p_XMLBooleanValue.dolock();
			XMLBooleanValue.production_kind kind = (XMLBooleanValue.production_kind) p_XMLBooleanValue.kind;
			p_XMLBooleanValue.turn_reset ();
			if (Raise_XMLBooleanValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLBooleanValue))
			switch (kind)
			{
				case XMLBooleanValue.production_kind.g_XMLBooleanValue_1:
					// traverse syntax tree node associated with production
					// XMLBooleanValue: EmptyElementBoolean

					if (Raise_XMLBooleanValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBooleanValue))
						Traverse (p_XMLBooleanValue.m_EmptyElementBoolean);
					p_XMLBooleanValue.turn_inc ();
					Raise_XMLBooleanValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBooleanValue);
				break;
				case XMLBooleanValue.production_kind.g_XMLBooleanValue_2:
					// traverse syntax tree node associated with production
					// XMLBooleanValue: TextBoolean

					if (Raise_XMLBooleanValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBooleanValue))
						Traverse (p_XMLBooleanValue.m_TextBoolean);
					p_XMLBooleanValue.turn_inc ();
					Raise_XMLBooleanValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBooleanValue);
				break;
			}
			Raise_XMLBooleanValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLBooleanValue);
			p_XMLBooleanValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLBooleanValue
		//

		public void TraverseCommon (XMLBooleanValue p_XMLBooleanValue)
		{
			XMLBooleanValue.production_kind kind = (XMLBooleanValue.production_kind) p_XMLBooleanValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLBooleanValue))
			switch (kind)
			{
				case XMLBooleanValue.production_kind.g_XMLBooleanValue_1:
					// traverse syntax tree node associated with production
					// XMLBooleanValue: EmptyElementBoolean

						TraverseCommon (p_XMLBooleanValue.m_EmptyElementBoolean);
				break;
				case XMLBooleanValue.production_kind.g_XMLBooleanValue_2:
					// traverse syntax tree node associated with production
					// XMLBooleanValue: TextBoolean

						TraverseCommon (p_XMLBooleanValue.m_TextBoolean);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLBooleanValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLBooleanValue

		//
		// create syntax tree node associated with production
		// XMLBooleanValue: EmptyElementBoolean

		//

		public XMLBooleanValue XMLBooleanValue_1 (EmptyElementBoolean p_EmptyElementBoolean)
		{
			XMLBooleanValue p_XMLBooleanValue_ref = new XMLBooleanValue(p_EmptyElementBoolean);
			p_EmptyElementBoolean.parent = p_XMLBooleanValue_ref;
			Raise_XMLBooleanValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBooleanValue.production_kind.g_XMLBooleanValue_1, p_XMLBooleanValue_ref);
			return p_XMLBooleanValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBooleanValue: TextBoolean

		//

		public XMLBooleanValue XMLBooleanValue_2 (TextBoolean p_TextBoolean)
		{
			XMLBooleanValue p_XMLBooleanValue_ref = new XMLBooleanValue(p_TextBoolean);
			p_TextBoolean.parent = p_XMLBooleanValue_ref;
			Raise_XMLBooleanValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBooleanValue.production_kind.g_XMLBooleanValue_2, p_XMLBooleanValue_ref);
			return p_XMLBooleanValue_ref;
		}
		#endregion
	};
}
