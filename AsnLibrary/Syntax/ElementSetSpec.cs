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
	// class associated with syntax rule ElementSetSpec
	//

	[DataContract]
	public class	ElementSetSpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ElementSetSpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ElementSetSpec
		{
			g_ElementSetSpec_1 = 1,	// Unions

			g_ElementSetSpec_2 = 2,	// ALL Exclusions

		};
		#endregion
		#region production markers associated with the syntax rule ElementSetSpec

		// markers associated with production: ElementSetSpec -> Unions

		public enum production_marker_1 : ushort
		{
			m_Unions,
			final
		};

		// markers associated with production: ElementSetSpec -> ALL Exclusions

		public enum production_marker_2 : ushort
		{
			m_Exclusions,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ElementSetSpec

		// Constructor declaration(s) associated with production(s) of syntax rule ElementSetSpec

		//
		// Constructor associated with the following production(s)
		// ElementSetSpec -> Unions

		//

		public ElementSetSpec (Unions p_Unions) : base ((uint) ProductionID._ElementSetSpec_ID, (uint) production_kind.g_ElementSetSpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Unions = p_Unions;
		}

		//
		// Constructor associated with the following production(s)
		// ElementSetSpec -> ALL Exclusions

		//

		public ElementSetSpec (SyntaxTreeToken p_token, Exclusions p_Exclusions) : base ((uint) ProductionID._ElementSetSpec_ID, (uint) production_kind.g_ElementSetSpec_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ALL = p_token;
			children[1] = m_Exclusions = p_Exclusions;
		}

		public ElementSetSpec () { }

		// Copy constructor

		public ElementSetSpec (ElementSetSpec p_ElementSetSpec) : base (p_ElementSetSpec.id, p_ElementSetSpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ElementSetSpec.appInfo;
			switch ((production_kind) p_ElementSetSpec.kind)
			{
				case production_kind.g_ElementSetSpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Unions = (p_ElementSetSpec.m_Unions != null) ? new Unions (p_ElementSetSpec.m_Unions) : null) != null) m_Unions.parent = this;
					break;
				case production_kind.g_ElementSetSpec_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ALL = (p_ElementSetSpec.m_ALL != null) ? new SyntaxTreeToken (p_ElementSetSpec.m_ALL) : null) != null) m_ALL.parent = this;
					if ((children [1] = m_Exclusions = (p_ElementSetSpec.m_Exclusions != null) ? new Exclusions (p_ElementSetSpec.m_Exclusions) : null) != null) m_Exclusions.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ElementSetSpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ElementSetSpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Unions?.Dispose ();
			m_ALL?.Dispose ();
			m_Exclusions?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ElementSetSpec

		// Content changing function(s) associated with production(s) of syntax rule ElementSetSpec

		//
		// Content changing function associated with following production(s)
		// ElementSetSpec -> Unions

		//

		public void change(Unions p_Unions)
		{
			_init ();
			this.kind = (uint) production_kind.g_ElementSetSpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Unions = p_Unions;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ElementSetSpec -> ALL Exclusions

		//

		public void change(SyntaxTreeToken p_token, Exclusions p_Exclusions)
		{
			_init ();
			this.kind = (uint) production_kind.g_ElementSetSpec_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ALL = p_token;
			children [1] = m_Exclusions = p_Exclusions;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ElementSetSpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Unions != null) && m_Unions.checkInclusion (element) ||
				(m_ALL != null) && m_ALL.checkInclusion (element) ||
				(m_Exclusions != null) && m_Exclusions.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ElementSetSpec

		//
		// emit production tree node associated with any production of syntax rule ElementSetSpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ElementSetSpec_1:
					// emit syntax tree node associated with production
					// ElementSetSpec: Unions

					s += m_Unions.Emit (depth - 1);
				break;
				case production_kind.g_ElementSetSpec_2:
					// emit syntax tree node associated with production
					// ElementSetSpec: ALL Exclusions

					s += m_ALL.Emit (depth - 1);
					s += " ";
					s += m_Exclusions.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ElementSetSpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ElementSetSpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ElementSetSpec_1:
					// emit syntax tree node associated with production
					// ElementSetSpec: Unions

					s += m_Unions.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ElementSetSpec_2:
					// emit syntax tree node associated with production
					// ElementSetSpec: ALL Exclusions

					s += "ALL";
					s += ' ';
					s += m_Exclusions.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ElementSetSpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ElementSetSpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ElementSetSpec.production_kind kind = (ElementSetSpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ElementSetSpec.production_kind.g_ElementSetSpec_1:
					// traverse syntax tree node associated with production
					// ElementSetSpec: Unions

						m_Unions.Visit (visitor, appData);
				break;
				case ElementSetSpec.production_kind.g_ElementSetSpec_2:
					// traverse syntax tree node associated with production
					// ElementSetSpec: ALL Exclusions

						m_ALL.Visit (visitor, appData);
						m_Exclusions.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Unions?.reparent (this);
			m_ALL?.reparent (this);
			m_Exclusions?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ElementSetSpec
		//

		public void _init ()
		{
			m_Unions = null;
			m_ALL = null;
			m_Exclusions = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ElementSetSpec

		// counter of all nodes associated with syntax rule ElementSetSpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ElementSetSpec
		[DataMember (Name = "m_Unions")] public Unions m_Unions { get; private set; }
		[DataMember (Name = "m_ALL")] public SyntaxTreeToken m_ALL { get; private set; }
		[DataMember (Name = "m_Exclusions")] public Exclusions m_Exclusions { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ElementSetSpec

		// delegate function (callback) prototype associated with syntax rule ElementSetSpec
		public delegate bool ElementSetSpec_Callback (SyntaxTreeCallbackReason reason, ElementSetSpec.production_kind kind, ElementSetSpec p_ElementSetSpec);

		// event associated with syntax rule ElementSetSpec
		public event ElementSetSpec_Callback ElementSetSpec_Event;

		// event trigger associated with syntax rule ElementSetSpec
		public bool Raise_ElementSetSpec_Event (SyntaxTreeCallbackReason reason, ElementSetSpec.production_kind kind, ElementSetSpec p_ElementSetSpec)
		{
			bool? status = ElementSetSpec_Event?.Invoke (reason, kind, p_ElementSetSpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ElementSetSpec
		//
		// traverse syntax tree node associated with any production of syntax rule ElementSetSpec
		//

		public void Traverse (ElementSetSpec p_ElementSetSpec)
		{
			if (p_ElementSetSpec.isLocked())
				return;
			p_ElementSetSpec.dolock();
			ElementSetSpec.production_kind kind = (ElementSetSpec.production_kind) p_ElementSetSpec.kind;
			p_ElementSetSpec.turn_reset ();
			if (Raise_ElementSetSpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ElementSetSpec))
			switch (kind)
			{
				case ElementSetSpec.production_kind.g_ElementSetSpec_1:
					// traverse syntax tree node associated with production
					// ElementSetSpec: Unions

					if (Raise_ElementSetSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ElementSetSpec))
						Traverse (p_ElementSetSpec.m_Unions);
					p_ElementSetSpec.turn_inc ();
					Raise_ElementSetSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ElementSetSpec);
				break;
				case ElementSetSpec.production_kind.g_ElementSetSpec_2:
					// traverse syntax tree node associated with production
					// ElementSetSpec: ALL Exclusions

					if (Raise_ElementSetSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ElementSetSpec))
						Traverse (p_ElementSetSpec.m_Exclusions);
					p_ElementSetSpec.turn_inc ();
					Raise_ElementSetSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ElementSetSpec);
				break;
			}
			Raise_ElementSetSpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ElementSetSpec);
			p_ElementSetSpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ElementSetSpec
		//

		public void TraverseCommon (ElementSetSpec p_ElementSetSpec)
		{
			ElementSetSpec.production_kind kind = (ElementSetSpec.production_kind) p_ElementSetSpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ElementSetSpec))
			switch (kind)
			{
				case ElementSetSpec.production_kind.g_ElementSetSpec_1:
					// traverse syntax tree node associated with production
					// ElementSetSpec: Unions

						TraverseCommon (p_ElementSetSpec.m_Unions);
				break;
				case ElementSetSpec.production_kind.g_ElementSetSpec_2:
					// traverse syntax tree node associated with production
					// ElementSetSpec: ALL Exclusions

						TraverseCommon (p_ElementSetSpec.m_ALL);
						TraverseCommon (p_ElementSetSpec.m_Exclusions);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ElementSetSpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ElementSetSpec

		//
		// create syntax tree node associated with production
		// ElementSetSpec: Unions

		//

		public ElementSetSpec ElementSetSpec_1 (Unions p_Unions)
		{
			ElementSetSpec p_ElementSetSpec_ref = new ElementSetSpec(p_Unions);
			p_Unions.parent = p_ElementSetSpec_ref;
			Raise_ElementSetSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ElementSetSpec.production_kind.g_ElementSetSpec_1, p_ElementSetSpec_ref);
			return p_ElementSetSpec_ref;
		}

		//
		// create syntax tree node associated with production
		// ElementSetSpec: ALL Exclusions

		//

		public ElementSetSpec ElementSetSpec_2 (SyntaxTreeToken p_token, Exclusions p_Exclusions)
		{
			ElementSetSpec p_ElementSetSpec_ref = new ElementSetSpec(p_token, p_Exclusions);
			p_token.parent = p_ElementSetSpec_ref;
			p_Exclusions.parent = p_ElementSetSpec_ref;
			Raise_ElementSetSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ElementSetSpec.production_kind.g_ElementSetSpec_2, p_ElementSetSpec_ref);
			return p_ElementSetSpec_ref;
		}
		#endregion
	};
}
