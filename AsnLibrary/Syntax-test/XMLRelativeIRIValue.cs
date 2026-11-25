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
	// class associated with syntax rule XMLRelativeIRIValue
	//

	[DataContract]
	public class	XMLRelativeIRIValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLRelativeIRIValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLRelativeIRIValue
		{
			g_XMLRelativeIRIValue_1 = 1,	// FirstRelativeArcIdentifier SubsequentArcIdentifier

		};
		#endregion
		#region production markers associated with the syntax rule XMLRelativeIRIValue

		// markers associated with production: XMLRelativeIRIValue -> FirstRelativeArcIdentifier SubsequentArcIdentifier

		public enum production_marker_1 : ushort
		{
			m_FirstRelativeArcIdentifier,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLRelativeIRIValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLRelativeIRIValue

		//
		// Constructor associated with the following production(s)
		// XMLRelativeIRIValue -> FirstRelativeArcIdentifier SubsequentArcIdentifier

		//

		public XMLRelativeIRIValue (FirstRelativeArcIdentifier p_FirstRelativeArcIdentifier, SyntaxTreeToken p_token) : base ((uint) ProductionID._XMLRelativeIRIValue_ID, (uint) production_kind.g_XMLRelativeIRIValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_FirstRelativeArcIdentifier = p_FirstRelativeArcIdentifier;
			children[1] = m_SubsequentArcIdentifier = p_token;
		}

		public XMLRelativeIRIValue () { }

		// Copy constructor

		public XMLRelativeIRIValue (XMLRelativeIRIValue p_XMLRelativeIRIValue) : base (p_XMLRelativeIRIValue.id, p_XMLRelativeIRIValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLRelativeIRIValue.appInfo;
			switch ((production_kind) p_XMLRelativeIRIValue.kind)
			{
				case production_kind.g_XMLRelativeIRIValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_FirstRelativeArcIdentifier = (p_XMLRelativeIRIValue.m_FirstRelativeArcIdentifier != null) ? new FirstRelativeArcIdentifier (p_XMLRelativeIRIValue.m_FirstRelativeArcIdentifier) : null) != null) m_FirstRelativeArcIdentifier.parent = this;
					if ((children [1] = m_SubsequentArcIdentifier = (p_XMLRelativeIRIValue.m_SubsequentArcIdentifier != null) ? new SyntaxTreeToken (p_XMLRelativeIRIValue.m_SubsequentArcIdentifier) : null) != null) m_SubsequentArcIdentifier.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLRelativeIRIValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLRelativeIRIValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_FirstRelativeArcIdentifier?.Dispose ();
			m_SubsequentArcIdentifier?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLRelativeIRIValue

		// Content changing function(s) associated with production(s) of syntax rule XMLRelativeIRIValue

		//
		// Content changing function associated with following production(s)
		// XMLRelativeIRIValue -> FirstRelativeArcIdentifier SubsequentArcIdentifier

		//

		public void change(FirstRelativeArcIdentifier p_FirstRelativeArcIdentifier, SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLRelativeIRIValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_FirstRelativeArcIdentifier = p_FirstRelativeArcIdentifier;
			children [1] = m_SubsequentArcIdentifier = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLRelativeIRIValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_FirstRelativeArcIdentifier != null) && m_FirstRelativeArcIdentifier.checkInclusion (element) ||
				(m_SubsequentArcIdentifier != null) && m_SubsequentArcIdentifier.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLRelativeIRIValue

		//
		// emit production tree node associated with any production of syntax rule XMLRelativeIRIValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLRelativeIRIValue_1:
					// emit syntax tree node associated with production
					// XMLRelativeIRIValue: FirstRelativeArcIdentifier SubsequentArcIdentifier

					s += m_FirstRelativeArcIdentifier.Emit (depth - 1);
					s += " ";
					s += m_SubsequentArcIdentifier.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLRelativeIRIValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLRelativeIRIValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLRelativeIRIValue_1:
					// emit syntax tree node associated with production
					// XMLRelativeIRIValue: FirstRelativeArcIdentifier SubsequentArcIdentifier

					s += m_FirstRelativeArcIdentifier.EmitProductionTree (depth - 1);
					s += ' ';
					s += "SubsequentArcIdentifier";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLRelativeIRIValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLRelativeIRIValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLRelativeIRIValue.production_kind kind = (XMLRelativeIRIValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLRelativeIRIValue.production_kind.g_XMLRelativeIRIValue_1:
					// traverse syntax tree node associated with production
					// XMLRelativeIRIValue: FirstRelativeArcIdentifier SubsequentArcIdentifier

						m_FirstRelativeArcIdentifier.Visit (visitor, appData);
						m_SubsequentArcIdentifier.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_FirstRelativeArcIdentifier?.reparent (this);
			m_SubsequentArcIdentifier?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLRelativeIRIValue
		//

		public void _init ()
		{
			m_FirstRelativeArcIdentifier = null;
			m_SubsequentArcIdentifier = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLRelativeIRIValue

		// counter of all nodes associated with syntax rule XMLRelativeIRIValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLRelativeIRIValue
		[DataMember (Name = "m_FirstRelativeArcIdentifier")] public FirstRelativeArcIdentifier m_FirstRelativeArcIdentifier { get; private set; }
		[DataMember (Name = "m_SubsequentArcIdentifier")] public SyntaxTreeToken m_SubsequentArcIdentifier { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLRelativeIRIValue

		// delegate function (callback) prototype associated with syntax rule XMLRelativeIRIValue
		public delegate bool XMLRelativeIRIValue_Callback (SyntaxTreeCallbackReason reason, XMLRelativeIRIValue.production_kind kind, XMLRelativeIRIValue p_XMLRelativeIRIValue);

		// event associated with syntax rule XMLRelativeIRIValue
		public event XMLRelativeIRIValue_Callback XMLRelativeIRIValue_Event;

		// event trigger associated with syntax rule XMLRelativeIRIValue
		public bool Raise_XMLRelativeIRIValue_Event (SyntaxTreeCallbackReason reason, XMLRelativeIRIValue.production_kind kind, XMLRelativeIRIValue p_XMLRelativeIRIValue)
		{
			bool? status = XMLRelativeIRIValue_Event?.Invoke (reason, kind, p_XMLRelativeIRIValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLRelativeIRIValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLRelativeIRIValue
		//

		public void Traverse (XMLRelativeIRIValue p_XMLRelativeIRIValue)
		{
			if (p_XMLRelativeIRIValue.isLocked())
				return;
			p_XMLRelativeIRIValue.dolock();
			XMLRelativeIRIValue.production_kind kind = (XMLRelativeIRIValue.production_kind) p_XMLRelativeIRIValue.kind;
			p_XMLRelativeIRIValue.turn_reset ();
			if (Raise_XMLRelativeIRIValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLRelativeIRIValue))
			switch (kind)
			{
				case XMLRelativeIRIValue.production_kind.g_XMLRelativeIRIValue_1:
					// traverse syntax tree node associated with production
					// XMLRelativeIRIValue: FirstRelativeArcIdentifier SubsequentArcIdentifier

					if (Raise_XMLRelativeIRIValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLRelativeIRIValue))
						Traverse (p_XMLRelativeIRIValue.m_FirstRelativeArcIdentifier);
					p_XMLRelativeIRIValue.turn_inc ();
					Raise_XMLRelativeIRIValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLRelativeIRIValue);
				break;
			}
			Raise_XMLRelativeIRIValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLRelativeIRIValue);
			p_XMLRelativeIRIValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLRelativeIRIValue
		//

		public void TraverseCommon (XMLRelativeIRIValue p_XMLRelativeIRIValue)
		{
			XMLRelativeIRIValue.production_kind kind = (XMLRelativeIRIValue.production_kind) p_XMLRelativeIRIValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLRelativeIRIValue))
			switch (kind)
			{
				case XMLRelativeIRIValue.production_kind.g_XMLRelativeIRIValue_1:
					// traverse syntax tree node associated with production
					// XMLRelativeIRIValue: FirstRelativeArcIdentifier SubsequentArcIdentifier

						TraverseCommon (p_XMLRelativeIRIValue.m_FirstRelativeArcIdentifier);
						TraverseCommon (p_XMLRelativeIRIValue.m_SubsequentArcIdentifier);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLRelativeIRIValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLRelativeIRIValue

		//
		// create syntax tree node associated with production
		// XMLRelativeIRIValue: FirstRelativeArcIdentifier SubsequentArcIdentifier

		//

		public XMLRelativeIRIValue XMLRelativeIRIValue_1 (FirstRelativeArcIdentifier p_FirstRelativeArcIdentifier, SyntaxTreeToken p_token)
		{
			XMLRelativeIRIValue p_XMLRelativeIRIValue_ref = new XMLRelativeIRIValue(p_FirstRelativeArcIdentifier, p_token);
			p_FirstRelativeArcIdentifier.parent = p_XMLRelativeIRIValue_ref;
			p_token.parent = p_XMLRelativeIRIValue_ref;
			Raise_XMLRelativeIRIValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLRelativeIRIValue.production_kind.g_XMLRelativeIRIValue_1, p_XMLRelativeIRIValue_ref);
			return p_XMLRelativeIRIValue_ref;
		}
		#endregion
	};
}
