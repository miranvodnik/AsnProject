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
	// class associated with syntax rule ObjectSetFieldSpec
	//

	[DataContract]
	public class	ObjectSetFieldSpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectSetFieldSpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectSetFieldSpec
		{
			g_ObjectSetFieldSpec_1 = 1,	// objectsetfieldreference-token DefinedObjectClass ObjectSetOptionalitySpec-optional

		};
		#endregion
		#region production markers associated with the syntax rule ObjectSetFieldSpec

		// markers associated with production: ObjectSetFieldSpec -> objectsetfieldreference-token DefinedObjectClass ObjectSetOptionalitySpec-optional

		public enum production_marker_1 : ushort
		{
			m_objectsetfieldreference_token,
			m_DefinedObjectClass,
			m_ObjectSetOptionalitySpec_optional,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectSetFieldSpec

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectSetFieldSpec

		//
		// Constructor associated with the following production(s)
		// ObjectSetFieldSpec -> objectsetfieldreference-token DefinedObjectClass ObjectSetOptionalitySpec-optional

		//

		public ObjectSetFieldSpec (objectsetfieldreference_token p_objectsetfieldreference_token, DefinedObjectClass p_DefinedObjectClass, ObjectSetOptionalitySpec_optional p_ObjectSetOptionalitySpec_optional) : base ((uint) ProductionID._ObjectSetFieldSpec_ID, (uint) production_kind.g_ObjectSetFieldSpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_objectsetfieldreference_token = p_objectsetfieldreference_token;
			children[1] = m_DefinedObjectClass = p_DefinedObjectClass;
			children[2] = m_ObjectSetOptionalitySpec_optional = p_ObjectSetOptionalitySpec_optional;
		}

		public ObjectSetFieldSpec () { }

		// Copy constructor

		public ObjectSetFieldSpec (ObjectSetFieldSpec p_ObjectSetFieldSpec) : base (p_ObjectSetFieldSpec.id, p_ObjectSetFieldSpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectSetFieldSpec.appInfo;
			switch ((production_kind) p_ObjectSetFieldSpec.kind)
			{
				case production_kind.g_ObjectSetFieldSpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_objectsetfieldreference_token = (p_ObjectSetFieldSpec.m_objectsetfieldreference_token != null) ? new objectsetfieldreference_token (p_ObjectSetFieldSpec.m_objectsetfieldreference_token) : null) != null) m_objectsetfieldreference_token.parent = this;
					if ((children [1] = m_DefinedObjectClass = (p_ObjectSetFieldSpec.m_DefinedObjectClass != null) ? new DefinedObjectClass (p_ObjectSetFieldSpec.m_DefinedObjectClass) : null) != null) m_DefinedObjectClass.parent = this;
					if ((children [2] = m_ObjectSetOptionalitySpec_optional = (p_ObjectSetFieldSpec.m_ObjectSetOptionalitySpec_optional != null) ? new ObjectSetOptionalitySpec_optional (p_ObjectSetFieldSpec.m_ObjectSetOptionalitySpec_optional) : null) != null) m_ObjectSetOptionalitySpec_optional.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectSetFieldSpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectSetFieldSpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_objectsetfieldreference_token?.Dispose ();
			m_DefinedObjectClass?.Dispose ();
			m_ObjectSetOptionalitySpec_optional?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectSetFieldSpec

		// Content changing function(s) associated with production(s) of syntax rule ObjectSetFieldSpec

		//
		// Content changing function associated with following production(s)
		// ObjectSetFieldSpec -> objectsetfieldreference-token DefinedObjectClass ObjectSetOptionalitySpec-optional

		//

		public void change(objectsetfieldreference_token p_objectsetfieldreference_token, DefinedObjectClass p_DefinedObjectClass, ObjectSetOptionalitySpec_optional p_ObjectSetOptionalitySpec_optional)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectSetFieldSpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_objectsetfieldreference_token = p_objectsetfieldreference_token;
			children [1] = m_DefinedObjectClass = p_DefinedObjectClass;
			children [2] = m_ObjectSetOptionalitySpec_optional = p_ObjectSetOptionalitySpec_optional;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectSetFieldSpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_objectsetfieldreference_token != null) && m_objectsetfieldreference_token.checkInclusion (element) ||
				(m_DefinedObjectClass != null) && m_DefinedObjectClass.checkInclusion (element) ||
				(m_ObjectSetOptionalitySpec_optional != null) && m_ObjectSetOptionalitySpec_optional.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectSetFieldSpec

		//
		// emit production tree node associated with any production of syntax rule ObjectSetFieldSpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectSetFieldSpec_1:
					// emit syntax tree node associated with production
					// ObjectSetFieldSpec: objectsetfieldreference-token DefinedObjectClass ObjectSetOptionalitySpec-optional

					s += m_objectsetfieldreference_token.Emit (depth - 1);
					s += " ";
					s += m_DefinedObjectClass.Emit (depth - 1);
					s += " ";
					s += m_ObjectSetOptionalitySpec_optional.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectSetFieldSpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectSetFieldSpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectSetFieldSpec_1:
					// emit syntax tree node associated with production
					// ObjectSetFieldSpec: objectsetfieldreference-token DefinedObjectClass ObjectSetOptionalitySpec-optional

					s += m_objectsetfieldreference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_DefinedObjectClass.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ObjectSetOptionalitySpec_optional.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectSetFieldSpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetFieldSpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectSetFieldSpec.production_kind kind = (ObjectSetFieldSpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectSetFieldSpec.production_kind.g_ObjectSetFieldSpec_1:
					// traverse syntax tree node associated with production
					// ObjectSetFieldSpec: objectsetfieldreference-token DefinedObjectClass ObjectSetOptionalitySpec-optional

						m_objectsetfieldreference_token.Visit (visitor, appData);
						m_DefinedObjectClass.Visit (visitor, appData);
						m_ObjectSetOptionalitySpec_optional.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_objectsetfieldreference_token?.reparent (this);
			m_DefinedObjectClass?.reparent (this);
			m_ObjectSetOptionalitySpec_optional?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectSetFieldSpec
		//

		public void _init ()
		{
			m_objectsetfieldreference_token = null;
			m_DefinedObjectClass = null;
			m_ObjectSetOptionalitySpec_optional = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectSetFieldSpec

		// counter of all nodes associated with syntax rule ObjectSetFieldSpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectSetFieldSpec
		[DataMember (Name = "m_objectsetfieldreference_token")] public objectsetfieldreference_token m_objectsetfieldreference_token { get; private set; }
		[DataMember (Name = "m_DefinedObjectClass")] public DefinedObjectClass m_DefinedObjectClass { get; private set; }
		[DataMember (Name = "m_ObjectSetOptionalitySpec_optional")] public ObjectSetOptionalitySpec_optional m_ObjectSetOptionalitySpec_optional { get; private set; }

		public enum __field_markers
		{
			push_governor = 2,
			pop_governor = 3,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectSetFieldSpec

		// delegate function (callback) prototype associated with syntax rule ObjectSetFieldSpec
		public delegate bool ObjectSetFieldSpec_Callback (SyntaxTreeCallbackReason reason, ObjectSetFieldSpec.production_kind kind, ObjectSetFieldSpec p_ObjectSetFieldSpec);

		// event associated with syntax rule ObjectSetFieldSpec
		public event ObjectSetFieldSpec_Callback ObjectSetFieldSpec_Event;

		// event trigger associated with syntax rule ObjectSetFieldSpec
		public bool Raise_ObjectSetFieldSpec_Event (SyntaxTreeCallbackReason reason, ObjectSetFieldSpec.production_kind kind, ObjectSetFieldSpec p_ObjectSetFieldSpec)
		{
			bool? status = ObjectSetFieldSpec_Event?.Invoke (reason, kind, p_ObjectSetFieldSpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectSetFieldSpec
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetFieldSpec
		//

		public void Traverse (ObjectSetFieldSpec p_ObjectSetFieldSpec)
		{
			if (p_ObjectSetFieldSpec.isLocked())
				return;
			p_ObjectSetFieldSpec.dolock();
			ObjectSetFieldSpec.production_kind kind = (ObjectSetFieldSpec.production_kind) p_ObjectSetFieldSpec.kind;
			p_ObjectSetFieldSpec.turn_reset ();
			if (Raise_ObjectSetFieldSpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectSetFieldSpec))
			switch (kind)
			{
				case ObjectSetFieldSpec.production_kind.g_ObjectSetFieldSpec_1:
					// traverse syntax tree node associated with production
					// ObjectSetFieldSpec: objectsetfieldreference-token DefinedObjectClass ObjectSetOptionalitySpec-optional

					if (Raise_ObjectSetFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetFieldSpec))
						Traverse (p_ObjectSetFieldSpec.m_objectsetfieldreference_token);
					p_ObjectSetFieldSpec.turn_inc ();
					if (Raise_ObjectSetFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetFieldSpec))
						Traverse (p_ObjectSetFieldSpec.m_DefinedObjectClass);
					p_ObjectSetFieldSpec.turn_inc ();
					if (Raise_ObjectSetFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetFieldSpec))
						Traverse (p_ObjectSetFieldSpec.m_ObjectSetOptionalitySpec_optional);
					p_ObjectSetFieldSpec.turn_inc ();
					Raise_ObjectSetFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetFieldSpec);
				break;
			}
			Raise_ObjectSetFieldSpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectSetFieldSpec);
			p_ObjectSetFieldSpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetFieldSpec
		//

		public void TraverseCommon (ObjectSetFieldSpec p_ObjectSetFieldSpec)
		{
			ObjectSetFieldSpec.production_kind kind = (ObjectSetFieldSpec.production_kind) p_ObjectSetFieldSpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectSetFieldSpec))
			switch (kind)
			{
				case ObjectSetFieldSpec.production_kind.g_ObjectSetFieldSpec_1:
					// traverse syntax tree node associated with production
					// ObjectSetFieldSpec: objectsetfieldreference-token DefinedObjectClass ObjectSetOptionalitySpec-optional

						TraverseCommon (p_ObjectSetFieldSpec.m_objectsetfieldreference_token);
						TraverseCommon (p_ObjectSetFieldSpec.m_DefinedObjectClass);
						TraverseCommon (p_ObjectSetFieldSpec.m_ObjectSetOptionalitySpec_optional);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectSetFieldSpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectSetFieldSpec

		//
		// create syntax tree node associated with production
		// ObjectSetFieldSpec: objectsetfieldreference-token DefinedObjectClass ObjectSetOptionalitySpec-optional

		//

		public ObjectSetFieldSpec ObjectSetFieldSpec_1 (objectsetfieldreference_token p_objectsetfieldreference_token, DefinedObjectClass p_DefinedObjectClass, ObjectSetOptionalitySpec_optional p_ObjectSetOptionalitySpec_optional)
		{
			ObjectSetFieldSpec p_ObjectSetFieldSpec_ref = new ObjectSetFieldSpec(p_objectsetfieldreference_token, p_DefinedObjectClass, p_ObjectSetOptionalitySpec_optional);
			p_objectsetfieldreference_token.parent = p_ObjectSetFieldSpec_ref;
			p_DefinedObjectClass.parent = p_ObjectSetFieldSpec_ref;
			p_ObjectSetOptionalitySpec_optional.parent = p_ObjectSetFieldSpec_ref;
			Raise_ObjectSetFieldSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectSetFieldSpec.production_kind.g_ObjectSetFieldSpec_1, p_ObjectSetFieldSpec_ref);
			return p_ObjectSetFieldSpec_ref;
		}
		#endregion
	};
}
