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
	// class associated with syntax rule Assignment
	//

	[DataContract]
	public class	Assignment : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Assignment
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Assignment
		{
			g_Assignment_1 = 1,	// TypeAssignment

			g_Assignment_2 = 2,	// ValueAssignment

			g_Assignment_3 = 3,	// XMLValueAssignment

			g_Assignment_4 = 4,	// ValueSetTypeAssignment

			g_Assignment_5 = 5,	// ObjectClassAssignment

			g_Assignment_6 = 6,	// ObjectAssignment

			g_Assignment_7 = 7,	// ObjectSetAssignment

			g_Assignment_8 = 8,	// ParameterizedAssignment

			g_Assignment_9 = 9,	// MacroAssignment

			g_Assignment_10 = 10,	// MacroDefinition

		};
		#endregion
		#region production markers associated with the syntax rule Assignment

		// markers associated with production: Assignment -> TypeAssignment

		public enum production_marker_1 : ushort
		{
			m_TypeAssignment,
			final
		};

		// markers associated with production: Assignment -> ValueAssignment

		public enum production_marker_2 : ushort
		{
			m_ValueAssignment,
			final
		};

		// markers associated with production: Assignment -> XMLValueAssignment

		public enum production_marker_3 : ushort
		{
			m_XMLValueAssignment,
			final
		};

		// markers associated with production: Assignment -> ValueSetTypeAssignment

		public enum production_marker_4 : ushort
		{
			m_ValueSetTypeAssignment,
			final
		};

		// markers associated with production: Assignment -> ObjectClassAssignment

		public enum production_marker_5 : ushort
		{
			m_ObjectClassAssignment,
			final
		};

		// markers associated with production: Assignment -> ObjectAssignment

		public enum production_marker_6 : ushort
		{
			m_ObjectAssignment,
			final
		};

		// markers associated with production: Assignment -> ObjectSetAssignment

		public enum production_marker_7 : ushort
		{
			m_ObjectSetAssignment,
			final
		};

		// markers associated with production: Assignment -> ParameterizedAssignment

		public enum production_marker_8 : ushort
		{
			m_ParameterizedAssignment,
			final
		};

		// markers associated with production: Assignment -> MacroAssignment

		public enum production_marker_9 : ushort
		{
			m_MacroAssignment,
			final
		};

		// markers associated with production: Assignment -> MacroDefinition

		public enum production_marker_10 : ushort
		{
			m_MacroDefinition,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Assignment

		// Constructor declaration(s) associated with production(s) of syntax rule Assignment

		//
		// Constructor associated with the following production(s)
		// Assignment -> TypeAssignment

		//

		public Assignment (TypeAssignment p_TypeAssignment) : base ((uint) ProductionID._Assignment_ID, (uint) production_kind.g_Assignment_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TypeAssignment = p_TypeAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// Assignment -> ValueAssignment

		//

		public Assignment (ValueAssignment p_ValueAssignment) : base ((uint) ProductionID._Assignment_ID, (uint) production_kind.g_Assignment_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ValueAssignment = p_ValueAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// Assignment -> XMLValueAssignment

		//

		public Assignment (XMLValueAssignment p_XMLValueAssignment) : base ((uint) ProductionID._Assignment_ID, (uint) production_kind.g_Assignment_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLValueAssignment = p_XMLValueAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// Assignment -> ValueSetTypeAssignment

		//

		public Assignment (ValueSetTypeAssignment p_ValueSetTypeAssignment) : base ((uint) ProductionID._Assignment_ID, (uint) production_kind.g_Assignment_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ValueSetTypeAssignment = p_ValueSetTypeAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// Assignment -> ObjectClassAssignment

		//

		public Assignment (ObjectClassAssignment p_ObjectClassAssignment) : base ((uint) ProductionID._Assignment_ID, (uint) production_kind.g_Assignment_5)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjectClassAssignment = p_ObjectClassAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// Assignment -> ObjectAssignment

		//

		public Assignment (ObjectAssignment p_ObjectAssignment) : base ((uint) ProductionID._Assignment_ID, (uint) production_kind.g_Assignment_6)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjectAssignment = p_ObjectAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// Assignment -> ObjectSetAssignment

		//

		public Assignment (ObjectSetAssignment p_ObjectSetAssignment) : base ((uint) ProductionID._Assignment_ID, (uint) production_kind.g_Assignment_7)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjectSetAssignment = p_ObjectSetAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// Assignment -> ParameterizedAssignment

		//

		public Assignment (ParameterizedAssignment p_ParameterizedAssignment) : base ((uint) ProductionID._Assignment_ID, (uint) production_kind.g_Assignment_8)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ParameterizedAssignment = p_ParameterizedAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// Assignment -> MacroAssignment

		//

		public Assignment (MacroAssignment p_MacroAssignment) : base ((uint) ProductionID._Assignment_ID, (uint) production_kind.g_Assignment_9)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_MacroAssignment = p_MacroAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// Assignment -> MacroDefinition

		//

		public Assignment (MacroDefinition p_MacroDefinition) : base ((uint) ProductionID._Assignment_ID, (uint) production_kind.g_Assignment_10)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_MacroDefinition = p_MacroDefinition;
		}

		public Assignment () { }

		// Copy constructor

		public Assignment (Assignment p_Assignment) : base (p_Assignment.id, p_Assignment.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Assignment.appInfo;
			switch ((production_kind) p_Assignment.kind)
			{
				case production_kind.g_Assignment_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TypeAssignment = (p_Assignment.m_TypeAssignment != null) ? new TypeAssignment (p_Assignment.m_TypeAssignment) : null) != null) m_TypeAssignment.parent = this;
					break;
				case production_kind.g_Assignment_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ValueAssignment = (p_Assignment.m_ValueAssignment != null) ? new ValueAssignment (p_Assignment.m_ValueAssignment) : null) != null) m_ValueAssignment.parent = this;
					break;
				case production_kind.g_Assignment_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLValueAssignment = (p_Assignment.m_XMLValueAssignment != null) ? new XMLValueAssignment (p_Assignment.m_XMLValueAssignment) : null) != null) m_XMLValueAssignment.parent = this;
					break;
				case production_kind.g_Assignment_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ValueSetTypeAssignment = (p_Assignment.m_ValueSetTypeAssignment != null) ? new ValueSetTypeAssignment (p_Assignment.m_ValueSetTypeAssignment) : null) != null) m_ValueSetTypeAssignment.parent = this;
					break;
				case production_kind.g_Assignment_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectClassAssignment = (p_Assignment.m_ObjectClassAssignment != null) ? new ObjectClassAssignment (p_Assignment.m_ObjectClassAssignment) : null) != null) m_ObjectClassAssignment.parent = this;
					break;
				case production_kind.g_Assignment_6:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectAssignment = (p_Assignment.m_ObjectAssignment != null) ? new ObjectAssignment (p_Assignment.m_ObjectAssignment) : null) != null) m_ObjectAssignment.parent = this;
					break;
				case production_kind.g_Assignment_7:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectSetAssignment = (p_Assignment.m_ObjectSetAssignment != null) ? new ObjectSetAssignment (p_Assignment.m_ObjectSetAssignment) : null) != null) m_ObjectSetAssignment.parent = this;
					break;
				case production_kind.g_Assignment_8:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ParameterizedAssignment = (p_Assignment.m_ParameterizedAssignment != null) ? new ParameterizedAssignment (p_Assignment.m_ParameterizedAssignment) : null) != null) m_ParameterizedAssignment.parent = this;
					break;
				case production_kind.g_Assignment_9:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MacroAssignment = (p_Assignment.m_MacroAssignment != null) ? new MacroAssignment (p_Assignment.m_MacroAssignment) : null) != null) m_MacroAssignment.parent = this;
					break;
				case production_kind.g_Assignment_10:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MacroDefinition = (p_Assignment.m_MacroDefinition != null) ? new MacroDefinition (p_Assignment.m_MacroDefinition) : null) != null) m_MacroDefinition.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Assignment" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Assignment (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_TypeAssignment?.Dispose ();
			m_ValueAssignment?.Dispose ();
			m_XMLValueAssignment?.Dispose ();
			m_ValueSetTypeAssignment?.Dispose ();
			m_ObjectClassAssignment?.Dispose ();
			m_ObjectAssignment?.Dispose ();
			m_ObjectSetAssignment?.Dispose ();
			m_ParameterizedAssignment?.Dispose ();
			m_MacroAssignment?.Dispose ();
			m_MacroDefinition?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Assignment

		// Content changing function(s) associated with production(s) of syntax rule Assignment

		//
		// Content changing function associated with following production(s)
		// Assignment -> TypeAssignment

		//

		public void change(TypeAssignment p_TypeAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_Assignment_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TypeAssignment = p_TypeAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Assignment -> ValueAssignment

		//

		public void change(ValueAssignment p_ValueAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_Assignment_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ValueAssignment = p_ValueAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Assignment -> XMLValueAssignment

		//

		public void change(XMLValueAssignment p_XMLValueAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_Assignment_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLValueAssignment = p_XMLValueAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Assignment -> ValueSetTypeAssignment

		//

		public void change(ValueSetTypeAssignment p_ValueSetTypeAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_Assignment_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ValueSetTypeAssignment = p_ValueSetTypeAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Assignment -> ObjectClassAssignment

		//

		public void change(ObjectClassAssignment p_ObjectClassAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_Assignment_5;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjectClassAssignment = p_ObjectClassAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Assignment -> ObjectAssignment

		//

		public void change(ObjectAssignment p_ObjectAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_Assignment_6;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjectAssignment = p_ObjectAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Assignment -> ObjectSetAssignment

		//

		public void change(ObjectSetAssignment p_ObjectSetAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_Assignment_7;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjectSetAssignment = p_ObjectSetAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Assignment -> ParameterizedAssignment

		//

		public void change(ParameterizedAssignment p_ParameterizedAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_Assignment_8;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ParameterizedAssignment = p_ParameterizedAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Assignment -> MacroAssignment

		//

		public void change(MacroAssignment p_MacroAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_Assignment_9;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_MacroAssignment = p_MacroAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Assignment -> MacroDefinition

		//

		public void change(MacroDefinition p_MacroDefinition)
		{
			_init ();
			this.kind = (uint) production_kind.g_Assignment_10;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_MacroDefinition = p_MacroDefinition;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Assignment
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_TypeAssignment != null) && m_TypeAssignment.checkInclusion (element) ||
				(m_ValueAssignment != null) && m_ValueAssignment.checkInclusion (element) ||
				(m_XMLValueAssignment != null) && m_XMLValueAssignment.checkInclusion (element) ||
				(m_ValueSetTypeAssignment != null) && m_ValueSetTypeAssignment.checkInclusion (element) ||
				(m_ObjectClassAssignment != null) && m_ObjectClassAssignment.checkInclusion (element) ||
				(m_ObjectAssignment != null) && m_ObjectAssignment.checkInclusion (element) ||
				(m_ObjectSetAssignment != null) && m_ObjectSetAssignment.checkInclusion (element) ||
				(m_ParameterizedAssignment != null) && m_ParameterizedAssignment.checkInclusion (element) ||
				(m_MacroAssignment != null) && m_MacroAssignment.checkInclusion (element) ||
				(m_MacroDefinition != null) && m_MacroDefinition.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Assignment

		//
		// emit production tree node associated with any production of syntax rule Assignment
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Assignment_1:
					// emit syntax tree node associated with production
					// Assignment: TypeAssignment

					s += m_TypeAssignment.Emit (depth - 1);
				break;
				case production_kind.g_Assignment_2:
					// emit syntax tree node associated with production
					// Assignment: ValueAssignment

					s += m_ValueAssignment.Emit (depth - 1);
				break;
				case production_kind.g_Assignment_3:
					// emit syntax tree node associated with production
					// Assignment: XMLValueAssignment

					s += m_XMLValueAssignment.Emit (depth - 1);
				break;
				case production_kind.g_Assignment_4:
					// emit syntax tree node associated with production
					// Assignment: ValueSetTypeAssignment

					s += m_ValueSetTypeAssignment.Emit (depth - 1);
				break;
				case production_kind.g_Assignment_5:
					// emit syntax tree node associated with production
					// Assignment: ObjectClassAssignment

					s += m_ObjectClassAssignment.Emit (depth - 1);
				break;
				case production_kind.g_Assignment_6:
					// emit syntax tree node associated with production
					// Assignment: ObjectAssignment

					s += m_ObjectAssignment.Emit (depth - 1);
				break;
				case production_kind.g_Assignment_7:
					// emit syntax tree node associated with production
					// Assignment: ObjectSetAssignment

					s += m_ObjectSetAssignment.Emit (depth - 1);
				break;
				case production_kind.g_Assignment_8:
					// emit syntax tree node associated with production
					// Assignment: ParameterizedAssignment

					s += m_ParameterizedAssignment.Emit (depth - 1);
				break;
				case production_kind.g_Assignment_9:
					// emit syntax tree node associated with production
					// Assignment: MacroAssignment

					s += m_MacroAssignment.Emit (depth - 1);
				break;
				case production_kind.g_Assignment_10:
					// emit syntax tree node associated with production
					// Assignment: MacroDefinition

					s += m_MacroDefinition.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Assignment
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Assignment (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Assignment_1:
					// emit syntax tree node associated with production
					// Assignment: TypeAssignment

					s += m_TypeAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Assignment_2:
					// emit syntax tree node associated with production
					// Assignment: ValueAssignment

					s += m_ValueAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Assignment_3:
					// emit syntax tree node associated with production
					// Assignment: XMLValueAssignment

					s += m_XMLValueAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Assignment_4:
					// emit syntax tree node associated with production
					// Assignment: ValueSetTypeAssignment

					s += m_ValueSetTypeAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Assignment_5:
					// emit syntax tree node associated with production
					// Assignment: ObjectClassAssignment

					s += m_ObjectClassAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Assignment_6:
					// emit syntax tree node associated with production
					// Assignment: ObjectAssignment

					s += m_ObjectAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Assignment_7:
					// emit syntax tree node associated with production
					// Assignment: ObjectSetAssignment

					s += m_ObjectSetAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Assignment_8:
					// emit syntax tree node associated with production
					// Assignment: ParameterizedAssignment

					s += m_ParameterizedAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Assignment_9:
					// emit syntax tree node associated with production
					// Assignment: MacroAssignment

					s += m_MacroAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Assignment_10:
					// emit syntax tree node associated with production
					// Assignment: MacroDefinition

					s += m_MacroDefinition.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Assignment

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Assignment with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Assignment.production_kind kind = (Assignment.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Assignment.production_kind.g_Assignment_1:
					// traverse syntax tree node associated with production
					// Assignment: TypeAssignment

						m_TypeAssignment.Visit (visitor, appData);
				break;
				case Assignment.production_kind.g_Assignment_2:
					// traverse syntax tree node associated with production
					// Assignment: ValueAssignment

						m_ValueAssignment.Visit (visitor, appData);
				break;
				case Assignment.production_kind.g_Assignment_3:
					// traverse syntax tree node associated with production
					// Assignment: XMLValueAssignment

						m_XMLValueAssignment.Visit (visitor, appData);
				break;
				case Assignment.production_kind.g_Assignment_4:
					// traverse syntax tree node associated with production
					// Assignment: ValueSetTypeAssignment

						m_ValueSetTypeAssignment.Visit (visitor, appData);
				break;
				case Assignment.production_kind.g_Assignment_5:
					// traverse syntax tree node associated with production
					// Assignment: ObjectClassAssignment

						m_ObjectClassAssignment.Visit (visitor, appData);
				break;
				case Assignment.production_kind.g_Assignment_6:
					// traverse syntax tree node associated with production
					// Assignment: ObjectAssignment

						m_ObjectAssignment.Visit (visitor, appData);
				break;
				case Assignment.production_kind.g_Assignment_7:
					// traverse syntax tree node associated with production
					// Assignment: ObjectSetAssignment

						m_ObjectSetAssignment.Visit (visitor, appData);
				break;
				case Assignment.production_kind.g_Assignment_8:
					// traverse syntax tree node associated with production
					// Assignment: ParameterizedAssignment

						m_ParameterizedAssignment.Visit (visitor, appData);
				break;
				case Assignment.production_kind.g_Assignment_9:
					// traverse syntax tree node associated with production
					// Assignment: MacroAssignment

						m_MacroAssignment.Visit (visitor, appData);
				break;
				case Assignment.production_kind.g_Assignment_10:
					// traverse syntax tree node associated with production
					// Assignment: MacroDefinition

						m_MacroDefinition.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_TypeAssignment?.reparent (this);
			m_ValueAssignment?.reparent (this);
			m_XMLValueAssignment?.reparent (this);
			m_ValueSetTypeAssignment?.reparent (this);
			m_ObjectClassAssignment?.reparent (this);
			m_ObjectAssignment?.reparent (this);
			m_ObjectSetAssignment?.reparent (this);
			m_ParameterizedAssignment?.reparent (this);
			m_MacroAssignment?.reparent (this);
			m_MacroDefinition?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Assignment
		//

		public void _init ()
		{
			m_TypeAssignment = null;
			m_ValueAssignment = null;
			m_XMLValueAssignment = null;
			m_ValueSetTypeAssignment = null;
			m_ObjectClassAssignment = null;
			m_ObjectAssignment = null;
			m_ObjectSetAssignment = null;
			m_ParameterizedAssignment = null;
			m_MacroAssignment = null;
			m_MacroDefinition = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Assignment

		// counter of all nodes associated with syntax rule Assignment
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Assignment
		[DataMember (Name = "m_TypeAssignment")] public TypeAssignment m_TypeAssignment { get; private set; }
		[DataMember (Name = "m_ValueAssignment")] public ValueAssignment m_ValueAssignment { get; private set; }
		[DataMember (Name = "m_XMLValueAssignment")] public XMLValueAssignment m_XMLValueAssignment { get; private set; }
		[DataMember (Name = "m_ValueSetTypeAssignment")] public ValueSetTypeAssignment m_ValueSetTypeAssignment { get; private set; }
		[DataMember (Name = "m_ObjectClassAssignment")] public ObjectClassAssignment m_ObjectClassAssignment { get; private set; }
		[DataMember (Name = "m_ObjectAssignment")] public ObjectAssignment m_ObjectAssignment { get; private set; }
		[DataMember (Name = "m_ObjectSetAssignment")] public ObjectSetAssignment m_ObjectSetAssignment { get; private set; }
		[DataMember (Name = "m_ParameterizedAssignment")] public ParameterizedAssignment m_ParameterizedAssignment { get; private set; }
		[DataMember (Name = "m_MacroAssignment")] public MacroAssignment m_MacroAssignment { get; private set; }
		[DataMember (Name = "m_MacroDefinition")] public MacroDefinition m_MacroDefinition { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Assignment

		// delegate function (callback) prototype associated with syntax rule Assignment
		public delegate bool Assignment_Callback (SyntaxTreeCallbackReason reason, Assignment.production_kind kind, Assignment p_Assignment);

		// event associated with syntax rule Assignment
		public event Assignment_Callback Assignment_Event;

		// event trigger associated with syntax rule Assignment
		public bool Raise_Assignment_Event (SyntaxTreeCallbackReason reason, Assignment.production_kind kind, Assignment p_Assignment)
		{
			bool? status = Assignment_Event?.Invoke (reason, kind, p_Assignment);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Assignment
		//
		// traverse syntax tree node associated with any production of syntax rule Assignment
		//

		public void Traverse (Assignment p_Assignment)
		{
			if (p_Assignment.isLocked())
				return;
			p_Assignment.dolock();
			Assignment.production_kind kind = (Assignment.production_kind) p_Assignment.kind;
			p_Assignment.turn_reset ();
			if (Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Assignment))
			switch (kind)
			{
				case Assignment.production_kind.g_Assignment_1:
					// traverse syntax tree node associated with production
					// Assignment: TypeAssignment

					if (Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment))
						Traverse (p_Assignment.m_TypeAssignment);
					p_Assignment.turn_inc ();
					Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment);
				break;
				case Assignment.production_kind.g_Assignment_2:
					// traverse syntax tree node associated with production
					// Assignment: ValueAssignment

					if (Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment))
						Traverse (p_Assignment.m_ValueAssignment);
					p_Assignment.turn_inc ();
					Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment);
				break;
				case Assignment.production_kind.g_Assignment_3:
					// traverse syntax tree node associated with production
					// Assignment: XMLValueAssignment

					if (Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment))
						Traverse (p_Assignment.m_XMLValueAssignment);
					p_Assignment.turn_inc ();
					Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment);
				break;
				case Assignment.production_kind.g_Assignment_4:
					// traverse syntax tree node associated with production
					// Assignment: ValueSetTypeAssignment

					if (Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment))
						Traverse (p_Assignment.m_ValueSetTypeAssignment);
					p_Assignment.turn_inc ();
					Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment);
				break;
				case Assignment.production_kind.g_Assignment_5:
					// traverse syntax tree node associated with production
					// Assignment: ObjectClassAssignment

					if (Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment))
						Traverse (p_Assignment.m_ObjectClassAssignment);
					p_Assignment.turn_inc ();
					Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment);
				break;
				case Assignment.production_kind.g_Assignment_6:
					// traverse syntax tree node associated with production
					// Assignment: ObjectAssignment

					if (Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment))
						Traverse (p_Assignment.m_ObjectAssignment);
					p_Assignment.turn_inc ();
					Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment);
				break;
				case Assignment.production_kind.g_Assignment_7:
					// traverse syntax tree node associated with production
					// Assignment: ObjectSetAssignment

					if (Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment))
						Traverse (p_Assignment.m_ObjectSetAssignment);
					p_Assignment.turn_inc ();
					Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment);
				break;
				case Assignment.production_kind.g_Assignment_8:
					// traverse syntax tree node associated with production
					// Assignment: ParameterizedAssignment

					if (Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment))
						Traverse (p_Assignment.m_ParameterizedAssignment);
					p_Assignment.turn_inc ();
					Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment);
				break;
				case Assignment.production_kind.g_Assignment_9:
					// traverse syntax tree node associated with production
					// Assignment: MacroAssignment

					if (Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment))
						Traverse (p_Assignment.m_MacroAssignment);
					p_Assignment.turn_inc ();
					Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment);
				break;
				case Assignment.production_kind.g_Assignment_10:
					// traverse syntax tree node associated with production
					// Assignment: MacroDefinition

					if (Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment))
						Traverse (p_Assignment.m_MacroDefinition);
					p_Assignment.turn_inc ();
					Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Assignment);
				break;
			}
			Raise_Assignment_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Assignment);
			p_Assignment.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Assignment
		//

		public void TraverseCommon (Assignment p_Assignment)
		{
			Assignment.production_kind kind = (Assignment.production_kind) p_Assignment.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Assignment))
			switch (kind)
			{
				case Assignment.production_kind.g_Assignment_1:
					// traverse syntax tree node associated with production
					// Assignment: TypeAssignment

						TraverseCommon (p_Assignment.m_TypeAssignment);
				break;
				case Assignment.production_kind.g_Assignment_2:
					// traverse syntax tree node associated with production
					// Assignment: ValueAssignment

						TraverseCommon (p_Assignment.m_ValueAssignment);
				break;
				case Assignment.production_kind.g_Assignment_3:
					// traverse syntax tree node associated with production
					// Assignment: XMLValueAssignment

						TraverseCommon (p_Assignment.m_XMLValueAssignment);
				break;
				case Assignment.production_kind.g_Assignment_4:
					// traverse syntax tree node associated with production
					// Assignment: ValueSetTypeAssignment

						TraverseCommon (p_Assignment.m_ValueSetTypeAssignment);
				break;
				case Assignment.production_kind.g_Assignment_5:
					// traverse syntax tree node associated with production
					// Assignment: ObjectClassAssignment

						TraverseCommon (p_Assignment.m_ObjectClassAssignment);
				break;
				case Assignment.production_kind.g_Assignment_6:
					// traverse syntax tree node associated with production
					// Assignment: ObjectAssignment

						TraverseCommon (p_Assignment.m_ObjectAssignment);
				break;
				case Assignment.production_kind.g_Assignment_7:
					// traverse syntax tree node associated with production
					// Assignment: ObjectSetAssignment

						TraverseCommon (p_Assignment.m_ObjectSetAssignment);
				break;
				case Assignment.production_kind.g_Assignment_8:
					// traverse syntax tree node associated with production
					// Assignment: ParameterizedAssignment

						TraverseCommon (p_Assignment.m_ParameterizedAssignment);
				break;
				case Assignment.production_kind.g_Assignment_9:
					// traverse syntax tree node associated with production
					// Assignment: MacroAssignment

						TraverseCommon (p_Assignment.m_MacroAssignment);
				break;
				case Assignment.production_kind.g_Assignment_10:
					// traverse syntax tree node associated with production
					// Assignment: MacroDefinition

						TraverseCommon (p_Assignment.m_MacroDefinition);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Assignment);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Assignment

		//
		// create syntax tree node associated with production
		// Assignment: TypeAssignment

		//

		public Assignment Assignment_1 (TypeAssignment p_TypeAssignment)
		{
			Assignment p_Assignment_ref = new Assignment(p_TypeAssignment);
			p_TypeAssignment.parent = p_Assignment_ref;
			Raise_Assignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Assignment.production_kind.g_Assignment_1, p_Assignment_ref);
			return p_Assignment_ref;
		}

		//
		// create syntax tree node associated with production
		// Assignment: ValueAssignment

		//

		public Assignment Assignment_2 (ValueAssignment p_ValueAssignment)
		{
			Assignment p_Assignment_ref = new Assignment(p_ValueAssignment);
			p_ValueAssignment.parent = p_Assignment_ref;
			Raise_Assignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Assignment.production_kind.g_Assignment_2, p_Assignment_ref);
			return p_Assignment_ref;
		}

		//
		// create syntax tree node associated with production
		// Assignment: XMLValueAssignment

		//

		public Assignment Assignment_3 (XMLValueAssignment p_XMLValueAssignment)
		{
			Assignment p_Assignment_ref = new Assignment(p_XMLValueAssignment);
			p_XMLValueAssignment.parent = p_Assignment_ref;
			Raise_Assignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Assignment.production_kind.g_Assignment_3, p_Assignment_ref);
			return p_Assignment_ref;
		}

		//
		// create syntax tree node associated with production
		// Assignment: ValueSetTypeAssignment

		//

		public Assignment Assignment_4 (ValueSetTypeAssignment p_ValueSetTypeAssignment)
		{
			Assignment p_Assignment_ref = new Assignment(p_ValueSetTypeAssignment);
			p_ValueSetTypeAssignment.parent = p_Assignment_ref;
			Raise_Assignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Assignment.production_kind.g_Assignment_4, p_Assignment_ref);
			return p_Assignment_ref;
		}

		//
		// create syntax tree node associated with production
		// Assignment: ObjectClassAssignment

		//

		public Assignment Assignment_5 (ObjectClassAssignment p_ObjectClassAssignment)
		{
			Assignment p_Assignment_ref = new Assignment(p_ObjectClassAssignment);
			p_ObjectClassAssignment.parent = p_Assignment_ref;
			Raise_Assignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Assignment.production_kind.g_Assignment_5, p_Assignment_ref);
			return p_Assignment_ref;
		}

		//
		// create syntax tree node associated with production
		// Assignment: ObjectAssignment

		//

		public Assignment Assignment_6 (ObjectAssignment p_ObjectAssignment)
		{
			Assignment p_Assignment_ref = new Assignment(p_ObjectAssignment);
			p_ObjectAssignment.parent = p_Assignment_ref;
			Raise_Assignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Assignment.production_kind.g_Assignment_6, p_Assignment_ref);
			return p_Assignment_ref;
		}

		//
		// create syntax tree node associated with production
		// Assignment: ObjectSetAssignment

		//

		public Assignment Assignment_7 (ObjectSetAssignment p_ObjectSetAssignment)
		{
			Assignment p_Assignment_ref = new Assignment(p_ObjectSetAssignment);
			p_ObjectSetAssignment.parent = p_Assignment_ref;
			Raise_Assignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Assignment.production_kind.g_Assignment_7, p_Assignment_ref);
			return p_Assignment_ref;
		}

		//
		// create syntax tree node associated with production
		// Assignment: ParameterizedAssignment

		//

		public Assignment Assignment_8 (ParameterizedAssignment p_ParameterizedAssignment)
		{
			Assignment p_Assignment_ref = new Assignment(p_ParameterizedAssignment);
			p_ParameterizedAssignment.parent = p_Assignment_ref;
			Raise_Assignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Assignment.production_kind.g_Assignment_8, p_Assignment_ref);
			return p_Assignment_ref;
		}

		//
		// create syntax tree node associated with production
		// Assignment: MacroAssignment

		//

		public Assignment Assignment_9 (MacroAssignment p_MacroAssignment)
		{
			Assignment p_Assignment_ref = new Assignment(p_MacroAssignment);
			p_MacroAssignment.parent = p_Assignment_ref;
			Raise_Assignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Assignment.production_kind.g_Assignment_9, p_Assignment_ref);
			return p_Assignment_ref;
		}

		//
		// create syntax tree node associated with production
		// Assignment: MacroDefinition

		//

		public Assignment Assignment_10 (MacroDefinition p_MacroDefinition)
		{
			Assignment p_Assignment_ref = new Assignment(p_MacroDefinition);
			p_MacroDefinition.parent = p_Assignment_ref;
			Raise_Assignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Assignment.production_kind.g_Assignment_10, p_Assignment_ref);
			return p_Assignment_ref;
		}
		#endregion
	};
}
