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
	// class associated with syntax rule ObjectSetOptionalitySpec-optional
	//

	[DataContract]
	public class	ObjectSetOptionalitySpec_optional : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectSetOptionalitySpec-optional
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectSetOptionalitySpec-optional
		{
			g_ObjectSetOptionalitySpec_optional_1 = 1,	// %empty

			g_ObjectSetOptionalitySpec_optional_2 = 2,	// ObjectSetOptionalitySpec

		};
		#endregion
		#region production markers associated with the syntax rule ObjectSetOptionalitySpec-optional

		// markers associated with production: ObjectSetOptionalitySpec-optional -> %empty

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: ObjectSetOptionalitySpec-optional -> ObjectSetOptionalitySpec

		public enum production_marker_2 : ushort
		{
			m_ObjectSetOptionalitySpec,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectSetOptionalitySpec-optional

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectSetOptionalitySpec-optional

		//
		// Constructor associated with the following production(s)
		// ObjectSetOptionalitySpec-optional -> %empty

		//

		public ObjectSetOptionalitySpec_optional () : base ((uint) ProductionID._ObjectSetOptionalitySpec_optional_ID, (uint) production_kind.g_ObjectSetOptionalitySpec_optional_1)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		//
		// Constructor associated with the following production(s)
		// ObjectSetOptionalitySpec-optional -> ObjectSetOptionalitySpec

		//

		public ObjectSetOptionalitySpec_optional (ObjectSetOptionalitySpec p_ObjectSetOptionalitySpec) : base ((uint) ProductionID._ObjectSetOptionalitySpec_optional_ID, (uint) production_kind.g_ObjectSetOptionalitySpec_optional_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjectSetOptionalitySpec = p_ObjectSetOptionalitySpec;
		}

		// Copy constructor

		public ObjectSetOptionalitySpec_optional (ObjectSetOptionalitySpec_optional p_ObjectSetOptionalitySpec_optional) : base (p_ObjectSetOptionalitySpec_optional.id, p_ObjectSetOptionalitySpec_optional.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectSetOptionalitySpec_optional.appInfo;
			switch ((production_kind) p_ObjectSetOptionalitySpec_optional.kind)
			{
				case production_kind.g_ObjectSetOptionalitySpec_optional_1:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				case production_kind.g_ObjectSetOptionalitySpec_optional_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectSetOptionalitySpec = (p_ObjectSetOptionalitySpec_optional.m_ObjectSetOptionalitySpec != null) ? new ObjectSetOptionalitySpec (p_ObjectSetOptionalitySpec_optional.m_ObjectSetOptionalitySpec) : null) != null) m_ObjectSetOptionalitySpec.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectSetOptionalitySpec_optional" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectSetOptionalitySpec_optional (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ObjectSetOptionalitySpec?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectSetOptionalitySpec-optional

		// Content changing function(s) associated with production(s) of syntax rule ObjectSetOptionalitySpec-optional

		//
		// Content changing function associated with following production(s)
		// ObjectSetOptionalitySpec-optional -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectSetOptionalitySpec_optional_1;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ObjectSetOptionalitySpec-optional -> ObjectSetOptionalitySpec

		//

		public void change(ObjectSetOptionalitySpec p_ObjectSetOptionalitySpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectSetOptionalitySpec_optional_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjectSetOptionalitySpec = p_ObjectSetOptionalitySpec;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectSetOptionalitySpec-optional
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ObjectSetOptionalitySpec != null) && m_ObjectSetOptionalitySpec.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectSetOptionalitySpec-optional

		//
		// emit production tree node associated with any production of syntax rule ObjectSetOptionalitySpec-optional
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectSetOptionalitySpec_optional_1:
					// emit syntax tree node associated with production
					// ObjectSetOptionalitySpec-optional: %empty

				break;
				case production_kind.g_ObjectSetOptionalitySpec_optional_2:
					// emit syntax tree node associated with production
					// ObjectSetOptionalitySpec-optional: ObjectSetOptionalitySpec

					s += m_ObjectSetOptionalitySpec.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectSetOptionalitySpec-optional
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectSetOptionalitySpec_optional (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectSetOptionalitySpec_optional_1:
					// emit syntax tree node associated with production
					// ObjectSetOptionalitySpec-optional: %empty

				break;
				case production_kind.g_ObjectSetOptionalitySpec_optional_2:
					// emit syntax tree node associated with production
					// ObjectSetOptionalitySpec-optional: ObjectSetOptionalitySpec

					s += m_ObjectSetOptionalitySpec.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectSetOptionalitySpec-optional

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetOptionalitySpec-optional with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectSetOptionalitySpec_optional.production_kind kind = (ObjectSetOptionalitySpec_optional.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectSetOptionalitySpec_optional.production_kind.g_ObjectSetOptionalitySpec_optional_1:
					// traverse syntax tree node associated with production
					// ObjectSetOptionalitySpec-optional: %empty

				break;
				case ObjectSetOptionalitySpec_optional.production_kind.g_ObjectSetOptionalitySpec_optional_2:
					// traverse syntax tree node associated with production
					// ObjectSetOptionalitySpec-optional: ObjectSetOptionalitySpec

						m_ObjectSetOptionalitySpec.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ObjectSetOptionalitySpec?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectSetOptionalitySpec-optional
		//

		public void _init ()
		{
			m_ObjectSetOptionalitySpec = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectSetOptionalitySpec-optional

		// counter of all nodes associated with syntax rule ObjectSetOptionalitySpec-optional
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectSetOptionalitySpec-optional
		[DataMember (Name = "m_ObjectSetOptionalitySpec")] public ObjectSetOptionalitySpec m_ObjectSetOptionalitySpec { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectSetOptionalitySpec-optional

		// delegate function (callback) prototype associated with syntax rule ObjectSetOptionalitySpec-optional
		public delegate bool ObjectSetOptionalitySpec_optional_Callback (SyntaxTreeCallbackReason reason, ObjectSetOptionalitySpec_optional.production_kind kind, ObjectSetOptionalitySpec_optional p_ObjectSetOptionalitySpec_optional);

		// event associated with syntax rule ObjectSetOptionalitySpec-optional
		public event ObjectSetOptionalitySpec_optional_Callback ObjectSetOptionalitySpec_optional_Event;

		// event trigger associated with syntax rule ObjectSetOptionalitySpec-optional
		public bool Raise_ObjectSetOptionalitySpec_optional_Event (SyntaxTreeCallbackReason reason, ObjectSetOptionalitySpec_optional.production_kind kind, ObjectSetOptionalitySpec_optional p_ObjectSetOptionalitySpec_optional)
		{
			bool? status = ObjectSetOptionalitySpec_optional_Event?.Invoke (reason, kind, p_ObjectSetOptionalitySpec_optional);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectSetOptionalitySpec-optional
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetOptionalitySpec-optional
		//

		public void Traverse (ObjectSetOptionalitySpec_optional p_ObjectSetOptionalitySpec_optional)
		{
			if (p_ObjectSetOptionalitySpec_optional.isLocked())
				return;
			p_ObjectSetOptionalitySpec_optional.dolock();
			ObjectSetOptionalitySpec_optional.production_kind kind = (ObjectSetOptionalitySpec_optional.production_kind) p_ObjectSetOptionalitySpec_optional.kind;
			p_ObjectSetOptionalitySpec_optional.turn_reset ();
			if (Raise_ObjectSetOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectSetOptionalitySpec_optional))
			switch (kind)
			{
				case ObjectSetOptionalitySpec_optional.production_kind.g_ObjectSetOptionalitySpec_optional_1:
					// traverse syntax tree node associated with production
					// ObjectSetOptionalitySpec-optional: %empty

				break;
				case ObjectSetOptionalitySpec_optional.production_kind.g_ObjectSetOptionalitySpec_optional_2:
					// traverse syntax tree node associated with production
					// ObjectSetOptionalitySpec-optional: ObjectSetOptionalitySpec

					if (Raise_ObjectSetOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetOptionalitySpec_optional))
						Traverse (p_ObjectSetOptionalitySpec_optional.m_ObjectSetOptionalitySpec);
					p_ObjectSetOptionalitySpec_optional.turn_inc ();
					Raise_ObjectSetOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSetOptionalitySpec_optional);
				break;
			}
			Raise_ObjectSetOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectSetOptionalitySpec_optional);
			p_ObjectSetOptionalitySpec_optional.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSetOptionalitySpec-optional
		//

		public void TraverseCommon (ObjectSetOptionalitySpec_optional p_ObjectSetOptionalitySpec_optional)
		{
			ObjectSetOptionalitySpec_optional.production_kind kind = (ObjectSetOptionalitySpec_optional.production_kind) p_ObjectSetOptionalitySpec_optional.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectSetOptionalitySpec_optional))
			switch (kind)
			{
				case ObjectSetOptionalitySpec_optional.production_kind.g_ObjectSetOptionalitySpec_optional_1:
					// traverse syntax tree node associated with production
					// ObjectSetOptionalitySpec-optional: %empty

				break;
				case ObjectSetOptionalitySpec_optional.production_kind.g_ObjectSetOptionalitySpec_optional_2:
					// traverse syntax tree node associated with production
					// ObjectSetOptionalitySpec-optional: ObjectSetOptionalitySpec

						TraverseCommon (p_ObjectSetOptionalitySpec_optional.m_ObjectSetOptionalitySpec);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectSetOptionalitySpec_optional);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectSetOptionalitySpec-optional

		//
		// create syntax tree node associated with production
		// ObjectSetOptionalitySpec-optional: %empty

		//

		public ObjectSetOptionalitySpec_optional ObjectSetOptionalitySpec_optional_1 ()
		{
			ObjectSetOptionalitySpec_optional p_ObjectSetOptionalitySpec_optional_ref = new ObjectSetOptionalitySpec_optional();
			Raise_ObjectSetOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectSetOptionalitySpec_optional.production_kind.g_ObjectSetOptionalitySpec_optional_1, p_ObjectSetOptionalitySpec_optional_ref);
			return p_ObjectSetOptionalitySpec_optional_ref;
		}

		//
		// create syntax tree node associated with production
		// ObjectSetOptionalitySpec-optional: ObjectSetOptionalitySpec

		//

		public ObjectSetOptionalitySpec_optional ObjectSetOptionalitySpec_optional_2 (ObjectSetOptionalitySpec p_ObjectSetOptionalitySpec)
		{
			ObjectSetOptionalitySpec_optional p_ObjectSetOptionalitySpec_optional_ref = new ObjectSetOptionalitySpec_optional(p_ObjectSetOptionalitySpec);
			p_ObjectSetOptionalitySpec.parent = p_ObjectSetOptionalitySpec_optional_ref;
			Raise_ObjectSetOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectSetOptionalitySpec_optional.production_kind.g_ObjectSetOptionalitySpec_optional_2, p_ObjectSetOptionalitySpec_optional_ref);
			return p_ObjectSetOptionalitySpec_optional_ref;
		}
		#endregion
	};
}
