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
	// class associated with syntax rule ObjectOptionalitySpec
	//

	[DataContract]
	public class	ObjectOptionalitySpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectOptionalitySpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectOptionalitySpec
		{
			g_ObjectOptionalitySpec_1 = 1,	// OPTIONAL

			g_ObjectOptionalitySpec_2 = 2,	// DEFAULT Object

		};
		#endregion
		#region production markers associated with the syntax rule ObjectOptionalitySpec

		// markers associated with production: ObjectOptionalitySpec -> OPTIONAL

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: ObjectOptionalitySpec -> DEFAULT Object

		public enum production_marker_2 : ushort
		{
			m_Object,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectOptionalitySpec

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectOptionalitySpec

		//
		// Constructor associated with the following production(s)
		// ObjectOptionalitySpec -> OPTIONAL

		//

		public ObjectOptionalitySpec (SyntaxTreeToken p_token) : base ((uint) ProductionID._ObjectOptionalitySpec_ID, (uint) production_kind.g_ObjectOptionalitySpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_OPTIONAL = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// ObjectOptionalitySpec -> DEFAULT Object

		//

		public ObjectOptionalitySpec (SyntaxTreeToken p_token, Object p_Object) : base ((uint) ProductionID._ObjectOptionalitySpec_ID, (uint) production_kind.g_ObjectOptionalitySpec_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_DEFAULT = p_token;
			children[1] = m_Object = p_Object;
		}

		public ObjectOptionalitySpec () { }

		// Copy constructor

		public ObjectOptionalitySpec (ObjectOptionalitySpec p_ObjectOptionalitySpec) : base (p_ObjectOptionalitySpec.id, p_ObjectOptionalitySpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectOptionalitySpec.appInfo;
			switch ((production_kind) p_ObjectOptionalitySpec.kind)
			{
				case production_kind.g_ObjectOptionalitySpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OPTIONAL = (p_ObjectOptionalitySpec.m_OPTIONAL != null) ? new SyntaxTreeToken (p_ObjectOptionalitySpec.m_OPTIONAL) : null) != null) m_OPTIONAL.parent = this;
					break;
				case production_kind.g_ObjectOptionalitySpec_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_DEFAULT = (p_ObjectOptionalitySpec.m_DEFAULT != null) ? new SyntaxTreeToken (p_ObjectOptionalitySpec.m_DEFAULT) : null) != null) m_DEFAULT.parent = this;
					if ((children [1] = m_Object = (p_ObjectOptionalitySpec.m_Object != null) ? new Object (p_ObjectOptionalitySpec.m_Object) : null) != null) m_Object.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectOptionalitySpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectOptionalitySpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_OPTIONAL?.Dispose ();
			m_DEFAULT?.Dispose ();
			m_Object?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectOptionalitySpec

		// Content changing function(s) associated with production(s) of syntax rule ObjectOptionalitySpec

		//
		// Content changing function associated with following production(s)
		// ObjectOptionalitySpec -> OPTIONAL

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectOptionalitySpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_OPTIONAL = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ObjectOptionalitySpec -> DEFAULT Object

		//

		public void change(SyntaxTreeToken p_token, Object p_Object)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectOptionalitySpec_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_DEFAULT = p_token;
			children [1] = m_Object = p_Object;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectOptionalitySpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_OPTIONAL != null) && m_OPTIONAL.checkInclusion (element) ||
				(m_DEFAULT != null) && m_DEFAULT.checkInclusion (element) ||
				(m_Object != null) && m_Object.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectOptionalitySpec

		//
		// emit production tree node associated with any production of syntax rule ObjectOptionalitySpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectOptionalitySpec_1:
					// emit syntax tree node associated with production
					// ObjectOptionalitySpec: OPTIONAL

					s += m_OPTIONAL.Emit (depth - 1);
				break;
				case production_kind.g_ObjectOptionalitySpec_2:
					// emit syntax tree node associated with production
					// ObjectOptionalitySpec: DEFAULT Object

					s += m_DEFAULT.Emit (depth - 1);
					s += " ";
					s += m_Object.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectOptionalitySpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectOptionalitySpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectOptionalitySpec_1:
					// emit syntax tree node associated with production
					// ObjectOptionalitySpec: OPTIONAL

					s += "OPTIONAL";
				break;
				case production_kind.g_ObjectOptionalitySpec_2:
					// emit syntax tree node associated with production
					// ObjectOptionalitySpec: DEFAULT Object

					s += "DEFAULT";
					s += ' ';
					s += m_Object.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectOptionalitySpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectOptionalitySpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectOptionalitySpec.production_kind kind = (ObjectOptionalitySpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectOptionalitySpec.production_kind.g_ObjectOptionalitySpec_1:
					// traverse syntax tree node associated with production
					// ObjectOptionalitySpec: OPTIONAL

						m_OPTIONAL.Visit (visitor, appData);
				break;
				case ObjectOptionalitySpec.production_kind.g_ObjectOptionalitySpec_2:
					// traverse syntax tree node associated with production
					// ObjectOptionalitySpec: DEFAULT Object

						m_DEFAULT.Visit (visitor, appData);
						m_Object.Visit (visitor, appData);
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
			m_Object?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectOptionalitySpec
		//

		public void _init ()
		{
			m_OPTIONAL = null;
			m_DEFAULT = null;
			m_Object = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectOptionalitySpec

		// counter of all nodes associated with syntax rule ObjectOptionalitySpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectOptionalitySpec
		[DataMember (Name = "m_OPTIONAL")] public SyntaxTreeToken m_OPTIONAL { get; private set; }
		[DataMember (Name = "m_DEFAULT")] public SyntaxTreeToken m_DEFAULT { get; private set; }
		[DataMember (Name = "m_Object")] public Object m_Object { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectOptionalitySpec

		// delegate function (callback) prototype associated with syntax rule ObjectOptionalitySpec
		public delegate bool ObjectOptionalitySpec_Callback (SyntaxTreeCallbackReason reason, ObjectOptionalitySpec.production_kind kind, ObjectOptionalitySpec p_ObjectOptionalitySpec);

		// event associated with syntax rule ObjectOptionalitySpec
		public event ObjectOptionalitySpec_Callback ObjectOptionalitySpec_Event;

		// event trigger associated with syntax rule ObjectOptionalitySpec
		public bool Raise_ObjectOptionalitySpec_Event (SyntaxTreeCallbackReason reason, ObjectOptionalitySpec.production_kind kind, ObjectOptionalitySpec p_ObjectOptionalitySpec)
		{
			bool? status = ObjectOptionalitySpec_Event?.Invoke (reason, kind, p_ObjectOptionalitySpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectOptionalitySpec
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectOptionalitySpec
		//

		public void Traverse (ObjectOptionalitySpec p_ObjectOptionalitySpec)
		{
			if (p_ObjectOptionalitySpec.isLocked())
				return;
			p_ObjectOptionalitySpec.dolock();
			ObjectOptionalitySpec.production_kind kind = (ObjectOptionalitySpec.production_kind) p_ObjectOptionalitySpec.kind;
			p_ObjectOptionalitySpec.turn_reset ();
			if (Raise_ObjectOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectOptionalitySpec))
			switch (kind)
			{
				case ObjectOptionalitySpec.production_kind.g_ObjectOptionalitySpec_1:
					// traverse syntax tree node associated with production
					// ObjectOptionalitySpec: OPTIONAL

				break;
				case ObjectOptionalitySpec.production_kind.g_ObjectOptionalitySpec_2:
					// traverse syntax tree node associated with production
					// ObjectOptionalitySpec: DEFAULT Object

					if (Raise_ObjectOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectOptionalitySpec))
						Traverse (p_ObjectOptionalitySpec.m_Object);
					p_ObjectOptionalitySpec.turn_inc ();
					Raise_ObjectOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectOptionalitySpec);
				break;
			}
			Raise_ObjectOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectOptionalitySpec);
			p_ObjectOptionalitySpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectOptionalitySpec
		//

		public void TraverseCommon (ObjectOptionalitySpec p_ObjectOptionalitySpec)
		{
			ObjectOptionalitySpec.production_kind kind = (ObjectOptionalitySpec.production_kind) p_ObjectOptionalitySpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectOptionalitySpec))
			switch (kind)
			{
				case ObjectOptionalitySpec.production_kind.g_ObjectOptionalitySpec_1:
					// traverse syntax tree node associated with production
					// ObjectOptionalitySpec: OPTIONAL

						TraverseCommon (p_ObjectOptionalitySpec.m_OPTIONAL);
				break;
				case ObjectOptionalitySpec.production_kind.g_ObjectOptionalitySpec_2:
					// traverse syntax tree node associated with production
					// ObjectOptionalitySpec: DEFAULT Object

						TraverseCommon (p_ObjectOptionalitySpec.m_DEFAULT);
						TraverseCommon (p_ObjectOptionalitySpec.m_Object);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectOptionalitySpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectOptionalitySpec

		//
		// create syntax tree node associated with production
		// ObjectOptionalitySpec: OPTIONAL

		//

		public ObjectOptionalitySpec ObjectOptionalitySpec_1 (SyntaxTreeToken p_token)
		{
			ObjectOptionalitySpec p_ObjectOptionalitySpec_ref = new ObjectOptionalitySpec(p_token);
			p_token.parent = p_ObjectOptionalitySpec_ref;
			Raise_ObjectOptionalitySpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectOptionalitySpec.production_kind.g_ObjectOptionalitySpec_1, p_ObjectOptionalitySpec_ref);
			return p_ObjectOptionalitySpec_ref;
		}

		//
		// create syntax tree node associated with production
		// ObjectOptionalitySpec: DEFAULT Object

		//

		public ObjectOptionalitySpec ObjectOptionalitySpec_2 (SyntaxTreeToken p_token, Object p_Object)
		{
			ObjectOptionalitySpec p_ObjectOptionalitySpec_ref = new ObjectOptionalitySpec(p_token, p_Object);
			p_token.parent = p_ObjectOptionalitySpec_ref;
			p_Object.parent = p_ObjectOptionalitySpec_ref;
			Raise_ObjectOptionalitySpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectOptionalitySpec.production_kind.g_ObjectOptionalitySpec_2, p_ObjectOptionalitySpec_ref);
			return p_ObjectOptionalitySpec_ref;
		}
		#endregion
	};
}
