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
	// class associated with syntax rule EnumerationItem
	//

	[DataContract]
	public class	EnumerationItem : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule EnumerationItem
		public enum production_kind : ushort	// enumerated production(s) of syntax rule EnumerationItem
		{
			g_EnumerationItem_1 = 1,	// identifier-token

			g_EnumerationItem_2 = 2,	// NamedNumber

		};
		#endregion
		#region production markers associated with the syntax rule EnumerationItem

		// markers associated with production: EnumerationItem -> identifier-token

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};

		// markers associated with production: EnumerationItem -> NamedNumber

		public enum production_marker_2 : ushort
		{
			m_NamedNumber,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule EnumerationItem

		// Constructor declaration(s) associated with production(s) of syntax rule EnumerationItem

		//
		// Constructor associated with the following production(s)
		// EnumerationItem -> identifier-token

		//

		public EnumerationItem (identifier_token p_identifier_token) : base ((uint) ProductionID._EnumerationItem_ID, (uint) production_kind.g_EnumerationItem_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_identifier_token = p_identifier_token;
		}

		//
		// Constructor associated with the following production(s)
		// EnumerationItem -> NamedNumber

		//

		public EnumerationItem (NamedNumber p_NamedNumber) : base ((uint) ProductionID._EnumerationItem_ID, (uint) production_kind.g_EnumerationItem_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NamedNumber = p_NamedNumber;
		}

		public EnumerationItem () { }

		// Copy constructor

		public EnumerationItem (EnumerationItem p_EnumerationItem) : base (p_EnumerationItem.id, p_EnumerationItem.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_EnumerationItem.appInfo;
			switch ((production_kind) p_EnumerationItem.kind)
			{
				case production_kind.g_EnumerationItem_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_identifier_token = (p_EnumerationItem.m_identifier_token != null) ? new identifier_token (p_EnumerationItem.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				case production_kind.g_EnumerationItem_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NamedNumber = (p_EnumerationItem.m_NamedNumber != null) ? new NamedNumber (p_EnumerationItem.m_NamedNumber) : null) != null) m_NamedNumber.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "EnumerationItem" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new EnumerationItem (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();
			m_NamedNumber?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule EnumerationItem

		// Content changing function(s) associated with production(s) of syntax rule EnumerationItem

		//
		// Content changing function associated with following production(s)
		// EnumerationItem -> identifier-token

		//

		public void change(identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_EnumerationItem_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// EnumerationItem -> NamedNumber

		//

		public void change(NamedNumber p_NamedNumber)
		{
			_init ();
			this.kind = (uint) production_kind.g_EnumerationItem_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NamedNumber = p_NamedNumber;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule EnumerationItem
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				(m_NamedNumber != null) && m_NamedNumber.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule EnumerationItem

		//
		// emit production tree node associated with any production of syntax rule EnumerationItem
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_EnumerationItem_1:
					// emit syntax tree node associated with production
					// EnumerationItem: identifier-token

					s += m_identifier_token.Emit (depth - 1);
				break;
				case production_kind.g_EnumerationItem_2:
					// emit syntax tree node associated with production
					// EnumerationItem: NamedNumber

					s += m_NamedNumber.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule EnumerationItem
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "EnumerationItem (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_EnumerationItem_1:
					// emit syntax tree node associated with production
					// EnumerationItem: identifier-token

					s += m_identifier_token.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_EnumerationItem_2:
					// emit syntax tree node associated with production
					// EnumerationItem: NamedNumber

					s += m_NamedNumber.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule EnumerationItem

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule EnumerationItem with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			EnumerationItem.production_kind kind = (EnumerationItem.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case EnumerationItem.production_kind.g_EnumerationItem_1:
					// traverse syntax tree node associated with production
					// EnumerationItem: identifier-token

						m_identifier_token.Visit (visitor, appData);
				break;
				case EnumerationItem.production_kind.g_EnumerationItem_2:
					// traverse syntax tree node associated with production
					// EnumerationItem: NamedNumber

						m_NamedNumber.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_identifier_token?.reparent (this);
			m_NamedNumber?.reparent (this);
		}

		//
		// initialize object associated with syntax rule EnumerationItem
		//

		public void _init ()
		{
			m_identifier_token = null;
			m_NamedNumber = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule EnumerationItem

		// counter of all nodes associated with syntax rule EnumerationItem
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule EnumerationItem
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_NamedNumber")] public NamedNumber m_NamedNumber { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule EnumerationItem

		// delegate function (callback) prototype associated with syntax rule EnumerationItem
		public delegate bool EnumerationItem_Callback (SyntaxTreeCallbackReason reason, EnumerationItem.production_kind kind, EnumerationItem p_EnumerationItem);

		// event associated with syntax rule EnumerationItem
		public event EnumerationItem_Callback EnumerationItem_Event;

		// event trigger associated with syntax rule EnumerationItem
		public bool Raise_EnumerationItem_Event (SyntaxTreeCallbackReason reason, EnumerationItem.production_kind kind, EnumerationItem p_EnumerationItem)
		{
			bool? status = EnumerationItem_Event?.Invoke (reason, kind, p_EnumerationItem);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule EnumerationItem
		//
		// traverse syntax tree node associated with any production of syntax rule EnumerationItem
		//

		public void Traverse (EnumerationItem p_EnumerationItem)
		{
			if (p_EnumerationItem.isLocked())
				return;
			p_EnumerationItem.dolock();
			EnumerationItem.production_kind kind = (EnumerationItem.production_kind) p_EnumerationItem.kind;
			p_EnumerationItem.turn_reset ();
			if (Raise_EnumerationItem_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_EnumerationItem))
			switch (kind)
			{
				case EnumerationItem.production_kind.g_EnumerationItem_1:
					// traverse syntax tree node associated with production
					// EnumerationItem: identifier-token

					if (Raise_EnumerationItem_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EnumerationItem))
						Traverse (p_EnumerationItem.m_identifier_token);
					p_EnumerationItem.turn_inc ();
					Raise_EnumerationItem_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EnumerationItem);
				break;
				case EnumerationItem.production_kind.g_EnumerationItem_2:
					// traverse syntax tree node associated with production
					// EnumerationItem: NamedNumber

					if (Raise_EnumerationItem_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EnumerationItem))
						Traverse (p_EnumerationItem.m_NamedNumber);
					p_EnumerationItem.turn_inc ();
					Raise_EnumerationItem_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EnumerationItem);
				break;
			}
			Raise_EnumerationItem_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_EnumerationItem);
			p_EnumerationItem.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule EnumerationItem
		//

		public void TraverseCommon (EnumerationItem p_EnumerationItem)
		{
			EnumerationItem.production_kind kind = (EnumerationItem.production_kind) p_EnumerationItem.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_EnumerationItem))
			switch (kind)
			{
				case EnumerationItem.production_kind.g_EnumerationItem_1:
					// traverse syntax tree node associated with production
					// EnumerationItem: identifier-token

						TraverseCommon (p_EnumerationItem.m_identifier_token);
				break;
				case EnumerationItem.production_kind.g_EnumerationItem_2:
					// traverse syntax tree node associated with production
					// EnumerationItem: NamedNumber

						TraverseCommon (p_EnumerationItem.m_NamedNumber);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_EnumerationItem);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule EnumerationItem

		//
		// create syntax tree node associated with production
		// EnumerationItem: identifier-token

		//

		public EnumerationItem EnumerationItem_1 (identifier_token p_identifier_token)
		{
			EnumerationItem p_EnumerationItem_ref = new EnumerationItem(p_identifier_token);
			p_identifier_token.parent = p_EnumerationItem_ref;
			Raise_EnumerationItem_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EnumerationItem.production_kind.g_EnumerationItem_1, p_EnumerationItem_ref);
			return p_EnumerationItem_ref;
		}

		//
		// create syntax tree node associated with production
		// EnumerationItem: NamedNumber

		//

		public EnumerationItem EnumerationItem_2 (NamedNumber p_NamedNumber)
		{
			EnumerationItem p_EnumerationItem_ref = new EnumerationItem(p_NamedNumber);
			p_NamedNumber.parent = p_EnumerationItem_ref;
			Raise_EnumerationItem_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EnumerationItem.production_kind.g_EnumerationItem_2, p_EnumerationItem_ref);
			return p_EnumerationItem_ref;
		}
		#endregion
	};
}
