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
	// class associated with syntax rule ObjectOptionalitySpec-optional
	//

	[DataContract]
	public class	ObjectOptionalitySpec_optional : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectOptionalitySpec-optional
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectOptionalitySpec-optional
		{
			g_ObjectOptionalitySpec_optional_1 = 1,	// %empty

			g_ObjectOptionalitySpec_optional_2 = 2,	// ObjectOptionalitySpec

		};
		#endregion
		#region production markers associated with the syntax rule ObjectOptionalitySpec-optional

		// markers associated with production: ObjectOptionalitySpec-optional -> %empty

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: ObjectOptionalitySpec-optional -> ObjectOptionalitySpec

		public enum production_marker_2 : ushort
		{
			m_ObjectOptionalitySpec,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectOptionalitySpec-optional

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectOptionalitySpec-optional

		//
		// Constructor associated with the following production(s)
		// ObjectOptionalitySpec-optional -> %empty

		//

		public ObjectOptionalitySpec_optional () : base ((uint) ProductionID._ObjectOptionalitySpec_optional_ID, (uint) production_kind.g_ObjectOptionalitySpec_optional_1)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		//
		// Constructor associated with the following production(s)
		// ObjectOptionalitySpec-optional -> ObjectOptionalitySpec

		//

		public ObjectOptionalitySpec_optional (ObjectOptionalitySpec p_ObjectOptionalitySpec) : base ((uint) ProductionID._ObjectOptionalitySpec_optional_ID, (uint) production_kind.g_ObjectOptionalitySpec_optional_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjectOptionalitySpec = p_ObjectOptionalitySpec;
		}

		// Copy constructor

		public ObjectOptionalitySpec_optional (ObjectOptionalitySpec_optional p_ObjectOptionalitySpec_optional) : base (p_ObjectOptionalitySpec_optional.id, p_ObjectOptionalitySpec_optional.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectOptionalitySpec_optional.appInfo;
			switch ((production_kind) p_ObjectOptionalitySpec_optional.kind)
			{
				case production_kind.g_ObjectOptionalitySpec_optional_1:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				case production_kind.g_ObjectOptionalitySpec_optional_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectOptionalitySpec = (p_ObjectOptionalitySpec_optional.m_ObjectOptionalitySpec != null) ? new ObjectOptionalitySpec (p_ObjectOptionalitySpec_optional.m_ObjectOptionalitySpec) : null) != null) m_ObjectOptionalitySpec.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectOptionalitySpec_optional" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectOptionalitySpec_optional (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ObjectOptionalitySpec?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectOptionalitySpec-optional

		// Content changing function(s) associated with production(s) of syntax rule ObjectOptionalitySpec-optional

		//
		// Content changing function associated with following production(s)
		// ObjectOptionalitySpec-optional -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectOptionalitySpec_optional_1;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ObjectOptionalitySpec-optional -> ObjectOptionalitySpec

		//

		public void change(ObjectOptionalitySpec p_ObjectOptionalitySpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectOptionalitySpec_optional_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjectOptionalitySpec = p_ObjectOptionalitySpec;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectOptionalitySpec-optional
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ObjectOptionalitySpec != null) && m_ObjectOptionalitySpec.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectOptionalitySpec-optional

		//
		// emit production tree node associated with any production of syntax rule ObjectOptionalitySpec-optional
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectOptionalitySpec_optional_1:
					// emit syntax tree node associated with production
					// ObjectOptionalitySpec-optional: %empty

				break;
				case production_kind.g_ObjectOptionalitySpec_optional_2:
					// emit syntax tree node associated with production
					// ObjectOptionalitySpec-optional: ObjectOptionalitySpec

					s += m_ObjectOptionalitySpec.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectOptionalitySpec-optional
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectOptionalitySpec_optional (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectOptionalitySpec_optional_1:
					// emit syntax tree node associated with production
					// ObjectOptionalitySpec-optional: %empty

				break;
				case production_kind.g_ObjectOptionalitySpec_optional_2:
					// emit syntax tree node associated with production
					// ObjectOptionalitySpec-optional: ObjectOptionalitySpec

					s += m_ObjectOptionalitySpec.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectOptionalitySpec-optional

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectOptionalitySpec-optional with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectOptionalitySpec_optional.production_kind kind = (ObjectOptionalitySpec_optional.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectOptionalitySpec_optional.production_kind.g_ObjectOptionalitySpec_optional_1:
					// traverse syntax tree node associated with production
					// ObjectOptionalitySpec-optional: %empty

				break;
				case ObjectOptionalitySpec_optional.production_kind.g_ObjectOptionalitySpec_optional_2:
					// traverse syntax tree node associated with production
					// ObjectOptionalitySpec-optional: ObjectOptionalitySpec

						m_ObjectOptionalitySpec.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ObjectOptionalitySpec?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectOptionalitySpec-optional
		//

		public void _init ()
		{
			m_ObjectOptionalitySpec = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectOptionalitySpec-optional

		// counter of all nodes associated with syntax rule ObjectOptionalitySpec-optional
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectOptionalitySpec-optional
		[DataMember (Name = "m_ObjectOptionalitySpec")] public ObjectOptionalitySpec m_ObjectOptionalitySpec { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectOptionalitySpec-optional

		// delegate function (callback) prototype associated with syntax rule ObjectOptionalitySpec-optional
		public delegate bool ObjectOptionalitySpec_optional_Callback (SyntaxTreeCallbackReason reason, ObjectOptionalitySpec_optional.production_kind kind, ObjectOptionalitySpec_optional p_ObjectOptionalitySpec_optional);

		// event associated with syntax rule ObjectOptionalitySpec-optional
		public event ObjectOptionalitySpec_optional_Callback ObjectOptionalitySpec_optional_Event;

		// event trigger associated with syntax rule ObjectOptionalitySpec-optional
		public bool Raise_ObjectOptionalitySpec_optional_Event (SyntaxTreeCallbackReason reason, ObjectOptionalitySpec_optional.production_kind kind, ObjectOptionalitySpec_optional p_ObjectOptionalitySpec_optional)
		{
			bool? status = ObjectOptionalitySpec_optional_Event?.Invoke (reason, kind, p_ObjectOptionalitySpec_optional);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectOptionalitySpec-optional
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectOptionalitySpec-optional
		//

		public void Traverse (ObjectOptionalitySpec_optional p_ObjectOptionalitySpec_optional)
		{
			if (p_ObjectOptionalitySpec_optional.isLocked())
				return;
			p_ObjectOptionalitySpec_optional.dolock();
			ObjectOptionalitySpec_optional.production_kind kind = (ObjectOptionalitySpec_optional.production_kind) p_ObjectOptionalitySpec_optional.kind;
			p_ObjectOptionalitySpec_optional.turn_reset ();
			if (Raise_ObjectOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectOptionalitySpec_optional))
			switch (kind)
			{
				case ObjectOptionalitySpec_optional.production_kind.g_ObjectOptionalitySpec_optional_1:
					// traverse syntax tree node associated with production
					// ObjectOptionalitySpec-optional: %empty

				break;
				case ObjectOptionalitySpec_optional.production_kind.g_ObjectOptionalitySpec_optional_2:
					// traverse syntax tree node associated with production
					// ObjectOptionalitySpec-optional: ObjectOptionalitySpec

					if (Raise_ObjectOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectOptionalitySpec_optional))
						Traverse (p_ObjectOptionalitySpec_optional.m_ObjectOptionalitySpec);
					p_ObjectOptionalitySpec_optional.turn_inc ();
					Raise_ObjectOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectOptionalitySpec_optional);
				break;
			}
			Raise_ObjectOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectOptionalitySpec_optional);
			p_ObjectOptionalitySpec_optional.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectOptionalitySpec-optional
		//

		public void TraverseCommon (ObjectOptionalitySpec_optional p_ObjectOptionalitySpec_optional)
		{
			ObjectOptionalitySpec_optional.production_kind kind = (ObjectOptionalitySpec_optional.production_kind) p_ObjectOptionalitySpec_optional.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectOptionalitySpec_optional))
			switch (kind)
			{
				case ObjectOptionalitySpec_optional.production_kind.g_ObjectOptionalitySpec_optional_1:
					// traverse syntax tree node associated with production
					// ObjectOptionalitySpec-optional: %empty

				break;
				case ObjectOptionalitySpec_optional.production_kind.g_ObjectOptionalitySpec_optional_2:
					// traverse syntax tree node associated with production
					// ObjectOptionalitySpec-optional: ObjectOptionalitySpec

						TraverseCommon (p_ObjectOptionalitySpec_optional.m_ObjectOptionalitySpec);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectOptionalitySpec_optional);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectOptionalitySpec-optional

		//
		// create syntax tree node associated with production
		// ObjectOptionalitySpec-optional: %empty

		//

		public ObjectOptionalitySpec_optional ObjectOptionalitySpec_optional_1 ()
		{
			ObjectOptionalitySpec_optional p_ObjectOptionalitySpec_optional_ref = new ObjectOptionalitySpec_optional();
			Raise_ObjectOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectOptionalitySpec_optional.production_kind.g_ObjectOptionalitySpec_optional_1, p_ObjectOptionalitySpec_optional_ref);
			return p_ObjectOptionalitySpec_optional_ref;
		}

		//
		// create syntax tree node associated with production
		// ObjectOptionalitySpec-optional: ObjectOptionalitySpec

		//

		public ObjectOptionalitySpec_optional ObjectOptionalitySpec_optional_2 (ObjectOptionalitySpec p_ObjectOptionalitySpec)
		{
			ObjectOptionalitySpec_optional p_ObjectOptionalitySpec_optional_ref = new ObjectOptionalitySpec_optional(p_ObjectOptionalitySpec);
			p_ObjectOptionalitySpec.parent = p_ObjectOptionalitySpec_optional_ref;
			Raise_ObjectOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectOptionalitySpec_optional.production_kind.g_ObjectOptionalitySpec_optional_2, p_ObjectOptionalitySpec_optional_ref);
			return p_ObjectOptionalitySpec_optional_ref;
		}
		#endregion
	};
}
