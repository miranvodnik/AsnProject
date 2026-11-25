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
	// class associated with syntax rule AC-NamedBits
	//

	[DataContract]
	public class	AC_NamedBits : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-NamedBits
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-NamedBits
		{
			g_AC_NamedBits_1 = 1,	// AC-NamedBit

			g_AC_NamedBits_2 = 2,	// AC-NamedBits "," AC-NamedBit Left

		};
		#endregion
		#region production markers associated with the syntax rule AC-NamedBits

		// markers associated with production: AC-NamedBits -> AC-NamedBit

		public enum production_marker_1 : ushort
		{
			m_AC_NamedBit,
			final
		};

		// markers associated with production: AC-NamedBits -> AC-NamedBits "," AC-NamedBit Left

		public enum production_marker_2 : ushort
		{
			m_AC_NamedBits,
			m_AC_NamedBit,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-NamedBits

		// Constructor declaration(s) associated with production(s) of syntax rule AC-NamedBits

		//
		// Constructor associated with the following production(s)
		// AC-NamedBits -> AC-NamedBit

		//

		public AC_NamedBits (AC_NamedBit p_AC_NamedBit) : base ((uint) ProductionID._AC_NamedBits_ID, (uint) production_kind.g_AC_NamedBits_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_AC_NamedBit = p_AC_NamedBit;
		}

		//
		// Constructor associated with the following production(s)
		// AC-NamedBits -> AC-NamedBits "," AC-NamedBit Left

		//

		public AC_NamedBits (AC_NamedBits p_AC_NamedBits, SyntaxTreeToken p_token, AC_NamedBit p_AC_NamedBit) : base ((uint) ProductionID._AC_NamedBits_ID, (uint) production_kind.g_AC_NamedBits_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_AC_NamedBits = p_AC_NamedBits;
			children[1] = m_comma = p_token;
			children[2] = m_AC_NamedBit = p_AC_NamedBit;
		}

		public AC_NamedBits () { }

		// Copy constructor

		public AC_NamedBits (AC_NamedBits p_AC_NamedBits) : base (p_AC_NamedBits.id, p_AC_NamedBits.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_NamedBits.appInfo;
			switch ((production_kind) p_AC_NamedBits.kind)
			{
				case production_kind.g_AC_NamedBits_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_AC_NamedBit = (p_AC_NamedBits.m_AC_NamedBit != null) ? new AC_NamedBit (p_AC_NamedBits.m_AC_NamedBit) : null) != null) m_AC_NamedBit.parent = this;
					break;
				case production_kind.g_AC_NamedBits_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_AC_NamedBits = (p_AC_NamedBits.m_AC_NamedBits != null) ? new AC_NamedBits (p_AC_NamedBits.m_AC_NamedBits) : null) != null) m_AC_NamedBits.parent = this;
					if ((children [1] = m_comma = (p_AC_NamedBits.m_comma != null) ? new SyntaxTreeToken (p_AC_NamedBits.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_AC_NamedBit = (p_AC_NamedBits.m_AC_NamedBit != null) ? new AC_NamedBit (p_AC_NamedBits.m_AC_NamedBit) : null) != null) m_AC_NamedBit.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AC_NamedBits" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_NamedBits (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_AC_NamedBit?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-NamedBits

		// Content changing function(s) associated with production(s) of syntax rule AC-NamedBits

		//
		// Content changing function associated with following production(s)
		// AC-NamedBits -> AC-NamedBit

		//

		public void change(AC_NamedBit p_AC_NamedBit)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_NamedBits_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_AC_NamedBit = p_AC_NamedBit;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AC-NamedBits -> AC-NamedBits "," AC-NamedBit Left

		//

		public void change(AC_NamedBits p_AC_NamedBits, SyntaxTreeToken p_token, AC_NamedBit p_AC_NamedBit)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_NamedBits_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_AC_NamedBits = p_AC_NamedBits;
			children [1] = m_comma = p_token;
			children [2] = m_AC_NamedBit = p_AC_NamedBit;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-NamedBits
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_AC_NamedBit != null) && node.m_AC_NamedBit.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-NamedBits

		//
		// emit production tree node associated with any production of syntax rule AC-NamedBits
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_AC_NamedBits_1:
						// emit syntax tree node associated with production
						// AC-NamedBits: AC-NamedBit

						s += " " + node.m_AC_NamedBit.Emit (depth - 1);
						break;
					case production_kind.g_AC_NamedBits_2:
						// emit syntax tree node associated with production
						// AC-NamedBits: AC-NamedBits "," AC-NamedBit Left

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_AC_NamedBit.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-NamedBits
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "AC_NamedBits (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_AC_NamedBits_1:
						// emit syntax tree node associated with production
						// AC-NamedBits: AC-NamedBit

						str += node.m_AC_NamedBit.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_AC_NamedBits_2:
						// emit syntax tree node associated with production
						// AC-NamedBits: AC-NamedBits "," AC-NamedBit Left

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_AC_NamedBit.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-NamedBits

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-NamedBits with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					AC_NamedBits.production_kind kind = (AC_NamedBits.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case AC_NamedBits.production_kind.g_AC_NamedBits_1:
							// traverse syntax tree node associated with production
							// AC-NamedBits: AC-NamedBit

							node.m_AC_NamedBit.Visit (visitor, appData);
							break;
						case AC_NamedBits.production_kind.g_AC_NamedBits_2:
							// traverse syntax tree node associated with production
							// AC-NamedBits: AC-NamedBits "," AC-NamedBit Left

							node.m_comma.Visit (visitor, appData);
							node.m_AC_NamedBit.Visit (visitor, appData);
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
			for (AC_NamedBits node = this; node != null; node = node.m_AC_NamedBits)
			{
				node.parent = parent;
				node.m_AC_NamedBit?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule AC-NamedBits
		//

		public void _init ()
		{
			m_AC_NamedBit = null;
			m_AC_NamedBits = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (AC_NamedBits p_AC_NamedBits, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<AC_NamedBits> stack = new Stack<AC_NamedBits> ();
			AC_NamedBits p_AC_NamedBits;
			for (p_AC_NamedBits = this; p_AC_NamedBits != null; p_AC_NamedBits = p_AC_NamedBits.m_AC_NamedBits)
				stack.Push (p_AC_NamedBits);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-NamedBits

		// counter of all nodes associated with syntax rule AC-NamedBits
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-NamedBits
		[DataMember (Name = "m_AC_NamedBit")] public AC_NamedBit m_AC_NamedBit { get; private set; }
		[DataMember (Name = "m_AC_NamedBits")] public AC_NamedBits m_AC_NamedBits { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-NamedBits

		// delegate function (callback) prototype associated with syntax rule AC-NamedBits
		public delegate bool AC_NamedBits_Callback (SyntaxTreeCallbackReason reason, AC_NamedBits.production_kind kind, AC_NamedBits p_AC_NamedBits);

		// event associated with syntax rule AC-NamedBits
		public event AC_NamedBits_Callback AC_NamedBits_Event;

		// event trigger associated with syntax rule AC-NamedBits
		public bool Raise_AC_NamedBits_Event (SyntaxTreeCallbackReason reason, AC_NamedBits.production_kind kind, AC_NamedBits p_AC_NamedBits)
		{
			bool? status = AC_NamedBits_Event?.Invoke (reason, kind, p_AC_NamedBits);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-NamedBits
		//
		// traverse syntax tree node associated with any production of syntax rule AC-NamedBits
		//

		public void Traverse (AC_NamedBits p_AC_NamedBits)
		{
			if (p_AC_NamedBits.isLocked())
				return;
			if (Raise_AC_NamedBits_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (AC_NamedBits.production_kind) p_AC_NamedBits.kind, p_AC_NamedBits))
				p_AC_NamedBits.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					AC_NamedBits.production_kind kind = (AC_NamedBits.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_AC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case AC_NamedBits.production_kind.g_AC_NamedBits_1:
								// traverse syntax tree node associated with production
								// AC-NamedBits: AC-NamedBit

								if (Raise_AC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_AC_NamedBit);
								node.turn_inc ();
								Raise_AC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case AC_NamedBits.production_kind.g_AC_NamedBits_2:
								// traverse syntax tree node associated with production
								// AC-NamedBits: AC-NamedBits "," AC-NamedBit Left

								if (Raise_AC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_AC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_AC_NamedBit);
								node.turn_inc ();
								Raise_AC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_AC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_AC_NamedBits_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (AC_NamedBits.production_kind) p_AC_NamedBits.kind, p_AC_NamedBits);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-NamedBits
		//

		public void TraverseCommon (AC_NamedBits p_AC_NamedBits)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_AC_NamedBits.kind, p_AC_NamedBits))
				p_AC_NamedBits.Iterate (null, (node, appData) =>
				{
					AC_NamedBits.production_kind kind = (AC_NamedBits.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case AC_NamedBits.production_kind.g_AC_NamedBits_1:
							// traverse syntax tree node associated with production
							// AC-NamedBits: AC-NamedBit

							TraverseCommon (node.m_AC_NamedBit);
							break;
						case AC_NamedBits.production_kind.g_AC_NamedBits_2:
							// traverse syntax tree node associated with production
							// AC-NamedBits: AC-NamedBits "," AC-NamedBit Left

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_AC_NamedBit);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_AC_NamedBits.kind, p_AC_NamedBits);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-NamedBits

		//
		// create syntax tree node associated with production
		// AC-NamedBits: AC-NamedBit

		//

		public AC_NamedBits AC_NamedBits_1 (AC_NamedBit p_AC_NamedBit)
		{
			AC_NamedBits p_AC_NamedBits_ref = new AC_NamedBits(p_AC_NamedBit);
			p_AC_NamedBit.parent = p_AC_NamedBits_ref;
			Raise_AC_NamedBits_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_NamedBits.production_kind.g_AC_NamedBits_1, p_AC_NamedBits_ref);
			return p_AC_NamedBits_ref;
		}

		//
		// create syntax tree node associated with production
		// AC-NamedBits: AC-NamedBits "," AC-NamedBit Left

		//

		public AC_NamedBits AC_NamedBits_2 (AC_NamedBits p_AC_NamedBits, SyntaxTreeToken p_token, AC_NamedBit p_AC_NamedBit)
		{
			AC_NamedBits p_AC_NamedBits_ref = new AC_NamedBits(p_AC_NamedBits, p_token, p_AC_NamedBit);
			p_AC_NamedBits.parent = p_AC_NamedBits_ref;
			p_token.parent = p_AC_NamedBits_ref;
			p_AC_NamedBit.parent = p_AC_NamedBits_ref;
			Raise_AC_NamedBits_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_NamedBits.production_kind.g_AC_NamedBits_2, p_AC_NamedBits_ref);
			return p_AC_NamedBits_ref;
		}
		#endregion
	};
}
