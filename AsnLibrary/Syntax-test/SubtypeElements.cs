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
	// class associated with syntax rule SubtypeElements
	//

	[DataContract]
	public class	SubtypeElements : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SubtypeElements
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SubtypeElements
		{
			g_SubtypeElements_1 = 1,	// SingleValue

			g_SubtypeElements_2 = 2,	// ContainedSubtype

			g_SubtypeElements_3 = 3,	// SEValueRange

			g_SubtypeElements_4 = 4,	// PermittedAlphabet

			g_SubtypeElements_5 = 5,	// SESizeConstraint

			g_SubtypeElements_6 = 6,	// TypeConstraint

			g_SubtypeElements_7 = 7,	// InnerTypeConstraints

			g_SubtypeElements_8 = 8,	// PatternConstraint

			g_SubtypeElements_9 = 9,	// PropertySettings

			g_SubtypeElements_10 = 10,	// DurationRange

			g_SubtypeElements_11 = 11,	// TimePointRange

			g_SubtypeElements_12 = 12,	// RecurrenceRange

		};
		#endregion
		#region production markers associated with the syntax rule SubtypeElements

		// markers associated with production: SubtypeElements -> SingleValue

		public enum production_marker_1 : ushort
		{
			m_SingleValue,
			final
		};

		// markers associated with production: SubtypeElements -> ContainedSubtype

		public enum production_marker_2 : ushort
		{
			m_ContainedSubtype,
			final
		};

		// markers associated with production: SubtypeElements -> SEValueRange

		public enum production_marker_3 : ushort
		{
			m_SEValueRange,
			final
		};

		// markers associated with production: SubtypeElements -> PermittedAlphabet

		public enum production_marker_4 : ushort
		{
			m_PermittedAlphabet,
			final
		};

		// markers associated with production: SubtypeElements -> SESizeConstraint

		public enum production_marker_5 : ushort
		{
			m_SESizeConstraint,
			final
		};

		// markers associated with production: SubtypeElements -> TypeConstraint

		public enum production_marker_6 : ushort
		{
			m_TypeConstraint,
			final
		};

		// markers associated with production: SubtypeElements -> InnerTypeConstraints

		public enum production_marker_7 : ushort
		{
			m_InnerTypeConstraints,
			final
		};

		// markers associated with production: SubtypeElements -> PatternConstraint

		public enum production_marker_8 : ushort
		{
			m_PatternConstraint,
			final
		};

		// markers associated with production: SubtypeElements -> PropertySettings

		public enum production_marker_9 : ushort
		{
			m_PropertySettings,
			final
		};

		// markers associated with production: SubtypeElements -> DurationRange

		public enum production_marker_10 : ushort
		{
			m_DurationRange,
			final
		};

		// markers associated with production: SubtypeElements -> TimePointRange

		public enum production_marker_11 : ushort
		{
			m_TimePointRange,
			final
		};

		// markers associated with production: SubtypeElements -> RecurrenceRange

		public enum production_marker_12 : ushort
		{
			m_RecurrenceRange,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SubtypeElements

		// Constructor declaration(s) associated with production(s) of syntax rule SubtypeElements

		//
		// Constructor associated with the following production(s)
		// SubtypeElements -> SingleValue

		//

		public SubtypeElements (SingleValue p_SingleValue) : base ((uint) ProductionID._SubtypeElements_ID, (uint) production_kind.g_SubtypeElements_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SingleValue = p_SingleValue;
		}

		//
		// Constructor associated with the following production(s)
		// SubtypeElements -> ContainedSubtype

		//

		public SubtypeElements (ContainedSubtype p_ContainedSubtype) : base ((uint) ProductionID._SubtypeElements_ID, (uint) production_kind.g_SubtypeElements_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ContainedSubtype = p_ContainedSubtype;
		}

		//
		// Constructor associated with the following production(s)
		// SubtypeElements -> SEValueRange

		//

		public SubtypeElements (SEValueRange p_SEValueRange) : base ((uint) ProductionID._SubtypeElements_ID, (uint) production_kind.g_SubtypeElements_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SEValueRange = p_SEValueRange;
		}

		//
		// Constructor associated with the following production(s)
		// SubtypeElements -> PermittedAlphabet

		//

		public SubtypeElements (PermittedAlphabet p_PermittedAlphabet) : base ((uint) ProductionID._SubtypeElements_ID, (uint) production_kind.g_SubtypeElements_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_PermittedAlphabet = p_PermittedAlphabet;
		}

		//
		// Constructor associated with the following production(s)
		// SubtypeElements -> SESizeConstraint

		//

		public SubtypeElements (SESizeConstraint p_SESizeConstraint) : base ((uint) ProductionID._SubtypeElements_ID, (uint) production_kind.g_SubtypeElements_5)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SESizeConstraint = p_SESizeConstraint;
		}

		//
		// Constructor associated with the following production(s)
		// SubtypeElements -> TypeConstraint

		//

		public SubtypeElements (TypeConstraint p_TypeConstraint) : base ((uint) ProductionID._SubtypeElements_ID, (uint) production_kind.g_SubtypeElements_6)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TypeConstraint = p_TypeConstraint;
		}

		//
		// Constructor associated with the following production(s)
		// SubtypeElements -> InnerTypeConstraints

		//

		public SubtypeElements (InnerTypeConstraints p_InnerTypeConstraints) : base ((uint) ProductionID._SubtypeElements_ID, (uint) production_kind.g_SubtypeElements_7)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_InnerTypeConstraints = p_InnerTypeConstraints;
		}

		//
		// Constructor associated with the following production(s)
		// SubtypeElements -> PatternConstraint

		//

		public SubtypeElements (PatternConstraint p_PatternConstraint) : base ((uint) ProductionID._SubtypeElements_ID, (uint) production_kind.g_SubtypeElements_8)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_PatternConstraint = p_PatternConstraint;
		}

		//
		// Constructor associated with the following production(s)
		// SubtypeElements -> PropertySettings

		//

		public SubtypeElements (PropertySettings p_PropertySettings) : base ((uint) ProductionID._SubtypeElements_ID, (uint) production_kind.g_SubtypeElements_9)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_PropertySettings = p_PropertySettings;
		}

		//
		// Constructor associated with the following production(s)
		// SubtypeElements -> DurationRange

		//

		public SubtypeElements (DurationRange p_DurationRange) : base ((uint) ProductionID._SubtypeElements_ID, (uint) production_kind.g_SubtypeElements_10)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DurationRange = p_DurationRange;
		}

		//
		// Constructor associated with the following production(s)
		// SubtypeElements -> TimePointRange

		//

		public SubtypeElements (TimePointRange p_TimePointRange) : base ((uint) ProductionID._SubtypeElements_ID, (uint) production_kind.g_SubtypeElements_11)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TimePointRange = p_TimePointRange;
		}

		//
		// Constructor associated with the following production(s)
		// SubtypeElements -> RecurrenceRange

		//

		public SubtypeElements (RecurrenceRange p_RecurrenceRange) : base ((uint) ProductionID._SubtypeElements_ID, (uint) production_kind.g_SubtypeElements_12)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_RecurrenceRange = p_RecurrenceRange;
		}

		public SubtypeElements () { }

		// Copy constructor

		public SubtypeElements (SubtypeElements p_SubtypeElements) : base (p_SubtypeElements.id, p_SubtypeElements.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SubtypeElements.appInfo;
			switch ((production_kind) p_SubtypeElements.kind)
			{
				case production_kind.g_SubtypeElements_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SingleValue = (p_SubtypeElements.m_SingleValue != null) ? new SingleValue (p_SubtypeElements.m_SingleValue) : null) != null) m_SingleValue.parent = this;
					break;
				case production_kind.g_SubtypeElements_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ContainedSubtype = (p_SubtypeElements.m_ContainedSubtype != null) ? new ContainedSubtype (p_SubtypeElements.m_ContainedSubtype) : null) != null) m_ContainedSubtype.parent = this;
					break;
				case production_kind.g_SubtypeElements_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SEValueRange = (p_SubtypeElements.m_SEValueRange != null) ? new SEValueRange (p_SubtypeElements.m_SEValueRange) : null) != null) m_SEValueRange.parent = this;
					break;
				case production_kind.g_SubtypeElements_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_PermittedAlphabet = (p_SubtypeElements.m_PermittedAlphabet != null) ? new PermittedAlphabet (p_SubtypeElements.m_PermittedAlphabet) : null) != null) m_PermittedAlphabet.parent = this;
					break;
				case production_kind.g_SubtypeElements_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SESizeConstraint = (p_SubtypeElements.m_SESizeConstraint != null) ? new SESizeConstraint (p_SubtypeElements.m_SESizeConstraint) : null) != null) m_SESizeConstraint.parent = this;
					break;
				case production_kind.g_SubtypeElements_6:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TypeConstraint = (p_SubtypeElements.m_TypeConstraint != null) ? new TypeConstraint (p_SubtypeElements.m_TypeConstraint) : null) != null) m_TypeConstraint.parent = this;
					break;
				case production_kind.g_SubtypeElements_7:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_InnerTypeConstraints = (p_SubtypeElements.m_InnerTypeConstraints != null) ? new InnerTypeConstraints (p_SubtypeElements.m_InnerTypeConstraints) : null) != null) m_InnerTypeConstraints.parent = this;
					break;
				case production_kind.g_SubtypeElements_8:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_PatternConstraint = (p_SubtypeElements.m_PatternConstraint != null) ? new PatternConstraint (p_SubtypeElements.m_PatternConstraint) : null) != null) m_PatternConstraint.parent = this;
					break;
				case production_kind.g_SubtypeElements_9:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_PropertySettings = (p_SubtypeElements.m_PropertySettings != null) ? new PropertySettings (p_SubtypeElements.m_PropertySettings) : null) != null) m_PropertySettings.parent = this;
					break;
				case production_kind.g_SubtypeElements_10:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DurationRange = (p_SubtypeElements.m_DurationRange != null) ? new DurationRange (p_SubtypeElements.m_DurationRange) : null) != null) m_DurationRange.parent = this;
					break;
				case production_kind.g_SubtypeElements_11:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TimePointRange = (p_SubtypeElements.m_TimePointRange != null) ? new TimePointRange (p_SubtypeElements.m_TimePointRange) : null) != null) m_TimePointRange.parent = this;
					break;
				case production_kind.g_SubtypeElements_12:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RecurrenceRange = (p_SubtypeElements.m_RecurrenceRange != null) ? new RecurrenceRange (p_SubtypeElements.m_RecurrenceRange) : null) != null) m_RecurrenceRange.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SubtypeElements" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SubtypeElements (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SingleValue?.Dispose ();
			m_ContainedSubtype?.Dispose ();
			m_SEValueRange?.Dispose ();
			m_PermittedAlphabet?.Dispose ();
			m_SESizeConstraint?.Dispose ();
			m_TypeConstraint?.Dispose ();
			m_InnerTypeConstraints?.Dispose ();
			m_PatternConstraint?.Dispose ();
			m_PropertySettings?.Dispose ();
			m_DurationRange?.Dispose ();
			m_TimePointRange?.Dispose ();
			m_RecurrenceRange?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SubtypeElements

		// Content changing function(s) associated with production(s) of syntax rule SubtypeElements

		//
		// Content changing function associated with following production(s)
		// SubtypeElements -> SingleValue

		//

		public void change(SingleValue p_SingleValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_SubtypeElements_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SingleValue = p_SingleValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SubtypeElements -> ContainedSubtype

		//

		public void change(ContainedSubtype p_ContainedSubtype)
		{
			_init ();
			this.kind = (uint) production_kind.g_SubtypeElements_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ContainedSubtype = p_ContainedSubtype;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SubtypeElements -> SEValueRange

		//

		public void change(SEValueRange p_SEValueRange)
		{
			_init ();
			this.kind = (uint) production_kind.g_SubtypeElements_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SEValueRange = p_SEValueRange;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SubtypeElements -> PermittedAlphabet

		//

		public void change(PermittedAlphabet p_PermittedAlphabet)
		{
			_init ();
			this.kind = (uint) production_kind.g_SubtypeElements_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_PermittedAlphabet = p_PermittedAlphabet;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SubtypeElements -> SESizeConstraint

		//

		public void change(SESizeConstraint p_SESizeConstraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_SubtypeElements_5;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SESizeConstraint = p_SESizeConstraint;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SubtypeElements -> TypeConstraint

		//

		public void change(TypeConstraint p_TypeConstraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_SubtypeElements_6;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TypeConstraint = p_TypeConstraint;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SubtypeElements -> InnerTypeConstraints

		//

		public void change(InnerTypeConstraints p_InnerTypeConstraints)
		{
			_init ();
			this.kind = (uint) production_kind.g_SubtypeElements_7;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_InnerTypeConstraints = p_InnerTypeConstraints;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SubtypeElements -> PatternConstraint

		//

		public void change(PatternConstraint p_PatternConstraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_SubtypeElements_8;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_PatternConstraint = p_PatternConstraint;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SubtypeElements -> PropertySettings

		//

		public void change(PropertySettings p_PropertySettings)
		{
			_init ();
			this.kind = (uint) production_kind.g_SubtypeElements_9;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_PropertySettings = p_PropertySettings;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SubtypeElements -> DurationRange

		//

		public void change(DurationRange p_DurationRange)
		{
			_init ();
			this.kind = (uint) production_kind.g_SubtypeElements_10;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DurationRange = p_DurationRange;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SubtypeElements -> TimePointRange

		//

		public void change(TimePointRange p_TimePointRange)
		{
			_init ();
			this.kind = (uint) production_kind.g_SubtypeElements_11;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TimePointRange = p_TimePointRange;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SubtypeElements -> RecurrenceRange

		//

		public void change(RecurrenceRange p_RecurrenceRange)
		{
			_init ();
			this.kind = (uint) production_kind.g_SubtypeElements_12;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_RecurrenceRange = p_RecurrenceRange;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SubtypeElements
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SingleValue != null) && m_SingleValue.checkInclusion (element) ||
				(m_ContainedSubtype != null) && m_ContainedSubtype.checkInclusion (element) ||
				(m_SEValueRange != null) && m_SEValueRange.checkInclusion (element) ||
				(m_PermittedAlphabet != null) && m_PermittedAlphabet.checkInclusion (element) ||
				(m_SESizeConstraint != null) && m_SESizeConstraint.checkInclusion (element) ||
				(m_TypeConstraint != null) && m_TypeConstraint.checkInclusion (element) ||
				(m_InnerTypeConstraints != null) && m_InnerTypeConstraints.checkInclusion (element) ||
				(m_PatternConstraint != null) && m_PatternConstraint.checkInclusion (element) ||
				(m_PropertySettings != null) && m_PropertySettings.checkInclusion (element) ||
				(m_DurationRange != null) && m_DurationRange.checkInclusion (element) ||
				(m_TimePointRange != null) && m_TimePointRange.checkInclusion (element) ||
				(m_RecurrenceRange != null) && m_RecurrenceRange.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SubtypeElements

		//
		// emit production tree node associated with any production of syntax rule SubtypeElements
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SubtypeElements_1:
					// emit syntax tree node associated with production
					// SubtypeElements: SingleValue

					s += m_SingleValue.Emit (depth - 1);
				break;
				case production_kind.g_SubtypeElements_2:
					// emit syntax tree node associated with production
					// SubtypeElements: ContainedSubtype

					s += m_ContainedSubtype.Emit (depth - 1);
				break;
				case production_kind.g_SubtypeElements_3:
					// emit syntax tree node associated with production
					// SubtypeElements: SEValueRange

					s += m_SEValueRange.Emit (depth - 1);
				break;
				case production_kind.g_SubtypeElements_4:
					// emit syntax tree node associated with production
					// SubtypeElements: PermittedAlphabet

					s += m_PermittedAlphabet.Emit (depth - 1);
				break;
				case production_kind.g_SubtypeElements_5:
					// emit syntax tree node associated with production
					// SubtypeElements: SESizeConstraint

					s += m_SESizeConstraint.Emit (depth - 1);
				break;
				case production_kind.g_SubtypeElements_6:
					// emit syntax tree node associated with production
					// SubtypeElements: TypeConstraint

					s += m_TypeConstraint.Emit (depth - 1);
				break;
				case production_kind.g_SubtypeElements_7:
					// emit syntax tree node associated with production
					// SubtypeElements: InnerTypeConstraints

					s += m_InnerTypeConstraints.Emit (depth - 1);
				break;
				case production_kind.g_SubtypeElements_8:
					// emit syntax tree node associated with production
					// SubtypeElements: PatternConstraint

					s += m_PatternConstraint.Emit (depth - 1);
				break;
				case production_kind.g_SubtypeElements_9:
					// emit syntax tree node associated with production
					// SubtypeElements: PropertySettings

					s += m_PropertySettings.Emit (depth - 1);
				break;
				case production_kind.g_SubtypeElements_10:
					// emit syntax tree node associated with production
					// SubtypeElements: DurationRange

					s += m_DurationRange.Emit (depth - 1);
				break;
				case production_kind.g_SubtypeElements_11:
					// emit syntax tree node associated with production
					// SubtypeElements: TimePointRange

					s += m_TimePointRange.Emit (depth - 1);
				break;
				case production_kind.g_SubtypeElements_12:
					// emit syntax tree node associated with production
					// SubtypeElements: RecurrenceRange

					s += m_RecurrenceRange.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SubtypeElements
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SubtypeElements (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SubtypeElements_1:
					// emit syntax tree node associated with production
					// SubtypeElements: SingleValue

					s += m_SingleValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_SubtypeElements_2:
					// emit syntax tree node associated with production
					// SubtypeElements: ContainedSubtype

					s += m_ContainedSubtype.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_SubtypeElements_3:
					// emit syntax tree node associated with production
					// SubtypeElements: SEValueRange

					s += m_SEValueRange.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_SubtypeElements_4:
					// emit syntax tree node associated with production
					// SubtypeElements: PermittedAlphabet

					s += m_PermittedAlphabet.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_SubtypeElements_5:
					// emit syntax tree node associated with production
					// SubtypeElements: SESizeConstraint

					s += m_SESizeConstraint.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_SubtypeElements_6:
					// emit syntax tree node associated with production
					// SubtypeElements: TypeConstraint

					s += m_TypeConstraint.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_SubtypeElements_7:
					// emit syntax tree node associated with production
					// SubtypeElements: InnerTypeConstraints

					s += m_InnerTypeConstraints.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_SubtypeElements_8:
					// emit syntax tree node associated with production
					// SubtypeElements: PatternConstraint

					s += m_PatternConstraint.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_SubtypeElements_9:
					// emit syntax tree node associated with production
					// SubtypeElements: PropertySettings

					s += m_PropertySettings.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_SubtypeElements_10:
					// emit syntax tree node associated with production
					// SubtypeElements: DurationRange

					s += m_DurationRange.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_SubtypeElements_11:
					// emit syntax tree node associated with production
					// SubtypeElements: TimePointRange

					s += m_TimePointRange.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_SubtypeElements_12:
					// emit syntax tree node associated with production
					// SubtypeElements: RecurrenceRange

					s += m_RecurrenceRange.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SubtypeElements

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SubtypeElements with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SubtypeElements.production_kind kind = (SubtypeElements.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SubtypeElements.production_kind.g_SubtypeElements_1:
					// traverse syntax tree node associated with production
					// SubtypeElements: SingleValue

						m_SingleValue.Visit (visitor, appData);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_2:
					// traverse syntax tree node associated with production
					// SubtypeElements: ContainedSubtype

						m_ContainedSubtype.Visit (visitor, appData);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_3:
					// traverse syntax tree node associated with production
					// SubtypeElements: SEValueRange

						m_SEValueRange.Visit (visitor, appData);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_4:
					// traverse syntax tree node associated with production
					// SubtypeElements: PermittedAlphabet

						m_PermittedAlphabet.Visit (visitor, appData);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_5:
					// traverse syntax tree node associated with production
					// SubtypeElements: SESizeConstraint

						m_SESizeConstraint.Visit (visitor, appData);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_6:
					// traverse syntax tree node associated with production
					// SubtypeElements: TypeConstraint

						m_TypeConstraint.Visit (visitor, appData);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_7:
					// traverse syntax tree node associated with production
					// SubtypeElements: InnerTypeConstraints

						m_InnerTypeConstraints.Visit (visitor, appData);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_8:
					// traverse syntax tree node associated with production
					// SubtypeElements: PatternConstraint

						m_PatternConstraint.Visit (visitor, appData);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_9:
					// traverse syntax tree node associated with production
					// SubtypeElements: PropertySettings

						m_PropertySettings.Visit (visitor, appData);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_10:
					// traverse syntax tree node associated with production
					// SubtypeElements: DurationRange

						m_DurationRange.Visit (visitor, appData);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_11:
					// traverse syntax tree node associated with production
					// SubtypeElements: TimePointRange

						m_TimePointRange.Visit (visitor, appData);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_12:
					// traverse syntax tree node associated with production
					// SubtypeElements: RecurrenceRange

						m_RecurrenceRange.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SingleValue?.reparent (this);
			m_ContainedSubtype?.reparent (this);
			m_SEValueRange?.reparent (this);
			m_PermittedAlphabet?.reparent (this);
			m_SESizeConstraint?.reparent (this);
			m_TypeConstraint?.reparent (this);
			m_InnerTypeConstraints?.reparent (this);
			m_PatternConstraint?.reparent (this);
			m_PropertySettings?.reparent (this);
			m_DurationRange?.reparent (this);
			m_TimePointRange?.reparent (this);
			m_RecurrenceRange?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SubtypeElements
		//

		public void _init ()
		{
			m_SingleValue = null;
			m_ContainedSubtype = null;
			m_SEValueRange = null;
			m_PermittedAlphabet = null;
			m_SESizeConstraint = null;
			m_TypeConstraint = null;
			m_InnerTypeConstraints = null;
			m_PatternConstraint = null;
			m_PropertySettings = null;
			m_DurationRange = null;
			m_TimePointRange = null;
			m_RecurrenceRange = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SubtypeElements

		// counter of all nodes associated with syntax rule SubtypeElements
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SubtypeElements
		[DataMember (Name = "m_SingleValue")] public SingleValue m_SingleValue { get; private set; }
		[DataMember (Name = "m_ContainedSubtype")] public ContainedSubtype m_ContainedSubtype { get; private set; }
		[DataMember (Name = "m_SEValueRange")] public SEValueRange m_SEValueRange { get; private set; }
		[DataMember (Name = "m_PermittedAlphabet")] public PermittedAlphabet m_PermittedAlphabet { get; private set; }
		[DataMember (Name = "m_SESizeConstraint")] public SESizeConstraint m_SESizeConstraint { get; private set; }
		[DataMember (Name = "m_TypeConstraint")] public TypeConstraint m_TypeConstraint { get; private set; }
		[DataMember (Name = "m_InnerTypeConstraints")] public InnerTypeConstraints m_InnerTypeConstraints { get; private set; }
		[DataMember (Name = "m_PatternConstraint")] public PatternConstraint m_PatternConstraint { get; private set; }
		[DataMember (Name = "m_PropertySettings")] public PropertySettings m_PropertySettings { get; private set; }
		[DataMember (Name = "m_DurationRange")] public DurationRange m_DurationRange { get; private set; }
		[DataMember (Name = "m_TimePointRange")] public TimePointRange m_TimePointRange { get; private set; }
		[DataMember (Name = "m_RecurrenceRange")] public RecurrenceRange m_RecurrenceRange { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SubtypeElements

		// delegate function (callback) prototype associated with syntax rule SubtypeElements
		public delegate bool SubtypeElements_Callback (SyntaxTreeCallbackReason reason, SubtypeElements.production_kind kind, SubtypeElements p_SubtypeElements);

		// event associated with syntax rule SubtypeElements
		public event SubtypeElements_Callback SubtypeElements_Event;

		// event trigger associated with syntax rule SubtypeElements
		public bool Raise_SubtypeElements_Event (SyntaxTreeCallbackReason reason, SubtypeElements.production_kind kind, SubtypeElements p_SubtypeElements)
		{
			bool? status = SubtypeElements_Event?.Invoke (reason, kind, p_SubtypeElements);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SubtypeElements
		//
		// traverse syntax tree node associated with any production of syntax rule SubtypeElements
		//

		public void Traverse (SubtypeElements p_SubtypeElements)
		{
			if (p_SubtypeElements.isLocked())
				return;
			p_SubtypeElements.dolock();
			SubtypeElements.production_kind kind = (SubtypeElements.production_kind) p_SubtypeElements.kind;
			p_SubtypeElements.turn_reset ();
			if (Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SubtypeElements))
			switch (kind)
			{
				case SubtypeElements.production_kind.g_SubtypeElements_1:
					// traverse syntax tree node associated with production
					// SubtypeElements: SingleValue

					if (Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements))
						Traverse (p_SubtypeElements.m_SingleValue);
					p_SubtypeElements.turn_inc ();
					Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_2:
					// traverse syntax tree node associated with production
					// SubtypeElements: ContainedSubtype

					if (Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements))
						Traverse (p_SubtypeElements.m_ContainedSubtype);
					p_SubtypeElements.turn_inc ();
					Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_3:
					// traverse syntax tree node associated with production
					// SubtypeElements: SEValueRange

					if (Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements))
						Traverse (p_SubtypeElements.m_SEValueRange);
					p_SubtypeElements.turn_inc ();
					Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_4:
					// traverse syntax tree node associated with production
					// SubtypeElements: PermittedAlphabet

					if (Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements))
						Traverse (p_SubtypeElements.m_PermittedAlphabet);
					p_SubtypeElements.turn_inc ();
					Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_5:
					// traverse syntax tree node associated with production
					// SubtypeElements: SESizeConstraint

					if (Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements))
						Traverse (p_SubtypeElements.m_SESizeConstraint);
					p_SubtypeElements.turn_inc ();
					Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_6:
					// traverse syntax tree node associated with production
					// SubtypeElements: TypeConstraint

					if (Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements))
						Traverse (p_SubtypeElements.m_TypeConstraint);
					p_SubtypeElements.turn_inc ();
					Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_7:
					// traverse syntax tree node associated with production
					// SubtypeElements: InnerTypeConstraints

					if (Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements))
						Traverse (p_SubtypeElements.m_InnerTypeConstraints);
					p_SubtypeElements.turn_inc ();
					Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_8:
					// traverse syntax tree node associated with production
					// SubtypeElements: PatternConstraint

					if (Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements))
						Traverse (p_SubtypeElements.m_PatternConstraint);
					p_SubtypeElements.turn_inc ();
					Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_9:
					// traverse syntax tree node associated with production
					// SubtypeElements: PropertySettings

					if (Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements))
						Traverse (p_SubtypeElements.m_PropertySettings);
					p_SubtypeElements.turn_inc ();
					Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_10:
					// traverse syntax tree node associated with production
					// SubtypeElements: DurationRange

					if (Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements))
						Traverse (p_SubtypeElements.m_DurationRange);
					p_SubtypeElements.turn_inc ();
					Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_11:
					// traverse syntax tree node associated with production
					// SubtypeElements: TimePointRange

					if (Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements))
						Traverse (p_SubtypeElements.m_TimePointRange);
					p_SubtypeElements.turn_inc ();
					Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_12:
					// traverse syntax tree node associated with production
					// SubtypeElements: RecurrenceRange

					if (Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements))
						Traverse (p_SubtypeElements.m_RecurrenceRange);
					p_SubtypeElements.turn_inc ();
					Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SubtypeElements);
				break;
			}
			Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SubtypeElements);
			p_SubtypeElements.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SubtypeElements
		//

		public void TraverseCommon (SubtypeElements p_SubtypeElements)
		{
			SubtypeElements.production_kind kind = (SubtypeElements.production_kind) p_SubtypeElements.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SubtypeElements))
			switch (kind)
			{
				case SubtypeElements.production_kind.g_SubtypeElements_1:
					// traverse syntax tree node associated with production
					// SubtypeElements: SingleValue

						TraverseCommon (p_SubtypeElements.m_SingleValue);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_2:
					// traverse syntax tree node associated with production
					// SubtypeElements: ContainedSubtype

						TraverseCommon (p_SubtypeElements.m_ContainedSubtype);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_3:
					// traverse syntax tree node associated with production
					// SubtypeElements: SEValueRange

						TraverseCommon (p_SubtypeElements.m_SEValueRange);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_4:
					// traverse syntax tree node associated with production
					// SubtypeElements: PermittedAlphabet

						TraverseCommon (p_SubtypeElements.m_PermittedAlphabet);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_5:
					// traverse syntax tree node associated with production
					// SubtypeElements: SESizeConstraint

						TraverseCommon (p_SubtypeElements.m_SESizeConstraint);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_6:
					// traverse syntax tree node associated with production
					// SubtypeElements: TypeConstraint

						TraverseCommon (p_SubtypeElements.m_TypeConstraint);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_7:
					// traverse syntax tree node associated with production
					// SubtypeElements: InnerTypeConstraints

						TraverseCommon (p_SubtypeElements.m_InnerTypeConstraints);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_8:
					// traverse syntax tree node associated with production
					// SubtypeElements: PatternConstraint

						TraverseCommon (p_SubtypeElements.m_PatternConstraint);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_9:
					// traverse syntax tree node associated with production
					// SubtypeElements: PropertySettings

						TraverseCommon (p_SubtypeElements.m_PropertySettings);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_10:
					// traverse syntax tree node associated with production
					// SubtypeElements: DurationRange

						TraverseCommon (p_SubtypeElements.m_DurationRange);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_11:
					// traverse syntax tree node associated with production
					// SubtypeElements: TimePointRange

						TraverseCommon (p_SubtypeElements.m_TimePointRange);
				break;
				case SubtypeElements.production_kind.g_SubtypeElements_12:
					// traverse syntax tree node associated with production
					// SubtypeElements: RecurrenceRange

						TraverseCommon (p_SubtypeElements.m_RecurrenceRange);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SubtypeElements);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SubtypeElements

		//
		// create syntax tree node associated with production
		// SubtypeElements: SingleValue

		//

		public SubtypeElements SubtypeElements_1 (SingleValue p_SingleValue)
		{
			SubtypeElements p_SubtypeElements_ref = new SubtypeElements(p_SingleValue);
			p_SingleValue.parent = p_SubtypeElements_ref;
			Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SubtypeElements.production_kind.g_SubtypeElements_1, p_SubtypeElements_ref);
			return p_SubtypeElements_ref;
		}

		//
		// create syntax tree node associated with production
		// SubtypeElements: ContainedSubtype

		//

		public SubtypeElements SubtypeElements_2 (ContainedSubtype p_ContainedSubtype)
		{
			SubtypeElements p_SubtypeElements_ref = new SubtypeElements(p_ContainedSubtype);
			p_ContainedSubtype.parent = p_SubtypeElements_ref;
			Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SubtypeElements.production_kind.g_SubtypeElements_2, p_SubtypeElements_ref);
			return p_SubtypeElements_ref;
		}

		//
		// create syntax tree node associated with production
		// SubtypeElements: SEValueRange

		//

		public SubtypeElements SubtypeElements_3 (SEValueRange p_SEValueRange)
		{
			SubtypeElements p_SubtypeElements_ref = new SubtypeElements(p_SEValueRange);
			p_SEValueRange.parent = p_SubtypeElements_ref;
			Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SubtypeElements.production_kind.g_SubtypeElements_3, p_SubtypeElements_ref);
			return p_SubtypeElements_ref;
		}

		//
		// create syntax tree node associated with production
		// SubtypeElements: PermittedAlphabet

		//

		public SubtypeElements SubtypeElements_4 (PermittedAlphabet p_PermittedAlphabet)
		{
			SubtypeElements p_SubtypeElements_ref = new SubtypeElements(p_PermittedAlphabet);
			p_PermittedAlphabet.parent = p_SubtypeElements_ref;
			Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SubtypeElements.production_kind.g_SubtypeElements_4, p_SubtypeElements_ref);
			return p_SubtypeElements_ref;
		}

		//
		// create syntax tree node associated with production
		// SubtypeElements: SESizeConstraint

		//

		public SubtypeElements SubtypeElements_5 (SESizeConstraint p_SESizeConstraint)
		{
			SubtypeElements p_SubtypeElements_ref = new SubtypeElements(p_SESizeConstraint);
			p_SESizeConstraint.parent = p_SubtypeElements_ref;
			Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SubtypeElements.production_kind.g_SubtypeElements_5, p_SubtypeElements_ref);
			return p_SubtypeElements_ref;
		}

		//
		// create syntax tree node associated with production
		// SubtypeElements: TypeConstraint

		//

		public SubtypeElements SubtypeElements_6 (TypeConstraint p_TypeConstraint)
		{
			SubtypeElements p_SubtypeElements_ref = new SubtypeElements(p_TypeConstraint);
			p_TypeConstraint.parent = p_SubtypeElements_ref;
			Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SubtypeElements.production_kind.g_SubtypeElements_6, p_SubtypeElements_ref);
			return p_SubtypeElements_ref;
		}

		//
		// create syntax tree node associated with production
		// SubtypeElements: InnerTypeConstraints

		//

		public SubtypeElements SubtypeElements_7 (InnerTypeConstraints p_InnerTypeConstraints)
		{
			SubtypeElements p_SubtypeElements_ref = new SubtypeElements(p_InnerTypeConstraints);
			p_InnerTypeConstraints.parent = p_SubtypeElements_ref;
			Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SubtypeElements.production_kind.g_SubtypeElements_7, p_SubtypeElements_ref);
			return p_SubtypeElements_ref;
		}

		//
		// create syntax tree node associated with production
		// SubtypeElements: PatternConstraint

		//

		public SubtypeElements SubtypeElements_8 (PatternConstraint p_PatternConstraint)
		{
			SubtypeElements p_SubtypeElements_ref = new SubtypeElements(p_PatternConstraint);
			p_PatternConstraint.parent = p_SubtypeElements_ref;
			Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SubtypeElements.production_kind.g_SubtypeElements_8, p_SubtypeElements_ref);
			return p_SubtypeElements_ref;
		}

		//
		// create syntax tree node associated with production
		// SubtypeElements: PropertySettings

		//

		public SubtypeElements SubtypeElements_9 (PropertySettings p_PropertySettings)
		{
			SubtypeElements p_SubtypeElements_ref = new SubtypeElements(p_PropertySettings);
			p_PropertySettings.parent = p_SubtypeElements_ref;
			Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SubtypeElements.production_kind.g_SubtypeElements_9, p_SubtypeElements_ref);
			return p_SubtypeElements_ref;
		}

		//
		// create syntax tree node associated with production
		// SubtypeElements: DurationRange

		//

		public SubtypeElements SubtypeElements_10 (DurationRange p_DurationRange)
		{
			SubtypeElements p_SubtypeElements_ref = new SubtypeElements(p_DurationRange);
			p_DurationRange.parent = p_SubtypeElements_ref;
			Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SubtypeElements.production_kind.g_SubtypeElements_10, p_SubtypeElements_ref);
			return p_SubtypeElements_ref;
		}

		//
		// create syntax tree node associated with production
		// SubtypeElements: TimePointRange

		//

		public SubtypeElements SubtypeElements_11 (TimePointRange p_TimePointRange)
		{
			SubtypeElements p_SubtypeElements_ref = new SubtypeElements(p_TimePointRange);
			p_TimePointRange.parent = p_SubtypeElements_ref;
			Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SubtypeElements.production_kind.g_SubtypeElements_11, p_SubtypeElements_ref);
			return p_SubtypeElements_ref;
		}

		//
		// create syntax tree node associated with production
		// SubtypeElements: RecurrenceRange

		//

		public SubtypeElements SubtypeElements_12 (RecurrenceRange p_RecurrenceRange)
		{
			SubtypeElements p_SubtypeElements_ref = new SubtypeElements(p_RecurrenceRange);
			p_RecurrenceRange.parent = p_SubtypeElements_ref;
			Raise_SubtypeElements_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SubtypeElements.production_kind.g_SubtypeElements_12, p_SubtypeElements_ref);
			return p_SubtypeElements_ref;
		}
		#endregion
	};
}
