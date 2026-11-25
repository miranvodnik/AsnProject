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
	// class associated with syntax rule AC-Modules
	//

	[DataContract]
	public class	AC_Modules : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-Modules
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-Modules
		{
			g_AC_Modules_1 = 1,	// AC-Module

			g_AC_Modules_2 = 2,	// AC-Modules AC-Module

		};
		#endregion
		#region production markers associated with the syntax rule AC-Modules

		// markers associated with production: AC-Modules -> AC-Module

		public enum production_marker_1 : ushort
		{
			m_AC_Module,
			final
		};

		// markers associated with production: AC-Modules -> AC-Modules AC-Module

		public enum production_marker_2 : ushort
		{
			m_AC_Modules,
			m_AC_Module,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-Modules

		// Constructor declaration(s) associated with production(s) of syntax rule AC-Modules

		//
		// Constructor associated with the following production(s)
		// AC-Modules -> AC-Module

		//

		public AC_Modules (AC_Module p_AC_Module) : base ((uint) ProductionID._AC_Modules_ID, (uint) production_kind.g_AC_Modules_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_AC_Module = p_AC_Module;
		}

		//
		// Constructor associated with the following production(s)
		// AC-Modules -> AC-Modules AC-Module

		//

		public AC_Modules (AC_Modules p_AC_Modules, AC_Module p_AC_Module) : base ((uint) ProductionID._AC_Modules_ID, (uint) production_kind.g_AC_Modules_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_AC_Modules = p_AC_Modules;
			children[1] = m_AC_Module = p_AC_Module;
		}

		public AC_Modules () { }

		// Copy constructor

		public AC_Modules (AC_Modules p_AC_Modules) : base (p_AC_Modules.id, p_AC_Modules.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_Modules.appInfo;
			switch ((production_kind) p_AC_Modules.kind)
			{
				case production_kind.g_AC_Modules_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_AC_Module = (p_AC_Modules.m_AC_Module != null) ? new AC_Module (p_AC_Modules.m_AC_Module) : null) != null) m_AC_Module.parent = this;
					break;
				case production_kind.g_AC_Modules_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_AC_Modules = (p_AC_Modules.m_AC_Modules != null) ? new AC_Modules (p_AC_Modules.m_AC_Modules) : null) != null) m_AC_Modules.parent = this;
					if ((children [1] = m_AC_Module = (p_AC_Modules.m_AC_Module != null) ? new AC_Module (p_AC_Modules.m_AC_Module) : null) != null) m_AC_Module.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AC_Modules" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_Modules (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_AC_Module?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-Modules

		// Content changing function(s) associated with production(s) of syntax rule AC-Modules

		//
		// Content changing function associated with following production(s)
		// AC-Modules -> AC-Module

		//

		public void change(AC_Module p_AC_Module)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_Modules_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_AC_Module = p_AC_Module;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AC-Modules -> AC-Modules AC-Module

		//

		public void change(AC_Modules p_AC_Modules, AC_Module p_AC_Module)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_Modules_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_AC_Modules = p_AC_Modules;
			children [1] = m_AC_Module = p_AC_Module;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-Modules
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_AC_Module != null) && node.m_AC_Module.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-Modules

		//
		// emit production tree node associated with any production of syntax rule AC-Modules
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_AC_Modules_1:
						// emit syntax tree node associated with production
						// AC-Modules: AC-Module

						s += " " + node.m_AC_Module.Emit (depth - 1);
						break;
					case production_kind.g_AC_Modules_2:
						// emit syntax tree node associated with production
						// AC-Modules: AC-Modules AC-Module

						s += " " + node.m_AC_Module.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-Modules
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "AC_Modules (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_AC_Modules_1:
						// emit syntax tree node associated with production
						// AC-Modules: AC-Module

						str += node.m_AC_Module.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_AC_Modules_2:
						// emit syntax tree node associated with production
						// AC-Modules: AC-Modules AC-Module

						str += ' ';
						str += node.m_AC_Module.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-Modules

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Modules with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					AC_Modules.production_kind kind = (AC_Modules.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case AC_Modules.production_kind.g_AC_Modules_1:
							// traverse syntax tree node associated with production
							// AC-Modules: AC-Module

							node.m_AC_Module.Visit (visitor, appData);
							break;
						case AC_Modules.production_kind.g_AC_Modules_2:
							// traverse syntax tree node associated with production
							// AC-Modules: AC-Modules AC-Module

							node.m_AC_Module.Visit (visitor, appData);
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
			for (AC_Modules node = this; node != null; node = node.m_AC_Modules)
			{
				node.parent = parent;
				node.m_AC_Module?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule AC-Modules
		//

		public void _init ()
		{
			m_AC_Module = null;
			m_AC_Modules = null;
		}

		public delegate object IteratorDelegate (AC_Modules p_AC_Modules, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<AC_Modules> stack = new Stack<AC_Modules> ();
			AC_Modules p_AC_Modules;
			for (p_AC_Modules = this; p_AC_Modules != null; p_AC_Modules = p_AC_Modules.m_AC_Modules)
				stack.Push (p_AC_Modules);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-Modules

		// counter of all nodes associated with syntax rule AC-Modules
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-Modules
		[DataMember (Name = "m_AC_Module")] public AC_Module m_AC_Module { get; private set; }
		[DataMember (Name = "m_AC_Modules")] public AC_Modules m_AC_Modules { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-Modules

		// delegate function (callback) prototype associated with syntax rule AC-Modules
		public delegate bool AC_Modules_Callback (SyntaxTreeCallbackReason reason, AC_Modules.production_kind kind, AC_Modules p_AC_Modules);

		// event associated with syntax rule AC-Modules
		public event AC_Modules_Callback AC_Modules_Event;

		// event trigger associated with syntax rule AC-Modules
		public bool Raise_AC_Modules_Event (SyntaxTreeCallbackReason reason, AC_Modules.production_kind kind, AC_Modules p_AC_Modules)
		{
			bool? status = AC_Modules_Event?.Invoke (reason, kind, p_AC_Modules);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-Modules
		//
		// traverse syntax tree node associated with any production of syntax rule AC-Modules
		//

		public void Traverse (AC_Modules p_AC_Modules)
		{
			if (p_AC_Modules.isLocked())
				return;
			if (Raise_AC_Modules_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (AC_Modules.production_kind) p_AC_Modules.kind, p_AC_Modules))
				p_AC_Modules.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					AC_Modules.production_kind kind = (AC_Modules.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_AC_Modules_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case AC_Modules.production_kind.g_AC_Modules_1:
								// traverse syntax tree node associated with production
								// AC-Modules: AC-Module

								if (Raise_AC_Modules_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_AC_Module);
								node.turn_inc ();
								Raise_AC_Modules_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case AC_Modules.production_kind.g_AC_Modules_2:
								// traverse syntax tree node associated with production
								// AC-Modules: AC-Modules AC-Module

								if (Raise_AC_Modules_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_AC_Modules_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_AC_Module);
								node.turn_inc ();
								Raise_AC_Modules_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_AC_Modules_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_AC_Modules_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (AC_Modules.production_kind) p_AC_Modules.kind, p_AC_Modules);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Modules
		//

		public void TraverseCommon (AC_Modules p_AC_Modules)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_AC_Modules.kind, p_AC_Modules))
				p_AC_Modules.Iterate (null, (node, appData) =>
				{
					AC_Modules.production_kind kind = (AC_Modules.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case AC_Modules.production_kind.g_AC_Modules_1:
							// traverse syntax tree node associated with production
							// AC-Modules: AC-Module

							TraverseCommon (node.m_AC_Module);
							break;
						case AC_Modules.production_kind.g_AC_Modules_2:
							// traverse syntax tree node associated with production
							// AC-Modules: AC-Modules AC-Module

							TraverseCommon (node.m_AC_Module);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_AC_Modules.kind, p_AC_Modules);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-Modules

		//
		// create syntax tree node associated with production
		// AC-Modules: AC-Module

		//

		public AC_Modules AC_Modules_1 (AC_Module p_AC_Module)
		{
			AC_Modules p_AC_Modules_ref = new AC_Modules(p_AC_Module);
			p_AC_Module.parent = p_AC_Modules_ref;
			Raise_AC_Modules_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_Modules.production_kind.g_AC_Modules_1, p_AC_Modules_ref);
			return p_AC_Modules_ref;
		}

		//
		// create syntax tree node associated with production
		// AC-Modules: AC-Modules AC-Module

		//

		public AC_Modules AC_Modules_2 (AC_Modules p_AC_Modules, AC_Module p_AC_Module)
		{
			AC_Modules p_AC_Modules_ref = new AC_Modules(p_AC_Modules, p_AC_Module);
			p_AC_Modules.parent = p_AC_Modules_ref;
			p_AC_Module.parent = p_AC_Modules_ref;
			Raise_AC_Modules_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_Modules.production_kind.g_AC_Modules_2, p_AC_Modules_ref);
			return p_AC_Modules_ref;
		}
		#endregion
	};
}
