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
	// class associated with syntax rule NT-Objects
	//

	[DataContract]
	public class	NT_Objects : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NT-Objects
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NT-Objects
		{
			g_NT_Objects_1 = 1,	// NT-Object

			g_NT_Objects_2 = 2,	// NT-Objects "," NT-Object Left

		};
		#endregion
		#region production markers associated with the syntax rule NT-Objects

		// markers associated with production: NT-Objects -> NT-Object

		public enum production_marker_1 : ushort
		{
			m_NT_Object,
			final
		};

		// markers associated with production: NT-Objects -> NT-Objects "," NT-Object Left

		public enum production_marker_2 : ushort
		{
			m_NT_Objects,
			m_NT_Object,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NT-Objects

		// Constructor declaration(s) associated with production(s) of syntax rule NT-Objects

		//
		// Constructor associated with the following production(s)
		// NT-Objects -> NT-Object

		//

		public NT_Objects (NT_Object p_NT_Object) : base ((uint) ProductionID._NT_Objects_ID, (uint) production_kind.g_NT_Objects_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NT_Object = p_NT_Object;
		}

		//
		// Constructor associated with the following production(s)
		// NT-Objects -> NT-Objects "," NT-Object Left

		//

		public NT_Objects (NT_Objects p_NT_Objects, SyntaxTreeToken p_token, NT_Object p_NT_Object) : base ((uint) ProductionID._NT_Objects_ID, (uint) production_kind.g_NT_Objects_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_NT_Objects = p_NT_Objects;
			children[1] = m_comma = p_token;
			children[2] = m_NT_Object = p_NT_Object;
		}

		public NT_Objects () { }

		// Copy constructor

		public NT_Objects (NT_Objects p_NT_Objects) : base (p_NT_Objects.id, p_NT_Objects.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NT_Objects.appInfo;
			switch ((production_kind) p_NT_Objects.kind)
			{
				case production_kind.g_NT_Objects_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NT_Object = (p_NT_Objects.m_NT_Object != null) ? new NT_Object (p_NT_Objects.m_NT_Object) : null) != null) m_NT_Object.parent = this;
					break;
				case production_kind.g_NT_Objects_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_NT_Objects = (p_NT_Objects.m_NT_Objects != null) ? new NT_Objects (p_NT_Objects.m_NT_Objects) : null) != null) m_NT_Objects.parent = this;
					if ((children [1] = m_comma = (p_NT_Objects.m_comma != null) ? new SyntaxTreeToken (p_NT_Objects.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_NT_Object = (p_NT_Objects.m_NT_Object != null) ? new NT_Object (p_NT_Objects.m_NT_Object) : null) != null) m_NT_Object.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NT_Objects" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NT_Objects (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_NT_Object?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NT-Objects

		// Content changing function(s) associated with production(s) of syntax rule NT-Objects

		//
		// Content changing function associated with following production(s)
		// NT-Objects -> NT-Object

		//

		public void change(NT_Object p_NT_Object)
		{
			_init ();
			this.kind = (uint) production_kind.g_NT_Objects_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NT_Object = p_NT_Object;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// NT-Objects -> NT-Objects "," NT-Object Left

		//

		public void change(NT_Objects p_NT_Objects, SyntaxTreeToken p_token, NT_Object p_NT_Object)
		{
			_init ();
			this.kind = (uint) production_kind.g_NT_Objects_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_NT_Objects = p_NT_Objects;
			children [1] = m_comma = p_token;
			children [2] = m_NT_Object = p_NT_Object;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NT-Objects
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_NT_Object != null) && node.m_NT_Object.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NT-Objects

		//
		// emit production tree node associated with any production of syntax rule NT-Objects
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_NT_Objects_1:
						// emit syntax tree node associated with production
						// NT-Objects: NT-Object

						s += " " + node.m_NT_Object.Emit (depth - 1);
						break;
					case production_kind.g_NT_Objects_2:
						// emit syntax tree node associated with production
						// NT-Objects: NT-Objects "," NT-Object Left

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_NT_Object.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NT-Objects
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "NT_Objects (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_NT_Objects_1:
						// emit syntax tree node associated with production
						// NT-Objects: NT-Object

						str += node.m_NT_Object.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_NT_Objects_2:
						// emit syntax tree node associated with production
						// NT-Objects: NT-Objects "," NT-Object Left

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_NT_Object.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NT-Objects

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NT-Objects with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					NT_Objects.production_kind kind = (NT_Objects.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case NT_Objects.production_kind.g_NT_Objects_1:
							// traverse syntax tree node associated with production
							// NT-Objects: NT-Object

							node.m_NT_Object.Visit (visitor, appData);
							break;
						case NT_Objects.production_kind.g_NT_Objects_2:
							// traverse syntax tree node associated with production
							// NT-Objects: NT-Objects "," NT-Object Left

							node.m_comma.Visit (visitor, appData);
							node.m_NT_Object.Visit (visitor, appData);
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
			for (NT_Objects node = this; node != null; node = node.m_NT_Objects)
			{
				node.parent = parent;
				node.m_NT_Object?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule NT-Objects
		//

		public void _init ()
		{
			m_NT_Object = null;
			m_NT_Objects = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (NT_Objects p_NT_Objects, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<NT_Objects> stack = new Stack<NT_Objects> ();
			NT_Objects p_NT_Objects;
			for (p_NT_Objects = this; p_NT_Objects != null; p_NT_Objects = p_NT_Objects.m_NT_Objects)
				stack.Push (p_NT_Objects);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NT-Objects

		// counter of all nodes associated with syntax rule NT-Objects
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NT-Objects
		[DataMember (Name = "m_NT_Object")] public NT_Object m_NT_Object { get; private set; }
		[DataMember (Name = "m_NT_Objects")] public NT_Objects m_NT_Objects { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NT-Objects

		// delegate function (callback) prototype associated with syntax rule NT-Objects
		public delegate bool NT_Objects_Callback (SyntaxTreeCallbackReason reason, NT_Objects.production_kind kind, NT_Objects p_NT_Objects);

		// event associated with syntax rule NT-Objects
		public event NT_Objects_Callback NT_Objects_Event;

		// event trigger associated with syntax rule NT-Objects
		public bool Raise_NT_Objects_Event (SyntaxTreeCallbackReason reason, NT_Objects.production_kind kind, NT_Objects p_NT_Objects)
		{
			bool? status = NT_Objects_Event?.Invoke (reason, kind, p_NT_Objects);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NT-Objects
		//
		// traverse syntax tree node associated with any production of syntax rule NT-Objects
		//

		public void Traverse (NT_Objects p_NT_Objects)
		{
			if (p_NT_Objects.isLocked())
				return;
			if (Raise_NT_Objects_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (NT_Objects.production_kind) p_NT_Objects.kind, p_NT_Objects))
				p_NT_Objects.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					NT_Objects.production_kind kind = (NT_Objects.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_NT_Objects_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case NT_Objects.production_kind.g_NT_Objects_1:
								// traverse syntax tree node associated with production
								// NT-Objects: NT-Object

								if (Raise_NT_Objects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_NT_Object);
								node.turn_inc ();
								Raise_NT_Objects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case NT_Objects.production_kind.g_NT_Objects_2:
								// traverse syntax tree node associated with production
								// NT-Objects: NT-Objects "," NT-Object Left

								if (Raise_NT_Objects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_NT_Objects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_NT_Object);
								node.turn_inc ();
								Raise_NT_Objects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_NT_Objects_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_NT_Objects_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (NT_Objects.production_kind) p_NT_Objects.kind, p_NT_Objects);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NT-Objects
		//

		public void TraverseCommon (NT_Objects p_NT_Objects)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_NT_Objects.kind, p_NT_Objects))
				p_NT_Objects.Iterate (null, (node, appData) =>
				{
					NT_Objects.production_kind kind = (NT_Objects.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case NT_Objects.production_kind.g_NT_Objects_1:
							// traverse syntax tree node associated with production
							// NT-Objects: NT-Object

							TraverseCommon (node.m_NT_Object);
							break;
						case NT_Objects.production_kind.g_NT_Objects_2:
							// traverse syntax tree node associated with production
							// NT-Objects: NT-Objects "," NT-Object Left

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_NT_Object);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_NT_Objects.kind, p_NT_Objects);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NT-Objects

		//
		// create syntax tree node associated with production
		// NT-Objects: NT-Object

		//

		public NT_Objects NT_Objects_1 (NT_Object p_NT_Object)
		{
			NT_Objects p_NT_Objects_ref = new NT_Objects(p_NT_Object);
			p_NT_Object.parent = p_NT_Objects_ref;
			Raise_NT_Objects_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NT_Objects.production_kind.g_NT_Objects_1, p_NT_Objects_ref);
			return p_NT_Objects_ref;
		}

		//
		// create syntax tree node associated with production
		// NT-Objects: NT-Objects "," NT-Object Left

		//

		public NT_Objects NT_Objects_2 (NT_Objects p_NT_Objects, SyntaxTreeToken p_token, NT_Object p_NT_Object)
		{
			NT_Objects p_NT_Objects_ref = new NT_Objects(p_NT_Objects, p_token, p_NT_Object);
			p_NT_Objects.parent = p_NT_Objects_ref;
			p_token.parent = p_NT_Objects_ref;
			p_NT_Object.parent = p_NT_Objects_ref;
			Raise_NT_Objects_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NT_Objects.production_kind.g_NT_Objects_2, p_NT_Objects_ref);
			return p_NT_Objects_ref;
		}
		#endregion
	};
}
