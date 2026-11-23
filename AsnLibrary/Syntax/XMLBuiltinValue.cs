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
	// class associated with syntax rule XMLBuiltinValue
	//

	[DataContract]
	public class	XMLBuiltinValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLBuiltinValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLBuiltinValue
		{
			g_XMLBuiltinValue_1 = 1,	// XMLBitStringValue

			g_XMLBuiltinValue_2 = 2,	// XMLBooleanValue

			g_XMLBuiltinValue_3 = 3,	// XMLCharacterStringValue

			g_XMLBuiltinValue_4 = 4,	// XMLChoiceValue

			g_XMLBuiltinValue_5 = 5,	// XMLEmbeddedPDVValue

			g_XMLBuiltinValue_6 = 6,	// XMLEnumeratedValue

			g_XMLBuiltinValue_7 = 7,	// XMLExternalValue

			g_XMLBuiltinValue_8 = 8,	// XMLInstanceOfValue

			g_XMLBuiltinValue_9 = 9,	// XMLIntegerValue

			g_XMLBuiltinValue_10 = 10,	// XMLIRIValue

			g_XMLBuiltinValue_11 = 11,	// XMLNullValue

			g_XMLBuiltinValue_12 = 12,	// XMLObjectIdentifierValue

			g_XMLBuiltinValue_13 = 13,	// XMLOctetStringValue

			g_XMLBuiltinValue_14 = 14,	// XMLRealValue

			g_XMLBuiltinValue_15 = 15,	// XMLRelativeIRIValue

			g_XMLBuiltinValue_16 = 16,	// XMLRelativeOIDValue

			g_XMLBuiltinValue_17 = 17,	// XMLSequenceValue

			g_XMLBuiltinValue_18 = 18,	// XMLSequenceOfValue

			g_XMLBuiltinValue_19 = 19,	// XMLSetValue

			g_XMLBuiltinValue_20 = 20,	// XMLSetOfValue

			g_XMLBuiltinValue_21 = 21,	// XMLPrefixedValue

			g_XMLBuiltinValue_22 = 22,	// XMLTimeValue

		};
		#endregion
		#region production markers associated with the syntax rule XMLBuiltinValue

		// markers associated with production: XMLBuiltinValue -> XMLBitStringValue

		public enum production_marker_1 : ushort
		{
			m_XMLBitStringValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLBooleanValue

		public enum production_marker_2 : ushort
		{
			m_XMLBooleanValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLCharacterStringValue

		public enum production_marker_3 : ushort
		{
			m_XMLCharacterStringValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLChoiceValue

		public enum production_marker_4 : ushort
		{
			m_XMLChoiceValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLEmbeddedPDVValue

		public enum production_marker_5 : ushort
		{
			m_XMLEmbeddedPDVValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLEnumeratedValue

		public enum production_marker_6 : ushort
		{
			m_XMLEnumeratedValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLExternalValue

		public enum production_marker_7 : ushort
		{
			m_XMLExternalValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLInstanceOfValue

		public enum production_marker_8 : ushort
		{
			m_XMLInstanceOfValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLIntegerValue

		public enum production_marker_9 : ushort
		{
			m_XMLIntegerValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLIRIValue

		public enum production_marker_10 : ushort
		{
			m_XMLIRIValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLNullValue

		public enum production_marker_11 : ushort
		{
			m_XMLNullValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLObjectIdentifierValue

		public enum production_marker_12 : ushort
		{
			m_XMLObjectIdentifierValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLOctetStringValue

		public enum production_marker_13 : ushort
		{
			m_XMLOctetStringValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLRealValue

		public enum production_marker_14 : ushort
		{
			m_XMLRealValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLRelativeIRIValue

		public enum production_marker_15 : ushort
		{
			m_XMLRelativeIRIValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLRelativeOIDValue

		public enum production_marker_16 : ushort
		{
			m_XMLRelativeOIDValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLSequenceValue

		public enum production_marker_17 : ushort
		{
			m_XMLSequenceValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLSequenceOfValue

		public enum production_marker_18 : ushort
		{
			m_XMLSequenceOfValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLSetValue

		public enum production_marker_19 : ushort
		{
			m_XMLSetValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLSetOfValue

		public enum production_marker_20 : ushort
		{
			m_XMLSetOfValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLPrefixedValue

		public enum production_marker_21 : ushort
		{
			m_XMLPrefixedValue,
			final
		};

		// markers associated with production: XMLBuiltinValue -> XMLTimeValue

		public enum production_marker_22 : ushort
		{
			m_XMLTimeValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLBuiltinValue

		// Constructor declaration(s) associated with production(s) of syntax rule XMLBuiltinValue

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLBitStringValue

		//

		public XMLBuiltinValue (XMLBitStringValue p_XMLBitStringValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLBitStringValue = p_XMLBitStringValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLBooleanValue

		//

		public XMLBuiltinValue (XMLBooleanValue p_XMLBooleanValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLBooleanValue = p_XMLBooleanValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLCharacterStringValue

		//

		public XMLBuiltinValue (XMLCharacterStringValue p_XMLCharacterStringValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLCharacterStringValue = p_XMLCharacterStringValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLChoiceValue

		//

		public XMLBuiltinValue (XMLChoiceValue p_XMLChoiceValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLChoiceValue = p_XMLChoiceValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLEmbeddedPDVValue

		//

		public XMLBuiltinValue (XMLEmbeddedPDVValue p_XMLEmbeddedPDVValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_5)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLEmbeddedPDVValue = p_XMLEmbeddedPDVValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLEnumeratedValue

		//

		public XMLBuiltinValue (XMLEnumeratedValue p_XMLEnumeratedValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_6)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLEnumeratedValue = p_XMLEnumeratedValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLExternalValue

		//

		public XMLBuiltinValue (XMLExternalValue p_XMLExternalValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_7)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLExternalValue = p_XMLExternalValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLInstanceOfValue

		//

		public XMLBuiltinValue (XMLInstanceOfValue p_XMLInstanceOfValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_8)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLInstanceOfValue = p_XMLInstanceOfValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLIntegerValue

		//

		public XMLBuiltinValue (XMLIntegerValue p_XMLIntegerValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_9)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLIntegerValue = p_XMLIntegerValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLIRIValue

		//

		public XMLBuiltinValue (XMLIRIValue p_XMLIRIValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_10)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLIRIValue = p_XMLIRIValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLNullValue

		//

		public XMLBuiltinValue (XMLNullValue p_XMLNullValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_11)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLNullValue = p_XMLNullValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLObjectIdentifierValue

		//

		public XMLBuiltinValue (XMLObjectIdentifierValue p_XMLObjectIdentifierValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_12)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLObjectIdentifierValue = p_XMLObjectIdentifierValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLOctetStringValue

		//

		public XMLBuiltinValue (XMLOctetStringValue p_XMLOctetStringValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_13)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLOctetStringValue = p_XMLOctetStringValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLRealValue

		//

		public XMLBuiltinValue (XMLRealValue p_XMLRealValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_14)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLRealValue = p_XMLRealValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLRelativeIRIValue

		//

		public XMLBuiltinValue (XMLRelativeIRIValue p_XMLRelativeIRIValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_15)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLRelativeIRIValue = p_XMLRelativeIRIValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLRelativeOIDValue

		//

		public XMLBuiltinValue (XMLRelativeOIDValue p_XMLRelativeOIDValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_16)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLRelativeOIDValue = p_XMLRelativeOIDValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLSequenceValue

		//

		public XMLBuiltinValue (XMLSequenceValue p_XMLSequenceValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_17)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLSequenceValue = p_XMLSequenceValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLSequenceOfValue

		//

		public XMLBuiltinValue (XMLSequenceOfValue p_XMLSequenceOfValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_18)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLSequenceOfValue = p_XMLSequenceOfValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLSetValue

		//

		public XMLBuiltinValue (XMLSetValue p_XMLSetValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_19)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLSetValue = p_XMLSetValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLSetOfValue

		//

		public XMLBuiltinValue (XMLSetOfValue p_XMLSetOfValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_20)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLSetOfValue = p_XMLSetOfValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLPrefixedValue

		//

		public XMLBuiltinValue (XMLPrefixedValue p_XMLPrefixedValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_21)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLPrefixedValue = p_XMLPrefixedValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLBuiltinValue -> XMLTimeValue

		//

		public XMLBuiltinValue (XMLTimeValue p_XMLTimeValue) : base ((uint) ProductionID._XMLBuiltinValue_ID, (uint) production_kind.g_XMLBuiltinValue_22)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLTimeValue = p_XMLTimeValue;
		}

		public XMLBuiltinValue () { }

		// Copy constructor

		public XMLBuiltinValue (XMLBuiltinValue p_XMLBuiltinValue) : base (p_XMLBuiltinValue.id, p_XMLBuiltinValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLBuiltinValue.appInfo;
			switch ((production_kind) p_XMLBuiltinValue.kind)
			{
				case production_kind.g_XMLBuiltinValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLBitStringValue = (p_XMLBuiltinValue.m_XMLBitStringValue != null) ? new XMLBitStringValue (p_XMLBuiltinValue.m_XMLBitStringValue) : null) != null) m_XMLBitStringValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLBooleanValue = (p_XMLBuiltinValue.m_XMLBooleanValue != null) ? new XMLBooleanValue (p_XMLBuiltinValue.m_XMLBooleanValue) : null) != null) m_XMLBooleanValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLCharacterStringValue = (p_XMLBuiltinValue.m_XMLCharacterStringValue != null) ? new XMLCharacterStringValue (p_XMLBuiltinValue.m_XMLCharacterStringValue) : null) != null) m_XMLCharacterStringValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLChoiceValue = (p_XMLBuiltinValue.m_XMLChoiceValue != null) ? new XMLChoiceValue (p_XMLBuiltinValue.m_XMLChoiceValue) : null) != null) m_XMLChoiceValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLEmbeddedPDVValue = (p_XMLBuiltinValue.m_XMLEmbeddedPDVValue != null) ? new XMLEmbeddedPDVValue (p_XMLBuiltinValue.m_XMLEmbeddedPDVValue) : null) != null) m_XMLEmbeddedPDVValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_6:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLEnumeratedValue = (p_XMLBuiltinValue.m_XMLEnumeratedValue != null) ? new XMLEnumeratedValue (p_XMLBuiltinValue.m_XMLEnumeratedValue) : null) != null) m_XMLEnumeratedValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_7:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLExternalValue = (p_XMLBuiltinValue.m_XMLExternalValue != null) ? new XMLExternalValue (p_XMLBuiltinValue.m_XMLExternalValue) : null) != null) m_XMLExternalValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_8:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLInstanceOfValue = (p_XMLBuiltinValue.m_XMLInstanceOfValue != null) ? new XMLInstanceOfValue (p_XMLBuiltinValue.m_XMLInstanceOfValue) : null) != null) m_XMLInstanceOfValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_9:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLIntegerValue = (p_XMLBuiltinValue.m_XMLIntegerValue != null) ? new XMLIntegerValue (p_XMLBuiltinValue.m_XMLIntegerValue) : null) != null) m_XMLIntegerValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_10:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLIRIValue = (p_XMLBuiltinValue.m_XMLIRIValue != null) ? new XMLIRIValue (p_XMLBuiltinValue.m_XMLIRIValue) : null) != null) m_XMLIRIValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_11:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLNullValue = (p_XMLBuiltinValue.m_XMLNullValue != null) ? new XMLNullValue (p_XMLBuiltinValue.m_XMLNullValue) : null) != null) m_XMLNullValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_12:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLObjectIdentifierValue = (p_XMLBuiltinValue.m_XMLObjectIdentifierValue != null) ? new XMLObjectIdentifierValue (p_XMLBuiltinValue.m_XMLObjectIdentifierValue) : null) != null) m_XMLObjectIdentifierValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_13:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLOctetStringValue = (p_XMLBuiltinValue.m_XMLOctetStringValue != null) ? new XMLOctetStringValue (p_XMLBuiltinValue.m_XMLOctetStringValue) : null) != null) m_XMLOctetStringValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_14:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLRealValue = (p_XMLBuiltinValue.m_XMLRealValue != null) ? new XMLRealValue (p_XMLBuiltinValue.m_XMLRealValue) : null) != null) m_XMLRealValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_15:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLRelativeIRIValue = (p_XMLBuiltinValue.m_XMLRelativeIRIValue != null) ? new XMLRelativeIRIValue (p_XMLBuiltinValue.m_XMLRelativeIRIValue) : null) != null) m_XMLRelativeIRIValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_16:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLRelativeOIDValue = (p_XMLBuiltinValue.m_XMLRelativeOIDValue != null) ? new XMLRelativeOIDValue (p_XMLBuiltinValue.m_XMLRelativeOIDValue) : null) != null) m_XMLRelativeOIDValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_17:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLSequenceValue = (p_XMLBuiltinValue.m_XMLSequenceValue != null) ? new XMLSequenceValue (p_XMLBuiltinValue.m_XMLSequenceValue) : null) != null) m_XMLSequenceValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_18:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLSequenceOfValue = (p_XMLBuiltinValue.m_XMLSequenceOfValue != null) ? new XMLSequenceOfValue (p_XMLBuiltinValue.m_XMLSequenceOfValue) : null) != null) m_XMLSequenceOfValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_19:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLSetValue = (p_XMLBuiltinValue.m_XMLSetValue != null) ? new XMLSetValue (p_XMLBuiltinValue.m_XMLSetValue) : null) != null) m_XMLSetValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_20:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLSetOfValue = (p_XMLBuiltinValue.m_XMLSetOfValue != null) ? new XMLSetOfValue (p_XMLBuiltinValue.m_XMLSetOfValue) : null) != null) m_XMLSetOfValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_21:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLPrefixedValue = (p_XMLBuiltinValue.m_XMLPrefixedValue != null) ? new XMLPrefixedValue (p_XMLBuiltinValue.m_XMLPrefixedValue) : null) != null) m_XMLPrefixedValue.parent = this;
					break;
				case production_kind.g_XMLBuiltinValue_22:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLTimeValue = (p_XMLBuiltinValue.m_XMLTimeValue != null) ? new XMLTimeValue (p_XMLBuiltinValue.m_XMLTimeValue) : null) != null) m_XMLTimeValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLBuiltinValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLBuiltinValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_XMLBitStringValue?.Dispose ();
			m_XMLBooleanValue?.Dispose ();
			m_XMLCharacterStringValue?.Dispose ();
			m_XMLChoiceValue?.Dispose ();
			m_XMLEmbeddedPDVValue?.Dispose ();
			m_XMLEnumeratedValue?.Dispose ();
			m_XMLExternalValue?.Dispose ();
			m_XMLInstanceOfValue?.Dispose ();
			m_XMLIntegerValue?.Dispose ();
			m_XMLIRIValue?.Dispose ();
			m_XMLNullValue?.Dispose ();
			m_XMLObjectIdentifierValue?.Dispose ();
			m_XMLOctetStringValue?.Dispose ();
			m_XMLRealValue?.Dispose ();
			m_XMLRelativeIRIValue?.Dispose ();
			m_XMLRelativeOIDValue?.Dispose ();
			m_XMLSequenceValue?.Dispose ();
			m_XMLSequenceOfValue?.Dispose ();
			m_XMLSetValue?.Dispose ();
			m_XMLSetOfValue?.Dispose ();
			m_XMLPrefixedValue?.Dispose ();
			m_XMLTimeValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLBuiltinValue

		// Content changing function(s) associated with production(s) of syntax rule XMLBuiltinValue

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLBitStringValue

		//

		public void change(XMLBitStringValue p_XMLBitStringValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLBitStringValue = p_XMLBitStringValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLBooleanValue

		//

		public void change(XMLBooleanValue p_XMLBooleanValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLBooleanValue = p_XMLBooleanValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLCharacterStringValue

		//

		public void change(XMLCharacterStringValue p_XMLCharacterStringValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLCharacterStringValue = p_XMLCharacterStringValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLChoiceValue

		//

		public void change(XMLChoiceValue p_XMLChoiceValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLChoiceValue = p_XMLChoiceValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLEmbeddedPDVValue

		//

		public void change(XMLEmbeddedPDVValue p_XMLEmbeddedPDVValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_5;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLEmbeddedPDVValue = p_XMLEmbeddedPDVValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLEnumeratedValue

		//

		public void change(XMLEnumeratedValue p_XMLEnumeratedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_6;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLEnumeratedValue = p_XMLEnumeratedValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLExternalValue

		//

		public void change(XMLExternalValue p_XMLExternalValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_7;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLExternalValue = p_XMLExternalValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLInstanceOfValue

		//

		public void change(XMLInstanceOfValue p_XMLInstanceOfValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_8;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLInstanceOfValue = p_XMLInstanceOfValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLIntegerValue

		//

		public void change(XMLIntegerValue p_XMLIntegerValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_9;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLIntegerValue = p_XMLIntegerValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLIRIValue

		//

		public void change(XMLIRIValue p_XMLIRIValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_10;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLIRIValue = p_XMLIRIValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLNullValue

		//

		public void change(XMLNullValue p_XMLNullValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_11;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLNullValue = p_XMLNullValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLObjectIdentifierValue

		//

		public void change(XMLObjectIdentifierValue p_XMLObjectIdentifierValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_12;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLObjectIdentifierValue = p_XMLObjectIdentifierValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLOctetStringValue

		//

		public void change(XMLOctetStringValue p_XMLOctetStringValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_13;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLOctetStringValue = p_XMLOctetStringValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLRealValue

		//

		public void change(XMLRealValue p_XMLRealValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_14;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLRealValue = p_XMLRealValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLRelativeIRIValue

		//

		public void change(XMLRelativeIRIValue p_XMLRelativeIRIValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_15;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLRelativeIRIValue = p_XMLRelativeIRIValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLRelativeOIDValue

		//

		public void change(XMLRelativeOIDValue p_XMLRelativeOIDValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_16;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLRelativeOIDValue = p_XMLRelativeOIDValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLSequenceValue

		//

		public void change(XMLSequenceValue p_XMLSequenceValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_17;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLSequenceValue = p_XMLSequenceValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLSequenceOfValue

		//

		public void change(XMLSequenceOfValue p_XMLSequenceOfValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_18;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLSequenceOfValue = p_XMLSequenceOfValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLSetValue

		//

		public void change(XMLSetValue p_XMLSetValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_19;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLSetValue = p_XMLSetValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLSetOfValue

		//

		public void change(XMLSetOfValue p_XMLSetOfValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_20;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLSetOfValue = p_XMLSetOfValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLPrefixedValue

		//

		public void change(XMLPrefixedValue p_XMLPrefixedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_21;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLPrefixedValue = p_XMLPrefixedValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLBuiltinValue -> XMLTimeValue

		//

		public void change(XMLTimeValue p_XMLTimeValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLBuiltinValue_22;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLTimeValue = p_XMLTimeValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLBuiltinValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_XMLBitStringValue != null) && m_XMLBitStringValue.checkInclusion (element) ||
				(m_XMLBooleanValue != null) && m_XMLBooleanValue.checkInclusion (element) ||
				(m_XMLCharacterStringValue != null) && m_XMLCharacterStringValue.checkInclusion (element) ||
				(m_XMLChoiceValue != null) && m_XMLChoiceValue.checkInclusion (element) ||
				(m_XMLEmbeddedPDVValue != null) && m_XMLEmbeddedPDVValue.checkInclusion (element) ||
				(m_XMLEnumeratedValue != null) && m_XMLEnumeratedValue.checkInclusion (element) ||
				(m_XMLExternalValue != null) && m_XMLExternalValue.checkInclusion (element) ||
				(m_XMLInstanceOfValue != null) && m_XMLInstanceOfValue.checkInclusion (element) ||
				(m_XMLIntegerValue != null) && m_XMLIntegerValue.checkInclusion (element) ||
				(m_XMLIRIValue != null) && m_XMLIRIValue.checkInclusion (element) ||
				(m_XMLNullValue != null) && m_XMLNullValue.checkInclusion (element) ||
				(m_XMLObjectIdentifierValue != null) && m_XMLObjectIdentifierValue.checkInclusion (element) ||
				(m_XMLOctetStringValue != null) && m_XMLOctetStringValue.checkInclusion (element) ||
				(m_XMLRealValue != null) && m_XMLRealValue.checkInclusion (element) ||
				(m_XMLRelativeIRIValue != null) && m_XMLRelativeIRIValue.checkInclusion (element) ||
				(m_XMLRelativeOIDValue != null) && m_XMLRelativeOIDValue.checkInclusion (element) ||
				(m_XMLSequenceValue != null) && m_XMLSequenceValue.checkInclusion (element) ||
				(m_XMLSequenceOfValue != null) && m_XMLSequenceOfValue.checkInclusion (element) ||
				(m_XMLSetValue != null) && m_XMLSetValue.checkInclusion (element) ||
				(m_XMLSetOfValue != null) && m_XMLSetOfValue.checkInclusion (element) ||
				(m_XMLPrefixedValue != null) && m_XMLPrefixedValue.checkInclusion (element) ||
				(m_XMLTimeValue != null) && m_XMLTimeValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLBuiltinValue

		//
		// emit production tree node associated with any production of syntax rule XMLBuiltinValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLBuiltinValue_1:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLBitStringValue

					s += m_XMLBitStringValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_2:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLBooleanValue

					s += m_XMLBooleanValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_3:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLCharacterStringValue

					s += m_XMLCharacterStringValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_4:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLChoiceValue

					s += m_XMLChoiceValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_5:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLEmbeddedPDVValue

					s += m_XMLEmbeddedPDVValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_6:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLEnumeratedValue

					s += m_XMLEnumeratedValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_7:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLExternalValue

					s += m_XMLExternalValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_8:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLInstanceOfValue

					s += m_XMLInstanceOfValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_9:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLIntegerValue

					s += m_XMLIntegerValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_10:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLIRIValue

					s += m_XMLIRIValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_11:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLNullValue

					s += m_XMLNullValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_12:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLObjectIdentifierValue

					s += m_XMLObjectIdentifierValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_13:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLOctetStringValue

					s += m_XMLOctetStringValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_14:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLRealValue

					s += m_XMLRealValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_15:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLRelativeIRIValue

					s += m_XMLRelativeIRIValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_16:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLRelativeOIDValue

					s += m_XMLRelativeOIDValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_17:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLSequenceValue

					s += m_XMLSequenceValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_18:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLSequenceOfValue

					s += m_XMLSequenceOfValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_19:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLSetValue

					s += m_XMLSetValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_20:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLSetOfValue

					s += m_XMLSetOfValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_21:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLPrefixedValue

					s += m_XMLPrefixedValue.Emit (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_22:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLTimeValue

					s += m_XMLTimeValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLBuiltinValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLBuiltinValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLBuiltinValue_1:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLBitStringValue

					s += m_XMLBitStringValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_2:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLBooleanValue

					s += m_XMLBooleanValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_3:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLCharacterStringValue

					s += m_XMLCharacterStringValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_4:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLChoiceValue

					s += m_XMLChoiceValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_5:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLEmbeddedPDVValue

					s += m_XMLEmbeddedPDVValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_6:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLEnumeratedValue

					s += m_XMLEnumeratedValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_7:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLExternalValue

					s += m_XMLExternalValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_8:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLInstanceOfValue

					s += m_XMLInstanceOfValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_9:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLIntegerValue

					s += m_XMLIntegerValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_10:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLIRIValue

					s += m_XMLIRIValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_11:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLNullValue

					s += m_XMLNullValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_12:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLObjectIdentifierValue

					s += m_XMLObjectIdentifierValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_13:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLOctetStringValue

					s += m_XMLOctetStringValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_14:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLRealValue

					s += m_XMLRealValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_15:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLRelativeIRIValue

					s += m_XMLRelativeIRIValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_16:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLRelativeOIDValue

					s += m_XMLRelativeOIDValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_17:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLSequenceValue

					s += m_XMLSequenceValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_18:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLSequenceOfValue

					s += m_XMLSequenceOfValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_19:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLSetValue

					s += m_XMLSetValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_20:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLSetOfValue

					s += m_XMLSetOfValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_21:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLPrefixedValue

					s += m_XMLPrefixedValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_XMLBuiltinValue_22:
					// emit syntax tree node associated with production
					// XMLBuiltinValue: XMLTimeValue

					s += m_XMLTimeValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLBuiltinValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLBuiltinValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLBuiltinValue.production_kind kind = (XMLBuiltinValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_1:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLBitStringValue

						m_XMLBitStringValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_2:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLBooleanValue

						m_XMLBooleanValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_3:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLCharacterStringValue

						m_XMLCharacterStringValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_4:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLChoiceValue

						m_XMLChoiceValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_5:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLEmbeddedPDVValue

						m_XMLEmbeddedPDVValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_6:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLEnumeratedValue

						m_XMLEnumeratedValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_7:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLExternalValue

						m_XMLExternalValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_8:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLInstanceOfValue

						m_XMLInstanceOfValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_9:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLIntegerValue

						m_XMLIntegerValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_10:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLIRIValue

						m_XMLIRIValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_11:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLNullValue

						m_XMLNullValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_12:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLObjectIdentifierValue

						m_XMLObjectIdentifierValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_13:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLOctetStringValue

						m_XMLOctetStringValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_14:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLRealValue

						m_XMLRealValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_15:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLRelativeIRIValue

						m_XMLRelativeIRIValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_16:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLRelativeOIDValue

						m_XMLRelativeOIDValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_17:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLSequenceValue

						m_XMLSequenceValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_18:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLSequenceOfValue

						m_XMLSequenceOfValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_19:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLSetValue

						m_XMLSetValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_20:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLSetOfValue

						m_XMLSetOfValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_21:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLPrefixedValue

						m_XMLPrefixedValue.Visit (visitor, appData);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_22:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLTimeValue

						m_XMLTimeValue.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_XMLBitStringValue?.reparent (this);
			m_XMLBooleanValue?.reparent (this);
			m_XMLCharacterStringValue?.reparent (this);
			m_XMLChoiceValue?.reparent (this);
			m_XMLEmbeddedPDVValue?.reparent (this);
			m_XMLEnumeratedValue?.reparent (this);
			m_XMLExternalValue?.reparent (this);
			m_XMLInstanceOfValue?.reparent (this);
			m_XMLIntegerValue?.reparent (this);
			m_XMLIRIValue?.reparent (this);
			m_XMLNullValue?.reparent (this);
			m_XMLObjectIdentifierValue?.reparent (this);
			m_XMLOctetStringValue?.reparent (this);
			m_XMLRealValue?.reparent (this);
			m_XMLRelativeIRIValue?.reparent (this);
			m_XMLRelativeOIDValue?.reparent (this);
			m_XMLSequenceValue?.reparent (this);
			m_XMLSequenceOfValue?.reparent (this);
			m_XMLSetValue?.reparent (this);
			m_XMLSetOfValue?.reparent (this);
			m_XMLPrefixedValue?.reparent (this);
			m_XMLTimeValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLBuiltinValue
		//

		public void _init ()
		{
			m_XMLBitStringValue = null;
			m_XMLBooleanValue = null;
			m_XMLCharacterStringValue = null;
			m_XMLChoiceValue = null;
			m_XMLEmbeddedPDVValue = null;
			m_XMLEnumeratedValue = null;
			m_XMLExternalValue = null;
			m_XMLInstanceOfValue = null;
			m_XMLIntegerValue = null;
			m_XMLIRIValue = null;
			m_XMLNullValue = null;
			m_XMLObjectIdentifierValue = null;
			m_XMLOctetStringValue = null;
			m_XMLRealValue = null;
			m_XMLRelativeIRIValue = null;
			m_XMLRelativeOIDValue = null;
			m_XMLSequenceValue = null;
			m_XMLSequenceOfValue = null;
			m_XMLSetValue = null;
			m_XMLSetOfValue = null;
			m_XMLPrefixedValue = null;
			m_XMLTimeValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLBuiltinValue

		// counter of all nodes associated with syntax rule XMLBuiltinValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLBuiltinValue
		[DataMember (Name = "m_XMLBitStringValue")] public XMLBitStringValue m_XMLBitStringValue { get; private set; }
		[DataMember (Name = "m_XMLBooleanValue")] public XMLBooleanValue m_XMLBooleanValue { get; private set; }
		[DataMember (Name = "m_XMLCharacterStringValue")] public XMLCharacterStringValue m_XMLCharacterStringValue { get; private set; }
		[DataMember (Name = "m_XMLChoiceValue")] public XMLChoiceValue m_XMLChoiceValue { get; private set; }
		[DataMember (Name = "m_XMLEmbeddedPDVValue")] public XMLEmbeddedPDVValue m_XMLEmbeddedPDVValue { get; private set; }
		[DataMember (Name = "m_XMLEnumeratedValue")] public XMLEnumeratedValue m_XMLEnumeratedValue { get; private set; }
		[DataMember (Name = "m_XMLExternalValue")] public XMLExternalValue m_XMLExternalValue { get; private set; }
		[DataMember (Name = "m_XMLInstanceOfValue")] public XMLInstanceOfValue m_XMLInstanceOfValue { get; private set; }
		[DataMember (Name = "m_XMLIntegerValue")] public XMLIntegerValue m_XMLIntegerValue { get; private set; }
		[DataMember (Name = "m_XMLIRIValue")] public XMLIRIValue m_XMLIRIValue { get; private set; }
		[DataMember (Name = "m_XMLNullValue")] public XMLNullValue m_XMLNullValue { get; private set; }
		[DataMember (Name = "m_XMLObjectIdentifierValue")] public XMLObjectIdentifierValue m_XMLObjectIdentifierValue { get; private set; }
		[DataMember (Name = "m_XMLOctetStringValue")] public XMLOctetStringValue m_XMLOctetStringValue { get; private set; }
		[DataMember (Name = "m_XMLRealValue")] public XMLRealValue m_XMLRealValue { get; private set; }
		[DataMember (Name = "m_XMLRelativeIRIValue")] public XMLRelativeIRIValue m_XMLRelativeIRIValue { get; private set; }
		[DataMember (Name = "m_XMLRelativeOIDValue")] public XMLRelativeOIDValue m_XMLRelativeOIDValue { get; private set; }
		[DataMember (Name = "m_XMLSequenceValue")] public XMLSequenceValue m_XMLSequenceValue { get; private set; }
		[DataMember (Name = "m_XMLSequenceOfValue")] public XMLSequenceOfValue m_XMLSequenceOfValue { get; private set; }
		[DataMember (Name = "m_XMLSetValue")] public XMLSetValue m_XMLSetValue { get; private set; }
		[DataMember (Name = "m_XMLSetOfValue")] public XMLSetOfValue m_XMLSetOfValue { get; private set; }
		[DataMember (Name = "m_XMLPrefixedValue")] public XMLPrefixedValue m_XMLPrefixedValue { get; private set; }
		[DataMember (Name = "m_XMLTimeValue")] public XMLTimeValue m_XMLTimeValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLBuiltinValue

		// delegate function (callback) prototype associated with syntax rule XMLBuiltinValue
		public delegate bool XMLBuiltinValue_Callback (SyntaxTreeCallbackReason reason, XMLBuiltinValue.production_kind kind, XMLBuiltinValue p_XMLBuiltinValue);

		// event associated with syntax rule XMLBuiltinValue
		public event XMLBuiltinValue_Callback XMLBuiltinValue_Event;

		// event trigger associated with syntax rule XMLBuiltinValue
		public bool Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason reason, XMLBuiltinValue.production_kind kind, XMLBuiltinValue p_XMLBuiltinValue)
		{
			bool? status = XMLBuiltinValue_Event?.Invoke (reason, kind, p_XMLBuiltinValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLBuiltinValue
		//
		// traverse syntax tree node associated with any production of syntax rule XMLBuiltinValue
		//

		public void Traverse (XMLBuiltinValue p_XMLBuiltinValue)
		{
			if (p_XMLBuiltinValue.isLocked())
				return;
			p_XMLBuiltinValue.dolock();
			XMLBuiltinValue.production_kind kind = (XMLBuiltinValue.production_kind) p_XMLBuiltinValue.kind;
			p_XMLBuiltinValue.turn_reset ();
			if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLBuiltinValue))
			switch (kind)
			{
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_1:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLBitStringValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLBitStringValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_2:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLBooleanValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLBooleanValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_3:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLCharacterStringValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLCharacterStringValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_4:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLChoiceValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLChoiceValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_5:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLEmbeddedPDVValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLEmbeddedPDVValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_6:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLEnumeratedValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLEnumeratedValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_7:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLExternalValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLExternalValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_8:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLInstanceOfValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLInstanceOfValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_9:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLIntegerValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLIntegerValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_10:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLIRIValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLIRIValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_11:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLNullValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLNullValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_12:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLObjectIdentifierValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLObjectIdentifierValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_13:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLOctetStringValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLOctetStringValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_14:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLRealValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLRealValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_15:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLRelativeIRIValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLRelativeIRIValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_16:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLRelativeOIDValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLRelativeOIDValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_17:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLSequenceValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLSequenceValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_18:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLSequenceOfValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLSequenceOfValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_19:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLSetValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLSetValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_20:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLSetOfValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLSetOfValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_21:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLPrefixedValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLPrefixedValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_22:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLTimeValue

					if (Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue))
						Traverse (p_XMLBuiltinValue.m_XMLTimeValue);
					p_XMLBuiltinValue.turn_inc ();
					Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLBuiltinValue);
				break;
			}
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLBuiltinValue);
			p_XMLBuiltinValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLBuiltinValue
		//

		public void TraverseCommon (XMLBuiltinValue p_XMLBuiltinValue)
		{
			XMLBuiltinValue.production_kind kind = (XMLBuiltinValue.production_kind) p_XMLBuiltinValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLBuiltinValue))
			switch (kind)
			{
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_1:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLBitStringValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLBitStringValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_2:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLBooleanValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLBooleanValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_3:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLCharacterStringValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLCharacterStringValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_4:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLChoiceValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLChoiceValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_5:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLEmbeddedPDVValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLEmbeddedPDVValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_6:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLEnumeratedValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLEnumeratedValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_7:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLExternalValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLExternalValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_8:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLInstanceOfValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLInstanceOfValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_9:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLIntegerValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLIntegerValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_10:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLIRIValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLIRIValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_11:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLNullValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLNullValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_12:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLObjectIdentifierValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLObjectIdentifierValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_13:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLOctetStringValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLOctetStringValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_14:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLRealValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLRealValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_15:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLRelativeIRIValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLRelativeIRIValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_16:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLRelativeOIDValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLRelativeOIDValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_17:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLSequenceValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLSequenceValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_18:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLSequenceOfValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLSequenceOfValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_19:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLSetValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLSetValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_20:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLSetOfValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLSetOfValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_21:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLPrefixedValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLPrefixedValue);
				break;
				case XMLBuiltinValue.production_kind.g_XMLBuiltinValue_22:
					// traverse syntax tree node associated with production
					// XMLBuiltinValue: XMLTimeValue

						TraverseCommon (p_XMLBuiltinValue.m_XMLTimeValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLBuiltinValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLBuiltinValue

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLBitStringValue

		//

		public XMLBuiltinValue XMLBuiltinValue_1 (XMLBitStringValue p_XMLBitStringValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLBitStringValue);
			p_XMLBitStringValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_1, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLBooleanValue

		//

		public XMLBuiltinValue XMLBuiltinValue_2 (XMLBooleanValue p_XMLBooleanValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLBooleanValue);
			p_XMLBooleanValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_2, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLCharacterStringValue

		//

		public XMLBuiltinValue XMLBuiltinValue_3 (XMLCharacterStringValue p_XMLCharacterStringValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLCharacterStringValue);
			p_XMLCharacterStringValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_3, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLChoiceValue

		//

		public XMLBuiltinValue XMLBuiltinValue_4 (XMLChoiceValue p_XMLChoiceValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLChoiceValue);
			p_XMLChoiceValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_4, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLEmbeddedPDVValue

		//

		public XMLBuiltinValue XMLBuiltinValue_5 (XMLEmbeddedPDVValue p_XMLEmbeddedPDVValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLEmbeddedPDVValue);
			p_XMLEmbeddedPDVValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_5, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLEnumeratedValue

		//

		public XMLBuiltinValue XMLBuiltinValue_6 (XMLEnumeratedValue p_XMLEnumeratedValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLEnumeratedValue);
			p_XMLEnumeratedValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_6, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLExternalValue

		//

		public XMLBuiltinValue XMLBuiltinValue_7 (XMLExternalValue p_XMLExternalValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLExternalValue);
			p_XMLExternalValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_7, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLInstanceOfValue

		//

		public XMLBuiltinValue XMLBuiltinValue_8 (XMLInstanceOfValue p_XMLInstanceOfValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLInstanceOfValue);
			p_XMLInstanceOfValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_8, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLIntegerValue

		//

		public XMLBuiltinValue XMLBuiltinValue_9 (XMLIntegerValue p_XMLIntegerValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLIntegerValue);
			p_XMLIntegerValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_9, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLIRIValue

		//

		public XMLBuiltinValue XMLBuiltinValue_10 (XMLIRIValue p_XMLIRIValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLIRIValue);
			p_XMLIRIValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_10, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLNullValue

		//

		public XMLBuiltinValue XMLBuiltinValue_11 (XMLNullValue p_XMLNullValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLNullValue);
			p_XMLNullValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_11, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLObjectIdentifierValue

		//

		public XMLBuiltinValue XMLBuiltinValue_12 (XMLObjectIdentifierValue p_XMLObjectIdentifierValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLObjectIdentifierValue);
			p_XMLObjectIdentifierValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_12, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLOctetStringValue

		//

		public XMLBuiltinValue XMLBuiltinValue_13 (XMLOctetStringValue p_XMLOctetStringValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLOctetStringValue);
			p_XMLOctetStringValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_13, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLRealValue

		//

		public XMLBuiltinValue XMLBuiltinValue_14 (XMLRealValue p_XMLRealValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLRealValue);
			p_XMLRealValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_14, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLRelativeIRIValue

		//

		public XMLBuiltinValue XMLBuiltinValue_15 (XMLRelativeIRIValue p_XMLRelativeIRIValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLRelativeIRIValue);
			p_XMLRelativeIRIValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_15, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLRelativeOIDValue

		//

		public XMLBuiltinValue XMLBuiltinValue_16 (XMLRelativeOIDValue p_XMLRelativeOIDValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLRelativeOIDValue);
			p_XMLRelativeOIDValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_16, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLSequenceValue

		//

		public XMLBuiltinValue XMLBuiltinValue_17 (XMLSequenceValue p_XMLSequenceValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLSequenceValue);
			p_XMLSequenceValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_17, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLSequenceOfValue

		//

		public XMLBuiltinValue XMLBuiltinValue_18 (XMLSequenceOfValue p_XMLSequenceOfValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLSequenceOfValue);
			p_XMLSequenceOfValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_18, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLSetValue

		//

		public XMLBuiltinValue XMLBuiltinValue_19 (XMLSetValue p_XMLSetValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLSetValue);
			p_XMLSetValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_19, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLSetOfValue

		//

		public XMLBuiltinValue XMLBuiltinValue_20 (XMLSetOfValue p_XMLSetOfValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLSetOfValue);
			p_XMLSetOfValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_20, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLPrefixedValue

		//

		public XMLBuiltinValue XMLBuiltinValue_21 (XMLPrefixedValue p_XMLPrefixedValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLPrefixedValue);
			p_XMLPrefixedValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_21, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLBuiltinValue: XMLTimeValue

		//

		public XMLBuiltinValue XMLBuiltinValue_22 (XMLTimeValue p_XMLTimeValue)
		{
			XMLBuiltinValue p_XMLBuiltinValue_ref = new XMLBuiltinValue(p_XMLTimeValue);
			p_XMLTimeValue.parent = p_XMLBuiltinValue_ref;
			Raise_XMLBuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLBuiltinValue.production_kind.g_XMLBuiltinValue_22, p_XMLBuiltinValue_ref);
			return p_XMLBuiltinValue_ref;
		}
		#endregion
	};
}
