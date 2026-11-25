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
	// class associated with syntax rule ElementSetSpecs
	//

	[DataContract]
	public class	ElementSetSpecs : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ElementSetSpecs
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ElementSetSpecs
		{
			g_ElementSetSpecs_1 = 1,	// RootElementSetSpec

			g_ElementSetSpecs_2 = 2,	// RootElementSetSpec "," "." "." "."

			g_ElementSetSpecs_3 = 3,	// RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

		};
		#endregion
		#region production markers associated with the syntax rule ElementSetSpecs

		// markers associated with production: ElementSetSpecs -> RootElementSetSpec

		public enum production_marker_1 : ushort
		{
			m_RootElementSetSpec,
			final
		};

		// markers associated with production: ElementSetSpecs -> RootElementSetSpec "," "." "." "."

		public enum production_marker_2 : ushort
		{
			m_RootElementSetSpec,
			final
		};

		// markers associated with production: ElementSetSpecs -> RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

		public enum production_marker_3 : ushort
		{
			m_RootElementSetSpec,
			m_AdditionalElementSetSpec,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ElementSetSpecs

		// Constructor declaration(s) associated with production(s) of syntax rule ElementSetSpecs

		//
		// Constructor associated with the following production(s)
		// ElementSetSpecs -> RootElementSetSpec

		//

		public ElementSetSpecs (RootElementSetSpec p_RootElementSetSpec) : base ((uint) ProductionID._ElementSetSpecs_ID, (uint) production_kind.g_ElementSetSpecs_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_RootElementSetSpec = p_RootElementSetSpec;
		}

		//
		// Constructor associated with the following production(s)
		// ElementSetSpecs -> RootElementSetSpec "," "." "." "."

		//

		public ElementSetSpecs (RootElementSetSpec p_RootElementSetSpec, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3) : base ((uint) ProductionID._ElementSetSpecs_ID, (uint) production_kind.g_ElementSetSpecs_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children[0] = m_RootElementSetSpec = p_RootElementSetSpec;
			children[1] = m_comma = p_token;
			children[2] = m_dot = p_token_1;
			children[3] = m_dot_1 = p_token_2;
			children[4] = m_dot_2 = p_token_3;
		}

		//
		// Constructor associated with the following production(s)
		// ElementSetSpecs -> RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

		//

		public ElementSetSpecs (RootElementSetSpec p_RootElementSetSpec, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, SyntaxTreeToken p_token_4, AdditionalElementSetSpec p_AdditionalElementSetSpec) : base ((uint) ProductionID._ElementSetSpecs_ID, (uint) production_kind.g_ElementSetSpecs_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children[0] = m_RootElementSetSpec = p_RootElementSetSpec;
			children[1] = m_comma = p_token;
			children[2] = m_dot = p_token_1;
			children[3] = m_dot_1 = p_token_2;
			children[4] = m_dot_2 = p_token_3;
			children[5] = m_comma_1 = p_token_4;
			children[6] = m_AdditionalElementSetSpec = p_AdditionalElementSetSpec;
		}

		public ElementSetSpecs () { }

		// Copy constructor

		public ElementSetSpecs (ElementSetSpecs p_ElementSetSpecs) : base (p_ElementSetSpecs.id, p_ElementSetSpecs.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ElementSetSpecs.appInfo;
			switch ((production_kind) p_ElementSetSpecs.kind)
			{
				case production_kind.g_ElementSetSpecs_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RootElementSetSpec = (p_ElementSetSpecs.m_RootElementSetSpec != null) ? new RootElementSetSpec (p_ElementSetSpecs.m_RootElementSetSpec) : null) != null) m_RootElementSetSpec.parent = this;
					break;
				case production_kind.g_ElementSetSpecs_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_RootElementSetSpec = (p_ElementSetSpecs.m_RootElementSetSpec != null) ? new RootElementSetSpec (p_ElementSetSpecs.m_RootElementSetSpec) : null) != null) m_RootElementSetSpec.parent = this;
					if ((children [1] = m_comma = (p_ElementSetSpecs.m_comma != null) ? new SyntaxTreeToken (p_ElementSetSpecs.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_dot = (p_ElementSetSpecs.m_dot != null) ? new SyntaxTreeToken (p_ElementSetSpecs.m_dot) : null) != null) m_dot.parent = this;
					if ((children [3] = m_dot_1 = (p_ElementSetSpecs.m_dot_1 != null) ? new SyntaxTreeToken (p_ElementSetSpecs.m_dot_1) : null) != null) m_dot_1.parent = this;
					if ((children [4] = m_dot_2 = (p_ElementSetSpecs.m_dot_2 != null) ? new SyntaxTreeToken (p_ElementSetSpecs.m_dot_2) : null) != null) m_dot_2.parent = this;
					break;
				case production_kind.g_ElementSetSpecs_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
					if ((children [0] = m_RootElementSetSpec = (p_ElementSetSpecs.m_RootElementSetSpec != null) ? new RootElementSetSpec (p_ElementSetSpecs.m_RootElementSetSpec) : null) != null) m_RootElementSetSpec.parent = this;
					if ((children [1] = m_comma = (p_ElementSetSpecs.m_comma != null) ? new SyntaxTreeToken (p_ElementSetSpecs.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_dot = (p_ElementSetSpecs.m_dot != null) ? new SyntaxTreeToken (p_ElementSetSpecs.m_dot) : null) != null) m_dot.parent = this;
					if ((children [3] = m_dot_1 = (p_ElementSetSpecs.m_dot_1 != null) ? new SyntaxTreeToken (p_ElementSetSpecs.m_dot_1) : null) != null) m_dot_1.parent = this;
					if ((children [4] = m_dot_2 = (p_ElementSetSpecs.m_dot_2 != null) ? new SyntaxTreeToken (p_ElementSetSpecs.m_dot_2) : null) != null) m_dot_2.parent = this;
					if ((children [5] = m_comma_1 = (p_ElementSetSpecs.m_comma_1 != null) ? new SyntaxTreeToken (p_ElementSetSpecs.m_comma_1) : null) != null) m_comma_1.parent = this;
					if ((children [6] = m_AdditionalElementSetSpec = (p_ElementSetSpecs.m_AdditionalElementSetSpec != null) ? new AdditionalElementSetSpec (p_ElementSetSpecs.m_AdditionalElementSetSpec) : null) != null) m_AdditionalElementSetSpec.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ElementSetSpecs" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ElementSetSpecs (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_RootElementSetSpec?.Dispose ();
			m_comma?.Dispose ();
			m_comma_1?.Dispose ();
			m_dot?.Dispose ();
			m_dot_1?.Dispose ();
			m_dot_2?.Dispose ();
			m_AdditionalElementSetSpec?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ElementSetSpecs

		// Content changing function(s) associated with production(s) of syntax rule ElementSetSpecs

		//
		// Content changing function associated with following production(s)
		// ElementSetSpecs -> RootElementSetSpec

		//

		public void change(RootElementSetSpec p_RootElementSetSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_ElementSetSpecs_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_RootElementSetSpec = p_RootElementSetSpec;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ElementSetSpecs -> RootElementSetSpec "," "." "." "."

		//

		public void change(RootElementSetSpec p_RootElementSetSpec, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3)
		{
			_init ();
			this.kind = (uint) production_kind.g_ElementSetSpecs_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children [0] = m_RootElementSetSpec = p_RootElementSetSpec;
			children [1] = m_comma = p_token;
			children [2] = m_dot = p_token_1;
			children [3] = m_dot_1 = p_token_2;
			children [4] = m_dot_2 = p_token_3;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ElementSetSpecs -> RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

		//

		public void change(RootElementSetSpec p_RootElementSetSpec, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, SyntaxTreeToken p_token_4, AdditionalElementSetSpec p_AdditionalElementSetSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_ElementSetSpecs_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children [0] = m_RootElementSetSpec = p_RootElementSetSpec;
			children [1] = m_comma = p_token;
			children [2] = m_dot = p_token_1;
			children [3] = m_dot_1 = p_token_2;
			children [4] = m_dot_2 = p_token_3;
			children [5] = m_comma_1 = p_token_4;
			children [6] = m_AdditionalElementSetSpec = p_AdditionalElementSetSpec;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ElementSetSpecs
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_RootElementSetSpec != null) && m_RootElementSetSpec.checkInclusion (element) ||
				(m_comma != null) && m_comma.checkInclusion (element) ||
				(m_comma_1 != null) && m_comma_1.checkInclusion (element) ||
				(m_dot != null) && m_dot.checkInclusion (element) ||
				(m_dot_1 != null) && m_dot_1.checkInclusion (element) ||
				(m_dot_2 != null) && m_dot_2.checkInclusion (element) ||
				(m_AdditionalElementSetSpec != null) && m_AdditionalElementSetSpec.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ElementSetSpecs

		//
		// emit production tree node associated with any production of syntax rule ElementSetSpecs
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ElementSetSpecs_1:
					// emit syntax tree node associated with production
					// ElementSetSpecs: RootElementSetSpec

					s += m_RootElementSetSpec.Emit (depth - 1);
				break;
				case production_kind.g_ElementSetSpecs_2:
					// emit syntax tree node associated with production
					// ElementSetSpecs: RootElementSetSpec "," "." "." "."

					s += m_RootElementSetSpec.Emit (depth - 1);
					s += " ";
					s += m_comma.Emit (depth - 1);
					s += " ";
					s += m_dot.Emit (depth - 1);
					s += " ";
					s += m_dot_1.Emit (depth - 1);
					s += " ";
					s += m_dot_2.Emit (depth - 1);
				break;
				case production_kind.g_ElementSetSpecs_3:
					// emit syntax tree node associated with production
					// ElementSetSpecs: RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

					s += m_RootElementSetSpec.Emit (depth - 1);
					s += " ";
					s += m_comma.Emit (depth - 1);
					s += " ";
					s += m_dot.Emit (depth - 1);
					s += " ";
					s += m_dot_1.Emit (depth - 1);
					s += " ";
					s += m_dot_2.Emit (depth - 1);
					s += " ";
					s += m_comma_1.Emit (depth - 1);
					s += " ";
					s += m_AdditionalElementSetSpec.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ElementSetSpecs
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ElementSetSpecs (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ElementSetSpecs_1:
					// emit syntax tree node associated with production
					// ElementSetSpecs: RootElementSetSpec

					s += m_RootElementSetSpec.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ElementSetSpecs_2:
					// emit syntax tree node associated with production
					// ElementSetSpecs: RootElementSetSpec "," "." "." "."

					s += m_RootElementSetSpec.EmitProductionTree (depth - 1);
					s += ' ';
					s += "comma";
					s += ' ';
					s += "dot";
					s += ' ';
					s += "dot";
					s += ' ';
					s += "dot";
				break;
				case production_kind.g_ElementSetSpecs_3:
					// emit syntax tree node associated with production
					// ElementSetSpecs: RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

					s += m_RootElementSetSpec.EmitProductionTree (depth - 1);
					s += ' ';
					s += "comma";
					s += ' ';
					s += "dot";
					s += ' ';
					s += "dot";
					s += ' ';
					s += "dot";
					s += ' ';
					s += "comma";
					s += ' ';
					s += m_AdditionalElementSetSpec.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ElementSetSpecs

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ElementSetSpecs with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ElementSetSpecs.production_kind kind = (ElementSetSpecs.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ElementSetSpecs.production_kind.g_ElementSetSpecs_1:
					// traverse syntax tree node associated with production
					// ElementSetSpecs: RootElementSetSpec

						m_RootElementSetSpec.Visit (visitor, appData);
				break;
				case ElementSetSpecs.production_kind.g_ElementSetSpecs_2:
					// traverse syntax tree node associated with production
					// ElementSetSpecs: RootElementSetSpec "," "." "." "."

						m_RootElementSetSpec.Visit (visitor, appData);
						m_comma.Visit (visitor, appData);
						m_dot.Visit (visitor, appData);
						m_dot_1.Visit (visitor, appData);
						m_dot_2.Visit (visitor, appData);
				break;
				case ElementSetSpecs.production_kind.g_ElementSetSpecs_3:
					// traverse syntax tree node associated with production
					// ElementSetSpecs: RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

						m_RootElementSetSpec.Visit (visitor, appData);
						m_comma.Visit (visitor, appData);
						m_dot.Visit (visitor, appData);
						m_dot_1.Visit (visitor, appData);
						m_dot_2.Visit (visitor, appData);
						m_comma_1.Visit (visitor, appData);
						m_AdditionalElementSetSpec.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_RootElementSetSpec?.reparent (this);
			m_comma?.reparent (this);
			m_comma_1?.reparent (this);

			m_dot?.reparent (this);
			m_dot_1?.reparent (this);

			m_dot_2?.reparent (this);

			m_AdditionalElementSetSpec?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ElementSetSpecs
		//

		public void _init ()
		{
			m_RootElementSetSpec = null;
			m_comma = null;
			m_comma_1 = null;
			m_dot = null;
			m_dot_1 = null;
			m_dot_2 = null;
			m_AdditionalElementSetSpec = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ElementSetSpecs

		// counter of all nodes associated with syntax rule ElementSetSpecs
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ElementSetSpecs
		[DataMember (Name = "m_RootElementSetSpec")] public RootElementSetSpec m_RootElementSetSpec { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		[DataMember (Name = "m_comma_1")] public SyntaxTreeToken m_comma_1 { get; private set; }
		[DataMember (Name = "m_dot")] public SyntaxTreeToken m_dot { get; private set; }
		[DataMember (Name = "m_dot_1")] public SyntaxTreeToken m_dot_1 { get; private set; }
		[DataMember (Name = "m_dot_2")] public SyntaxTreeToken m_dot_2 { get; private set; }
		[DataMember (Name = "m_AdditionalElementSetSpec")] public AdditionalElementSetSpec m_AdditionalElementSetSpec { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ElementSetSpecs

		// delegate function (callback) prototype associated with syntax rule ElementSetSpecs
		public delegate bool ElementSetSpecs_Callback (SyntaxTreeCallbackReason reason, ElementSetSpecs.production_kind kind, ElementSetSpecs p_ElementSetSpecs);

		// event associated with syntax rule ElementSetSpecs
		public event ElementSetSpecs_Callback ElementSetSpecs_Event;

		// event trigger associated with syntax rule ElementSetSpecs
		public bool Raise_ElementSetSpecs_Event (SyntaxTreeCallbackReason reason, ElementSetSpecs.production_kind kind, ElementSetSpecs p_ElementSetSpecs)
		{
			bool? status = ElementSetSpecs_Event?.Invoke (reason, kind, p_ElementSetSpecs);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ElementSetSpecs
		//
		// traverse syntax tree node associated with any production of syntax rule ElementSetSpecs
		//

		public void Traverse (ElementSetSpecs p_ElementSetSpecs)
		{
			if (p_ElementSetSpecs.isLocked())
				return;
			p_ElementSetSpecs.dolock();
			ElementSetSpecs.production_kind kind = (ElementSetSpecs.production_kind) p_ElementSetSpecs.kind;
			p_ElementSetSpecs.turn_reset ();
			if (Raise_ElementSetSpecs_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ElementSetSpecs))
			switch (kind)
			{
				case ElementSetSpecs.production_kind.g_ElementSetSpecs_1:
					// traverse syntax tree node associated with production
					// ElementSetSpecs: RootElementSetSpec

					if (Raise_ElementSetSpecs_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ElementSetSpecs))
						Traverse (p_ElementSetSpecs.m_RootElementSetSpec);
					p_ElementSetSpecs.turn_inc ();
					Raise_ElementSetSpecs_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ElementSetSpecs);
				break;
				case ElementSetSpecs.production_kind.g_ElementSetSpecs_2:
					// traverse syntax tree node associated with production
					// ElementSetSpecs: RootElementSetSpec "," "." "." "."

					if (Raise_ElementSetSpecs_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ElementSetSpecs))
						Traverse (p_ElementSetSpecs.m_RootElementSetSpec);
					p_ElementSetSpecs.turn_inc ();
					Raise_ElementSetSpecs_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ElementSetSpecs);
				break;
				case ElementSetSpecs.production_kind.g_ElementSetSpecs_3:
					// traverse syntax tree node associated with production
					// ElementSetSpecs: RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

					if (Raise_ElementSetSpecs_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ElementSetSpecs))
						Traverse (p_ElementSetSpecs.m_RootElementSetSpec);
					p_ElementSetSpecs.turn_inc ();
					if (Raise_ElementSetSpecs_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ElementSetSpecs))
						Traverse (p_ElementSetSpecs.m_AdditionalElementSetSpec);
					p_ElementSetSpecs.turn_inc ();
					Raise_ElementSetSpecs_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ElementSetSpecs);
				break;
			}
			Raise_ElementSetSpecs_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ElementSetSpecs);
			p_ElementSetSpecs.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ElementSetSpecs
		//

		public void TraverseCommon (ElementSetSpecs p_ElementSetSpecs)
		{
			ElementSetSpecs.production_kind kind = (ElementSetSpecs.production_kind) p_ElementSetSpecs.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ElementSetSpecs))
			switch (kind)
			{
				case ElementSetSpecs.production_kind.g_ElementSetSpecs_1:
					// traverse syntax tree node associated with production
					// ElementSetSpecs: RootElementSetSpec

						TraverseCommon (p_ElementSetSpecs.m_RootElementSetSpec);
				break;
				case ElementSetSpecs.production_kind.g_ElementSetSpecs_2:
					// traverse syntax tree node associated with production
					// ElementSetSpecs: RootElementSetSpec "," "." "." "."

						TraverseCommon (p_ElementSetSpecs.m_RootElementSetSpec);
						TraverseCommon (p_ElementSetSpecs.m_comma);
						TraverseCommon (p_ElementSetSpecs.m_dot);
						TraverseCommon (p_ElementSetSpecs.m_dot_1);
						TraverseCommon (p_ElementSetSpecs.m_dot_2);
				break;
				case ElementSetSpecs.production_kind.g_ElementSetSpecs_3:
					// traverse syntax tree node associated with production
					// ElementSetSpecs: RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

						TraverseCommon (p_ElementSetSpecs.m_RootElementSetSpec);
						TraverseCommon (p_ElementSetSpecs.m_comma);
						TraverseCommon (p_ElementSetSpecs.m_dot);
						TraverseCommon (p_ElementSetSpecs.m_dot_1);
						TraverseCommon (p_ElementSetSpecs.m_dot_2);
						TraverseCommon (p_ElementSetSpecs.m_comma_1);
						TraverseCommon (p_ElementSetSpecs.m_AdditionalElementSetSpec);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ElementSetSpecs);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ElementSetSpecs

		//
		// create syntax tree node associated with production
		// ElementSetSpecs: RootElementSetSpec

		//

		public ElementSetSpecs ElementSetSpecs_1 (RootElementSetSpec p_RootElementSetSpec)
		{
			ElementSetSpecs p_ElementSetSpecs_ref = new ElementSetSpecs(p_RootElementSetSpec);
			p_RootElementSetSpec.parent = p_ElementSetSpecs_ref;
			Raise_ElementSetSpecs_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ElementSetSpecs.production_kind.g_ElementSetSpecs_1, p_ElementSetSpecs_ref);
			return p_ElementSetSpecs_ref;
		}

		//
		// create syntax tree node associated with production
		// ElementSetSpecs: RootElementSetSpec "," "." "." "."

		//

		public ElementSetSpecs ElementSetSpecs_2 (RootElementSetSpec p_RootElementSetSpec, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3)
		{
			ElementSetSpecs p_ElementSetSpecs_ref = new ElementSetSpecs(p_RootElementSetSpec, p_token, p_token_1, p_token_2, p_token_3);
			p_RootElementSetSpec.parent = p_ElementSetSpecs_ref;
			p_token.parent = p_ElementSetSpecs_ref;
			p_token_1.parent = p_ElementSetSpecs_ref;
			p_token_2.parent = p_ElementSetSpecs_ref;
			p_token_3.parent = p_ElementSetSpecs_ref;
			Raise_ElementSetSpecs_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ElementSetSpecs.production_kind.g_ElementSetSpecs_2, p_ElementSetSpecs_ref);
			return p_ElementSetSpecs_ref;
		}

		//
		// create syntax tree node associated with production
		// ElementSetSpecs: RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

		//

		public ElementSetSpecs ElementSetSpecs_3 (RootElementSetSpec p_RootElementSetSpec, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, SyntaxTreeToken p_token_4, AdditionalElementSetSpec p_AdditionalElementSetSpec)
		{
			ElementSetSpecs p_ElementSetSpecs_ref = new ElementSetSpecs(p_RootElementSetSpec, p_token, p_token_1, p_token_2, p_token_3, p_token_4, p_AdditionalElementSetSpec);
			p_RootElementSetSpec.parent = p_ElementSetSpecs_ref;
			p_token.parent = p_ElementSetSpecs_ref;
			p_token_1.parent = p_ElementSetSpecs_ref;
			p_token_2.parent = p_ElementSetSpecs_ref;
			p_token_3.parent = p_ElementSetSpecs_ref;
			p_token_4.parent = p_ElementSetSpecs_ref;
			p_AdditionalElementSetSpec.parent = p_ElementSetSpecs_ref;
			Raise_ElementSetSpecs_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ElementSetSpecs.production_kind.g_ElementSetSpecs_3, p_ElementSetSpecs_ref);
			return p_ElementSetSpecs_ref;
		}
		#endregion
	};
}
