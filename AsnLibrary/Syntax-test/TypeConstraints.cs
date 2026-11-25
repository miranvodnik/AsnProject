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
	// class associated with syntax rule TypeConstraints
	//

	[DataContract]
	public class	TypeConstraints : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TypeConstraints
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TypeConstraints
		{
			g_TypeConstraints_1 = 1,	// NamedConstraint

			g_TypeConstraints_2 = 2,	// TypeConstraints "," NamedConstraint Left

		};
		#endregion
		#region production markers associated with the syntax rule TypeConstraints

		// markers associated with production: TypeConstraints -> NamedConstraint

		public enum production_marker_1 : ushort
		{
			m_NamedConstraint,
			final
		};

		// markers associated with production: TypeConstraints -> TypeConstraints "," NamedConstraint Left

		public enum production_marker_2 : ushort
		{
			m_TypeConstraints,
			m_NamedConstraint,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TypeConstraints

		// Constructor declaration(s) associated with production(s) of syntax rule TypeConstraints

		//
		// Constructor associated with the following production(s)
		// TypeConstraints -> NamedConstraint

		//

		public TypeConstraints (NamedConstraint p_NamedConstraint) : base ((uint) ProductionID._TypeConstraints_ID, (uint) production_kind.g_TypeConstraints_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NamedConstraint = p_NamedConstraint;
		}

		//
		// Constructor associated with the following production(s)
		// TypeConstraints -> TypeConstraints "," NamedConstraint Left

		//

		public TypeConstraints (TypeConstraints p_TypeConstraints, SyntaxTreeToken p_token, NamedConstraint p_NamedConstraint) : base ((uint) ProductionID._TypeConstraints_ID, (uint) production_kind.g_TypeConstraints_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_TypeConstraints = p_TypeConstraints;
			children[1] = m_comma = p_token;
			children[2] = m_NamedConstraint = p_NamedConstraint;
		}

		public TypeConstraints () { }

		// Copy constructor

		public TypeConstraints (TypeConstraints p_TypeConstraints) : base (p_TypeConstraints.id, p_TypeConstraints.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TypeConstraints.appInfo;
			switch ((production_kind) p_TypeConstraints.kind)
			{
				case production_kind.g_TypeConstraints_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NamedConstraint = (p_TypeConstraints.m_NamedConstraint != null) ? new NamedConstraint (p_TypeConstraints.m_NamedConstraint) : null) != null) m_NamedConstraint.parent = this;
					break;
				case production_kind.g_TypeConstraints_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_TypeConstraints = (p_TypeConstraints.m_TypeConstraints != null) ? new TypeConstraints (p_TypeConstraints.m_TypeConstraints) : null) != null) m_TypeConstraints.parent = this;
					if ((children [1] = m_comma = (p_TypeConstraints.m_comma != null) ? new SyntaxTreeToken (p_TypeConstraints.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_NamedConstraint = (p_TypeConstraints.m_NamedConstraint != null) ? new NamedConstraint (p_TypeConstraints.m_NamedConstraint) : null) != null) m_NamedConstraint.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TypeConstraints" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TypeConstraints (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_NamedConstraint?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TypeConstraints

		// Content changing function(s) associated with production(s) of syntax rule TypeConstraints

		//
		// Content changing function associated with following production(s)
		// TypeConstraints -> NamedConstraint

		//

		public void change(NamedConstraint p_NamedConstraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_TypeConstraints_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NamedConstraint = p_NamedConstraint;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TypeConstraints -> TypeConstraints "," NamedConstraint Left

		//

		public void change(TypeConstraints p_TypeConstraints, SyntaxTreeToken p_token, NamedConstraint p_NamedConstraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_TypeConstraints_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_TypeConstraints = p_TypeConstraints;
			children [1] = m_comma = p_token;
			children [2] = m_NamedConstraint = p_NamedConstraint;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TypeConstraints
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_NamedConstraint != null) && node.m_NamedConstraint.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TypeConstraints

		//
		// emit production tree node associated with any production of syntax rule TypeConstraints
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_TypeConstraints_1:
						// emit syntax tree node associated with production
						// TypeConstraints: NamedConstraint

						s += " " + node.m_NamedConstraint.Emit (depth - 1);
						break;
					case production_kind.g_TypeConstraints_2:
						// emit syntax tree node associated with production
						// TypeConstraints: TypeConstraints "," NamedConstraint Left

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_NamedConstraint.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TypeConstraints
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "TypeConstraints (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_TypeConstraints_1:
						// emit syntax tree node associated with production
						// TypeConstraints: NamedConstraint

						str += node.m_NamedConstraint.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_TypeConstraints_2:
						// emit syntax tree node associated with production
						// TypeConstraints: TypeConstraints "," NamedConstraint Left

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_NamedConstraint.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TypeConstraints

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TypeConstraints with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					TypeConstraints.production_kind kind = (TypeConstraints.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case TypeConstraints.production_kind.g_TypeConstraints_1:
							// traverse syntax tree node associated with production
							// TypeConstraints: NamedConstraint

							node.m_NamedConstraint.Visit (visitor, appData);
							break;
						case TypeConstraints.production_kind.g_TypeConstraints_2:
							// traverse syntax tree node associated with production
							// TypeConstraints: TypeConstraints "," NamedConstraint Left

							node.m_comma.Visit (visitor, appData);
							node.m_NamedConstraint.Visit (visitor, appData);
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
			for (TypeConstraints node = this; node != null; node = node.m_TypeConstraints)
			{
				node.parent = parent;
				node.m_NamedConstraint?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule TypeConstraints
		//

		public void _init ()
		{
			m_NamedConstraint = null;
			m_TypeConstraints = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (TypeConstraints p_TypeConstraints, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<TypeConstraints> stack = new Stack<TypeConstraints> ();
			TypeConstraints p_TypeConstraints;
			for (p_TypeConstraints = this; p_TypeConstraints != null; p_TypeConstraints = p_TypeConstraints.m_TypeConstraints)
				stack.Push (p_TypeConstraints);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TypeConstraints

		// counter of all nodes associated with syntax rule TypeConstraints
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TypeConstraints
		[DataMember (Name = "m_NamedConstraint")] public NamedConstraint m_NamedConstraint { get; private set; }
		[DataMember (Name = "m_TypeConstraints")] public TypeConstraints m_TypeConstraints { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TypeConstraints

		// delegate function (callback) prototype associated with syntax rule TypeConstraints
		public delegate bool TypeConstraints_Callback (SyntaxTreeCallbackReason reason, TypeConstraints.production_kind kind, TypeConstraints p_TypeConstraints);

		// event associated with syntax rule TypeConstraints
		public event TypeConstraints_Callback TypeConstraints_Event;

		// event trigger associated with syntax rule TypeConstraints
		public bool Raise_TypeConstraints_Event (SyntaxTreeCallbackReason reason, TypeConstraints.production_kind kind, TypeConstraints p_TypeConstraints)
		{
			bool? status = TypeConstraints_Event?.Invoke (reason, kind, p_TypeConstraints);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TypeConstraints
		//
		// traverse syntax tree node associated with any production of syntax rule TypeConstraints
		//

		public void Traverse (TypeConstraints p_TypeConstraints)
		{
			if (p_TypeConstraints.isLocked())
				return;
			if (Raise_TypeConstraints_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (TypeConstraints.production_kind) p_TypeConstraints.kind, p_TypeConstraints))
				p_TypeConstraints.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					TypeConstraints.production_kind kind = (TypeConstraints.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_TypeConstraints_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case TypeConstraints.production_kind.g_TypeConstraints_1:
								// traverse syntax tree node associated with production
								// TypeConstraints: NamedConstraint

								if (Raise_TypeConstraints_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_NamedConstraint);
								node.turn_inc ();
								Raise_TypeConstraints_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case TypeConstraints.production_kind.g_TypeConstraints_2:
								// traverse syntax tree node associated with production
								// TypeConstraints: TypeConstraints "," NamedConstraint Left

								if (Raise_TypeConstraints_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_TypeConstraints_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_NamedConstraint);
								node.turn_inc ();
								Raise_TypeConstraints_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_TypeConstraints_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_TypeConstraints_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (TypeConstraints.production_kind) p_TypeConstraints.kind, p_TypeConstraints);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TypeConstraints
		//

		public void TraverseCommon (TypeConstraints p_TypeConstraints)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_TypeConstraints.kind, p_TypeConstraints))
				p_TypeConstraints.Iterate (null, (node, appData) =>
				{
					TypeConstraints.production_kind kind = (TypeConstraints.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case TypeConstraints.production_kind.g_TypeConstraints_1:
							// traverse syntax tree node associated with production
							// TypeConstraints: NamedConstraint

							TraverseCommon (node.m_NamedConstraint);
							break;
						case TypeConstraints.production_kind.g_TypeConstraints_2:
							// traverse syntax tree node associated with production
							// TypeConstraints: TypeConstraints "," NamedConstraint Left

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_NamedConstraint);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_TypeConstraints.kind, p_TypeConstraints);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TypeConstraints

		//
		// create syntax tree node associated with production
		// TypeConstraints: NamedConstraint

		//

		public TypeConstraints TypeConstraints_1 (NamedConstraint p_NamedConstraint)
		{
			TypeConstraints p_TypeConstraints_ref = new TypeConstraints(p_NamedConstraint);
			p_NamedConstraint.parent = p_TypeConstraints_ref;
			Raise_TypeConstraints_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeConstraints.production_kind.g_TypeConstraints_1, p_TypeConstraints_ref);
			return p_TypeConstraints_ref;
		}

		//
		// create syntax tree node associated with production
		// TypeConstraints: TypeConstraints "," NamedConstraint Left

		//

		public TypeConstraints TypeConstraints_2 (TypeConstraints p_TypeConstraints, SyntaxTreeToken p_token, NamedConstraint p_NamedConstraint)
		{
			TypeConstraints p_TypeConstraints_ref = new TypeConstraints(p_TypeConstraints, p_token, p_NamedConstraint);
			p_TypeConstraints.parent = p_TypeConstraints_ref;
			p_token.parent = p_TypeConstraints_ref;
			p_NamedConstraint.parent = p_TypeConstraints_ref;
			Raise_TypeConstraints_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeConstraints.production_kind.g_TypeConstraints_2, p_TypeConstraints_ref);
			return p_TypeConstraints_ref;
		}
		#endregion
	};
}
