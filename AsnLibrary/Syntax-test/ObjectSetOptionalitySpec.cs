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
	// class associated with syntax rule ObjectSetOptionalitySpec
	//

	[DataContract]
	public class	ObjectSetOptionalitySpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectSetOptionalitySpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectSetOptionalitySpec
		{
			g_ObjectSetOptionalitySpec_1 = 1,	// OPTIONAL

			g_ObjectSetOptionalitySpec_2 = 2,	// DEFAULT ObjectSet

		};
		#endregion
		#region production markers associated with the syntax rule ObjectSetOptionalitySpec

		// markers associated with production: ObjectSetOptionalitySpec -> OPTIONAL

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: ObjectSetOptionalitySpec -> DEFAULT ObjectSet

		public enum production_marker_2 : ushort
		{
			m_ObjectSet,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectSetOptionalitySpec

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectSetOptionalitySpec

		//
		// Constructor associated with the following production(s)
		// ObjectSetOptionalitySpec -> OPTIONAL

		//

		public ObjectSetOptionalitySpec (SyntaxTreeToken p_token) : base ((uint) ProductionID._ObjectSetOptionalitySpec_ID, (uint) production_kind.g_ObjectSetOptionalitySpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_OPTIONAL = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// ObjectSetOptionalitySpec -> DEFAULT ObjectSet

		//

		public ObjectSetOptionalitySpec (SyntaxTreeToken p_token, ObjectSet p_ObjectSet) : base ((uint) ProductionID._ObjectSetOptionalitySpec_ID, (uint) production_kind.g_ObjectSetOptionalitySpec_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_DEFAULT = p_token;
			children[1] = m_ObjectSet = p_ObjectSet;
		}

		public ObjectSetOptionalitySpec () { }

		// Copy constructor

		public ObjectSetOptionalitySpec (ObjectSetOptionalitySpec p_ObjectSetOptionalitySpec) : base (p_ObjectSetOptionalitySpec.id, p_ObjectSetOptionalitySpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectSetOptionalitySpec.appInfo;
			switch ((production_kind) p_ObjectSetOptionalitySpec.kind)
			{
				case production_kind.g_ObjectSetOptionalitySpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OPTIONAL = (p_ObjectSetOptionalitySpec.m_OPTIONAL != null) ? new SyntaxTreeToken (p_ObjectSetOptionalitySpec.m_OPTIONAL) : null) != null) m_OPTIONAL.parent = this;
					break;
				case production_kind.g_ObjectSetOptionalitySpec_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_DEFAULT = (p_ObjectSetOptionalitySpec.m_DEFAULT != null) ? new SyntaxTreeToken (p_ObjectSetOptionalitySpec.m_DEFAULT) : null) != null) m_DEFAULT.parent = this;
					if ((children [1] = m_ObjectSet = (p_ObjectSetOptionalitySpec.m_ObjectSet != null) ? new ObjectSet (p_ObjectSetOptionalitySpec.m_ObjectSet) : null) != null) m_ObjectSet.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectSetOptionalitySpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectSetOptionalitySpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_OPTIONAL?.Dispose ();
			m_DEFAULT?.Dispose ();
			m_ObjectSet?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectSetOptionalitySpec

		// Content changing function(s) associated with production(s) of syntax rule ObjectSetOptionalitySpec

		//
		// Content changing function associated with following production(s)
		// ObjectSetOptionalitySpec -> OPTIONAL

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectSetOptionalitySpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_OPTIONAL = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ObjectSetOptionalitySpec -> DEFAULT ObjectSet

		//

		public void change(SyntaxTreeToken p_token, ObjectSet p_ObjectSet)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectSetOptionalitySpec_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_DEFAULT = p_token;
			children [1] = m_ObjectSet = p_ObjectSet;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectSetOptionalitySpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_OPTIONAL != null) && m_OPTIONAL.checkInclusion (element) ||
				(m_DEFAULT != null) && m_DEFAULT.checkInclusion (element) ||
				(m_ObjectSet != null) && m_ObjectSet.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectSetOptionalitySpec

		//
		// emit production tree node associated with any production of syntax rule ObjectSetOptionalitySpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectSetOptionalitySpec_1:
					// emit syntax tree node associated with production
					// ObjectSetOptionalitySpec: OPTIONAL

					s += m_OPTIONAL.Emit (depth - 1);
				break;
				case production_kind.g_ObjectSetOptionalitySpec_2:
					// emit syntax tree node associated with production
					// ObjectSetOptionalitySpec: DEFAULT ObjectSet

					s += m_DEFAULT.Emit (depth - 1);
					s += " ";
					s += m_ObjectSet.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectSetOptionalitySpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectSetOptionalitySpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectSetOptionalitySpec_1:
					// emit syntax tree node associated with production
					// ObjectSetOptionalitySpec: OPTIONAL

					s += "OPTIONAL";
				break;
				case production_kind.g_ObjectSetOptionalitySpec_2:
					// emit syntax tree node associated with production
					// ObjectSetOptionalitySpec: DEFAULT ObjectSet

					s += "DEFAULT";
					s += ' ';
					s += m_ObjectSet.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectSetOptionalitySpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetOptionalitySpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectSetOptionalitySpec.production_kind kind = (ObjectSetOptionalitySpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectSetOptionalitySpec.production_kind.g_ObjectSetOptionalitySpec_1:
					// traverse syntax tree node associated with production
					// ObjectSetOptionalitySpec: OPTIONAL

						m_OPTIONAL.Visit (visitor, appData);
				break;
				case ObjectSetOptionalitySpec.production_kind.g_ObjectSetOptionalitySpec_2:
					// traverse syntax tree node associated with production
					// ObjectSetOptionalitySpec: DEFAULT ObjectSet

						m_DEFAULT.Visit (visitor, appData);
						m_ObjectSet.Visit (visitor, appData);
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
			m_ObjectSet?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectSetOptionalitySpec
		//

		public void _init ()
		{
			m_OPTIONAL = null;
			m_DEFAULT = null;
			m_ObjectSet = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectSetOptionalitySpec

		// counter of all nodes associated with syntax rule ObjectSetOptionalitySpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectSetOptionalitySpec
		[DataMember (Name = "m_OPTIONAL")] public SyntaxTreeToken m_OPTIONAL { get; private set; }
		[DataMember (Name = "m_DEFAULT")] public SyntaxTreeToken m_DEFAULT { get; private set; }
		[DataMember (Name = "m_ObjectSet")] public ObjectSet m_ObjectSet { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectSetOptionalitySpec

		// delegate function (callback) prototype associated with syntax rule ObjectSetOptionalitySpec
		public delegate bool ObjectSetOptionalitySpec_Callback (SyntaxTreeCallbackReason reason, ObjectSetOptionalitySpec.production_kind kind, ObjectSetOptionalitySpec p_ObjectSetOptionalitySpec);

		// event associated with syntax rule ObjectSetOptionalitySpec
		public event ObjectSetOptionalitySpec_Callback ObjectSetOptionalitySpec_Event;

		// event trigger associated with syntax rule ObjectSetOptionalitySpec
		public bool Raise_ObjectSetOptionalitySpec_Event (SyntaxTreeCallbackReason reason, ObjectSetOptionalitySpec.production_kind kind, ObjectSetOptionalitySpec p_ObjectSetOptionalitySpec)
		{
			bool? status = ObjectSetOptionalitySpec_Event?.Invoke (reason, kind, p_ObjectSetOptionalitySpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectSetOptionalitySpec
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetOptionalitySpec
		//

		public void Traverse (ObjectSetOptionalitySpec p_ObjectSetOptionalitySpec)
		{
			if (p_ObjectSetOptionalitySpec.isLocked())
				return;
			p_ObjectSetOptionalitySpec.dolock();
			ObjectSetOptionalitySpec.production_kind kind = (ObjectSetOptionalitySpec.production_kind) p_ObjectSetOptionalitySpec.kind;
			p_ObjectSetOptionalitySpec.turn_reset ();
			if (Raise_ObjectSetOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectSetOptionalitySpec))
			switch (kind)
			{
				case ObjectSetOptionalitySpec.production_kind.g_ObjectSetOptionalitySpec_1:
					// traverse syntax tree node associated with production
					// ObjectSetOptionalitySpec: OPTIONAL

				break;
				case ObjectSetOptionalitySpec.production_kind.g_ObjectSetOptionalitySpec_2:
					// traverse syntax tree node associated with production
					// ObjectSetOptionalitySpec: DEFAULT ObjectSet

					if (Raise_ObjectSetOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetOptionalitySpec))
						Traverse (p_ObjectSetOptionalitySpec.m_ObjectSet);
					p_ObjectSetOptionalitySpec.turn_inc ();
					Raise_ObjectSetOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetOptionalitySpec);
				break;
			}
			Raise_ObjectSetOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectSetOptionalitySpec);
			p_ObjectSetOptionalitySpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetOptionalitySpec
		//

		public void TraverseCommon (ObjectSetOptionalitySpec p_ObjectSetOptionalitySpec)
		{
			ObjectSetOptionalitySpec.production_kind kind = (ObjectSetOptionalitySpec.production_kind) p_ObjectSetOptionalitySpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectSetOptionalitySpec))
			switch (kind)
			{
				case ObjectSetOptionalitySpec.production_kind.g_ObjectSetOptionalitySpec_1:
					// traverse syntax tree node associated with production
					// ObjectSetOptionalitySpec: OPTIONAL

						TraverseCommon (p_ObjectSetOptionalitySpec.m_OPTIONAL);
				break;
				case ObjectSetOptionalitySpec.production_kind.g_ObjectSetOptionalitySpec_2:
					// traverse syntax tree node associated with production
					// ObjectSetOptionalitySpec: DEFAULT ObjectSet

						TraverseCommon (p_ObjectSetOptionalitySpec.m_DEFAULT);
						TraverseCommon (p_ObjectSetOptionalitySpec.m_ObjectSet);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectSetOptionalitySpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectSetOptionalitySpec

		//
		// create syntax tree node associated with production
		// ObjectSetOptionalitySpec: OPTIONAL

		//

		public ObjectSetOptionalitySpec ObjectSetOptionalitySpec_1 (SyntaxTreeToken p_token)
		{
			ObjectSetOptionalitySpec p_ObjectSetOptionalitySpec_ref = new ObjectSetOptionalitySpec(p_token);
			p_token.parent = p_ObjectSetOptionalitySpec_ref;
			Raise_ObjectSetOptionalitySpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectSetOptionalitySpec.production_kind.g_ObjectSetOptionalitySpec_1, p_ObjectSetOptionalitySpec_ref);
			return p_ObjectSetOptionalitySpec_ref;
		}

		//
		// create syntax tree node associated with production
		// ObjectSetOptionalitySpec: DEFAULT ObjectSet

		//

		public ObjectSetOptionalitySpec ObjectSetOptionalitySpec_2 (SyntaxTreeToken p_token, ObjectSet p_ObjectSet)
		{
			ObjectSetOptionalitySpec p_ObjectSetOptionalitySpec_ref = new ObjectSetOptionalitySpec(p_token, p_ObjectSet);
			p_token.parent = p_ObjectSetOptionalitySpec_ref;
			p_ObjectSet.parent = p_ObjectSetOptionalitySpec_ref;
			Raise_ObjectSetOptionalitySpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectSetOptionalitySpec.production_kind.g_ObjectSetOptionalitySpec_2, p_ObjectSetOptionalitySpec_ref);
			return p_ObjectSetOptionalitySpec_ref;
		}
		#endregion
	};
}
