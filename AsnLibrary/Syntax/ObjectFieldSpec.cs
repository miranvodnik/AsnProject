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
	// class associated with syntax rule ObjectFieldSpec
	//

	[DataContract]
	public class	ObjectFieldSpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectFieldSpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectFieldSpec
		{
			g_ObjectFieldSpec_1 = 1,	// objectfieldreference-token DefinedObjectClass ObjectOptionalitySpec-optional

		};
		#endregion
		#region production markers associated with the syntax rule ObjectFieldSpec

		// markers associated with production: ObjectFieldSpec -> objectfieldreference-token DefinedObjectClass ObjectOptionalitySpec-optional

		public enum production_marker_1 : ushort
		{
			m_objectfieldreference_token,
			m_DefinedObjectClass,
			m_ObjectOptionalitySpec_optional,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectFieldSpec

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectFieldSpec

		//
		// Constructor associated with the following production(s)
		// ObjectFieldSpec -> objectfieldreference-token DefinedObjectClass ObjectOptionalitySpec-optional

		//

		public ObjectFieldSpec (objectfieldreference_token p_objectfieldreference_token, DefinedObjectClass p_DefinedObjectClass, ObjectOptionalitySpec_optional p_ObjectOptionalitySpec_optional) : base ((uint) ProductionID._ObjectFieldSpec_ID, (uint) production_kind.g_ObjectFieldSpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_objectfieldreference_token = p_objectfieldreference_token;
			children[1] = m_DefinedObjectClass = p_DefinedObjectClass;
			children[2] = m_ObjectOptionalitySpec_optional = p_ObjectOptionalitySpec_optional;
		}

		public ObjectFieldSpec () { }

		// Copy constructor

		public ObjectFieldSpec (ObjectFieldSpec p_ObjectFieldSpec) : base (p_ObjectFieldSpec.id, p_ObjectFieldSpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectFieldSpec.appInfo;
			switch ((production_kind) p_ObjectFieldSpec.kind)
			{
				case production_kind.g_ObjectFieldSpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_objectfieldreference_token = (p_ObjectFieldSpec.m_objectfieldreference_token != null) ? new objectfieldreference_token (p_ObjectFieldSpec.m_objectfieldreference_token) : null) != null) m_objectfieldreference_token.parent = this;
					if ((children [1] = m_DefinedObjectClass = (p_ObjectFieldSpec.m_DefinedObjectClass != null) ? new DefinedObjectClass (p_ObjectFieldSpec.m_DefinedObjectClass) : null) != null) m_DefinedObjectClass.parent = this;
					if ((children [2] = m_ObjectOptionalitySpec_optional = (p_ObjectFieldSpec.m_ObjectOptionalitySpec_optional != null) ? new ObjectOptionalitySpec_optional (p_ObjectFieldSpec.m_ObjectOptionalitySpec_optional) : null) != null) m_ObjectOptionalitySpec_optional.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectFieldSpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectFieldSpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_objectfieldreference_token?.Dispose ();
			m_DefinedObjectClass?.Dispose ();
			m_ObjectOptionalitySpec_optional?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectFieldSpec

		// Content changing function(s) associated with production(s) of syntax rule ObjectFieldSpec

		//
		// Content changing function associated with following production(s)
		// ObjectFieldSpec -> objectfieldreference-token DefinedObjectClass ObjectOptionalitySpec-optional

		//

		public void change(objectfieldreference_token p_objectfieldreference_token, DefinedObjectClass p_DefinedObjectClass, ObjectOptionalitySpec_optional p_ObjectOptionalitySpec_optional)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectFieldSpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_objectfieldreference_token = p_objectfieldreference_token;
			children [1] = m_DefinedObjectClass = p_DefinedObjectClass;
			children [2] = m_ObjectOptionalitySpec_optional = p_ObjectOptionalitySpec_optional;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectFieldSpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_objectfieldreference_token != null) && m_objectfieldreference_token.checkInclusion (element) ||
				(m_DefinedObjectClass != null) && m_DefinedObjectClass.checkInclusion (element) ||
				(m_ObjectOptionalitySpec_optional != null) && m_ObjectOptionalitySpec_optional.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectFieldSpec

		//
		// emit production tree node associated with any production of syntax rule ObjectFieldSpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectFieldSpec_1:
					// emit syntax tree node associated with production
					// ObjectFieldSpec: objectfieldreference-token DefinedObjectClass ObjectOptionalitySpec-optional

					s += m_objectfieldreference_token.Emit (depth - 1);
					s += " ";
					s += m_DefinedObjectClass.Emit (depth - 1);
					s += " ";
					s += m_ObjectOptionalitySpec_optional.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectFieldSpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectFieldSpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectFieldSpec_1:
					// emit syntax tree node associated with production
					// ObjectFieldSpec: objectfieldreference-token DefinedObjectClass ObjectOptionalitySpec-optional

					s += m_objectfieldreference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_DefinedObjectClass.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ObjectOptionalitySpec_optional.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectFieldSpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectFieldSpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectFieldSpec.production_kind kind = (ObjectFieldSpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectFieldSpec.production_kind.g_ObjectFieldSpec_1:
					// traverse syntax tree node associated with production
					// ObjectFieldSpec: objectfieldreference-token DefinedObjectClass ObjectOptionalitySpec-optional

						m_objectfieldreference_token.Visit (visitor, appData);
						m_DefinedObjectClass.Visit (visitor, appData);
						m_ObjectOptionalitySpec_optional.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_objectfieldreference_token?.reparent (this);
			m_DefinedObjectClass?.reparent (this);
			m_ObjectOptionalitySpec_optional?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectFieldSpec
		//

		public void _init ()
		{
			m_objectfieldreference_token = null;
			m_DefinedObjectClass = null;
			m_ObjectOptionalitySpec_optional = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectFieldSpec

		// counter of all nodes associated with syntax rule ObjectFieldSpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectFieldSpec
		[DataMember (Name = "m_objectfieldreference_token")] public objectfieldreference_token m_objectfieldreference_token { get; private set; }
		[DataMember (Name = "m_DefinedObjectClass")] public DefinedObjectClass m_DefinedObjectClass { get; private set; }
		[DataMember (Name = "m_ObjectOptionalitySpec_optional")] public ObjectOptionalitySpec_optional m_ObjectOptionalitySpec_optional { get; private set; }

		public enum __field_markers
		{
			push_governor = 2,
			pop_governor = 3,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectFieldSpec

		// delegate function (callback) prototype associated with syntax rule ObjectFieldSpec
		public delegate bool ObjectFieldSpec_Callback (SyntaxTreeCallbackReason reason, ObjectFieldSpec.production_kind kind, ObjectFieldSpec p_ObjectFieldSpec);

		// event associated with syntax rule ObjectFieldSpec
		public event ObjectFieldSpec_Callback ObjectFieldSpec_Event;

		// event trigger associated with syntax rule ObjectFieldSpec
		public bool Raise_ObjectFieldSpec_Event (SyntaxTreeCallbackReason reason, ObjectFieldSpec.production_kind kind, ObjectFieldSpec p_ObjectFieldSpec)
		{
			bool? status = ObjectFieldSpec_Event?.Invoke (reason, kind, p_ObjectFieldSpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectFieldSpec
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectFieldSpec
		//

		public void Traverse (ObjectFieldSpec p_ObjectFieldSpec)
		{
			if (p_ObjectFieldSpec.isLocked())
				return;
			p_ObjectFieldSpec.dolock();
			ObjectFieldSpec.production_kind kind = (ObjectFieldSpec.production_kind) p_ObjectFieldSpec.kind;
			p_ObjectFieldSpec.turn_reset ();
			if (Raise_ObjectFieldSpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectFieldSpec))
			switch (kind)
			{
				case ObjectFieldSpec.production_kind.g_ObjectFieldSpec_1:
					// traverse syntax tree node associated with production
					// ObjectFieldSpec: objectfieldreference-token DefinedObjectClass ObjectOptionalitySpec-optional

					if (Raise_ObjectFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectFieldSpec))
						Traverse (p_ObjectFieldSpec.m_objectfieldreference_token);
					p_ObjectFieldSpec.turn_inc ();
					if (Raise_ObjectFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectFieldSpec))
						Traverse (p_ObjectFieldSpec.m_DefinedObjectClass);
					p_ObjectFieldSpec.turn_inc ();
					if (Raise_ObjectFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectFieldSpec))
						Traverse (p_ObjectFieldSpec.m_ObjectOptionalitySpec_optional);
					p_ObjectFieldSpec.turn_inc ();
					Raise_ObjectFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectFieldSpec);
				break;
			}
			Raise_ObjectFieldSpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectFieldSpec);
			p_ObjectFieldSpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectFieldSpec
		//

		public void TraverseCommon (ObjectFieldSpec p_ObjectFieldSpec)
		{
			ObjectFieldSpec.production_kind kind = (ObjectFieldSpec.production_kind) p_ObjectFieldSpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectFieldSpec))
			switch (kind)
			{
				case ObjectFieldSpec.production_kind.g_ObjectFieldSpec_1:
					// traverse syntax tree node associated with production
					// ObjectFieldSpec: objectfieldreference-token DefinedObjectClass ObjectOptionalitySpec-optional

						TraverseCommon (p_ObjectFieldSpec.m_objectfieldreference_token);
						TraverseCommon (p_ObjectFieldSpec.m_DefinedObjectClass);
						TraverseCommon (p_ObjectFieldSpec.m_ObjectOptionalitySpec_optional);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectFieldSpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectFieldSpec

		//
		// create syntax tree node associated with production
		// ObjectFieldSpec: objectfieldreference-token DefinedObjectClass ObjectOptionalitySpec-optional

		//

		public ObjectFieldSpec ObjectFieldSpec_1 (objectfieldreference_token p_objectfieldreference_token, DefinedObjectClass p_DefinedObjectClass, ObjectOptionalitySpec_optional p_ObjectOptionalitySpec_optional)
		{
			ObjectFieldSpec p_ObjectFieldSpec_ref = new ObjectFieldSpec(p_objectfieldreference_token, p_DefinedObjectClass, p_ObjectOptionalitySpec_optional);
			p_objectfieldreference_token.parent = p_ObjectFieldSpec_ref;
			p_DefinedObjectClass.parent = p_ObjectFieldSpec_ref;
			p_ObjectOptionalitySpec_optional.parent = p_ObjectFieldSpec_ref;
			Raise_ObjectFieldSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectFieldSpec.production_kind.g_ObjectFieldSpec_1, p_ObjectFieldSpec_ref);
			return p_ObjectFieldSpec_ref;
		}
		#endregion
	};
}
