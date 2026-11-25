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
	// class associated with syntax rule MC-Modules
	//

	[DataContract]
	public class	MC_Modules : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MC-Modules
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MC-Modules
		{
			g_MC_Modules_1 = 1,	// MC-Module

			g_MC_Modules_2 = 2,	// MC-Modules MC-Module

		};
		#endregion
		#region production markers associated with the syntax rule MC-Modules

		// markers associated with production: MC-Modules -> MC-Module

		public enum production_marker_1 : ushort
		{
			m_MC_Module,
			final
		};

		// markers associated with production: MC-Modules -> MC-Modules MC-Module

		public enum production_marker_2 : ushort
		{
			m_MC_Modules,
			m_MC_Module,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MC-Modules

		// Constructor declaration(s) associated with production(s) of syntax rule MC-Modules

		//
		// Constructor associated with the following production(s)
		// MC-Modules -> MC-Module

		//

		public MC_Modules (MC_Module p_MC_Module) : base ((uint) ProductionID._MC_Modules_ID, (uint) production_kind.g_MC_Modules_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_MC_Module = p_MC_Module;
		}

		//
		// Constructor associated with the following production(s)
		// MC-Modules -> MC-Modules MC-Module

		//

		public MC_Modules (MC_Modules p_MC_Modules, MC_Module p_MC_Module) : base ((uint) ProductionID._MC_Modules_ID, (uint) production_kind.g_MC_Modules_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_MC_Modules = p_MC_Modules;
			children[1] = m_MC_Module = p_MC_Module;
		}

		public MC_Modules () { }

		// Copy constructor

		public MC_Modules (MC_Modules p_MC_Modules) : base (p_MC_Modules.id, p_MC_Modules.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MC_Modules.appInfo;
			switch ((production_kind) p_MC_Modules.kind)
			{
				case production_kind.g_MC_Modules_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MC_Module = (p_MC_Modules.m_MC_Module != null) ? new MC_Module (p_MC_Modules.m_MC_Module) : null) != null) m_MC_Module.parent = this;
					break;
				case production_kind.g_MC_Modules_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_MC_Modules = (p_MC_Modules.m_MC_Modules != null) ? new MC_Modules (p_MC_Modules.m_MC_Modules) : null) != null) m_MC_Modules.parent = this;
					if ((children [1] = m_MC_Module = (p_MC_Modules.m_MC_Module != null) ? new MC_Module (p_MC_Modules.m_MC_Module) : null) != null) m_MC_Module.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "MC_Modules" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MC_Modules (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_MC_Module?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MC-Modules

		// Content changing function(s) associated with production(s) of syntax rule MC-Modules

		//
		// Content changing function associated with following production(s)
		// MC-Modules -> MC-Module

		//

		public void change(MC_Module p_MC_Module)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_Modules_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_MC_Module = p_MC_Module;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MC-Modules -> MC-Modules MC-Module

		//

		public void change(MC_Modules p_MC_Modules, MC_Module p_MC_Module)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_Modules_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_MC_Modules = p_MC_Modules;
			children [1] = m_MC_Module = p_MC_Module;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MC-Modules
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_MC_Module != null) && node.m_MC_Module.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MC-Modules

		//
		// emit production tree node associated with any production of syntax rule MC-Modules
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_MC_Modules_1:
						// emit syntax tree node associated with production
						// MC-Modules: MC-Module

						s += " " + node.m_MC_Module.Emit (depth - 1);
						break;
					case production_kind.g_MC_Modules_2:
						// emit syntax tree node associated with production
						// MC-Modules: MC-Modules MC-Module

						s += " " + node.m_MC_Module.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MC-Modules
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "MC_Modules (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_MC_Modules_1:
						// emit syntax tree node associated with production
						// MC-Modules: MC-Module

						str += node.m_MC_Module.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_MC_Modules_2:
						// emit syntax tree node associated with production
						// MC-Modules: MC-Modules MC-Module

						str += ' ';
						str += node.m_MC_Module.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MC-Modules

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MC-Modules with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					MC_Modules.production_kind kind = (MC_Modules.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case MC_Modules.production_kind.g_MC_Modules_1:
							// traverse syntax tree node associated with production
							// MC-Modules: MC-Module

							node.m_MC_Module.Visit (visitor, appData);
							break;
						case MC_Modules.production_kind.g_MC_Modules_2:
							// traverse syntax tree node associated with production
							// MC-Modules: MC-Modules MC-Module

							node.m_MC_Module.Visit (visitor, appData);
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
			for (MC_Modules node = this; node != null; node = node.m_MC_Modules)
			{
				node.parent = parent;
				node.m_MC_Module?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule MC-Modules
		//

		public void _init ()
		{
			m_MC_Module = null;
			m_MC_Modules = null;
		}

		public delegate object IteratorDelegate (MC_Modules p_MC_Modules, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<MC_Modules> stack = new Stack<MC_Modules> ();
			MC_Modules p_MC_Modules;
			for (p_MC_Modules = this; p_MC_Modules != null; p_MC_Modules = p_MC_Modules.m_MC_Modules)
				stack.Push (p_MC_Modules);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MC-Modules

		// counter of all nodes associated with syntax rule MC-Modules
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MC-Modules
		[DataMember (Name = "m_MC_Module")] public MC_Module m_MC_Module { get; private set; }
		[DataMember (Name = "m_MC_Modules")] public MC_Modules m_MC_Modules { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MC-Modules

		// delegate function (callback) prototype associated with syntax rule MC-Modules
		public delegate bool MC_Modules_Callback (SyntaxTreeCallbackReason reason, MC_Modules.production_kind kind, MC_Modules p_MC_Modules);

		// event associated with syntax rule MC-Modules
		public event MC_Modules_Callback MC_Modules_Event;

		// event trigger associated with syntax rule MC-Modules
		public bool Raise_MC_Modules_Event (SyntaxTreeCallbackReason reason, MC_Modules.production_kind kind, MC_Modules p_MC_Modules)
		{
			bool? status = MC_Modules_Event?.Invoke (reason, kind, p_MC_Modules);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MC-Modules
		//
		// traverse syntax tree node associated with any production of syntax rule MC-Modules
		//

		public void Traverse (MC_Modules p_MC_Modules)
		{
			if (p_MC_Modules.isLocked())
				return;
			if (Raise_MC_Modules_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (MC_Modules.production_kind) p_MC_Modules.kind, p_MC_Modules))
				p_MC_Modules.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					MC_Modules.production_kind kind = (MC_Modules.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_MC_Modules_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case MC_Modules.production_kind.g_MC_Modules_1:
								// traverse syntax tree node associated with production
								// MC-Modules: MC-Module

								if (Raise_MC_Modules_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_MC_Module);
								node.turn_inc ();
								Raise_MC_Modules_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case MC_Modules.production_kind.g_MC_Modules_2:
								// traverse syntax tree node associated with production
								// MC-Modules: MC-Modules MC-Module

								if (Raise_MC_Modules_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_MC_Modules_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_MC_Module);
								node.turn_inc ();
								Raise_MC_Modules_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_MC_Modules_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_MC_Modules_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (MC_Modules.production_kind) p_MC_Modules.kind, p_MC_Modules);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MC-Modules
		//

		public void TraverseCommon (MC_Modules p_MC_Modules)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_MC_Modules.kind, p_MC_Modules))
				p_MC_Modules.Iterate (null, (node, appData) =>
				{
					MC_Modules.production_kind kind = (MC_Modules.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case MC_Modules.production_kind.g_MC_Modules_1:
							// traverse syntax tree node associated with production
							// MC-Modules: MC-Module

							TraverseCommon (node.m_MC_Module);
							break;
						case MC_Modules.production_kind.g_MC_Modules_2:
							// traverse syntax tree node associated with production
							// MC-Modules: MC-Modules MC-Module

							TraverseCommon (node.m_MC_Module);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_MC_Modules.kind, p_MC_Modules);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MC-Modules

		//
		// create syntax tree node associated with production
		// MC-Modules: MC-Module

		//

		public MC_Modules MC_Modules_1 (MC_Module p_MC_Module)
		{
			MC_Modules p_MC_Modules_ref = new MC_Modules(p_MC_Module);
			p_MC_Module.parent = p_MC_Modules_ref;
			Raise_MC_Modules_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_Modules.production_kind.g_MC_Modules_1, p_MC_Modules_ref);
			return p_MC_Modules_ref;
		}

		//
		// create syntax tree node associated with production
		// MC-Modules: MC-Modules MC-Module

		//

		public MC_Modules MC_Modules_2 (MC_Modules p_MC_Modules, MC_Module p_MC_Module)
		{
			MC_Modules p_MC_Modules_ref = new MC_Modules(p_MC_Modules, p_MC_Module);
			p_MC_Modules.parent = p_MC_Modules_ref;
			p_MC_Module.parent = p_MC_Modules_ref;
			Raise_MC_Modules_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_Modules.production_kind.g_MC_Modules_2, p_MC_Modules_ref);
			return p_MC_Modules_ref;
		}
		#endregion
	};
}
