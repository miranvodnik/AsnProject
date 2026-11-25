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
	// class associated with syntax rule OpenTypeFieldVal
	//

	[DataContract]
	public class	OpenTypeFieldVal : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OpenTypeFieldVal
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OpenTypeFieldVal
		{
			g_OpenTypeFieldVal_1 = 1,	// Type ":" Value

		};
		#endregion
		#region production markers associated with the syntax rule OpenTypeFieldVal

		// markers associated with production: OpenTypeFieldVal -> Type ":" Value

		public enum production_marker_1 : ushort
		{
			m_Type,
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OpenTypeFieldVal

		// Constructor declaration(s) associated with production(s) of syntax rule OpenTypeFieldVal

		//
		// Constructor associated with the following production(s)
		// OpenTypeFieldVal -> Type ":" Value

		//

		public OpenTypeFieldVal (Type p_Type, SyntaxTreeToken p_token, Value p_Value) : base ((uint) ProductionID._OpenTypeFieldVal_ID, (uint) production_kind.g_OpenTypeFieldVal_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_Type = p_Type;
			children[1] = m_colon = p_token;
			children[2] = m_Value = p_Value;
		}

		public OpenTypeFieldVal () { }

		// Copy constructor

		public OpenTypeFieldVal (OpenTypeFieldVal p_OpenTypeFieldVal) : base (p_OpenTypeFieldVal.id, p_OpenTypeFieldVal.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OpenTypeFieldVal.appInfo;
			switch ((production_kind) p_OpenTypeFieldVal.kind)
			{
				case production_kind.g_OpenTypeFieldVal_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_Type = (p_OpenTypeFieldVal.m_Type != null) ? new Type (p_OpenTypeFieldVal.m_Type) : null) != null) m_Type.parent = this;
					if ((children [1] = m_colon = (p_OpenTypeFieldVal.m_colon != null) ? new SyntaxTreeToken (p_OpenTypeFieldVal.m_colon) : null) != null) m_colon.parent = this;
					if ((children [2] = m_Value = (p_OpenTypeFieldVal.m_Value != null) ? new Value (p_OpenTypeFieldVal.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "OpenTypeFieldVal" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OpenTypeFieldVal (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Type?.Dispose ();
			m_colon?.Dispose ();
			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OpenTypeFieldVal

		// Content changing function(s) associated with production(s) of syntax rule OpenTypeFieldVal

		//
		// Content changing function associated with following production(s)
		// OpenTypeFieldVal -> Type ":" Value

		//

		public void change(Type p_Type, SyntaxTreeToken p_token, Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_OpenTypeFieldVal_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_Type = p_Type;
			children [1] = m_colon = p_token;
			children [2] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OpenTypeFieldVal
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_colon != null) && m_colon.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OpenTypeFieldVal

		//
		// emit production tree node associated with any production of syntax rule OpenTypeFieldVal
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_OpenTypeFieldVal_1:
					// emit syntax tree node associated with production
					// OpenTypeFieldVal: Type ":" Value

					s += m_Type.Emit (depth - 1);
					s += " ";
					s += m_colon.Emit (depth - 1);
					s += " ";
					s += m_Value.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OpenTypeFieldVal
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "OpenTypeFieldVal (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_OpenTypeFieldVal_1:
					// emit syntax tree node associated with production
					// OpenTypeFieldVal: Type ":" Value

					s += m_Type.EmitProductionTree (depth - 1);
					s += ' ';
					s += "colon";
					s += ' ';
					s += m_Value.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OpenTypeFieldVal

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OpenTypeFieldVal with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			OpenTypeFieldVal.production_kind kind = (OpenTypeFieldVal.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case OpenTypeFieldVal.production_kind.g_OpenTypeFieldVal_1:
					// traverse syntax tree node associated with production
					// OpenTypeFieldVal: Type ":" Value

						m_Type.Visit (visitor, appData);
						m_colon.Visit (visitor, appData);
						m_Value.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Type?.reparent (this);
			m_colon?.reparent (this);
			m_Value?.reparent (this);
		}

		//
		// initialize object associated with syntax rule OpenTypeFieldVal
		//

		public void _init ()
		{
			m_Type = null;
			m_colon = null;
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OpenTypeFieldVal

		// counter of all nodes associated with syntax rule OpenTypeFieldVal
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OpenTypeFieldVal
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_colon")] public SyntaxTreeToken m_colon { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }

		public enum __p1_markers
		{
			m1 = 1,
			m2 = 2,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OpenTypeFieldVal

		// delegate function (callback) prototype associated with syntax rule OpenTypeFieldVal
		public delegate bool OpenTypeFieldVal_Callback (SyntaxTreeCallbackReason reason, OpenTypeFieldVal.production_kind kind, OpenTypeFieldVal p_OpenTypeFieldVal);

		// event associated with syntax rule OpenTypeFieldVal
		public event OpenTypeFieldVal_Callback OpenTypeFieldVal_Event;

		// event trigger associated with syntax rule OpenTypeFieldVal
		public bool Raise_OpenTypeFieldVal_Event (SyntaxTreeCallbackReason reason, OpenTypeFieldVal.production_kind kind, OpenTypeFieldVal p_OpenTypeFieldVal)
		{
			bool? status = OpenTypeFieldVal_Event?.Invoke (reason, kind, p_OpenTypeFieldVal);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OpenTypeFieldVal
		//
		// traverse syntax tree node associated with any production of syntax rule OpenTypeFieldVal
		//

		public void Traverse (OpenTypeFieldVal p_OpenTypeFieldVal)
		{
			if (p_OpenTypeFieldVal.isLocked())
				return;
			p_OpenTypeFieldVal.dolock();
			OpenTypeFieldVal.production_kind kind = (OpenTypeFieldVal.production_kind) p_OpenTypeFieldVal.kind;
			p_OpenTypeFieldVal.turn_reset ();
			if (Raise_OpenTypeFieldVal_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_OpenTypeFieldVal))
			switch (kind)
			{
				case OpenTypeFieldVal.production_kind.g_OpenTypeFieldVal_1:
					// traverse syntax tree node associated with production
					// OpenTypeFieldVal: Type ":" Value

					if (Raise_OpenTypeFieldVal_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OpenTypeFieldVal))
						Traverse (p_OpenTypeFieldVal.m_Type);
					p_OpenTypeFieldVal.turn_inc ();
					if (Raise_OpenTypeFieldVal_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OpenTypeFieldVal))
						Traverse (p_OpenTypeFieldVal.m_Value);
					p_OpenTypeFieldVal.turn_inc ();
					Raise_OpenTypeFieldVal_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OpenTypeFieldVal);
				break;
			}
			Raise_OpenTypeFieldVal_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_OpenTypeFieldVal);
			p_OpenTypeFieldVal.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OpenTypeFieldVal
		//

		public void TraverseCommon (OpenTypeFieldVal p_OpenTypeFieldVal)
		{
			OpenTypeFieldVal.production_kind kind = (OpenTypeFieldVal.production_kind) p_OpenTypeFieldVal.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_OpenTypeFieldVal))
			switch (kind)
			{
				case OpenTypeFieldVal.production_kind.g_OpenTypeFieldVal_1:
					// traverse syntax tree node associated with production
					// OpenTypeFieldVal: Type ":" Value

						TraverseCommon (p_OpenTypeFieldVal.m_Type);
						TraverseCommon (p_OpenTypeFieldVal.m_colon);
						TraverseCommon (p_OpenTypeFieldVal.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_OpenTypeFieldVal);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OpenTypeFieldVal

		//
		// create syntax tree node associated with production
		// OpenTypeFieldVal: Type ":" Value

		//

		public OpenTypeFieldVal OpenTypeFieldVal_1 (Type p_Type, SyntaxTreeToken p_token, Value p_Value)
		{
			OpenTypeFieldVal p_OpenTypeFieldVal_ref = new OpenTypeFieldVal(p_Type, p_token, p_Value);
			p_Type.parent = p_OpenTypeFieldVal_ref;
			p_token.parent = p_OpenTypeFieldVal_ref;
			p_Value.parent = p_OpenTypeFieldVal_ref;
			Raise_OpenTypeFieldVal_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OpenTypeFieldVal.production_kind.g_OpenTypeFieldVal_1, p_OpenTypeFieldVal_ref);
			return p_OpenTypeFieldVal_ref;
		}
		#endregion
	};
}
