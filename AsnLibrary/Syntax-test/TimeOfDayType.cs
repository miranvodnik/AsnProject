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
	// class associated with syntax rule TimeOfDayType
	//

	[DataContract]
	public class	TimeOfDayType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TimeOfDayType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TimeOfDayType
		{
			g_TimeOfDayType_1 = 1,	// TIME-OF-DAY

		};
		#endregion
		#region production markers associated with the syntax rule TimeOfDayType

		// markers associated with production: TimeOfDayType -> TIME-OF-DAY

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TimeOfDayType

		// Constructor declaration(s) associated with production(s) of syntax rule TimeOfDayType

		//
		// Constructor associated with the following production(s)
		// TimeOfDayType -> TIME-OF-DAY

		//

		public TimeOfDayType (SyntaxTreeToken p_token) : base ((uint) ProductionID._TimeOfDayType_ID, (uint) production_kind.g_TimeOfDayType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TIME_OF_DAY = p_token;
		}

		public TimeOfDayType () { }

		// Copy constructor

		public TimeOfDayType (TimeOfDayType p_TimeOfDayType) : base (p_TimeOfDayType.id, p_TimeOfDayType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TimeOfDayType.appInfo;
			switch ((production_kind) p_TimeOfDayType.kind)
			{
				case production_kind.g_TimeOfDayType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TIME_OF_DAY = (p_TimeOfDayType.m_TIME_OF_DAY != null) ? new SyntaxTreeToken (p_TimeOfDayType.m_TIME_OF_DAY) : null) != null) m_TIME_OF_DAY.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TimeOfDayType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TimeOfDayType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_TIME_OF_DAY?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TimeOfDayType

		// Content changing function(s) associated with production(s) of syntax rule TimeOfDayType

		//
		// Content changing function associated with following production(s)
		// TimeOfDayType -> TIME-OF-DAY

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_TimeOfDayType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TIME_OF_DAY = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TimeOfDayType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_TIME_OF_DAY != null) && m_TIME_OF_DAY.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TimeOfDayType

		//
		// emit production tree node associated with any production of syntax rule TimeOfDayType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TimeOfDayType_1:
					// emit syntax tree node associated with production
					// TimeOfDayType: TIME-OF-DAY

					s += m_TIME_OF_DAY.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TimeOfDayType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TimeOfDayType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TimeOfDayType_1:
					// emit syntax tree node associated with production
					// TimeOfDayType: TIME-OF-DAY

					s += "TIME_OF_DAY";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TimeOfDayType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TimeOfDayType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TimeOfDayType.production_kind kind = (TimeOfDayType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TimeOfDayType.production_kind.g_TimeOfDayType_1:
					// traverse syntax tree node associated with production
					// TimeOfDayType: TIME-OF-DAY

						m_TIME_OF_DAY.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_TIME_OF_DAY?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TimeOfDayType
		//

		public void _init ()
		{
			m_TIME_OF_DAY = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TimeOfDayType

		// counter of all nodes associated with syntax rule TimeOfDayType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TimeOfDayType
		[DataMember (Name = "m_TIME_OF_DAY")] public SyntaxTreeToken m_TIME_OF_DAY { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TimeOfDayType

		// delegate function (callback) prototype associated with syntax rule TimeOfDayType
		public delegate bool TimeOfDayType_Callback (SyntaxTreeCallbackReason reason, TimeOfDayType.production_kind kind, TimeOfDayType p_TimeOfDayType);

		// event associated with syntax rule TimeOfDayType
		public event TimeOfDayType_Callback TimeOfDayType_Event;

		// event trigger associated with syntax rule TimeOfDayType
		public bool Raise_TimeOfDayType_Event (SyntaxTreeCallbackReason reason, TimeOfDayType.production_kind kind, TimeOfDayType p_TimeOfDayType)
		{
			bool? status = TimeOfDayType_Event?.Invoke (reason, kind, p_TimeOfDayType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TimeOfDayType
		//
		// traverse syntax tree node associated with any production of syntax rule TimeOfDayType
		//

		public void Traverse (TimeOfDayType p_TimeOfDayType)
		{
			if (p_TimeOfDayType.isLocked())
				return;
			p_TimeOfDayType.dolock();
			TimeOfDayType.production_kind kind = (TimeOfDayType.production_kind) p_TimeOfDayType.kind;
			p_TimeOfDayType.turn_reset ();
			if (Raise_TimeOfDayType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TimeOfDayType))
			switch (kind)
			{
				case TimeOfDayType.production_kind.g_TimeOfDayType_1:
					// traverse syntax tree node associated with production
					// TimeOfDayType: TIME-OF-DAY

				break;
			}
			Raise_TimeOfDayType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TimeOfDayType);
			p_TimeOfDayType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TimeOfDayType
		//

		public void TraverseCommon (TimeOfDayType p_TimeOfDayType)
		{
			TimeOfDayType.production_kind kind = (TimeOfDayType.production_kind) p_TimeOfDayType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TimeOfDayType))
			switch (kind)
			{
				case TimeOfDayType.production_kind.g_TimeOfDayType_1:
					// traverse syntax tree node associated with production
					// TimeOfDayType: TIME-OF-DAY

						TraverseCommon (p_TimeOfDayType.m_TIME_OF_DAY);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TimeOfDayType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TimeOfDayType

		//
		// create syntax tree node associated with production
		// TimeOfDayType: TIME-OF-DAY

		//

		public TimeOfDayType TimeOfDayType_1 (SyntaxTreeToken p_token)
		{
			TimeOfDayType p_TimeOfDayType_ref = new TimeOfDayType(p_token);
			p_token.parent = p_TimeOfDayType_ref;
			Raise_TimeOfDayType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TimeOfDayType.production_kind.g_TimeOfDayType_1, p_TimeOfDayType_ref);
			return p_TimeOfDayType_ref;
		}
		#endregion
	};
}
