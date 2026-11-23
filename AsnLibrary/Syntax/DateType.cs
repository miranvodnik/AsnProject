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
	// class associated with syntax rule DateType
	//

	[DataContract]
	public class	DateType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DateType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DateType
		{
			g_DateType_1 = 1,	// DATE

		};
		#endregion
		#region production markers associated with the syntax rule DateType

		// markers associated with production: DateType -> DATE

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DateType

		// Constructor declaration(s) associated with production(s) of syntax rule DateType

		//
		// Constructor associated with the following production(s)
		// DateType -> DATE

		//

		public DateType (SyntaxTreeToken p_token) : base ((uint) ProductionID._DateType_ID, (uint) production_kind.g_DateType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DATE = p_token;
		}

		public DateType () { }

		// Copy constructor

		public DateType (DateType p_DateType) : base (p_DateType.id, p_DateType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DateType.appInfo;
			switch ((production_kind) p_DateType.kind)
			{
				case production_kind.g_DateType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DATE = (p_DateType.m_DATE != null) ? new SyntaxTreeToken (p_DateType.m_DATE) : null) != null) m_DATE.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DateType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DateType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DATE?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DateType

		// Content changing function(s) associated with production(s) of syntax rule DateType

		//
		// Content changing function associated with following production(s)
		// DateType -> DATE

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_DateType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DATE = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DateType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DATE != null) && m_DATE.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DateType

		//
		// emit production tree node associated with any production of syntax rule DateType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DateType_1:
					// emit syntax tree node associated with production
					// DateType: DATE

					s += m_DATE.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DateType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DateType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DateType_1:
					// emit syntax tree node associated with production
					// DateType: DATE

					s += "DATE";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DateType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DateType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DateType.production_kind kind = (DateType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DateType.production_kind.g_DateType_1:
					// traverse syntax tree node associated with production
					// DateType: DATE

						m_DATE.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DATE?.reparent (this);
		}

		//
		// initialize object associated with syntax rule DateType
		//

		public void _init ()
		{
			m_DATE = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DateType

		// counter of all nodes associated with syntax rule DateType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DateType
		[DataMember (Name = "m_DATE")] public SyntaxTreeToken m_DATE { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DateType

		// delegate function (callback) prototype associated with syntax rule DateType
		public delegate bool DateType_Callback (SyntaxTreeCallbackReason reason, DateType.production_kind kind, DateType p_DateType);

		// event associated with syntax rule DateType
		public event DateType_Callback DateType_Event;

		// event trigger associated with syntax rule DateType
		public bool Raise_DateType_Event (SyntaxTreeCallbackReason reason, DateType.production_kind kind, DateType p_DateType)
		{
			bool? status = DateType_Event?.Invoke (reason, kind, p_DateType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DateType
		//
		// traverse syntax tree node associated with any production of syntax rule DateType
		//

		public void Traverse (DateType p_DateType)
		{
			if (p_DateType.isLocked())
				return;
			p_DateType.dolock();
			DateType.production_kind kind = (DateType.production_kind) p_DateType.kind;
			p_DateType.turn_reset ();
			if (Raise_DateType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DateType))
			switch (kind)
			{
				case DateType.production_kind.g_DateType_1:
					// traverse syntax tree node associated with production
					// DateType: DATE

				break;
			}
			Raise_DateType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DateType);
			p_DateType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DateType
		//

		public void TraverseCommon (DateType p_DateType)
		{
			DateType.production_kind kind = (DateType.production_kind) p_DateType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DateType))
			switch (kind)
			{
				case DateType.production_kind.g_DateType_1:
					// traverse syntax tree node associated with production
					// DateType: DATE

						TraverseCommon (p_DateType.m_DATE);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DateType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DateType

		//
		// create syntax tree node associated with production
		// DateType: DATE

		//

		public DateType DateType_1 (SyntaxTreeToken p_token)
		{
			DateType p_DateType_ref = new DateType(p_token);
			p_token.parent = p_DateType_ref;
			Raise_DateType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DateType.production_kind.g_DateType_1, p_DateType_ref);
			return p_DateType_ref;
		}
		#endregion
	};
}
