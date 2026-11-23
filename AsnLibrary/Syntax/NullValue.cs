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
	// class associated with syntax rule NullValue
	//

	[DataContract]
	public class	NullValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NullValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NullValue
		{
			g_NullValue_1 = 1,	// NULL

		};
		#endregion
		#region production markers associated with the syntax rule NullValue

		// markers associated with production: NullValue -> NULL

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NullValue

		// Constructor declaration(s) associated with production(s) of syntax rule NullValue

		//
		// Constructor associated with the following production(s)
		// NullValue -> NULL

		//

		public NullValue (SyntaxTreeToken p_token) : base ((uint) ProductionID._NullValue_ID, (uint) production_kind.g_NullValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NULL = p_token;
		}

		public NullValue () { }

		// Copy constructor

		public NullValue (NullValue p_NullValue) : base (p_NullValue.id, p_NullValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NullValue.appInfo;
			switch ((production_kind) p_NullValue.kind)
			{
				case production_kind.g_NullValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NULL = (p_NullValue.m_NULL != null) ? new SyntaxTreeToken (p_NullValue.m_NULL) : null) != null) m_NULL.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NullValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NullValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_NULL?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NullValue

		// Content changing function(s) associated with production(s) of syntax rule NullValue

		//
		// Content changing function associated with following production(s)
		// NullValue -> NULL

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_NullValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NULL = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NullValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_NULL != null) && m_NULL.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NullValue

		//
		// emit production tree node associated with any production of syntax rule NullValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NullValue_1:
					// emit syntax tree node associated with production
					// NullValue: NULL

					s += m_NULL.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NullValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NullValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NullValue_1:
					// emit syntax tree node associated with production
					// NullValue: NULL

					s += "NULL";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NullValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NullValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NullValue.production_kind kind = (NullValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NullValue.production_kind.g_NullValue_1:
					// traverse syntax tree node associated with production
					// NullValue: NULL

						m_NULL.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_NULL?.reparent (this);
		}

		//
		// initialize object associated with syntax rule NullValue
		//

		public void _init ()
		{
			m_NULL = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NullValue

		// counter of all nodes associated with syntax rule NullValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NullValue
		[DataMember (Name = "m_NULL")] public SyntaxTreeToken m_NULL { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NullValue

		// delegate function (callback) prototype associated with syntax rule NullValue
		public delegate bool NullValue_Callback (SyntaxTreeCallbackReason reason, NullValue.production_kind kind, NullValue p_NullValue);

		// event associated with syntax rule NullValue
		public event NullValue_Callback NullValue_Event;

		// event trigger associated with syntax rule NullValue
		public bool Raise_NullValue_Event (SyntaxTreeCallbackReason reason, NullValue.production_kind kind, NullValue p_NullValue)
		{
			bool? status = NullValue_Event?.Invoke (reason, kind, p_NullValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NullValue
		//
		// traverse syntax tree node associated with any production of syntax rule NullValue
		//

		public void Traverse (NullValue p_NullValue)
		{
			if (p_NullValue.isLocked())
				return;
			p_NullValue.dolock();
			NullValue.production_kind kind = (NullValue.production_kind) p_NullValue.kind;
			p_NullValue.turn_reset ();
			if (Raise_NullValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NullValue))
			switch (kind)
			{
				case NullValue.production_kind.g_NullValue_1:
					// traverse syntax tree node associated with production
					// NullValue: NULL

				break;
			}
			Raise_NullValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NullValue);
			p_NullValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NullValue
		//

		public void TraverseCommon (NullValue p_NullValue)
		{
			NullValue.production_kind kind = (NullValue.production_kind) p_NullValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NullValue))
			switch (kind)
			{
				case NullValue.production_kind.g_NullValue_1:
					// traverse syntax tree node associated with production
					// NullValue: NULL

						TraverseCommon (p_NullValue.m_NULL);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NullValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NullValue

		//
		// create syntax tree node associated with production
		// NullValue: NULL

		//

		public NullValue NullValue_1 (SyntaxTreeToken p_token)
		{
			NullValue p_NullValue_ref = new NullValue(p_token);
			p_token.parent = p_NullValue_ref;
			Raise_NullValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NullValue.production_kind.g_NullValue_1, p_NullValue_ref);
			return p_NullValue_ref;
		}
		#endregion
	};
}
