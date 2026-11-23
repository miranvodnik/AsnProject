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
	// class associated with syntax rule OT-BitsValue
	//

	[DataContract]
	public class	OT_BitsValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OT-BitsValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OT-BitsValue
		{
			g_OT_BitsValue_1 = 1,	// OT-BitNames

			g_OT_BitsValue_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule OT-BitsValue

		// markers associated with production: OT-BitsValue -> OT-BitNames

		public enum production_marker_1 : ushort
		{
			m_OT_BitNames,
			final
		};

		// markers associated with production: OT-BitsValue -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OT-BitsValue

		// Constructor declaration(s) associated with production(s) of syntax rule OT-BitsValue

		//
		// Constructor associated with the following production(s)
		// OT-BitsValue -> OT-BitNames

		//

		public OT_BitsValue (OT_BitNames p_OT_BitNames) : base ((uint) ProductionID._OT_BitsValue_ID, (uint) production_kind.g_OT_BitsValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_OT_BitNames = p_OT_BitNames;
		}

		//
		// Constructor associated with the following production(s)
		// OT-BitsValue -> %empty

		//

		public OT_BitsValue () : base ((uint) ProductionID._OT_BitsValue_ID, (uint) production_kind.g_OT_BitsValue_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public OT_BitsValue (OT_BitsValue p_OT_BitsValue) : base (p_OT_BitsValue.id, p_OT_BitsValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OT_BitsValue.appInfo;
			switch ((production_kind) p_OT_BitsValue.kind)
			{
				case production_kind.g_OT_BitsValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OT_BitNames = (p_OT_BitsValue.m_OT_BitNames != null) ? new OT_BitNames (p_OT_BitsValue.m_OT_BitNames) : null) != null) m_OT_BitNames.parent = this;
					break;
				case production_kind.g_OT_BitsValue_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "OT_BitsValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OT_BitsValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_OT_BitNames?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OT-BitsValue

		// Content changing function(s) associated with production(s) of syntax rule OT-BitsValue

		//
		// Content changing function associated with following production(s)
		// OT-BitsValue -> OT-BitNames

		//

		public void change(OT_BitNames p_OT_BitNames)
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_BitsValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_OT_BitNames = p_OT_BitNames;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// OT-BitsValue -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_BitsValue_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OT-BitsValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_OT_BitNames != null) && m_OT_BitNames.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OT-BitsValue

		//
		// emit production tree node associated with any production of syntax rule OT-BitsValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_OT_BitsValue_1:
					// emit syntax tree node associated with production
					// OT-BitsValue: OT-BitNames

					s += m_OT_BitNames.Emit (depth - 1);
				break;
				case production_kind.g_OT_BitsValue_2:
					// emit syntax tree node associated with production
					// OT-BitsValue: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OT-BitsValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "OT_BitsValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_OT_BitsValue_1:
					// emit syntax tree node associated with production
					// OT-BitsValue: OT-BitNames

					s += m_OT_BitNames.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_OT_BitsValue_2:
					// emit syntax tree node associated with production
					// OT-BitsValue: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OT-BitsValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OT-BitsValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			OT_BitsValue.production_kind kind = (OT_BitsValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case OT_BitsValue.production_kind.g_OT_BitsValue_1:
					// traverse syntax tree node associated with production
					// OT-BitsValue: OT-BitNames

						m_OT_BitNames.Visit (visitor, appData);
				break;
				case OT_BitsValue.production_kind.g_OT_BitsValue_2:
					// traverse syntax tree node associated with production
					// OT-BitsValue: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_OT_BitNames?.reparent (this);
		}

		//
		// initialize object associated with syntax rule OT-BitsValue
		//

		public void _init ()
		{
			m_OT_BitNames = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OT-BitsValue

		// counter of all nodes associated with syntax rule OT-BitsValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OT-BitsValue
		[DataMember (Name = "m_OT_BitNames")] public OT_BitNames m_OT_BitNames { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OT-BitsValue

		// delegate function (callback) prototype associated with syntax rule OT-BitsValue
		public delegate bool OT_BitsValue_Callback (SyntaxTreeCallbackReason reason, OT_BitsValue.production_kind kind, OT_BitsValue p_OT_BitsValue);

		// event associated with syntax rule OT-BitsValue
		public event OT_BitsValue_Callback OT_BitsValue_Event;

		// event trigger associated with syntax rule OT-BitsValue
		public bool Raise_OT_BitsValue_Event (SyntaxTreeCallbackReason reason, OT_BitsValue.production_kind kind, OT_BitsValue p_OT_BitsValue)
		{
			bool? status = OT_BitsValue_Event?.Invoke (reason, kind, p_OT_BitsValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OT-BitsValue
		//
		// traverse syntax tree node associated with any production of syntax rule OT-BitsValue
		//

		public void Traverse (OT_BitsValue p_OT_BitsValue)
		{
			if (p_OT_BitsValue.isLocked())
				return;
			p_OT_BitsValue.dolock();
			OT_BitsValue.production_kind kind = (OT_BitsValue.production_kind) p_OT_BitsValue.kind;
			p_OT_BitsValue.turn_reset ();
			if (Raise_OT_BitsValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_OT_BitsValue))
			switch (kind)
			{
				case OT_BitsValue.production_kind.g_OT_BitsValue_1:
					// traverse syntax tree node associated with production
					// OT-BitsValue: OT-BitNames

					if (Raise_OT_BitsValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_BitsValue))
						Traverse (p_OT_BitsValue.m_OT_BitNames);
					p_OT_BitsValue.turn_inc ();
					Raise_OT_BitsValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_BitsValue);
				break;
				case OT_BitsValue.production_kind.g_OT_BitsValue_2:
					// traverse syntax tree node associated with production
					// OT-BitsValue: %empty

				break;
			}
			Raise_OT_BitsValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_OT_BitsValue);
			p_OT_BitsValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OT-BitsValue
		//

		public void TraverseCommon (OT_BitsValue p_OT_BitsValue)
		{
			OT_BitsValue.production_kind kind = (OT_BitsValue.production_kind) p_OT_BitsValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_OT_BitsValue))
			switch (kind)
			{
				case OT_BitsValue.production_kind.g_OT_BitsValue_1:
					// traverse syntax tree node associated with production
					// OT-BitsValue: OT-BitNames

						TraverseCommon (p_OT_BitsValue.m_OT_BitNames);
				break;
				case OT_BitsValue.production_kind.g_OT_BitsValue_2:
					// traverse syntax tree node associated with production
					// OT-BitsValue: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_OT_BitsValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OT-BitsValue

		//
		// create syntax tree node associated with production
		// OT-BitsValue: OT-BitNames

		//

		public OT_BitsValue OT_BitsValue_1 (OT_BitNames p_OT_BitNames)
		{
			OT_BitsValue p_OT_BitsValue_ref = new OT_BitsValue(p_OT_BitNames);
			p_OT_BitNames.parent = p_OT_BitsValue_ref;
			Raise_OT_BitsValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_BitsValue.production_kind.g_OT_BitsValue_1, p_OT_BitsValue_ref);
			return p_OT_BitsValue_ref;
		}

		//
		// create syntax tree node associated with production
		// OT-BitsValue: %empty

		//

		public OT_BitsValue OT_BitsValue_2 ()
		{
			OT_BitsValue p_OT_BitsValue_ref = new OT_BitsValue();
			Raise_OT_BitsValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_BitsValue.production_kind.g_OT_BitsValue_2, p_OT_BitsValue_ref);
			return p_OT_BitsValue_ref;
		}
		#endregion
	};
}
