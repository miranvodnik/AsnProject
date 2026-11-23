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
	// class associated with syntax rule TypeConstraint
	//

	[DataContract]
	public class	TypeConstraint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TypeConstraint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TypeConstraint
		{
			g_TypeConstraint_1 = 1,	// Type

		};
		#endregion
		#region production markers associated with the syntax rule TypeConstraint

		// markers associated with production: TypeConstraint -> Type

		public enum production_marker_1 : ushort
		{
			m_Type,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TypeConstraint

		// Constructor declaration(s) associated with production(s) of syntax rule TypeConstraint

		//
		// Constructor associated with the following production(s)
		// TypeConstraint -> Type

		//

		public TypeConstraint (Type p_Type) : base ((uint) ProductionID._TypeConstraint_ID, (uint) production_kind.g_TypeConstraint_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Type = p_Type;
		}

		public TypeConstraint () { }

		// Copy constructor

		public TypeConstraint (TypeConstraint p_TypeConstraint) : base (p_TypeConstraint.id, p_TypeConstraint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TypeConstraint.appInfo;
			switch ((production_kind) p_TypeConstraint.kind)
			{
				case production_kind.g_TypeConstraint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Type = (p_TypeConstraint.m_Type != null) ? new Type (p_TypeConstraint.m_Type) : null) != null) m_Type.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TypeConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TypeConstraint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Type?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TypeConstraint

		// Content changing function(s) associated with production(s) of syntax rule TypeConstraint

		//
		// Content changing function associated with following production(s)
		// TypeConstraint -> Type

		//

		public void change(Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_TypeConstraint_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TypeConstraint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TypeConstraint

		//
		// emit production tree node associated with any production of syntax rule TypeConstraint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TypeConstraint_1:
					// emit syntax tree node associated with production
					// TypeConstraint: Type

					s += m_Type.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TypeConstraint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TypeConstraint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TypeConstraint_1:
					// emit syntax tree node associated with production
					// TypeConstraint: Type

					s += m_Type.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TypeConstraint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TypeConstraint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TypeConstraint.production_kind kind = (TypeConstraint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TypeConstraint.production_kind.g_TypeConstraint_1:
					// traverse syntax tree node associated with production
					// TypeConstraint: Type

						m_Type.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Type?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TypeConstraint
		//

		public void _init ()
		{
			m_Type = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TypeConstraint

		// counter of all nodes associated with syntax rule TypeConstraint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TypeConstraint
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TypeConstraint

		// delegate function (callback) prototype associated with syntax rule TypeConstraint
		public delegate bool TypeConstraint_Callback (SyntaxTreeCallbackReason reason, TypeConstraint.production_kind kind, TypeConstraint p_TypeConstraint);

		// event associated with syntax rule TypeConstraint
		public event TypeConstraint_Callback TypeConstraint_Event;

		// event trigger associated with syntax rule TypeConstraint
		public bool Raise_TypeConstraint_Event (SyntaxTreeCallbackReason reason, TypeConstraint.production_kind kind, TypeConstraint p_TypeConstraint)
		{
			bool? status = TypeConstraint_Event?.Invoke (reason, kind, p_TypeConstraint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TypeConstraint
		//
		// traverse syntax tree node associated with any production of syntax rule TypeConstraint
		//

		public void Traverse (TypeConstraint p_TypeConstraint)
		{
			if (p_TypeConstraint.isLocked())
				return;
			p_TypeConstraint.dolock();
			TypeConstraint.production_kind kind = (TypeConstraint.production_kind) p_TypeConstraint.kind;
			p_TypeConstraint.turn_reset ();
			if (Raise_TypeConstraint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TypeConstraint))
			switch (kind)
			{
				case TypeConstraint.production_kind.g_TypeConstraint_1:
					// traverse syntax tree node associated with production
					// TypeConstraint: Type

					if (Raise_TypeConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeConstraint))
						Traverse (p_TypeConstraint.m_Type);
					p_TypeConstraint.turn_inc ();
					Raise_TypeConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeConstraint);
				break;
			}
			Raise_TypeConstraint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TypeConstraint);
			p_TypeConstraint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TypeConstraint
		//

		public void TraverseCommon (TypeConstraint p_TypeConstraint)
		{
			TypeConstraint.production_kind kind = (TypeConstraint.production_kind) p_TypeConstraint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TypeConstraint))
			switch (kind)
			{
				case TypeConstraint.production_kind.g_TypeConstraint_1:
					// traverse syntax tree node associated with production
					// TypeConstraint: Type

						TraverseCommon (p_TypeConstraint.m_Type);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TypeConstraint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TypeConstraint

		//
		// create syntax tree node associated with production
		// TypeConstraint: Type

		//

		public TypeConstraint TypeConstraint_1 (Type p_Type)
		{
			TypeConstraint p_TypeConstraint_ref = new TypeConstraint(p_Type);
			p_Type.parent = p_TypeConstraint_ref;
			Raise_TypeConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeConstraint.production_kind.g_TypeConstraint_1, p_TypeConstraint_ref);
			return p_TypeConstraint_ref;
		}
		#endregion
	};
}
