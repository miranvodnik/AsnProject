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
	// class associated with syntax rule AC-BitNames
	//

	[DataContract]
	public class	AC_BitNames : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-BitNames
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-BitNames
		{
			g_AC_BitNames_1 = 1,	// AC-BitName

			g_AC_BitNames_2 = 2,	// AC-BitNames "," AC-BitName Left

		};
		#endregion
		#region production markers associated with the syntax rule AC-BitNames

		// markers associated with production: AC-BitNames -> AC-BitName

		public enum production_marker_1 : ushort
		{
			m_AC_BitName,
			final
		};

		// markers associated with production: AC-BitNames -> AC-BitNames "," AC-BitName Left

		public enum production_marker_2 : ushort
		{
			m_AC_BitNames,
			m_AC_BitName,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-BitNames

		// Constructor declaration(s) associated with production(s) of syntax rule AC-BitNames

		//
		// Constructor associated with the following production(s)
		// AC-BitNames -> AC-BitName

		//

		public AC_BitNames (AC_BitName p_AC_BitName) : base ((uint) ProductionID._AC_BitNames_ID, (uint) production_kind.g_AC_BitNames_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_AC_BitName = p_AC_BitName;
		}

		//
		// Constructor associated with the following production(s)
		// AC-BitNames -> AC-BitNames "," AC-BitName Left

		//

		public AC_BitNames (AC_BitNames p_AC_BitNames, SyntaxTreeToken p_token, AC_BitName p_AC_BitName) : base ((uint) ProductionID._AC_BitNames_ID, (uint) production_kind.g_AC_BitNames_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_AC_BitNames = p_AC_BitNames;
			children[1] = m_comma = p_token;
			children[2] = m_AC_BitName = p_AC_BitName;
		}

		public AC_BitNames () { }

		// Copy constructor

		public AC_BitNames (AC_BitNames p_AC_BitNames) : base (p_AC_BitNames.id, p_AC_BitNames.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_BitNames.appInfo;
			switch ((production_kind) p_AC_BitNames.kind)
			{
				case production_kind.g_AC_BitNames_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_AC_BitName = (p_AC_BitNames.m_AC_BitName != null) ? new AC_BitName (p_AC_BitNames.m_AC_BitName) : null) != null) m_AC_BitName.parent = this;
					break;
				case production_kind.g_AC_BitNames_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_AC_BitNames = (p_AC_BitNames.m_AC_BitNames != null) ? new AC_BitNames (p_AC_BitNames.m_AC_BitNames) : null) != null) m_AC_BitNames.parent = this;
					if ((children [1] = m_comma = (p_AC_BitNames.m_comma != null) ? new SyntaxTreeToken (p_AC_BitNames.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_AC_BitName = (p_AC_BitNames.m_AC_BitName != null) ? new AC_BitName (p_AC_BitNames.m_AC_BitName) : null) != null) m_AC_BitName.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AC_BitNames" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_BitNames (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_AC_BitName?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-BitNames

		// Content changing function(s) associated with production(s) of syntax rule AC-BitNames

		//
		// Content changing function associated with following production(s)
		// AC-BitNames -> AC-BitName

		//

		public void change(AC_BitName p_AC_BitName)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_BitNames_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_AC_BitName = p_AC_BitName;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AC-BitNames -> AC-BitNames "," AC-BitName Left

		//

		public void change(AC_BitNames p_AC_BitNames, SyntaxTreeToken p_token, AC_BitName p_AC_BitName)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_BitNames_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_AC_BitNames = p_AC_BitNames;
			children [1] = m_comma = p_token;
			children [2] = m_AC_BitName = p_AC_BitName;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-BitNames
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_AC_BitName != null) && node.m_AC_BitName.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-BitNames

		//
		// emit production tree node associated with any production of syntax rule AC-BitNames
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_AC_BitNames_1:
						// emit syntax tree node associated with production
						// AC-BitNames: AC-BitName

						s += " " + node.m_AC_BitName.Emit (depth - 1);
						break;
					case production_kind.g_AC_BitNames_2:
						// emit syntax tree node associated with production
						// AC-BitNames: AC-BitNames "," AC-BitName Left

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_AC_BitName.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-BitNames
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "AC_BitNames (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_AC_BitNames_1:
						// emit syntax tree node associated with production
						// AC-BitNames: AC-BitName

						str += node.m_AC_BitName.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_AC_BitNames_2:
						// emit syntax tree node associated with production
						// AC-BitNames: AC-BitNames "," AC-BitName Left

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_AC_BitName.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-BitNames

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-BitNames with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					AC_BitNames.production_kind kind = (AC_BitNames.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case AC_BitNames.production_kind.g_AC_BitNames_1:
							// traverse syntax tree node associated with production
							// AC-BitNames: AC-BitName

							node.m_AC_BitName.Visit (visitor, appData);
							break;
						case AC_BitNames.production_kind.g_AC_BitNames_2:
							// traverse syntax tree node associated with production
							// AC-BitNames: AC-BitNames "," AC-BitName Left

							node.m_comma.Visit (visitor, appData);
							node.m_AC_BitName.Visit (visitor, appData);
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
			for (AC_BitNames node = this; node != null; node = node.m_AC_BitNames)
			{
				node.parent = parent;
				node.m_AC_BitName?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule AC-BitNames
		//

		public void _init ()
		{
			m_AC_BitName = null;
			m_AC_BitNames = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (AC_BitNames p_AC_BitNames, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<AC_BitNames> stack = new Stack<AC_BitNames> ();
			AC_BitNames p_AC_BitNames;
			for (p_AC_BitNames = this; p_AC_BitNames != null; p_AC_BitNames = p_AC_BitNames.m_AC_BitNames)
				stack.Push (p_AC_BitNames);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-BitNames

		// counter of all nodes associated with syntax rule AC-BitNames
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-BitNames
		[DataMember (Name = "m_AC_BitName")] public AC_BitName m_AC_BitName { get; private set; }
		[DataMember (Name = "m_AC_BitNames")] public AC_BitNames m_AC_BitNames { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-BitNames

		// delegate function (callback) prototype associated with syntax rule AC-BitNames
		public delegate bool AC_BitNames_Callback (SyntaxTreeCallbackReason reason, AC_BitNames.production_kind kind, AC_BitNames p_AC_BitNames);

		// event associated with syntax rule AC-BitNames
		public event AC_BitNames_Callback AC_BitNames_Event;

		// event trigger associated with syntax rule AC-BitNames
		public bool Raise_AC_BitNames_Event (SyntaxTreeCallbackReason reason, AC_BitNames.production_kind kind, AC_BitNames p_AC_BitNames)
		{
			bool? status = AC_BitNames_Event?.Invoke (reason, kind, p_AC_BitNames);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-BitNames
		//
		// traverse syntax tree node associated with any production of syntax rule AC-BitNames
		//

		public void Traverse (AC_BitNames p_AC_BitNames)
		{
			if (p_AC_BitNames.isLocked())
				return;
			if (Raise_AC_BitNames_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (AC_BitNames.production_kind) p_AC_BitNames.kind, p_AC_BitNames))
				p_AC_BitNames.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					AC_BitNames.production_kind kind = (AC_BitNames.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_AC_BitNames_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case AC_BitNames.production_kind.g_AC_BitNames_1:
								// traverse syntax tree node associated with production
								// AC-BitNames: AC-BitName

								if (Raise_AC_BitNames_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_AC_BitName);
								node.turn_inc ();
								Raise_AC_BitNames_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case AC_BitNames.production_kind.g_AC_BitNames_2:
								// traverse syntax tree node associated with production
								// AC-BitNames: AC-BitNames "," AC-BitName Left

								if (Raise_AC_BitNames_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_AC_BitNames_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_AC_BitName);
								node.turn_inc ();
								Raise_AC_BitNames_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_AC_BitNames_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_AC_BitNames_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (AC_BitNames.production_kind) p_AC_BitNames.kind, p_AC_BitNames);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-BitNames
		//

		public void TraverseCommon (AC_BitNames p_AC_BitNames)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_AC_BitNames.kind, p_AC_BitNames))
				p_AC_BitNames.Iterate (null, (node, appData) =>
				{
					AC_BitNames.production_kind kind = (AC_BitNames.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case AC_BitNames.production_kind.g_AC_BitNames_1:
							// traverse syntax tree node associated with production
							// AC-BitNames: AC-BitName

							TraverseCommon (node.m_AC_BitName);
							break;
						case AC_BitNames.production_kind.g_AC_BitNames_2:
							// traverse syntax tree node associated with production
							// AC-BitNames: AC-BitNames "," AC-BitName Left

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_AC_BitName);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_AC_BitNames.kind, p_AC_BitNames);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-BitNames

		//
		// create syntax tree node associated with production
		// AC-BitNames: AC-BitName

		//

		public AC_BitNames AC_BitNames_1 (AC_BitName p_AC_BitName)
		{
			AC_BitNames p_AC_BitNames_ref = new AC_BitNames(p_AC_BitName);
			p_AC_BitName.parent = p_AC_BitNames_ref;
			Raise_AC_BitNames_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_BitNames.production_kind.g_AC_BitNames_1, p_AC_BitNames_ref);
			return p_AC_BitNames_ref;
		}

		//
		// create syntax tree node associated with production
		// AC-BitNames: AC-BitNames "," AC-BitName Left

		//

		public AC_BitNames AC_BitNames_2 (AC_BitNames p_AC_BitNames, SyntaxTreeToken p_token, AC_BitName p_AC_BitName)
		{
			AC_BitNames p_AC_BitNames_ref = new AC_BitNames(p_AC_BitNames, p_token, p_AC_BitName);
			p_AC_BitNames.parent = p_AC_BitNames_ref;
			p_token.parent = p_AC_BitNames_ref;
			p_AC_BitName.parent = p_AC_BitNames_ref;
			Raise_AC_BitNames_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_BitNames.production_kind.g_AC_BitNames_2, p_AC_BitNames_ref);
			return p_AC_BitNames_ref;
		}
		#endregion
	};
}
