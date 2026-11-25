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
	// class associated with syntax rule Level
	//

	[DataContract]
	public class	Level : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Level
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Level
		{
			g_Level_1 = 1,	// "."

			g_Level_2 = 2,	// Level "."

		};
		#endregion
		#region production markers associated with the syntax rule Level

		// markers associated with production: Level -> "."

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: Level -> Level "."

		public enum production_marker_2 : ushort
		{
			m_Level,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Level

		// Constructor declaration(s) associated with production(s) of syntax rule Level

		//
		// Constructor associated with the following production(s)
		// Level -> "."

		//

		public Level (SyntaxTreeToken p_token) : base ((uint) ProductionID._Level_ID, (uint) production_kind.g_Level_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_dot = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// Level -> Level "."

		//

		public Level (Level p_Level, SyntaxTreeToken p_token) : base ((uint) ProductionID._Level_ID, (uint) production_kind.g_Level_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_Level = p_Level;
			children[1] = m_dot = p_token;
		}

		public Level () { }

		// Copy constructor

		public Level (Level p_Level) : base (p_Level.id, p_Level.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Level.appInfo;
			switch ((production_kind) p_Level.kind)
			{
				case production_kind.g_Level_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_dot = (p_Level.m_dot != null) ? new SyntaxTreeToken (p_Level.m_dot) : null) != null) m_dot.parent = this;
					break;
				case production_kind.g_Level_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_Level = (p_Level.m_Level != null) ? new Level (p_Level.m_Level) : null) != null) m_Level.parent = this;
					if ((children [1] = m_dot = (p_Level.m_dot != null) ? new SyntaxTreeToken (p_Level.m_dot) : null) != null) m_dot.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Level" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Level (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_dot?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Level

		// Content changing function(s) associated with production(s) of syntax rule Level

		//
		// Content changing function associated with following production(s)
		// Level -> "."

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_Level_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_dot = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Level -> Level "."

		//

		public void change(Level p_Level, SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_Level_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_Level = p_Level;
			children [1] = m_dot = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Level
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_dot != null) && node.m_dot.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Level

		//
		// emit production tree node associated with any production of syntax rule Level
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_Level_1:
						// emit syntax tree node associated with production
						// Level: "."

						s += " " + node.m_dot.Emit (depth - 1);
						break;
					case production_kind.g_Level_2:
						// emit syntax tree node associated with production
						// Level: Level "."

						s += " " + node.m_dot.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Level
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "Level (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_Level_1:
						// emit syntax tree node associated with production
						// Level: "."

						str += "dot";
						break;
					case production_kind.g_Level_2:
						// emit syntax tree node associated with production
						// Level: Level "."

						str += ' ';
						str += "dot";
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Level

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Level with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					Level.production_kind kind = (Level.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case Level.production_kind.g_Level_1:
							// traverse syntax tree node associated with production
							// Level: "."

							node.m_dot.Visit (visitor, appData);
							break;
						case Level.production_kind.g_Level_2:
							// traverse syntax tree node associated with production
							// Level: Level "."

							node.m_dot.Visit (visitor, appData);
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
			for (Level node = this; node != null; node = node.m_Level)
			{
				node.parent = parent;
				node.m_dot?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule Level
		//

		public void _init ()
		{
			m_dot = null;
			m_Level = null;
		}

		public delegate object IteratorDelegate (Level p_Level, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<Level> stack = new Stack<Level> ();
			Level p_Level;
			for (p_Level = this; p_Level != null; p_Level = p_Level.m_Level)
				stack.Push (p_Level);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Level

		// counter of all nodes associated with syntax rule Level
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Level
		[DataMember (Name = "m_dot")] public SyntaxTreeToken m_dot { get; private set; }
		[DataMember (Name = "m_Level")] public Level m_Level { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Level

		// delegate function (callback) prototype associated with syntax rule Level
		public delegate bool Level_Callback (SyntaxTreeCallbackReason reason, Level.production_kind kind, Level p_Level);

		// event associated with syntax rule Level
		public event Level_Callback Level_Event;

		// event trigger associated with syntax rule Level
		public bool Raise_Level_Event (SyntaxTreeCallbackReason reason, Level.production_kind kind, Level p_Level)
		{
			bool? status = Level_Event?.Invoke (reason, kind, p_Level);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Level
		//
		// traverse syntax tree node associated with any production of syntax rule Level
		//

		public void Traverse (Level p_Level)
		{
			if (p_Level.isLocked())
				return;
			if (Raise_Level_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (Level.production_kind) p_Level.kind, p_Level))
				p_Level.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					Level.production_kind kind = (Level.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_Level_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case Level.production_kind.g_Level_1:
								// traverse syntax tree node associated with production
								// Level: "."

							break;
							case Level.production_kind.g_Level_2:
								// traverse syntax tree node associated with production
								// Level: Level "."

								if (Raise_Level_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								Raise_Level_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_Level_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_Level_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (Level.production_kind) p_Level.kind, p_Level);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Level
		//

		public void TraverseCommon (Level p_Level)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_Level.kind, p_Level))
				p_Level.Iterate (null, (node, appData) =>
				{
					Level.production_kind kind = (Level.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case Level.production_kind.g_Level_1:
							// traverse syntax tree node associated with production
							// Level: "."

							TraverseCommon (node.m_dot);
							break;
						case Level.production_kind.g_Level_2:
							// traverse syntax tree node associated with production
							// Level: Level "."

							TraverseCommon (node.m_dot);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_Level.kind, p_Level);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Level

		//
		// create syntax tree node associated with production
		// Level: "."

		//

		public Level Level_1 (SyntaxTreeToken p_token)
		{
			Level p_Level_ref = new Level(p_token);
			p_token.parent = p_Level_ref;
			Raise_Level_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Level.production_kind.g_Level_1, p_Level_ref);
			return p_Level_ref;
		}

		//
		// create syntax tree node associated with production
		// Level: Level "."

		//

		public Level Level_2 (Level p_Level, SyntaxTreeToken p_token)
		{
			Level p_Level_ref = new Level(p_Level, p_token);
			p_Level.parent = p_Level_ref;
			p_token.parent = p_Level_ref;
			Raise_Level_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Level.production_kind.g_Level_2, p_Level_ref);
			return p_Level_ref;
		}
		#endregion
	};
}
