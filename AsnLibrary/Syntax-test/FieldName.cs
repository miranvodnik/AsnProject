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
	// class associated with syntax rule FieldName
	//

	[DataContract]
	public class	FieldName : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule FieldName
		public enum production_kind : ushort	// enumerated production(s) of syntax rule FieldName
		{
			g_FieldName_1 = 1,	// PrimitiveFieldName

			g_FieldName_2 = 2,	// FieldName "." PrimitiveFieldName Left

		};
		#endregion
		#region production markers associated with the syntax rule FieldName

		// markers associated with production: FieldName -> PrimitiveFieldName

		public enum production_marker_1 : ushort
		{
			m_PrimitiveFieldName,
			final
		};

		// markers associated with production: FieldName -> FieldName "." PrimitiveFieldName Left

		public enum production_marker_2 : ushort
		{
			m_FieldName,
			m_PrimitiveFieldName,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule FieldName

		// Constructor declaration(s) associated with production(s) of syntax rule FieldName

		//
		// Constructor associated with the following production(s)
		// FieldName -> PrimitiveFieldName

		//

		public FieldName (PrimitiveFieldName p_PrimitiveFieldName) : base ((uint) ProductionID._FieldName_ID, (uint) production_kind.g_FieldName_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_PrimitiveFieldName = p_PrimitiveFieldName;
		}

		//
		// Constructor associated with the following production(s)
		// FieldName -> FieldName "." PrimitiveFieldName Left

		//

		public FieldName (FieldName p_FieldName, SyntaxTreeToken p_token, PrimitiveFieldName p_PrimitiveFieldName) : base ((uint) ProductionID._FieldName_ID, (uint) production_kind.g_FieldName_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_FieldName = p_FieldName;
			children[1] = m_dot = p_token;
			children[2] = m_PrimitiveFieldName = p_PrimitiveFieldName;
		}

		public FieldName () { }

		// Copy constructor

		public FieldName (FieldName p_FieldName) : base (p_FieldName.id, p_FieldName.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_FieldName.appInfo;
			switch ((production_kind) p_FieldName.kind)
			{
				case production_kind.g_FieldName_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_PrimitiveFieldName = (p_FieldName.m_PrimitiveFieldName != null) ? new PrimitiveFieldName (p_FieldName.m_PrimitiveFieldName) : null) != null) m_PrimitiveFieldName.parent = this;
					break;
				case production_kind.g_FieldName_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_FieldName = (p_FieldName.m_FieldName != null) ? new FieldName (p_FieldName.m_FieldName) : null) != null) m_FieldName.parent = this;
					if ((children [1] = m_dot = (p_FieldName.m_dot != null) ? new SyntaxTreeToken (p_FieldName.m_dot) : null) != null) m_dot.parent = this;
					if ((children [2] = m_PrimitiveFieldName = (p_FieldName.m_PrimitiveFieldName != null) ? new PrimitiveFieldName (p_FieldName.m_PrimitiveFieldName) : null) != null) m_PrimitiveFieldName.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "FieldName" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new FieldName (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_PrimitiveFieldName?.Dispose ();
				node.m_dot?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule FieldName

		// Content changing function(s) associated with production(s) of syntax rule FieldName

		//
		// Content changing function associated with following production(s)
		// FieldName -> PrimitiveFieldName

		//

		public void change(PrimitiveFieldName p_PrimitiveFieldName)
		{
			_init ();
			this.kind = (uint) production_kind.g_FieldName_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_PrimitiveFieldName = p_PrimitiveFieldName;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// FieldName -> FieldName "." PrimitiveFieldName Left

		//

		public void change(FieldName p_FieldName, SyntaxTreeToken p_token, PrimitiveFieldName p_PrimitiveFieldName)
		{
			_init ();
			this.kind = (uint) production_kind.g_FieldName_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_FieldName = p_FieldName;
			children [1] = m_dot = p_token;
			children [2] = m_PrimitiveFieldName = p_PrimitiveFieldName;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule FieldName
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_PrimitiveFieldName != null) && node.m_PrimitiveFieldName.checkInclusion (element) ||
					(node.m_dot != null) && node.m_dot.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule FieldName

		//
		// emit production tree node associated with any production of syntax rule FieldName
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_FieldName_1:
						// emit syntax tree node associated with production
						// FieldName: PrimitiveFieldName

						s += " " + node.m_PrimitiveFieldName.Emit (depth - 1);
						break;
					case production_kind.g_FieldName_2:
						// emit syntax tree node associated with production
						// FieldName: FieldName "." PrimitiveFieldName Left

						s += " " + node.m_dot.Emit (depth - 1);
						s += " " + node.m_PrimitiveFieldName.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule FieldName
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "FieldName (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_FieldName_1:
						// emit syntax tree node associated with production
						// FieldName: PrimitiveFieldName

						str += node.m_PrimitiveFieldName.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_FieldName_2:
						// emit syntax tree node associated with production
						// FieldName: FieldName "." PrimitiveFieldName Left

						str += ' ';
						str += "dot";
						str += ' ';
						str += node.m_PrimitiveFieldName.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule FieldName

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule FieldName with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					FieldName.production_kind kind = (FieldName.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case FieldName.production_kind.g_FieldName_1:
							// traverse syntax tree node associated with production
							// FieldName: PrimitiveFieldName

							node.m_PrimitiveFieldName.Visit (visitor, appData);
							break;
						case FieldName.production_kind.g_FieldName_2:
							// traverse syntax tree node associated with production
							// FieldName: FieldName "." PrimitiveFieldName Left

							node.m_dot.Visit (visitor, appData);
							node.m_PrimitiveFieldName.Visit (visitor, appData);
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
			for (FieldName node = this; node != null; node = node.m_FieldName)
			{
				node.parent = parent;
				node.m_PrimitiveFieldName?.reparent (parent);
				node.m_dot?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule FieldName
		//

		public void _init ()
		{
			m_PrimitiveFieldName = null;
			m_FieldName = null;
			m_dot = null;
		}

		public delegate object IteratorDelegate (FieldName p_FieldName, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<FieldName> stack = new Stack<FieldName> ();
			FieldName p_FieldName;
			for (p_FieldName = this; p_FieldName != null; p_FieldName = p_FieldName.m_FieldName)
				stack.Push (p_FieldName);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule FieldName

		// counter of all nodes associated with syntax rule FieldName
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule FieldName
		[DataMember (Name = "m_PrimitiveFieldName")] public PrimitiveFieldName m_PrimitiveFieldName { get; private set; }
		[DataMember (Name = "m_FieldName")] public FieldName m_FieldName { get; private set; }
		[DataMember (Name = "m_dot")] public SyntaxTreeToken m_dot { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule FieldName

		// delegate function (callback) prototype associated with syntax rule FieldName
		public delegate bool FieldName_Callback (SyntaxTreeCallbackReason reason, FieldName.production_kind kind, FieldName p_FieldName);

		// event associated with syntax rule FieldName
		public event FieldName_Callback FieldName_Event;

		// event trigger associated with syntax rule FieldName
		public bool Raise_FieldName_Event (SyntaxTreeCallbackReason reason, FieldName.production_kind kind, FieldName p_FieldName)
		{
			bool? status = FieldName_Event?.Invoke (reason, kind, p_FieldName);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule FieldName
		//
		// traverse syntax tree node associated with any production of syntax rule FieldName
		//

		public void Traverse (FieldName p_FieldName)
		{
			if (p_FieldName.isLocked())
				return;
			if (Raise_FieldName_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (FieldName.production_kind) p_FieldName.kind, p_FieldName))
				p_FieldName.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					FieldName.production_kind kind = (FieldName.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_FieldName_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case FieldName.production_kind.g_FieldName_1:
								// traverse syntax tree node associated with production
								// FieldName: PrimitiveFieldName

								if (Raise_FieldName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_PrimitiveFieldName);
								node.turn_inc ();
								Raise_FieldName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case FieldName.production_kind.g_FieldName_2:
								// traverse syntax tree node associated with production
								// FieldName: FieldName "." PrimitiveFieldName Left

								if (Raise_FieldName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_FieldName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_PrimitiveFieldName);
								node.turn_inc ();
								Raise_FieldName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_FieldName_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_FieldName_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (FieldName.production_kind) p_FieldName.kind, p_FieldName);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule FieldName
		//

		public void TraverseCommon (FieldName p_FieldName)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_FieldName.kind, p_FieldName))
				p_FieldName.Iterate (null, (node, appData) =>
				{
					FieldName.production_kind kind = (FieldName.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case FieldName.production_kind.g_FieldName_1:
							// traverse syntax tree node associated with production
							// FieldName: PrimitiveFieldName

							TraverseCommon (node.m_PrimitiveFieldName);
							break;
						case FieldName.production_kind.g_FieldName_2:
							// traverse syntax tree node associated with production
							// FieldName: FieldName "." PrimitiveFieldName Left

							TraverseCommon (node.m_dot);
							TraverseCommon (node.m_PrimitiveFieldName);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_FieldName.kind, p_FieldName);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule FieldName

		//
		// create syntax tree node associated with production
		// FieldName: PrimitiveFieldName

		//

		public FieldName FieldName_1 (PrimitiveFieldName p_PrimitiveFieldName)
		{
			FieldName p_FieldName_ref = new FieldName(p_PrimitiveFieldName);
			p_PrimitiveFieldName.parent = p_FieldName_ref;
			Raise_FieldName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, FieldName.production_kind.g_FieldName_1, p_FieldName_ref);
			return p_FieldName_ref;
		}

		//
		// create syntax tree node associated with production
		// FieldName: FieldName "." PrimitiveFieldName Left

		//

		public FieldName FieldName_2 (FieldName p_FieldName, SyntaxTreeToken p_token, PrimitiveFieldName p_PrimitiveFieldName)
		{
			FieldName p_FieldName_ref = new FieldName(p_FieldName, p_token, p_PrimitiveFieldName);
			p_FieldName.parent = p_FieldName_ref;
			p_token.parent = p_FieldName_ref;
			p_PrimitiveFieldName.parent = p_FieldName_ref;
			Raise_FieldName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, FieldName.production_kind.g_FieldName_2, p_FieldName_ref);
			return p_FieldName_ref;
		}
		#endregion
	};
}
