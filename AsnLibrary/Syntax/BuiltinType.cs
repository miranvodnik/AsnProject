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
	// class associated with syntax rule BuiltinType
	//

	[DataContract]
	public class	BuiltinType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule BuiltinType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule BuiltinType
		{
			g_BuiltinType_1 = 1,	// AnyType

			g_BuiltinType_2 = 2,	// BitStringType

			g_BuiltinType_3 = 3,	// BooleanType

			g_BuiltinType_4 = 4,	// CharacterStringType

			g_BuiltinType_5 = 5,	// ChoiceType

			g_BuiltinType_6 = 6,	// DateType

			g_BuiltinType_7 = 7,	// DateTimeType

			g_BuiltinType_8 = 8,	// DurationType

			g_BuiltinType_9 = 9,	// EmbeddedPDVType

			g_BuiltinType_10 = 10,	// EnumeratedType

			g_BuiltinType_11 = 11,	// ExternalType

			g_BuiltinType_12 = 12,	// InstanceOfType

			g_BuiltinType_13 = 13,	// IntegerType

			g_BuiltinType_14 = 14,	// IRIType

			g_BuiltinType_15 = 15,	// NullType

			g_BuiltinType_16 = 16,	// ObjectClassFieldType

			g_BuiltinType_17 = 17,	// ObjectIdentifierType

			g_BuiltinType_18 = 18,	// OctetStringType

			g_BuiltinType_19 = 19,	// RealType

			g_BuiltinType_20 = 20,	// RelativeIRIType

			g_BuiltinType_21 = 21,	// RelativeOIDType

			g_BuiltinType_22 = 22,	// SequenceType

			g_BuiltinType_23 = 23,	// SequenceOfType

			g_BuiltinType_24 = 24,	// SetType

			g_BuiltinType_25 = 25,	// SetOfType

			g_BuiltinType_26 = 26,	// PrefixedType

			g_BuiltinType_27 = 27,	// TimeType

			g_BuiltinType_28 = 28,	// TimeOfDayType

		};
		#endregion
		#region production markers associated with the syntax rule BuiltinType

		// markers associated with production: BuiltinType -> AnyType

		public enum production_marker_1 : ushort
		{
			m_AnyType,
			final
		};

		// markers associated with production: BuiltinType -> BitStringType

		public enum production_marker_2 : ushort
		{
			m_BitStringType,
			final
		};

		// markers associated with production: BuiltinType -> BooleanType

		public enum production_marker_3 : ushort
		{
			m_BooleanType,
			final
		};

		// markers associated with production: BuiltinType -> CharacterStringType

		public enum production_marker_4 : ushort
		{
			m_CharacterStringType,
			final
		};

		// markers associated with production: BuiltinType -> ChoiceType

		public enum production_marker_5 : ushort
		{
			m_ChoiceType,
			final
		};

		// markers associated with production: BuiltinType -> DateType

		public enum production_marker_6 : ushort
		{
			m_DateType,
			final
		};

		// markers associated with production: BuiltinType -> DateTimeType

		public enum production_marker_7 : ushort
		{
			m_DateTimeType,
			final
		};

		// markers associated with production: BuiltinType -> DurationType

		public enum production_marker_8 : ushort
		{
			m_DurationType,
			final
		};

		// markers associated with production: BuiltinType -> EmbeddedPDVType

		public enum production_marker_9 : ushort
		{
			m_EmbeddedPDVType,
			final
		};

		// markers associated with production: BuiltinType -> EnumeratedType

		public enum production_marker_10 : ushort
		{
			m_EnumeratedType,
			final
		};

		// markers associated with production: BuiltinType -> ExternalType

		public enum production_marker_11 : ushort
		{
			m_ExternalType,
			final
		};

		// markers associated with production: BuiltinType -> InstanceOfType

		public enum production_marker_12 : ushort
		{
			m_InstanceOfType,
			final
		};

		// markers associated with production: BuiltinType -> IntegerType

		public enum production_marker_13 : ushort
		{
			m_IntegerType,
			final
		};

		// markers associated with production: BuiltinType -> IRIType

		public enum production_marker_14 : ushort
		{
			m_IRIType,
			final
		};

		// markers associated with production: BuiltinType -> NullType

		public enum production_marker_15 : ushort
		{
			m_NullType,
			final
		};

		// markers associated with production: BuiltinType -> ObjectClassFieldType

		public enum production_marker_16 : ushort
		{
			m_ObjectClassFieldType,
			final
		};

		// markers associated with production: BuiltinType -> ObjectIdentifierType

		public enum production_marker_17 : ushort
		{
			m_ObjectIdentifierType,
			final
		};

		// markers associated with production: BuiltinType -> OctetStringType

		public enum production_marker_18 : ushort
		{
			m_OctetStringType,
			final
		};

		// markers associated with production: BuiltinType -> RealType

		public enum production_marker_19 : ushort
		{
			m_RealType,
			final
		};

		// markers associated with production: BuiltinType -> RelativeIRIType

		public enum production_marker_20 : ushort
		{
			m_RelativeIRIType,
			final
		};

		// markers associated with production: BuiltinType -> RelativeOIDType

		public enum production_marker_21 : ushort
		{
			m_RelativeOIDType,
			final
		};

		// markers associated with production: BuiltinType -> SequenceType

		public enum production_marker_22 : ushort
		{
			m_SequenceType,
			final
		};

		// markers associated with production: BuiltinType -> SequenceOfType

		public enum production_marker_23 : ushort
		{
			m_SequenceOfType,
			final
		};

		// markers associated with production: BuiltinType -> SetType

		public enum production_marker_24 : ushort
		{
			m_SetType,
			final
		};

		// markers associated with production: BuiltinType -> SetOfType

		public enum production_marker_25 : ushort
		{
			m_SetOfType,
			final
		};

		// markers associated with production: BuiltinType -> PrefixedType

		public enum production_marker_26 : ushort
		{
			m_PrefixedType,
			final
		};

		// markers associated with production: BuiltinType -> TimeType

		public enum production_marker_27 : ushort
		{
			m_TimeType,
			final
		};

		// markers associated with production: BuiltinType -> TimeOfDayType

		public enum production_marker_28 : ushort
		{
			m_TimeOfDayType,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule BuiltinType

		// Constructor declaration(s) associated with production(s) of syntax rule BuiltinType

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> AnyType

		//

		public BuiltinType (AnyType p_AnyType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_AnyType = p_AnyType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> BitStringType

		//

		public BuiltinType (BitStringType p_BitStringType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_BitStringType = p_BitStringType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> BooleanType

		//

		public BuiltinType (BooleanType p_BooleanType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_BooleanType = p_BooleanType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> CharacterStringType

		//

		public BuiltinType (CharacterStringType p_CharacterStringType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_CharacterStringType = p_CharacterStringType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> ChoiceType

		//

		public BuiltinType (ChoiceType p_ChoiceType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_5)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ChoiceType = p_ChoiceType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> DateType

		//

		public BuiltinType (DateType p_DateType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_6)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DateType = p_DateType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> DateTimeType

		//

		public BuiltinType (DateTimeType p_DateTimeType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_7)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DateTimeType = p_DateTimeType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> DurationType

		//

		public BuiltinType (DurationType p_DurationType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_8)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DurationType = p_DurationType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> EmbeddedPDVType

		//

		public BuiltinType (EmbeddedPDVType p_EmbeddedPDVType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_9)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_EmbeddedPDVType = p_EmbeddedPDVType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> EnumeratedType

		//

		public BuiltinType (EnumeratedType p_EnumeratedType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_10)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_EnumeratedType = p_EnumeratedType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> ExternalType

		//

		public BuiltinType (ExternalType p_ExternalType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_11)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ExternalType = p_ExternalType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> InstanceOfType

		//

		public BuiltinType (InstanceOfType p_InstanceOfType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_12)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_InstanceOfType = p_InstanceOfType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> IntegerType

		//

		public BuiltinType (IntegerType p_IntegerType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_13)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_IntegerType = p_IntegerType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> IRIType

		//

		public BuiltinType (IRIType p_IRIType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_14)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_IRIType = p_IRIType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> NullType

		//

		public BuiltinType (NullType p_NullType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_15)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NullType = p_NullType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> ObjectClassFieldType

		//

		public BuiltinType (ObjectClassFieldType p_ObjectClassFieldType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_16)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjectClassFieldType = p_ObjectClassFieldType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> ObjectIdentifierType

		//

		public BuiltinType (ObjectIdentifierType p_ObjectIdentifierType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_17)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjectIdentifierType = p_ObjectIdentifierType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> OctetStringType

		//

		public BuiltinType (OctetStringType p_OctetStringType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_18)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_OctetStringType = p_OctetStringType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> RealType

		//

		public BuiltinType (RealType p_RealType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_19)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_RealType = p_RealType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> RelativeIRIType

		//

		public BuiltinType (RelativeIRIType p_RelativeIRIType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_20)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_RelativeIRIType = p_RelativeIRIType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> RelativeOIDType

		//

		public BuiltinType (RelativeOIDType p_RelativeOIDType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_21)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_RelativeOIDType = p_RelativeOIDType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> SequenceType

		//

		public BuiltinType (SequenceType p_SequenceType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_22)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SequenceType = p_SequenceType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> SequenceOfType

		//

		public BuiltinType (SequenceOfType p_SequenceOfType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_23)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SequenceOfType = p_SequenceOfType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> SetType

		//

		public BuiltinType (SetType p_SetType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_24)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SetType = p_SetType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> SetOfType

		//

		public BuiltinType (SetOfType p_SetOfType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_25)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SetOfType = p_SetOfType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> PrefixedType

		//

		public BuiltinType (PrefixedType p_PrefixedType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_26)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_PrefixedType = p_PrefixedType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> TimeType

		//

		public BuiltinType (TimeType p_TimeType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_27)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TimeType = p_TimeType;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinType -> TimeOfDayType

		//

		public BuiltinType (TimeOfDayType p_TimeOfDayType) : base ((uint) ProductionID._BuiltinType_ID, (uint) production_kind.g_BuiltinType_28)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TimeOfDayType = p_TimeOfDayType;
		}

		public BuiltinType () { }

		// Copy constructor

		public BuiltinType (BuiltinType p_BuiltinType) : base (p_BuiltinType.id, p_BuiltinType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_BuiltinType.appInfo;
			switch ((production_kind) p_BuiltinType.kind)
			{
				case production_kind.g_BuiltinType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_AnyType = (p_BuiltinType.m_AnyType != null) ? new AnyType (p_BuiltinType.m_AnyType) : null) != null) m_AnyType.parent = this;
					break;
				case production_kind.g_BuiltinType_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_BitStringType = (p_BuiltinType.m_BitStringType != null) ? new BitStringType (p_BuiltinType.m_BitStringType) : null) != null) m_BitStringType.parent = this;
					break;
				case production_kind.g_BuiltinType_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_BooleanType = (p_BuiltinType.m_BooleanType != null) ? new BooleanType (p_BuiltinType.m_BooleanType) : null) != null) m_BooleanType.parent = this;
					break;
				case production_kind.g_BuiltinType_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_CharacterStringType = (p_BuiltinType.m_CharacterStringType != null) ? new CharacterStringType (p_BuiltinType.m_CharacterStringType) : null) != null) m_CharacterStringType.parent = this;
					break;
				case production_kind.g_BuiltinType_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ChoiceType = (p_BuiltinType.m_ChoiceType != null) ? new ChoiceType (p_BuiltinType.m_ChoiceType) : null) != null) m_ChoiceType.parent = this;
					break;
				case production_kind.g_BuiltinType_6:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DateType = (p_BuiltinType.m_DateType != null) ? new DateType (p_BuiltinType.m_DateType) : null) != null) m_DateType.parent = this;
					break;
				case production_kind.g_BuiltinType_7:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DateTimeType = (p_BuiltinType.m_DateTimeType != null) ? new DateTimeType (p_BuiltinType.m_DateTimeType) : null) != null) m_DateTimeType.parent = this;
					break;
				case production_kind.g_BuiltinType_8:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DurationType = (p_BuiltinType.m_DurationType != null) ? new DurationType (p_BuiltinType.m_DurationType) : null) != null) m_DurationType.parent = this;
					break;
				case production_kind.g_BuiltinType_9:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EmbeddedPDVType = (p_BuiltinType.m_EmbeddedPDVType != null) ? new EmbeddedPDVType (p_BuiltinType.m_EmbeddedPDVType) : null) != null) m_EmbeddedPDVType.parent = this;
					break;
				case production_kind.g_BuiltinType_10:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EnumeratedType = (p_BuiltinType.m_EnumeratedType != null) ? new EnumeratedType (p_BuiltinType.m_EnumeratedType) : null) != null) m_EnumeratedType.parent = this;
					break;
				case production_kind.g_BuiltinType_11:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ExternalType = (p_BuiltinType.m_ExternalType != null) ? new ExternalType (p_BuiltinType.m_ExternalType) : null) != null) m_ExternalType.parent = this;
					break;
				case production_kind.g_BuiltinType_12:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_InstanceOfType = (p_BuiltinType.m_InstanceOfType != null) ? new InstanceOfType (p_BuiltinType.m_InstanceOfType) : null) != null) m_InstanceOfType.parent = this;
					break;
				case production_kind.g_BuiltinType_13:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_IntegerType = (p_BuiltinType.m_IntegerType != null) ? new IntegerType (p_BuiltinType.m_IntegerType) : null) != null) m_IntegerType.parent = this;
					break;
				case production_kind.g_BuiltinType_14:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_IRIType = (p_BuiltinType.m_IRIType != null) ? new IRIType (p_BuiltinType.m_IRIType) : null) != null) m_IRIType.parent = this;
					break;
				case production_kind.g_BuiltinType_15:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NullType = (p_BuiltinType.m_NullType != null) ? new NullType (p_BuiltinType.m_NullType) : null) != null) m_NullType.parent = this;
					break;
				case production_kind.g_BuiltinType_16:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectClassFieldType = (p_BuiltinType.m_ObjectClassFieldType != null) ? new ObjectClassFieldType (p_BuiltinType.m_ObjectClassFieldType) : null) != null) m_ObjectClassFieldType.parent = this;
					break;
				case production_kind.g_BuiltinType_17:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectIdentifierType = (p_BuiltinType.m_ObjectIdentifierType != null) ? new ObjectIdentifierType (p_BuiltinType.m_ObjectIdentifierType) : null) != null) m_ObjectIdentifierType.parent = this;
					break;
				case production_kind.g_BuiltinType_18:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OctetStringType = (p_BuiltinType.m_OctetStringType != null) ? new OctetStringType (p_BuiltinType.m_OctetStringType) : null) != null) m_OctetStringType.parent = this;
					break;
				case production_kind.g_BuiltinType_19:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RealType = (p_BuiltinType.m_RealType != null) ? new RealType (p_BuiltinType.m_RealType) : null) != null) m_RealType.parent = this;
					break;
				case production_kind.g_BuiltinType_20:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RelativeIRIType = (p_BuiltinType.m_RelativeIRIType != null) ? new RelativeIRIType (p_BuiltinType.m_RelativeIRIType) : null) != null) m_RelativeIRIType.parent = this;
					break;
				case production_kind.g_BuiltinType_21:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RelativeOIDType = (p_BuiltinType.m_RelativeOIDType != null) ? new RelativeOIDType (p_BuiltinType.m_RelativeOIDType) : null) != null) m_RelativeOIDType.parent = this;
					break;
				case production_kind.g_BuiltinType_22:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SequenceType = (p_BuiltinType.m_SequenceType != null) ? new SequenceType (p_BuiltinType.m_SequenceType) : null) != null) m_SequenceType.parent = this;
					break;
				case production_kind.g_BuiltinType_23:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SequenceOfType = (p_BuiltinType.m_SequenceOfType != null) ? new SequenceOfType (p_BuiltinType.m_SequenceOfType) : null) != null) m_SequenceOfType.parent = this;
					break;
				case production_kind.g_BuiltinType_24:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SetType = (p_BuiltinType.m_SetType != null) ? new SetType (p_BuiltinType.m_SetType) : null) != null) m_SetType.parent = this;
					break;
				case production_kind.g_BuiltinType_25:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SetOfType = (p_BuiltinType.m_SetOfType != null) ? new SetOfType (p_BuiltinType.m_SetOfType) : null) != null) m_SetOfType.parent = this;
					break;
				case production_kind.g_BuiltinType_26:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_PrefixedType = (p_BuiltinType.m_PrefixedType != null) ? new PrefixedType (p_BuiltinType.m_PrefixedType) : null) != null) m_PrefixedType.parent = this;
					break;
				case production_kind.g_BuiltinType_27:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TimeType = (p_BuiltinType.m_TimeType != null) ? new TimeType (p_BuiltinType.m_TimeType) : null) != null) m_TimeType.parent = this;
					break;
				case production_kind.g_BuiltinType_28:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TimeOfDayType = (p_BuiltinType.m_TimeOfDayType != null) ? new TimeOfDayType (p_BuiltinType.m_TimeOfDayType) : null) != null) m_TimeOfDayType.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "BuiltinType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new BuiltinType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_AnyType?.Dispose ();
			m_BitStringType?.Dispose ();
			m_BooleanType?.Dispose ();
			m_CharacterStringType?.Dispose ();
			m_ChoiceType?.Dispose ();
			m_DateType?.Dispose ();
			m_DateTimeType?.Dispose ();
			m_DurationType?.Dispose ();
			m_EmbeddedPDVType?.Dispose ();
			m_EnumeratedType?.Dispose ();
			m_ExternalType?.Dispose ();
			m_InstanceOfType?.Dispose ();
			m_IntegerType?.Dispose ();
			m_IRIType?.Dispose ();
			m_NullType?.Dispose ();
			m_ObjectClassFieldType?.Dispose ();
			m_ObjectIdentifierType?.Dispose ();
			m_OctetStringType?.Dispose ();
			m_RealType?.Dispose ();
			m_RelativeIRIType?.Dispose ();
			m_RelativeOIDType?.Dispose ();
			m_SequenceType?.Dispose ();
			m_SequenceOfType?.Dispose ();
			m_SetType?.Dispose ();
			m_SetOfType?.Dispose ();
			m_PrefixedType?.Dispose ();
			m_TimeType?.Dispose ();
			m_TimeOfDayType?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule BuiltinType

		// Content changing function(s) associated with production(s) of syntax rule BuiltinType

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> AnyType

		//

		public void change(AnyType p_AnyType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_AnyType = p_AnyType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> BitStringType

		//

		public void change(BitStringType p_BitStringType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_BitStringType = p_BitStringType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> BooleanType

		//

		public void change(BooleanType p_BooleanType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_BooleanType = p_BooleanType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> CharacterStringType

		//

		public void change(CharacterStringType p_CharacterStringType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_CharacterStringType = p_CharacterStringType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> ChoiceType

		//

		public void change(ChoiceType p_ChoiceType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_5;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ChoiceType = p_ChoiceType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> DateType

		//

		public void change(DateType p_DateType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_6;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DateType = p_DateType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> DateTimeType

		//

		public void change(DateTimeType p_DateTimeType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_7;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DateTimeType = p_DateTimeType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> DurationType

		//

		public void change(DurationType p_DurationType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_8;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DurationType = p_DurationType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> EmbeddedPDVType

		//

		public void change(EmbeddedPDVType p_EmbeddedPDVType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_9;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_EmbeddedPDVType = p_EmbeddedPDVType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> EnumeratedType

		//

		public void change(EnumeratedType p_EnumeratedType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_10;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_EnumeratedType = p_EnumeratedType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> ExternalType

		//

		public void change(ExternalType p_ExternalType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_11;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ExternalType = p_ExternalType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> InstanceOfType

		//

		public void change(InstanceOfType p_InstanceOfType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_12;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_InstanceOfType = p_InstanceOfType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> IntegerType

		//

		public void change(IntegerType p_IntegerType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_13;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_IntegerType = p_IntegerType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> IRIType

		//

		public void change(IRIType p_IRIType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_14;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_IRIType = p_IRIType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> NullType

		//

		public void change(NullType p_NullType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_15;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NullType = p_NullType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> ObjectClassFieldType

		//

		public void change(ObjectClassFieldType p_ObjectClassFieldType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_16;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjectClassFieldType = p_ObjectClassFieldType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> ObjectIdentifierType

		//

		public void change(ObjectIdentifierType p_ObjectIdentifierType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_17;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjectIdentifierType = p_ObjectIdentifierType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> OctetStringType

		//

		public void change(OctetStringType p_OctetStringType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_18;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_OctetStringType = p_OctetStringType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> RealType

		//

		public void change(RealType p_RealType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_19;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_RealType = p_RealType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> RelativeIRIType

		//

		public void change(RelativeIRIType p_RelativeIRIType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_20;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_RelativeIRIType = p_RelativeIRIType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> RelativeOIDType

		//

		public void change(RelativeOIDType p_RelativeOIDType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_21;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_RelativeOIDType = p_RelativeOIDType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> SequenceType

		//

		public void change(SequenceType p_SequenceType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_22;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SequenceType = p_SequenceType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> SequenceOfType

		//

		public void change(SequenceOfType p_SequenceOfType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_23;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SequenceOfType = p_SequenceOfType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> SetType

		//

		public void change(SetType p_SetType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_24;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SetType = p_SetType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> SetOfType

		//

		public void change(SetOfType p_SetOfType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_25;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SetOfType = p_SetOfType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> PrefixedType

		//

		public void change(PrefixedType p_PrefixedType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_26;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_PrefixedType = p_PrefixedType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> TimeType

		//

		public void change(TimeType p_TimeType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_27;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TimeType = p_TimeType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinType -> TimeOfDayType

		//

		public void change(TimeOfDayType p_TimeOfDayType)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinType_28;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TimeOfDayType = p_TimeOfDayType;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule BuiltinType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_AnyType != null) && m_AnyType.checkInclusion (element) ||
				(m_BitStringType != null) && m_BitStringType.checkInclusion (element) ||
				(m_BooleanType != null) && m_BooleanType.checkInclusion (element) ||
				(m_CharacterStringType != null) && m_CharacterStringType.checkInclusion (element) ||
				(m_ChoiceType != null) && m_ChoiceType.checkInclusion (element) ||
				(m_DateType != null) && m_DateType.checkInclusion (element) ||
				(m_DateTimeType != null) && m_DateTimeType.checkInclusion (element) ||
				(m_DurationType != null) && m_DurationType.checkInclusion (element) ||
				(m_EmbeddedPDVType != null) && m_EmbeddedPDVType.checkInclusion (element) ||
				(m_EnumeratedType != null) && m_EnumeratedType.checkInclusion (element) ||
				(m_ExternalType != null) && m_ExternalType.checkInclusion (element) ||
				(m_InstanceOfType != null) && m_InstanceOfType.checkInclusion (element) ||
				(m_IntegerType != null) && m_IntegerType.checkInclusion (element) ||
				(m_IRIType != null) && m_IRIType.checkInclusion (element) ||
				(m_NullType != null) && m_NullType.checkInclusion (element) ||
				(m_ObjectClassFieldType != null) && m_ObjectClassFieldType.checkInclusion (element) ||
				(m_ObjectIdentifierType != null) && m_ObjectIdentifierType.checkInclusion (element) ||
				(m_OctetStringType != null) && m_OctetStringType.checkInclusion (element) ||
				(m_RealType != null) && m_RealType.checkInclusion (element) ||
				(m_RelativeIRIType != null) && m_RelativeIRIType.checkInclusion (element) ||
				(m_RelativeOIDType != null) && m_RelativeOIDType.checkInclusion (element) ||
				(m_SequenceType != null) && m_SequenceType.checkInclusion (element) ||
				(m_SequenceOfType != null) && m_SequenceOfType.checkInclusion (element) ||
				(m_SetType != null) && m_SetType.checkInclusion (element) ||
				(m_SetOfType != null) && m_SetOfType.checkInclusion (element) ||
				(m_PrefixedType != null) && m_PrefixedType.checkInclusion (element) ||
				(m_TimeType != null) && m_TimeType.checkInclusion (element) ||
				(m_TimeOfDayType != null) && m_TimeOfDayType.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule BuiltinType

		//
		// emit production tree node associated with any production of syntax rule BuiltinType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_BuiltinType_1:
					// emit syntax tree node associated with production
					// BuiltinType: AnyType

					s += m_AnyType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_2:
					// emit syntax tree node associated with production
					// BuiltinType: BitStringType

					s += m_BitStringType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_3:
					// emit syntax tree node associated with production
					// BuiltinType: BooleanType

					s += m_BooleanType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_4:
					// emit syntax tree node associated with production
					// BuiltinType: CharacterStringType

					s += m_CharacterStringType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_5:
					// emit syntax tree node associated with production
					// BuiltinType: ChoiceType

					s += m_ChoiceType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_6:
					// emit syntax tree node associated with production
					// BuiltinType: DateType

					s += m_DateType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_7:
					// emit syntax tree node associated with production
					// BuiltinType: DateTimeType

					s += m_DateTimeType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_8:
					// emit syntax tree node associated with production
					// BuiltinType: DurationType

					s += m_DurationType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_9:
					// emit syntax tree node associated with production
					// BuiltinType: EmbeddedPDVType

					s += m_EmbeddedPDVType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_10:
					// emit syntax tree node associated with production
					// BuiltinType: EnumeratedType

					s += m_EnumeratedType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_11:
					// emit syntax tree node associated with production
					// BuiltinType: ExternalType

					s += m_ExternalType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_12:
					// emit syntax tree node associated with production
					// BuiltinType: InstanceOfType

					s += m_InstanceOfType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_13:
					// emit syntax tree node associated with production
					// BuiltinType: IntegerType

					s += m_IntegerType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_14:
					// emit syntax tree node associated with production
					// BuiltinType: IRIType

					s += m_IRIType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_15:
					// emit syntax tree node associated with production
					// BuiltinType: NullType

					s += m_NullType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_16:
					// emit syntax tree node associated with production
					// BuiltinType: ObjectClassFieldType

					s += m_ObjectClassFieldType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_17:
					// emit syntax tree node associated with production
					// BuiltinType: ObjectIdentifierType

					s += m_ObjectIdentifierType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_18:
					// emit syntax tree node associated with production
					// BuiltinType: OctetStringType

					s += m_OctetStringType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_19:
					// emit syntax tree node associated with production
					// BuiltinType: RealType

					s += m_RealType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_20:
					// emit syntax tree node associated with production
					// BuiltinType: RelativeIRIType

					s += m_RelativeIRIType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_21:
					// emit syntax tree node associated with production
					// BuiltinType: RelativeOIDType

					s += m_RelativeOIDType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_22:
					// emit syntax tree node associated with production
					// BuiltinType: SequenceType

					s += m_SequenceType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_23:
					// emit syntax tree node associated with production
					// BuiltinType: SequenceOfType

					s += m_SequenceOfType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_24:
					// emit syntax tree node associated with production
					// BuiltinType: SetType

					s += m_SetType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_25:
					// emit syntax tree node associated with production
					// BuiltinType: SetOfType

					s += m_SetOfType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_26:
					// emit syntax tree node associated with production
					// BuiltinType: PrefixedType

					s += m_PrefixedType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_27:
					// emit syntax tree node associated with production
					// BuiltinType: TimeType

					s += m_TimeType.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinType_28:
					// emit syntax tree node associated with production
					// BuiltinType: TimeOfDayType

					s += m_TimeOfDayType.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule BuiltinType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "BuiltinType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_BuiltinType_1:
					// emit syntax tree node associated with production
					// BuiltinType: AnyType

					s += m_AnyType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_2:
					// emit syntax tree node associated with production
					// BuiltinType: BitStringType

					s += m_BitStringType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_3:
					// emit syntax tree node associated with production
					// BuiltinType: BooleanType

					s += m_BooleanType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_4:
					// emit syntax tree node associated with production
					// BuiltinType: CharacterStringType

					s += m_CharacterStringType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_5:
					// emit syntax tree node associated with production
					// BuiltinType: ChoiceType

					s += m_ChoiceType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_6:
					// emit syntax tree node associated with production
					// BuiltinType: DateType

					s += m_DateType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_7:
					// emit syntax tree node associated with production
					// BuiltinType: DateTimeType

					s += m_DateTimeType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_8:
					// emit syntax tree node associated with production
					// BuiltinType: DurationType

					s += m_DurationType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_9:
					// emit syntax tree node associated with production
					// BuiltinType: EmbeddedPDVType

					s += m_EmbeddedPDVType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_10:
					// emit syntax tree node associated with production
					// BuiltinType: EnumeratedType

					s += m_EnumeratedType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_11:
					// emit syntax tree node associated with production
					// BuiltinType: ExternalType

					s += m_ExternalType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_12:
					// emit syntax tree node associated with production
					// BuiltinType: InstanceOfType

					s += m_InstanceOfType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_13:
					// emit syntax tree node associated with production
					// BuiltinType: IntegerType

					s += m_IntegerType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_14:
					// emit syntax tree node associated with production
					// BuiltinType: IRIType

					s += m_IRIType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_15:
					// emit syntax tree node associated with production
					// BuiltinType: NullType

					s += m_NullType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_16:
					// emit syntax tree node associated with production
					// BuiltinType: ObjectClassFieldType

					s += m_ObjectClassFieldType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_17:
					// emit syntax tree node associated with production
					// BuiltinType: ObjectIdentifierType

					s += m_ObjectIdentifierType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_18:
					// emit syntax tree node associated with production
					// BuiltinType: OctetStringType

					s += m_OctetStringType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_19:
					// emit syntax tree node associated with production
					// BuiltinType: RealType

					s += m_RealType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_20:
					// emit syntax tree node associated with production
					// BuiltinType: RelativeIRIType

					s += m_RelativeIRIType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_21:
					// emit syntax tree node associated with production
					// BuiltinType: RelativeOIDType

					s += m_RelativeOIDType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_22:
					// emit syntax tree node associated with production
					// BuiltinType: SequenceType

					s += m_SequenceType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_23:
					// emit syntax tree node associated with production
					// BuiltinType: SequenceOfType

					s += m_SequenceOfType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_24:
					// emit syntax tree node associated with production
					// BuiltinType: SetType

					s += m_SetType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_25:
					// emit syntax tree node associated with production
					// BuiltinType: SetOfType

					s += m_SetOfType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_26:
					// emit syntax tree node associated with production
					// BuiltinType: PrefixedType

					s += m_PrefixedType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_27:
					// emit syntax tree node associated with production
					// BuiltinType: TimeType

					s += m_TimeType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinType_28:
					// emit syntax tree node associated with production
					// BuiltinType: TimeOfDayType

					s += m_TimeOfDayType.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule BuiltinType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule BuiltinType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			BuiltinType.production_kind kind = (BuiltinType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case BuiltinType.production_kind.g_BuiltinType_1:
					// traverse syntax tree node associated with production
					// BuiltinType: AnyType

						m_AnyType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_2:
					// traverse syntax tree node associated with production
					// BuiltinType: BitStringType

						m_BitStringType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_3:
					// traverse syntax tree node associated with production
					// BuiltinType: BooleanType

						m_BooleanType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_4:
					// traverse syntax tree node associated with production
					// BuiltinType: CharacterStringType

						m_CharacterStringType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_5:
					// traverse syntax tree node associated with production
					// BuiltinType: ChoiceType

						m_ChoiceType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_6:
					// traverse syntax tree node associated with production
					// BuiltinType: DateType

						m_DateType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_7:
					// traverse syntax tree node associated with production
					// BuiltinType: DateTimeType

						m_DateTimeType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_8:
					// traverse syntax tree node associated with production
					// BuiltinType: DurationType

						m_DurationType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_9:
					// traverse syntax tree node associated with production
					// BuiltinType: EmbeddedPDVType

						m_EmbeddedPDVType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_10:
					// traverse syntax tree node associated with production
					// BuiltinType: EnumeratedType

						m_EnumeratedType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_11:
					// traverse syntax tree node associated with production
					// BuiltinType: ExternalType

						m_ExternalType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_12:
					// traverse syntax tree node associated with production
					// BuiltinType: InstanceOfType

						m_InstanceOfType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_13:
					// traverse syntax tree node associated with production
					// BuiltinType: IntegerType

						m_IntegerType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_14:
					// traverse syntax tree node associated with production
					// BuiltinType: IRIType

						m_IRIType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_15:
					// traverse syntax tree node associated with production
					// BuiltinType: NullType

						m_NullType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_16:
					// traverse syntax tree node associated with production
					// BuiltinType: ObjectClassFieldType

						m_ObjectClassFieldType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_17:
					// traverse syntax tree node associated with production
					// BuiltinType: ObjectIdentifierType

						m_ObjectIdentifierType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_18:
					// traverse syntax tree node associated with production
					// BuiltinType: OctetStringType

						m_OctetStringType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_19:
					// traverse syntax tree node associated with production
					// BuiltinType: RealType

						m_RealType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_20:
					// traverse syntax tree node associated with production
					// BuiltinType: RelativeIRIType

						m_RelativeIRIType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_21:
					// traverse syntax tree node associated with production
					// BuiltinType: RelativeOIDType

						m_RelativeOIDType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_22:
					// traverse syntax tree node associated with production
					// BuiltinType: SequenceType

						m_SequenceType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_23:
					// traverse syntax tree node associated with production
					// BuiltinType: SequenceOfType

						m_SequenceOfType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_24:
					// traverse syntax tree node associated with production
					// BuiltinType: SetType

						m_SetType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_25:
					// traverse syntax tree node associated with production
					// BuiltinType: SetOfType

						m_SetOfType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_26:
					// traverse syntax tree node associated with production
					// BuiltinType: PrefixedType

						m_PrefixedType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_27:
					// traverse syntax tree node associated with production
					// BuiltinType: TimeType

						m_TimeType.Visit (visitor, appData);
				break;
				case BuiltinType.production_kind.g_BuiltinType_28:
					// traverse syntax tree node associated with production
					// BuiltinType: TimeOfDayType

						m_TimeOfDayType.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_AnyType?.reparent (this);
			m_BitStringType?.reparent (this);
			m_BooleanType?.reparent (this);
			m_CharacterStringType?.reparent (this);
			m_ChoiceType?.reparent (this);
			m_DateType?.reparent (this);
			m_DateTimeType?.reparent (this);
			m_DurationType?.reparent (this);
			m_EmbeddedPDVType?.reparent (this);
			m_EnumeratedType?.reparent (this);
			m_ExternalType?.reparent (this);
			m_InstanceOfType?.reparent (this);
			m_IntegerType?.reparent (this);
			m_IRIType?.reparent (this);
			m_NullType?.reparent (this);
			m_ObjectClassFieldType?.reparent (this);
			m_ObjectIdentifierType?.reparent (this);
			m_OctetStringType?.reparent (this);
			m_RealType?.reparent (this);
			m_RelativeIRIType?.reparent (this);
			m_RelativeOIDType?.reparent (this);
			m_SequenceType?.reparent (this);
			m_SequenceOfType?.reparent (this);
			m_SetType?.reparent (this);
			m_SetOfType?.reparent (this);
			m_PrefixedType?.reparent (this);
			m_TimeType?.reparent (this);
			m_TimeOfDayType?.reparent (this);
		}

		//
		// initialize object associated with syntax rule BuiltinType
		//

		public void _init ()
		{
			m_AnyType = null;
			m_BitStringType = null;
			m_BooleanType = null;
			m_CharacterStringType = null;
			m_ChoiceType = null;
			m_DateType = null;
			m_DateTimeType = null;
			m_DurationType = null;
			m_EmbeddedPDVType = null;
			m_EnumeratedType = null;
			m_ExternalType = null;
			m_InstanceOfType = null;
			m_IntegerType = null;
			m_IRIType = null;
			m_NullType = null;
			m_ObjectClassFieldType = null;
			m_ObjectIdentifierType = null;
			m_OctetStringType = null;
			m_RealType = null;
			m_RelativeIRIType = null;
			m_RelativeOIDType = null;
			m_SequenceType = null;
			m_SequenceOfType = null;
			m_SetType = null;
			m_SetOfType = null;
			m_PrefixedType = null;
			m_TimeType = null;
			m_TimeOfDayType = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule BuiltinType

		// counter of all nodes associated with syntax rule BuiltinType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule BuiltinType
		[DataMember (Name = "m_AnyType")] public AnyType m_AnyType { get; private set; }
		[DataMember (Name = "m_BitStringType")] public BitStringType m_BitStringType { get; private set; }
		[DataMember (Name = "m_BooleanType")] public BooleanType m_BooleanType { get; private set; }
		[DataMember (Name = "m_CharacterStringType")] public CharacterStringType m_CharacterStringType { get; private set; }
		[DataMember (Name = "m_ChoiceType")] public ChoiceType m_ChoiceType { get; private set; }
		[DataMember (Name = "m_DateType")] public DateType m_DateType { get; private set; }
		[DataMember (Name = "m_DateTimeType")] public DateTimeType m_DateTimeType { get; private set; }
		[DataMember (Name = "m_DurationType")] public DurationType m_DurationType { get; private set; }
		[DataMember (Name = "m_EmbeddedPDVType")] public EmbeddedPDVType m_EmbeddedPDVType { get; private set; }
		[DataMember (Name = "m_EnumeratedType")] public EnumeratedType m_EnumeratedType { get; private set; }
		[DataMember (Name = "m_ExternalType")] public ExternalType m_ExternalType { get; private set; }
		[DataMember (Name = "m_InstanceOfType")] public InstanceOfType m_InstanceOfType { get; private set; }
		[DataMember (Name = "m_IntegerType")] public IntegerType m_IntegerType { get; private set; }
		[DataMember (Name = "m_IRIType")] public IRIType m_IRIType { get; private set; }
		[DataMember (Name = "m_NullType")] public NullType m_NullType { get; private set; }
		[DataMember (Name = "m_ObjectClassFieldType")] public ObjectClassFieldType m_ObjectClassFieldType { get; private set; }
		[DataMember (Name = "m_ObjectIdentifierType")] public ObjectIdentifierType m_ObjectIdentifierType { get; private set; }
		[DataMember (Name = "m_OctetStringType")] public OctetStringType m_OctetStringType { get; private set; }
		[DataMember (Name = "m_RealType")] public RealType m_RealType { get; private set; }
		[DataMember (Name = "m_RelativeIRIType")] public RelativeIRIType m_RelativeIRIType { get; private set; }
		[DataMember (Name = "m_RelativeOIDType")] public RelativeOIDType m_RelativeOIDType { get; private set; }
		[DataMember (Name = "m_SequenceType")] public SequenceType m_SequenceType { get; private set; }
		[DataMember (Name = "m_SequenceOfType")] public SequenceOfType m_SequenceOfType { get; private set; }
		[DataMember (Name = "m_SetType")] public SetType m_SetType { get; private set; }
		[DataMember (Name = "m_SetOfType")] public SetOfType m_SetOfType { get; private set; }
		[DataMember (Name = "m_PrefixedType")] public PrefixedType m_PrefixedType { get; private set; }
		[DataMember (Name = "m_TimeType")] public TimeType m_TimeType { get; private set; }
		[DataMember (Name = "m_TimeOfDayType")] public TimeOfDayType m_TimeOfDayType { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule BuiltinType

		// delegate function (callback) prototype associated with syntax rule BuiltinType
		public delegate bool BuiltinType_Callback (SyntaxTreeCallbackReason reason, BuiltinType.production_kind kind, BuiltinType p_BuiltinType);

		// event associated with syntax rule BuiltinType
		public event BuiltinType_Callback BuiltinType_Event;

		// event trigger associated with syntax rule BuiltinType
		public bool Raise_BuiltinType_Event (SyntaxTreeCallbackReason reason, BuiltinType.production_kind kind, BuiltinType p_BuiltinType)
		{
			bool? status = BuiltinType_Event?.Invoke (reason, kind, p_BuiltinType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule BuiltinType
		//
		// traverse syntax tree node associated with any production of syntax rule BuiltinType
		//

		public void Traverse (BuiltinType p_BuiltinType)
		{
			if (p_BuiltinType.isLocked())
				return;
			p_BuiltinType.dolock();
			BuiltinType.production_kind kind = (BuiltinType.production_kind) p_BuiltinType.kind;
			p_BuiltinType.turn_reset ();
			if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_BuiltinType))
			switch (kind)
			{
				case BuiltinType.production_kind.g_BuiltinType_1:
					// traverse syntax tree node associated with production
					// BuiltinType: AnyType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_AnyType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_2:
					// traverse syntax tree node associated with production
					// BuiltinType: BitStringType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_BitStringType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_3:
					// traverse syntax tree node associated with production
					// BuiltinType: BooleanType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_BooleanType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_4:
					// traverse syntax tree node associated with production
					// BuiltinType: CharacterStringType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_CharacterStringType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_5:
					// traverse syntax tree node associated with production
					// BuiltinType: ChoiceType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_ChoiceType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_6:
					// traverse syntax tree node associated with production
					// BuiltinType: DateType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_DateType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_7:
					// traverse syntax tree node associated with production
					// BuiltinType: DateTimeType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_DateTimeType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_8:
					// traverse syntax tree node associated with production
					// BuiltinType: DurationType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_DurationType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_9:
					// traverse syntax tree node associated with production
					// BuiltinType: EmbeddedPDVType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_EmbeddedPDVType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_10:
					// traverse syntax tree node associated with production
					// BuiltinType: EnumeratedType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_EnumeratedType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_11:
					// traverse syntax tree node associated with production
					// BuiltinType: ExternalType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_ExternalType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_12:
					// traverse syntax tree node associated with production
					// BuiltinType: InstanceOfType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_InstanceOfType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_13:
					// traverse syntax tree node associated with production
					// BuiltinType: IntegerType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_IntegerType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_14:
					// traverse syntax tree node associated with production
					// BuiltinType: IRIType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_IRIType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_15:
					// traverse syntax tree node associated with production
					// BuiltinType: NullType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_NullType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_16:
					// traverse syntax tree node associated with production
					// BuiltinType: ObjectClassFieldType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_ObjectClassFieldType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_17:
					// traverse syntax tree node associated with production
					// BuiltinType: ObjectIdentifierType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_ObjectIdentifierType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_18:
					// traverse syntax tree node associated with production
					// BuiltinType: OctetStringType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_OctetStringType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_19:
					// traverse syntax tree node associated with production
					// BuiltinType: RealType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_RealType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_20:
					// traverse syntax tree node associated with production
					// BuiltinType: RelativeIRIType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_RelativeIRIType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_21:
					// traverse syntax tree node associated with production
					// BuiltinType: RelativeOIDType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_RelativeOIDType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_22:
					// traverse syntax tree node associated with production
					// BuiltinType: SequenceType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_SequenceType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_23:
					// traverse syntax tree node associated with production
					// BuiltinType: SequenceOfType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_SequenceOfType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_24:
					// traverse syntax tree node associated with production
					// BuiltinType: SetType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_SetType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_25:
					// traverse syntax tree node associated with production
					// BuiltinType: SetOfType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_SetOfType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_26:
					// traverse syntax tree node associated with production
					// BuiltinType: PrefixedType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_PrefixedType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_27:
					// traverse syntax tree node associated with production
					// BuiltinType: TimeType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_TimeType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_28:
					// traverse syntax tree node associated with production
					// BuiltinType: TimeOfDayType

					if (Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType))
						Traverse (p_BuiltinType.m_TimeOfDayType);
					p_BuiltinType.turn_inc ();
					Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinType);
				break;
			}
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_BuiltinType);
			p_BuiltinType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule BuiltinType
		//

		public void TraverseCommon (BuiltinType p_BuiltinType)
		{
			BuiltinType.production_kind kind = (BuiltinType.production_kind) p_BuiltinType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_BuiltinType))
			switch (kind)
			{
				case BuiltinType.production_kind.g_BuiltinType_1:
					// traverse syntax tree node associated with production
					// BuiltinType: AnyType

						TraverseCommon (p_BuiltinType.m_AnyType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_2:
					// traverse syntax tree node associated with production
					// BuiltinType: BitStringType

						TraverseCommon (p_BuiltinType.m_BitStringType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_3:
					// traverse syntax tree node associated with production
					// BuiltinType: BooleanType

						TraverseCommon (p_BuiltinType.m_BooleanType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_4:
					// traverse syntax tree node associated with production
					// BuiltinType: CharacterStringType

						TraverseCommon (p_BuiltinType.m_CharacterStringType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_5:
					// traverse syntax tree node associated with production
					// BuiltinType: ChoiceType

						TraverseCommon (p_BuiltinType.m_ChoiceType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_6:
					// traverse syntax tree node associated with production
					// BuiltinType: DateType

						TraverseCommon (p_BuiltinType.m_DateType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_7:
					// traverse syntax tree node associated with production
					// BuiltinType: DateTimeType

						TraverseCommon (p_BuiltinType.m_DateTimeType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_8:
					// traverse syntax tree node associated with production
					// BuiltinType: DurationType

						TraverseCommon (p_BuiltinType.m_DurationType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_9:
					// traverse syntax tree node associated with production
					// BuiltinType: EmbeddedPDVType

						TraverseCommon (p_BuiltinType.m_EmbeddedPDVType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_10:
					// traverse syntax tree node associated with production
					// BuiltinType: EnumeratedType

						TraverseCommon (p_BuiltinType.m_EnumeratedType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_11:
					// traverse syntax tree node associated with production
					// BuiltinType: ExternalType

						TraverseCommon (p_BuiltinType.m_ExternalType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_12:
					// traverse syntax tree node associated with production
					// BuiltinType: InstanceOfType

						TraverseCommon (p_BuiltinType.m_InstanceOfType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_13:
					// traverse syntax tree node associated with production
					// BuiltinType: IntegerType

						TraverseCommon (p_BuiltinType.m_IntegerType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_14:
					// traverse syntax tree node associated with production
					// BuiltinType: IRIType

						TraverseCommon (p_BuiltinType.m_IRIType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_15:
					// traverse syntax tree node associated with production
					// BuiltinType: NullType

						TraverseCommon (p_BuiltinType.m_NullType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_16:
					// traverse syntax tree node associated with production
					// BuiltinType: ObjectClassFieldType

						TraverseCommon (p_BuiltinType.m_ObjectClassFieldType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_17:
					// traverse syntax tree node associated with production
					// BuiltinType: ObjectIdentifierType

						TraverseCommon (p_BuiltinType.m_ObjectIdentifierType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_18:
					// traverse syntax tree node associated with production
					// BuiltinType: OctetStringType

						TraverseCommon (p_BuiltinType.m_OctetStringType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_19:
					// traverse syntax tree node associated with production
					// BuiltinType: RealType

						TraverseCommon (p_BuiltinType.m_RealType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_20:
					// traverse syntax tree node associated with production
					// BuiltinType: RelativeIRIType

						TraverseCommon (p_BuiltinType.m_RelativeIRIType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_21:
					// traverse syntax tree node associated with production
					// BuiltinType: RelativeOIDType

						TraverseCommon (p_BuiltinType.m_RelativeOIDType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_22:
					// traverse syntax tree node associated with production
					// BuiltinType: SequenceType

						TraverseCommon (p_BuiltinType.m_SequenceType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_23:
					// traverse syntax tree node associated with production
					// BuiltinType: SequenceOfType

						TraverseCommon (p_BuiltinType.m_SequenceOfType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_24:
					// traverse syntax tree node associated with production
					// BuiltinType: SetType

						TraverseCommon (p_BuiltinType.m_SetType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_25:
					// traverse syntax tree node associated with production
					// BuiltinType: SetOfType

						TraverseCommon (p_BuiltinType.m_SetOfType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_26:
					// traverse syntax tree node associated with production
					// BuiltinType: PrefixedType

						TraverseCommon (p_BuiltinType.m_PrefixedType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_27:
					// traverse syntax tree node associated with production
					// BuiltinType: TimeType

						TraverseCommon (p_BuiltinType.m_TimeType);
				break;
				case BuiltinType.production_kind.g_BuiltinType_28:
					// traverse syntax tree node associated with production
					// BuiltinType: TimeOfDayType

						TraverseCommon (p_BuiltinType.m_TimeOfDayType);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_BuiltinType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule BuiltinType

		//
		// create syntax tree node associated with production
		// BuiltinType: AnyType

		//

		public BuiltinType BuiltinType_1 (AnyType p_AnyType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_AnyType);
			p_AnyType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_1, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: BitStringType

		//

		public BuiltinType BuiltinType_2 (BitStringType p_BitStringType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_BitStringType);
			p_BitStringType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_2, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: BooleanType

		//

		public BuiltinType BuiltinType_3 (BooleanType p_BooleanType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_BooleanType);
			p_BooleanType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_3, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: CharacterStringType

		//

		public BuiltinType BuiltinType_4 (CharacterStringType p_CharacterStringType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_CharacterStringType);
			p_CharacterStringType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_4, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: ChoiceType

		//

		public BuiltinType BuiltinType_5 (ChoiceType p_ChoiceType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_ChoiceType);
			p_ChoiceType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_5, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: DateType

		//

		public BuiltinType BuiltinType_6 (DateType p_DateType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_DateType);
			p_DateType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_6, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: DateTimeType

		//

		public BuiltinType BuiltinType_7 (DateTimeType p_DateTimeType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_DateTimeType);
			p_DateTimeType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_7, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: DurationType

		//

		public BuiltinType BuiltinType_8 (DurationType p_DurationType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_DurationType);
			p_DurationType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_8, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: EmbeddedPDVType

		//

		public BuiltinType BuiltinType_9 (EmbeddedPDVType p_EmbeddedPDVType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_EmbeddedPDVType);
			p_EmbeddedPDVType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_9, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: EnumeratedType

		//

		public BuiltinType BuiltinType_10 (EnumeratedType p_EnumeratedType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_EnumeratedType);
			p_EnumeratedType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_10, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: ExternalType

		//

		public BuiltinType BuiltinType_11 (ExternalType p_ExternalType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_ExternalType);
			p_ExternalType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_11, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: InstanceOfType

		//

		public BuiltinType BuiltinType_12 (InstanceOfType p_InstanceOfType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_InstanceOfType);
			p_InstanceOfType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_12, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: IntegerType

		//

		public BuiltinType BuiltinType_13 (IntegerType p_IntegerType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_IntegerType);
			p_IntegerType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_13, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: IRIType

		//

		public BuiltinType BuiltinType_14 (IRIType p_IRIType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_IRIType);
			p_IRIType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_14, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: NullType

		//

		public BuiltinType BuiltinType_15 (NullType p_NullType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_NullType);
			p_NullType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_15, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: ObjectClassFieldType

		//

		public BuiltinType BuiltinType_16 (ObjectClassFieldType p_ObjectClassFieldType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_ObjectClassFieldType);
			p_ObjectClassFieldType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_16, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: ObjectIdentifierType

		//

		public BuiltinType BuiltinType_17 (ObjectIdentifierType p_ObjectIdentifierType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_ObjectIdentifierType);
			p_ObjectIdentifierType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_17, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: OctetStringType

		//

		public BuiltinType BuiltinType_18 (OctetStringType p_OctetStringType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_OctetStringType);
			p_OctetStringType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_18, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: RealType

		//

		public BuiltinType BuiltinType_19 (RealType p_RealType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_RealType);
			p_RealType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_19, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: RelativeIRIType

		//

		public BuiltinType BuiltinType_20 (RelativeIRIType p_RelativeIRIType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_RelativeIRIType);
			p_RelativeIRIType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_20, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: RelativeOIDType

		//

		public BuiltinType BuiltinType_21 (RelativeOIDType p_RelativeOIDType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_RelativeOIDType);
			p_RelativeOIDType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_21, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: SequenceType

		//

		public BuiltinType BuiltinType_22 (SequenceType p_SequenceType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_SequenceType);
			p_SequenceType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_22, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: SequenceOfType

		//

		public BuiltinType BuiltinType_23 (SequenceOfType p_SequenceOfType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_SequenceOfType);
			p_SequenceOfType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_23, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: SetType

		//

		public BuiltinType BuiltinType_24 (SetType p_SetType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_SetType);
			p_SetType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_24, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: SetOfType

		//

		public BuiltinType BuiltinType_25 (SetOfType p_SetOfType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_SetOfType);
			p_SetOfType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_25, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: PrefixedType

		//

		public BuiltinType BuiltinType_26 (PrefixedType p_PrefixedType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_PrefixedType);
			p_PrefixedType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_26, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: TimeType

		//

		public BuiltinType BuiltinType_27 (TimeType p_TimeType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_TimeType);
			p_TimeType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_27, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinType: TimeOfDayType

		//

		public BuiltinType BuiltinType_28 (TimeOfDayType p_TimeOfDayType)
		{
			BuiltinType p_BuiltinType_ref = new BuiltinType(p_TimeOfDayType);
			p_TimeOfDayType.parent = p_BuiltinType_ref;
			Raise_BuiltinType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinType.production_kind.g_BuiltinType_28, p_BuiltinType_ref);
			return p_BuiltinType_ref;
		}
		#endregion
	};
}
