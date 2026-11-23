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
	// class associated with syntax rule MC-Groups
	//

	[DataContract]
	public class	MC_Groups : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MC-Groups
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MC-Groups
		{
			g_MC_Groups_1 = 1,	// MC-Group

			g_MC_Groups_2 = 2,	// MC-Groups "," MC-Group

		};
		#endregion
		#region production markers associated with the syntax rule MC-Groups

		// markers associated with production: MC-Groups -> MC-Group

		public enum production_marker_1 : ushort
		{
			m_MC_Group,
			final
		};

		// markers associated with production: MC-Groups -> MC-Groups "," MC-Group

		public enum production_marker_2 : ushort
		{
			m_MC_Groups,
			m_MC_Group,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MC-Groups

		// Constructor declaration(s) associated with production(s) of syntax rule MC-Groups

		//
		// Constructor associated with the following production(s)
		// MC-Groups -> MC-Group

		//

		public MC_Groups (MC_Group p_MC_Group) : base ((uint) ProductionID._MC_Groups_ID, (uint) production_kind.g_MC_Groups_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_MC_Group = p_MC_Group;
		}

		//
		// Constructor associated with the following production(s)
		// MC-Groups -> MC-Groups "," MC-Group

		//

		public MC_Groups (MC_Groups p_MC_Groups, SyntaxTreeToken p_token, MC_Group p_MC_Group) : base ((uint) ProductionID._MC_Groups_ID, (uint) production_kind.g_MC_Groups_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_MC_Groups = p_MC_Groups;
			children[1] = m_comma = p_token;
			children[2] = m_MC_Group = p_MC_Group;
		}

		public MC_Groups () { }

		// Copy constructor

		public MC_Groups (MC_Groups p_MC_Groups) : base (p_MC_Groups.id, p_MC_Groups.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MC_Groups.appInfo;
			switch ((production_kind) p_MC_Groups.kind)
			{
				case production_kind.g_MC_Groups_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MC_Group = (p_MC_Groups.m_MC_Group != null) ? new MC_Group (p_MC_Groups.m_MC_Group) : null) != null) m_MC_Group.parent = this;
					break;
				case production_kind.g_MC_Groups_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_MC_Groups = (p_MC_Groups.m_MC_Groups != null) ? new MC_Groups (p_MC_Groups.m_MC_Groups) : null) != null) m_MC_Groups.parent = this;
					if ((children [1] = m_comma = (p_MC_Groups.m_comma != null) ? new SyntaxTreeToken (p_MC_Groups.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_MC_Group = (p_MC_Groups.m_MC_Group != null) ? new MC_Group (p_MC_Groups.m_MC_Group) : null) != null) m_MC_Group.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "MC_Groups" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MC_Groups (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_MC_Group?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MC-Groups

		// Content changing function(s) associated with production(s) of syntax rule MC-Groups

		//
		// Content changing function associated with following production(s)
		// MC-Groups -> MC-Group

		//

		public void change(MC_Group p_MC_Group)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_Groups_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_MC_Group = p_MC_Group;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MC-Groups -> MC-Groups "," MC-Group

		//

		public void change(MC_Groups p_MC_Groups, SyntaxTreeToken p_token, MC_Group p_MC_Group)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_Groups_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_MC_Groups = p_MC_Groups;
			children [1] = m_comma = p_token;
			children [2] = m_MC_Group = p_MC_Group;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MC-Groups
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_MC_Group != null) && node.m_MC_Group.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MC-Groups

		//
		// emit production tree node associated with any production of syntax rule MC-Groups
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_MC_Groups_1:
						// emit syntax tree node associated with production
						// MC-Groups: MC-Group

						s += " " + node.m_MC_Group.Emit (depth - 1);
						break;
					case production_kind.g_MC_Groups_2:
						// emit syntax tree node associated with production
						// MC-Groups: MC-Groups "," MC-Group

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_MC_Group.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MC-Groups
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "MC_Groups (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_MC_Groups_1:
						// emit syntax tree node associated with production
						// MC-Groups: MC-Group

						str += node.m_MC_Group.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_MC_Groups_2:
						// emit syntax tree node associated with production
						// MC-Groups: MC-Groups "," MC-Group

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_MC_Group.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MC-Groups

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MC-Groups with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					MC_Groups.production_kind kind = (MC_Groups.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case MC_Groups.production_kind.g_MC_Groups_1:
							// traverse syntax tree node associated with production
							// MC-Groups: MC-Group

							node.m_MC_Group.Visit (visitor, appData);
							break;
						case MC_Groups.production_kind.g_MC_Groups_2:
							// traverse syntax tree node associated with production
							// MC-Groups: MC-Groups "," MC-Group

							node.m_comma.Visit (visitor, appData);
							node.m_MC_Group.Visit (visitor, appData);
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
			for (MC_Groups node = this; node != null; node = node.m_MC_Groups)
			{
				node.parent = parent;
				node.m_MC_Group?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule MC-Groups
		//

		public void _init ()
		{
			m_MC_Group = null;
			m_MC_Groups = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (MC_Groups p_MC_Groups, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<MC_Groups> stack = new Stack<MC_Groups> ();
			MC_Groups p_MC_Groups;
			for (p_MC_Groups = this; p_MC_Groups != null; p_MC_Groups = p_MC_Groups.m_MC_Groups)
				stack.Push (p_MC_Groups);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MC-Groups

		// counter of all nodes associated with syntax rule MC-Groups
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MC-Groups
		[DataMember (Name = "m_MC_Group")] public MC_Group m_MC_Group { get; private set; }
		[DataMember (Name = "m_MC_Groups")] public MC_Groups m_MC_Groups { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MC-Groups

		// delegate function (callback) prototype associated with syntax rule MC-Groups
		public delegate bool MC_Groups_Callback (SyntaxTreeCallbackReason reason, MC_Groups.production_kind kind, MC_Groups p_MC_Groups);

		// event associated with syntax rule MC-Groups
		public event MC_Groups_Callback MC_Groups_Event;

		// event trigger associated with syntax rule MC-Groups
		public bool Raise_MC_Groups_Event (SyntaxTreeCallbackReason reason, MC_Groups.production_kind kind, MC_Groups p_MC_Groups)
		{
			bool? status = MC_Groups_Event?.Invoke (reason, kind, p_MC_Groups);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MC-Groups
		//
		// traverse syntax tree node associated with any production of syntax rule MC-Groups
		//

		public void Traverse (MC_Groups p_MC_Groups)
		{
			if (p_MC_Groups.isLocked())
				return;
			if (Raise_MC_Groups_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (MC_Groups.production_kind) p_MC_Groups.kind, p_MC_Groups))
				p_MC_Groups.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					MC_Groups.production_kind kind = (MC_Groups.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_MC_Groups_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case MC_Groups.production_kind.g_MC_Groups_1:
								// traverse syntax tree node associated with production
								// MC-Groups: MC-Group

								if (Raise_MC_Groups_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_MC_Group);
								node.turn_inc ();
								Raise_MC_Groups_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case MC_Groups.production_kind.g_MC_Groups_2:
								// traverse syntax tree node associated with production
								// MC-Groups: MC-Groups "," MC-Group

								if (Raise_MC_Groups_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_MC_Groups_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_MC_Group);
								node.turn_inc ();
								Raise_MC_Groups_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_MC_Groups_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_MC_Groups_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (MC_Groups.production_kind) p_MC_Groups.kind, p_MC_Groups);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MC-Groups
		//

		public void TraverseCommon (MC_Groups p_MC_Groups)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_MC_Groups.kind, p_MC_Groups))
				p_MC_Groups.Iterate (null, (node, appData) =>
				{
					MC_Groups.production_kind kind = (MC_Groups.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case MC_Groups.production_kind.g_MC_Groups_1:
							// traverse syntax tree node associated with production
							// MC-Groups: MC-Group

							TraverseCommon (node.m_MC_Group);
							break;
						case MC_Groups.production_kind.g_MC_Groups_2:
							// traverse syntax tree node associated with production
							// MC-Groups: MC-Groups "," MC-Group

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_MC_Group);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_MC_Groups.kind, p_MC_Groups);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MC-Groups

		//
		// create syntax tree node associated with production
		// MC-Groups: MC-Group

		//

		public MC_Groups MC_Groups_1 (MC_Group p_MC_Group)
		{
			MC_Groups p_MC_Groups_ref = new MC_Groups(p_MC_Group);
			p_MC_Group.parent = p_MC_Groups_ref;
			Raise_MC_Groups_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_Groups.production_kind.g_MC_Groups_1, p_MC_Groups_ref);
			return p_MC_Groups_ref;
		}

		//
		// create syntax tree node associated with production
		// MC-Groups: MC-Groups "," MC-Group

		//

		public MC_Groups MC_Groups_2 (MC_Groups p_MC_Groups, SyntaxTreeToken p_token, MC_Group p_MC_Group)
		{
			MC_Groups p_MC_Groups_ref = new MC_Groups(p_MC_Groups, p_token, p_MC_Group);
			p_MC_Groups.parent = p_MC_Groups_ref;
			p_token.parent = p_MC_Groups_ref;
			p_MC_Group.parent = p_MC_Groups_ref;
			Raise_MC_Groups_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_Groups.production_kind.g_MC_Groups_2, p_MC_Groups_ref);
			return p_MC_Groups_ref;
		}
		#endregion
	};
}
