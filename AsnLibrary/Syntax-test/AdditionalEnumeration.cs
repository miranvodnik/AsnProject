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
	// class associated with syntax rule AdditionalEnumeration
	//

	[DataContract]
	public class	AdditionalEnumeration : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AdditionalEnumeration
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AdditionalEnumeration
		{
			g_AdditionalEnumeration_1 = 1,	// Enumeration

		};
		#endregion
		#region production markers associated with the syntax rule AdditionalEnumeration

		// markers associated with production: AdditionalEnumeration -> Enumeration

		public enum production_marker_1 : ushort
		{
			m_Enumeration,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AdditionalEnumeration

		// Constructor declaration(s) associated with production(s) of syntax rule AdditionalEnumeration

		//
		// Constructor associated with the following production(s)
		// AdditionalEnumeration -> Enumeration

		//

		public AdditionalEnumeration (Enumeration p_Enumeration) : base ((uint) ProductionID._AdditionalEnumeration_ID, (uint) production_kind.g_AdditionalEnumeration_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Enumeration = p_Enumeration;
		}

		public AdditionalEnumeration () { }

		// Copy constructor

		public AdditionalEnumeration (AdditionalEnumeration p_AdditionalEnumeration) : base (p_AdditionalEnumeration.id, p_AdditionalEnumeration.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AdditionalEnumeration.appInfo;
			switch ((production_kind) p_AdditionalEnumeration.kind)
			{
				case production_kind.g_AdditionalEnumeration_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Enumeration = (p_AdditionalEnumeration.m_Enumeration != null) ? new Enumeration (p_AdditionalEnumeration.m_Enumeration) : null) != null) m_Enumeration.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AdditionalEnumeration" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AdditionalEnumeration (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Enumeration?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AdditionalEnumeration

		// Content changing function(s) associated with production(s) of syntax rule AdditionalEnumeration

		//
		// Content changing function associated with following production(s)
		// AdditionalEnumeration -> Enumeration

		//

		public void change(Enumeration p_Enumeration)
		{
			_init ();
			this.kind = (uint) production_kind.g_AdditionalEnumeration_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Enumeration = p_Enumeration;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AdditionalEnumeration
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Enumeration != null) && m_Enumeration.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AdditionalEnumeration

		//
		// emit production tree node associated with any production of syntax rule AdditionalEnumeration
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AdditionalEnumeration_1:
					// emit syntax tree node associated with production
					// AdditionalEnumeration: Enumeration

					s += m_Enumeration.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AdditionalEnumeration
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AdditionalEnumeration (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AdditionalEnumeration_1:
					// emit syntax tree node associated with production
					// AdditionalEnumeration: Enumeration

					s += m_Enumeration.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AdditionalEnumeration

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AdditionalEnumeration with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AdditionalEnumeration.production_kind kind = (AdditionalEnumeration.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AdditionalEnumeration.production_kind.g_AdditionalEnumeration_1:
					// traverse syntax tree node associated with production
					// AdditionalEnumeration: Enumeration

						m_Enumeration.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Enumeration?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AdditionalEnumeration
		//

		public void _init ()
		{
			m_Enumeration = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AdditionalEnumeration

		// counter of all nodes associated with syntax rule AdditionalEnumeration
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AdditionalEnumeration
		[DataMember (Name = "m_Enumeration")] public Enumeration m_Enumeration { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AdditionalEnumeration

		// delegate function (callback) prototype associated with syntax rule AdditionalEnumeration
		public delegate bool AdditionalEnumeration_Callback (SyntaxTreeCallbackReason reason, AdditionalEnumeration.production_kind kind, AdditionalEnumeration p_AdditionalEnumeration);

		// event associated with syntax rule AdditionalEnumeration
		public event AdditionalEnumeration_Callback AdditionalEnumeration_Event;

		// event trigger associated with syntax rule AdditionalEnumeration
		public bool Raise_AdditionalEnumeration_Event (SyntaxTreeCallbackReason reason, AdditionalEnumeration.production_kind kind, AdditionalEnumeration p_AdditionalEnumeration)
		{
			bool? status = AdditionalEnumeration_Event?.Invoke (reason, kind, p_AdditionalEnumeration);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AdditionalEnumeration
		//
		// traverse syntax tree node associated with any production of syntax rule AdditionalEnumeration
		//

		public void Traverse (AdditionalEnumeration p_AdditionalEnumeration)
		{
			if (p_AdditionalEnumeration.isLocked())
				return;
			p_AdditionalEnumeration.dolock();
			AdditionalEnumeration.production_kind kind = (AdditionalEnumeration.production_kind) p_AdditionalEnumeration.kind;
			p_AdditionalEnumeration.turn_reset ();
			if (Raise_AdditionalEnumeration_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AdditionalEnumeration))
			switch (kind)
			{
				case AdditionalEnumeration.production_kind.g_AdditionalEnumeration_1:
					// traverse syntax tree node associated with production
					// AdditionalEnumeration: Enumeration

					if (Raise_AdditionalEnumeration_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AdditionalEnumeration))
						Traverse (p_AdditionalEnumeration.m_Enumeration);
					p_AdditionalEnumeration.turn_inc ();
					Raise_AdditionalEnumeration_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AdditionalEnumeration);
				break;
			}
			Raise_AdditionalEnumeration_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AdditionalEnumeration);
			p_AdditionalEnumeration.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AdditionalEnumeration
		//

		public void TraverseCommon (AdditionalEnumeration p_AdditionalEnumeration)
		{
			AdditionalEnumeration.production_kind kind = (AdditionalEnumeration.production_kind) p_AdditionalEnumeration.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AdditionalEnumeration))
			switch (kind)
			{
				case AdditionalEnumeration.production_kind.g_AdditionalEnumeration_1:
					// traverse syntax tree node associated with production
					// AdditionalEnumeration: Enumeration

						TraverseCommon (p_AdditionalEnumeration.m_Enumeration);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AdditionalEnumeration);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AdditionalEnumeration

		//
		// create syntax tree node associated with production
		// AdditionalEnumeration: Enumeration

		//

		public AdditionalEnumeration AdditionalEnumeration_1 (Enumeration p_Enumeration)
		{
			AdditionalEnumeration p_AdditionalEnumeration_ref = new AdditionalEnumeration(p_Enumeration);
			p_Enumeration.parent = p_AdditionalEnumeration_ref;
			Raise_AdditionalEnumeration_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AdditionalEnumeration.production_kind.g_AdditionalEnumeration_1, p_AdditionalEnumeration_ref);
			return p_AdditionalEnumeration_ref;
		}
		#endregion
	};
}
