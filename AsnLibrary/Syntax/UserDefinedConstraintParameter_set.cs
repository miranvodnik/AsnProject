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
	// class associated with syntax rule UserDefinedConstraintParameter-set
	//

	[DataContract]
	public class	UserDefinedConstraintParameter_set : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule UserDefinedConstraintParameter-set
		public enum production_kind : ushort	// enumerated production(s) of syntax rule UserDefinedConstraintParameter-set
		{
			g_UserDefinedConstraintParameter_set_1 = 1,	// UserDefinedConstraintParameter

			g_UserDefinedConstraintParameter_set_2 = 2,	// UserDefinedConstraintParameter-set "," UserDefinedConstraintParameter

		};
		#endregion
		#region production markers associated with the syntax rule UserDefinedConstraintParameter-set

		// markers associated with production: UserDefinedConstraintParameter-set -> UserDefinedConstraintParameter

		public enum production_marker_1 : ushort
		{
			m_UserDefinedConstraintParameter,
			final
		};

		// markers associated with production: UserDefinedConstraintParameter-set -> UserDefinedConstraintParameter-set "," UserDefinedConstraintParameter

		public enum production_marker_2 : ushort
		{
			m_UserDefinedConstraintParameter_set,
			m_UserDefinedConstraintParameter,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule UserDefinedConstraintParameter-set

		// Constructor declaration(s) associated with production(s) of syntax rule UserDefinedConstraintParameter-set

		//
		// Constructor associated with the following production(s)
		// UserDefinedConstraintParameter-set -> UserDefinedConstraintParameter

		//

		public UserDefinedConstraintParameter_set (UserDefinedConstraintParameter p_UserDefinedConstraintParameter) : base ((uint) ProductionID._UserDefinedConstraintParameter_set_ID, (uint) production_kind.g_UserDefinedConstraintParameter_set_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_UserDefinedConstraintParameter = p_UserDefinedConstraintParameter;
		}

		//
		// Constructor associated with the following production(s)
		// UserDefinedConstraintParameter-set -> UserDefinedConstraintParameter-set "," UserDefinedConstraintParameter

		//

		public UserDefinedConstraintParameter_set (UserDefinedConstraintParameter_set p_UserDefinedConstraintParameter_set, SyntaxTreeToken p_token, UserDefinedConstraintParameter p_UserDefinedConstraintParameter) : base ((uint) ProductionID._UserDefinedConstraintParameter_set_ID, (uint) production_kind.g_UserDefinedConstraintParameter_set_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_UserDefinedConstraintParameter_set = p_UserDefinedConstraintParameter_set;
			children[1] = m_comma = p_token;
			children[2] = m_UserDefinedConstraintParameter = p_UserDefinedConstraintParameter;
		}

		public UserDefinedConstraintParameter_set () { }

		// Copy constructor

		public UserDefinedConstraintParameter_set (UserDefinedConstraintParameter_set p_UserDefinedConstraintParameter_set) : base (p_UserDefinedConstraintParameter_set.id, p_UserDefinedConstraintParameter_set.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_UserDefinedConstraintParameter_set.appInfo;
			switch ((production_kind) p_UserDefinedConstraintParameter_set.kind)
			{
				case production_kind.g_UserDefinedConstraintParameter_set_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UserDefinedConstraintParameter = (p_UserDefinedConstraintParameter_set.m_UserDefinedConstraintParameter != null) ? new UserDefinedConstraintParameter (p_UserDefinedConstraintParameter_set.m_UserDefinedConstraintParameter) : null) != null) m_UserDefinedConstraintParameter.parent = this;
					break;
				case production_kind.g_UserDefinedConstraintParameter_set_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_UserDefinedConstraintParameter_set = (p_UserDefinedConstraintParameter_set.m_UserDefinedConstraintParameter_set != null) ? new UserDefinedConstraintParameter_set (p_UserDefinedConstraintParameter_set.m_UserDefinedConstraintParameter_set) : null) != null) m_UserDefinedConstraintParameter_set.parent = this;
					if ((children [1] = m_comma = (p_UserDefinedConstraintParameter_set.m_comma != null) ? new SyntaxTreeToken (p_UserDefinedConstraintParameter_set.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_UserDefinedConstraintParameter = (p_UserDefinedConstraintParameter_set.m_UserDefinedConstraintParameter != null) ? new UserDefinedConstraintParameter (p_UserDefinedConstraintParameter_set.m_UserDefinedConstraintParameter) : null) != null) m_UserDefinedConstraintParameter.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "UserDefinedConstraintParameter_set" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new UserDefinedConstraintParameter_set (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_UserDefinedConstraintParameter?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule UserDefinedConstraintParameter-set

		// Content changing function(s) associated with production(s) of syntax rule UserDefinedConstraintParameter-set

		//
		// Content changing function associated with following production(s)
		// UserDefinedConstraintParameter-set -> UserDefinedConstraintParameter

		//

		public void change(UserDefinedConstraintParameter p_UserDefinedConstraintParameter)
		{
			_init ();
			this.kind = (uint) production_kind.g_UserDefinedConstraintParameter_set_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_UserDefinedConstraintParameter = p_UserDefinedConstraintParameter;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// UserDefinedConstraintParameter-set -> UserDefinedConstraintParameter-set "," UserDefinedConstraintParameter

		//

		public void change(UserDefinedConstraintParameter_set p_UserDefinedConstraintParameter_set, SyntaxTreeToken p_token, UserDefinedConstraintParameter p_UserDefinedConstraintParameter)
		{
			_init ();
			this.kind = (uint) production_kind.g_UserDefinedConstraintParameter_set_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_UserDefinedConstraintParameter_set = p_UserDefinedConstraintParameter_set;
			children [1] = m_comma = p_token;
			children [2] = m_UserDefinedConstraintParameter = p_UserDefinedConstraintParameter;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule UserDefinedConstraintParameter-set
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_UserDefinedConstraintParameter != null) && node.m_UserDefinedConstraintParameter.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule UserDefinedConstraintParameter-set

		//
		// emit production tree node associated with any production of syntax rule UserDefinedConstraintParameter-set
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_UserDefinedConstraintParameter_set_1:
						// emit syntax tree node associated with production
						// UserDefinedConstraintParameter-set: UserDefinedConstraintParameter

						s += " " + node.m_UserDefinedConstraintParameter.Emit (depth - 1);
						break;
					case production_kind.g_UserDefinedConstraintParameter_set_2:
						// emit syntax tree node associated with production
						// UserDefinedConstraintParameter-set: UserDefinedConstraintParameter-set "," UserDefinedConstraintParameter

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_UserDefinedConstraintParameter.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule UserDefinedConstraintParameter-set
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "UserDefinedConstraintParameter_set (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_UserDefinedConstraintParameter_set_1:
						// emit syntax tree node associated with production
						// UserDefinedConstraintParameter-set: UserDefinedConstraintParameter

						str += node.m_UserDefinedConstraintParameter.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_UserDefinedConstraintParameter_set_2:
						// emit syntax tree node associated with production
						// UserDefinedConstraintParameter-set: UserDefinedConstraintParameter-set "," UserDefinedConstraintParameter

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_UserDefinedConstraintParameter.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule UserDefinedConstraintParameter-set

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule UserDefinedConstraintParameter-set with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					UserDefinedConstraintParameter_set.production_kind kind = (UserDefinedConstraintParameter_set.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case UserDefinedConstraintParameter_set.production_kind.g_UserDefinedConstraintParameter_set_1:
							// traverse syntax tree node associated with production
							// UserDefinedConstraintParameter-set: UserDefinedConstraintParameter

							node.m_UserDefinedConstraintParameter.Visit (visitor, appData);
							break;
						case UserDefinedConstraintParameter_set.production_kind.g_UserDefinedConstraintParameter_set_2:
							// traverse syntax tree node associated with production
							// UserDefinedConstraintParameter-set: UserDefinedConstraintParameter-set "," UserDefinedConstraintParameter

							node.m_comma.Visit (visitor, appData);
							node.m_UserDefinedConstraintParameter.Visit (visitor, appData);
							break;
						}
					visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node, appData);
					return null;
				});
			visitor (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) this.kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			for (UserDefinedConstraintParameter_set node = this; node != null; node = node.m_UserDefinedConstraintParameter_set)
			{
				node.parent = parent;
				node.m_UserDefinedConstraintParameter?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule UserDefinedConstraintParameter-set
		//

		public void _init ()
		{
			m_UserDefinedConstraintParameter = null;
			m_UserDefinedConstraintParameter_set = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (UserDefinedConstraintParameter_set p_UserDefinedConstraintParameter_set, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<UserDefinedConstraintParameter_set> stack = new Stack<UserDefinedConstraintParameter_set> ();
			UserDefinedConstraintParameter_set p_UserDefinedConstraintParameter_set;
			for (p_UserDefinedConstraintParameter_set = this; p_UserDefinedConstraintParameter_set != null; p_UserDefinedConstraintParameter_set = p_UserDefinedConstraintParameter_set.m_UserDefinedConstraintParameter_set)
				stack.Push (p_UserDefinedConstraintParameter_set);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule UserDefinedConstraintParameter-set

		// counter of all nodes associated with syntax rule UserDefinedConstraintParameter-set
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule UserDefinedConstraintParameter-set
		[DataMember (Name = "m_UserDefinedConstraintParameter")] public UserDefinedConstraintParameter m_UserDefinedConstraintParameter { get; private set; }
		[DataMember (Name = "m_UserDefinedConstraintParameter_set")] public UserDefinedConstraintParameter_set m_UserDefinedConstraintParameter_set { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule UserDefinedConstraintParameter-set

		// delegate function (callback) prototype associated with syntax rule UserDefinedConstraintParameter-set
		public delegate bool UserDefinedConstraintParameter_set_Callback (SyntaxTreeCallbackReason reason, UserDefinedConstraintParameter_set.production_kind kind, UserDefinedConstraintParameter_set p_UserDefinedConstraintParameter_set);

		// event associated with syntax rule UserDefinedConstraintParameter-set
		public event UserDefinedConstraintParameter_set_Callback UserDefinedConstraintParameter_set_Event;

		// event trigger associated with syntax rule UserDefinedConstraintParameter-set
		public bool Raise_UserDefinedConstraintParameter_set_Event (SyntaxTreeCallbackReason reason, UserDefinedConstraintParameter_set.production_kind kind, UserDefinedConstraintParameter_set p_UserDefinedConstraintParameter_set)
		{
			bool? status = UserDefinedConstraintParameter_set_Event?.Invoke (reason, kind, p_UserDefinedConstraintParameter_set);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule UserDefinedConstraintParameter-set
		//
		// traverse syntax tree node associated with any production of syntax rule UserDefinedConstraintParameter-set
		//

		public void Traverse (UserDefinedConstraintParameter_set p_UserDefinedConstraintParameter_set)
		{
			if (p_UserDefinedConstraintParameter_set.isLocked())
				return;
			if (Raise_UserDefinedConstraintParameter_set_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (UserDefinedConstraintParameter_set.production_kind) p_UserDefinedConstraintParameter_set.kind, p_UserDefinedConstraintParameter_set))
				p_UserDefinedConstraintParameter_set.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					UserDefinedConstraintParameter_set.production_kind kind = (UserDefinedConstraintParameter_set.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_UserDefinedConstraintParameter_set_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case UserDefinedConstraintParameter_set.production_kind.g_UserDefinedConstraintParameter_set_1:
								// traverse syntax tree node associated with production
								// UserDefinedConstraintParameter-set: UserDefinedConstraintParameter

								if (Raise_UserDefinedConstraintParameter_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_UserDefinedConstraintParameter);
								node.turn_inc ();
								Raise_UserDefinedConstraintParameter_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case UserDefinedConstraintParameter_set.production_kind.g_UserDefinedConstraintParameter_set_2:
								// traverse syntax tree node associated with production
								// UserDefinedConstraintParameter-set: UserDefinedConstraintParameter-set "," UserDefinedConstraintParameter

								if (Raise_UserDefinedConstraintParameter_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_UserDefinedConstraintParameter_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_UserDefinedConstraintParameter);
								node.turn_inc ();
								Raise_UserDefinedConstraintParameter_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_UserDefinedConstraintParameter_set_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_UserDefinedConstraintParameter_set_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (UserDefinedConstraintParameter_set.production_kind) p_UserDefinedConstraintParameter_set.kind, p_UserDefinedConstraintParameter_set);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule UserDefinedConstraintParameter-set
		//

		public void TraverseCommon (UserDefinedConstraintParameter_set p_UserDefinedConstraintParameter_set)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_UserDefinedConstraintParameter_set.kind, p_UserDefinedConstraintParameter_set))
				p_UserDefinedConstraintParameter_set.Iterate (null, (node, appData) =>
				{
					UserDefinedConstraintParameter_set.production_kind kind = (UserDefinedConstraintParameter_set.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case UserDefinedConstraintParameter_set.production_kind.g_UserDefinedConstraintParameter_set_1:
							// traverse syntax tree node associated with production
							// UserDefinedConstraintParameter-set: UserDefinedConstraintParameter

							TraverseCommon (node.m_UserDefinedConstraintParameter);
							break;
						case UserDefinedConstraintParameter_set.production_kind.g_UserDefinedConstraintParameter_set_2:
							// traverse syntax tree node associated with production
							// UserDefinedConstraintParameter-set: UserDefinedConstraintParameter-set "," UserDefinedConstraintParameter

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_UserDefinedConstraintParameter);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_UserDefinedConstraintParameter_set.kind, p_UserDefinedConstraintParameter_set);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule UserDefinedConstraintParameter-set

		//
		// create syntax tree node associated with production
		// UserDefinedConstraintParameter-set: UserDefinedConstraintParameter

		//

		public UserDefinedConstraintParameter_set UserDefinedConstraintParameter_set_1 (UserDefinedConstraintParameter p_UserDefinedConstraintParameter)
		{
			UserDefinedConstraintParameter_set p_UserDefinedConstraintParameter_set_ref = new UserDefinedConstraintParameter_set(p_UserDefinedConstraintParameter);
			p_UserDefinedConstraintParameter.parent = p_UserDefinedConstraintParameter_set_ref;
			Raise_UserDefinedConstraintParameter_set_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UserDefinedConstraintParameter_set.production_kind.g_UserDefinedConstraintParameter_set_1, p_UserDefinedConstraintParameter_set_ref);
			return p_UserDefinedConstraintParameter_set_ref;
		}

		//
		// create syntax tree node associated with production
		// UserDefinedConstraintParameter-set: UserDefinedConstraintParameter-set "," UserDefinedConstraintParameter

		//

		public UserDefinedConstraintParameter_set UserDefinedConstraintParameter_set_2 (UserDefinedConstraintParameter_set p_UserDefinedConstraintParameter_set, SyntaxTreeToken p_token, UserDefinedConstraintParameter p_UserDefinedConstraintParameter)
		{
			UserDefinedConstraintParameter_set p_UserDefinedConstraintParameter_set_ref = new UserDefinedConstraintParameter_set(p_UserDefinedConstraintParameter_set, p_token, p_UserDefinedConstraintParameter);
			p_UserDefinedConstraintParameter_set.parent = p_UserDefinedConstraintParameter_set_ref;
			p_token.parent = p_UserDefinedConstraintParameter_set_ref;
			p_UserDefinedConstraintParameter.parent = p_UserDefinedConstraintParameter_set_ref;
			Raise_UserDefinedConstraintParameter_set_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UserDefinedConstraintParameter_set.production_kind.g_UserDefinedConstraintParameter_set_2, p_UserDefinedConstraintParameter_set_ref);
			return p_UserDefinedConstraintParameter_set_ref;
		}
		#endregion
	};
}
