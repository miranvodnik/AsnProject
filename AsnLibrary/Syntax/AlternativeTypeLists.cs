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
	// class associated with syntax rule AlternativeTypeLists
	//

	[DataContract]
	public class	AlternativeTypeLists : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AlternativeTypeLists
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AlternativeTypeLists
		{
			g_AlternativeTypeLists_1 = 1,	// RootAlternativeTypeList

			g_AlternativeTypeLists_2 = 2,	// RootAlternativeTypeList "," ExtensionAndException ExtensionAdditionAlternatives OptionalExtensionMarker

		};
		#endregion
		#region production markers associated with the syntax rule AlternativeTypeLists

		// markers associated with production: AlternativeTypeLists -> RootAlternativeTypeList

		public enum production_marker_1 : ushort
		{
			m_RootAlternativeTypeList,
			final
		};

		// markers associated with production: AlternativeTypeLists -> RootAlternativeTypeList "," ExtensionAndException ExtensionAdditionAlternatives OptionalExtensionMarker

		public enum production_marker_2 : ushort
		{
			m_RootAlternativeTypeList,
			m_ExtensionAndException,
			m_ExtensionAdditionAlternatives,
			m_OptionalExtensionMarker,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AlternativeTypeLists

		// Constructor declaration(s) associated with production(s) of syntax rule AlternativeTypeLists

		//
		// Constructor associated with the following production(s)
		// AlternativeTypeLists -> RootAlternativeTypeList

		//

		public AlternativeTypeLists (RootAlternativeTypeList p_RootAlternativeTypeList) : base ((uint) ProductionID._AlternativeTypeLists_ID, (uint) production_kind.g_AlternativeTypeLists_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_RootAlternativeTypeList = p_RootAlternativeTypeList;
		}

		//
		// Constructor associated with the following production(s)
		// AlternativeTypeLists -> RootAlternativeTypeList "," ExtensionAndException ExtensionAdditionAlternatives OptionalExtensionMarker

		//

		public AlternativeTypeLists (RootAlternativeTypeList p_RootAlternativeTypeList, SyntaxTreeToken p_token, ExtensionAndException p_ExtensionAndException, ExtensionAdditionAlternatives p_ExtensionAdditionAlternatives, OptionalExtensionMarker p_OptionalExtensionMarker) : base ((uint) ProductionID._AlternativeTypeLists_ID, (uint) production_kind.g_AlternativeTypeLists_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children[0] = m_RootAlternativeTypeList = p_RootAlternativeTypeList;
			children[1] = m_comma = p_token;
			children[2] = m_ExtensionAndException = p_ExtensionAndException;
			children[3] = m_ExtensionAdditionAlternatives = p_ExtensionAdditionAlternatives;
			children[4] = m_OptionalExtensionMarker = p_OptionalExtensionMarker;
		}

		public AlternativeTypeLists () { }

		// Copy constructor

		public AlternativeTypeLists (AlternativeTypeLists p_AlternativeTypeLists) : base (p_AlternativeTypeLists.id, p_AlternativeTypeLists.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AlternativeTypeLists.appInfo;
			switch ((production_kind) p_AlternativeTypeLists.kind)
			{
				case production_kind.g_AlternativeTypeLists_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RootAlternativeTypeList = (p_AlternativeTypeLists.m_RootAlternativeTypeList != null) ? new RootAlternativeTypeList (p_AlternativeTypeLists.m_RootAlternativeTypeList) : null) != null) m_RootAlternativeTypeList.parent = this;
					break;
				case production_kind.g_AlternativeTypeLists_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_RootAlternativeTypeList = (p_AlternativeTypeLists.m_RootAlternativeTypeList != null) ? new RootAlternativeTypeList (p_AlternativeTypeLists.m_RootAlternativeTypeList) : null) != null) m_RootAlternativeTypeList.parent = this;
					if ((children [1] = m_comma = (p_AlternativeTypeLists.m_comma != null) ? new SyntaxTreeToken (p_AlternativeTypeLists.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_ExtensionAndException = (p_AlternativeTypeLists.m_ExtensionAndException != null) ? new ExtensionAndException (p_AlternativeTypeLists.m_ExtensionAndException) : null) != null) m_ExtensionAndException.parent = this;
					if ((children [3] = m_ExtensionAdditionAlternatives = (p_AlternativeTypeLists.m_ExtensionAdditionAlternatives != null) ? new ExtensionAdditionAlternatives (p_AlternativeTypeLists.m_ExtensionAdditionAlternatives) : null) != null) m_ExtensionAdditionAlternatives.parent = this;
					if ((children [4] = m_OptionalExtensionMarker = (p_AlternativeTypeLists.m_OptionalExtensionMarker != null) ? new OptionalExtensionMarker (p_AlternativeTypeLists.m_OptionalExtensionMarker) : null) != null) m_OptionalExtensionMarker.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AlternativeTypeLists" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AlternativeTypeLists (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_RootAlternativeTypeList?.Dispose ();
			m_comma?.Dispose ();
			m_ExtensionAndException?.Dispose ();
			m_ExtensionAdditionAlternatives?.Dispose ();
			m_OptionalExtensionMarker?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AlternativeTypeLists

		// Content changing function(s) associated with production(s) of syntax rule AlternativeTypeLists

		//
		// Content changing function associated with following production(s)
		// AlternativeTypeLists -> RootAlternativeTypeList

		//

		public void change(RootAlternativeTypeList p_RootAlternativeTypeList)
		{
			_init ();
			this.kind = (uint) production_kind.g_AlternativeTypeLists_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_RootAlternativeTypeList = p_RootAlternativeTypeList;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AlternativeTypeLists -> RootAlternativeTypeList "," ExtensionAndException ExtensionAdditionAlternatives OptionalExtensionMarker

		//

		public void change(RootAlternativeTypeList p_RootAlternativeTypeList, SyntaxTreeToken p_token, ExtensionAndException p_ExtensionAndException, ExtensionAdditionAlternatives p_ExtensionAdditionAlternatives, OptionalExtensionMarker p_OptionalExtensionMarker)
		{
			_init ();
			this.kind = (uint) production_kind.g_AlternativeTypeLists_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children [0] = m_RootAlternativeTypeList = p_RootAlternativeTypeList;
			children [1] = m_comma = p_token;
			children [2] = m_ExtensionAndException = p_ExtensionAndException;
			children [3] = m_ExtensionAdditionAlternatives = p_ExtensionAdditionAlternatives;
			children [4] = m_OptionalExtensionMarker = p_OptionalExtensionMarker;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AlternativeTypeLists
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_RootAlternativeTypeList != null) && m_RootAlternativeTypeList.checkInclusion (element) ||
				(m_comma != null) && m_comma.checkInclusion (element) ||
				(m_ExtensionAndException != null) && m_ExtensionAndException.checkInclusion (element) ||
				(m_ExtensionAdditionAlternatives != null) && m_ExtensionAdditionAlternatives.checkInclusion (element) ||
				(m_OptionalExtensionMarker != null) && m_OptionalExtensionMarker.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AlternativeTypeLists

		//
		// emit production tree node associated with any production of syntax rule AlternativeTypeLists
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AlternativeTypeLists_1:
					// emit syntax tree node associated with production
					// AlternativeTypeLists: RootAlternativeTypeList

					s += m_RootAlternativeTypeList.Emit (depth - 1);
				break;
				case production_kind.g_AlternativeTypeLists_2:
					// emit syntax tree node associated with production
					// AlternativeTypeLists: RootAlternativeTypeList "," ExtensionAndException ExtensionAdditionAlternatives OptionalExtensionMarker

					s += m_RootAlternativeTypeList.Emit (depth - 1);
					s += " ";
					s += m_comma.Emit (depth - 1);
					s += " ";
					s += m_ExtensionAndException.Emit (depth - 1);
					s += " ";
					s += m_ExtensionAdditionAlternatives.Emit (depth - 1);
					s += " ";
					s += m_OptionalExtensionMarker.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AlternativeTypeLists
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AlternativeTypeLists (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AlternativeTypeLists_1:
					// emit syntax tree node associated with production
					// AlternativeTypeLists: RootAlternativeTypeList

					s += m_RootAlternativeTypeList.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_AlternativeTypeLists_2:
					// emit syntax tree node associated with production
					// AlternativeTypeLists: RootAlternativeTypeList "," ExtensionAndException ExtensionAdditionAlternatives OptionalExtensionMarker

					s += m_RootAlternativeTypeList.EmitProductionTree (depth - 1);
					s += ' ';
					s += "comma";
					s += ' ';
					s += m_ExtensionAndException.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ExtensionAdditionAlternatives.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_OptionalExtensionMarker.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AlternativeTypeLists

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AlternativeTypeLists with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AlternativeTypeLists.production_kind kind = (AlternativeTypeLists.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AlternativeTypeLists.production_kind.g_AlternativeTypeLists_1:
					// traverse syntax tree node associated with production
					// AlternativeTypeLists: RootAlternativeTypeList

						m_RootAlternativeTypeList.Visit (visitor, appData);
				break;
				case AlternativeTypeLists.production_kind.g_AlternativeTypeLists_2:
					// traverse syntax tree node associated with production
					// AlternativeTypeLists: RootAlternativeTypeList "," ExtensionAndException ExtensionAdditionAlternatives OptionalExtensionMarker

						m_RootAlternativeTypeList.Visit (visitor, appData);
						m_comma.Visit (visitor, appData);
						m_ExtensionAndException.Visit (visitor, appData);
						m_ExtensionAdditionAlternatives.Visit (visitor, appData);
						m_OptionalExtensionMarker.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_RootAlternativeTypeList?.reparent (this);
			m_comma?.reparent (this);
			m_ExtensionAndException?.reparent (this);
			m_ExtensionAdditionAlternatives?.reparent (this);
			m_OptionalExtensionMarker?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AlternativeTypeLists
		//

		public void _init ()
		{
			m_RootAlternativeTypeList = null;
			m_comma = null;
			m_ExtensionAndException = null;
			m_ExtensionAdditionAlternatives = null;
			m_OptionalExtensionMarker = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AlternativeTypeLists

		// counter of all nodes associated with syntax rule AlternativeTypeLists
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AlternativeTypeLists
		[DataMember (Name = "m_RootAlternativeTypeList")] public RootAlternativeTypeList m_RootAlternativeTypeList { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		[DataMember (Name = "m_ExtensionAndException")] public ExtensionAndException m_ExtensionAndException { get; private set; }
		[DataMember (Name = "m_ExtensionAdditionAlternatives")] public ExtensionAdditionAlternatives m_ExtensionAdditionAlternatives { get; private set; }
		[DataMember (Name = "m_OptionalExtensionMarker")] public OptionalExtensionMarker m_OptionalExtensionMarker { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AlternativeTypeLists

		// delegate function (callback) prototype associated with syntax rule AlternativeTypeLists
		public delegate bool AlternativeTypeLists_Callback (SyntaxTreeCallbackReason reason, AlternativeTypeLists.production_kind kind, AlternativeTypeLists p_AlternativeTypeLists);

		// event associated with syntax rule AlternativeTypeLists
		public event AlternativeTypeLists_Callback AlternativeTypeLists_Event;

		// event trigger associated with syntax rule AlternativeTypeLists
		public bool Raise_AlternativeTypeLists_Event (SyntaxTreeCallbackReason reason, AlternativeTypeLists.production_kind kind, AlternativeTypeLists p_AlternativeTypeLists)
		{
			bool? status = AlternativeTypeLists_Event?.Invoke (reason, kind, p_AlternativeTypeLists);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AlternativeTypeLists
		//
		// traverse syntax tree node associated with any production of syntax rule AlternativeTypeLists
		//

		public void Traverse (AlternativeTypeLists p_AlternativeTypeLists)
		{
			if (p_AlternativeTypeLists.isLocked())
				return;
			p_AlternativeTypeLists.dolock();
			AlternativeTypeLists.production_kind kind = (AlternativeTypeLists.production_kind) p_AlternativeTypeLists.kind;
			p_AlternativeTypeLists.turn_reset ();
			if (Raise_AlternativeTypeLists_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AlternativeTypeLists))
			switch (kind)
			{
				case AlternativeTypeLists.production_kind.g_AlternativeTypeLists_1:
					// traverse syntax tree node associated with production
					// AlternativeTypeLists: RootAlternativeTypeList

					if (Raise_AlternativeTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AlternativeTypeLists))
						Traverse (p_AlternativeTypeLists.m_RootAlternativeTypeList);
					p_AlternativeTypeLists.turn_inc ();
					Raise_AlternativeTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AlternativeTypeLists);
				break;
				case AlternativeTypeLists.production_kind.g_AlternativeTypeLists_2:
					// traverse syntax tree node associated with production
					// AlternativeTypeLists: RootAlternativeTypeList "," ExtensionAndException ExtensionAdditionAlternatives OptionalExtensionMarker

					if (Raise_AlternativeTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AlternativeTypeLists))
						Traverse (p_AlternativeTypeLists.m_RootAlternativeTypeList);
					p_AlternativeTypeLists.turn_inc ();
					if (Raise_AlternativeTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AlternativeTypeLists))
						Traverse (p_AlternativeTypeLists.m_ExtensionAndException);
					p_AlternativeTypeLists.turn_inc ();
					if (Raise_AlternativeTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AlternativeTypeLists))
						Traverse (p_AlternativeTypeLists.m_ExtensionAdditionAlternatives);
					p_AlternativeTypeLists.turn_inc ();
					if (Raise_AlternativeTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AlternativeTypeLists))
						Traverse (p_AlternativeTypeLists.m_OptionalExtensionMarker);
					p_AlternativeTypeLists.turn_inc ();
					Raise_AlternativeTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AlternativeTypeLists);
				break;
			}
			Raise_AlternativeTypeLists_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AlternativeTypeLists);
			p_AlternativeTypeLists.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AlternativeTypeLists
		//

		public void TraverseCommon (AlternativeTypeLists p_AlternativeTypeLists)
		{
			AlternativeTypeLists.production_kind kind = (AlternativeTypeLists.production_kind) p_AlternativeTypeLists.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AlternativeTypeLists))
			switch (kind)
			{
				case AlternativeTypeLists.production_kind.g_AlternativeTypeLists_1:
					// traverse syntax tree node associated with production
					// AlternativeTypeLists: RootAlternativeTypeList

						TraverseCommon (p_AlternativeTypeLists.m_RootAlternativeTypeList);
				break;
				case AlternativeTypeLists.production_kind.g_AlternativeTypeLists_2:
					// traverse syntax tree node associated with production
					// AlternativeTypeLists: RootAlternativeTypeList "," ExtensionAndException ExtensionAdditionAlternatives OptionalExtensionMarker

						TraverseCommon (p_AlternativeTypeLists.m_RootAlternativeTypeList);
						TraverseCommon (p_AlternativeTypeLists.m_comma);
						TraverseCommon (p_AlternativeTypeLists.m_ExtensionAndException);
						TraverseCommon (p_AlternativeTypeLists.m_ExtensionAdditionAlternatives);
						TraverseCommon (p_AlternativeTypeLists.m_OptionalExtensionMarker);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AlternativeTypeLists);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AlternativeTypeLists

		//
		// create syntax tree node associated with production
		// AlternativeTypeLists: RootAlternativeTypeList

		//

		public AlternativeTypeLists AlternativeTypeLists_1 (RootAlternativeTypeList p_RootAlternativeTypeList)
		{
			AlternativeTypeLists p_AlternativeTypeLists_ref = new AlternativeTypeLists(p_RootAlternativeTypeList);
			p_RootAlternativeTypeList.parent = p_AlternativeTypeLists_ref;
			Raise_AlternativeTypeLists_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AlternativeTypeLists.production_kind.g_AlternativeTypeLists_1, p_AlternativeTypeLists_ref);
			return p_AlternativeTypeLists_ref;
		}

		//
		// create syntax tree node associated with production
		// AlternativeTypeLists: RootAlternativeTypeList "," ExtensionAndException ExtensionAdditionAlternatives OptionalExtensionMarker

		//

		public AlternativeTypeLists AlternativeTypeLists_2 (RootAlternativeTypeList p_RootAlternativeTypeList, SyntaxTreeToken p_token, ExtensionAndException p_ExtensionAndException, ExtensionAdditionAlternatives p_ExtensionAdditionAlternatives, OptionalExtensionMarker p_OptionalExtensionMarker)
		{
			AlternativeTypeLists p_AlternativeTypeLists_ref = new AlternativeTypeLists(p_RootAlternativeTypeList, p_token, p_ExtensionAndException, p_ExtensionAdditionAlternatives, p_OptionalExtensionMarker);
			p_RootAlternativeTypeList.parent = p_AlternativeTypeLists_ref;
			p_token.parent = p_AlternativeTypeLists_ref;
			p_ExtensionAndException.parent = p_AlternativeTypeLists_ref;
			p_ExtensionAdditionAlternatives.parent = p_AlternativeTypeLists_ref;
			p_OptionalExtensionMarker.parent = p_AlternativeTypeLists_ref;
			Raise_AlternativeTypeLists_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AlternativeTypeLists.production_kind.g_AlternativeTypeLists_2, p_AlternativeTypeLists_ref);
			return p_AlternativeTypeLists_ref;
		}
		#endregion
	};
}
