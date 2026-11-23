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
	// class associated with syntax rule Enumeration
	//

	[DataContract]
	public class	Enumeration : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Enumeration
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Enumeration
		{
			g_Enumeration_1 = 1,	// EnumerationItem

			g_Enumeration_2 = 2,	// Enumeration "," EnumerationItem

		};
		#endregion
		#region production markers associated with the syntax rule Enumeration

		// markers associated with production: Enumeration -> EnumerationItem

		public enum production_marker_1 : ushort
		{
			m_EnumerationItem,
			final
		};

		// markers associated with production: Enumeration -> Enumeration "," EnumerationItem

		public enum production_marker_2 : ushort
		{
			m_Enumeration,
			m_EnumerationItem,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Enumeration

		// Constructor declaration(s) associated with production(s) of syntax rule Enumeration

		//
		// Constructor associated with the following production(s)
		// Enumeration -> EnumerationItem

		//

		public Enumeration (EnumerationItem p_EnumerationItem) : base ((uint) ProductionID._Enumeration_ID, (uint) production_kind.g_Enumeration_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_EnumerationItem = p_EnumerationItem;
		}

		//
		// Constructor associated with the following production(s)
		// Enumeration -> Enumeration "," EnumerationItem

		//

		public Enumeration (Enumeration p_Enumeration, SyntaxTreeToken p_token, EnumerationItem p_EnumerationItem) : base ((uint) ProductionID._Enumeration_ID, (uint) production_kind.g_Enumeration_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_Enumeration = p_Enumeration;
			children[1] = m_comma = p_token;
			children[2] = m_EnumerationItem = p_EnumerationItem;
		}

		public Enumeration () { }

		// Copy constructor

		public Enumeration (Enumeration p_Enumeration) : base (p_Enumeration.id, p_Enumeration.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Enumeration.appInfo;
			switch ((production_kind) p_Enumeration.kind)
			{
				case production_kind.g_Enumeration_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EnumerationItem = (p_Enumeration.m_EnumerationItem != null) ? new EnumerationItem (p_Enumeration.m_EnumerationItem) : null) != null) m_EnumerationItem.parent = this;
					break;
				case production_kind.g_Enumeration_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_Enumeration = (p_Enumeration.m_Enumeration != null) ? new Enumeration (p_Enumeration.m_Enumeration) : null) != null) m_Enumeration.parent = this;
					if ((children [1] = m_comma = (p_Enumeration.m_comma != null) ? new SyntaxTreeToken (p_Enumeration.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_EnumerationItem = (p_Enumeration.m_EnumerationItem != null) ? new EnumerationItem (p_Enumeration.m_EnumerationItem) : null) != null) m_EnumerationItem.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Enumeration" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Enumeration (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_EnumerationItem?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Enumeration

		// Content changing function(s) associated with production(s) of syntax rule Enumeration

		//
		// Content changing function associated with following production(s)
		// Enumeration -> EnumerationItem

		//

		public void change(EnumerationItem p_EnumerationItem)
		{
			_init ();
			this.kind = (uint) production_kind.g_Enumeration_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_EnumerationItem = p_EnumerationItem;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Enumeration -> Enumeration "," EnumerationItem

		//

		public void change(Enumeration p_Enumeration, SyntaxTreeToken p_token, EnumerationItem p_EnumerationItem)
		{
			_init ();
			this.kind = (uint) production_kind.g_Enumeration_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_Enumeration = p_Enumeration;
			children [1] = m_comma = p_token;
			children [2] = m_EnumerationItem = p_EnumerationItem;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Enumeration
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_EnumerationItem != null) && node.m_EnumerationItem.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Enumeration

		//
		// emit production tree node associated with any production of syntax rule Enumeration
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_Enumeration_1:
						// emit syntax tree node associated with production
						// Enumeration: EnumerationItem

						s += " " + node.m_EnumerationItem.Emit (depth - 1);
						break;
					case production_kind.g_Enumeration_2:
						// emit syntax tree node associated with production
						// Enumeration: Enumeration "," EnumerationItem

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_EnumerationItem.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Enumeration
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "Enumeration (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_Enumeration_1:
						// emit syntax tree node associated with production
						// Enumeration: EnumerationItem

						str += node.m_EnumerationItem.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_Enumeration_2:
						// emit syntax tree node associated with production
						// Enumeration: Enumeration "," EnumerationItem

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_EnumerationItem.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Enumeration

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Enumeration with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					Enumeration.production_kind kind = (Enumeration.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case Enumeration.production_kind.g_Enumeration_1:
							// traverse syntax tree node associated with production
							// Enumeration: EnumerationItem

							node.m_EnumerationItem.Visit (visitor, appData);
							break;
						case Enumeration.production_kind.g_Enumeration_2:
							// traverse syntax tree node associated with production
							// Enumeration: Enumeration "," EnumerationItem

							node.m_comma.Visit (visitor, appData);
							node.m_EnumerationItem.Visit (visitor, appData);
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
			for (Enumeration node = this; node != null; node = node.m_Enumeration)
			{
				node.parent = parent;
				node.m_EnumerationItem?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule Enumeration
		//

		public void _init ()
		{
			m_EnumerationItem = null;
			m_Enumeration = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (Enumeration p_Enumeration, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<Enumeration> stack = new Stack<Enumeration> ();
			Enumeration p_Enumeration;
			for (p_Enumeration = this; p_Enumeration != null; p_Enumeration = p_Enumeration.m_Enumeration)
				stack.Push (p_Enumeration);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Enumeration

		// counter of all nodes associated with syntax rule Enumeration
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Enumeration
		[DataMember (Name = "m_EnumerationItem")] public EnumerationItem m_EnumerationItem { get; private set; }
		[DataMember (Name = "m_Enumeration")] public Enumeration m_Enumeration { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Enumeration

		// delegate function (callback) prototype associated with syntax rule Enumeration
		public delegate bool Enumeration_Callback (SyntaxTreeCallbackReason reason, Enumeration.production_kind kind, Enumeration p_Enumeration);

		// event associated with syntax rule Enumeration
		public event Enumeration_Callback Enumeration_Event;

		// event trigger associated with syntax rule Enumeration
		public bool Raise_Enumeration_Event (SyntaxTreeCallbackReason reason, Enumeration.production_kind kind, Enumeration p_Enumeration)
		{
			bool? status = Enumeration_Event?.Invoke (reason, kind, p_Enumeration);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Enumeration
		//
		// traverse syntax tree node associated with any production of syntax rule Enumeration
		//

		public void Traverse (Enumeration p_Enumeration)
		{
			if (p_Enumeration.isLocked())
				return;
			if (Raise_Enumeration_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (Enumeration.production_kind) p_Enumeration.kind, p_Enumeration))
				p_Enumeration.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					Enumeration.production_kind kind = (Enumeration.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_Enumeration_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case Enumeration.production_kind.g_Enumeration_1:
								// traverse syntax tree node associated with production
								// Enumeration: EnumerationItem

								if (Raise_Enumeration_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_EnumerationItem);
								node.turn_inc ();
								Raise_Enumeration_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case Enumeration.production_kind.g_Enumeration_2:
								// traverse syntax tree node associated with production
								// Enumeration: Enumeration "," EnumerationItem

								if (Raise_Enumeration_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_Enumeration_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_EnumerationItem);
								node.turn_inc ();
								Raise_Enumeration_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_Enumeration_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_Enumeration_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (Enumeration.production_kind) p_Enumeration.kind, p_Enumeration);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Enumeration
		//

		public void TraverseCommon (Enumeration p_Enumeration)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_Enumeration.kind, p_Enumeration))
				p_Enumeration.Iterate (null, (node, appData) =>
				{
					Enumeration.production_kind kind = (Enumeration.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case Enumeration.production_kind.g_Enumeration_1:
							// traverse syntax tree node associated with production
							// Enumeration: EnumerationItem

							TraverseCommon (node.m_EnumerationItem);
							break;
						case Enumeration.production_kind.g_Enumeration_2:
							// traverse syntax tree node associated with production
							// Enumeration: Enumeration "," EnumerationItem

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_EnumerationItem);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_Enumeration.kind, p_Enumeration);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Enumeration

		//
		// create syntax tree node associated with production
		// Enumeration: EnumerationItem

		//

		public Enumeration Enumeration_1 (EnumerationItem p_EnumerationItem)
		{
			Enumeration p_Enumeration_ref = new Enumeration(p_EnumerationItem);
			p_EnumerationItem.parent = p_Enumeration_ref;
			Raise_Enumeration_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Enumeration.production_kind.g_Enumeration_1, p_Enumeration_ref);
			return p_Enumeration_ref;
		}

		//
		// create syntax tree node associated with production
		// Enumeration: Enumeration "," EnumerationItem

		//

		public Enumeration Enumeration_2 (Enumeration p_Enumeration, SyntaxTreeToken p_token, EnumerationItem p_EnumerationItem)
		{
			Enumeration p_Enumeration_ref = new Enumeration(p_Enumeration, p_token, p_EnumerationItem);
			p_Enumeration.parent = p_Enumeration_ref;
			p_token.parent = p_Enumeration_ref;
			p_EnumerationItem.parent = p_Enumeration_ref;
			Raise_Enumeration_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Enumeration.production_kind.g_Enumeration_2, p_Enumeration_ref);
			return p_Enumeration_ref;
		}
		#endregion
	};
}
