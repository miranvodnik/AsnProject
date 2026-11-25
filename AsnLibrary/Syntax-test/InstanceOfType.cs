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
	// class associated with syntax rule InstanceOfType
	//

	[DataContract]
	public class	InstanceOfType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule InstanceOfType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule InstanceOfType
		{
			g_InstanceOfType_1 = 1,	// INSTANCE OF DefinedObjectClass

		};
		#endregion
		#region production markers associated with the syntax rule InstanceOfType

		// markers associated with production: InstanceOfType -> INSTANCE OF DefinedObjectClass

		public enum production_marker_1 : ushort
		{
			m_DefinedObjectClass,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule InstanceOfType

		// Constructor declaration(s) associated with production(s) of syntax rule InstanceOfType

		//
		// Constructor associated with the following production(s)
		// InstanceOfType -> INSTANCE OF DefinedObjectClass

		//

		public InstanceOfType (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, DefinedObjectClass p_DefinedObjectClass) : base ((uint) ProductionID._InstanceOfType_ID, (uint) production_kind.g_InstanceOfType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_INSTANCE = p_token;
			children[1] = m_OF = p_token_1;
			children[2] = m_DefinedObjectClass = p_DefinedObjectClass;
		}

		public InstanceOfType () { }

		// Copy constructor

		public InstanceOfType (InstanceOfType p_InstanceOfType) : base (p_InstanceOfType.id, p_InstanceOfType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_InstanceOfType.appInfo;
			switch ((production_kind) p_InstanceOfType.kind)
			{
				case production_kind.g_InstanceOfType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_INSTANCE = (p_InstanceOfType.m_INSTANCE != null) ? new SyntaxTreeToken (p_InstanceOfType.m_INSTANCE) : null) != null) m_INSTANCE.parent = this;
					if ((children [1] = m_OF = (p_InstanceOfType.m_OF != null) ? new SyntaxTreeToken (p_InstanceOfType.m_OF) : null) != null) m_OF.parent = this;
					if ((children [2] = m_DefinedObjectClass = (p_InstanceOfType.m_DefinedObjectClass != null) ? new DefinedObjectClass (p_InstanceOfType.m_DefinedObjectClass) : null) != null) m_DefinedObjectClass.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "InstanceOfType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new InstanceOfType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_INSTANCE?.Dispose ();
			m_OF?.Dispose ();
			m_DefinedObjectClass?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule InstanceOfType

		// Content changing function(s) associated with production(s) of syntax rule InstanceOfType

		//
		// Content changing function associated with following production(s)
		// InstanceOfType -> INSTANCE OF DefinedObjectClass

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, DefinedObjectClass p_DefinedObjectClass)
		{
			_init ();
			this.kind = (uint) production_kind.g_InstanceOfType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_INSTANCE = p_token;
			children [1] = m_OF = p_token_1;
			children [2] = m_DefinedObjectClass = p_DefinedObjectClass;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule InstanceOfType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_INSTANCE != null) && m_INSTANCE.checkInclusion (element) ||
				(m_OF != null) && m_OF.checkInclusion (element) ||
				(m_DefinedObjectClass != null) && m_DefinedObjectClass.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule InstanceOfType

		//
		// emit production tree node associated with any production of syntax rule InstanceOfType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_InstanceOfType_1:
					// emit syntax tree node associated with production
					// InstanceOfType: INSTANCE OF DefinedObjectClass

					s += m_INSTANCE.Emit (depth - 1);
					s += " ";
					s += m_OF.Emit (depth - 1);
					s += " ";
					s += m_DefinedObjectClass.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule InstanceOfType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "InstanceOfType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_InstanceOfType_1:
					// emit syntax tree node associated with production
					// InstanceOfType: INSTANCE OF DefinedObjectClass

					s += "INSTANCE";
					s += ' ';
					s += "OF";
					s += ' ';
					s += m_DefinedObjectClass.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule InstanceOfType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule InstanceOfType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			InstanceOfType.production_kind kind = (InstanceOfType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case InstanceOfType.production_kind.g_InstanceOfType_1:
					// traverse syntax tree node associated with production
					// InstanceOfType: INSTANCE OF DefinedObjectClass

						m_INSTANCE.Visit (visitor, appData);
						m_OF.Visit (visitor, appData);
						m_DefinedObjectClass.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_INSTANCE?.reparent (this);
			m_OF?.reparent (this);
			m_DefinedObjectClass?.reparent (this);
		}

		//
		// initialize object associated with syntax rule InstanceOfType
		//

		public void _init ()
		{
			m_INSTANCE = null;
			m_OF = null;
			m_DefinedObjectClass = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule InstanceOfType

		// counter of all nodes associated with syntax rule InstanceOfType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule InstanceOfType
		[DataMember (Name = "m_INSTANCE")] public SyntaxTreeToken m_INSTANCE { get; private set; }
		[DataMember (Name = "m_OF")] public SyntaxTreeToken m_OF { get; private set; }
		[DataMember (Name = "m_DefinedObjectClass")] public DefinedObjectClass m_DefinedObjectClass { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule InstanceOfType

		// delegate function (callback) prototype associated with syntax rule InstanceOfType
		public delegate bool InstanceOfType_Callback (SyntaxTreeCallbackReason reason, InstanceOfType.production_kind kind, InstanceOfType p_InstanceOfType);

		// event associated with syntax rule InstanceOfType
		public event InstanceOfType_Callback InstanceOfType_Event;

		// event trigger associated with syntax rule InstanceOfType
		public bool Raise_InstanceOfType_Event (SyntaxTreeCallbackReason reason, InstanceOfType.production_kind kind, InstanceOfType p_InstanceOfType)
		{
			bool? status = InstanceOfType_Event?.Invoke (reason, kind, p_InstanceOfType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule InstanceOfType
		//
		// traverse syntax tree node associated with any production of syntax rule InstanceOfType
		//

		public void Traverse (InstanceOfType p_InstanceOfType)
		{
			if (p_InstanceOfType.isLocked())
				return;
			p_InstanceOfType.dolock();
			InstanceOfType.production_kind kind = (InstanceOfType.production_kind) p_InstanceOfType.kind;
			p_InstanceOfType.turn_reset ();
			if (Raise_InstanceOfType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_InstanceOfType))
			switch (kind)
			{
				case InstanceOfType.production_kind.g_InstanceOfType_1:
					// traverse syntax tree node associated with production
					// InstanceOfType: INSTANCE OF DefinedObjectClass

					if (Raise_InstanceOfType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_InstanceOfType))
						Traverse (p_InstanceOfType.m_DefinedObjectClass);
					p_InstanceOfType.turn_inc ();
					Raise_InstanceOfType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_InstanceOfType);
				break;
			}
			Raise_InstanceOfType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_InstanceOfType);
			p_InstanceOfType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule InstanceOfType
		//

		public void TraverseCommon (InstanceOfType p_InstanceOfType)
		{
			InstanceOfType.production_kind kind = (InstanceOfType.production_kind) p_InstanceOfType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_InstanceOfType))
			switch (kind)
			{
				case InstanceOfType.production_kind.g_InstanceOfType_1:
					// traverse syntax tree node associated with production
					// InstanceOfType: INSTANCE OF DefinedObjectClass

						TraverseCommon (p_InstanceOfType.m_INSTANCE);
						TraverseCommon (p_InstanceOfType.m_OF);
						TraverseCommon (p_InstanceOfType.m_DefinedObjectClass);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_InstanceOfType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule InstanceOfType

		//
		// create syntax tree node associated with production
		// InstanceOfType: INSTANCE OF DefinedObjectClass

		//

		public InstanceOfType InstanceOfType_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, DefinedObjectClass p_DefinedObjectClass)
		{
			InstanceOfType p_InstanceOfType_ref = new InstanceOfType(p_token, p_token_1, p_DefinedObjectClass);
			p_token.parent = p_InstanceOfType_ref;
			p_token_1.parent = p_InstanceOfType_ref;
			p_DefinedObjectClass.parent = p_InstanceOfType_ref;
			Raise_InstanceOfType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, InstanceOfType.production_kind.g_InstanceOfType_1, p_InstanceOfType_ref);
			return p_InstanceOfType_ref;
		}
		#endregion
	};
}
