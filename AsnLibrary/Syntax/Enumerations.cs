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
	// class associated with syntax rule Enumerations
	//

	[DataContract]
	public class	Enumerations : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Enumerations
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Enumerations
		{
			g_Enumerations_1 = 1,	// RootEnumeration

			g_Enumerations_2 = 2,	// RootEnumeration "," "." "." "." ExceptionSpec

			g_Enumerations_3 = 3,	// RootEnumeration "," "." "." "." ExceptionSpec "," AdditionalEnumeration

		};
		#endregion
		#region production markers associated with the syntax rule Enumerations

		// markers associated with production: Enumerations -> RootEnumeration

		public enum production_marker_1 : ushort
		{
			m_RootEnumeration,
			final
		};

		// markers associated with production: Enumerations -> RootEnumeration "," "." "." "." ExceptionSpec

		public enum production_marker_2 : ushort
		{
			m_RootEnumeration,
			m_ExceptionSpec,
			final
		};

		// markers associated with production: Enumerations -> RootEnumeration "," "." "." "." ExceptionSpec "," AdditionalEnumeration

		public enum production_marker_3 : ushort
		{
			m_RootEnumeration,
			m_ExceptionSpec,
			m_AdditionalEnumeration,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Enumerations

		// Constructor declaration(s) associated with production(s) of syntax rule Enumerations

		//
		// Constructor associated with the following production(s)
		// Enumerations -> RootEnumeration

		//

		public Enumerations (RootEnumeration p_RootEnumeration) : base ((uint) ProductionID._Enumerations_ID, (uint) production_kind.g_Enumerations_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_RootEnumeration = p_RootEnumeration;
		}

		//
		// Constructor associated with the following production(s)
		// Enumerations -> RootEnumeration "," "." "." "." ExceptionSpec

		//

		public Enumerations (RootEnumeration p_RootEnumeration, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, ExceptionSpec p_ExceptionSpec) : base ((uint) ProductionID._Enumerations_ID, (uint) production_kind.g_Enumerations_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 6);
			children[0] = m_RootEnumeration = p_RootEnumeration;
			children[1] = m_comma = p_token;
			children[2] = m_dot = p_token_1;
			children[3] = m_dot_1 = p_token_2;
			children[4] = m_dot_2 = p_token_3;
			children[5] = m_ExceptionSpec = p_ExceptionSpec;
		}

		//
		// Constructor associated with the following production(s)
		// Enumerations -> RootEnumeration "," "." "." "." ExceptionSpec "," AdditionalEnumeration

		//

		public Enumerations (RootEnumeration p_RootEnumeration, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, ExceptionSpec p_ExceptionSpec, SyntaxTreeToken p_token_4, AdditionalEnumeration p_AdditionalEnumeration) : base ((uint) ProductionID._Enumerations_ID, (uint) production_kind.g_Enumerations_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 8);
			children[0] = m_RootEnumeration = p_RootEnumeration;
			children[1] = m_comma = p_token;
			children[2] = m_dot = p_token_1;
			children[3] = m_dot_1 = p_token_2;
			children[4] = m_dot_2 = p_token_3;
			children[5] = m_ExceptionSpec = p_ExceptionSpec;
			children[6] = m_comma_1 = p_token_4;
			children[7] = m_AdditionalEnumeration = p_AdditionalEnumeration;
		}

		public Enumerations () { }

		// Copy constructor

		public Enumerations (Enumerations p_Enumerations) : base (p_Enumerations.id, p_Enumerations.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Enumerations.appInfo;
			switch ((production_kind) p_Enumerations.kind)
			{
				case production_kind.g_Enumerations_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RootEnumeration = (p_Enumerations.m_RootEnumeration != null) ? new RootEnumeration (p_Enumerations.m_RootEnumeration) : null) != null) m_RootEnumeration.parent = this;
					break;
				case production_kind.g_Enumerations_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 6);
					if ((children [0] = m_RootEnumeration = (p_Enumerations.m_RootEnumeration != null) ? new RootEnumeration (p_Enumerations.m_RootEnumeration) : null) != null) m_RootEnumeration.parent = this;
					if ((children [1] = m_comma = (p_Enumerations.m_comma != null) ? new SyntaxTreeToken (p_Enumerations.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_dot = (p_Enumerations.m_dot != null) ? new SyntaxTreeToken (p_Enumerations.m_dot) : null) != null) m_dot.parent = this;
					if ((children [3] = m_dot_1 = (p_Enumerations.m_dot_1 != null) ? new SyntaxTreeToken (p_Enumerations.m_dot_1) : null) != null) m_dot_1.parent = this;
					if ((children [4] = m_dot_2 = (p_Enumerations.m_dot_2 != null) ? new SyntaxTreeToken (p_Enumerations.m_dot_2) : null) != null) m_dot_2.parent = this;
					if ((children [5] = m_ExceptionSpec = (p_Enumerations.m_ExceptionSpec != null) ? new ExceptionSpec (p_Enumerations.m_ExceptionSpec) : null) != null) m_ExceptionSpec.parent = this;
					break;
				case production_kind.g_Enumerations_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 8);
					if ((children [0] = m_RootEnumeration = (p_Enumerations.m_RootEnumeration != null) ? new RootEnumeration (p_Enumerations.m_RootEnumeration) : null) != null) m_RootEnumeration.parent = this;
					if ((children [1] = m_comma = (p_Enumerations.m_comma != null) ? new SyntaxTreeToken (p_Enumerations.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_dot = (p_Enumerations.m_dot != null) ? new SyntaxTreeToken (p_Enumerations.m_dot) : null) != null) m_dot.parent = this;
					if ((children [3] = m_dot_1 = (p_Enumerations.m_dot_1 != null) ? new SyntaxTreeToken (p_Enumerations.m_dot_1) : null) != null) m_dot_1.parent = this;
					if ((children [4] = m_dot_2 = (p_Enumerations.m_dot_2 != null) ? new SyntaxTreeToken (p_Enumerations.m_dot_2) : null) != null) m_dot_2.parent = this;
					if ((children [5] = m_ExceptionSpec = (p_Enumerations.m_ExceptionSpec != null) ? new ExceptionSpec (p_Enumerations.m_ExceptionSpec) : null) != null) m_ExceptionSpec.parent = this;
					if ((children [6] = m_comma_1 = (p_Enumerations.m_comma_1 != null) ? new SyntaxTreeToken (p_Enumerations.m_comma_1) : null) != null) m_comma_1.parent = this;
					if ((children [7] = m_AdditionalEnumeration = (p_Enumerations.m_AdditionalEnumeration != null) ? new AdditionalEnumeration (p_Enumerations.m_AdditionalEnumeration) : null) != null) m_AdditionalEnumeration.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Enumerations" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Enumerations (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_RootEnumeration?.Dispose ();
			m_comma?.Dispose ();
			m_comma_1?.Dispose ();
			m_dot?.Dispose ();
			m_dot_1?.Dispose ();
			m_dot_2?.Dispose ();
			m_ExceptionSpec?.Dispose ();
			m_AdditionalEnumeration?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Enumerations

		// Content changing function(s) associated with production(s) of syntax rule Enumerations

		//
		// Content changing function associated with following production(s)
		// Enumerations -> RootEnumeration

		//

		public void change(RootEnumeration p_RootEnumeration)
		{
			_init ();
			this.kind = (uint) production_kind.g_Enumerations_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_RootEnumeration = p_RootEnumeration;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Enumerations -> RootEnumeration "," "." "." "." ExceptionSpec

		//

		public void change(RootEnumeration p_RootEnumeration, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, ExceptionSpec p_ExceptionSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_Enumerations_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 6);
			children [0] = m_RootEnumeration = p_RootEnumeration;
			children [1] = m_comma = p_token;
			children [2] = m_dot = p_token_1;
			children [3] = m_dot_1 = p_token_2;
			children [4] = m_dot_2 = p_token_3;
			children [5] = m_ExceptionSpec = p_ExceptionSpec;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Enumerations -> RootEnumeration "," "." "." "." ExceptionSpec "," AdditionalEnumeration

		//

		public void change(RootEnumeration p_RootEnumeration, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, ExceptionSpec p_ExceptionSpec, SyntaxTreeToken p_token_4, AdditionalEnumeration p_AdditionalEnumeration)
		{
			_init ();
			this.kind = (uint) production_kind.g_Enumerations_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 8);
			children [0] = m_RootEnumeration = p_RootEnumeration;
			children [1] = m_comma = p_token;
			children [2] = m_dot = p_token_1;
			children [3] = m_dot_1 = p_token_2;
			children [4] = m_dot_2 = p_token_3;
			children [5] = m_ExceptionSpec = p_ExceptionSpec;
			children [6] = m_comma_1 = p_token_4;
			children [7] = m_AdditionalEnumeration = p_AdditionalEnumeration;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Enumerations
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_RootEnumeration != null) && m_RootEnumeration.checkInclusion (element) ||
				(m_comma != null) && m_comma.checkInclusion (element) ||
				(m_comma_1 != null) && m_comma_1.checkInclusion (element) ||
				(m_dot != null) && m_dot.checkInclusion (element) ||
				(m_dot_1 != null) && m_dot_1.checkInclusion (element) ||
				(m_dot_2 != null) && m_dot_2.checkInclusion (element) ||
				(m_ExceptionSpec != null) && m_ExceptionSpec.checkInclusion (element) ||
				(m_AdditionalEnumeration != null) && m_AdditionalEnumeration.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Enumerations

		//
		// emit production tree node associated with any production of syntax rule Enumerations
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Enumerations_1:
					// emit syntax tree node associated with production
					// Enumerations: RootEnumeration

					s += m_RootEnumeration.Emit (depth - 1);
				break;
				case production_kind.g_Enumerations_2:
					// emit syntax tree node associated with production
					// Enumerations: RootEnumeration "," "." "." "." ExceptionSpec

					s += m_RootEnumeration.Emit (depth - 1);
					s += " ";
					s += m_comma.Emit (depth - 1);
					s += " ";
					s += m_dot.Emit (depth - 1);
					s += " ";
					s += m_dot_1.Emit (depth - 1);
					s += " ";
					s += m_dot_2.Emit (depth - 1);
					s += " ";
					s += m_ExceptionSpec.Emit (depth - 1);
				break;
				case production_kind.g_Enumerations_3:
					// emit syntax tree node associated with production
					// Enumerations: RootEnumeration "," "." "." "." ExceptionSpec "," AdditionalEnumeration

					s += m_RootEnumeration.Emit (depth - 1);
					s += " ";
					s += m_comma.Emit (depth - 1);
					s += " ";
					s += m_dot.Emit (depth - 1);
					s += " ";
					s += m_dot_1.Emit (depth - 1);
					s += " ";
					s += m_dot_2.Emit (depth - 1);
					s += " ";
					s += m_ExceptionSpec.Emit (depth - 1);
					s += " ";
					s += m_comma_1.Emit (depth - 1);
					s += " ";
					s += m_AdditionalEnumeration.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Enumerations
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Enumerations (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Enumerations_1:
					// emit syntax tree node associated with production
					// Enumerations: RootEnumeration

					s += m_RootEnumeration.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Enumerations_2:
					// emit syntax tree node associated with production
					// Enumerations: RootEnumeration "," "." "." "." ExceptionSpec

					s += m_RootEnumeration.EmitProductionTree (depth - 1);
					s += ' ';
					s += "comma";
					s += ' ';
					s += "dot";
					s += ' ';
					s += "dot";
					s += ' ';
					s += "dot";
					s += ' ';
					s += m_ExceptionSpec.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Enumerations_3:
					// emit syntax tree node associated with production
					// Enumerations: RootEnumeration "," "." "." "." ExceptionSpec "," AdditionalEnumeration

					s += m_RootEnumeration.EmitProductionTree (depth - 1);
					s += ' ';
					s += "comma";
					s += ' ';
					s += "dot";
					s += ' ';
					s += "dot";
					s += ' ';
					s += "dot";
					s += ' ';
					s += m_ExceptionSpec.EmitProductionTree (depth - 1);
					s += ' ';
					s += "comma";
					s += ' ';
					s += m_AdditionalEnumeration.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Enumerations

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Enumerations with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Enumerations.production_kind kind = (Enumerations.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Enumerations.production_kind.g_Enumerations_1:
					// traverse syntax tree node associated with production
					// Enumerations: RootEnumeration

						m_RootEnumeration.Visit (visitor, appData);
				break;
				case Enumerations.production_kind.g_Enumerations_2:
					// traverse syntax tree node associated with production
					// Enumerations: RootEnumeration "," "." "." "." ExceptionSpec

						m_RootEnumeration.Visit (visitor, appData);
						m_comma.Visit (visitor, appData);
						m_dot.Visit (visitor, appData);
						m_dot_1.Visit (visitor, appData);
						m_dot_2.Visit (visitor, appData);
						m_ExceptionSpec.Visit (visitor, appData);
				break;
				case Enumerations.production_kind.g_Enumerations_3:
					// traverse syntax tree node associated with production
					// Enumerations: RootEnumeration "," "." "." "." ExceptionSpec "," AdditionalEnumeration

						m_RootEnumeration.Visit (visitor, appData);
						m_comma.Visit (visitor, appData);
						m_dot.Visit (visitor, appData);
						m_dot_1.Visit (visitor, appData);
						m_dot_2.Visit (visitor, appData);
						m_ExceptionSpec.Visit (visitor, appData);
						m_comma_1.Visit (visitor, appData);
						m_AdditionalEnumeration.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_RootEnumeration?.reparent (this);
			m_comma?.reparent (this);
			m_comma_1?.reparent (this);

			m_dot?.reparent (this);
			m_dot_1?.reparent (this);

			m_dot_2?.reparent (this);

			m_ExceptionSpec?.reparent (this);
			m_AdditionalEnumeration?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Enumerations
		//

		public void _init ()
		{
			m_RootEnumeration = null;
			m_comma = null;
			m_comma_1 = null;
			m_dot = null;
			m_dot_1 = null;
			m_dot_2 = null;
			m_ExceptionSpec = null;
			m_AdditionalEnumeration = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Enumerations

		// counter of all nodes associated with syntax rule Enumerations
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Enumerations
		[DataMember (Name = "m_RootEnumeration")] public RootEnumeration m_RootEnumeration { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		[DataMember (Name = "m_comma_1")] public SyntaxTreeToken m_comma_1 { get; private set; }
		[DataMember (Name = "m_dot")] public SyntaxTreeToken m_dot { get; private set; }
		[DataMember (Name = "m_dot_1")] public SyntaxTreeToken m_dot_1 { get; private set; }
		[DataMember (Name = "m_dot_2")] public SyntaxTreeToken m_dot_2 { get; private set; }
		[DataMember (Name = "m_ExceptionSpec")] public ExceptionSpec m_ExceptionSpec { get; private set; }
		[DataMember (Name = "m_AdditionalEnumeration")] public AdditionalEnumeration m_AdditionalEnumeration { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Enumerations

		// delegate function (callback) prototype associated with syntax rule Enumerations
		public delegate bool Enumerations_Callback (SyntaxTreeCallbackReason reason, Enumerations.production_kind kind, Enumerations p_Enumerations);

		// event associated with syntax rule Enumerations
		public event Enumerations_Callback Enumerations_Event;

		// event trigger associated with syntax rule Enumerations
		public bool Raise_Enumerations_Event (SyntaxTreeCallbackReason reason, Enumerations.production_kind kind, Enumerations p_Enumerations)
		{
			bool? status = Enumerations_Event?.Invoke (reason, kind, p_Enumerations);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Enumerations
		//
		// traverse syntax tree node associated with any production of syntax rule Enumerations
		//

		public void Traverse (Enumerations p_Enumerations)
		{
			if (p_Enumerations.isLocked())
				return;
			p_Enumerations.dolock();
			Enumerations.production_kind kind = (Enumerations.production_kind) p_Enumerations.kind;
			p_Enumerations.turn_reset ();
			if (Raise_Enumerations_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Enumerations))
			switch (kind)
			{
				case Enumerations.production_kind.g_Enumerations_1:
					// traverse syntax tree node associated with production
					// Enumerations: RootEnumeration

					if (Raise_Enumerations_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Enumerations))
						Traverse (p_Enumerations.m_RootEnumeration);
					p_Enumerations.turn_inc ();
					Raise_Enumerations_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Enumerations);
				break;
				case Enumerations.production_kind.g_Enumerations_2:
					// traverse syntax tree node associated with production
					// Enumerations: RootEnumeration "," "." "." "." ExceptionSpec

					if (Raise_Enumerations_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Enumerations))
						Traverse (p_Enumerations.m_RootEnumeration);
					p_Enumerations.turn_inc ();
					if (Raise_Enumerations_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Enumerations))
						Traverse (p_Enumerations.m_ExceptionSpec);
					p_Enumerations.turn_inc ();
					Raise_Enumerations_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Enumerations);
				break;
				case Enumerations.production_kind.g_Enumerations_3:
					// traverse syntax tree node associated with production
					// Enumerations: RootEnumeration "," "." "." "." ExceptionSpec "," AdditionalEnumeration

					if (Raise_Enumerations_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Enumerations))
						Traverse (p_Enumerations.m_RootEnumeration);
					p_Enumerations.turn_inc ();
					if (Raise_Enumerations_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Enumerations))
						Traverse (p_Enumerations.m_ExceptionSpec);
					p_Enumerations.turn_inc ();
					if (Raise_Enumerations_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Enumerations))
						Traverse (p_Enumerations.m_AdditionalEnumeration);
					p_Enumerations.turn_inc ();
					Raise_Enumerations_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Enumerations);
				break;
			}
			Raise_Enumerations_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Enumerations);
			p_Enumerations.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Enumerations
		//

		public void TraverseCommon (Enumerations p_Enumerations)
		{
			Enumerations.production_kind kind = (Enumerations.production_kind) p_Enumerations.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Enumerations))
			switch (kind)
			{
				case Enumerations.production_kind.g_Enumerations_1:
					// traverse syntax tree node associated with production
					// Enumerations: RootEnumeration

						TraverseCommon (p_Enumerations.m_RootEnumeration);
				break;
				case Enumerations.production_kind.g_Enumerations_2:
					// traverse syntax tree node associated with production
					// Enumerations: RootEnumeration "," "." "." "." ExceptionSpec

						TraverseCommon (p_Enumerations.m_RootEnumeration);
						TraverseCommon (p_Enumerations.m_comma);
						TraverseCommon (p_Enumerations.m_dot);
						TraverseCommon (p_Enumerations.m_dot_1);
						TraverseCommon (p_Enumerations.m_dot_2);
						TraverseCommon (p_Enumerations.m_ExceptionSpec);
				break;
				case Enumerations.production_kind.g_Enumerations_3:
					// traverse syntax tree node associated with production
					// Enumerations: RootEnumeration "," "." "." "." ExceptionSpec "," AdditionalEnumeration

						TraverseCommon (p_Enumerations.m_RootEnumeration);
						TraverseCommon (p_Enumerations.m_comma);
						TraverseCommon (p_Enumerations.m_dot);
						TraverseCommon (p_Enumerations.m_dot_1);
						TraverseCommon (p_Enumerations.m_dot_2);
						TraverseCommon (p_Enumerations.m_ExceptionSpec);
						TraverseCommon (p_Enumerations.m_comma_1);
						TraverseCommon (p_Enumerations.m_AdditionalEnumeration);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Enumerations);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Enumerations

		//
		// create syntax tree node associated with production
		// Enumerations: RootEnumeration

		//

		public Enumerations Enumerations_1 (RootEnumeration p_RootEnumeration)
		{
			Enumerations p_Enumerations_ref = new Enumerations(p_RootEnumeration);
			p_RootEnumeration.parent = p_Enumerations_ref;
			Raise_Enumerations_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Enumerations.production_kind.g_Enumerations_1, p_Enumerations_ref);
			return p_Enumerations_ref;
		}

		//
		// create syntax tree node associated with production
		// Enumerations: RootEnumeration "," "." "." "." ExceptionSpec

		//

		public Enumerations Enumerations_2 (RootEnumeration p_RootEnumeration, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, ExceptionSpec p_ExceptionSpec)
		{
			Enumerations p_Enumerations_ref = new Enumerations(p_RootEnumeration, p_token, p_token_1, p_token_2, p_token_3, p_ExceptionSpec);
			p_RootEnumeration.parent = p_Enumerations_ref;
			p_token.parent = p_Enumerations_ref;
			p_token_1.parent = p_Enumerations_ref;
			p_token_2.parent = p_Enumerations_ref;
			p_token_3.parent = p_Enumerations_ref;
			p_ExceptionSpec.parent = p_Enumerations_ref;
			Raise_Enumerations_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Enumerations.production_kind.g_Enumerations_2, p_Enumerations_ref);
			return p_Enumerations_ref;
		}

		//
		// create syntax tree node associated with production
		// Enumerations: RootEnumeration "," "." "." "." ExceptionSpec "," AdditionalEnumeration

		//

		public Enumerations Enumerations_3 (RootEnumeration p_RootEnumeration, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, ExceptionSpec p_ExceptionSpec, SyntaxTreeToken p_token_4, AdditionalEnumeration p_AdditionalEnumeration)
		{
			Enumerations p_Enumerations_ref = new Enumerations(p_RootEnumeration, p_token, p_token_1, p_token_2, p_token_3, p_ExceptionSpec, p_token_4, p_AdditionalEnumeration);
			p_RootEnumeration.parent = p_Enumerations_ref;
			p_token.parent = p_Enumerations_ref;
			p_token_1.parent = p_Enumerations_ref;
			p_token_2.parent = p_Enumerations_ref;
			p_token_3.parent = p_Enumerations_ref;
			p_ExceptionSpec.parent = p_Enumerations_ref;
			p_token_4.parent = p_Enumerations_ref;
			p_AdditionalEnumeration.parent = p_Enumerations_ref;
			Raise_Enumerations_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Enumerations.production_kind.g_Enumerations_3, p_Enumerations_ref);
			return p_Enumerations_ref;
		}
		#endregion
	};
}
