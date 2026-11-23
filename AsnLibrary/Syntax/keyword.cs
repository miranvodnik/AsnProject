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
	// class associated with syntax rule keyword
	//

	[DataContract]
	public class	keyword : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule keyword
		public enum production_kind : ushort	// enumerated production(s) of syntax rule keyword
		{
			g_keyword_1 = 1,	// DESCENDANTS

			g_keyword_2 = 2,	// SUCCESSORS

			g_keyword_3 = 3,	// ABSENT

			g_keyword_4 = 4,	// ABSTRACT-SYNTAX

			g_keyword_5 = 5,	// ALL

			g_keyword_6 = 6,	// APPLICATION

			g_keyword_7 = 7,	// AUTOMATIC

			g_keyword_8 = 8,	// BEGIN

			g_keyword_9 = 9,	// BIT

			g_keyword_10 = 10,	// BMPString

			g_keyword_11 = 11,	// BOOLEAN

			g_keyword_12 = 12,	// BY

			g_keyword_13 = 13,	// CHARACTER

			g_keyword_14 = 14,	// CHOICE

			g_keyword_15 = 15,	// CLASS

			g_keyword_16 = 16,	// COMPONENT

			g_keyword_17 = 17,	// COMPONENTS

			g_keyword_18 = 18,	// CONSTRAINED

			g_keyword_19 = 19,	// CONTAINING

			g_keyword_20 = 20,	// DATE

			g_keyword_21 = 21,	// DATE-TIME

			g_keyword_22 = 22,	// DEFAULT

			g_keyword_23 = 23,	// DEFINITIONS

			g_keyword_24 = 24,	// DURATION

			g_keyword_25 = 25,	// EMBEDDED

			g_keyword_26 = 26,	// ENCODED

			g_keyword_27 = 27,	// ENCODING-CONTROL

			g_keyword_28 = 28,	// END

			g_keyword_29 = 29,	// ENUMERATED

			g_keyword_30 = 30,	// EXCEPT

			g_keyword_31 = 31,	// EXPLICIT

			g_keyword_32 = 32,	// EXPORTS

			g_keyword_33 = 33,	// EXTENSIBILITY

			g_keyword_34 = 34,	// EXTERNAL

			g_keyword_35 = 35,	// FALSE

			g_keyword_36 = 36,	// FROM

			g_keyword_37 = 37,	// GeneralizedTime

			g_keyword_38 = 38,	// GeneralString

			g_keyword_39 = 39,	// GraphicString

			g_keyword_40 = 40,	// IA5String

			g_keyword_41 = 41,	// IDENTIFIER

			g_keyword_42 = 42,	// IMPLICIT

			g_keyword_43 = 43,	// IMPLIED

			g_keyword_44 = 44,	// IMPORTS

			g_keyword_45 = 45,	// INCLUDES

			g_keyword_46 = 46,	// INSTANCE

			g_keyword_47 = 47,	// INSTRUCTIONS

			g_keyword_48 = 48,	// INTEGER

			g_keyword_49 = 49,	// INTERSECTION

			g_keyword_50 = 50,	// ISO646String

			g_keyword_51 = 51,	// MAX

			g_keyword_52 = 52,	// MIN

			g_keyword_53 = 53,	// MINUS-INFINITY

			g_keyword_54 = 54,	// NOT-A-NUMBER

			g_keyword_55 = 55,	// NULL

			g_keyword_56 = 56,	// NumericString

			g_keyword_57 = 57,	// OBJECT

			g_keyword_58 = 58,	// ObjectDescriptor

			g_keyword_59 = 59,	// OCTET

			g_keyword_60 = 60,	// OF

			g_keyword_61 = 61,	// OID-IRI

			g_keyword_62 = 62,	// OPTIONAL

			g_keyword_63 = 63,	// PATTERN

			g_keyword_64 = 64,	// PDV

			g_keyword_65 = 65,	// PLUS-INFINITY

			g_keyword_66 = 66,	// PRESENT

			g_keyword_67 = 67,	// PrintableString

			g_keyword_68 = 68,	// PRIVATE

			g_keyword_69 = 69,	// REAL

			g_keyword_70 = 70,	// RELATIVE-OID

			g_keyword_71 = 71,	// RELATIVE-OID-IRI

			g_keyword_72 = 72,	// SEQUENCE

			g_keyword_73 = 73,	// SET

			g_keyword_74 = 74,	// SETTINGS

			g_keyword_75 = 75,	// SIZE

			g_keyword_76 = 76,	// STRING

			g_keyword_77 = 77,	// SYNTAX

			g_keyword_78 = 78,	// T61String

			g_keyword_79 = 79,	// TAGS

			g_keyword_80 = 80,	// TeletexString

			g_keyword_81 = 81,	// TIME

			g_keyword_82 = 82,	// TIME-OF-DAY

			g_keyword_83 = 83,	// TRUE

			g_keyword_84 = 84,	// TYPE-IDENTIFIER

			g_keyword_85 = 85,	// UNION

			g_keyword_86 = 86,	// UNIQUE

			g_keyword_87 = 87,	// UNIVERSAL

			g_keyword_88 = 88,	// UniversalString

			g_keyword_89 = 89,	// UTCTime

			g_keyword_90 = 90,	// UTF8String

			g_keyword_91 = 91,	// VideotexString

			g_keyword_92 = 92,	// VisibleString

			g_keyword_93 = 93,	// WITH

			g_keyword_94 = 94,	// ANY

			g_keyword_95 = 95,	// DEFINED

			g_keyword_96 = 96,	// MACRO

			g_keyword_97 = 97,	// MACRO-BODY

			g_keyword_98 = 98,	// MODULE-IDENTITY

			g_keyword_99 = 99,	// OBJECT-IDENTITY

			g_keyword_100 = 100,	// OBJECT-TYPE

			g_keyword_101 = 101,	// NOTIFICATION-TYPE

			g_keyword_102 = 102,	// TEXTUAL-CONVENTION

			g_keyword_103 = 103,	// OBJECT-GROUP

			g_keyword_104 = 104,	// NOTIFICATION-GROUP

			g_keyword_105 = 105,	// MODULE-COMPLIANCE

			g_keyword_106 = 106,	// AGENT-CAPABILITIES

			g_keyword_107 = 107,	// TRAP-TYPE

			g_keyword_108 = 108,	// LAST-UPDATED

			g_keyword_109 = 109,	// ORGANIZATION

			g_keyword_110 = 110,	// CONTACT-INFO

			g_keyword_111 = 111,	// DESCRIPTION

			g_keyword_112 = 112,	// REVISION

			g_keyword_113 = 113,	// STATUS

			g_keyword_114 = 114,	// REFERENCE

			g_keyword_115 = 115,	// MAX-ACCESS

			g_keyword_116 = 116,	// BITS

			g_keyword_117 = 117,	// UNITS

			g_keyword_118 = 118,	// INDEX

			g_keyword_119 = 119,	// AUGMENTS

			g_keyword_120 = 120,	// DEFVAL

			g_keyword_121 = 121,	// OBJECTS

			g_keyword_122 = 122,	// DISPLAY-HINT

			g_keyword_123 = 123,	// NOTIFICATIONS

			g_keyword_124 = 124,	// MODULE

			g_keyword_125 = 125,	// MANDATORY-GROUPS

			g_keyword_126 = 126,	// GROUP

			g_keyword_127 = 127,	// WRITE-SYNTAX

			g_keyword_128 = 128,	// MIN-ACCESS

			g_keyword_129 = 129,	// PRODUCT-RELEASE

			g_keyword_130 = 130,	// SUPPORTS

			g_keyword_131 = 131,	// VARIATION

			g_keyword_132 = 132,	// ACCESS

			g_keyword_133 = 133,	// CREATION-REQUIRES

			g_keyword_134 = 134,	// ENTERPRISE

			g_keyword_135 = 135,	// VARIABLES

		};
		#endregion
		#region production markers associated with the syntax rule keyword

		// markers associated with production: keyword -> DESCENDANTS

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: keyword -> SUCCESSORS

		public enum production_marker_2 : ushort
		{
			final
		};

		// markers associated with production: keyword -> ABSENT

		public enum production_marker_3 : ushort
		{
			final
		};

		// markers associated with production: keyword -> ABSTRACT-SYNTAX

		public enum production_marker_4 : ushort
		{
			final
		};

		// markers associated with production: keyword -> ALL

		public enum production_marker_5 : ushort
		{
			final
		};

		// markers associated with production: keyword -> APPLICATION

		public enum production_marker_6 : ushort
		{
			final
		};

		// markers associated with production: keyword -> AUTOMATIC

		public enum production_marker_7 : ushort
		{
			final
		};

		// markers associated with production: keyword -> BEGIN

		public enum production_marker_8 : ushort
		{
			final
		};

		// markers associated with production: keyword -> BIT

		public enum production_marker_9 : ushort
		{
			final
		};

		// markers associated with production: keyword -> BMPString

		public enum production_marker_10 : ushort
		{
			final
		};

		// markers associated with production: keyword -> BOOLEAN

		public enum production_marker_11 : ushort
		{
			final
		};

		// markers associated with production: keyword -> BY

		public enum production_marker_12 : ushort
		{
			final
		};

		// markers associated with production: keyword -> CHARACTER

		public enum production_marker_13 : ushort
		{
			final
		};

		// markers associated with production: keyword -> CHOICE

		public enum production_marker_14 : ushort
		{
			final
		};

		// markers associated with production: keyword -> CLASS

		public enum production_marker_15 : ushort
		{
			final
		};

		// markers associated with production: keyword -> COMPONENT

		public enum production_marker_16 : ushort
		{
			final
		};

		// markers associated with production: keyword -> COMPONENTS

		public enum production_marker_17 : ushort
		{
			final
		};

		// markers associated with production: keyword -> CONSTRAINED

		public enum production_marker_18 : ushort
		{
			final
		};

		// markers associated with production: keyword -> CONTAINING

		public enum production_marker_19 : ushort
		{
			final
		};

		// markers associated with production: keyword -> DATE

		public enum production_marker_20 : ushort
		{
			final
		};

		// markers associated with production: keyword -> DATE-TIME

		public enum production_marker_21 : ushort
		{
			final
		};

		// markers associated with production: keyword -> DEFAULT

		public enum production_marker_22 : ushort
		{
			final
		};

		// markers associated with production: keyword -> DEFINITIONS

		public enum production_marker_23 : ushort
		{
			final
		};

		// markers associated with production: keyword -> DURATION

		public enum production_marker_24 : ushort
		{
			final
		};

		// markers associated with production: keyword -> EMBEDDED

		public enum production_marker_25 : ushort
		{
			final
		};

		// markers associated with production: keyword -> ENCODED

		public enum production_marker_26 : ushort
		{
			final
		};

		// markers associated with production: keyword -> ENCODING-CONTROL

		public enum production_marker_27 : ushort
		{
			final
		};

		// markers associated with production: keyword -> END

		public enum production_marker_28 : ushort
		{
			final
		};

		// markers associated with production: keyword -> ENUMERATED

		public enum production_marker_29 : ushort
		{
			final
		};

		// markers associated with production: keyword -> EXCEPT

		public enum production_marker_30 : ushort
		{
			final
		};

		// markers associated with production: keyword -> EXPLICIT

		public enum production_marker_31 : ushort
		{
			final
		};

		// markers associated with production: keyword -> EXPORTS

		public enum production_marker_32 : ushort
		{
			final
		};

		// markers associated with production: keyword -> EXTENSIBILITY

		public enum production_marker_33 : ushort
		{
			final
		};

		// markers associated with production: keyword -> EXTERNAL

		public enum production_marker_34 : ushort
		{
			final
		};

		// markers associated with production: keyword -> FALSE

		public enum production_marker_35 : ushort
		{
			final
		};

		// markers associated with production: keyword -> FROM

		public enum production_marker_36 : ushort
		{
			final
		};

		// markers associated with production: keyword -> GeneralizedTime

		public enum production_marker_37 : ushort
		{
			final
		};

		// markers associated with production: keyword -> GeneralString

		public enum production_marker_38 : ushort
		{
			final
		};

		// markers associated with production: keyword -> GraphicString

		public enum production_marker_39 : ushort
		{
			final
		};

		// markers associated with production: keyword -> IA5String

		public enum production_marker_40 : ushort
		{
			final
		};

		// markers associated with production: keyword -> IDENTIFIER

		public enum production_marker_41 : ushort
		{
			final
		};

		// markers associated with production: keyword -> IMPLICIT

		public enum production_marker_42 : ushort
		{
			final
		};

		// markers associated with production: keyword -> IMPLIED

		public enum production_marker_43 : ushort
		{
			final
		};

		// markers associated with production: keyword -> IMPORTS

		public enum production_marker_44 : ushort
		{
			final
		};

		// markers associated with production: keyword -> INCLUDES

		public enum production_marker_45 : ushort
		{
			final
		};

		// markers associated with production: keyword -> INSTANCE

		public enum production_marker_46 : ushort
		{
			final
		};

		// markers associated with production: keyword -> INSTRUCTIONS

		public enum production_marker_47 : ushort
		{
			final
		};

		// markers associated with production: keyword -> INTEGER

		public enum production_marker_48 : ushort
		{
			final
		};

		// markers associated with production: keyword -> INTERSECTION

		public enum production_marker_49 : ushort
		{
			final
		};

		// markers associated with production: keyword -> ISO646String

		public enum production_marker_50 : ushort
		{
			final
		};

		// markers associated with production: keyword -> MAX

		public enum production_marker_51 : ushort
		{
			final
		};

		// markers associated with production: keyword -> MIN

		public enum production_marker_52 : ushort
		{
			final
		};

		// markers associated with production: keyword -> MINUS-INFINITY

		public enum production_marker_53 : ushort
		{
			final
		};

		// markers associated with production: keyword -> NOT-A-NUMBER

		public enum production_marker_54 : ushort
		{
			final
		};

		// markers associated with production: keyword -> NULL

		public enum production_marker_55 : ushort
		{
			final
		};

		// markers associated with production: keyword -> NumericString

		public enum production_marker_56 : ushort
		{
			final
		};

		// markers associated with production: keyword -> OBJECT

		public enum production_marker_57 : ushort
		{
			final
		};

		// markers associated with production: keyword -> ObjectDescriptor

		public enum production_marker_58 : ushort
		{
			final
		};

		// markers associated with production: keyword -> OCTET

		public enum production_marker_59 : ushort
		{
			final
		};

		// markers associated with production: keyword -> OF

		public enum production_marker_60 : ushort
		{
			final
		};

		// markers associated with production: keyword -> OID-IRI

		public enum production_marker_61 : ushort
		{
			final
		};

		// markers associated with production: keyword -> OPTIONAL

		public enum production_marker_62 : ushort
		{
			final
		};

		// markers associated with production: keyword -> PATTERN

		public enum production_marker_63 : ushort
		{
			final
		};

		// markers associated with production: keyword -> PDV

		public enum production_marker_64 : ushort
		{
			final
		};

		// markers associated with production: keyword -> PLUS-INFINITY

		public enum production_marker_65 : ushort
		{
			final
		};

		// markers associated with production: keyword -> PRESENT

		public enum production_marker_66 : ushort
		{
			final
		};

		// markers associated with production: keyword -> PrintableString

		public enum production_marker_67 : ushort
		{
			final
		};

		// markers associated with production: keyword -> PRIVATE

		public enum production_marker_68 : ushort
		{
			final
		};

		// markers associated with production: keyword -> REAL

		public enum production_marker_69 : ushort
		{
			final
		};

		// markers associated with production: keyword -> RELATIVE-OID

		public enum production_marker_70 : ushort
		{
			final
		};

		// markers associated with production: keyword -> RELATIVE-OID-IRI

		public enum production_marker_71 : ushort
		{
			final
		};

		// markers associated with production: keyword -> SEQUENCE

		public enum production_marker_72 : ushort
		{
			final
		};

		// markers associated with production: keyword -> SET

		public enum production_marker_73 : ushort
		{
			final
		};

		// markers associated with production: keyword -> SETTINGS

		public enum production_marker_74 : ushort
		{
			final
		};

		// markers associated with production: keyword -> SIZE

		public enum production_marker_75 : ushort
		{
			final
		};

		// markers associated with production: keyword -> STRING

		public enum production_marker_76 : ushort
		{
			final
		};

		// markers associated with production: keyword -> SYNTAX

		public enum production_marker_77 : ushort
		{
			final
		};

		// markers associated with production: keyword -> T61String

		public enum production_marker_78 : ushort
		{
			final
		};

		// markers associated with production: keyword -> TAGS

		public enum production_marker_79 : ushort
		{
			final
		};

		// markers associated with production: keyword -> TeletexString

		public enum production_marker_80 : ushort
		{
			final
		};

		// markers associated with production: keyword -> TIME

		public enum production_marker_81 : ushort
		{
			final
		};

		// markers associated with production: keyword -> TIME-OF-DAY

		public enum production_marker_82 : ushort
		{
			final
		};

		// markers associated with production: keyword -> TRUE

		public enum production_marker_83 : ushort
		{
			final
		};

		// markers associated with production: keyword -> TYPE-IDENTIFIER

		public enum production_marker_84 : ushort
		{
			final
		};

		// markers associated with production: keyword -> UNION

		public enum production_marker_85 : ushort
		{
			final
		};

		// markers associated with production: keyword -> UNIQUE

		public enum production_marker_86 : ushort
		{
			final
		};

		// markers associated with production: keyword -> UNIVERSAL

		public enum production_marker_87 : ushort
		{
			final
		};

		// markers associated with production: keyword -> UniversalString

		public enum production_marker_88 : ushort
		{
			final
		};

		// markers associated with production: keyword -> UTCTime

		public enum production_marker_89 : ushort
		{
			final
		};

		// markers associated with production: keyword -> UTF8String

		public enum production_marker_90 : ushort
		{
			final
		};

		// markers associated with production: keyword -> VideotexString

		public enum production_marker_91 : ushort
		{
			final
		};

		// markers associated with production: keyword -> VisibleString

		public enum production_marker_92 : ushort
		{
			final
		};

		// markers associated with production: keyword -> WITH

		public enum production_marker_93 : ushort
		{
			final
		};

		// markers associated with production: keyword -> ANY

		public enum production_marker_94 : ushort
		{
			final
		};

		// markers associated with production: keyword -> DEFINED

		public enum production_marker_95 : ushort
		{
			final
		};

		// markers associated with production: keyword -> MACRO

		public enum production_marker_96 : ushort
		{
			final
		};

		// markers associated with production: keyword -> MACRO-BODY

		public enum production_marker_97 : ushort
		{
			final
		};

		// markers associated with production: keyword -> MODULE-IDENTITY

		public enum production_marker_98 : ushort
		{
			final
		};

		// markers associated with production: keyword -> OBJECT-IDENTITY

		public enum production_marker_99 : ushort
		{
			final
		};

		// markers associated with production: keyword -> OBJECT-TYPE

		public enum production_marker_100 : ushort
		{
			final
		};

		// markers associated with production: keyword -> NOTIFICATION-TYPE

		public enum production_marker_101 : ushort
		{
			final
		};

		// markers associated with production: keyword -> TEXTUAL-CONVENTION

		public enum production_marker_102 : ushort
		{
			final
		};

		// markers associated with production: keyword -> OBJECT-GROUP

		public enum production_marker_103 : ushort
		{
			final
		};

		// markers associated with production: keyword -> NOTIFICATION-GROUP

		public enum production_marker_104 : ushort
		{
			final
		};

		// markers associated with production: keyword -> MODULE-COMPLIANCE

		public enum production_marker_105 : ushort
		{
			final
		};

		// markers associated with production: keyword -> AGENT-CAPABILITIES

		public enum production_marker_106 : ushort
		{
			final
		};

		// markers associated with production: keyword -> TRAP-TYPE

		public enum production_marker_107 : ushort
		{
			final
		};

		// markers associated with production: keyword -> LAST-UPDATED

		public enum production_marker_108 : ushort
		{
			final
		};

		// markers associated with production: keyword -> ORGANIZATION

		public enum production_marker_109 : ushort
		{
			final
		};

		// markers associated with production: keyword -> CONTACT-INFO

		public enum production_marker_110 : ushort
		{
			final
		};

		// markers associated with production: keyword -> DESCRIPTION

		public enum production_marker_111 : ushort
		{
			final
		};

		// markers associated with production: keyword -> REVISION

		public enum production_marker_112 : ushort
		{
			final
		};

		// markers associated with production: keyword -> STATUS

		public enum production_marker_113 : ushort
		{
			final
		};

		// markers associated with production: keyword -> REFERENCE

		public enum production_marker_114 : ushort
		{
			final
		};

		// markers associated with production: keyword -> MAX-ACCESS

		public enum production_marker_115 : ushort
		{
			final
		};

		// markers associated with production: keyword -> BITS

		public enum production_marker_116 : ushort
		{
			final
		};

		// markers associated with production: keyword -> UNITS

		public enum production_marker_117 : ushort
		{
			final
		};

		// markers associated with production: keyword -> INDEX

		public enum production_marker_118 : ushort
		{
			final
		};

		// markers associated with production: keyword -> AUGMENTS

		public enum production_marker_119 : ushort
		{
			final
		};

		// markers associated with production: keyword -> DEFVAL

		public enum production_marker_120 : ushort
		{
			final
		};

		// markers associated with production: keyword -> OBJECTS

		public enum production_marker_121 : ushort
		{
			final
		};

		// markers associated with production: keyword -> DISPLAY-HINT

		public enum production_marker_122 : ushort
		{
			final
		};

		// markers associated with production: keyword -> NOTIFICATIONS

		public enum production_marker_123 : ushort
		{
			final
		};

		// markers associated with production: keyword -> MODULE

		public enum production_marker_124 : ushort
		{
			final
		};

		// markers associated with production: keyword -> MANDATORY-GROUPS

		public enum production_marker_125 : ushort
		{
			final
		};

		// markers associated with production: keyword -> GROUP

		public enum production_marker_126 : ushort
		{
			final
		};

		// markers associated with production: keyword -> WRITE-SYNTAX

		public enum production_marker_127 : ushort
		{
			final
		};

		// markers associated with production: keyword -> MIN-ACCESS

		public enum production_marker_128 : ushort
		{
			final
		};

		// markers associated with production: keyword -> PRODUCT-RELEASE

		public enum production_marker_129 : ushort
		{
			final
		};

		// markers associated with production: keyword -> SUPPORTS

		public enum production_marker_130 : ushort
		{
			final
		};

		// markers associated with production: keyword -> VARIATION

		public enum production_marker_131 : ushort
		{
			final
		};

		// markers associated with production: keyword -> ACCESS

		public enum production_marker_132 : ushort
		{
			final
		};

		// markers associated with production: keyword -> CREATION-REQUIRES

		public enum production_marker_133 : ushort
		{
			final
		};

		// markers associated with production: keyword -> ENTERPRISE

		public enum production_marker_134 : ushort
		{
			final
		};

		// markers associated with production: keyword -> VARIABLES

		public enum production_marker_135 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule keyword

		// Constructor declaration(s) associated with production(s) of syntax rule keyword

		//
		// Constructor associated with the following production(s)
		// keyword -> DESCENDANTS

		// keyword -> SUCCESSORS

		// keyword -> ABSENT

		// keyword -> ABSTRACT-SYNTAX

		// keyword -> ALL

		// keyword -> APPLICATION

		// keyword -> AUTOMATIC

		// keyword -> BEGIN

		// keyword -> BIT

		// keyword -> BMPString

		// keyword -> BOOLEAN

		// keyword -> BY

		// keyword -> CHARACTER

		// keyword -> CHOICE

		// keyword -> CLASS

		// keyword -> COMPONENT

		// keyword -> COMPONENTS

		// keyword -> CONSTRAINED

		// keyword -> CONTAINING

		// keyword -> DATE

		// keyword -> DATE-TIME

		// keyword -> DEFAULT

		// keyword -> DEFINITIONS

		// keyword -> DURATION

		// keyword -> EMBEDDED

		// keyword -> ENCODED

		// keyword -> ENCODING-CONTROL

		// keyword -> END

		// keyword -> ENUMERATED

		// keyword -> EXCEPT

		// keyword -> EXPLICIT

		// keyword -> EXPORTS

		// keyword -> EXTENSIBILITY

		// keyword -> EXTERNAL

		// keyword -> FALSE

		// keyword -> FROM

		// keyword -> GeneralizedTime

		// keyword -> GeneralString

		// keyword -> GraphicString

		// keyword -> IA5String

		// keyword -> IDENTIFIER

		// keyword -> IMPLICIT

		// keyword -> IMPLIED

		// keyword -> IMPORTS

		// keyword -> INCLUDES

		// keyword -> INSTANCE

		// keyword -> INSTRUCTIONS

		// keyword -> INTEGER

		// keyword -> INTERSECTION

		// keyword -> ISO646String

		// keyword -> MAX

		// keyword -> MIN

		// keyword -> MINUS-INFINITY

		// keyword -> NOT-A-NUMBER

		// keyword -> NULL

		// keyword -> NumericString

		// keyword -> OBJECT

		// keyword -> ObjectDescriptor

		// keyword -> OCTET

		// keyword -> OF

		// keyword -> OID-IRI

		// keyword -> OPTIONAL

		// keyword -> PATTERN

		// keyword -> PDV

		// keyword -> PLUS-INFINITY

		// keyword -> PRESENT

		// keyword -> PrintableString

		// keyword -> PRIVATE

		// keyword -> REAL

		// keyword -> RELATIVE-OID

		// keyword -> RELATIVE-OID-IRI

		// keyword -> SEQUENCE

		// keyword -> SET

		// keyword -> SETTINGS

		// keyword -> SIZE

		// keyword -> STRING

		// keyword -> SYNTAX

		// keyword -> T61String

		// keyword -> TAGS

		// keyword -> TeletexString

		// keyword -> TIME

		// keyword -> TIME-OF-DAY

		// keyword -> TRUE

		// keyword -> TYPE-IDENTIFIER

		// keyword -> UNION

		// keyword -> UNIQUE

		// keyword -> UNIVERSAL

		// keyword -> UniversalString

		// keyword -> UTCTime

		// keyword -> UTF8String

		// keyword -> VideotexString

		// keyword -> VisibleString

		// keyword -> WITH

		// keyword -> ANY

		// keyword -> DEFINED

		// keyword -> MACRO

		// keyword -> MACRO-BODY

		// keyword -> MODULE-IDENTITY

		// keyword -> OBJECT-IDENTITY

		// keyword -> OBJECT-TYPE

		// keyword -> NOTIFICATION-TYPE

		// keyword -> TEXTUAL-CONVENTION

		// keyword -> OBJECT-GROUP

		// keyword -> NOTIFICATION-GROUP

		// keyword -> MODULE-COMPLIANCE

		// keyword -> AGENT-CAPABILITIES

		// keyword -> TRAP-TYPE

		// keyword -> LAST-UPDATED

		// keyword -> ORGANIZATION

		// keyword -> CONTACT-INFO

		// keyword -> DESCRIPTION

		// keyword -> REVISION

		// keyword -> STATUS

		// keyword -> REFERENCE

		// keyword -> MAX-ACCESS

		// keyword -> BITS

		// keyword -> UNITS

		// keyword -> INDEX

		// keyword -> AUGMENTS

		// keyword -> DEFVAL

		// keyword -> OBJECTS

		// keyword -> DISPLAY-HINT

		// keyword -> NOTIFICATIONS

		// keyword -> MODULE

		// keyword -> MANDATORY-GROUPS

		// keyword -> GROUP

		// keyword -> WRITE-SYNTAX

		// keyword -> MIN-ACCESS

		// keyword -> PRODUCT-RELEASE

		// keyword -> SUPPORTS

		// keyword -> VARIATION

		// keyword -> ACCESS

		// keyword -> CREATION-REQUIRES

		// keyword -> ENTERPRISE

		// keyword -> VARIABLES

		//

		public keyword (SyntaxTreeToken p_token, int kind) : base ((uint) ProductionID._keyword_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_keyword_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_DESCENDANTS = p_token;
				break;
			case production_kind.g_keyword_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_SUCCESSORS = p_token;
				break;
			case production_kind.g_keyword_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_ABSENT = p_token;
				break;
			case production_kind.g_keyword_4:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_ABSTRACT_SYNTAX = p_token;
				break;
			case production_kind.g_keyword_5:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_ALL = p_token;
				break;
			case production_kind.g_keyword_6:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_APPLICATION = p_token;
				break;
			case production_kind.g_keyword_7:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_AUTOMATIC = p_token;
				break;
			case production_kind.g_keyword_8:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_BEGIN = p_token;
				break;
			case production_kind.g_keyword_9:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_BIT = p_token;
				break;
			case production_kind.g_keyword_10:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_BMPString = p_token;
				break;
			case production_kind.g_keyword_11:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_BOOLEAN = p_token;
				break;
			case production_kind.g_keyword_12:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_BY = p_token;
				break;
			case production_kind.g_keyword_13:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_CHARACTER = p_token;
				break;
			case production_kind.g_keyword_14:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_CHOICE = p_token;
				break;
			case production_kind.g_keyword_15:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_CLASS = p_token;
				break;
			case production_kind.g_keyword_16:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_COMPONENT = p_token;
				break;
			case production_kind.g_keyword_17:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_COMPONENTS = p_token;
				break;
			case production_kind.g_keyword_18:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_CONSTRAINED = p_token;
				break;
			case production_kind.g_keyword_19:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_CONTAINING = p_token;
				break;
			case production_kind.g_keyword_20:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_DATE = p_token;
				break;
			case production_kind.g_keyword_21:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_DATE_TIME = p_token;
				break;
			case production_kind.g_keyword_22:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_DEFAULT = p_token;
				break;
			case production_kind.g_keyword_23:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_DEFINITIONS = p_token;
				break;
			case production_kind.g_keyword_24:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_DURATION = p_token;
				break;
			case production_kind.g_keyword_25:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_EMBEDDED = p_token;
				break;
			case production_kind.g_keyword_26:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_ENCODED = p_token;
				break;
			case production_kind.g_keyword_27:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_ENCODING_CONTROL = p_token;
				break;
			case production_kind.g_keyword_28:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_END = p_token;
				break;
			case production_kind.g_keyword_29:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_ENUMERATED = p_token;
				break;
			case production_kind.g_keyword_30:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_EXCEPT = p_token;
				break;
			case production_kind.g_keyword_31:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_EXPLICIT = p_token;
				break;
			case production_kind.g_keyword_32:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_EXPORTS = p_token;
				break;
			case production_kind.g_keyword_33:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_EXTENSIBILITY = p_token;
				break;
			case production_kind.g_keyword_34:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_EXTERNAL = p_token;
				break;
			case production_kind.g_keyword_35:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_FALSE = p_token;
				break;
			case production_kind.g_keyword_36:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_FROM = p_token;
				break;
			case production_kind.g_keyword_37:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_GeneralizedTime = p_token;
				break;
			case production_kind.g_keyword_38:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_GeneralString = p_token;
				break;
			case production_kind.g_keyword_39:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_GraphicString = p_token;
				break;
			case production_kind.g_keyword_40:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_IA5String = p_token;
				break;
			case production_kind.g_keyword_41:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_IDENTIFIER = p_token;
				break;
			case production_kind.g_keyword_42:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_IMPLICIT = p_token;
				break;
			case production_kind.g_keyword_43:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_IMPLIED = p_token;
				break;
			case production_kind.g_keyword_44:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_IMPORTS = p_token;
				break;
			case production_kind.g_keyword_45:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_INCLUDES = p_token;
				break;
			case production_kind.g_keyword_46:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_INSTANCE = p_token;
				break;
			case production_kind.g_keyword_47:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_INSTRUCTIONS = p_token;
				break;
			case production_kind.g_keyword_48:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_INTEGER = p_token;
				break;
			case production_kind.g_keyword_49:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_INTERSECTION = p_token;
				break;
			case production_kind.g_keyword_50:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_ISO646String = p_token;
				break;
			case production_kind.g_keyword_51:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_MAX = p_token;
				break;
			case production_kind.g_keyword_52:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_MIN = p_token;
				break;
			case production_kind.g_keyword_53:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_MINUS_INFINITY = p_token;
				break;
			case production_kind.g_keyword_54:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_NOT_A_NUMBER = p_token;
				break;
			case production_kind.g_keyword_55:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_NULL = p_token;
				break;
			case production_kind.g_keyword_56:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_NumericString = p_token;
				break;
			case production_kind.g_keyword_57:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_OBJECT = p_token;
				break;
			case production_kind.g_keyword_58:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_ObjectDescriptor = p_token;
				break;
			case production_kind.g_keyword_59:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_OCTET = p_token;
				break;
			case production_kind.g_keyword_60:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_OF = p_token;
				break;
			case production_kind.g_keyword_61:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_OID_IRI = p_token;
				break;
			case production_kind.g_keyword_62:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_OPTIONAL = p_token;
				break;
			case production_kind.g_keyword_63:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_PATTERN = p_token;
				break;
			case production_kind.g_keyword_64:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_PDV = p_token;
				break;
			case production_kind.g_keyword_65:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_PLUS_INFINITY = p_token;
				break;
			case production_kind.g_keyword_66:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_PRESENT = p_token;
				break;
			case production_kind.g_keyword_67:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_PrintableString = p_token;
				break;
			case production_kind.g_keyword_68:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_PRIVATE = p_token;
				break;
			case production_kind.g_keyword_69:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_REAL = p_token;
				break;
			case production_kind.g_keyword_70:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_RELATIVE_OID = p_token;
				break;
			case production_kind.g_keyword_71:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_RELATIVE_OID_IRI = p_token;
				break;
			case production_kind.g_keyword_72:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_SEQUENCE = p_token;
				break;
			case production_kind.g_keyword_73:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_SET = p_token;
				break;
			case production_kind.g_keyword_74:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_SETTINGS = p_token;
				break;
			case production_kind.g_keyword_75:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_SIZE = p_token;
				break;
			case production_kind.g_keyword_76:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_STRING = p_token;
				break;
			case production_kind.g_keyword_77:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_SYNTAX = p_token;
				break;
			case production_kind.g_keyword_78:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_T61String = p_token;
				break;
			case production_kind.g_keyword_79:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_TAGS = p_token;
				break;
			case production_kind.g_keyword_80:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_TeletexString = p_token;
				break;
			case production_kind.g_keyword_81:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_TIME = p_token;
				break;
			case production_kind.g_keyword_82:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_TIME_OF_DAY = p_token;
				break;
			case production_kind.g_keyword_83:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_TRUE = p_token;
				break;
			case production_kind.g_keyword_84:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_TYPE_IDENTIFIER = p_token;
				break;
			case production_kind.g_keyword_85:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_UNION = p_token;
				break;
			case production_kind.g_keyword_86:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_UNIQUE = p_token;
				break;
			case production_kind.g_keyword_87:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_UNIVERSAL = p_token;
				break;
			case production_kind.g_keyword_88:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_UniversalString = p_token;
				break;
			case production_kind.g_keyword_89:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_UTCTime = p_token;
				break;
			case production_kind.g_keyword_90:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_UTF8String = p_token;
				break;
			case production_kind.g_keyword_91:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_VideotexString = p_token;
				break;
			case production_kind.g_keyword_92:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_VisibleString = p_token;
				break;
			case production_kind.g_keyword_93:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_WITH = p_token;
				break;
			case production_kind.g_keyword_94:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_ANY = p_token;
				break;
			case production_kind.g_keyword_95:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_DEFINED = p_token;
				break;
			case production_kind.g_keyword_96:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_MACRO = p_token;
				break;
			case production_kind.g_keyword_97:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_MACRO_BODY = p_token;
				break;
			case production_kind.g_keyword_98:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_MODULE_IDENTITY = p_token;
				break;
			case production_kind.g_keyword_99:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_OBJECT_IDENTITY = p_token;
				break;
			case production_kind.g_keyword_100:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_OBJECT_TYPE = p_token;
				break;
			case production_kind.g_keyword_101:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_NOTIFICATION_TYPE = p_token;
				break;
			case production_kind.g_keyword_102:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_TEXTUAL_CONVENTION = p_token;
				break;
			case production_kind.g_keyword_103:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_OBJECT_GROUP = p_token;
				break;
			case production_kind.g_keyword_104:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_NOTIFICATION_GROUP = p_token;
				break;
			case production_kind.g_keyword_105:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_MODULE_COMPLIANCE = p_token;
				break;
			case production_kind.g_keyword_106:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_AGENT_CAPABILITIES = p_token;
				break;
			case production_kind.g_keyword_107:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_TRAP_TYPE = p_token;
				break;
			case production_kind.g_keyword_108:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_LAST_UPDATED = p_token;
				break;
			case production_kind.g_keyword_109:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_ORGANIZATION = p_token;
				break;
			case production_kind.g_keyword_110:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_CONTACT_INFO = p_token;
				break;
			case production_kind.g_keyword_111:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_DESCRIPTION = p_token;
				break;
			case production_kind.g_keyword_112:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_REVISION = p_token;
				break;
			case production_kind.g_keyword_113:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_STATUS = p_token;
				break;
			case production_kind.g_keyword_114:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_REFERENCE = p_token;
				break;
			case production_kind.g_keyword_115:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_MAX_ACCESS = p_token;
				break;
			case production_kind.g_keyword_116:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_BITS = p_token;
				break;
			case production_kind.g_keyword_117:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_UNITS = p_token;
				break;
			case production_kind.g_keyword_118:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_INDEX = p_token;
				break;
			case production_kind.g_keyword_119:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_AUGMENTS = p_token;
				break;
			case production_kind.g_keyword_120:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_DEFVAL = p_token;
				break;
			case production_kind.g_keyword_121:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_OBJECTS = p_token;
				break;
			case production_kind.g_keyword_122:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_DISPLAY_HINT = p_token;
				break;
			case production_kind.g_keyword_123:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_NOTIFICATIONS = p_token;
				break;
			case production_kind.g_keyword_124:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_MODULE = p_token;
				break;
			case production_kind.g_keyword_125:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_MANDATORY_GROUPS = p_token;
				break;
			case production_kind.g_keyword_126:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_GROUP = p_token;
				break;
			case production_kind.g_keyword_127:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_WRITE_SYNTAX = p_token;
				break;
			case production_kind.g_keyword_128:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_MIN_ACCESS = p_token;
				break;
			case production_kind.g_keyword_129:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_PRODUCT_RELEASE = p_token;
				break;
			case production_kind.g_keyword_130:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_SUPPORTS = p_token;
				break;
			case production_kind.g_keyword_131:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_VARIATION = p_token;
				break;
			case production_kind.g_keyword_132:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_ACCESS = p_token;
				break;
			case production_kind.g_keyword_133:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_CREATION_REQUIRES = p_token;
				break;
			case production_kind.g_keyword_134:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_ENTERPRISE = p_token;
				break;
			case production_kind.g_keyword_135:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_VARIABLES = p_token;
				break;
			default:
				{
					string[] args = new string[] { "keyword" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		public keyword () { }

		// Copy constructor

		public keyword (keyword p_keyword) : base (p_keyword.id, p_keyword.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_keyword.appInfo;
			switch ((production_kind) p_keyword.kind)
			{
				case production_kind.g_keyword_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DESCENDANTS = (p_keyword.m_DESCENDANTS != null) ? new SyntaxTreeToken (p_keyword.m_DESCENDANTS) : null) != null) m_DESCENDANTS.parent = this;
					break;
				case production_kind.g_keyword_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SUCCESSORS = (p_keyword.m_SUCCESSORS != null) ? new SyntaxTreeToken (p_keyword.m_SUCCESSORS) : null) != null) m_SUCCESSORS.parent = this;
					break;
				case production_kind.g_keyword_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ABSENT = (p_keyword.m_ABSENT != null) ? new SyntaxTreeToken (p_keyword.m_ABSENT) : null) != null) m_ABSENT.parent = this;
					break;
				case production_kind.g_keyword_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ABSTRACT_SYNTAX = (p_keyword.m_ABSTRACT_SYNTAX != null) ? new SyntaxTreeToken (p_keyword.m_ABSTRACT_SYNTAX) : null) != null) m_ABSTRACT_SYNTAX.parent = this;
					break;
				case production_kind.g_keyword_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ALL = (p_keyword.m_ALL != null) ? new SyntaxTreeToken (p_keyword.m_ALL) : null) != null) m_ALL.parent = this;
					break;
				case production_kind.g_keyword_6:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_APPLICATION = (p_keyword.m_APPLICATION != null) ? new SyntaxTreeToken (p_keyword.m_APPLICATION) : null) != null) m_APPLICATION.parent = this;
					break;
				case production_kind.g_keyword_7:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_AUTOMATIC = (p_keyword.m_AUTOMATIC != null) ? new SyntaxTreeToken (p_keyword.m_AUTOMATIC) : null) != null) m_AUTOMATIC.parent = this;
					break;
				case production_kind.g_keyword_8:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_BEGIN = (p_keyword.m_BEGIN != null) ? new SyntaxTreeToken (p_keyword.m_BEGIN) : null) != null) m_BEGIN.parent = this;
					break;
				case production_kind.g_keyword_9:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_BIT = (p_keyword.m_BIT != null) ? new SyntaxTreeToken (p_keyword.m_BIT) : null) != null) m_BIT.parent = this;
					break;
				case production_kind.g_keyword_10:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_BMPString = (p_keyword.m_BMPString != null) ? new SyntaxTreeToken (p_keyword.m_BMPString) : null) != null) m_BMPString.parent = this;
					break;
				case production_kind.g_keyword_11:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_BOOLEAN = (p_keyword.m_BOOLEAN != null) ? new SyntaxTreeToken (p_keyword.m_BOOLEAN) : null) != null) m_BOOLEAN.parent = this;
					break;
				case production_kind.g_keyword_12:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_BY = (p_keyword.m_BY != null) ? new SyntaxTreeToken (p_keyword.m_BY) : null) != null) m_BY.parent = this;
					break;
				case production_kind.g_keyword_13:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_CHARACTER = (p_keyword.m_CHARACTER != null) ? new SyntaxTreeToken (p_keyword.m_CHARACTER) : null) != null) m_CHARACTER.parent = this;
					break;
				case production_kind.g_keyword_14:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_CHOICE = (p_keyword.m_CHOICE != null) ? new SyntaxTreeToken (p_keyword.m_CHOICE) : null) != null) m_CHOICE.parent = this;
					break;
				case production_kind.g_keyword_15:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_CLASS = (p_keyword.m_CLASS != null) ? new SyntaxTreeToken (p_keyword.m_CLASS) : null) != null) m_CLASS.parent = this;
					break;
				case production_kind.g_keyword_16:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_COMPONENT = (p_keyword.m_COMPONENT != null) ? new SyntaxTreeToken (p_keyword.m_COMPONENT) : null) != null) m_COMPONENT.parent = this;
					break;
				case production_kind.g_keyword_17:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_COMPONENTS = (p_keyword.m_COMPONENTS != null) ? new SyntaxTreeToken (p_keyword.m_COMPONENTS) : null) != null) m_COMPONENTS.parent = this;
					break;
				case production_kind.g_keyword_18:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_CONSTRAINED = (p_keyword.m_CONSTRAINED != null) ? new SyntaxTreeToken (p_keyword.m_CONSTRAINED) : null) != null) m_CONSTRAINED.parent = this;
					break;
				case production_kind.g_keyword_19:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_CONTAINING = (p_keyword.m_CONTAINING != null) ? new SyntaxTreeToken (p_keyword.m_CONTAINING) : null) != null) m_CONTAINING.parent = this;
					break;
				case production_kind.g_keyword_20:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DATE = (p_keyword.m_DATE != null) ? new SyntaxTreeToken (p_keyword.m_DATE) : null) != null) m_DATE.parent = this;
					break;
				case production_kind.g_keyword_21:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DATE_TIME = (p_keyword.m_DATE_TIME != null) ? new SyntaxTreeToken (p_keyword.m_DATE_TIME) : null) != null) m_DATE_TIME.parent = this;
					break;
				case production_kind.g_keyword_22:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DEFAULT = (p_keyword.m_DEFAULT != null) ? new SyntaxTreeToken (p_keyword.m_DEFAULT) : null) != null) m_DEFAULT.parent = this;
					break;
				case production_kind.g_keyword_23:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DEFINITIONS = (p_keyword.m_DEFINITIONS != null) ? new SyntaxTreeToken (p_keyword.m_DEFINITIONS) : null) != null) m_DEFINITIONS.parent = this;
					break;
				case production_kind.g_keyword_24:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DURATION = (p_keyword.m_DURATION != null) ? new SyntaxTreeToken (p_keyword.m_DURATION) : null) != null) m_DURATION.parent = this;
					break;
				case production_kind.g_keyword_25:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EMBEDDED = (p_keyword.m_EMBEDDED != null) ? new SyntaxTreeToken (p_keyword.m_EMBEDDED) : null) != null) m_EMBEDDED.parent = this;
					break;
				case production_kind.g_keyword_26:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ENCODED = (p_keyword.m_ENCODED != null) ? new SyntaxTreeToken (p_keyword.m_ENCODED) : null) != null) m_ENCODED.parent = this;
					break;
				case production_kind.g_keyword_27:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ENCODING_CONTROL = (p_keyword.m_ENCODING_CONTROL != null) ? new SyntaxTreeToken (p_keyword.m_ENCODING_CONTROL) : null) != null) m_ENCODING_CONTROL.parent = this;
					break;
				case production_kind.g_keyword_28:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_END = (p_keyword.m_END != null) ? new SyntaxTreeToken (p_keyword.m_END) : null) != null) m_END.parent = this;
					break;
				case production_kind.g_keyword_29:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ENUMERATED = (p_keyword.m_ENUMERATED != null) ? new SyntaxTreeToken (p_keyword.m_ENUMERATED) : null) != null) m_ENUMERATED.parent = this;
					break;
				case production_kind.g_keyword_30:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EXCEPT = (p_keyword.m_EXCEPT != null) ? new SyntaxTreeToken (p_keyword.m_EXCEPT) : null) != null) m_EXCEPT.parent = this;
					break;
				case production_kind.g_keyword_31:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EXPLICIT = (p_keyword.m_EXPLICIT != null) ? new SyntaxTreeToken (p_keyword.m_EXPLICIT) : null) != null) m_EXPLICIT.parent = this;
					break;
				case production_kind.g_keyword_32:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EXPORTS = (p_keyword.m_EXPORTS != null) ? new SyntaxTreeToken (p_keyword.m_EXPORTS) : null) != null) m_EXPORTS.parent = this;
					break;
				case production_kind.g_keyword_33:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EXTENSIBILITY = (p_keyword.m_EXTENSIBILITY != null) ? new SyntaxTreeToken (p_keyword.m_EXTENSIBILITY) : null) != null) m_EXTENSIBILITY.parent = this;
					break;
				case production_kind.g_keyword_34:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EXTERNAL = (p_keyword.m_EXTERNAL != null) ? new SyntaxTreeToken (p_keyword.m_EXTERNAL) : null) != null) m_EXTERNAL.parent = this;
					break;
				case production_kind.g_keyword_35:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_FALSE = (p_keyword.m_FALSE != null) ? new SyntaxTreeToken (p_keyword.m_FALSE) : null) != null) m_FALSE.parent = this;
					break;
				case production_kind.g_keyword_36:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_FROM = (p_keyword.m_FROM != null) ? new SyntaxTreeToken (p_keyword.m_FROM) : null) != null) m_FROM.parent = this;
					break;
				case production_kind.g_keyword_37:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_GeneralizedTime = (p_keyword.m_GeneralizedTime != null) ? new SyntaxTreeToken (p_keyword.m_GeneralizedTime) : null) != null) m_GeneralizedTime.parent = this;
					break;
				case production_kind.g_keyword_38:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_GeneralString = (p_keyword.m_GeneralString != null) ? new SyntaxTreeToken (p_keyword.m_GeneralString) : null) != null) m_GeneralString.parent = this;
					break;
				case production_kind.g_keyword_39:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_GraphicString = (p_keyword.m_GraphicString != null) ? new SyntaxTreeToken (p_keyword.m_GraphicString) : null) != null) m_GraphicString.parent = this;
					break;
				case production_kind.g_keyword_40:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_IA5String = (p_keyword.m_IA5String != null) ? new SyntaxTreeToken (p_keyword.m_IA5String) : null) != null) m_IA5String.parent = this;
					break;
				case production_kind.g_keyword_41:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_IDENTIFIER = (p_keyword.m_IDENTIFIER != null) ? new SyntaxTreeToken (p_keyword.m_IDENTIFIER) : null) != null) m_IDENTIFIER.parent = this;
					break;
				case production_kind.g_keyword_42:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_IMPLICIT = (p_keyword.m_IMPLICIT != null) ? new SyntaxTreeToken (p_keyword.m_IMPLICIT) : null) != null) m_IMPLICIT.parent = this;
					break;
				case production_kind.g_keyword_43:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_IMPLIED = (p_keyword.m_IMPLIED != null) ? new SyntaxTreeToken (p_keyword.m_IMPLIED) : null) != null) m_IMPLIED.parent = this;
					break;
				case production_kind.g_keyword_44:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_IMPORTS = (p_keyword.m_IMPORTS != null) ? new SyntaxTreeToken (p_keyword.m_IMPORTS) : null) != null) m_IMPORTS.parent = this;
					break;
				case production_kind.g_keyword_45:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_INCLUDES = (p_keyword.m_INCLUDES != null) ? new SyntaxTreeToken (p_keyword.m_INCLUDES) : null) != null) m_INCLUDES.parent = this;
					break;
				case production_kind.g_keyword_46:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_INSTANCE = (p_keyword.m_INSTANCE != null) ? new SyntaxTreeToken (p_keyword.m_INSTANCE) : null) != null) m_INSTANCE.parent = this;
					break;
				case production_kind.g_keyword_47:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_INSTRUCTIONS = (p_keyword.m_INSTRUCTIONS != null) ? new SyntaxTreeToken (p_keyword.m_INSTRUCTIONS) : null) != null) m_INSTRUCTIONS.parent = this;
					break;
				case production_kind.g_keyword_48:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_INTEGER = (p_keyword.m_INTEGER != null) ? new SyntaxTreeToken (p_keyword.m_INTEGER) : null) != null) m_INTEGER.parent = this;
					break;
				case production_kind.g_keyword_49:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_INTERSECTION = (p_keyword.m_INTERSECTION != null) ? new SyntaxTreeToken (p_keyword.m_INTERSECTION) : null) != null) m_INTERSECTION.parent = this;
					break;
				case production_kind.g_keyword_50:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ISO646String = (p_keyword.m_ISO646String != null) ? new SyntaxTreeToken (p_keyword.m_ISO646String) : null) != null) m_ISO646String.parent = this;
					break;
				case production_kind.g_keyword_51:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MAX = (p_keyword.m_MAX != null) ? new SyntaxTreeToken (p_keyword.m_MAX) : null) != null) m_MAX.parent = this;
					break;
				case production_kind.g_keyword_52:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MIN = (p_keyword.m_MIN != null) ? new SyntaxTreeToken (p_keyword.m_MIN) : null) != null) m_MIN.parent = this;
					break;
				case production_kind.g_keyword_53:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MINUS_INFINITY = (p_keyword.m_MINUS_INFINITY != null) ? new SyntaxTreeToken (p_keyword.m_MINUS_INFINITY) : null) != null) m_MINUS_INFINITY.parent = this;
					break;
				case production_kind.g_keyword_54:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NOT_A_NUMBER = (p_keyword.m_NOT_A_NUMBER != null) ? new SyntaxTreeToken (p_keyword.m_NOT_A_NUMBER) : null) != null) m_NOT_A_NUMBER.parent = this;
					break;
				case production_kind.g_keyword_55:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NULL = (p_keyword.m_NULL != null) ? new SyntaxTreeToken (p_keyword.m_NULL) : null) != null) m_NULL.parent = this;
					break;
				case production_kind.g_keyword_56:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NumericString = (p_keyword.m_NumericString != null) ? new SyntaxTreeToken (p_keyword.m_NumericString) : null) != null) m_NumericString.parent = this;
					break;
				case production_kind.g_keyword_57:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OBJECT = (p_keyword.m_OBJECT != null) ? new SyntaxTreeToken (p_keyword.m_OBJECT) : null) != null) m_OBJECT.parent = this;
					break;
				case production_kind.g_keyword_58:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectDescriptor = (p_keyword.m_ObjectDescriptor != null) ? new SyntaxTreeToken (p_keyword.m_ObjectDescriptor) : null) != null) m_ObjectDescriptor.parent = this;
					break;
				case production_kind.g_keyword_59:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OCTET = (p_keyword.m_OCTET != null) ? new SyntaxTreeToken (p_keyword.m_OCTET) : null) != null) m_OCTET.parent = this;
					break;
				case production_kind.g_keyword_60:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OF = (p_keyword.m_OF != null) ? new SyntaxTreeToken (p_keyword.m_OF) : null) != null) m_OF.parent = this;
					break;
				case production_kind.g_keyword_61:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OID_IRI = (p_keyword.m_OID_IRI != null) ? new SyntaxTreeToken (p_keyword.m_OID_IRI) : null) != null) m_OID_IRI.parent = this;
					break;
				case production_kind.g_keyword_62:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OPTIONAL = (p_keyword.m_OPTIONAL != null) ? new SyntaxTreeToken (p_keyword.m_OPTIONAL) : null) != null) m_OPTIONAL.parent = this;
					break;
				case production_kind.g_keyword_63:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_PATTERN = (p_keyword.m_PATTERN != null) ? new SyntaxTreeToken (p_keyword.m_PATTERN) : null) != null) m_PATTERN.parent = this;
					break;
				case production_kind.g_keyword_64:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_PDV = (p_keyword.m_PDV != null) ? new SyntaxTreeToken (p_keyword.m_PDV) : null) != null) m_PDV.parent = this;
					break;
				case production_kind.g_keyword_65:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_PLUS_INFINITY = (p_keyword.m_PLUS_INFINITY != null) ? new SyntaxTreeToken (p_keyword.m_PLUS_INFINITY) : null) != null) m_PLUS_INFINITY.parent = this;
					break;
				case production_kind.g_keyword_66:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_PRESENT = (p_keyword.m_PRESENT != null) ? new SyntaxTreeToken (p_keyword.m_PRESENT) : null) != null) m_PRESENT.parent = this;
					break;
				case production_kind.g_keyword_67:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_PrintableString = (p_keyword.m_PrintableString != null) ? new SyntaxTreeToken (p_keyword.m_PrintableString) : null) != null) m_PrintableString.parent = this;
					break;
				case production_kind.g_keyword_68:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_PRIVATE = (p_keyword.m_PRIVATE != null) ? new SyntaxTreeToken (p_keyword.m_PRIVATE) : null) != null) m_PRIVATE.parent = this;
					break;
				case production_kind.g_keyword_69:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_REAL = (p_keyword.m_REAL != null) ? new SyntaxTreeToken (p_keyword.m_REAL) : null) != null) m_REAL.parent = this;
					break;
				case production_kind.g_keyword_70:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RELATIVE_OID = (p_keyword.m_RELATIVE_OID != null) ? new SyntaxTreeToken (p_keyword.m_RELATIVE_OID) : null) != null) m_RELATIVE_OID.parent = this;
					break;
				case production_kind.g_keyword_71:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RELATIVE_OID_IRI = (p_keyword.m_RELATIVE_OID_IRI != null) ? new SyntaxTreeToken (p_keyword.m_RELATIVE_OID_IRI) : null) != null) m_RELATIVE_OID_IRI.parent = this;
					break;
				case production_kind.g_keyword_72:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SEQUENCE = (p_keyword.m_SEQUENCE != null) ? new SyntaxTreeToken (p_keyword.m_SEQUENCE) : null) != null) m_SEQUENCE.parent = this;
					break;
				case production_kind.g_keyword_73:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SET = (p_keyword.m_SET != null) ? new SyntaxTreeToken (p_keyword.m_SET) : null) != null) m_SET.parent = this;
					break;
				case production_kind.g_keyword_74:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SETTINGS = (p_keyword.m_SETTINGS != null) ? new SyntaxTreeToken (p_keyword.m_SETTINGS) : null) != null) m_SETTINGS.parent = this;
					break;
				case production_kind.g_keyword_75:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SIZE = (p_keyword.m_SIZE != null) ? new SyntaxTreeToken (p_keyword.m_SIZE) : null) != null) m_SIZE.parent = this;
					break;
				case production_kind.g_keyword_76:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_STRING = (p_keyword.m_STRING != null) ? new SyntaxTreeToken (p_keyword.m_STRING) : null) != null) m_STRING.parent = this;
					break;
				case production_kind.g_keyword_77:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SYNTAX = (p_keyword.m_SYNTAX != null) ? new SyntaxTreeToken (p_keyword.m_SYNTAX) : null) != null) m_SYNTAX.parent = this;
					break;
				case production_kind.g_keyword_78:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_T61String = (p_keyword.m_T61String != null) ? new SyntaxTreeToken (p_keyword.m_T61String) : null) != null) m_T61String.parent = this;
					break;
				case production_kind.g_keyword_79:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TAGS = (p_keyword.m_TAGS != null) ? new SyntaxTreeToken (p_keyword.m_TAGS) : null) != null) m_TAGS.parent = this;
					break;
				case production_kind.g_keyword_80:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TeletexString = (p_keyword.m_TeletexString != null) ? new SyntaxTreeToken (p_keyword.m_TeletexString) : null) != null) m_TeletexString.parent = this;
					break;
				case production_kind.g_keyword_81:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TIME = (p_keyword.m_TIME != null) ? new SyntaxTreeToken (p_keyword.m_TIME) : null) != null) m_TIME.parent = this;
					break;
				case production_kind.g_keyword_82:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TIME_OF_DAY = (p_keyword.m_TIME_OF_DAY != null) ? new SyntaxTreeToken (p_keyword.m_TIME_OF_DAY) : null) != null) m_TIME_OF_DAY.parent = this;
					break;
				case production_kind.g_keyword_83:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TRUE = (p_keyword.m_TRUE != null) ? new SyntaxTreeToken (p_keyword.m_TRUE) : null) != null) m_TRUE.parent = this;
					break;
				case production_kind.g_keyword_84:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TYPE_IDENTIFIER = (p_keyword.m_TYPE_IDENTIFIER != null) ? new SyntaxTreeToken (p_keyword.m_TYPE_IDENTIFIER) : null) != null) m_TYPE_IDENTIFIER.parent = this;
					break;
				case production_kind.g_keyword_85:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UNION = (p_keyword.m_UNION != null) ? new SyntaxTreeToken (p_keyword.m_UNION) : null) != null) m_UNION.parent = this;
					break;
				case production_kind.g_keyword_86:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UNIQUE = (p_keyword.m_UNIQUE != null) ? new SyntaxTreeToken (p_keyword.m_UNIQUE) : null) != null) m_UNIQUE.parent = this;
					break;
				case production_kind.g_keyword_87:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UNIVERSAL = (p_keyword.m_UNIVERSAL != null) ? new SyntaxTreeToken (p_keyword.m_UNIVERSAL) : null) != null) m_UNIVERSAL.parent = this;
					break;
				case production_kind.g_keyword_88:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UniversalString = (p_keyword.m_UniversalString != null) ? new SyntaxTreeToken (p_keyword.m_UniversalString) : null) != null) m_UniversalString.parent = this;
					break;
				case production_kind.g_keyword_89:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UTCTime = (p_keyword.m_UTCTime != null) ? new SyntaxTreeToken (p_keyword.m_UTCTime) : null) != null) m_UTCTime.parent = this;
					break;
				case production_kind.g_keyword_90:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UTF8String = (p_keyword.m_UTF8String != null) ? new SyntaxTreeToken (p_keyword.m_UTF8String) : null) != null) m_UTF8String.parent = this;
					break;
				case production_kind.g_keyword_91:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_VideotexString = (p_keyword.m_VideotexString != null) ? new SyntaxTreeToken (p_keyword.m_VideotexString) : null) != null) m_VideotexString.parent = this;
					break;
				case production_kind.g_keyword_92:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_VisibleString = (p_keyword.m_VisibleString != null) ? new SyntaxTreeToken (p_keyword.m_VisibleString) : null) != null) m_VisibleString.parent = this;
					break;
				case production_kind.g_keyword_93:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_WITH = (p_keyword.m_WITH != null) ? new SyntaxTreeToken (p_keyword.m_WITH) : null) != null) m_WITH.parent = this;
					break;
				case production_kind.g_keyword_94:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ANY = (p_keyword.m_ANY != null) ? new SyntaxTreeToken (p_keyword.m_ANY) : null) != null) m_ANY.parent = this;
					break;
				case production_kind.g_keyword_95:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DEFINED = (p_keyword.m_DEFINED != null) ? new SyntaxTreeToken (p_keyword.m_DEFINED) : null) != null) m_DEFINED.parent = this;
					break;
				case production_kind.g_keyword_96:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MACRO = (p_keyword.m_MACRO != null) ? new SyntaxTreeToken (p_keyword.m_MACRO) : null) != null) m_MACRO.parent = this;
					break;
				case production_kind.g_keyword_97:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MACRO_BODY = (p_keyword.m_MACRO_BODY != null) ? new SyntaxTreeToken (p_keyword.m_MACRO_BODY) : null) != null) m_MACRO_BODY.parent = this;
					break;
				case production_kind.g_keyword_98:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MODULE_IDENTITY = (p_keyword.m_MODULE_IDENTITY != null) ? new SyntaxTreeToken (p_keyword.m_MODULE_IDENTITY) : null) != null) m_MODULE_IDENTITY.parent = this;
					break;
				case production_kind.g_keyword_99:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OBJECT_IDENTITY = (p_keyword.m_OBJECT_IDENTITY != null) ? new SyntaxTreeToken (p_keyword.m_OBJECT_IDENTITY) : null) != null) m_OBJECT_IDENTITY.parent = this;
					break;
				case production_kind.g_keyword_100:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OBJECT_TYPE = (p_keyword.m_OBJECT_TYPE != null) ? new SyntaxTreeToken (p_keyword.m_OBJECT_TYPE) : null) != null) m_OBJECT_TYPE.parent = this;
					break;
				case production_kind.g_keyword_101:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NOTIFICATION_TYPE = (p_keyword.m_NOTIFICATION_TYPE != null) ? new SyntaxTreeToken (p_keyword.m_NOTIFICATION_TYPE) : null) != null) m_NOTIFICATION_TYPE.parent = this;
					break;
				case production_kind.g_keyword_102:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TEXTUAL_CONVENTION = (p_keyword.m_TEXTUAL_CONVENTION != null) ? new SyntaxTreeToken (p_keyword.m_TEXTUAL_CONVENTION) : null) != null) m_TEXTUAL_CONVENTION.parent = this;
					break;
				case production_kind.g_keyword_103:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OBJECT_GROUP = (p_keyword.m_OBJECT_GROUP != null) ? new SyntaxTreeToken (p_keyword.m_OBJECT_GROUP) : null) != null) m_OBJECT_GROUP.parent = this;
					break;
				case production_kind.g_keyword_104:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NOTIFICATION_GROUP = (p_keyword.m_NOTIFICATION_GROUP != null) ? new SyntaxTreeToken (p_keyword.m_NOTIFICATION_GROUP) : null) != null) m_NOTIFICATION_GROUP.parent = this;
					break;
				case production_kind.g_keyword_105:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MODULE_COMPLIANCE = (p_keyword.m_MODULE_COMPLIANCE != null) ? new SyntaxTreeToken (p_keyword.m_MODULE_COMPLIANCE) : null) != null) m_MODULE_COMPLIANCE.parent = this;
					break;
				case production_kind.g_keyword_106:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_AGENT_CAPABILITIES = (p_keyword.m_AGENT_CAPABILITIES != null) ? new SyntaxTreeToken (p_keyword.m_AGENT_CAPABILITIES) : null) != null) m_AGENT_CAPABILITIES.parent = this;
					break;
				case production_kind.g_keyword_107:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TRAP_TYPE = (p_keyword.m_TRAP_TYPE != null) ? new SyntaxTreeToken (p_keyword.m_TRAP_TYPE) : null) != null) m_TRAP_TYPE.parent = this;
					break;
				case production_kind.g_keyword_108:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_LAST_UPDATED = (p_keyword.m_LAST_UPDATED != null) ? new SyntaxTreeToken (p_keyword.m_LAST_UPDATED) : null) != null) m_LAST_UPDATED.parent = this;
					break;
				case production_kind.g_keyword_109:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ORGANIZATION = (p_keyword.m_ORGANIZATION != null) ? new SyntaxTreeToken (p_keyword.m_ORGANIZATION) : null) != null) m_ORGANIZATION.parent = this;
					break;
				case production_kind.g_keyword_110:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_CONTACT_INFO = (p_keyword.m_CONTACT_INFO != null) ? new SyntaxTreeToken (p_keyword.m_CONTACT_INFO) : null) != null) m_CONTACT_INFO.parent = this;
					break;
				case production_kind.g_keyword_111:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DESCRIPTION = (p_keyword.m_DESCRIPTION != null) ? new SyntaxTreeToken (p_keyword.m_DESCRIPTION) : null) != null) m_DESCRIPTION.parent = this;
					break;
				case production_kind.g_keyword_112:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_REVISION = (p_keyword.m_REVISION != null) ? new SyntaxTreeToken (p_keyword.m_REVISION) : null) != null) m_REVISION.parent = this;
					break;
				case production_kind.g_keyword_113:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_STATUS = (p_keyword.m_STATUS != null) ? new SyntaxTreeToken (p_keyword.m_STATUS) : null) != null) m_STATUS.parent = this;
					break;
				case production_kind.g_keyword_114:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_REFERENCE = (p_keyword.m_REFERENCE != null) ? new SyntaxTreeToken (p_keyword.m_REFERENCE) : null) != null) m_REFERENCE.parent = this;
					break;
				case production_kind.g_keyword_115:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MAX_ACCESS = (p_keyword.m_MAX_ACCESS != null) ? new SyntaxTreeToken (p_keyword.m_MAX_ACCESS) : null) != null) m_MAX_ACCESS.parent = this;
					break;
				case production_kind.g_keyword_116:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_BITS = (p_keyword.m_BITS != null) ? new SyntaxTreeToken (p_keyword.m_BITS) : null) != null) m_BITS.parent = this;
					break;
				case production_kind.g_keyword_117:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UNITS = (p_keyword.m_UNITS != null) ? new SyntaxTreeToken (p_keyword.m_UNITS) : null) != null) m_UNITS.parent = this;
					break;
				case production_kind.g_keyword_118:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_INDEX = (p_keyword.m_INDEX != null) ? new SyntaxTreeToken (p_keyword.m_INDEX) : null) != null) m_INDEX.parent = this;
					break;
				case production_kind.g_keyword_119:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_AUGMENTS = (p_keyword.m_AUGMENTS != null) ? new SyntaxTreeToken (p_keyword.m_AUGMENTS) : null) != null) m_AUGMENTS.parent = this;
					break;
				case production_kind.g_keyword_120:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DEFVAL = (p_keyword.m_DEFVAL != null) ? new SyntaxTreeToken (p_keyword.m_DEFVAL) : null) != null) m_DEFVAL.parent = this;
					break;
				case production_kind.g_keyword_121:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OBJECTS = (p_keyword.m_OBJECTS != null) ? new SyntaxTreeToken (p_keyword.m_OBJECTS) : null) != null) m_OBJECTS.parent = this;
					break;
				case production_kind.g_keyword_122:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DISPLAY_HINT = (p_keyword.m_DISPLAY_HINT != null) ? new SyntaxTreeToken (p_keyword.m_DISPLAY_HINT) : null) != null) m_DISPLAY_HINT.parent = this;
					break;
				case production_kind.g_keyword_123:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NOTIFICATIONS = (p_keyword.m_NOTIFICATIONS != null) ? new SyntaxTreeToken (p_keyword.m_NOTIFICATIONS) : null) != null) m_NOTIFICATIONS.parent = this;
					break;
				case production_kind.g_keyword_124:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MODULE = (p_keyword.m_MODULE != null) ? new SyntaxTreeToken (p_keyword.m_MODULE) : null) != null) m_MODULE.parent = this;
					break;
				case production_kind.g_keyword_125:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MANDATORY_GROUPS = (p_keyword.m_MANDATORY_GROUPS != null) ? new SyntaxTreeToken (p_keyword.m_MANDATORY_GROUPS) : null) != null) m_MANDATORY_GROUPS.parent = this;
					break;
				case production_kind.g_keyword_126:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_GROUP = (p_keyword.m_GROUP != null) ? new SyntaxTreeToken (p_keyword.m_GROUP) : null) != null) m_GROUP.parent = this;
					break;
				case production_kind.g_keyword_127:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_WRITE_SYNTAX = (p_keyword.m_WRITE_SYNTAX != null) ? new SyntaxTreeToken (p_keyword.m_WRITE_SYNTAX) : null) != null) m_WRITE_SYNTAX.parent = this;
					break;
				case production_kind.g_keyword_128:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MIN_ACCESS = (p_keyword.m_MIN_ACCESS != null) ? new SyntaxTreeToken (p_keyword.m_MIN_ACCESS) : null) != null) m_MIN_ACCESS.parent = this;
					break;
				case production_kind.g_keyword_129:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_PRODUCT_RELEASE = (p_keyword.m_PRODUCT_RELEASE != null) ? new SyntaxTreeToken (p_keyword.m_PRODUCT_RELEASE) : null) != null) m_PRODUCT_RELEASE.parent = this;
					break;
				case production_kind.g_keyword_130:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SUPPORTS = (p_keyword.m_SUPPORTS != null) ? new SyntaxTreeToken (p_keyword.m_SUPPORTS) : null) != null) m_SUPPORTS.parent = this;
					break;
				case production_kind.g_keyword_131:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_VARIATION = (p_keyword.m_VARIATION != null) ? new SyntaxTreeToken (p_keyword.m_VARIATION) : null) != null) m_VARIATION.parent = this;
					break;
				case production_kind.g_keyword_132:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ACCESS = (p_keyword.m_ACCESS != null) ? new SyntaxTreeToken (p_keyword.m_ACCESS) : null) != null) m_ACCESS.parent = this;
					break;
				case production_kind.g_keyword_133:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_CREATION_REQUIRES = (p_keyword.m_CREATION_REQUIRES != null) ? new SyntaxTreeToken (p_keyword.m_CREATION_REQUIRES) : null) != null) m_CREATION_REQUIRES.parent = this;
					break;
				case production_kind.g_keyword_134:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ENTERPRISE = (p_keyword.m_ENTERPRISE != null) ? new SyntaxTreeToken (p_keyword.m_ENTERPRISE) : null) != null) m_ENTERPRISE.parent = this;
					break;
				case production_kind.g_keyword_135:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_VARIABLES = (p_keyword.m_VARIABLES != null) ? new SyntaxTreeToken (p_keyword.m_VARIABLES) : null) != null) m_VARIABLES.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "keyword" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new keyword (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DESCENDANTS?.Dispose ();
			m_SUCCESSORS?.Dispose ();
			m_ABSENT?.Dispose ();
			m_ABSTRACT_SYNTAX?.Dispose ();
			m_ALL?.Dispose ();
			m_APPLICATION?.Dispose ();
			m_AUTOMATIC?.Dispose ();
			m_BEGIN?.Dispose ();
			m_BIT?.Dispose ();
			m_BMPString?.Dispose ();
			m_BOOLEAN?.Dispose ();
			m_BY?.Dispose ();
			m_CHARACTER?.Dispose ();
			m_CHOICE?.Dispose ();
			m_CLASS?.Dispose ();
			m_COMPONENT?.Dispose ();
			m_COMPONENTS?.Dispose ();
			m_CONSTRAINED?.Dispose ();
			m_CONTAINING?.Dispose ();
			m_DATE?.Dispose ();
			m_DATE_TIME?.Dispose ();
			m_DEFAULT?.Dispose ();
			m_DEFINITIONS?.Dispose ();
			m_DURATION?.Dispose ();
			m_EMBEDDED?.Dispose ();
			m_ENCODED?.Dispose ();
			m_ENCODING_CONTROL?.Dispose ();
			m_END?.Dispose ();
			m_ENUMERATED?.Dispose ();
			m_EXCEPT?.Dispose ();
			m_EXPLICIT?.Dispose ();
			m_EXPORTS?.Dispose ();
			m_EXTENSIBILITY?.Dispose ();
			m_EXTERNAL?.Dispose ();
			m_FALSE?.Dispose ();
			m_FROM?.Dispose ();
			m_GeneralizedTime?.Dispose ();
			m_GeneralString?.Dispose ();
			m_GraphicString?.Dispose ();
			m_IA5String?.Dispose ();
			m_IDENTIFIER?.Dispose ();
			m_IMPLICIT?.Dispose ();
			m_IMPLIED?.Dispose ();
			m_IMPORTS?.Dispose ();
			m_INCLUDES?.Dispose ();
			m_INSTANCE?.Dispose ();
			m_INSTRUCTIONS?.Dispose ();
			m_INTEGER?.Dispose ();
			m_INTERSECTION?.Dispose ();
			m_ISO646String?.Dispose ();
			m_MAX?.Dispose ();
			m_MIN?.Dispose ();
			m_MINUS_INFINITY?.Dispose ();
			m_NOT_A_NUMBER?.Dispose ();
			m_NULL?.Dispose ();
			m_NumericString?.Dispose ();
			m_OBJECT?.Dispose ();
			m_ObjectDescriptor?.Dispose ();
			m_OCTET?.Dispose ();
			m_OF?.Dispose ();
			m_OID_IRI?.Dispose ();
			m_OPTIONAL?.Dispose ();
			m_PATTERN?.Dispose ();
			m_PDV?.Dispose ();
			m_PLUS_INFINITY?.Dispose ();
			m_PRESENT?.Dispose ();
			m_PrintableString?.Dispose ();
			m_PRIVATE?.Dispose ();
			m_REAL?.Dispose ();
			m_RELATIVE_OID?.Dispose ();
			m_RELATIVE_OID_IRI?.Dispose ();
			m_SEQUENCE?.Dispose ();
			m_SET?.Dispose ();
			m_SETTINGS?.Dispose ();
			m_SIZE?.Dispose ();
			m_STRING?.Dispose ();
			m_SYNTAX?.Dispose ();
			m_T61String?.Dispose ();
			m_TAGS?.Dispose ();
			m_TeletexString?.Dispose ();
			m_TIME?.Dispose ();
			m_TIME_OF_DAY?.Dispose ();
			m_TRUE?.Dispose ();
			m_TYPE_IDENTIFIER?.Dispose ();
			m_UNION?.Dispose ();
			m_UNIQUE?.Dispose ();
			m_UNIVERSAL?.Dispose ();
			m_UniversalString?.Dispose ();
			m_UTCTime?.Dispose ();
			m_UTF8String?.Dispose ();
			m_VideotexString?.Dispose ();
			m_VisibleString?.Dispose ();
			m_WITH?.Dispose ();
			m_ANY?.Dispose ();
			m_DEFINED?.Dispose ();
			m_MACRO?.Dispose ();
			m_MACRO_BODY?.Dispose ();
			m_MODULE_IDENTITY?.Dispose ();
			m_OBJECT_IDENTITY?.Dispose ();
			m_OBJECT_TYPE?.Dispose ();
			m_NOTIFICATION_TYPE?.Dispose ();
			m_TEXTUAL_CONVENTION?.Dispose ();
			m_OBJECT_GROUP?.Dispose ();
			m_NOTIFICATION_GROUP?.Dispose ();
			m_MODULE_COMPLIANCE?.Dispose ();
			m_AGENT_CAPABILITIES?.Dispose ();
			m_TRAP_TYPE?.Dispose ();
			m_LAST_UPDATED?.Dispose ();
			m_ORGANIZATION?.Dispose ();
			m_CONTACT_INFO?.Dispose ();
			m_DESCRIPTION?.Dispose ();
			m_REVISION?.Dispose ();
			m_STATUS?.Dispose ();
			m_REFERENCE?.Dispose ();
			m_MAX_ACCESS?.Dispose ();
			m_BITS?.Dispose ();
			m_UNITS?.Dispose ();
			m_INDEX?.Dispose ();
			m_AUGMENTS?.Dispose ();
			m_DEFVAL?.Dispose ();
			m_OBJECTS?.Dispose ();
			m_DISPLAY_HINT?.Dispose ();
			m_NOTIFICATIONS?.Dispose ();
			m_MODULE?.Dispose ();
			m_MANDATORY_GROUPS?.Dispose ();
			m_GROUP?.Dispose ();
			m_WRITE_SYNTAX?.Dispose ();
			m_MIN_ACCESS?.Dispose ();
			m_PRODUCT_RELEASE?.Dispose ();
			m_SUPPORTS?.Dispose ();
			m_VARIATION?.Dispose ();
			m_ACCESS?.Dispose ();
			m_CREATION_REQUIRES?.Dispose ();
			m_ENTERPRISE?.Dispose ();
			m_VARIABLES?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule keyword

		// Content changing function(s) associated with production(s) of syntax rule keyword

		//
		// Content changing function associated with following production(s)
		// keyword -> DESCENDANTS

		// keyword -> SUCCESSORS

		// keyword -> ABSENT

		// keyword -> ABSTRACT-SYNTAX

		// keyword -> ALL

		// keyword -> APPLICATION

		// keyword -> AUTOMATIC

		// keyword -> BEGIN

		// keyword -> BIT

		// keyword -> BMPString

		// keyword -> BOOLEAN

		// keyword -> BY

		// keyword -> CHARACTER

		// keyword -> CHOICE

		// keyword -> CLASS

		// keyword -> COMPONENT

		// keyword -> COMPONENTS

		// keyword -> CONSTRAINED

		// keyword -> CONTAINING

		// keyword -> DATE

		// keyword -> DATE-TIME

		// keyword -> DEFAULT

		// keyword -> DEFINITIONS

		// keyword -> DURATION

		// keyword -> EMBEDDED

		// keyword -> ENCODED

		// keyword -> ENCODING-CONTROL

		// keyword -> END

		// keyword -> ENUMERATED

		// keyword -> EXCEPT

		// keyword -> EXPLICIT

		// keyword -> EXPORTS

		// keyword -> EXTENSIBILITY

		// keyword -> EXTERNAL

		// keyword -> FALSE

		// keyword -> FROM

		// keyword -> GeneralizedTime

		// keyword -> GeneralString

		// keyword -> GraphicString

		// keyword -> IA5String

		// keyword -> IDENTIFIER

		// keyword -> IMPLICIT

		// keyword -> IMPLIED

		// keyword -> IMPORTS

		// keyword -> INCLUDES

		// keyword -> INSTANCE

		// keyword -> INSTRUCTIONS

		// keyword -> INTEGER

		// keyword -> INTERSECTION

		// keyword -> ISO646String

		// keyword -> MAX

		// keyword -> MIN

		// keyword -> MINUS-INFINITY

		// keyword -> NOT-A-NUMBER

		// keyword -> NULL

		// keyword -> NumericString

		// keyword -> OBJECT

		// keyword -> ObjectDescriptor

		// keyword -> OCTET

		// keyword -> OF

		// keyword -> OID-IRI

		// keyword -> OPTIONAL

		// keyword -> PATTERN

		// keyword -> PDV

		// keyword -> PLUS-INFINITY

		// keyword -> PRESENT

		// keyword -> PrintableString

		// keyword -> PRIVATE

		// keyword -> REAL

		// keyword -> RELATIVE-OID

		// keyword -> RELATIVE-OID-IRI

		// keyword -> SEQUENCE

		// keyword -> SET

		// keyword -> SETTINGS

		// keyword -> SIZE

		// keyword -> STRING

		// keyword -> SYNTAX

		// keyword -> T61String

		// keyword -> TAGS

		// keyword -> TeletexString

		// keyword -> TIME

		// keyword -> TIME-OF-DAY

		// keyword -> TRUE

		// keyword -> TYPE-IDENTIFIER

		// keyword -> UNION

		// keyword -> UNIQUE

		// keyword -> UNIVERSAL

		// keyword -> UniversalString

		// keyword -> UTCTime

		// keyword -> UTF8String

		// keyword -> VideotexString

		// keyword -> VisibleString

		// keyword -> WITH

		// keyword -> ANY

		// keyword -> DEFINED

		// keyword -> MACRO

		// keyword -> MACRO-BODY

		// keyword -> MODULE-IDENTITY

		// keyword -> OBJECT-IDENTITY

		// keyword -> OBJECT-TYPE

		// keyword -> NOTIFICATION-TYPE

		// keyword -> TEXTUAL-CONVENTION

		// keyword -> OBJECT-GROUP

		// keyword -> NOTIFICATION-GROUP

		// keyword -> MODULE-COMPLIANCE

		// keyword -> AGENT-CAPABILITIES

		// keyword -> TRAP-TYPE

		// keyword -> LAST-UPDATED

		// keyword -> ORGANIZATION

		// keyword -> CONTACT-INFO

		// keyword -> DESCRIPTION

		// keyword -> REVISION

		// keyword -> STATUS

		// keyword -> REFERENCE

		// keyword -> MAX-ACCESS

		// keyword -> BITS

		// keyword -> UNITS

		// keyword -> INDEX

		// keyword -> AUGMENTS

		// keyword -> DEFVAL

		// keyword -> OBJECTS

		// keyword -> DISPLAY-HINT

		// keyword -> NOTIFICATIONS

		// keyword -> MODULE

		// keyword -> MANDATORY-GROUPS

		// keyword -> GROUP

		// keyword -> WRITE-SYNTAX

		// keyword -> MIN-ACCESS

		// keyword -> PRODUCT-RELEASE

		// keyword -> SUPPORTS

		// keyword -> VARIATION

		// keyword -> ACCESS

		// keyword -> CREATION-REQUIRES

		// keyword -> ENTERPRISE

		// keyword -> VARIABLES

		//

		public void change(SyntaxTreeToken p_token, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_keyword_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_DESCENDANTS = p_token;
				break;
			case production_kind.g_keyword_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_SUCCESSORS = p_token;
				break;
			case production_kind.g_keyword_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_ABSENT = p_token;
				break;
			case production_kind.g_keyword_4:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_ABSTRACT_SYNTAX = p_token;
				break;
			case production_kind.g_keyword_5:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_ALL = p_token;
				break;
			case production_kind.g_keyword_6:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_APPLICATION = p_token;
				break;
			case production_kind.g_keyword_7:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_AUTOMATIC = p_token;
				break;
			case production_kind.g_keyword_8:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_BEGIN = p_token;
				break;
			case production_kind.g_keyword_9:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_BIT = p_token;
				break;
			case production_kind.g_keyword_10:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_BMPString = p_token;
				break;
			case production_kind.g_keyword_11:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_BOOLEAN = p_token;
				break;
			case production_kind.g_keyword_12:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_BY = p_token;
				break;
			case production_kind.g_keyword_13:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_CHARACTER = p_token;
				break;
			case production_kind.g_keyword_14:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_CHOICE = p_token;
				break;
			case production_kind.g_keyword_15:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_CLASS = p_token;
				break;
			case production_kind.g_keyword_16:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_COMPONENT = p_token;
				break;
			case production_kind.g_keyword_17:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_COMPONENTS = p_token;
				break;
			case production_kind.g_keyword_18:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_CONSTRAINED = p_token;
				break;
			case production_kind.g_keyword_19:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_CONTAINING = p_token;
				break;
			case production_kind.g_keyword_20:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_DATE = p_token;
				break;
			case production_kind.g_keyword_21:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_DATE_TIME = p_token;
				break;
			case production_kind.g_keyword_22:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_DEFAULT = p_token;
				break;
			case production_kind.g_keyword_23:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_DEFINITIONS = p_token;
				break;
			case production_kind.g_keyword_24:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_DURATION = p_token;
				break;
			case production_kind.g_keyword_25:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_EMBEDDED = p_token;
				break;
			case production_kind.g_keyword_26:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_ENCODED = p_token;
				break;
			case production_kind.g_keyword_27:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_ENCODING_CONTROL = p_token;
				break;
			case production_kind.g_keyword_28:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_END = p_token;
				break;
			case production_kind.g_keyword_29:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_ENUMERATED = p_token;
				break;
			case production_kind.g_keyword_30:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_EXCEPT = p_token;
				break;
			case production_kind.g_keyword_31:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_EXPLICIT = p_token;
				break;
			case production_kind.g_keyword_32:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_EXPORTS = p_token;
				break;
			case production_kind.g_keyword_33:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_EXTENSIBILITY = p_token;
				break;
			case production_kind.g_keyword_34:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_EXTERNAL = p_token;
				break;
			case production_kind.g_keyword_35:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_FALSE = p_token;
				break;
			case production_kind.g_keyword_36:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_FROM = p_token;
				break;
			case production_kind.g_keyword_37:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_GeneralizedTime = p_token;
				break;
			case production_kind.g_keyword_38:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_GeneralString = p_token;
				break;
			case production_kind.g_keyword_39:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_GraphicString = p_token;
				break;
			case production_kind.g_keyword_40:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_IA5String = p_token;
				break;
			case production_kind.g_keyword_41:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_IDENTIFIER = p_token;
				break;
			case production_kind.g_keyword_42:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_IMPLICIT = p_token;
				break;
			case production_kind.g_keyword_43:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_IMPLIED = p_token;
				break;
			case production_kind.g_keyword_44:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_IMPORTS = p_token;
				break;
			case production_kind.g_keyword_45:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_INCLUDES = p_token;
				break;
			case production_kind.g_keyword_46:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_INSTANCE = p_token;
				break;
			case production_kind.g_keyword_47:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_INSTRUCTIONS = p_token;
				break;
			case production_kind.g_keyword_48:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_INTEGER = p_token;
				break;
			case production_kind.g_keyword_49:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_INTERSECTION = p_token;
				break;
			case production_kind.g_keyword_50:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_ISO646String = p_token;
				break;
			case production_kind.g_keyword_51:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_MAX = p_token;
				break;
			case production_kind.g_keyword_52:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_MIN = p_token;
				break;
			case production_kind.g_keyword_53:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_MINUS_INFINITY = p_token;
				break;
			case production_kind.g_keyword_54:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_NOT_A_NUMBER = p_token;
				break;
			case production_kind.g_keyword_55:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_NULL = p_token;
				break;
			case production_kind.g_keyword_56:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_NumericString = p_token;
				break;
			case production_kind.g_keyword_57:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_OBJECT = p_token;
				break;
			case production_kind.g_keyword_58:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_ObjectDescriptor = p_token;
				break;
			case production_kind.g_keyword_59:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_OCTET = p_token;
				break;
			case production_kind.g_keyword_60:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_OF = p_token;
				break;
			case production_kind.g_keyword_61:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_OID_IRI = p_token;
				break;
			case production_kind.g_keyword_62:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_OPTIONAL = p_token;
				break;
			case production_kind.g_keyword_63:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_PATTERN = p_token;
				break;
			case production_kind.g_keyword_64:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_PDV = p_token;
				break;
			case production_kind.g_keyword_65:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_PLUS_INFINITY = p_token;
				break;
			case production_kind.g_keyword_66:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_PRESENT = p_token;
				break;
			case production_kind.g_keyword_67:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_PrintableString = p_token;
				break;
			case production_kind.g_keyword_68:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_PRIVATE = p_token;
				break;
			case production_kind.g_keyword_69:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_REAL = p_token;
				break;
			case production_kind.g_keyword_70:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_RELATIVE_OID = p_token;
				break;
			case production_kind.g_keyword_71:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_RELATIVE_OID_IRI = p_token;
				break;
			case production_kind.g_keyword_72:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_SEQUENCE = p_token;
				break;
			case production_kind.g_keyword_73:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_SET = p_token;
				break;
			case production_kind.g_keyword_74:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_SETTINGS = p_token;
				break;
			case production_kind.g_keyword_75:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_SIZE = p_token;
				break;
			case production_kind.g_keyword_76:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_STRING = p_token;
				break;
			case production_kind.g_keyword_77:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_SYNTAX = p_token;
				break;
			case production_kind.g_keyword_78:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_T61String = p_token;
				break;
			case production_kind.g_keyword_79:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_TAGS = p_token;
				break;
			case production_kind.g_keyword_80:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_TeletexString = p_token;
				break;
			case production_kind.g_keyword_81:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_TIME = p_token;
				break;
			case production_kind.g_keyword_82:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_TIME_OF_DAY = p_token;
				break;
			case production_kind.g_keyword_83:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_TRUE = p_token;
				break;
			case production_kind.g_keyword_84:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_TYPE_IDENTIFIER = p_token;
				break;
			case production_kind.g_keyword_85:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_UNION = p_token;
				break;
			case production_kind.g_keyword_86:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_UNIQUE = p_token;
				break;
			case production_kind.g_keyword_87:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_UNIVERSAL = p_token;
				break;
			case production_kind.g_keyword_88:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_UniversalString = p_token;
				break;
			case production_kind.g_keyword_89:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_UTCTime = p_token;
				break;
			case production_kind.g_keyword_90:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_UTF8String = p_token;
				break;
			case production_kind.g_keyword_91:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_VideotexString = p_token;
				break;
			case production_kind.g_keyword_92:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_VisibleString = p_token;
				break;
			case production_kind.g_keyword_93:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_WITH = p_token;
				break;
			case production_kind.g_keyword_94:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_ANY = p_token;
				break;
			case production_kind.g_keyword_95:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_DEFINED = p_token;
				break;
			case production_kind.g_keyword_96:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_MACRO = p_token;
				break;
			case production_kind.g_keyword_97:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_MACRO_BODY = p_token;
				break;
			case production_kind.g_keyword_98:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_MODULE_IDENTITY = p_token;
				break;
			case production_kind.g_keyword_99:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_OBJECT_IDENTITY = p_token;
				break;
			case production_kind.g_keyword_100:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_OBJECT_TYPE = p_token;
				break;
			case production_kind.g_keyword_101:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_NOTIFICATION_TYPE = p_token;
				break;
			case production_kind.g_keyword_102:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_TEXTUAL_CONVENTION = p_token;
				break;
			case production_kind.g_keyword_103:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_OBJECT_GROUP = p_token;
				break;
			case production_kind.g_keyword_104:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_NOTIFICATION_GROUP = p_token;
				break;
			case production_kind.g_keyword_105:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_MODULE_COMPLIANCE = p_token;
				break;
			case production_kind.g_keyword_106:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_AGENT_CAPABILITIES = p_token;
				break;
			case production_kind.g_keyword_107:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_TRAP_TYPE = p_token;
				break;
			case production_kind.g_keyword_108:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_LAST_UPDATED = p_token;
				break;
			case production_kind.g_keyword_109:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_ORGANIZATION = p_token;
				break;
			case production_kind.g_keyword_110:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_CONTACT_INFO = p_token;
				break;
			case production_kind.g_keyword_111:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_DESCRIPTION = p_token;
				break;
			case production_kind.g_keyword_112:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_REVISION = p_token;
				break;
			case production_kind.g_keyword_113:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_STATUS = p_token;
				break;
			case production_kind.g_keyword_114:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_REFERENCE = p_token;
				break;
			case production_kind.g_keyword_115:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_MAX_ACCESS = p_token;
				break;
			case production_kind.g_keyword_116:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_BITS = p_token;
				break;
			case production_kind.g_keyword_117:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_UNITS = p_token;
				break;
			case production_kind.g_keyword_118:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_INDEX = p_token;
				break;
			case production_kind.g_keyword_119:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_AUGMENTS = p_token;
				break;
			case production_kind.g_keyword_120:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_DEFVAL = p_token;
				break;
			case production_kind.g_keyword_121:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_OBJECTS = p_token;
				break;
			case production_kind.g_keyword_122:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_DISPLAY_HINT = p_token;
				break;
			case production_kind.g_keyword_123:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_NOTIFICATIONS = p_token;
				break;
			case production_kind.g_keyword_124:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_MODULE = p_token;
				break;
			case production_kind.g_keyword_125:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_MANDATORY_GROUPS = p_token;
				break;
			case production_kind.g_keyword_126:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_GROUP = p_token;
				break;
			case production_kind.g_keyword_127:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_WRITE_SYNTAX = p_token;
				break;
			case production_kind.g_keyword_128:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_MIN_ACCESS = p_token;
				break;
			case production_kind.g_keyword_129:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_PRODUCT_RELEASE = p_token;
				break;
			case production_kind.g_keyword_130:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_SUPPORTS = p_token;
				break;
			case production_kind.g_keyword_131:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_VARIATION = p_token;
				break;
			case production_kind.g_keyword_132:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_ACCESS = p_token;
				break;
			case production_kind.g_keyword_133:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_CREATION_REQUIRES = p_token;
				break;
			case production_kind.g_keyword_134:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_ENTERPRISE = p_token;
				break;
			case production_kind.g_keyword_135:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_VARIABLES = p_token;
				break;
			default:
				{
					string[] args = new string[] { "keyword" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule keyword
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DESCENDANTS != null) && m_DESCENDANTS.checkInclusion (element) ||
				(m_SUCCESSORS != null) && m_SUCCESSORS.checkInclusion (element) ||
				(m_ABSENT != null) && m_ABSENT.checkInclusion (element) ||
				(m_ABSTRACT_SYNTAX != null) && m_ABSTRACT_SYNTAX.checkInclusion (element) ||
				(m_ALL != null) && m_ALL.checkInclusion (element) ||
				(m_APPLICATION != null) && m_APPLICATION.checkInclusion (element) ||
				(m_AUTOMATIC != null) && m_AUTOMATIC.checkInclusion (element) ||
				(m_BEGIN != null) && m_BEGIN.checkInclusion (element) ||
				(m_BIT != null) && m_BIT.checkInclusion (element) ||
				(m_BMPString != null) && m_BMPString.checkInclusion (element) ||
				(m_BOOLEAN != null) && m_BOOLEAN.checkInclusion (element) ||
				(m_BY != null) && m_BY.checkInclusion (element) ||
				(m_CHARACTER != null) && m_CHARACTER.checkInclusion (element) ||
				(m_CHOICE != null) && m_CHOICE.checkInclusion (element) ||
				(m_CLASS != null) && m_CLASS.checkInclusion (element) ||
				(m_COMPONENT != null) && m_COMPONENT.checkInclusion (element) ||
				(m_COMPONENTS != null) && m_COMPONENTS.checkInclusion (element) ||
				(m_CONSTRAINED != null) && m_CONSTRAINED.checkInclusion (element) ||
				(m_CONTAINING != null) && m_CONTAINING.checkInclusion (element) ||
				(m_DATE != null) && m_DATE.checkInclusion (element) ||
				(m_DATE_TIME != null) && m_DATE_TIME.checkInclusion (element) ||
				(m_DEFAULT != null) && m_DEFAULT.checkInclusion (element) ||
				(m_DEFINITIONS != null) && m_DEFINITIONS.checkInclusion (element) ||
				(m_DURATION != null) && m_DURATION.checkInclusion (element) ||
				(m_EMBEDDED != null) && m_EMBEDDED.checkInclusion (element) ||
				(m_ENCODED != null) && m_ENCODED.checkInclusion (element) ||
				(m_ENCODING_CONTROL != null) && m_ENCODING_CONTROL.checkInclusion (element) ||
				(m_END != null) && m_END.checkInclusion (element) ||
				(m_ENUMERATED != null) && m_ENUMERATED.checkInclusion (element) ||
				(m_EXCEPT != null) && m_EXCEPT.checkInclusion (element) ||
				(m_EXPLICIT != null) && m_EXPLICIT.checkInclusion (element) ||
				(m_EXPORTS != null) && m_EXPORTS.checkInclusion (element) ||
				(m_EXTENSIBILITY != null) && m_EXTENSIBILITY.checkInclusion (element) ||
				(m_EXTERNAL != null) && m_EXTERNAL.checkInclusion (element) ||
				(m_FALSE != null) && m_FALSE.checkInclusion (element) ||
				(m_FROM != null) && m_FROM.checkInclusion (element) ||
				(m_GeneralizedTime != null) && m_GeneralizedTime.checkInclusion (element) ||
				(m_GeneralString != null) && m_GeneralString.checkInclusion (element) ||
				(m_GraphicString != null) && m_GraphicString.checkInclusion (element) ||
				(m_IA5String != null) && m_IA5String.checkInclusion (element) ||
				(m_IDENTIFIER != null) && m_IDENTIFIER.checkInclusion (element) ||
				(m_IMPLICIT != null) && m_IMPLICIT.checkInclusion (element) ||
				(m_IMPLIED != null) && m_IMPLIED.checkInclusion (element) ||
				(m_IMPORTS != null) && m_IMPORTS.checkInclusion (element) ||
				(m_INCLUDES != null) && m_INCLUDES.checkInclusion (element) ||
				(m_INSTANCE != null) && m_INSTANCE.checkInclusion (element) ||
				(m_INSTRUCTIONS != null) && m_INSTRUCTIONS.checkInclusion (element) ||
				(m_INTEGER != null) && m_INTEGER.checkInclusion (element) ||
				(m_INTERSECTION != null) && m_INTERSECTION.checkInclusion (element) ||
				(m_ISO646String != null) && m_ISO646String.checkInclusion (element) ||
				(m_MAX != null) && m_MAX.checkInclusion (element) ||
				(m_MIN != null) && m_MIN.checkInclusion (element) ||
				(m_MINUS_INFINITY != null) && m_MINUS_INFINITY.checkInclusion (element) ||
				(m_NOT_A_NUMBER != null) && m_NOT_A_NUMBER.checkInclusion (element) ||
				(m_NULL != null) && m_NULL.checkInclusion (element) ||
				(m_NumericString != null) && m_NumericString.checkInclusion (element) ||
				(m_OBJECT != null) && m_OBJECT.checkInclusion (element) ||
				(m_ObjectDescriptor != null) && m_ObjectDescriptor.checkInclusion (element) ||
				(m_OCTET != null) && m_OCTET.checkInclusion (element) ||
				(m_OF != null) && m_OF.checkInclusion (element) ||
				(m_OID_IRI != null) && m_OID_IRI.checkInclusion (element) ||
				(m_OPTIONAL != null) && m_OPTIONAL.checkInclusion (element) ||
				(m_PATTERN != null) && m_PATTERN.checkInclusion (element) ||
				(m_PDV != null) && m_PDV.checkInclusion (element) ||
				(m_PLUS_INFINITY != null) && m_PLUS_INFINITY.checkInclusion (element) ||
				(m_PRESENT != null) && m_PRESENT.checkInclusion (element) ||
				(m_PrintableString != null) && m_PrintableString.checkInclusion (element) ||
				(m_PRIVATE != null) && m_PRIVATE.checkInclusion (element) ||
				(m_REAL != null) && m_REAL.checkInclusion (element) ||
				(m_RELATIVE_OID != null) && m_RELATIVE_OID.checkInclusion (element) ||
				(m_RELATIVE_OID_IRI != null) && m_RELATIVE_OID_IRI.checkInclusion (element) ||
				(m_SEQUENCE != null) && m_SEQUENCE.checkInclusion (element) ||
				(m_SET != null) && m_SET.checkInclusion (element) ||
				(m_SETTINGS != null) && m_SETTINGS.checkInclusion (element) ||
				(m_SIZE != null) && m_SIZE.checkInclusion (element) ||
				(m_STRING != null) && m_STRING.checkInclusion (element) ||
				(m_SYNTAX != null) && m_SYNTAX.checkInclusion (element) ||
				(m_T61String != null) && m_T61String.checkInclusion (element) ||
				(m_TAGS != null) && m_TAGS.checkInclusion (element) ||
				(m_TeletexString != null) && m_TeletexString.checkInclusion (element) ||
				(m_TIME != null) && m_TIME.checkInclusion (element) ||
				(m_TIME_OF_DAY != null) && m_TIME_OF_DAY.checkInclusion (element) ||
				(m_TRUE != null) && m_TRUE.checkInclusion (element) ||
				(m_TYPE_IDENTIFIER != null) && m_TYPE_IDENTIFIER.checkInclusion (element) ||
				(m_UNION != null) && m_UNION.checkInclusion (element) ||
				(m_UNIQUE != null) && m_UNIQUE.checkInclusion (element) ||
				(m_UNIVERSAL != null) && m_UNIVERSAL.checkInclusion (element) ||
				(m_UniversalString != null) && m_UniversalString.checkInclusion (element) ||
				(m_UTCTime != null) && m_UTCTime.checkInclusion (element) ||
				(m_UTF8String != null) && m_UTF8String.checkInclusion (element) ||
				(m_VideotexString != null) && m_VideotexString.checkInclusion (element) ||
				(m_VisibleString != null) && m_VisibleString.checkInclusion (element) ||
				(m_WITH != null) && m_WITH.checkInclusion (element) ||
				(m_ANY != null) && m_ANY.checkInclusion (element) ||
				(m_DEFINED != null) && m_DEFINED.checkInclusion (element) ||
				(m_MACRO != null) && m_MACRO.checkInclusion (element) ||
				(m_MACRO_BODY != null) && m_MACRO_BODY.checkInclusion (element) ||
				(m_MODULE_IDENTITY != null) && m_MODULE_IDENTITY.checkInclusion (element) ||
				(m_OBJECT_IDENTITY != null) && m_OBJECT_IDENTITY.checkInclusion (element) ||
				(m_OBJECT_TYPE != null) && m_OBJECT_TYPE.checkInclusion (element) ||
				(m_NOTIFICATION_TYPE != null) && m_NOTIFICATION_TYPE.checkInclusion (element) ||
				(m_TEXTUAL_CONVENTION != null) && m_TEXTUAL_CONVENTION.checkInclusion (element) ||
				(m_OBJECT_GROUP != null) && m_OBJECT_GROUP.checkInclusion (element) ||
				(m_NOTIFICATION_GROUP != null) && m_NOTIFICATION_GROUP.checkInclusion (element) ||
				(m_MODULE_COMPLIANCE != null) && m_MODULE_COMPLIANCE.checkInclusion (element) ||
				(m_AGENT_CAPABILITIES != null) && m_AGENT_CAPABILITIES.checkInclusion (element) ||
				(m_TRAP_TYPE != null) && m_TRAP_TYPE.checkInclusion (element) ||
				(m_LAST_UPDATED != null) && m_LAST_UPDATED.checkInclusion (element) ||
				(m_ORGANIZATION != null) && m_ORGANIZATION.checkInclusion (element) ||
				(m_CONTACT_INFO != null) && m_CONTACT_INFO.checkInclusion (element) ||
				(m_DESCRIPTION != null) && m_DESCRIPTION.checkInclusion (element) ||
				(m_REVISION != null) && m_REVISION.checkInclusion (element) ||
				(m_STATUS != null) && m_STATUS.checkInclusion (element) ||
				(m_REFERENCE != null) && m_REFERENCE.checkInclusion (element) ||
				(m_MAX_ACCESS != null) && m_MAX_ACCESS.checkInclusion (element) ||
				(m_BITS != null) && m_BITS.checkInclusion (element) ||
				(m_UNITS != null) && m_UNITS.checkInclusion (element) ||
				(m_INDEX != null) && m_INDEX.checkInclusion (element) ||
				(m_AUGMENTS != null) && m_AUGMENTS.checkInclusion (element) ||
				(m_DEFVAL != null) && m_DEFVAL.checkInclusion (element) ||
				(m_OBJECTS != null) && m_OBJECTS.checkInclusion (element) ||
				(m_DISPLAY_HINT != null) && m_DISPLAY_HINT.checkInclusion (element) ||
				(m_NOTIFICATIONS != null) && m_NOTIFICATIONS.checkInclusion (element) ||
				(m_MODULE != null) && m_MODULE.checkInclusion (element) ||
				(m_MANDATORY_GROUPS != null) && m_MANDATORY_GROUPS.checkInclusion (element) ||
				(m_GROUP != null) && m_GROUP.checkInclusion (element) ||
				(m_WRITE_SYNTAX != null) && m_WRITE_SYNTAX.checkInclusion (element) ||
				(m_MIN_ACCESS != null) && m_MIN_ACCESS.checkInclusion (element) ||
				(m_PRODUCT_RELEASE != null) && m_PRODUCT_RELEASE.checkInclusion (element) ||
				(m_SUPPORTS != null) && m_SUPPORTS.checkInclusion (element) ||
				(m_VARIATION != null) && m_VARIATION.checkInclusion (element) ||
				(m_ACCESS != null) && m_ACCESS.checkInclusion (element) ||
				(m_CREATION_REQUIRES != null) && m_CREATION_REQUIRES.checkInclusion (element) ||
				(m_ENTERPRISE != null) && m_ENTERPRISE.checkInclusion (element) ||
				(m_VARIABLES != null) && m_VARIABLES.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule keyword

		//
		// emit production tree node associated with any production of syntax rule keyword
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_keyword_1:
					// emit syntax tree node associated with production
					// keyword: DESCENDANTS

					s += m_DESCENDANTS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_2:
					// emit syntax tree node associated with production
					// keyword: SUCCESSORS

					s += m_SUCCESSORS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_3:
					// emit syntax tree node associated with production
					// keyword: ABSENT

					s += m_ABSENT.Emit (depth - 1);
				break;
				case production_kind.g_keyword_4:
					// emit syntax tree node associated with production
					// keyword: ABSTRACT-SYNTAX

					s += m_ABSTRACT_SYNTAX.Emit (depth - 1);
				break;
				case production_kind.g_keyword_5:
					// emit syntax tree node associated with production
					// keyword: ALL

					s += m_ALL.Emit (depth - 1);
				break;
				case production_kind.g_keyword_6:
					// emit syntax tree node associated with production
					// keyword: APPLICATION

					s += m_APPLICATION.Emit (depth - 1);
				break;
				case production_kind.g_keyword_7:
					// emit syntax tree node associated with production
					// keyword: AUTOMATIC

					s += m_AUTOMATIC.Emit (depth - 1);
				break;
				case production_kind.g_keyword_8:
					// emit syntax tree node associated with production
					// keyword: BEGIN

					s += m_BEGIN.Emit (depth - 1);
				break;
				case production_kind.g_keyword_9:
					// emit syntax tree node associated with production
					// keyword: BIT

					s += m_BIT.Emit (depth - 1);
				break;
				case production_kind.g_keyword_10:
					// emit syntax tree node associated with production
					// keyword: BMPString

					s += m_BMPString.Emit (depth - 1);
				break;
				case production_kind.g_keyword_11:
					// emit syntax tree node associated with production
					// keyword: BOOLEAN

					s += m_BOOLEAN.Emit (depth - 1);
				break;
				case production_kind.g_keyword_12:
					// emit syntax tree node associated with production
					// keyword: BY

					s += m_BY.Emit (depth - 1);
				break;
				case production_kind.g_keyword_13:
					// emit syntax tree node associated with production
					// keyword: CHARACTER

					s += m_CHARACTER.Emit (depth - 1);
				break;
				case production_kind.g_keyword_14:
					// emit syntax tree node associated with production
					// keyword: CHOICE

					s += m_CHOICE.Emit (depth - 1);
				break;
				case production_kind.g_keyword_15:
					// emit syntax tree node associated with production
					// keyword: CLASS

					s += m_CLASS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_16:
					// emit syntax tree node associated with production
					// keyword: COMPONENT

					s += m_COMPONENT.Emit (depth - 1);
				break;
				case production_kind.g_keyword_17:
					// emit syntax tree node associated with production
					// keyword: COMPONENTS

					s += m_COMPONENTS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_18:
					// emit syntax tree node associated with production
					// keyword: CONSTRAINED

					s += m_CONSTRAINED.Emit (depth - 1);
				break;
				case production_kind.g_keyword_19:
					// emit syntax tree node associated with production
					// keyword: CONTAINING

					s += m_CONTAINING.Emit (depth - 1);
				break;
				case production_kind.g_keyword_20:
					// emit syntax tree node associated with production
					// keyword: DATE

					s += m_DATE.Emit (depth - 1);
				break;
				case production_kind.g_keyword_21:
					// emit syntax tree node associated with production
					// keyword: DATE-TIME

					s += m_DATE_TIME.Emit (depth - 1);
				break;
				case production_kind.g_keyword_22:
					// emit syntax tree node associated with production
					// keyword: DEFAULT

					s += m_DEFAULT.Emit (depth - 1);
				break;
				case production_kind.g_keyword_23:
					// emit syntax tree node associated with production
					// keyword: DEFINITIONS

					s += m_DEFINITIONS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_24:
					// emit syntax tree node associated with production
					// keyword: DURATION

					s += m_DURATION.Emit (depth - 1);
				break;
				case production_kind.g_keyword_25:
					// emit syntax tree node associated with production
					// keyword: EMBEDDED

					s += m_EMBEDDED.Emit (depth - 1);
				break;
				case production_kind.g_keyword_26:
					// emit syntax tree node associated with production
					// keyword: ENCODED

					s += m_ENCODED.Emit (depth - 1);
				break;
				case production_kind.g_keyword_27:
					// emit syntax tree node associated with production
					// keyword: ENCODING-CONTROL

					s += m_ENCODING_CONTROL.Emit (depth - 1);
				break;
				case production_kind.g_keyword_28:
					// emit syntax tree node associated with production
					// keyword: END

					s += m_END.Emit (depth - 1);
				break;
				case production_kind.g_keyword_29:
					// emit syntax tree node associated with production
					// keyword: ENUMERATED

					s += m_ENUMERATED.Emit (depth - 1);
				break;
				case production_kind.g_keyword_30:
					// emit syntax tree node associated with production
					// keyword: EXCEPT

					s += m_EXCEPT.Emit (depth - 1);
				break;
				case production_kind.g_keyword_31:
					// emit syntax tree node associated with production
					// keyword: EXPLICIT

					s += m_EXPLICIT.Emit (depth - 1);
				break;
				case production_kind.g_keyword_32:
					// emit syntax tree node associated with production
					// keyword: EXPORTS

					s += m_EXPORTS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_33:
					// emit syntax tree node associated with production
					// keyword: EXTENSIBILITY

					s += m_EXTENSIBILITY.Emit (depth - 1);
				break;
				case production_kind.g_keyword_34:
					// emit syntax tree node associated with production
					// keyword: EXTERNAL

					s += m_EXTERNAL.Emit (depth - 1);
				break;
				case production_kind.g_keyword_35:
					// emit syntax tree node associated with production
					// keyword: FALSE

					s += m_FALSE.Emit (depth - 1);
				break;
				case production_kind.g_keyword_36:
					// emit syntax tree node associated with production
					// keyword: FROM

					s += m_FROM.Emit (depth - 1);
				break;
				case production_kind.g_keyword_37:
					// emit syntax tree node associated with production
					// keyword: GeneralizedTime

					s += m_GeneralizedTime.Emit (depth - 1);
				break;
				case production_kind.g_keyword_38:
					// emit syntax tree node associated with production
					// keyword: GeneralString

					s += m_GeneralString.Emit (depth - 1);
				break;
				case production_kind.g_keyword_39:
					// emit syntax tree node associated with production
					// keyword: GraphicString

					s += m_GraphicString.Emit (depth - 1);
				break;
				case production_kind.g_keyword_40:
					// emit syntax tree node associated with production
					// keyword: IA5String

					s += m_IA5String.Emit (depth - 1);
				break;
				case production_kind.g_keyword_41:
					// emit syntax tree node associated with production
					// keyword: IDENTIFIER

					s += m_IDENTIFIER.Emit (depth - 1);
				break;
				case production_kind.g_keyword_42:
					// emit syntax tree node associated with production
					// keyword: IMPLICIT

					s += m_IMPLICIT.Emit (depth - 1);
				break;
				case production_kind.g_keyword_43:
					// emit syntax tree node associated with production
					// keyword: IMPLIED

					s += m_IMPLIED.Emit (depth - 1);
				break;
				case production_kind.g_keyword_44:
					// emit syntax tree node associated with production
					// keyword: IMPORTS

					s += m_IMPORTS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_45:
					// emit syntax tree node associated with production
					// keyword: INCLUDES

					s += m_INCLUDES.Emit (depth - 1);
				break;
				case production_kind.g_keyword_46:
					// emit syntax tree node associated with production
					// keyword: INSTANCE

					s += m_INSTANCE.Emit (depth - 1);
				break;
				case production_kind.g_keyword_47:
					// emit syntax tree node associated with production
					// keyword: INSTRUCTIONS

					s += m_INSTRUCTIONS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_48:
					// emit syntax tree node associated with production
					// keyword: INTEGER

					s += m_INTEGER.Emit (depth - 1);
				break;
				case production_kind.g_keyword_49:
					// emit syntax tree node associated with production
					// keyword: INTERSECTION

					s += m_INTERSECTION.Emit (depth - 1);
				break;
				case production_kind.g_keyword_50:
					// emit syntax tree node associated with production
					// keyword: ISO646String

					s += m_ISO646String.Emit (depth - 1);
				break;
				case production_kind.g_keyword_51:
					// emit syntax tree node associated with production
					// keyword: MAX

					s += m_MAX.Emit (depth - 1);
				break;
				case production_kind.g_keyword_52:
					// emit syntax tree node associated with production
					// keyword: MIN

					s += m_MIN.Emit (depth - 1);
				break;
				case production_kind.g_keyword_53:
					// emit syntax tree node associated with production
					// keyword: MINUS-INFINITY

					s += m_MINUS_INFINITY.Emit (depth - 1);
				break;
				case production_kind.g_keyword_54:
					// emit syntax tree node associated with production
					// keyword: NOT-A-NUMBER

					s += m_NOT_A_NUMBER.Emit (depth - 1);
				break;
				case production_kind.g_keyword_55:
					// emit syntax tree node associated with production
					// keyword: NULL

					s += m_NULL.Emit (depth - 1);
				break;
				case production_kind.g_keyword_56:
					// emit syntax tree node associated with production
					// keyword: NumericString

					s += m_NumericString.Emit (depth - 1);
				break;
				case production_kind.g_keyword_57:
					// emit syntax tree node associated with production
					// keyword: OBJECT

					s += m_OBJECT.Emit (depth - 1);
				break;
				case production_kind.g_keyword_58:
					// emit syntax tree node associated with production
					// keyword: ObjectDescriptor

					s += m_ObjectDescriptor.Emit (depth - 1);
				break;
				case production_kind.g_keyword_59:
					// emit syntax tree node associated with production
					// keyword: OCTET

					s += m_OCTET.Emit (depth - 1);
				break;
				case production_kind.g_keyword_60:
					// emit syntax tree node associated with production
					// keyword: OF

					s += m_OF.Emit (depth - 1);
				break;
				case production_kind.g_keyword_61:
					// emit syntax tree node associated with production
					// keyword: OID-IRI

					s += m_OID_IRI.Emit (depth - 1);
				break;
				case production_kind.g_keyword_62:
					// emit syntax tree node associated with production
					// keyword: OPTIONAL

					s += m_OPTIONAL.Emit (depth - 1);
				break;
				case production_kind.g_keyword_63:
					// emit syntax tree node associated with production
					// keyword: PATTERN

					s += m_PATTERN.Emit (depth - 1);
				break;
				case production_kind.g_keyword_64:
					// emit syntax tree node associated with production
					// keyword: PDV

					s += m_PDV.Emit (depth - 1);
				break;
				case production_kind.g_keyword_65:
					// emit syntax tree node associated with production
					// keyword: PLUS-INFINITY

					s += m_PLUS_INFINITY.Emit (depth - 1);
				break;
				case production_kind.g_keyword_66:
					// emit syntax tree node associated with production
					// keyword: PRESENT

					s += m_PRESENT.Emit (depth - 1);
				break;
				case production_kind.g_keyword_67:
					// emit syntax tree node associated with production
					// keyword: PrintableString

					s += m_PrintableString.Emit (depth - 1);
				break;
				case production_kind.g_keyword_68:
					// emit syntax tree node associated with production
					// keyword: PRIVATE

					s += m_PRIVATE.Emit (depth - 1);
				break;
				case production_kind.g_keyword_69:
					// emit syntax tree node associated with production
					// keyword: REAL

					s += m_REAL.Emit (depth - 1);
				break;
				case production_kind.g_keyword_70:
					// emit syntax tree node associated with production
					// keyword: RELATIVE-OID

					s += m_RELATIVE_OID.Emit (depth - 1);
				break;
				case production_kind.g_keyword_71:
					// emit syntax tree node associated with production
					// keyword: RELATIVE-OID-IRI

					s += m_RELATIVE_OID_IRI.Emit (depth - 1);
				break;
				case production_kind.g_keyword_72:
					// emit syntax tree node associated with production
					// keyword: SEQUENCE

					s += m_SEQUENCE.Emit (depth - 1);
				break;
				case production_kind.g_keyword_73:
					// emit syntax tree node associated with production
					// keyword: SET

					s += m_SET.Emit (depth - 1);
				break;
				case production_kind.g_keyword_74:
					// emit syntax tree node associated with production
					// keyword: SETTINGS

					s += m_SETTINGS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_75:
					// emit syntax tree node associated with production
					// keyword: SIZE

					s += m_SIZE.Emit (depth - 1);
				break;
				case production_kind.g_keyword_76:
					// emit syntax tree node associated with production
					// keyword: STRING

					s += m_STRING.Emit (depth - 1);
				break;
				case production_kind.g_keyword_77:
					// emit syntax tree node associated with production
					// keyword: SYNTAX

					s += m_SYNTAX.Emit (depth - 1);
				break;
				case production_kind.g_keyword_78:
					// emit syntax tree node associated with production
					// keyword: T61String

					s += m_T61String.Emit (depth - 1);
				break;
				case production_kind.g_keyword_79:
					// emit syntax tree node associated with production
					// keyword: TAGS

					s += m_TAGS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_80:
					// emit syntax tree node associated with production
					// keyword: TeletexString

					s += m_TeletexString.Emit (depth - 1);
				break;
				case production_kind.g_keyword_81:
					// emit syntax tree node associated with production
					// keyword: TIME

					s += m_TIME.Emit (depth - 1);
				break;
				case production_kind.g_keyword_82:
					// emit syntax tree node associated with production
					// keyword: TIME-OF-DAY

					s += m_TIME_OF_DAY.Emit (depth - 1);
				break;
				case production_kind.g_keyword_83:
					// emit syntax tree node associated with production
					// keyword: TRUE

					s += m_TRUE.Emit (depth - 1);
				break;
				case production_kind.g_keyword_84:
					// emit syntax tree node associated with production
					// keyword: TYPE-IDENTIFIER

					s += m_TYPE_IDENTIFIER.Emit (depth - 1);
				break;
				case production_kind.g_keyword_85:
					// emit syntax tree node associated with production
					// keyword: UNION

					s += m_UNION.Emit (depth - 1);
				break;
				case production_kind.g_keyword_86:
					// emit syntax tree node associated with production
					// keyword: UNIQUE

					s += m_UNIQUE.Emit (depth - 1);
				break;
				case production_kind.g_keyword_87:
					// emit syntax tree node associated with production
					// keyword: UNIVERSAL

					s += m_UNIVERSAL.Emit (depth - 1);
				break;
				case production_kind.g_keyword_88:
					// emit syntax tree node associated with production
					// keyword: UniversalString

					s += m_UniversalString.Emit (depth - 1);
				break;
				case production_kind.g_keyword_89:
					// emit syntax tree node associated with production
					// keyword: UTCTime

					s += m_UTCTime.Emit (depth - 1);
				break;
				case production_kind.g_keyword_90:
					// emit syntax tree node associated with production
					// keyword: UTF8String

					s += m_UTF8String.Emit (depth - 1);
				break;
				case production_kind.g_keyword_91:
					// emit syntax tree node associated with production
					// keyword: VideotexString

					s += m_VideotexString.Emit (depth - 1);
				break;
				case production_kind.g_keyword_92:
					// emit syntax tree node associated with production
					// keyword: VisibleString

					s += m_VisibleString.Emit (depth - 1);
				break;
				case production_kind.g_keyword_93:
					// emit syntax tree node associated with production
					// keyword: WITH

					s += m_WITH.Emit (depth - 1);
				break;
				case production_kind.g_keyword_94:
					// emit syntax tree node associated with production
					// keyword: ANY

					s += m_ANY.Emit (depth - 1);
				break;
				case production_kind.g_keyword_95:
					// emit syntax tree node associated with production
					// keyword: DEFINED

					s += m_DEFINED.Emit (depth - 1);
				break;
				case production_kind.g_keyword_96:
					// emit syntax tree node associated with production
					// keyword: MACRO

					s += m_MACRO.Emit (depth - 1);
				break;
				case production_kind.g_keyword_97:
					// emit syntax tree node associated with production
					// keyword: MACRO-BODY

					s += m_MACRO_BODY.Emit (depth - 1);
				break;
				case production_kind.g_keyword_98:
					// emit syntax tree node associated with production
					// keyword: MODULE-IDENTITY

					s += m_MODULE_IDENTITY.Emit (depth - 1);
				break;
				case production_kind.g_keyword_99:
					// emit syntax tree node associated with production
					// keyword: OBJECT-IDENTITY

					s += m_OBJECT_IDENTITY.Emit (depth - 1);
				break;
				case production_kind.g_keyword_100:
					// emit syntax tree node associated with production
					// keyword: OBJECT-TYPE

					s += m_OBJECT_TYPE.Emit (depth - 1);
				break;
				case production_kind.g_keyword_101:
					// emit syntax tree node associated with production
					// keyword: NOTIFICATION-TYPE

					s += m_NOTIFICATION_TYPE.Emit (depth - 1);
				break;
				case production_kind.g_keyword_102:
					// emit syntax tree node associated with production
					// keyword: TEXTUAL-CONVENTION

					s += m_TEXTUAL_CONVENTION.Emit (depth - 1);
				break;
				case production_kind.g_keyword_103:
					// emit syntax tree node associated with production
					// keyword: OBJECT-GROUP

					s += m_OBJECT_GROUP.Emit (depth - 1);
				break;
				case production_kind.g_keyword_104:
					// emit syntax tree node associated with production
					// keyword: NOTIFICATION-GROUP

					s += m_NOTIFICATION_GROUP.Emit (depth - 1);
				break;
				case production_kind.g_keyword_105:
					// emit syntax tree node associated with production
					// keyword: MODULE-COMPLIANCE

					s += m_MODULE_COMPLIANCE.Emit (depth - 1);
				break;
				case production_kind.g_keyword_106:
					// emit syntax tree node associated with production
					// keyword: AGENT-CAPABILITIES

					s += m_AGENT_CAPABILITIES.Emit (depth - 1);
				break;
				case production_kind.g_keyword_107:
					// emit syntax tree node associated with production
					// keyword: TRAP-TYPE

					s += m_TRAP_TYPE.Emit (depth - 1);
				break;
				case production_kind.g_keyword_108:
					// emit syntax tree node associated with production
					// keyword: LAST-UPDATED

					s += m_LAST_UPDATED.Emit (depth - 1);
				break;
				case production_kind.g_keyword_109:
					// emit syntax tree node associated with production
					// keyword: ORGANIZATION

					s += m_ORGANIZATION.Emit (depth - 1);
				break;
				case production_kind.g_keyword_110:
					// emit syntax tree node associated with production
					// keyword: CONTACT-INFO

					s += m_CONTACT_INFO.Emit (depth - 1);
				break;
				case production_kind.g_keyword_111:
					// emit syntax tree node associated with production
					// keyword: DESCRIPTION

					s += m_DESCRIPTION.Emit (depth - 1);
				break;
				case production_kind.g_keyword_112:
					// emit syntax tree node associated with production
					// keyword: REVISION

					s += m_REVISION.Emit (depth - 1);
				break;
				case production_kind.g_keyword_113:
					// emit syntax tree node associated with production
					// keyword: STATUS

					s += m_STATUS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_114:
					// emit syntax tree node associated with production
					// keyword: REFERENCE

					s += m_REFERENCE.Emit (depth - 1);
				break;
				case production_kind.g_keyword_115:
					// emit syntax tree node associated with production
					// keyword: MAX-ACCESS

					s += m_MAX_ACCESS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_116:
					// emit syntax tree node associated with production
					// keyword: BITS

					s += m_BITS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_117:
					// emit syntax tree node associated with production
					// keyword: UNITS

					s += m_UNITS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_118:
					// emit syntax tree node associated with production
					// keyword: INDEX

					s += m_INDEX.Emit (depth - 1);
				break;
				case production_kind.g_keyword_119:
					// emit syntax tree node associated with production
					// keyword: AUGMENTS

					s += m_AUGMENTS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_120:
					// emit syntax tree node associated with production
					// keyword: DEFVAL

					s += m_DEFVAL.Emit (depth - 1);
				break;
				case production_kind.g_keyword_121:
					// emit syntax tree node associated with production
					// keyword: OBJECTS

					s += m_OBJECTS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_122:
					// emit syntax tree node associated with production
					// keyword: DISPLAY-HINT

					s += m_DISPLAY_HINT.Emit (depth - 1);
				break;
				case production_kind.g_keyword_123:
					// emit syntax tree node associated with production
					// keyword: NOTIFICATIONS

					s += m_NOTIFICATIONS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_124:
					// emit syntax tree node associated with production
					// keyword: MODULE

					s += m_MODULE.Emit (depth - 1);
				break;
				case production_kind.g_keyword_125:
					// emit syntax tree node associated with production
					// keyword: MANDATORY-GROUPS

					s += m_MANDATORY_GROUPS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_126:
					// emit syntax tree node associated with production
					// keyword: GROUP

					s += m_GROUP.Emit (depth - 1);
				break;
				case production_kind.g_keyword_127:
					// emit syntax tree node associated with production
					// keyword: WRITE-SYNTAX

					s += m_WRITE_SYNTAX.Emit (depth - 1);
				break;
				case production_kind.g_keyword_128:
					// emit syntax tree node associated with production
					// keyword: MIN-ACCESS

					s += m_MIN_ACCESS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_129:
					// emit syntax tree node associated with production
					// keyword: PRODUCT-RELEASE

					s += m_PRODUCT_RELEASE.Emit (depth - 1);
				break;
				case production_kind.g_keyword_130:
					// emit syntax tree node associated with production
					// keyword: SUPPORTS

					s += m_SUPPORTS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_131:
					// emit syntax tree node associated with production
					// keyword: VARIATION

					s += m_VARIATION.Emit (depth - 1);
				break;
				case production_kind.g_keyword_132:
					// emit syntax tree node associated with production
					// keyword: ACCESS

					s += m_ACCESS.Emit (depth - 1);
				break;
				case production_kind.g_keyword_133:
					// emit syntax tree node associated with production
					// keyword: CREATION-REQUIRES

					s += m_CREATION_REQUIRES.Emit (depth - 1);
				break;
				case production_kind.g_keyword_134:
					// emit syntax tree node associated with production
					// keyword: ENTERPRISE

					s += m_ENTERPRISE.Emit (depth - 1);
				break;
				case production_kind.g_keyword_135:
					// emit syntax tree node associated with production
					// keyword: VARIABLES

					s += m_VARIABLES.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule keyword
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "keyword (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_keyword_1:
					// emit syntax tree node associated with production
					// keyword: DESCENDANTS

					s += "DESCENDANTS";
				break;
				case production_kind.g_keyword_2:
					// emit syntax tree node associated with production
					// keyword: SUCCESSORS

					s += "SUCCESSORS";
				break;
				case production_kind.g_keyword_3:
					// emit syntax tree node associated with production
					// keyword: ABSENT

					s += "ABSENT";
				break;
				case production_kind.g_keyword_4:
					// emit syntax tree node associated with production
					// keyword: ABSTRACT-SYNTAX

					s += "ABSTRACT_SYNTAX";
				break;
				case production_kind.g_keyword_5:
					// emit syntax tree node associated with production
					// keyword: ALL

					s += "ALL";
				break;
				case production_kind.g_keyword_6:
					// emit syntax tree node associated with production
					// keyword: APPLICATION

					s += "APPLICATION";
				break;
				case production_kind.g_keyword_7:
					// emit syntax tree node associated with production
					// keyword: AUTOMATIC

					s += "AUTOMATIC";
				break;
				case production_kind.g_keyword_8:
					// emit syntax tree node associated with production
					// keyword: BEGIN

					s += "BEGIN";
				break;
				case production_kind.g_keyword_9:
					// emit syntax tree node associated with production
					// keyword: BIT

					s += "BIT";
				break;
				case production_kind.g_keyword_10:
					// emit syntax tree node associated with production
					// keyword: BMPString

					s += "BMPString";
				break;
				case production_kind.g_keyword_11:
					// emit syntax tree node associated with production
					// keyword: BOOLEAN

					s += "BOOLEAN";
				break;
				case production_kind.g_keyword_12:
					// emit syntax tree node associated with production
					// keyword: BY

					s += "BY";
				break;
				case production_kind.g_keyword_13:
					// emit syntax tree node associated with production
					// keyword: CHARACTER

					s += "CHARACTER";
				break;
				case production_kind.g_keyword_14:
					// emit syntax tree node associated with production
					// keyword: CHOICE

					s += "CHOICE";
				break;
				case production_kind.g_keyword_15:
					// emit syntax tree node associated with production
					// keyword: CLASS

					s += "CLASS";
				break;
				case production_kind.g_keyword_16:
					// emit syntax tree node associated with production
					// keyword: COMPONENT

					s += "COMPONENT";
				break;
				case production_kind.g_keyword_17:
					// emit syntax tree node associated with production
					// keyword: COMPONENTS

					s += "COMPONENTS";
				break;
				case production_kind.g_keyword_18:
					// emit syntax tree node associated with production
					// keyword: CONSTRAINED

					s += "CONSTRAINED";
				break;
				case production_kind.g_keyword_19:
					// emit syntax tree node associated with production
					// keyword: CONTAINING

					s += "CONTAINING";
				break;
				case production_kind.g_keyword_20:
					// emit syntax tree node associated with production
					// keyword: DATE

					s += "DATE";
				break;
				case production_kind.g_keyword_21:
					// emit syntax tree node associated with production
					// keyword: DATE-TIME

					s += "DATE_TIME";
				break;
				case production_kind.g_keyword_22:
					// emit syntax tree node associated with production
					// keyword: DEFAULT

					s += "DEFAULT";
				break;
				case production_kind.g_keyword_23:
					// emit syntax tree node associated with production
					// keyword: DEFINITIONS

					s += "DEFINITIONS";
				break;
				case production_kind.g_keyword_24:
					// emit syntax tree node associated with production
					// keyword: DURATION

					s += "DURATION";
				break;
				case production_kind.g_keyword_25:
					// emit syntax tree node associated with production
					// keyword: EMBEDDED

					s += "EMBEDDED";
				break;
				case production_kind.g_keyword_26:
					// emit syntax tree node associated with production
					// keyword: ENCODED

					s += "ENCODED";
				break;
				case production_kind.g_keyword_27:
					// emit syntax tree node associated with production
					// keyword: ENCODING-CONTROL

					s += "ENCODING_CONTROL";
				break;
				case production_kind.g_keyword_28:
					// emit syntax tree node associated with production
					// keyword: END

					s += "END";
				break;
				case production_kind.g_keyword_29:
					// emit syntax tree node associated with production
					// keyword: ENUMERATED

					s += "ENUMERATED";
				break;
				case production_kind.g_keyword_30:
					// emit syntax tree node associated with production
					// keyword: EXCEPT

					s += "EXCEPT";
				break;
				case production_kind.g_keyword_31:
					// emit syntax tree node associated with production
					// keyword: EXPLICIT

					s += "EXPLICIT";
				break;
				case production_kind.g_keyword_32:
					// emit syntax tree node associated with production
					// keyword: EXPORTS

					s += "EXPORTS";
				break;
				case production_kind.g_keyword_33:
					// emit syntax tree node associated with production
					// keyword: EXTENSIBILITY

					s += "EXTENSIBILITY";
				break;
				case production_kind.g_keyword_34:
					// emit syntax tree node associated with production
					// keyword: EXTERNAL

					s += "EXTERNAL";
				break;
				case production_kind.g_keyword_35:
					// emit syntax tree node associated with production
					// keyword: FALSE

					s += "FALSE";
				break;
				case production_kind.g_keyword_36:
					// emit syntax tree node associated with production
					// keyword: FROM

					s += "FROM";
				break;
				case production_kind.g_keyword_37:
					// emit syntax tree node associated with production
					// keyword: GeneralizedTime

					s += "GeneralizedTime";
				break;
				case production_kind.g_keyword_38:
					// emit syntax tree node associated with production
					// keyword: GeneralString

					s += "GeneralString";
				break;
				case production_kind.g_keyword_39:
					// emit syntax tree node associated with production
					// keyword: GraphicString

					s += "GraphicString";
				break;
				case production_kind.g_keyword_40:
					// emit syntax tree node associated with production
					// keyword: IA5String

					s += "IA5String";
				break;
				case production_kind.g_keyword_41:
					// emit syntax tree node associated with production
					// keyword: IDENTIFIER

					s += "IDENTIFIER";
				break;
				case production_kind.g_keyword_42:
					// emit syntax tree node associated with production
					// keyword: IMPLICIT

					s += "IMPLICIT";
				break;
				case production_kind.g_keyword_43:
					// emit syntax tree node associated with production
					// keyword: IMPLIED

					s += "IMPLIED";
				break;
				case production_kind.g_keyword_44:
					// emit syntax tree node associated with production
					// keyword: IMPORTS

					s += "IMPORTS";
				break;
				case production_kind.g_keyword_45:
					// emit syntax tree node associated with production
					// keyword: INCLUDES

					s += "INCLUDES";
				break;
				case production_kind.g_keyword_46:
					// emit syntax tree node associated with production
					// keyword: INSTANCE

					s += "INSTANCE";
				break;
				case production_kind.g_keyword_47:
					// emit syntax tree node associated with production
					// keyword: INSTRUCTIONS

					s += "INSTRUCTIONS";
				break;
				case production_kind.g_keyword_48:
					// emit syntax tree node associated with production
					// keyword: INTEGER

					s += "INTEGER";
				break;
				case production_kind.g_keyword_49:
					// emit syntax tree node associated with production
					// keyword: INTERSECTION

					s += "INTERSECTION";
				break;
				case production_kind.g_keyword_50:
					// emit syntax tree node associated with production
					// keyword: ISO646String

					s += "ISO646String";
				break;
				case production_kind.g_keyword_51:
					// emit syntax tree node associated with production
					// keyword: MAX

					s += "MAX";
				break;
				case production_kind.g_keyword_52:
					// emit syntax tree node associated with production
					// keyword: MIN

					s += "MIN";
				break;
				case production_kind.g_keyword_53:
					// emit syntax tree node associated with production
					// keyword: MINUS-INFINITY

					s += "MINUS_INFINITY";
				break;
				case production_kind.g_keyword_54:
					// emit syntax tree node associated with production
					// keyword: NOT-A-NUMBER

					s += "NOT_A_NUMBER";
				break;
				case production_kind.g_keyword_55:
					// emit syntax tree node associated with production
					// keyword: NULL

					s += "NULL";
				break;
				case production_kind.g_keyword_56:
					// emit syntax tree node associated with production
					// keyword: NumericString

					s += "NumericString";
				break;
				case production_kind.g_keyword_57:
					// emit syntax tree node associated with production
					// keyword: OBJECT

					s += "OBJECT";
				break;
				case production_kind.g_keyword_58:
					// emit syntax tree node associated with production
					// keyword: ObjectDescriptor

					s += "ObjectDescriptor";
				break;
				case production_kind.g_keyword_59:
					// emit syntax tree node associated with production
					// keyword: OCTET

					s += "OCTET";
				break;
				case production_kind.g_keyword_60:
					// emit syntax tree node associated with production
					// keyword: OF

					s += "OF";
				break;
				case production_kind.g_keyword_61:
					// emit syntax tree node associated with production
					// keyword: OID-IRI

					s += "OID_IRI";
				break;
				case production_kind.g_keyword_62:
					// emit syntax tree node associated with production
					// keyword: OPTIONAL

					s += "OPTIONAL";
				break;
				case production_kind.g_keyword_63:
					// emit syntax tree node associated with production
					// keyword: PATTERN

					s += "PATTERN";
				break;
				case production_kind.g_keyword_64:
					// emit syntax tree node associated with production
					// keyword: PDV

					s += "PDV";
				break;
				case production_kind.g_keyword_65:
					// emit syntax tree node associated with production
					// keyword: PLUS-INFINITY

					s += "PLUS_INFINITY";
				break;
				case production_kind.g_keyword_66:
					// emit syntax tree node associated with production
					// keyword: PRESENT

					s += "PRESENT";
				break;
				case production_kind.g_keyword_67:
					// emit syntax tree node associated with production
					// keyword: PrintableString

					s += "PrintableString";
				break;
				case production_kind.g_keyword_68:
					// emit syntax tree node associated with production
					// keyword: PRIVATE

					s += "PRIVATE";
				break;
				case production_kind.g_keyword_69:
					// emit syntax tree node associated with production
					// keyword: REAL

					s += "REAL";
				break;
				case production_kind.g_keyword_70:
					// emit syntax tree node associated with production
					// keyword: RELATIVE-OID

					s += "RELATIVE_OID";
				break;
				case production_kind.g_keyword_71:
					// emit syntax tree node associated with production
					// keyword: RELATIVE-OID-IRI

					s += "RELATIVE_OID_IRI";
				break;
				case production_kind.g_keyword_72:
					// emit syntax tree node associated with production
					// keyword: SEQUENCE

					s += "SEQUENCE";
				break;
				case production_kind.g_keyword_73:
					// emit syntax tree node associated with production
					// keyword: SET

					s += "SET";
				break;
				case production_kind.g_keyword_74:
					// emit syntax tree node associated with production
					// keyword: SETTINGS

					s += "SETTINGS";
				break;
				case production_kind.g_keyword_75:
					// emit syntax tree node associated with production
					// keyword: SIZE

					s += "SIZE";
				break;
				case production_kind.g_keyword_76:
					// emit syntax tree node associated with production
					// keyword: STRING

					s += "STRING";
				break;
				case production_kind.g_keyword_77:
					// emit syntax tree node associated with production
					// keyword: SYNTAX

					s += "SYNTAX";
				break;
				case production_kind.g_keyword_78:
					// emit syntax tree node associated with production
					// keyword: T61String

					s += "T61String";
				break;
				case production_kind.g_keyword_79:
					// emit syntax tree node associated with production
					// keyword: TAGS

					s += "TAGS";
				break;
				case production_kind.g_keyword_80:
					// emit syntax tree node associated with production
					// keyword: TeletexString

					s += "TeletexString";
				break;
				case production_kind.g_keyword_81:
					// emit syntax tree node associated with production
					// keyword: TIME

					s += "TIME";
				break;
				case production_kind.g_keyword_82:
					// emit syntax tree node associated with production
					// keyword: TIME-OF-DAY

					s += "TIME_OF_DAY";
				break;
				case production_kind.g_keyword_83:
					// emit syntax tree node associated with production
					// keyword: TRUE

					s += "TRUE";
				break;
				case production_kind.g_keyword_84:
					// emit syntax tree node associated with production
					// keyword: TYPE-IDENTIFIER

					s += "TYPE_IDENTIFIER";
				break;
				case production_kind.g_keyword_85:
					// emit syntax tree node associated with production
					// keyword: UNION

					s += "UNION";
				break;
				case production_kind.g_keyword_86:
					// emit syntax tree node associated with production
					// keyword: UNIQUE

					s += "UNIQUE";
				break;
				case production_kind.g_keyword_87:
					// emit syntax tree node associated with production
					// keyword: UNIVERSAL

					s += "UNIVERSAL";
				break;
				case production_kind.g_keyword_88:
					// emit syntax tree node associated with production
					// keyword: UniversalString

					s += "UniversalString";
				break;
				case production_kind.g_keyword_89:
					// emit syntax tree node associated with production
					// keyword: UTCTime

					s += "UTCTime";
				break;
				case production_kind.g_keyword_90:
					// emit syntax tree node associated with production
					// keyword: UTF8String

					s += "UTF8String";
				break;
				case production_kind.g_keyword_91:
					// emit syntax tree node associated with production
					// keyword: VideotexString

					s += "VideotexString";
				break;
				case production_kind.g_keyword_92:
					// emit syntax tree node associated with production
					// keyword: VisibleString

					s += "VisibleString";
				break;
				case production_kind.g_keyword_93:
					// emit syntax tree node associated with production
					// keyword: WITH

					s += "WITH";
				break;
				case production_kind.g_keyword_94:
					// emit syntax tree node associated with production
					// keyword: ANY

					s += "ANY";
				break;
				case production_kind.g_keyword_95:
					// emit syntax tree node associated with production
					// keyword: DEFINED

					s += "DEFINED";
				break;
				case production_kind.g_keyword_96:
					// emit syntax tree node associated with production
					// keyword: MACRO

					s += "MACRO";
				break;
				case production_kind.g_keyword_97:
					// emit syntax tree node associated with production
					// keyword: MACRO-BODY

					s += "MACRO_BODY";
				break;
				case production_kind.g_keyword_98:
					// emit syntax tree node associated with production
					// keyword: MODULE-IDENTITY

					s += "MODULE_IDENTITY";
				break;
				case production_kind.g_keyword_99:
					// emit syntax tree node associated with production
					// keyword: OBJECT-IDENTITY

					s += "OBJECT_IDENTITY";
				break;
				case production_kind.g_keyword_100:
					// emit syntax tree node associated with production
					// keyword: OBJECT-TYPE

					s += "OBJECT_TYPE";
				break;
				case production_kind.g_keyword_101:
					// emit syntax tree node associated with production
					// keyword: NOTIFICATION-TYPE

					s += "NOTIFICATION_TYPE";
				break;
				case production_kind.g_keyword_102:
					// emit syntax tree node associated with production
					// keyword: TEXTUAL-CONVENTION

					s += "TEXTUAL_CONVENTION";
				break;
				case production_kind.g_keyword_103:
					// emit syntax tree node associated with production
					// keyword: OBJECT-GROUP

					s += "OBJECT_GROUP";
				break;
				case production_kind.g_keyword_104:
					// emit syntax tree node associated with production
					// keyword: NOTIFICATION-GROUP

					s += "NOTIFICATION_GROUP";
				break;
				case production_kind.g_keyword_105:
					// emit syntax tree node associated with production
					// keyword: MODULE-COMPLIANCE

					s += "MODULE_COMPLIANCE";
				break;
				case production_kind.g_keyword_106:
					// emit syntax tree node associated with production
					// keyword: AGENT-CAPABILITIES

					s += "AGENT_CAPABILITIES";
				break;
				case production_kind.g_keyword_107:
					// emit syntax tree node associated with production
					// keyword: TRAP-TYPE

					s += "TRAP_TYPE";
				break;
				case production_kind.g_keyword_108:
					// emit syntax tree node associated with production
					// keyword: LAST-UPDATED

					s += "LAST_UPDATED";
				break;
				case production_kind.g_keyword_109:
					// emit syntax tree node associated with production
					// keyword: ORGANIZATION

					s += "ORGANIZATION";
				break;
				case production_kind.g_keyword_110:
					// emit syntax tree node associated with production
					// keyword: CONTACT-INFO

					s += "CONTACT_INFO";
				break;
				case production_kind.g_keyword_111:
					// emit syntax tree node associated with production
					// keyword: DESCRIPTION

					s += "DESCRIPTION";
				break;
				case production_kind.g_keyword_112:
					// emit syntax tree node associated with production
					// keyword: REVISION

					s += "REVISION";
				break;
				case production_kind.g_keyword_113:
					// emit syntax tree node associated with production
					// keyword: STATUS

					s += "STATUS";
				break;
				case production_kind.g_keyword_114:
					// emit syntax tree node associated with production
					// keyword: REFERENCE

					s += "REFERENCE";
				break;
				case production_kind.g_keyword_115:
					// emit syntax tree node associated with production
					// keyword: MAX-ACCESS

					s += "MAX_ACCESS";
				break;
				case production_kind.g_keyword_116:
					// emit syntax tree node associated with production
					// keyword: BITS

					s += "BITS";
				break;
				case production_kind.g_keyword_117:
					// emit syntax tree node associated with production
					// keyword: UNITS

					s += "UNITS";
				break;
				case production_kind.g_keyword_118:
					// emit syntax tree node associated with production
					// keyword: INDEX

					s += "INDEX";
				break;
				case production_kind.g_keyword_119:
					// emit syntax tree node associated with production
					// keyword: AUGMENTS

					s += "AUGMENTS";
				break;
				case production_kind.g_keyword_120:
					// emit syntax tree node associated with production
					// keyword: DEFVAL

					s += "DEFVAL";
				break;
				case production_kind.g_keyword_121:
					// emit syntax tree node associated with production
					// keyword: OBJECTS

					s += "OBJECTS";
				break;
				case production_kind.g_keyword_122:
					// emit syntax tree node associated with production
					// keyword: DISPLAY-HINT

					s += "DISPLAY_HINT";
				break;
				case production_kind.g_keyword_123:
					// emit syntax tree node associated with production
					// keyword: NOTIFICATIONS

					s += "NOTIFICATIONS";
				break;
				case production_kind.g_keyword_124:
					// emit syntax tree node associated with production
					// keyword: MODULE

					s += "MODULE";
				break;
				case production_kind.g_keyword_125:
					// emit syntax tree node associated with production
					// keyword: MANDATORY-GROUPS

					s += "MANDATORY_GROUPS";
				break;
				case production_kind.g_keyword_126:
					// emit syntax tree node associated with production
					// keyword: GROUP

					s += "GROUP";
				break;
				case production_kind.g_keyword_127:
					// emit syntax tree node associated with production
					// keyword: WRITE-SYNTAX

					s += "WRITE_SYNTAX";
				break;
				case production_kind.g_keyword_128:
					// emit syntax tree node associated with production
					// keyword: MIN-ACCESS

					s += "MIN_ACCESS";
				break;
				case production_kind.g_keyword_129:
					// emit syntax tree node associated with production
					// keyword: PRODUCT-RELEASE

					s += "PRODUCT_RELEASE";
				break;
				case production_kind.g_keyword_130:
					// emit syntax tree node associated with production
					// keyword: SUPPORTS

					s += "SUPPORTS";
				break;
				case production_kind.g_keyword_131:
					// emit syntax tree node associated with production
					// keyword: VARIATION

					s += "VARIATION";
				break;
				case production_kind.g_keyword_132:
					// emit syntax tree node associated with production
					// keyword: ACCESS

					s += "ACCESS";
				break;
				case production_kind.g_keyword_133:
					// emit syntax tree node associated with production
					// keyword: CREATION-REQUIRES

					s += "CREATION_REQUIRES";
				break;
				case production_kind.g_keyword_134:
					// emit syntax tree node associated with production
					// keyword: ENTERPRISE

					s += "ENTERPRISE";
				break;
				case production_kind.g_keyword_135:
					// emit syntax tree node associated with production
					// keyword: VARIABLES

					s += "VARIABLES";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule keyword

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule keyword with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			keyword.production_kind kind = (keyword.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case keyword.production_kind.g_keyword_1:
					// traverse syntax tree node associated with production
					// keyword: DESCENDANTS

						m_DESCENDANTS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_2:
					// traverse syntax tree node associated with production
					// keyword: SUCCESSORS

						m_SUCCESSORS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_3:
					// traverse syntax tree node associated with production
					// keyword: ABSENT

						m_ABSENT.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_4:
					// traverse syntax tree node associated with production
					// keyword: ABSTRACT-SYNTAX

						m_ABSTRACT_SYNTAX.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_5:
					// traverse syntax tree node associated with production
					// keyword: ALL

						m_ALL.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_6:
					// traverse syntax tree node associated with production
					// keyword: APPLICATION

						m_APPLICATION.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_7:
					// traverse syntax tree node associated with production
					// keyword: AUTOMATIC

						m_AUTOMATIC.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_8:
					// traverse syntax tree node associated with production
					// keyword: BEGIN

						m_BEGIN.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_9:
					// traverse syntax tree node associated with production
					// keyword: BIT

						m_BIT.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_10:
					// traverse syntax tree node associated with production
					// keyword: BMPString

						m_BMPString.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_11:
					// traverse syntax tree node associated with production
					// keyword: BOOLEAN

						m_BOOLEAN.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_12:
					// traverse syntax tree node associated with production
					// keyword: BY

						m_BY.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_13:
					// traverse syntax tree node associated with production
					// keyword: CHARACTER

						m_CHARACTER.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_14:
					// traverse syntax tree node associated with production
					// keyword: CHOICE

						m_CHOICE.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_15:
					// traverse syntax tree node associated with production
					// keyword: CLASS

						m_CLASS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_16:
					// traverse syntax tree node associated with production
					// keyword: COMPONENT

						m_COMPONENT.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_17:
					// traverse syntax tree node associated with production
					// keyword: COMPONENTS

						m_COMPONENTS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_18:
					// traverse syntax tree node associated with production
					// keyword: CONSTRAINED

						m_CONSTRAINED.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_19:
					// traverse syntax tree node associated with production
					// keyword: CONTAINING

						m_CONTAINING.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_20:
					// traverse syntax tree node associated with production
					// keyword: DATE

						m_DATE.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_21:
					// traverse syntax tree node associated with production
					// keyword: DATE-TIME

						m_DATE_TIME.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_22:
					// traverse syntax tree node associated with production
					// keyword: DEFAULT

						m_DEFAULT.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_23:
					// traverse syntax tree node associated with production
					// keyword: DEFINITIONS

						m_DEFINITIONS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_24:
					// traverse syntax tree node associated with production
					// keyword: DURATION

						m_DURATION.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_25:
					// traverse syntax tree node associated with production
					// keyword: EMBEDDED

						m_EMBEDDED.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_26:
					// traverse syntax tree node associated with production
					// keyword: ENCODED

						m_ENCODED.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_27:
					// traverse syntax tree node associated with production
					// keyword: ENCODING-CONTROL

						m_ENCODING_CONTROL.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_28:
					// traverse syntax tree node associated with production
					// keyword: END

						m_END.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_29:
					// traverse syntax tree node associated with production
					// keyword: ENUMERATED

						m_ENUMERATED.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_30:
					// traverse syntax tree node associated with production
					// keyword: EXCEPT

						m_EXCEPT.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_31:
					// traverse syntax tree node associated with production
					// keyword: EXPLICIT

						m_EXPLICIT.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_32:
					// traverse syntax tree node associated with production
					// keyword: EXPORTS

						m_EXPORTS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_33:
					// traverse syntax tree node associated with production
					// keyword: EXTENSIBILITY

						m_EXTENSIBILITY.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_34:
					// traverse syntax tree node associated with production
					// keyword: EXTERNAL

						m_EXTERNAL.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_35:
					// traverse syntax tree node associated with production
					// keyword: FALSE

						m_FALSE.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_36:
					// traverse syntax tree node associated with production
					// keyword: FROM

						m_FROM.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_37:
					// traverse syntax tree node associated with production
					// keyword: GeneralizedTime

						m_GeneralizedTime.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_38:
					// traverse syntax tree node associated with production
					// keyword: GeneralString

						m_GeneralString.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_39:
					// traverse syntax tree node associated with production
					// keyword: GraphicString

						m_GraphicString.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_40:
					// traverse syntax tree node associated with production
					// keyword: IA5String

						m_IA5String.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_41:
					// traverse syntax tree node associated with production
					// keyword: IDENTIFIER

						m_IDENTIFIER.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_42:
					// traverse syntax tree node associated with production
					// keyword: IMPLICIT

						m_IMPLICIT.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_43:
					// traverse syntax tree node associated with production
					// keyword: IMPLIED

						m_IMPLIED.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_44:
					// traverse syntax tree node associated with production
					// keyword: IMPORTS

						m_IMPORTS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_45:
					// traverse syntax tree node associated with production
					// keyword: INCLUDES

						m_INCLUDES.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_46:
					// traverse syntax tree node associated with production
					// keyword: INSTANCE

						m_INSTANCE.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_47:
					// traverse syntax tree node associated with production
					// keyword: INSTRUCTIONS

						m_INSTRUCTIONS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_48:
					// traverse syntax tree node associated with production
					// keyword: INTEGER

						m_INTEGER.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_49:
					// traverse syntax tree node associated with production
					// keyword: INTERSECTION

						m_INTERSECTION.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_50:
					// traverse syntax tree node associated with production
					// keyword: ISO646String

						m_ISO646String.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_51:
					// traverse syntax tree node associated with production
					// keyword: MAX

						m_MAX.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_52:
					// traverse syntax tree node associated with production
					// keyword: MIN

						m_MIN.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_53:
					// traverse syntax tree node associated with production
					// keyword: MINUS-INFINITY

						m_MINUS_INFINITY.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_54:
					// traverse syntax tree node associated with production
					// keyword: NOT-A-NUMBER

						m_NOT_A_NUMBER.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_55:
					// traverse syntax tree node associated with production
					// keyword: NULL

						m_NULL.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_56:
					// traverse syntax tree node associated with production
					// keyword: NumericString

						m_NumericString.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_57:
					// traverse syntax tree node associated with production
					// keyword: OBJECT

						m_OBJECT.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_58:
					// traverse syntax tree node associated with production
					// keyword: ObjectDescriptor

						m_ObjectDescriptor.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_59:
					// traverse syntax tree node associated with production
					// keyword: OCTET

						m_OCTET.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_60:
					// traverse syntax tree node associated with production
					// keyword: OF

						m_OF.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_61:
					// traverse syntax tree node associated with production
					// keyword: OID-IRI

						m_OID_IRI.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_62:
					// traverse syntax tree node associated with production
					// keyword: OPTIONAL

						m_OPTIONAL.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_63:
					// traverse syntax tree node associated with production
					// keyword: PATTERN

						m_PATTERN.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_64:
					// traverse syntax tree node associated with production
					// keyword: PDV

						m_PDV.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_65:
					// traverse syntax tree node associated with production
					// keyword: PLUS-INFINITY

						m_PLUS_INFINITY.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_66:
					// traverse syntax tree node associated with production
					// keyword: PRESENT

						m_PRESENT.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_67:
					// traverse syntax tree node associated with production
					// keyword: PrintableString

						m_PrintableString.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_68:
					// traverse syntax tree node associated with production
					// keyword: PRIVATE

						m_PRIVATE.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_69:
					// traverse syntax tree node associated with production
					// keyword: REAL

						m_REAL.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_70:
					// traverse syntax tree node associated with production
					// keyword: RELATIVE-OID

						m_RELATIVE_OID.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_71:
					// traverse syntax tree node associated with production
					// keyword: RELATIVE-OID-IRI

						m_RELATIVE_OID_IRI.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_72:
					// traverse syntax tree node associated with production
					// keyword: SEQUENCE

						m_SEQUENCE.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_73:
					// traverse syntax tree node associated with production
					// keyword: SET

						m_SET.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_74:
					// traverse syntax tree node associated with production
					// keyword: SETTINGS

						m_SETTINGS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_75:
					// traverse syntax tree node associated with production
					// keyword: SIZE

						m_SIZE.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_76:
					// traverse syntax tree node associated with production
					// keyword: STRING

						m_STRING.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_77:
					// traverse syntax tree node associated with production
					// keyword: SYNTAX

						m_SYNTAX.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_78:
					// traverse syntax tree node associated with production
					// keyword: T61String

						m_T61String.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_79:
					// traverse syntax tree node associated with production
					// keyword: TAGS

						m_TAGS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_80:
					// traverse syntax tree node associated with production
					// keyword: TeletexString

						m_TeletexString.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_81:
					// traverse syntax tree node associated with production
					// keyword: TIME

						m_TIME.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_82:
					// traverse syntax tree node associated with production
					// keyword: TIME-OF-DAY

						m_TIME_OF_DAY.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_83:
					// traverse syntax tree node associated with production
					// keyword: TRUE

						m_TRUE.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_84:
					// traverse syntax tree node associated with production
					// keyword: TYPE-IDENTIFIER

						m_TYPE_IDENTIFIER.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_85:
					// traverse syntax tree node associated with production
					// keyword: UNION

						m_UNION.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_86:
					// traverse syntax tree node associated with production
					// keyword: UNIQUE

						m_UNIQUE.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_87:
					// traverse syntax tree node associated with production
					// keyword: UNIVERSAL

						m_UNIVERSAL.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_88:
					// traverse syntax tree node associated with production
					// keyword: UniversalString

						m_UniversalString.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_89:
					// traverse syntax tree node associated with production
					// keyword: UTCTime

						m_UTCTime.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_90:
					// traverse syntax tree node associated with production
					// keyword: UTF8String

						m_UTF8String.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_91:
					// traverse syntax tree node associated with production
					// keyword: VideotexString

						m_VideotexString.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_92:
					// traverse syntax tree node associated with production
					// keyword: VisibleString

						m_VisibleString.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_93:
					// traverse syntax tree node associated with production
					// keyword: WITH

						m_WITH.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_94:
					// traverse syntax tree node associated with production
					// keyword: ANY

						m_ANY.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_95:
					// traverse syntax tree node associated with production
					// keyword: DEFINED

						m_DEFINED.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_96:
					// traverse syntax tree node associated with production
					// keyword: MACRO

						m_MACRO.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_97:
					// traverse syntax tree node associated with production
					// keyword: MACRO-BODY

						m_MACRO_BODY.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_98:
					// traverse syntax tree node associated with production
					// keyword: MODULE-IDENTITY

						m_MODULE_IDENTITY.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_99:
					// traverse syntax tree node associated with production
					// keyword: OBJECT-IDENTITY

						m_OBJECT_IDENTITY.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_100:
					// traverse syntax tree node associated with production
					// keyword: OBJECT-TYPE

						m_OBJECT_TYPE.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_101:
					// traverse syntax tree node associated with production
					// keyword: NOTIFICATION-TYPE

						m_NOTIFICATION_TYPE.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_102:
					// traverse syntax tree node associated with production
					// keyword: TEXTUAL-CONVENTION

						m_TEXTUAL_CONVENTION.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_103:
					// traverse syntax tree node associated with production
					// keyword: OBJECT-GROUP

						m_OBJECT_GROUP.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_104:
					// traverse syntax tree node associated with production
					// keyword: NOTIFICATION-GROUP

						m_NOTIFICATION_GROUP.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_105:
					// traverse syntax tree node associated with production
					// keyword: MODULE-COMPLIANCE

						m_MODULE_COMPLIANCE.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_106:
					// traverse syntax tree node associated with production
					// keyword: AGENT-CAPABILITIES

						m_AGENT_CAPABILITIES.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_107:
					// traverse syntax tree node associated with production
					// keyword: TRAP-TYPE

						m_TRAP_TYPE.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_108:
					// traverse syntax tree node associated with production
					// keyword: LAST-UPDATED

						m_LAST_UPDATED.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_109:
					// traverse syntax tree node associated with production
					// keyword: ORGANIZATION

						m_ORGANIZATION.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_110:
					// traverse syntax tree node associated with production
					// keyword: CONTACT-INFO

						m_CONTACT_INFO.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_111:
					// traverse syntax tree node associated with production
					// keyword: DESCRIPTION

						m_DESCRIPTION.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_112:
					// traverse syntax tree node associated with production
					// keyword: REVISION

						m_REVISION.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_113:
					// traverse syntax tree node associated with production
					// keyword: STATUS

						m_STATUS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_114:
					// traverse syntax tree node associated with production
					// keyword: REFERENCE

						m_REFERENCE.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_115:
					// traverse syntax tree node associated with production
					// keyword: MAX-ACCESS

						m_MAX_ACCESS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_116:
					// traverse syntax tree node associated with production
					// keyword: BITS

						m_BITS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_117:
					// traverse syntax tree node associated with production
					// keyword: UNITS

						m_UNITS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_118:
					// traverse syntax tree node associated with production
					// keyword: INDEX

						m_INDEX.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_119:
					// traverse syntax tree node associated with production
					// keyword: AUGMENTS

						m_AUGMENTS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_120:
					// traverse syntax tree node associated with production
					// keyword: DEFVAL

						m_DEFVAL.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_121:
					// traverse syntax tree node associated with production
					// keyword: OBJECTS

						m_OBJECTS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_122:
					// traverse syntax tree node associated with production
					// keyword: DISPLAY-HINT

						m_DISPLAY_HINT.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_123:
					// traverse syntax tree node associated with production
					// keyword: NOTIFICATIONS

						m_NOTIFICATIONS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_124:
					// traverse syntax tree node associated with production
					// keyword: MODULE

						m_MODULE.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_125:
					// traverse syntax tree node associated with production
					// keyword: MANDATORY-GROUPS

						m_MANDATORY_GROUPS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_126:
					// traverse syntax tree node associated with production
					// keyword: GROUP

						m_GROUP.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_127:
					// traverse syntax tree node associated with production
					// keyword: WRITE-SYNTAX

						m_WRITE_SYNTAX.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_128:
					// traverse syntax tree node associated with production
					// keyword: MIN-ACCESS

						m_MIN_ACCESS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_129:
					// traverse syntax tree node associated with production
					// keyword: PRODUCT-RELEASE

						m_PRODUCT_RELEASE.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_130:
					// traverse syntax tree node associated with production
					// keyword: SUPPORTS

						m_SUPPORTS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_131:
					// traverse syntax tree node associated with production
					// keyword: VARIATION

						m_VARIATION.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_132:
					// traverse syntax tree node associated with production
					// keyword: ACCESS

						m_ACCESS.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_133:
					// traverse syntax tree node associated with production
					// keyword: CREATION-REQUIRES

						m_CREATION_REQUIRES.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_134:
					// traverse syntax tree node associated with production
					// keyword: ENTERPRISE

						m_ENTERPRISE.Visit (visitor, appData);
				break;
				case keyword.production_kind.g_keyword_135:
					// traverse syntax tree node associated with production
					// keyword: VARIABLES

						m_VARIABLES.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DESCENDANTS?.reparent (this);
			m_SUCCESSORS?.reparent (this);
			m_ABSENT?.reparent (this);
			m_ABSTRACT_SYNTAX?.reparent (this);
			m_ALL?.reparent (this);
			m_APPLICATION?.reparent (this);
			m_AUTOMATIC?.reparent (this);
			m_BEGIN?.reparent (this);
			m_BIT?.reparent (this);
			m_BMPString?.reparent (this);
			m_BOOLEAN?.reparent (this);
			m_BY?.reparent (this);
			m_CHARACTER?.reparent (this);
			m_CHOICE?.reparent (this);
			m_CLASS?.reparent (this);
			m_COMPONENT?.reparent (this);
			m_COMPONENTS?.reparent (this);
			m_CONSTRAINED?.reparent (this);
			m_CONTAINING?.reparent (this);
			m_DATE?.reparent (this);
			m_DATE_TIME?.reparent (this);
			m_DEFAULT?.reparent (this);
			m_DEFINITIONS?.reparent (this);
			m_DURATION?.reparent (this);
			m_EMBEDDED?.reparent (this);
			m_ENCODED?.reparent (this);
			m_ENCODING_CONTROL?.reparent (this);
			m_END?.reparent (this);
			m_ENUMERATED?.reparent (this);
			m_EXCEPT?.reparent (this);
			m_EXPLICIT?.reparent (this);
			m_EXPORTS?.reparent (this);
			m_EXTENSIBILITY?.reparent (this);
			m_EXTERNAL?.reparent (this);
			m_FALSE?.reparent (this);
			m_FROM?.reparent (this);
			m_GeneralizedTime?.reparent (this);
			m_GeneralString?.reparent (this);
			m_GraphicString?.reparent (this);
			m_IA5String?.reparent (this);
			m_IDENTIFIER?.reparent (this);
			m_IMPLICIT?.reparent (this);
			m_IMPLIED?.reparent (this);
			m_IMPORTS?.reparent (this);
			m_INCLUDES?.reparent (this);
			m_INSTANCE?.reparent (this);
			m_INSTRUCTIONS?.reparent (this);
			m_INTEGER?.reparent (this);
			m_INTERSECTION?.reparent (this);
			m_ISO646String?.reparent (this);
			m_MAX?.reparent (this);
			m_MIN?.reparent (this);
			m_MINUS_INFINITY?.reparent (this);
			m_NOT_A_NUMBER?.reparent (this);
			m_NULL?.reparent (this);
			m_NumericString?.reparent (this);
			m_OBJECT?.reparent (this);
			m_ObjectDescriptor?.reparent (this);
			m_OCTET?.reparent (this);
			m_OF?.reparent (this);
			m_OID_IRI?.reparent (this);
			m_OPTIONAL?.reparent (this);
			m_PATTERN?.reparent (this);
			m_PDV?.reparent (this);
			m_PLUS_INFINITY?.reparent (this);
			m_PRESENT?.reparent (this);
			m_PrintableString?.reparent (this);
			m_PRIVATE?.reparent (this);
			m_REAL?.reparent (this);
			m_RELATIVE_OID?.reparent (this);
			m_RELATIVE_OID_IRI?.reparent (this);
			m_SEQUENCE?.reparent (this);
			m_SET?.reparent (this);
			m_SETTINGS?.reparent (this);
			m_SIZE?.reparent (this);
			m_STRING?.reparent (this);
			m_SYNTAX?.reparent (this);
			m_T61String?.reparent (this);
			m_TAGS?.reparent (this);
			m_TeletexString?.reparent (this);
			m_TIME?.reparent (this);
			m_TIME_OF_DAY?.reparent (this);
			m_TRUE?.reparent (this);
			m_TYPE_IDENTIFIER?.reparent (this);
			m_UNION?.reparent (this);
			m_UNIQUE?.reparent (this);
			m_UNIVERSAL?.reparent (this);
			m_UniversalString?.reparent (this);
			m_UTCTime?.reparent (this);
			m_UTF8String?.reparent (this);
			m_VideotexString?.reparent (this);
			m_VisibleString?.reparent (this);
			m_WITH?.reparent (this);
			m_ANY?.reparent (this);
			m_DEFINED?.reparent (this);
			m_MACRO?.reparent (this);
			m_MACRO_BODY?.reparent (this);
			m_MODULE_IDENTITY?.reparent (this);
			m_OBJECT_IDENTITY?.reparent (this);
			m_OBJECT_TYPE?.reparent (this);
			m_NOTIFICATION_TYPE?.reparent (this);
			m_TEXTUAL_CONVENTION?.reparent (this);
			m_OBJECT_GROUP?.reparent (this);
			m_NOTIFICATION_GROUP?.reparent (this);
			m_MODULE_COMPLIANCE?.reparent (this);
			m_AGENT_CAPABILITIES?.reparent (this);
			m_TRAP_TYPE?.reparent (this);
			m_LAST_UPDATED?.reparent (this);
			m_ORGANIZATION?.reparent (this);
			m_CONTACT_INFO?.reparent (this);
			m_DESCRIPTION?.reparent (this);
			m_REVISION?.reparent (this);
			m_STATUS?.reparent (this);
			m_REFERENCE?.reparent (this);
			m_MAX_ACCESS?.reparent (this);
			m_BITS?.reparent (this);
			m_UNITS?.reparent (this);
			m_INDEX?.reparent (this);
			m_AUGMENTS?.reparent (this);
			m_DEFVAL?.reparent (this);
			m_OBJECTS?.reparent (this);
			m_DISPLAY_HINT?.reparent (this);
			m_NOTIFICATIONS?.reparent (this);
			m_MODULE?.reparent (this);
			m_MANDATORY_GROUPS?.reparent (this);
			m_GROUP?.reparent (this);
			m_WRITE_SYNTAX?.reparent (this);
			m_MIN_ACCESS?.reparent (this);
			m_PRODUCT_RELEASE?.reparent (this);
			m_SUPPORTS?.reparent (this);
			m_VARIATION?.reparent (this);
			m_ACCESS?.reparent (this);
			m_CREATION_REQUIRES?.reparent (this);
			m_ENTERPRISE?.reparent (this);
			m_VARIABLES?.reparent (this);
		}

		//
		// initialize object associated with syntax rule keyword
		//

		public void _init ()
		{
			m_DESCENDANTS = null;
			m_SUCCESSORS = null;
			m_ABSENT = null;
			m_ABSTRACT_SYNTAX = null;
			m_ALL = null;
			m_APPLICATION = null;
			m_AUTOMATIC = null;
			m_BEGIN = null;
			m_BIT = null;
			m_BMPString = null;
			m_BOOLEAN = null;
			m_BY = null;
			m_CHARACTER = null;
			m_CHOICE = null;
			m_CLASS = null;
			m_COMPONENT = null;
			m_COMPONENTS = null;
			m_CONSTRAINED = null;
			m_CONTAINING = null;
			m_DATE = null;
			m_DATE_TIME = null;
			m_DEFAULT = null;
			m_DEFINITIONS = null;
			m_DURATION = null;
			m_EMBEDDED = null;
			m_ENCODED = null;
			m_ENCODING_CONTROL = null;
			m_END = null;
			m_ENUMERATED = null;
			m_EXCEPT = null;
			m_EXPLICIT = null;
			m_EXPORTS = null;
			m_EXTENSIBILITY = null;
			m_EXTERNAL = null;
			m_FALSE = null;
			m_FROM = null;
			m_GeneralizedTime = null;
			m_GeneralString = null;
			m_GraphicString = null;
			m_IA5String = null;
			m_IDENTIFIER = null;
			m_IMPLICIT = null;
			m_IMPLIED = null;
			m_IMPORTS = null;
			m_INCLUDES = null;
			m_INSTANCE = null;
			m_INSTRUCTIONS = null;
			m_INTEGER = null;
			m_INTERSECTION = null;
			m_ISO646String = null;
			m_MAX = null;
			m_MIN = null;
			m_MINUS_INFINITY = null;
			m_NOT_A_NUMBER = null;
			m_NULL = null;
			m_NumericString = null;
			m_OBJECT = null;
			m_ObjectDescriptor = null;
			m_OCTET = null;
			m_OF = null;
			m_OID_IRI = null;
			m_OPTIONAL = null;
			m_PATTERN = null;
			m_PDV = null;
			m_PLUS_INFINITY = null;
			m_PRESENT = null;
			m_PrintableString = null;
			m_PRIVATE = null;
			m_REAL = null;
			m_RELATIVE_OID = null;
			m_RELATIVE_OID_IRI = null;
			m_SEQUENCE = null;
			m_SET = null;
			m_SETTINGS = null;
			m_SIZE = null;
			m_STRING = null;
			m_SYNTAX = null;
			m_T61String = null;
			m_TAGS = null;
			m_TeletexString = null;
			m_TIME = null;
			m_TIME_OF_DAY = null;
			m_TRUE = null;
			m_TYPE_IDENTIFIER = null;
			m_UNION = null;
			m_UNIQUE = null;
			m_UNIVERSAL = null;
			m_UniversalString = null;
			m_UTCTime = null;
			m_UTF8String = null;
			m_VideotexString = null;
			m_VisibleString = null;
			m_WITH = null;
			m_ANY = null;
			m_DEFINED = null;
			m_MACRO = null;
			m_MACRO_BODY = null;
			m_MODULE_IDENTITY = null;
			m_OBJECT_IDENTITY = null;
			m_OBJECT_TYPE = null;
			m_NOTIFICATION_TYPE = null;
			m_TEXTUAL_CONVENTION = null;
			m_OBJECT_GROUP = null;
			m_NOTIFICATION_GROUP = null;
			m_MODULE_COMPLIANCE = null;
			m_AGENT_CAPABILITIES = null;
			m_TRAP_TYPE = null;
			m_LAST_UPDATED = null;
			m_ORGANIZATION = null;
			m_CONTACT_INFO = null;
			m_DESCRIPTION = null;
			m_REVISION = null;
			m_STATUS = null;
			m_REFERENCE = null;
			m_MAX_ACCESS = null;
			m_BITS = null;
			m_UNITS = null;
			m_INDEX = null;
			m_AUGMENTS = null;
			m_DEFVAL = null;
			m_OBJECTS = null;
			m_DISPLAY_HINT = null;
			m_NOTIFICATIONS = null;
			m_MODULE = null;
			m_MANDATORY_GROUPS = null;
			m_GROUP = null;
			m_WRITE_SYNTAX = null;
			m_MIN_ACCESS = null;
			m_PRODUCT_RELEASE = null;
			m_SUPPORTS = null;
			m_VARIATION = null;
			m_ACCESS = null;
			m_CREATION_REQUIRES = null;
			m_ENTERPRISE = null;
			m_VARIABLES = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule keyword

		// counter of all nodes associated with syntax rule keyword
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule keyword
		[DataMember (Name = "m_DESCENDANTS")] public SyntaxTreeToken m_DESCENDANTS { get; private set; }
		[DataMember (Name = "m_SUCCESSORS")] public SyntaxTreeToken m_SUCCESSORS { get; private set; }
		[DataMember (Name = "m_ABSENT")] public SyntaxTreeToken m_ABSENT { get; private set; }
		[DataMember (Name = "m_ABSTRACT_SYNTAX")] public SyntaxTreeToken m_ABSTRACT_SYNTAX { get; private set; }
		[DataMember (Name = "m_ALL")] public SyntaxTreeToken m_ALL { get; private set; }
		[DataMember (Name = "m_APPLICATION")] public SyntaxTreeToken m_APPLICATION { get; private set; }
		[DataMember (Name = "m_AUTOMATIC")] public SyntaxTreeToken m_AUTOMATIC { get; private set; }
		[DataMember (Name = "m_BEGIN")] public SyntaxTreeToken m_BEGIN { get; private set; }
		[DataMember (Name = "m_BIT")] public SyntaxTreeToken m_BIT { get; private set; }
		[DataMember (Name = "m_BMPString")] public SyntaxTreeToken m_BMPString { get; private set; }
		[DataMember (Name = "m_BOOLEAN")] public SyntaxTreeToken m_BOOLEAN { get; private set; }
		[DataMember (Name = "m_BY")] public SyntaxTreeToken m_BY { get; private set; }
		[DataMember (Name = "m_CHARACTER")] public SyntaxTreeToken m_CHARACTER { get; private set; }
		[DataMember (Name = "m_CHOICE")] public SyntaxTreeToken m_CHOICE { get; private set; }
		[DataMember (Name = "m_CLASS")] public SyntaxTreeToken m_CLASS { get; private set; }
		[DataMember (Name = "m_COMPONENT")] public SyntaxTreeToken m_COMPONENT { get; private set; }
		[DataMember (Name = "m_COMPONENTS")] public SyntaxTreeToken m_COMPONENTS { get; private set; }
		[DataMember (Name = "m_CONSTRAINED")] public SyntaxTreeToken m_CONSTRAINED { get; private set; }
		[DataMember (Name = "m_CONTAINING")] public SyntaxTreeToken m_CONTAINING { get; private set; }
		[DataMember (Name = "m_DATE")] public SyntaxTreeToken m_DATE { get; private set; }
		[DataMember (Name = "m_DATE_TIME")] public SyntaxTreeToken m_DATE_TIME { get; private set; }
		[DataMember (Name = "m_DEFAULT")] public SyntaxTreeToken m_DEFAULT { get; private set; }
		[DataMember (Name = "m_DEFINITIONS")] public SyntaxTreeToken m_DEFINITIONS { get; private set; }
		[DataMember (Name = "m_DURATION")] public SyntaxTreeToken m_DURATION { get; private set; }
		[DataMember (Name = "m_EMBEDDED")] public SyntaxTreeToken m_EMBEDDED { get; private set; }
		[DataMember (Name = "m_ENCODED")] public SyntaxTreeToken m_ENCODED { get; private set; }
		[DataMember (Name = "m_ENCODING_CONTROL")] public SyntaxTreeToken m_ENCODING_CONTROL { get; private set; }
		[DataMember (Name = "m_END")] public SyntaxTreeToken m_END { get; private set; }
		[DataMember (Name = "m_ENUMERATED")] public SyntaxTreeToken m_ENUMERATED { get; private set; }
		[DataMember (Name = "m_EXCEPT")] public SyntaxTreeToken m_EXCEPT { get; private set; }
		[DataMember (Name = "m_EXPLICIT")] public SyntaxTreeToken m_EXPLICIT { get; private set; }
		[DataMember (Name = "m_EXPORTS")] public SyntaxTreeToken m_EXPORTS { get; private set; }
		[DataMember (Name = "m_EXTENSIBILITY")] public SyntaxTreeToken m_EXTENSIBILITY { get; private set; }
		[DataMember (Name = "m_EXTERNAL")] public SyntaxTreeToken m_EXTERNAL { get; private set; }
		[DataMember (Name = "m_FALSE")] public SyntaxTreeToken m_FALSE { get; private set; }
		[DataMember (Name = "m_FROM")] public SyntaxTreeToken m_FROM { get; private set; }
		[DataMember (Name = "m_GeneralizedTime")] public SyntaxTreeToken m_GeneralizedTime { get; private set; }
		[DataMember (Name = "m_GeneralString")] public SyntaxTreeToken m_GeneralString { get; private set; }
		[DataMember (Name = "m_GraphicString")] public SyntaxTreeToken m_GraphicString { get; private set; }
		[DataMember (Name = "m_IA5String")] public SyntaxTreeToken m_IA5String { get; private set; }
		[DataMember (Name = "m_IDENTIFIER")] public SyntaxTreeToken m_IDENTIFIER { get; private set; }
		[DataMember (Name = "m_IMPLICIT")] public SyntaxTreeToken m_IMPLICIT { get; private set; }
		[DataMember (Name = "m_IMPLIED")] public SyntaxTreeToken m_IMPLIED { get; private set; }
		[DataMember (Name = "m_IMPORTS")] public SyntaxTreeToken m_IMPORTS { get; private set; }
		[DataMember (Name = "m_INCLUDES")] public SyntaxTreeToken m_INCLUDES { get; private set; }
		[DataMember (Name = "m_INSTANCE")] public SyntaxTreeToken m_INSTANCE { get; private set; }
		[DataMember (Name = "m_INSTRUCTIONS")] public SyntaxTreeToken m_INSTRUCTIONS { get; private set; }
		[DataMember (Name = "m_INTEGER")] public SyntaxTreeToken m_INTEGER { get; private set; }
		[DataMember (Name = "m_INTERSECTION")] public SyntaxTreeToken m_INTERSECTION { get; private set; }
		[DataMember (Name = "m_ISO646String")] public SyntaxTreeToken m_ISO646String { get; private set; }
		[DataMember (Name = "m_MAX")] public SyntaxTreeToken m_MAX { get; private set; }
		[DataMember (Name = "m_MIN")] public SyntaxTreeToken m_MIN { get; private set; }
		[DataMember (Name = "m_MINUS_INFINITY")] public SyntaxTreeToken m_MINUS_INFINITY { get; private set; }
		[DataMember (Name = "m_NOT_A_NUMBER")] public SyntaxTreeToken m_NOT_A_NUMBER { get; private set; }
		[DataMember (Name = "m_NULL")] public SyntaxTreeToken m_NULL { get; private set; }
		[DataMember (Name = "m_NumericString")] public SyntaxTreeToken m_NumericString { get; private set; }
		[DataMember (Name = "m_OBJECT")] public SyntaxTreeToken m_OBJECT { get; private set; }
		[DataMember (Name = "m_ObjectDescriptor")] public SyntaxTreeToken m_ObjectDescriptor { get; private set; }
		[DataMember (Name = "m_OCTET")] public SyntaxTreeToken m_OCTET { get; private set; }
		[DataMember (Name = "m_OF")] public SyntaxTreeToken m_OF { get; private set; }
		[DataMember (Name = "m_OID_IRI")] public SyntaxTreeToken m_OID_IRI { get; private set; }
		[DataMember (Name = "m_OPTIONAL")] public SyntaxTreeToken m_OPTIONAL { get; private set; }
		[DataMember (Name = "m_PATTERN")] public SyntaxTreeToken m_PATTERN { get; private set; }
		[DataMember (Name = "m_PDV")] public SyntaxTreeToken m_PDV { get; private set; }
		[DataMember (Name = "m_PLUS_INFINITY")] public SyntaxTreeToken m_PLUS_INFINITY { get; private set; }
		[DataMember (Name = "m_PRESENT")] public SyntaxTreeToken m_PRESENT { get; private set; }
		[DataMember (Name = "m_PrintableString")] public SyntaxTreeToken m_PrintableString { get; private set; }
		[DataMember (Name = "m_PRIVATE")] public SyntaxTreeToken m_PRIVATE { get; private set; }
		[DataMember (Name = "m_REAL")] public SyntaxTreeToken m_REAL { get; private set; }
		[DataMember (Name = "m_RELATIVE_OID")] public SyntaxTreeToken m_RELATIVE_OID { get; private set; }
		[DataMember (Name = "m_RELATIVE_OID_IRI")] public SyntaxTreeToken m_RELATIVE_OID_IRI { get; private set; }
		[DataMember (Name = "m_SEQUENCE")] public SyntaxTreeToken m_SEQUENCE { get; private set; }
		[DataMember (Name = "m_SET")] public SyntaxTreeToken m_SET { get; private set; }
		[DataMember (Name = "m_SETTINGS")] public SyntaxTreeToken m_SETTINGS { get; private set; }
		[DataMember (Name = "m_SIZE")] public SyntaxTreeToken m_SIZE { get; private set; }
		[DataMember (Name = "m_STRING")] public SyntaxTreeToken m_STRING { get; private set; }
		[DataMember (Name = "m_SYNTAX")] public SyntaxTreeToken m_SYNTAX { get; private set; }
		[DataMember (Name = "m_T61String")] public SyntaxTreeToken m_T61String { get; private set; }
		[DataMember (Name = "m_TAGS")] public SyntaxTreeToken m_TAGS { get; private set; }
		[DataMember (Name = "m_TeletexString")] public SyntaxTreeToken m_TeletexString { get; private set; }
		[DataMember (Name = "m_TIME")] public SyntaxTreeToken m_TIME { get; private set; }
		[DataMember (Name = "m_TIME_OF_DAY")] public SyntaxTreeToken m_TIME_OF_DAY { get; private set; }
		[DataMember (Name = "m_TRUE")] public SyntaxTreeToken m_TRUE { get; private set; }
		[DataMember (Name = "m_TYPE_IDENTIFIER")] public SyntaxTreeToken m_TYPE_IDENTIFIER { get; private set; }
		[DataMember (Name = "m_UNION")] public SyntaxTreeToken m_UNION { get; private set; }
		[DataMember (Name = "m_UNIQUE")] public SyntaxTreeToken m_UNIQUE { get; private set; }
		[DataMember (Name = "m_UNIVERSAL")] public SyntaxTreeToken m_UNIVERSAL { get; private set; }
		[DataMember (Name = "m_UniversalString")] public SyntaxTreeToken m_UniversalString { get; private set; }
		[DataMember (Name = "m_UTCTime")] public SyntaxTreeToken m_UTCTime { get; private set; }
		[DataMember (Name = "m_UTF8String")] public SyntaxTreeToken m_UTF8String { get; private set; }
		[DataMember (Name = "m_VideotexString")] public SyntaxTreeToken m_VideotexString { get; private set; }
		[DataMember (Name = "m_VisibleString")] public SyntaxTreeToken m_VisibleString { get; private set; }
		[DataMember (Name = "m_WITH")] public SyntaxTreeToken m_WITH { get; private set; }
		[DataMember (Name = "m_ANY")] public SyntaxTreeToken m_ANY { get; private set; }
		[DataMember (Name = "m_DEFINED")] public SyntaxTreeToken m_DEFINED { get; private set; }
		[DataMember (Name = "m_MACRO")] public SyntaxTreeToken m_MACRO { get; private set; }
		[DataMember (Name = "m_MACRO_BODY")] public SyntaxTreeToken m_MACRO_BODY { get; private set; }
		[DataMember (Name = "m_MODULE_IDENTITY")] public SyntaxTreeToken m_MODULE_IDENTITY { get; private set; }
		[DataMember (Name = "m_OBJECT_IDENTITY")] public SyntaxTreeToken m_OBJECT_IDENTITY { get; private set; }
		[DataMember (Name = "m_OBJECT_TYPE")] public SyntaxTreeToken m_OBJECT_TYPE { get; private set; }
		[DataMember (Name = "m_NOTIFICATION_TYPE")] public SyntaxTreeToken m_NOTIFICATION_TYPE { get; private set; }
		[DataMember (Name = "m_TEXTUAL_CONVENTION")] public SyntaxTreeToken m_TEXTUAL_CONVENTION { get; private set; }
		[DataMember (Name = "m_OBJECT_GROUP")] public SyntaxTreeToken m_OBJECT_GROUP { get; private set; }
		[DataMember (Name = "m_NOTIFICATION_GROUP")] public SyntaxTreeToken m_NOTIFICATION_GROUP { get; private set; }
		[DataMember (Name = "m_MODULE_COMPLIANCE")] public SyntaxTreeToken m_MODULE_COMPLIANCE { get; private set; }
		[DataMember (Name = "m_AGENT_CAPABILITIES")] public SyntaxTreeToken m_AGENT_CAPABILITIES { get; private set; }
		[DataMember (Name = "m_TRAP_TYPE")] public SyntaxTreeToken m_TRAP_TYPE { get; private set; }
		[DataMember (Name = "m_LAST_UPDATED")] public SyntaxTreeToken m_LAST_UPDATED { get; private set; }
		[DataMember (Name = "m_ORGANIZATION")] public SyntaxTreeToken m_ORGANIZATION { get; private set; }
		[DataMember (Name = "m_CONTACT_INFO")] public SyntaxTreeToken m_CONTACT_INFO { get; private set; }
		[DataMember (Name = "m_DESCRIPTION")] public SyntaxTreeToken m_DESCRIPTION { get; private set; }
		[DataMember (Name = "m_REVISION")] public SyntaxTreeToken m_REVISION { get; private set; }
		[DataMember (Name = "m_STATUS")] public SyntaxTreeToken m_STATUS { get; private set; }
		[DataMember (Name = "m_REFERENCE")] public SyntaxTreeToken m_REFERENCE { get; private set; }
		[DataMember (Name = "m_MAX_ACCESS")] public SyntaxTreeToken m_MAX_ACCESS { get; private set; }
		[DataMember (Name = "m_BITS")] public SyntaxTreeToken m_BITS { get; private set; }
		[DataMember (Name = "m_UNITS")] public SyntaxTreeToken m_UNITS { get; private set; }
		[DataMember (Name = "m_INDEX")] public SyntaxTreeToken m_INDEX { get; private set; }
		[DataMember (Name = "m_AUGMENTS")] public SyntaxTreeToken m_AUGMENTS { get; private set; }
		[DataMember (Name = "m_DEFVAL")] public SyntaxTreeToken m_DEFVAL { get; private set; }
		[DataMember (Name = "m_OBJECTS")] public SyntaxTreeToken m_OBJECTS { get; private set; }
		[DataMember (Name = "m_DISPLAY_HINT")] public SyntaxTreeToken m_DISPLAY_HINT { get; private set; }
		[DataMember (Name = "m_NOTIFICATIONS")] public SyntaxTreeToken m_NOTIFICATIONS { get; private set; }
		[DataMember (Name = "m_MODULE")] public SyntaxTreeToken m_MODULE { get; private set; }
		[DataMember (Name = "m_MANDATORY_GROUPS")] public SyntaxTreeToken m_MANDATORY_GROUPS { get; private set; }
		[DataMember (Name = "m_GROUP")] public SyntaxTreeToken m_GROUP { get; private set; }
		[DataMember (Name = "m_WRITE_SYNTAX")] public SyntaxTreeToken m_WRITE_SYNTAX { get; private set; }
		[DataMember (Name = "m_MIN_ACCESS")] public SyntaxTreeToken m_MIN_ACCESS { get; private set; }
		[DataMember (Name = "m_PRODUCT_RELEASE")] public SyntaxTreeToken m_PRODUCT_RELEASE { get; private set; }
		[DataMember (Name = "m_SUPPORTS")] public SyntaxTreeToken m_SUPPORTS { get; private set; }
		[DataMember (Name = "m_VARIATION")] public SyntaxTreeToken m_VARIATION { get; private set; }
		[DataMember (Name = "m_ACCESS")] public SyntaxTreeToken m_ACCESS { get; private set; }
		[DataMember (Name = "m_CREATION_REQUIRES")] public SyntaxTreeToken m_CREATION_REQUIRES { get; private set; }
		[DataMember (Name = "m_ENTERPRISE")] public SyntaxTreeToken m_ENTERPRISE { get; private set; }
		[DataMember (Name = "m_VARIABLES")] public SyntaxTreeToken m_VARIABLES { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule keyword

		// delegate function (callback) prototype associated with syntax rule keyword
		public delegate bool keyword_Callback (SyntaxTreeCallbackReason reason, keyword.production_kind kind, keyword p_keyword);

		// event associated with syntax rule keyword
		public event keyword_Callback keyword_Event;

		// event trigger associated with syntax rule keyword
		public bool Raise_keyword_Event (SyntaxTreeCallbackReason reason, keyword.production_kind kind, keyword p_keyword)
		{
			bool? status = keyword_Event?.Invoke (reason, kind, p_keyword);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule keyword
		//
		// traverse syntax tree node associated with any production of syntax rule keyword
		//

		public void Traverse (keyword p_keyword)
		{
			if (p_keyword.isLocked())
				return;
			p_keyword.dolock();
			keyword.production_kind kind = (keyword.production_kind) p_keyword.kind;
			p_keyword.turn_reset ();
			if (Raise_keyword_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_keyword))
			switch (kind)
			{
				case keyword.production_kind.g_keyword_1:
					// traverse syntax tree node associated with production
					// keyword: DESCENDANTS

				break;
				case keyword.production_kind.g_keyword_2:
					// traverse syntax tree node associated with production
					// keyword: SUCCESSORS

				break;
				case keyword.production_kind.g_keyword_3:
					// traverse syntax tree node associated with production
					// keyword: ABSENT

				break;
				case keyword.production_kind.g_keyword_4:
					// traverse syntax tree node associated with production
					// keyword: ABSTRACT-SYNTAX

				break;
				case keyword.production_kind.g_keyword_5:
					// traverse syntax tree node associated with production
					// keyword: ALL

				break;
				case keyword.production_kind.g_keyword_6:
					// traverse syntax tree node associated with production
					// keyword: APPLICATION

				break;
				case keyword.production_kind.g_keyword_7:
					// traverse syntax tree node associated with production
					// keyword: AUTOMATIC

				break;
				case keyword.production_kind.g_keyword_8:
					// traverse syntax tree node associated with production
					// keyword: BEGIN

				break;
				case keyword.production_kind.g_keyword_9:
					// traverse syntax tree node associated with production
					// keyword: BIT

				break;
				case keyword.production_kind.g_keyword_10:
					// traverse syntax tree node associated with production
					// keyword: BMPString

				break;
				case keyword.production_kind.g_keyword_11:
					// traverse syntax tree node associated with production
					// keyword: BOOLEAN

				break;
				case keyword.production_kind.g_keyword_12:
					// traverse syntax tree node associated with production
					// keyword: BY

				break;
				case keyword.production_kind.g_keyword_13:
					// traverse syntax tree node associated with production
					// keyword: CHARACTER

				break;
				case keyword.production_kind.g_keyword_14:
					// traverse syntax tree node associated with production
					// keyword: CHOICE

				break;
				case keyword.production_kind.g_keyword_15:
					// traverse syntax tree node associated with production
					// keyword: CLASS

				break;
				case keyword.production_kind.g_keyword_16:
					// traverse syntax tree node associated with production
					// keyword: COMPONENT

				break;
				case keyword.production_kind.g_keyword_17:
					// traverse syntax tree node associated with production
					// keyword: COMPONENTS

				break;
				case keyword.production_kind.g_keyword_18:
					// traverse syntax tree node associated with production
					// keyword: CONSTRAINED

				break;
				case keyword.production_kind.g_keyword_19:
					// traverse syntax tree node associated with production
					// keyword: CONTAINING

				break;
				case keyword.production_kind.g_keyword_20:
					// traverse syntax tree node associated with production
					// keyword: DATE

				break;
				case keyword.production_kind.g_keyword_21:
					// traverse syntax tree node associated with production
					// keyword: DATE-TIME

				break;
				case keyword.production_kind.g_keyword_22:
					// traverse syntax tree node associated with production
					// keyword: DEFAULT

				break;
				case keyword.production_kind.g_keyword_23:
					// traverse syntax tree node associated with production
					// keyword: DEFINITIONS

				break;
				case keyword.production_kind.g_keyword_24:
					// traverse syntax tree node associated with production
					// keyword: DURATION

				break;
				case keyword.production_kind.g_keyword_25:
					// traverse syntax tree node associated with production
					// keyword: EMBEDDED

				break;
				case keyword.production_kind.g_keyword_26:
					// traverse syntax tree node associated with production
					// keyword: ENCODED

				break;
				case keyword.production_kind.g_keyword_27:
					// traverse syntax tree node associated with production
					// keyword: ENCODING-CONTROL

				break;
				case keyword.production_kind.g_keyword_28:
					// traverse syntax tree node associated with production
					// keyword: END

				break;
				case keyword.production_kind.g_keyword_29:
					// traverse syntax tree node associated with production
					// keyword: ENUMERATED

				break;
				case keyword.production_kind.g_keyword_30:
					// traverse syntax tree node associated with production
					// keyword: EXCEPT

				break;
				case keyword.production_kind.g_keyword_31:
					// traverse syntax tree node associated with production
					// keyword: EXPLICIT

				break;
				case keyword.production_kind.g_keyword_32:
					// traverse syntax tree node associated with production
					// keyword: EXPORTS

				break;
				case keyword.production_kind.g_keyword_33:
					// traverse syntax tree node associated with production
					// keyword: EXTENSIBILITY

				break;
				case keyword.production_kind.g_keyword_34:
					// traverse syntax tree node associated with production
					// keyword: EXTERNAL

				break;
				case keyword.production_kind.g_keyword_35:
					// traverse syntax tree node associated with production
					// keyword: FALSE

				break;
				case keyword.production_kind.g_keyword_36:
					// traverse syntax tree node associated with production
					// keyword: FROM

				break;
				case keyword.production_kind.g_keyword_37:
					// traverse syntax tree node associated with production
					// keyword: GeneralizedTime

				break;
				case keyword.production_kind.g_keyword_38:
					// traverse syntax tree node associated with production
					// keyword: GeneralString

				break;
				case keyword.production_kind.g_keyword_39:
					// traverse syntax tree node associated with production
					// keyword: GraphicString

				break;
				case keyword.production_kind.g_keyword_40:
					// traverse syntax tree node associated with production
					// keyword: IA5String

				break;
				case keyword.production_kind.g_keyword_41:
					// traverse syntax tree node associated with production
					// keyword: IDENTIFIER

				break;
				case keyword.production_kind.g_keyword_42:
					// traverse syntax tree node associated with production
					// keyword: IMPLICIT

				break;
				case keyword.production_kind.g_keyword_43:
					// traverse syntax tree node associated with production
					// keyword: IMPLIED

				break;
				case keyword.production_kind.g_keyword_44:
					// traverse syntax tree node associated with production
					// keyword: IMPORTS

				break;
				case keyword.production_kind.g_keyword_45:
					// traverse syntax tree node associated with production
					// keyword: INCLUDES

				break;
				case keyword.production_kind.g_keyword_46:
					// traverse syntax tree node associated with production
					// keyword: INSTANCE

				break;
				case keyword.production_kind.g_keyword_47:
					// traverse syntax tree node associated with production
					// keyword: INSTRUCTIONS

				break;
				case keyword.production_kind.g_keyword_48:
					// traverse syntax tree node associated with production
					// keyword: INTEGER

				break;
				case keyword.production_kind.g_keyword_49:
					// traverse syntax tree node associated with production
					// keyword: INTERSECTION

				break;
				case keyword.production_kind.g_keyword_50:
					// traverse syntax tree node associated with production
					// keyword: ISO646String

				break;
				case keyword.production_kind.g_keyword_51:
					// traverse syntax tree node associated with production
					// keyword: MAX

				break;
				case keyword.production_kind.g_keyword_52:
					// traverse syntax tree node associated with production
					// keyword: MIN

				break;
				case keyword.production_kind.g_keyword_53:
					// traverse syntax tree node associated with production
					// keyword: MINUS-INFINITY

				break;
				case keyword.production_kind.g_keyword_54:
					// traverse syntax tree node associated with production
					// keyword: NOT-A-NUMBER

				break;
				case keyword.production_kind.g_keyword_55:
					// traverse syntax tree node associated with production
					// keyword: NULL

				break;
				case keyword.production_kind.g_keyword_56:
					// traverse syntax tree node associated with production
					// keyword: NumericString

				break;
				case keyword.production_kind.g_keyword_57:
					// traverse syntax tree node associated with production
					// keyword: OBJECT

				break;
				case keyword.production_kind.g_keyword_58:
					// traverse syntax tree node associated with production
					// keyword: ObjectDescriptor

				break;
				case keyword.production_kind.g_keyword_59:
					// traverse syntax tree node associated with production
					// keyword: OCTET

				break;
				case keyword.production_kind.g_keyword_60:
					// traverse syntax tree node associated with production
					// keyword: OF

				break;
				case keyword.production_kind.g_keyword_61:
					// traverse syntax tree node associated with production
					// keyword: OID-IRI

				break;
				case keyword.production_kind.g_keyword_62:
					// traverse syntax tree node associated with production
					// keyword: OPTIONAL

				break;
				case keyword.production_kind.g_keyword_63:
					// traverse syntax tree node associated with production
					// keyword: PATTERN

				break;
				case keyword.production_kind.g_keyword_64:
					// traverse syntax tree node associated with production
					// keyword: PDV

				break;
				case keyword.production_kind.g_keyword_65:
					// traverse syntax tree node associated with production
					// keyword: PLUS-INFINITY

				break;
				case keyword.production_kind.g_keyword_66:
					// traverse syntax tree node associated with production
					// keyword: PRESENT

				break;
				case keyword.production_kind.g_keyword_67:
					// traverse syntax tree node associated with production
					// keyword: PrintableString

				break;
				case keyword.production_kind.g_keyword_68:
					// traverse syntax tree node associated with production
					// keyword: PRIVATE

				break;
				case keyword.production_kind.g_keyword_69:
					// traverse syntax tree node associated with production
					// keyword: REAL

				break;
				case keyword.production_kind.g_keyword_70:
					// traverse syntax tree node associated with production
					// keyword: RELATIVE-OID

				break;
				case keyword.production_kind.g_keyword_71:
					// traverse syntax tree node associated with production
					// keyword: RELATIVE-OID-IRI

				break;
				case keyword.production_kind.g_keyword_72:
					// traverse syntax tree node associated with production
					// keyword: SEQUENCE

				break;
				case keyword.production_kind.g_keyword_73:
					// traverse syntax tree node associated with production
					// keyword: SET

				break;
				case keyword.production_kind.g_keyword_74:
					// traverse syntax tree node associated with production
					// keyword: SETTINGS

				break;
				case keyword.production_kind.g_keyword_75:
					// traverse syntax tree node associated with production
					// keyword: SIZE

				break;
				case keyword.production_kind.g_keyword_76:
					// traverse syntax tree node associated with production
					// keyword: STRING

				break;
				case keyword.production_kind.g_keyword_77:
					// traverse syntax tree node associated with production
					// keyword: SYNTAX

				break;
				case keyword.production_kind.g_keyword_78:
					// traverse syntax tree node associated with production
					// keyword: T61String

				break;
				case keyword.production_kind.g_keyword_79:
					// traverse syntax tree node associated with production
					// keyword: TAGS

				break;
				case keyword.production_kind.g_keyword_80:
					// traverse syntax tree node associated with production
					// keyword: TeletexString

				break;
				case keyword.production_kind.g_keyword_81:
					// traverse syntax tree node associated with production
					// keyword: TIME

				break;
				case keyword.production_kind.g_keyword_82:
					// traverse syntax tree node associated with production
					// keyword: TIME-OF-DAY

				break;
				case keyword.production_kind.g_keyword_83:
					// traverse syntax tree node associated with production
					// keyword: TRUE

				break;
				case keyword.production_kind.g_keyword_84:
					// traverse syntax tree node associated with production
					// keyword: TYPE-IDENTIFIER

				break;
				case keyword.production_kind.g_keyword_85:
					// traverse syntax tree node associated with production
					// keyword: UNION

				break;
				case keyword.production_kind.g_keyword_86:
					// traverse syntax tree node associated with production
					// keyword: UNIQUE

				break;
				case keyword.production_kind.g_keyword_87:
					// traverse syntax tree node associated with production
					// keyword: UNIVERSAL

				break;
				case keyword.production_kind.g_keyword_88:
					// traverse syntax tree node associated with production
					// keyword: UniversalString

				break;
				case keyword.production_kind.g_keyword_89:
					// traverse syntax tree node associated with production
					// keyword: UTCTime

				break;
				case keyword.production_kind.g_keyword_90:
					// traverse syntax tree node associated with production
					// keyword: UTF8String

				break;
				case keyword.production_kind.g_keyword_91:
					// traverse syntax tree node associated with production
					// keyword: VideotexString

				break;
				case keyword.production_kind.g_keyword_92:
					// traverse syntax tree node associated with production
					// keyword: VisibleString

				break;
				case keyword.production_kind.g_keyword_93:
					// traverse syntax tree node associated with production
					// keyword: WITH

				break;
				case keyword.production_kind.g_keyword_94:
					// traverse syntax tree node associated with production
					// keyword: ANY

				break;
				case keyword.production_kind.g_keyword_95:
					// traverse syntax tree node associated with production
					// keyword: DEFINED

				break;
				case keyword.production_kind.g_keyword_96:
					// traverse syntax tree node associated with production
					// keyword: MACRO

				break;
				case keyword.production_kind.g_keyword_97:
					// traverse syntax tree node associated with production
					// keyword: MACRO-BODY

				break;
				case keyword.production_kind.g_keyword_98:
					// traverse syntax tree node associated with production
					// keyword: MODULE-IDENTITY

				break;
				case keyword.production_kind.g_keyword_99:
					// traverse syntax tree node associated with production
					// keyword: OBJECT-IDENTITY

				break;
				case keyword.production_kind.g_keyword_100:
					// traverse syntax tree node associated with production
					// keyword: OBJECT-TYPE

				break;
				case keyword.production_kind.g_keyword_101:
					// traverse syntax tree node associated with production
					// keyword: NOTIFICATION-TYPE

				break;
				case keyword.production_kind.g_keyword_102:
					// traverse syntax tree node associated with production
					// keyword: TEXTUAL-CONVENTION

				break;
				case keyword.production_kind.g_keyword_103:
					// traverse syntax tree node associated with production
					// keyword: OBJECT-GROUP

				break;
				case keyword.production_kind.g_keyword_104:
					// traverse syntax tree node associated with production
					// keyword: NOTIFICATION-GROUP

				break;
				case keyword.production_kind.g_keyword_105:
					// traverse syntax tree node associated with production
					// keyword: MODULE-COMPLIANCE

				break;
				case keyword.production_kind.g_keyword_106:
					// traverse syntax tree node associated with production
					// keyword: AGENT-CAPABILITIES

				break;
				case keyword.production_kind.g_keyword_107:
					// traverse syntax tree node associated with production
					// keyword: TRAP-TYPE

				break;
				case keyword.production_kind.g_keyword_108:
					// traverse syntax tree node associated with production
					// keyword: LAST-UPDATED

				break;
				case keyword.production_kind.g_keyword_109:
					// traverse syntax tree node associated with production
					// keyword: ORGANIZATION

				break;
				case keyword.production_kind.g_keyword_110:
					// traverse syntax tree node associated with production
					// keyword: CONTACT-INFO

				break;
				case keyword.production_kind.g_keyword_111:
					// traverse syntax tree node associated with production
					// keyword: DESCRIPTION

				break;
				case keyword.production_kind.g_keyword_112:
					// traverse syntax tree node associated with production
					// keyword: REVISION

				break;
				case keyword.production_kind.g_keyword_113:
					// traverse syntax tree node associated with production
					// keyword: STATUS

				break;
				case keyword.production_kind.g_keyword_114:
					// traverse syntax tree node associated with production
					// keyword: REFERENCE

				break;
				case keyword.production_kind.g_keyword_115:
					// traverse syntax tree node associated with production
					// keyword: MAX-ACCESS

				break;
				case keyword.production_kind.g_keyword_116:
					// traverse syntax tree node associated with production
					// keyword: BITS

				break;
				case keyword.production_kind.g_keyword_117:
					// traverse syntax tree node associated with production
					// keyword: UNITS

				break;
				case keyword.production_kind.g_keyword_118:
					// traverse syntax tree node associated with production
					// keyword: INDEX

				break;
				case keyword.production_kind.g_keyword_119:
					// traverse syntax tree node associated with production
					// keyword: AUGMENTS

				break;
				case keyword.production_kind.g_keyword_120:
					// traverse syntax tree node associated with production
					// keyword: DEFVAL

				break;
				case keyword.production_kind.g_keyword_121:
					// traverse syntax tree node associated with production
					// keyword: OBJECTS

				break;
				case keyword.production_kind.g_keyword_122:
					// traverse syntax tree node associated with production
					// keyword: DISPLAY-HINT

				break;
				case keyword.production_kind.g_keyword_123:
					// traverse syntax tree node associated with production
					// keyword: NOTIFICATIONS

				break;
				case keyword.production_kind.g_keyword_124:
					// traverse syntax tree node associated with production
					// keyword: MODULE

				break;
				case keyword.production_kind.g_keyword_125:
					// traverse syntax tree node associated with production
					// keyword: MANDATORY-GROUPS

				break;
				case keyword.production_kind.g_keyword_126:
					// traverse syntax tree node associated with production
					// keyword: GROUP

				break;
				case keyword.production_kind.g_keyword_127:
					// traverse syntax tree node associated with production
					// keyword: WRITE-SYNTAX

				break;
				case keyword.production_kind.g_keyword_128:
					// traverse syntax tree node associated with production
					// keyword: MIN-ACCESS

				break;
				case keyword.production_kind.g_keyword_129:
					// traverse syntax tree node associated with production
					// keyword: PRODUCT-RELEASE

				break;
				case keyword.production_kind.g_keyword_130:
					// traverse syntax tree node associated with production
					// keyword: SUPPORTS

				break;
				case keyword.production_kind.g_keyword_131:
					// traverse syntax tree node associated with production
					// keyword: VARIATION

				break;
				case keyword.production_kind.g_keyword_132:
					// traverse syntax tree node associated with production
					// keyword: ACCESS

				break;
				case keyword.production_kind.g_keyword_133:
					// traverse syntax tree node associated with production
					// keyword: CREATION-REQUIRES

				break;
				case keyword.production_kind.g_keyword_134:
					// traverse syntax tree node associated with production
					// keyword: ENTERPRISE

				break;
				case keyword.production_kind.g_keyword_135:
					// traverse syntax tree node associated with production
					// keyword: VARIABLES

				break;
			}
			Raise_keyword_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_keyword);
			p_keyword.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule keyword
		//

		public void TraverseCommon (keyword p_keyword)
		{
			keyword.production_kind kind = (keyword.production_kind) p_keyword.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_keyword))
			switch (kind)
			{
				case keyword.production_kind.g_keyword_1:
					// traverse syntax tree node associated with production
					// keyword: DESCENDANTS

						TraverseCommon (p_keyword.m_DESCENDANTS);
				break;
				case keyword.production_kind.g_keyword_2:
					// traverse syntax tree node associated with production
					// keyword: SUCCESSORS

						TraverseCommon (p_keyword.m_SUCCESSORS);
				break;
				case keyword.production_kind.g_keyword_3:
					// traverse syntax tree node associated with production
					// keyword: ABSENT

						TraverseCommon (p_keyword.m_ABSENT);
				break;
				case keyword.production_kind.g_keyword_4:
					// traverse syntax tree node associated with production
					// keyword: ABSTRACT-SYNTAX

						TraverseCommon (p_keyword.m_ABSTRACT_SYNTAX);
				break;
				case keyword.production_kind.g_keyword_5:
					// traverse syntax tree node associated with production
					// keyword: ALL

						TraverseCommon (p_keyword.m_ALL);
				break;
				case keyword.production_kind.g_keyword_6:
					// traverse syntax tree node associated with production
					// keyword: APPLICATION

						TraverseCommon (p_keyword.m_APPLICATION);
				break;
				case keyword.production_kind.g_keyword_7:
					// traverse syntax tree node associated with production
					// keyword: AUTOMATIC

						TraverseCommon (p_keyword.m_AUTOMATIC);
				break;
				case keyword.production_kind.g_keyword_8:
					// traverse syntax tree node associated with production
					// keyword: BEGIN

						TraverseCommon (p_keyword.m_BEGIN);
				break;
				case keyword.production_kind.g_keyword_9:
					// traverse syntax tree node associated with production
					// keyword: BIT

						TraverseCommon (p_keyword.m_BIT);
				break;
				case keyword.production_kind.g_keyword_10:
					// traverse syntax tree node associated with production
					// keyword: BMPString

						TraverseCommon (p_keyword.m_BMPString);
				break;
				case keyword.production_kind.g_keyword_11:
					// traverse syntax tree node associated with production
					// keyword: BOOLEAN

						TraverseCommon (p_keyword.m_BOOLEAN);
				break;
				case keyword.production_kind.g_keyword_12:
					// traverse syntax tree node associated with production
					// keyword: BY

						TraverseCommon (p_keyword.m_BY);
				break;
				case keyword.production_kind.g_keyword_13:
					// traverse syntax tree node associated with production
					// keyword: CHARACTER

						TraverseCommon (p_keyword.m_CHARACTER);
				break;
				case keyword.production_kind.g_keyword_14:
					// traverse syntax tree node associated with production
					// keyword: CHOICE

						TraverseCommon (p_keyword.m_CHOICE);
				break;
				case keyword.production_kind.g_keyword_15:
					// traverse syntax tree node associated with production
					// keyword: CLASS

						TraverseCommon (p_keyword.m_CLASS);
				break;
				case keyword.production_kind.g_keyword_16:
					// traverse syntax tree node associated with production
					// keyword: COMPONENT

						TraverseCommon (p_keyword.m_COMPONENT);
				break;
				case keyword.production_kind.g_keyword_17:
					// traverse syntax tree node associated with production
					// keyword: COMPONENTS

						TraverseCommon (p_keyword.m_COMPONENTS);
				break;
				case keyword.production_kind.g_keyword_18:
					// traverse syntax tree node associated with production
					// keyword: CONSTRAINED

						TraverseCommon (p_keyword.m_CONSTRAINED);
				break;
				case keyword.production_kind.g_keyword_19:
					// traverse syntax tree node associated with production
					// keyword: CONTAINING

						TraverseCommon (p_keyword.m_CONTAINING);
				break;
				case keyword.production_kind.g_keyword_20:
					// traverse syntax tree node associated with production
					// keyword: DATE

						TraverseCommon (p_keyword.m_DATE);
				break;
				case keyword.production_kind.g_keyword_21:
					// traverse syntax tree node associated with production
					// keyword: DATE-TIME

						TraverseCommon (p_keyword.m_DATE_TIME);
				break;
				case keyword.production_kind.g_keyword_22:
					// traverse syntax tree node associated with production
					// keyword: DEFAULT

						TraverseCommon (p_keyword.m_DEFAULT);
				break;
				case keyword.production_kind.g_keyword_23:
					// traverse syntax tree node associated with production
					// keyword: DEFINITIONS

						TraverseCommon (p_keyword.m_DEFINITIONS);
				break;
				case keyword.production_kind.g_keyword_24:
					// traverse syntax tree node associated with production
					// keyword: DURATION

						TraverseCommon (p_keyword.m_DURATION);
				break;
				case keyword.production_kind.g_keyword_25:
					// traverse syntax tree node associated with production
					// keyword: EMBEDDED

						TraverseCommon (p_keyword.m_EMBEDDED);
				break;
				case keyword.production_kind.g_keyword_26:
					// traverse syntax tree node associated with production
					// keyword: ENCODED

						TraverseCommon (p_keyword.m_ENCODED);
				break;
				case keyword.production_kind.g_keyword_27:
					// traverse syntax tree node associated with production
					// keyword: ENCODING-CONTROL

						TraverseCommon (p_keyword.m_ENCODING_CONTROL);
				break;
				case keyword.production_kind.g_keyword_28:
					// traverse syntax tree node associated with production
					// keyword: END

						TraverseCommon (p_keyword.m_END);
				break;
				case keyword.production_kind.g_keyword_29:
					// traverse syntax tree node associated with production
					// keyword: ENUMERATED

						TraverseCommon (p_keyword.m_ENUMERATED);
				break;
				case keyword.production_kind.g_keyword_30:
					// traverse syntax tree node associated with production
					// keyword: EXCEPT

						TraverseCommon (p_keyword.m_EXCEPT);
				break;
				case keyword.production_kind.g_keyword_31:
					// traverse syntax tree node associated with production
					// keyword: EXPLICIT

						TraverseCommon (p_keyword.m_EXPLICIT);
				break;
				case keyword.production_kind.g_keyword_32:
					// traverse syntax tree node associated with production
					// keyword: EXPORTS

						TraverseCommon (p_keyword.m_EXPORTS);
				break;
				case keyword.production_kind.g_keyword_33:
					// traverse syntax tree node associated with production
					// keyword: EXTENSIBILITY

						TraverseCommon (p_keyword.m_EXTENSIBILITY);
				break;
				case keyword.production_kind.g_keyword_34:
					// traverse syntax tree node associated with production
					// keyword: EXTERNAL

						TraverseCommon (p_keyword.m_EXTERNAL);
				break;
				case keyword.production_kind.g_keyword_35:
					// traverse syntax tree node associated with production
					// keyword: FALSE

						TraverseCommon (p_keyword.m_FALSE);
				break;
				case keyword.production_kind.g_keyword_36:
					// traverse syntax tree node associated with production
					// keyword: FROM

						TraverseCommon (p_keyword.m_FROM);
				break;
				case keyword.production_kind.g_keyword_37:
					// traverse syntax tree node associated with production
					// keyword: GeneralizedTime

						TraverseCommon (p_keyword.m_GeneralizedTime);
				break;
				case keyword.production_kind.g_keyword_38:
					// traverse syntax tree node associated with production
					// keyword: GeneralString

						TraverseCommon (p_keyword.m_GeneralString);
				break;
				case keyword.production_kind.g_keyword_39:
					// traverse syntax tree node associated with production
					// keyword: GraphicString

						TraverseCommon (p_keyword.m_GraphicString);
				break;
				case keyword.production_kind.g_keyword_40:
					// traverse syntax tree node associated with production
					// keyword: IA5String

						TraverseCommon (p_keyword.m_IA5String);
				break;
				case keyword.production_kind.g_keyword_41:
					// traverse syntax tree node associated with production
					// keyword: IDENTIFIER

						TraverseCommon (p_keyword.m_IDENTIFIER);
				break;
				case keyword.production_kind.g_keyword_42:
					// traverse syntax tree node associated with production
					// keyword: IMPLICIT

						TraverseCommon (p_keyword.m_IMPLICIT);
				break;
				case keyword.production_kind.g_keyword_43:
					// traverse syntax tree node associated with production
					// keyword: IMPLIED

						TraverseCommon (p_keyword.m_IMPLIED);
				break;
				case keyword.production_kind.g_keyword_44:
					// traverse syntax tree node associated with production
					// keyword: IMPORTS

						TraverseCommon (p_keyword.m_IMPORTS);
				break;
				case keyword.production_kind.g_keyword_45:
					// traverse syntax tree node associated with production
					// keyword: INCLUDES

						TraverseCommon (p_keyword.m_INCLUDES);
				break;
				case keyword.production_kind.g_keyword_46:
					// traverse syntax tree node associated with production
					// keyword: INSTANCE

						TraverseCommon (p_keyword.m_INSTANCE);
				break;
				case keyword.production_kind.g_keyword_47:
					// traverse syntax tree node associated with production
					// keyword: INSTRUCTIONS

						TraverseCommon (p_keyword.m_INSTRUCTIONS);
				break;
				case keyword.production_kind.g_keyword_48:
					// traverse syntax tree node associated with production
					// keyword: INTEGER

						TraverseCommon (p_keyword.m_INTEGER);
				break;
				case keyword.production_kind.g_keyword_49:
					// traverse syntax tree node associated with production
					// keyword: INTERSECTION

						TraverseCommon (p_keyword.m_INTERSECTION);
				break;
				case keyword.production_kind.g_keyword_50:
					// traverse syntax tree node associated with production
					// keyword: ISO646String

						TraverseCommon (p_keyword.m_ISO646String);
				break;
				case keyword.production_kind.g_keyword_51:
					// traverse syntax tree node associated with production
					// keyword: MAX

						TraverseCommon (p_keyword.m_MAX);
				break;
				case keyword.production_kind.g_keyword_52:
					// traverse syntax tree node associated with production
					// keyword: MIN

						TraverseCommon (p_keyword.m_MIN);
				break;
				case keyword.production_kind.g_keyword_53:
					// traverse syntax tree node associated with production
					// keyword: MINUS-INFINITY

						TraverseCommon (p_keyword.m_MINUS_INFINITY);
				break;
				case keyword.production_kind.g_keyword_54:
					// traverse syntax tree node associated with production
					// keyword: NOT-A-NUMBER

						TraverseCommon (p_keyword.m_NOT_A_NUMBER);
				break;
				case keyword.production_kind.g_keyword_55:
					// traverse syntax tree node associated with production
					// keyword: NULL

						TraverseCommon (p_keyword.m_NULL);
				break;
				case keyword.production_kind.g_keyword_56:
					// traverse syntax tree node associated with production
					// keyword: NumericString

						TraverseCommon (p_keyword.m_NumericString);
				break;
				case keyword.production_kind.g_keyword_57:
					// traverse syntax tree node associated with production
					// keyword: OBJECT

						TraverseCommon (p_keyword.m_OBJECT);
				break;
				case keyword.production_kind.g_keyword_58:
					// traverse syntax tree node associated with production
					// keyword: ObjectDescriptor

						TraverseCommon (p_keyword.m_ObjectDescriptor);
				break;
				case keyword.production_kind.g_keyword_59:
					// traverse syntax tree node associated with production
					// keyword: OCTET

						TraverseCommon (p_keyword.m_OCTET);
				break;
				case keyword.production_kind.g_keyword_60:
					// traverse syntax tree node associated with production
					// keyword: OF

						TraverseCommon (p_keyword.m_OF);
				break;
				case keyword.production_kind.g_keyword_61:
					// traverse syntax tree node associated with production
					// keyword: OID-IRI

						TraverseCommon (p_keyword.m_OID_IRI);
				break;
				case keyword.production_kind.g_keyword_62:
					// traverse syntax tree node associated with production
					// keyword: OPTIONAL

						TraverseCommon (p_keyword.m_OPTIONAL);
				break;
				case keyword.production_kind.g_keyword_63:
					// traverse syntax tree node associated with production
					// keyword: PATTERN

						TraverseCommon (p_keyword.m_PATTERN);
				break;
				case keyword.production_kind.g_keyword_64:
					// traverse syntax tree node associated with production
					// keyword: PDV

						TraverseCommon (p_keyword.m_PDV);
				break;
				case keyword.production_kind.g_keyword_65:
					// traverse syntax tree node associated with production
					// keyword: PLUS-INFINITY

						TraverseCommon (p_keyword.m_PLUS_INFINITY);
				break;
				case keyword.production_kind.g_keyword_66:
					// traverse syntax tree node associated with production
					// keyword: PRESENT

						TraverseCommon (p_keyword.m_PRESENT);
				break;
				case keyword.production_kind.g_keyword_67:
					// traverse syntax tree node associated with production
					// keyword: PrintableString

						TraverseCommon (p_keyword.m_PrintableString);
				break;
				case keyword.production_kind.g_keyword_68:
					// traverse syntax tree node associated with production
					// keyword: PRIVATE

						TraverseCommon (p_keyword.m_PRIVATE);
				break;
				case keyword.production_kind.g_keyword_69:
					// traverse syntax tree node associated with production
					// keyword: REAL

						TraverseCommon (p_keyword.m_REAL);
				break;
				case keyword.production_kind.g_keyword_70:
					// traverse syntax tree node associated with production
					// keyword: RELATIVE-OID

						TraverseCommon (p_keyword.m_RELATIVE_OID);
				break;
				case keyword.production_kind.g_keyword_71:
					// traverse syntax tree node associated with production
					// keyword: RELATIVE-OID-IRI

						TraverseCommon (p_keyword.m_RELATIVE_OID_IRI);
				break;
				case keyword.production_kind.g_keyword_72:
					// traverse syntax tree node associated with production
					// keyword: SEQUENCE

						TraverseCommon (p_keyword.m_SEQUENCE);
				break;
				case keyword.production_kind.g_keyword_73:
					// traverse syntax tree node associated with production
					// keyword: SET

						TraverseCommon (p_keyword.m_SET);
				break;
				case keyword.production_kind.g_keyword_74:
					// traverse syntax tree node associated with production
					// keyword: SETTINGS

						TraverseCommon (p_keyword.m_SETTINGS);
				break;
				case keyword.production_kind.g_keyword_75:
					// traverse syntax tree node associated with production
					// keyword: SIZE

						TraverseCommon (p_keyword.m_SIZE);
				break;
				case keyword.production_kind.g_keyword_76:
					// traverse syntax tree node associated with production
					// keyword: STRING

						TraverseCommon (p_keyword.m_STRING);
				break;
				case keyword.production_kind.g_keyword_77:
					// traverse syntax tree node associated with production
					// keyword: SYNTAX

						TraverseCommon (p_keyword.m_SYNTAX);
				break;
				case keyword.production_kind.g_keyword_78:
					// traverse syntax tree node associated with production
					// keyword: T61String

						TraverseCommon (p_keyword.m_T61String);
				break;
				case keyword.production_kind.g_keyword_79:
					// traverse syntax tree node associated with production
					// keyword: TAGS

						TraverseCommon (p_keyword.m_TAGS);
				break;
				case keyword.production_kind.g_keyword_80:
					// traverse syntax tree node associated with production
					// keyword: TeletexString

						TraverseCommon (p_keyword.m_TeletexString);
				break;
				case keyword.production_kind.g_keyword_81:
					// traverse syntax tree node associated with production
					// keyword: TIME

						TraverseCommon (p_keyword.m_TIME);
				break;
				case keyword.production_kind.g_keyword_82:
					// traverse syntax tree node associated with production
					// keyword: TIME-OF-DAY

						TraverseCommon (p_keyword.m_TIME_OF_DAY);
				break;
				case keyword.production_kind.g_keyword_83:
					// traverse syntax tree node associated with production
					// keyword: TRUE

						TraverseCommon (p_keyword.m_TRUE);
				break;
				case keyword.production_kind.g_keyword_84:
					// traverse syntax tree node associated with production
					// keyword: TYPE-IDENTIFIER

						TraverseCommon (p_keyword.m_TYPE_IDENTIFIER);
				break;
				case keyword.production_kind.g_keyword_85:
					// traverse syntax tree node associated with production
					// keyword: UNION

						TraverseCommon (p_keyword.m_UNION);
				break;
				case keyword.production_kind.g_keyword_86:
					// traverse syntax tree node associated with production
					// keyword: UNIQUE

						TraverseCommon (p_keyword.m_UNIQUE);
				break;
				case keyword.production_kind.g_keyword_87:
					// traverse syntax tree node associated with production
					// keyword: UNIVERSAL

						TraverseCommon (p_keyword.m_UNIVERSAL);
				break;
				case keyword.production_kind.g_keyword_88:
					// traverse syntax tree node associated with production
					// keyword: UniversalString

						TraverseCommon (p_keyword.m_UniversalString);
				break;
				case keyword.production_kind.g_keyword_89:
					// traverse syntax tree node associated with production
					// keyword: UTCTime

						TraverseCommon (p_keyword.m_UTCTime);
				break;
				case keyword.production_kind.g_keyword_90:
					// traverse syntax tree node associated with production
					// keyword: UTF8String

						TraverseCommon (p_keyword.m_UTF8String);
				break;
				case keyword.production_kind.g_keyword_91:
					// traverse syntax tree node associated with production
					// keyword: VideotexString

						TraverseCommon (p_keyword.m_VideotexString);
				break;
				case keyword.production_kind.g_keyword_92:
					// traverse syntax tree node associated with production
					// keyword: VisibleString

						TraverseCommon (p_keyword.m_VisibleString);
				break;
				case keyword.production_kind.g_keyword_93:
					// traverse syntax tree node associated with production
					// keyword: WITH

						TraverseCommon (p_keyword.m_WITH);
				break;
				case keyword.production_kind.g_keyword_94:
					// traverse syntax tree node associated with production
					// keyword: ANY

						TraverseCommon (p_keyword.m_ANY);
				break;
				case keyword.production_kind.g_keyword_95:
					// traverse syntax tree node associated with production
					// keyword: DEFINED

						TraverseCommon (p_keyword.m_DEFINED);
				break;
				case keyword.production_kind.g_keyword_96:
					// traverse syntax tree node associated with production
					// keyword: MACRO

						TraverseCommon (p_keyword.m_MACRO);
				break;
				case keyword.production_kind.g_keyword_97:
					// traverse syntax tree node associated with production
					// keyword: MACRO-BODY

						TraverseCommon (p_keyword.m_MACRO_BODY);
				break;
				case keyword.production_kind.g_keyword_98:
					// traverse syntax tree node associated with production
					// keyword: MODULE-IDENTITY

						TraverseCommon (p_keyword.m_MODULE_IDENTITY);
				break;
				case keyword.production_kind.g_keyword_99:
					// traverse syntax tree node associated with production
					// keyword: OBJECT-IDENTITY

						TraverseCommon (p_keyword.m_OBJECT_IDENTITY);
				break;
				case keyword.production_kind.g_keyword_100:
					// traverse syntax tree node associated with production
					// keyword: OBJECT-TYPE

						TraverseCommon (p_keyword.m_OBJECT_TYPE);
				break;
				case keyword.production_kind.g_keyword_101:
					// traverse syntax tree node associated with production
					// keyword: NOTIFICATION-TYPE

						TraverseCommon (p_keyword.m_NOTIFICATION_TYPE);
				break;
				case keyword.production_kind.g_keyword_102:
					// traverse syntax tree node associated with production
					// keyword: TEXTUAL-CONVENTION

						TraverseCommon (p_keyword.m_TEXTUAL_CONVENTION);
				break;
				case keyword.production_kind.g_keyword_103:
					// traverse syntax tree node associated with production
					// keyword: OBJECT-GROUP

						TraverseCommon (p_keyword.m_OBJECT_GROUP);
				break;
				case keyword.production_kind.g_keyword_104:
					// traverse syntax tree node associated with production
					// keyword: NOTIFICATION-GROUP

						TraverseCommon (p_keyword.m_NOTIFICATION_GROUP);
				break;
				case keyword.production_kind.g_keyword_105:
					// traverse syntax tree node associated with production
					// keyword: MODULE-COMPLIANCE

						TraverseCommon (p_keyword.m_MODULE_COMPLIANCE);
				break;
				case keyword.production_kind.g_keyword_106:
					// traverse syntax tree node associated with production
					// keyword: AGENT-CAPABILITIES

						TraverseCommon (p_keyword.m_AGENT_CAPABILITIES);
				break;
				case keyword.production_kind.g_keyword_107:
					// traverse syntax tree node associated with production
					// keyword: TRAP-TYPE

						TraverseCommon (p_keyword.m_TRAP_TYPE);
				break;
				case keyword.production_kind.g_keyword_108:
					// traverse syntax tree node associated with production
					// keyword: LAST-UPDATED

						TraverseCommon (p_keyword.m_LAST_UPDATED);
				break;
				case keyword.production_kind.g_keyword_109:
					// traverse syntax tree node associated with production
					// keyword: ORGANIZATION

						TraverseCommon (p_keyword.m_ORGANIZATION);
				break;
				case keyword.production_kind.g_keyword_110:
					// traverse syntax tree node associated with production
					// keyword: CONTACT-INFO

						TraverseCommon (p_keyword.m_CONTACT_INFO);
				break;
				case keyword.production_kind.g_keyword_111:
					// traverse syntax tree node associated with production
					// keyword: DESCRIPTION

						TraverseCommon (p_keyword.m_DESCRIPTION);
				break;
				case keyword.production_kind.g_keyword_112:
					// traverse syntax tree node associated with production
					// keyword: REVISION

						TraverseCommon (p_keyword.m_REVISION);
				break;
				case keyword.production_kind.g_keyword_113:
					// traverse syntax tree node associated with production
					// keyword: STATUS

						TraverseCommon (p_keyword.m_STATUS);
				break;
				case keyword.production_kind.g_keyword_114:
					// traverse syntax tree node associated with production
					// keyword: REFERENCE

						TraverseCommon (p_keyword.m_REFERENCE);
				break;
				case keyword.production_kind.g_keyword_115:
					// traverse syntax tree node associated with production
					// keyword: MAX-ACCESS

						TraverseCommon (p_keyword.m_MAX_ACCESS);
				break;
				case keyword.production_kind.g_keyword_116:
					// traverse syntax tree node associated with production
					// keyword: BITS

						TraverseCommon (p_keyword.m_BITS);
				break;
				case keyword.production_kind.g_keyword_117:
					// traverse syntax tree node associated with production
					// keyword: UNITS

						TraverseCommon (p_keyword.m_UNITS);
				break;
				case keyword.production_kind.g_keyword_118:
					// traverse syntax tree node associated with production
					// keyword: INDEX

						TraverseCommon (p_keyword.m_INDEX);
				break;
				case keyword.production_kind.g_keyword_119:
					// traverse syntax tree node associated with production
					// keyword: AUGMENTS

						TraverseCommon (p_keyword.m_AUGMENTS);
				break;
				case keyword.production_kind.g_keyword_120:
					// traverse syntax tree node associated with production
					// keyword: DEFVAL

						TraverseCommon (p_keyword.m_DEFVAL);
				break;
				case keyword.production_kind.g_keyword_121:
					// traverse syntax tree node associated with production
					// keyword: OBJECTS

						TraverseCommon (p_keyword.m_OBJECTS);
				break;
				case keyword.production_kind.g_keyword_122:
					// traverse syntax tree node associated with production
					// keyword: DISPLAY-HINT

						TraverseCommon (p_keyword.m_DISPLAY_HINT);
				break;
				case keyword.production_kind.g_keyword_123:
					// traverse syntax tree node associated with production
					// keyword: NOTIFICATIONS

						TraverseCommon (p_keyword.m_NOTIFICATIONS);
				break;
				case keyword.production_kind.g_keyword_124:
					// traverse syntax tree node associated with production
					// keyword: MODULE

						TraverseCommon (p_keyword.m_MODULE);
				break;
				case keyword.production_kind.g_keyword_125:
					// traverse syntax tree node associated with production
					// keyword: MANDATORY-GROUPS

						TraverseCommon (p_keyword.m_MANDATORY_GROUPS);
				break;
				case keyword.production_kind.g_keyword_126:
					// traverse syntax tree node associated with production
					// keyword: GROUP

						TraverseCommon (p_keyword.m_GROUP);
				break;
				case keyword.production_kind.g_keyword_127:
					// traverse syntax tree node associated with production
					// keyword: WRITE-SYNTAX

						TraverseCommon (p_keyword.m_WRITE_SYNTAX);
				break;
				case keyword.production_kind.g_keyword_128:
					// traverse syntax tree node associated with production
					// keyword: MIN-ACCESS

						TraverseCommon (p_keyword.m_MIN_ACCESS);
				break;
				case keyword.production_kind.g_keyword_129:
					// traverse syntax tree node associated with production
					// keyword: PRODUCT-RELEASE

						TraverseCommon (p_keyword.m_PRODUCT_RELEASE);
				break;
				case keyword.production_kind.g_keyword_130:
					// traverse syntax tree node associated with production
					// keyword: SUPPORTS

						TraverseCommon (p_keyword.m_SUPPORTS);
				break;
				case keyword.production_kind.g_keyword_131:
					// traverse syntax tree node associated with production
					// keyword: VARIATION

						TraverseCommon (p_keyword.m_VARIATION);
				break;
				case keyword.production_kind.g_keyword_132:
					// traverse syntax tree node associated with production
					// keyword: ACCESS

						TraverseCommon (p_keyword.m_ACCESS);
				break;
				case keyword.production_kind.g_keyword_133:
					// traverse syntax tree node associated with production
					// keyword: CREATION-REQUIRES

						TraverseCommon (p_keyword.m_CREATION_REQUIRES);
				break;
				case keyword.production_kind.g_keyword_134:
					// traverse syntax tree node associated with production
					// keyword: ENTERPRISE

						TraverseCommon (p_keyword.m_ENTERPRISE);
				break;
				case keyword.production_kind.g_keyword_135:
					// traverse syntax tree node associated with production
					// keyword: VARIABLES

						TraverseCommon (p_keyword.m_VARIABLES);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_keyword);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule keyword

		//
		// create syntax tree node associated with production
		// keyword: DESCENDANTS

		//

		public keyword keyword_1 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 1);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_1, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: SUCCESSORS

		//

		public keyword keyword_2 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 2);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_2, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: ABSENT

		//

		public keyword keyword_3 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 3);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_3, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: ABSTRACT-SYNTAX

		//

		public keyword keyword_4 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 4);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_4, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: ALL

		//

		public keyword keyword_5 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 5);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_5, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: APPLICATION

		//

		public keyword keyword_6 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 6);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_6, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: AUTOMATIC

		//

		public keyword keyword_7 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 7);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_7, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: BEGIN

		//

		public keyword keyword_8 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 8);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_8, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: BIT

		//

		public keyword keyword_9 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 9);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_9, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: BMPString

		//

		public keyword keyword_10 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 10);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_10, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: BOOLEAN

		//

		public keyword keyword_11 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 11);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_11, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: BY

		//

		public keyword keyword_12 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 12);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_12, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: CHARACTER

		//

		public keyword keyword_13 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 13);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_13, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: CHOICE

		//

		public keyword keyword_14 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 14);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_14, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: CLASS

		//

		public keyword keyword_15 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 15);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_15, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: COMPONENT

		//

		public keyword keyword_16 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 16);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_16, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: COMPONENTS

		//

		public keyword keyword_17 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 17);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_17, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: CONSTRAINED

		//

		public keyword keyword_18 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 18);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_18, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: CONTAINING

		//

		public keyword keyword_19 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 19);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_19, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: DATE

		//

		public keyword keyword_20 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 20);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_20, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: DATE-TIME

		//

		public keyword keyword_21 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 21);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_21, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: DEFAULT

		//

		public keyword keyword_22 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 22);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_22, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: DEFINITIONS

		//

		public keyword keyword_23 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 23);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_23, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: DURATION

		//

		public keyword keyword_24 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 24);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_24, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: EMBEDDED

		//

		public keyword keyword_25 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 25);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_25, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: ENCODED

		//

		public keyword keyword_26 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 26);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_26, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: ENCODING-CONTROL

		//

		public keyword keyword_27 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 27);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_27, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: END

		//

		public keyword keyword_28 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 28);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_28, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: ENUMERATED

		//

		public keyword keyword_29 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 29);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_29, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: EXCEPT

		//

		public keyword keyword_30 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 30);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_30, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: EXPLICIT

		//

		public keyword keyword_31 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 31);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_31, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: EXPORTS

		//

		public keyword keyword_32 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 32);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_32, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: EXTENSIBILITY

		//

		public keyword keyword_33 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 33);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_33, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: EXTERNAL

		//

		public keyword keyword_34 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 34);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_34, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: FALSE

		//

		public keyword keyword_35 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 35);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_35, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: FROM

		//

		public keyword keyword_36 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 36);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_36, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: GeneralizedTime

		//

		public keyword keyword_37 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 37);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_37, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: GeneralString

		//

		public keyword keyword_38 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 38);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_38, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: GraphicString

		//

		public keyword keyword_39 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 39);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_39, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: IA5String

		//

		public keyword keyword_40 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 40);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_40, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: IDENTIFIER

		//

		public keyword keyword_41 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 41);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_41, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: IMPLICIT

		//

		public keyword keyword_42 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 42);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_42, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: IMPLIED

		//

		public keyword keyword_43 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 43);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_43, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: IMPORTS

		//

		public keyword keyword_44 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 44);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_44, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: INCLUDES

		//

		public keyword keyword_45 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 45);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_45, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: INSTANCE

		//

		public keyword keyword_46 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 46);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_46, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: INSTRUCTIONS

		//

		public keyword keyword_47 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 47);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_47, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: INTEGER

		//

		public keyword keyword_48 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 48);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_48, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: INTERSECTION

		//

		public keyword keyword_49 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 49);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_49, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: ISO646String

		//

		public keyword keyword_50 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 50);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_50, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: MAX

		//

		public keyword keyword_51 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 51);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_51, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: MIN

		//

		public keyword keyword_52 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 52);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_52, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: MINUS-INFINITY

		//

		public keyword keyword_53 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 53);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_53, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: NOT-A-NUMBER

		//

		public keyword keyword_54 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 54);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_54, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: NULL

		//

		public keyword keyword_55 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 55);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_55, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: NumericString

		//

		public keyword keyword_56 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 56);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_56, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: OBJECT

		//

		public keyword keyword_57 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 57);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_57, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: ObjectDescriptor

		//

		public keyword keyword_58 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 58);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_58, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: OCTET

		//

		public keyword keyword_59 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 59);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_59, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: OF

		//

		public keyword keyword_60 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 60);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_60, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: OID-IRI

		//

		public keyword keyword_61 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 61);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_61, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: OPTIONAL

		//

		public keyword keyword_62 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 62);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_62, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: PATTERN

		//

		public keyword keyword_63 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 63);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_63, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: PDV

		//

		public keyword keyword_64 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 64);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_64, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: PLUS-INFINITY

		//

		public keyword keyword_65 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 65);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_65, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: PRESENT

		//

		public keyword keyword_66 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 66);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_66, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: PrintableString

		//

		public keyword keyword_67 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 67);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_67, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: PRIVATE

		//

		public keyword keyword_68 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 68);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_68, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: REAL

		//

		public keyword keyword_69 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 69);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_69, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: RELATIVE-OID

		//

		public keyword keyword_70 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 70);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_70, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: RELATIVE-OID-IRI

		//

		public keyword keyword_71 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 71);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_71, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: SEQUENCE

		//

		public keyword keyword_72 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 72);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_72, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: SET

		//

		public keyword keyword_73 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 73);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_73, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: SETTINGS

		//

		public keyword keyword_74 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 74);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_74, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: SIZE

		//

		public keyword keyword_75 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 75);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_75, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: STRING

		//

		public keyword keyword_76 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 76);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_76, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: SYNTAX

		//

		public keyword keyword_77 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 77);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_77, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: T61String

		//

		public keyword keyword_78 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 78);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_78, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: TAGS

		//

		public keyword keyword_79 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 79);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_79, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: TeletexString

		//

		public keyword keyword_80 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 80);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_80, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: TIME

		//

		public keyword keyword_81 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 81);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_81, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: TIME-OF-DAY

		//

		public keyword keyword_82 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 82);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_82, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: TRUE

		//

		public keyword keyword_83 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 83);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_83, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: TYPE-IDENTIFIER

		//

		public keyword keyword_84 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 84);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_84, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: UNION

		//

		public keyword keyword_85 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 85);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_85, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: UNIQUE

		//

		public keyword keyword_86 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 86);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_86, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: UNIVERSAL

		//

		public keyword keyword_87 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 87);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_87, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: UniversalString

		//

		public keyword keyword_88 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 88);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_88, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: UTCTime

		//

		public keyword keyword_89 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 89);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_89, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: UTF8String

		//

		public keyword keyword_90 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 90);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_90, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: VideotexString

		//

		public keyword keyword_91 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 91);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_91, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: VisibleString

		//

		public keyword keyword_92 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 92);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_92, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: WITH

		//

		public keyword keyword_93 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 93);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_93, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: ANY

		//

		public keyword keyword_94 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 94);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_94, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: DEFINED

		//

		public keyword keyword_95 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 95);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_95, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: MACRO

		//

		public keyword keyword_96 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 96);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_96, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: MACRO-BODY

		//

		public keyword keyword_97 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 97);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_97, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: MODULE-IDENTITY

		//

		public keyword keyword_98 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 98);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_98, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: OBJECT-IDENTITY

		//

		public keyword keyword_99 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 99);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_99, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: OBJECT-TYPE

		//

		public keyword keyword_100 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 100);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_100, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: NOTIFICATION-TYPE

		//

		public keyword keyword_101 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 101);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_101, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: TEXTUAL-CONVENTION

		//

		public keyword keyword_102 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 102);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_102, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: OBJECT-GROUP

		//

		public keyword keyword_103 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 103);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_103, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: NOTIFICATION-GROUP

		//

		public keyword keyword_104 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 104);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_104, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: MODULE-COMPLIANCE

		//

		public keyword keyword_105 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 105);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_105, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: AGENT-CAPABILITIES

		//

		public keyword keyword_106 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 106);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_106, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: TRAP-TYPE

		//

		public keyword keyword_107 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 107);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_107, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: LAST-UPDATED

		//

		public keyword keyword_108 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 108);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_108, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: ORGANIZATION

		//

		public keyword keyword_109 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 109);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_109, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: CONTACT-INFO

		//

		public keyword keyword_110 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 110);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_110, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: DESCRIPTION

		//

		public keyword keyword_111 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 111);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_111, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: REVISION

		//

		public keyword keyword_112 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 112);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_112, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: STATUS

		//

		public keyword keyword_113 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 113);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_113, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: REFERENCE

		//

		public keyword keyword_114 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 114);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_114, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: MAX-ACCESS

		//

		public keyword keyword_115 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 115);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_115, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: BITS

		//

		public keyword keyword_116 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 116);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_116, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: UNITS

		//

		public keyword keyword_117 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 117);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_117, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: INDEX

		//

		public keyword keyword_118 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 118);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_118, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: AUGMENTS

		//

		public keyword keyword_119 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 119);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_119, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: DEFVAL

		//

		public keyword keyword_120 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 120);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_120, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: OBJECTS

		//

		public keyword keyword_121 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 121);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_121, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: DISPLAY-HINT

		//

		public keyword keyword_122 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 122);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_122, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: NOTIFICATIONS

		//

		public keyword keyword_123 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 123);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_123, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: MODULE

		//

		public keyword keyword_124 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 124);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_124, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: MANDATORY-GROUPS

		//

		public keyword keyword_125 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 125);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_125, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: GROUP

		//

		public keyword keyword_126 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 126);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_126, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: WRITE-SYNTAX

		//

		public keyword keyword_127 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 127);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_127, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: MIN-ACCESS

		//

		public keyword keyword_128 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 128);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_128, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: PRODUCT-RELEASE

		//

		public keyword keyword_129 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 129);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_129, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: SUPPORTS

		//

		public keyword keyword_130 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 130);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_130, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: VARIATION

		//

		public keyword keyword_131 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 131);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_131, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: ACCESS

		//

		public keyword keyword_132 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 132);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_132, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: CREATION-REQUIRES

		//

		public keyword keyword_133 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 133);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_133, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: ENTERPRISE

		//

		public keyword keyword_134 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 134);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_134, p_keyword_ref);
			return p_keyword_ref;
		}

		//
		// create syntax tree node associated with production
		// keyword: VARIABLES

		//

		public keyword keyword_135 (SyntaxTreeToken p_token)
		{
			keyword p_keyword_ref = new keyword(p_token, 135);
			p_token.parent = p_keyword_ref;
			Raise_keyword_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, keyword.production_kind.g_keyword_135, p_keyword_ref);
			return p_keyword_ref;
		}
		#endregion
	};
}
