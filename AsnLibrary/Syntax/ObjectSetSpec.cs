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
	// class associated with syntax rule ObjectSetSpec
	//

	[DataContract]
	public class	ObjectSetSpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectSetSpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectSetSpec
		{
			g_ObjectSetSpec_1 = 1,	// RootElementSetSpec

			g_ObjectSetSpec_2 = 2,	// RootElementSetSpec "," "." "." "."

			g_ObjectSetSpec_3 = 3,	// "." "." "."

			g_ObjectSetSpec_4 = 4,	// "." "." "." "," AdditionalElementSetSpec

			g_ObjectSetSpec_5 = 5,	// RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

		};
		#endregion
		#region production markers associated with the syntax rule ObjectSetSpec

		// markers associated with production: ObjectSetSpec -> RootElementSetSpec

		public enum production_marker_1 : ushort
		{
			m_RootElementSetSpec,
			final
		};

		// markers associated with production: ObjectSetSpec -> RootElementSetSpec "," "." "." "."

		public enum production_marker_2 : ushort
		{
			m_RootElementSetSpec,
			final
		};

		// markers associated with production: ObjectSetSpec -> "." "." "."

		public enum production_marker_3 : ushort
		{
			final
		};

		// markers associated with production: ObjectSetSpec -> "." "." "." "," AdditionalElementSetSpec

		public enum production_marker_4 : ushort
		{
			m_AdditionalElementSetSpec,
			final
		};

		// markers associated with production: ObjectSetSpec -> RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

		public enum production_marker_5 : ushort
		{
			m_RootElementSetSpec,
			m_AdditionalElementSetSpec,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectSetSpec

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectSetSpec

		//
		// Constructor associated with the following production(s)
		// ObjectSetSpec -> RootElementSetSpec

		//

		public ObjectSetSpec (RootElementSetSpec p_RootElementSetSpec) : base ((uint) ProductionID._ObjectSetSpec_ID, (uint) production_kind.g_ObjectSetSpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_RootElementSetSpec = p_RootElementSetSpec;
		}

		//
		// Constructor associated with the following production(s)
		// ObjectSetSpec -> RootElementSetSpec "," "." "." "."

		//

		public ObjectSetSpec (RootElementSetSpec p_RootElementSetSpec, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3) : base ((uint) ProductionID._ObjectSetSpec_ID, (uint) production_kind.g_ObjectSetSpec_2)
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
		// ObjectSetSpec -> "." "." "."

		//

		public ObjectSetSpec (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._ObjectSetSpec_ID, (uint) production_kind.g_ObjectSetSpec_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_dot = p_token;
			children[1] = m_dot_1 = p_token_1;
			children[2] = m_dot_2 = p_token_2;
		}

		//
		// Constructor associated with the following production(s)
		// ObjectSetSpec -> "." "." "." "," AdditionalElementSetSpec

		//

		public ObjectSetSpec (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, AdditionalElementSetSpec p_AdditionalElementSetSpec) : base ((uint) ProductionID._ObjectSetSpec_ID, (uint) production_kind.g_ObjectSetSpec_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children[0] = m_dot = p_token;
			children[1] = m_dot_1 = p_token_1;
			children[2] = m_dot_2 = p_token_2;
			children[3] = m_comma = p_token_3;
			children[4] = m_AdditionalElementSetSpec = p_AdditionalElementSetSpec;
		}

		//
		// Constructor associated with the following production(s)
		// ObjectSetSpec -> RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

		//

		public ObjectSetSpec (RootElementSetSpec p_RootElementSetSpec, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, SyntaxTreeToken p_token_4, AdditionalElementSetSpec p_AdditionalElementSetSpec) : base ((uint) ProductionID._ObjectSetSpec_ID, (uint) production_kind.g_ObjectSetSpec_5)
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

		public ObjectSetSpec () { }

		// Copy constructor

		public ObjectSetSpec (ObjectSetSpec p_ObjectSetSpec) : base (p_ObjectSetSpec.id, p_ObjectSetSpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectSetSpec.appInfo;
			switch ((production_kind) p_ObjectSetSpec.kind)
			{
				case production_kind.g_ObjectSetSpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RootElementSetSpec = (p_ObjectSetSpec.m_RootElementSetSpec != null) ? new RootElementSetSpec (p_ObjectSetSpec.m_RootElementSetSpec) : null) != null) m_RootElementSetSpec.parent = this;
					break;
				case production_kind.g_ObjectSetSpec_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_RootElementSetSpec = (p_ObjectSetSpec.m_RootElementSetSpec != null) ? new RootElementSetSpec (p_ObjectSetSpec.m_RootElementSetSpec) : null) != null) m_RootElementSetSpec.parent = this;
					if ((children [1] = m_comma = (p_ObjectSetSpec.m_comma != null) ? new SyntaxTreeToken (p_ObjectSetSpec.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_dot = (p_ObjectSetSpec.m_dot != null) ? new SyntaxTreeToken (p_ObjectSetSpec.m_dot) : null) != null) m_dot.parent = this;
					if ((children [3] = m_dot_1 = (p_ObjectSetSpec.m_dot_1 != null) ? new SyntaxTreeToken (p_ObjectSetSpec.m_dot_1) : null) != null) m_dot_1.parent = this;
					if ((children [4] = m_dot_2 = (p_ObjectSetSpec.m_dot_2 != null) ? new SyntaxTreeToken (p_ObjectSetSpec.m_dot_2) : null) != null) m_dot_2.parent = this;
					break;
				case production_kind.g_ObjectSetSpec_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_dot = (p_ObjectSetSpec.m_dot != null) ? new SyntaxTreeToken (p_ObjectSetSpec.m_dot) : null) != null) m_dot.parent = this;
					if ((children [1] = m_dot_1 = (p_ObjectSetSpec.m_dot_1 != null) ? new SyntaxTreeToken (p_ObjectSetSpec.m_dot_1) : null) != null) m_dot_1.parent = this;
					if ((children [2] = m_dot_2 = (p_ObjectSetSpec.m_dot_2 != null) ? new SyntaxTreeToken (p_ObjectSetSpec.m_dot_2) : null) != null) m_dot_2.parent = this;
					break;
				case production_kind.g_ObjectSetSpec_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_dot = (p_ObjectSetSpec.m_dot != null) ? new SyntaxTreeToken (p_ObjectSetSpec.m_dot) : null) != null) m_dot.parent = this;
					if ((children [1] = m_dot_1 = (p_ObjectSetSpec.m_dot_1 != null) ? new SyntaxTreeToken (p_ObjectSetSpec.m_dot_1) : null) != null) m_dot_1.parent = this;
					if ((children [2] = m_dot_2 = (p_ObjectSetSpec.m_dot_2 != null) ? new SyntaxTreeToken (p_ObjectSetSpec.m_dot_2) : null) != null) m_dot_2.parent = this;
					if ((children [3] = m_comma = (p_ObjectSetSpec.m_comma != null) ? new SyntaxTreeToken (p_ObjectSetSpec.m_comma) : null) != null) m_comma.parent = this;
					if ((children [4] = m_AdditionalElementSetSpec = (p_ObjectSetSpec.m_AdditionalElementSetSpec != null) ? new AdditionalElementSetSpec (p_ObjectSetSpec.m_AdditionalElementSetSpec) : null) != null) m_AdditionalElementSetSpec.parent = this;
					break;
				case production_kind.g_ObjectSetSpec_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
					if ((children [0] = m_RootElementSetSpec = (p_ObjectSetSpec.m_RootElementSetSpec != null) ? new RootElementSetSpec (p_ObjectSetSpec.m_RootElementSetSpec) : null) != null) m_RootElementSetSpec.parent = this;
					if ((children [1] = m_comma = (p_ObjectSetSpec.m_comma != null) ? new SyntaxTreeToken (p_ObjectSetSpec.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_dot = (p_ObjectSetSpec.m_dot != null) ? new SyntaxTreeToken (p_ObjectSetSpec.m_dot) : null) != null) m_dot.parent = this;
					if ((children [3] = m_dot_1 = (p_ObjectSetSpec.m_dot_1 != null) ? new SyntaxTreeToken (p_ObjectSetSpec.m_dot_1) : null) != null) m_dot_1.parent = this;
					if ((children [4] = m_dot_2 = (p_ObjectSetSpec.m_dot_2 != null) ? new SyntaxTreeToken (p_ObjectSetSpec.m_dot_2) : null) != null) m_dot_2.parent = this;
					if ((children [5] = m_comma_1 = (p_ObjectSetSpec.m_comma_1 != null) ? new SyntaxTreeToken (p_ObjectSetSpec.m_comma_1) : null) != null) m_comma_1.parent = this;
					if ((children [6] = m_AdditionalElementSetSpec = (p_ObjectSetSpec.m_AdditionalElementSetSpec != null) ? new AdditionalElementSetSpec (p_ObjectSetSpec.m_AdditionalElementSetSpec) : null) != null) m_AdditionalElementSetSpec.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectSetSpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectSetSpec (this); }

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
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectSetSpec

		// Content changing function(s) associated with production(s) of syntax rule ObjectSetSpec

		//
		// Content changing function associated with following production(s)
		// ObjectSetSpec -> RootElementSetSpec

		//

		public void change(RootElementSetSpec p_RootElementSetSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectSetSpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_RootElementSetSpec = p_RootElementSetSpec;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ObjectSetSpec -> RootElementSetSpec "," "." "." "."

		//

		public void change(RootElementSetSpec p_RootElementSetSpec, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectSetSpec_2;
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
		// ObjectSetSpec -> "." "." "."

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectSetSpec_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_dot = p_token;
			children [1] = m_dot_1 = p_token_1;
			children [2] = m_dot_2 = p_token_2;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ObjectSetSpec -> "." "." "." "," AdditionalElementSetSpec

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, AdditionalElementSetSpec p_AdditionalElementSetSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectSetSpec_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children [0] = m_dot = p_token;
			children [1] = m_dot_1 = p_token_1;
			children [2] = m_dot_2 = p_token_2;
			children [3] = m_comma = p_token_3;
			children [4] = m_AdditionalElementSetSpec = p_AdditionalElementSetSpec;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ObjectSetSpec -> RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

		//

		public void change(RootElementSetSpec p_RootElementSetSpec, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, SyntaxTreeToken p_token_4, AdditionalElementSetSpec p_AdditionalElementSetSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectSetSpec_5;
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
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectSetSpec
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
		#region Syntax tree emit methods associated with the syntax rule ObjectSetSpec

		//
		// emit production tree node associated with any production of syntax rule ObjectSetSpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectSetSpec_1:
					// emit syntax tree node associated with production
					// ObjectSetSpec: RootElementSetSpec

					s += m_RootElementSetSpec.Emit (depth - 1);
				break;
				case production_kind.g_ObjectSetSpec_2:
					// emit syntax tree node associated with production
					// ObjectSetSpec: RootElementSetSpec "," "." "." "."

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
				case production_kind.g_ObjectSetSpec_3:
					// emit syntax tree node associated with production
					// ObjectSetSpec: "." "." "."

					s += m_dot.Emit (depth - 1);
					s += " ";
					s += m_dot_1.Emit (depth - 1);
					s += " ";
					s += m_dot_2.Emit (depth - 1);
				break;
				case production_kind.g_ObjectSetSpec_4:
					// emit syntax tree node associated with production
					// ObjectSetSpec: "." "." "." "," AdditionalElementSetSpec

					s += m_dot.Emit (depth - 1);
					s += " ";
					s += m_dot_1.Emit (depth - 1);
					s += " ";
					s += m_dot_2.Emit (depth - 1);
					s += " ";
					s += m_comma.Emit (depth - 1);
					s += " ";
					s += m_AdditionalElementSetSpec.Emit (depth - 1);
				break;
				case production_kind.g_ObjectSetSpec_5:
					// emit syntax tree node associated with production
					// ObjectSetSpec: RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

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
		// emit production tree node associated with any production of syntax rule ObjectSetSpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectSetSpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectSetSpec_1:
					// emit syntax tree node associated with production
					// ObjectSetSpec: RootElementSetSpec

					s += m_RootElementSetSpec.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ObjectSetSpec_2:
					// emit syntax tree node associated with production
					// ObjectSetSpec: RootElementSetSpec "," "." "." "."

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
				case production_kind.g_ObjectSetSpec_3:
					// emit syntax tree node associated with production
					// ObjectSetSpec: "." "." "."

					s += "dot";
					s += ' ';
					s += "dot";
					s += ' ';
					s += "dot";
				break;
				case production_kind.g_ObjectSetSpec_4:
					// emit syntax tree node associated with production
					// ObjectSetSpec: "." "." "." "," AdditionalElementSetSpec

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
				case production_kind.g_ObjectSetSpec_5:
					// emit syntax tree node associated with production
					// ObjectSetSpec: RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectSetSpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetSpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectSetSpec.production_kind kind = (ObjectSetSpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectSetSpec.production_kind.g_ObjectSetSpec_1:
					// traverse syntax tree node associated with production
					// ObjectSetSpec: RootElementSetSpec

						m_RootElementSetSpec.Visit (visitor, appData);
				break;
				case ObjectSetSpec.production_kind.g_ObjectSetSpec_2:
					// traverse syntax tree node associated with production
					// ObjectSetSpec: RootElementSetSpec "," "." "." "."

						m_RootElementSetSpec.Visit (visitor, appData);
						m_comma.Visit (visitor, appData);
						m_dot.Visit (visitor, appData);
						m_dot_1.Visit (visitor, appData);
						m_dot_2.Visit (visitor, appData);
				break;
				case ObjectSetSpec.production_kind.g_ObjectSetSpec_3:
					// traverse syntax tree node associated with production
					// ObjectSetSpec: "." "." "."

						m_dot.Visit (visitor, appData);
						m_dot_1.Visit (visitor, appData);
						m_dot_2.Visit (visitor, appData);
				break;
				case ObjectSetSpec.production_kind.g_ObjectSetSpec_4:
					// traverse syntax tree node associated with production
					// ObjectSetSpec: "." "." "." "," AdditionalElementSetSpec

						m_dot.Visit (visitor, appData);
						m_dot_1.Visit (visitor, appData);
						m_dot_2.Visit (visitor, appData);
						m_comma.Visit (visitor, appData);
						m_AdditionalElementSetSpec.Visit (visitor, appData);
				break;
				case ObjectSetSpec.production_kind.g_ObjectSetSpec_5:
					// traverse syntax tree node associated with production
					// ObjectSetSpec: RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

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
		// initialize object associated with syntax rule ObjectSetSpec
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
		#region Fields and properties associated with the syntax rule ObjectSetSpec

		// counter of all nodes associated with syntax rule ObjectSetSpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectSetSpec
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
		#region delegates and events associated with the syntax rule ObjectSetSpec

		// delegate function (callback) prototype associated with syntax rule ObjectSetSpec
		public delegate bool ObjectSetSpec_Callback (SyntaxTreeCallbackReason reason, ObjectSetSpec.production_kind kind, ObjectSetSpec p_ObjectSetSpec);

		// event associated with syntax rule ObjectSetSpec
		public event ObjectSetSpec_Callback ObjectSetSpec_Event;

		// event trigger associated with syntax rule ObjectSetSpec
		public bool Raise_ObjectSetSpec_Event (SyntaxTreeCallbackReason reason, ObjectSetSpec.production_kind kind, ObjectSetSpec p_ObjectSetSpec)
		{
			bool? status = ObjectSetSpec_Event?.Invoke (reason, kind, p_ObjectSetSpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectSetSpec
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetSpec
		//

		public void Traverse (ObjectSetSpec p_ObjectSetSpec)
		{
			if (p_ObjectSetSpec.isLocked())
				return;
			p_ObjectSetSpec.dolock();
			ObjectSetSpec.production_kind kind = (ObjectSetSpec.production_kind) p_ObjectSetSpec.kind;
			p_ObjectSetSpec.turn_reset ();
			if (Raise_ObjectSetSpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectSetSpec))
			switch (kind)
			{
				case ObjectSetSpec.production_kind.g_ObjectSetSpec_1:
					// traverse syntax tree node associated with production
					// ObjectSetSpec: RootElementSetSpec

					if (Raise_ObjectSetSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetSpec))
						Traverse (p_ObjectSetSpec.m_RootElementSetSpec);
					p_ObjectSetSpec.turn_inc ();
					Raise_ObjectSetSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetSpec);
				break;
				case ObjectSetSpec.production_kind.g_ObjectSetSpec_2:
					// traverse syntax tree node associated with production
					// ObjectSetSpec: RootElementSetSpec "," "." "." "."

					if (Raise_ObjectSetSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetSpec))
						Traverse (p_ObjectSetSpec.m_RootElementSetSpec);
					p_ObjectSetSpec.turn_inc ();
					Raise_ObjectSetSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetSpec);
				break;
				case ObjectSetSpec.production_kind.g_ObjectSetSpec_3:
					// traverse syntax tree node associated with production
					// ObjectSetSpec: "." "." "."

				break;
				case ObjectSetSpec.production_kind.g_ObjectSetSpec_4:
					// traverse syntax tree node associated with production
					// ObjectSetSpec: "." "." "." "," AdditionalElementSetSpec

					if (Raise_ObjectSetSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetSpec))
						Traverse (p_ObjectSetSpec.m_AdditionalElementSetSpec);
					p_ObjectSetSpec.turn_inc ();
					Raise_ObjectSetSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetSpec);
				break;
				case ObjectSetSpec.production_kind.g_ObjectSetSpec_5:
					// traverse syntax tree node associated with production
					// ObjectSetSpec: RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

					if (Raise_ObjectSetSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetSpec))
						Traverse (p_ObjectSetSpec.m_RootElementSetSpec);
					p_ObjectSetSpec.turn_inc ();
					if (Raise_ObjectSetSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetSpec))
						Traverse (p_ObjectSetSpec.m_AdditionalElementSetSpec);
					p_ObjectSetSpec.turn_inc ();
					Raise_ObjectSetSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetSpec);
				break;
			}
			Raise_ObjectSetSpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectSetSpec);
			p_ObjectSetSpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetSpec
		//

		public void TraverseCommon (ObjectSetSpec p_ObjectSetSpec)
		{
			ObjectSetSpec.production_kind kind = (ObjectSetSpec.production_kind) p_ObjectSetSpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectSetSpec))
			switch (kind)
			{
				case ObjectSetSpec.production_kind.g_ObjectSetSpec_1:
					// traverse syntax tree node associated with production
					// ObjectSetSpec: RootElementSetSpec

						TraverseCommon (p_ObjectSetSpec.m_RootElementSetSpec);
				break;
				case ObjectSetSpec.production_kind.g_ObjectSetSpec_2:
					// traverse syntax tree node associated with production
					// ObjectSetSpec: RootElementSetSpec "," "." "." "."

						TraverseCommon (p_ObjectSetSpec.m_RootElementSetSpec);
						TraverseCommon (p_ObjectSetSpec.m_comma);
						TraverseCommon (p_ObjectSetSpec.m_dot);
						TraverseCommon (p_ObjectSetSpec.m_dot_1);
						TraverseCommon (p_ObjectSetSpec.m_dot_2);
				break;
				case ObjectSetSpec.production_kind.g_ObjectSetSpec_3:
					// traverse syntax tree node associated with production
					// ObjectSetSpec: "." "." "."

						TraverseCommon (p_ObjectSetSpec.m_dot);
						TraverseCommon (p_ObjectSetSpec.m_dot_1);
						TraverseCommon (p_ObjectSetSpec.m_dot_2);
				break;
				case ObjectSetSpec.production_kind.g_ObjectSetSpec_4:
					// traverse syntax tree node associated with production
					// ObjectSetSpec: "." "." "." "," AdditionalElementSetSpec

						TraverseCommon (p_ObjectSetSpec.m_dot);
						TraverseCommon (p_ObjectSetSpec.m_dot_1);
						TraverseCommon (p_ObjectSetSpec.m_dot_2);
						TraverseCommon (p_ObjectSetSpec.m_comma);
						TraverseCommon (p_ObjectSetSpec.m_AdditionalElementSetSpec);
				break;
				case ObjectSetSpec.production_kind.g_ObjectSetSpec_5:
					// traverse syntax tree node associated with production
					// ObjectSetSpec: RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

						TraverseCommon (p_ObjectSetSpec.m_RootElementSetSpec);
						TraverseCommon (p_ObjectSetSpec.m_comma);
						TraverseCommon (p_ObjectSetSpec.m_dot);
						TraverseCommon (p_ObjectSetSpec.m_dot_1);
						TraverseCommon (p_ObjectSetSpec.m_dot_2);
						TraverseCommon (p_ObjectSetSpec.m_comma_1);
						TraverseCommon (p_ObjectSetSpec.m_AdditionalElementSetSpec);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectSetSpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectSetSpec

		//
		// create syntax tree node associated with production
		// ObjectSetSpec: RootElementSetSpec

		//

		public ObjectSetSpec ObjectSetSpec_1 (RootElementSetSpec p_RootElementSetSpec)
		{
			ObjectSetSpec p_ObjectSetSpec_ref = new ObjectSetSpec(p_RootElementSetSpec);
			p_RootElementSetSpec.parent = p_ObjectSetSpec_ref;
			Raise_ObjectSetSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectSetSpec.production_kind.g_ObjectSetSpec_1, p_ObjectSetSpec_ref);
			return p_ObjectSetSpec_ref;
		}

		//
		// create syntax tree node associated with production
		// ObjectSetSpec: RootElementSetSpec "," "." "." "."

		//

		public ObjectSetSpec ObjectSetSpec_2 (RootElementSetSpec p_RootElementSetSpec, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3)
		{
			ObjectSetSpec p_ObjectSetSpec_ref = new ObjectSetSpec(p_RootElementSetSpec, p_token, p_token_1, p_token_2, p_token_3);
			p_RootElementSetSpec.parent = p_ObjectSetSpec_ref;
			p_token.parent = p_ObjectSetSpec_ref;
			p_token_1.parent = p_ObjectSetSpec_ref;
			p_token_2.parent = p_ObjectSetSpec_ref;
			p_token_3.parent = p_ObjectSetSpec_ref;
			Raise_ObjectSetSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectSetSpec.production_kind.g_ObjectSetSpec_2, p_ObjectSetSpec_ref);
			return p_ObjectSetSpec_ref;
		}

		//
		// create syntax tree node associated with production
		// ObjectSetSpec: "." "." "."

		//

		public ObjectSetSpec ObjectSetSpec_3 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			ObjectSetSpec p_ObjectSetSpec_ref = new ObjectSetSpec(p_token, p_token_1, p_token_2);
			p_token.parent = p_ObjectSetSpec_ref;
			p_token_1.parent = p_ObjectSetSpec_ref;
			p_token_2.parent = p_ObjectSetSpec_ref;
			Raise_ObjectSetSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectSetSpec.production_kind.g_ObjectSetSpec_3, p_ObjectSetSpec_ref);
			return p_ObjectSetSpec_ref;
		}

		//
		// create syntax tree node associated with production
		// ObjectSetSpec: "." "." "." "," AdditionalElementSetSpec

		//

		public ObjectSetSpec ObjectSetSpec_4 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, AdditionalElementSetSpec p_AdditionalElementSetSpec)
		{
			ObjectSetSpec p_ObjectSetSpec_ref = new ObjectSetSpec(p_token, p_token_1, p_token_2, p_token_3, p_AdditionalElementSetSpec);
			p_token.parent = p_ObjectSetSpec_ref;
			p_token_1.parent = p_ObjectSetSpec_ref;
			p_token_2.parent = p_ObjectSetSpec_ref;
			p_token_3.parent = p_ObjectSetSpec_ref;
			p_AdditionalElementSetSpec.parent = p_ObjectSetSpec_ref;
			Raise_ObjectSetSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectSetSpec.production_kind.g_ObjectSetSpec_4, p_ObjectSetSpec_ref);
			return p_ObjectSetSpec_ref;
		}

		//
		// create syntax tree node associated with production
		// ObjectSetSpec: RootElementSetSpec "," "." "." "." "," AdditionalElementSetSpec

		//

		public ObjectSetSpec ObjectSetSpec_5 (RootElementSetSpec p_RootElementSetSpec, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, SyntaxTreeToken p_token_4, AdditionalElementSetSpec p_AdditionalElementSetSpec)
		{
			ObjectSetSpec p_ObjectSetSpec_ref = new ObjectSetSpec(p_RootElementSetSpec, p_token, p_token_1, p_token_2, p_token_3, p_token_4, p_AdditionalElementSetSpec);
			p_RootElementSetSpec.parent = p_ObjectSetSpec_ref;
			p_token.parent = p_ObjectSetSpec_ref;
			p_token_1.parent = p_ObjectSetSpec_ref;
			p_token_2.parent = p_ObjectSetSpec_ref;
			p_token_3.parent = p_ObjectSetSpec_ref;
			p_token_4.parent = p_ObjectSetSpec_ref;
			p_AdditionalElementSetSpec.parent = p_ObjectSetSpec_ref;
			Raise_ObjectSetSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectSetSpec.production_kind.g_ObjectSetSpec_5, p_ObjectSetSpec_ref);
			return p_ObjectSetSpec_ref;
		}
		#endregion
	};
}
