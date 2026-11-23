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
	// class associated with syntax rule AC-Groups
	//

	[DataContract]
	public class	AC_Groups : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-Groups
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-Groups
		{
			g_AC_Groups_1 = 1,	// AC-Group

			g_AC_Groups_2 = 2,	// AC-Groups "," AC-Group

		};
		#endregion
		#region production markers associated with the syntax rule AC-Groups

		// markers associated with production: AC-Groups -> AC-Group

		public enum production_marker_1 : ushort
		{
			m_AC_Group,
			final
		};

		// markers associated with production: AC-Groups -> AC-Groups "," AC-Group

		public enum production_marker_2 : ushort
		{
			m_AC_Groups,
			m_AC_Group,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-Groups

		// Constructor declaration(s) associated with production(s) of syntax rule AC-Groups

		//
		// Constructor associated with the following production(s)
		// AC-Groups -> AC-Group

		//

		public AC_Groups (AC_Group p_AC_Group) : base ((uint) ProductionID._AC_Groups_ID, (uint) production_kind.g_AC_Groups_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_AC_Group = p_AC_Group;
		}

		//
		// Constructor associated with the following production(s)
		// AC-Groups -> AC-Groups "," AC-Group

		//

		public AC_Groups (AC_Groups p_AC_Groups, SyntaxTreeToken p_token, AC_Group p_AC_Group) : base ((uint) ProductionID._AC_Groups_ID, (uint) production_kind.g_AC_Groups_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_AC_Groups = p_AC_Groups;
			children[1] = m_comma = p_token;
			children[2] = m_AC_Group = p_AC_Group;
		}

		public AC_Groups () { }

		// Copy constructor

		public AC_Groups (AC_Groups p_AC_Groups) : base (p_AC_Groups.id, p_AC_Groups.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_Groups.appInfo;
			switch ((production_kind) p_AC_Groups.kind)
			{
				case production_kind.g_AC_Groups_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_AC_Group = (p_AC_Groups.m_AC_Group != null) ? new AC_Group (p_AC_Groups.m_AC_Group) : null) != null) m_AC_Group.parent = this;
					break;
				case production_kind.g_AC_Groups_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_AC_Groups = (p_AC_Groups.m_AC_Groups != null) ? new AC_Groups (p_AC_Groups.m_AC_Groups) : null) != null) m_AC_Groups.parent = this;
					if ((children [1] = m_comma = (p_AC_Groups.m_comma != null) ? new SyntaxTreeToken (p_AC_Groups.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_AC_Group = (p_AC_Groups.m_AC_Group != null) ? new AC_Group (p_AC_Groups.m_AC_Group) : null) != null) m_AC_Group.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AC_Groups" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_Groups (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_AC_Group?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-Groups

		// Content changing function(s) associated with production(s) of syntax rule AC-Groups

		//
		// Content changing function associated with following production(s)
		// AC-Groups -> AC-Group

		//

		public void change(AC_Group p_AC_Group)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_Groups_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_AC_Group = p_AC_Group;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AC-Groups -> AC-Groups "," AC-Group

		//

		public void change(AC_Groups p_AC_Groups, SyntaxTreeToken p_token, AC_Group p_AC_Group)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_Groups_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_AC_Groups = p_AC_Groups;
			children [1] = m_comma = p_token;
			children [2] = m_AC_Group = p_AC_Group;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-Groups
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_AC_Group != null) && node.m_AC_Group.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-Groups

		//
		// emit production tree node associated with any production of syntax rule AC-Groups
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_AC_Groups_1:
						// emit syntax tree node associated with production
						// AC-Groups: AC-Group

						s += " " + node.m_AC_Group.Emit (depth - 1);
						break;
					case production_kind.g_AC_Groups_2:
						// emit syntax tree node associated with production
						// AC-Groups: AC-Groups "," AC-Group

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_AC_Group.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-Groups
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "AC_Groups (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_AC_Groups_1:
						// emit syntax tree node associated with production
						// AC-Groups: AC-Group

						str += node.m_AC_Group.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_AC_Groups_2:
						// emit syntax tree node associated with production
						// AC-Groups: AC-Groups "," AC-Group

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_AC_Group.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-Groups

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Groups with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					AC_Groups.production_kind kind = (AC_Groups.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case AC_Groups.production_kind.g_AC_Groups_1:
							// traverse syntax tree node associated with production
							// AC-Groups: AC-Group

							node.m_AC_Group.Visit (visitor, appData);
							break;
						case AC_Groups.production_kind.g_AC_Groups_2:
							// traverse syntax tree node associated with production
							// AC-Groups: AC-Groups "," AC-Group

							node.m_comma.Visit (visitor, appData);
							node.m_AC_Group.Visit (visitor, appData);
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
			for (AC_Groups node = this; node != null; node = node.m_AC_Groups)
			{
				node.parent = parent;
				node.m_AC_Group?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule AC-Groups
		//

		public void _init ()
		{
			m_AC_Group = null;
			m_AC_Groups = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (AC_Groups p_AC_Groups, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<AC_Groups> stack = new Stack<AC_Groups> ();
			AC_Groups p_AC_Groups;
			for (p_AC_Groups = this; p_AC_Groups != null; p_AC_Groups = p_AC_Groups.m_AC_Groups)
				stack.Push (p_AC_Groups);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-Groups

		// counter of all nodes associated with syntax rule AC-Groups
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-Groups
		[DataMember (Name = "m_AC_Group")] public AC_Group m_AC_Group { get; private set; }
		[DataMember (Name = "m_AC_Groups")] public AC_Groups m_AC_Groups { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-Groups

		// delegate function (callback) prototype associated with syntax rule AC-Groups
		public delegate bool AC_Groups_Callback (SyntaxTreeCallbackReason reason, AC_Groups.production_kind kind, AC_Groups p_AC_Groups);

		// event associated with syntax rule AC-Groups
		public event AC_Groups_Callback AC_Groups_Event;

		// event trigger associated with syntax rule AC-Groups
		public bool Raise_AC_Groups_Event (SyntaxTreeCallbackReason reason, AC_Groups.production_kind kind, AC_Groups p_AC_Groups)
		{
			bool? status = AC_Groups_Event?.Invoke (reason, kind, p_AC_Groups);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-Groups
		//
		// traverse syntax tree node associated with any production of syntax rule AC-Groups
		//

		public void Traverse (AC_Groups p_AC_Groups)
		{
			if (p_AC_Groups.isLocked())
				return;
			if (Raise_AC_Groups_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (AC_Groups.production_kind) p_AC_Groups.kind, p_AC_Groups))
				p_AC_Groups.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					AC_Groups.production_kind kind = (AC_Groups.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_AC_Groups_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case AC_Groups.production_kind.g_AC_Groups_1:
								// traverse syntax tree node associated with production
								// AC-Groups: AC-Group

								if (Raise_AC_Groups_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_AC_Group);
								node.turn_inc ();
								Raise_AC_Groups_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case AC_Groups.production_kind.g_AC_Groups_2:
								// traverse syntax tree node associated with production
								// AC-Groups: AC-Groups "," AC-Group

								if (Raise_AC_Groups_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_AC_Groups_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_AC_Group);
								node.turn_inc ();
								Raise_AC_Groups_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_AC_Groups_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_AC_Groups_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (AC_Groups.production_kind) p_AC_Groups.kind, p_AC_Groups);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Groups
		//

		public void TraverseCommon (AC_Groups p_AC_Groups)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_AC_Groups.kind, p_AC_Groups))
				p_AC_Groups.Iterate (null, (node, appData) =>
				{
					AC_Groups.production_kind kind = (AC_Groups.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case AC_Groups.production_kind.g_AC_Groups_1:
							// traverse syntax tree node associated with production
							// AC-Groups: AC-Group

							TraverseCommon (node.m_AC_Group);
							break;
						case AC_Groups.production_kind.g_AC_Groups_2:
							// traverse syntax tree node associated with production
							// AC-Groups: AC-Groups "," AC-Group

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_AC_Group);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_AC_Groups.kind, p_AC_Groups);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-Groups

		//
		// create syntax tree node associated with production
		// AC-Groups: AC-Group

		//

		public AC_Groups AC_Groups_1 (AC_Group p_AC_Group)
		{
			AC_Groups p_AC_Groups_ref = new AC_Groups(p_AC_Group);
			p_AC_Group.parent = p_AC_Groups_ref;
			Raise_AC_Groups_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_Groups.production_kind.g_AC_Groups_1, p_AC_Groups_ref);
			return p_AC_Groups_ref;
		}

		//
		// create syntax tree node associated with production
		// AC-Groups: AC-Groups "," AC-Group

		//

		public AC_Groups AC_Groups_2 (AC_Groups p_AC_Groups, SyntaxTreeToken p_token, AC_Group p_AC_Group)
		{
			AC_Groups p_AC_Groups_ref = new AC_Groups(p_AC_Groups, p_token, p_AC_Group);
			p_AC_Groups.parent = p_AC_Groups_ref;
			p_token.parent = p_AC_Groups_ref;
			p_AC_Group.parent = p_AC_Groups_ref;
			Raise_AC_Groups_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_Groups.production_kind.g_AC_Groups_2, p_AC_Groups_ref);
			return p_AC_Groups_ref;
		}
		#endregion
	};
}
