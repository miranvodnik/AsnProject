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
	// class associated with syntax rule IRIValue
	//

	[DataContract]
	public class	IRIValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule IRIValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule IRIValue
		{
			g_IRIValue_1 = 1,	// '"' ArcList '"'

		};
		#endregion
		#region production markers associated with the syntax rule IRIValue

		// markers associated with production: IRIValue -> '"' ArcList '"'

		public enum production_marker_1 : ushort
		{
			m_ArcList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule IRIValue

		// Constructor declaration(s) associated with production(s) of syntax rule IRIValue

		//
		// Constructor associated with the following production(s)
		// IRIValue -> '"' ArcList '"'

		//

		public IRIValue (SyntaxTreeToken p_token, ArcList p_ArcList, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._IRIValue_ID, (uint) production_kind.g_IRIValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_double_quotes = p_token;
			children[1] = m_ArcList = p_ArcList;
			children[2] = m_double_quotes_1 = p_token_1;
		}

		public IRIValue () { }

		// Copy constructor

		public IRIValue (IRIValue p_IRIValue) : base (p_IRIValue.id, p_IRIValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_IRIValue.appInfo;
			switch ((production_kind) p_IRIValue.kind)
			{
				case production_kind.g_IRIValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_double_quotes = (p_IRIValue.m_double_quotes != null) ? new SyntaxTreeToken (p_IRIValue.m_double_quotes) : null) != null) m_double_quotes.parent = this;
					if ((children [1] = m_ArcList = (p_IRIValue.m_ArcList != null) ? new ArcList (p_IRIValue.m_ArcList) : null) != null) m_ArcList.parent = this;
					if ((children [2] = m_double_quotes_1 = (p_IRIValue.m_double_quotes_1 != null) ? new SyntaxTreeToken (p_IRIValue.m_double_quotes_1) : null) != null) m_double_quotes_1.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "IRIValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new IRIValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_double_quotes?.Dispose ();
			m_double_quotes_1?.Dispose ();
			m_ArcList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule IRIValue

		// Content changing function(s) associated with production(s) of syntax rule IRIValue

		//
		// Content changing function associated with following production(s)
		// IRIValue -> '"' ArcList '"'

		//

		public void change(SyntaxTreeToken p_token, ArcList p_ArcList, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_IRIValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_double_quotes = p_token;
			children [1] = m_ArcList = p_ArcList;
			children [2] = m_double_quotes_1 = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule IRIValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_double_quotes != null) && m_double_quotes.checkInclusion (element) ||
				(m_double_quotes_1 != null) && m_double_quotes_1.checkInclusion (element) ||
				(m_ArcList != null) && m_ArcList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule IRIValue

		//
		// emit production tree node associated with any production of syntax rule IRIValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_IRIValue_1:
					// emit syntax tree node associated with production
					// IRIValue: '"' ArcList '"'

					s += m_double_quotes.Emit (depth - 1);
					s += " ";
					s += m_ArcList.Emit (depth - 1);
					s += " ";
					s += m_double_quotes_1.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule IRIValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "IRIValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_IRIValue_1:
					// emit syntax tree node associated with production
					// IRIValue: '"' ArcList '"'

					s += "double_quotes";
					s += ' ';
					s += m_ArcList.EmitProductionTree (depth - 1);
					s += ' ';
					s += "double_quotes";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule IRIValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule IRIValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			IRIValue.production_kind kind = (IRIValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case IRIValue.production_kind.g_IRIValue_1:
					// traverse syntax tree node associated with production
					// IRIValue: '"' ArcList '"'

						m_double_quotes.Visit (visitor, appData);
						m_ArcList.Visit (visitor, appData);
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

			m_ArcList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule IRIValue
		//

		public void _init ()
		{
			m_double_quotes = null;
			m_double_quotes_1 = null;
			m_ArcList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule IRIValue

		// counter of all nodes associated with syntax rule IRIValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule IRIValue
		[DataMember (Name = "m_double_quotes")] public SyntaxTreeToken m_double_quotes { get; private set; }
		[DataMember (Name = "m_double_quotes_1")] public SyntaxTreeToken m_double_quotes_1 { get; private set; }
		[DataMember (Name = "m_ArcList")] public ArcList m_ArcList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule IRIValue

		// delegate function (callback) prototype associated with syntax rule IRIValue
		public delegate bool IRIValue_Callback (SyntaxTreeCallbackReason reason, IRIValue.production_kind kind, IRIValue p_IRIValue);

		// event associated with syntax rule IRIValue
		public event IRIValue_Callback IRIValue_Event;

		// event trigger associated with syntax rule IRIValue
		public bool Raise_IRIValue_Event (SyntaxTreeCallbackReason reason, IRIValue.production_kind kind, IRIValue p_IRIValue)
		{
			bool? status = IRIValue_Event?.Invoke (reason, kind, p_IRIValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule IRIValue
		//
		// traverse syntax tree node associated with any production of syntax rule IRIValue
		//

		public void Traverse (IRIValue p_IRIValue)
		{
			if (p_IRIValue.isLocked())
				return;
			p_IRIValue.dolock();
			IRIValue.production_kind kind = (IRIValue.production_kind) p_IRIValue.kind;
			p_IRIValue.turn_reset ();
			if (Raise_IRIValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_IRIValue))
			switch (kind)
			{
				case IRIValue.production_kind.g_IRIValue_1:
					// traverse syntax tree node associated with production
					// IRIValue: '"' ArcList '"'

					if (Raise_IRIValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_IRIValue))
						Traverse (p_IRIValue.m_ArcList);
					p_IRIValue.turn_inc ();
					Raise_IRIValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_IRIValue);
				break;
			}
			Raise_IRIValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_IRIValue);
			p_IRIValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule IRIValue
		//

		public void TraverseCommon (IRIValue p_IRIValue)
		{
			IRIValue.production_kind kind = (IRIValue.production_kind) p_IRIValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_IRIValue))
			switch (kind)
			{
				case IRIValue.production_kind.g_IRIValue_1:
					// traverse syntax tree node associated with production
					// IRIValue: '"' ArcList '"'

						TraverseCommon (p_IRIValue.m_double_quotes);
						TraverseCommon (p_IRIValue.m_ArcList);
						TraverseCommon (p_IRIValue.m_double_quotes_1);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_IRIValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule IRIValue

		//
		// create syntax tree node associated with production
		// IRIValue: '"' ArcList '"'

		//

		public IRIValue IRIValue_1 (SyntaxTreeToken p_token, ArcList p_ArcList, SyntaxTreeToken p_token_1)
		{
			IRIValue p_IRIValue_ref = new IRIValue(p_token, p_ArcList, p_token_1);
			p_token.parent = p_IRIValue_ref;
			p_ArcList.parent = p_IRIValue_ref;
			p_token_1.parent = p_IRIValue_ref;
			Raise_IRIValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, IRIValue.production_kind.g_IRIValue_1, p_IRIValue_ref);
			return p_IRIValue_ref;
		}
		#endregion
	};
}
