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
	// class associated with syntax rule Parameter-set
	//

	[DataContract]
	public class	Parameter_set : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Parameter-set
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Parameter-set
		{
			g_Parameter_set_1 = 1,	// Parameter

			g_Parameter_set_2 = 2,	// Parameter-set "," Parameter Left

		};
		#endregion
		#region production markers associated with the syntax rule Parameter-set

		// markers associated with production: Parameter-set -> Parameter

		public enum production_marker_1 : ushort
		{
			m_Parameter,
			final
		};

		// markers associated with production: Parameter-set -> Parameter-set "," Parameter Left

		public enum production_marker_2 : ushort
		{
			m_Parameter_set,
			m_Parameter,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Parameter-set

		// Constructor declaration(s) associated with production(s) of syntax rule Parameter-set

		//
		// Constructor associated with the following production(s)
		// Parameter-set -> Parameter

		//

		public Parameter_set (Parameter p_Parameter) : base ((uint) ProductionID._Parameter_set_ID, (uint) production_kind.g_Parameter_set_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Parameter = p_Parameter;
		}

		//
		// Constructor associated with the following production(s)
		// Parameter-set -> Parameter-set "," Parameter Left

		//

		public Parameter_set (Parameter_set p_Parameter_set, SyntaxTreeToken p_token, Parameter p_Parameter) : base ((uint) ProductionID._Parameter_set_ID, (uint) production_kind.g_Parameter_set_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_Parameter_set = p_Parameter_set;
			children[1] = m_comma = p_token;
			children[2] = m_Parameter = p_Parameter;
		}

		public Parameter_set () { }

		// Copy constructor

		public Parameter_set (Parameter_set p_Parameter_set) : base (p_Parameter_set.id, p_Parameter_set.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Parameter_set.appInfo;
			switch ((production_kind) p_Parameter_set.kind)
			{
				case production_kind.g_Parameter_set_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Parameter = (p_Parameter_set.m_Parameter != null) ? new Parameter (p_Parameter_set.m_Parameter) : null) != null) m_Parameter.parent = this;
					break;
				case production_kind.g_Parameter_set_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_Parameter_set = (p_Parameter_set.m_Parameter_set != null) ? new Parameter_set (p_Parameter_set.m_Parameter_set) : null) != null) m_Parameter_set.parent = this;
					if ((children [1] = m_comma = (p_Parameter_set.m_comma != null) ? new SyntaxTreeToken (p_Parameter_set.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_Parameter = (p_Parameter_set.m_Parameter != null) ? new Parameter (p_Parameter_set.m_Parameter) : null) != null) m_Parameter.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Parameter_set" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Parameter_set (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_Parameter?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Parameter-set

		// Content changing function(s) associated with production(s) of syntax rule Parameter-set

		//
		// Content changing function associated with following production(s)
		// Parameter-set -> Parameter

		//

		public void change(Parameter p_Parameter)
		{
			_init ();
			this.kind = (uint) production_kind.g_Parameter_set_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Parameter = p_Parameter;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Parameter-set -> Parameter-set "," Parameter Left

		//

		public void change(Parameter_set p_Parameter_set, SyntaxTreeToken p_token, Parameter p_Parameter)
		{
			_init ();
			this.kind = (uint) production_kind.g_Parameter_set_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_Parameter_set = p_Parameter_set;
			children [1] = m_comma = p_token;
			children [2] = m_Parameter = p_Parameter;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Parameter-set
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_Parameter != null) && node.m_Parameter.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Parameter-set

		//
		// emit production tree node associated with any production of syntax rule Parameter-set
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_Parameter_set_1:
						// emit syntax tree node associated with production
						// Parameter-set: Parameter

						s += " " + node.m_Parameter.Emit (depth - 1);
						break;
					case production_kind.g_Parameter_set_2:
						// emit syntax tree node associated with production
						// Parameter-set: Parameter-set "," Parameter Left

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_Parameter.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Parameter-set
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "Parameter_set (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_Parameter_set_1:
						// emit syntax tree node associated with production
						// Parameter-set: Parameter

						str += node.m_Parameter.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_Parameter_set_2:
						// emit syntax tree node associated with production
						// Parameter-set: Parameter-set "," Parameter Left

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_Parameter.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Parameter-set

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Parameter-set with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					Parameter_set.production_kind kind = (Parameter_set.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case Parameter_set.production_kind.g_Parameter_set_1:
							// traverse syntax tree node associated with production
							// Parameter-set: Parameter

							node.m_Parameter.Visit (visitor, appData);
							break;
						case Parameter_set.production_kind.g_Parameter_set_2:
							// traverse syntax tree node associated with production
							// Parameter-set: Parameter-set "," Parameter Left

							node.m_comma.Visit (visitor, appData);
							node.m_Parameter.Visit (visitor, appData);
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
			for (Parameter_set node = this; node != null; node = node.m_Parameter_set)
			{
				node.parent = parent;
				node.m_Parameter?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule Parameter-set
		//

		public void _init ()
		{
			m_Parameter = null;
			m_Parameter_set = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (Parameter_set p_Parameter_set, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<Parameter_set> stack = new Stack<Parameter_set> ();
			Parameter_set p_Parameter_set;
			for (p_Parameter_set = this; p_Parameter_set != null; p_Parameter_set = p_Parameter_set.m_Parameter_set)
				stack.Push (p_Parameter_set);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Parameter-set

		// counter of all nodes associated with syntax rule Parameter-set
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Parameter-set
		[DataMember (Name = "m_Parameter")] public Parameter m_Parameter { get; private set; }
		[DataMember (Name = "m_Parameter_set")] public Parameter_set m_Parameter_set { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Parameter-set

		// delegate function (callback) prototype associated with syntax rule Parameter-set
		public delegate bool Parameter_set_Callback (SyntaxTreeCallbackReason reason, Parameter_set.production_kind kind, Parameter_set p_Parameter_set);

		// event associated with syntax rule Parameter-set
		public event Parameter_set_Callback Parameter_set_Event;

		// event trigger associated with syntax rule Parameter-set
		public bool Raise_Parameter_set_Event (SyntaxTreeCallbackReason reason, Parameter_set.production_kind kind, Parameter_set p_Parameter_set)
		{
			bool? status = Parameter_set_Event?.Invoke (reason, kind, p_Parameter_set);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Parameter-set
		//
		// traverse syntax tree node associated with any production of syntax rule Parameter-set
		//

		public void Traverse (Parameter_set p_Parameter_set)
		{
			if (p_Parameter_set.isLocked())
				return;
			if (Raise_Parameter_set_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (Parameter_set.production_kind) p_Parameter_set.kind, p_Parameter_set))
				p_Parameter_set.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					Parameter_set.production_kind kind = (Parameter_set.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_Parameter_set_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case Parameter_set.production_kind.g_Parameter_set_1:
								// traverse syntax tree node associated with production
								// Parameter-set: Parameter

								if (Raise_Parameter_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_Parameter);
								node.turn_inc ();
								Raise_Parameter_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case Parameter_set.production_kind.g_Parameter_set_2:
								// traverse syntax tree node associated with production
								// Parameter-set: Parameter-set "," Parameter Left

								if (Raise_Parameter_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_Parameter_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_Parameter);
								node.turn_inc ();
								Raise_Parameter_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_Parameter_set_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_Parameter_set_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (Parameter_set.production_kind) p_Parameter_set.kind, p_Parameter_set);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Parameter-set
		//

		public void TraverseCommon (Parameter_set p_Parameter_set)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_Parameter_set.kind, p_Parameter_set))
				p_Parameter_set.Iterate (null, (node, appData) =>
				{
					Parameter_set.production_kind kind = (Parameter_set.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case Parameter_set.production_kind.g_Parameter_set_1:
							// traverse syntax tree node associated with production
							// Parameter-set: Parameter

							TraverseCommon (node.m_Parameter);
							break;
						case Parameter_set.production_kind.g_Parameter_set_2:
							// traverse syntax tree node associated with production
							// Parameter-set: Parameter-set "," Parameter Left

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_Parameter);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_Parameter_set.kind, p_Parameter_set);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Parameter-set

		//
		// create syntax tree node associated with production
		// Parameter-set: Parameter

		//

		public Parameter_set Parameter_set_1 (Parameter p_Parameter)
		{
			Parameter_set p_Parameter_set_ref = new Parameter_set(p_Parameter);
			p_Parameter.parent = p_Parameter_set_ref;
			Raise_Parameter_set_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Parameter_set.production_kind.g_Parameter_set_1, p_Parameter_set_ref);
			return p_Parameter_set_ref;
		}

		//
		// create syntax tree node associated with production
		// Parameter-set: Parameter-set "," Parameter Left

		//

		public Parameter_set Parameter_set_2 (Parameter_set p_Parameter_set, SyntaxTreeToken p_token, Parameter p_Parameter)
		{
			Parameter_set p_Parameter_set_ref = new Parameter_set(p_Parameter_set, p_token, p_Parameter);
			p_Parameter_set.parent = p_Parameter_set_ref;
			p_token.parent = p_Parameter_set_ref;
			p_Parameter.parent = p_Parameter_set_ref;
			Raise_Parameter_set_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Parameter_set.production_kind.g_Parameter_set_2, p_Parameter_set_ref);
			return p_Parameter_set_ref;
		}
		#endregion
	};
}
