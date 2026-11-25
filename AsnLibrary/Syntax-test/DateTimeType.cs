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
	// class associated with syntax rule DateTimeType
	//

	[DataContract]
	public class	DateTimeType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DateTimeType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DateTimeType
		{
			g_DateTimeType_1 = 1,	// DATE-TIME

		};
		#endregion
		#region production markers associated with the syntax rule DateTimeType

		// markers associated with production: DateTimeType -> DATE-TIME

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DateTimeType

		// Constructor declaration(s) associated with production(s) of syntax rule DateTimeType

		//
		// Constructor associated with the following production(s)
		// DateTimeType -> DATE-TIME

		//

		public DateTimeType (SyntaxTreeToken p_token) : base ((uint) ProductionID._DateTimeType_ID, (uint) production_kind.g_DateTimeType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DATE_TIME = p_token;
		}

		public DateTimeType () { }

		// Copy constructor

		public DateTimeType (DateTimeType p_DateTimeType) : base (p_DateTimeType.id, p_DateTimeType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DateTimeType.appInfo;
			switch ((production_kind) p_DateTimeType.kind)
			{
				case production_kind.g_DateTimeType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DATE_TIME = (p_DateTimeType.m_DATE_TIME != null) ? new SyntaxTreeToken (p_DateTimeType.m_DATE_TIME) : null) != null) m_DATE_TIME.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DateTimeType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DateTimeType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DATE_TIME?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DateTimeType

		// Content changing function(s) associated with production(s) of syntax rule DateTimeType

		//
		// Content changing function associated with following production(s)
		// DateTimeType -> DATE-TIME

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_DateTimeType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DATE_TIME = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DateTimeType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DATE_TIME != null) && m_DATE_TIME.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DateTimeType

		//
		// emit production tree node associated with any production of syntax rule DateTimeType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DateTimeType_1:
					// emit syntax tree node associated with production
					// DateTimeType: DATE-TIME

					s += m_DATE_TIME.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DateTimeType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DateTimeType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DateTimeType_1:
					// emit syntax tree node associated with production
					// DateTimeType: DATE-TIME

					s += "DATE_TIME";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DateTimeType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DateTimeType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DateTimeType.production_kind kind = (DateTimeType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DateTimeType.production_kind.g_DateTimeType_1:
					// traverse syntax tree node associated with production
					// DateTimeType: DATE-TIME

						m_DATE_TIME.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DATE_TIME?.reparent (this);
		}

		//
		// initialize object associated with syntax rule DateTimeType
		//

		public void _init ()
		{
			m_DATE_TIME = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DateTimeType

		// counter of all nodes associated with syntax rule DateTimeType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DateTimeType
		[DataMember (Name = "m_DATE_TIME")] public SyntaxTreeToken m_DATE_TIME { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DateTimeType

		// delegate function (callback) prototype associated with syntax rule DateTimeType
		public delegate bool DateTimeType_Callback (SyntaxTreeCallbackReason reason, DateTimeType.production_kind kind, DateTimeType p_DateTimeType);

		// event associated with syntax rule DateTimeType
		public event DateTimeType_Callback DateTimeType_Event;

		// event trigger associated with syntax rule DateTimeType
		public bool Raise_DateTimeType_Event (SyntaxTreeCallbackReason reason, DateTimeType.production_kind kind, DateTimeType p_DateTimeType)
		{
			bool? status = DateTimeType_Event?.Invoke (reason, kind, p_DateTimeType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DateTimeType
		//
		// traverse syntax tree node associated with any production of syntax rule DateTimeType
		//

		public void Traverse (DateTimeType p_DateTimeType)
		{
			if (p_DateTimeType.isLocked())
				return;
			p_DateTimeType.dolock();
			DateTimeType.production_kind kind = (DateTimeType.production_kind) p_DateTimeType.kind;
			p_DateTimeType.turn_reset ();
			if (Raise_DateTimeType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DateTimeType))
			switch (kind)
			{
				case DateTimeType.production_kind.g_DateTimeType_1:
					// traverse syntax tree node associated with production
					// DateTimeType: DATE-TIME

				break;
			}
			Raise_DateTimeType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DateTimeType);
			p_DateTimeType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DateTimeType
		//

		public void TraverseCommon (DateTimeType p_DateTimeType)
		{
			DateTimeType.production_kind kind = (DateTimeType.production_kind) p_DateTimeType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DateTimeType))
			switch (kind)
			{
				case DateTimeType.production_kind.g_DateTimeType_1:
					// traverse syntax tree node associated with production
					// DateTimeType: DATE-TIME

						TraverseCommon (p_DateTimeType.m_DATE_TIME);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DateTimeType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DateTimeType

		//
		// create syntax tree node associated with production
		// DateTimeType: DATE-TIME

		//

		public DateTimeType DateTimeType_1 (SyntaxTreeToken p_token)
		{
			DateTimeType p_DateTimeType_ref = new DateTimeType(p_token);
			p_token.parent = p_DateTimeType_ref;
			Raise_DateTimeType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DateTimeType.production_kind.g_DateTimeType_1, p_DateTimeType_ref);
			return p_DateTimeType_ref;
		}
		#endregion
	};
}
