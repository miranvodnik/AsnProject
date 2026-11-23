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
	// class associated with syntax rule DurationType
	//

	[DataContract]
	public class	DurationType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DurationType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DurationType
		{
			g_DurationType_1 = 1,	// DURATION

		};
		#endregion
		#region production markers associated with the syntax rule DurationType

		// markers associated with production: DurationType -> DURATION

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DurationType

		// Constructor declaration(s) associated with production(s) of syntax rule DurationType

		//
		// Constructor associated with the following production(s)
		// DurationType -> DURATION

		//

		public DurationType (SyntaxTreeToken p_token) : base ((uint) ProductionID._DurationType_ID, (uint) production_kind.g_DurationType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DURATION = p_token;
		}

		public DurationType () { }

		// Copy constructor

		public DurationType (DurationType p_DurationType) : base (p_DurationType.id, p_DurationType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DurationType.appInfo;
			switch ((production_kind) p_DurationType.kind)
			{
				case production_kind.g_DurationType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DURATION = (p_DurationType.m_DURATION != null) ? new SyntaxTreeToken (p_DurationType.m_DURATION) : null) != null) m_DURATION.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DurationType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DurationType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DURATION?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DurationType

		// Content changing function(s) associated with production(s) of syntax rule DurationType

		//
		// Content changing function associated with following production(s)
		// DurationType -> DURATION

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_DurationType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DURATION = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DurationType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DURATION != null) && m_DURATION.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DurationType

		//
		// emit production tree node associated with any production of syntax rule DurationType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DurationType_1:
					// emit syntax tree node associated with production
					// DurationType: DURATION

					s += m_DURATION.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DurationType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DurationType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DurationType_1:
					// emit syntax tree node associated with production
					// DurationType: DURATION

					s += "DURATION";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DurationType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DurationType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DurationType.production_kind kind = (DurationType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DurationType.production_kind.g_DurationType_1:
					// traverse syntax tree node associated with production
					// DurationType: DURATION

						m_DURATION.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DURATION?.reparent (this);
		}

		//
		// initialize object associated with syntax rule DurationType
		//

		public void _init ()
		{
			m_DURATION = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DurationType

		// counter of all nodes associated with syntax rule DurationType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DurationType
		[DataMember (Name = "m_DURATION")] public SyntaxTreeToken m_DURATION { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DurationType

		// delegate function (callback) prototype associated with syntax rule DurationType
		public delegate bool DurationType_Callback (SyntaxTreeCallbackReason reason, DurationType.production_kind kind, DurationType p_DurationType);

		// event associated with syntax rule DurationType
		public event DurationType_Callback DurationType_Event;

		// event trigger associated with syntax rule DurationType
		public bool Raise_DurationType_Event (SyntaxTreeCallbackReason reason, DurationType.production_kind kind, DurationType p_DurationType)
		{
			bool? status = DurationType_Event?.Invoke (reason, kind, p_DurationType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DurationType
		//
		// traverse syntax tree node associated with any production of syntax rule DurationType
		//

		public void Traverse (DurationType p_DurationType)
		{
			if (p_DurationType.isLocked())
				return;
			p_DurationType.dolock();
			DurationType.production_kind kind = (DurationType.production_kind) p_DurationType.kind;
			p_DurationType.turn_reset ();
			if (Raise_DurationType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DurationType))
			switch (kind)
			{
				case DurationType.production_kind.g_DurationType_1:
					// traverse syntax tree node associated with production
					// DurationType: DURATION

				break;
			}
			Raise_DurationType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DurationType);
			p_DurationType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DurationType
		//

		public void TraverseCommon (DurationType p_DurationType)
		{
			DurationType.production_kind kind = (DurationType.production_kind) p_DurationType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DurationType))
			switch (kind)
			{
				case DurationType.production_kind.g_DurationType_1:
					// traverse syntax tree node associated with production
					// DurationType: DURATION

						TraverseCommon (p_DurationType.m_DURATION);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DurationType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DurationType

		//
		// create syntax tree node associated with production
		// DurationType: DURATION

		//

		public DurationType DurationType_1 (SyntaxTreeToken p_token)
		{
			DurationType p_DurationType_ref = new DurationType(p_token);
			p_token.parent = p_DurationType_ref;
			Raise_DurationType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DurationType.production_kind.g_DurationType_1, p_DurationType_ref);
			return p_DurationType_ref;
		}
		#endregion
	};
}
