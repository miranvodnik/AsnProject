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
	// class associated with syntax rule MC-Compliances
	//

	[DataContract]
	public class	MC_Compliances : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MC-Compliances
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MC-Compliances
		{
			g_MC_Compliances_1 = 1,	// MC-Compliance

			g_MC_Compliances_2 = 2,	// MC-Compliances MC-Compliance

		};
		#endregion
		#region production markers associated with the syntax rule MC-Compliances

		// markers associated with production: MC-Compliances -> MC-Compliance

		public enum production_marker_1 : ushort
		{
			m_MC_Compliance,
			final
		};

		// markers associated with production: MC-Compliances -> MC-Compliances MC-Compliance

		public enum production_marker_2 : ushort
		{
			m_MC_Compliances,
			m_MC_Compliance,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MC-Compliances

		// Constructor declaration(s) associated with production(s) of syntax rule MC-Compliances

		//
		// Constructor associated with the following production(s)
		// MC-Compliances -> MC-Compliance

		//

		public MC_Compliances (MC_Compliance p_MC_Compliance) : base ((uint) ProductionID._MC_Compliances_ID, (uint) production_kind.g_MC_Compliances_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_MC_Compliance = p_MC_Compliance;
		}

		//
		// Constructor associated with the following production(s)
		// MC-Compliances -> MC-Compliances MC-Compliance

		//

		public MC_Compliances (MC_Compliances p_MC_Compliances, MC_Compliance p_MC_Compliance) : base ((uint) ProductionID._MC_Compliances_ID, (uint) production_kind.g_MC_Compliances_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_MC_Compliances = p_MC_Compliances;
			children[1] = m_MC_Compliance = p_MC_Compliance;
		}

		public MC_Compliances () { }

		// Copy constructor

		public MC_Compliances (MC_Compliances p_MC_Compliances) : base (p_MC_Compliances.id, p_MC_Compliances.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MC_Compliances.appInfo;
			switch ((production_kind) p_MC_Compliances.kind)
			{
				case production_kind.g_MC_Compliances_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MC_Compliance = (p_MC_Compliances.m_MC_Compliance != null) ? new MC_Compliance (p_MC_Compliances.m_MC_Compliance) : null) != null) m_MC_Compliance.parent = this;
					break;
				case production_kind.g_MC_Compliances_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_MC_Compliances = (p_MC_Compliances.m_MC_Compliances != null) ? new MC_Compliances (p_MC_Compliances.m_MC_Compliances) : null) != null) m_MC_Compliances.parent = this;
					if ((children [1] = m_MC_Compliance = (p_MC_Compliances.m_MC_Compliance != null) ? new MC_Compliance (p_MC_Compliances.m_MC_Compliance) : null) != null) m_MC_Compliance.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "MC_Compliances" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MC_Compliances (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_MC_Compliance?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MC-Compliances

		// Content changing function(s) associated with production(s) of syntax rule MC-Compliances

		//
		// Content changing function associated with following production(s)
		// MC-Compliances -> MC-Compliance

		//

		public void change(MC_Compliance p_MC_Compliance)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_Compliances_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_MC_Compliance = p_MC_Compliance;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MC-Compliances -> MC-Compliances MC-Compliance

		//

		public void change(MC_Compliances p_MC_Compliances, MC_Compliance p_MC_Compliance)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_Compliances_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_MC_Compliances = p_MC_Compliances;
			children [1] = m_MC_Compliance = p_MC_Compliance;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MC-Compliances
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_MC_Compliance != null) && node.m_MC_Compliance.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MC-Compliances

		//
		// emit production tree node associated with any production of syntax rule MC-Compliances
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_MC_Compliances_1:
						// emit syntax tree node associated with production
						// MC-Compliances: MC-Compliance

						s += " " + node.m_MC_Compliance.Emit (depth - 1);
						break;
					case production_kind.g_MC_Compliances_2:
						// emit syntax tree node associated with production
						// MC-Compliances: MC-Compliances MC-Compliance

						s += " " + node.m_MC_Compliance.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MC-Compliances
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "MC_Compliances (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_MC_Compliances_1:
						// emit syntax tree node associated with production
						// MC-Compliances: MC-Compliance

						str += node.m_MC_Compliance.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_MC_Compliances_2:
						// emit syntax tree node associated with production
						// MC-Compliances: MC-Compliances MC-Compliance

						str += ' ';
						str += node.m_MC_Compliance.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MC-Compliances

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MC-Compliances with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					MC_Compliances.production_kind kind = (MC_Compliances.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case MC_Compliances.production_kind.g_MC_Compliances_1:
							// traverse syntax tree node associated with production
							// MC-Compliances: MC-Compliance

							node.m_MC_Compliance.Visit (visitor, appData);
							break;
						case MC_Compliances.production_kind.g_MC_Compliances_2:
							// traverse syntax tree node associated with production
							// MC-Compliances: MC-Compliances MC-Compliance

							node.m_MC_Compliance.Visit (visitor, appData);
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
			for (MC_Compliances node = this; node != null; node = node.m_MC_Compliances)
			{
				node.parent = parent;
				node.m_MC_Compliance?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule MC-Compliances
		//

		public void _init ()
		{
			m_MC_Compliance = null;
			m_MC_Compliances = null;
		}

		public delegate object IteratorDelegate (MC_Compliances p_MC_Compliances, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<MC_Compliances> stack = new Stack<MC_Compliances> ();
			MC_Compliances p_MC_Compliances;
			for (p_MC_Compliances = this; p_MC_Compliances != null; p_MC_Compliances = p_MC_Compliances.m_MC_Compliances)
				stack.Push (p_MC_Compliances);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MC-Compliances

		// counter of all nodes associated with syntax rule MC-Compliances
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MC-Compliances
		[DataMember (Name = "m_MC_Compliance")] public MC_Compliance m_MC_Compliance { get; private set; }
		[DataMember (Name = "m_MC_Compliances")] public MC_Compliances m_MC_Compliances { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MC-Compliances

		// delegate function (callback) prototype associated with syntax rule MC-Compliances
		public delegate bool MC_Compliances_Callback (SyntaxTreeCallbackReason reason, MC_Compliances.production_kind kind, MC_Compliances p_MC_Compliances);

		// event associated with syntax rule MC-Compliances
		public event MC_Compliances_Callback MC_Compliances_Event;

		// event trigger associated with syntax rule MC-Compliances
		public bool Raise_MC_Compliances_Event (SyntaxTreeCallbackReason reason, MC_Compliances.production_kind kind, MC_Compliances p_MC_Compliances)
		{
			bool? status = MC_Compliances_Event?.Invoke (reason, kind, p_MC_Compliances);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MC-Compliances
		//
		// traverse syntax tree node associated with any production of syntax rule MC-Compliances
		//

		public void Traverse (MC_Compliances p_MC_Compliances)
		{
			if (p_MC_Compliances.isLocked())
				return;
			if (Raise_MC_Compliances_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (MC_Compliances.production_kind) p_MC_Compliances.kind, p_MC_Compliances))
				p_MC_Compliances.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					MC_Compliances.production_kind kind = (MC_Compliances.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_MC_Compliances_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case MC_Compliances.production_kind.g_MC_Compliances_1:
								// traverse syntax tree node associated with production
								// MC-Compliances: MC-Compliance

								if (Raise_MC_Compliances_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_MC_Compliance);
								node.turn_inc ();
								Raise_MC_Compliances_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case MC_Compliances.production_kind.g_MC_Compliances_2:
								// traverse syntax tree node associated with production
								// MC-Compliances: MC-Compliances MC-Compliance

								if (Raise_MC_Compliances_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_MC_Compliances_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_MC_Compliance);
								node.turn_inc ();
								Raise_MC_Compliances_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_MC_Compliances_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_MC_Compliances_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (MC_Compliances.production_kind) p_MC_Compliances.kind, p_MC_Compliances);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MC-Compliances
		//

		public void TraverseCommon (MC_Compliances p_MC_Compliances)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_MC_Compliances.kind, p_MC_Compliances))
				p_MC_Compliances.Iterate (null, (node, appData) =>
				{
					MC_Compliances.production_kind kind = (MC_Compliances.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case MC_Compliances.production_kind.g_MC_Compliances_1:
							// traverse syntax tree node associated with production
							// MC-Compliances: MC-Compliance

							TraverseCommon (node.m_MC_Compliance);
							break;
						case MC_Compliances.production_kind.g_MC_Compliances_2:
							// traverse syntax tree node associated with production
							// MC-Compliances: MC-Compliances MC-Compliance

							TraverseCommon (node.m_MC_Compliance);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_MC_Compliances.kind, p_MC_Compliances);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MC-Compliances

		//
		// create syntax tree node associated with production
		// MC-Compliances: MC-Compliance

		//

		public MC_Compliances MC_Compliances_1 (MC_Compliance p_MC_Compliance)
		{
			MC_Compliances p_MC_Compliances_ref = new MC_Compliances(p_MC_Compliance);
			p_MC_Compliance.parent = p_MC_Compliances_ref;
			Raise_MC_Compliances_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_Compliances.production_kind.g_MC_Compliances_1, p_MC_Compliances_ref);
			return p_MC_Compliances_ref;
		}

		//
		// create syntax tree node associated with production
		// MC-Compliances: MC-Compliances MC-Compliance

		//

		public MC_Compliances MC_Compliances_2 (MC_Compliances p_MC_Compliances, MC_Compliance p_MC_Compliance)
		{
			MC_Compliances p_MC_Compliances_ref = new MC_Compliances(p_MC_Compliances, p_MC_Compliance);
			p_MC_Compliances.parent = p_MC_Compliances_ref;
			p_MC_Compliance.parent = p_MC_Compliances_ref;
			Raise_MC_Compliances_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_Compliances.production_kind.g_MC_Compliances_2, p_MC_Compliances_ref);
			return p_MC_Compliances_ref;
		}
		#endregion
	};
}
