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
	// class associated with syntax rule UsefulType
	//

	[DataContract]
	public class	UsefulType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule UsefulType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule UsefulType
		{
			g_UsefulType_1 = 1,	// UTF8String

			g_UsefulType_2 = 2,	// GraphicString

			g_UsefulType_3 = 3,	// NumericString

			g_UsefulType_4 = 4,	// VisibleString

			g_UsefulType_5 = 5,	// PrintableString

			g_UsefulType_6 = 6,	// ISO646String

			g_UsefulType_7 = 7,	// TeletexString

			g_UsefulType_8 = 8,	// GeneralString

			g_UsefulType_9 = 9,	// T61String

			g_UsefulType_10 = 10,	// UniversalString

			g_UsefulType_11 = 11,	// VideotexString

			g_UsefulType_12 = 12,	// BMPString

			g_UsefulType_13 = 13,	// IA5String

			g_UsefulType_14 = 14,	// GeneralizedTime

			g_UsefulType_15 = 15,	// UTCTime

			g_UsefulType_16 = 16,	// ObjectDescriptor

		};
		#endregion
		#region production markers associated with the syntax rule UsefulType

		// markers associated with production: UsefulType -> UTF8String

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: UsefulType -> GraphicString

		public enum production_marker_2 : ushort
		{
			final
		};

		// markers associated with production: UsefulType -> NumericString

		public enum production_marker_3 : ushort
		{
			final
		};

		// markers associated with production: UsefulType -> VisibleString

		public enum production_marker_4 : ushort
		{
			final
		};

		// markers associated with production: UsefulType -> PrintableString

		public enum production_marker_5 : ushort
		{
			final
		};

		// markers associated with production: UsefulType -> ISO646String

		public enum production_marker_6 : ushort
		{
			final
		};

		// markers associated with production: UsefulType -> TeletexString

		public enum production_marker_7 : ushort
		{
			final
		};

		// markers associated with production: UsefulType -> GeneralString

		public enum production_marker_8 : ushort
		{
			final
		};

		// markers associated with production: UsefulType -> T61String

		public enum production_marker_9 : ushort
		{
			final
		};

		// markers associated with production: UsefulType -> UniversalString

		public enum production_marker_10 : ushort
		{
			final
		};

		// markers associated with production: UsefulType -> VideotexString

		public enum production_marker_11 : ushort
		{
			final
		};

		// markers associated with production: UsefulType -> BMPString

		public enum production_marker_12 : ushort
		{
			final
		};

		// markers associated with production: UsefulType -> IA5String

		public enum production_marker_13 : ushort
		{
			final
		};

		// markers associated with production: UsefulType -> GeneralizedTime

		public enum production_marker_14 : ushort
		{
			final
		};

		// markers associated with production: UsefulType -> UTCTime

		public enum production_marker_15 : ushort
		{
			final
		};

		// markers associated with production: UsefulType -> ObjectDescriptor

		public enum production_marker_16 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule UsefulType

		// Constructor declaration(s) associated with production(s) of syntax rule UsefulType

		//
		// Constructor associated with the following production(s)
		// UsefulType -> UTF8String

		// UsefulType -> GraphicString

		// UsefulType -> NumericString

		// UsefulType -> VisibleString

		// UsefulType -> PrintableString

		// UsefulType -> ISO646String

		// UsefulType -> TeletexString

		// UsefulType -> GeneralString

		// UsefulType -> T61String

		// UsefulType -> UniversalString

		// UsefulType -> VideotexString

		// UsefulType -> BMPString

		// UsefulType -> IA5String

		// UsefulType -> GeneralizedTime

		// UsefulType -> UTCTime

		// UsefulType -> ObjectDescriptor

		//

		public UsefulType (SyntaxTreeToken p_token, int kind) : base ((uint) ProductionID._UsefulType_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_UsefulType_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_UTF8String = p_token;
				break;
			case production_kind.g_UsefulType_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_GraphicString = p_token;
				break;
			case production_kind.g_UsefulType_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_NumericString = p_token;
				break;
			case production_kind.g_UsefulType_4:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_VisibleString = p_token;
				break;
			case production_kind.g_UsefulType_5:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_PrintableString = p_token;
				break;
			case production_kind.g_UsefulType_6:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_ISO646String = p_token;
				break;
			case production_kind.g_UsefulType_7:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_TeletexString = p_token;
				break;
			case production_kind.g_UsefulType_8:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_GeneralString = p_token;
				break;
			case production_kind.g_UsefulType_9:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_T61String = p_token;
				break;
			case production_kind.g_UsefulType_10:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_UniversalString = p_token;
				break;
			case production_kind.g_UsefulType_11:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_VideotexString = p_token;
				break;
			case production_kind.g_UsefulType_12:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_BMPString = p_token;
				break;
			case production_kind.g_UsefulType_13:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_IA5String = p_token;
				break;
			case production_kind.g_UsefulType_14:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_GeneralizedTime = p_token;
				break;
			case production_kind.g_UsefulType_15:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_UTCTime = p_token;
				break;
			case production_kind.g_UsefulType_16:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_ObjectDescriptor = p_token;
				break;
			default:
				{
					string[] args = new string[] { "UsefulType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		public UsefulType () { }

		// Copy constructor

		public UsefulType (UsefulType p_UsefulType) : base (p_UsefulType.id, p_UsefulType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_UsefulType.appInfo;
			switch ((production_kind) p_UsefulType.kind)
			{
				case production_kind.g_UsefulType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UTF8String = (p_UsefulType.m_UTF8String != null) ? new SyntaxTreeToken (p_UsefulType.m_UTF8String) : null) != null) m_UTF8String.parent = this;
					break;
				case production_kind.g_UsefulType_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_GraphicString = (p_UsefulType.m_GraphicString != null) ? new SyntaxTreeToken (p_UsefulType.m_GraphicString) : null) != null) m_GraphicString.parent = this;
					break;
				case production_kind.g_UsefulType_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NumericString = (p_UsefulType.m_NumericString != null) ? new SyntaxTreeToken (p_UsefulType.m_NumericString) : null) != null) m_NumericString.parent = this;
					break;
				case production_kind.g_UsefulType_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_VisibleString = (p_UsefulType.m_VisibleString != null) ? new SyntaxTreeToken (p_UsefulType.m_VisibleString) : null) != null) m_VisibleString.parent = this;
					break;
				case production_kind.g_UsefulType_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_PrintableString = (p_UsefulType.m_PrintableString != null) ? new SyntaxTreeToken (p_UsefulType.m_PrintableString) : null) != null) m_PrintableString.parent = this;
					break;
				case production_kind.g_UsefulType_6:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ISO646String = (p_UsefulType.m_ISO646String != null) ? new SyntaxTreeToken (p_UsefulType.m_ISO646String) : null) != null) m_ISO646String.parent = this;
					break;
				case production_kind.g_UsefulType_7:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TeletexString = (p_UsefulType.m_TeletexString != null) ? new SyntaxTreeToken (p_UsefulType.m_TeletexString) : null) != null) m_TeletexString.parent = this;
					break;
				case production_kind.g_UsefulType_8:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_GeneralString = (p_UsefulType.m_GeneralString != null) ? new SyntaxTreeToken (p_UsefulType.m_GeneralString) : null) != null) m_GeneralString.parent = this;
					break;
				case production_kind.g_UsefulType_9:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_T61String = (p_UsefulType.m_T61String != null) ? new SyntaxTreeToken (p_UsefulType.m_T61String) : null) != null) m_T61String.parent = this;
					break;
				case production_kind.g_UsefulType_10:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UniversalString = (p_UsefulType.m_UniversalString != null) ? new SyntaxTreeToken (p_UsefulType.m_UniversalString) : null) != null) m_UniversalString.parent = this;
					break;
				case production_kind.g_UsefulType_11:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_VideotexString = (p_UsefulType.m_VideotexString != null) ? new SyntaxTreeToken (p_UsefulType.m_VideotexString) : null) != null) m_VideotexString.parent = this;
					break;
				case production_kind.g_UsefulType_12:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_BMPString = (p_UsefulType.m_BMPString != null) ? new SyntaxTreeToken (p_UsefulType.m_BMPString) : null) != null) m_BMPString.parent = this;
					break;
				case production_kind.g_UsefulType_13:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_IA5String = (p_UsefulType.m_IA5String != null) ? new SyntaxTreeToken (p_UsefulType.m_IA5String) : null) != null) m_IA5String.parent = this;
					break;
				case production_kind.g_UsefulType_14:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_GeneralizedTime = (p_UsefulType.m_GeneralizedTime != null) ? new SyntaxTreeToken (p_UsefulType.m_GeneralizedTime) : null) != null) m_GeneralizedTime.parent = this;
					break;
				case production_kind.g_UsefulType_15:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UTCTime = (p_UsefulType.m_UTCTime != null) ? new SyntaxTreeToken (p_UsefulType.m_UTCTime) : null) != null) m_UTCTime.parent = this;
					break;
				case production_kind.g_UsefulType_16:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectDescriptor = (p_UsefulType.m_ObjectDescriptor != null) ? new SyntaxTreeToken (p_UsefulType.m_ObjectDescriptor) : null) != null) m_ObjectDescriptor.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "UsefulType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new UsefulType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_UTF8String?.Dispose ();
			m_GraphicString?.Dispose ();
			m_NumericString?.Dispose ();
			m_VisibleString?.Dispose ();
			m_PrintableString?.Dispose ();
			m_ISO646String?.Dispose ();
			m_TeletexString?.Dispose ();
			m_GeneralString?.Dispose ();
			m_T61String?.Dispose ();
			m_UniversalString?.Dispose ();
			m_VideotexString?.Dispose ();
			m_BMPString?.Dispose ();
			m_IA5String?.Dispose ();
			m_GeneralizedTime?.Dispose ();
			m_UTCTime?.Dispose ();
			m_ObjectDescriptor?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule UsefulType

		// Content changing function(s) associated with production(s) of syntax rule UsefulType

		//
		// Content changing function associated with following production(s)
		// UsefulType -> UTF8String

		// UsefulType -> GraphicString

		// UsefulType -> NumericString

		// UsefulType -> VisibleString

		// UsefulType -> PrintableString

		// UsefulType -> ISO646String

		// UsefulType -> TeletexString

		// UsefulType -> GeneralString

		// UsefulType -> T61String

		// UsefulType -> UniversalString

		// UsefulType -> VideotexString

		// UsefulType -> BMPString

		// UsefulType -> IA5String

		// UsefulType -> GeneralizedTime

		// UsefulType -> UTCTime

		// UsefulType -> ObjectDescriptor

		//

		public void change(SyntaxTreeToken p_token, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_UsefulType_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_UTF8String = p_token;
				break;
			case production_kind.g_UsefulType_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_GraphicString = p_token;
				break;
			case production_kind.g_UsefulType_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_NumericString = p_token;
				break;
			case production_kind.g_UsefulType_4:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_VisibleString = p_token;
				break;
			case production_kind.g_UsefulType_5:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_PrintableString = p_token;
				break;
			case production_kind.g_UsefulType_6:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_ISO646String = p_token;
				break;
			case production_kind.g_UsefulType_7:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_TeletexString = p_token;
				break;
			case production_kind.g_UsefulType_8:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_GeneralString = p_token;
				break;
			case production_kind.g_UsefulType_9:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_T61String = p_token;
				break;
			case production_kind.g_UsefulType_10:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_UniversalString = p_token;
				break;
			case production_kind.g_UsefulType_11:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_VideotexString = p_token;
				break;
			case production_kind.g_UsefulType_12:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_BMPString = p_token;
				break;
			case production_kind.g_UsefulType_13:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_IA5String = p_token;
				break;
			case production_kind.g_UsefulType_14:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_GeneralizedTime = p_token;
				break;
			case production_kind.g_UsefulType_15:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_UTCTime = p_token;
				break;
			case production_kind.g_UsefulType_16:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_ObjectDescriptor = p_token;
				break;
			default:
				{
					string[] args = new string[] { "UsefulType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule UsefulType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_UTF8String != null) && m_UTF8String.checkInclusion (element) ||
				(m_GraphicString != null) && m_GraphicString.checkInclusion (element) ||
				(m_NumericString != null) && m_NumericString.checkInclusion (element) ||
				(m_VisibleString != null) && m_VisibleString.checkInclusion (element) ||
				(m_PrintableString != null) && m_PrintableString.checkInclusion (element) ||
				(m_ISO646String != null) && m_ISO646String.checkInclusion (element) ||
				(m_TeletexString != null) && m_TeletexString.checkInclusion (element) ||
				(m_GeneralString != null) && m_GeneralString.checkInclusion (element) ||
				(m_T61String != null) && m_T61String.checkInclusion (element) ||
				(m_UniversalString != null) && m_UniversalString.checkInclusion (element) ||
				(m_VideotexString != null) && m_VideotexString.checkInclusion (element) ||
				(m_BMPString != null) && m_BMPString.checkInclusion (element) ||
				(m_IA5String != null) && m_IA5String.checkInclusion (element) ||
				(m_GeneralizedTime != null) && m_GeneralizedTime.checkInclusion (element) ||
				(m_UTCTime != null) && m_UTCTime.checkInclusion (element) ||
				(m_ObjectDescriptor != null) && m_ObjectDescriptor.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule UsefulType

		//
		// emit production tree node associated with any production of syntax rule UsefulType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_UsefulType_1:
					// emit syntax tree node associated with production
					// UsefulType: UTF8String

					s += m_UTF8String.Emit (depth - 1);
				break;
				case production_kind.g_UsefulType_2:
					// emit syntax tree node associated with production
					// UsefulType: GraphicString

					s += m_GraphicString.Emit (depth - 1);
				break;
				case production_kind.g_UsefulType_3:
					// emit syntax tree node associated with production
					// UsefulType: NumericString

					s += m_NumericString.Emit (depth - 1);
				break;
				case production_kind.g_UsefulType_4:
					// emit syntax tree node associated with production
					// UsefulType: VisibleString

					s += m_VisibleString.Emit (depth - 1);
				break;
				case production_kind.g_UsefulType_5:
					// emit syntax tree node associated with production
					// UsefulType: PrintableString

					s += m_PrintableString.Emit (depth - 1);
				break;
				case production_kind.g_UsefulType_6:
					// emit syntax tree node associated with production
					// UsefulType: ISO646String

					s += m_ISO646String.Emit (depth - 1);
				break;
				case production_kind.g_UsefulType_7:
					// emit syntax tree node associated with production
					// UsefulType: TeletexString

					s += m_TeletexString.Emit (depth - 1);
				break;
				case production_kind.g_UsefulType_8:
					// emit syntax tree node associated with production
					// UsefulType: GeneralString

					s += m_GeneralString.Emit (depth - 1);
				break;
				case production_kind.g_UsefulType_9:
					// emit syntax tree node associated with production
					// UsefulType: T61String

					s += m_T61String.Emit (depth - 1);
				break;
				case production_kind.g_UsefulType_10:
					// emit syntax tree node associated with production
					// UsefulType: UniversalString

					s += m_UniversalString.Emit (depth - 1);
				break;
				case production_kind.g_UsefulType_11:
					// emit syntax tree node associated with production
					// UsefulType: VideotexString

					s += m_VideotexString.Emit (depth - 1);
				break;
				case production_kind.g_UsefulType_12:
					// emit syntax tree node associated with production
					// UsefulType: BMPString

					s += m_BMPString.Emit (depth - 1);
				break;
				case production_kind.g_UsefulType_13:
					// emit syntax tree node associated with production
					// UsefulType: IA5String

					s += m_IA5String.Emit (depth - 1);
				break;
				case production_kind.g_UsefulType_14:
					// emit syntax tree node associated with production
					// UsefulType: GeneralizedTime

					s += m_GeneralizedTime.Emit (depth - 1);
				break;
				case production_kind.g_UsefulType_15:
					// emit syntax tree node associated with production
					// UsefulType: UTCTime

					s += m_UTCTime.Emit (depth - 1);
				break;
				case production_kind.g_UsefulType_16:
					// emit syntax tree node associated with production
					// UsefulType: ObjectDescriptor

					s += m_ObjectDescriptor.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule UsefulType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "UsefulType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_UsefulType_1:
					// emit syntax tree node associated with production
					// UsefulType: UTF8String

					s += "UTF8String";
				break;
				case production_kind.g_UsefulType_2:
					// emit syntax tree node associated with production
					// UsefulType: GraphicString

					s += "GraphicString";
				break;
				case production_kind.g_UsefulType_3:
					// emit syntax tree node associated with production
					// UsefulType: NumericString

					s += "NumericString";
				break;
				case production_kind.g_UsefulType_4:
					// emit syntax tree node associated with production
					// UsefulType: VisibleString

					s += "VisibleString";
				break;
				case production_kind.g_UsefulType_5:
					// emit syntax tree node associated with production
					// UsefulType: PrintableString

					s += "PrintableString";
				break;
				case production_kind.g_UsefulType_6:
					// emit syntax tree node associated with production
					// UsefulType: ISO646String

					s += "ISO646String";
				break;
				case production_kind.g_UsefulType_7:
					// emit syntax tree node associated with production
					// UsefulType: TeletexString

					s += "TeletexString";
				break;
				case production_kind.g_UsefulType_8:
					// emit syntax tree node associated with production
					// UsefulType: GeneralString

					s += "GeneralString";
				break;
				case production_kind.g_UsefulType_9:
					// emit syntax tree node associated with production
					// UsefulType: T61String

					s += "T61String";
				break;
				case production_kind.g_UsefulType_10:
					// emit syntax tree node associated with production
					// UsefulType: UniversalString

					s += "UniversalString";
				break;
				case production_kind.g_UsefulType_11:
					// emit syntax tree node associated with production
					// UsefulType: VideotexString

					s += "VideotexString";
				break;
				case production_kind.g_UsefulType_12:
					// emit syntax tree node associated with production
					// UsefulType: BMPString

					s += "BMPString";
				break;
				case production_kind.g_UsefulType_13:
					// emit syntax tree node associated with production
					// UsefulType: IA5String

					s += "IA5String";
				break;
				case production_kind.g_UsefulType_14:
					// emit syntax tree node associated with production
					// UsefulType: GeneralizedTime

					s += "GeneralizedTime";
				break;
				case production_kind.g_UsefulType_15:
					// emit syntax tree node associated with production
					// UsefulType: UTCTime

					s += "UTCTime";
				break;
				case production_kind.g_UsefulType_16:
					// emit syntax tree node associated with production
					// UsefulType: ObjectDescriptor

					s += "ObjectDescriptor";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule UsefulType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule UsefulType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			UsefulType.production_kind kind = (UsefulType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case UsefulType.production_kind.g_UsefulType_1:
					// traverse syntax tree node associated with production
					// UsefulType: UTF8String

						m_UTF8String.Visit (visitor, appData);
				break;
				case UsefulType.production_kind.g_UsefulType_2:
					// traverse syntax tree node associated with production
					// UsefulType: GraphicString

						m_GraphicString.Visit (visitor, appData);
				break;
				case UsefulType.production_kind.g_UsefulType_3:
					// traverse syntax tree node associated with production
					// UsefulType: NumericString

						m_NumericString.Visit (visitor, appData);
				break;
				case UsefulType.production_kind.g_UsefulType_4:
					// traverse syntax tree node associated with production
					// UsefulType: VisibleString

						m_VisibleString.Visit (visitor, appData);
				break;
				case UsefulType.production_kind.g_UsefulType_5:
					// traverse syntax tree node associated with production
					// UsefulType: PrintableString

						m_PrintableString.Visit (visitor, appData);
				break;
				case UsefulType.production_kind.g_UsefulType_6:
					// traverse syntax tree node associated with production
					// UsefulType: ISO646String

						m_ISO646String.Visit (visitor, appData);
				break;
				case UsefulType.production_kind.g_UsefulType_7:
					// traverse syntax tree node associated with production
					// UsefulType: TeletexString

						m_TeletexString.Visit (visitor, appData);
				break;
				case UsefulType.production_kind.g_UsefulType_8:
					// traverse syntax tree node associated with production
					// UsefulType: GeneralString

						m_GeneralString.Visit (visitor, appData);
				break;
				case UsefulType.production_kind.g_UsefulType_9:
					// traverse syntax tree node associated with production
					// UsefulType: T61String

						m_T61String.Visit (visitor, appData);
				break;
				case UsefulType.production_kind.g_UsefulType_10:
					// traverse syntax tree node associated with production
					// UsefulType: UniversalString

						m_UniversalString.Visit (visitor, appData);
				break;
				case UsefulType.production_kind.g_UsefulType_11:
					// traverse syntax tree node associated with production
					// UsefulType: VideotexString

						m_VideotexString.Visit (visitor, appData);
				break;
				case UsefulType.production_kind.g_UsefulType_12:
					// traverse syntax tree node associated with production
					// UsefulType: BMPString

						m_BMPString.Visit (visitor, appData);
				break;
				case UsefulType.production_kind.g_UsefulType_13:
					// traverse syntax tree node associated with production
					// UsefulType: IA5String

						m_IA5String.Visit (visitor, appData);
				break;
				case UsefulType.production_kind.g_UsefulType_14:
					// traverse syntax tree node associated with production
					// UsefulType: GeneralizedTime

						m_GeneralizedTime.Visit (visitor, appData);
				break;
				case UsefulType.production_kind.g_UsefulType_15:
					// traverse syntax tree node associated with production
					// UsefulType: UTCTime

						m_UTCTime.Visit (visitor, appData);
				break;
				case UsefulType.production_kind.g_UsefulType_16:
					// traverse syntax tree node associated with production
					// UsefulType: ObjectDescriptor

						m_ObjectDescriptor.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_UTF8String?.reparent (this);
			m_GraphicString?.reparent (this);
			m_NumericString?.reparent (this);
			m_VisibleString?.reparent (this);
			m_PrintableString?.reparent (this);
			m_ISO646String?.reparent (this);
			m_TeletexString?.reparent (this);
			m_GeneralString?.reparent (this);
			m_T61String?.reparent (this);
			m_UniversalString?.reparent (this);
			m_VideotexString?.reparent (this);
			m_BMPString?.reparent (this);
			m_IA5String?.reparent (this);
			m_GeneralizedTime?.reparent (this);
			m_UTCTime?.reparent (this);
			m_ObjectDescriptor?.reparent (this);
		}

		//
		// initialize object associated with syntax rule UsefulType
		//

		public void _init ()
		{
			m_UTF8String = null;
			m_GraphicString = null;
			m_NumericString = null;
			m_VisibleString = null;
			m_PrintableString = null;
			m_ISO646String = null;
			m_TeletexString = null;
			m_GeneralString = null;
			m_T61String = null;
			m_UniversalString = null;
			m_VideotexString = null;
			m_BMPString = null;
			m_IA5String = null;
			m_GeneralizedTime = null;
			m_UTCTime = null;
			m_ObjectDescriptor = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule UsefulType

		// counter of all nodes associated with syntax rule UsefulType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule UsefulType
		[DataMember (Name = "m_UTF8String")] public SyntaxTreeToken m_UTF8String { get; private set; }
		[DataMember (Name = "m_GraphicString")] public SyntaxTreeToken m_GraphicString { get; private set; }
		[DataMember (Name = "m_NumericString")] public SyntaxTreeToken m_NumericString { get; private set; }
		[DataMember (Name = "m_VisibleString")] public SyntaxTreeToken m_VisibleString { get; private set; }
		[DataMember (Name = "m_PrintableString")] public SyntaxTreeToken m_PrintableString { get; private set; }
		[DataMember (Name = "m_ISO646String")] public SyntaxTreeToken m_ISO646String { get; private set; }
		[DataMember (Name = "m_TeletexString")] public SyntaxTreeToken m_TeletexString { get; private set; }
		[DataMember (Name = "m_GeneralString")] public SyntaxTreeToken m_GeneralString { get; private set; }
		[DataMember (Name = "m_T61String")] public SyntaxTreeToken m_T61String { get; private set; }
		[DataMember (Name = "m_UniversalString")] public SyntaxTreeToken m_UniversalString { get; private set; }
		[DataMember (Name = "m_VideotexString")] public SyntaxTreeToken m_VideotexString { get; private set; }
		[DataMember (Name = "m_BMPString")] public SyntaxTreeToken m_BMPString { get; private set; }
		[DataMember (Name = "m_IA5String")] public SyntaxTreeToken m_IA5String { get; private set; }
		[DataMember (Name = "m_GeneralizedTime")] public SyntaxTreeToken m_GeneralizedTime { get; private set; }
		[DataMember (Name = "m_UTCTime")] public SyntaxTreeToken m_UTCTime { get; private set; }
		[DataMember (Name = "m_ObjectDescriptor")] public SyntaxTreeToken m_ObjectDescriptor { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule UsefulType

		// delegate function (callback) prototype associated with syntax rule UsefulType
		public delegate bool UsefulType_Callback (SyntaxTreeCallbackReason reason, UsefulType.production_kind kind, UsefulType p_UsefulType);

		// event associated with syntax rule UsefulType
		public event UsefulType_Callback UsefulType_Event;

		// event trigger associated with syntax rule UsefulType
		public bool Raise_UsefulType_Event (SyntaxTreeCallbackReason reason, UsefulType.production_kind kind, UsefulType p_UsefulType)
		{
			bool? status = UsefulType_Event?.Invoke (reason, kind, p_UsefulType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule UsefulType
		//
		// traverse syntax tree node associated with any production of syntax rule UsefulType
		//

		public void Traverse (UsefulType p_UsefulType)
		{
			if (p_UsefulType.isLocked())
				return;
			p_UsefulType.dolock();
			UsefulType.production_kind kind = (UsefulType.production_kind) p_UsefulType.kind;
			p_UsefulType.turn_reset ();
			if (Raise_UsefulType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_UsefulType))
			switch (kind)
			{
				case UsefulType.production_kind.g_UsefulType_1:
					// traverse syntax tree node associated with production
					// UsefulType: UTF8String

				break;
				case UsefulType.production_kind.g_UsefulType_2:
					// traverse syntax tree node associated with production
					// UsefulType: GraphicString

				break;
				case UsefulType.production_kind.g_UsefulType_3:
					// traverse syntax tree node associated with production
					// UsefulType: NumericString

				break;
				case UsefulType.production_kind.g_UsefulType_4:
					// traverse syntax tree node associated with production
					// UsefulType: VisibleString

				break;
				case UsefulType.production_kind.g_UsefulType_5:
					// traverse syntax tree node associated with production
					// UsefulType: PrintableString

				break;
				case UsefulType.production_kind.g_UsefulType_6:
					// traverse syntax tree node associated with production
					// UsefulType: ISO646String

				break;
				case UsefulType.production_kind.g_UsefulType_7:
					// traverse syntax tree node associated with production
					// UsefulType: TeletexString

				break;
				case UsefulType.production_kind.g_UsefulType_8:
					// traverse syntax tree node associated with production
					// UsefulType: GeneralString

				break;
				case UsefulType.production_kind.g_UsefulType_9:
					// traverse syntax tree node associated with production
					// UsefulType: T61String

				break;
				case UsefulType.production_kind.g_UsefulType_10:
					// traverse syntax tree node associated with production
					// UsefulType: UniversalString

				break;
				case UsefulType.production_kind.g_UsefulType_11:
					// traverse syntax tree node associated with production
					// UsefulType: VideotexString

				break;
				case UsefulType.production_kind.g_UsefulType_12:
					// traverse syntax tree node associated with production
					// UsefulType: BMPString

				break;
				case UsefulType.production_kind.g_UsefulType_13:
					// traverse syntax tree node associated with production
					// UsefulType: IA5String

				break;
				case UsefulType.production_kind.g_UsefulType_14:
					// traverse syntax tree node associated with production
					// UsefulType: GeneralizedTime

				break;
				case UsefulType.production_kind.g_UsefulType_15:
					// traverse syntax tree node associated with production
					// UsefulType: UTCTime

				break;
				case UsefulType.production_kind.g_UsefulType_16:
					// traverse syntax tree node associated with production
					// UsefulType: ObjectDescriptor

				break;
			}
			Raise_UsefulType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_UsefulType);
			p_UsefulType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule UsefulType
		//

		public void TraverseCommon (UsefulType p_UsefulType)
		{
			UsefulType.production_kind kind = (UsefulType.production_kind) p_UsefulType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_UsefulType))
			switch (kind)
			{
				case UsefulType.production_kind.g_UsefulType_1:
					// traverse syntax tree node associated with production
					// UsefulType: UTF8String

						TraverseCommon (p_UsefulType.m_UTF8String);
				break;
				case UsefulType.production_kind.g_UsefulType_2:
					// traverse syntax tree node associated with production
					// UsefulType: GraphicString

						TraverseCommon (p_UsefulType.m_GraphicString);
				break;
				case UsefulType.production_kind.g_UsefulType_3:
					// traverse syntax tree node associated with production
					// UsefulType: NumericString

						TraverseCommon (p_UsefulType.m_NumericString);
				break;
				case UsefulType.production_kind.g_UsefulType_4:
					// traverse syntax tree node associated with production
					// UsefulType: VisibleString

						TraverseCommon (p_UsefulType.m_VisibleString);
				break;
				case UsefulType.production_kind.g_UsefulType_5:
					// traverse syntax tree node associated with production
					// UsefulType: PrintableString

						TraverseCommon (p_UsefulType.m_PrintableString);
				break;
				case UsefulType.production_kind.g_UsefulType_6:
					// traverse syntax tree node associated with production
					// UsefulType: ISO646String

						TraverseCommon (p_UsefulType.m_ISO646String);
				break;
				case UsefulType.production_kind.g_UsefulType_7:
					// traverse syntax tree node associated with production
					// UsefulType: TeletexString

						TraverseCommon (p_UsefulType.m_TeletexString);
				break;
				case UsefulType.production_kind.g_UsefulType_8:
					// traverse syntax tree node associated with production
					// UsefulType: GeneralString

						TraverseCommon (p_UsefulType.m_GeneralString);
				break;
				case UsefulType.production_kind.g_UsefulType_9:
					// traverse syntax tree node associated with production
					// UsefulType: T61String

						TraverseCommon (p_UsefulType.m_T61String);
				break;
				case UsefulType.production_kind.g_UsefulType_10:
					// traverse syntax tree node associated with production
					// UsefulType: UniversalString

						TraverseCommon (p_UsefulType.m_UniversalString);
				break;
				case UsefulType.production_kind.g_UsefulType_11:
					// traverse syntax tree node associated with production
					// UsefulType: VideotexString

						TraverseCommon (p_UsefulType.m_VideotexString);
				break;
				case UsefulType.production_kind.g_UsefulType_12:
					// traverse syntax tree node associated with production
					// UsefulType: BMPString

						TraverseCommon (p_UsefulType.m_BMPString);
				break;
				case UsefulType.production_kind.g_UsefulType_13:
					// traverse syntax tree node associated with production
					// UsefulType: IA5String

						TraverseCommon (p_UsefulType.m_IA5String);
				break;
				case UsefulType.production_kind.g_UsefulType_14:
					// traverse syntax tree node associated with production
					// UsefulType: GeneralizedTime

						TraverseCommon (p_UsefulType.m_GeneralizedTime);
				break;
				case UsefulType.production_kind.g_UsefulType_15:
					// traverse syntax tree node associated with production
					// UsefulType: UTCTime

						TraverseCommon (p_UsefulType.m_UTCTime);
				break;
				case UsefulType.production_kind.g_UsefulType_16:
					// traverse syntax tree node associated with production
					// UsefulType: ObjectDescriptor

						TraverseCommon (p_UsefulType.m_ObjectDescriptor);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_UsefulType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule UsefulType

		//
		// create syntax tree node associated with production
		// UsefulType: UTF8String

		//

		public UsefulType UsefulType_1 (SyntaxTreeToken p_token)
		{
			UsefulType p_UsefulType_ref = new UsefulType(p_token, 1);
			p_token.parent = p_UsefulType_ref;
			Raise_UsefulType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UsefulType.production_kind.g_UsefulType_1, p_UsefulType_ref);
			return p_UsefulType_ref;
		}

		//
		// create syntax tree node associated with production
		// UsefulType: GraphicString

		//

		public UsefulType UsefulType_2 (SyntaxTreeToken p_token)
		{
			UsefulType p_UsefulType_ref = new UsefulType(p_token, 2);
			p_token.parent = p_UsefulType_ref;
			Raise_UsefulType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UsefulType.production_kind.g_UsefulType_2, p_UsefulType_ref);
			return p_UsefulType_ref;
		}

		//
		// create syntax tree node associated with production
		// UsefulType: NumericString

		//

		public UsefulType UsefulType_3 (SyntaxTreeToken p_token)
		{
			UsefulType p_UsefulType_ref = new UsefulType(p_token, 3);
			p_token.parent = p_UsefulType_ref;
			Raise_UsefulType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UsefulType.production_kind.g_UsefulType_3, p_UsefulType_ref);
			return p_UsefulType_ref;
		}

		//
		// create syntax tree node associated with production
		// UsefulType: VisibleString

		//

		public UsefulType UsefulType_4 (SyntaxTreeToken p_token)
		{
			UsefulType p_UsefulType_ref = new UsefulType(p_token, 4);
			p_token.parent = p_UsefulType_ref;
			Raise_UsefulType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UsefulType.production_kind.g_UsefulType_4, p_UsefulType_ref);
			return p_UsefulType_ref;
		}

		//
		// create syntax tree node associated with production
		// UsefulType: PrintableString

		//

		public UsefulType UsefulType_5 (SyntaxTreeToken p_token)
		{
			UsefulType p_UsefulType_ref = new UsefulType(p_token, 5);
			p_token.parent = p_UsefulType_ref;
			Raise_UsefulType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UsefulType.production_kind.g_UsefulType_5, p_UsefulType_ref);
			return p_UsefulType_ref;
		}

		//
		// create syntax tree node associated with production
		// UsefulType: ISO646String

		//

		public UsefulType UsefulType_6 (SyntaxTreeToken p_token)
		{
			UsefulType p_UsefulType_ref = new UsefulType(p_token, 6);
			p_token.parent = p_UsefulType_ref;
			Raise_UsefulType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UsefulType.production_kind.g_UsefulType_6, p_UsefulType_ref);
			return p_UsefulType_ref;
		}

		//
		// create syntax tree node associated with production
		// UsefulType: TeletexString

		//

		public UsefulType UsefulType_7 (SyntaxTreeToken p_token)
		{
			UsefulType p_UsefulType_ref = new UsefulType(p_token, 7);
			p_token.parent = p_UsefulType_ref;
			Raise_UsefulType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UsefulType.production_kind.g_UsefulType_7, p_UsefulType_ref);
			return p_UsefulType_ref;
		}

		//
		// create syntax tree node associated with production
		// UsefulType: GeneralString

		//

		public UsefulType UsefulType_8 (SyntaxTreeToken p_token)
		{
			UsefulType p_UsefulType_ref = new UsefulType(p_token, 8);
			p_token.parent = p_UsefulType_ref;
			Raise_UsefulType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UsefulType.production_kind.g_UsefulType_8, p_UsefulType_ref);
			return p_UsefulType_ref;
		}

		//
		// create syntax tree node associated with production
		// UsefulType: T61String

		//

		public UsefulType UsefulType_9 (SyntaxTreeToken p_token)
		{
			UsefulType p_UsefulType_ref = new UsefulType(p_token, 9);
			p_token.parent = p_UsefulType_ref;
			Raise_UsefulType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UsefulType.production_kind.g_UsefulType_9, p_UsefulType_ref);
			return p_UsefulType_ref;
		}

		//
		// create syntax tree node associated with production
		// UsefulType: UniversalString

		//

		public UsefulType UsefulType_10 (SyntaxTreeToken p_token)
		{
			UsefulType p_UsefulType_ref = new UsefulType(p_token, 10);
			p_token.parent = p_UsefulType_ref;
			Raise_UsefulType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UsefulType.production_kind.g_UsefulType_10, p_UsefulType_ref);
			return p_UsefulType_ref;
		}

		//
		// create syntax tree node associated with production
		// UsefulType: VideotexString

		//

		public UsefulType UsefulType_11 (SyntaxTreeToken p_token)
		{
			UsefulType p_UsefulType_ref = new UsefulType(p_token, 11);
			p_token.parent = p_UsefulType_ref;
			Raise_UsefulType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UsefulType.production_kind.g_UsefulType_11, p_UsefulType_ref);
			return p_UsefulType_ref;
		}

		//
		// create syntax tree node associated with production
		// UsefulType: BMPString

		//

		public UsefulType UsefulType_12 (SyntaxTreeToken p_token)
		{
			UsefulType p_UsefulType_ref = new UsefulType(p_token, 12);
			p_token.parent = p_UsefulType_ref;
			Raise_UsefulType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UsefulType.production_kind.g_UsefulType_12, p_UsefulType_ref);
			return p_UsefulType_ref;
		}

		//
		// create syntax tree node associated with production
		// UsefulType: IA5String

		//

		public UsefulType UsefulType_13 (SyntaxTreeToken p_token)
		{
			UsefulType p_UsefulType_ref = new UsefulType(p_token, 13);
			p_token.parent = p_UsefulType_ref;
			Raise_UsefulType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UsefulType.production_kind.g_UsefulType_13, p_UsefulType_ref);
			return p_UsefulType_ref;
		}

		//
		// create syntax tree node associated with production
		// UsefulType: GeneralizedTime

		//

		public UsefulType UsefulType_14 (SyntaxTreeToken p_token)
		{
			UsefulType p_UsefulType_ref = new UsefulType(p_token, 14);
			p_token.parent = p_UsefulType_ref;
			Raise_UsefulType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UsefulType.production_kind.g_UsefulType_14, p_UsefulType_ref);
			return p_UsefulType_ref;
		}

		//
		// create syntax tree node associated with production
		// UsefulType: UTCTime

		//

		public UsefulType UsefulType_15 (SyntaxTreeToken p_token)
		{
			UsefulType p_UsefulType_ref = new UsefulType(p_token, 15);
			p_token.parent = p_UsefulType_ref;
			Raise_UsefulType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UsefulType.production_kind.g_UsefulType_15, p_UsefulType_ref);
			return p_UsefulType_ref;
		}

		//
		// create syntax tree node associated with production
		// UsefulType: ObjectDescriptor

		//

		public UsefulType UsefulType_16 (SyntaxTreeToken p_token)
		{
			UsefulType p_UsefulType_ref = new UsefulType(p_token, 16);
			p_token.parent = p_UsefulType_ref;
			Raise_UsefulType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UsefulType.production_kind.g_UsefulType_16, p_UsefulType_ref);
			return p_UsefulType_ref;
		}
		#endregion
	};
}
