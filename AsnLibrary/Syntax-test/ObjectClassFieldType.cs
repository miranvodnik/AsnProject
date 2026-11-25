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
	// class associated with syntax rule ObjectClassFieldType
	//

	[DataContract]
	public class	ObjectClassFieldType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectClassFieldType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectClassFieldType
		{
			g_ObjectClassFieldType_1 = 1,	// DefinedObjectClass "." FieldName

		};
		#endregion
		#region production markers associated with the syntax rule ObjectClassFieldType

		// markers associated with production: ObjectClassFieldType -> DefinedObjectClass "." FieldName

		public enum production_marker_1 : ushort
		{
			m_DefinedObjectClass,
			m_FieldName,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectClassFieldType

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectClassFieldType

		//
		// Constructor associated with the following production(s)
		// ObjectClassFieldType -> DefinedObjectClass "." FieldName

		//

		public ObjectClassFieldType (DefinedObjectClass p_DefinedObjectClass, SyntaxTreeToken p_token, FieldName p_FieldName) : base ((uint) ProductionID._ObjectClassFieldType_ID, (uint) production_kind.g_ObjectClassFieldType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_DefinedObjectClass = p_DefinedObjectClass;
			children[1] = m_dot = p_token;
			children[2] = m_FieldName = p_FieldName;
		}

		public ObjectClassFieldType () { }

		// Copy constructor

		public ObjectClassFieldType (ObjectClassFieldType p_ObjectClassFieldType) : base (p_ObjectClassFieldType.id, p_ObjectClassFieldType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectClassFieldType.appInfo;
			switch ((production_kind) p_ObjectClassFieldType.kind)
			{
				case production_kind.g_ObjectClassFieldType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_DefinedObjectClass = (p_ObjectClassFieldType.m_DefinedObjectClass != null) ? new DefinedObjectClass (p_ObjectClassFieldType.m_DefinedObjectClass) : null) != null) m_DefinedObjectClass.parent = this;
					if ((children [1] = m_dot = (p_ObjectClassFieldType.m_dot != null) ? new SyntaxTreeToken (p_ObjectClassFieldType.m_dot) : null) != null) m_dot.parent = this;
					if ((children [2] = m_FieldName = (p_ObjectClassFieldType.m_FieldName != null) ? new FieldName (p_ObjectClassFieldType.m_FieldName) : null) != null) m_FieldName.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectClassFieldType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectClassFieldType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DefinedObjectClass?.Dispose ();
			m_dot?.Dispose ();
			m_FieldName?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectClassFieldType

		// Content changing function(s) associated with production(s) of syntax rule ObjectClassFieldType

		//
		// Content changing function associated with following production(s)
		// ObjectClassFieldType -> DefinedObjectClass "." FieldName

		//

		public void change(DefinedObjectClass p_DefinedObjectClass, SyntaxTreeToken p_token, FieldName p_FieldName)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectClassFieldType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_DefinedObjectClass = p_DefinedObjectClass;
			children [1] = m_dot = p_token;
			children [2] = m_FieldName = p_FieldName;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectClassFieldType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DefinedObjectClass != null) && m_DefinedObjectClass.checkInclusion (element) ||
				(m_dot != null) && m_dot.checkInclusion (element) ||
				(m_FieldName != null) && m_FieldName.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectClassFieldType

		//
		// emit production tree node associated with any production of syntax rule ObjectClassFieldType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectClassFieldType_1:
					// emit syntax tree node associated with production
					// ObjectClassFieldType: DefinedObjectClass "." FieldName

					s += m_DefinedObjectClass.Emit (depth - 1);
					s += " ";
					s += m_dot.Emit (depth - 1);
					s += " ";
					s += m_FieldName.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectClassFieldType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectClassFieldType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectClassFieldType_1:
					// emit syntax tree node associated with production
					// ObjectClassFieldType: DefinedObjectClass "." FieldName

					s += m_DefinedObjectClass.EmitProductionTree (depth - 1);
					s += ' ';
					s += "dot";
					s += ' ';
					s += m_FieldName.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectClassFieldType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectClassFieldType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectClassFieldType.production_kind kind = (ObjectClassFieldType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectClassFieldType.production_kind.g_ObjectClassFieldType_1:
					// traverse syntax tree node associated with production
					// ObjectClassFieldType: DefinedObjectClass "." FieldName

						m_DefinedObjectClass.Visit (visitor, appData);
						m_dot.Visit (visitor, appData);
						m_FieldName.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DefinedObjectClass?.reparent (this);
			m_dot?.reparent (this);
			m_FieldName?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectClassFieldType
		//

		public void _init ()
		{
			m_DefinedObjectClass = null;
			m_dot = null;
			m_FieldName = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectClassFieldType

		// counter of all nodes associated with syntax rule ObjectClassFieldType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectClassFieldType
		[DataMember (Name = "m_DefinedObjectClass")] public DefinedObjectClass m_DefinedObjectClass { get; private set; }
		[DataMember (Name = "m_dot")] public SyntaxTreeToken m_dot { get; private set; }
		[DataMember (Name = "m_FieldName")] public FieldName m_FieldName { get; private set; }

		public enum __p1_markers
		{
			m1 = 1,
			m2 = 2,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectClassFieldType

		// delegate function (callback) prototype associated with syntax rule ObjectClassFieldType
		public delegate bool ObjectClassFieldType_Callback (SyntaxTreeCallbackReason reason, ObjectClassFieldType.production_kind kind, ObjectClassFieldType p_ObjectClassFieldType);

		// event associated with syntax rule ObjectClassFieldType
		public event ObjectClassFieldType_Callback ObjectClassFieldType_Event;

		// event trigger associated with syntax rule ObjectClassFieldType
		public bool Raise_ObjectClassFieldType_Event (SyntaxTreeCallbackReason reason, ObjectClassFieldType.production_kind kind, ObjectClassFieldType p_ObjectClassFieldType)
		{
			bool? status = ObjectClassFieldType_Event?.Invoke (reason, kind, p_ObjectClassFieldType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectClassFieldType
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectClassFieldType
		//

		public void Traverse (ObjectClassFieldType p_ObjectClassFieldType)
		{
			if (p_ObjectClassFieldType.isLocked())
				return;
			p_ObjectClassFieldType.dolock();
			ObjectClassFieldType.production_kind kind = (ObjectClassFieldType.production_kind) p_ObjectClassFieldType.kind;
			p_ObjectClassFieldType.turn_reset ();
			if (Raise_ObjectClassFieldType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectClassFieldType))
			switch (kind)
			{
				case ObjectClassFieldType.production_kind.g_ObjectClassFieldType_1:
					// traverse syntax tree node associated with production
					// ObjectClassFieldType: DefinedObjectClass "." FieldName

					if (Raise_ObjectClassFieldType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectClassFieldType))
						Traverse (p_ObjectClassFieldType.m_DefinedObjectClass);
					p_ObjectClassFieldType.turn_inc ();
					if (Raise_ObjectClassFieldType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectClassFieldType))
						Traverse (p_ObjectClassFieldType.m_FieldName);
					p_ObjectClassFieldType.turn_inc ();
					Raise_ObjectClassFieldType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectClassFieldType);
				break;
			}
			Raise_ObjectClassFieldType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectClassFieldType);
			p_ObjectClassFieldType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectClassFieldType
		//

		public void TraverseCommon (ObjectClassFieldType p_ObjectClassFieldType)
		{
			ObjectClassFieldType.production_kind kind = (ObjectClassFieldType.production_kind) p_ObjectClassFieldType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectClassFieldType))
			switch (kind)
			{
				case ObjectClassFieldType.production_kind.g_ObjectClassFieldType_1:
					// traverse syntax tree node associated with production
					// ObjectClassFieldType: DefinedObjectClass "." FieldName

						TraverseCommon (p_ObjectClassFieldType.m_DefinedObjectClass);
						TraverseCommon (p_ObjectClassFieldType.m_dot);
						TraverseCommon (p_ObjectClassFieldType.m_FieldName);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectClassFieldType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectClassFieldType

		//
		// create syntax tree node associated with production
		// ObjectClassFieldType: DefinedObjectClass "." FieldName

		//

		public ObjectClassFieldType ObjectClassFieldType_1 (DefinedObjectClass p_DefinedObjectClass, SyntaxTreeToken p_token, FieldName p_FieldName)
		{
			ObjectClassFieldType p_ObjectClassFieldType_ref = new ObjectClassFieldType(p_DefinedObjectClass, p_token, p_FieldName);
			p_DefinedObjectClass.parent = p_ObjectClassFieldType_ref;
			p_token.parent = p_ObjectClassFieldType_ref;
			p_FieldName.parent = p_ObjectClassFieldType_ref;
			Raise_ObjectClassFieldType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectClassFieldType.production_kind.g_ObjectClassFieldType_1, p_ObjectClassFieldType_ref);
			return p_ObjectClassFieldType_ref;
		}
		#endregion
	};
}
