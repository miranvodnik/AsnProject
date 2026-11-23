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
	// class associated with syntax rule XMLIntegerValue
	//

	[DataContract]
	public class	XMLIntegerValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLIntegerValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLIntegerValue
		{
			g_XMLIntegerValue_1 = 1,	// XMLSignedNumber

			g_XMLIntegerValue_2 = 2,	// EmptyElementInteger

			g_XMLIntegerValue_3 = 3,	// TextInteger

		};
		#endregion
		#region production markers associated with the syntax rule XMLIntegerValue

		// markers associated with production: XMLIntegerValue -> XMLSignedNumber

		public enum production_marker_1 : ushort
		{
			m_XMLSignedNumber,
			final
		};

		// markers associated with production: XMLIntegerValue -> EmptyElementInteger

		public enum production_marker_2 : ushort
		{
			m_EmptyElementInteger,
			final
		};

		// markers associated with production: XMLIntegerValue -> TextInteger

		public enum production_marker_3 : ushort
		{
			m_TextInteger,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLIntegerValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLIntegerValue

		//
		// Constructor associated with the following production(s)
		// XMLIntegerValue -> XMLSignedNumber

		//

		public XMLIntegerValue (XMLSignedNumber p_XMLSignedNumber) : base ((uint) ProductionID._XMLIntegerValue_ID, (uint) production_kind.g_XMLIntegerValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLSignedNumber = p_XMLSignedNumber;
		}

		//
		// Constructor associated with the following production(s)
		// XMLIntegerValue -> EmptyElementInteger

		//

		public XMLIntegerValue (EmptyElementInteger p_EmptyElementInteger) : base ((uint) ProductionID._XMLIntegerValue_ID, (uint) production_kind.g_XMLIntegerValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_EmptyElementInteger = p_EmptyElementInteger;
		}

		//
		// Constructor associated with the following production(s)
		// XMLIntegerValue -> TextInteger

		//

		public XMLIntegerValue (TextInteger p_TextInteger) : base ((uint) ProductionID._XMLIntegerValue_ID, (uint) production_kind.g_XMLIntegerValue_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TextInteger = p_TextInteger;
		}

		public XMLIntegerValue () { }

		// Copy constructor

		public XMLIntegerValue (XMLIntegerValue p_XMLIntegerValue) : base (p_XMLIntegerValue.id, p_XMLIntegerValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLIntegerValue.appInfo;
			switch ((production_kind) p_XMLIntegerValue.kind)
			{
				case production_kind.g_XMLIntegerValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLSignedNumber = (p_XMLIntegerValue.m_XMLSignedNumber != null) ? new XMLSignedNumber (p_XMLIntegerValue.m_XMLSignedNumber) : null) != null) m_XMLSignedNumber.parent = this;
					break;
				case production_kind.g_XMLIntegerValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EmptyElementInteger = (p_XMLIntegerValue.m_EmptyElementInteger != null) ? new EmptyElementInteger (p_XMLIntegerValue.m_EmptyElementInteger) : null) != null) m_EmptyElementInteger.parent = this;
					break;
				case production_kind.g_XMLIntegerValue_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TextInteger = (p_XMLIntegerValue.m_TextInteger != null) ? new TextInteger (p_XMLIntegerValue.m_TextInteger) : null) != null) m_TextInteger.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLIntegerValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLIntegerValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLSignedNumber?.Dispose ();
			m_EmptyElementInteger?.Dispose ();
			m_TextInteger?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLIntegerValue

		// Content changing function(s) associated with production(s) of syntax rule XMLIntegerValue

		//
		// Content changing function associated with following production(s)
		// XMLIntegerValue -> XMLSignedNumber

		//

		public void change(XMLSignedNumber p_XMLSignedNumber)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLIntegerValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLSignedNumber = p_XMLSignedNumber;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLIntegerValue -> EmptyElementInteger

		//

		public void change(EmptyElementInteger p_EmptyElementInteger)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLIntegerValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_EmptyElementInteger = p_EmptyElementInteger;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLIntegerValue -> TextInteger

		//

		public void change(TextInteger p_TextInteger)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLIntegerValue_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TextInteger = p_TextInteger;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLIntegerValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLSignedNumber != null) && m_XMLSignedNumber.checkInclusion (element) ||
				(m_EmptyElementInteger != null) && m_EmptyElementInteger.checkInclusion (element) ||
				(m_TextInteger != null) && m_TextInteger.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLIntegerValue

		//
		// emit production tree node associated with any production of syntax rule XMLIntegerValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLIntegerValue_1:
					// emit syntax tree node associated with production
					// XMLIntegerValue: XMLSignedNumber

					s += m_XMLSignedNumber.Emit (depth - 1);
				break;
				case production_kind.g_XMLIntegerValue_2:
					// emit syntax tree node associated with production
					// XMLIntegerValue: EmptyElementInteger

					s += m_EmptyElementInteger.Emit (depth - 1);
				break;
				case production_kind.g_XMLIntegerValue_3:
					// emit syntax tree node associated with production
					// XMLIntegerValue: TextInteger

					s += m_TextInteger.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLIntegerValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLIntegerValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLIntegerValue_1:
					// emit syntax tree node associated with production
					// XMLIntegerValue: XMLSignedNumber

					s += m_XMLSignedNumber.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLIntegerValue_2:
					// emit syntax tree node associated with production
					// XMLIntegerValue: EmptyElementInteger

					s += m_EmptyElementInteger.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLIntegerValue_3:
					// emit syntax tree node associated with production
					// XMLIntegerValue: TextInteger

					s += m_TextInteger.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLIntegerValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLIntegerValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLIntegerValue.production_kind kind = (XMLIntegerValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLIntegerValue.production_kind.g_XMLIntegerValue_1:
					// traverse syntax tree node associated with production
					// XMLIntegerValue: XMLSignedNumber

						m_XMLSignedNumber.Visit (visitor, appData);
				break;
				case XMLIntegerValue.production_kind.g_XMLIntegerValue_2:
					// traverse syntax tree node associated with production
					// XMLIntegerValue: EmptyElementInteger

						m_EmptyElementInteger.Visit (visitor, appData);
				break;
				case XMLIntegerValue.production_kind.g_XMLIntegerValue_3:
					// traverse syntax tree node associated with production
					// XMLIntegerValue: TextInteger

						m_TextInteger.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_XMLSignedNumber?.reparent (this);
			m_EmptyElementInteger?.reparent (this);
			m_TextInteger?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLIntegerValue
		//

		public void _init ()
		{
			m_XMLSignedNumber = null;
			m_EmptyElementInteger = null;
			m_TextInteger = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLIntegerValue

		// counter of all nodes associated with syntax rule XMLIntegerValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLIntegerValue
		[DataMember (Name = "m_XMLSignedNumber")] public XMLSignedNumber m_XMLSignedNumber { get; private set; }
		[DataMember (Name = "m_EmptyElementInteger")] public EmptyElementInteger m_EmptyElementInteger { get; private set; }
		[DataMember (Name = "m_TextInteger")] public TextInteger m_TextInteger { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLIntegerValue

		// delegate function (callback) prototype associated with syntax rule XMLIntegerValue
		public delegate bool XMLIntegerValue_Callback (SyntaxTreeCallbackReason reason, XMLIntegerValue.production_kind kind, XMLIntegerValue p_XMLIntegerValue);

		// event associated with syntax rule XMLIntegerValue
		public event XMLIntegerValue_Callback XMLIntegerValue_Event;

		// event trigger associated with syntax rule XMLIntegerValue
		public bool Raise_XMLIntegerValue_Event (SyntaxTreeCallbackReason reason, XMLIntegerValue.production_kind kind, XMLIntegerValue p_XMLIntegerValue)
		{
			bool? status = XMLIntegerValue_Event?.Invoke (reason, kind, p_XMLIntegerValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLIntegerValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLIntegerValue
		//

		public void Traverse (XMLIntegerValue p_XMLIntegerValue)
		{
			if (p_XMLIntegerValue.isLocked())
				return;
			p_XMLIntegerValue.dolock();
			XMLIntegerValue.production_kind kind = (XMLIntegerValue.production_kind) p_XMLIntegerValue.kind;
			p_XMLIntegerValue.turn_reset ();
			if (Raise_XMLIntegerValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLIntegerValue))
			switch (kind)
			{
				case XMLIntegerValue.production_kind.g_XMLIntegerValue_1:
					// traverse syntax tree node associated with production
					// XMLIntegerValue: XMLSignedNumber

					if (Raise_XMLIntegerValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLIntegerValue))
						Traverse (p_XMLIntegerValue.m_XMLSignedNumber);
					p_XMLIntegerValue.turn_inc ();
					Raise_XMLIntegerValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLIntegerValue);
				break;
				case XMLIntegerValue.production_kind.g_XMLIntegerValue_2:
					// traverse syntax tree node associated with production
					// XMLIntegerValue: EmptyElementInteger

					if (Raise_XMLIntegerValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLIntegerValue))
						Traverse (p_XMLIntegerValue.m_EmptyElementInteger);
					p_XMLIntegerValue.turn_inc ();
					Raise_XMLIntegerValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLIntegerValue);
				break;
				case XMLIntegerValue.production_kind.g_XMLIntegerValue_3:
					// traverse syntax tree node associated with production
					// XMLIntegerValue: TextInteger

					if (Raise_XMLIntegerValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLIntegerValue))
						Traverse (p_XMLIntegerValue.m_TextInteger);
					p_XMLIntegerValue.turn_inc ();
					Raise_XMLIntegerValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLIntegerValue);
				break;
			}
			Raise_XMLIntegerValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLIntegerValue);
			p_XMLIntegerValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLIntegerValue
		//

		public void TraverseCommon (XMLIntegerValue p_XMLIntegerValue)
		{
			XMLIntegerValue.production_kind kind = (XMLIntegerValue.production_kind) p_XMLIntegerValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLIntegerValue))
			switch (kind)
			{
				case XMLIntegerValue.production_kind.g_XMLIntegerValue_1:
					// traverse syntax tree node associated with production
					// XMLIntegerValue: XMLSignedNumber

						TraverseCommon (p_XMLIntegerValue.m_XMLSignedNumber);
				break;
				case XMLIntegerValue.production_kind.g_XMLIntegerValue_2:
					// traverse syntax tree node associated with production
					// XMLIntegerValue: EmptyElementInteger

						TraverseCommon (p_XMLIntegerValue.m_EmptyElementInteger);
				break;
				case XMLIntegerValue.production_kind.g_XMLIntegerValue_3:
					// traverse syntax tree node associated with production
					// XMLIntegerValue: TextInteger

						TraverseCommon (p_XMLIntegerValue.m_TextInteger);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLIntegerValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLIntegerValue

		//
		// create syntax tree node associated with production
		// XMLIntegerValue: XMLSignedNumber

		//

		public XMLIntegerValue XMLIntegerValue_1 (XMLSignedNumber p_XMLSignedNumber)
		{
			XMLIntegerValue p_XMLIntegerValue_ref = new XMLIntegerValue(p_XMLSignedNumber);
			p_XMLSignedNumber.parent = p_XMLIntegerValue_ref;
			Raise_XMLIntegerValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLIntegerValue.production_kind.g_XMLIntegerValue_1, p_XMLIntegerValue_ref);
			return p_XMLIntegerValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLIntegerValue: EmptyElementInteger

		//

		public XMLIntegerValue XMLIntegerValue_2 (EmptyElementInteger p_EmptyElementInteger)
		{
			XMLIntegerValue p_XMLIntegerValue_ref = new XMLIntegerValue(p_EmptyElementInteger);
			p_EmptyElementInteger.parent = p_XMLIntegerValue_ref;
			Raise_XMLIntegerValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLIntegerValue.production_kind.g_XMLIntegerValue_2, p_XMLIntegerValue_ref);
			return p_XMLIntegerValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLIntegerValue: TextInteger

		//

		public XMLIntegerValue XMLIntegerValue_3 (TextInteger p_TextInteger)
		{
			XMLIntegerValue p_XMLIntegerValue_ref = new XMLIntegerValue(p_TextInteger);
			p_TextInteger.parent = p_XMLIntegerValue_ref;
			Raise_XMLIntegerValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLIntegerValue.production_kind.g_XMLIntegerValue_3, p_XMLIntegerValue_ref);
			return p_XMLIntegerValue_ref;
		}
		#endregion
	};
}
