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
	// class associated with syntax rule UserDefinedConstraintParameter
	//

	[DataContract]
	public class	UserDefinedConstraintParameter : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule UserDefinedConstraintParameter
		public enum production_kind : ushort	// enumerated production(s) of syntax rule UserDefinedConstraintParameter
		{
			g_UserDefinedConstraintParameter_1 = 1,	// Governor ":" Value

			g_UserDefinedConstraintParameter_2 = 2,	// Governor ":" Object

			g_UserDefinedConstraintParameter_3 = 3,	// DefinedObjectSet

			g_UserDefinedConstraintParameter_4 = 4,	// Type

			g_UserDefinedConstraintParameter_5 = 5,	// DefinedObjectClass

		};
		#endregion
		#region production markers associated with the syntax rule UserDefinedConstraintParameter

		// markers associated with production: UserDefinedConstraintParameter -> Governor ":" Value

		public enum production_marker_1 : ushort
		{
			m_Governor,
			m_Value,
			final
		};

		// markers associated with production: UserDefinedConstraintParameter -> Governor ":" Object

		public enum production_marker_2 : ushort
		{
			m_Governor,
			m_Object,
			final
		};

		// markers associated with production: UserDefinedConstraintParameter -> DefinedObjectSet

		public enum production_marker_3 : ushort
		{
			m_DefinedObjectSet,
			final
		};

		// markers associated with production: UserDefinedConstraintParameter -> Type

		public enum production_marker_4 : ushort
		{
			m_Type,
			final
		};

		// markers associated with production: UserDefinedConstraintParameter -> DefinedObjectClass

		public enum production_marker_5 : ushort
		{
			m_DefinedObjectClass,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule UserDefinedConstraintParameter

		// Constructor declaration(s) associated with production(s) of syntax rule UserDefinedConstraintParameter

		//
		// Constructor associated with the following production(s)
		// UserDefinedConstraintParameter -> Governor ":" Value

		//

		public UserDefinedConstraintParameter (Governor p_Governor, SyntaxTreeToken p_token, Value p_Value) : base ((uint) ProductionID._UserDefinedConstraintParameter_ID, (uint) production_kind.g_UserDefinedConstraintParameter_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_Governor = p_Governor;
			children[1] = m_colon = p_token;
			children[2] = m_Value = p_Value;
		}

		//
		// Constructor associated with the following production(s)
		// UserDefinedConstraintParameter -> Governor ":" Object

		//

		public UserDefinedConstraintParameter (Governor p_Governor, SyntaxTreeToken p_token, Object p_Object) : base ((uint) ProductionID._UserDefinedConstraintParameter_ID, (uint) production_kind.g_UserDefinedConstraintParameter_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_Governor = p_Governor;
			children[1] = m_colon = p_token;
			children[2] = m_Object = p_Object;
		}

		//
		// Constructor associated with the following production(s)
		// UserDefinedConstraintParameter -> DefinedObjectSet

		//

		public UserDefinedConstraintParameter (DefinedObjectSet p_DefinedObjectSet) : base ((uint) ProductionID._UserDefinedConstraintParameter_ID, (uint) production_kind.g_UserDefinedConstraintParameter_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinedObjectSet = p_DefinedObjectSet;
		}

		//
		// Constructor associated with the following production(s)
		// UserDefinedConstraintParameter -> Type

		//

		public UserDefinedConstraintParameter (Type p_Type) : base ((uint) ProductionID._UserDefinedConstraintParameter_ID, (uint) production_kind.g_UserDefinedConstraintParameter_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Type = p_Type;
		}

		//
		// Constructor associated with the following production(s)
		// UserDefinedConstraintParameter -> DefinedObjectClass

		//

		public UserDefinedConstraintParameter (DefinedObjectClass p_DefinedObjectClass) : base ((uint) ProductionID._UserDefinedConstraintParameter_ID, (uint) production_kind.g_UserDefinedConstraintParameter_5)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinedObjectClass = p_DefinedObjectClass;
		}

		public UserDefinedConstraintParameter () { }

		// Copy constructor

		public UserDefinedConstraintParameter (UserDefinedConstraintParameter p_UserDefinedConstraintParameter) : base (p_UserDefinedConstraintParameter.id, p_UserDefinedConstraintParameter.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_UserDefinedConstraintParameter.appInfo;
			switch ((production_kind) p_UserDefinedConstraintParameter.kind)
			{
				case production_kind.g_UserDefinedConstraintParameter_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_Governor = (p_UserDefinedConstraintParameter.m_Governor != null) ? new Governor (p_UserDefinedConstraintParameter.m_Governor) : null) != null) m_Governor.parent = this;
					if ((children [1] = m_colon = (p_UserDefinedConstraintParameter.m_colon != null) ? new SyntaxTreeToken (p_UserDefinedConstraintParameter.m_colon) : null) != null) m_colon.parent = this;
					if ((children [2] = m_Value = (p_UserDefinedConstraintParameter.m_Value != null) ? new Value (p_UserDefinedConstraintParameter.m_Value) : null) != null) m_Value.parent = this;
					break;
				case production_kind.g_UserDefinedConstraintParameter_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_Governor = (p_UserDefinedConstraintParameter.m_Governor != null) ? new Governor (p_UserDefinedConstraintParameter.m_Governor) : null) != null) m_Governor.parent = this;
					if ((children [1] = m_colon = (p_UserDefinedConstraintParameter.m_colon != null) ? new SyntaxTreeToken (p_UserDefinedConstraintParameter.m_colon) : null) != null) m_colon.parent = this;
					if ((children [2] = m_Object = (p_UserDefinedConstraintParameter.m_Object != null) ? new Object (p_UserDefinedConstraintParameter.m_Object) : null) != null) m_Object.parent = this;
					break;
				case production_kind.g_UserDefinedConstraintParameter_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinedObjectSet = (p_UserDefinedConstraintParameter.m_DefinedObjectSet != null) ? new DefinedObjectSet (p_UserDefinedConstraintParameter.m_DefinedObjectSet) : null) != null) m_DefinedObjectSet.parent = this;
					break;
				case production_kind.g_UserDefinedConstraintParameter_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Type = (p_UserDefinedConstraintParameter.m_Type != null) ? new Type (p_UserDefinedConstraintParameter.m_Type) : null) != null) m_Type.parent = this;
					break;
				case production_kind.g_UserDefinedConstraintParameter_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinedObjectClass = (p_UserDefinedConstraintParameter.m_DefinedObjectClass != null) ? new DefinedObjectClass (p_UserDefinedConstraintParameter.m_DefinedObjectClass) : null) != null) m_DefinedObjectClass.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "UserDefinedConstraintParameter" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new UserDefinedConstraintParameter (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Governor?.Dispose ();
			m_colon?.Dispose ();
			m_Value?.Dispose ();
			m_Object?.Dispose ();
			m_DefinedObjectSet?.Dispose ();
			m_Type?.Dispose ();
			m_DefinedObjectClass?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule UserDefinedConstraintParameter

		// Content changing function(s) associated with production(s) of syntax rule UserDefinedConstraintParameter

		//
		// Content changing function associated with following production(s)
		// UserDefinedConstraintParameter -> Governor ":" Value

		//

		public void change(Governor p_Governor, SyntaxTreeToken p_token, Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_UserDefinedConstraintParameter_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_Governor = p_Governor;
			children [1] = m_colon = p_token;
			children [2] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// UserDefinedConstraintParameter -> Governor ":" Object

		//

		public void change(Governor p_Governor, SyntaxTreeToken p_token, Object p_Object)
		{
			_init ();
			this.kind = (uint) production_kind.g_UserDefinedConstraintParameter_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_Governor = p_Governor;
			children [1] = m_colon = p_token;
			children [2] = m_Object = p_Object;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// UserDefinedConstraintParameter -> DefinedObjectSet

		//

		public void change(DefinedObjectSet p_DefinedObjectSet)
		{
			_init ();
			this.kind = (uint) production_kind.g_UserDefinedConstraintParameter_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinedObjectSet = p_DefinedObjectSet;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// UserDefinedConstraintParameter -> Type

		//

		public void change(Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_UserDefinedConstraintParameter_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// UserDefinedConstraintParameter -> DefinedObjectClass

		//

		public void change(DefinedObjectClass p_DefinedObjectClass)
		{
			_init ();
			this.kind = (uint) production_kind.g_UserDefinedConstraintParameter_5;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinedObjectClass = p_DefinedObjectClass;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule UserDefinedConstraintParameter
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Governor != null) && m_Governor.checkInclusion (element) ||
				(m_colon != null) && m_colon.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				(m_Object != null) && m_Object.checkInclusion (element) ||
				(m_DefinedObjectSet != null) && m_DefinedObjectSet.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_DefinedObjectClass != null) && m_DefinedObjectClass.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule UserDefinedConstraintParameter

		//
		// emit production tree node associated with any production of syntax rule UserDefinedConstraintParameter
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_UserDefinedConstraintParameter_1:
					// emit syntax tree node associated with production
					// UserDefinedConstraintParameter: Governor ":" Value

					s += m_Governor.Emit (depth - 1);
					s += " ";
					s += m_colon.Emit (depth - 1);
					s += " ";
					s += m_Value.Emit (depth - 1);
				break;
				case production_kind.g_UserDefinedConstraintParameter_2:
					// emit syntax tree node associated with production
					// UserDefinedConstraintParameter: Governor ":" Object

					s += m_Governor.Emit (depth - 1);
					s += " ";
					s += m_colon.Emit (depth - 1);
					s += " ";
					s += m_Object.Emit (depth - 1);
				break;
				case production_kind.g_UserDefinedConstraintParameter_3:
					// emit syntax tree node associated with production
					// UserDefinedConstraintParameter: DefinedObjectSet

					s += m_DefinedObjectSet.Emit (depth - 1);
				break;
				case production_kind.g_UserDefinedConstraintParameter_4:
					// emit syntax tree node associated with production
					// UserDefinedConstraintParameter: Type

					s += m_Type.Emit (depth - 1);
				break;
				case production_kind.g_UserDefinedConstraintParameter_5:
					// emit syntax tree node associated with production
					// UserDefinedConstraintParameter: DefinedObjectClass

					s += m_DefinedObjectClass.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule UserDefinedConstraintParameter
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "UserDefinedConstraintParameter (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_UserDefinedConstraintParameter_1:
					// emit syntax tree node associated with production
					// UserDefinedConstraintParameter: Governor ":" Value

					s += m_Governor.EmitProductionTree (depth - 1);
					s += ' ';
					s += "colon";
					s += ' ';
					s += m_Value.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_UserDefinedConstraintParameter_2:
					// emit syntax tree node associated with production
					// UserDefinedConstraintParameter: Governor ":" Object

					s += m_Governor.EmitProductionTree (depth - 1);
					s += ' ';
					s += "colon";
					s += ' ';
					s += m_Object.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_UserDefinedConstraintParameter_3:
					// emit syntax tree node associated with production
					// UserDefinedConstraintParameter: DefinedObjectSet

					s += m_DefinedObjectSet.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_UserDefinedConstraintParameter_4:
					// emit syntax tree node associated with production
					// UserDefinedConstraintParameter: Type

					s += m_Type.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_UserDefinedConstraintParameter_5:
					// emit syntax tree node associated with production
					// UserDefinedConstraintParameter: DefinedObjectClass

					s += m_DefinedObjectClass.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule UserDefinedConstraintParameter

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule UserDefinedConstraintParameter with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			UserDefinedConstraintParameter.production_kind kind = (UserDefinedConstraintParameter.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_1:
					// traverse syntax tree node associated with production
					// UserDefinedConstraintParameter: Governor ":" Value

						m_Governor.Visit (visitor, appData);
						m_colon.Visit (visitor, appData);
						m_Value.Visit (visitor, appData);
				break;
				case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_2:
					// traverse syntax tree node associated with production
					// UserDefinedConstraintParameter: Governor ":" Object

						m_Governor.Visit (visitor, appData);
						m_colon.Visit (visitor, appData);
						m_Object.Visit (visitor, appData);
				break;
				case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_3:
					// traverse syntax tree node associated with production
					// UserDefinedConstraintParameter: DefinedObjectSet

						m_DefinedObjectSet.Visit (visitor, appData);
				break;
				case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_4:
					// traverse syntax tree node associated with production
					// UserDefinedConstraintParameter: Type

						m_Type.Visit (visitor, appData);
				break;
				case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_5:
					// traverse syntax tree node associated with production
					// UserDefinedConstraintParameter: DefinedObjectClass

						m_DefinedObjectClass.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Governor?.reparent (this);
			m_colon?.reparent (this);
			m_Value?.reparent (this);
			m_Object?.reparent (this);
			m_DefinedObjectSet?.reparent (this);
			m_Type?.reparent (this);
			m_DefinedObjectClass?.reparent (this);
		}

		//
		// initialize object associated with syntax rule UserDefinedConstraintParameter
		//

		public void _init ()
		{
			m_Governor = null;
			m_colon = null;
			m_Value = null;
			m_Object = null;
			m_DefinedObjectSet = null;
			m_Type = null;
			m_DefinedObjectClass = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule UserDefinedConstraintParameter

		// counter of all nodes associated with syntax rule UserDefinedConstraintParameter
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule UserDefinedConstraintParameter
		[DataMember (Name = "m_Governor")] public Governor m_Governor { get; private set; }
		[DataMember (Name = "m_colon")] public SyntaxTreeToken m_colon { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		[DataMember (Name = "m_Object")] public Object m_Object { get; private set; }
		[DataMember (Name = "m_DefinedObjectSet")] public DefinedObjectSet m_DefinedObjectSet { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_DefinedObjectClass")] public DefinedObjectClass m_DefinedObjectClass { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule UserDefinedConstraintParameter

		// delegate function (callback) prototype associated with syntax rule UserDefinedConstraintParameter
		public delegate bool UserDefinedConstraintParameter_Callback (SyntaxTreeCallbackReason reason, UserDefinedConstraintParameter.production_kind kind, UserDefinedConstraintParameter p_UserDefinedConstraintParameter);

		// event associated with syntax rule UserDefinedConstraintParameter
		public event UserDefinedConstraintParameter_Callback UserDefinedConstraintParameter_Event;

		// event trigger associated with syntax rule UserDefinedConstraintParameter
		public bool Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason reason, UserDefinedConstraintParameter.production_kind kind, UserDefinedConstraintParameter p_UserDefinedConstraintParameter)
		{
			bool? status = UserDefinedConstraintParameter_Event?.Invoke (reason, kind, p_UserDefinedConstraintParameter);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule UserDefinedConstraintParameter
		//
		// traverse syntax tree node associated with any production of syntax rule UserDefinedConstraintParameter
		//

		public void Traverse (UserDefinedConstraintParameter p_UserDefinedConstraintParameter)
		{
			if (p_UserDefinedConstraintParameter.isLocked())
				return;
			p_UserDefinedConstraintParameter.dolock();
			UserDefinedConstraintParameter.production_kind kind = (UserDefinedConstraintParameter.production_kind) p_UserDefinedConstraintParameter.kind;
			p_UserDefinedConstraintParameter.turn_reset ();
			if (Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_UserDefinedConstraintParameter))
			switch (kind)
			{
				case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_1:
					// traverse syntax tree node associated with production
					// UserDefinedConstraintParameter: Governor ":" Value

					if (Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UserDefinedConstraintParameter))
						Traverse (p_UserDefinedConstraintParameter.m_Governor);
					p_UserDefinedConstraintParameter.turn_inc ();
					if (Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UserDefinedConstraintParameter))
						Traverse (p_UserDefinedConstraintParameter.m_Value);
					p_UserDefinedConstraintParameter.turn_inc ();
					Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UserDefinedConstraintParameter);
				break;
				case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_2:
					// traverse syntax tree node associated with production
					// UserDefinedConstraintParameter: Governor ":" Object

					if (Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UserDefinedConstraintParameter))
						Traverse (p_UserDefinedConstraintParameter.m_Governor);
					p_UserDefinedConstraintParameter.turn_inc ();
					if (Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UserDefinedConstraintParameter))
						Traverse (p_UserDefinedConstraintParameter.m_Object);
					p_UserDefinedConstraintParameter.turn_inc ();
					Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UserDefinedConstraintParameter);
				break;
				case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_3:
					// traverse syntax tree node associated with production
					// UserDefinedConstraintParameter: DefinedObjectSet

					if (Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UserDefinedConstraintParameter))
						Traverse (p_UserDefinedConstraintParameter.m_DefinedObjectSet);
					p_UserDefinedConstraintParameter.turn_inc ();
					Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UserDefinedConstraintParameter);
				break;
				case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_4:
					// traverse syntax tree node associated with production
					// UserDefinedConstraintParameter: Type

					if (Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UserDefinedConstraintParameter))
						Traverse (p_UserDefinedConstraintParameter.m_Type);
					p_UserDefinedConstraintParameter.turn_inc ();
					Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UserDefinedConstraintParameter);
				break;
				case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_5:
					// traverse syntax tree node associated with production
					// UserDefinedConstraintParameter: DefinedObjectClass

					if (Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UserDefinedConstraintParameter))
						Traverse (p_UserDefinedConstraintParameter.m_DefinedObjectClass);
					p_UserDefinedConstraintParameter.turn_inc ();
					Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UserDefinedConstraintParameter);
				break;
			}
			Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_UserDefinedConstraintParameter);
			p_UserDefinedConstraintParameter.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule UserDefinedConstraintParameter
		//

		public void TraverseCommon (UserDefinedConstraintParameter p_UserDefinedConstraintParameter)
		{
			UserDefinedConstraintParameter.production_kind kind = (UserDefinedConstraintParameter.production_kind) p_UserDefinedConstraintParameter.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_UserDefinedConstraintParameter))
			switch (kind)
			{
				case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_1:
					// traverse syntax tree node associated with production
					// UserDefinedConstraintParameter: Governor ":" Value

						TraverseCommon (p_UserDefinedConstraintParameter.m_Governor);
						TraverseCommon (p_UserDefinedConstraintParameter.m_colon);
						TraverseCommon (p_UserDefinedConstraintParameter.m_Value);
				break;
				case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_2:
					// traverse syntax tree node associated with production
					// UserDefinedConstraintParameter: Governor ":" Object

						TraverseCommon (p_UserDefinedConstraintParameter.m_Governor);
						TraverseCommon (p_UserDefinedConstraintParameter.m_colon);
						TraverseCommon (p_UserDefinedConstraintParameter.m_Object);
				break;
				case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_3:
					// traverse syntax tree node associated with production
					// UserDefinedConstraintParameter: DefinedObjectSet

						TraverseCommon (p_UserDefinedConstraintParameter.m_DefinedObjectSet);
				break;
				case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_4:
					// traverse syntax tree node associated with production
					// UserDefinedConstraintParameter: Type

						TraverseCommon (p_UserDefinedConstraintParameter.m_Type);
				break;
				case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_5:
					// traverse syntax tree node associated with production
					// UserDefinedConstraintParameter: DefinedObjectClass

						TraverseCommon (p_UserDefinedConstraintParameter.m_DefinedObjectClass);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_UserDefinedConstraintParameter);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule UserDefinedConstraintParameter

		//
		// create syntax tree node associated with production
		// UserDefinedConstraintParameter: Governor ":" Value

		//

		public UserDefinedConstraintParameter UserDefinedConstraintParameter_1 (Governor p_Governor, SyntaxTreeToken p_token, Value p_Value)
		{
			UserDefinedConstraintParameter p_UserDefinedConstraintParameter_ref = new UserDefinedConstraintParameter(p_Governor, p_token, p_Value);
			p_Governor.parent = p_UserDefinedConstraintParameter_ref;
			p_token.parent = p_UserDefinedConstraintParameter_ref;
			p_Value.parent = p_UserDefinedConstraintParameter_ref;
			Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_1, p_UserDefinedConstraintParameter_ref);
			return p_UserDefinedConstraintParameter_ref;
		}

		//
		// create syntax tree node associated with production
		// UserDefinedConstraintParameter: Governor ":" Object

		//

		public UserDefinedConstraintParameter UserDefinedConstraintParameter_2 (Governor p_Governor, SyntaxTreeToken p_token, Object p_Object)
		{
			UserDefinedConstraintParameter p_UserDefinedConstraintParameter_ref = new UserDefinedConstraintParameter(p_Governor, p_token, p_Object);
			p_Governor.parent = p_UserDefinedConstraintParameter_ref;
			p_token.parent = p_UserDefinedConstraintParameter_ref;
			p_Object.parent = p_UserDefinedConstraintParameter_ref;
			Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_2, p_UserDefinedConstraintParameter_ref);
			return p_UserDefinedConstraintParameter_ref;
		}

		//
		// create syntax tree node associated with production
		// UserDefinedConstraintParameter: DefinedObjectSet

		//

		public UserDefinedConstraintParameter UserDefinedConstraintParameter_3 (DefinedObjectSet p_DefinedObjectSet)
		{
			UserDefinedConstraintParameter p_UserDefinedConstraintParameter_ref = new UserDefinedConstraintParameter(p_DefinedObjectSet);
			p_DefinedObjectSet.parent = p_UserDefinedConstraintParameter_ref;
			Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_3, p_UserDefinedConstraintParameter_ref);
			return p_UserDefinedConstraintParameter_ref;
		}

		//
		// create syntax tree node associated with production
		// UserDefinedConstraintParameter: Type

		//

		public UserDefinedConstraintParameter UserDefinedConstraintParameter_4 (Type p_Type)
		{
			UserDefinedConstraintParameter p_UserDefinedConstraintParameter_ref = new UserDefinedConstraintParameter(p_Type);
			p_Type.parent = p_UserDefinedConstraintParameter_ref;
			Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_4, p_UserDefinedConstraintParameter_ref);
			return p_UserDefinedConstraintParameter_ref;
		}

		//
		// create syntax tree node associated with production
		// UserDefinedConstraintParameter: DefinedObjectClass

		//

		public UserDefinedConstraintParameter UserDefinedConstraintParameter_5 (DefinedObjectClass p_DefinedObjectClass)
		{
			UserDefinedConstraintParameter p_UserDefinedConstraintParameter_ref = new UserDefinedConstraintParameter(p_DefinedObjectClass);
			p_DefinedObjectClass.parent = p_UserDefinedConstraintParameter_ref;
			Raise_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_5, p_UserDefinedConstraintParameter_ref);
			return p_UserDefinedConstraintParameter_ref;
		}
		#endregion
	};
}
