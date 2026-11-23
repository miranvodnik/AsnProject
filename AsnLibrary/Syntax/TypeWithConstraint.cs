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
	// class associated with syntax rule TypeWithConstraint
	//

	[DataContract]
	public class	TypeWithConstraint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TypeWithConstraint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TypeWithConstraint
		{
			g_TypeWithConstraint_1 = 1,	// SET Constraint OF Type

			g_TypeWithConstraint_2 = 2,	// SET SizeConstraint OF Type

			g_TypeWithConstraint_3 = 3,	// SEQUENCE Constraint OF Type

			g_TypeWithConstraint_4 = 4,	// SEQUENCE SizeConstraint OF Type

			g_TypeWithConstraint_5 = 5,	// SET Constraint OF NamedType

			g_TypeWithConstraint_6 = 6,	// SET SizeConstraint OF NamedType

			g_TypeWithConstraint_7 = 7,	// SEQUENCE Constraint OF NamedType

			g_TypeWithConstraint_8 = 8,	// SEQUENCE SizeConstraint OF NamedType

		};
		#endregion
		#region production markers associated with the syntax rule TypeWithConstraint

		// markers associated with production: TypeWithConstraint -> SET Constraint OF Type

		public enum production_marker_1 : ushort
		{
			m_Constraint,
			m_Type,
			final
		};

		// markers associated with production: TypeWithConstraint -> SET SizeConstraint OF Type

		public enum production_marker_2 : ushort
		{
			m_SizeConstraint,
			m_Type,
			final
		};

		// markers associated with production: TypeWithConstraint -> SEQUENCE Constraint OF Type

		public enum production_marker_3 : ushort
		{
			m_Constraint,
			m_Type,
			final
		};

		// markers associated with production: TypeWithConstraint -> SEQUENCE SizeConstraint OF Type

		public enum production_marker_4 : ushort
		{
			m_SizeConstraint,
			m_Type,
			final
		};

		// markers associated with production: TypeWithConstraint -> SET Constraint OF NamedType

		public enum production_marker_5 : ushort
		{
			m_Constraint,
			m_NamedType,
			final
		};

		// markers associated with production: TypeWithConstraint -> SET SizeConstraint OF NamedType

		public enum production_marker_6 : ushort
		{
			m_SizeConstraint,
			m_NamedType,
			final
		};

		// markers associated with production: TypeWithConstraint -> SEQUENCE Constraint OF NamedType

		public enum production_marker_7 : ushort
		{
			m_Constraint,
			m_NamedType,
			final
		};

		// markers associated with production: TypeWithConstraint -> SEQUENCE SizeConstraint OF NamedType

		public enum production_marker_8 : ushort
		{
			m_SizeConstraint,
			m_NamedType,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TypeWithConstraint

		// Constructor declaration(s) associated with production(s) of syntax rule TypeWithConstraint

		//
		// Constructor associated with the following production(s)
		// TypeWithConstraint -> SET Constraint OF Type

		// TypeWithConstraint -> SEQUENCE Constraint OF Type

		//

		public TypeWithConstraint (SyntaxTreeToken p_token, Constraint p_Constraint, SyntaxTreeToken p_token_1, Type p_Type, int kind) : base ((uint) ProductionID._TypeWithConstraint_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_TypeWithConstraint_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
				children[0] = m_SET = p_token;
				children[1] = m_Constraint = p_Constraint;
				children[2] = m_OF = p_token_1;
				children[3] = m_Type = p_Type;
				break;
			case production_kind.g_TypeWithConstraint_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
				children[0] = m_SEQUENCE = p_token;
				children[1] = m_Constraint = p_Constraint;
				children[2] = m_OF = p_token_1;
				children[3] = m_Type = p_Type;
				break;
			default:
				{
					string[] args = new string[] { "TypeWithConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		//
		// Constructor associated with the following production(s)
		// TypeWithConstraint -> SET SizeConstraint OF Type

		// TypeWithConstraint -> SEQUENCE SizeConstraint OF Type

		//

		public TypeWithConstraint (SyntaxTreeToken p_token, SizeConstraint p_SizeConstraint, SyntaxTreeToken p_token_1, Type p_Type, int kind) : base ((uint) ProductionID._TypeWithConstraint_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_TypeWithConstraint_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
				children[0] = m_SET = p_token;
				children[1] = m_SizeConstraint = p_SizeConstraint;
				children[2] = m_OF = p_token_1;
				children[3] = m_Type = p_Type;
				break;
			case production_kind.g_TypeWithConstraint_4:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
				children[0] = m_SEQUENCE = p_token;
				children[1] = m_SizeConstraint = p_SizeConstraint;
				children[2] = m_OF = p_token_1;
				children[3] = m_Type = p_Type;
				break;
			default:
				{
					string[] args = new string[] { "TypeWithConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		//
		// Constructor associated with the following production(s)
		// TypeWithConstraint -> SET Constraint OF NamedType

		// TypeWithConstraint -> SEQUENCE Constraint OF NamedType

		//

		public TypeWithConstraint (SyntaxTreeToken p_token, Constraint p_Constraint, SyntaxTreeToken p_token_1, NamedType p_NamedType, int kind) : base ((uint) ProductionID._TypeWithConstraint_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_TypeWithConstraint_5:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
				children[0] = m_SET = p_token;
				children[1] = m_Constraint = p_Constraint;
				children[2] = m_OF = p_token_1;
				children[3] = m_NamedType = p_NamedType;
				break;
			case production_kind.g_TypeWithConstraint_7:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
				children[0] = m_SEQUENCE = p_token;
				children[1] = m_Constraint = p_Constraint;
				children[2] = m_OF = p_token_1;
				children[3] = m_NamedType = p_NamedType;
				break;
			default:
				{
					string[] args = new string[] { "TypeWithConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		//
		// Constructor associated with the following production(s)
		// TypeWithConstraint -> SET SizeConstraint OF NamedType

		// TypeWithConstraint -> SEQUENCE SizeConstraint OF NamedType

		//

		public TypeWithConstraint (SyntaxTreeToken p_token, SizeConstraint p_SizeConstraint, SyntaxTreeToken p_token_1, NamedType p_NamedType, int kind) : base ((uint) ProductionID._TypeWithConstraint_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_TypeWithConstraint_6:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
				children[0] = m_SET = p_token;
				children[1] = m_SizeConstraint = p_SizeConstraint;
				children[2] = m_OF = p_token_1;
				children[3] = m_NamedType = p_NamedType;
				break;
			case production_kind.g_TypeWithConstraint_8:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
				children[0] = m_SEQUENCE = p_token;
				children[1] = m_SizeConstraint = p_SizeConstraint;
				children[2] = m_OF = p_token_1;
				children[3] = m_NamedType = p_NamedType;
				break;
			default:
				{
					string[] args = new string[] { "TypeWithConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		public TypeWithConstraint () { }

		// Copy constructor

		public TypeWithConstraint (TypeWithConstraint p_TypeWithConstraint) : base (p_TypeWithConstraint.id, p_TypeWithConstraint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TypeWithConstraint.appInfo;
			switch ((production_kind) p_TypeWithConstraint.kind)
			{
				case production_kind.g_TypeWithConstraint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_SET = (p_TypeWithConstraint.m_SET != null) ? new SyntaxTreeToken (p_TypeWithConstraint.m_SET) : null) != null) m_SET.parent = this;
					if ((children [1] = m_Constraint = (p_TypeWithConstraint.m_Constraint != null) ? new Constraint (p_TypeWithConstraint.m_Constraint) : null) != null) m_Constraint.parent = this;
					if ((children [2] = m_OF = (p_TypeWithConstraint.m_OF != null) ? new SyntaxTreeToken (p_TypeWithConstraint.m_OF) : null) != null) m_OF.parent = this;
					if ((children [3] = m_Type = (p_TypeWithConstraint.m_Type != null) ? new Type (p_TypeWithConstraint.m_Type) : null) != null) m_Type.parent = this;
					break;
				case production_kind.g_TypeWithConstraint_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_SEQUENCE = (p_TypeWithConstraint.m_SEQUENCE != null) ? new SyntaxTreeToken (p_TypeWithConstraint.m_SEQUENCE) : null) != null) m_SEQUENCE.parent = this;
					if ((children [1] = m_Constraint = (p_TypeWithConstraint.m_Constraint != null) ? new Constraint (p_TypeWithConstraint.m_Constraint) : null) != null) m_Constraint.parent = this;
					if ((children [2] = m_OF = (p_TypeWithConstraint.m_OF != null) ? new SyntaxTreeToken (p_TypeWithConstraint.m_OF) : null) != null) m_OF.parent = this;
					if ((children [3] = m_Type = (p_TypeWithConstraint.m_Type != null) ? new Type (p_TypeWithConstraint.m_Type) : null) != null) m_Type.parent = this;
					break;
				case production_kind.g_TypeWithConstraint_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_SET = (p_TypeWithConstraint.m_SET != null) ? new SyntaxTreeToken (p_TypeWithConstraint.m_SET) : null) != null) m_SET.parent = this;
					if ((children [1] = m_SizeConstraint = (p_TypeWithConstraint.m_SizeConstraint != null) ? new SizeConstraint (p_TypeWithConstraint.m_SizeConstraint) : null) != null) m_SizeConstraint.parent = this;
					if ((children [2] = m_OF = (p_TypeWithConstraint.m_OF != null) ? new SyntaxTreeToken (p_TypeWithConstraint.m_OF) : null) != null) m_OF.parent = this;
					if ((children [3] = m_Type = (p_TypeWithConstraint.m_Type != null) ? new Type (p_TypeWithConstraint.m_Type) : null) != null) m_Type.parent = this;
					break;
				case production_kind.g_TypeWithConstraint_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_SEQUENCE = (p_TypeWithConstraint.m_SEQUENCE != null) ? new SyntaxTreeToken (p_TypeWithConstraint.m_SEQUENCE) : null) != null) m_SEQUENCE.parent = this;
					if ((children [1] = m_SizeConstraint = (p_TypeWithConstraint.m_SizeConstraint != null) ? new SizeConstraint (p_TypeWithConstraint.m_SizeConstraint) : null) != null) m_SizeConstraint.parent = this;
					if ((children [2] = m_OF = (p_TypeWithConstraint.m_OF != null) ? new SyntaxTreeToken (p_TypeWithConstraint.m_OF) : null) != null) m_OF.parent = this;
					if ((children [3] = m_Type = (p_TypeWithConstraint.m_Type != null) ? new Type (p_TypeWithConstraint.m_Type) : null) != null) m_Type.parent = this;
					break;
				case production_kind.g_TypeWithConstraint_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_SET = (p_TypeWithConstraint.m_SET != null) ? new SyntaxTreeToken (p_TypeWithConstraint.m_SET) : null) != null) m_SET.parent = this;
					if ((children [1] = m_Constraint = (p_TypeWithConstraint.m_Constraint != null) ? new Constraint (p_TypeWithConstraint.m_Constraint) : null) != null) m_Constraint.parent = this;
					if ((children [2] = m_OF = (p_TypeWithConstraint.m_OF != null) ? new SyntaxTreeToken (p_TypeWithConstraint.m_OF) : null) != null) m_OF.parent = this;
					if ((children [3] = m_NamedType = (p_TypeWithConstraint.m_NamedType != null) ? new NamedType (p_TypeWithConstraint.m_NamedType) : null) != null) m_NamedType.parent = this;
					break;
				case production_kind.g_TypeWithConstraint_7:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_SEQUENCE = (p_TypeWithConstraint.m_SEQUENCE != null) ? new SyntaxTreeToken (p_TypeWithConstraint.m_SEQUENCE) : null) != null) m_SEQUENCE.parent = this;
					if ((children [1] = m_Constraint = (p_TypeWithConstraint.m_Constraint != null) ? new Constraint (p_TypeWithConstraint.m_Constraint) : null) != null) m_Constraint.parent = this;
					if ((children [2] = m_OF = (p_TypeWithConstraint.m_OF != null) ? new SyntaxTreeToken (p_TypeWithConstraint.m_OF) : null) != null) m_OF.parent = this;
					if ((children [3] = m_NamedType = (p_TypeWithConstraint.m_NamedType != null) ? new NamedType (p_TypeWithConstraint.m_NamedType) : null) != null) m_NamedType.parent = this;
					break;
				case production_kind.g_TypeWithConstraint_6:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_SET = (p_TypeWithConstraint.m_SET != null) ? new SyntaxTreeToken (p_TypeWithConstraint.m_SET) : null) != null) m_SET.parent = this;
					if ((children [1] = m_SizeConstraint = (p_TypeWithConstraint.m_SizeConstraint != null) ? new SizeConstraint (p_TypeWithConstraint.m_SizeConstraint) : null) != null) m_SizeConstraint.parent = this;
					if ((children [2] = m_OF = (p_TypeWithConstraint.m_OF != null) ? new SyntaxTreeToken (p_TypeWithConstraint.m_OF) : null) != null) m_OF.parent = this;
					if ((children [3] = m_NamedType = (p_TypeWithConstraint.m_NamedType != null) ? new NamedType (p_TypeWithConstraint.m_NamedType) : null) != null) m_NamedType.parent = this;
					break;
				case production_kind.g_TypeWithConstraint_8:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_SEQUENCE = (p_TypeWithConstraint.m_SEQUENCE != null) ? new SyntaxTreeToken (p_TypeWithConstraint.m_SEQUENCE) : null) != null) m_SEQUENCE.parent = this;
					if ((children [1] = m_SizeConstraint = (p_TypeWithConstraint.m_SizeConstraint != null) ? new SizeConstraint (p_TypeWithConstraint.m_SizeConstraint) : null) != null) m_SizeConstraint.parent = this;
					if ((children [2] = m_OF = (p_TypeWithConstraint.m_OF != null) ? new SyntaxTreeToken (p_TypeWithConstraint.m_OF) : null) != null) m_OF.parent = this;
					if ((children [3] = m_NamedType = (p_TypeWithConstraint.m_NamedType != null) ? new NamedType (p_TypeWithConstraint.m_NamedType) : null) != null) m_NamedType.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TypeWithConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TypeWithConstraint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SET?.Dispose ();
			m_Constraint?.Dispose ();
			m_OF?.Dispose ();
			m_Type?.Dispose ();
			m_SizeConstraint?.Dispose ();
			m_SEQUENCE?.Dispose ();
			m_NamedType?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TypeWithConstraint

		// Content changing function(s) associated with production(s) of syntax rule TypeWithConstraint

		//
		// Content changing function associated with following production(s)
		// TypeWithConstraint -> SET Constraint OF Type

		// TypeWithConstraint -> SEQUENCE Constraint OF Type

		//

		public void change(SyntaxTreeToken p_token, Constraint p_Constraint, SyntaxTreeToken p_token_1, Type p_Type, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_TypeWithConstraint_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
				children [0] = m_SET = p_token;
				children [1] = m_Constraint = p_Constraint;
				children [2] = m_OF = p_token_1;
				children [3] = m_Type = p_Type;
				break;
			case production_kind.g_TypeWithConstraint_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
				children [0] = m_SEQUENCE = p_token;
				children [1] = m_Constraint = p_Constraint;
				children [2] = m_OF = p_token_1;
				children [3] = m_Type = p_Type;
				break;
			default:
				{
					string[] args = new string[] { "TypeWithConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TypeWithConstraint -> SET SizeConstraint OF Type

		// TypeWithConstraint -> SEQUENCE SizeConstraint OF Type

		//

		public void change(SyntaxTreeToken p_token, SizeConstraint p_SizeConstraint, SyntaxTreeToken p_token_1, Type p_Type, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_TypeWithConstraint_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
				children [0] = m_SET = p_token;
				children [1] = m_SizeConstraint = p_SizeConstraint;
				children [2] = m_OF = p_token_1;
				children [3] = m_Type = p_Type;
				break;
			case production_kind.g_TypeWithConstraint_4:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
				children [0] = m_SEQUENCE = p_token;
				children [1] = m_SizeConstraint = p_SizeConstraint;
				children [2] = m_OF = p_token_1;
				children [3] = m_Type = p_Type;
				break;
			default:
				{
					string[] args = new string[] { "TypeWithConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TypeWithConstraint -> SET Constraint OF NamedType

		// TypeWithConstraint -> SEQUENCE Constraint OF NamedType

		//

		public void change(SyntaxTreeToken p_token, Constraint p_Constraint, SyntaxTreeToken p_token_1, NamedType p_NamedType, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_TypeWithConstraint_5:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
				children [0] = m_SET = p_token;
				children [1] = m_Constraint = p_Constraint;
				children [2] = m_OF = p_token_1;
				children [3] = m_NamedType = p_NamedType;
				break;
			case production_kind.g_TypeWithConstraint_7:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
				children [0] = m_SEQUENCE = p_token;
				children [1] = m_Constraint = p_Constraint;
				children [2] = m_OF = p_token_1;
				children [3] = m_NamedType = p_NamedType;
				break;
			default:
				{
					string[] args = new string[] { "TypeWithConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TypeWithConstraint -> SET SizeConstraint OF NamedType

		// TypeWithConstraint -> SEQUENCE SizeConstraint OF NamedType

		//

		public void change(SyntaxTreeToken p_token, SizeConstraint p_SizeConstraint, SyntaxTreeToken p_token_1, NamedType p_NamedType, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_TypeWithConstraint_6:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
				children [0] = m_SET = p_token;
				children [1] = m_SizeConstraint = p_SizeConstraint;
				children [2] = m_OF = p_token_1;
				children [3] = m_NamedType = p_NamedType;
				break;
			case production_kind.g_TypeWithConstraint_8:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
				children [0] = m_SEQUENCE = p_token;
				children [1] = m_SizeConstraint = p_SizeConstraint;
				children [2] = m_OF = p_token_1;
				children [3] = m_NamedType = p_NamedType;
				break;
			default:
				{
					string[] args = new string[] { "TypeWithConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TypeWithConstraint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SET != null) && m_SET.checkInclusion (element) ||
				(m_Constraint != null) && m_Constraint.checkInclusion (element) ||
				(m_OF != null) && m_OF.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_SizeConstraint != null) && m_SizeConstraint.checkInclusion (element) ||
				(m_SEQUENCE != null) && m_SEQUENCE.checkInclusion (element) ||
				(m_NamedType != null) && m_NamedType.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TypeWithConstraint

		//
		// emit production tree node associated with any production of syntax rule TypeWithConstraint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TypeWithConstraint_1:
					// emit syntax tree node associated with production
					// TypeWithConstraint: SET Constraint OF Type

					s += m_SET.Emit (depth - 1);
					s += " ";
					s += m_Constraint.Emit (depth - 1);
					s += " ";
					s += m_OF.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
				break;
				case production_kind.g_TypeWithConstraint_2:
					// emit syntax tree node associated with production
					// TypeWithConstraint: SET SizeConstraint OF Type

					s += m_SET.Emit (depth - 1);
					s += " ";
					s += m_SizeConstraint.Emit (depth - 1);
					s += " ";
					s += m_OF.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
				break;
				case production_kind.g_TypeWithConstraint_3:
					// emit syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE Constraint OF Type

					s += m_SEQUENCE.Emit (depth - 1);
					s += " ";
					s += m_Constraint.Emit (depth - 1);
					s += " ";
					s += m_OF.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
				break;
				case production_kind.g_TypeWithConstraint_4:
					// emit syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE SizeConstraint OF Type

					s += m_SEQUENCE.Emit (depth - 1);
					s += " ";
					s += m_SizeConstraint.Emit (depth - 1);
					s += " ";
					s += m_OF.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
				break;
				case production_kind.g_TypeWithConstraint_5:
					// emit syntax tree node associated with production
					// TypeWithConstraint: SET Constraint OF NamedType

					s += m_SET.Emit (depth - 1);
					s += " ";
					s += m_Constraint.Emit (depth - 1);
					s += " ";
					s += m_OF.Emit (depth - 1);
					s += " ";
					s += m_NamedType.Emit (depth - 1);
				break;
				case production_kind.g_TypeWithConstraint_6:
					// emit syntax tree node associated with production
					// TypeWithConstraint: SET SizeConstraint OF NamedType

					s += m_SET.Emit (depth - 1);
					s += " ";
					s += m_SizeConstraint.Emit (depth - 1);
					s += " ";
					s += m_OF.Emit (depth - 1);
					s += " ";
					s += m_NamedType.Emit (depth - 1);
				break;
				case production_kind.g_TypeWithConstraint_7:
					// emit syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE Constraint OF NamedType

					s += m_SEQUENCE.Emit (depth - 1);
					s += " ";
					s += m_Constraint.Emit (depth - 1);
					s += " ";
					s += m_OF.Emit (depth - 1);
					s += " ";
					s += m_NamedType.Emit (depth - 1);
				break;
				case production_kind.g_TypeWithConstraint_8:
					// emit syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE SizeConstraint OF NamedType

					s += m_SEQUENCE.Emit (depth - 1);
					s += " ";
					s += m_SizeConstraint.Emit (depth - 1);
					s += " ";
					s += m_OF.Emit (depth - 1);
					s += " ";
					s += m_NamedType.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TypeWithConstraint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TypeWithConstraint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TypeWithConstraint_1:
					// emit syntax tree node associated with production
					// TypeWithConstraint: SET Constraint OF Type

					s += "SET";
					s += ' ';
					s += m_Constraint.EmitProductionTree (depth - 1);
					s += ' ';
					s += "OF";
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_TypeWithConstraint_2:
					// emit syntax tree node associated with production
					// TypeWithConstraint: SET SizeConstraint OF Type

					s += "SET";
					s += ' ';
					s += m_SizeConstraint.EmitProductionTree (depth - 1);
					s += ' ';
					s += "OF";
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_TypeWithConstraint_3:
					// emit syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE Constraint OF Type

					s += "SEQUENCE";
					s += ' ';
					s += m_Constraint.EmitProductionTree (depth - 1);
					s += ' ';
					s += "OF";
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_TypeWithConstraint_4:
					// emit syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE SizeConstraint OF Type

					s += "SEQUENCE";
					s += ' ';
					s += m_SizeConstraint.EmitProductionTree (depth - 1);
					s += ' ';
					s += "OF";
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_TypeWithConstraint_5:
					// emit syntax tree node associated with production
					// TypeWithConstraint: SET Constraint OF NamedType

					s += "SET";
					s += ' ';
					s += m_Constraint.EmitProductionTree (depth - 1);
					s += ' ';
					s += "OF";
					s += ' ';
					s += m_NamedType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_TypeWithConstraint_6:
					// emit syntax tree node associated with production
					// TypeWithConstraint: SET SizeConstraint OF NamedType

					s += "SET";
					s += ' ';
					s += m_SizeConstraint.EmitProductionTree (depth - 1);
					s += ' ';
					s += "OF";
					s += ' ';
					s += m_NamedType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_TypeWithConstraint_7:
					// emit syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE Constraint OF NamedType

					s += "SEQUENCE";
					s += ' ';
					s += m_Constraint.EmitProductionTree (depth - 1);
					s += ' ';
					s += "OF";
					s += ' ';
					s += m_NamedType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_TypeWithConstraint_8:
					// emit syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE SizeConstraint OF NamedType

					s += "SEQUENCE";
					s += ' ';
					s += m_SizeConstraint.EmitProductionTree (depth - 1);
					s += ' ';
					s += "OF";
					s += ' ';
					s += m_NamedType.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TypeWithConstraint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TypeWithConstraint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TypeWithConstraint.production_kind kind = (TypeWithConstraint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_1:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SET Constraint OF Type

						m_SET.Visit (visitor, appData);
						m_Constraint.Visit (visitor, appData);
						m_OF.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_2:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SET SizeConstraint OF Type

						m_SET.Visit (visitor, appData);
						m_SizeConstraint.Visit (visitor, appData);
						m_OF.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_3:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE Constraint OF Type

						m_SEQUENCE.Visit (visitor, appData);
						m_Constraint.Visit (visitor, appData);
						m_OF.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_4:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE SizeConstraint OF Type

						m_SEQUENCE.Visit (visitor, appData);
						m_SizeConstraint.Visit (visitor, appData);
						m_OF.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_5:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SET Constraint OF NamedType

						m_SET.Visit (visitor, appData);
						m_Constraint.Visit (visitor, appData);
						m_OF.Visit (visitor, appData);
						m_NamedType.Visit (visitor, appData);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_6:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SET SizeConstraint OF NamedType

						m_SET.Visit (visitor, appData);
						m_SizeConstraint.Visit (visitor, appData);
						m_OF.Visit (visitor, appData);
						m_NamedType.Visit (visitor, appData);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_7:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE Constraint OF NamedType

						m_SEQUENCE.Visit (visitor, appData);
						m_Constraint.Visit (visitor, appData);
						m_OF.Visit (visitor, appData);
						m_NamedType.Visit (visitor, appData);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_8:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE SizeConstraint OF NamedType

						m_SEQUENCE.Visit (visitor, appData);
						m_SizeConstraint.Visit (visitor, appData);
						m_OF.Visit (visitor, appData);
						m_NamedType.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SET?.reparent (this);
			m_Constraint?.reparent (this);
			m_OF?.reparent (this);
			m_Type?.reparent (this);
			m_SizeConstraint?.reparent (this);
			m_SEQUENCE?.reparent (this);
			m_NamedType?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TypeWithConstraint
		//

		public void _init ()
		{
			m_SET = null;
			m_Constraint = null;
			m_OF = null;
			m_Type = null;
			m_SizeConstraint = null;
			m_SEQUENCE = null;
			m_NamedType = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TypeWithConstraint

		// counter of all nodes associated with syntax rule TypeWithConstraint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TypeWithConstraint
		[DataMember (Name = "m_SET")] public SyntaxTreeToken m_SET { get; private set; }
		[DataMember (Name = "m_Constraint")] public Constraint m_Constraint { get; private set; }
		[DataMember (Name = "m_OF")] public SyntaxTreeToken m_OF { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_SizeConstraint")] public SizeConstraint m_SizeConstraint { get; private set; }
		[DataMember (Name = "m_SEQUENCE")] public SyntaxTreeToken m_SEQUENCE { get; private set; }
		[DataMember (Name = "m_NamedType")] public NamedType m_NamedType { get; private set; }

		public enum __p1_markers
		{
			m1 = 0,
			m2 = 1,
		};

		public enum __p2_markers
		{
			m1 = 0,
			m2 = 1,
		};

		public enum __p3_markers
		{
			m1 = 0,
			m2 = 1,
		};

		public enum __p4_markers
		{
			m1 = 0,
			m2 = 1,
		};

		public enum __p5_markers
		{
			m1 = 0,
			m2 = 1,
		};

		public enum __p6_markers
		{
			m1 = 0,
			m2 = 1,
		};

		public enum __p7_markers
		{
			m1 = 0,
			m2 = 1,
		};

		public enum __p8_markers
		{
			m1 = 0,
			m2 = 1,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TypeWithConstraint

		// delegate function (callback) prototype associated with syntax rule TypeWithConstraint
		public delegate bool TypeWithConstraint_Callback (SyntaxTreeCallbackReason reason, TypeWithConstraint.production_kind kind, TypeWithConstraint p_TypeWithConstraint);

		// event associated with syntax rule TypeWithConstraint
		public event TypeWithConstraint_Callback TypeWithConstraint_Event;

		// event trigger associated with syntax rule TypeWithConstraint
		public bool Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason reason, TypeWithConstraint.production_kind kind, TypeWithConstraint p_TypeWithConstraint)
		{
			bool? status = TypeWithConstraint_Event?.Invoke (reason, kind, p_TypeWithConstraint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TypeWithConstraint
		//
		// traverse syntax tree node associated with any production of syntax rule TypeWithConstraint
		//

		public void Traverse (TypeWithConstraint p_TypeWithConstraint)
		{
			if (p_TypeWithConstraint.isLocked())
				return;
			p_TypeWithConstraint.dolock();
			TypeWithConstraint.production_kind kind = (TypeWithConstraint.production_kind) p_TypeWithConstraint.kind;
			p_TypeWithConstraint.turn_reset ();
			if (Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TypeWithConstraint))
			switch (kind)
			{
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_1:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SET Constraint OF Type

					if (Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint))
						Traverse (p_TypeWithConstraint.m_Constraint);
					p_TypeWithConstraint.turn_inc ();
					if (Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint))
						Traverse (p_TypeWithConstraint.m_Type);
					p_TypeWithConstraint.turn_inc ();
					Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_2:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SET SizeConstraint OF Type

					if (Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint))
						Traverse (p_TypeWithConstraint.m_SizeConstraint);
					p_TypeWithConstraint.turn_inc ();
					if (Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint))
						Traverse (p_TypeWithConstraint.m_Type);
					p_TypeWithConstraint.turn_inc ();
					Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_3:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE Constraint OF Type

					if (Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint))
						Traverse (p_TypeWithConstraint.m_Constraint);
					p_TypeWithConstraint.turn_inc ();
					if (Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint))
						Traverse (p_TypeWithConstraint.m_Type);
					p_TypeWithConstraint.turn_inc ();
					Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_4:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE SizeConstraint OF Type

					if (Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint))
						Traverse (p_TypeWithConstraint.m_SizeConstraint);
					p_TypeWithConstraint.turn_inc ();
					if (Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint))
						Traverse (p_TypeWithConstraint.m_Type);
					p_TypeWithConstraint.turn_inc ();
					Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_5:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SET Constraint OF NamedType

					if (Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint))
						Traverse (p_TypeWithConstraint.m_Constraint);
					p_TypeWithConstraint.turn_inc ();
					if (Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint))
						Traverse (p_TypeWithConstraint.m_NamedType);
					p_TypeWithConstraint.turn_inc ();
					Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_6:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SET SizeConstraint OF NamedType

					if (Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint))
						Traverse (p_TypeWithConstraint.m_SizeConstraint);
					p_TypeWithConstraint.turn_inc ();
					if (Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint))
						Traverse (p_TypeWithConstraint.m_NamedType);
					p_TypeWithConstraint.turn_inc ();
					Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_7:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE Constraint OF NamedType

					if (Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint))
						Traverse (p_TypeWithConstraint.m_Constraint);
					p_TypeWithConstraint.turn_inc ();
					if (Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint))
						Traverse (p_TypeWithConstraint.m_NamedType);
					p_TypeWithConstraint.turn_inc ();
					Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_8:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE SizeConstraint OF NamedType

					if (Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint))
						Traverse (p_TypeWithConstraint.m_SizeConstraint);
					p_TypeWithConstraint.turn_inc ();
					if (Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint))
						Traverse (p_TypeWithConstraint.m_NamedType);
					p_TypeWithConstraint.turn_inc ();
					Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeWithConstraint);
				break;
			}
			Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TypeWithConstraint);
			p_TypeWithConstraint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TypeWithConstraint
		//

		public void TraverseCommon (TypeWithConstraint p_TypeWithConstraint)
		{
			TypeWithConstraint.production_kind kind = (TypeWithConstraint.production_kind) p_TypeWithConstraint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TypeWithConstraint))
			switch (kind)
			{
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_1:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SET Constraint OF Type

						TraverseCommon (p_TypeWithConstraint.m_SET);
						TraverseCommon (p_TypeWithConstraint.m_Constraint);
						TraverseCommon (p_TypeWithConstraint.m_OF);
						TraverseCommon (p_TypeWithConstraint.m_Type);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_2:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SET SizeConstraint OF Type

						TraverseCommon (p_TypeWithConstraint.m_SET);
						TraverseCommon (p_TypeWithConstraint.m_SizeConstraint);
						TraverseCommon (p_TypeWithConstraint.m_OF);
						TraverseCommon (p_TypeWithConstraint.m_Type);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_3:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE Constraint OF Type

						TraverseCommon (p_TypeWithConstraint.m_SEQUENCE);
						TraverseCommon (p_TypeWithConstraint.m_Constraint);
						TraverseCommon (p_TypeWithConstraint.m_OF);
						TraverseCommon (p_TypeWithConstraint.m_Type);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_4:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE SizeConstraint OF Type

						TraverseCommon (p_TypeWithConstraint.m_SEQUENCE);
						TraverseCommon (p_TypeWithConstraint.m_SizeConstraint);
						TraverseCommon (p_TypeWithConstraint.m_OF);
						TraverseCommon (p_TypeWithConstraint.m_Type);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_5:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SET Constraint OF NamedType

						TraverseCommon (p_TypeWithConstraint.m_SET);
						TraverseCommon (p_TypeWithConstraint.m_Constraint);
						TraverseCommon (p_TypeWithConstraint.m_OF);
						TraverseCommon (p_TypeWithConstraint.m_NamedType);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_6:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SET SizeConstraint OF NamedType

						TraverseCommon (p_TypeWithConstraint.m_SET);
						TraverseCommon (p_TypeWithConstraint.m_SizeConstraint);
						TraverseCommon (p_TypeWithConstraint.m_OF);
						TraverseCommon (p_TypeWithConstraint.m_NamedType);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_7:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE Constraint OF NamedType

						TraverseCommon (p_TypeWithConstraint.m_SEQUENCE);
						TraverseCommon (p_TypeWithConstraint.m_Constraint);
						TraverseCommon (p_TypeWithConstraint.m_OF);
						TraverseCommon (p_TypeWithConstraint.m_NamedType);
				break;
				case TypeWithConstraint.production_kind.g_TypeWithConstraint_8:
					// traverse syntax tree node associated with production
					// TypeWithConstraint: SEQUENCE SizeConstraint OF NamedType

						TraverseCommon (p_TypeWithConstraint.m_SEQUENCE);
						TraverseCommon (p_TypeWithConstraint.m_SizeConstraint);
						TraverseCommon (p_TypeWithConstraint.m_OF);
						TraverseCommon (p_TypeWithConstraint.m_NamedType);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TypeWithConstraint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TypeWithConstraint

		//
		// create syntax tree node associated with production
		// TypeWithConstraint: SET Constraint OF Type

		//

		public TypeWithConstraint TypeWithConstraint_1 (SyntaxTreeToken p_token, Constraint p_Constraint, SyntaxTreeToken p_token_1, Type p_Type)
		{
			TypeWithConstraint p_TypeWithConstraint_ref = new TypeWithConstraint(p_token, p_Constraint, p_token_1, p_Type, 1);
			p_token.parent = p_TypeWithConstraint_ref;
			p_Constraint.parent = p_TypeWithConstraint_ref;
			p_token_1.parent = p_TypeWithConstraint_ref;
			p_Type.parent = p_TypeWithConstraint_ref;
			Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeWithConstraint.production_kind.g_TypeWithConstraint_1, p_TypeWithConstraint_ref);
			return p_TypeWithConstraint_ref;
		}

		//
		// create syntax tree node associated with production
		// TypeWithConstraint: SET SizeConstraint OF Type

		//

		public TypeWithConstraint TypeWithConstraint_2 (SyntaxTreeToken p_token, SizeConstraint p_SizeConstraint, SyntaxTreeToken p_token_1, Type p_Type)
		{
			TypeWithConstraint p_TypeWithConstraint_ref = new TypeWithConstraint(p_token, p_SizeConstraint, p_token_1, p_Type, 2);
			p_token.parent = p_TypeWithConstraint_ref;
			p_SizeConstraint.parent = p_TypeWithConstraint_ref;
			p_token_1.parent = p_TypeWithConstraint_ref;
			p_Type.parent = p_TypeWithConstraint_ref;
			Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeWithConstraint.production_kind.g_TypeWithConstraint_2, p_TypeWithConstraint_ref);
			return p_TypeWithConstraint_ref;
		}

		//
		// create syntax tree node associated with production
		// TypeWithConstraint: SEQUENCE Constraint OF Type

		//

		public TypeWithConstraint TypeWithConstraint_3 (SyntaxTreeToken p_token, Constraint p_Constraint, SyntaxTreeToken p_token_1, Type p_Type)
		{
			TypeWithConstraint p_TypeWithConstraint_ref = new TypeWithConstraint(p_token, p_Constraint, p_token_1, p_Type, 3);
			p_token.parent = p_TypeWithConstraint_ref;
			p_Constraint.parent = p_TypeWithConstraint_ref;
			p_token_1.parent = p_TypeWithConstraint_ref;
			p_Type.parent = p_TypeWithConstraint_ref;
			Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeWithConstraint.production_kind.g_TypeWithConstraint_3, p_TypeWithConstraint_ref);
			return p_TypeWithConstraint_ref;
		}

		//
		// create syntax tree node associated with production
		// TypeWithConstraint: SEQUENCE SizeConstraint OF Type

		//

		public TypeWithConstraint TypeWithConstraint_4 (SyntaxTreeToken p_token, SizeConstraint p_SizeConstraint, SyntaxTreeToken p_token_1, Type p_Type)
		{
			TypeWithConstraint p_TypeWithConstraint_ref = new TypeWithConstraint(p_token, p_SizeConstraint, p_token_1, p_Type, 4);
			p_token.parent = p_TypeWithConstraint_ref;
			p_SizeConstraint.parent = p_TypeWithConstraint_ref;
			p_token_1.parent = p_TypeWithConstraint_ref;
			p_Type.parent = p_TypeWithConstraint_ref;
			Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeWithConstraint.production_kind.g_TypeWithConstraint_4, p_TypeWithConstraint_ref);
			return p_TypeWithConstraint_ref;
		}

		//
		// create syntax tree node associated with production
		// TypeWithConstraint: SET Constraint OF NamedType

		//

		public TypeWithConstraint TypeWithConstraint_5 (SyntaxTreeToken p_token, Constraint p_Constraint, SyntaxTreeToken p_token_1, NamedType p_NamedType)
		{
			TypeWithConstraint p_TypeWithConstraint_ref = new TypeWithConstraint(p_token, p_Constraint, p_token_1, p_NamedType, 5);
			p_token.parent = p_TypeWithConstraint_ref;
			p_Constraint.parent = p_TypeWithConstraint_ref;
			p_token_1.parent = p_TypeWithConstraint_ref;
			p_NamedType.parent = p_TypeWithConstraint_ref;
			Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeWithConstraint.production_kind.g_TypeWithConstraint_5, p_TypeWithConstraint_ref);
			return p_TypeWithConstraint_ref;
		}

		//
		// create syntax tree node associated with production
		// TypeWithConstraint: SET SizeConstraint OF NamedType

		//

		public TypeWithConstraint TypeWithConstraint_6 (SyntaxTreeToken p_token, SizeConstraint p_SizeConstraint, SyntaxTreeToken p_token_1, NamedType p_NamedType)
		{
			TypeWithConstraint p_TypeWithConstraint_ref = new TypeWithConstraint(p_token, p_SizeConstraint, p_token_1, p_NamedType, 6);
			p_token.parent = p_TypeWithConstraint_ref;
			p_SizeConstraint.parent = p_TypeWithConstraint_ref;
			p_token_1.parent = p_TypeWithConstraint_ref;
			p_NamedType.parent = p_TypeWithConstraint_ref;
			Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeWithConstraint.production_kind.g_TypeWithConstraint_6, p_TypeWithConstraint_ref);
			return p_TypeWithConstraint_ref;
		}

		//
		// create syntax tree node associated with production
		// TypeWithConstraint: SEQUENCE Constraint OF NamedType

		//

		public TypeWithConstraint TypeWithConstraint_7 (SyntaxTreeToken p_token, Constraint p_Constraint, SyntaxTreeToken p_token_1, NamedType p_NamedType)
		{
			TypeWithConstraint p_TypeWithConstraint_ref = new TypeWithConstraint(p_token, p_Constraint, p_token_1, p_NamedType, 7);
			p_token.parent = p_TypeWithConstraint_ref;
			p_Constraint.parent = p_TypeWithConstraint_ref;
			p_token_1.parent = p_TypeWithConstraint_ref;
			p_NamedType.parent = p_TypeWithConstraint_ref;
			Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeWithConstraint.production_kind.g_TypeWithConstraint_7, p_TypeWithConstraint_ref);
			return p_TypeWithConstraint_ref;
		}

		//
		// create syntax tree node associated with production
		// TypeWithConstraint: SEQUENCE SizeConstraint OF NamedType

		//

		public TypeWithConstraint TypeWithConstraint_8 (SyntaxTreeToken p_token, SizeConstraint p_SizeConstraint, SyntaxTreeToken p_token_1, NamedType p_NamedType)
		{
			TypeWithConstraint p_TypeWithConstraint_ref = new TypeWithConstraint(p_token, p_SizeConstraint, p_token_1, p_NamedType, 8);
			p_token.parent = p_TypeWithConstraint_ref;
			p_SizeConstraint.parent = p_TypeWithConstraint_ref;
			p_token_1.parent = p_TypeWithConstraint_ref;
			p_NamedType.parent = p_TypeWithConstraint_ref;
			Raise_TypeWithConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeWithConstraint.production_kind.g_TypeWithConstraint_8, p_TypeWithConstraint_ref);
			return p_TypeWithConstraint_ref;
		}
		#endregion
	};
}
