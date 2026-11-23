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
	// class associated with syntax rule FieldSpec
	//

	[DataContract]
	public class	FieldSpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule FieldSpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule FieldSpec
		{
			g_FieldSpec_1 = 1,	// TypeFieldSpec

			g_FieldSpec_2 = 2,	// FixedTypeValueFieldSpec

			g_FieldSpec_3 = 3,	// VariableTypeValueFieldSpec

			g_FieldSpec_4 = 4,	// FixedTypeValueSetFieldSpec

			g_FieldSpec_5 = 5,	// VariableTypeValueSetFieldSpec

			g_FieldSpec_6 = 6,	// ObjectFieldSpec

			g_FieldSpec_7 = 7,	// ObjectSetFieldSpec

		};
		#endregion
		#region production markers associated with the syntax rule FieldSpec

		// markers associated with production: FieldSpec -> TypeFieldSpec

		public enum production_marker_1 : ushort
		{
			m_TypeFieldSpec,
			final
		};

		// markers associated with production: FieldSpec -> FixedTypeValueFieldSpec

		public enum production_marker_2 : ushort
		{
			m_FixedTypeValueFieldSpec,
			final
		};

		// markers associated with production: FieldSpec -> VariableTypeValueFieldSpec

		public enum production_marker_3 : ushort
		{
			m_VariableTypeValueFieldSpec,
			final
		};

		// markers associated with production: FieldSpec -> FixedTypeValueSetFieldSpec

		public enum production_marker_4 : ushort
		{
			m_FixedTypeValueSetFieldSpec,
			final
		};

		// markers associated with production: FieldSpec -> VariableTypeValueSetFieldSpec

		public enum production_marker_5 : ushort
		{
			m_VariableTypeValueSetFieldSpec,
			final
		};

		// markers associated with production: FieldSpec -> ObjectFieldSpec

		public enum production_marker_6 : ushort
		{
			m_ObjectFieldSpec,
			final
		};

		// markers associated with production: FieldSpec -> ObjectSetFieldSpec

		public enum production_marker_7 : ushort
		{
			m_ObjectSetFieldSpec,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule FieldSpec

		// Constructor declaration(s) associated with production(s) of syntax rule FieldSpec

		//
		// Constructor associated with the following production(s)
		// FieldSpec -> TypeFieldSpec

		//

		public FieldSpec (TypeFieldSpec p_TypeFieldSpec) : base ((uint) ProductionID._FieldSpec_ID, (uint) production_kind.g_FieldSpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TypeFieldSpec = p_TypeFieldSpec;
		}

		//
		// Constructor associated with the following production(s)
		// FieldSpec -> FixedTypeValueFieldSpec

		//

		public FieldSpec (FixedTypeValueFieldSpec p_FixedTypeValueFieldSpec) : base ((uint) ProductionID._FieldSpec_ID, (uint) production_kind.g_FieldSpec_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_FixedTypeValueFieldSpec = p_FixedTypeValueFieldSpec;
		}

		//
		// Constructor associated with the following production(s)
		// FieldSpec -> VariableTypeValueFieldSpec

		//

		public FieldSpec (VariableTypeValueFieldSpec p_VariableTypeValueFieldSpec) : base ((uint) ProductionID._FieldSpec_ID, (uint) production_kind.g_FieldSpec_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_VariableTypeValueFieldSpec = p_VariableTypeValueFieldSpec;
		}

		//
		// Constructor associated with the following production(s)
		// FieldSpec -> FixedTypeValueSetFieldSpec

		//

		public FieldSpec (FixedTypeValueSetFieldSpec p_FixedTypeValueSetFieldSpec) : base ((uint) ProductionID._FieldSpec_ID, (uint) production_kind.g_FieldSpec_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_FixedTypeValueSetFieldSpec = p_FixedTypeValueSetFieldSpec;
		}

		//
		// Constructor associated with the following production(s)
		// FieldSpec -> VariableTypeValueSetFieldSpec

		//

		public FieldSpec (VariableTypeValueSetFieldSpec p_VariableTypeValueSetFieldSpec) : base ((uint) ProductionID._FieldSpec_ID, (uint) production_kind.g_FieldSpec_5)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_VariableTypeValueSetFieldSpec = p_VariableTypeValueSetFieldSpec;
		}

		//
		// Constructor associated with the following production(s)
		// FieldSpec -> ObjectFieldSpec

		//

		public FieldSpec (ObjectFieldSpec p_ObjectFieldSpec) : base ((uint) ProductionID._FieldSpec_ID, (uint) production_kind.g_FieldSpec_6)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjectFieldSpec = p_ObjectFieldSpec;
		}

		//
		// Constructor associated with the following production(s)
		// FieldSpec -> ObjectSetFieldSpec

		//

		public FieldSpec (ObjectSetFieldSpec p_ObjectSetFieldSpec) : base ((uint) ProductionID._FieldSpec_ID, (uint) production_kind.g_FieldSpec_7)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjectSetFieldSpec = p_ObjectSetFieldSpec;
		}

		public FieldSpec () { }

		// Copy constructor

		public FieldSpec (FieldSpec p_FieldSpec) : base (p_FieldSpec.id, p_FieldSpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_FieldSpec.appInfo;
			switch ((production_kind) p_FieldSpec.kind)
			{
				case production_kind.g_FieldSpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TypeFieldSpec = (p_FieldSpec.m_TypeFieldSpec != null) ? new TypeFieldSpec (p_FieldSpec.m_TypeFieldSpec) : null) != null) m_TypeFieldSpec.parent = this;
					break;
				case production_kind.g_FieldSpec_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_FixedTypeValueFieldSpec = (p_FieldSpec.m_FixedTypeValueFieldSpec != null) ? new FixedTypeValueFieldSpec (p_FieldSpec.m_FixedTypeValueFieldSpec) : null) != null) m_FixedTypeValueFieldSpec.parent = this;
					break;
				case production_kind.g_FieldSpec_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_VariableTypeValueFieldSpec = (p_FieldSpec.m_VariableTypeValueFieldSpec != null) ? new VariableTypeValueFieldSpec (p_FieldSpec.m_VariableTypeValueFieldSpec) : null) != null) m_VariableTypeValueFieldSpec.parent = this;
					break;
				case production_kind.g_FieldSpec_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_FixedTypeValueSetFieldSpec = (p_FieldSpec.m_FixedTypeValueSetFieldSpec != null) ? new FixedTypeValueSetFieldSpec (p_FieldSpec.m_FixedTypeValueSetFieldSpec) : null) != null) m_FixedTypeValueSetFieldSpec.parent = this;
					break;
				case production_kind.g_FieldSpec_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_VariableTypeValueSetFieldSpec = (p_FieldSpec.m_VariableTypeValueSetFieldSpec != null) ? new VariableTypeValueSetFieldSpec (p_FieldSpec.m_VariableTypeValueSetFieldSpec) : null) != null) m_VariableTypeValueSetFieldSpec.parent = this;
					break;
				case production_kind.g_FieldSpec_6:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectFieldSpec = (p_FieldSpec.m_ObjectFieldSpec != null) ? new ObjectFieldSpec (p_FieldSpec.m_ObjectFieldSpec) : null) != null) m_ObjectFieldSpec.parent = this;
					break;
				case production_kind.g_FieldSpec_7:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectSetFieldSpec = (p_FieldSpec.m_ObjectSetFieldSpec != null) ? new ObjectSetFieldSpec (p_FieldSpec.m_ObjectSetFieldSpec) : null) != null) m_ObjectSetFieldSpec.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "FieldSpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new FieldSpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_TypeFieldSpec?.Dispose ();
			m_FixedTypeValueFieldSpec?.Dispose ();
			m_VariableTypeValueFieldSpec?.Dispose ();
			m_FixedTypeValueSetFieldSpec?.Dispose ();
			m_VariableTypeValueSetFieldSpec?.Dispose ();
			m_ObjectFieldSpec?.Dispose ();
			m_ObjectSetFieldSpec?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule FieldSpec

		// Content changing function(s) associated with production(s) of syntax rule FieldSpec

		//
		// Content changing function associated with following production(s)
		// FieldSpec -> TypeFieldSpec

		//

		public void change(TypeFieldSpec p_TypeFieldSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_FieldSpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TypeFieldSpec = p_TypeFieldSpec;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// FieldSpec -> FixedTypeValueFieldSpec

		//

		public void change(FixedTypeValueFieldSpec p_FixedTypeValueFieldSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_FieldSpec_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_FixedTypeValueFieldSpec = p_FixedTypeValueFieldSpec;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// FieldSpec -> VariableTypeValueFieldSpec

		//

		public void change(VariableTypeValueFieldSpec p_VariableTypeValueFieldSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_FieldSpec_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_VariableTypeValueFieldSpec = p_VariableTypeValueFieldSpec;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// FieldSpec -> FixedTypeValueSetFieldSpec

		//

		public void change(FixedTypeValueSetFieldSpec p_FixedTypeValueSetFieldSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_FieldSpec_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_FixedTypeValueSetFieldSpec = p_FixedTypeValueSetFieldSpec;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// FieldSpec -> VariableTypeValueSetFieldSpec

		//

		public void change(VariableTypeValueSetFieldSpec p_VariableTypeValueSetFieldSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_FieldSpec_5;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_VariableTypeValueSetFieldSpec = p_VariableTypeValueSetFieldSpec;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// FieldSpec -> ObjectFieldSpec

		//

		public void change(ObjectFieldSpec p_ObjectFieldSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_FieldSpec_6;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjectFieldSpec = p_ObjectFieldSpec;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// FieldSpec -> ObjectSetFieldSpec

		//

		public void change(ObjectSetFieldSpec p_ObjectSetFieldSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_FieldSpec_7;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjectSetFieldSpec = p_ObjectSetFieldSpec;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule FieldSpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_TypeFieldSpec != null) && m_TypeFieldSpec.checkInclusion (element) ||
				(m_FixedTypeValueFieldSpec != null) && m_FixedTypeValueFieldSpec.checkInclusion (element) ||
				(m_VariableTypeValueFieldSpec != null) && m_VariableTypeValueFieldSpec.checkInclusion (element) ||
				(m_FixedTypeValueSetFieldSpec != null) && m_FixedTypeValueSetFieldSpec.checkInclusion (element) ||
				(m_VariableTypeValueSetFieldSpec != null) && m_VariableTypeValueSetFieldSpec.checkInclusion (element) ||
				(m_ObjectFieldSpec != null) && m_ObjectFieldSpec.checkInclusion (element) ||
				(m_ObjectSetFieldSpec != null) && m_ObjectSetFieldSpec.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule FieldSpec

		//
		// emit production tree node associated with any production of syntax rule FieldSpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_FieldSpec_1:
					// emit syntax tree node associated with production
					// FieldSpec: TypeFieldSpec

					s += m_TypeFieldSpec.Emit (depth - 1);
				break;
				case production_kind.g_FieldSpec_2:
					// emit syntax tree node associated with production
					// FieldSpec: FixedTypeValueFieldSpec

					s += m_FixedTypeValueFieldSpec.Emit (depth - 1);
				break;
				case production_kind.g_FieldSpec_3:
					// emit syntax tree node associated with production
					// FieldSpec: VariableTypeValueFieldSpec

					s += m_VariableTypeValueFieldSpec.Emit (depth - 1);
				break;
				case production_kind.g_FieldSpec_4:
					// emit syntax tree node associated with production
					// FieldSpec: FixedTypeValueSetFieldSpec

					s += m_FixedTypeValueSetFieldSpec.Emit (depth - 1);
				break;
				case production_kind.g_FieldSpec_5:
					// emit syntax tree node associated with production
					// FieldSpec: VariableTypeValueSetFieldSpec

					s += m_VariableTypeValueSetFieldSpec.Emit (depth - 1);
				break;
				case production_kind.g_FieldSpec_6:
					// emit syntax tree node associated with production
					// FieldSpec: ObjectFieldSpec

					s += m_ObjectFieldSpec.Emit (depth - 1);
				break;
				case production_kind.g_FieldSpec_7:
					// emit syntax tree node associated with production
					// FieldSpec: ObjectSetFieldSpec

					s += m_ObjectSetFieldSpec.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule FieldSpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "FieldSpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_FieldSpec_1:
					// emit syntax tree node associated with production
					// FieldSpec: TypeFieldSpec

					s += m_TypeFieldSpec.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_FieldSpec_2:
					// emit syntax tree node associated with production
					// FieldSpec: FixedTypeValueFieldSpec

					s += m_FixedTypeValueFieldSpec.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_FieldSpec_3:
					// emit syntax tree node associated with production
					// FieldSpec: VariableTypeValueFieldSpec

					s += m_VariableTypeValueFieldSpec.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_FieldSpec_4:
					// emit syntax tree node associated with production
					// FieldSpec: FixedTypeValueSetFieldSpec

					s += m_FixedTypeValueSetFieldSpec.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_FieldSpec_5:
					// emit syntax tree node associated with production
					// FieldSpec: VariableTypeValueSetFieldSpec

					s += m_VariableTypeValueSetFieldSpec.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_FieldSpec_6:
					// emit syntax tree node associated with production
					// FieldSpec: ObjectFieldSpec

					s += m_ObjectFieldSpec.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_FieldSpec_7:
					// emit syntax tree node associated with production
					// FieldSpec: ObjectSetFieldSpec

					s += m_ObjectSetFieldSpec.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule FieldSpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule FieldSpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			FieldSpec.production_kind kind = (FieldSpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case FieldSpec.production_kind.g_FieldSpec_1:
					// traverse syntax tree node associated with production
					// FieldSpec: TypeFieldSpec

						m_TypeFieldSpec.Visit (visitor, appData);
				break;
				case FieldSpec.production_kind.g_FieldSpec_2:
					// traverse syntax tree node associated with production
					// FieldSpec: FixedTypeValueFieldSpec

						m_FixedTypeValueFieldSpec.Visit (visitor, appData);
				break;
				case FieldSpec.production_kind.g_FieldSpec_3:
					// traverse syntax tree node associated with production
					// FieldSpec: VariableTypeValueFieldSpec

						m_VariableTypeValueFieldSpec.Visit (visitor, appData);
				break;
				case FieldSpec.production_kind.g_FieldSpec_4:
					// traverse syntax tree node associated with production
					// FieldSpec: FixedTypeValueSetFieldSpec

						m_FixedTypeValueSetFieldSpec.Visit (visitor, appData);
				break;
				case FieldSpec.production_kind.g_FieldSpec_5:
					// traverse syntax tree node associated with production
					// FieldSpec: VariableTypeValueSetFieldSpec

						m_VariableTypeValueSetFieldSpec.Visit (visitor, appData);
				break;
				case FieldSpec.production_kind.g_FieldSpec_6:
					// traverse syntax tree node associated with production
					// FieldSpec: ObjectFieldSpec

						m_ObjectFieldSpec.Visit (visitor, appData);
				break;
				case FieldSpec.production_kind.g_FieldSpec_7:
					// traverse syntax tree node associated with production
					// FieldSpec: ObjectSetFieldSpec

						m_ObjectSetFieldSpec.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_TypeFieldSpec?.reparent (this);
			m_FixedTypeValueFieldSpec?.reparent (this);
			m_VariableTypeValueFieldSpec?.reparent (this);
			m_FixedTypeValueSetFieldSpec?.reparent (this);
			m_VariableTypeValueSetFieldSpec?.reparent (this);
			m_ObjectFieldSpec?.reparent (this);
			m_ObjectSetFieldSpec?.reparent (this);
		}

		//
		// initialize object associated with syntax rule FieldSpec
		//

		public void _init ()
		{
			m_TypeFieldSpec = null;
			m_FixedTypeValueFieldSpec = null;
			m_VariableTypeValueFieldSpec = null;
			m_FixedTypeValueSetFieldSpec = null;
			m_VariableTypeValueSetFieldSpec = null;
			m_ObjectFieldSpec = null;
			m_ObjectSetFieldSpec = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule FieldSpec

		// counter of all nodes associated with syntax rule FieldSpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule FieldSpec
		[DataMember (Name = "m_TypeFieldSpec")] public TypeFieldSpec m_TypeFieldSpec { get; private set; }
		[DataMember (Name = "m_FixedTypeValueFieldSpec")] public FixedTypeValueFieldSpec m_FixedTypeValueFieldSpec { get; private set; }
		[DataMember (Name = "m_VariableTypeValueFieldSpec")] public VariableTypeValueFieldSpec m_VariableTypeValueFieldSpec { get; private set; }
		[DataMember (Name = "m_FixedTypeValueSetFieldSpec")] public FixedTypeValueSetFieldSpec m_FixedTypeValueSetFieldSpec { get; private set; }
		[DataMember (Name = "m_VariableTypeValueSetFieldSpec")] public VariableTypeValueSetFieldSpec m_VariableTypeValueSetFieldSpec { get; private set; }
		[DataMember (Name = "m_ObjectFieldSpec")] public ObjectFieldSpec m_ObjectFieldSpec { get; private set; }
		[DataMember (Name = "m_ObjectSetFieldSpec")] public ObjectSetFieldSpec m_ObjectSetFieldSpec { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule FieldSpec

		// delegate function (callback) prototype associated with syntax rule FieldSpec
		public delegate bool FieldSpec_Callback (SyntaxTreeCallbackReason reason, FieldSpec.production_kind kind, FieldSpec p_FieldSpec);

		// event associated with syntax rule FieldSpec
		public event FieldSpec_Callback FieldSpec_Event;

		// event trigger associated with syntax rule FieldSpec
		public bool Raise_FieldSpec_Event (SyntaxTreeCallbackReason reason, FieldSpec.production_kind kind, FieldSpec p_FieldSpec)
		{
			bool? status = FieldSpec_Event?.Invoke (reason, kind, p_FieldSpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule FieldSpec
		//
		// traverse syntax tree node associated with any production of syntax rule FieldSpec
		//

		public void Traverse (FieldSpec p_FieldSpec)
		{
			if (p_FieldSpec.isLocked())
				return;
			p_FieldSpec.dolock();
			FieldSpec.production_kind kind = (FieldSpec.production_kind) p_FieldSpec.kind;
			p_FieldSpec.turn_reset ();
			if (Raise_FieldSpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_FieldSpec))
			switch (kind)
			{
				case FieldSpec.production_kind.g_FieldSpec_1:
					// traverse syntax tree node associated with production
					// FieldSpec: TypeFieldSpec

					if (Raise_FieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FieldSpec))
						Traverse (p_FieldSpec.m_TypeFieldSpec);
					p_FieldSpec.turn_inc ();
					Raise_FieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FieldSpec);
				break;
				case FieldSpec.production_kind.g_FieldSpec_2:
					// traverse syntax tree node associated with production
					// FieldSpec: FixedTypeValueFieldSpec

					if (Raise_FieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FieldSpec))
						Traverse (p_FieldSpec.m_FixedTypeValueFieldSpec);
					p_FieldSpec.turn_inc ();
					Raise_FieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FieldSpec);
				break;
				case FieldSpec.production_kind.g_FieldSpec_3:
					// traverse syntax tree node associated with production
					// FieldSpec: VariableTypeValueFieldSpec

					if (Raise_FieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FieldSpec))
						Traverse (p_FieldSpec.m_VariableTypeValueFieldSpec);
					p_FieldSpec.turn_inc ();
					Raise_FieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FieldSpec);
				break;
				case FieldSpec.production_kind.g_FieldSpec_4:
					// traverse syntax tree node associated with production
					// FieldSpec: FixedTypeValueSetFieldSpec

					if (Raise_FieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FieldSpec))
						Traverse (p_FieldSpec.m_FixedTypeValueSetFieldSpec);
					p_FieldSpec.turn_inc ();
					Raise_FieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FieldSpec);
				break;
				case FieldSpec.production_kind.g_FieldSpec_5:
					// traverse syntax tree node associated with production
					// FieldSpec: VariableTypeValueSetFieldSpec

					if (Raise_FieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FieldSpec))
						Traverse (p_FieldSpec.m_VariableTypeValueSetFieldSpec);
					p_FieldSpec.turn_inc ();
					Raise_FieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FieldSpec);
				break;
				case FieldSpec.production_kind.g_FieldSpec_6:
					// traverse syntax tree node associated with production
					// FieldSpec: ObjectFieldSpec

					if (Raise_FieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FieldSpec))
						Traverse (p_FieldSpec.m_ObjectFieldSpec);
					p_FieldSpec.turn_inc ();
					Raise_FieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FieldSpec);
				break;
				case FieldSpec.production_kind.g_FieldSpec_7:
					// traverse syntax tree node associated with production
					// FieldSpec: ObjectSetFieldSpec

					if (Raise_FieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FieldSpec))
						Traverse (p_FieldSpec.m_ObjectSetFieldSpec);
					p_FieldSpec.turn_inc ();
					Raise_FieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FieldSpec);
				break;
			}
			Raise_FieldSpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_FieldSpec);
			p_FieldSpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule FieldSpec
		//

		public void TraverseCommon (FieldSpec p_FieldSpec)
		{
			FieldSpec.production_kind kind = (FieldSpec.production_kind) p_FieldSpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_FieldSpec))
			switch (kind)
			{
				case FieldSpec.production_kind.g_FieldSpec_1:
					// traverse syntax tree node associated with production
					// FieldSpec: TypeFieldSpec

						TraverseCommon (p_FieldSpec.m_TypeFieldSpec);
				break;
				case FieldSpec.production_kind.g_FieldSpec_2:
					// traverse syntax tree node associated with production
					// FieldSpec: FixedTypeValueFieldSpec

						TraverseCommon (p_FieldSpec.m_FixedTypeValueFieldSpec);
				break;
				case FieldSpec.production_kind.g_FieldSpec_3:
					// traverse syntax tree node associated with production
					// FieldSpec: VariableTypeValueFieldSpec

						TraverseCommon (p_FieldSpec.m_VariableTypeValueFieldSpec);
				break;
				case FieldSpec.production_kind.g_FieldSpec_4:
					// traverse syntax tree node associated with production
					// FieldSpec: FixedTypeValueSetFieldSpec

						TraverseCommon (p_FieldSpec.m_FixedTypeValueSetFieldSpec);
				break;
				case FieldSpec.production_kind.g_FieldSpec_5:
					// traverse syntax tree node associated with production
					// FieldSpec: VariableTypeValueSetFieldSpec

						TraverseCommon (p_FieldSpec.m_VariableTypeValueSetFieldSpec);
				break;
				case FieldSpec.production_kind.g_FieldSpec_6:
					// traverse syntax tree node associated with production
					// FieldSpec: ObjectFieldSpec

						TraverseCommon (p_FieldSpec.m_ObjectFieldSpec);
				break;
				case FieldSpec.production_kind.g_FieldSpec_7:
					// traverse syntax tree node associated with production
					// FieldSpec: ObjectSetFieldSpec

						TraverseCommon (p_FieldSpec.m_ObjectSetFieldSpec);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_FieldSpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule FieldSpec

		//
		// create syntax tree node associated with production
		// FieldSpec: TypeFieldSpec

		//

		public FieldSpec FieldSpec_1 (TypeFieldSpec p_TypeFieldSpec)
		{
			FieldSpec p_FieldSpec_ref = new FieldSpec(p_TypeFieldSpec);
			p_TypeFieldSpec.parent = p_FieldSpec_ref;
			Raise_FieldSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, FieldSpec.production_kind.g_FieldSpec_1, p_FieldSpec_ref);
			return p_FieldSpec_ref;
		}

		//
		// create syntax tree node associated with production
		// FieldSpec: FixedTypeValueFieldSpec

		//

		public FieldSpec FieldSpec_2 (FixedTypeValueFieldSpec p_FixedTypeValueFieldSpec)
		{
			FieldSpec p_FieldSpec_ref = new FieldSpec(p_FixedTypeValueFieldSpec);
			p_FixedTypeValueFieldSpec.parent = p_FieldSpec_ref;
			Raise_FieldSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, FieldSpec.production_kind.g_FieldSpec_2, p_FieldSpec_ref);
			return p_FieldSpec_ref;
		}

		//
		// create syntax tree node associated with production
		// FieldSpec: VariableTypeValueFieldSpec

		//

		public FieldSpec FieldSpec_3 (VariableTypeValueFieldSpec p_VariableTypeValueFieldSpec)
		{
			FieldSpec p_FieldSpec_ref = new FieldSpec(p_VariableTypeValueFieldSpec);
			p_VariableTypeValueFieldSpec.parent = p_FieldSpec_ref;
			Raise_FieldSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, FieldSpec.production_kind.g_FieldSpec_3, p_FieldSpec_ref);
			return p_FieldSpec_ref;
		}

		//
		// create syntax tree node associated with production
		// FieldSpec: FixedTypeValueSetFieldSpec

		//

		public FieldSpec FieldSpec_4 (FixedTypeValueSetFieldSpec p_FixedTypeValueSetFieldSpec)
		{
			FieldSpec p_FieldSpec_ref = new FieldSpec(p_FixedTypeValueSetFieldSpec);
			p_FixedTypeValueSetFieldSpec.parent = p_FieldSpec_ref;
			Raise_FieldSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, FieldSpec.production_kind.g_FieldSpec_4, p_FieldSpec_ref);
			return p_FieldSpec_ref;
		}

		//
		// create syntax tree node associated with production
		// FieldSpec: VariableTypeValueSetFieldSpec

		//

		public FieldSpec FieldSpec_5 (VariableTypeValueSetFieldSpec p_VariableTypeValueSetFieldSpec)
		{
			FieldSpec p_FieldSpec_ref = new FieldSpec(p_VariableTypeValueSetFieldSpec);
			p_VariableTypeValueSetFieldSpec.parent = p_FieldSpec_ref;
			Raise_FieldSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, FieldSpec.production_kind.g_FieldSpec_5, p_FieldSpec_ref);
			return p_FieldSpec_ref;
		}

		//
		// create syntax tree node associated with production
		// FieldSpec: ObjectFieldSpec

		//

		public FieldSpec FieldSpec_6 (ObjectFieldSpec p_ObjectFieldSpec)
		{
			FieldSpec p_FieldSpec_ref = new FieldSpec(p_ObjectFieldSpec);
			p_ObjectFieldSpec.parent = p_FieldSpec_ref;
			Raise_FieldSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, FieldSpec.production_kind.g_FieldSpec_6, p_FieldSpec_ref);
			return p_FieldSpec_ref;
		}

		//
		// create syntax tree node associated with production
		// FieldSpec: ObjectSetFieldSpec

		//

		public FieldSpec FieldSpec_7 (ObjectSetFieldSpec p_ObjectSetFieldSpec)
		{
			FieldSpec p_FieldSpec_ref = new FieldSpec(p_ObjectSetFieldSpec);
			p_ObjectSetFieldSpec.parent = p_FieldSpec_ref;
			Raise_FieldSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, FieldSpec.production_kind.g_FieldSpec_7, p_FieldSpec_ref);
			return p_FieldSpec_ref;
		}
		#endregion
	};
}
