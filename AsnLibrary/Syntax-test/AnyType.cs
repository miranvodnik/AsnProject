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
	// class associated with syntax rule AnyType
	//

	[DataContract]
	public class	AnyType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AnyType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AnyType
		{
			g_AnyType_1 = 1,	// ANY

		};
		#endregion
		#region production markers associated with the syntax rule AnyType

		// markers associated with production: AnyType -> ANY

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AnyType

		// Constructor declaration(s) associated with production(s) of syntax rule AnyType

		//
		// Constructor associated with the following production(s)
		// AnyType -> ANY

		//

		public AnyType (SyntaxTreeToken p_token) : base ((uint) ProductionID._AnyType_ID, (uint) production_kind.g_AnyType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ANY = p_token;
		}

		public AnyType () { }

		// Copy constructor

		public AnyType (AnyType p_AnyType) : base (p_AnyType.id, p_AnyType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AnyType.appInfo;
			switch ((production_kind) p_AnyType.kind)
			{
				case production_kind.g_AnyType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ANY = (p_AnyType.m_ANY != null) ? new SyntaxTreeToken (p_AnyType.m_ANY) : null) != null) m_ANY.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AnyType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AnyType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ANY?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AnyType

		// Content changing function(s) associated with production(s) of syntax rule AnyType

		//
		// Content changing function associated with following production(s)
		// AnyType -> ANY

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_AnyType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ANY = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AnyType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ANY != null) && m_ANY.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AnyType

		//
		// emit production tree node associated with any production of syntax rule AnyType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AnyType_1:
					// emit syntax tree node associated with production
					// AnyType: ANY

					s += m_ANY.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AnyType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AnyType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AnyType_1:
					// emit syntax tree node associated with production
					// AnyType: ANY

					s += "ANY";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AnyType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AnyType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AnyType.production_kind kind = (AnyType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AnyType.production_kind.g_AnyType_1:
					// traverse syntax tree node associated with production
					// AnyType: ANY

						m_ANY.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ANY?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AnyType
		//

		public void _init ()
		{
			m_ANY = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AnyType

		// counter of all nodes associated with syntax rule AnyType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AnyType
		[DataMember (Name = "m_ANY")] public SyntaxTreeToken m_ANY { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AnyType

		// delegate function (callback) prototype associated with syntax rule AnyType
		public delegate bool AnyType_Callback (SyntaxTreeCallbackReason reason, AnyType.production_kind kind, AnyType p_AnyType);

		// event associated with syntax rule AnyType
		public event AnyType_Callback AnyType_Event;

		// event trigger associated with syntax rule AnyType
		public bool Raise_AnyType_Event (SyntaxTreeCallbackReason reason, AnyType.production_kind kind, AnyType p_AnyType)
		{
			bool? status = AnyType_Event?.Invoke (reason, kind, p_AnyType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AnyType
		//
		// traverse syntax tree node associated with any production of syntax rule AnyType
		//

		public void Traverse (AnyType p_AnyType)
		{
			if (p_AnyType.isLocked())
				return;
			p_AnyType.dolock();
			AnyType.production_kind kind = (AnyType.production_kind) p_AnyType.kind;
			p_AnyType.turn_reset ();
			if (Raise_AnyType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AnyType))
			switch (kind)
			{
				case AnyType.production_kind.g_AnyType_1:
					// traverse syntax tree node associated with production
					// AnyType: ANY

				break;
			}
			Raise_AnyType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AnyType);
			p_AnyType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AnyType
		//

		public void TraverseCommon (AnyType p_AnyType)
		{
			AnyType.production_kind kind = (AnyType.production_kind) p_AnyType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AnyType))
			switch (kind)
			{
				case AnyType.production_kind.g_AnyType_1:
					// traverse syntax tree node associated with production
					// AnyType: ANY

						TraverseCommon (p_AnyType.m_ANY);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AnyType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AnyType

		//
		// create syntax tree node associated with production
		// AnyType: ANY

		//

		public AnyType AnyType_1 (SyntaxTreeToken p_token)
		{
			AnyType p_AnyType_ref = new AnyType(p_token);
			p_token.parent = p_AnyType_ref;
			Raise_AnyType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AnyType.production_kind.g_AnyType_1, p_AnyType_ref);
			return p_AnyType_ref;
		}
		#endregion
	};
}
