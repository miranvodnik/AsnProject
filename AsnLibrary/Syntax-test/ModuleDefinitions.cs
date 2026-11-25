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
	// class associated with syntax rule ModuleDefinitions
	//

	[DataContract]
	public class	ModuleDefinitions : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ModuleDefinitions
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ModuleDefinitions
		{
			g_ModuleDefinitions_1 = 1,	// ModuleDefinition

			g_ModuleDefinitions_2 = 2,	// ModuleDefinitions ModuleDefinition

		};
		#endregion
		#region production markers associated with the syntax rule ModuleDefinitions

		// markers associated with production: ModuleDefinitions -> ModuleDefinition

		public enum production_marker_1 : ushort
		{
			m_ModuleDefinition,
			final
		};

		// markers associated with production: ModuleDefinitions -> ModuleDefinitions ModuleDefinition

		public enum production_marker_2 : ushort
		{
			m_ModuleDefinitions,
			m_ModuleDefinition,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ModuleDefinitions

		// Constructor declaration(s) associated with production(s) of syntax rule ModuleDefinitions

		//
		// Constructor associated with the following production(s)
		// ModuleDefinitions -> ModuleDefinition

		//

		public ModuleDefinitions (ModuleDefinition p_ModuleDefinition) : base ((uint) ProductionID._ModuleDefinitions_ID, (uint) production_kind.g_ModuleDefinitions_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ModuleDefinition = p_ModuleDefinition;
		}

		//
		// Constructor associated with the following production(s)
		// ModuleDefinitions -> ModuleDefinitions ModuleDefinition

		//

		public ModuleDefinitions (ModuleDefinitions p_ModuleDefinitions, ModuleDefinition p_ModuleDefinition) : base ((uint) ProductionID._ModuleDefinitions_ID, (uint) production_kind.g_ModuleDefinitions_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ModuleDefinitions = p_ModuleDefinitions;
			children[1] = m_ModuleDefinition = p_ModuleDefinition;
		}

		public ModuleDefinitions () { }

		// Copy constructor

		public ModuleDefinitions (ModuleDefinitions p_ModuleDefinitions) : base (p_ModuleDefinitions.id, p_ModuleDefinitions.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ModuleDefinitions.appInfo;
			switch ((production_kind) p_ModuleDefinitions.kind)
			{
				case production_kind.g_ModuleDefinitions_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ModuleDefinition = (p_ModuleDefinitions.m_ModuleDefinition != null) ? new ModuleDefinition (p_ModuleDefinitions.m_ModuleDefinition) : null) != null) m_ModuleDefinition.parent = this;
					break;
				case production_kind.g_ModuleDefinitions_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ModuleDefinitions = (p_ModuleDefinitions.m_ModuleDefinitions != null) ? new ModuleDefinitions (p_ModuleDefinitions.m_ModuleDefinitions) : null) != null) m_ModuleDefinitions.parent = this;
					if ((children [1] = m_ModuleDefinition = (p_ModuleDefinitions.m_ModuleDefinition != null) ? new ModuleDefinition (p_ModuleDefinitions.m_ModuleDefinition) : null) != null) m_ModuleDefinition.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ModuleDefinitions" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ModuleDefinitions (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_ModuleDefinition?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ModuleDefinitions

		// Content changing function(s) associated with production(s) of syntax rule ModuleDefinitions

		//
		// Content changing function associated with following production(s)
		// ModuleDefinitions -> ModuleDefinition

		//

		public void change(ModuleDefinition p_ModuleDefinition)
		{
			_init ();
			this.kind = (uint) production_kind.g_ModuleDefinitions_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ModuleDefinition = p_ModuleDefinition;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ModuleDefinitions -> ModuleDefinitions ModuleDefinition

		//

		public void change(ModuleDefinitions p_ModuleDefinitions, ModuleDefinition p_ModuleDefinition)
		{
			_init ();
			this.kind = (uint) production_kind.g_ModuleDefinitions_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ModuleDefinitions = p_ModuleDefinitions;
			children [1] = m_ModuleDefinition = p_ModuleDefinition;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ModuleDefinitions
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_ModuleDefinition != null) && node.m_ModuleDefinition.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ModuleDefinitions

		//
		// emit production tree node associated with any production of syntax rule ModuleDefinitions
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_ModuleDefinitions_1:
						// emit syntax tree node associated with production
						// ModuleDefinitions: ModuleDefinition

						s += " " + node.m_ModuleDefinition.Emit (depth - 1);
						break;
					case production_kind.g_ModuleDefinitions_2:
						// emit syntax tree node associated with production
						// ModuleDefinitions: ModuleDefinitions ModuleDefinition

						s += " " + node.m_ModuleDefinition.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ModuleDefinitions
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "ModuleDefinitions (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_ModuleDefinitions_1:
						// emit syntax tree node associated with production
						// ModuleDefinitions: ModuleDefinition

						str += node.m_ModuleDefinition.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_ModuleDefinitions_2:
						// emit syntax tree node associated with production
						// ModuleDefinitions: ModuleDefinitions ModuleDefinition

						str += ' ';
						str += node.m_ModuleDefinition.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ModuleDefinitions

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ModuleDefinitions with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					ModuleDefinitions.production_kind kind = (ModuleDefinitions.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case ModuleDefinitions.production_kind.g_ModuleDefinitions_1:
							// traverse syntax tree node associated with production
							// ModuleDefinitions: ModuleDefinition

							node.m_ModuleDefinition.Visit (visitor, appData);
							break;
						case ModuleDefinitions.production_kind.g_ModuleDefinitions_2:
							// traverse syntax tree node associated with production
							// ModuleDefinitions: ModuleDefinitions ModuleDefinition

							node.m_ModuleDefinition.Visit (visitor, appData);
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
			for (ModuleDefinitions node = this; node != null; node = node.m_ModuleDefinitions)
			{
				node.parent = parent;
				node.m_ModuleDefinition?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule ModuleDefinitions
		//

		public void _init ()
		{
			m_ModuleDefinition = null;
			m_ModuleDefinitions = null;
		}

		public delegate object IteratorDelegate (ModuleDefinitions p_ModuleDefinitions, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<ModuleDefinitions> stack = new Stack<ModuleDefinitions> ();
			ModuleDefinitions p_ModuleDefinitions;
			for (p_ModuleDefinitions = this; p_ModuleDefinitions != null; p_ModuleDefinitions = p_ModuleDefinitions.m_ModuleDefinitions)
				stack.Push (p_ModuleDefinitions);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ModuleDefinitions

		// counter of all nodes associated with syntax rule ModuleDefinitions
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ModuleDefinitions
		[DataMember (Name = "m_ModuleDefinition")] public ModuleDefinition m_ModuleDefinition { get; private set; }
		[DataMember (Name = "m_ModuleDefinitions")] public ModuleDefinitions m_ModuleDefinitions { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ModuleDefinitions

		// delegate function (callback) prototype associated with syntax rule ModuleDefinitions
		public delegate bool ModuleDefinitions_Callback (SyntaxTreeCallbackReason reason, ModuleDefinitions.production_kind kind, ModuleDefinitions p_ModuleDefinitions);

		// event associated with syntax rule ModuleDefinitions
		public event ModuleDefinitions_Callback ModuleDefinitions_Event;

		// event trigger associated with syntax rule ModuleDefinitions
		public bool Raise_ModuleDefinitions_Event (SyntaxTreeCallbackReason reason, ModuleDefinitions.production_kind kind, ModuleDefinitions p_ModuleDefinitions)
		{
			bool? status = ModuleDefinitions_Event?.Invoke (reason, kind, p_ModuleDefinitions);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ModuleDefinitions
		//
		// traverse syntax tree node associated with any production of syntax rule ModuleDefinitions
		//

		public void Traverse (ModuleDefinitions p_ModuleDefinitions)
		{
			if (p_ModuleDefinitions.isLocked())
				return;
			if (Raise_ModuleDefinitions_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (ModuleDefinitions.production_kind) p_ModuleDefinitions.kind, p_ModuleDefinitions))
				p_ModuleDefinitions.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					ModuleDefinitions.production_kind kind = (ModuleDefinitions.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_ModuleDefinitions_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case ModuleDefinitions.production_kind.g_ModuleDefinitions_1:
								// traverse syntax tree node associated with production
								// ModuleDefinitions: ModuleDefinition

								if (Raise_ModuleDefinitions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_ModuleDefinition);
								node.turn_inc ();
								Raise_ModuleDefinitions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case ModuleDefinitions.production_kind.g_ModuleDefinitions_2:
								// traverse syntax tree node associated with production
								// ModuleDefinitions: ModuleDefinitions ModuleDefinition

								if (Raise_ModuleDefinitions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_ModuleDefinitions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_ModuleDefinition);
								node.turn_inc ();
								Raise_ModuleDefinitions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_ModuleDefinitions_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_ModuleDefinitions_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (ModuleDefinitions.production_kind) p_ModuleDefinitions.kind, p_ModuleDefinitions);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ModuleDefinitions
		//

		public void TraverseCommon (ModuleDefinitions p_ModuleDefinitions)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_ModuleDefinitions.kind, p_ModuleDefinitions))
				p_ModuleDefinitions.Iterate (null, (node, appData) =>
				{
					ModuleDefinitions.production_kind kind = (ModuleDefinitions.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case ModuleDefinitions.production_kind.g_ModuleDefinitions_1:
							// traverse syntax tree node associated with production
							// ModuleDefinitions: ModuleDefinition

							TraverseCommon (node.m_ModuleDefinition);
							break;
						case ModuleDefinitions.production_kind.g_ModuleDefinitions_2:
							// traverse syntax tree node associated with production
							// ModuleDefinitions: ModuleDefinitions ModuleDefinition

							TraverseCommon (node.m_ModuleDefinition);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_ModuleDefinitions.kind, p_ModuleDefinitions);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ModuleDefinitions

		//
		// create syntax tree node associated with production
		// ModuleDefinitions: ModuleDefinition

		//

		public ModuleDefinitions ModuleDefinitions_1 (ModuleDefinition p_ModuleDefinition)
		{
			ModuleDefinitions p_ModuleDefinitions_ref = new ModuleDefinitions(p_ModuleDefinition);
			p_ModuleDefinition.parent = p_ModuleDefinitions_ref;
			Raise_ModuleDefinitions_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ModuleDefinitions.production_kind.g_ModuleDefinitions_1, p_ModuleDefinitions_ref);
			return p_ModuleDefinitions_ref;
		}

		//
		// create syntax tree node associated with production
		// ModuleDefinitions: ModuleDefinitions ModuleDefinition

		//

		public ModuleDefinitions ModuleDefinitions_2 (ModuleDefinitions p_ModuleDefinitions, ModuleDefinition p_ModuleDefinition)
		{
			ModuleDefinitions p_ModuleDefinitions_ref = new ModuleDefinitions(p_ModuleDefinitions, p_ModuleDefinition);
			p_ModuleDefinitions.parent = p_ModuleDefinitions_ref;
			p_ModuleDefinition.parent = p_ModuleDefinitions_ref;
			Raise_ModuleDefinitions_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ModuleDefinitions.production_kind.g_ModuleDefinitions_2, p_ModuleDefinitions_ref);
			return p_ModuleDefinitions_ref;
		}
		#endregion
	};
}
