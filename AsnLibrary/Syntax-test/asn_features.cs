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
	// class associated with syntax rule asn-features
	//

	[DataContract]
	public class	asn_features : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule asn-features
		public enum production_kind : ushort	// enumerated production(s) of syntax rule asn-features
		{
			g_asn_features_1 = 1,	// ModuleDefinitions-token ModuleDefinitions

			g_asn_features_2 = 2,	// ParameterizedType-token ParameterizedType

			g_asn_features_3 = 3,	// ParameterizedValue-token ParameterizedValue

			g_asn_features_4 = 4,	// ParameterizedValueSetType-token ParameterizedValueSetType

			g_asn_features_5 = 5,	// ParameterizedObjectClass-token ParameterizedObjectClass

			g_asn_features_6 = 6,	// ParameterizedObjectSet-token ParameterizedObjectSet

			g_asn_features_7 = 7,	// ParameterizedObject-token ParameterizedObject

			g_asn_features_8 = 8,	// AssignmentList-token AssignmentList

			g_asn_features_9 = 9,	// BuiltinValue-token BuiltinValue

			g_asn_features_10 = 10,	// TypeAssignment-token TypeAssignment

			g_asn_features_11 = 11,	// ValueAssignment-token ValueAssignment

			g_asn_features_12 = 12,	// ValueSetTypeAssignment-token ValueSetTypeAssignment

			g_asn_features_13 = 13,	// ObjectClassAssignment-token ObjectClassAssignment

			g_asn_features_14 = 14,	// ObjectAssignment-token ObjectAssignment

			g_asn_features_15 = 15,	// ObjectSetAssignment-token ObjectSetAssignment

			g_asn_features_16 = 16,	// ParameterizedTypeAssignment-token ParameterizedTypeAssignment

			g_asn_features_17 = 17,	// ParameterizedValueAssignment-token ParameterizedValueAssignment

			g_asn_features_18 = 18,	// ParameterizedValueSetTypeAssignment-token ParameterizedValueSetTypeAssignment

			g_asn_features_19 = 19,	// ParameterizedObjectClassAssignment-token ParameterizedObjectClassAssignment

			g_asn_features_20 = 20,	// ParameterizedObjectAssignment-token ParameterizedObjectAssignment

			g_asn_features_21 = 21,	// ParameterizedObjectSetAssignment-token ParameterizedObjectSetAssignment

			g_asn_features_22 = 22,	// DefaultSyntax-token DefaultSyntax

			g_asn_features_23 = 23,	// TypeFieldSpec-token TypeFieldSpec

			g_asn_features_24 = 24,	// FixedTypeValueFieldSpec-token FixedTypeValueFieldSpec

			g_asn_features_25 = 25,	// VariableTypeValueFieldSpec-token VariableTypeValueFieldSpec

			g_asn_features_26 = 26,	// FixedTypeValueSetFieldSpec-token FixedTypeValueSetFieldSpec

			g_asn_features_27 = 27,	// VariableTypeValueSetFieldSpec-token VariableTypeValueSetFieldSpec

			g_asn_features_28 = 28,	// ObjectFieldSpec-token ObjectFieldSpec

			g_asn_features_29 = 29,	// ObjectSetFieldSpec-token ObjectSetFieldSpec

			g_asn_features_30 = 30,	// DefinedType-token DefinedType

			g_asn_features_31 = 31,	// DefinedValue-token DefinedValue

			g_asn_features_32 = 32,	// ObjectClass-token ObjectClass

			g_asn_features_33 = 33,	// ObjectSetElements-token ObjectSetElements

			g_asn_features_34 = 34,	// Object-token Object

			g_asn_features_35 = 35,	// ObjectSet-token ObjectSet

			g_asn_features_36 = 36,	// ReferencedValue-token ReferencedValue

			g_asn_features_37 = 37,	// Type-token Type

			g_asn_features_38 = 38,	// Value-token Value

			g_asn_features_39 = 39,	// ValueSet-token ValueSet

			g_asn_features_40 = 40,	// BitStringValue-token BitStringValue

			g_asn_features_41 = 41,	// BooleanValue-token BooleanValue

			g_asn_features_42 = 42,	// CharacterStringValue-token CharacterStringValue

			g_asn_features_43 = 43,	// ChoiceValue-token ChoiceValue

			g_asn_features_44 = 44,	// EmbeddedPDVValue-token EmbeddedPDVValue

			g_asn_features_45 = 45,	// EnumeratedValue-token EnumeratedValue

			g_asn_features_46 = 46,	// ExternalValue-token ExternalValue

			g_asn_features_47 = 47,	// IntegerValue-token IntegerValue

			g_asn_features_48 = 48,	// IRIValue-token IRIValue

			g_asn_features_49 = 49,	// NullValue-token NullValue

			g_asn_features_50 = 50,	// ObjectIdentifierValue-token ObjectIdentifierValue

			g_asn_features_51 = 51,	// OctetStringValue-token OctetStringValue

			g_asn_features_52 = 52,	// RealValue-token RealValue

			g_asn_features_53 = 53,	// RelativeIRIValue-token RelativeIRIValue

			g_asn_features_54 = 54,	// RelativeOIDValue-token RelativeOIDValue

			g_asn_features_55 = 55,	// SequenceValue-token SequenceValue

			g_asn_features_56 = 56,	// SequenceOfValue-token SequenceOfValue

			g_asn_features_57 = 57,	// SetValue-token SetValue

			g_asn_features_58 = 58,	// SetOfValue-token SetOfValue

			g_asn_features_59 = 59,	// TimeValue-token TimeValue

			g_asn_features_60 = 60,	// SubtypeElements-token SubtypeElements

		};
		#endregion
		#region production markers associated with the syntax rule asn-features

		// markers associated with production: asn-features -> ModuleDefinitions-token ModuleDefinitions

		public enum production_marker_1 : ushort
		{
			m_ModuleDefinitions,
			final
		};

		// markers associated with production: asn-features -> ParameterizedType-token ParameterizedType

		public enum production_marker_2 : ushort
		{
			m_ParameterizedType,
			final
		};

		// markers associated with production: asn-features -> ParameterizedValue-token ParameterizedValue

		public enum production_marker_3 : ushort
		{
			m_ParameterizedValue,
			final
		};

		// markers associated with production: asn-features -> ParameterizedValueSetType-token ParameterizedValueSetType

		public enum production_marker_4 : ushort
		{
			m_ParameterizedValueSetType,
			final
		};

		// markers associated with production: asn-features -> ParameterizedObjectClass-token ParameterizedObjectClass

		public enum production_marker_5 : ushort
		{
			m_ParameterizedObjectClass,
			final
		};

		// markers associated with production: asn-features -> ParameterizedObjectSet-token ParameterizedObjectSet

		public enum production_marker_6 : ushort
		{
			m_ParameterizedObjectSet,
			final
		};

		// markers associated with production: asn-features -> ParameterizedObject-token ParameterizedObject

		public enum production_marker_7 : ushort
		{
			m_ParameterizedObject,
			final
		};

		// markers associated with production: asn-features -> AssignmentList-token AssignmentList

		public enum production_marker_8 : ushort
		{
			m_AssignmentList,
			final
		};

		// markers associated with production: asn-features -> BuiltinValue-token BuiltinValue

		public enum production_marker_9 : ushort
		{
			m_BuiltinValue,
			final
		};

		// markers associated with production: asn-features -> TypeAssignment-token TypeAssignment

		public enum production_marker_10 : ushort
		{
			m_TypeAssignment,
			final
		};

		// markers associated with production: asn-features -> ValueAssignment-token ValueAssignment

		public enum production_marker_11 : ushort
		{
			m_ValueAssignment,
			final
		};

		// markers associated with production: asn-features -> ValueSetTypeAssignment-token ValueSetTypeAssignment

		public enum production_marker_12 : ushort
		{
			m_ValueSetTypeAssignment,
			final
		};

		// markers associated with production: asn-features -> ObjectClassAssignment-token ObjectClassAssignment

		public enum production_marker_13 : ushort
		{
			m_ObjectClassAssignment,
			final
		};

		// markers associated with production: asn-features -> ObjectAssignment-token ObjectAssignment

		public enum production_marker_14 : ushort
		{
			m_ObjectAssignment,
			final
		};

		// markers associated with production: asn-features -> ObjectSetAssignment-token ObjectSetAssignment

		public enum production_marker_15 : ushort
		{
			m_ObjectSetAssignment,
			final
		};

		// markers associated with production: asn-features -> ParameterizedTypeAssignment-token ParameterizedTypeAssignment

		public enum production_marker_16 : ushort
		{
			m_ParameterizedTypeAssignment,
			final
		};

		// markers associated with production: asn-features -> ParameterizedValueAssignment-token ParameterizedValueAssignment

		public enum production_marker_17 : ushort
		{
			m_ParameterizedValueAssignment,
			final
		};

		// markers associated with production: asn-features -> ParameterizedValueSetTypeAssignment-token ParameterizedValueSetTypeAssignment

		public enum production_marker_18 : ushort
		{
			m_ParameterizedValueSetTypeAssignment,
			final
		};

		// markers associated with production: asn-features -> ParameterizedObjectClassAssignment-token ParameterizedObjectClassAssignment

		public enum production_marker_19 : ushort
		{
			m_ParameterizedObjectClassAssignment,
			final
		};

		// markers associated with production: asn-features -> ParameterizedObjectAssignment-token ParameterizedObjectAssignment

		public enum production_marker_20 : ushort
		{
			m_ParameterizedObjectAssignment,
			final
		};

		// markers associated with production: asn-features -> ParameterizedObjectSetAssignment-token ParameterizedObjectSetAssignment

		public enum production_marker_21 : ushort
		{
			m_ParameterizedObjectSetAssignment,
			final
		};

		// markers associated with production: asn-features -> DefaultSyntax-token DefaultSyntax

		public enum production_marker_22 : ushort
		{
			m_DefaultSyntax,
			final
		};

		// markers associated with production: asn-features -> TypeFieldSpec-token TypeFieldSpec

		public enum production_marker_23 : ushort
		{
			m_TypeFieldSpec,
			final
		};

		// markers associated with production: asn-features -> FixedTypeValueFieldSpec-token FixedTypeValueFieldSpec

		public enum production_marker_24 : ushort
		{
			m_FixedTypeValueFieldSpec,
			final
		};

		// markers associated with production: asn-features -> VariableTypeValueFieldSpec-token VariableTypeValueFieldSpec

		public enum production_marker_25 : ushort
		{
			m_VariableTypeValueFieldSpec,
			final
		};

		// markers associated with production: asn-features -> FixedTypeValueSetFieldSpec-token FixedTypeValueSetFieldSpec

		public enum production_marker_26 : ushort
		{
			m_FixedTypeValueSetFieldSpec,
			final
		};

		// markers associated with production: asn-features -> VariableTypeValueSetFieldSpec-token VariableTypeValueSetFieldSpec

		public enum production_marker_27 : ushort
		{
			m_VariableTypeValueSetFieldSpec,
			final
		};

		// markers associated with production: asn-features -> ObjectFieldSpec-token ObjectFieldSpec

		public enum production_marker_28 : ushort
		{
			m_ObjectFieldSpec,
			final
		};

		// markers associated with production: asn-features -> ObjectSetFieldSpec-token ObjectSetFieldSpec

		public enum production_marker_29 : ushort
		{
			m_ObjectSetFieldSpec,
			final
		};

		// markers associated with production: asn-features -> DefinedType-token DefinedType

		public enum production_marker_30 : ushort
		{
			m_DefinedType,
			final
		};

		// markers associated with production: asn-features -> DefinedValue-token DefinedValue

		public enum production_marker_31 : ushort
		{
			m_DefinedValue,
			final
		};

		// markers associated with production: asn-features -> ObjectClass-token ObjectClass

		public enum production_marker_32 : ushort
		{
			m_ObjectClass,
			final
		};

		// markers associated with production: asn-features -> ObjectSetElements-token ObjectSetElements

		public enum production_marker_33 : ushort
		{
			m_ObjectSetElements,
			final
		};

		// markers associated with production: asn-features -> Object-token Object

		public enum production_marker_34 : ushort
		{
			m_Object,
			final
		};

		// markers associated with production: asn-features -> ObjectSet-token ObjectSet

		public enum production_marker_35 : ushort
		{
			m_ObjectSet,
			final
		};

		// markers associated with production: asn-features -> ReferencedValue-token ReferencedValue

		public enum production_marker_36 : ushort
		{
			m_ReferencedValue,
			final
		};

		// markers associated with production: asn-features -> Type-token Type

		public enum production_marker_37 : ushort
		{
			m_Type,
			final
		};

		// markers associated with production: asn-features -> Value-token Value

		public enum production_marker_38 : ushort
		{
			m_Value,
			final
		};

		// markers associated with production: asn-features -> ValueSet-token ValueSet

		public enum production_marker_39 : ushort
		{
			m_ValueSet,
			final
		};

		// markers associated with production: asn-features -> BitStringValue-token BitStringValue

		public enum production_marker_40 : ushort
		{
			m_BitStringValue,
			final
		};

		// markers associated with production: asn-features -> BooleanValue-token BooleanValue

		public enum production_marker_41 : ushort
		{
			m_BooleanValue,
			final
		};

		// markers associated with production: asn-features -> CharacterStringValue-token CharacterStringValue

		public enum production_marker_42 : ushort
		{
			m_CharacterStringValue,
			final
		};

		// markers associated with production: asn-features -> ChoiceValue-token ChoiceValue

		public enum production_marker_43 : ushort
		{
			m_ChoiceValue,
			final
		};

		// markers associated with production: asn-features -> EmbeddedPDVValue-token EmbeddedPDVValue

		public enum production_marker_44 : ushort
		{
			m_EmbeddedPDVValue,
			final
		};

		// markers associated with production: asn-features -> EnumeratedValue-token EnumeratedValue

		public enum production_marker_45 : ushort
		{
			m_EnumeratedValue,
			final
		};

		// markers associated with production: asn-features -> ExternalValue-token ExternalValue

		public enum production_marker_46 : ushort
		{
			m_ExternalValue,
			final
		};

		// markers associated with production: asn-features -> IntegerValue-token IntegerValue

		public enum production_marker_47 : ushort
		{
			m_IntegerValue,
			final
		};

		// markers associated with production: asn-features -> IRIValue-token IRIValue

		public enum production_marker_48 : ushort
		{
			m_IRIValue,
			final
		};

		// markers associated with production: asn-features -> NullValue-token NullValue

		public enum production_marker_49 : ushort
		{
			m_NullValue,
			final
		};

		// markers associated with production: asn-features -> ObjectIdentifierValue-token ObjectIdentifierValue

		public enum production_marker_50 : ushort
		{
			m_ObjectIdentifierValue,
			final
		};

		// markers associated with production: asn-features -> OctetStringValue-token OctetStringValue

		public enum production_marker_51 : ushort
		{
			m_OctetStringValue,
			final
		};

		// markers associated with production: asn-features -> RealValue-token RealValue

		public enum production_marker_52 : ushort
		{
			m_RealValue,
			final
		};

		// markers associated with production: asn-features -> RelativeIRIValue-token RelativeIRIValue

		public enum production_marker_53 : ushort
		{
			m_RelativeIRIValue,
			final
		};

		// markers associated with production: asn-features -> RelativeOIDValue-token RelativeOIDValue

		public enum production_marker_54 : ushort
		{
			m_RelativeOIDValue,
			final
		};

		// markers associated with production: asn-features -> SequenceValue-token SequenceValue

		public enum production_marker_55 : ushort
		{
			m_SequenceValue,
			final
		};

		// markers associated with production: asn-features -> SequenceOfValue-token SequenceOfValue

		public enum production_marker_56 : ushort
		{
			m_SequenceOfValue,
			final
		};

		// markers associated with production: asn-features -> SetValue-token SetValue

		public enum production_marker_57 : ushort
		{
			m_SetValue,
			final
		};

		// markers associated with production: asn-features -> SetOfValue-token SetOfValue

		public enum production_marker_58 : ushort
		{
			m_SetOfValue,
			final
		};

		// markers associated with production: asn-features -> TimeValue-token TimeValue

		public enum production_marker_59 : ushort
		{
			m_TimeValue,
			final
		};

		// markers associated with production: asn-features -> SubtypeElements-token SubtypeElements

		public enum production_marker_60 : ushort
		{
			m_SubtypeElements,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule asn-features

		// Constructor declaration(s) associated with production(s) of syntax rule asn-features

		//
		// Constructor associated with the following production(s)
		// asn-features -> ModuleDefinitions-token ModuleDefinitions

		//

		public asn_features (SyntaxTreeToken p_token, ModuleDefinitions p_ModuleDefinitions) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ModuleDefinitions_token = p_token;
			children[1] = m_ModuleDefinitions = p_ModuleDefinitions;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ParameterizedType-token ParameterizedType

		//

		public asn_features (SyntaxTreeToken p_token, ParameterizedType p_ParameterizedType) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ParameterizedType_token = p_token;
			children[1] = m_ParameterizedType = p_ParameterizedType;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ParameterizedValue-token ParameterizedValue

		//

		public asn_features (SyntaxTreeToken p_token, ParameterizedValue p_ParameterizedValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ParameterizedValue_token = p_token;
			children[1] = m_ParameterizedValue = p_ParameterizedValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ParameterizedValueSetType-token ParameterizedValueSetType

		//

		public asn_features (SyntaxTreeToken p_token, ParameterizedValueSetType p_ParameterizedValueSetType) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ParameterizedValueSetType_token = p_token;
			children[1] = m_ParameterizedValueSetType = p_ParameterizedValueSetType;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ParameterizedObjectClass-token ParameterizedObjectClass

		//

		public asn_features (SyntaxTreeToken p_token, ParameterizedObjectClass p_ParameterizedObjectClass) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_5)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ParameterizedObjectClass_token = p_token;
			children[1] = m_ParameterizedObjectClass = p_ParameterizedObjectClass;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ParameterizedObjectSet-token ParameterizedObjectSet

		//

		public asn_features (SyntaxTreeToken p_token, ParameterizedObjectSet p_ParameterizedObjectSet) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_6)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ParameterizedObjectSet_token = p_token;
			children[1] = m_ParameterizedObjectSet = p_ParameterizedObjectSet;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ParameterizedObject-token ParameterizedObject

		//

		public asn_features (SyntaxTreeToken p_token, ParameterizedObject p_ParameterizedObject) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_7)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ParameterizedObject_token = p_token;
			children[1] = m_ParameterizedObject = p_ParameterizedObject;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> AssignmentList-token AssignmentList

		//

		public asn_features (SyntaxTreeToken p_token, AssignmentList p_AssignmentList) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_8)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_AssignmentList_token = p_token;
			children[1] = m_AssignmentList = p_AssignmentList;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> BuiltinValue-token BuiltinValue

		//

		public asn_features (SyntaxTreeToken p_token, BuiltinValue p_BuiltinValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_9)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_BuiltinValue_token = p_token;
			children[1] = m_BuiltinValue = p_BuiltinValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> TypeAssignment-token TypeAssignment

		//

		public asn_features (SyntaxTreeToken p_token, TypeAssignment p_TypeAssignment) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_10)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_TypeAssignment_token = p_token;
			children[1] = m_TypeAssignment = p_TypeAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ValueAssignment-token ValueAssignment

		//

		public asn_features (SyntaxTreeToken p_token, ValueAssignment p_ValueAssignment) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_11)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ValueAssignment_token = p_token;
			children[1] = m_ValueAssignment = p_ValueAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ValueSetTypeAssignment-token ValueSetTypeAssignment

		//

		public asn_features (SyntaxTreeToken p_token, ValueSetTypeAssignment p_ValueSetTypeAssignment) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_12)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ValueSetTypeAssignment_token = p_token;
			children[1] = m_ValueSetTypeAssignment = p_ValueSetTypeAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ObjectClassAssignment-token ObjectClassAssignment

		//

		public asn_features (SyntaxTreeToken p_token, ObjectClassAssignment p_ObjectClassAssignment) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_13)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ObjectClassAssignment_token = p_token;
			children[1] = m_ObjectClassAssignment = p_ObjectClassAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ObjectAssignment-token ObjectAssignment

		//

		public asn_features (SyntaxTreeToken p_token, ObjectAssignment p_ObjectAssignment) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_14)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ObjectAssignment_token = p_token;
			children[1] = m_ObjectAssignment = p_ObjectAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ObjectSetAssignment-token ObjectSetAssignment

		//

		public asn_features (SyntaxTreeToken p_token, ObjectSetAssignment p_ObjectSetAssignment) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_15)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ObjectSetAssignment_token = p_token;
			children[1] = m_ObjectSetAssignment = p_ObjectSetAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ParameterizedTypeAssignment-token ParameterizedTypeAssignment

		//

		public asn_features (SyntaxTreeToken p_token, ParameterizedTypeAssignment p_ParameterizedTypeAssignment) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_16)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ParameterizedTypeAssignment_token = p_token;
			children[1] = m_ParameterizedTypeAssignment = p_ParameterizedTypeAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ParameterizedValueAssignment-token ParameterizedValueAssignment

		//

		public asn_features (SyntaxTreeToken p_token, ParameterizedValueAssignment p_ParameterizedValueAssignment) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_17)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ParameterizedValueAssignment_token = p_token;
			children[1] = m_ParameterizedValueAssignment = p_ParameterizedValueAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ParameterizedValueSetTypeAssignment-token ParameterizedValueSetTypeAssignment

		//

		public asn_features (SyntaxTreeToken p_token, ParameterizedValueSetTypeAssignment p_ParameterizedValueSetTypeAssignment) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_18)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ParameterizedValueSetTypeAssignment_token = p_token;
			children[1] = m_ParameterizedValueSetTypeAssignment = p_ParameterizedValueSetTypeAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ParameterizedObjectClassAssignment-token ParameterizedObjectClassAssignment

		//

		public asn_features (SyntaxTreeToken p_token, ParameterizedObjectClassAssignment p_ParameterizedObjectClassAssignment) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_19)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ParameterizedObjectClassAssignment_token = p_token;
			children[1] = m_ParameterizedObjectClassAssignment = p_ParameterizedObjectClassAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ParameterizedObjectAssignment-token ParameterizedObjectAssignment

		//

		public asn_features (SyntaxTreeToken p_token, ParameterizedObjectAssignment p_ParameterizedObjectAssignment) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_20)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ParameterizedObjectAssignment_token = p_token;
			children[1] = m_ParameterizedObjectAssignment = p_ParameterizedObjectAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ParameterizedObjectSetAssignment-token ParameterizedObjectSetAssignment

		//

		public asn_features (SyntaxTreeToken p_token, ParameterizedObjectSetAssignment p_ParameterizedObjectSetAssignment) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_21)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ParameterizedObjectSetAssignment_token = p_token;
			children[1] = m_ParameterizedObjectSetAssignment = p_ParameterizedObjectSetAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> DefaultSyntax-token DefaultSyntax

		//

		public asn_features (SyntaxTreeToken p_token, DefaultSyntax p_DefaultSyntax) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_22)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_DefaultSyntax_token = p_token;
			children[1] = m_DefaultSyntax = p_DefaultSyntax;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> TypeFieldSpec-token TypeFieldSpec

		//

		public asn_features (SyntaxTreeToken p_token, TypeFieldSpec p_TypeFieldSpec) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_23)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_TypeFieldSpec_token = p_token;
			children[1] = m_TypeFieldSpec = p_TypeFieldSpec;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> FixedTypeValueFieldSpec-token FixedTypeValueFieldSpec

		//

		public asn_features (SyntaxTreeToken p_token, FixedTypeValueFieldSpec p_FixedTypeValueFieldSpec) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_24)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_FixedTypeValueFieldSpec_token = p_token;
			children[1] = m_FixedTypeValueFieldSpec = p_FixedTypeValueFieldSpec;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> VariableTypeValueFieldSpec-token VariableTypeValueFieldSpec

		//

		public asn_features (SyntaxTreeToken p_token, VariableTypeValueFieldSpec p_VariableTypeValueFieldSpec) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_25)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_VariableTypeValueFieldSpec_token = p_token;
			children[1] = m_VariableTypeValueFieldSpec = p_VariableTypeValueFieldSpec;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> FixedTypeValueSetFieldSpec-token FixedTypeValueSetFieldSpec

		//

		public asn_features (SyntaxTreeToken p_token, FixedTypeValueSetFieldSpec p_FixedTypeValueSetFieldSpec) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_26)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_FixedTypeValueSetFieldSpec_token = p_token;
			children[1] = m_FixedTypeValueSetFieldSpec = p_FixedTypeValueSetFieldSpec;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> VariableTypeValueSetFieldSpec-token VariableTypeValueSetFieldSpec

		//

		public asn_features (SyntaxTreeToken p_token, VariableTypeValueSetFieldSpec p_VariableTypeValueSetFieldSpec) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_27)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_VariableTypeValueSetFieldSpec_token = p_token;
			children[1] = m_VariableTypeValueSetFieldSpec = p_VariableTypeValueSetFieldSpec;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ObjectFieldSpec-token ObjectFieldSpec

		//

		public asn_features (SyntaxTreeToken p_token, ObjectFieldSpec p_ObjectFieldSpec) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_28)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ObjectFieldSpec_token = p_token;
			children[1] = m_ObjectFieldSpec = p_ObjectFieldSpec;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ObjectSetFieldSpec-token ObjectSetFieldSpec

		//

		public asn_features (SyntaxTreeToken p_token, ObjectSetFieldSpec p_ObjectSetFieldSpec) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_29)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ObjectSetFieldSpec_token = p_token;
			children[1] = m_ObjectSetFieldSpec = p_ObjectSetFieldSpec;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> DefinedType-token DefinedType

		//

		public asn_features (SyntaxTreeToken p_token, DefinedType p_DefinedType) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_30)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_DefinedType_token = p_token;
			children[1] = m_DefinedType = p_DefinedType;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> DefinedValue-token DefinedValue

		//

		public asn_features (SyntaxTreeToken p_token, DefinedValue p_DefinedValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_31)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_DefinedValue_token = p_token;
			children[1] = m_DefinedValue = p_DefinedValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ObjectClass-token ObjectClass

		//

		public asn_features (SyntaxTreeToken p_token, ObjectClass p_ObjectClass) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_32)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ObjectClass_token = p_token;
			children[1] = m_ObjectClass = p_ObjectClass;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ObjectSetElements-token ObjectSetElements

		//

		public asn_features (SyntaxTreeToken p_token, ObjectSetElements p_ObjectSetElements) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_33)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ObjectSetElements_token = p_token;
			children[1] = m_ObjectSetElements = p_ObjectSetElements;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> Object-token Object

		//

		public asn_features (SyntaxTreeToken p_token, Object p_Object) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_34)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_Object_token = p_token;
			children[1] = m_Object = p_Object;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ObjectSet-token ObjectSet

		//

		public asn_features (SyntaxTreeToken p_token, ObjectSet p_ObjectSet) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_35)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ObjectSet_token = p_token;
			children[1] = m_ObjectSet = p_ObjectSet;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ReferencedValue-token ReferencedValue

		//

		public asn_features (SyntaxTreeToken p_token, ReferencedValue p_ReferencedValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_36)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ReferencedValue_token = p_token;
			children[1] = m_ReferencedValue = p_ReferencedValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> Type-token Type

		//

		public asn_features (SyntaxTreeToken p_token, Type p_Type) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_37)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_Type_token = p_token;
			children[1] = m_Type = p_Type;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> Value-token Value

		//

		public asn_features (SyntaxTreeToken p_token, Value p_Value) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_38)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_Value_token = p_token;
			children[1] = m_Value = p_Value;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ValueSet-token ValueSet

		//

		public asn_features (SyntaxTreeToken p_token, ValueSet p_ValueSet) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_39)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ValueSet_token = p_token;
			children[1] = m_ValueSet = p_ValueSet;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> BitStringValue-token BitStringValue

		//

		public asn_features (SyntaxTreeToken p_token, BitStringValue p_BitStringValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_40)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_BitStringValue_token = p_token;
			children[1] = m_BitStringValue = p_BitStringValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> BooleanValue-token BooleanValue

		//

		public asn_features (SyntaxTreeToken p_token, BooleanValue p_BooleanValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_41)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_BooleanValue_token = p_token;
			children[1] = m_BooleanValue = p_BooleanValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> CharacterStringValue-token CharacterStringValue

		//

		public asn_features (SyntaxTreeToken p_token, CharacterStringValue p_CharacterStringValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_42)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_CharacterStringValue_token = p_token;
			children[1] = m_CharacterStringValue = p_CharacterStringValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ChoiceValue-token ChoiceValue

		//

		public asn_features (SyntaxTreeToken p_token, ChoiceValue p_ChoiceValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_43)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ChoiceValue_token = p_token;
			children[1] = m_ChoiceValue = p_ChoiceValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> EmbeddedPDVValue-token EmbeddedPDVValue

		//

		public asn_features (SyntaxTreeToken p_token, EmbeddedPDVValue p_EmbeddedPDVValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_44)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_EmbeddedPDVValue_token = p_token;
			children[1] = m_EmbeddedPDVValue = p_EmbeddedPDVValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> EnumeratedValue-token EnumeratedValue

		//

		public asn_features (SyntaxTreeToken p_token, EnumeratedValue p_EnumeratedValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_45)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_EnumeratedValue_token = p_token;
			children[1] = m_EnumeratedValue = p_EnumeratedValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ExternalValue-token ExternalValue

		//

		public asn_features (SyntaxTreeToken p_token, ExternalValue p_ExternalValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_46)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ExternalValue_token = p_token;
			children[1] = m_ExternalValue = p_ExternalValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> IntegerValue-token IntegerValue

		//

		public asn_features (SyntaxTreeToken p_token, IntegerValue p_IntegerValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_47)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_IntegerValue_token = p_token;
			children[1] = m_IntegerValue = p_IntegerValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> IRIValue-token IRIValue

		//

		public asn_features (SyntaxTreeToken p_token, IRIValue p_IRIValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_48)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_IRIValue_token = p_token;
			children[1] = m_IRIValue = p_IRIValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> NullValue-token NullValue

		//

		public asn_features (SyntaxTreeToken p_token, NullValue p_NullValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_49)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_NullValue_token = p_token;
			children[1] = m_NullValue = p_NullValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> ObjectIdentifierValue-token ObjectIdentifierValue

		//

		public asn_features (SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_50)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ObjectIdentifierValue_token = p_token;
			children[1] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> OctetStringValue-token OctetStringValue

		//

		public asn_features (SyntaxTreeToken p_token, OctetStringValue p_OctetStringValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_51)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_OctetStringValue_token = p_token;
			children[1] = m_OctetStringValue = p_OctetStringValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> RealValue-token RealValue

		//

		public asn_features (SyntaxTreeToken p_token, RealValue p_RealValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_52)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_RealValue_token = p_token;
			children[1] = m_RealValue = p_RealValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> RelativeIRIValue-token RelativeIRIValue

		//

		public asn_features (SyntaxTreeToken p_token, RelativeIRIValue p_RelativeIRIValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_53)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_RelativeIRIValue_token = p_token;
			children[1] = m_RelativeIRIValue = p_RelativeIRIValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> RelativeOIDValue-token RelativeOIDValue

		//

		public asn_features (SyntaxTreeToken p_token, RelativeOIDValue p_RelativeOIDValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_54)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_RelativeOIDValue_token = p_token;
			children[1] = m_RelativeOIDValue = p_RelativeOIDValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> SequenceValue-token SequenceValue

		//

		public asn_features (SyntaxTreeToken p_token, SequenceValue p_SequenceValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_55)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_SequenceValue_token = p_token;
			children[1] = m_SequenceValue = p_SequenceValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> SequenceOfValue-token SequenceOfValue

		//

		public asn_features (SyntaxTreeToken p_token, SequenceOfValue p_SequenceOfValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_56)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_SequenceOfValue_token = p_token;
			children[1] = m_SequenceOfValue = p_SequenceOfValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> SetValue-token SetValue

		//

		public asn_features (SyntaxTreeToken p_token, SetValue p_SetValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_57)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_SetValue_token = p_token;
			children[1] = m_SetValue = p_SetValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> SetOfValue-token SetOfValue

		//

		public asn_features (SyntaxTreeToken p_token, SetOfValue p_SetOfValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_58)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_SetOfValue_token = p_token;
			children[1] = m_SetOfValue = p_SetOfValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> TimeValue-token TimeValue

		//

		public asn_features (SyntaxTreeToken p_token, TimeValue p_TimeValue) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_59)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_TimeValue_token = p_token;
			children[1] = m_TimeValue = p_TimeValue;
		}

		//
		// Constructor associated with the following production(s)
		// asn-features -> SubtypeElements-token SubtypeElements

		//

		public asn_features (SyntaxTreeToken p_token, SubtypeElements p_SubtypeElements) : base ((uint) ProductionID._asn_features_ID, (uint) production_kind.g_asn_features_60)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_SubtypeElements_token = p_token;
			children[1] = m_SubtypeElements = p_SubtypeElements;
		}

		public asn_features () { }

		// Copy constructor

		public asn_features (asn_features p_asn_features) : base (p_asn_features.id, p_asn_features.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_asn_features.appInfo;
			switch ((production_kind) p_asn_features.kind)
			{
				case production_kind.g_asn_features_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ModuleDefinitions_token = (p_asn_features.m_ModuleDefinitions_token != null) ? new SyntaxTreeToken (p_asn_features.m_ModuleDefinitions_token) : null) != null) m_ModuleDefinitions_token.parent = this;
					if ((children [1] = m_ModuleDefinitions = (p_asn_features.m_ModuleDefinitions != null) ? new ModuleDefinitions (p_asn_features.m_ModuleDefinitions) : null) != null) m_ModuleDefinitions.parent = this;
					break;
				case production_kind.g_asn_features_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ParameterizedType_token = (p_asn_features.m_ParameterizedType_token != null) ? new SyntaxTreeToken (p_asn_features.m_ParameterizedType_token) : null) != null) m_ParameterizedType_token.parent = this;
					if ((children [1] = m_ParameterizedType = (p_asn_features.m_ParameterizedType != null) ? new ParameterizedType (p_asn_features.m_ParameterizedType) : null) != null) m_ParameterizedType.parent = this;
					break;
				case production_kind.g_asn_features_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ParameterizedValue_token = (p_asn_features.m_ParameterizedValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_ParameterizedValue_token) : null) != null) m_ParameterizedValue_token.parent = this;
					if ((children [1] = m_ParameterizedValue = (p_asn_features.m_ParameterizedValue != null) ? new ParameterizedValue (p_asn_features.m_ParameterizedValue) : null) != null) m_ParameterizedValue.parent = this;
					break;
				case production_kind.g_asn_features_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ParameterizedValueSetType_token = (p_asn_features.m_ParameterizedValueSetType_token != null) ? new SyntaxTreeToken (p_asn_features.m_ParameterizedValueSetType_token) : null) != null) m_ParameterizedValueSetType_token.parent = this;
					if ((children [1] = m_ParameterizedValueSetType = (p_asn_features.m_ParameterizedValueSetType != null) ? new ParameterizedValueSetType (p_asn_features.m_ParameterizedValueSetType) : null) != null) m_ParameterizedValueSetType.parent = this;
					break;
				case production_kind.g_asn_features_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ParameterizedObjectClass_token = (p_asn_features.m_ParameterizedObjectClass_token != null) ? new SyntaxTreeToken (p_asn_features.m_ParameterizedObjectClass_token) : null) != null) m_ParameterizedObjectClass_token.parent = this;
					if ((children [1] = m_ParameterizedObjectClass = (p_asn_features.m_ParameterizedObjectClass != null) ? new ParameterizedObjectClass (p_asn_features.m_ParameterizedObjectClass) : null) != null) m_ParameterizedObjectClass.parent = this;
					break;
				case production_kind.g_asn_features_6:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ParameterizedObjectSet_token = (p_asn_features.m_ParameterizedObjectSet_token != null) ? new SyntaxTreeToken (p_asn_features.m_ParameterizedObjectSet_token) : null) != null) m_ParameterizedObjectSet_token.parent = this;
					if ((children [1] = m_ParameterizedObjectSet = (p_asn_features.m_ParameterizedObjectSet != null) ? new ParameterizedObjectSet (p_asn_features.m_ParameterizedObjectSet) : null) != null) m_ParameterizedObjectSet.parent = this;
					break;
				case production_kind.g_asn_features_7:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ParameterizedObject_token = (p_asn_features.m_ParameterizedObject_token != null) ? new SyntaxTreeToken (p_asn_features.m_ParameterizedObject_token) : null) != null) m_ParameterizedObject_token.parent = this;
					if ((children [1] = m_ParameterizedObject = (p_asn_features.m_ParameterizedObject != null) ? new ParameterizedObject (p_asn_features.m_ParameterizedObject) : null) != null) m_ParameterizedObject.parent = this;
					break;
				case production_kind.g_asn_features_8:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_AssignmentList_token = (p_asn_features.m_AssignmentList_token != null) ? new SyntaxTreeToken (p_asn_features.m_AssignmentList_token) : null) != null) m_AssignmentList_token.parent = this;
					if ((children [1] = m_AssignmentList = (p_asn_features.m_AssignmentList != null) ? new AssignmentList (p_asn_features.m_AssignmentList) : null) != null) m_AssignmentList.parent = this;
					break;
				case production_kind.g_asn_features_9:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_BuiltinValue_token = (p_asn_features.m_BuiltinValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_BuiltinValue_token) : null) != null) m_BuiltinValue_token.parent = this;
					if ((children [1] = m_BuiltinValue = (p_asn_features.m_BuiltinValue != null) ? new BuiltinValue (p_asn_features.m_BuiltinValue) : null) != null) m_BuiltinValue.parent = this;
					break;
				case production_kind.g_asn_features_10:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_TypeAssignment_token = (p_asn_features.m_TypeAssignment_token != null) ? new SyntaxTreeToken (p_asn_features.m_TypeAssignment_token) : null) != null) m_TypeAssignment_token.parent = this;
					if ((children [1] = m_TypeAssignment = (p_asn_features.m_TypeAssignment != null) ? new TypeAssignment (p_asn_features.m_TypeAssignment) : null) != null) m_TypeAssignment.parent = this;
					break;
				case production_kind.g_asn_features_11:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ValueAssignment_token = (p_asn_features.m_ValueAssignment_token != null) ? new SyntaxTreeToken (p_asn_features.m_ValueAssignment_token) : null) != null) m_ValueAssignment_token.parent = this;
					if ((children [1] = m_ValueAssignment = (p_asn_features.m_ValueAssignment != null) ? new ValueAssignment (p_asn_features.m_ValueAssignment) : null) != null) m_ValueAssignment.parent = this;
					break;
				case production_kind.g_asn_features_12:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ValueSetTypeAssignment_token = (p_asn_features.m_ValueSetTypeAssignment_token != null) ? new SyntaxTreeToken (p_asn_features.m_ValueSetTypeAssignment_token) : null) != null) m_ValueSetTypeAssignment_token.parent = this;
					if ((children [1] = m_ValueSetTypeAssignment = (p_asn_features.m_ValueSetTypeAssignment != null) ? new ValueSetTypeAssignment (p_asn_features.m_ValueSetTypeAssignment) : null) != null) m_ValueSetTypeAssignment.parent = this;
					break;
				case production_kind.g_asn_features_13:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ObjectClassAssignment_token = (p_asn_features.m_ObjectClassAssignment_token != null) ? new SyntaxTreeToken (p_asn_features.m_ObjectClassAssignment_token) : null) != null) m_ObjectClassAssignment_token.parent = this;
					if ((children [1] = m_ObjectClassAssignment = (p_asn_features.m_ObjectClassAssignment != null) ? new ObjectClassAssignment (p_asn_features.m_ObjectClassAssignment) : null) != null) m_ObjectClassAssignment.parent = this;
					break;
				case production_kind.g_asn_features_14:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ObjectAssignment_token = (p_asn_features.m_ObjectAssignment_token != null) ? new SyntaxTreeToken (p_asn_features.m_ObjectAssignment_token) : null) != null) m_ObjectAssignment_token.parent = this;
					if ((children [1] = m_ObjectAssignment = (p_asn_features.m_ObjectAssignment != null) ? new ObjectAssignment (p_asn_features.m_ObjectAssignment) : null) != null) m_ObjectAssignment.parent = this;
					break;
				case production_kind.g_asn_features_15:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ObjectSetAssignment_token = (p_asn_features.m_ObjectSetAssignment_token != null) ? new SyntaxTreeToken (p_asn_features.m_ObjectSetAssignment_token) : null) != null) m_ObjectSetAssignment_token.parent = this;
					if ((children [1] = m_ObjectSetAssignment = (p_asn_features.m_ObjectSetAssignment != null) ? new ObjectSetAssignment (p_asn_features.m_ObjectSetAssignment) : null) != null) m_ObjectSetAssignment.parent = this;
					break;
				case production_kind.g_asn_features_16:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ParameterizedTypeAssignment_token = (p_asn_features.m_ParameterizedTypeAssignment_token != null) ? new SyntaxTreeToken (p_asn_features.m_ParameterizedTypeAssignment_token) : null) != null) m_ParameterizedTypeAssignment_token.parent = this;
					if ((children [1] = m_ParameterizedTypeAssignment = (p_asn_features.m_ParameterizedTypeAssignment != null) ? new ParameterizedTypeAssignment (p_asn_features.m_ParameterizedTypeAssignment) : null) != null) m_ParameterizedTypeAssignment.parent = this;
					break;
				case production_kind.g_asn_features_17:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ParameterizedValueAssignment_token = (p_asn_features.m_ParameterizedValueAssignment_token != null) ? new SyntaxTreeToken (p_asn_features.m_ParameterizedValueAssignment_token) : null) != null) m_ParameterizedValueAssignment_token.parent = this;
					if ((children [1] = m_ParameterizedValueAssignment = (p_asn_features.m_ParameterizedValueAssignment != null) ? new ParameterizedValueAssignment (p_asn_features.m_ParameterizedValueAssignment) : null) != null) m_ParameterizedValueAssignment.parent = this;
					break;
				case production_kind.g_asn_features_18:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ParameterizedValueSetTypeAssignment_token = (p_asn_features.m_ParameterizedValueSetTypeAssignment_token != null) ? new SyntaxTreeToken (p_asn_features.m_ParameterizedValueSetTypeAssignment_token) : null) != null) m_ParameterizedValueSetTypeAssignment_token.parent = this;
					if ((children [1] = m_ParameterizedValueSetTypeAssignment = (p_asn_features.m_ParameterizedValueSetTypeAssignment != null) ? new ParameterizedValueSetTypeAssignment (p_asn_features.m_ParameterizedValueSetTypeAssignment) : null) != null) m_ParameterizedValueSetTypeAssignment.parent = this;
					break;
				case production_kind.g_asn_features_19:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ParameterizedObjectClassAssignment_token = (p_asn_features.m_ParameterizedObjectClassAssignment_token != null) ? new SyntaxTreeToken (p_asn_features.m_ParameterizedObjectClassAssignment_token) : null) != null) m_ParameterizedObjectClassAssignment_token.parent = this;
					if ((children [1] = m_ParameterizedObjectClassAssignment = (p_asn_features.m_ParameterizedObjectClassAssignment != null) ? new ParameterizedObjectClassAssignment (p_asn_features.m_ParameterizedObjectClassAssignment) : null) != null) m_ParameterizedObjectClassAssignment.parent = this;
					break;
				case production_kind.g_asn_features_20:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ParameterizedObjectAssignment_token = (p_asn_features.m_ParameterizedObjectAssignment_token != null) ? new SyntaxTreeToken (p_asn_features.m_ParameterizedObjectAssignment_token) : null) != null) m_ParameterizedObjectAssignment_token.parent = this;
					if ((children [1] = m_ParameterizedObjectAssignment = (p_asn_features.m_ParameterizedObjectAssignment != null) ? new ParameterizedObjectAssignment (p_asn_features.m_ParameterizedObjectAssignment) : null) != null) m_ParameterizedObjectAssignment.parent = this;
					break;
				case production_kind.g_asn_features_21:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ParameterizedObjectSetAssignment_token = (p_asn_features.m_ParameterizedObjectSetAssignment_token != null) ? new SyntaxTreeToken (p_asn_features.m_ParameterizedObjectSetAssignment_token) : null) != null) m_ParameterizedObjectSetAssignment_token.parent = this;
					if ((children [1] = m_ParameterizedObjectSetAssignment = (p_asn_features.m_ParameterizedObjectSetAssignment != null) ? new ParameterizedObjectSetAssignment (p_asn_features.m_ParameterizedObjectSetAssignment) : null) != null) m_ParameterizedObjectSetAssignment.parent = this;
					break;
				case production_kind.g_asn_features_22:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_DefaultSyntax_token = (p_asn_features.m_DefaultSyntax_token != null) ? new SyntaxTreeToken (p_asn_features.m_DefaultSyntax_token) : null) != null) m_DefaultSyntax_token.parent = this;
					if ((children [1] = m_DefaultSyntax = (p_asn_features.m_DefaultSyntax != null) ? new DefaultSyntax (p_asn_features.m_DefaultSyntax) : null) != null) m_DefaultSyntax.parent = this;
					break;
				case production_kind.g_asn_features_23:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_TypeFieldSpec_token = (p_asn_features.m_TypeFieldSpec_token != null) ? new SyntaxTreeToken (p_asn_features.m_TypeFieldSpec_token) : null) != null) m_TypeFieldSpec_token.parent = this;
					if ((children [1] = m_TypeFieldSpec = (p_asn_features.m_TypeFieldSpec != null) ? new TypeFieldSpec (p_asn_features.m_TypeFieldSpec) : null) != null) m_TypeFieldSpec.parent = this;
					break;
				case production_kind.g_asn_features_24:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_FixedTypeValueFieldSpec_token = (p_asn_features.m_FixedTypeValueFieldSpec_token != null) ? new SyntaxTreeToken (p_asn_features.m_FixedTypeValueFieldSpec_token) : null) != null) m_FixedTypeValueFieldSpec_token.parent = this;
					if ((children [1] = m_FixedTypeValueFieldSpec = (p_asn_features.m_FixedTypeValueFieldSpec != null) ? new FixedTypeValueFieldSpec (p_asn_features.m_FixedTypeValueFieldSpec) : null) != null) m_FixedTypeValueFieldSpec.parent = this;
					break;
				case production_kind.g_asn_features_25:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_VariableTypeValueFieldSpec_token = (p_asn_features.m_VariableTypeValueFieldSpec_token != null) ? new SyntaxTreeToken (p_asn_features.m_VariableTypeValueFieldSpec_token) : null) != null) m_VariableTypeValueFieldSpec_token.parent = this;
					if ((children [1] = m_VariableTypeValueFieldSpec = (p_asn_features.m_VariableTypeValueFieldSpec != null) ? new VariableTypeValueFieldSpec (p_asn_features.m_VariableTypeValueFieldSpec) : null) != null) m_VariableTypeValueFieldSpec.parent = this;
					break;
				case production_kind.g_asn_features_26:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_FixedTypeValueSetFieldSpec_token = (p_asn_features.m_FixedTypeValueSetFieldSpec_token != null) ? new SyntaxTreeToken (p_asn_features.m_FixedTypeValueSetFieldSpec_token) : null) != null) m_FixedTypeValueSetFieldSpec_token.parent = this;
					if ((children [1] = m_FixedTypeValueSetFieldSpec = (p_asn_features.m_FixedTypeValueSetFieldSpec != null) ? new FixedTypeValueSetFieldSpec (p_asn_features.m_FixedTypeValueSetFieldSpec) : null) != null) m_FixedTypeValueSetFieldSpec.parent = this;
					break;
				case production_kind.g_asn_features_27:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_VariableTypeValueSetFieldSpec_token = (p_asn_features.m_VariableTypeValueSetFieldSpec_token != null) ? new SyntaxTreeToken (p_asn_features.m_VariableTypeValueSetFieldSpec_token) : null) != null) m_VariableTypeValueSetFieldSpec_token.parent = this;
					if ((children [1] = m_VariableTypeValueSetFieldSpec = (p_asn_features.m_VariableTypeValueSetFieldSpec != null) ? new VariableTypeValueSetFieldSpec (p_asn_features.m_VariableTypeValueSetFieldSpec) : null) != null) m_VariableTypeValueSetFieldSpec.parent = this;
					break;
				case production_kind.g_asn_features_28:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ObjectFieldSpec_token = (p_asn_features.m_ObjectFieldSpec_token != null) ? new SyntaxTreeToken (p_asn_features.m_ObjectFieldSpec_token) : null) != null) m_ObjectFieldSpec_token.parent = this;
					if ((children [1] = m_ObjectFieldSpec = (p_asn_features.m_ObjectFieldSpec != null) ? new ObjectFieldSpec (p_asn_features.m_ObjectFieldSpec) : null) != null) m_ObjectFieldSpec.parent = this;
					break;
				case production_kind.g_asn_features_29:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ObjectSetFieldSpec_token = (p_asn_features.m_ObjectSetFieldSpec_token != null) ? new SyntaxTreeToken (p_asn_features.m_ObjectSetFieldSpec_token) : null) != null) m_ObjectSetFieldSpec_token.parent = this;
					if ((children [1] = m_ObjectSetFieldSpec = (p_asn_features.m_ObjectSetFieldSpec != null) ? new ObjectSetFieldSpec (p_asn_features.m_ObjectSetFieldSpec) : null) != null) m_ObjectSetFieldSpec.parent = this;
					break;
				case production_kind.g_asn_features_30:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_DefinedType_token = (p_asn_features.m_DefinedType_token != null) ? new SyntaxTreeToken (p_asn_features.m_DefinedType_token) : null) != null) m_DefinedType_token.parent = this;
					if ((children [1] = m_DefinedType = (p_asn_features.m_DefinedType != null) ? new DefinedType (p_asn_features.m_DefinedType) : null) != null) m_DefinedType.parent = this;
					break;
				case production_kind.g_asn_features_31:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_DefinedValue_token = (p_asn_features.m_DefinedValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_DefinedValue_token) : null) != null) m_DefinedValue_token.parent = this;
					if ((children [1] = m_DefinedValue = (p_asn_features.m_DefinedValue != null) ? new DefinedValue (p_asn_features.m_DefinedValue) : null) != null) m_DefinedValue.parent = this;
					break;
				case production_kind.g_asn_features_32:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ObjectClass_token = (p_asn_features.m_ObjectClass_token != null) ? new SyntaxTreeToken (p_asn_features.m_ObjectClass_token) : null) != null) m_ObjectClass_token.parent = this;
					if ((children [1] = m_ObjectClass = (p_asn_features.m_ObjectClass != null) ? new ObjectClass (p_asn_features.m_ObjectClass) : null) != null) m_ObjectClass.parent = this;
					break;
				case production_kind.g_asn_features_33:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ObjectSetElements_token = (p_asn_features.m_ObjectSetElements_token != null) ? new SyntaxTreeToken (p_asn_features.m_ObjectSetElements_token) : null) != null) m_ObjectSetElements_token.parent = this;
					if ((children [1] = m_ObjectSetElements = (p_asn_features.m_ObjectSetElements != null) ? new ObjectSetElements (p_asn_features.m_ObjectSetElements) : null) != null) m_ObjectSetElements.parent = this;
					break;
				case production_kind.g_asn_features_34:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_Object_token = (p_asn_features.m_Object_token != null) ? new SyntaxTreeToken (p_asn_features.m_Object_token) : null) != null) m_Object_token.parent = this;
					if ((children [1] = m_Object = (p_asn_features.m_Object != null) ? new Object (p_asn_features.m_Object) : null) != null) m_Object.parent = this;
					break;
				case production_kind.g_asn_features_35:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ObjectSet_token = (p_asn_features.m_ObjectSet_token != null) ? new SyntaxTreeToken (p_asn_features.m_ObjectSet_token) : null) != null) m_ObjectSet_token.parent = this;
					if ((children [1] = m_ObjectSet = (p_asn_features.m_ObjectSet != null) ? new ObjectSet (p_asn_features.m_ObjectSet) : null) != null) m_ObjectSet.parent = this;
					break;
				case production_kind.g_asn_features_36:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ReferencedValue_token = (p_asn_features.m_ReferencedValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_ReferencedValue_token) : null) != null) m_ReferencedValue_token.parent = this;
					if ((children [1] = m_ReferencedValue = (p_asn_features.m_ReferencedValue != null) ? new ReferencedValue (p_asn_features.m_ReferencedValue) : null) != null) m_ReferencedValue.parent = this;
					break;
				case production_kind.g_asn_features_37:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_Type_token = (p_asn_features.m_Type_token != null) ? new SyntaxTreeToken (p_asn_features.m_Type_token) : null) != null) m_Type_token.parent = this;
					if ((children [1] = m_Type = (p_asn_features.m_Type != null) ? new Type (p_asn_features.m_Type) : null) != null) m_Type.parent = this;
					break;
				case production_kind.g_asn_features_38:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_Value_token = (p_asn_features.m_Value_token != null) ? new SyntaxTreeToken (p_asn_features.m_Value_token) : null) != null) m_Value_token.parent = this;
					if ((children [1] = m_Value = (p_asn_features.m_Value != null) ? new Value (p_asn_features.m_Value) : null) != null) m_Value.parent = this;
					break;
				case production_kind.g_asn_features_39:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ValueSet_token = (p_asn_features.m_ValueSet_token != null) ? new SyntaxTreeToken (p_asn_features.m_ValueSet_token) : null) != null) m_ValueSet_token.parent = this;
					if ((children [1] = m_ValueSet = (p_asn_features.m_ValueSet != null) ? new ValueSet (p_asn_features.m_ValueSet) : null) != null) m_ValueSet.parent = this;
					break;
				case production_kind.g_asn_features_40:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_BitStringValue_token = (p_asn_features.m_BitStringValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_BitStringValue_token) : null) != null) m_BitStringValue_token.parent = this;
					if ((children [1] = m_BitStringValue = (p_asn_features.m_BitStringValue != null) ? new BitStringValue (p_asn_features.m_BitStringValue) : null) != null) m_BitStringValue.parent = this;
					break;
				case production_kind.g_asn_features_41:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_BooleanValue_token = (p_asn_features.m_BooleanValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_BooleanValue_token) : null) != null) m_BooleanValue_token.parent = this;
					if ((children [1] = m_BooleanValue = (p_asn_features.m_BooleanValue != null) ? new BooleanValue (p_asn_features.m_BooleanValue) : null) != null) m_BooleanValue.parent = this;
					break;
				case production_kind.g_asn_features_42:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_CharacterStringValue_token = (p_asn_features.m_CharacterStringValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_CharacterStringValue_token) : null) != null) m_CharacterStringValue_token.parent = this;
					if ((children [1] = m_CharacterStringValue = (p_asn_features.m_CharacterStringValue != null) ? new CharacterStringValue (p_asn_features.m_CharacterStringValue) : null) != null) m_CharacterStringValue.parent = this;
					break;
				case production_kind.g_asn_features_43:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ChoiceValue_token = (p_asn_features.m_ChoiceValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_ChoiceValue_token) : null) != null) m_ChoiceValue_token.parent = this;
					if ((children [1] = m_ChoiceValue = (p_asn_features.m_ChoiceValue != null) ? new ChoiceValue (p_asn_features.m_ChoiceValue) : null) != null) m_ChoiceValue.parent = this;
					break;
				case production_kind.g_asn_features_44:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_EmbeddedPDVValue_token = (p_asn_features.m_EmbeddedPDVValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_EmbeddedPDVValue_token) : null) != null) m_EmbeddedPDVValue_token.parent = this;
					if ((children [1] = m_EmbeddedPDVValue = (p_asn_features.m_EmbeddedPDVValue != null) ? new EmbeddedPDVValue (p_asn_features.m_EmbeddedPDVValue) : null) != null) m_EmbeddedPDVValue.parent = this;
					break;
				case production_kind.g_asn_features_45:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_EnumeratedValue_token = (p_asn_features.m_EnumeratedValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_EnumeratedValue_token) : null) != null) m_EnumeratedValue_token.parent = this;
					if ((children [1] = m_EnumeratedValue = (p_asn_features.m_EnumeratedValue != null) ? new EnumeratedValue (p_asn_features.m_EnumeratedValue) : null) != null) m_EnumeratedValue.parent = this;
					break;
				case production_kind.g_asn_features_46:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ExternalValue_token = (p_asn_features.m_ExternalValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_ExternalValue_token) : null) != null) m_ExternalValue_token.parent = this;
					if ((children [1] = m_ExternalValue = (p_asn_features.m_ExternalValue != null) ? new ExternalValue (p_asn_features.m_ExternalValue) : null) != null) m_ExternalValue.parent = this;
					break;
				case production_kind.g_asn_features_47:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_IntegerValue_token = (p_asn_features.m_IntegerValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_IntegerValue_token) : null) != null) m_IntegerValue_token.parent = this;
					if ((children [1] = m_IntegerValue = (p_asn_features.m_IntegerValue != null) ? new IntegerValue (p_asn_features.m_IntegerValue) : null) != null) m_IntegerValue.parent = this;
					break;
				case production_kind.g_asn_features_48:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_IRIValue_token = (p_asn_features.m_IRIValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_IRIValue_token) : null) != null) m_IRIValue_token.parent = this;
					if ((children [1] = m_IRIValue = (p_asn_features.m_IRIValue != null) ? new IRIValue (p_asn_features.m_IRIValue) : null) != null) m_IRIValue.parent = this;
					break;
				case production_kind.g_asn_features_49:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_NullValue_token = (p_asn_features.m_NullValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_NullValue_token) : null) != null) m_NullValue_token.parent = this;
					if ((children [1] = m_NullValue = (p_asn_features.m_NullValue != null) ? new NullValue (p_asn_features.m_NullValue) : null) != null) m_NullValue.parent = this;
					break;
				case production_kind.g_asn_features_50:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ObjectIdentifierValue_token = (p_asn_features.m_ObjectIdentifierValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_ObjectIdentifierValue_token) : null) != null) m_ObjectIdentifierValue_token.parent = this;
					if ((children [1] = m_ObjectIdentifierValue = (p_asn_features.m_ObjectIdentifierValue != null) ? new ObjectIdentifierValue (p_asn_features.m_ObjectIdentifierValue) : null) != null) m_ObjectIdentifierValue.parent = this;
					break;
				case production_kind.g_asn_features_51:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_OctetStringValue_token = (p_asn_features.m_OctetStringValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_OctetStringValue_token) : null) != null) m_OctetStringValue_token.parent = this;
					if ((children [1] = m_OctetStringValue = (p_asn_features.m_OctetStringValue != null) ? new OctetStringValue (p_asn_features.m_OctetStringValue) : null) != null) m_OctetStringValue.parent = this;
					break;
				case production_kind.g_asn_features_52:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_RealValue_token = (p_asn_features.m_RealValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_RealValue_token) : null) != null) m_RealValue_token.parent = this;
					if ((children [1] = m_RealValue = (p_asn_features.m_RealValue != null) ? new RealValue (p_asn_features.m_RealValue) : null) != null) m_RealValue.parent = this;
					break;
				case production_kind.g_asn_features_53:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_RelativeIRIValue_token = (p_asn_features.m_RelativeIRIValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_RelativeIRIValue_token) : null) != null) m_RelativeIRIValue_token.parent = this;
					if ((children [1] = m_RelativeIRIValue = (p_asn_features.m_RelativeIRIValue != null) ? new RelativeIRIValue (p_asn_features.m_RelativeIRIValue) : null) != null) m_RelativeIRIValue.parent = this;
					break;
				case production_kind.g_asn_features_54:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_RelativeOIDValue_token = (p_asn_features.m_RelativeOIDValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_RelativeOIDValue_token) : null) != null) m_RelativeOIDValue_token.parent = this;
					if ((children [1] = m_RelativeOIDValue = (p_asn_features.m_RelativeOIDValue != null) ? new RelativeOIDValue (p_asn_features.m_RelativeOIDValue) : null) != null) m_RelativeOIDValue.parent = this;
					break;
				case production_kind.g_asn_features_55:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_SequenceValue_token = (p_asn_features.m_SequenceValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_SequenceValue_token) : null) != null) m_SequenceValue_token.parent = this;
					if ((children [1] = m_SequenceValue = (p_asn_features.m_SequenceValue != null) ? new SequenceValue (p_asn_features.m_SequenceValue) : null) != null) m_SequenceValue.parent = this;
					break;
				case production_kind.g_asn_features_56:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_SequenceOfValue_token = (p_asn_features.m_SequenceOfValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_SequenceOfValue_token) : null) != null) m_SequenceOfValue_token.parent = this;
					if ((children [1] = m_SequenceOfValue = (p_asn_features.m_SequenceOfValue != null) ? new SequenceOfValue (p_asn_features.m_SequenceOfValue) : null) != null) m_SequenceOfValue.parent = this;
					break;
				case production_kind.g_asn_features_57:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_SetValue_token = (p_asn_features.m_SetValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_SetValue_token) : null) != null) m_SetValue_token.parent = this;
					if ((children [1] = m_SetValue = (p_asn_features.m_SetValue != null) ? new SetValue (p_asn_features.m_SetValue) : null) != null) m_SetValue.parent = this;
					break;
				case production_kind.g_asn_features_58:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_SetOfValue_token = (p_asn_features.m_SetOfValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_SetOfValue_token) : null) != null) m_SetOfValue_token.parent = this;
					if ((children [1] = m_SetOfValue = (p_asn_features.m_SetOfValue != null) ? new SetOfValue (p_asn_features.m_SetOfValue) : null) != null) m_SetOfValue.parent = this;
					break;
				case production_kind.g_asn_features_59:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_TimeValue_token = (p_asn_features.m_TimeValue_token != null) ? new SyntaxTreeToken (p_asn_features.m_TimeValue_token) : null) != null) m_TimeValue_token.parent = this;
					if ((children [1] = m_TimeValue = (p_asn_features.m_TimeValue != null) ? new TimeValue (p_asn_features.m_TimeValue) : null) != null) m_TimeValue.parent = this;
					break;
				case production_kind.g_asn_features_60:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_SubtypeElements_token = (p_asn_features.m_SubtypeElements_token != null) ? new SyntaxTreeToken (p_asn_features.m_SubtypeElements_token) : null) != null) m_SubtypeElements_token.parent = this;
					if ((children [1] = m_SubtypeElements = (p_asn_features.m_SubtypeElements != null) ? new SubtypeElements (p_asn_features.m_SubtypeElements) : null) != null) m_SubtypeElements.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "asn_features" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new asn_features (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ModuleDefinitions_token?.Dispose ();
			m_ModuleDefinitions?.Dispose ();
			m_ParameterizedType_token?.Dispose ();
			m_ParameterizedType?.Dispose ();
			m_ParameterizedValue_token?.Dispose ();
			m_ParameterizedValue?.Dispose ();
			m_ParameterizedValueSetType_token?.Dispose ();
			m_ParameterizedValueSetType?.Dispose ();
			m_ParameterizedObjectClass_token?.Dispose ();
			m_ParameterizedObjectClass?.Dispose ();
			m_ParameterizedObjectSet_token?.Dispose ();
			m_ParameterizedObjectSet?.Dispose ();
			m_ParameterizedObject_token?.Dispose ();
			m_ParameterizedObject?.Dispose ();
			m_AssignmentList_token?.Dispose ();
			m_AssignmentList?.Dispose ();
			m_BuiltinValue_token?.Dispose ();
			m_BuiltinValue?.Dispose ();
			m_TypeAssignment_token?.Dispose ();
			m_TypeAssignment?.Dispose ();
			m_ValueAssignment_token?.Dispose ();
			m_ValueAssignment?.Dispose ();
			m_ValueSetTypeAssignment_token?.Dispose ();
			m_ValueSetTypeAssignment?.Dispose ();
			m_ObjectClassAssignment_token?.Dispose ();
			m_ObjectClassAssignment?.Dispose ();
			m_ObjectAssignment_token?.Dispose ();
			m_ObjectAssignment?.Dispose ();
			m_ObjectSetAssignment_token?.Dispose ();
			m_ObjectSetAssignment?.Dispose ();
			m_ParameterizedTypeAssignment_token?.Dispose ();
			m_ParameterizedTypeAssignment?.Dispose ();
			m_ParameterizedValueAssignment_token?.Dispose ();
			m_ParameterizedValueAssignment?.Dispose ();
			m_ParameterizedValueSetTypeAssignment_token?.Dispose ();
			m_ParameterizedValueSetTypeAssignment?.Dispose ();
			m_ParameterizedObjectClassAssignment_token?.Dispose ();
			m_ParameterizedObjectClassAssignment?.Dispose ();
			m_ParameterizedObjectAssignment_token?.Dispose ();
			m_ParameterizedObjectAssignment?.Dispose ();
			m_ParameterizedObjectSetAssignment_token?.Dispose ();
			m_ParameterizedObjectSetAssignment?.Dispose ();
			m_DefaultSyntax_token?.Dispose ();
			m_DefaultSyntax?.Dispose ();
			m_TypeFieldSpec_token?.Dispose ();
			m_TypeFieldSpec?.Dispose ();
			m_FixedTypeValueFieldSpec_token?.Dispose ();
			m_FixedTypeValueFieldSpec?.Dispose ();
			m_VariableTypeValueFieldSpec_token?.Dispose ();
			m_VariableTypeValueFieldSpec?.Dispose ();
			m_FixedTypeValueSetFieldSpec_token?.Dispose ();
			m_FixedTypeValueSetFieldSpec?.Dispose ();
			m_VariableTypeValueSetFieldSpec_token?.Dispose ();
			m_VariableTypeValueSetFieldSpec?.Dispose ();
			m_ObjectFieldSpec_token?.Dispose ();
			m_ObjectFieldSpec?.Dispose ();
			m_ObjectSetFieldSpec_token?.Dispose ();
			m_ObjectSetFieldSpec?.Dispose ();
			m_DefinedType_token?.Dispose ();
			m_DefinedType?.Dispose ();
			m_DefinedValue_token?.Dispose ();
			m_DefinedValue?.Dispose ();
			m_ObjectClass_token?.Dispose ();
			m_ObjectClass?.Dispose ();
			m_ObjectSetElements_token?.Dispose ();
			m_ObjectSetElements?.Dispose ();
			m_Object_token?.Dispose ();
			m_Object?.Dispose ();
			m_ObjectSet_token?.Dispose ();
			m_ObjectSet?.Dispose ();
			m_ReferencedValue_token?.Dispose ();
			m_ReferencedValue?.Dispose ();
			m_Type_token?.Dispose ();
			m_Type?.Dispose ();
			m_Value_token?.Dispose ();
			m_Value?.Dispose ();
			m_ValueSet_token?.Dispose ();
			m_ValueSet?.Dispose ();
			m_BitStringValue_token?.Dispose ();
			m_BitStringValue?.Dispose ();
			m_BooleanValue_token?.Dispose ();
			m_BooleanValue?.Dispose ();
			m_CharacterStringValue_token?.Dispose ();
			m_CharacterStringValue?.Dispose ();
			m_ChoiceValue_token?.Dispose ();
			m_ChoiceValue?.Dispose ();
			m_EmbeddedPDVValue_token?.Dispose ();
			m_EmbeddedPDVValue?.Dispose ();
			m_EnumeratedValue_token?.Dispose ();
			m_EnumeratedValue?.Dispose ();
			m_ExternalValue_token?.Dispose ();
			m_ExternalValue?.Dispose ();
			m_IntegerValue_token?.Dispose ();
			m_IntegerValue?.Dispose ();
			m_IRIValue_token?.Dispose ();
			m_IRIValue?.Dispose ();
			m_NullValue_token?.Dispose ();
			m_NullValue?.Dispose ();
			m_ObjectIdentifierValue_token?.Dispose ();
			m_ObjectIdentifierValue?.Dispose ();
			m_OctetStringValue_token?.Dispose ();
			m_OctetStringValue?.Dispose ();
			m_RealValue_token?.Dispose ();
			m_RealValue?.Dispose ();
			m_RelativeIRIValue_token?.Dispose ();
			m_RelativeIRIValue?.Dispose ();
			m_RelativeOIDValue_token?.Dispose ();
			m_RelativeOIDValue?.Dispose ();
			m_SequenceValue_token?.Dispose ();
			m_SequenceValue?.Dispose ();
			m_SequenceOfValue_token?.Dispose ();
			m_SequenceOfValue?.Dispose ();
			m_SetValue_token?.Dispose ();
			m_SetValue?.Dispose ();
			m_SetOfValue_token?.Dispose ();
			m_SetOfValue?.Dispose ();
			m_TimeValue_token?.Dispose ();
			m_TimeValue?.Dispose ();
			m_SubtypeElements_token?.Dispose ();
			m_SubtypeElements?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule asn-features

		// Content changing function(s) associated with production(s) of syntax rule asn-features

		//
		// Content changing function associated with following production(s)
		// asn-features -> ModuleDefinitions-token ModuleDefinitions

		//

		public void change(SyntaxTreeToken p_token, ModuleDefinitions p_ModuleDefinitions)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ModuleDefinitions_token = p_token;
			children [1] = m_ModuleDefinitions = p_ModuleDefinitions;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ParameterizedType-token ParameterizedType

		//

		public void change(SyntaxTreeToken p_token, ParameterizedType p_ParameterizedType)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ParameterizedType_token = p_token;
			children [1] = m_ParameterizedType = p_ParameterizedType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ParameterizedValue-token ParameterizedValue

		//

		public void change(SyntaxTreeToken p_token, ParameterizedValue p_ParameterizedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ParameterizedValue_token = p_token;
			children [1] = m_ParameterizedValue = p_ParameterizedValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ParameterizedValueSetType-token ParameterizedValueSetType

		//

		public void change(SyntaxTreeToken p_token, ParameterizedValueSetType p_ParameterizedValueSetType)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ParameterizedValueSetType_token = p_token;
			children [1] = m_ParameterizedValueSetType = p_ParameterizedValueSetType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ParameterizedObjectClass-token ParameterizedObjectClass

		//

		public void change(SyntaxTreeToken p_token, ParameterizedObjectClass p_ParameterizedObjectClass)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_5;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ParameterizedObjectClass_token = p_token;
			children [1] = m_ParameterizedObjectClass = p_ParameterizedObjectClass;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ParameterizedObjectSet-token ParameterizedObjectSet

		//

		public void change(SyntaxTreeToken p_token, ParameterizedObjectSet p_ParameterizedObjectSet)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_6;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ParameterizedObjectSet_token = p_token;
			children [1] = m_ParameterizedObjectSet = p_ParameterizedObjectSet;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ParameterizedObject-token ParameterizedObject

		//

		public void change(SyntaxTreeToken p_token, ParameterizedObject p_ParameterizedObject)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_7;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ParameterizedObject_token = p_token;
			children [1] = m_ParameterizedObject = p_ParameterizedObject;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> AssignmentList-token AssignmentList

		//

		public void change(SyntaxTreeToken p_token, AssignmentList p_AssignmentList)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_8;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_AssignmentList_token = p_token;
			children [1] = m_AssignmentList = p_AssignmentList;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> BuiltinValue-token BuiltinValue

		//

		public void change(SyntaxTreeToken p_token, BuiltinValue p_BuiltinValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_9;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_BuiltinValue_token = p_token;
			children [1] = m_BuiltinValue = p_BuiltinValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> TypeAssignment-token TypeAssignment

		//

		public void change(SyntaxTreeToken p_token, TypeAssignment p_TypeAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_10;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_TypeAssignment_token = p_token;
			children [1] = m_TypeAssignment = p_TypeAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ValueAssignment-token ValueAssignment

		//

		public void change(SyntaxTreeToken p_token, ValueAssignment p_ValueAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_11;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ValueAssignment_token = p_token;
			children [1] = m_ValueAssignment = p_ValueAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ValueSetTypeAssignment-token ValueSetTypeAssignment

		//

		public void change(SyntaxTreeToken p_token, ValueSetTypeAssignment p_ValueSetTypeAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_12;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ValueSetTypeAssignment_token = p_token;
			children [1] = m_ValueSetTypeAssignment = p_ValueSetTypeAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ObjectClassAssignment-token ObjectClassAssignment

		//

		public void change(SyntaxTreeToken p_token, ObjectClassAssignment p_ObjectClassAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_13;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ObjectClassAssignment_token = p_token;
			children [1] = m_ObjectClassAssignment = p_ObjectClassAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ObjectAssignment-token ObjectAssignment

		//

		public void change(SyntaxTreeToken p_token, ObjectAssignment p_ObjectAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_14;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ObjectAssignment_token = p_token;
			children [1] = m_ObjectAssignment = p_ObjectAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ObjectSetAssignment-token ObjectSetAssignment

		//

		public void change(SyntaxTreeToken p_token, ObjectSetAssignment p_ObjectSetAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_15;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ObjectSetAssignment_token = p_token;
			children [1] = m_ObjectSetAssignment = p_ObjectSetAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ParameterizedTypeAssignment-token ParameterizedTypeAssignment

		//

		public void change(SyntaxTreeToken p_token, ParameterizedTypeAssignment p_ParameterizedTypeAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_16;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ParameterizedTypeAssignment_token = p_token;
			children [1] = m_ParameterizedTypeAssignment = p_ParameterizedTypeAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ParameterizedValueAssignment-token ParameterizedValueAssignment

		//

		public void change(SyntaxTreeToken p_token, ParameterizedValueAssignment p_ParameterizedValueAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_17;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ParameterizedValueAssignment_token = p_token;
			children [1] = m_ParameterizedValueAssignment = p_ParameterizedValueAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ParameterizedValueSetTypeAssignment-token ParameterizedValueSetTypeAssignment

		//

		public void change(SyntaxTreeToken p_token, ParameterizedValueSetTypeAssignment p_ParameterizedValueSetTypeAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_18;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ParameterizedValueSetTypeAssignment_token = p_token;
			children [1] = m_ParameterizedValueSetTypeAssignment = p_ParameterizedValueSetTypeAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ParameterizedObjectClassAssignment-token ParameterizedObjectClassAssignment

		//

		public void change(SyntaxTreeToken p_token, ParameterizedObjectClassAssignment p_ParameterizedObjectClassAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_19;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ParameterizedObjectClassAssignment_token = p_token;
			children [1] = m_ParameterizedObjectClassAssignment = p_ParameterizedObjectClassAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ParameterizedObjectAssignment-token ParameterizedObjectAssignment

		//

		public void change(SyntaxTreeToken p_token, ParameterizedObjectAssignment p_ParameterizedObjectAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_20;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ParameterizedObjectAssignment_token = p_token;
			children [1] = m_ParameterizedObjectAssignment = p_ParameterizedObjectAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ParameterizedObjectSetAssignment-token ParameterizedObjectSetAssignment

		//

		public void change(SyntaxTreeToken p_token, ParameterizedObjectSetAssignment p_ParameterizedObjectSetAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_21;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ParameterizedObjectSetAssignment_token = p_token;
			children [1] = m_ParameterizedObjectSetAssignment = p_ParameterizedObjectSetAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> DefaultSyntax-token DefaultSyntax

		//

		public void change(SyntaxTreeToken p_token, DefaultSyntax p_DefaultSyntax)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_22;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_DefaultSyntax_token = p_token;
			children [1] = m_DefaultSyntax = p_DefaultSyntax;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> TypeFieldSpec-token TypeFieldSpec

		//

		public void change(SyntaxTreeToken p_token, TypeFieldSpec p_TypeFieldSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_23;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_TypeFieldSpec_token = p_token;
			children [1] = m_TypeFieldSpec = p_TypeFieldSpec;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> FixedTypeValueFieldSpec-token FixedTypeValueFieldSpec

		//

		public void change(SyntaxTreeToken p_token, FixedTypeValueFieldSpec p_FixedTypeValueFieldSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_24;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_FixedTypeValueFieldSpec_token = p_token;
			children [1] = m_FixedTypeValueFieldSpec = p_FixedTypeValueFieldSpec;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> VariableTypeValueFieldSpec-token VariableTypeValueFieldSpec

		//

		public void change(SyntaxTreeToken p_token, VariableTypeValueFieldSpec p_VariableTypeValueFieldSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_25;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_VariableTypeValueFieldSpec_token = p_token;
			children [1] = m_VariableTypeValueFieldSpec = p_VariableTypeValueFieldSpec;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> FixedTypeValueSetFieldSpec-token FixedTypeValueSetFieldSpec

		//

		public void change(SyntaxTreeToken p_token, FixedTypeValueSetFieldSpec p_FixedTypeValueSetFieldSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_26;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_FixedTypeValueSetFieldSpec_token = p_token;
			children [1] = m_FixedTypeValueSetFieldSpec = p_FixedTypeValueSetFieldSpec;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> VariableTypeValueSetFieldSpec-token VariableTypeValueSetFieldSpec

		//

		public void change(SyntaxTreeToken p_token, VariableTypeValueSetFieldSpec p_VariableTypeValueSetFieldSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_27;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_VariableTypeValueSetFieldSpec_token = p_token;
			children [1] = m_VariableTypeValueSetFieldSpec = p_VariableTypeValueSetFieldSpec;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ObjectFieldSpec-token ObjectFieldSpec

		//

		public void change(SyntaxTreeToken p_token, ObjectFieldSpec p_ObjectFieldSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_28;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ObjectFieldSpec_token = p_token;
			children [1] = m_ObjectFieldSpec = p_ObjectFieldSpec;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ObjectSetFieldSpec-token ObjectSetFieldSpec

		//

		public void change(SyntaxTreeToken p_token, ObjectSetFieldSpec p_ObjectSetFieldSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_29;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ObjectSetFieldSpec_token = p_token;
			children [1] = m_ObjectSetFieldSpec = p_ObjectSetFieldSpec;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> DefinedType-token DefinedType

		//

		public void change(SyntaxTreeToken p_token, DefinedType p_DefinedType)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_30;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_DefinedType_token = p_token;
			children [1] = m_DefinedType = p_DefinedType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> DefinedValue-token DefinedValue

		//

		public void change(SyntaxTreeToken p_token, DefinedValue p_DefinedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_31;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_DefinedValue_token = p_token;
			children [1] = m_DefinedValue = p_DefinedValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ObjectClass-token ObjectClass

		//

		public void change(SyntaxTreeToken p_token, ObjectClass p_ObjectClass)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_32;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ObjectClass_token = p_token;
			children [1] = m_ObjectClass = p_ObjectClass;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ObjectSetElements-token ObjectSetElements

		//

		public void change(SyntaxTreeToken p_token, ObjectSetElements p_ObjectSetElements)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_33;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ObjectSetElements_token = p_token;
			children [1] = m_ObjectSetElements = p_ObjectSetElements;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> Object-token Object

		//

		public void change(SyntaxTreeToken p_token, Object p_Object)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_34;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_Object_token = p_token;
			children [1] = m_Object = p_Object;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ObjectSet-token ObjectSet

		//

		public void change(SyntaxTreeToken p_token, ObjectSet p_ObjectSet)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_35;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ObjectSet_token = p_token;
			children [1] = m_ObjectSet = p_ObjectSet;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ReferencedValue-token ReferencedValue

		//

		public void change(SyntaxTreeToken p_token, ReferencedValue p_ReferencedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_36;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ReferencedValue_token = p_token;
			children [1] = m_ReferencedValue = p_ReferencedValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> Type-token Type

		//

		public void change(SyntaxTreeToken p_token, Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_37;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_Type_token = p_token;
			children [1] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> Value-token Value

		//

		public void change(SyntaxTreeToken p_token, Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_38;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_Value_token = p_token;
			children [1] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ValueSet-token ValueSet

		//

		public void change(SyntaxTreeToken p_token, ValueSet p_ValueSet)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_39;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ValueSet_token = p_token;
			children [1] = m_ValueSet = p_ValueSet;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> BitStringValue-token BitStringValue

		//

		public void change(SyntaxTreeToken p_token, BitStringValue p_BitStringValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_40;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_BitStringValue_token = p_token;
			children [1] = m_BitStringValue = p_BitStringValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> BooleanValue-token BooleanValue

		//

		public void change(SyntaxTreeToken p_token, BooleanValue p_BooleanValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_41;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_BooleanValue_token = p_token;
			children [1] = m_BooleanValue = p_BooleanValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> CharacterStringValue-token CharacterStringValue

		//

		public void change(SyntaxTreeToken p_token, CharacterStringValue p_CharacterStringValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_42;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_CharacterStringValue_token = p_token;
			children [1] = m_CharacterStringValue = p_CharacterStringValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ChoiceValue-token ChoiceValue

		//

		public void change(SyntaxTreeToken p_token, ChoiceValue p_ChoiceValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_43;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ChoiceValue_token = p_token;
			children [1] = m_ChoiceValue = p_ChoiceValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> EmbeddedPDVValue-token EmbeddedPDVValue

		//

		public void change(SyntaxTreeToken p_token, EmbeddedPDVValue p_EmbeddedPDVValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_44;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_EmbeddedPDVValue_token = p_token;
			children [1] = m_EmbeddedPDVValue = p_EmbeddedPDVValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> EnumeratedValue-token EnumeratedValue

		//

		public void change(SyntaxTreeToken p_token, EnumeratedValue p_EnumeratedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_45;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_EnumeratedValue_token = p_token;
			children [1] = m_EnumeratedValue = p_EnumeratedValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ExternalValue-token ExternalValue

		//

		public void change(SyntaxTreeToken p_token, ExternalValue p_ExternalValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_46;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ExternalValue_token = p_token;
			children [1] = m_ExternalValue = p_ExternalValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> IntegerValue-token IntegerValue

		//

		public void change(SyntaxTreeToken p_token, IntegerValue p_IntegerValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_47;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_IntegerValue_token = p_token;
			children [1] = m_IntegerValue = p_IntegerValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> IRIValue-token IRIValue

		//

		public void change(SyntaxTreeToken p_token, IRIValue p_IRIValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_48;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_IRIValue_token = p_token;
			children [1] = m_IRIValue = p_IRIValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> NullValue-token NullValue

		//

		public void change(SyntaxTreeToken p_token, NullValue p_NullValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_49;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_NullValue_token = p_token;
			children [1] = m_NullValue = p_NullValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> ObjectIdentifierValue-token ObjectIdentifierValue

		//

		public void change(SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_50;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ObjectIdentifierValue_token = p_token;
			children [1] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> OctetStringValue-token OctetStringValue

		//

		public void change(SyntaxTreeToken p_token, OctetStringValue p_OctetStringValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_51;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_OctetStringValue_token = p_token;
			children [1] = m_OctetStringValue = p_OctetStringValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> RealValue-token RealValue

		//

		public void change(SyntaxTreeToken p_token, RealValue p_RealValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_52;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_RealValue_token = p_token;
			children [1] = m_RealValue = p_RealValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> RelativeIRIValue-token RelativeIRIValue

		//

		public void change(SyntaxTreeToken p_token, RelativeIRIValue p_RelativeIRIValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_53;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_RelativeIRIValue_token = p_token;
			children [1] = m_RelativeIRIValue = p_RelativeIRIValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> RelativeOIDValue-token RelativeOIDValue

		//

		public void change(SyntaxTreeToken p_token, RelativeOIDValue p_RelativeOIDValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_54;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_RelativeOIDValue_token = p_token;
			children [1] = m_RelativeOIDValue = p_RelativeOIDValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> SequenceValue-token SequenceValue

		//

		public void change(SyntaxTreeToken p_token, SequenceValue p_SequenceValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_55;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_SequenceValue_token = p_token;
			children [1] = m_SequenceValue = p_SequenceValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> SequenceOfValue-token SequenceOfValue

		//

		public void change(SyntaxTreeToken p_token, SequenceOfValue p_SequenceOfValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_56;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_SequenceOfValue_token = p_token;
			children [1] = m_SequenceOfValue = p_SequenceOfValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> SetValue-token SetValue

		//

		public void change(SyntaxTreeToken p_token, SetValue p_SetValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_57;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_SetValue_token = p_token;
			children [1] = m_SetValue = p_SetValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> SetOfValue-token SetOfValue

		//

		public void change(SyntaxTreeToken p_token, SetOfValue p_SetOfValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_58;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_SetOfValue_token = p_token;
			children [1] = m_SetOfValue = p_SetOfValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> TimeValue-token TimeValue

		//

		public void change(SyntaxTreeToken p_token, TimeValue p_TimeValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_59;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_TimeValue_token = p_token;
			children [1] = m_TimeValue = p_TimeValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// asn-features -> SubtypeElements-token SubtypeElements

		//

		public void change(SyntaxTreeToken p_token, SubtypeElements p_SubtypeElements)
		{
			_init ();
			this.kind = (uint) production_kind.g_asn_features_60;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_SubtypeElements_token = p_token;
			children [1] = m_SubtypeElements = p_SubtypeElements;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule asn-features
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ModuleDefinitions_token != null) && m_ModuleDefinitions_token.checkInclusion (element) ||
				(m_ModuleDefinitions != null) && m_ModuleDefinitions.checkInclusion (element) ||
				(m_ParameterizedType_token != null) && m_ParameterizedType_token.checkInclusion (element) ||
				(m_ParameterizedType != null) && m_ParameterizedType.checkInclusion (element) ||
				(m_ParameterizedValue_token != null) && m_ParameterizedValue_token.checkInclusion (element) ||
				(m_ParameterizedValue != null) && m_ParameterizedValue.checkInclusion (element) ||
				(m_ParameterizedValueSetType_token != null) && m_ParameterizedValueSetType_token.checkInclusion (element) ||
				(m_ParameterizedValueSetType != null) && m_ParameterizedValueSetType.checkInclusion (element) ||
				(m_ParameterizedObjectClass_token != null) && m_ParameterizedObjectClass_token.checkInclusion (element) ||
				(m_ParameterizedObjectClass != null) && m_ParameterizedObjectClass.checkInclusion (element) ||
				(m_ParameterizedObjectSet_token != null) && m_ParameterizedObjectSet_token.checkInclusion (element) ||
				(m_ParameterizedObjectSet != null) && m_ParameterizedObjectSet.checkInclusion (element) ||
				(m_ParameterizedObject_token != null) && m_ParameterizedObject_token.checkInclusion (element) ||
				(m_ParameterizedObject != null) && m_ParameterizedObject.checkInclusion (element) ||
				(m_AssignmentList_token != null) && m_AssignmentList_token.checkInclusion (element) ||
				(m_AssignmentList != null) && m_AssignmentList.checkInclusion (element) ||
				(m_BuiltinValue_token != null) && m_BuiltinValue_token.checkInclusion (element) ||
				(m_BuiltinValue != null) && m_BuiltinValue.checkInclusion (element) ||
				(m_TypeAssignment_token != null) && m_TypeAssignment_token.checkInclusion (element) ||
				(m_TypeAssignment != null) && m_TypeAssignment.checkInclusion (element) ||
				(m_ValueAssignment_token != null) && m_ValueAssignment_token.checkInclusion (element) ||
				(m_ValueAssignment != null) && m_ValueAssignment.checkInclusion (element) ||
				(m_ValueSetTypeAssignment_token != null) && m_ValueSetTypeAssignment_token.checkInclusion (element) ||
				(m_ValueSetTypeAssignment != null) && m_ValueSetTypeAssignment.checkInclusion (element) ||
				(m_ObjectClassAssignment_token != null) && m_ObjectClassAssignment_token.checkInclusion (element) ||
				(m_ObjectClassAssignment != null) && m_ObjectClassAssignment.checkInclusion (element) ||
				(m_ObjectAssignment_token != null) && m_ObjectAssignment_token.checkInclusion (element) ||
				(m_ObjectAssignment != null) && m_ObjectAssignment.checkInclusion (element) ||
				(m_ObjectSetAssignment_token != null) && m_ObjectSetAssignment_token.checkInclusion (element) ||
				(m_ObjectSetAssignment != null) && m_ObjectSetAssignment.checkInclusion (element) ||
				(m_ParameterizedTypeAssignment_token != null) && m_ParameterizedTypeAssignment_token.checkInclusion (element) ||
				(m_ParameterizedTypeAssignment != null) && m_ParameterizedTypeAssignment.checkInclusion (element) ||
				(m_ParameterizedValueAssignment_token != null) && m_ParameterizedValueAssignment_token.checkInclusion (element) ||
				(m_ParameterizedValueAssignment != null) && m_ParameterizedValueAssignment.checkInclusion (element) ||
				(m_ParameterizedValueSetTypeAssignment_token != null) && m_ParameterizedValueSetTypeAssignment_token.checkInclusion (element) ||
				(m_ParameterizedValueSetTypeAssignment != null) && m_ParameterizedValueSetTypeAssignment.checkInclusion (element) ||
				(m_ParameterizedObjectClassAssignment_token != null) && m_ParameterizedObjectClassAssignment_token.checkInclusion (element) ||
				(m_ParameterizedObjectClassAssignment != null) && m_ParameterizedObjectClassAssignment.checkInclusion (element) ||
				(m_ParameterizedObjectAssignment_token != null) && m_ParameterizedObjectAssignment_token.checkInclusion (element) ||
				(m_ParameterizedObjectAssignment != null) && m_ParameterizedObjectAssignment.checkInclusion (element) ||
				(m_ParameterizedObjectSetAssignment_token != null) && m_ParameterizedObjectSetAssignment_token.checkInclusion (element) ||
				(m_ParameterizedObjectSetAssignment != null) && m_ParameterizedObjectSetAssignment.checkInclusion (element) ||
				(m_DefaultSyntax_token != null) && m_DefaultSyntax_token.checkInclusion (element) ||
				(m_DefaultSyntax != null) && m_DefaultSyntax.checkInclusion (element) ||
				(m_TypeFieldSpec_token != null) && m_TypeFieldSpec_token.checkInclusion (element) ||
				(m_TypeFieldSpec != null) && m_TypeFieldSpec.checkInclusion (element) ||
				(m_FixedTypeValueFieldSpec_token != null) && m_FixedTypeValueFieldSpec_token.checkInclusion (element) ||
				(m_FixedTypeValueFieldSpec != null) && m_FixedTypeValueFieldSpec.checkInclusion (element) ||
				(m_VariableTypeValueFieldSpec_token != null) && m_VariableTypeValueFieldSpec_token.checkInclusion (element) ||
				(m_VariableTypeValueFieldSpec != null) && m_VariableTypeValueFieldSpec.checkInclusion (element) ||
				(m_FixedTypeValueSetFieldSpec_token != null) && m_FixedTypeValueSetFieldSpec_token.checkInclusion (element) ||
				(m_FixedTypeValueSetFieldSpec != null) && m_FixedTypeValueSetFieldSpec.checkInclusion (element) ||
				(m_VariableTypeValueSetFieldSpec_token != null) && m_VariableTypeValueSetFieldSpec_token.checkInclusion (element) ||
				(m_VariableTypeValueSetFieldSpec != null) && m_VariableTypeValueSetFieldSpec.checkInclusion (element) ||
				(m_ObjectFieldSpec_token != null) && m_ObjectFieldSpec_token.checkInclusion (element) ||
				(m_ObjectFieldSpec != null) && m_ObjectFieldSpec.checkInclusion (element) ||
				(m_ObjectSetFieldSpec_token != null) && m_ObjectSetFieldSpec_token.checkInclusion (element) ||
				(m_ObjectSetFieldSpec != null) && m_ObjectSetFieldSpec.checkInclusion (element) ||
				(m_DefinedType_token != null) && m_DefinedType_token.checkInclusion (element) ||
				(m_DefinedType != null) && m_DefinedType.checkInclusion (element) ||
				(m_DefinedValue_token != null) && m_DefinedValue_token.checkInclusion (element) ||
				(m_DefinedValue != null) && m_DefinedValue.checkInclusion (element) ||
				(m_ObjectClass_token != null) && m_ObjectClass_token.checkInclusion (element) ||
				(m_ObjectClass != null) && m_ObjectClass.checkInclusion (element) ||
				(m_ObjectSetElements_token != null) && m_ObjectSetElements_token.checkInclusion (element) ||
				(m_ObjectSetElements != null) && m_ObjectSetElements.checkInclusion (element) ||
				(m_Object_token != null) && m_Object_token.checkInclusion (element) ||
				(m_Object != null) && m_Object.checkInclusion (element) ||
				(m_ObjectSet_token != null) && m_ObjectSet_token.checkInclusion (element) ||
				(m_ObjectSet != null) && m_ObjectSet.checkInclusion (element) ||
				(m_ReferencedValue_token != null) && m_ReferencedValue_token.checkInclusion (element) ||
				(m_ReferencedValue != null) && m_ReferencedValue.checkInclusion (element) ||
				(m_Type_token != null) && m_Type_token.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_Value_token != null) && m_Value_token.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				(m_ValueSet_token != null) && m_ValueSet_token.checkInclusion (element) ||
				(m_ValueSet != null) && m_ValueSet.checkInclusion (element) ||
				(m_BitStringValue_token != null) && m_BitStringValue_token.checkInclusion (element) ||
				(m_BitStringValue != null) && m_BitStringValue.checkInclusion (element) ||
				(m_BooleanValue_token != null) && m_BooleanValue_token.checkInclusion (element) ||
				(m_BooleanValue != null) && m_BooleanValue.checkInclusion (element) ||
				(m_CharacterStringValue_token != null) && m_CharacterStringValue_token.checkInclusion (element) ||
				(m_CharacterStringValue != null) && m_CharacterStringValue.checkInclusion (element) ||
				(m_ChoiceValue_token != null) && m_ChoiceValue_token.checkInclusion (element) ||
				(m_ChoiceValue != null) && m_ChoiceValue.checkInclusion (element) ||
				(m_EmbeddedPDVValue_token != null) && m_EmbeddedPDVValue_token.checkInclusion (element) ||
				(m_EmbeddedPDVValue != null) && m_EmbeddedPDVValue.checkInclusion (element) ||
				(m_EnumeratedValue_token != null) && m_EnumeratedValue_token.checkInclusion (element) ||
				(m_EnumeratedValue != null) && m_EnumeratedValue.checkInclusion (element) ||
				(m_ExternalValue_token != null) && m_ExternalValue_token.checkInclusion (element) ||
				(m_ExternalValue != null) && m_ExternalValue.checkInclusion (element) ||
				(m_IntegerValue_token != null) && m_IntegerValue_token.checkInclusion (element) ||
				(m_IntegerValue != null) && m_IntegerValue.checkInclusion (element) ||
				(m_IRIValue_token != null) && m_IRIValue_token.checkInclusion (element) ||
				(m_IRIValue != null) && m_IRIValue.checkInclusion (element) ||
				(m_NullValue_token != null) && m_NullValue_token.checkInclusion (element) ||
				(m_NullValue != null) && m_NullValue.checkInclusion (element) ||
				(m_ObjectIdentifierValue_token != null) && m_ObjectIdentifierValue_token.checkInclusion (element) ||
				(m_ObjectIdentifierValue != null) && m_ObjectIdentifierValue.checkInclusion (element) ||
				(m_OctetStringValue_token != null) && m_OctetStringValue_token.checkInclusion (element) ||
				(m_OctetStringValue != null) && m_OctetStringValue.checkInclusion (element) ||
				(m_RealValue_token != null) && m_RealValue_token.checkInclusion (element) ||
				(m_RealValue != null) && m_RealValue.checkInclusion (element) ||
				(m_RelativeIRIValue_token != null) && m_RelativeIRIValue_token.checkInclusion (element) ||
				(m_RelativeIRIValue != null) && m_RelativeIRIValue.checkInclusion (element) ||
				(m_RelativeOIDValue_token != null) && m_RelativeOIDValue_token.checkInclusion (element) ||
				(m_RelativeOIDValue != null) && m_RelativeOIDValue.checkInclusion (element) ||
				(m_SequenceValue_token != null) && m_SequenceValue_token.checkInclusion (element) ||
				(m_SequenceValue != null) && m_SequenceValue.checkInclusion (element) ||
				(m_SequenceOfValue_token != null) && m_SequenceOfValue_token.checkInclusion (element) ||
				(m_SequenceOfValue != null) && m_SequenceOfValue.checkInclusion (element) ||
				(m_SetValue_token != null) && m_SetValue_token.checkInclusion (element) ||
				(m_SetValue != null) && m_SetValue.checkInclusion (element) ||
				(m_SetOfValue_token != null) && m_SetOfValue_token.checkInclusion (element) ||
				(m_SetOfValue != null) && m_SetOfValue.checkInclusion (element) ||
				(m_TimeValue_token != null) && m_TimeValue_token.checkInclusion (element) ||
				(m_TimeValue != null) && m_TimeValue.checkInclusion (element) ||
				(m_SubtypeElements_token != null) && m_SubtypeElements_token.checkInclusion (element) ||
				(m_SubtypeElements != null) && m_SubtypeElements.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule asn-features

		//
		// emit production tree node associated with any production of syntax rule asn-features
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_asn_features_1:
					// emit syntax tree node associated with production
					// asn-features: ModuleDefinitions-token ModuleDefinitions

					s += m_ModuleDefinitions_token.Emit (depth - 1);
					s += " ";
					s += m_ModuleDefinitions.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_2:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedType-token ParameterizedType

					s += m_ParameterizedType_token.Emit (depth - 1);
					s += " ";
					s += m_ParameterizedType.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_3:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedValue-token ParameterizedValue

					s += m_ParameterizedValue_token.Emit (depth - 1);
					s += " ";
					s += m_ParameterizedValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_4:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedValueSetType-token ParameterizedValueSetType

					s += m_ParameterizedValueSetType_token.Emit (depth - 1);
					s += " ";
					s += m_ParameterizedValueSetType.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_5:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedObjectClass-token ParameterizedObjectClass

					s += m_ParameterizedObjectClass_token.Emit (depth - 1);
					s += " ";
					s += m_ParameterizedObjectClass.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_6:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedObjectSet-token ParameterizedObjectSet

					s += m_ParameterizedObjectSet_token.Emit (depth - 1);
					s += " ";
					s += m_ParameterizedObjectSet.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_7:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedObject-token ParameterizedObject

					s += m_ParameterizedObject_token.Emit (depth - 1);
					s += " ";
					s += m_ParameterizedObject.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_8:
					// emit syntax tree node associated with production
					// asn-features: AssignmentList-token AssignmentList

					s += m_AssignmentList_token.Emit (depth - 1);
					s += " ";
					s += m_AssignmentList.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_9:
					// emit syntax tree node associated with production
					// asn-features: BuiltinValue-token BuiltinValue

					s += m_BuiltinValue_token.Emit (depth - 1);
					s += " ";
					s += m_BuiltinValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_10:
					// emit syntax tree node associated with production
					// asn-features: TypeAssignment-token TypeAssignment

					s += m_TypeAssignment_token.Emit (depth - 1);
					s += " ";
					s += m_TypeAssignment.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_11:
					// emit syntax tree node associated with production
					// asn-features: ValueAssignment-token ValueAssignment

					s += m_ValueAssignment_token.Emit (depth - 1);
					s += " ";
					s += m_ValueAssignment.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_12:
					// emit syntax tree node associated with production
					// asn-features: ValueSetTypeAssignment-token ValueSetTypeAssignment

					s += m_ValueSetTypeAssignment_token.Emit (depth - 1);
					s += " ";
					s += m_ValueSetTypeAssignment.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_13:
					// emit syntax tree node associated with production
					// asn-features: ObjectClassAssignment-token ObjectClassAssignment

					s += m_ObjectClassAssignment_token.Emit (depth - 1);
					s += " ";
					s += m_ObjectClassAssignment.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_14:
					// emit syntax tree node associated with production
					// asn-features: ObjectAssignment-token ObjectAssignment

					s += m_ObjectAssignment_token.Emit (depth - 1);
					s += " ";
					s += m_ObjectAssignment.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_15:
					// emit syntax tree node associated with production
					// asn-features: ObjectSetAssignment-token ObjectSetAssignment

					s += m_ObjectSetAssignment_token.Emit (depth - 1);
					s += " ";
					s += m_ObjectSetAssignment.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_16:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedTypeAssignment-token ParameterizedTypeAssignment

					s += m_ParameterizedTypeAssignment_token.Emit (depth - 1);
					s += " ";
					s += m_ParameterizedTypeAssignment.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_17:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedValueAssignment-token ParameterizedValueAssignment

					s += m_ParameterizedValueAssignment_token.Emit (depth - 1);
					s += " ";
					s += m_ParameterizedValueAssignment.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_18:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedValueSetTypeAssignment-token ParameterizedValueSetTypeAssignment

					s += m_ParameterizedValueSetTypeAssignment_token.Emit (depth - 1);
					s += " ";
					s += m_ParameterizedValueSetTypeAssignment.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_19:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedObjectClassAssignment-token ParameterizedObjectClassAssignment

					s += m_ParameterizedObjectClassAssignment_token.Emit (depth - 1);
					s += " ";
					s += m_ParameterizedObjectClassAssignment.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_20:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedObjectAssignment-token ParameterizedObjectAssignment

					s += m_ParameterizedObjectAssignment_token.Emit (depth - 1);
					s += " ";
					s += m_ParameterizedObjectAssignment.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_21:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedObjectSetAssignment-token ParameterizedObjectSetAssignment

					s += m_ParameterizedObjectSetAssignment_token.Emit (depth - 1);
					s += " ";
					s += m_ParameterizedObjectSetAssignment.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_22:
					// emit syntax tree node associated with production
					// asn-features: DefaultSyntax-token DefaultSyntax

					s += m_DefaultSyntax_token.Emit (depth - 1);
					s += " ";
					s += m_DefaultSyntax.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_23:
					// emit syntax tree node associated with production
					// asn-features: TypeFieldSpec-token TypeFieldSpec

					s += m_TypeFieldSpec_token.Emit (depth - 1);
					s += " ";
					s += m_TypeFieldSpec.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_24:
					// emit syntax tree node associated with production
					// asn-features: FixedTypeValueFieldSpec-token FixedTypeValueFieldSpec

					s += m_FixedTypeValueFieldSpec_token.Emit (depth - 1);
					s += " ";
					s += m_FixedTypeValueFieldSpec.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_25:
					// emit syntax tree node associated with production
					// asn-features: VariableTypeValueFieldSpec-token VariableTypeValueFieldSpec

					s += m_VariableTypeValueFieldSpec_token.Emit (depth - 1);
					s += " ";
					s += m_VariableTypeValueFieldSpec.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_26:
					// emit syntax tree node associated with production
					// asn-features: FixedTypeValueSetFieldSpec-token FixedTypeValueSetFieldSpec

					s += m_FixedTypeValueSetFieldSpec_token.Emit (depth - 1);
					s += " ";
					s += m_FixedTypeValueSetFieldSpec.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_27:
					// emit syntax tree node associated with production
					// asn-features: VariableTypeValueSetFieldSpec-token VariableTypeValueSetFieldSpec

					s += m_VariableTypeValueSetFieldSpec_token.Emit (depth - 1);
					s += " ";
					s += m_VariableTypeValueSetFieldSpec.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_28:
					// emit syntax tree node associated with production
					// asn-features: ObjectFieldSpec-token ObjectFieldSpec

					s += m_ObjectFieldSpec_token.Emit (depth - 1);
					s += " ";
					s += m_ObjectFieldSpec.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_29:
					// emit syntax tree node associated with production
					// asn-features: ObjectSetFieldSpec-token ObjectSetFieldSpec

					s += m_ObjectSetFieldSpec_token.Emit (depth - 1);
					s += " ";
					s += m_ObjectSetFieldSpec.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_30:
					// emit syntax tree node associated with production
					// asn-features: DefinedType-token DefinedType

					s += m_DefinedType_token.Emit (depth - 1);
					s += " ";
					s += m_DefinedType.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_31:
					// emit syntax tree node associated with production
					// asn-features: DefinedValue-token DefinedValue

					s += m_DefinedValue_token.Emit (depth - 1);
					s += " ";
					s += m_DefinedValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_32:
					// emit syntax tree node associated with production
					// asn-features: ObjectClass-token ObjectClass

					s += m_ObjectClass_token.Emit (depth - 1);
					s += " ";
					s += m_ObjectClass.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_33:
					// emit syntax tree node associated with production
					// asn-features: ObjectSetElements-token ObjectSetElements

					s += m_ObjectSetElements_token.Emit (depth - 1);
					s += " ";
					s += m_ObjectSetElements.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_34:
					// emit syntax tree node associated with production
					// asn-features: Object-token Object

					s += m_Object_token.Emit (depth - 1);
					s += " ";
					s += m_Object.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_35:
					// emit syntax tree node associated with production
					// asn-features: ObjectSet-token ObjectSet

					s += m_ObjectSet_token.Emit (depth - 1);
					s += " ";
					s += m_ObjectSet.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_36:
					// emit syntax tree node associated with production
					// asn-features: ReferencedValue-token ReferencedValue

					s += m_ReferencedValue_token.Emit (depth - 1);
					s += " ";
					s += m_ReferencedValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_37:
					// emit syntax tree node associated with production
					// asn-features: Type-token Type

					s += m_Type_token.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_38:
					// emit syntax tree node associated with production
					// asn-features: Value-token Value

					s += m_Value_token.Emit (depth - 1);
					s += " ";
					s += m_Value.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_39:
					// emit syntax tree node associated with production
					// asn-features: ValueSet-token ValueSet

					s += m_ValueSet_token.Emit (depth - 1);
					s += " ";
					s += m_ValueSet.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_40:
					// emit syntax tree node associated with production
					// asn-features: BitStringValue-token BitStringValue

					s += m_BitStringValue_token.Emit (depth - 1);
					s += " ";
					s += m_BitStringValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_41:
					// emit syntax tree node associated with production
					// asn-features: BooleanValue-token BooleanValue

					s += m_BooleanValue_token.Emit (depth - 1);
					s += " ";
					s += m_BooleanValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_42:
					// emit syntax tree node associated with production
					// asn-features: CharacterStringValue-token CharacterStringValue

					s += m_CharacterStringValue_token.Emit (depth - 1);
					s += " ";
					s += m_CharacterStringValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_43:
					// emit syntax tree node associated with production
					// asn-features: ChoiceValue-token ChoiceValue

					s += m_ChoiceValue_token.Emit (depth - 1);
					s += " ";
					s += m_ChoiceValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_44:
					// emit syntax tree node associated with production
					// asn-features: EmbeddedPDVValue-token EmbeddedPDVValue

					s += m_EmbeddedPDVValue_token.Emit (depth - 1);
					s += " ";
					s += m_EmbeddedPDVValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_45:
					// emit syntax tree node associated with production
					// asn-features: EnumeratedValue-token EnumeratedValue

					s += m_EnumeratedValue_token.Emit (depth - 1);
					s += " ";
					s += m_EnumeratedValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_46:
					// emit syntax tree node associated with production
					// asn-features: ExternalValue-token ExternalValue

					s += m_ExternalValue_token.Emit (depth - 1);
					s += " ";
					s += m_ExternalValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_47:
					// emit syntax tree node associated with production
					// asn-features: IntegerValue-token IntegerValue

					s += m_IntegerValue_token.Emit (depth - 1);
					s += " ";
					s += m_IntegerValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_48:
					// emit syntax tree node associated with production
					// asn-features: IRIValue-token IRIValue

					s += m_IRIValue_token.Emit (depth - 1);
					s += " ";
					s += m_IRIValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_49:
					// emit syntax tree node associated with production
					// asn-features: NullValue-token NullValue

					s += m_NullValue_token.Emit (depth - 1);
					s += " ";
					s += m_NullValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_50:
					// emit syntax tree node associated with production
					// asn-features: ObjectIdentifierValue-token ObjectIdentifierValue

					s += m_ObjectIdentifierValue_token.Emit (depth - 1);
					s += " ";
					s += m_ObjectIdentifierValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_51:
					// emit syntax tree node associated with production
					// asn-features: OctetStringValue-token OctetStringValue

					s += m_OctetStringValue_token.Emit (depth - 1);
					s += " ";
					s += m_OctetStringValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_52:
					// emit syntax tree node associated with production
					// asn-features: RealValue-token RealValue

					s += m_RealValue_token.Emit (depth - 1);
					s += " ";
					s += m_RealValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_53:
					// emit syntax tree node associated with production
					// asn-features: RelativeIRIValue-token RelativeIRIValue

					s += m_RelativeIRIValue_token.Emit (depth - 1);
					s += " ";
					s += m_RelativeIRIValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_54:
					// emit syntax tree node associated with production
					// asn-features: RelativeOIDValue-token RelativeOIDValue

					s += m_RelativeOIDValue_token.Emit (depth - 1);
					s += " ";
					s += m_RelativeOIDValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_55:
					// emit syntax tree node associated with production
					// asn-features: SequenceValue-token SequenceValue

					s += m_SequenceValue_token.Emit (depth - 1);
					s += " ";
					s += m_SequenceValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_56:
					// emit syntax tree node associated with production
					// asn-features: SequenceOfValue-token SequenceOfValue

					s += m_SequenceOfValue_token.Emit (depth - 1);
					s += " ";
					s += m_SequenceOfValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_57:
					// emit syntax tree node associated with production
					// asn-features: SetValue-token SetValue

					s += m_SetValue_token.Emit (depth - 1);
					s += " ";
					s += m_SetValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_58:
					// emit syntax tree node associated with production
					// asn-features: SetOfValue-token SetOfValue

					s += m_SetOfValue_token.Emit (depth - 1);
					s += " ";
					s += m_SetOfValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_59:
					// emit syntax tree node associated with production
					// asn-features: TimeValue-token TimeValue

					s += m_TimeValue_token.Emit (depth - 1);
					s += " ";
					s += m_TimeValue.Emit (depth - 1);
				break;
				case production_kind.g_asn_features_60:
					// emit syntax tree node associated with production
					// asn-features: SubtypeElements-token SubtypeElements

					s += m_SubtypeElements_token.Emit (depth - 1);
					s += " ";
					s += m_SubtypeElements.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule asn-features
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "asn_features (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_asn_features_1:
					// emit syntax tree node associated with production
					// asn-features: ModuleDefinitions-token ModuleDefinitions

					s += "ModuleDefinitions_token";
					s += ' ';
					s += m_ModuleDefinitions.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_2:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedType-token ParameterizedType

					s += "ParameterizedType_token";
					s += ' ';
					s += m_ParameterizedType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_3:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedValue-token ParameterizedValue

					s += "ParameterizedValue_token";
					s += ' ';
					s += m_ParameterizedValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_4:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedValueSetType-token ParameterizedValueSetType

					s += "ParameterizedValueSetType_token";
					s += ' ';
					s += m_ParameterizedValueSetType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_5:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedObjectClass-token ParameterizedObjectClass

					s += "ParameterizedObjectClass_token";
					s += ' ';
					s += m_ParameterizedObjectClass.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_6:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedObjectSet-token ParameterizedObjectSet

					s += "ParameterizedObjectSet_token";
					s += ' ';
					s += m_ParameterizedObjectSet.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_7:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedObject-token ParameterizedObject

					s += "ParameterizedObject_token";
					s += ' ';
					s += m_ParameterizedObject.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_8:
					// emit syntax tree node associated with production
					// asn-features: AssignmentList-token AssignmentList

					s += "AssignmentList_token";
					s += ' ';
					s += m_AssignmentList.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_9:
					// emit syntax tree node associated with production
					// asn-features: BuiltinValue-token BuiltinValue

					s += "BuiltinValue_token";
					s += ' ';
					s += m_BuiltinValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_10:
					// emit syntax tree node associated with production
					// asn-features: TypeAssignment-token TypeAssignment

					s += "TypeAssignment_token";
					s += ' ';
					s += m_TypeAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_11:
					// emit syntax tree node associated with production
					// asn-features: ValueAssignment-token ValueAssignment

					s += "ValueAssignment_token";
					s += ' ';
					s += m_ValueAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_12:
					// emit syntax tree node associated with production
					// asn-features: ValueSetTypeAssignment-token ValueSetTypeAssignment

					s += "ValueSetTypeAssignment_token";
					s += ' ';
					s += m_ValueSetTypeAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_13:
					// emit syntax tree node associated with production
					// asn-features: ObjectClassAssignment-token ObjectClassAssignment

					s += "ObjectClassAssignment_token";
					s += ' ';
					s += m_ObjectClassAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_14:
					// emit syntax tree node associated with production
					// asn-features: ObjectAssignment-token ObjectAssignment

					s += "ObjectAssignment_token";
					s += ' ';
					s += m_ObjectAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_15:
					// emit syntax tree node associated with production
					// asn-features: ObjectSetAssignment-token ObjectSetAssignment

					s += "ObjectSetAssignment_token";
					s += ' ';
					s += m_ObjectSetAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_16:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedTypeAssignment-token ParameterizedTypeAssignment

					s += "ParameterizedTypeAssignment_token";
					s += ' ';
					s += m_ParameterizedTypeAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_17:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedValueAssignment-token ParameterizedValueAssignment

					s += "ParameterizedValueAssignment_token";
					s += ' ';
					s += m_ParameterizedValueAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_18:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedValueSetTypeAssignment-token ParameterizedValueSetTypeAssignment

					s += "ParameterizedValueSetTypeAssignment_token";
					s += ' ';
					s += m_ParameterizedValueSetTypeAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_19:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedObjectClassAssignment-token ParameterizedObjectClassAssignment

					s += "ParameterizedObjectClassAssignment_token";
					s += ' ';
					s += m_ParameterizedObjectClassAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_20:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedObjectAssignment-token ParameterizedObjectAssignment

					s += "ParameterizedObjectAssignment_token";
					s += ' ';
					s += m_ParameterizedObjectAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_21:
					// emit syntax tree node associated with production
					// asn-features: ParameterizedObjectSetAssignment-token ParameterizedObjectSetAssignment

					s += "ParameterizedObjectSetAssignment_token";
					s += ' ';
					s += m_ParameterizedObjectSetAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_22:
					// emit syntax tree node associated with production
					// asn-features: DefaultSyntax-token DefaultSyntax

					s += "DefaultSyntax_token";
					s += ' ';
					s += m_DefaultSyntax.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_23:
					// emit syntax tree node associated with production
					// asn-features: TypeFieldSpec-token TypeFieldSpec

					s += "TypeFieldSpec_token";
					s += ' ';
					s += m_TypeFieldSpec.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_24:
					// emit syntax tree node associated with production
					// asn-features: FixedTypeValueFieldSpec-token FixedTypeValueFieldSpec

					s += "FixedTypeValueFieldSpec_token";
					s += ' ';
					s += m_FixedTypeValueFieldSpec.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_25:
					// emit syntax tree node associated with production
					// asn-features: VariableTypeValueFieldSpec-token VariableTypeValueFieldSpec

					s += "VariableTypeValueFieldSpec_token";
					s += ' ';
					s += m_VariableTypeValueFieldSpec.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_26:
					// emit syntax tree node associated with production
					// asn-features: FixedTypeValueSetFieldSpec-token FixedTypeValueSetFieldSpec

					s += "FixedTypeValueSetFieldSpec_token";
					s += ' ';
					s += m_FixedTypeValueSetFieldSpec.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_27:
					// emit syntax tree node associated with production
					// asn-features: VariableTypeValueSetFieldSpec-token VariableTypeValueSetFieldSpec

					s += "VariableTypeValueSetFieldSpec_token";
					s += ' ';
					s += m_VariableTypeValueSetFieldSpec.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_28:
					// emit syntax tree node associated with production
					// asn-features: ObjectFieldSpec-token ObjectFieldSpec

					s += "ObjectFieldSpec_token";
					s += ' ';
					s += m_ObjectFieldSpec.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_29:
					// emit syntax tree node associated with production
					// asn-features: ObjectSetFieldSpec-token ObjectSetFieldSpec

					s += "ObjectSetFieldSpec_token";
					s += ' ';
					s += m_ObjectSetFieldSpec.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_30:
					// emit syntax tree node associated with production
					// asn-features: DefinedType-token DefinedType

					s += "DefinedType_token";
					s += ' ';
					s += m_DefinedType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_31:
					// emit syntax tree node associated with production
					// asn-features: DefinedValue-token DefinedValue

					s += "DefinedValue_token";
					s += ' ';
					s += m_DefinedValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_32:
					// emit syntax tree node associated with production
					// asn-features: ObjectClass-token ObjectClass

					s += "ObjectClass_token";
					s += ' ';
					s += m_ObjectClass.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_33:
					// emit syntax tree node associated with production
					// asn-features: ObjectSetElements-token ObjectSetElements

					s += "ObjectSetElements_token";
					s += ' ';
					s += m_ObjectSetElements.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_34:
					// emit syntax tree node associated with production
					// asn-features: Object-token Object

					s += "Object_token";
					s += ' ';
					s += m_Object.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_35:
					// emit syntax tree node associated with production
					// asn-features: ObjectSet-token ObjectSet

					s += "ObjectSet_token";
					s += ' ';
					s += m_ObjectSet.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_36:
					// emit syntax tree node associated with production
					// asn-features: ReferencedValue-token ReferencedValue

					s += "ReferencedValue_token";
					s += ' ';
					s += m_ReferencedValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_37:
					// emit syntax tree node associated with production
					// asn-features: Type-token Type

					s += "Type_token";
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_38:
					// emit syntax tree node associated with production
					// asn-features: Value-token Value

					s += "Value_token";
					s += ' ';
					s += m_Value.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_39:
					// emit syntax tree node associated with production
					// asn-features: ValueSet-token ValueSet

					s += "ValueSet_token";
					s += ' ';
					s += m_ValueSet.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_40:
					// emit syntax tree node associated with production
					// asn-features: BitStringValue-token BitStringValue

					s += "BitStringValue_token";
					s += ' ';
					s += m_BitStringValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_41:
					// emit syntax tree node associated with production
					// asn-features: BooleanValue-token BooleanValue

					s += "BooleanValue_token";
					s += ' ';
					s += m_BooleanValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_42:
					// emit syntax tree node associated with production
					// asn-features: CharacterStringValue-token CharacterStringValue

					s += "CharacterStringValue_token";
					s += ' ';
					s += m_CharacterStringValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_43:
					// emit syntax tree node associated with production
					// asn-features: ChoiceValue-token ChoiceValue

					s += "ChoiceValue_token";
					s += ' ';
					s += m_ChoiceValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_44:
					// emit syntax tree node associated with production
					// asn-features: EmbeddedPDVValue-token EmbeddedPDVValue

					s += "EmbeddedPDVValue_token";
					s += ' ';
					s += m_EmbeddedPDVValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_45:
					// emit syntax tree node associated with production
					// asn-features: EnumeratedValue-token EnumeratedValue

					s += "EnumeratedValue_token";
					s += ' ';
					s += m_EnumeratedValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_46:
					// emit syntax tree node associated with production
					// asn-features: ExternalValue-token ExternalValue

					s += "ExternalValue_token";
					s += ' ';
					s += m_ExternalValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_47:
					// emit syntax tree node associated with production
					// asn-features: IntegerValue-token IntegerValue

					s += "IntegerValue_token";
					s += ' ';
					s += m_IntegerValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_48:
					// emit syntax tree node associated with production
					// asn-features: IRIValue-token IRIValue

					s += "IRIValue_token";
					s += ' ';
					s += m_IRIValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_49:
					// emit syntax tree node associated with production
					// asn-features: NullValue-token NullValue

					s += "NullValue_token";
					s += ' ';
					s += m_NullValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_50:
					// emit syntax tree node associated with production
					// asn-features: ObjectIdentifierValue-token ObjectIdentifierValue

					s += "ObjectIdentifierValue_token";
					s += ' ';
					s += m_ObjectIdentifierValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_51:
					// emit syntax tree node associated with production
					// asn-features: OctetStringValue-token OctetStringValue

					s += "OctetStringValue_token";
					s += ' ';
					s += m_OctetStringValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_52:
					// emit syntax tree node associated with production
					// asn-features: RealValue-token RealValue

					s += "RealValue_token";
					s += ' ';
					s += m_RealValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_53:
					// emit syntax tree node associated with production
					// asn-features: RelativeIRIValue-token RelativeIRIValue

					s += "RelativeIRIValue_token";
					s += ' ';
					s += m_RelativeIRIValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_54:
					// emit syntax tree node associated with production
					// asn-features: RelativeOIDValue-token RelativeOIDValue

					s += "RelativeOIDValue_token";
					s += ' ';
					s += m_RelativeOIDValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_55:
					// emit syntax tree node associated with production
					// asn-features: SequenceValue-token SequenceValue

					s += "SequenceValue_token";
					s += ' ';
					s += m_SequenceValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_56:
					// emit syntax tree node associated with production
					// asn-features: SequenceOfValue-token SequenceOfValue

					s += "SequenceOfValue_token";
					s += ' ';
					s += m_SequenceOfValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_57:
					// emit syntax tree node associated with production
					// asn-features: SetValue-token SetValue

					s += "SetValue_token";
					s += ' ';
					s += m_SetValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_58:
					// emit syntax tree node associated with production
					// asn-features: SetOfValue-token SetOfValue

					s += "SetOfValue_token";
					s += ' ';
					s += m_SetOfValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_59:
					// emit syntax tree node associated with production
					// asn-features: TimeValue-token TimeValue

					s += "TimeValue_token";
					s += ' ';
					s += m_TimeValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_asn_features_60:
					// emit syntax tree node associated with production
					// asn-features: SubtypeElements-token SubtypeElements

					s += "SubtypeElements_token";
					s += ' ';
					s += m_SubtypeElements.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule asn-features

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule asn-features with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			asn_features.production_kind kind = (asn_features.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case asn_features.production_kind.g_asn_features_1:
					// traverse syntax tree node associated with production
					// asn-features: ModuleDefinitions-token ModuleDefinitions

						m_ModuleDefinitions_token.Visit (visitor, appData);
						m_ModuleDefinitions.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_2:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedType-token ParameterizedType

						m_ParameterizedType_token.Visit (visitor, appData);
						m_ParameterizedType.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_3:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedValue-token ParameterizedValue

						m_ParameterizedValue_token.Visit (visitor, appData);
						m_ParameterizedValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_4:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedValueSetType-token ParameterizedValueSetType

						m_ParameterizedValueSetType_token.Visit (visitor, appData);
						m_ParameterizedValueSetType.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_5:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedObjectClass-token ParameterizedObjectClass

						m_ParameterizedObjectClass_token.Visit (visitor, appData);
						m_ParameterizedObjectClass.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_6:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedObjectSet-token ParameterizedObjectSet

						m_ParameterizedObjectSet_token.Visit (visitor, appData);
						m_ParameterizedObjectSet.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_7:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedObject-token ParameterizedObject

						m_ParameterizedObject_token.Visit (visitor, appData);
						m_ParameterizedObject.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_8:
					// traverse syntax tree node associated with production
					// asn-features: AssignmentList-token AssignmentList

						m_AssignmentList_token.Visit (visitor, appData);
						m_AssignmentList.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_9:
					// traverse syntax tree node associated with production
					// asn-features: BuiltinValue-token BuiltinValue

						m_BuiltinValue_token.Visit (visitor, appData);
						m_BuiltinValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_10:
					// traverse syntax tree node associated with production
					// asn-features: TypeAssignment-token TypeAssignment

						m_TypeAssignment_token.Visit (visitor, appData);
						m_TypeAssignment.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_11:
					// traverse syntax tree node associated with production
					// asn-features: ValueAssignment-token ValueAssignment

						m_ValueAssignment_token.Visit (visitor, appData);
						m_ValueAssignment.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_12:
					// traverse syntax tree node associated with production
					// asn-features: ValueSetTypeAssignment-token ValueSetTypeAssignment

						m_ValueSetTypeAssignment_token.Visit (visitor, appData);
						m_ValueSetTypeAssignment.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_13:
					// traverse syntax tree node associated with production
					// asn-features: ObjectClassAssignment-token ObjectClassAssignment

						m_ObjectClassAssignment_token.Visit (visitor, appData);
						m_ObjectClassAssignment.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_14:
					// traverse syntax tree node associated with production
					// asn-features: ObjectAssignment-token ObjectAssignment

						m_ObjectAssignment_token.Visit (visitor, appData);
						m_ObjectAssignment.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_15:
					// traverse syntax tree node associated with production
					// asn-features: ObjectSetAssignment-token ObjectSetAssignment

						m_ObjectSetAssignment_token.Visit (visitor, appData);
						m_ObjectSetAssignment.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_16:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedTypeAssignment-token ParameterizedTypeAssignment

						m_ParameterizedTypeAssignment_token.Visit (visitor, appData);
						m_ParameterizedTypeAssignment.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_17:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedValueAssignment-token ParameterizedValueAssignment

						m_ParameterizedValueAssignment_token.Visit (visitor, appData);
						m_ParameterizedValueAssignment.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_18:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedValueSetTypeAssignment-token ParameterizedValueSetTypeAssignment

						m_ParameterizedValueSetTypeAssignment_token.Visit (visitor, appData);
						m_ParameterizedValueSetTypeAssignment.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_19:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedObjectClassAssignment-token ParameterizedObjectClassAssignment

						m_ParameterizedObjectClassAssignment_token.Visit (visitor, appData);
						m_ParameterizedObjectClassAssignment.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_20:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedObjectAssignment-token ParameterizedObjectAssignment

						m_ParameterizedObjectAssignment_token.Visit (visitor, appData);
						m_ParameterizedObjectAssignment.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_21:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedObjectSetAssignment-token ParameterizedObjectSetAssignment

						m_ParameterizedObjectSetAssignment_token.Visit (visitor, appData);
						m_ParameterizedObjectSetAssignment.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_22:
					// traverse syntax tree node associated with production
					// asn-features: DefaultSyntax-token DefaultSyntax

						m_DefaultSyntax_token.Visit (visitor, appData);
						m_DefaultSyntax.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_23:
					// traverse syntax tree node associated with production
					// asn-features: TypeFieldSpec-token TypeFieldSpec

						m_TypeFieldSpec_token.Visit (visitor, appData);
						m_TypeFieldSpec.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_24:
					// traverse syntax tree node associated with production
					// asn-features: FixedTypeValueFieldSpec-token FixedTypeValueFieldSpec

						m_FixedTypeValueFieldSpec_token.Visit (visitor, appData);
						m_FixedTypeValueFieldSpec.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_25:
					// traverse syntax tree node associated with production
					// asn-features: VariableTypeValueFieldSpec-token VariableTypeValueFieldSpec

						m_VariableTypeValueFieldSpec_token.Visit (visitor, appData);
						m_VariableTypeValueFieldSpec.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_26:
					// traverse syntax tree node associated with production
					// asn-features: FixedTypeValueSetFieldSpec-token FixedTypeValueSetFieldSpec

						m_FixedTypeValueSetFieldSpec_token.Visit (visitor, appData);
						m_FixedTypeValueSetFieldSpec.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_27:
					// traverse syntax tree node associated with production
					// asn-features: VariableTypeValueSetFieldSpec-token VariableTypeValueSetFieldSpec

						m_VariableTypeValueSetFieldSpec_token.Visit (visitor, appData);
						m_VariableTypeValueSetFieldSpec.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_28:
					// traverse syntax tree node associated with production
					// asn-features: ObjectFieldSpec-token ObjectFieldSpec

						m_ObjectFieldSpec_token.Visit (visitor, appData);
						m_ObjectFieldSpec.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_29:
					// traverse syntax tree node associated with production
					// asn-features: ObjectSetFieldSpec-token ObjectSetFieldSpec

						m_ObjectSetFieldSpec_token.Visit (visitor, appData);
						m_ObjectSetFieldSpec.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_30:
					// traverse syntax tree node associated with production
					// asn-features: DefinedType-token DefinedType

						m_DefinedType_token.Visit (visitor, appData);
						m_DefinedType.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_31:
					// traverse syntax tree node associated with production
					// asn-features: DefinedValue-token DefinedValue

						m_DefinedValue_token.Visit (visitor, appData);
						m_DefinedValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_32:
					// traverse syntax tree node associated with production
					// asn-features: ObjectClass-token ObjectClass

						m_ObjectClass_token.Visit (visitor, appData);
						m_ObjectClass.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_33:
					// traverse syntax tree node associated with production
					// asn-features: ObjectSetElements-token ObjectSetElements

						m_ObjectSetElements_token.Visit (visitor, appData);
						m_ObjectSetElements.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_34:
					// traverse syntax tree node associated with production
					// asn-features: Object-token Object

						m_Object_token.Visit (visitor, appData);
						m_Object.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_35:
					// traverse syntax tree node associated with production
					// asn-features: ObjectSet-token ObjectSet

						m_ObjectSet_token.Visit (visitor, appData);
						m_ObjectSet.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_36:
					// traverse syntax tree node associated with production
					// asn-features: ReferencedValue-token ReferencedValue

						m_ReferencedValue_token.Visit (visitor, appData);
						m_ReferencedValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_37:
					// traverse syntax tree node associated with production
					// asn-features: Type-token Type

						m_Type_token.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_38:
					// traverse syntax tree node associated with production
					// asn-features: Value-token Value

						m_Value_token.Visit (visitor, appData);
						m_Value.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_39:
					// traverse syntax tree node associated with production
					// asn-features: ValueSet-token ValueSet

						m_ValueSet_token.Visit (visitor, appData);
						m_ValueSet.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_40:
					// traverse syntax tree node associated with production
					// asn-features: BitStringValue-token BitStringValue

						m_BitStringValue_token.Visit (visitor, appData);
						m_BitStringValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_41:
					// traverse syntax tree node associated with production
					// asn-features: BooleanValue-token BooleanValue

						m_BooleanValue_token.Visit (visitor, appData);
						m_BooleanValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_42:
					// traverse syntax tree node associated with production
					// asn-features: CharacterStringValue-token CharacterStringValue

						m_CharacterStringValue_token.Visit (visitor, appData);
						m_CharacterStringValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_43:
					// traverse syntax tree node associated with production
					// asn-features: ChoiceValue-token ChoiceValue

						m_ChoiceValue_token.Visit (visitor, appData);
						m_ChoiceValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_44:
					// traverse syntax tree node associated with production
					// asn-features: EmbeddedPDVValue-token EmbeddedPDVValue

						m_EmbeddedPDVValue_token.Visit (visitor, appData);
						m_EmbeddedPDVValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_45:
					// traverse syntax tree node associated with production
					// asn-features: EnumeratedValue-token EnumeratedValue

						m_EnumeratedValue_token.Visit (visitor, appData);
						m_EnumeratedValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_46:
					// traverse syntax tree node associated with production
					// asn-features: ExternalValue-token ExternalValue

						m_ExternalValue_token.Visit (visitor, appData);
						m_ExternalValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_47:
					// traverse syntax tree node associated with production
					// asn-features: IntegerValue-token IntegerValue

						m_IntegerValue_token.Visit (visitor, appData);
						m_IntegerValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_48:
					// traverse syntax tree node associated with production
					// asn-features: IRIValue-token IRIValue

						m_IRIValue_token.Visit (visitor, appData);
						m_IRIValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_49:
					// traverse syntax tree node associated with production
					// asn-features: NullValue-token NullValue

						m_NullValue_token.Visit (visitor, appData);
						m_NullValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_50:
					// traverse syntax tree node associated with production
					// asn-features: ObjectIdentifierValue-token ObjectIdentifierValue

						m_ObjectIdentifierValue_token.Visit (visitor, appData);
						m_ObjectIdentifierValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_51:
					// traverse syntax tree node associated with production
					// asn-features: OctetStringValue-token OctetStringValue

						m_OctetStringValue_token.Visit (visitor, appData);
						m_OctetStringValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_52:
					// traverse syntax tree node associated with production
					// asn-features: RealValue-token RealValue

						m_RealValue_token.Visit (visitor, appData);
						m_RealValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_53:
					// traverse syntax tree node associated with production
					// asn-features: RelativeIRIValue-token RelativeIRIValue

						m_RelativeIRIValue_token.Visit (visitor, appData);
						m_RelativeIRIValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_54:
					// traverse syntax tree node associated with production
					// asn-features: RelativeOIDValue-token RelativeOIDValue

						m_RelativeOIDValue_token.Visit (visitor, appData);
						m_RelativeOIDValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_55:
					// traverse syntax tree node associated with production
					// asn-features: SequenceValue-token SequenceValue

						m_SequenceValue_token.Visit (visitor, appData);
						m_SequenceValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_56:
					// traverse syntax tree node associated with production
					// asn-features: SequenceOfValue-token SequenceOfValue

						m_SequenceOfValue_token.Visit (visitor, appData);
						m_SequenceOfValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_57:
					// traverse syntax tree node associated with production
					// asn-features: SetValue-token SetValue

						m_SetValue_token.Visit (visitor, appData);
						m_SetValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_58:
					// traverse syntax tree node associated with production
					// asn-features: SetOfValue-token SetOfValue

						m_SetOfValue_token.Visit (visitor, appData);
						m_SetOfValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_59:
					// traverse syntax tree node associated with production
					// asn-features: TimeValue-token TimeValue

						m_TimeValue_token.Visit (visitor, appData);
						m_TimeValue.Visit (visitor, appData);
				break;
				case asn_features.production_kind.g_asn_features_60:
					// traverse syntax tree node associated with production
					// asn-features: SubtypeElements-token SubtypeElements

						m_SubtypeElements_token.Visit (visitor, appData);
						m_SubtypeElements.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ModuleDefinitions_token?.reparent (this);
			m_ModuleDefinitions?.reparent (this);
			m_ParameterizedType_token?.reparent (this);
			m_ParameterizedType?.reparent (this);
			m_ParameterizedValue_token?.reparent (this);
			m_ParameterizedValue?.reparent (this);
			m_ParameterizedValueSetType_token?.reparent (this);
			m_ParameterizedValueSetType?.reparent (this);
			m_ParameterizedObjectClass_token?.reparent (this);
			m_ParameterizedObjectClass?.reparent (this);
			m_ParameterizedObjectSet_token?.reparent (this);
			m_ParameterizedObjectSet?.reparent (this);
			m_ParameterizedObject_token?.reparent (this);
			m_ParameterizedObject?.reparent (this);
			m_AssignmentList_token?.reparent (this);
			m_AssignmentList?.reparent (this);
			m_BuiltinValue_token?.reparent (this);
			m_BuiltinValue?.reparent (this);
			m_TypeAssignment_token?.reparent (this);
			m_TypeAssignment?.reparent (this);
			m_ValueAssignment_token?.reparent (this);
			m_ValueAssignment?.reparent (this);
			m_ValueSetTypeAssignment_token?.reparent (this);
			m_ValueSetTypeAssignment?.reparent (this);
			m_ObjectClassAssignment_token?.reparent (this);
			m_ObjectClassAssignment?.reparent (this);
			m_ObjectAssignment_token?.reparent (this);
			m_ObjectAssignment?.reparent (this);
			m_ObjectSetAssignment_token?.reparent (this);
			m_ObjectSetAssignment?.reparent (this);
			m_ParameterizedTypeAssignment_token?.reparent (this);
			m_ParameterizedTypeAssignment?.reparent (this);
			m_ParameterizedValueAssignment_token?.reparent (this);
			m_ParameterizedValueAssignment?.reparent (this);
			m_ParameterizedValueSetTypeAssignment_token?.reparent (this);
			m_ParameterizedValueSetTypeAssignment?.reparent (this);
			m_ParameterizedObjectClassAssignment_token?.reparent (this);
			m_ParameterizedObjectClassAssignment?.reparent (this);
			m_ParameterizedObjectAssignment_token?.reparent (this);
			m_ParameterizedObjectAssignment?.reparent (this);
			m_ParameterizedObjectSetAssignment_token?.reparent (this);
			m_ParameterizedObjectSetAssignment?.reparent (this);
			m_DefaultSyntax_token?.reparent (this);
			m_DefaultSyntax?.reparent (this);
			m_TypeFieldSpec_token?.reparent (this);
			m_TypeFieldSpec?.reparent (this);
			m_FixedTypeValueFieldSpec_token?.reparent (this);
			m_FixedTypeValueFieldSpec?.reparent (this);
			m_VariableTypeValueFieldSpec_token?.reparent (this);
			m_VariableTypeValueFieldSpec?.reparent (this);
			m_FixedTypeValueSetFieldSpec_token?.reparent (this);
			m_FixedTypeValueSetFieldSpec?.reparent (this);
			m_VariableTypeValueSetFieldSpec_token?.reparent (this);
			m_VariableTypeValueSetFieldSpec?.reparent (this);
			m_ObjectFieldSpec_token?.reparent (this);
			m_ObjectFieldSpec?.reparent (this);
			m_ObjectSetFieldSpec_token?.reparent (this);
			m_ObjectSetFieldSpec?.reparent (this);
			m_DefinedType_token?.reparent (this);
			m_DefinedType?.reparent (this);
			m_DefinedValue_token?.reparent (this);
			m_DefinedValue?.reparent (this);
			m_ObjectClass_token?.reparent (this);
			m_ObjectClass?.reparent (this);
			m_ObjectSetElements_token?.reparent (this);
			m_ObjectSetElements?.reparent (this);
			m_Object_token?.reparent (this);
			m_Object?.reparent (this);
			m_ObjectSet_token?.reparent (this);
			m_ObjectSet?.reparent (this);
			m_ReferencedValue_token?.reparent (this);
			m_ReferencedValue?.reparent (this);
			m_Type_token?.reparent (this);
			m_Type?.reparent (this);
			m_Value_token?.reparent (this);
			m_Value?.reparent (this);
			m_ValueSet_token?.reparent (this);
			m_ValueSet?.reparent (this);
			m_BitStringValue_token?.reparent (this);
			m_BitStringValue?.reparent (this);
			m_BooleanValue_token?.reparent (this);
			m_BooleanValue?.reparent (this);
			m_CharacterStringValue_token?.reparent (this);
			m_CharacterStringValue?.reparent (this);
			m_ChoiceValue_token?.reparent (this);
			m_ChoiceValue?.reparent (this);
			m_EmbeddedPDVValue_token?.reparent (this);
			m_EmbeddedPDVValue?.reparent (this);
			m_EnumeratedValue_token?.reparent (this);
			m_EnumeratedValue?.reparent (this);
			m_ExternalValue_token?.reparent (this);
			m_ExternalValue?.reparent (this);
			m_IntegerValue_token?.reparent (this);
			m_IntegerValue?.reparent (this);
			m_IRIValue_token?.reparent (this);
			m_IRIValue?.reparent (this);
			m_NullValue_token?.reparent (this);
			m_NullValue?.reparent (this);
			m_ObjectIdentifierValue_token?.reparent (this);
			m_ObjectIdentifierValue?.reparent (this);
			m_OctetStringValue_token?.reparent (this);
			m_OctetStringValue?.reparent (this);
			m_RealValue_token?.reparent (this);
			m_RealValue?.reparent (this);
			m_RelativeIRIValue_token?.reparent (this);
			m_RelativeIRIValue?.reparent (this);
			m_RelativeOIDValue_token?.reparent (this);
			m_RelativeOIDValue?.reparent (this);
			m_SequenceValue_token?.reparent (this);
			m_SequenceValue?.reparent (this);
			m_SequenceOfValue_token?.reparent (this);
			m_SequenceOfValue?.reparent (this);
			m_SetValue_token?.reparent (this);
			m_SetValue?.reparent (this);
			m_SetOfValue_token?.reparent (this);
			m_SetOfValue?.reparent (this);
			m_TimeValue_token?.reparent (this);
			m_TimeValue?.reparent (this);
			m_SubtypeElements_token?.reparent (this);
			m_SubtypeElements?.reparent (this);
		}

		//
		// initialize object associated with syntax rule asn-features
		//

		public void _init ()
		{
			m_ModuleDefinitions_token = null;
			m_ModuleDefinitions = null;
			m_ParameterizedType_token = null;
			m_ParameterizedType = null;
			m_ParameterizedValue_token = null;
			m_ParameterizedValue = null;
			m_ParameterizedValueSetType_token = null;
			m_ParameterizedValueSetType = null;
			m_ParameterizedObjectClass_token = null;
			m_ParameterizedObjectClass = null;
			m_ParameterizedObjectSet_token = null;
			m_ParameterizedObjectSet = null;
			m_ParameterizedObject_token = null;
			m_ParameterizedObject = null;
			m_AssignmentList_token = null;
			m_AssignmentList = null;
			m_BuiltinValue_token = null;
			m_BuiltinValue = null;
			m_TypeAssignment_token = null;
			m_TypeAssignment = null;
			m_ValueAssignment_token = null;
			m_ValueAssignment = null;
			m_ValueSetTypeAssignment_token = null;
			m_ValueSetTypeAssignment = null;
			m_ObjectClassAssignment_token = null;
			m_ObjectClassAssignment = null;
			m_ObjectAssignment_token = null;
			m_ObjectAssignment = null;
			m_ObjectSetAssignment_token = null;
			m_ObjectSetAssignment = null;
			m_ParameterizedTypeAssignment_token = null;
			m_ParameterizedTypeAssignment = null;
			m_ParameterizedValueAssignment_token = null;
			m_ParameterizedValueAssignment = null;
			m_ParameterizedValueSetTypeAssignment_token = null;
			m_ParameterizedValueSetTypeAssignment = null;
			m_ParameterizedObjectClassAssignment_token = null;
			m_ParameterizedObjectClassAssignment = null;
			m_ParameterizedObjectAssignment_token = null;
			m_ParameterizedObjectAssignment = null;
			m_ParameterizedObjectSetAssignment_token = null;
			m_ParameterizedObjectSetAssignment = null;
			m_DefaultSyntax_token = null;
			m_DefaultSyntax = null;
			m_TypeFieldSpec_token = null;
			m_TypeFieldSpec = null;
			m_FixedTypeValueFieldSpec_token = null;
			m_FixedTypeValueFieldSpec = null;
			m_VariableTypeValueFieldSpec_token = null;
			m_VariableTypeValueFieldSpec = null;
			m_FixedTypeValueSetFieldSpec_token = null;
			m_FixedTypeValueSetFieldSpec = null;
			m_VariableTypeValueSetFieldSpec_token = null;
			m_VariableTypeValueSetFieldSpec = null;
			m_ObjectFieldSpec_token = null;
			m_ObjectFieldSpec = null;
			m_ObjectSetFieldSpec_token = null;
			m_ObjectSetFieldSpec = null;
			m_DefinedType_token = null;
			m_DefinedType = null;
			m_DefinedValue_token = null;
			m_DefinedValue = null;
			m_ObjectClass_token = null;
			m_ObjectClass = null;
			m_ObjectSetElements_token = null;
			m_ObjectSetElements = null;
			m_Object_token = null;
			m_Object = null;
			m_ObjectSet_token = null;
			m_ObjectSet = null;
			m_ReferencedValue_token = null;
			m_ReferencedValue = null;
			m_Type_token = null;
			m_Type = null;
			m_Value_token = null;
			m_Value = null;
			m_ValueSet_token = null;
			m_ValueSet = null;
			m_BitStringValue_token = null;
			m_BitStringValue = null;
			m_BooleanValue_token = null;
			m_BooleanValue = null;
			m_CharacterStringValue_token = null;
			m_CharacterStringValue = null;
			m_ChoiceValue_token = null;
			m_ChoiceValue = null;
			m_EmbeddedPDVValue_token = null;
			m_EmbeddedPDVValue = null;
			m_EnumeratedValue_token = null;
			m_EnumeratedValue = null;
			m_ExternalValue_token = null;
			m_ExternalValue = null;
			m_IntegerValue_token = null;
			m_IntegerValue = null;
			m_IRIValue_token = null;
			m_IRIValue = null;
			m_NullValue_token = null;
			m_NullValue = null;
			m_ObjectIdentifierValue_token = null;
			m_ObjectIdentifierValue = null;
			m_OctetStringValue_token = null;
			m_OctetStringValue = null;
			m_RealValue_token = null;
			m_RealValue = null;
			m_RelativeIRIValue_token = null;
			m_RelativeIRIValue = null;
			m_RelativeOIDValue_token = null;
			m_RelativeOIDValue = null;
			m_SequenceValue_token = null;
			m_SequenceValue = null;
			m_SequenceOfValue_token = null;
			m_SequenceOfValue = null;
			m_SetValue_token = null;
			m_SetValue = null;
			m_SetOfValue_token = null;
			m_SetOfValue = null;
			m_TimeValue_token = null;
			m_TimeValue = null;
			m_SubtypeElements_token = null;
			m_SubtypeElements = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule asn-features

		// counter of all nodes associated with syntax rule asn-features
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule asn-features
		[DataMember (Name = "m_ModuleDefinitions_token")] public SyntaxTreeToken m_ModuleDefinitions_token { get; private set; }
		[DataMember (Name = "m_ModuleDefinitions")] public ModuleDefinitions m_ModuleDefinitions { get; private set; }
		[DataMember (Name = "m_ParameterizedType_token")] public SyntaxTreeToken m_ParameterizedType_token { get; private set; }
		[DataMember (Name = "m_ParameterizedType")] public ParameterizedType m_ParameterizedType { get; private set; }
		[DataMember (Name = "m_ParameterizedValue_token")] public SyntaxTreeToken m_ParameterizedValue_token { get; private set; }
		[DataMember (Name = "m_ParameterizedValue")] public ParameterizedValue m_ParameterizedValue { get; private set; }
		[DataMember (Name = "m_ParameterizedValueSetType_token")] public SyntaxTreeToken m_ParameterizedValueSetType_token { get; private set; }
		[DataMember (Name = "m_ParameterizedValueSetType")] public ParameterizedValueSetType m_ParameterizedValueSetType { get; private set; }
		[DataMember (Name = "m_ParameterizedObjectClass_token")] public SyntaxTreeToken m_ParameterizedObjectClass_token { get; private set; }
		[DataMember (Name = "m_ParameterizedObjectClass")] public ParameterizedObjectClass m_ParameterizedObjectClass { get; private set; }
		[DataMember (Name = "m_ParameterizedObjectSet_token")] public SyntaxTreeToken m_ParameterizedObjectSet_token { get; private set; }
		[DataMember (Name = "m_ParameterizedObjectSet")] public ParameterizedObjectSet m_ParameterizedObjectSet { get; private set; }
		[DataMember (Name = "m_ParameterizedObject_token")] public SyntaxTreeToken m_ParameterizedObject_token { get; private set; }
		[DataMember (Name = "m_ParameterizedObject")] public ParameterizedObject m_ParameterizedObject { get; private set; }
		[DataMember (Name = "m_AssignmentList_token")] public SyntaxTreeToken m_AssignmentList_token { get; private set; }
		[DataMember (Name = "m_AssignmentList")] public AssignmentList m_AssignmentList { get; private set; }
		[DataMember (Name = "m_BuiltinValue_token")] public SyntaxTreeToken m_BuiltinValue_token { get; private set; }
		[DataMember (Name = "m_BuiltinValue")] public BuiltinValue m_BuiltinValue { get; private set; }
		[DataMember (Name = "m_TypeAssignment_token")] public SyntaxTreeToken m_TypeAssignment_token { get; private set; }
		[DataMember (Name = "m_TypeAssignment")] public TypeAssignment m_TypeAssignment { get; private set; }
		[DataMember (Name = "m_ValueAssignment_token")] public SyntaxTreeToken m_ValueAssignment_token { get; private set; }
		[DataMember (Name = "m_ValueAssignment")] public ValueAssignment m_ValueAssignment { get; private set; }
		[DataMember (Name = "m_ValueSetTypeAssignment_token")] public SyntaxTreeToken m_ValueSetTypeAssignment_token { get; private set; }
		[DataMember (Name = "m_ValueSetTypeAssignment")] public ValueSetTypeAssignment m_ValueSetTypeAssignment { get; private set; }
		[DataMember (Name = "m_ObjectClassAssignment_token")] public SyntaxTreeToken m_ObjectClassAssignment_token { get; private set; }
		[DataMember (Name = "m_ObjectClassAssignment")] public ObjectClassAssignment m_ObjectClassAssignment { get; private set; }
		[DataMember (Name = "m_ObjectAssignment_token")] public SyntaxTreeToken m_ObjectAssignment_token { get; private set; }
		[DataMember (Name = "m_ObjectAssignment")] public ObjectAssignment m_ObjectAssignment { get; private set; }
		[DataMember (Name = "m_ObjectSetAssignment_token")] public SyntaxTreeToken m_ObjectSetAssignment_token { get; private set; }
		[DataMember (Name = "m_ObjectSetAssignment")] public ObjectSetAssignment m_ObjectSetAssignment { get; private set; }
		[DataMember (Name = "m_ParameterizedTypeAssignment_token")] public SyntaxTreeToken m_ParameterizedTypeAssignment_token { get; private set; }
		[DataMember (Name = "m_ParameterizedTypeAssignment")] public ParameterizedTypeAssignment m_ParameterizedTypeAssignment { get; private set; }
		[DataMember (Name = "m_ParameterizedValueAssignment_token")] public SyntaxTreeToken m_ParameterizedValueAssignment_token { get; private set; }
		[DataMember (Name = "m_ParameterizedValueAssignment")] public ParameterizedValueAssignment m_ParameterizedValueAssignment { get; private set; }
		[DataMember (Name = "m_ParameterizedValueSetTypeAssignment_token")] public SyntaxTreeToken m_ParameterizedValueSetTypeAssignment_token { get; private set; }
		[DataMember (Name = "m_ParameterizedValueSetTypeAssignment")] public ParameterizedValueSetTypeAssignment m_ParameterizedValueSetTypeAssignment { get; private set; }
		[DataMember (Name = "m_ParameterizedObjectClassAssignment_token")] public SyntaxTreeToken m_ParameterizedObjectClassAssignment_token { get; private set; }
		[DataMember (Name = "m_ParameterizedObjectClassAssignment")] public ParameterizedObjectClassAssignment m_ParameterizedObjectClassAssignment { get; private set; }
		[DataMember (Name = "m_ParameterizedObjectAssignment_token")] public SyntaxTreeToken m_ParameterizedObjectAssignment_token { get; private set; }
		[DataMember (Name = "m_ParameterizedObjectAssignment")] public ParameterizedObjectAssignment m_ParameterizedObjectAssignment { get; private set; }
		[DataMember (Name = "m_ParameterizedObjectSetAssignment_token")] public SyntaxTreeToken m_ParameterizedObjectSetAssignment_token { get; private set; }
		[DataMember (Name = "m_ParameterizedObjectSetAssignment")] public ParameterizedObjectSetAssignment m_ParameterizedObjectSetAssignment { get; private set; }
		[DataMember (Name = "m_DefaultSyntax_token")] public SyntaxTreeToken m_DefaultSyntax_token { get; private set; }
		[DataMember (Name = "m_DefaultSyntax")] public DefaultSyntax m_DefaultSyntax { get; private set; }
		[DataMember (Name = "m_TypeFieldSpec_token")] public SyntaxTreeToken m_TypeFieldSpec_token { get; private set; }
		[DataMember (Name = "m_TypeFieldSpec")] public TypeFieldSpec m_TypeFieldSpec { get; private set; }
		[DataMember (Name = "m_FixedTypeValueFieldSpec_token")] public SyntaxTreeToken m_FixedTypeValueFieldSpec_token { get; private set; }
		[DataMember (Name = "m_FixedTypeValueFieldSpec")] public FixedTypeValueFieldSpec m_FixedTypeValueFieldSpec { get; private set; }
		[DataMember (Name = "m_VariableTypeValueFieldSpec_token")] public SyntaxTreeToken m_VariableTypeValueFieldSpec_token { get; private set; }
		[DataMember (Name = "m_VariableTypeValueFieldSpec")] public VariableTypeValueFieldSpec m_VariableTypeValueFieldSpec { get; private set; }
		[DataMember (Name = "m_FixedTypeValueSetFieldSpec_token")] public SyntaxTreeToken m_FixedTypeValueSetFieldSpec_token { get; private set; }
		[DataMember (Name = "m_FixedTypeValueSetFieldSpec")] public FixedTypeValueSetFieldSpec m_FixedTypeValueSetFieldSpec { get; private set; }
		[DataMember (Name = "m_VariableTypeValueSetFieldSpec_token")] public SyntaxTreeToken m_VariableTypeValueSetFieldSpec_token { get; private set; }
		[DataMember (Name = "m_VariableTypeValueSetFieldSpec")] public VariableTypeValueSetFieldSpec m_VariableTypeValueSetFieldSpec { get; private set; }
		[DataMember (Name = "m_ObjectFieldSpec_token")] public SyntaxTreeToken m_ObjectFieldSpec_token { get; private set; }
		[DataMember (Name = "m_ObjectFieldSpec")] public ObjectFieldSpec m_ObjectFieldSpec { get; private set; }
		[DataMember (Name = "m_ObjectSetFieldSpec_token")] public SyntaxTreeToken m_ObjectSetFieldSpec_token { get; private set; }
		[DataMember (Name = "m_ObjectSetFieldSpec")] public ObjectSetFieldSpec m_ObjectSetFieldSpec { get; private set; }
		[DataMember (Name = "m_DefinedType_token")] public SyntaxTreeToken m_DefinedType_token { get; private set; }
		[DataMember (Name = "m_DefinedType")] public DefinedType m_DefinedType { get; private set; }
		[DataMember (Name = "m_DefinedValue_token")] public SyntaxTreeToken m_DefinedValue_token { get; private set; }
		[DataMember (Name = "m_DefinedValue")] public DefinedValue m_DefinedValue { get; private set; }
		[DataMember (Name = "m_ObjectClass_token")] public SyntaxTreeToken m_ObjectClass_token { get; private set; }
		[DataMember (Name = "m_ObjectClass")] public ObjectClass m_ObjectClass { get; private set; }
		[DataMember (Name = "m_ObjectSetElements_token")] public SyntaxTreeToken m_ObjectSetElements_token { get; private set; }
		[DataMember (Name = "m_ObjectSetElements")] public ObjectSetElements m_ObjectSetElements { get; private set; }
		[DataMember (Name = "m_Object_token")] public SyntaxTreeToken m_Object_token { get; private set; }
		[DataMember (Name = "m_Object")] public Object m_Object { get; private set; }
		[DataMember (Name = "m_ObjectSet_token")] public SyntaxTreeToken m_ObjectSet_token { get; private set; }
		[DataMember (Name = "m_ObjectSet")] public ObjectSet m_ObjectSet { get; private set; }
		[DataMember (Name = "m_ReferencedValue_token")] public SyntaxTreeToken m_ReferencedValue_token { get; private set; }
		[DataMember (Name = "m_ReferencedValue")] public ReferencedValue m_ReferencedValue { get; private set; }
		[DataMember (Name = "m_Type_token")] public SyntaxTreeToken m_Type_token { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_Value_token")] public SyntaxTreeToken m_Value_token { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		[DataMember (Name = "m_ValueSet_token")] public SyntaxTreeToken m_ValueSet_token { get; private set; }
		[DataMember (Name = "m_ValueSet")] public ValueSet m_ValueSet { get; private set; }
		[DataMember (Name = "m_BitStringValue_token")] public SyntaxTreeToken m_BitStringValue_token { get; private set; }
		[DataMember (Name = "m_BitStringValue")] public BitStringValue m_BitStringValue { get; private set; }
		[DataMember (Name = "m_BooleanValue_token")] public SyntaxTreeToken m_BooleanValue_token { get; private set; }
		[DataMember (Name = "m_BooleanValue")] public BooleanValue m_BooleanValue { get; private set; }
		[DataMember (Name = "m_CharacterStringValue_token")] public SyntaxTreeToken m_CharacterStringValue_token { get; private set; }
		[DataMember (Name = "m_CharacterStringValue")] public CharacterStringValue m_CharacterStringValue { get; private set; }
		[DataMember (Name = "m_ChoiceValue_token")] public SyntaxTreeToken m_ChoiceValue_token { get; private set; }
		[DataMember (Name = "m_ChoiceValue")] public ChoiceValue m_ChoiceValue { get; private set; }
		[DataMember (Name = "m_EmbeddedPDVValue_token")] public SyntaxTreeToken m_EmbeddedPDVValue_token { get; private set; }
		[DataMember (Name = "m_EmbeddedPDVValue")] public EmbeddedPDVValue m_EmbeddedPDVValue { get; private set; }
		[DataMember (Name = "m_EnumeratedValue_token")] public SyntaxTreeToken m_EnumeratedValue_token { get; private set; }
		[DataMember (Name = "m_EnumeratedValue")] public EnumeratedValue m_EnumeratedValue { get; private set; }
		[DataMember (Name = "m_ExternalValue_token")] public SyntaxTreeToken m_ExternalValue_token { get; private set; }
		[DataMember (Name = "m_ExternalValue")] public ExternalValue m_ExternalValue { get; private set; }
		[DataMember (Name = "m_IntegerValue_token")] public SyntaxTreeToken m_IntegerValue_token { get; private set; }
		[DataMember (Name = "m_IntegerValue")] public IntegerValue m_IntegerValue { get; private set; }
		[DataMember (Name = "m_IRIValue_token")] public SyntaxTreeToken m_IRIValue_token { get; private set; }
		[DataMember (Name = "m_IRIValue")] public IRIValue m_IRIValue { get; private set; }
		[DataMember (Name = "m_NullValue_token")] public SyntaxTreeToken m_NullValue_token { get; private set; }
		[DataMember (Name = "m_NullValue")] public NullValue m_NullValue { get; private set; }
		[DataMember (Name = "m_ObjectIdentifierValue_token")] public SyntaxTreeToken m_ObjectIdentifierValue_token { get; private set; }
		[DataMember (Name = "m_ObjectIdentifierValue")] public ObjectIdentifierValue m_ObjectIdentifierValue { get; private set; }
		[DataMember (Name = "m_OctetStringValue_token")] public SyntaxTreeToken m_OctetStringValue_token { get; private set; }
		[DataMember (Name = "m_OctetStringValue")] public OctetStringValue m_OctetStringValue { get; private set; }
		[DataMember (Name = "m_RealValue_token")] public SyntaxTreeToken m_RealValue_token { get; private set; }
		[DataMember (Name = "m_RealValue")] public RealValue m_RealValue { get; private set; }
		[DataMember (Name = "m_RelativeIRIValue_token")] public SyntaxTreeToken m_RelativeIRIValue_token { get; private set; }
		[DataMember (Name = "m_RelativeIRIValue")] public RelativeIRIValue m_RelativeIRIValue { get; private set; }
		[DataMember (Name = "m_RelativeOIDValue_token")] public SyntaxTreeToken m_RelativeOIDValue_token { get; private set; }
		[DataMember (Name = "m_RelativeOIDValue")] public RelativeOIDValue m_RelativeOIDValue { get; private set; }
		[DataMember (Name = "m_SequenceValue_token")] public SyntaxTreeToken m_SequenceValue_token { get; private set; }
		[DataMember (Name = "m_SequenceValue")] public SequenceValue m_SequenceValue { get; private set; }
		[DataMember (Name = "m_SequenceOfValue_token")] public SyntaxTreeToken m_SequenceOfValue_token { get; private set; }
		[DataMember (Name = "m_SequenceOfValue")] public SequenceOfValue m_SequenceOfValue { get; private set; }
		[DataMember (Name = "m_SetValue_token")] public SyntaxTreeToken m_SetValue_token { get; private set; }
		[DataMember (Name = "m_SetValue")] public SetValue m_SetValue { get; private set; }
		[DataMember (Name = "m_SetOfValue_token")] public SyntaxTreeToken m_SetOfValue_token { get; private set; }
		[DataMember (Name = "m_SetOfValue")] public SetOfValue m_SetOfValue { get; private set; }
		[DataMember (Name = "m_TimeValue_token")] public SyntaxTreeToken m_TimeValue_token { get; private set; }
		[DataMember (Name = "m_TimeValue")] public TimeValue m_TimeValue { get; private set; }
		[DataMember (Name = "m_SubtypeElements_token")] public SyntaxTreeToken m_SubtypeElements_token { get; private set; }
		[DataMember (Name = "m_SubtypeElements")] public SubtypeElements m_SubtypeElements { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule asn-features

		// delegate function (callback) prototype associated with syntax rule asn-features
		public delegate bool asn_features_Callback (SyntaxTreeCallbackReason reason, asn_features.production_kind kind, asn_features p_asn_features);

		// event associated with syntax rule asn-features
		public event asn_features_Callback asn_features_Event;

		// event trigger associated with syntax rule asn-features
		public bool Raise_asn_features_Event (SyntaxTreeCallbackReason reason, asn_features.production_kind kind, asn_features p_asn_features)
		{
			bool? status = asn_features_Event?.Invoke (reason, kind, p_asn_features);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule asn-features
		//
		// traverse syntax tree node associated with any production of syntax rule asn-features
		//

		public void Traverse (asn_features p_asn_features)
		{
			if (p_asn_features.isLocked())
				return;
			p_asn_features.dolock();
			asn_features.production_kind kind = (asn_features.production_kind) p_asn_features.kind;
			p_asn_features.turn_reset ();
			if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_asn_features))
			switch (kind)
			{
				case asn_features.production_kind.g_asn_features_1:
					// traverse syntax tree node associated with production
					// asn-features: ModuleDefinitions-token ModuleDefinitions

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ModuleDefinitions);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_2:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedType-token ParameterizedType

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ParameterizedType);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_3:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedValue-token ParameterizedValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ParameterizedValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_4:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedValueSetType-token ParameterizedValueSetType

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ParameterizedValueSetType);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_5:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedObjectClass-token ParameterizedObjectClass

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ParameterizedObjectClass);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_6:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedObjectSet-token ParameterizedObjectSet

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ParameterizedObjectSet);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_7:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedObject-token ParameterizedObject

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ParameterizedObject);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_8:
					// traverse syntax tree node associated with production
					// asn-features: AssignmentList-token AssignmentList

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_AssignmentList);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_9:
					// traverse syntax tree node associated with production
					// asn-features: BuiltinValue-token BuiltinValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_BuiltinValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_10:
					// traverse syntax tree node associated with production
					// asn-features: TypeAssignment-token TypeAssignment

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_TypeAssignment);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_11:
					// traverse syntax tree node associated with production
					// asn-features: ValueAssignment-token ValueAssignment

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ValueAssignment);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_12:
					// traverse syntax tree node associated with production
					// asn-features: ValueSetTypeAssignment-token ValueSetTypeAssignment

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ValueSetTypeAssignment);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_13:
					// traverse syntax tree node associated with production
					// asn-features: ObjectClassAssignment-token ObjectClassAssignment

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ObjectClassAssignment);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_14:
					// traverse syntax tree node associated with production
					// asn-features: ObjectAssignment-token ObjectAssignment

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ObjectAssignment);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_15:
					// traverse syntax tree node associated with production
					// asn-features: ObjectSetAssignment-token ObjectSetAssignment

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ObjectSetAssignment);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_16:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedTypeAssignment-token ParameterizedTypeAssignment

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ParameterizedTypeAssignment);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_17:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedValueAssignment-token ParameterizedValueAssignment

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ParameterizedValueAssignment);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_18:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedValueSetTypeAssignment-token ParameterizedValueSetTypeAssignment

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ParameterizedValueSetTypeAssignment);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_19:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedObjectClassAssignment-token ParameterizedObjectClassAssignment

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ParameterizedObjectClassAssignment);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_20:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedObjectAssignment-token ParameterizedObjectAssignment

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ParameterizedObjectAssignment);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_21:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedObjectSetAssignment-token ParameterizedObjectSetAssignment

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ParameterizedObjectSetAssignment);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_22:
					// traverse syntax tree node associated with production
					// asn-features: DefaultSyntax-token DefaultSyntax

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_DefaultSyntax);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_23:
					// traverse syntax tree node associated with production
					// asn-features: TypeFieldSpec-token TypeFieldSpec

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_TypeFieldSpec);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_24:
					// traverse syntax tree node associated with production
					// asn-features: FixedTypeValueFieldSpec-token FixedTypeValueFieldSpec

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_FixedTypeValueFieldSpec);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_25:
					// traverse syntax tree node associated with production
					// asn-features: VariableTypeValueFieldSpec-token VariableTypeValueFieldSpec

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_VariableTypeValueFieldSpec);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_26:
					// traverse syntax tree node associated with production
					// asn-features: FixedTypeValueSetFieldSpec-token FixedTypeValueSetFieldSpec

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_FixedTypeValueSetFieldSpec);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_27:
					// traverse syntax tree node associated with production
					// asn-features: VariableTypeValueSetFieldSpec-token VariableTypeValueSetFieldSpec

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_VariableTypeValueSetFieldSpec);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_28:
					// traverse syntax tree node associated with production
					// asn-features: ObjectFieldSpec-token ObjectFieldSpec

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ObjectFieldSpec);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_29:
					// traverse syntax tree node associated with production
					// asn-features: ObjectSetFieldSpec-token ObjectSetFieldSpec

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ObjectSetFieldSpec);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_30:
					// traverse syntax tree node associated with production
					// asn-features: DefinedType-token DefinedType

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_DefinedType);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_31:
					// traverse syntax tree node associated with production
					// asn-features: DefinedValue-token DefinedValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_DefinedValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_32:
					// traverse syntax tree node associated with production
					// asn-features: ObjectClass-token ObjectClass

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ObjectClass);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_33:
					// traverse syntax tree node associated with production
					// asn-features: ObjectSetElements-token ObjectSetElements

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ObjectSetElements);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_34:
					// traverse syntax tree node associated with production
					// asn-features: Object-token Object

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_Object);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_35:
					// traverse syntax tree node associated with production
					// asn-features: ObjectSet-token ObjectSet

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ObjectSet);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_36:
					// traverse syntax tree node associated with production
					// asn-features: ReferencedValue-token ReferencedValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ReferencedValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_37:
					// traverse syntax tree node associated with production
					// asn-features: Type-token Type

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_Type);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_38:
					// traverse syntax tree node associated with production
					// asn-features: Value-token Value

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_Value);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_39:
					// traverse syntax tree node associated with production
					// asn-features: ValueSet-token ValueSet

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ValueSet);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_40:
					// traverse syntax tree node associated with production
					// asn-features: BitStringValue-token BitStringValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_BitStringValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_41:
					// traverse syntax tree node associated with production
					// asn-features: BooleanValue-token BooleanValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_BooleanValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_42:
					// traverse syntax tree node associated with production
					// asn-features: CharacterStringValue-token CharacterStringValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_CharacterStringValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_43:
					// traverse syntax tree node associated with production
					// asn-features: ChoiceValue-token ChoiceValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ChoiceValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_44:
					// traverse syntax tree node associated with production
					// asn-features: EmbeddedPDVValue-token EmbeddedPDVValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_EmbeddedPDVValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_45:
					// traverse syntax tree node associated with production
					// asn-features: EnumeratedValue-token EnumeratedValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_EnumeratedValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_46:
					// traverse syntax tree node associated with production
					// asn-features: ExternalValue-token ExternalValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ExternalValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_47:
					// traverse syntax tree node associated with production
					// asn-features: IntegerValue-token IntegerValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_IntegerValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_48:
					// traverse syntax tree node associated with production
					// asn-features: IRIValue-token IRIValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_IRIValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_49:
					// traverse syntax tree node associated with production
					// asn-features: NullValue-token NullValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_NullValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_50:
					// traverse syntax tree node associated with production
					// asn-features: ObjectIdentifierValue-token ObjectIdentifierValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_ObjectIdentifierValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_51:
					// traverse syntax tree node associated with production
					// asn-features: OctetStringValue-token OctetStringValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_OctetStringValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_52:
					// traverse syntax tree node associated with production
					// asn-features: RealValue-token RealValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_RealValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_53:
					// traverse syntax tree node associated with production
					// asn-features: RelativeIRIValue-token RelativeIRIValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_RelativeIRIValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_54:
					// traverse syntax tree node associated with production
					// asn-features: RelativeOIDValue-token RelativeOIDValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_RelativeOIDValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_55:
					// traverse syntax tree node associated with production
					// asn-features: SequenceValue-token SequenceValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_SequenceValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_56:
					// traverse syntax tree node associated with production
					// asn-features: SequenceOfValue-token SequenceOfValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_SequenceOfValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_57:
					// traverse syntax tree node associated with production
					// asn-features: SetValue-token SetValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_SetValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_58:
					// traverse syntax tree node associated with production
					// asn-features: SetOfValue-token SetOfValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_SetOfValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_59:
					// traverse syntax tree node associated with production
					// asn-features: TimeValue-token TimeValue

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_TimeValue);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
				case asn_features.production_kind.g_asn_features_60:
					// traverse syntax tree node associated with production
					// asn-features: SubtypeElements-token SubtypeElements

					if (Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features))
						Traverse (p_asn_features.m_SubtypeElements);
					p_asn_features.turn_inc ();
					Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_asn_features);
				break;
			}
			Raise_asn_features_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_asn_features);
			p_asn_features.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule asn-features
		//

		public void TraverseCommon (asn_features p_asn_features)
		{
			asn_features.production_kind kind = (asn_features.production_kind) p_asn_features.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_asn_features))
			switch (kind)
			{
				case asn_features.production_kind.g_asn_features_1:
					// traverse syntax tree node associated with production
					// asn-features: ModuleDefinitions-token ModuleDefinitions

						TraverseCommon (p_asn_features.m_ModuleDefinitions_token);
						TraverseCommon (p_asn_features.m_ModuleDefinitions);
				break;
				case asn_features.production_kind.g_asn_features_2:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedType-token ParameterizedType

						TraverseCommon (p_asn_features.m_ParameterizedType_token);
						TraverseCommon (p_asn_features.m_ParameterizedType);
				break;
				case asn_features.production_kind.g_asn_features_3:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedValue-token ParameterizedValue

						TraverseCommon (p_asn_features.m_ParameterizedValue_token);
						TraverseCommon (p_asn_features.m_ParameterizedValue);
				break;
				case asn_features.production_kind.g_asn_features_4:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedValueSetType-token ParameterizedValueSetType

						TraverseCommon (p_asn_features.m_ParameterizedValueSetType_token);
						TraverseCommon (p_asn_features.m_ParameterizedValueSetType);
				break;
				case asn_features.production_kind.g_asn_features_5:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedObjectClass-token ParameterizedObjectClass

						TraverseCommon (p_asn_features.m_ParameterizedObjectClass_token);
						TraverseCommon (p_asn_features.m_ParameterizedObjectClass);
				break;
				case asn_features.production_kind.g_asn_features_6:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedObjectSet-token ParameterizedObjectSet

						TraverseCommon (p_asn_features.m_ParameterizedObjectSet_token);
						TraverseCommon (p_asn_features.m_ParameterizedObjectSet);
				break;
				case asn_features.production_kind.g_asn_features_7:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedObject-token ParameterizedObject

						TraverseCommon (p_asn_features.m_ParameterizedObject_token);
						TraverseCommon (p_asn_features.m_ParameterizedObject);
				break;
				case asn_features.production_kind.g_asn_features_8:
					// traverse syntax tree node associated with production
					// asn-features: AssignmentList-token AssignmentList

						TraverseCommon (p_asn_features.m_AssignmentList_token);
						TraverseCommon (p_asn_features.m_AssignmentList);
				break;
				case asn_features.production_kind.g_asn_features_9:
					// traverse syntax tree node associated with production
					// asn-features: BuiltinValue-token BuiltinValue

						TraverseCommon (p_asn_features.m_BuiltinValue_token);
						TraverseCommon (p_asn_features.m_BuiltinValue);
				break;
				case asn_features.production_kind.g_asn_features_10:
					// traverse syntax tree node associated with production
					// asn-features: TypeAssignment-token TypeAssignment

						TraverseCommon (p_asn_features.m_TypeAssignment_token);
						TraverseCommon (p_asn_features.m_TypeAssignment);
				break;
				case asn_features.production_kind.g_asn_features_11:
					// traverse syntax tree node associated with production
					// asn-features: ValueAssignment-token ValueAssignment

						TraverseCommon (p_asn_features.m_ValueAssignment_token);
						TraverseCommon (p_asn_features.m_ValueAssignment);
				break;
				case asn_features.production_kind.g_asn_features_12:
					// traverse syntax tree node associated with production
					// asn-features: ValueSetTypeAssignment-token ValueSetTypeAssignment

						TraverseCommon (p_asn_features.m_ValueSetTypeAssignment_token);
						TraverseCommon (p_asn_features.m_ValueSetTypeAssignment);
				break;
				case asn_features.production_kind.g_asn_features_13:
					// traverse syntax tree node associated with production
					// asn-features: ObjectClassAssignment-token ObjectClassAssignment

						TraverseCommon (p_asn_features.m_ObjectClassAssignment_token);
						TraverseCommon (p_asn_features.m_ObjectClassAssignment);
				break;
				case asn_features.production_kind.g_asn_features_14:
					// traverse syntax tree node associated with production
					// asn-features: ObjectAssignment-token ObjectAssignment

						TraverseCommon (p_asn_features.m_ObjectAssignment_token);
						TraverseCommon (p_asn_features.m_ObjectAssignment);
				break;
				case asn_features.production_kind.g_asn_features_15:
					// traverse syntax tree node associated with production
					// asn-features: ObjectSetAssignment-token ObjectSetAssignment

						TraverseCommon (p_asn_features.m_ObjectSetAssignment_token);
						TraverseCommon (p_asn_features.m_ObjectSetAssignment);
				break;
				case asn_features.production_kind.g_asn_features_16:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedTypeAssignment-token ParameterizedTypeAssignment

						TraverseCommon (p_asn_features.m_ParameterizedTypeAssignment_token);
						TraverseCommon (p_asn_features.m_ParameterizedTypeAssignment);
				break;
				case asn_features.production_kind.g_asn_features_17:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedValueAssignment-token ParameterizedValueAssignment

						TraverseCommon (p_asn_features.m_ParameterizedValueAssignment_token);
						TraverseCommon (p_asn_features.m_ParameterizedValueAssignment);
				break;
				case asn_features.production_kind.g_asn_features_18:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedValueSetTypeAssignment-token ParameterizedValueSetTypeAssignment

						TraverseCommon (p_asn_features.m_ParameterizedValueSetTypeAssignment_token);
						TraverseCommon (p_asn_features.m_ParameterizedValueSetTypeAssignment);
				break;
				case asn_features.production_kind.g_asn_features_19:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedObjectClassAssignment-token ParameterizedObjectClassAssignment

						TraverseCommon (p_asn_features.m_ParameterizedObjectClassAssignment_token);
						TraverseCommon (p_asn_features.m_ParameterizedObjectClassAssignment);
				break;
				case asn_features.production_kind.g_asn_features_20:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedObjectAssignment-token ParameterizedObjectAssignment

						TraverseCommon (p_asn_features.m_ParameterizedObjectAssignment_token);
						TraverseCommon (p_asn_features.m_ParameterizedObjectAssignment);
				break;
				case asn_features.production_kind.g_asn_features_21:
					// traverse syntax tree node associated with production
					// asn-features: ParameterizedObjectSetAssignment-token ParameterizedObjectSetAssignment

						TraverseCommon (p_asn_features.m_ParameterizedObjectSetAssignment_token);
						TraverseCommon (p_asn_features.m_ParameterizedObjectSetAssignment);
				break;
				case asn_features.production_kind.g_asn_features_22:
					// traverse syntax tree node associated with production
					// asn-features: DefaultSyntax-token DefaultSyntax

						TraverseCommon (p_asn_features.m_DefaultSyntax_token);
						TraverseCommon (p_asn_features.m_DefaultSyntax);
				break;
				case asn_features.production_kind.g_asn_features_23:
					// traverse syntax tree node associated with production
					// asn-features: TypeFieldSpec-token TypeFieldSpec

						TraverseCommon (p_asn_features.m_TypeFieldSpec_token);
						TraverseCommon (p_asn_features.m_TypeFieldSpec);
				break;
				case asn_features.production_kind.g_asn_features_24:
					// traverse syntax tree node associated with production
					// asn-features: FixedTypeValueFieldSpec-token FixedTypeValueFieldSpec

						TraverseCommon (p_asn_features.m_FixedTypeValueFieldSpec_token);
						TraverseCommon (p_asn_features.m_FixedTypeValueFieldSpec);
				break;
				case asn_features.production_kind.g_asn_features_25:
					// traverse syntax tree node associated with production
					// asn-features: VariableTypeValueFieldSpec-token VariableTypeValueFieldSpec

						TraverseCommon (p_asn_features.m_VariableTypeValueFieldSpec_token);
						TraverseCommon (p_asn_features.m_VariableTypeValueFieldSpec);
				break;
				case asn_features.production_kind.g_asn_features_26:
					// traverse syntax tree node associated with production
					// asn-features: FixedTypeValueSetFieldSpec-token FixedTypeValueSetFieldSpec

						TraverseCommon (p_asn_features.m_FixedTypeValueSetFieldSpec_token);
						TraverseCommon (p_asn_features.m_FixedTypeValueSetFieldSpec);
				break;
				case asn_features.production_kind.g_asn_features_27:
					// traverse syntax tree node associated with production
					// asn-features: VariableTypeValueSetFieldSpec-token VariableTypeValueSetFieldSpec

						TraverseCommon (p_asn_features.m_VariableTypeValueSetFieldSpec_token);
						TraverseCommon (p_asn_features.m_VariableTypeValueSetFieldSpec);
				break;
				case asn_features.production_kind.g_asn_features_28:
					// traverse syntax tree node associated with production
					// asn-features: ObjectFieldSpec-token ObjectFieldSpec

						TraverseCommon (p_asn_features.m_ObjectFieldSpec_token);
						TraverseCommon (p_asn_features.m_ObjectFieldSpec);
				break;
				case asn_features.production_kind.g_asn_features_29:
					// traverse syntax tree node associated with production
					// asn-features: ObjectSetFieldSpec-token ObjectSetFieldSpec

						TraverseCommon (p_asn_features.m_ObjectSetFieldSpec_token);
						TraverseCommon (p_asn_features.m_ObjectSetFieldSpec);
				break;
				case asn_features.production_kind.g_asn_features_30:
					// traverse syntax tree node associated with production
					// asn-features: DefinedType-token DefinedType

						TraverseCommon (p_asn_features.m_DefinedType_token);
						TraverseCommon (p_asn_features.m_DefinedType);
				break;
				case asn_features.production_kind.g_asn_features_31:
					// traverse syntax tree node associated with production
					// asn-features: DefinedValue-token DefinedValue

						TraverseCommon (p_asn_features.m_DefinedValue_token);
						TraverseCommon (p_asn_features.m_DefinedValue);
				break;
				case asn_features.production_kind.g_asn_features_32:
					// traverse syntax tree node associated with production
					// asn-features: ObjectClass-token ObjectClass

						TraverseCommon (p_asn_features.m_ObjectClass_token);
						TraverseCommon (p_asn_features.m_ObjectClass);
				break;
				case asn_features.production_kind.g_asn_features_33:
					// traverse syntax tree node associated with production
					// asn-features: ObjectSetElements-token ObjectSetElements

						TraverseCommon (p_asn_features.m_ObjectSetElements_token);
						TraverseCommon (p_asn_features.m_ObjectSetElements);
				break;
				case asn_features.production_kind.g_asn_features_34:
					// traverse syntax tree node associated with production
					// asn-features: Object-token Object

						TraverseCommon (p_asn_features.m_Object_token);
						TraverseCommon (p_asn_features.m_Object);
				break;
				case asn_features.production_kind.g_asn_features_35:
					// traverse syntax tree node associated with production
					// asn-features: ObjectSet-token ObjectSet

						TraverseCommon (p_asn_features.m_ObjectSet_token);
						TraverseCommon (p_asn_features.m_ObjectSet);
				break;
				case asn_features.production_kind.g_asn_features_36:
					// traverse syntax tree node associated with production
					// asn-features: ReferencedValue-token ReferencedValue

						TraverseCommon (p_asn_features.m_ReferencedValue_token);
						TraverseCommon (p_asn_features.m_ReferencedValue);
				break;
				case asn_features.production_kind.g_asn_features_37:
					// traverse syntax tree node associated with production
					// asn-features: Type-token Type

						TraverseCommon (p_asn_features.m_Type_token);
						TraverseCommon (p_asn_features.m_Type);
				break;
				case asn_features.production_kind.g_asn_features_38:
					// traverse syntax tree node associated with production
					// asn-features: Value-token Value

						TraverseCommon (p_asn_features.m_Value_token);
						TraverseCommon (p_asn_features.m_Value);
				break;
				case asn_features.production_kind.g_asn_features_39:
					// traverse syntax tree node associated with production
					// asn-features: ValueSet-token ValueSet

						TraverseCommon (p_asn_features.m_ValueSet_token);
						TraverseCommon (p_asn_features.m_ValueSet);
				break;
				case asn_features.production_kind.g_asn_features_40:
					// traverse syntax tree node associated with production
					// asn-features: BitStringValue-token BitStringValue

						TraverseCommon (p_asn_features.m_BitStringValue_token);
						TraverseCommon (p_asn_features.m_BitStringValue);
				break;
				case asn_features.production_kind.g_asn_features_41:
					// traverse syntax tree node associated with production
					// asn-features: BooleanValue-token BooleanValue

						TraverseCommon (p_asn_features.m_BooleanValue_token);
						TraverseCommon (p_asn_features.m_BooleanValue);
				break;
				case asn_features.production_kind.g_asn_features_42:
					// traverse syntax tree node associated with production
					// asn-features: CharacterStringValue-token CharacterStringValue

						TraverseCommon (p_asn_features.m_CharacterStringValue_token);
						TraverseCommon (p_asn_features.m_CharacterStringValue);
				break;
				case asn_features.production_kind.g_asn_features_43:
					// traverse syntax tree node associated with production
					// asn-features: ChoiceValue-token ChoiceValue

						TraverseCommon (p_asn_features.m_ChoiceValue_token);
						TraverseCommon (p_asn_features.m_ChoiceValue);
				break;
				case asn_features.production_kind.g_asn_features_44:
					// traverse syntax tree node associated with production
					// asn-features: EmbeddedPDVValue-token EmbeddedPDVValue

						TraverseCommon (p_asn_features.m_EmbeddedPDVValue_token);
						TraverseCommon (p_asn_features.m_EmbeddedPDVValue);
				break;
				case asn_features.production_kind.g_asn_features_45:
					// traverse syntax tree node associated with production
					// asn-features: EnumeratedValue-token EnumeratedValue

						TraverseCommon (p_asn_features.m_EnumeratedValue_token);
						TraverseCommon (p_asn_features.m_EnumeratedValue);
				break;
				case asn_features.production_kind.g_asn_features_46:
					// traverse syntax tree node associated with production
					// asn-features: ExternalValue-token ExternalValue

						TraverseCommon (p_asn_features.m_ExternalValue_token);
						TraverseCommon (p_asn_features.m_ExternalValue);
				break;
				case asn_features.production_kind.g_asn_features_47:
					// traverse syntax tree node associated with production
					// asn-features: IntegerValue-token IntegerValue

						TraverseCommon (p_asn_features.m_IntegerValue_token);
						TraverseCommon (p_asn_features.m_IntegerValue);
				break;
				case asn_features.production_kind.g_asn_features_48:
					// traverse syntax tree node associated with production
					// asn-features: IRIValue-token IRIValue

						TraverseCommon (p_asn_features.m_IRIValue_token);
						TraverseCommon (p_asn_features.m_IRIValue);
				break;
				case asn_features.production_kind.g_asn_features_49:
					// traverse syntax tree node associated with production
					// asn-features: NullValue-token NullValue

						TraverseCommon (p_asn_features.m_NullValue_token);
						TraverseCommon (p_asn_features.m_NullValue);
				break;
				case asn_features.production_kind.g_asn_features_50:
					// traverse syntax tree node associated with production
					// asn-features: ObjectIdentifierValue-token ObjectIdentifierValue

						TraverseCommon (p_asn_features.m_ObjectIdentifierValue_token);
						TraverseCommon (p_asn_features.m_ObjectIdentifierValue);
				break;
				case asn_features.production_kind.g_asn_features_51:
					// traverse syntax tree node associated with production
					// asn-features: OctetStringValue-token OctetStringValue

						TraverseCommon (p_asn_features.m_OctetStringValue_token);
						TraverseCommon (p_asn_features.m_OctetStringValue);
				break;
				case asn_features.production_kind.g_asn_features_52:
					// traverse syntax tree node associated with production
					// asn-features: RealValue-token RealValue

						TraverseCommon (p_asn_features.m_RealValue_token);
						TraverseCommon (p_asn_features.m_RealValue);
				break;
				case asn_features.production_kind.g_asn_features_53:
					// traverse syntax tree node associated with production
					// asn-features: RelativeIRIValue-token RelativeIRIValue

						TraverseCommon (p_asn_features.m_RelativeIRIValue_token);
						TraverseCommon (p_asn_features.m_RelativeIRIValue);
				break;
				case asn_features.production_kind.g_asn_features_54:
					// traverse syntax tree node associated with production
					// asn-features: RelativeOIDValue-token RelativeOIDValue

						TraverseCommon (p_asn_features.m_RelativeOIDValue_token);
						TraverseCommon (p_asn_features.m_RelativeOIDValue);
				break;
				case asn_features.production_kind.g_asn_features_55:
					// traverse syntax tree node associated with production
					// asn-features: SequenceValue-token SequenceValue

						TraverseCommon (p_asn_features.m_SequenceValue_token);
						TraverseCommon (p_asn_features.m_SequenceValue);
				break;
				case asn_features.production_kind.g_asn_features_56:
					// traverse syntax tree node associated with production
					// asn-features: SequenceOfValue-token SequenceOfValue

						TraverseCommon (p_asn_features.m_SequenceOfValue_token);
						TraverseCommon (p_asn_features.m_SequenceOfValue);
				break;
				case asn_features.production_kind.g_asn_features_57:
					// traverse syntax tree node associated with production
					// asn-features: SetValue-token SetValue

						TraverseCommon (p_asn_features.m_SetValue_token);
						TraverseCommon (p_asn_features.m_SetValue);
				break;
				case asn_features.production_kind.g_asn_features_58:
					// traverse syntax tree node associated with production
					// asn-features: SetOfValue-token SetOfValue

						TraverseCommon (p_asn_features.m_SetOfValue_token);
						TraverseCommon (p_asn_features.m_SetOfValue);
				break;
				case asn_features.production_kind.g_asn_features_59:
					// traverse syntax tree node associated with production
					// asn-features: TimeValue-token TimeValue

						TraverseCommon (p_asn_features.m_TimeValue_token);
						TraverseCommon (p_asn_features.m_TimeValue);
				break;
				case asn_features.production_kind.g_asn_features_60:
					// traverse syntax tree node associated with production
					// asn-features: SubtypeElements-token SubtypeElements

						TraverseCommon (p_asn_features.m_SubtypeElements_token);
						TraverseCommon (p_asn_features.m_SubtypeElements);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_asn_features);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule asn-features

		//
		// create syntax tree node associated with production
		// asn-features: ModuleDefinitions-token ModuleDefinitions

		//

		public asn_features asn_features_1 (SyntaxTreeToken p_token, ModuleDefinitions p_ModuleDefinitions)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ModuleDefinitions);
			p_token.parent = p_asn_features_ref;
			p_ModuleDefinitions.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_1, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ParameterizedType-token ParameterizedType

		//

		public asn_features asn_features_2 (SyntaxTreeToken p_token, ParameterizedType p_ParameterizedType)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ParameterizedType);
			p_token.parent = p_asn_features_ref;
			p_ParameterizedType.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_2, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ParameterizedValue-token ParameterizedValue

		//

		public asn_features asn_features_3 (SyntaxTreeToken p_token, ParameterizedValue p_ParameterizedValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ParameterizedValue);
			p_token.parent = p_asn_features_ref;
			p_ParameterizedValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_3, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ParameterizedValueSetType-token ParameterizedValueSetType

		//

		public asn_features asn_features_4 (SyntaxTreeToken p_token, ParameterizedValueSetType p_ParameterizedValueSetType)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ParameterizedValueSetType);
			p_token.parent = p_asn_features_ref;
			p_ParameterizedValueSetType.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_4, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ParameterizedObjectClass-token ParameterizedObjectClass

		//

		public asn_features asn_features_5 (SyntaxTreeToken p_token, ParameterizedObjectClass p_ParameterizedObjectClass)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ParameterizedObjectClass);
			p_token.parent = p_asn_features_ref;
			p_ParameterizedObjectClass.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_5, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ParameterizedObjectSet-token ParameterizedObjectSet

		//

		public asn_features asn_features_6 (SyntaxTreeToken p_token, ParameterizedObjectSet p_ParameterizedObjectSet)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ParameterizedObjectSet);
			p_token.parent = p_asn_features_ref;
			p_ParameterizedObjectSet.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_6, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ParameterizedObject-token ParameterizedObject

		//

		public asn_features asn_features_7 (SyntaxTreeToken p_token, ParameterizedObject p_ParameterizedObject)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ParameterizedObject);
			p_token.parent = p_asn_features_ref;
			p_ParameterizedObject.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_7, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: AssignmentList-token AssignmentList

		//

		public asn_features asn_features_8 (SyntaxTreeToken p_token, AssignmentList p_AssignmentList)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_AssignmentList);
			p_token.parent = p_asn_features_ref;
			p_AssignmentList.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_8, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: BuiltinValue-token BuiltinValue

		//

		public asn_features asn_features_9 (SyntaxTreeToken p_token, BuiltinValue p_BuiltinValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_BuiltinValue);
			p_token.parent = p_asn_features_ref;
			p_BuiltinValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_9, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: TypeAssignment-token TypeAssignment

		//

		public asn_features asn_features_10 (SyntaxTreeToken p_token, TypeAssignment p_TypeAssignment)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_TypeAssignment);
			p_token.parent = p_asn_features_ref;
			p_TypeAssignment.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_10, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ValueAssignment-token ValueAssignment

		//

		public asn_features asn_features_11 (SyntaxTreeToken p_token, ValueAssignment p_ValueAssignment)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ValueAssignment);
			p_token.parent = p_asn_features_ref;
			p_ValueAssignment.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_11, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ValueSetTypeAssignment-token ValueSetTypeAssignment

		//

		public asn_features asn_features_12 (SyntaxTreeToken p_token, ValueSetTypeAssignment p_ValueSetTypeAssignment)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ValueSetTypeAssignment);
			p_token.parent = p_asn_features_ref;
			p_ValueSetTypeAssignment.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_12, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ObjectClassAssignment-token ObjectClassAssignment

		//

		public asn_features asn_features_13 (SyntaxTreeToken p_token, ObjectClassAssignment p_ObjectClassAssignment)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ObjectClassAssignment);
			p_token.parent = p_asn_features_ref;
			p_ObjectClassAssignment.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_13, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ObjectAssignment-token ObjectAssignment

		//

		public asn_features asn_features_14 (SyntaxTreeToken p_token, ObjectAssignment p_ObjectAssignment)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ObjectAssignment);
			p_token.parent = p_asn_features_ref;
			p_ObjectAssignment.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_14, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ObjectSetAssignment-token ObjectSetAssignment

		//

		public asn_features asn_features_15 (SyntaxTreeToken p_token, ObjectSetAssignment p_ObjectSetAssignment)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ObjectSetAssignment);
			p_token.parent = p_asn_features_ref;
			p_ObjectSetAssignment.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_15, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ParameterizedTypeAssignment-token ParameterizedTypeAssignment

		//

		public asn_features asn_features_16 (SyntaxTreeToken p_token, ParameterizedTypeAssignment p_ParameterizedTypeAssignment)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ParameterizedTypeAssignment);
			p_token.parent = p_asn_features_ref;
			p_ParameterizedTypeAssignment.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_16, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ParameterizedValueAssignment-token ParameterizedValueAssignment

		//

		public asn_features asn_features_17 (SyntaxTreeToken p_token, ParameterizedValueAssignment p_ParameterizedValueAssignment)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ParameterizedValueAssignment);
			p_token.parent = p_asn_features_ref;
			p_ParameterizedValueAssignment.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_17, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ParameterizedValueSetTypeAssignment-token ParameterizedValueSetTypeAssignment

		//

		public asn_features asn_features_18 (SyntaxTreeToken p_token, ParameterizedValueSetTypeAssignment p_ParameterizedValueSetTypeAssignment)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ParameterizedValueSetTypeAssignment);
			p_token.parent = p_asn_features_ref;
			p_ParameterizedValueSetTypeAssignment.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_18, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ParameterizedObjectClassAssignment-token ParameterizedObjectClassAssignment

		//

		public asn_features asn_features_19 (SyntaxTreeToken p_token, ParameterizedObjectClassAssignment p_ParameterizedObjectClassAssignment)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ParameterizedObjectClassAssignment);
			p_token.parent = p_asn_features_ref;
			p_ParameterizedObjectClassAssignment.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_19, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ParameterizedObjectAssignment-token ParameterizedObjectAssignment

		//

		public asn_features asn_features_20 (SyntaxTreeToken p_token, ParameterizedObjectAssignment p_ParameterizedObjectAssignment)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ParameterizedObjectAssignment);
			p_token.parent = p_asn_features_ref;
			p_ParameterizedObjectAssignment.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_20, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ParameterizedObjectSetAssignment-token ParameterizedObjectSetAssignment

		//

		public asn_features asn_features_21 (SyntaxTreeToken p_token, ParameterizedObjectSetAssignment p_ParameterizedObjectSetAssignment)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ParameterizedObjectSetAssignment);
			p_token.parent = p_asn_features_ref;
			p_ParameterizedObjectSetAssignment.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_21, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: DefaultSyntax-token DefaultSyntax

		//

		public asn_features asn_features_22 (SyntaxTreeToken p_token, DefaultSyntax p_DefaultSyntax)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_DefaultSyntax);
			p_token.parent = p_asn_features_ref;
			p_DefaultSyntax.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_22, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: TypeFieldSpec-token TypeFieldSpec

		//

		public asn_features asn_features_23 (SyntaxTreeToken p_token, TypeFieldSpec p_TypeFieldSpec)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_TypeFieldSpec);
			p_token.parent = p_asn_features_ref;
			p_TypeFieldSpec.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_23, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: FixedTypeValueFieldSpec-token FixedTypeValueFieldSpec

		//

		public asn_features asn_features_24 (SyntaxTreeToken p_token, FixedTypeValueFieldSpec p_FixedTypeValueFieldSpec)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_FixedTypeValueFieldSpec);
			p_token.parent = p_asn_features_ref;
			p_FixedTypeValueFieldSpec.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_24, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: VariableTypeValueFieldSpec-token VariableTypeValueFieldSpec

		//

		public asn_features asn_features_25 (SyntaxTreeToken p_token, VariableTypeValueFieldSpec p_VariableTypeValueFieldSpec)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_VariableTypeValueFieldSpec);
			p_token.parent = p_asn_features_ref;
			p_VariableTypeValueFieldSpec.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_25, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: FixedTypeValueSetFieldSpec-token FixedTypeValueSetFieldSpec

		//

		public asn_features asn_features_26 (SyntaxTreeToken p_token, FixedTypeValueSetFieldSpec p_FixedTypeValueSetFieldSpec)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_FixedTypeValueSetFieldSpec);
			p_token.parent = p_asn_features_ref;
			p_FixedTypeValueSetFieldSpec.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_26, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: VariableTypeValueSetFieldSpec-token VariableTypeValueSetFieldSpec

		//

		public asn_features asn_features_27 (SyntaxTreeToken p_token, VariableTypeValueSetFieldSpec p_VariableTypeValueSetFieldSpec)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_VariableTypeValueSetFieldSpec);
			p_token.parent = p_asn_features_ref;
			p_VariableTypeValueSetFieldSpec.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_27, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ObjectFieldSpec-token ObjectFieldSpec

		//

		public asn_features asn_features_28 (SyntaxTreeToken p_token, ObjectFieldSpec p_ObjectFieldSpec)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ObjectFieldSpec);
			p_token.parent = p_asn_features_ref;
			p_ObjectFieldSpec.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_28, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ObjectSetFieldSpec-token ObjectSetFieldSpec

		//

		public asn_features asn_features_29 (SyntaxTreeToken p_token, ObjectSetFieldSpec p_ObjectSetFieldSpec)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ObjectSetFieldSpec);
			p_token.parent = p_asn_features_ref;
			p_ObjectSetFieldSpec.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_29, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: DefinedType-token DefinedType

		//

		public asn_features asn_features_30 (SyntaxTreeToken p_token, DefinedType p_DefinedType)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_DefinedType);
			p_token.parent = p_asn_features_ref;
			p_DefinedType.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_30, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: DefinedValue-token DefinedValue

		//

		public asn_features asn_features_31 (SyntaxTreeToken p_token, DefinedValue p_DefinedValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_DefinedValue);
			p_token.parent = p_asn_features_ref;
			p_DefinedValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_31, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ObjectClass-token ObjectClass

		//

		public asn_features asn_features_32 (SyntaxTreeToken p_token, ObjectClass p_ObjectClass)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ObjectClass);
			p_token.parent = p_asn_features_ref;
			p_ObjectClass.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_32, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ObjectSetElements-token ObjectSetElements

		//

		public asn_features asn_features_33 (SyntaxTreeToken p_token, ObjectSetElements p_ObjectSetElements)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ObjectSetElements);
			p_token.parent = p_asn_features_ref;
			p_ObjectSetElements.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_33, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: Object-token Object

		//

		public asn_features asn_features_34 (SyntaxTreeToken p_token, Object p_Object)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_Object);
			p_token.parent = p_asn_features_ref;
			p_Object.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_34, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ObjectSet-token ObjectSet

		//

		public asn_features asn_features_35 (SyntaxTreeToken p_token, ObjectSet p_ObjectSet)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ObjectSet);
			p_token.parent = p_asn_features_ref;
			p_ObjectSet.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_35, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ReferencedValue-token ReferencedValue

		//

		public asn_features asn_features_36 (SyntaxTreeToken p_token, ReferencedValue p_ReferencedValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ReferencedValue);
			p_token.parent = p_asn_features_ref;
			p_ReferencedValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_36, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: Type-token Type

		//

		public asn_features asn_features_37 (SyntaxTreeToken p_token, Type p_Type)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_Type);
			p_token.parent = p_asn_features_ref;
			p_Type.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_37, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: Value-token Value

		//

		public asn_features asn_features_38 (SyntaxTreeToken p_token, Value p_Value)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_Value);
			p_token.parent = p_asn_features_ref;
			p_Value.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_38, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ValueSet-token ValueSet

		//

		public asn_features asn_features_39 (SyntaxTreeToken p_token, ValueSet p_ValueSet)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ValueSet);
			p_token.parent = p_asn_features_ref;
			p_ValueSet.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_39, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: BitStringValue-token BitStringValue

		//

		public asn_features asn_features_40 (SyntaxTreeToken p_token, BitStringValue p_BitStringValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_BitStringValue);
			p_token.parent = p_asn_features_ref;
			p_BitStringValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_40, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: BooleanValue-token BooleanValue

		//

		public asn_features asn_features_41 (SyntaxTreeToken p_token, BooleanValue p_BooleanValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_BooleanValue);
			p_token.parent = p_asn_features_ref;
			p_BooleanValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_41, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: CharacterStringValue-token CharacterStringValue

		//

		public asn_features asn_features_42 (SyntaxTreeToken p_token, CharacterStringValue p_CharacterStringValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_CharacterStringValue);
			p_token.parent = p_asn_features_ref;
			p_CharacterStringValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_42, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ChoiceValue-token ChoiceValue

		//

		public asn_features asn_features_43 (SyntaxTreeToken p_token, ChoiceValue p_ChoiceValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ChoiceValue);
			p_token.parent = p_asn_features_ref;
			p_ChoiceValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_43, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: EmbeddedPDVValue-token EmbeddedPDVValue

		//

		public asn_features asn_features_44 (SyntaxTreeToken p_token, EmbeddedPDVValue p_EmbeddedPDVValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_EmbeddedPDVValue);
			p_token.parent = p_asn_features_ref;
			p_EmbeddedPDVValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_44, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: EnumeratedValue-token EnumeratedValue

		//

		public asn_features asn_features_45 (SyntaxTreeToken p_token, EnumeratedValue p_EnumeratedValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_EnumeratedValue);
			p_token.parent = p_asn_features_ref;
			p_EnumeratedValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_45, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ExternalValue-token ExternalValue

		//

		public asn_features asn_features_46 (SyntaxTreeToken p_token, ExternalValue p_ExternalValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ExternalValue);
			p_token.parent = p_asn_features_ref;
			p_ExternalValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_46, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: IntegerValue-token IntegerValue

		//

		public asn_features asn_features_47 (SyntaxTreeToken p_token, IntegerValue p_IntegerValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_IntegerValue);
			p_token.parent = p_asn_features_ref;
			p_IntegerValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_47, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: IRIValue-token IRIValue

		//

		public asn_features asn_features_48 (SyntaxTreeToken p_token, IRIValue p_IRIValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_IRIValue);
			p_token.parent = p_asn_features_ref;
			p_IRIValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_48, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: NullValue-token NullValue

		//

		public asn_features asn_features_49 (SyntaxTreeToken p_token, NullValue p_NullValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_NullValue);
			p_token.parent = p_asn_features_ref;
			p_NullValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_49, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: ObjectIdentifierValue-token ObjectIdentifierValue

		//

		public asn_features asn_features_50 (SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_ObjectIdentifierValue);
			p_token.parent = p_asn_features_ref;
			p_ObjectIdentifierValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_50, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: OctetStringValue-token OctetStringValue

		//

		public asn_features asn_features_51 (SyntaxTreeToken p_token, OctetStringValue p_OctetStringValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_OctetStringValue);
			p_token.parent = p_asn_features_ref;
			p_OctetStringValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_51, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: RealValue-token RealValue

		//

		public asn_features asn_features_52 (SyntaxTreeToken p_token, RealValue p_RealValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_RealValue);
			p_token.parent = p_asn_features_ref;
			p_RealValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_52, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: RelativeIRIValue-token RelativeIRIValue

		//

		public asn_features asn_features_53 (SyntaxTreeToken p_token, RelativeIRIValue p_RelativeIRIValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_RelativeIRIValue);
			p_token.parent = p_asn_features_ref;
			p_RelativeIRIValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_53, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: RelativeOIDValue-token RelativeOIDValue

		//

		public asn_features asn_features_54 (SyntaxTreeToken p_token, RelativeOIDValue p_RelativeOIDValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_RelativeOIDValue);
			p_token.parent = p_asn_features_ref;
			p_RelativeOIDValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_54, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: SequenceValue-token SequenceValue

		//

		public asn_features asn_features_55 (SyntaxTreeToken p_token, SequenceValue p_SequenceValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_SequenceValue);
			p_token.parent = p_asn_features_ref;
			p_SequenceValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_55, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: SequenceOfValue-token SequenceOfValue

		//

		public asn_features asn_features_56 (SyntaxTreeToken p_token, SequenceOfValue p_SequenceOfValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_SequenceOfValue);
			p_token.parent = p_asn_features_ref;
			p_SequenceOfValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_56, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: SetValue-token SetValue

		//

		public asn_features asn_features_57 (SyntaxTreeToken p_token, SetValue p_SetValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_SetValue);
			p_token.parent = p_asn_features_ref;
			p_SetValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_57, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: SetOfValue-token SetOfValue

		//

		public asn_features asn_features_58 (SyntaxTreeToken p_token, SetOfValue p_SetOfValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_SetOfValue);
			p_token.parent = p_asn_features_ref;
			p_SetOfValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_58, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: TimeValue-token TimeValue

		//

		public asn_features asn_features_59 (SyntaxTreeToken p_token, TimeValue p_TimeValue)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_TimeValue);
			p_token.parent = p_asn_features_ref;
			p_TimeValue.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_59, p_asn_features_ref);
			return p_asn_features_ref;
		}

		//
		// create syntax tree node associated with production
		// asn-features: SubtypeElements-token SubtypeElements

		//

		public asn_features asn_features_60 (SyntaxTreeToken p_token, SubtypeElements p_SubtypeElements)
		{
			asn_features p_asn_features_ref = new asn_features(p_token, p_SubtypeElements);
			p_token.parent = p_asn_features_ref;
			p_SubtypeElements.parent = p_asn_features_ref;
			Raise_asn_features_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, asn_features.production_kind.g_asn_features_60, p_asn_features_ref);
			return p_asn_features_ref;
		}
		#endregion
	};
}
