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
	// class associated with syntax rule RestrictedCharacterStringType
	//

	[DataContract]
	public class	RestrictedCharacterStringType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule RestrictedCharacterStringType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule RestrictedCharacterStringType
		{
			g_RestrictedCharacterStringType_1 = 1,	// BMPString

			g_RestrictedCharacterStringType_2 = 2,	// GeneralString

			g_RestrictedCharacterStringType_3 = 3,	// GraphicString

			g_RestrictedCharacterStringType_4 = 4,	// IA5String

			g_RestrictedCharacterStringType_5 = 5,	// ISO646String

			g_RestrictedCharacterStringType_6 = 6,	// NumericString

			g_RestrictedCharacterStringType_7 = 7,	// PrintableString

			g_RestrictedCharacterStringType_8 = 8,	// TeletexString

			g_RestrictedCharacterStringType_9 = 9,	// T61String

			g_RestrictedCharacterStringType_10 = 10,	// UniversalString

			g_RestrictedCharacterStringType_11 = 11,	// UTF8String

			g_RestrictedCharacterStringType_12 = 12,	// VideotexString

			g_RestrictedCharacterStringType_13 = 13,	// VisibleString

		};
		#endregion
		#region production markers associated with the syntax rule RestrictedCharacterStringType

		// markers associated with production: RestrictedCharacterStringType -> BMPString

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: RestrictedCharacterStringType -> GeneralString

		public enum production_marker_2 : ushort
		{
			final
		};

		// markers associated with production: RestrictedCharacterStringType -> GraphicString

		public enum production_marker_3 : ushort
		{
			final
		};

		// markers associated with production: RestrictedCharacterStringType -> IA5String

		public enum production_marker_4 : ushort
		{
			final
		};

		// markers associated with production: RestrictedCharacterStringType -> ISO646String

		public enum production_marker_5 : ushort
		{
			final
		};

		// markers associated with production: RestrictedCharacterStringType -> NumericString

		public enum production_marker_6 : ushort
		{
			final
		};

		// markers associated with production: RestrictedCharacterStringType -> PrintableString

		public enum production_marker_7 : ushort
		{
			final
		};

		// markers associated with production: RestrictedCharacterStringType -> TeletexString

		public enum production_marker_8 : ushort
		{
			final
		};

		// markers associated with production: RestrictedCharacterStringType -> T61String

		public enum production_marker_9 : ushort
		{
			final
		};

		// markers associated with production: RestrictedCharacterStringType -> UniversalString

		public enum production_marker_10 : ushort
		{
			final
		};

		// markers associated with production: RestrictedCharacterStringType -> UTF8String

		public enum production_marker_11 : ushort
		{
			final
		};

		// markers associated with production: RestrictedCharacterStringType -> VideotexString

		public enum production_marker_12 : ushort
		{
			final
		};

		// markers associated with production: RestrictedCharacterStringType -> VisibleString

		public enum production_marker_13 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule RestrictedCharacterStringType

		// Constructor declaration(s) associated with production(s) of syntax rule RestrictedCharacterStringType

		//
		// Constructor associated with the following production(s)
		// RestrictedCharacterStringType -> BMPString

		// RestrictedCharacterStringType -> GeneralString

		// RestrictedCharacterStringType -> GraphicString

		// RestrictedCharacterStringType -> IA5String

		// RestrictedCharacterStringType -> ISO646String

		// RestrictedCharacterStringType -> NumericString

		// RestrictedCharacterStringType -> PrintableString

		// RestrictedCharacterStringType -> TeletexString

		// RestrictedCharacterStringType -> T61String

		// RestrictedCharacterStringType -> UniversalString

		// RestrictedCharacterStringType -> UTF8String

		// RestrictedCharacterStringType -> VideotexString

		// RestrictedCharacterStringType -> VisibleString

		//

		public RestrictedCharacterStringType (SyntaxTreeToken p_token, int kind) : base ((uint) ProductionID._RestrictedCharacterStringType_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_RestrictedCharacterStringType_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_BMPString = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_GeneralString = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_GraphicString = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_4:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_IA5String = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_5:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_ISO646String = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_6:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_NumericString = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_7:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_PrintableString = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_8:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_TeletexString = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_9:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_T61String = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_10:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_UniversalString = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_11:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_UTF8String = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_12:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_VideotexString = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_13:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_VisibleString = p_token;
				break;
			default:
				{
					string[] args = new string[] { "RestrictedCharacterStringType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		public RestrictedCharacterStringType () { }

		// Copy constructor

		public RestrictedCharacterStringType (RestrictedCharacterStringType p_RestrictedCharacterStringType) : base (p_RestrictedCharacterStringType.id, p_RestrictedCharacterStringType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_RestrictedCharacterStringType.appInfo;
			switch ((production_kind) p_RestrictedCharacterStringType.kind)
			{
				case production_kind.g_RestrictedCharacterStringType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_BMPString = (p_RestrictedCharacterStringType.m_BMPString != null) ? new SyntaxTreeToken (p_RestrictedCharacterStringType.m_BMPString) : null) != null) m_BMPString.parent = this;
					break;
				case production_kind.g_RestrictedCharacterStringType_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_GeneralString = (p_RestrictedCharacterStringType.m_GeneralString != null) ? new SyntaxTreeToken (p_RestrictedCharacterStringType.m_GeneralString) : null) != null) m_GeneralString.parent = this;
					break;
				case production_kind.g_RestrictedCharacterStringType_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_GraphicString = (p_RestrictedCharacterStringType.m_GraphicString != null) ? new SyntaxTreeToken (p_RestrictedCharacterStringType.m_GraphicString) : null) != null) m_GraphicString.parent = this;
					break;
				case production_kind.g_RestrictedCharacterStringType_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_IA5String = (p_RestrictedCharacterStringType.m_IA5String != null) ? new SyntaxTreeToken (p_RestrictedCharacterStringType.m_IA5String) : null) != null) m_IA5String.parent = this;
					break;
				case production_kind.g_RestrictedCharacterStringType_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ISO646String = (p_RestrictedCharacterStringType.m_ISO646String != null) ? new SyntaxTreeToken (p_RestrictedCharacterStringType.m_ISO646String) : null) != null) m_ISO646String.parent = this;
					break;
				case production_kind.g_RestrictedCharacterStringType_6:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NumericString = (p_RestrictedCharacterStringType.m_NumericString != null) ? new SyntaxTreeToken (p_RestrictedCharacterStringType.m_NumericString) : null) != null) m_NumericString.parent = this;
					break;
				case production_kind.g_RestrictedCharacterStringType_7:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_PrintableString = (p_RestrictedCharacterStringType.m_PrintableString != null) ? new SyntaxTreeToken (p_RestrictedCharacterStringType.m_PrintableString) : null) != null) m_PrintableString.parent = this;
					break;
				case production_kind.g_RestrictedCharacterStringType_8:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TeletexString = (p_RestrictedCharacterStringType.m_TeletexString != null) ? new SyntaxTreeToken (p_RestrictedCharacterStringType.m_TeletexString) : null) != null) m_TeletexString.parent = this;
					break;
				case production_kind.g_RestrictedCharacterStringType_9:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_T61String = (p_RestrictedCharacterStringType.m_T61String != null) ? new SyntaxTreeToken (p_RestrictedCharacterStringType.m_T61String) : null) != null) m_T61String.parent = this;
					break;
				case production_kind.g_RestrictedCharacterStringType_10:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UniversalString = (p_RestrictedCharacterStringType.m_UniversalString != null) ? new SyntaxTreeToken (p_RestrictedCharacterStringType.m_UniversalString) : null) != null) m_UniversalString.parent = this;
					break;
				case production_kind.g_RestrictedCharacterStringType_11:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UTF8String = (p_RestrictedCharacterStringType.m_UTF8String != null) ? new SyntaxTreeToken (p_RestrictedCharacterStringType.m_UTF8String) : null) != null) m_UTF8String.parent = this;
					break;
				case production_kind.g_RestrictedCharacterStringType_12:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_VideotexString = (p_RestrictedCharacterStringType.m_VideotexString != null) ? new SyntaxTreeToken (p_RestrictedCharacterStringType.m_VideotexString) : null) != null) m_VideotexString.parent = this;
					break;
				case production_kind.g_RestrictedCharacterStringType_13:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_VisibleString = (p_RestrictedCharacterStringType.m_VisibleString != null) ? new SyntaxTreeToken (p_RestrictedCharacterStringType.m_VisibleString) : null) != null) m_VisibleString.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "RestrictedCharacterStringType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new RestrictedCharacterStringType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_BMPString?.Dispose ();
			m_GeneralString?.Dispose ();
			m_GraphicString?.Dispose ();
			m_IA5String?.Dispose ();
			m_ISO646String?.Dispose ();
			m_NumericString?.Dispose ();
			m_PrintableString?.Dispose ();
			m_TeletexString?.Dispose ();
			m_T61String?.Dispose ();
			m_UniversalString?.Dispose ();
			m_UTF8String?.Dispose ();
			m_VideotexString?.Dispose ();
			m_VisibleString?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule RestrictedCharacterStringType

		// Content changing function(s) associated with production(s) of syntax rule RestrictedCharacterStringType

		//
		// Content changing function associated with following production(s)
		// RestrictedCharacterStringType -> BMPString

		// RestrictedCharacterStringType -> GeneralString

		// RestrictedCharacterStringType -> GraphicString

		// RestrictedCharacterStringType -> IA5String

		// RestrictedCharacterStringType -> ISO646String

		// RestrictedCharacterStringType -> NumericString

		// RestrictedCharacterStringType -> PrintableString

		// RestrictedCharacterStringType -> TeletexString

		// RestrictedCharacterStringType -> T61String

		// RestrictedCharacterStringType -> UniversalString

		// RestrictedCharacterStringType -> UTF8String

		// RestrictedCharacterStringType -> VideotexString

		// RestrictedCharacterStringType -> VisibleString

		//

		public void change(SyntaxTreeToken p_token, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_RestrictedCharacterStringType_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_BMPString = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_GeneralString = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_GraphicString = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_4:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_IA5String = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_5:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_ISO646String = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_6:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_NumericString = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_7:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_PrintableString = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_8:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_TeletexString = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_9:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_T61String = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_10:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_UniversalString = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_11:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_UTF8String = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_12:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_VideotexString = p_token;
				break;
			case production_kind.g_RestrictedCharacterStringType_13:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_VisibleString = p_token;
				break;
			default:
				{
					string[] args = new string[] { "RestrictedCharacterStringType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule RestrictedCharacterStringType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_BMPString != null) && m_BMPString.checkInclusion (element) ||
				(m_GeneralString != null) && m_GeneralString.checkInclusion (element) ||
				(m_GraphicString != null) && m_GraphicString.checkInclusion (element) ||
				(m_IA5String != null) && m_IA5String.checkInclusion (element) ||
				(m_ISO646String != null) && m_ISO646String.checkInclusion (element) ||
				(m_NumericString != null) && m_NumericString.checkInclusion (element) ||
				(m_PrintableString != null) && m_PrintableString.checkInclusion (element) ||
				(m_TeletexString != null) && m_TeletexString.checkInclusion (element) ||
				(m_T61String != null) && m_T61String.checkInclusion (element) ||
				(m_UniversalString != null) && m_UniversalString.checkInclusion (element) ||
				(m_UTF8String != null) && m_UTF8String.checkInclusion (element) ||
				(m_VideotexString != null) && m_VideotexString.checkInclusion (element) ||
				(m_VisibleString != null) && m_VisibleString.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule RestrictedCharacterStringType

		//
		// emit production tree node associated with any production of syntax rule RestrictedCharacterStringType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_RestrictedCharacterStringType_1:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: BMPString

					s += m_BMPString.Emit (depth - 1);
				break;
				case production_kind.g_RestrictedCharacterStringType_2:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: GeneralString

					s += m_GeneralString.Emit (depth - 1);
				break;
				case production_kind.g_RestrictedCharacterStringType_3:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: GraphicString

					s += m_GraphicString.Emit (depth - 1);
				break;
				case production_kind.g_RestrictedCharacterStringType_4:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: IA5String

					s += m_IA5String.Emit (depth - 1);
				break;
				case production_kind.g_RestrictedCharacterStringType_5:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: ISO646String

					s += m_ISO646String.Emit (depth - 1);
				break;
				case production_kind.g_RestrictedCharacterStringType_6:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: NumericString

					s += m_NumericString.Emit (depth - 1);
				break;
				case production_kind.g_RestrictedCharacterStringType_7:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: PrintableString

					s += m_PrintableString.Emit (depth - 1);
				break;
				case production_kind.g_RestrictedCharacterStringType_8:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: TeletexString

					s += m_TeletexString.Emit (depth - 1);
				break;
				case production_kind.g_RestrictedCharacterStringType_9:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: T61String

					s += m_T61String.Emit (depth - 1);
				break;
				case production_kind.g_RestrictedCharacterStringType_10:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: UniversalString

					s += m_UniversalString.Emit (depth - 1);
				break;
				case production_kind.g_RestrictedCharacterStringType_11:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: UTF8String

					s += m_UTF8String.Emit (depth - 1);
				break;
				case production_kind.g_RestrictedCharacterStringType_12:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: VideotexString

					s += m_VideotexString.Emit (depth - 1);
				break;
				case production_kind.g_RestrictedCharacterStringType_13:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: VisibleString

					s += m_VisibleString.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule RestrictedCharacterStringType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "RestrictedCharacterStringType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_RestrictedCharacterStringType_1:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: BMPString

					s += "BMPString";
				break;
				case production_kind.g_RestrictedCharacterStringType_2:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: GeneralString

					s += "GeneralString";
				break;
				case production_kind.g_RestrictedCharacterStringType_3:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: GraphicString

					s += "GraphicString";
				break;
				case production_kind.g_RestrictedCharacterStringType_4:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: IA5String

					s += "IA5String";
				break;
				case production_kind.g_RestrictedCharacterStringType_5:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: ISO646String

					s += "ISO646String";
				break;
				case production_kind.g_RestrictedCharacterStringType_6:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: NumericString

					s += "NumericString";
				break;
				case production_kind.g_RestrictedCharacterStringType_7:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: PrintableString

					s += "PrintableString";
				break;
				case production_kind.g_RestrictedCharacterStringType_8:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: TeletexString

					s += "TeletexString";
				break;
				case production_kind.g_RestrictedCharacterStringType_9:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: T61String

					s += "T61String";
				break;
				case production_kind.g_RestrictedCharacterStringType_10:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: UniversalString

					s += "UniversalString";
				break;
				case production_kind.g_RestrictedCharacterStringType_11:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: UTF8String

					s += "UTF8String";
				break;
				case production_kind.g_RestrictedCharacterStringType_12:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: VideotexString

					s += "VideotexString";
				break;
				case production_kind.g_RestrictedCharacterStringType_13:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringType: VisibleString

					s += "VisibleString";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule RestrictedCharacterStringType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule RestrictedCharacterStringType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			RestrictedCharacterStringType.production_kind kind = (RestrictedCharacterStringType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_1:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: BMPString

						m_BMPString.Visit (visitor, appData);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_2:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: GeneralString

						m_GeneralString.Visit (visitor, appData);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_3:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: GraphicString

						m_GraphicString.Visit (visitor, appData);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_4:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: IA5String

						m_IA5String.Visit (visitor, appData);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_5:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: ISO646String

						m_ISO646String.Visit (visitor, appData);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_6:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: NumericString

						m_NumericString.Visit (visitor, appData);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_7:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: PrintableString

						m_PrintableString.Visit (visitor, appData);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_8:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: TeletexString

						m_TeletexString.Visit (visitor, appData);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_9:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: T61String

						m_T61String.Visit (visitor, appData);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_10:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: UniversalString

						m_UniversalString.Visit (visitor, appData);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_11:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: UTF8String

						m_UTF8String.Visit (visitor, appData);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_12:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: VideotexString

						m_VideotexString.Visit (visitor, appData);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_13:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: VisibleString

						m_VisibleString.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_BMPString?.reparent (this);
			m_GeneralString?.reparent (this);
			m_GraphicString?.reparent (this);
			m_IA5String?.reparent (this);
			m_ISO646String?.reparent (this);
			m_NumericString?.reparent (this);
			m_PrintableString?.reparent (this);
			m_TeletexString?.reparent (this);
			m_T61String?.reparent (this);
			m_UniversalString?.reparent (this);
			m_UTF8String?.reparent (this);
			m_VideotexString?.reparent (this);
			m_VisibleString?.reparent (this);
		}

		//
		// initialize object associated with syntax rule RestrictedCharacterStringType
		//

		public void _init ()
		{
			m_BMPString = null;
			m_GeneralString = null;
			m_GraphicString = null;
			m_IA5String = null;
			m_ISO646String = null;
			m_NumericString = null;
			m_PrintableString = null;
			m_TeletexString = null;
			m_T61String = null;
			m_UniversalString = null;
			m_UTF8String = null;
			m_VideotexString = null;
			m_VisibleString = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule RestrictedCharacterStringType

		// counter of all nodes associated with syntax rule RestrictedCharacterStringType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule RestrictedCharacterStringType
		[DataMember (Name = "m_BMPString")] public SyntaxTreeToken m_BMPString { get; private set; }
		[DataMember (Name = "m_GeneralString")] public SyntaxTreeToken m_GeneralString { get; private set; }
		[DataMember (Name = "m_GraphicString")] public SyntaxTreeToken m_GraphicString { get; private set; }
		[DataMember (Name = "m_IA5String")] public SyntaxTreeToken m_IA5String { get; private set; }
		[DataMember (Name = "m_ISO646String")] public SyntaxTreeToken m_ISO646String { get; private set; }
		[DataMember (Name = "m_NumericString")] public SyntaxTreeToken m_NumericString { get; private set; }
		[DataMember (Name = "m_PrintableString")] public SyntaxTreeToken m_PrintableString { get; private set; }
		[DataMember (Name = "m_TeletexString")] public SyntaxTreeToken m_TeletexString { get; private set; }
		[DataMember (Name = "m_T61String")] public SyntaxTreeToken m_T61String { get; private set; }
		[DataMember (Name = "m_UniversalString")] public SyntaxTreeToken m_UniversalString { get; private set; }
		[DataMember (Name = "m_UTF8String")] public SyntaxTreeToken m_UTF8String { get; private set; }
		[DataMember (Name = "m_VideotexString")] public SyntaxTreeToken m_VideotexString { get; private set; }
		[DataMember (Name = "m_VisibleString")] public SyntaxTreeToken m_VisibleString { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule RestrictedCharacterStringType

		// delegate function (callback) prototype associated with syntax rule RestrictedCharacterStringType
		public delegate bool RestrictedCharacterStringType_Callback (SyntaxTreeCallbackReason reason, RestrictedCharacterStringType.production_kind kind, RestrictedCharacterStringType p_RestrictedCharacterStringType);

		// event associated with syntax rule RestrictedCharacterStringType
		public event RestrictedCharacterStringType_Callback RestrictedCharacterStringType_Event;

		// event trigger associated with syntax rule RestrictedCharacterStringType
		public bool Raise_RestrictedCharacterStringType_Event (SyntaxTreeCallbackReason reason, RestrictedCharacterStringType.production_kind kind, RestrictedCharacterStringType p_RestrictedCharacterStringType)
		{
			bool? status = RestrictedCharacterStringType_Event?.Invoke (reason, kind, p_RestrictedCharacterStringType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule RestrictedCharacterStringType
		//
		// traverse syntax tree node associated with any production of syntax rule RestrictedCharacterStringType
		//

		public void Traverse (RestrictedCharacterStringType p_RestrictedCharacterStringType)
		{
			if (p_RestrictedCharacterStringType.isLocked())
				return;
			p_RestrictedCharacterStringType.dolock();
			RestrictedCharacterStringType.production_kind kind = (RestrictedCharacterStringType.production_kind) p_RestrictedCharacterStringType.kind;
			p_RestrictedCharacterStringType.turn_reset ();
			if (Raise_RestrictedCharacterStringType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_RestrictedCharacterStringType))
			switch (kind)
			{
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_1:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: BMPString

				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_2:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: GeneralString

				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_3:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: GraphicString

				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_4:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: IA5String

				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_5:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: ISO646String

				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_6:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: NumericString

				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_7:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: PrintableString

				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_8:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: TeletexString

				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_9:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: T61String

				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_10:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: UniversalString

				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_11:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: UTF8String

				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_12:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: VideotexString

				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_13:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: VisibleString

				break;
			}
			Raise_RestrictedCharacterStringType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_RestrictedCharacterStringType);
			p_RestrictedCharacterStringType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule RestrictedCharacterStringType
		//

		public void TraverseCommon (RestrictedCharacterStringType p_RestrictedCharacterStringType)
		{
			RestrictedCharacterStringType.production_kind kind = (RestrictedCharacterStringType.production_kind) p_RestrictedCharacterStringType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_RestrictedCharacterStringType))
			switch (kind)
			{
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_1:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: BMPString

						TraverseCommon (p_RestrictedCharacterStringType.m_BMPString);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_2:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: GeneralString

						TraverseCommon (p_RestrictedCharacterStringType.m_GeneralString);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_3:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: GraphicString

						TraverseCommon (p_RestrictedCharacterStringType.m_GraphicString);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_4:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: IA5String

						TraverseCommon (p_RestrictedCharacterStringType.m_IA5String);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_5:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: ISO646String

						TraverseCommon (p_RestrictedCharacterStringType.m_ISO646String);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_6:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: NumericString

						TraverseCommon (p_RestrictedCharacterStringType.m_NumericString);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_7:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: PrintableString

						TraverseCommon (p_RestrictedCharacterStringType.m_PrintableString);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_8:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: TeletexString

						TraverseCommon (p_RestrictedCharacterStringType.m_TeletexString);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_9:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: T61String

						TraverseCommon (p_RestrictedCharacterStringType.m_T61String);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_10:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: UniversalString

						TraverseCommon (p_RestrictedCharacterStringType.m_UniversalString);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_11:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: UTF8String

						TraverseCommon (p_RestrictedCharacterStringType.m_UTF8String);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_12:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: VideotexString

						TraverseCommon (p_RestrictedCharacterStringType.m_VideotexString);
				break;
				case RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_13:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringType: VisibleString

						TraverseCommon (p_RestrictedCharacterStringType.m_VisibleString);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_RestrictedCharacterStringType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule RestrictedCharacterStringType

		//
		// create syntax tree node associated with production
		// RestrictedCharacterStringType: BMPString

		//

		public RestrictedCharacterStringType RestrictedCharacterStringType_1 (SyntaxTreeToken p_token)
		{
			RestrictedCharacterStringType p_RestrictedCharacterStringType_ref = new RestrictedCharacterStringType(p_token, 1);
			p_token.parent = p_RestrictedCharacterStringType_ref;
			Raise_RestrictedCharacterStringType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_1, p_RestrictedCharacterStringType_ref);
			return p_RestrictedCharacterStringType_ref;
		}

		//
		// create syntax tree node associated with production
		// RestrictedCharacterStringType: GeneralString

		//

		public RestrictedCharacterStringType RestrictedCharacterStringType_2 (SyntaxTreeToken p_token)
		{
			RestrictedCharacterStringType p_RestrictedCharacterStringType_ref = new RestrictedCharacterStringType(p_token, 2);
			p_token.parent = p_RestrictedCharacterStringType_ref;
			Raise_RestrictedCharacterStringType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_2, p_RestrictedCharacterStringType_ref);
			return p_RestrictedCharacterStringType_ref;
		}

		//
		// create syntax tree node associated with production
		// RestrictedCharacterStringType: GraphicString

		//

		public RestrictedCharacterStringType RestrictedCharacterStringType_3 (SyntaxTreeToken p_token)
		{
			RestrictedCharacterStringType p_RestrictedCharacterStringType_ref = new RestrictedCharacterStringType(p_token, 3);
			p_token.parent = p_RestrictedCharacterStringType_ref;
			Raise_RestrictedCharacterStringType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_3, p_RestrictedCharacterStringType_ref);
			return p_RestrictedCharacterStringType_ref;
		}

		//
		// create syntax tree node associated with production
		// RestrictedCharacterStringType: IA5String

		//

		public RestrictedCharacterStringType RestrictedCharacterStringType_4 (SyntaxTreeToken p_token)
		{
			RestrictedCharacterStringType p_RestrictedCharacterStringType_ref = new RestrictedCharacterStringType(p_token, 4);
			p_token.parent = p_RestrictedCharacterStringType_ref;
			Raise_RestrictedCharacterStringType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_4, p_RestrictedCharacterStringType_ref);
			return p_RestrictedCharacterStringType_ref;
		}

		//
		// create syntax tree node associated with production
		// RestrictedCharacterStringType: ISO646String

		//

		public RestrictedCharacterStringType RestrictedCharacterStringType_5 (SyntaxTreeToken p_token)
		{
			RestrictedCharacterStringType p_RestrictedCharacterStringType_ref = new RestrictedCharacterStringType(p_token, 5);
			p_token.parent = p_RestrictedCharacterStringType_ref;
			Raise_RestrictedCharacterStringType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_5, p_RestrictedCharacterStringType_ref);
			return p_RestrictedCharacterStringType_ref;
		}

		//
		// create syntax tree node associated with production
		// RestrictedCharacterStringType: NumericString

		//

		public RestrictedCharacterStringType RestrictedCharacterStringType_6 (SyntaxTreeToken p_token)
		{
			RestrictedCharacterStringType p_RestrictedCharacterStringType_ref = new RestrictedCharacterStringType(p_token, 6);
			p_token.parent = p_RestrictedCharacterStringType_ref;
			Raise_RestrictedCharacterStringType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_6, p_RestrictedCharacterStringType_ref);
			return p_RestrictedCharacterStringType_ref;
		}

		//
		// create syntax tree node associated with production
		// RestrictedCharacterStringType: PrintableString

		//

		public RestrictedCharacterStringType RestrictedCharacterStringType_7 (SyntaxTreeToken p_token)
		{
			RestrictedCharacterStringType p_RestrictedCharacterStringType_ref = new RestrictedCharacterStringType(p_token, 7);
			p_token.parent = p_RestrictedCharacterStringType_ref;
			Raise_RestrictedCharacterStringType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_7, p_RestrictedCharacterStringType_ref);
			return p_RestrictedCharacterStringType_ref;
		}

		//
		// create syntax tree node associated with production
		// RestrictedCharacterStringType: TeletexString

		//

		public RestrictedCharacterStringType RestrictedCharacterStringType_8 (SyntaxTreeToken p_token)
		{
			RestrictedCharacterStringType p_RestrictedCharacterStringType_ref = new RestrictedCharacterStringType(p_token, 8);
			p_token.parent = p_RestrictedCharacterStringType_ref;
			Raise_RestrictedCharacterStringType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_8, p_RestrictedCharacterStringType_ref);
			return p_RestrictedCharacterStringType_ref;
		}

		//
		// create syntax tree node associated with production
		// RestrictedCharacterStringType: T61String

		//

		public RestrictedCharacterStringType RestrictedCharacterStringType_9 (SyntaxTreeToken p_token)
		{
			RestrictedCharacterStringType p_RestrictedCharacterStringType_ref = new RestrictedCharacterStringType(p_token, 9);
			p_token.parent = p_RestrictedCharacterStringType_ref;
			Raise_RestrictedCharacterStringType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_9, p_RestrictedCharacterStringType_ref);
			return p_RestrictedCharacterStringType_ref;
		}

		//
		// create syntax tree node associated with production
		// RestrictedCharacterStringType: UniversalString

		//

		public RestrictedCharacterStringType RestrictedCharacterStringType_10 (SyntaxTreeToken p_token)
		{
			RestrictedCharacterStringType p_RestrictedCharacterStringType_ref = new RestrictedCharacterStringType(p_token, 10);
			p_token.parent = p_RestrictedCharacterStringType_ref;
			Raise_RestrictedCharacterStringType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_10, p_RestrictedCharacterStringType_ref);
			return p_RestrictedCharacterStringType_ref;
		}

		//
		// create syntax tree node associated with production
		// RestrictedCharacterStringType: UTF8String

		//

		public RestrictedCharacterStringType RestrictedCharacterStringType_11 (SyntaxTreeToken p_token)
		{
			RestrictedCharacterStringType p_RestrictedCharacterStringType_ref = new RestrictedCharacterStringType(p_token, 11);
			p_token.parent = p_RestrictedCharacterStringType_ref;
			Raise_RestrictedCharacterStringType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_11, p_RestrictedCharacterStringType_ref);
			return p_RestrictedCharacterStringType_ref;
		}

		//
		// create syntax tree node associated with production
		// RestrictedCharacterStringType: VideotexString

		//

		public RestrictedCharacterStringType RestrictedCharacterStringType_12 (SyntaxTreeToken p_token)
		{
			RestrictedCharacterStringType p_RestrictedCharacterStringType_ref = new RestrictedCharacterStringType(p_token, 12);
			p_token.parent = p_RestrictedCharacterStringType_ref;
			Raise_RestrictedCharacterStringType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_12, p_RestrictedCharacterStringType_ref);
			return p_RestrictedCharacterStringType_ref;
		}

		//
		// create syntax tree node associated with production
		// RestrictedCharacterStringType: VisibleString

		//

		public RestrictedCharacterStringType RestrictedCharacterStringType_13 (SyntaxTreeToken p_token)
		{
			RestrictedCharacterStringType p_RestrictedCharacterStringType_ref = new RestrictedCharacterStringType(p_token, 13);
			p_token.parent = p_RestrictedCharacterStringType_ref;
			Raise_RestrictedCharacterStringType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RestrictedCharacterStringType.production_kind.g_RestrictedCharacterStringType_13, p_RestrictedCharacterStringType_ref);
			return p_RestrictedCharacterStringType_ref;
		}
		#endregion
	};
}
