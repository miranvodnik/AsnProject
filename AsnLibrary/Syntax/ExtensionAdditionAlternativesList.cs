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
	// class associated with syntax rule ExtensionAdditionAlternativesList
	//

	[DataContract]
	public class	ExtensionAdditionAlternativesList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExtensionAdditionAlternativesList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExtensionAdditionAlternativesList
		{
			g_ExtensionAdditionAlternativesList_1 = 1,	// ExtensionAdditionAlternative

			g_ExtensionAdditionAlternativesList_2 = 2,	// ExtensionAdditionAlternativesList "," ExtensionAdditionAlternative

		};
		#endregion
		#region production markers associated with the syntax rule ExtensionAdditionAlternativesList

		// markers associated with production: ExtensionAdditionAlternativesList -> ExtensionAdditionAlternative

		public enum production_marker_1 : ushort
		{
			m_ExtensionAdditionAlternative,
			final
		};

		// markers associated with production: ExtensionAdditionAlternativesList -> ExtensionAdditionAlternativesList "," ExtensionAdditionAlternative

		public enum production_marker_2 : ushort
		{
			m_ExtensionAdditionAlternativesList,
			m_ExtensionAdditionAlternative,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExtensionAdditionAlternativesList

		// Constructor declaration(s) associated with production(s) of syntax rule ExtensionAdditionAlternativesList

		//
		// Constructor associated with the following production(s)
		// ExtensionAdditionAlternativesList -> ExtensionAdditionAlternative

		//

		public ExtensionAdditionAlternativesList (ExtensionAdditionAlternative p_ExtensionAdditionAlternative) : base ((uint) ProductionID._ExtensionAdditionAlternativesList_ID, (uint) production_kind.g_ExtensionAdditionAlternativesList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ExtensionAdditionAlternative = p_ExtensionAdditionAlternative;
		}

		//
		// Constructor associated with the following production(s)
		// ExtensionAdditionAlternativesList -> ExtensionAdditionAlternativesList "," ExtensionAdditionAlternative

		//

		public ExtensionAdditionAlternativesList (ExtensionAdditionAlternativesList p_ExtensionAdditionAlternativesList, SyntaxTreeToken p_token, ExtensionAdditionAlternative p_ExtensionAdditionAlternative) : base ((uint) ProductionID._ExtensionAdditionAlternativesList_ID, (uint) production_kind.g_ExtensionAdditionAlternativesList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_ExtensionAdditionAlternativesList = p_ExtensionAdditionAlternativesList;
			children[1] = m_comma = p_token;
			children[2] = m_ExtensionAdditionAlternative = p_ExtensionAdditionAlternative;
		}

		public ExtensionAdditionAlternativesList () { }

		// Copy constructor

		public ExtensionAdditionAlternativesList (ExtensionAdditionAlternativesList p_ExtensionAdditionAlternativesList) : base (p_ExtensionAdditionAlternativesList.id, p_ExtensionAdditionAlternativesList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExtensionAdditionAlternativesList.appInfo;
			switch ((production_kind) p_ExtensionAdditionAlternativesList.kind)
			{
				case production_kind.g_ExtensionAdditionAlternativesList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ExtensionAdditionAlternative = (p_ExtensionAdditionAlternativesList.m_ExtensionAdditionAlternative != null) ? new ExtensionAdditionAlternative (p_ExtensionAdditionAlternativesList.m_ExtensionAdditionAlternative) : null) != null) m_ExtensionAdditionAlternative.parent = this;
					break;
				case production_kind.g_ExtensionAdditionAlternativesList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_ExtensionAdditionAlternativesList = (p_ExtensionAdditionAlternativesList.m_ExtensionAdditionAlternativesList != null) ? new ExtensionAdditionAlternativesList (p_ExtensionAdditionAlternativesList.m_ExtensionAdditionAlternativesList) : null) != null) m_ExtensionAdditionAlternativesList.parent = this;
					if ((children [1] = m_comma = (p_ExtensionAdditionAlternativesList.m_comma != null) ? new SyntaxTreeToken (p_ExtensionAdditionAlternativesList.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_ExtensionAdditionAlternative = (p_ExtensionAdditionAlternativesList.m_ExtensionAdditionAlternative != null) ? new ExtensionAdditionAlternative (p_ExtensionAdditionAlternativesList.m_ExtensionAdditionAlternative) : null) != null) m_ExtensionAdditionAlternative.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ExtensionAdditionAlternativesList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExtensionAdditionAlternativesList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_ExtensionAdditionAlternative?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExtensionAdditionAlternativesList

		// Content changing function(s) associated with production(s) of syntax rule ExtensionAdditionAlternativesList

		//
		// Content changing function associated with following production(s)
		// ExtensionAdditionAlternativesList -> ExtensionAdditionAlternative

		//

		public void change(ExtensionAdditionAlternative p_ExtensionAdditionAlternative)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExtensionAdditionAlternativesList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ExtensionAdditionAlternative = p_ExtensionAdditionAlternative;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ExtensionAdditionAlternativesList -> ExtensionAdditionAlternativesList "," ExtensionAdditionAlternative

		//

		public void change(ExtensionAdditionAlternativesList p_ExtensionAdditionAlternativesList, SyntaxTreeToken p_token, ExtensionAdditionAlternative p_ExtensionAdditionAlternative)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExtensionAdditionAlternativesList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_ExtensionAdditionAlternativesList = p_ExtensionAdditionAlternativesList;
			children [1] = m_comma = p_token;
			children [2] = m_ExtensionAdditionAlternative = p_ExtensionAdditionAlternative;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExtensionAdditionAlternativesList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_ExtensionAdditionAlternative != null) && node.m_ExtensionAdditionAlternative.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExtensionAdditionAlternativesList

		//
		// emit production tree node associated with any production of syntax rule ExtensionAdditionAlternativesList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_ExtensionAdditionAlternativesList_1:
						// emit syntax tree node associated with production
						// ExtensionAdditionAlternativesList: ExtensionAdditionAlternative

						s += " " + node.m_ExtensionAdditionAlternative.Emit (depth - 1);
						break;
					case production_kind.g_ExtensionAdditionAlternativesList_2:
						// emit syntax tree node associated with production
						// ExtensionAdditionAlternativesList: ExtensionAdditionAlternativesList "," ExtensionAdditionAlternative

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_ExtensionAdditionAlternative.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExtensionAdditionAlternativesList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "ExtensionAdditionAlternativesList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_ExtensionAdditionAlternativesList_1:
						// emit syntax tree node associated with production
						// ExtensionAdditionAlternativesList: ExtensionAdditionAlternative

						str += node.m_ExtensionAdditionAlternative.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_ExtensionAdditionAlternativesList_2:
						// emit syntax tree node associated with production
						// ExtensionAdditionAlternativesList: ExtensionAdditionAlternativesList "," ExtensionAdditionAlternative

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_ExtensionAdditionAlternative.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExtensionAdditionAlternativesList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditionAlternativesList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					ExtensionAdditionAlternativesList.production_kind kind = (ExtensionAdditionAlternativesList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case ExtensionAdditionAlternativesList.production_kind.g_ExtensionAdditionAlternativesList_1:
							// traverse syntax tree node associated with production
							// ExtensionAdditionAlternativesList: ExtensionAdditionAlternative

							node.m_ExtensionAdditionAlternative.Visit (visitor, appData);
							break;
						case ExtensionAdditionAlternativesList.production_kind.g_ExtensionAdditionAlternativesList_2:
							// traverse syntax tree node associated with production
							// ExtensionAdditionAlternativesList: ExtensionAdditionAlternativesList "," ExtensionAdditionAlternative

							node.m_comma.Visit (visitor, appData);
							node.m_ExtensionAdditionAlternative.Visit (visitor, appData);
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
			for (ExtensionAdditionAlternativesList node = this; node != null; node = node.m_ExtensionAdditionAlternativesList)
			{
				node.parent = parent;
				node.m_ExtensionAdditionAlternative?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule ExtensionAdditionAlternativesList
		//

		public void _init ()
		{
			m_ExtensionAdditionAlternative = null;
			m_ExtensionAdditionAlternativesList = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (ExtensionAdditionAlternativesList p_ExtensionAdditionAlternativesList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<ExtensionAdditionAlternativesList> stack = new Stack<ExtensionAdditionAlternativesList> ();
			ExtensionAdditionAlternativesList p_ExtensionAdditionAlternativesList;
			for (p_ExtensionAdditionAlternativesList = this; p_ExtensionAdditionAlternativesList != null; p_ExtensionAdditionAlternativesList = p_ExtensionAdditionAlternativesList.m_ExtensionAdditionAlternativesList)
				stack.Push (p_ExtensionAdditionAlternativesList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExtensionAdditionAlternativesList

		// counter of all nodes associated with syntax rule ExtensionAdditionAlternativesList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExtensionAdditionAlternativesList
		[DataMember (Name = "m_ExtensionAdditionAlternative")] public ExtensionAdditionAlternative m_ExtensionAdditionAlternative { get; private set; }
		[DataMember (Name = "m_ExtensionAdditionAlternativesList")] public ExtensionAdditionAlternativesList m_ExtensionAdditionAlternativesList { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExtensionAdditionAlternativesList

		// delegate function (callback) prototype associated with syntax rule ExtensionAdditionAlternativesList
		public delegate bool ExtensionAdditionAlternativesList_Callback (SyntaxTreeCallbackReason reason, ExtensionAdditionAlternativesList.production_kind kind, ExtensionAdditionAlternativesList p_ExtensionAdditionAlternativesList);

		// event associated with syntax rule ExtensionAdditionAlternativesList
		public event ExtensionAdditionAlternativesList_Callback ExtensionAdditionAlternativesList_Event;

		// event trigger associated with syntax rule ExtensionAdditionAlternativesList
		public bool Raise_ExtensionAdditionAlternativesList_Event (SyntaxTreeCallbackReason reason, ExtensionAdditionAlternativesList.production_kind kind, ExtensionAdditionAlternativesList p_ExtensionAdditionAlternativesList)
		{
			bool? status = ExtensionAdditionAlternativesList_Event?.Invoke (reason, kind, p_ExtensionAdditionAlternativesList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExtensionAdditionAlternativesList
		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditionAlternativesList
		//

		public void Traverse (ExtensionAdditionAlternativesList p_ExtensionAdditionAlternativesList)
		{
			if (p_ExtensionAdditionAlternativesList.isLocked())
				return;
			if (Raise_ExtensionAdditionAlternativesList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (ExtensionAdditionAlternativesList.production_kind) p_ExtensionAdditionAlternativesList.kind, p_ExtensionAdditionAlternativesList))
				p_ExtensionAdditionAlternativesList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					ExtensionAdditionAlternativesList.production_kind kind = (ExtensionAdditionAlternativesList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_ExtensionAdditionAlternativesList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case ExtensionAdditionAlternativesList.production_kind.g_ExtensionAdditionAlternativesList_1:
								// traverse syntax tree node associated with production
								// ExtensionAdditionAlternativesList: ExtensionAdditionAlternative

								if (Raise_ExtensionAdditionAlternativesList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_ExtensionAdditionAlternative);
								node.turn_inc ();
								Raise_ExtensionAdditionAlternativesList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case ExtensionAdditionAlternativesList.production_kind.g_ExtensionAdditionAlternativesList_2:
								// traverse syntax tree node associated with production
								// ExtensionAdditionAlternativesList: ExtensionAdditionAlternativesList "," ExtensionAdditionAlternative

								if (Raise_ExtensionAdditionAlternativesList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_ExtensionAdditionAlternativesList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_ExtensionAdditionAlternative);
								node.turn_inc ();
								Raise_ExtensionAdditionAlternativesList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_ExtensionAdditionAlternativesList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_ExtensionAdditionAlternativesList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (ExtensionAdditionAlternativesList.production_kind) p_ExtensionAdditionAlternativesList.kind, p_ExtensionAdditionAlternativesList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditionAlternativesList
		//

		public void TraverseCommon (ExtensionAdditionAlternativesList p_ExtensionAdditionAlternativesList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_ExtensionAdditionAlternativesList.kind, p_ExtensionAdditionAlternativesList))
				p_ExtensionAdditionAlternativesList.Iterate (null, (node, appData) =>
				{
					ExtensionAdditionAlternativesList.production_kind kind = (ExtensionAdditionAlternativesList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case ExtensionAdditionAlternativesList.production_kind.g_ExtensionAdditionAlternativesList_1:
							// traverse syntax tree node associated with production
							// ExtensionAdditionAlternativesList: ExtensionAdditionAlternative

							TraverseCommon (node.m_ExtensionAdditionAlternative);
							break;
						case ExtensionAdditionAlternativesList.production_kind.g_ExtensionAdditionAlternativesList_2:
							// traverse syntax tree node associated with production
							// ExtensionAdditionAlternativesList: ExtensionAdditionAlternativesList "," ExtensionAdditionAlternative

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_ExtensionAdditionAlternative);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_ExtensionAdditionAlternativesList.kind, p_ExtensionAdditionAlternativesList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExtensionAdditionAlternativesList

		//
		// create syntax tree node associated with production
		// ExtensionAdditionAlternativesList: ExtensionAdditionAlternative

		//

		public ExtensionAdditionAlternativesList ExtensionAdditionAlternativesList_1 (ExtensionAdditionAlternative p_ExtensionAdditionAlternative)
		{
			ExtensionAdditionAlternativesList p_ExtensionAdditionAlternativesList_ref = new ExtensionAdditionAlternativesList(p_ExtensionAdditionAlternative);
			p_ExtensionAdditionAlternative.parent = p_ExtensionAdditionAlternativesList_ref;
			Raise_ExtensionAdditionAlternativesList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExtensionAdditionAlternativesList.production_kind.g_ExtensionAdditionAlternativesList_1, p_ExtensionAdditionAlternativesList_ref);
			return p_ExtensionAdditionAlternativesList_ref;
		}

		//
		// create syntax tree node associated with production
		// ExtensionAdditionAlternativesList: ExtensionAdditionAlternativesList "," ExtensionAdditionAlternative

		//

		public ExtensionAdditionAlternativesList ExtensionAdditionAlternativesList_2 (ExtensionAdditionAlternativesList p_ExtensionAdditionAlternativesList, SyntaxTreeToken p_token, ExtensionAdditionAlternative p_ExtensionAdditionAlternative)
		{
			ExtensionAdditionAlternativesList p_ExtensionAdditionAlternativesList_ref = new ExtensionAdditionAlternativesList(p_ExtensionAdditionAlternativesList, p_token, p_ExtensionAdditionAlternative);
			p_ExtensionAdditionAlternativesList.parent = p_ExtensionAdditionAlternativesList_ref;
			p_token.parent = p_ExtensionAdditionAlternativesList_ref;
			p_ExtensionAdditionAlternative.parent = p_ExtensionAdditionAlternativesList_ref;
			Raise_ExtensionAdditionAlternativesList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExtensionAdditionAlternativesList.production_kind.g_ExtensionAdditionAlternativesList_2, p_ExtensionAdditionAlternativesList_ref);
			return p_ExtensionAdditionAlternativesList_ref;
		}
		#endregion
	};
}
