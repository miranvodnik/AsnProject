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
	// class associated with syntax rule TimeType
	//

	[DataContract]
	public class	TimeType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TimeType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TimeType
		{
			g_TimeType_1 = 1,	// TIME

		};
		#endregion
		#region production markers associated with the syntax rule TimeType

		// markers associated with production: TimeType -> TIME

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TimeType

		// Constructor declaration(s) associated with production(s) of syntax rule TimeType

		//
		// Constructor associated with the following production(s)
		// TimeType -> TIME

		//

		public TimeType (SyntaxTreeToken p_token) : base ((uint) ProductionID._TimeType_ID, (uint) production_kind.g_TimeType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TIME = p_token;
		}

		public TimeType () { }

		// Copy constructor

		public TimeType (TimeType p_TimeType) : base (p_TimeType.id, p_TimeType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TimeType.appInfo;
			switch ((production_kind) p_TimeType.kind)
			{
				case production_kind.g_TimeType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TIME = (p_TimeType.m_TIME != null) ? new SyntaxTreeToken (p_TimeType.m_TIME) : null) != null) m_TIME.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TimeType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TimeType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_TIME?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TimeType

		// Content changing function(s) associated with production(s) of syntax rule TimeType

		//
		// Content changing function associated with following production(s)
		// TimeType -> TIME

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_TimeType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TIME = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TimeType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_TIME != null) && m_TIME.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TimeType

		//
		// emit production tree node associated with any production of syntax rule TimeType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TimeType_1:
					// emit syntax tree node associated with production
					// TimeType: TIME

					s += m_TIME.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TimeType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TimeType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TimeType_1:
					// emit syntax tree node associated with production
					// TimeType: TIME

					s += "TIME";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TimeType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TimeType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TimeType.production_kind kind = (TimeType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TimeType.production_kind.g_TimeType_1:
					// traverse syntax tree node associated with production
					// TimeType: TIME

						m_TIME.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_TIME?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TimeType
		//

		public void _init ()
		{
			m_TIME = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TimeType

		// counter of all nodes associated with syntax rule TimeType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TimeType
		[DataMember (Name = "m_TIME")] public SyntaxTreeToken m_TIME { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TimeType

		// delegate function (callback) prototype associated with syntax rule TimeType
		public delegate bool TimeType_Callback (SyntaxTreeCallbackReason reason, TimeType.production_kind kind, TimeType p_TimeType);

		// event associated with syntax rule TimeType
		public event TimeType_Callback TimeType_Event;

		// event trigger associated with syntax rule TimeType
		public bool Raise_TimeType_Event (SyntaxTreeCallbackReason reason, TimeType.production_kind kind, TimeType p_TimeType)
		{
			bool? status = TimeType_Event?.Invoke (reason, kind, p_TimeType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TimeType
		//
		// traverse syntax tree node associated with any production of syntax rule TimeType
		//

		public void Traverse (TimeType p_TimeType)
		{
			if (p_TimeType.isLocked())
				return;
			p_TimeType.dolock();
			TimeType.production_kind kind = (TimeType.production_kind) p_TimeType.kind;
			p_TimeType.turn_reset ();
			if (Raise_TimeType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TimeType))
			switch (kind)
			{
				case TimeType.production_kind.g_TimeType_1:
					// traverse syntax tree node associated with production
					// TimeType: TIME

				break;
			}
			Raise_TimeType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TimeType);
			p_TimeType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TimeType
		//

		public void TraverseCommon (TimeType p_TimeType)
		{
			TimeType.production_kind kind = (TimeType.production_kind) p_TimeType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TimeType))
			switch (kind)
			{
				case TimeType.production_kind.g_TimeType_1:
					// traverse syntax tree node associated with production
					// TimeType: TIME

						TraverseCommon (p_TimeType.m_TIME);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TimeType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TimeType

		//
		// create syntax tree node associated with production
		// TimeType: TIME

		//

		public TimeType TimeType_1 (SyntaxTreeToken p_token)
		{
			TimeType p_TimeType_ref = new TimeType(p_token);
			p_token.parent = p_TimeType_ref;
			Raise_TimeType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TimeType.production_kind.g_TimeType_1, p_TimeType_ref);
			return p_TimeType_ref;
		}
		#endregion
	};
}
