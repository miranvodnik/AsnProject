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
	// class associated with syntax rule ObjectIdentifierType
	//

	[DataContract]
	public class	ObjectIdentifierType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectIdentifierType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectIdentifierType
		{
			g_ObjectIdentifierType_1 = 1,	// OBJECT IDENTIFIER

		};
		#endregion
		#region production markers associated with the syntax rule ObjectIdentifierType

		// markers associated with production: ObjectIdentifierType -> OBJECT IDENTIFIER

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectIdentifierType

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectIdentifierType

		//
		// Constructor associated with the following production(s)
		// ObjectIdentifierType -> OBJECT IDENTIFIER

		//

		public ObjectIdentifierType (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._ObjectIdentifierType_ID, (uint) production_kind.g_ObjectIdentifierType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_OBJECT = p_token;
			children[1] = m_IDENTIFIER = p_token_1;
		}

		public ObjectIdentifierType () { }

		// Copy constructor

		public ObjectIdentifierType (ObjectIdentifierType p_ObjectIdentifierType) : base (p_ObjectIdentifierType.id, p_ObjectIdentifierType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectIdentifierType.appInfo;
			switch ((production_kind) p_ObjectIdentifierType.kind)
			{
				case production_kind.g_ObjectIdentifierType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_OBJECT = (p_ObjectIdentifierType.m_OBJECT != null) ? new SyntaxTreeToken (p_ObjectIdentifierType.m_OBJECT) : null) != null) m_OBJECT.parent = this;
					if ((children [1] = m_IDENTIFIER = (p_ObjectIdentifierType.m_IDENTIFIER != null) ? new SyntaxTreeToken (p_ObjectIdentifierType.m_IDENTIFIER) : null) != null) m_IDENTIFIER.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectIdentifierType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectIdentifierType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_OBJECT?.Dispose ();
			m_IDENTIFIER?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectIdentifierType

		// Content changing function(s) associated with production(s) of syntax rule ObjectIdentifierType

		//
		// Content changing function associated with following production(s)
		// ObjectIdentifierType -> OBJECT IDENTIFIER

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectIdentifierType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_OBJECT = p_token;
			children [1] = m_IDENTIFIER = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectIdentifierType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_OBJECT != null) && m_OBJECT.checkInclusion (element) ||
				(m_IDENTIFIER != null) && m_IDENTIFIER.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectIdentifierType

		//
		// emit production tree node associated with any production of syntax rule ObjectIdentifierType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectIdentifierType_1:
					// emit syntax tree node associated with production
					// ObjectIdentifierType: OBJECT IDENTIFIER

					s += m_OBJECT.Emit (depth - 1);
					s += " ";
					s += m_IDENTIFIER.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectIdentifierType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectIdentifierType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectIdentifierType_1:
					// emit syntax tree node associated with production
					// ObjectIdentifierType: OBJECT IDENTIFIER

					s += "OBJECT";
					s += ' ';
					s += "IDENTIFIER";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectIdentifierType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectIdentifierType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectIdentifierType.production_kind kind = (ObjectIdentifierType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectIdentifierType.production_kind.g_ObjectIdentifierType_1:
					// traverse syntax tree node associated with production
					// ObjectIdentifierType: OBJECT IDENTIFIER

						m_OBJECT.Visit (visitor, appData);
						m_IDENTIFIER.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_OBJECT?.reparent (this);
			m_IDENTIFIER?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectIdentifierType
		//

		public void _init ()
		{
			m_OBJECT = null;
			m_IDENTIFIER = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectIdentifierType

		// counter of all nodes associated with syntax rule ObjectIdentifierType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectIdentifierType
		[DataMember (Name = "m_OBJECT")] public SyntaxTreeToken m_OBJECT { get; private set; }
		[DataMember (Name = "m_IDENTIFIER")] public SyntaxTreeToken m_IDENTIFIER { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectIdentifierType

		// delegate function (callback) prototype associated with syntax rule ObjectIdentifierType
		public delegate bool ObjectIdentifierType_Callback (SyntaxTreeCallbackReason reason, ObjectIdentifierType.production_kind kind, ObjectIdentifierType p_ObjectIdentifierType);

		// event associated with syntax rule ObjectIdentifierType
		public event ObjectIdentifierType_Callback ObjectIdentifierType_Event;

		// event trigger associated with syntax rule ObjectIdentifierType
		public bool Raise_ObjectIdentifierType_Event (SyntaxTreeCallbackReason reason, ObjectIdentifierType.production_kind kind, ObjectIdentifierType p_ObjectIdentifierType)
		{
			bool? status = ObjectIdentifierType_Event?.Invoke (reason, kind, p_ObjectIdentifierType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectIdentifierType
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectIdentifierType
		//

		public void Traverse (ObjectIdentifierType p_ObjectIdentifierType)
		{
			if (p_ObjectIdentifierType.isLocked())
				return;
			p_ObjectIdentifierType.dolock();
			ObjectIdentifierType.production_kind kind = (ObjectIdentifierType.production_kind) p_ObjectIdentifierType.kind;
			p_ObjectIdentifierType.turn_reset ();
			if (Raise_ObjectIdentifierType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectIdentifierType))
			switch (kind)
			{
				case ObjectIdentifierType.production_kind.g_ObjectIdentifierType_1:
					// traverse syntax tree node associated with production
					// ObjectIdentifierType: OBJECT IDENTIFIER

				break;
			}
			Raise_ObjectIdentifierType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectIdentifierType);
			p_ObjectIdentifierType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectIdentifierType
		//

		public void TraverseCommon (ObjectIdentifierType p_ObjectIdentifierType)
		{
			ObjectIdentifierType.production_kind kind = (ObjectIdentifierType.production_kind) p_ObjectIdentifierType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectIdentifierType))
			switch (kind)
			{
				case ObjectIdentifierType.production_kind.g_ObjectIdentifierType_1:
					// traverse syntax tree node associated with production
					// ObjectIdentifierType: OBJECT IDENTIFIER

						TraverseCommon (p_ObjectIdentifierType.m_OBJECT);
						TraverseCommon (p_ObjectIdentifierType.m_IDENTIFIER);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectIdentifierType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectIdentifierType

		//
		// create syntax tree node associated with production
		// ObjectIdentifierType: OBJECT IDENTIFIER

		//

		public ObjectIdentifierType ObjectIdentifierType_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			ObjectIdentifierType p_ObjectIdentifierType_ref = new ObjectIdentifierType(p_token, p_token_1);
			p_token.parent = p_ObjectIdentifierType_ref;
			p_token_1.parent = p_ObjectIdentifierType_ref;
			Raise_ObjectIdentifierType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectIdentifierType.production_kind.g_ObjectIdentifierType_1, p_ObjectIdentifierType_ref);
			return p_ObjectIdentifierType_ref;
		}
		#endregion
	};
}
