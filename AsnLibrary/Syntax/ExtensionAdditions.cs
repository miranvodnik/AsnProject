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
	// class associated with syntax rule ExtensionAdditions
	//

	[DataContract]
	public class	ExtensionAdditions : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExtensionAdditions
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExtensionAdditions
		{
			g_ExtensionAdditions_1 = 1,	// "," ExtensionAdditionList

			g_ExtensionAdditions_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule ExtensionAdditions

		// markers associated with production: ExtensionAdditions -> "," ExtensionAdditionList

		public enum production_marker_1 : ushort
		{
			m_ExtensionAdditionList,
			final
		};

		// markers associated with production: ExtensionAdditions -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExtensionAdditions

		// Constructor declaration(s) associated with production(s) of syntax rule ExtensionAdditions

		//
		// Constructor associated with the following production(s)
		// ExtensionAdditions -> "," ExtensionAdditionList

		//

		public ExtensionAdditions (SyntaxTreeToken p_token, ExtensionAdditionList p_ExtensionAdditionList) : base ((uint) ProductionID._ExtensionAdditions_ID, (uint) production_kind.g_ExtensionAdditions_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_comma = p_token;
			children[1] = m_ExtensionAdditionList = p_ExtensionAdditionList;
		}

		//
		// Constructor associated with the following production(s)
		// ExtensionAdditions -> %empty

		//

		public ExtensionAdditions () : base ((uint) ProductionID._ExtensionAdditions_ID, (uint) production_kind.g_ExtensionAdditions_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public ExtensionAdditions (ExtensionAdditions p_ExtensionAdditions) : base (p_ExtensionAdditions.id, p_ExtensionAdditions.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExtensionAdditions.appInfo;
			switch ((production_kind) p_ExtensionAdditions.kind)
			{
				case production_kind.g_ExtensionAdditions_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_comma = (p_ExtensionAdditions.m_comma != null) ? new SyntaxTreeToken (p_ExtensionAdditions.m_comma) : null) != null) m_comma.parent = this;
					if ((children [1] = m_ExtensionAdditionList = (p_ExtensionAdditions.m_ExtensionAdditionList != null) ? new ExtensionAdditionList (p_ExtensionAdditions.m_ExtensionAdditionList) : null) != null) m_ExtensionAdditionList.parent = this;
					break;
				case production_kind.g_ExtensionAdditions_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "ExtensionAdditions" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExtensionAdditions (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_comma?.Dispose ();
			m_ExtensionAdditionList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExtensionAdditions

		// Content changing function(s) associated with production(s) of syntax rule ExtensionAdditions

		//
		// Content changing function associated with following production(s)
		// ExtensionAdditions -> "," ExtensionAdditionList

		//

		public void change(SyntaxTreeToken p_token, ExtensionAdditionList p_ExtensionAdditionList)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExtensionAdditions_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_comma = p_token;
			children [1] = m_ExtensionAdditionList = p_ExtensionAdditionList;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ExtensionAdditions -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_ExtensionAdditions_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExtensionAdditions
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_comma != null) && m_comma.checkInclusion (element) ||
				(m_ExtensionAdditionList != null) && m_ExtensionAdditionList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExtensionAdditions

		//
		// emit production tree node associated with any production of syntax rule ExtensionAdditions
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ExtensionAdditions_1:
					// emit syntax tree node associated with production
					// ExtensionAdditions: "," ExtensionAdditionList

					s += m_comma.Emit (depth - 1);
					s += " ";
					s += m_ExtensionAdditionList.Emit (depth - 1);
				break;
				case production_kind.g_ExtensionAdditions_2:
					// emit syntax tree node associated with production
					// ExtensionAdditions: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExtensionAdditions
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ExtensionAdditions (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ExtensionAdditions_1:
					// emit syntax tree node associated with production
					// ExtensionAdditions: "," ExtensionAdditionList

					s += "comma";
					s += ' ';
					s += m_ExtensionAdditionList.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ExtensionAdditions_2:
					// emit syntax tree node associated with production
					// ExtensionAdditions: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExtensionAdditions

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditions with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ExtensionAdditions.production_kind kind = (ExtensionAdditions.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ExtensionAdditions.production_kind.g_ExtensionAdditions_1:
					// traverse syntax tree node associated with production
					// ExtensionAdditions: "," ExtensionAdditionList

						m_comma.Visit (visitor, appData);
						m_ExtensionAdditionList.Visit (visitor, appData);
				break;
				case ExtensionAdditions.production_kind.g_ExtensionAdditions_2:
					// traverse syntax tree node associated with production
					// ExtensionAdditions: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_comma?.reparent (this);
			m_ExtensionAdditionList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ExtensionAdditions
		//

		public void _init ()
		{
			m_comma = null;
			m_ExtensionAdditionList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExtensionAdditions

		// counter of all nodes associated with syntax rule ExtensionAdditions
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExtensionAdditions
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		[DataMember (Name = "m_ExtensionAdditionList")] public ExtensionAdditionList m_ExtensionAdditionList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExtensionAdditions

		// delegate function (callback) prototype associated with syntax rule ExtensionAdditions
		public delegate bool ExtensionAdditions_Callback (SyntaxTreeCallbackReason reason, ExtensionAdditions.production_kind kind, ExtensionAdditions p_ExtensionAdditions);

		// event associated with syntax rule ExtensionAdditions
		public event ExtensionAdditions_Callback ExtensionAdditions_Event;

		// event trigger associated with syntax rule ExtensionAdditions
		public bool Raise_ExtensionAdditions_Event (SyntaxTreeCallbackReason reason, ExtensionAdditions.production_kind kind, ExtensionAdditions p_ExtensionAdditions)
		{
			bool? status = ExtensionAdditions_Event?.Invoke (reason, kind, p_ExtensionAdditions);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExtensionAdditions
		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditions
		//

		public void Traverse (ExtensionAdditions p_ExtensionAdditions)
		{
			if (p_ExtensionAdditions.isLocked())
				return;
			p_ExtensionAdditions.dolock();
			ExtensionAdditions.production_kind kind = (ExtensionAdditions.production_kind) p_ExtensionAdditions.kind;
			p_ExtensionAdditions.turn_reset ();
			if (Raise_ExtensionAdditions_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ExtensionAdditions))
			switch (kind)
			{
				case ExtensionAdditions.production_kind.g_ExtensionAdditions_1:
					// traverse syntax tree node associated with production
					// ExtensionAdditions: "," ExtensionAdditionList

					if (Raise_ExtensionAdditions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAdditions))
						Traverse (p_ExtensionAdditions.m_ExtensionAdditionList);
					p_ExtensionAdditions.turn_inc ();
					Raise_ExtensionAdditions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAdditions);
				break;
				case ExtensionAdditions.production_kind.g_ExtensionAdditions_2:
					// traverse syntax tree node associated with production
					// ExtensionAdditions: %empty

				break;
			}
			Raise_ExtensionAdditions_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ExtensionAdditions);
			p_ExtensionAdditions.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditions
		//

		public void TraverseCommon (ExtensionAdditions p_ExtensionAdditions)
		{
			ExtensionAdditions.production_kind kind = (ExtensionAdditions.production_kind) p_ExtensionAdditions.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ExtensionAdditions))
			switch (kind)
			{
				case ExtensionAdditions.production_kind.g_ExtensionAdditions_1:
					// traverse syntax tree node associated with production
					// ExtensionAdditions: "," ExtensionAdditionList

						TraverseCommon (p_ExtensionAdditions.m_comma);
						TraverseCommon (p_ExtensionAdditions.m_ExtensionAdditionList);
				break;
				case ExtensionAdditions.production_kind.g_ExtensionAdditions_2:
					// traverse syntax tree node associated with production
					// ExtensionAdditions: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ExtensionAdditions);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExtensionAdditions

		//
		// create syntax tree node associated with production
		// ExtensionAdditions: "," ExtensionAdditionList

		//

		public ExtensionAdditions ExtensionAdditions_1 (SyntaxTreeToken p_token, ExtensionAdditionList p_ExtensionAdditionList)
		{
			ExtensionAdditions p_ExtensionAdditions_ref = new ExtensionAdditions(p_token, p_ExtensionAdditionList);
			p_token.parent = p_ExtensionAdditions_ref;
			p_ExtensionAdditionList.parent = p_ExtensionAdditions_ref;
			Raise_ExtensionAdditions_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExtensionAdditions.production_kind.g_ExtensionAdditions_1, p_ExtensionAdditions_ref);
			return p_ExtensionAdditions_ref;
		}

		//
		// create syntax tree node associated with production
		// ExtensionAdditions: %empty

		//

		public ExtensionAdditions ExtensionAdditions_2 ()
		{
			ExtensionAdditions p_ExtensionAdditions_ref = new ExtensionAdditions();
			Raise_ExtensionAdditions_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExtensionAdditions.production_kind.g_ExtensionAdditions_2, p_ExtensionAdditions_ref);
			return p_ExtensionAdditions_ref;
		}
		#endregion
	};
}
