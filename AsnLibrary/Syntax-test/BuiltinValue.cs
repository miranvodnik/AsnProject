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
	// class associated with syntax rule BuiltinValue
	//

	[DataContract]
	public class	BuiltinValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule BuiltinValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule BuiltinValue
		{
			g_BuiltinValue_1 = 1,	// BitStringValue

			g_BuiltinValue_2 = 2,	// BooleanValue

			g_BuiltinValue_3 = 3,	// CharacterStringValue

			g_BuiltinValue_4 = 4,	// ChoiceValue

			g_BuiltinValue_5 = 5,	// EmbeddedPDVValue

			g_BuiltinValue_6 = 6,	// EnumeratedValue

			g_BuiltinValue_7 = 7,	// ExternalValue

			g_BuiltinValue_8 = 8,	// IntegerValue

			g_BuiltinValue_9 = 9,	// IRIValue

			g_BuiltinValue_10 = 10,	// NullValue

			g_BuiltinValue_11 = 11,	// ObjectIdentifierValue

			g_BuiltinValue_12 = 12,	// OctetStringValue

			g_BuiltinValue_13 = 13,	// RealValue

			g_BuiltinValue_14 = 14,	// RelativeIRIValue

			g_BuiltinValue_15 = 15,	// RelativeOIDValue

			g_BuiltinValue_16 = 16,	// SequenceValue

			g_BuiltinValue_17 = 17,	// SequenceOfValue

			g_BuiltinValue_18 = 18,	// SetValue

			g_BuiltinValue_19 = 19,	// SetOfValue

			g_BuiltinValue_20 = 20,	// TimeValue

		};
		#endregion
		#region production markers associated with the syntax rule BuiltinValue

		// markers associated with production: BuiltinValue -> BitStringValue

		public enum production_marker_1 : ushort
		{
			m_BitStringValue,
			final
		};

		// markers associated with production: BuiltinValue -> BooleanValue

		public enum production_marker_2 : ushort
		{
			m_BooleanValue,
			final
		};

		// markers associated with production: BuiltinValue -> CharacterStringValue

		public enum production_marker_3 : ushort
		{
			m_CharacterStringValue,
			final
		};

		// markers associated with production: BuiltinValue -> ChoiceValue

		public enum production_marker_4 : ushort
		{
			m_ChoiceValue,
			final
		};

		// markers associated with production: BuiltinValue -> EmbeddedPDVValue

		public enum production_marker_5 : ushort
		{
			m_EmbeddedPDVValue,
			final
		};

		// markers associated with production: BuiltinValue -> EnumeratedValue

		public enum production_marker_6 : ushort
		{
			m_EnumeratedValue,
			final
		};

		// markers associated with production: BuiltinValue -> ExternalValue

		public enum production_marker_7 : ushort
		{
			m_ExternalValue,
			final
		};

		// markers associated with production: BuiltinValue -> IntegerValue

		public enum production_marker_8 : ushort
		{
			m_IntegerValue,
			final
		};

		// markers associated with production: BuiltinValue -> IRIValue

		public enum production_marker_9 : ushort
		{
			m_IRIValue,
			final
		};

		// markers associated with production: BuiltinValue -> NullValue

		public enum production_marker_10 : ushort
		{
			m_NullValue,
			final
		};

		// markers associated with production: BuiltinValue -> ObjectIdentifierValue

		public enum production_marker_11 : ushort
		{
			m_ObjectIdentifierValue,
			final
		};

		// markers associated with production: BuiltinValue -> OctetStringValue

		public enum production_marker_12 : ushort
		{
			m_OctetStringValue,
			final
		};

		// markers associated with production: BuiltinValue -> RealValue

		public enum production_marker_13 : ushort
		{
			m_RealValue,
			final
		};

		// markers associated with production: BuiltinValue -> RelativeIRIValue

		public enum production_marker_14 : ushort
		{
			m_RelativeIRIValue,
			final
		};

		// markers associated with production: BuiltinValue -> RelativeOIDValue

		public enum production_marker_15 : ushort
		{
			m_RelativeOIDValue,
			final
		};

		// markers associated with production: BuiltinValue -> SequenceValue

		public enum production_marker_16 : ushort
		{
			m_SequenceValue,
			final
		};

		// markers associated with production: BuiltinValue -> SequenceOfValue

		public enum production_marker_17 : ushort
		{
			m_SequenceOfValue,
			final
		};

		// markers associated with production: BuiltinValue -> SetValue

		public enum production_marker_18 : ushort
		{
			m_SetValue,
			final
		};

		// markers associated with production: BuiltinValue -> SetOfValue

		public enum production_marker_19 : ushort
		{
			m_SetOfValue,
			final
		};

		// markers associated with production: BuiltinValue -> TimeValue

		public enum production_marker_20 : ushort
		{
			m_TimeValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule BuiltinValue

		// Constructor declaration(s) associated with production(s) of syntax rule BuiltinValue

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> BitStringValue

		//

		public BuiltinValue (BitStringValue p_BitStringValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_BitStringValue = p_BitStringValue;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> BooleanValue

		//

		public BuiltinValue (BooleanValue p_BooleanValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_BooleanValue = p_BooleanValue;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> CharacterStringValue

		//

		public BuiltinValue (CharacterStringValue p_CharacterStringValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_CharacterStringValue = p_CharacterStringValue;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> ChoiceValue

		//

		public BuiltinValue (ChoiceValue p_ChoiceValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ChoiceValue = p_ChoiceValue;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> EmbeddedPDVValue

		//

		public BuiltinValue (EmbeddedPDVValue p_EmbeddedPDVValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_5)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_EmbeddedPDVValue = p_EmbeddedPDVValue;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> EnumeratedValue

		//

		public BuiltinValue (EnumeratedValue p_EnumeratedValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_6)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_EnumeratedValue = p_EnumeratedValue;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> ExternalValue

		//

		public BuiltinValue (ExternalValue p_ExternalValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_7)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ExternalValue = p_ExternalValue;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> IntegerValue

		//

		public BuiltinValue (IntegerValue p_IntegerValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_8)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_IntegerValue = p_IntegerValue;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> IRIValue

		//

		public BuiltinValue (IRIValue p_IRIValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_9)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_IRIValue = p_IRIValue;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> NullValue

		//

		public BuiltinValue (NullValue p_NullValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_10)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NullValue = p_NullValue;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> ObjectIdentifierValue

		//

		public BuiltinValue (ObjectIdentifierValue p_ObjectIdentifierValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_11)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> OctetStringValue

		//

		public BuiltinValue (OctetStringValue p_OctetStringValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_12)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_OctetStringValue = p_OctetStringValue;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> RealValue

		//

		public BuiltinValue (RealValue p_RealValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_13)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_RealValue = p_RealValue;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> RelativeIRIValue

		//

		public BuiltinValue (RelativeIRIValue p_RelativeIRIValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_14)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_RelativeIRIValue = p_RelativeIRIValue;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> RelativeOIDValue

		//

		public BuiltinValue (RelativeOIDValue p_RelativeOIDValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_15)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_RelativeOIDValue = p_RelativeOIDValue;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> SequenceValue

		//

		public BuiltinValue (SequenceValue p_SequenceValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_16)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SequenceValue = p_SequenceValue;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> SequenceOfValue

		//

		public BuiltinValue (SequenceOfValue p_SequenceOfValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_17)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SequenceOfValue = p_SequenceOfValue;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> SetValue

		//

		public BuiltinValue (SetValue p_SetValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_18)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SetValue = p_SetValue;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> SetOfValue

		//

		public BuiltinValue (SetOfValue p_SetOfValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_19)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SetOfValue = p_SetOfValue;
		}

		//
		// Constructor associated with the following production(s)
		// BuiltinValue -> TimeValue

		//

		public BuiltinValue (TimeValue p_TimeValue) : base ((uint) ProductionID._BuiltinValue_ID, (uint) production_kind.g_BuiltinValue_20)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TimeValue = p_TimeValue;
		}

		public BuiltinValue () { }

		// Copy constructor

		public BuiltinValue (BuiltinValue p_BuiltinValue) : base (p_BuiltinValue.id, p_BuiltinValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_BuiltinValue.appInfo;
			switch ((production_kind) p_BuiltinValue.kind)
			{
				case production_kind.g_BuiltinValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_BitStringValue = (p_BuiltinValue.m_BitStringValue != null) ? new BitStringValue (p_BuiltinValue.m_BitStringValue) : null) != null) m_BitStringValue.parent = this;
					break;
				case production_kind.g_BuiltinValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_BooleanValue = (p_BuiltinValue.m_BooleanValue != null) ? new BooleanValue (p_BuiltinValue.m_BooleanValue) : null) != null) m_BooleanValue.parent = this;
					break;
				case production_kind.g_BuiltinValue_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_CharacterStringValue = (p_BuiltinValue.m_CharacterStringValue != null) ? new CharacterStringValue (p_BuiltinValue.m_CharacterStringValue) : null) != null) m_CharacterStringValue.parent = this;
					break;
				case production_kind.g_BuiltinValue_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ChoiceValue = (p_BuiltinValue.m_ChoiceValue != null) ? new ChoiceValue (p_BuiltinValue.m_ChoiceValue) : null) != null) m_ChoiceValue.parent = this;
					break;
				case production_kind.g_BuiltinValue_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EmbeddedPDVValue = (p_BuiltinValue.m_EmbeddedPDVValue != null) ? new EmbeddedPDVValue (p_BuiltinValue.m_EmbeddedPDVValue) : null) != null) m_EmbeddedPDVValue.parent = this;
					break;
				case production_kind.g_BuiltinValue_6:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EnumeratedValue = (p_BuiltinValue.m_EnumeratedValue != null) ? new EnumeratedValue (p_BuiltinValue.m_EnumeratedValue) : null) != null) m_EnumeratedValue.parent = this;
					break;
				case production_kind.g_BuiltinValue_7:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ExternalValue = (p_BuiltinValue.m_ExternalValue != null) ? new ExternalValue (p_BuiltinValue.m_ExternalValue) : null) != null) m_ExternalValue.parent = this;
					break;
				case production_kind.g_BuiltinValue_8:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_IntegerValue = (p_BuiltinValue.m_IntegerValue != null) ? new IntegerValue (p_BuiltinValue.m_IntegerValue) : null) != null) m_IntegerValue.parent = this;
					break;
				case production_kind.g_BuiltinValue_9:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_IRIValue = (p_BuiltinValue.m_IRIValue != null) ? new IRIValue (p_BuiltinValue.m_IRIValue) : null) != null) m_IRIValue.parent = this;
					break;
				case production_kind.g_BuiltinValue_10:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NullValue = (p_BuiltinValue.m_NullValue != null) ? new NullValue (p_BuiltinValue.m_NullValue) : null) != null) m_NullValue.parent = this;
					break;
				case production_kind.g_BuiltinValue_11:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectIdentifierValue = (p_BuiltinValue.m_ObjectIdentifierValue != null) ? new ObjectIdentifierValue (p_BuiltinValue.m_ObjectIdentifierValue) : null) != null) m_ObjectIdentifierValue.parent = this;
					break;
				case production_kind.g_BuiltinValue_12:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OctetStringValue = (p_BuiltinValue.m_OctetStringValue != null) ? new OctetStringValue (p_BuiltinValue.m_OctetStringValue) : null) != null) m_OctetStringValue.parent = this;
					break;
				case production_kind.g_BuiltinValue_13:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RealValue = (p_BuiltinValue.m_RealValue != null) ? new RealValue (p_BuiltinValue.m_RealValue) : null) != null) m_RealValue.parent = this;
					break;
				case production_kind.g_BuiltinValue_14:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RelativeIRIValue = (p_BuiltinValue.m_RelativeIRIValue != null) ? new RelativeIRIValue (p_BuiltinValue.m_RelativeIRIValue) : null) != null) m_RelativeIRIValue.parent = this;
					break;
				case production_kind.g_BuiltinValue_15:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RelativeOIDValue = (p_BuiltinValue.m_RelativeOIDValue != null) ? new RelativeOIDValue (p_BuiltinValue.m_RelativeOIDValue) : null) != null) m_RelativeOIDValue.parent = this;
					break;
				case production_kind.g_BuiltinValue_16:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SequenceValue = (p_BuiltinValue.m_SequenceValue != null) ? new SequenceValue (p_BuiltinValue.m_SequenceValue) : null) != null) m_SequenceValue.parent = this;
					break;
				case production_kind.g_BuiltinValue_17:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SequenceOfValue = (p_BuiltinValue.m_SequenceOfValue != null) ? new SequenceOfValue (p_BuiltinValue.m_SequenceOfValue) : null) != null) m_SequenceOfValue.parent = this;
					break;
				case production_kind.g_BuiltinValue_18:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SetValue = (p_BuiltinValue.m_SetValue != null) ? new SetValue (p_BuiltinValue.m_SetValue) : null) != null) m_SetValue.parent = this;
					break;
				case production_kind.g_BuiltinValue_19:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SetOfValue = (p_BuiltinValue.m_SetOfValue != null) ? new SetOfValue (p_BuiltinValue.m_SetOfValue) : null) != null) m_SetOfValue.parent = this;
					break;
				case production_kind.g_BuiltinValue_20:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TimeValue = (p_BuiltinValue.m_TimeValue != null) ? new TimeValue (p_BuiltinValue.m_TimeValue) : null) != null) m_TimeValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "BuiltinValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new BuiltinValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_BitStringValue?.Dispose ();
			m_BooleanValue?.Dispose ();
			m_CharacterStringValue?.Dispose ();
			m_ChoiceValue?.Dispose ();
			m_EmbeddedPDVValue?.Dispose ();
			m_EnumeratedValue?.Dispose ();
			m_ExternalValue?.Dispose ();
			m_IntegerValue?.Dispose ();
			m_IRIValue?.Dispose ();
			m_NullValue?.Dispose ();
			m_ObjectIdentifierValue?.Dispose ();
			m_OctetStringValue?.Dispose ();
			m_RealValue?.Dispose ();
			m_RelativeIRIValue?.Dispose ();
			m_RelativeOIDValue?.Dispose ();
			m_SequenceValue?.Dispose ();
			m_SequenceOfValue?.Dispose ();
			m_SetValue?.Dispose ();
			m_SetOfValue?.Dispose ();
			m_TimeValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule BuiltinValue

		// Content changing function(s) associated with production(s) of syntax rule BuiltinValue

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> BitStringValue

		//

		public void change(BitStringValue p_BitStringValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_BitStringValue = p_BitStringValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> BooleanValue

		//

		public void change(BooleanValue p_BooleanValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_BooleanValue = p_BooleanValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> CharacterStringValue

		//

		public void change(CharacterStringValue p_CharacterStringValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_CharacterStringValue = p_CharacterStringValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> ChoiceValue

		//

		public void change(ChoiceValue p_ChoiceValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ChoiceValue = p_ChoiceValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> EmbeddedPDVValue

		//

		public void change(EmbeddedPDVValue p_EmbeddedPDVValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_5;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_EmbeddedPDVValue = p_EmbeddedPDVValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> EnumeratedValue

		//

		public void change(EnumeratedValue p_EnumeratedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_6;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_EnumeratedValue = p_EnumeratedValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> ExternalValue

		//

		public void change(ExternalValue p_ExternalValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_7;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ExternalValue = p_ExternalValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> IntegerValue

		//

		public void change(IntegerValue p_IntegerValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_8;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_IntegerValue = p_IntegerValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> IRIValue

		//

		public void change(IRIValue p_IRIValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_9;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_IRIValue = p_IRIValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> NullValue

		//

		public void change(NullValue p_NullValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_10;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NullValue = p_NullValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> ObjectIdentifierValue

		//

		public void change(ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_11;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> OctetStringValue

		//

		public void change(OctetStringValue p_OctetStringValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_12;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_OctetStringValue = p_OctetStringValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> RealValue

		//

		public void change(RealValue p_RealValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_13;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_RealValue = p_RealValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> RelativeIRIValue

		//

		public void change(RelativeIRIValue p_RelativeIRIValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_14;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_RelativeIRIValue = p_RelativeIRIValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> RelativeOIDValue

		//

		public void change(RelativeOIDValue p_RelativeOIDValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_15;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_RelativeOIDValue = p_RelativeOIDValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> SequenceValue

		//

		public void change(SequenceValue p_SequenceValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_16;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SequenceValue = p_SequenceValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> SequenceOfValue

		//

		public void change(SequenceOfValue p_SequenceOfValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_17;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SequenceOfValue = p_SequenceOfValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> SetValue

		//

		public void change(SetValue p_SetValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_18;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SetValue = p_SetValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> SetOfValue

		//

		public void change(SetOfValue p_SetOfValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_19;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SetOfValue = p_SetOfValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BuiltinValue -> TimeValue

		//

		public void change(TimeValue p_TimeValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_BuiltinValue_20;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TimeValue = p_TimeValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule BuiltinValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_BitStringValue != null) && m_BitStringValue.checkInclusion (element) ||
				(m_BooleanValue != null) && m_BooleanValue.checkInclusion (element) ||
				(m_CharacterStringValue != null) && m_CharacterStringValue.checkInclusion (element) ||
				(m_ChoiceValue != null) && m_ChoiceValue.checkInclusion (element) ||
				(m_EmbeddedPDVValue != null) && m_EmbeddedPDVValue.checkInclusion (element) ||
				(m_EnumeratedValue != null) && m_EnumeratedValue.checkInclusion (element) ||
				(m_ExternalValue != null) && m_ExternalValue.checkInclusion (element) ||
				(m_IntegerValue != null) && m_IntegerValue.checkInclusion (element) ||
				(m_IRIValue != null) && m_IRIValue.checkInclusion (element) ||
				(m_NullValue != null) && m_NullValue.checkInclusion (element) ||
				(m_ObjectIdentifierValue != null) && m_ObjectIdentifierValue.checkInclusion (element) ||
				(m_OctetStringValue != null) && m_OctetStringValue.checkInclusion (element) ||
				(m_RealValue != null) && m_RealValue.checkInclusion (element) ||
				(m_RelativeIRIValue != null) && m_RelativeIRIValue.checkInclusion (element) ||
				(m_RelativeOIDValue != null) && m_RelativeOIDValue.checkInclusion (element) ||
				(m_SequenceValue != null) && m_SequenceValue.checkInclusion (element) ||
				(m_SequenceOfValue != null) && m_SequenceOfValue.checkInclusion (element) ||
				(m_SetValue != null) && m_SetValue.checkInclusion (element) ||
				(m_SetOfValue != null) && m_SetOfValue.checkInclusion (element) ||
				(m_TimeValue != null) && m_TimeValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule BuiltinValue

		//
		// emit production tree node associated with any production of syntax rule BuiltinValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_BuiltinValue_1:
					// emit syntax tree node associated with production
					// BuiltinValue: BitStringValue

					s += m_BitStringValue.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinValue_2:
					// emit syntax tree node associated with production
					// BuiltinValue: BooleanValue

					s += m_BooleanValue.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinValue_3:
					// emit syntax tree node associated with production
					// BuiltinValue: CharacterStringValue

					s += m_CharacterStringValue.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinValue_4:
					// emit syntax tree node associated with production
					// BuiltinValue: ChoiceValue

					s += m_ChoiceValue.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinValue_5:
					// emit syntax tree node associated with production
					// BuiltinValue: EmbeddedPDVValue

					s += m_EmbeddedPDVValue.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinValue_6:
					// emit syntax tree node associated with production
					// BuiltinValue: EnumeratedValue

					s += m_EnumeratedValue.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinValue_7:
					// emit syntax tree node associated with production
					// BuiltinValue: ExternalValue

					s += m_ExternalValue.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinValue_8:
					// emit syntax tree node associated with production
					// BuiltinValue: IntegerValue

					s += m_IntegerValue.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinValue_9:
					// emit syntax tree node associated with production
					// BuiltinValue: IRIValue

					s += m_IRIValue.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinValue_10:
					// emit syntax tree node associated with production
					// BuiltinValue: NullValue

					s += m_NullValue.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinValue_11:
					// emit syntax tree node associated with production
					// BuiltinValue: ObjectIdentifierValue

					s += m_ObjectIdentifierValue.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinValue_12:
					// emit syntax tree node associated with production
					// BuiltinValue: OctetStringValue

					s += m_OctetStringValue.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinValue_13:
					// emit syntax tree node associated with production
					// BuiltinValue: RealValue

					s += m_RealValue.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinValue_14:
					// emit syntax tree node associated with production
					// BuiltinValue: RelativeIRIValue

					s += m_RelativeIRIValue.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinValue_15:
					// emit syntax tree node associated with production
					// BuiltinValue: RelativeOIDValue

					s += m_RelativeOIDValue.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinValue_16:
					// emit syntax tree node associated with production
					// BuiltinValue: SequenceValue

					s += m_SequenceValue.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinValue_17:
					// emit syntax tree node associated with production
					// BuiltinValue: SequenceOfValue

					s += m_SequenceOfValue.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinValue_18:
					// emit syntax tree node associated with production
					// BuiltinValue: SetValue

					s += m_SetValue.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinValue_19:
					// emit syntax tree node associated with production
					// BuiltinValue: SetOfValue

					s += m_SetOfValue.Emit (depth - 1);
				break;
				case production_kind.g_BuiltinValue_20:
					// emit syntax tree node associated with production
					// BuiltinValue: TimeValue

					s += m_TimeValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule BuiltinValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "BuiltinValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_BuiltinValue_1:
					// emit syntax tree node associated with production
					// BuiltinValue: BitStringValue

					s += m_BitStringValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinValue_2:
					// emit syntax tree node associated with production
					// BuiltinValue: BooleanValue

					s += m_BooleanValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinValue_3:
					// emit syntax tree node associated with production
					// BuiltinValue: CharacterStringValue

					s += m_CharacterStringValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinValue_4:
					// emit syntax tree node associated with production
					// BuiltinValue: ChoiceValue

					s += m_ChoiceValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinValue_5:
					// emit syntax tree node associated with production
					// BuiltinValue: EmbeddedPDVValue

					s += m_EmbeddedPDVValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinValue_6:
					// emit syntax tree node associated with production
					// BuiltinValue: EnumeratedValue

					s += m_EnumeratedValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinValue_7:
					// emit syntax tree node associated with production
					// BuiltinValue: ExternalValue

					s += m_ExternalValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinValue_8:
					// emit syntax tree node associated with production
					// BuiltinValue: IntegerValue

					s += m_IntegerValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinValue_9:
					// emit syntax tree node associated with production
					// BuiltinValue: IRIValue

					s += m_IRIValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinValue_10:
					// emit syntax tree node associated with production
					// BuiltinValue: NullValue

					s += m_NullValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinValue_11:
					// emit syntax tree node associated with production
					// BuiltinValue: ObjectIdentifierValue

					s += m_ObjectIdentifierValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinValue_12:
					// emit syntax tree node associated with production
					// BuiltinValue: OctetStringValue

					s += m_OctetStringValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinValue_13:
					// emit syntax tree node associated with production
					// BuiltinValue: RealValue

					s += m_RealValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinValue_14:
					// emit syntax tree node associated with production
					// BuiltinValue: RelativeIRIValue

					s += m_RelativeIRIValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinValue_15:
					// emit syntax tree node associated with production
					// BuiltinValue: RelativeOIDValue

					s += m_RelativeOIDValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinValue_16:
					// emit syntax tree node associated with production
					// BuiltinValue: SequenceValue

					s += m_SequenceValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinValue_17:
					// emit syntax tree node associated with production
					// BuiltinValue: SequenceOfValue

					s += m_SequenceOfValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinValue_18:
					// emit syntax tree node associated with production
					// BuiltinValue: SetValue

					s += m_SetValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinValue_19:
					// emit syntax tree node associated with production
					// BuiltinValue: SetOfValue

					s += m_SetOfValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_BuiltinValue_20:
					// emit syntax tree node associated with production
					// BuiltinValue: TimeValue

					s += m_TimeValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule BuiltinValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule BuiltinValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			BuiltinValue.production_kind kind = (BuiltinValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case BuiltinValue.production_kind.g_BuiltinValue_1:
					// traverse syntax tree node associated with production
					// BuiltinValue: BitStringValue

						m_BitStringValue.Visit (visitor, appData);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_2:
					// traverse syntax tree node associated with production
					// BuiltinValue: BooleanValue

						m_BooleanValue.Visit (visitor, appData);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_3:
					// traverse syntax tree node associated with production
					// BuiltinValue: CharacterStringValue

						m_CharacterStringValue.Visit (visitor, appData);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_4:
					// traverse syntax tree node associated with production
					// BuiltinValue: ChoiceValue

						m_ChoiceValue.Visit (visitor, appData);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_5:
					// traverse syntax tree node associated with production
					// BuiltinValue: EmbeddedPDVValue

						m_EmbeddedPDVValue.Visit (visitor, appData);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_6:
					// traverse syntax tree node associated with production
					// BuiltinValue: EnumeratedValue

						m_EnumeratedValue.Visit (visitor, appData);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_7:
					// traverse syntax tree node associated with production
					// BuiltinValue: ExternalValue

						m_ExternalValue.Visit (visitor, appData);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_8:
					// traverse syntax tree node associated with production
					// BuiltinValue: IntegerValue

						m_IntegerValue.Visit (visitor, appData);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_9:
					// traverse syntax tree node associated with production
					// BuiltinValue: IRIValue

						m_IRIValue.Visit (visitor, appData);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_10:
					// traverse syntax tree node associated with production
					// BuiltinValue: NullValue

						m_NullValue.Visit (visitor, appData);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_11:
					// traverse syntax tree node associated with production
					// BuiltinValue: ObjectIdentifierValue

						m_ObjectIdentifierValue.Visit (visitor, appData);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_12:
					// traverse syntax tree node associated with production
					// BuiltinValue: OctetStringValue

						m_OctetStringValue.Visit (visitor, appData);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_13:
					// traverse syntax tree node associated with production
					// BuiltinValue: RealValue

						m_RealValue.Visit (visitor, appData);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_14:
					// traverse syntax tree node associated with production
					// BuiltinValue: RelativeIRIValue

						m_RelativeIRIValue.Visit (visitor, appData);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_15:
					// traverse syntax tree node associated with production
					// BuiltinValue: RelativeOIDValue

						m_RelativeOIDValue.Visit (visitor, appData);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_16:
					// traverse syntax tree node associated with production
					// BuiltinValue: SequenceValue

						m_SequenceValue.Visit (visitor, appData);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_17:
					// traverse syntax tree node associated with production
					// BuiltinValue: SequenceOfValue

						m_SequenceOfValue.Visit (visitor, appData);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_18:
					// traverse syntax tree node associated with production
					// BuiltinValue: SetValue

						m_SetValue.Visit (visitor, appData);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_19:
					// traverse syntax tree node associated with production
					// BuiltinValue: SetOfValue

						m_SetOfValue.Visit (visitor, appData);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_20:
					// traverse syntax tree node associated with production
					// BuiltinValue: TimeValue

						m_TimeValue.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_BitStringValue?.reparent (this);
			m_BooleanValue?.reparent (this);
			m_CharacterStringValue?.reparent (this);
			m_ChoiceValue?.reparent (this);
			m_EmbeddedPDVValue?.reparent (this);
			m_EnumeratedValue?.reparent (this);
			m_ExternalValue?.reparent (this);
			m_IntegerValue?.reparent (this);
			m_IRIValue?.reparent (this);
			m_NullValue?.reparent (this);
			m_ObjectIdentifierValue?.reparent (this);
			m_OctetStringValue?.reparent (this);
			m_RealValue?.reparent (this);
			m_RelativeIRIValue?.reparent (this);
			m_RelativeOIDValue?.reparent (this);
			m_SequenceValue?.reparent (this);
			m_SequenceOfValue?.reparent (this);
			m_SetValue?.reparent (this);
			m_SetOfValue?.reparent (this);
			m_TimeValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule BuiltinValue
		//

		public void _init ()
		{
			m_BitStringValue = null;
			m_BooleanValue = null;
			m_CharacterStringValue = null;
			m_ChoiceValue = null;
			m_EmbeddedPDVValue = null;
			m_EnumeratedValue = null;
			m_ExternalValue = null;
			m_IntegerValue = null;
			m_IRIValue = null;
			m_NullValue = null;
			m_ObjectIdentifierValue = null;
			m_OctetStringValue = null;
			m_RealValue = null;
			m_RelativeIRIValue = null;
			m_RelativeOIDValue = null;
			m_SequenceValue = null;
			m_SequenceOfValue = null;
			m_SetValue = null;
			m_SetOfValue = null;
			m_TimeValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule BuiltinValue

		// counter of all nodes associated with syntax rule BuiltinValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule BuiltinValue
		[DataMember (Name = "m_BitStringValue")] public BitStringValue m_BitStringValue { get; private set; }
		[DataMember (Name = "m_BooleanValue")] public BooleanValue m_BooleanValue { get; private set; }
		[DataMember (Name = "m_CharacterStringValue")] public CharacterStringValue m_CharacterStringValue { get; private set; }
		[DataMember (Name = "m_ChoiceValue")] public ChoiceValue m_ChoiceValue { get; private set; }
		[DataMember (Name = "m_EmbeddedPDVValue")] public EmbeddedPDVValue m_EmbeddedPDVValue { get; private set; }
		[DataMember (Name = "m_EnumeratedValue")] public EnumeratedValue m_EnumeratedValue { get; private set; }
		[DataMember (Name = "m_ExternalValue")] public ExternalValue m_ExternalValue { get; private set; }
		[DataMember (Name = "m_IntegerValue")] public IntegerValue m_IntegerValue { get; private set; }
		[DataMember (Name = "m_IRIValue")] public IRIValue m_IRIValue { get; private set; }
		[DataMember (Name = "m_NullValue")] public NullValue m_NullValue { get; private set; }
		[DataMember (Name = "m_ObjectIdentifierValue")] public ObjectIdentifierValue m_ObjectIdentifierValue { get; private set; }
		[DataMember (Name = "m_OctetStringValue")] public OctetStringValue m_OctetStringValue { get; private set; }
		[DataMember (Name = "m_RealValue")] public RealValue m_RealValue { get; private set; }
		[DataMember (Name = "m_RelativeIRIValue")] public RelativeIRIValue m_RelativeIRIValue { get; private set; }
		[DataMember (Name = "m_RelativeOIDValue")] public RelativeOIDValue m_RelativeOIDValue { get; private set; }
		[DataMember (Name = "m_SequenceValue")] public SequenceValue m_SequenceValue { get; private set; }
		[DataMember (Name = "m_SequenceOfValue")] public SequenceOfValue m_SequenceOfValue { get; private set; }
		[DataMember (Name = "m_SetValue")] public SetValue m_SetValue { get; private set; }
		[DataMember (Name = "m_SetOfValue")] public SetOfValue m_SetOfValue { get; private set; }
		[DataMember (Name = "m_TimeValue")] public TimeValue m_TimeValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule BuiltinValue

		// delegate function (callback) prototype associated with syntax rule BuiltinValue
		public delegate bool BuiltinValue_Callback (SyntaxTreeCallbackReason reason, BuiltinValue.production_kind kind, BuiltinValue p_BuiltinValue);

		// event associated with syntax rule BuiltinValue
		public event BuiltinValue_Callback BuiltinValue_Event;

		// event trigger associated with syntax rule BuiltinValue
		public bool Raise_BuiltinValue_Event (SyntaxTreeCallbackReason reason, BuiltinValue.production_kind kind, BuiltinValue p_BuiltinValue)
		{
			bool? status = BuiltinValue_Event?.Invoke (reason, kind, p_BuiltinValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule BuiltinValue
		//
		// traverse syntax tree node associated with any production of syntax rule BuiltinValue
		//

		public void Traverse (BuiltinValue p_BuiltinValue)
		{
			if (p_BuiltinValue.isLocked())
				return;
			p_BuiltinValue.dolock();
			BuiltinValue.production_kind kind = (BuiltinValue.production_kind) p_BuiltinValue.kind;
			p_BuiltinValue.turn_reset ();
			if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_BuiltinValue))
			switch (kind)
			{
				case BuiltinValue.production_kind.g_BuiltinValue_1:
					// traverse syntax tree node associated with production
					// BuiltinValue: BitStringValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_BitStringValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_2:
					// traverse syntax tree node associated with production
					// BuiltinValue: BooleanValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_BooleanValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_3:
					// traverse syntax tree node associated with production
					// BuiltinValue: CharacterStringValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_CharacterStringValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_4:
					// traverse syntax tree node associated with production
					// BuiltinValue: ChoiceValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_ChoiceValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_5:
					// traverse syntax tree node associated with production
					// BuiltinValue: EmbeddedPDVValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_EmbeddedPDVValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_6:
					// traverse syntax tree node associated with production
					// BuiltinValue: EnumeratedValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_EnumeratedValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_7:
					// traverse syntax tree node associated with production
					// BuiltinValue: ExternalValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_ExternalValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_8:
					// traverse syntax tree node associated with production
					// BuiltinValue: IntegerValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_IntegerValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_9:
					// traverse syntax tree node associated with production
					// BuiltinValue: IRIValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_IRIValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_10:
					// traverse syntax tree node associated with production
					// BuiltinValue: NullValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_NullValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_11:
					// traverse syntax tree node associated with production
					// BuiltinValue: ObjectIdentifierValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_ObjectIdentifierValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_12:
					// traverse syntax tree node associated with production
					// BuiltinValue: OctetStringValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_OctetStringValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_13:
					// traverse syntax tree node associated with production
					// BuiltinValue: RealValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_RealValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_14:
					// traverse syntax tree node associated with production
					// BuiltinValue: RelativeIRIValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_RelativeIRIValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_15:
					// traverse syntax tree node associated with production
					// BuiltinValue: RelativeOIDValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_RelativeOIDValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_16:
					// traverse syntax tree node associated with production
					// BuiltinValue: SequenceValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_SequenceValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_17:
					// traverse syntax tree node associated with production
					// BuiltinValue: SequenceOfValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_SequenceOfValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_18:
					// traverse syntax tree node associated with production
					// BuiltinValue: SetValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_SetValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_19:
					// traverse syntax tree node associated with production
					// BuiltinValue: SetOfValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_SetOfValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_20:
					// traverse syntax tree node associated with production
					// BuiltinValue: TimeValue

					if (Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue))
						Traverse (p_BuiltinValue.m_TimeValue);
					p_BuiltinValue.turn_inc ();
					Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BuiltinValue);
				break;
			}
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_BuiltinValue);
			p_BuiltinValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule BuiltinValue
		//

		public void TraverseCommon (BuiltinValue p_BuiltinValue)
		{
			BuiltinValue.production_kind kind = (BuiltinValue.production_kind) p_BuiltinValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_BuiltinValue))
			switch (kind)
			{
				case BuiltinValue.production_kind.g_BuiltinValue_1:
					// traverse syntax tree node associated with production
					// BuiltinValue: BitStringValue

						TraverseCommon (p_BuiltinValue.m_BitStringValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_2:
					// traverse syntax tree node associated with production
					// BuiltinValue: BooleanValue

						TraverseCommon (p_BuiltinValue.m_BooleanValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_3:
					// traverse syntax tree node associated with production
					// BuiltinValue: CharacterStringValue

						TraverseCommon (p_BuiltinValue.m_CharacterStringValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_4:
					// traverse syntax tree node associated with production
					// BuiltinValue: ChoiceValue

						TraverseCommon (p_BuiltinValue.m_ChoiceValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_5:
					// traverse syntax tree node associated with production
					// BuiltinValue: EmbeddedPDVValue

						TraverseCommon (p_BuiltinValue.m_EmbeddedPDVValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_6:
					// traverse syntax tree node associated with production
					// BuiltinValue: EnumeratedValue

						TraverseCommon (p_BuiltinValue.m_EnumeratedValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_7:
					// traverse syntax tree node associated with production
					// BuiltinValue: ExternalValue

						TraverseCommon (p_BuiltinValue.m_ExternalValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_8:
					// traverse syntax tree node associated with production
					// BuiltinValue: IntegerValue

						TraverseCommon (p_BuiltinValue.m_IntegerValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_9:
					// traverse syntax tree node associated with production
					// BuiltinValue: IRIValue

						TraverseCommon (p_BuiltinValue.m_IRIValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_10:
					// traverse syntax tree node associated with production
					// BuiltinValue: NullValue

						TraverseCommon (p_BuiltinValue.m_NullValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_11:
					// traverse syntax tree node associated with production
					// BuiltinValue: ObjectIdentifierValue

						TraverseCommon (p_BuiltinValue.m_ObjectIdentifierValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_12:
					// traverse syntax tree node associated with production
					// BuiltinValue: OctetStringValue

						TraverseCommon (p_BuiltinValue.m_OctetStringValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_13:
					// traverse syntax tree node associated with production
					// BuiltinValue: RealValue

						TraverseCommon (p_BuiltinValue.m_RealValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_14:
					// traverse syntax tree node associated with production
					// BuiltinValue: RelativeIRIValue

						TraverseCommon (p_BuiltinValue.m_RelativeIRIValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_15:
					// traverse syntax tree node associated with production
					// BuiltinValue: RelativeOIDValue

						TraverseCommon (p_BuiltinValue.m_RelativeOIDValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_16:
					// traverse syntax tree node associated with production
					// BuiltinValue: SequenceValue

						TraverseCommon (p_BuiltinValue.m_SequenceValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_17:
					// traverse syntax tree node associated with production
					// BuiltinValue: SequenceOfValue

						TraverseCommon (p_BuiltinValue.m_SequenceOfValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_18:
					// traverse syntax tree node associated with production
					// BuiltinValue: SetValue

						TraverseCommon (p_BuiltinValue.m_SetValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_19:
					// traverse syntax tree node associated with production
					// BuiltinValue: SetOfValue

						TraverseCommon (p_BuiltinValue.m_SetOfValue);
				break;
				case BuiltinValue.production_kind.g_BuiltinValue_20:
					// traverse syntax tree node associated with production
					// BuiltinValue: TimeValue

						TraverseCommon (p_BuiltinValue.m_TimeValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_BuiltinValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule BuiltinValue

		//
		// create syntax tree node associated with production
		// BuiltinValue: BitStringValue

		//

		public BuiltinValue BuiltinValue_1 (BitStringValue p_BitStringValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_BitStringValue);
			p_BitStringValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_1, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinValue: BooleanValue

		//

		public BuiltinValue BuiltinValue_2 (BooleanValue p_BooleanValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_BooleanValue);
			p_BooleanValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_2, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinValue: CharacterStringValue

		//

		public BuiltinValue BuiltinValue_3 (CharacterStringValue p_CharacterStringValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_CharacterStringValue);
			p_CharacterStringValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_3, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinValue: ChoiceValue

		//

		public BuiltinValue BuiltinValue_4 (ChoiceValue p_ChoiceValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_ChoiceValue);
			p_ChoiceValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_4, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinValue: EmbeddedPDVValue

		//

		public BuiltinValue BuiltinValue_5 (EmbeddedPDVValue p_EmbeddedPDVValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_EmbeddedPDVValue);
			p_EmbeddedPDVValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_5, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinValue: EnumeratedValue

		//

		public BuiltinValue BuiltinValue_6 (EnumeratedValue p_EnumeratedValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_EnumeratedValue);
			p_EnumeratedValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_6, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinValue: ExternalValue

		//

		public BuiltinValue BuiltinValue_7 (ExternalValue p_ExternalValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_ExternalValue);
			p_ExternalValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_7, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinValue: IntegerValue

		//

		public BuiltinValue BuiltinValue_8 (IntegerValue p_IntegerValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_IntegerValue);
			p_IntegerValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_8, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinValue: IRIValue

		//

		public BuiltinValue BuiltinValue_9 (IRIValue p_IRIValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_IRIValue);
			p_IRIValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_9, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinValue: NullValue

		//

		public BuiltinValue BuiltinValue_10 (NullValue p_NullValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_NullValue);
			p_NullValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_10, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinValue: ObjectIdentifierValue

		//

		public BuiltinValue BuiltinValue_11 (ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_ObjectIdentifierValue);
			p_ObjectIdentifierValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_11, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinValue: OctetStringValue

		//

		public BuiltinValue BuiltinValue_12 (OctetStringValue p_OctetStringValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_OctetStringValue);
			p_OctetStringValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_12, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinValue: RealValue

		//

		public BuiltinValue BuiltinValue_13 (RealValue p_RealValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_RealValue);
			p_RealValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_13, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinValue: RelativeIRIValue

		//

		public BuiltinValue BuiltinValue_14 (RelativeIRIValue p_RelativeIRIValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_RelativeIRIValue);
			p_RelativeIRIValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_14, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinValue: RelativeOIDValue

		//

		public BuiltinValue BuiltinValue_15 (RelativeOIDValue p_RelativeOIDValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_RelativeOIDValue);
			p_RelativeOIDValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_15, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinValue: SequenceValue

		//

		public BuiltinValue BuiltinValue_16 (SequenceValue p_SequenceValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_SequenceValue);
			p_SequenceValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_16, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinValue: SequenceOfValue

		//

		public BuiltinValue BuiltinValue_17 (SequenceOfValue p_SequenceOfValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_SequenceOfValue);
			p_SequenceOfValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_17, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinValue: SetValue

		//

		public BuiltinValue BuiltinValue_18 (SetValue p_SetValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_SetValue);
			p_SetValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_18, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinValue: SetOfValue

		//

		public BuiltinValue BuiltinValue_19 (SetOfValue p_SetOfValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_SetOfValue);
			p_SetOfValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_19, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BuiltinValue: TimeValue

		//

		public BuiltinValue BuiltinValue_20 (TimeValue p_TimeValue)
		{
			BuiltinValue p_BuiltinValue_ref = new BuiltinValue(p_TimeValue);
			p_TimeValue.parent = p_BuiltinValue_ref;
			Raise_BuiltinValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BuiltinValue.production_kind.g_BuiltinValue_20, p_BuiltinValue_ref);
			return p_BuiltinValue_ref;
		}
		#endregion
	};
}
