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
	// class associated with syntax rule TimeValue
	//

	[DataContract]
	public class	TimeValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TimeValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TimeValue
		{
			g_TimeValue_1 = 1,	// tstring

		};
		#endregion
		#region production markers associated with the syntax rule TimeValue

		// markers associated with production: TimeValue -> tstring

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TimeValue

		// Constructor declaration(s) associated with production(s) of syntax rule TimeValue

		//
		// Constructor associated with the following production(s)
		// TimeValue -> tstring

		//

		public TimeValue (SyntaxTreeToken p_token) : base ((uint) ProductionID._TimeValue_ID, (uint) production_kind.g_TimeValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_tstring = p_token;
		}

		public TimeValue () { }

		// Copy constructor

		public TimeValue (TimeValue p_TimeValue) : base (p_TimeValue.id, p_TimeValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TimeValue.appInfo;
			switch ((production_kind) p_TimeValue.kind)
			{
				case production_kind.g_TimeValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_tstring = (p_TimeValue.m_tstring != null) ? new SyntaxTreeToken (p_TimeValue.m_tstring) : null) != null) m_tstring.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TimeValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TimeValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_tstring?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TimeValue

		// Content changing function(s) associated with production(s) of syntax rule TimeValue

		//
		// Content changing function associated with following production(s)
		// TimeValue -> tstring

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_TimeValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_tstring = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TimeValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_tstring != null) && m_tstring.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TimeValue

		//
		// emit production tree node associated with any production of syntax rule TimeValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TimeValue_1:
					// emit syntax tree node associated with production
					// TimeValue: tstring

					s += m_tstring.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TimeValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TimeValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TimeValue_1:
					// emit syntax tree node associated with production
					// TimeValue: tstring

					s += "tstring";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TimeValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TimeValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TimeValue.production_kind kind = (TimeValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TimeValue.production_kind.g_TimeValue_1:
					// traverse syntax tree node associated with production
					// TimeValue: tstring

						m_tstring.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_tstring?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TimeValue
		//

		public void _init ()
		{
			m_tstring = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TimeValue

		// counter of all nodes associated with syntax rule TimeValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TimeValue
		[DataMember (Name = "m_tstring")] public SyntaxTreeToken m_tstring { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TimeValue

		// delegate function (callback) prototype associated with syntax rule TimeValue
		public delegate bool TimeValue_Callback (SyntaxTreeCallbackReason reason, TimeValue.production_kind kind, TimeValue p_TimeValue);

		// event associated with syntax rule TimeValue
		public event TimeValue_Callback TimeValue_Event;

		// event trigger associated with syntax rule TimeValue
		public bool Raise_TimeValue_Event (SyntaxTreeCallbackReason reason, TimeValue.production_kind kind, TimeValue p_TimeValue)
		{
			bool? status = TimeValue_Event?.Invoke (reason, kind, p_TimeValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TimeValue
		//
		// traverse syntax tree node associated with any production of syntax rule TimeValue
		//

		public void Traverse (TimeValue p_TimeValue)
		{
			if (p_TimeValue.isLocked())
				return;
			p_TimeValue.dolock();
			TimeValue.production_kind kind = (TimeValue.production_kind) p_TimeValue.kind;
			p_TimeValue.turn_reset ();
			if (Raise_TimeValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TimeValue))
			switch (kind)
			{
				case TimeValue.production_kind.g_TimeValue_1:
					// traverse syntax tree node associated with production
					// TimeValue: tstring

				break;
			}
			Raise_TimeValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TimeValue);
			p_TimeValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TimeValue
		//

		public void TraverseCommon (TimeValue p_TimeValue)
		{
			TimeValue.production_kind kind = (TimeValue.production_kind) p_TimeValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TimeValue))
			switch (kind)
			{
				case TimeValue.production_kind.g_TimeValue_1:
					// traverse syntax tree node associated with production
					// TimeValue: tstring

						TraverseCommon (p_TimeValue.m_tstring);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TimeValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TimeValue

		//
		// create syntax tree node associated with production
		// TimeValue: tstring

		//

		public TimeValue TimeValue_1 (SyntaxTreeToken p_token)
		{
			TimeValue p_TimeValue_ref = new TimeValue(p_token);
			p_token.parent = p_TimeValue_ref;
			Raise_TimeValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TimeValue.production_kind.g_TimeValue_1, p_TimeValue_ref);
			return p_TimeValue_ref;
		}
		#endregion
	};
}
