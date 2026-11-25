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
	// class associated with syntax rule ExtensionAdditionAlternatives
	//

	[DataContract]
	public class	ExtensionAdditionAlternatives : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExtensionAdditionAlternatives
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExtensionAdditionAlternatives
		{
			g_ExtensionAdditionAlternatives_1 = 1,	// "," ExtensionAdditionAlternativesList

			g_ExtensionAdditionAlternatives_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule ExtensionAdditionAlternatives

		// markers associated with production: ExtensionAdditionAlternatives -> "," ExtensionAdditionAlternativesList

		public enum production_marker_1 : ushort
		{
			m_ExtensionAdditionAlternativesList,
			final
		};

		// markers associated with production: ExtensionAdditionAlternatives -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExtensionAdditionAlternatives

		// Constructor declaration(s) associated with production(s) of syntax rule ExtensionAdditionAlternatives

		//
		// Constructor associated with the following production(s)
		// ExtensionAdditionAlternatives -> "," ExtensionAdditionAlternativesList

		//

		public ExtensionAdditionAlternatives (SyntaxTreeToken p_token, ExtensionAdditionAlternativesList p_ExtensionAdditionAlternativesList) : base ((uint) ProductionID._ExtensionAdditionAlternatives_ID, (uint) production_kind.g_ExtensionAdditionAlternatives_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_comma = p_token;
			children[1] = m_ExtensionAdditionAlternativesList = p_ExtensionAdditionAlternativesList;
		}

		//
		// Constructor associated with the following production(s)
		// ExtensionAdditionAlternatives -> %empty

		//

		public ExtensionAdditionAlternatives () : base ((uint) ProductionID._ExtensionAdditionAlternatives_ID, (uint) production_kind.g_ExtensionAdditionAlternatives_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public ExtensionAdditionAlternatives (ExtensionAdditionAlternatives p_ExtensionAdditionAlternatives) : base (p_ExtensionAdditionAlternatives.id, p_ExtensionAdditionAlternatives.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExtensionAdditionAlternatives.appInfo;
			switch ((production_kind) p_ExtensionAdditionAlternatives.kind)
			{
				case production_kind.g_ExtensionAdditionAlternatives_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_comma = (p_ExtensionAdditionAlternatives.m_comma != null) ? new SyntaxTreeToken (p_ExtensionAdditionAlternatives.m_comma) : null) != null) m_comma.parent = this;
					if ((children [1] = m_ExtensionAdditionAlternativesList = (p_ExtensionAdditionAlternatives.m_ExtensionAdditionAlternativesList != null) ? new ExtensionAdditionAlternativesList (p_ExtensionAdditionAlternatives.m_ExtensionAdditionAlternativesList) : null) != null) m_ExtensionAdditionAlternativesList.parent = this;
					break;
				case production_kind.g_ExtensionAdditionAlternatives_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "ExtensionAdditionAlternatives" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExtensionAdditionAlternatives (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_comma?.Dispose ();
			m_ExtensionAdditionAlternativesList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExtensionAdditionAlternatives

		// Content changing function(s) associated with production(s) of syntax rule ExtensionAdditionAlternatives

		//
		// Content changing function associated with following production(s)
		// ExtensionAdditionAlternatives -> "," ExtensionAdditionAlternativesList

		//

		public void change(SyntaxTreeToken p_token, ExtensionAdditionAlternativesList p_ExtensionAdditionAlternativesList)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExtensionAdditionAlternatives_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_comma = p_token;
			children [1] = m_ExtensionAdditionAlternativesList = p_ExtensionAdditionAlternativesList;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ExtensionAdditionAlternatives -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_ExtensionAdditionAlternatives_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExtensionAdditionAlternatives
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_comma != null) && m_comma.checkInclusion (element) ||
				(m_ExtensionAdditionAlternativesList != null) && m_ExtensionAdditionAlternativesList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExtensionAdditionAlternatives

		//
		// emit production tree node associated with any production of syntax rule ExtensionAdditionAlternatives
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ExtensionAdditionAlternatives_1:
					// emit syntax tree node associated with production
					// ExtensionAdditionAlternatives: "," ExtensionAdditionAlternativesList

					s += m_comma.Emit (depth - 1);
					s += " ";
					s += m_ExtensionAdditionAlternativesList.Emit (depth - 1);
				break;
				case production_kind.g_ExtensionAdditionAlternatives_2:
					// emit syntax tree node associated with production
					// ExtensionAdditionAlternatives: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExtensionAdditionAlternatives
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ExtensionAdditionAlternatives (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ExtensionAdditionAlternatives_1:
					// emit syntax tree node associated with production
					// ExtensionAdditionAlternatives: "," ExtensionAdditionAlternativesList

					s += "comma";
					s += ' ';
					s += m_ExtensionAdditionAlternativesList.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ExtensionAdditionAlternatives_2:
					// emit syntax tree node associated with production
					// ExtensionAdditionAlternatives: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExtensionAdditionAlternatives

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditionAlternatives with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ExtensionAdditionAlternatives.production_kind kind = (ExtensionAdditionAlternatives.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ExtensionAdditionAlternatives.production_kind.g_ExtensionAdditionAlternatives_1:
					// traverse syntax tree node associated with production
					// ExtensionAdditionAlternatives: "," ExtensionAdditionAlternativesList

						m_comma.Visit (visitor, appData);
						m_ExtensionAdditionAlternativesList.Visit (visitor, appData);
				break;
				case ExtensionAdditionAlternatives.production_kind.g_ExtensionAdditionAlternatives_2:
					// traverse syntax tree node associated with production
					// ExtensionAdditionAlternatives: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_comma?.reparent (this);
			m_ExtensionAdditionAlternativesList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ExtensionAdditionAlternatives
		//

		public void _init ()
		{
			m_comma = null;
			m_ExtensionAdditionAlternativesList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExtensionAdditionAlternatives

		// counter of all nodes associated with syntax rule ExtensionAdditionAlternatives
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExtensionAdditionAlternatives
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		[DataMember (Name = "m_ExtensionAdditionAlternativesList")] public ExtensionAdditionAlternativesList m_ExtensionAdditionAlternativesList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExtensionAdditionAlternatives

		// delegate function (callback) prototype associated with syntax rule ExtensionAdditionAlternatives
		public delegate bool ExtensionAdditionAlternatives_Callback (SyntaxTreeCallbackReason reason, ExtensionAdditionAlternatives.production_kind kind, ExtensionAdditionAlternatives p_ExtensionAdditionAlternatives);

		// event associated with syntax rule ExtensionAdditionAlternatives
		public event ExtensionAdditionAlternatives_Callback ExtensionAdditionAlternatives_Event;

		// event trigger associated with syntax rule ExtensionAdditionAlternatives
		public bool Raise_ExtensionAdditionAlternatives_Event (SyntaxTreeCallbackReason reason, ExtensionAdditionAlternatives.production_kind kind, ExtensionAdditionAlternatives p_ExtensionAdditionAlternatives)
		{
			bool? status = ExtensionAdditionAlternatives_Event?.Invoke (reason, kind, p_ExtensionAdditionAlternatives);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExtensionAdditionAlternatives
		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditionAlternatives
		//

		public void Traverse (ExtensionAdditionAlternatives p_ExtensionAdditionAlternatives)
		{
			if (p_ExtensionAdditionAlternatives.isLocked())
				return;
			p_ExtensionAdditionAlternatives.dolock();
			ExtensionAdditionAlternatives.production_kind kind = (ExtensionAdditionAlternatives.production_kind) p_ExtensionAdditionAlternatives.kind;
			p_ExtensionAdditionAlternatives.turn_reset ();
			if (Raise_ExtensionAdditionAlternatives_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ExtensionAdditionAlternatives))
			switch (kind)
			{
				case ExtensionAdditionAlternatives.production_kind.g_ExtensionAdditionAlternatives_1:
					// traverse syntax tree node associated with production
					// ExtensionAdditionAlternatives: "," ExtensionAdditionAlternativesList

					if (Raise_ExtensionAdditionAlternatives_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAdditionAlternatives))
						Traverse (p_ExtensionAdditionAlternatives.m_ExtensionAdditionAlternativesList);
					p_ExtensionAdditionAlternatives.turn_inc ();
					Raise_ExtensionAdditionAlternatives_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAdditionAlternatives);
				break;
				case ExtensionAdditionAlternatives.production_kind.g_ExtensionAdditionAlternatives_2:
					// traverse syntax tree node associated with production
					// ExtensionAdditionAlternatives: %empty

				break;
			}
			Raise_ExtensionAdditionAlternatives_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ExtensionAdditionAlternatives);
			p_ExtensionAdditionAlternatives.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditionAlternatives
		//

		public void TraverseCommon (ExtensionAdditionAlternatives p_ExtensionAdditionAlternatives)
		{
			ExtensionAdditionAlternatives.production_kind kind = (ExtensionAdditionAlternatives.production_kind) p_ExtensionAdditionAlternatives.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ExtensionAdditionAlternatives))
			switch (kind)
			{
				case ExtensionAdditionAlternatives.production_kind.g_ExtensionAdditionAlternatives_1:
					// traverse syntax tree node associated with production
					// ExtensionAdditionAlternatives: "," ExtensionAdditionAlternativesList

						TraverseCommon (p_ExtensionAdditionAlternatives.m_comma);
						TraverseCommon (p_ExtensionAdditionAlternatives.m_ExtensionAdditionAlternativesList);
				break;
				case ExtensionAdditionAlternatives.production_kind.g_ExtensionAdditionAlternatives_2:
					// traverse syntax tree node associated with production
					// ExtensionAdditionAlternatives: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ExtensionAdditionAlternatives);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExtensionAdditionAlternatives

		//
		// create syntax tree node associated with production
		// ExtensionAdditionAlternatives: "," ExtensionAdditionAlternativesList

		//

		public ExtensionAdditionAlternatives ExtensionAdditionAlternatives_1 (SyntaxTreeToken p_token, ExtensionAdditionAlternativesList p_ExtensionAdditionAlternativesList)
		{
			ExtensionAdditionAlternatives p_ExtensionAdditionAlternatives_ref = new ExtensionAdditionAlternatives(p_token, p_ExtensionAdditionAlternativesList);
			p_token.parent = p_ExtensionAdditionAlternatives_ref;
			p_ExtensionAdditionAlternativesList.parent = p_ExtensionAdditionAlternatives_ref;
			Raise_ExtensionAdditionAlternatives_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExtensionAdditionAlternatives.production_kind.g_ExtensionAdditionAlternatives_1, p_ExtensionAdditionAlternatives_ref);
			return p_ExtensionAdditionAlternatives_ref;
		}

		//
		// create syntax tree node associated with production
		// ExtensionAdditionAlternatives: %empty

		//

		public ExtensionAdditionAlternatives ExtensionAdditionAlternatives_2 ()
		{
			ExtensionAdditionAlternatives p_ExtensionAdditionAlternatives_ref = new ExtensionAdditionAlternatives();
			Raise_ExtensionAdditionAlternatives_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExtensionAdditionAlternatives.production_kind.g_ExtensionAdditionAlternatives_2, p_ExtensionAdditionAlternatives_ref);
			return p_ExtensionAdditionAlternatives_ref;
		}
		#endregion
	};
}
