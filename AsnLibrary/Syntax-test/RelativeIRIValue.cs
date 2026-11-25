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
	// class associated with syntax rule RelativeIRIValue
	//

	[DataContract]
	public class	RelativeIRIValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule RelativeIRIValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule RelativeIRIValue
		{
			g_RelativeIRIValue_1 = 1,	// '"' FirstRelativeArcIdentifier SubsequentArcIdentifier '"'

		};
		#endregion
		#region production markers associated with the syntax rule RelativeIRIValue

		// markers associated with production: RelativeIRIValue -> '"' FirstRelativeArcIdentifier SubsequentArcIdentifier '"'

		public enum production_marker_1 : ushort
		{
			m_FirstRelativeArcIdentifier,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule RelativeIRIValue

		// Constructor declaration(s) associated with production(s) of syntax rule RelativeIRIValue

		//
		// Constructor associated with the following production(s)
		// RelativeIRIValue -> '"' FirstRelativeArcIdentifier SubsequentArcIdentifier '"'

		//

		public RelativeIRIValue (SyntaxTreeToken p_token, FirstRelativeArcIdentifier p_FirstRelativeArcIdentifier, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._RelativeIRIValue_ID, (uint) production_kind.g_RelativeIRIValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_double_quotes = p_token;
			children[1] = m_FirstRelativeArcIdentifier = p_FirstRelativeArcIdentifier;
			children[2] = m_SubsequentArcIdentifier = p_token_1;
			children[3] = m_double_quotes_1 = p_token_2;
		}

		public RelativeIRIValue () { }

		// Copy constructor

		public RelativeIRIValue (RelativeIRIValue p_RelativeIRIValue) : base (p_RelativeIRIValue.id, p_RelativeIRIValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_RelativeIRIValue.appInfo;
			switch ((production_kind) p_RelativeIRIValue.kind)
			{
				case production_kind.g_RelativeIRIValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_double_quotes = (p_RelativeIRIValue.m_double_quotes != null) ? new SyntaxTreeToken (p_RelativeIRIValue.m_double_quotes) : null) != null) m_double_quotes.parent = this;
					if ((children [1] = m_FirstRelativeArcIdentifier = (p_RelativeIRIValue.m_FirstRelativeArcIdentifier != null) ? new FirstRelativeArcIdentifier (p_RelativeIRIValue.m_FirstRelativeArcIdentifier) : null) != null) m_FirstRelativeArcIdentifier.parent = this;
					if ((children [2] = m_SubsequentArcIdentifier = (p_RelativeIRIValue.m_SubsequentArcIdentifier != null) ? new SyntaxTreeToken (p_RelativeIRIValue.m_SubsequentArcIdentifier) : null) != null) m_SubsequentArcIdentifier.parent = this;
					if ((children [3] = m_double_quotes_1 = (p_RelativeIRIValue.m_double_quotes_1 != null) ? new SyntaxTreeToken (p_RelativeIRIValue.m_double_quotes_1) : null) != null) m_double_quotes_1.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "RelativeIRIValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new RelativeIRIValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_double_quotes?.Dispose ();
			m_double_quotes_1?.Dispose ();
			m_FirstRelativeArcIdentifier?.Dispose ();
			m_SubsequentArcIdentifier?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule RelativeIRIValue

		// Content changing function(s) associated with production(s) of syntax rule RelativeIRIValue

		//
		// Content changing function associated with following production(s)
		// RelativeIRIValue -> '"' FirstRelativeArcIdentifier SubsequentArcIdentifier '"'

		//

		public void change(SyntaxTreeToken p_token, FirstRelativeArcIdentifier p_FirstRelativeArcIdentifier, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_RelativeIRIValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_double_quotes = p_token;
			children [1] = m_FirstRelativeArcIdentifier = p_FirstRelativeArcIdentifier;
			children [2] = m_SubsequentArcIdentifier = p_token_1;
			children [3] = m_double_quotes_1 = p_token_2;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule RelativeIRIValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_double_quotes != null) && m_double_quotes.checkInclusion (element) ||
				(m_double_quotes_1 != null) && m_double_quotes_1.checkInclusion (element) ||
				(m_FirstRelativeArcIdentifier != null) && m_FirstRelativeArcIdentifier.checkInclusion (element) ||
				(m_SubsequentArcIdentifier != null) && m_SubsequentArcIdentifier.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule RelativeIRIValue

		//
		// emit production tree node associated with any production of syntax rule RelativeIRIValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_RelativeIRIValue_1:
					// emit syntax tree node associated with production
					// RelativeIRIValue: '"' FirstRelativeArcIdentifier SubsequentArcIdentifier '"'

					s += m_double_quotes.Emit (depth - 1);
					s += " ";
					s += m_FirstRelativeArcIdentifier.Emit (depth - 1);
					s += " ";
					s += m_SubsequentArcIdentifier.Emit (depth - 1);
					s += " ";
					s += m_double_quotes_1.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule RelativeIRIValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "RelativeIRIValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_RelativeIRIValue_1:
					// emit syntax tree node associated with production
					// RelativeIRIValue: '"' FirstRelativeArcIdentifier SubsequentArcIdentifier '"'

					s += "double_quotes";
					s += ' ';
					s += m_FirstRelativeArcIdentifier.EmitProductionTree (depth - 1);
					s += ' ';
					s += "SubsequentArcIdentifier";
					s += ' ';
					s += "double_quotes";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule RelativeIRIValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule RelativeIRIValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			RelativeIRIValue.production_kind kind = (RelativeIRIValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case RelativeIRIValue.production_kind.g_RelativeIRIValue_1:
					// traverse syntax tree node associated with production
					// RelativeIRIValue: '"' FirstRelativeArcIdentifier SubsequentArcIdentifier '"'

						m_double_quotes.Visit (visitor, appData);
						m_FirstRelativeArcIdentifier.Visit (visitor, appData);
						m_SubsequentArcIdentifier.Visit (visitor, appData);
						m_double_quotes_1.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_double_quotes?.reparent (this);
			m_double_quotes_1?.reparent (this);

			m_FirstRelativeArcIdentifier?.reparent (this);
			m_SubsequentArcIdentifier?.reparent (this);
		}

		//
		// initialize object associated with syntax rule RelativeIRIValue
		//

		public void _init ()
		{
			m_double_quotes = null;
			m_double_quotes_1 = null;
			m_FirstRelativeArcIdentifier = null;
			m_SubsequentArcIdentifier = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule RelativeIRIValue

		// counter of all nodes associated with syntax rule RelativeIRIValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule RelativeIRIValue
		[DataMember (Name = "m_double_quotes")] public SyntaxTreeToken m_double_quotes { get; private set; }
		[DataMember (Name = "m_double_quotes_1")] public SyntaxTreeToken m_double_quotes_1 { get; private set; }
		[DataMember (Name = "m_FirstRelativeArcIdentifier")] public FirstRelativeArcIdentifier m_FirstRelativeArcIdentifier { get; private set; }
		[DataMember (Name = "m_SubsequentArcIdentifier")] public SyntaxTreeToken m_SubsequentArcIdentifier { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule RelativeIRIValue

		// delegate function (callback) prototype associated with syntax rule RelativeIRIValue
		public delegate bool RelativeIRIValue_Callback (SyntaxTreeCallbackReason reason, RelativeIRIValue.production_kind kind, RelativeIRIValue p_RelativeIRIValue);

		// event associated with syntax rule RelativeIRIValue
		public event RelativeIRIValue_Callback RelativeIRIValue_Event;

		// event trigger associated with syntax rule RelativeIRIValue
		public bool Raise_RelativeIRIValue_Event (SyntaxTreeCallbackReason reason, RelativeIRIValue.production_kind kind, RelativeIRIValue p_RelativeIRIValue)
		{
			bool? status = RelativeIRIValue_Event?.Invoke (reason, kind, p_RelativeIRIValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule RelativeIRIValue
		//
		// traverse syntax tree node associated with any production of syntax rule RelativeIRIValue
		//

		public void Traverse (RelativeIRIValue p_RelativeIRIValue)
		{
			if (p_RelativeIRIValue.isLocked())
				return;
			p_RelativeIRIValue.dolock();
			RelativeIRIValue.production_kind kind = (RelativeIRIValue.production_kind) p_RelativeIRIValue.kind;
			p_RelativeIRIValue.turn_reset ();
			if (Raise_RelativeIRIValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_RelativeIRIValue))
			switch (kind)
			{
				case RelativeIRIValue.production_kind.g_RelativeIRIValue_1:
					// traverse syntax tree node associated with production
					// RelativeIRIValue: '"' FirstRelativeArcIdentifier SubsequentArcIdentifier '"'

					if (Raise_RelativeIRIValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RelativeIRIValue))
						Traverse (p_RelativeIRIValue.m_FirstRelativeArcIdentifier);
					p_RelativeIRIValue.turn_inc ();
					Raise_RelativeIRIValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RelativeIRIValue);
				break;
			}
			Raise_RelativeIRIValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_RelativeIRIValue);
			p_RelativeIRIValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule RelativeIRIValue
		//

		public void TraverseCommon (RelativeIRIValue p_RelativeIRIValue)
		{
			RelativeIRIValue.production_kind kind = (RelativeIRIValue.production_kind) p_RelativeIRIValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_RelativeIRIValue))
			switch (kind)
			{
				case RelativeIRIValue.production_kind.g_RelativeIRIValue_1:
					// traverse syntax tree node associated with production
					// RelativeIRIValue: '"' FirstRelativeArcIdentifier SubsequentArcIdentifier '"'

						TraverseCommon (p_RelativeIRIValue.m_double_quotes);
						TraverseCommon (p_RelativeIRIValue.m_FirstRelativeArcIdentifier);
						TraverseCommon (p_RelativeIRIValue.m_SubsequentArcIdentifier);
						TraverseCommon (p_RelativeIRIValue.m_double_quotes_1);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_RelativeIRIValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule RelativeIRIValue

		//
		// create syntax tree node associated with production
		// RelativeIRIValue: '"' FirstRelativeArcIdentifier SubsequentArcIdentifier '"'

		//

		public RelativeIRIValue RelativeIRIValue_1 (SyntaxTreeToken p_token, FirstRelativeArcIdentifier p_FirstRelativeArcIdentifier, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			RelativeIRIValue p_RelativeIRIValue_ref = new RelativeIRIValue(p_token, p_FirstRelativeArcIdentifier, p_token_1, p_token_2);
			p_token.parent = p_RelativeIRIValue_ref;
			p_FirstRelativeArcIdentifier.parent = p_RelativeIRIValue_ref;
			p_token_1.parent = p_RelativeIRIValue_ref;
			p_token_2.parent = p_RelativeIRIValue_ref;
			Raise_RelativeIRIValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RelativeIRIValue.production_kind.g_RelativeIRIValue_1, p_RelativeIRIValue_ref);
			return p_RelativeIRIValue_ref;
		}
		#endregion
	};
}
