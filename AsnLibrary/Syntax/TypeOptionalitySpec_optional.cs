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
	// class associated with syntax rule TypeOptionalitySpec-optional
	//

	[DataContract]
	public class	TypeOptionalitySpec_optional : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TypeOptionalitySpec-optional
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TypeOptionalitySpec-optional
		{
			g_TypeOptionalitySpec_optional_1 = 1,	// %empty

			g_TypeOptionalitySpec_optional_2 = 2,	// TypeOptionalitySpec

		};
		#endregion
		#region production markers associated with the syntax rule TypeOptionalitySpec-optional

		// markers associated with production: TypeOptionalitySpec-optional -> %empty

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: TypeOptionalitySpec-optional -> TypeOptionalitySpec

		public enum production_marker_2 : ushort
		{
			m_TypeOptionalitySpec,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TypeOptionalitySpec-optional

		// Constructor declaration(s) associated with production(s) of syntax rule TypeOptionalitySpec-optional

		//
		// Constructor associated with the following production(s)
		// TypeOptionalitySpec-optional -> %empty

		//

		public TypeOptionalitySpec_optional () : base ((uint) ProductionID._TypeOptionalitySpec_optional_ID, (uint) production_kind.g_TypeOptionalitySpec_optional_1)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		//
		// Constructor associated with the following production(s)
		// TypeOptionalitySpec-optional -> TypeOptionalitySpec

		//

		public TypeOptionalitySpec_optional (TypeOptionalitySpec p_TypeOptionalitySpec) : base ((uint) ProductionID._TypeOptionalitySpec_optional_ID, (uint) production_kind.g_TypeOptionalitySpec_optional_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TypeOptionalitySpec = p_TypeOptionalitySpec;
		}

		// Copy constructor

		public TypeOptionalitySpec_optional (TypeOptionalitySpec_optional p_TypeOptionalitySpec_optional) : base (p_TypeOptionalitySpec_optional.id, p_TypeOptionalitySpec_optional.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TypeOptionalitySpec_optional.appInfo;
			switch ((production_kind) p_TypeOptionalitySpec_optional.kind)
			{
				case production_kind.g_TypeOptionalitySpec_optional_1:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				case production_kind.g_TypeOptionalitySpec_optional_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TypeOptionalitySpec = (p_TypeOptionalitySpec_optional.m_TypeOptionalitySpec != null) ? new TypeOptionalitySpec (p_TypeOptionalitySpec_optional.m_TypeOptionalitySpec) : null) != null) m_TypeOptionalitySpec.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TypeOptionalitySpec_optional" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TypeOptionalitySpec_optional (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_TypeOptionalitySpec?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TypeOptionalitySpec-optional

		// Content changing function(s) associated with production(s) of syntax rule TypeOptionalitySpec-optional

		//
		// Content changing function associated with following production(s)
		// TypeOptionalitySpec-optional -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_TypeOptionalitySpec_optional_1;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TypeOptionalitySpec-optional -> TypeOptionalitySpec

		//

		public void change(TypeOptionalitySpec p_TypeOptionalitySpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_TypeOptionalitySpec_optional_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TypeOptionalitySpec = p_TypeOptionalitySpec;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TypeOptionalitySpec-optional
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_TypeOptionalitySpec != null) && m_TypeOptionalitySpec.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TypeOptionalitySpec-optional

		//
		// emit production tree node associated with any production of syntax rule TypeOptionalitySpec-optional
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TypeOptionalitySpec_optional_1:
					// emit syntax tree node associated with production
					// TypeOptionalitySpec-optional: %empty

				break;
				case production_kind.g_TypeOptionalitySpec_optional_2:
					// emit syntax tree node associated with production
					// TypeOptionalitySpec-optional: TypeOptionalitySpec

					s += m_TypeOptionalitySpec.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TypeOptionalitySpec-optional
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TypeOptionalitySpec_optional (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TypeOptionalitySpec_optional_1:
					// emit syntax tree node associated with production
					// TypeOptionalitySpec-optional: %empty

				break;
				case production_kind.g_TypeOptionalitySpec_optional_2:
					// emit syntax tree node associated with production
					// TypeOptionalitySpec-optional: TypeOptionalitySpec

					s += m_TypeOptionalitySpec.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TypeOptionalitySpec-optional

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TypeOptionalitySpec-optional with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TypeOptionalitySpec_optional.production_kind kind = (TypeOptionalitySpec_optional.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TypeOptionalitySpec_optional.production_kind.g_TypeOptionalitySpec_optional_1:
					// traverse syntax tree node associated with production
					// TypeOptionalitySpec-optional: %empty

				break;
				case TypeOptionalitySpec_optional.production_kind.g_TypeOptionalitySpec_optional_2:
					// traverse syntax tree node associated with production
					// TypeOptionalitySpec-optional: TypeOptionalitySpec

						m_TypeOptionalitySpec.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_TypeOptionalitySpec?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TypeOptionalitySpec-optional
		//

		public void _init ()
		{
			m_TypeOptionalitySpec = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TypeOptionalitySpec-optional

		// counter of all nodes associated with syntax rule TypeOptionalitySpec-optional
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TypeOptionalitySpec-optional
		[DataMember (Name = "m_TypeOptionalitySpec")] public TypeOptionalitySpec m_TypeOptionalitySpec { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TypeOptionalitySpec-optional

		// delegate function (callback) prototype associated with syntax rule TypeOptionalitySpec-optional
		public delegate bool TypeOptionalitySpec_optional_Callback (SyntaxTreeCallbackReason reason, TypeOptionalitySpec_optional.production_kind kind, TypeOptionalitySpec_optional p_TypeOptionalitySpec_optional);

		// event associated with syntax rule TypeOptionalitySpec-optional
		public event TypeOptionalitySpec_optional_Callback TypeOptionalitySpec_optional_Event;

		// event trigger associated with syntax rule TypeOptionalitySpec-optional
		public bool Raise_TypeOptionalitySpec_optional_Event (SyntaxTreeCallbackReason reason, TypeOptionalitySpec_optional.production_kind kind, TypeOptionalitySpec_optional p_TypeOptionalitySpec_optional)
		{
			bool? status = TypeOptionalitySpec_optional_Event?.Invoke (reason, kind, p_TypeOptionalitySpec_optional);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TypeOptionalitySpec-optional
		//
		// traverse syntax tree node associated with any production of syntax rule TypeOptionalitySpec-optional
		//

		public void Traverse (TypeOptionalitySpec_optional p_TypeOptionalitySpec_optional)
		{
			if (p_TypeOptionalitySpec_optional.isLocked())
				return;
			p_TypeOptionalitySpec_optional.dolock();
			TypeOptionalitySpec_optional.production_kind kind = (TypeOptionalitySpec_optional.production_kind) p_TypeOptionalitySpec_optional.kind;
			p_TypeOptionalitySpec_optional.turn_reset ();
			if (Raise_TypeOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TypeOptionalitySpec_optional))
			switch (kind)
			{
				case TypeOptionalitySpec_optional.production_kind.g_TypeOptionalitySpec_optional_1:
					// traverse syntax tree node associated with production
					// TypeOptionalitySpec-optional: %empty

				break;
				case TypeOptionalitySpec_optional.production_kind.g_TypeOptionalitySpec_optional_2:
					// traverse syntax tree node associated with production
					// TypeOptionalitySpec-optional: TypeOptionalitySpec

					if (Raise_TypeOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeOptionalitySpec_optional))
						Traverse (p_TypeOptionalitySpec_optional.m_TypeOptionalitySpec);
					p_TypeOptionalitySpec_optional.turn_inc ();
					Raise_TypeOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeOptionalitySpec_optional);
				break;
			}
			Raise_TypeOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TypeOptionalitySpec_optional);
			p_TypeOptionalitySpec_optional.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TypeOptionalitySpec-optional
		//

		public void TraverseCommon (TypeOptionalitySpec_optional p_TypeOptionalitySpec_optional)
		{
			TypeOptionalitySpec_optional.production_kind kind = (TypeOptionalitySpec_optional.production_kind) p_TypeOptionalitySpec_optional.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TypeOptionalitySpec_optional))
			switch (kind)
			{
				case TypeOptionalitySpec_optional.production_kind.g_TypeOptionalitySpec_optional_1:
					// traverse syntax tree node associated with production
					// TypeOptionalitySpec-optional: %empty

				break;
				case TypeOptionalitySpec_optional.production_kind.g_TypeOptionalitySpec_optional_2:
					// traverse syntax tree node associated with production
					// TypeOptionalitySpec-optional: TypeOptionalitySpec

						TraverseCommon (p_TypeOptionalitySpec_optional.m_TypeOptionalitySpec);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TypeOptionalitySpec_optional);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TypeOptionalitySpec-optional

		//
		// create syntax tree node associated with production
		// TypeOptionalitySpec-optional: %empty

		//

		public TypeOptionalitySpec_optional TypeOptionalitySpec_optional_1 ()
		{
			TypeOptionalitySpec_optional p_TypeOptionalitySpec_optional_ref = new TypeOptionalitySpec_optional();
			Raise_TypeOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeOptionalitySpec_optional.production_kind.g_TypeOptionalitySpec_optional_1, p_TypeOptionalitySpec_optional_ref);
			return p_TypeOptionalitySpec_optional_ref;
		}

		//
		// create syntax tree node associated with production
		// TypeOptionalitySpec-optional: TypeOptionalitySpec

		//

		public TypeOptionalitySpec_optional TypeOptionalitySpec_optional_2 (TypeOptionalitySpec p_TypeOptionalitySpec)
		{
			TypeOptionalitySpec_optional p_TypeOptionalitySpec_optional_ref = new TypeOptionalitySpec_optional(p_TypeOptionalitySpec);
			p_TypeOptionalitySpec.parent = p_TypeOptionalitySpec_optional_ref;
			Raise_TypeOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeOptionalitySpec_optional.production_kind.g_TypeOptionalitySpec_optional_2, p_TypeOptionalitySpec_optional_ref);
			return p_TypeOptionalitySpec_optional_ref;
		}
		#endregion
	};
}
