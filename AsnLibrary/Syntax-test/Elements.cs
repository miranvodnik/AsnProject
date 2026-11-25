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
	// class associated with syntax rule Elements
	//

	[DataContract]
	public class	Elements : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Elements
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Elements
		{
			g_Elements_1 = 1,	// SubtypeElements

			g_Elements_2 = 2,	// ObjectSetElements

			g_Elements_3 = 3,	// "(" ElementSetSpec ")"

		};
		#endregion
		#region production markers associated with the syntax rule Elements

		// markers associated with production: Elements -> SubtypeElements

		public enum production_marker_1 : ushort
		{
			m_SubtypeElements,
			final
		};

		// markers associated with production: Elements -> ObjectSetElements

		public enum production_marker_2 : ushort
		{
			m_ObjectSetElements,
			final
		};

		// markers associated with production: Elements -> "(" ElementSetSpec ")"

		public enum production_marker_3 : ushort
		{
			m_ElementSetSpec,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Elements

		// Constructor declaration(s) associated with production(s) of syntax rule Elements

		//
		// Constructor associated with the following production(s)
		// Elements -> SubtypeElements

		//

		public Elements (SubtypeElements p_SubtypeElements) : base ((uint) ProductionID._Elements_ID, (uint) production_kind.g_Elements_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SubtypeElements = p_SubtypeElements;
		}

		//
		// Constructor associated with the following production(s)
		// Elements -> ObjectSetElements

		//

		public Elements (ObjectSetElements p_ObjectSetElements) : base ((uint) ProductionID._Elements_ID, (uint) production_kind.g_Elements_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjectSetElements = p_ObjectSetElements;
		}

		//
		// Constructor associated with the following production(s)
		// Elements -> "(" ElementSetSpec ")"

		//

		public Elements (SyntaxTreeToken p_token, ElementSetSpec p_ElementSetSpec, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._Elements_ID, (uint) production_kind.g_Elements_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_round_bracket = p_token;
			children[1] = m_ElementSetSpec = p_ElementSetSpec;
			children[2] = m_right_round_bracket = p_token_1;
		}

		public Elements () { }

		// Copy constructor

		public Elements (Elements p_Elements) : base (p_Elements.id, p_Elements.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Elements.appInfo;
			switch ((production_kind) p_Elements.kind)
			{
				case production_kind.g_Elements_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SubtypeElements = (p_Elements.m_SubtypeElements != null) ? new SubtypeElements (p_Elements.m_SubtypeElements) : null) != null) m_SubtypeElements.parent = this;
					break;
				case production_kind.g_Elements_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectSetElements = (p_Elements.m_ObjectSetElements != null) ? new ObjectSetElements (p_Elements.m_ObjectSetElements) : null) != null) m_ObjectSetElements.parent = this;
					break;
				case production_kind.g_Elements_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_round_bracket = (p_Elements.m_left_round_bracket != null) ? new SyntaxTreeToken (p_Elements.m_left_round_bracket) : null) != null) m_left_round_bracket.parent = this;
					if ((children [1] = m_ElementSetSpec = (p_Elements.m_ElementSetSpec != null) ? new ElementSetSpec (p_Elements.m_ElementSetSpec) : null) != null) m_ElementSetSpec.parent = this;
					if ((children [2] = m_right_round_bracket = (p_Elements.m_right_round_bracket != null) ? new SyntaxTreeToken (p_Elements.m_right_round_bracket) : null) != null) m_right_round_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Elements" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Elements (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SubtypeElements?.Dispose ();
			m_ObjectSetElements?.Dispose ();
			m_left_round_bracket?.Dispose ();
			m_ElementSetSpec?.Dispose ();
			m_right_round_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Elements

		// Content changing function(s) associated with production(s) of syntax rule Elements

		//
		// Content changing function associated with following production(s)
		// Elements -> SubtypeElements

		//

		public void change(SubtypeElements p_SubtypeElements)
		{
			_init ();
			this.kind = (uint) production_kind.g_Elements_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SubtypeElements = p_SubtypeElements;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Elements -> ObjectSetElements

		//

		public void change(ObjectSetElements p_ObjectSetElements)
		{
			_init ();
			this.kind = (uint) production_kind.g_Elements_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjectSetElements = p_ObjectSetElements;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Elements -> "(" ElementSetSpec ")"

		//

		public void change(SyntaxTreeToken p_token, ElementSetSpec p_ElementSetSpec, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_Elements_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_round_bracket = p_token;
			children [1] = m_ElementSetSpec = p_ElementSetSpec;
			children [2] = m_right_round_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Elements
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SubtypeElements != null) && m_SubtypeElements.checkInclusion (element) ||
				(m_ObjectSetElements != null) && m_ObjectSetElements.checkInclusion (element) ||
				(m_left_round_bracket != null) && m_left_round_bracket.checkInclusion (element) ||
				(m_ElementSetSpec != null) && m_ElementSetSpec.checkInclusion (element) ||
				(m_right_round_bracket != null) && m_right_round_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Elements

		//
		// emit production tree node associated with any production of syntax rule Elements
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Elements_1:
					// emit syntax tree node associated with production
					// Elements: SubtypeElements

					s += m_SubtypeElements.Emit (depth - 1);
				break;
				case production_kind.g_Elements_2:
					// emit syntax tree node associated with production
					// Elements: ObjectSetElements

					s += m_ObjectSetElements.Emit (depth - 1);
				break;
				case production_kind.g_Elements_3:
					// emit syntax tree node associated with production
					// Elements: "(" ElementSetSpec ")"

					s += m_left_round_bracket.Emit (depth - 1);
					s += " ";
					s += m_ElementSetSpec.Emit (depth - 1);
					s += " ";
					s += m_right_round_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Elements
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Elements (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Elements_1:
					// emit syntax tree node associated with production
					// Elements: SubtypeElements

					s += m_SubtypeElements.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Elements_2:
					// emit syntax tree node associated with production
					// Elements: ObjectSetElements

					s += m_ObjectSetElements.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Elements_3:
					// emit syntax tree node associated with production
					// Elements: "(" ElementSetSpec ")"

					s += "left_round_bracket";
					s += ' ';
					s += m_ElementSetSpec.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_round_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Elements

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Elements with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Elements.production_kind kind = (Elements.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Elements.production_kind.g_Elements_1:
					// traverse syntax tree node associated with production
					// Elements: SubtypeElements

						m_SubtypeElements.Visit (visitor, appData);
				break;
				case Elements.production_kind.g_Elements_2:
					// traverse syntax tree node associated with production
					// Elements: ObjectSetElements

						m_ObjectSetElements.Visit (visitor, appData);
				break;
				case Elements.production_kind.g_Elements_3:
					// traverse syntax tree node associated with production
					// Elements: "(" ElementSetSpec ")"

						m_left_round_bracket.Visit (visitor, appData);
						m_ElementSetSpec.Visit (visitor, appData);
						m_right_round_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SubtypeElements?.reparent (this);
			m_ObjectSetElements?.reparent (this);
			m_left_round_bracket?.reparent (this);
			m_ElementSetSpec?.reparent (this);
			m_right_round_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Elements
		//

		public void _init ()
		{
			m_SubtypeElements = null;
			m_ObjectSetElements = null;
			m_left_round_bracket = null;
			m_ElementSetSpec = null;
			m_right_round_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Elements

		// counter of all nodes associated with syntax rule Elements
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Elements
		[DataMember (Name = "m_SubtypeElements")] public SubtypeElements m_SubtypeElements { get; private set; }
		[DataMember (Name = "m_ObjectSetElements")] public ObjectSetElements m_ObjectSetElements { get; private set; }
		[DataMember (Name = "m_left_round_bracket")] public SyntaxTreeToken m_left_round_bracket { get; private set; }
		[DataMember (Name = "m_ElementSetSpec")] public ElementSetSpec m_ElementSetSpec { get; private set; }
		[DataMember (Name = "m_right_round_bracket")] public SyntaxTreeToken m_right_round_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Elements

		// delegate function (callback) prototype associated with syntax rule Elements
		public delegate bool Elements_Callback (SyntaxTreeCallbackReason reason, Elements.production_kind kind, Elements p_Elements);

		// event associated with syntax rule Elements
		public event Elements_Callback Elements_Event;

		// event trigger associated with syntax rule Elements
		public bool Raise_Elements_Event (SyntaxTreeCallbackReason reason, Elements.production_kind kind, Elements p_Elements)
		{
			bool? status = Elements_Event?.Invoke (reason, kind, p_Elements);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Elements
		//
		// traverse syntax tree node associated with any production of syntax rule Elements
		//

		public void Traverse (Elements p_Elements)
		{
			if (p_Elements.isLocked())
				return;
			p_Elements.dolock();
			Elements.production_kind kind = (Elements.production_kind) p_Elements.kind;
			p_Elements.turn_reset ();
			if (Raise_Elements_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Elements))
			switch (kind)
			{
				case Elements.production_kind.g_Elements_1:
					// traverse syntax tree node associated with production
					// Elements: SubtypeElements

					if (Raise_Elements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Elements))
						Traverse (p_Elements.m_SubtypeElements);
					p_Elements.turn_inc ();
					Raise_Elements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Elements);
				break;
				case Elements.production_kind.g_Elements_2:
					// traverse syntax tree node associated with production
					// Elements: ObjectSetElements

					if (Raise_Elements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Elements))
						Traverse (p_Elements.m_ObjectSetElements);
					p_Elements.turn_inc ();
					Raise_Elements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Elements);
				break;
				case Elements.production_kind.g_Elements_3:
					// traverse syntax tree node associated with production
					// Elements: "(" ElementSetSpec ")"

					if (Raise_Elements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Elements))
						Traverse (p_Elements.m_ElementSetSpec);
					p_Elements.turn_inc ();
					Raise_Elements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Elements);
				break;
			}
			Raise_Elements_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Elements);
			p_Elements.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Elements
		//

		public void TraverseCommon (Elements p_Elements)
		{
			Elements.production_kind kind = (Elements.production_kind) p_Elements.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Elements))
			switch (kind)
			{
				case Elements.production_kind.g_Elements_1:
					// traverse syntax tree node associated with production
					// Elements: SubtypeElements

						TraverseCommon (p_Elements.m_SubtypeElements);
				break;
				case Elements.production_kind.g_Elements_2:
					// traverse syntax tree node associated with production
					// Elements: ObjectSetElements

						TraverseCommon (p_Elements.m_ObjectSetElements);
				break;
				case Elements.production_kind.g_Elements_3:
					// traverse syntax tree node associated with production
					// Elements: "(" ElementSetSpec ")"

						TraverseCommon (p_Elements.m_left_round_bracket);
						TraverseCommon (p_Elements.m_ElementSetSpec);
						TraverseCommon (p_Elements.m_right_round_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Elements);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Elements

		//
		// create syntax tree node associated with production
		// Elements: SubtypeElements

		//

		public Elements Elements_1 (SubtypeElements p_SubtypeElements)
		{
			Elements p_Elements_ref = new Elements(p_SubtypeElements);
			p_SubtypeElements.parent = p_Elements_ref;
			Raise_Elements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Elements.production_kind.g_Elements_1, p_Elements_ref);
			return p_Elements_ref;
		}

		//
		// create syntax tree node associated with production
		// Elements: ObjectSetElements

		//

		public Elements Elements_2 (ObjectSetElements p_ObjectSetElements)
		{
			Elements p_Elements_ref = new Elements(p_ObjectSetElements);
			p_ObjectSetElements.parent = p_Elements_ref;
			Raise_Elements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Elements.production_kind.g_Elements_2, p_Elements_ref);
			return p_Elements_ref;
		}

		//
		// create syntax tree node associated with production
		// Elements: "(" ElementSetSpec ")"

		//

		public Elements Elements_3 (SyntaxTreeToken p_token, ElementSetSpec p_ElementSetSpec, SyntaxTreeToken p_token_1)
		{
			Elements p_Elements_ref = new Elements(p_token, p_ElementSetSpec, p_token_1);
			p_token.parent = p_Elements_ref;
			p_ElementSetSpec.parent = p_Elements_ref;
			p_token_1.parent = p_Elements_ref;
			Raise_Elements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Elements.production_kind.g_Elements_3, p_Elements_ref);
			return p_Elements_ref;
		}
		#endregion
	};
}
