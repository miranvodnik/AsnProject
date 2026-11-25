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
	// class associated with syntax rule TypeOptionalitySpec
	//

	[DataContract]
	public class	TypeOptionalitySpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TypeOptionalitySpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TypeOptionalitySpec
		{
			g_TypeOptionalitySpec_1 = 1,	// OPTIONAL

			g_TypeOptionalitySpec_2 = 2,	// DEFAULT Type

		};
		#endregion
		#region production markers associated with the syntax rule TypeOptionalitySpec

		// markers associated with production: TypeOptionalitySpec -> OPTIONAL

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: TypeOptionalitySpec -> DEFAULT Type

		public enum production_marker_2 : ushort
		{
			m_Type,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TypeOptionalitySpec

		// Constructor declaration(s) associated with production(s) of syntax rule TypeOptionalitySpec

		//
		// Constructor associated with the following production(s)
		// TypeOptionalitySpec -> OPTIONAL

		//

		public TypeOptionalitySpec (SyntaxTreeToken p_token) : base ((uint) ProductionID._TypeOptionalitySpec_ID, (uint) production_kind.g_TypeOptionalitySpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_OPTIONAL = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// TypeOptionalitySpec -> DEFAULT Type

		//

		public TypeOptionalitySpec (SyntaxTreeToken p_token, Type p_Type) : base ((uint) ProductionID._TypeOptionalitySpec_ID, (uint) production_kind.g_TypeOptionalitySpec_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_DEFAULT = p_token;
			children[1] = m_Type = p_Type;
		}

		public TypeOptionalitySpec () { }

		// Copy constructor

		public TypeOptionalitySpec (TypeOptionalitySpec p_TypeOptionalitySpec) : base (p_TypeOptionalitySpec.id, p_TypeOptionalitySpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TypeOptionalitySpec.appInfo;
			switch ((production_kind) p_TypeOptionalitySpec.kind)
			{
				case production_kind.g_TypeOptionalitySpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OPTIONAL = (p_TypeOptionalitySpec.m_OPTIONAL != null) ? new SyntaxTreeToken (p_TypeOptionalitySpec.m_OPTIONAL) : null) != null) m_OPTIONAL.parent = this;
					break;
				case production_kind.g_TypeOptionalitySpec_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_DEFAULT = (p_TypeOptionalitySpec.m_DEFAULT != null) ? new SyntaxTreeToken (p_TypeOptionalitySpec.m_DEFAULT) : null) != null) m_DEFAULT.parent = this;
					if ((children [1] = m_Type = (p_TypeOptionalitySpec.m_Type != null) ? new Type (p_TypeOptionalitySpec.m_Type) : null) != null) m_Type.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TypeOptionalitySpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TypeOptionalitySpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_OPTIONAL?.Dispose ();
			m_DEFAULT?.Dispose ();
			m_Type?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TypeOptionalitySpec

		// Content changing function(s) associated with production(s) of syntax rule TypeOptionalitySpec

		//
		// Content changing function associated with following production(s)
		// TypeOptionalitySpec -> OPTIONAL

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_TypeOptionalitySpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_OPTIONAL = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TypeOptionalitySpec -> DEFAULT Type

		//

		public void change(SyntaxTreeToken p_token, Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_TypeOptionalitySpec_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_DEFAULT = p_token;
			children [1] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TypeOptionalitySpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_OPTIONAL != null) && m_OPTIONAL.checkInclusion (element) ||
				(m_DEFAULT != null) && m_DEFAULT.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TypeOptionalitySpec

		//
		// emit production tree node associated with any production of syntax rule TypeOptionalitySpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TypeOptionalitySpec_1:
					// emit syntax tree node associated with production
					// TypeOptionalitySpec: OPTIONAL

					s += m_OPTIONAL.Emit (depth - 1);
				break;
				case production_kind.g_TypeOptionalitySpec_2:
					// emit syntax tree node associated with production
					// TypeOptionalitySpec: DEFAULT Type

					s += m_DEFAULT.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TypeOptionalitySpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TypeOptionalitySpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TypeOptionalitySpec_1:
					// emit syntax tree node associated with production
					// TypeOptionalitySpec: OPTIONAL

					s += "OPTIONAL";
				break;
				case production_kind.g_TypeOptionalitySpec_2:
					// emit syntax tree node associated with production
					// TypeOptionalitySpec: DEFAULT Type

					s += "DEFAULT";
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TypeOptionalitySpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TypeOptionalitySpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TypeOptionalitySpec.production_kind kind = (TypeOptionalitySpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TypeOptionalitySpec.production_kind.g_TypeOptionalitySpec_1:
					// traverse syntax tree node associated with production
					// TypeOptionalitySpec: OPTIONAL

						m_OPTIONAL.Visit (visitor, appData);
				break;
				case TypeOptionalitySpec.production_kind.g_TypeOptionalitySpec_2:
					// traverse syntax tree node associated with production
					// TypeOptionalitySpec: DEFAULT Type

						m_DEFAULT.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_OPTIONAL?.reparent (this);
			m_DEFAULT?.reparent (this);
			m_Type?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TypeOptionalitySpec
		//

		public void _init ()
		{
			m_OPTIONAL = null;
			m_DEFAULT = null;
			m_Type = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TypeOptionalitySpec

		// counter of all nodes associated with syntax rule TypeOptionalitySpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TypeOptionalitySpec
		[DataMember (Name = "m_OPTIONAL")] public SyntaxTreeToken m_OPTIONAL { get; private set; }
		[DataMember (Name = "m_DEFAULT")] public SyntaxTreeToken m_DEFAULT { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TypeOptionalitySpec

		// delegate function (callback) prototype associated with syntax rule TypeOptionalitySpec
		public delegate bool TypeOptionalitySpec_Callback (SyntaxTreeCallbackReason reason, TypeOptionalitySpec.production_kind kind, TypeOptionalitySpec p_TypeOptionalitySpec);

		// event associated with syntax rule TypeOptionalitySpec
		public event TypeOptionalitySpec_Callback TypeOptionalitySpec_Event;

		// event trigger associated with syntax rule TypeOptionalitySpec
		public bool Raise_TypeOptionalitySpec_Event (SyntaxTreeCallbackReason reason, TypeOptionalitySpec.production_kind kind, TypeOptionalitySpec p_TypeOptionalitySpec)
		{
			bool? status = TypeOptionalitySpec_Event?.Invoke (reason, kind, p_TypeOptionalitySpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TypeOptionalitySpec
		//
		// traverse syntax tree node associated with any production of syntax rule TypeOptionalitySpec
		//

		public void Traverse (TypeOptionalitySpec p_TypeOptionalitySpec)
		{
			if (p_TypeOptionalitySpec.isLocked())
				return;
			p_TypeOptionalitySpec.dolock();
			TypeOptionalitySpec.production_kind kind = (TypeOptionalitySpec.production_kind) p_TypeOptionalitySpec.kind;
			p_TypeOptionalitySpec.turn_reset ();
			if (Raise_TypeOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TypeOptionalitySpec))
			switch (kind)
			{
				case TypeOptionalitySpec.production_kind.g_TypeOptionalitySpec_1:
					// traverse syntax tree node associated with production
					// TypeOptionalitySpec: OPTIONAL

				break;
				case TypeOptionalitySpec.production_kind.g_TypeOptionalitySpec_2:
					// traverse syntax tree node associated with production
					// TypeOptionalitySpec: DEFAULT Type

					if (Raise_TypeOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeOptionalitySpec))
						Traverse (p_TypeOptionalitySpec.m_Type);
					p_TypeOptionalitySpec.turn_inc ();
					Raise_TypeOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeOptionalitySpec);
				break;
			}
			Raise_TypeOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TypeOptionalitySpec);
			p_TypeOptionalitySpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TypeOptionalitySpec
		//

		public void TraverseCommon (TypeOptionalitySpec p_TypeOptionalitySpec)
		{
			TypeOptionalitySpec.production_kind kind = (TypeOptionalitySpec.production_kind) p_TypeOptionalitySpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TypeOptionalitySpec))
			switch (kind)
			{
				case TypeOptionalitySpec.production_kind.g_TypeOptionalitySpec_1:
					// traverse syntax tree node associated with production
					// TypeOptionalitySpec: OPTIONAL

						TraverseCommon (p_TypeOptionalitySpec.m_OPTIONAL);
				break;
				case TypeOptionalitySpec.production_kind.g_TypeOptionalitySpec_2:
					// traverse syntax tree node associated with production
					// TypeOptionalitySpec: DEFAULT Type

						TraverseCommon (p_TypeOptionalitySpec.m_DEFAULT);
						TraverseCommon (p_TypeOptionalitySpec.m_Type);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TypeOptionalitySpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TypeOptionalitySpec

		//
		// create syntax tree node associated with production
		// TypeOptionalitySpec: OPTIONAL

		//

		public TypeOptionalitySpec TypeOptionalitySpec_1 (SyntaxTreeToken p_token)
		{
			TypeOptionalitySpec p_TypeOptionalitySpec_ref = new TypeOptionalitySpec(p_token);
			p_token.parent = p_TypeOptionalitySpec_ref;
			Raise_TypeOptionalitySpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeOptionalitySpec.production_kind.g_TypeOptionalitySpec_1, p_TypeOptionalitySpec_ref);
			return p_TypeOptionalitySpec_ref;
		}

		//
		// create syntax tree node associated with production
		// TypeOptionalitySpec: DEFAULT Type

		//

		public TypeOptionalitySpec TypeOptionalitySpec_2 (SyntaxTreeToken p_token, Type p_Type)
		{
			TypeOptionalitySpec p_TypeOptionalitySpec_ref = new TypeOptionalitySpec(p_token, p_Type);
			p_token.parent = p_TypeOptionalitySpec_ref;
			p_Type.parent = p_TypeOptionalitySpec_ref;
			Raise_TypeOptionalitySpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeOptionalitySpec.production_kind.g_TypeOptionalitySpec_2, p_TypeOptionalitySpec_ref);
			return p_TypeOptionalitySpec_ref;
		}
		#endregion
	};
}
