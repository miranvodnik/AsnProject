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
	// class associated with syntax rule MacroAssignment
	//

	[DataContract]
	public class	MacroAssignment : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MacroAssignment
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MacroAssignment
		{
			g_MacroAssignment_1 = 1,	// valuereference-token ModuleIdentityMacro "::=" ObjectIdentifierValue

			g_MacroAssignment_2 = 2,	// valuereference-token ObjectIdentityMacro "::=" ObjectIdentifierValue

			g_MacroAssignment_3 = 3,	// valuereference-token ObjectTypeMacro "::=" ObjectIdentifierValue

			g_MacroAssignment_4 = 4,	// valuereference-token NotificationTypeMacro "::=" ObjectIdentifierValue

			g_MacroAssignment_5 = 5,	// valuereference-token TextualConventionMacro "::=" ObjectIdentifierValue

			g_MacroAssignment_6 = 6,	// valuereference-token ObjectGroupMacro "::=" ObjectIdentifierValue

			g_MacroAssignment_7 = 7,	// valuereference-token NotificationGroupMacro "::=" ObjectIdentifierValue

			g_MacroAssignment_8 = 8,	// valuereference-token ModuleComplianceMacro "::=" ObjectIdentifierValue

			g_MacroAssignment_9 = 9,	// valuereference-token AgentCapabilitiesMacro "::=" ObjectIdentifierValue

			g_MacroAssignment_10 = 10,	// valuereference-token TrapTypeMacro "::=" IntegerValue

			g_MacroAssignment_11 = 11,	// typereference-token "::=" ModuleIdentityMacro

			g_MacroAssignment_12 = 12,	// typereference-token "::=" ObjectIdentityMacro

			g_MacroAssignment_13 = 13,	// typereference-token "::=" ObjectTypeMacro

			g_MacroAssignment_14 = 14,	// typereference-token "::=" NotificationTypeMacro

			g_MacroAssignment_15 = 15,	// typereference-token "::=" TextualConventionMacro

			g_MacroAssignment_16 = 16,	// typereference-token "::=" ObjectGroupMacro

			g_MacroAssignment_17 = 17,	// typereference-token "::=" NotificationGroupMacro

			g_MacroAssignment_18 = 18,	// typereference-token "::=" ModuleComplianceMacro

			g_MacroAssignment_19 = 19,	// typereference-token "::=" AgentCapabilitiesMacro

			g_MacroAssignment_20 = 20,	// typereference-token "::=" TrapTypeMacro

		};
		#endregion
		#region production markers associated with the syntax rule MacroAssignment

		// markers associated with production: MacroAssignment -> valuereference-token ModuleIdentityMacro "::=" ObjectIdentifierValue

		public enum production_marker_1 : ushort
		{
			m_valuereference_token,
			m_ModuleIdentityMacro,
			m_ObjectIdentifierValue,
			final
		};

		// markers associated with production: MacroAssignment -> valuereference-token ObjectIdentityMacro "::=" ObjectIdentifierValue

		public enum production_marker_2 : ushort
		{
			m_valuereference_token,
			m_ObjectIdentityMacro,
			m_ObjectIdentifierValue,
			final
		};

		// markers associated with production: MacroAssignment -> valuereference-token ObjectTypeMacro "::=" ObjectIdentifierValue

		public enum production_marker_3 : ushort
		{
			m_valuereference_token,
			m_ObjectTypeMacro,
			m_ObjectIdentifierValue,
			final
		};

		// markers associated with production: MacroAssignment -> valuereference-token NotificationTypeMacro "::=" ObjectIdentifierValue

		public enum production_marker_4 : ushort
		{
			m_valuereference_token,
			m_NotificationTypeMacro,
			m_ObjectIdentifierValue,
			final
		};

		// markers associated with production: MacroAssignment -> valuereference-token TextualConventionMacro "::=" ObjectIdentifierValue

		public enum production_marker_5 : ushort
		{
			m_valuereference_token,
			m_TextualConventionMacro,
			m_ObjectIdentifierValue,
			final
		};

		// markers associated with production: MacroAssignment -> valuereference-token ObjectGroupMacro "::=" ObjectIdentifierValue

		public enum production_marker_6 : ushort
		{
			m_valuereference_token,
			m_ObjectGroupMacro,
			m_ObjectIdentifierValue,
			final
		};

		// markers associated with production: MacroAssignment -> valuereference-token NotificationGroupMacro "::=" ObjectIdentifierValue

		public enum production_marker_7 : ushort
		{
			m_valuereference_token,
			m_NotificationGroupMacro,
			m_ObjectIdentifierValue,
			final
		};

		// markers associated with production: MacroAssignment -> valuereference-token ModuleComplianceMacro "::=" ObjectIdentifierValue

		public enum production_marker_8 : ushort
		{
			m_valuereference_token,
			m_ModuleComplianceMacro,
			m_ObjectIdentifierValue,
			final
		};

		// markers associated with production: MacroAssignment -> valuereference-token AgentCapabilitiesMacro "::=" ObjectIdentifierValue

		public enum production_marker_9 : ushort
		{
			m_valuereference_token,
			m_AgentCapabilitiesMacro,
			m_ObjectIdentifierValue,
			final
		};

		// markers associated with production: MacroAssignment -> valuereference-token TrapTypeMacro "::=" IntegerValue

		public enum production_marker_10 : ushort
		{
			m_valuereference_token,
			m_TrapTypeMacro,
			m_IntegerValue,
			final
		};

		// markers associated with production: MacroAssignment -> typereference-token "::=" ModuleIdentityMacro

		public enum production_marker_11 : ushort
		{
			m_typereference_token,
			m_ModuleIdentityMacro,
			final
		};

		// markers associated with production: MacroAssignment -> typereference-token "::=" ObjectIdentityMacro

		public enum production_marker_12 : ushort
		{
			m_typereference_token,
			m_ObjectIdentityMacro,
			final
		};

		// markers associated with production: MacroAssignment -> typereference-token "::=" ObjectTypeMacro

		public enum production_marker_13 : ushort
		{
			m_typereference_token,
			m_ObjectTypeMacro,
			final
		};

		// markers associated with production: MacroAssignment -> typereference-token "::=" NotificationTypeMacro

		public enum production_marker_14 : ushort
		{
			m_typereference_token,
			m_NotificationTypeMacro,
			final
		};

		// markers associated with production: MacroAssignment -> typereference-token "::=" TextualConventionMacro

		public enum production_marker_15 : ushort
		{
			m_typereference_token,
			m_TextualConventionMacro,
			final
		};

		// markers associated with production: MacroAssignment -> typereference-token "::=" ObjectGroupMacro

		public enum production_marker_16 : ushort
		{
			m_typereference_token,
			m_ObjectGroupMacro,
			final
		};

		// markers associated with production: MacroAssignment -> typereference-token "::=" NotificationGroupMacro

		public enum production_marker_17 : ushort
		{
			m_typereference_token,
			m_NotificationGroupMacro,
			final
		};

		// markers associated with production: MacroAssignment -> typereference-token "::=" ModuleComplianceMacro

		public enum production_marker_18 : ushort
		{
			m_typereference_token,
			m_ModuleComplianceMacro,
			final
		};

		// markers associated with production: MacroAssignment -> typereference-token "::=" AgentCapabilitiesMacro

		public enum production_marker_19 : ushort
		{
			m_typereference_token,
			m_AgentCapabilitiesMacro,
			final
		};

		// markers associated with production: MacroAssignment -> typereference-token "::=" TrapTypeMacro

		public enum production_marker_20 : ushort
		{
			m_typereference_token,
			m_TrapTypeMacro,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MacroAssignment

		// Constructor declaration(s) associated with production(s) of syntax rule MacroAssignment

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> valuereference-token ModuleIdentityMacro "::=" ObjectIdentifierValue

		//

		public MacroAssignment (valuereference_token p_valuereference_token, ModuleIdentityMacro p_ModuleIdentityMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_valuereference_token = p_valuereference_token;
			children[1] = m_ModuleIdentityMacro = p_ModuleIdentityMacro;
			children[2] = m_assignment_sign = p_token;
			children[3] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
		}

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> valuereference-token ObjectIdentityMacro "::=" ObjectIdentifierValue

		//

		public MacroAssignment (valuereference_token p_valuereference_token, ObjectIdentityMacro p_ObjectIdentityMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_valuereference_token = p_valuereference_token;
			children[1] = m_ObjectIdentityMacro = p_ObjectIdentityMacro;
			children[2] = m_assignment_sign = p_token;
			children[3] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
		}

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> valuereference-token ObjectTypeMacro "::=" ObjectIdentifierValue

		//

		public MacroAssignment (valuereference_token p_valuereference_token, ObjectTypeMacro p_ObjectTypeMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_valuereference_token = p_valuereference_token;
			children[1] = m_ObjectTypeMacro = p_ObjectTypeMacro;
			children[2] = m_assignment_sign = p_token;
			children[3] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
		}

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> valuereference-token NotificationTypeMacro "::=" ObjectIdentifierValue

		//

		public MacroAssignment (valuereference_token p_valuereference_token, NotificationTypeMacro p_NotificationTypeMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_valuereference_token = p_valuereference_token;
			children[1] = m_NotificationTypeMacro = p_NotificationTypeMacro;
			children[2] = m_assignment_sign = p_token;
			children[3] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
		}

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> valuereference-token TextualConventionMacro "::=" ObjectIdentifierValue

		//

		public MacroAssignment (valuereference_token p_valuereference_token, TextualConventionMacro p_TextualConventionMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_5)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_valuereference_token = p_valuereference_token;
			children[1] = m_TextualConventionMacro = p_TextualConventionMacro;
			children[2] = m_assignment_sign = p_token;
			children[3] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
		}

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> valuereference-token ObjectGroupMacro "::=" ObjectIdentifierValue

		//

		public MacroAssignment (valuereference_token p_valuereference_token, ObjectGroupMacro p_ObjectGroupMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_6)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_valuereference_token = p_valuereference_token;
			children[1] = m_ObjectGroupMacro = p_ObjectGroupMacro;
			children[2] = m_assignment_sign = p_token;
			children[3] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
		}

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> valuereference-token NotificationGroupMacro "::=" ObjectIdentifierValue

		//

		public MacroAssignment (valuereference_token p_valuereference_token, NotificationGroupMacro p_NotificationGroupMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_7)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_valuereference_token = p_valuereference_token;
			children[1] = m_NotificationGroupMacro = p_NotificationGroupMacro;
			children[2] = m_assignment_sign = p_token;
			children[3] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
		}

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> valuereference-token ModuleComplianceMacro "::=" ObjectIdentifierValue

		//

		public MacroAssignment (valuereference_token p_valuereference_token, ModuleComplianceMacro p_ModuleComplianceMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_8)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_valuereference_token = p_valuereference_token;
			children[1] = m_ModuleComplianceMacro = p_ModuleComplianceMacro;
			children[2] = m_assignment_sign = p_token;
			children[3] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
		}

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> valuereference-token AgentCapabilitiesMacro "::=" ObjectIdentifierValue

		//

		public MacroAssignment (valuereference_token p_valuereference_token, AgentCapabilitiesMacro p_AgentCapabilitiesMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_9)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_valuereference_token = p_valuereference_token;
			children[1] = m_AgentCapabilitiesMacro = p_AgentCapabilitiesMacro;
			children[2] = m_assignment_sign = p_token;
			children[3] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
		}

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> valuereference-token TrapTypeMacro "::=" IntegerValue

		//

		public MacroAssignment (valuereference_token p_valuereference_token, TrapTypeMacro p_TrapTypeMacro, SyntaxTreeToken p_token, IntegerValue p_IntegerValue) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_10)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_valuereference_token = p_valuereference_token;
			children[1] = m_TrapTypeMacro = p_TrapTypeMacro;
			children[2] = m_assignment_sign = p_token;
			children[3] = m_IntegerValue = p_IntegerValue;
		}

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> typereference-token "::=" ModuleIdentityMacro

		//

		public MacroAssignment (typereference_token p_typereference_token, SyntaxTreeToken p_token, ModuleIdentityMacro p_ModuleIdentityMacro) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_11)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_typereference_token = p_typereference_token;
			children[1] = m_assignment_sign = p_token;
			children[2] = m_ModuleIdentityMacro = p_ModuleIdentityMacro;
		}

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> typereference-token "::=" ObjectIdentityMacro

		//

		public MacroAssignment (typereference_token p_typereference_token, SyntaxTreeToken p_token, ObjectIdentityMacro p_ObjectIdentityMacro) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_12)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_typereference_token = p_typereference_token;
			children[1] = m_assignment_sign = p_token;
			children[2] = m_ObjectIdentityMacro = p_ObjectIdentityMacro;
		}

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> typereference-token "::=" ObjectTypeMacro

		//

		public MacroAssignment (typereference_token p_typereference_token, SyntaxTreeToken p_token, ObjectTypeMacro p_ObjectTypeMacro) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_13)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_typereference_token = p_typereference_token;
			children[1] = m_assignment_sign = p_token;
			children[2] = m_ObjectTypeMacro = p_ObjectTypeMacro;
		}

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> typereference-token "::=" NotificationTypeMacro

		//

		public MacroAssignment (typereference_token p_typereference_token, SyntaxTreeToken p_token, NotificationTypeMacro p_NotificationTypeMacro) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_14)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_typereference_token = p_typereference_token;
			children[1] = m_assignment_sign = p_token;
			children[2] = m_NotificationTypeMacro = p_NotificationTypeMacro;
		}

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> typereference-token "::=" TextualConventionMacro

		//

		public MacroAssignment (typereference_token p_typereference_token, SyntaxTreeToken p_token, TextualConventionMacro p_TextualConventionMacro) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_15)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_typereference_token = p_typereference_token;
			children[1] = m_assignment_sign = p_token;
			children[2] = m_TextualConventionMacro = p_TextualConventionMacro;
		}

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> typereference-token "::=" ObjectGroupMacro

		//

		public MacroAssignment (typereference_token p_typereference_token, SyntaxTreeToken p_token, ObjectGroupMacro p_ObjectGroupMacro) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_16)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_typereference_token = p_typereference_token;
			children[1] = m_assignment_sign = p_token;
			children[2] = m_ObjectGroupMacro = p_ObjectGroupMacro;
		}

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> typereference-token "::=" NotificationGroupMacro

		//

		public MacroAssignment (typereference_token p_typereference_token, SyntaxTreeToken p_token, NotificationGroupMacro p_NotificationGroupMacro) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_17)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_typereference_token = p_typereference_token;
			children[1] = m_assignment_sign = p_token;
			children[2] = m_NotificationGroupMacro = p_NotificationGroupMacro;
		}

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> typereference-token "::=" ModuleComplianceMacro

		//

		public MacroAssignment (typereference_token p_typereference_token, SyntaxTreeToken p_token, ModuleComplianceMacro p_ModuleComplianceMacro) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_18)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_typereference_token = p_typereference_token;
			children[1] = m_assignment_sign = p_token;
			children[2] = m_ModuleComplianceMacro = p_ModuleComplianceMacro;
		}

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> typereference-token "::=" AgentCapabilitiesMacro

		//

		public MacroAssignment (typereference_token p_typereference_token, SyntaxTreeToken p_token, AgentCapabilitiesMacro p_AgentCapabilitiesMacro) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_19)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_typereference_token = p_typereference_token;
			children[1] = m_assignment_sign = p_token;
			children[2] = m_AgentCapabilitiesMacro = p_AgentCapabilitiesMacro;
		}

		//
		// Constructor associated with the following production(s)
		// MacroAssignment -> typereference-token "::=" TrapTypeMacro

		//

		public MacroAssignment (typereference_token p_typereference_token, SyntaxTreeToken p_token, TrapTypeMacro p_TrapTypeMacro) : base ((uint) ProductionID._MacroAssignment_ID, (uint) production_kind.g_MacroAssignment_20)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_typereference_token = p_typereference_token;
			children[1] = m_assignment_sign = p_token;
			children[2] = m_TrapTypeMacro = p_TrapTypeMacro;
		}

		public MacroAssignment () { }

		// Copy constructor

		public MacroAssignment (MacroAssignment p_MacroAssignment) : base (p_MacroAssignment.id, p_MacroAssignment.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MacroAssignment.appInfo;
			switch ((production_kind) p_MacroAssignment.kind)
			{
				case production_kind.g_MacroAssignment_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_valuereference_token = (p_MacroAssignment.m_valuereference_token != null) ? new valuereference_token (p_MacroAssignment.m_valuereference_token) : null) != null) m_valuereference_token.parent = this;
					if ((children [1] = m_ModuleIdentityMacro = (p_MacroAssignment.m_ModuleIdentityMacro != null) ? new ModuleIdentityMacro (p_MacroAssignment.m_ModuleIdentityMacro) : null) != null) m_ModuleIdentityMacro.parent = this;
					if ((children [2] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [3] = m_ObjectIdentifierValue = (p_MacroAssignment.m_ObjectIdentifierValue != null) ? new ObjectIdentifierValue (p_MacroAssignment.m_ObjectIdentifierValue) : null) != null) m_ObjectIdentifierValue.parent = this;
					break;
				case production_kind.g_MacroAssignment_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_valuereference_token = (p_MacroAssignment.m_valuereference_token != null) ? new valuereference_token (p_MacroAssignment.m_valuereference_token) : null) != null) m_valuereference_token.parent = this;
					if ((children [1] = m_ObjectIdentityMacro = (p_MacroAssignment.m_ObjectIdentityMacro != null) ? new ObjectIdentityMacro (p_MacroAssignment.m_ObjectIdentityMacro) : null) != null) m_ObjectIdentityMacro.parent = this;
					if ((children [2] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [3] = m_ObjectIdentifierValue = (p_MacroAssignment.m_ObjectIdentifierValue != null) ? new ObjectIdentifierValue (p_MacroAssignment.m_ObjectIdentifierValue) : null) != null) m_ObjectIdentifierValue.parent = this;
					break;
				case production_kind.g_MacroAssignment_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_valuereference_token = (p_MacroAssignment.m_valuereference_token != null) ? new valuereference_token (p_MacroAssignment.m_valuereference_token) : null) != null) m_valuereference_token.parent = this;
					if ((children [1] = m_ObjectTypeMacro = (p_MacroAssignment.m_ObjectTypeMacro != null) ? new ObjectTypeMacro (p_MacroAssignment.m_ObjectTypeMacro) : null) != null) m_ObjectTypeMacro.parent = this;
					if ((children [2] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [3] = m_ObjectIdentifierValue = (p_MacroAssignment.m_ObjectIdentifierValue != null) ? new ObjectIdentifierValue (p_MacroAssignment.m_ObjectIdentifierValue) : null) != null) m_ObjectIdentifierValue.parent = this;
					break;
				case production_kind.g_MacroAssignment_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_valuereference_token = (p_MacroAssignment.m_valuereference_token != null) ? new valuereference_token (p_MacroAssignment.m_valuereference_token) : null) != null) m_valuereference_token.parent = this;
					if ((children [1] = m_NotificationTypeMacro = (p_MacroAssignment.m_NotificationTypeMacro != null) ? new NotificationTypeMacro (p_MacroAssignment.m_NotificationTypeMacro) : null) != null) m_NotificationTypeMacro.parent = this;
					if ((children [2] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [3] = m_ObjectIdentifierValue = (p_MacroAssignment.m_ObjectIdentifierValue != null) ? new ObjectIdentifierValue (p_MacroAssignment.m_ObjectIdentifierValue) : null) != null) m_ObjectIdentifierValue.parent = this;
					break;
				case production_kind.g_MacroAssignment_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_valuereference_token = (p_MacroAssignment.m_valuereference_token != null) ? new valuereference_token (p_MacroAssignment.m_valuereference_token) : null) != null) m_valuereference_token.parent = this;
					if ((children [1] = m_TextualConventionMacro = (p_MacroAssignment.m_TextualConventionMacro != null) ? new TextualConventionMacro (p_MacroAssignment.m_TextualConventionMacro) : null) != null) m_TextualConventionMacro.parent = this;
					if ((children [2] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [3] = m_ObjectIdentifierValue = (p_MacroAssignment.m_ObjectIdentifierValue != null) ? new ObjectIdentifierValue (p_MacroAssignment.m_ObjectIdentifierValue) : null) != null) m_ObjectIdentifierValue.parent = this;
					break;
				case production_kind.g_MacroAssignment_6:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_valuereference_token = (p_MacroAssignment.m_valuereference_token != null) ? new valuereference_token (p_MacroAssignment.m_valuereference_token) : null) != null) m_valuereference_token.parent = this;
					if ((children [1] = m_ObjectGroupMacro = (p_MacroAssignment.m_ObjectGroupMacro != null) ? new ObjectGroupMacro (p_MacroAssignment.m_ObjectGroupMacro) : null) != null) m_ObjectGroupMacro.parent = this;
					if ((children [2] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [3] = m_ObjectIdentifierValue = (p_MacroAssignment.m_ObjectIdentifierValue != null) ? new ObjectIdentifierValue (p_MacroAssignment.m_ObjectIdentifierValue) : null) != null) m_ObjectIdentifierValue.parent = this;
					break;
				case production_kind.g_MacroAssignment_7:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_valuereference_token = (p_MacroAssignment.m_valuereference_token != null) ? new valuereference_token (p_MacroAssignment.m_valuereference_token) : null) != null) m_valuereference_token.parent = this;
					if ((children [1] = m_NotificationGroupMacro = (p_MacroAssignment.m_NotificationGroupMacro != null) ? new NotificationGroupMacro (p_MacroAssignment.m_NotificationGroupMacro) : null) != null) m_NotificationGroupMacro.parent = this;
					if ((children [2] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [3] = m_ObjectIdentifierValue = (p_MacroAssignment.m_ObjectIdentifierValue != null) ? new ObjectIdentifierValue (p_MacroAssignment.m_ObjectIdentifierValue) : null) != null) m_ObjectIdentifierValue.parent = this;
					break;
				case production_kind.g_MacroAssignment_8:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_valuereference_token = (p_MacroAssignment.m_valuereference_token != null) ? new valuereference_token (p_MacroAssignment.m_valuereference_token) : null) != null) m_valuereference_token.parent = this;
					if ((children [1] = m_ModuleComplianceMacro = (p_MacroAssignment.m_ModuleComplianceMacro != null) ? new ModuleComplianceMacro (p_MacroAssignment.m_ModuleComplianceMacro) : null) != null) m_ModuleComplianceMacro.parent = this;
					if ((children [2] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [3] = m_ObjectIdentifierValue = (p_MacroAssignment.m_ObjectIdentifierValue != null) ? new ObjectIdentifierValue (p_MacroAssignment.m_ObjectIdentifierValue) : null) != null) m_ObjectIdentifierValue.parent = this;
					break;
				case production_kind.g_MacroAssignment_9:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_valuereference_token = (p_MacroAssignment.m_valuereference_token != null) ? new valuereference_token (p_MacroAssignment.m_valuereference_token) : null) != null) m_valuereference_token.parent = this;
					if ((children [1] = m_AgentCapabilitiesMacro = (p_MacroAssignment.m_AgentCapabilitiesMacro != null) ? new AgentCapabilitiesMacro (p_MacroAssignment.m_AgentCapabilitiesMacro) : null) != null) m_AgentCapabilitiesMacro.parent = this;
					if ((children [2] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [3] = m_ObjectIdentifierValue = (p_MacroAssignment.m_ObjectIdentifierValue != null) ? new ObjectIdentifierValue (p_MacroAssignment.m_ObjectIdentifierValue) : null) != null) m_ObjectIdentifierValue.parent = this;
					break;
				case production_kind.g_MacroAssignment_10:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_valuereference_token = (p_MacroAssignment.m_valuereference_token != null) ? new valuereference_token (p_MacroAssignment.m_valuereference_token) : null) != null) m_valuereference_token.parent = this;
					if ((children [1] = m_TrapTypeMacro = (p_MacroAssignment.m_TrapTypeMacro != null) ? new TrapTypeMacro (p_MacroAssignment.m_TrapTypeMacro) : null) != null) m_TrapTypeMacro.parent = this;
					if ((children [2] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [3] = m_IntegerValue = (p_MacroAssignment.m_IntegerValue != null) ? new IntegerValue (p_MacroAssignment.m_IntegerValue) : null) != null) m_IntegerValue.parent = this;
					break;
				case production_kind.g_MacroAssignment_11:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_typereference_token = (p_MacroAssignment.m_typereference_token != null) ? new typereference_token (p_MacroAssignment.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					if ((children [1] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [2] = m_ModuleIdentityMacro = (p_MacroAssignment.m_ModuleIdentityMacro != null) ? new ModuleIdentityMacro (p_MacroAssignment.m_ModuleIdentityMacro) : null) != null) m_ModuleIdentityMacro.parent = this;
					break;
				case production_kind.g_MacroAssignment_12:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_typereference_token = (p_MacroAssignment.m_typereference_token != null) ? new typereference_token (p_MacroAssignment.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					if ((children [1] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [2] = m_ObjectIdentityMacro = (p_MacroAssignment.m_ObjectIdentityMacro != null) ? new ObjectIdentityMacro (p_MacroAssignment.m_ObjectIdentityMacro) : null) != null) m_ObjectIdentityMacro.parent = this;
					break;
				case production_kind.g_MacroAssignment_13:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_typereference_token = (p_MacroAssignment.m_typereference_token != null) ? new typereference_token (p_MacroAssignment.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					if ((children [1] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [2] = m_ObjectTypeMacro = (p_MacroAssignment.m_ObjectTypeMacro != null) ? new ObjectTypeMacro (p_MacroAssignment.m_ObjectTypeMacro) : null) != null) m_ObjectTypeMacro.parent = this;
					break;
				case production_kind.g_MacroAssignment_14:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_typereference_token = (p_MacroAssignment.m_typereference_token != null) ? new typereference_token (p_MacroAssignment.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					if ((children [1] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [2] = m_NotificationTypeMacro = (p_MacroAssignment.m_NotificationTypeMacro != null) ? new NotificationTypeMacro (p_MacroAssignment.m_NotificationTypeMacro) : null) != null) m_NotificationTypeMacro.parent = this;
					break;
				case production_kind.g_MacroAssignment_15:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_typereference_token = (p_MacroAssignment.m_typereference_token != null) ? new typereference_token (p_MacroAssignment.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					if ((children [1] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [2] = m_TextualConventionMacro = (p_MacroAssignment.m_TextualConventionMacro != null) ? new TextualConventionMacro (p_MacroAssignment.m_TextualConventionMacro) : null) != null) m_TextualConventionMacro.parent = this;
					break;
				case production_kind.g_MacroAssignment_16:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_typereference_token = (p_MacroAssignment.m_typereference_token != null) ? new typereference_token (p_MacroAssignment.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					if ((children [1] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [2] = m_ObjectGroupMacro = (p_MacroAssignment.m_ObjectGroupMacro != null) ? new ObjectGroupMacro (p_MacroAssignment.m_ObjectGroupMacro) : null) != null) m_ObjectGroupMacro.parent = this;
					break;
				case production_kind.g_MacroAssignment_17:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_typereference_token = (p_MacroAssignment.m_typereference_token != null) ? new typereference_token (p_MacroAssignment.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					if ((children [1] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [2] = m_NotificationGroupMacro = (p_MacroAssignment.m_NotificationGroupMacro != null) ? new NotificationGroupMacro (p_MacroAssignment.m_NotificationGroupMacro) : null) != null) m_NotificationGroupMacro.parent = this;
					break;
				case production_kind.g_MacroAssignment_18:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_typereference_token = (p_MacroAssignment.m_typereference_token != null) ? new typereference_token (p_MacroAssignment.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					if ((children [1] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [2] = m_ModuleComplianceMacro = (p_MacroAssignment.m_ModuleComplianceMacro != null) ? new ModuleComplianceMacro (p_MacroAssignment.m_ModuleComplianceMacro) : null) != null) m_ModuleComplianceMacro.parent = this;
					break;
				case production_kind.g_MacroAssignment_19:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_typereference_token = (p_MacroAssignment.m_typereference_token != null) ? new typereference_token (p_MacroAssignment.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					if ((children [1] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [2] = m_AgentCapabilitiesMacro = (p_MacroAssignment.m_AgentCapabilitiesMacro != null) ? new AgentCapabilitiesMacro (p_MacroAssignment.m_AgentCapabilitiesMacro) : null) != null) m_AgentCapabilitiesMacro.parent = this;
					break;
				case production_kind.g_MacroAssignment_20:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_typereference_token = (p_MacroAssignment.m_typereference_token != null) ? new typereference_token (p_MacroAssignment.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					if ((children [1] = m_assignment_sign = (p_MacroAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [2] = m_TrapTypeMacro = (p_MacroAssignment.m_TrapTypeMacro != null) ? new TrapTypeMacro (p_MacroAssignment.m_TrapTypeMacro) : null) != null) m_TrapTypeMacro.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "MacroAssignment" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MacroAssignment (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_valuereference_token?.Dispose ();
			m_ModuleIdentityMacro?.Dispose ();
			m_assignment_sign?.Dispose ();
			m_ObjectIdentifierValue?.Dispose ();
			m_ObjectIdentityMacro?.Dispose ();
			m_ObjectTypeMacro?.Dispose ();
			m_NotificationTypeMacro?.Dispose ();
			m_TextualConventionMacro?.Dispose ();
			m_ObjectGroupMacro?.Dispose ();
			m_NotificationGroupMacro?.Dispose ();
			m_ModuleComplianceMacro?.Dispose ();
			m_AgentCapabilitiesMacro?.Dispose ();
			m_TrapTypeMacro?.Dispose ();
			m_IntegerValue?.Dispose ();
			m_typereference_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MacroAssignment

		// Content changing function(s) associated with production(s) of syntax rule MacroAssignment

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> valuereference-token ModuleIdentityMacro "::=" ObjectIdentifierValue

		//

		public void change(valuereference_token p_valuereference_token, ModuleIdentityMacro p_ModuleIdentityMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_valuereference_token = p_valuereference_token;
			children [1] = m_ModuleIdentityMacro = p_ModuleIdentityMacro;
			children [2] = m_assignment_sign = p_token;
			children [3] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> valuereference-token ObjectIdentityMacro "::=" ObjectIdentifierValue

		//

		public void change(valuereference_token p_valuereference_token, ObjectIdentityMacro p_ObjectIdentityMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_valuereference_token = p_valuereference_token;
			children [1] = m_ObjectIdentityMacro = p_ObjectIdentityMacro;
			children [2] = m_assignment_sign = p_token;
			children [3] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> valuereference-token ObjectTypeMacro "::=" ObjectIdentifierValue

		//

		public void change(valuereference_token p_valuereference_token, ObjectTypeMacro p_ObjectTypeMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_valuereference_token = p_valuereference_token;
			children [1] = m_ObjectTypeMacro = p_ObjectTypeMacro;
			children [2] = m_assignment_sign = p_token;
			children [3] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> valuereference-token NotificationTypeMacro "::=" ObjectIdentifierValue

		//

		public void change(valuereference_token p_valuereference_token, NotificationTypeMacro p_NotificationTypeMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_valuereference_token = p_valuereference_token;
			children [1] = m_NotificationTypeMacro = p_NotificationTypeMacro;
			children [2] = m_assignment_sign = p_token;
			children [3] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> valuereference-token TextualConventionMacro "::=" ObjectIdentifierValue

		//

		public void change(valuereference_token p_valuereference_token, TextualConventionMacro p_TextualConventionMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_5;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_valuereference_token = p_valuereference_token;
			children [1] = m_TextualConventionMacro = p_TextualConventionMacro;
			children [2] = m_assignment_sign = p_token;
			children [3] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> valuereference-token ObjectGroupMacro "::=" ObjectIdentifierValue

		//

		public void change(valuereference_token p_valuereference_token, ObjectGroupMacro p_ObjectGroupMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_6;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_valuereference_token = p_valuereference_token;
			children [1] = m_ObjectGroupMacro = p_ObjectGroupMacro;
			children [2] = m_assignment_sign = p_token;
			children [3] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> valuereference-token NotificationGroupMacro "::=" ObjectIdentifierValue

		//

		public void change(valuereference_token p_valuereference_token, NotificationGroupMacro p_NotificationGroupMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_7;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_valuereference_token = p_valuereference_token;
			children [1] = m_NotificationGroupMacro = p_NotificationGroupMacro;
			children [2] = m_assignment_sign = p_token;
			children [3] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> valuereference-token ModuleComplianceMacro "::=" ObjectIdentifierValue

		//

		public void change(valuereference_token p_valuereference_token, ModuleComplianceMacro p_ModuleComplianceMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_8;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_valuereference_token = p_valuereference_token;
			children [1] = m_ModuleComplianceMacro = p_ModuleComplianceMacro;
			children [2] = m_assignment_sign = p_token;
			children [3] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> valuereference-token AgentCapabilitiesMacro "::=" ObjectIdentifierValue

		//

		public void change(valuereference_token p_valuereference_token, AgentCapabilitiesMacro p_AgentCapabilitiesMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_9;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_valuereference_token = p_valuereference_token;
			children [1] = m_AgentCapabilitiesMacro = p_AgentCapabilitiesMacro;
			children [2] = m_assignment_sign = p_token;
			children [3] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> valuereference-token TrapTypeMacro "::=" IntegerValue

		//

		public void change(valuereference_token p_valuereference_token, TrapTypeMacro p_TrapTypeMacro, SyntaxTreeToken p_token, IntegerValue p_IntegerValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_10;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_valuereference_token = p_valuereference_token;
			children [1] = m_TrapTypeMacro = p_TrapTypeMacro;
			children [2] = m_assignment_sign = p_token;
			children [3] = m_IntegerValue = p_IntegerValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> typereference-token "::=" ModuleIdentityMacro

		//

		public void change(typereference_token p_typereference_token, SyntaxTreeToken p_token, ModuleIdentityMacro p_ModuleIdentityMacro)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_11;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_typereference_token = p_typereference_token;
			children [1] = m_assignment_sign = p_token;
			children [2] = m_ModuleIdentityMacro = p_ModuleIdentityMacro;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> typereference-token "::=" ObjectIdentityMacro

		//

		public void change(typereference_token p_typereference_token, SyntaxTreeToken p_token, ObjectIdentityMacro p_ObjectIdentityMacro)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_12;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_typereference_token = p_typereference_token;
			children [1] = m_assignment_sign = p_token;
			children [2] = m_ObjectIdentityMacro = p_ObjectIdentityMacro;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> typereference-token "::=" ObjectTypeMacro

		//

		public void change(typereference_token p_typereference_token, SyntaxTreeToken p_token, ObjectTypeMacro p_ObjectTypeMacro)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_13;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_typereference_token = p_typereference_token;
			children [1] = m_assignment_sign = p_token;
			children [2] = m_ObjectTypeMacro = p_ObjectTypeMacro;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> typereference-token "::=" NotificationTypeMacro

		//

		public void change(typereference_token p_typereference_token, SyntaxTreeToken p_token, NotificationTypeMacro p_NotificationTypeMacro)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_14;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_typereference_token = p_typereference_token;
			children [1] = m_assignment_sign = p_token;
			children [2] = m_NotificationTypeMacro = p_NotificationTypeMacro;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> typereference-token "::=" TextualConventionMacro

		//

		public void change(typereference_token p_typereference_token, SyntaxTreeToken p_token, TextualConventionMacro p_TextualConventionMacro)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_15;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_typereference_token = p_typereference_token;
			children [1] = m_assignment_sign = p_token;
			children [2] = m_TextualConventionMacro = p_TextualConventionMacro;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> typereference-token "::=" ObjectGroupMacro

		//

		public void change(typereference_token p_typereference_token, SyntaxTreeToken p_token, ObjectGroupMacro p_ObjectGroupMacro)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_16;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_typereference_token = p_typereference_token;
			children [1] = m_assignment_sign = p_token;
			children [2] = m_ObjectGroupMacro = p_ObjectGroupMacro;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> typereference-token "::=" NotificationGroupMacro

		//

		public void change(typereference_token p_typereference_token, SyntaxTreeToken p_token, NotificationGroupMacro p_NotificationGroupMacro)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_17;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_typereference_token = p_typereference_token;
			children [1] = m_assignment_sign = p_token;
			children [2] = m_NotificationGroupMacro = p_NotificationGroupMacro;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> typereference-token "::=" ModuleComplianceMacro

		//

		public void change(typereference_token p_typereference_token, SyntaxTreeToken p_token, ModuleComplianceMacro p_ModuleComplianceMacro)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_18;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_typereference_token = p_typereference_token;
			children [1] = m_assignment_sign = p_token;
			children [2] = m_ModuleComplianceMacro = p_ModuleComplianceMacro;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> typereference-token "::=" AgentCapabilitiesMacro

		//

		public void change(typereference_token p_typereference_token, SyntaxTreeToken p_token, AgentCapabilitiesMacro p_AgentCapabilitiesMacro)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_19;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_typereference_token = p_typereference_token;
			children [1] = m_assignment_sign = p_token;
			children [2] = m_AgentCapabilitiesMacro = p_AgentCapabilitiesMacro;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroAssignment -> typereference-token "::=" TrapTypeMacro

		//

		public void change(typereference_token p_typereference_token, SyntaxTreeToken p_token, TrapTypeMacro p_TrapTypeMacro)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroAssignment_20;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_typereference_token = p_typereference_token;
			children [1] = m_assignment_sign = p_token;
			children [2] = m_TrapTypeMacro = p_TrapTypeMacro;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MacroAssignment
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_valuereference_token != null) && m_valuereference_token.checkInclusion (element) ||
				(m_ModuleIdentityMacro != null) && m_ModuleIdentityMacro.checkInclusion (element) ||
				(m_assignment_sign != null) && m_assignment_sign.checkInclusion (element) ||
				(m_ObjectIdentifierValue != null) && m_ObjectIdentifierValue.checkInclusion (element) ||
				(m_ObjectIdentityMacro != null) && m_ObjectIdentityMacro.checkInclusion (element) ||
				(m_ObjectTypeMacro != null) && m_ObjectTypeMacro.checkInclusion (element) ||
				(m_NotificationTypeMacro != null) && m_NotificationTypeMacro.checkInclusion (element) ||
				(m_TextualConventionMacro != null) && m_TextualConventionMacro.checkInclusion (element) ||
				(m_ObjectGroupMacro != null) && m_ObjectGroupMacro.checkInclusion (element) ||
				(m_NotificationGroupMacro != null) && m_NotificationGroupMacro.checkInclusion (element) ||
				(m_ModuleComplianceMacro != null) && m_ModuleComplianceMacro.checkInclusion (element) ||
				(m_AgentCapabilitiesMacro != null) && m_AgentCapabilitiesMacro.checkInclusion (element) ||
				(m_TrapTypeMacro != null) && m_TrapTypeMacro.checkInclusion (element) ||
				(m_IntegerValue != null) && m_IntegerValue.checkInclusion (element) ||
				(m_typereference_token != null) && m_typereference_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MacroAssignment

		//
		// emit production tree node associated with any production of syntax rule MacroAssignment
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MacroAssignment_1:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token ModuleIdentityMacro "::=" ObjectIdentifierValue

					s += m_valuereference_token.Emit (depth - 1);
					s += " ";
					s += m_ModuleIdentityMacro.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_ObjectIdentifierValue.Emit (depth - 1);
				break;
				case production_kind.g_MacroAssignment_2:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token ObjectIdentityMacro "::=" ObjectIdentifierValue

					s += m_valuereference_token.Emit (depth - 1);
					s += " ";
					s += m_ObjectIdentityMacro.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_ObjectIdentifierValue.Emit (depth - 1);
				break;
				case production_kind.g_MacroAssignment_3:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token ObjectTypeMacro "::=" ObjectIdentifierValue

					s += m_valuereference_token.Emit (depth - 1);
					s += " ";
					s += m_ObjectTypeMacro.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_ObjectIdentifierValue.Emit (depth - 1);
				break;
				case production_kind.g_MacroAssignment_4:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token NotificationTypeMacro "::=" ObjectIdentifierValue

					s += m_valuereference_token.Emit (depth - 1);
					s += " ";
					s += m_NotificationTypeMacro.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_ObjectIdentifierValue.Emit (depth - 1);
				break;
				case production_kind.g_MacroAssignment_5:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token TextualConventionMacro "::=" ObjectIdentifierValue

					s += m_valuereference_token.Emit (depth - 1);
					s += " ";
					s += m_TextualConventionMacro.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_ObjectIdentifierValue.Emit (depth - 1);
				break;
				case production_kind.g_MacroAssignment_6:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token ObjectGroupMacro "::=" ObjectIdentifierValue

					s += m_valuereference_token.Emit (depth - 1);
					s += " ";
					s += m_ObjectGroupMacro.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_ObjectIdentifierValue.Emit (depth - 1);
				break;
				case production_kind.g_MacroAssignment_7:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token NotificationGroupMacro "::=" ObjectIdentifierValue

					s += m_valuereference_token.Emit (depth - 1);
					s += " ";
					s += m_NotificationGroupMacro.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_ObjectIdentifierValue.Emit (depth - 1);
				break;
				case production_kind.g_MacroAssignment_8:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token ModuleComplianceMacro "::=" ObjectIdentifierValue

					s += m_valuereference_token.Emit (depth - 1);
					s += " ";
					s += m_ModuleComplianceMacro.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_ObjectIdentifierValue.Emit (depth - 1);
				break;
				case production_kind.g_MacroAssignment_9:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token AgentCapabilitiesMacro "::=" ObjectIdentifierValue

					s += m_valuereference_token.Emit (depth - 1);
					s += " ";
					s += m_AgentCapabilitiesMacro.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_ObjectIdentifierValue.Emit (depth - 1);
				break;
				case production_kind.g_MacroAssignment_10:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token TrapTypeMacro "::=" IntegerValue

					s += m_valuereference_token.Emit (depth - 1);
					s += " ";
					s += m_TrapTypeMacro.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_IntegerValue.Emit (depth - 1);
				break;
				case production_kind.g_MacroAssignment_11:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ModuleIdentityMacro

					s += m_typereference_token.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_ModuleIdentityMacro.Emit (depth - 1);
				break;
				case production_kind.g_MacroAssignment_12:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ObjectIdentityMacro

					s += m_typereference_token.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_ObjectIdentityMacro.Emit (depth - 1);
				break;
				case production_kind.g_MacroAssignment_13:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ObjectTypeMacro

					s += m_typereference_token.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_ObjectTypeMacro.Emit (depth - 1);
				break;
				case production_kind.g_MacroAssignment_14:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" NotificationTypeMacro

					s += m_typereference_token.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_NotificationTypeMacro.Emit (depth - 1);
				break;
				case production_kind.g_MacroAssignment_15:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" TextualConventionMacro

					s += m_typereference_token.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_TextualConventionMacro.Emit (depth - 1);
				break;
				case production_kind.g_MacroAssignment_16:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ObjectGroupMacro

					s += m_typereference_token.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_ObjectGroupMacro.Emit (depth - 1);
				break;
				case production_kind.g_MacroAssignment_17:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" NotificationGroupMacro

					s += m_typereference_token.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_NotificationGroupMacro.Emit (depth - 1);
				break;
				case production_kind.g_MacroAssignment_18:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ModuleComplianceMacro

					s += m_typereference_token.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_ModuleComplianceMacro.Emit (depth - 1);
				break;
				case production_kind.g_MacroAssignment_19:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" AgentCapabilitiesMacro

					s += m_typereference_token.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_AgentCapabilitiesMacro.Emit (depth - 1);
				break;
				case production_kind.g_MacroAssignment_20:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" TrapTypeMacro

					s += m_typereference_token.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_TrapTypeMacro.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MacroAssignment
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MacroAssignment (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MacroAssignment_1:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token ModuleIdentityMacro "::=" ObjectIdentifierValue

					s += m_valuereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ModuleIdentityMacro.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_ObjectIdentifierValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroAssignment_2:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token ObjectIdentityMacro "::=" ObjectIdentifierValue

					s += m_valuereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ObjectIdentityMacro.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_ObjectIdentifierValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroAssignment_3:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token ObjectTypeMacro "::=" ObjectIdentifierValue

					s += m_valuereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ObjectTypeMacro.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_ObjectIdentifierValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroAssignment_4:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token NotificationTypeMacro "::=" ObjectIdentifierValue

					s += m_valuereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_NotificationTypeMacro.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_ObjectIdentifierValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroAssignment_5:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token TextualConventionMacro "::=" ObjectIdentifierValue

					s += m_valuereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_TextualConventionMacro.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_ObjectIdentifierValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroAssignment_6:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token ObjectGroupMacro "::=" ObjectIdentifierValue

					s += m_valuereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ObjectGroupMacro.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_ObjectIdentifierValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroAssignment_7:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token NotificationGroupMacro "::=" ObjectIdentifierValue

					s += m_valuereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_NotificationGroupMacro.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_ObjectIdentifierValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroAssignment_8:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token ModuleComplianceMacro "::=" ObjectIdentifierValue

					s += m_valuereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ModuleComplianceMacro.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_ObjectIdentifierValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroAssignment_9:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token AgentCapabilitiesMacro "::=" ObjectIdentifierValue

					s += m_valuereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_AgentCapabilitiesMacro.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_ObjectIdentifierValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroAssignment_10:
					// emit syntax tree node associated with production
					// MacroAssignment: valuereference-token TrapTypeMacro "::=" IntegerValue

					s += m_valuereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_TrapTypeMacro.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_IntegerValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroAssignment_11:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ModuleIdentityMacro

					s += m_typereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_ModuleIdentityMacro.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroAssignment_12:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ObjectIdentityMacro

					s += m_typereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_ObjectIdentityMacro.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroAssignment_13:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ObjectTypeMacro

					s += m_typereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_ObjectTypeMacro.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroAssignment_14:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" NotificationTypeMacro

					s += m_typereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_NotificationTypeMacro.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroAssignment_15:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" TextualConventionMacro

					s += m_typereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_TextualConventionMacro.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroAssignment_16:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ObjectGroupMacro

					s += m_typereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_ObjectGroupMacro.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroAssignment_17:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" NotificationGroupMacro

					s += m_typereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_NotificationGroupMacro.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroAssignment_18:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ModuleComplianceMacro

					s += m_typereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_ModuleComplianceMacro.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroAssignment_19:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" AgentCapabilitiesMacro

					s += m_typereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_AgentCapabilitiesMacro.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroAssignment_20:
					// emit syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" TrapTypeMacro

					s += m_typereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_TrapTypeMacro.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MacroAssignment

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MacroAssignment with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MacroAssignment.production_kind kind = (MacroAssignment.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MacroAssignment.production_kind.g_MacroAssignment_1:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token ModuleIdentityMacro "::=" ObjectIdentifierValue

						m_valuereference_token.Visit (visitor, appData);
						m_ModuleIdentityMacro.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_ObjectIdentifierValue.Visit (visitor, appData);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_2:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token ObjectIdentityMacro "::=" ObjectIdentifierValue

						m_valuereference_token.Visit (visitor, appData);
						m_ObjectIdentityMacro.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_ObjectIdentifierValue.Visit (visitor, appData);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_3:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token ObjectTypeMacro "::=" ObjectIdentifierValue

						m_valuereference_token.Visit (visitor, appData);
						m_ObjectTypeMacro.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_ObjectIdentifierValue.Visit (visitor, appData);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_4:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token NotificationTypeMacro "::=" ObjectIdentifierValue

						m_valuereference_token.Visit (visitor, appData);
						m_NotificationTypeMacro.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_ObjectIdentifierValue.Visit (visitor, appData);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_5:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token TextualConventionMacro "::=" ObjectIdentifierValue

						m_valuereference_token.Visit (visitor, appData);
						m_TextualConventionMacro.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_ObjectIdentifierValue.Visit (visitor, appData);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_6:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token ObjectGroupMacro "::=" ObjectIdentifierValue

						m_valuereference_token.Visit (visitor, appData);
						m_ObjectGroupMacro.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_ObjectIdentifierValue.Visit (visitor, appData);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_7:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token NotificationGroupMacro "::=" ObjectIdentifierValue

						m_valuereference_token.Visit (visitor, appData);
						m_NotificationGroupMacro.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_ObjectIdentifierValue.Visit (visitor, appData);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_8:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token ModuleComplianceMacro "::=" ObjectIdentifierValue

						m_valuereference_token.Visit (visitor, appData);
						m_ModuleComplianceMacro.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_ObjectIdentifierValue.Visit (visitor, appData);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_9:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token AgentCapabilitiesMacro "::=" ObjectIdentifierValue

						m_valuereference_token.Visit (visitor, appData);
						m_AgentCapabilitiesMacro.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_ObjectIdentifierValue.Visit (visitor, appData);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_10:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token TrapTypeMacro "::=" IntegerValue

						m_valuereference_token.Visit (visitor, appData);
						m_TrapTypeMacro.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_IntegerValue.Visit (visitor, appData);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_11:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ModuleIdentityMacro

						m_typereference_token.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_ModuleIdentityMacro.Visit (visitor, appData);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_12:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ObjectIdentityMacro

						m_typereference_token.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_ObjectIdentityMacro.Visit (visitor, appData);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_13:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ObjectTypeMacro

						m_typereference_token.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_ObjectTypeMacro.Visit (visitor, appData);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_14:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" NotificationTypeMacro

						m_typereference_token.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_NotificationTypeMacro.Visit (visitor, appData);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_15:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" TextualConventionMacro

						m_typereference_token.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_TextualConventionMacro.Visit (visitor, appData);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_16:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ObjectGroupMacro

						m_typereference_token.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_ObjectGroupMacro.Visit (visitor, appData);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_17:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" NotificationGroupMacro

						m_typereference_token.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_NotificationGroupMacro.Visit (visitor, appData);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_18:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ModuleComplianceMacro

						m_typereference_token.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_ModuleComplianceMacro.Visit (visitor, appData);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_19:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" AgentCapabilitiesMacro

						m_typereference_token.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_AgentCapabilitiesMacro.Visit (visitor, appData);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_20:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" TrapTypeMacro

						m_typereference_token.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_TrapTypeMacro.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_valuereference_token?.reparent (this);
			m_ModuleIdentityMacro?.reparent (this);
			m_assignment_sign?.reparent (this);
			m_ObjectIdentifierValue?.reparent (this);
			m_ObjectIdentityMacro?.reparent (this);
			m_ObjectTypeMacro?.reparent (this);
			m_NotificationTypeMacro?.reparent (this);
			m_TextualConventionMacro?.reparent (this);
			m_ObjectGroupMacro?.reparent (this);
			m_NotificationGroupMacro?.reparent (this);
			m_ModuleComplianceMacro?.reparent (this);
			m_AgentCapabilitiesMacro?.reparent (this);
			m_TrapTypeMacro?.reparent (this);
			m_IntegerValue?.reparent (this);
			m_typereference_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MacroAssignment
		//

		public void _init ()
		{
			m_valuereference_token = null;
			m_ModuleIdentityMacro = null;
			m_assignment_sign = null;
			m_ObjectIdentifierValue = null;
			m_ObjectIdentityMacro = null;
			m_ObjectTypeMacro = null;
			m_NotificationTypeMacro = null;
			m_TextualConventionMacro = null;
			m_ObjectGroupMacro = null;
			m_NotificationGroupMacro = null;
			m_ModuleComplianceMacro = null;
			m_AgentCapabilitiesMacro = null;
			m_TrapTypeMacro = null;
			m_IntegerValue = null;
			m_typereference_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MacroAssignment

		// counter of all nodes associated with syntax rule MacroAssignment
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MacroAssignment
		[DataMember (Name = "m_valuereference_token")] public valuereference_token m_valuereference_token { get; private set; }
		[DataMember (Name = "m_ModuleIdentityMacro")] public ModuleIdentityMacro m_ModuleIdentityMacro { get; private set; }
		[DataMember (Name = "m_assignment_sign")] public SyntaxTreeToken m_assignment_sign { get; private set; }
		[DataMember (Name = "m_ObjectIdentifierValue")] public ObjectIdentifierValue m_ObjectIdentifierValue { get; private set; }
		[DataMember (Name = "m_ObjectIdentityMacro")] public ObjectIdentityMacro m_ObjectIdentityMacro { get; private set; }
		[DataMember (Name = "m_ObjectTypeMacro")] public ObjectTypeMacro m_ObjectTypeMacro { get; private set; }
		[DataMember (Name = "m_NotificationTypeMacro")] public NotificationTypeMacro m_NotificationTypeMacro { get; private set; }
		[DataMember (Name = "m_TextualConventionMacro")] public TextualConventionMacro m_TextualConventionMacro { get; private set; }
		[DataMember (Name = "m_ObjectGroupMacro")] public ObjectGroupMacro m_ObjectGroupMacro { get; private set; }
		[DataMember (Name = "m_NotificationGroupMacro")] public NotificationGroupMacro m_NotificationGroupMacro { get; private set; }
		[DataMember (Name = "m_ModuleComplianceMacro")] public ModuleComplianceMacro m_ModuleComplianceMacro { get; private set; }
		[DataMember (Name = "m_AgentCapabilitiesMacro")] public AgentCapabilitiesMacro m_AgentCapabilitiesMacro { get; private set; }
		[DataMember (Name = "m_TrapTypeMacro")] public TrapTypeMacro m_TrapTypeMacro { get; private set; }
		[DataMember (Name = "m_IntegerValue")] public IntegerValue m_IntegerValue { get; private set; }
		[DataMember (Name = "m_typereference_token")] public typereference_token m_typereference_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MacroAssignment

		// delegate function (callback) prototype associated with syntax rule MacroAssignment
		public delegate bool MacroAssignment_Callback (SyntaxTreeCallbackReason reason, MacroAssignment.production_kind kind, MacroAssignment p_MacroAssignment);

		// event associated with syntax rule MacroAssignment
		public event MacroAssignment_Callback MacroAssignment_Event;

		// event trigger associated with syntax rule MacroAssignment
		public bool Raise_MacroAssignment_Event (SyntaxTreeCallbackReason reason, MacroAssignment.production_kind kind, MacroAssignment p_MacroAssignment)
		{
			bool? status = MacroAssignment_Event?.Invoke (reason, kind, p_MacroAssignment);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MacroAssignment
		//
		// traverse syntax tree node associated with any production of syntax rule MacroAssignment
		//

		public void Traverse (MacroAssignment p_MacroAssignment)
		{
			if (p_MacroAssignment.isLocked())
				return;
			p_MacroAssignment.dolock();
			MacroAssignment.production_kind kind = (MacroAssignment.production_kind) p_MacroAssignment.kind;
			p_MacroAssignment.turn_reset ();
			if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MacroAssignment))
			switch (kind)
			{
				case MacroAssignment.production_kind.g_MacroAssignment_1:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token ModuleIdentityMacro "::=" ObjectIdentifierValue

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_valuereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_ModuleIdentityMacro);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_ObjectIdentifierValue);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_2:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token ObjectIdentityMacro "::=" ObjectIdentifierValue

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_valuereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_ObjectIdentityMacro);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_ObjectIdentifierValue);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_3:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token ObjectTypeMacro "::=" ObjectIdentifierValue

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_valuereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_ObjectTypeMacro);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_ObjectIdentifierValue);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_4:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token NotificationTypeMacro "::=" ObjectIdentifierValue

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_valuereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_NotificationTypeMacro);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_ObjectIdentifierValue);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_5:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token TextualConventionMacro "::=" ObjectIdentifierValue

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_valuereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_TextualConventionMacro);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_ObjectIdentifierValue);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_6:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token ObjectGroupMacro "::=" ObjectIdentifierValue

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_valuereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_ObjectGroupMacro);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_ObjectIdentifierValue);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_7:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token NotificationGroupMacro "::=" ObjectIdentifierValue

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_valuereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_NotificationGroupMacro);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_ObjectIdentifierValue);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_8:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token ModuleComplianceMacro "::=" ObjectIdentifierValue

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_valuereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_ModuleComplianceMacro);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_ObjectIdentifierValue);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_9:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token AgentCapabilitiesMacro "::=" ObjectIdentifierValue

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_valuereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_AgentCapabilitiesMacro);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_ObjectIdentifierValue);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_10:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token TrapTypeMacro "::=" IntegerValue

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_valuereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_TrapTypeMacro);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_IntegerValue);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_11:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ModuleIdentityMacro

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_typereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_ModuleIdentityMacro);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_12:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ObjectIdentityMacro

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_typereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_ObjectIdentityMacro);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_13:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ObjectTypeMacro

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_typereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_ObjectTypeMacro);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_14:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" NotificationTypeMacro

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_typereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_NotificationTypeMacro);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_15:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" TextualConventionMacro

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_typereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_TextualConventionMacro);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_16:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ObjectGroupMacro

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_typereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_ObjectGroupMacro);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_17:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" NotificationGroupMacro

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_typereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_NotificationGroupMacro);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_18:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ModuleComplianceMacro

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_typereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_ModuleComplianceMacro);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_19:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" AgentCapabilitiesMacro

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_typereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_AgentCapabilitiesMacro);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_20:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" TrapTypeMacro

					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_typereference_token);
					p_MacroAssignment.turn_inc ();
					if (Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment))
						Traverse (p_MacroAssignment.m_TrapTypeMacro);
					p_MacroAssignment.turn_inc ();
					Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroAssignment);
				break;
			}
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MacroAssignment);
			p_MacroAssignment.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MacroAssignment
		//

		public void TraverseCommon (MacroAssignment p_MacroAssignment)
		{
			MacroAssignment.production_kind kind = (MacroAssignment.production_kind) p_MacroAssignment.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MacroAssignment))
			switch (kind)
			{
				case MacroAssignment.production_kind.g_MacroAssignment_1:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token ModuleIdentityMacro "::=" ObjectIdentifierValue

						TraverseCommon (p_MacroAssignment.m_valuereference_token);
						TraverseCommon (p_MacroAssignment.m_ModuleIdentityMacro);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_ObjectIdentifierValue);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_2:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token ObjectIdentityMacro "::=" ObjectIdentifierValue

						TraverseCommon (p_MacroAssignment.m_valuereference_token);
						TraverseCommon (p_MacroAssignment.m_ObjectIdentityMacro);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_ObjectIdentifierValue);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_3:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token ObjectTypeMacro "::=" ObjectIdentifierValue

						TraverseCommon (p_MacroAssignment.m_valuereference_token);
						TraverseCommon (p_MacroAssignment.m_ObjectTypeMacro);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_ObjectIdentifierValue);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_4:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token NotificationTypeMacro "::=" ObjectIdentifierValue

						TraverseCommon (p_MacroAssignment.m_valuereference_token);
						TraverseCommon (p_MacroAssignment.m_NotificationTypeMacro);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_ObjectIdentifierValue);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_5:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token TextualConventionMacro "::=" ObjectIdentifierValue

						TraverseCommon (p_MacroAssignment.m_valuereference_token);
						TraverseCommon (p_MacroAssignment.m_TextualConventionMacro);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_ObjectIdentifierValue);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_6:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token ObjectGroupMacro "::=" ObjectIdentifierValue

						TraverseCommon (p_MacroAssignment.m_valuereference_token);
						TraverseCommon (p_MacroAssignment.m_ObjectGroupMacro);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_ObjectIdentifierValue);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_7:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token NotificationGroupMacro "::=" ObjectIdentifierValue

						TraverseCommon (p_MacroAssignment.m_valuereference_token);
						TraverseCommon (p_MacroAssignment.m_NotificationGroupMacro);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_ObjectIdentifierValue);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_8:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token ModuleComplianceMacro "::=" ObjectIdentifierValue

						TraverseCommon (p_MacroAssignment.m_valuereference_token);
						TraverseCommon (p_MacroAssignment.m_ModuleComplianceMacro);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_ObjectIdentifierValue);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_9:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token AgentCapabilitiesMacro "::=" ObjectIdentifierValue

						TraverseCommon (p_MacroAssignment.m_valuereference_token);
						TraverseCommon (p_MacroAssignment.m_AgentCapabilitiesMacro);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_ObjectIdentifierValue);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_10:
					// traverse syntax tree node associated with production
					// MacroAssignment: valuereference-token TrapTypeMacro "::=" IntegerValue

						TraverseCommon (p_MacroAssignment.m_valuereference_token);
						TraverseCommon (p_MacroAssignment.m_TrapTypeMacro);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_IntegerValue);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_11:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ModuleIdentityMacro

						TraverseCommon (p_MacroAssignment.m_typereference_token);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_ModuleIdentityMacro);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_12:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ObjectIdentityMacro

						TraverseCommon (p_MacroAssignment.m_typereference_token);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_ObjectIdentityMacro);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_13:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ObjectTypeMacro

						TraverseCommon (p_MacroAssignment.m_typereference_token);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_ObjectTypeMacro);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_14:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" NotificationTypeMacro

						TraverseCommon (p_MacroAssignment.m_typereference_token);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_NotificationTypeMacro);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_15:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" TextualConventionMacro

						TraverseCommon (p_MacroAssignment.m_typereference_token);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_TextualConventionMacro);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_16:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ObjectGroupMacro

						TraverseCommon (p_MacroAssignment.m_typereference_token);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_ObjectGroupMacro);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_17:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" NotificationGroupMacro

						TraverseCommon (p_MacroAssignment.m_typereference_token);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_NotificationGroupMacro);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_18:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" ModuleComplianceMacro

						TraverseCommon (p_MacroAssignment.m_typereference_token);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_ModuleComplianceMacro);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_19:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" AgentCapabilitiesMacro

						TraverseCommon (p_MacroAssignment.m_typereference_token);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_AgentCapabilitiesMacro);
				break;
				case MacroAssignment.production_kind.g_MacroAssignment_20:
					// traverse syntax tree node associated with production
					// MacroAssignment: typereference-token "::=" TrapTypeMacro

						TraverseCommon (p_MacroAssignment.m_typereference_token);
						TraverseCommon (p_MacroAssignment.m_assignment_sign);
						TraverseCommon (p_MacroAssignment.m_TrapTypeMacro);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MacroAssignment);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MacroAssignment

		//
		// create syntax tree node associated with production
		// MacroAssignment: valuereference-token ModuleIdentityMacro "::=" ObjectIdentifierValue

		//

		public MacroAssignment MacroAssignment_1 (valuereference_token p_valuereference_token, ModuleIdentityMacro p_ModuleIdentityMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_valuereference_token, p_ModuleIdentityMacro, p_token, p_ObjectIdentifierValue);
			p_valuereference_token.parent = p_MacroAssignment_ref;
			p_ModuleIdentityMacro.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_ObjectIdentifierValue.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_1, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroAssignment: valuereference-token ObjectIdentityMacro "::=" ObjectIdentifierValue

		//

		public MacroAssignment MacroAssignment_2 (valuereference_token p_valuereference_token, ObjectIdentityMacro p_ObjectIdentityMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_valuereference_token, p_ObjectIdentityMacro, p_token, p_ObjectIdentifierValue);
			p_valuereference_token.parent = p_MacroAssignment_ref;
			p_ObjectIdentityMacro.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_ObjectIdentifierValue.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_2, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroAssignment: valuereference-token ObjectTypeMacro "::=" ObjectIdentifierValue

		//

		public MacroAssignment MacroAssignment_3 (valuereference_token p_valuereference_token, ObjectTypeMacro p_ObjectTypeMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_valuereference_token, p_ObjectTypeMacro, p_token, p_ObjectIdentifierValue);
			p_valuereference_token.parent = p_MacroAssignment_ref;
			p_ObjectTypeMacro.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_ObjectIdentifierValue.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_3, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroAssignment: valuereference-token NotificationTypeMacro "::=" ObjectIdentifierValue

		//

		public MacroAssignment MacroAssignment_4 (valuereference_token p_valuereference_token, NotificationTypeMacro p_NotificationTypeMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_valuereference_token, p_NotificationTypeMacro, p_token, p_ObjectIdentifierValue);
			p_valuereference_token.parent = p_MacroAssignment_ref;
			p_NotificationTypeMacro.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_ObjectIdentifierValue.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_4, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroAssignment: valuereference-token TextualConventionMacro "::=" ObjectIdentifierValue

		//

		public MacroAssignment MacroAssignment_5 (valuereference_token p_valuereference_token, TextualConventionMacro p_TextualConventionMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_valuereference_token, p_TextualConventionMacro, p_token, p_ObjectIdentifierValue);
			p_valuereference_token.parent = p_MacroAssignment_ref;
			p_TextualConventionMacro.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_ObjectIdentifierValue.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_5, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroAssignment: valuereference-token ObjectGroupMacro "::=" ObjectIdentifierValue

		//

		public MacroAssignment MacroAssignment_6 (valuereference_token p_valuereference_token, ObjectGroupMacro p_ObjectGroupMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_valuereference_token, p_ObjectGroupMacro, p_token, p_ObjectIdentifierValue);
			p_valuereference_token.parent = p_MacroAssignment_ref;
			p_ObjectGroupMacro.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_ObjectIdentifierValue.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_6, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroAssignment: valuereference-token NotificationGroupMacro "::=" ObjectIdentifierValue

		//

		public MacroAssignment MacroAssignment_7 (valuereference_token p_valuereference_token, NotificationGroupMacro p_NotificationGroupMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_valuereference_token, p_NotificationGroupMacro, p_token, p_ObjectIdentifierValue);
			p_valuereference_token.parent = p_MacroAssignment_ref;
			p_NotificationGroupMacro.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_ObjectIdentifierValue.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_7, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroAssignment: valuereference-token ModuleComplianceMacro "::=" ObjectIdentifierValue

		//

		public MacroAssignment MacroAssignment_8 (valuereference_token p_valuereference_token, ModuleComplianceMacro p_ModuleComplianceMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_valuereference_token, p_ModuleComplianceMacro, p_token, p_ObjectIdentifierValue);
			p_valuereference_token.parent = p_MacroAssignment_ref;
			p_ModuleComplianceMacro.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_ObjectIdentifierValue.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_8, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroAssignment: valuereference-token AgentCapabilitiesMacro "::=" ObjectIdentifierValue

		//

		public MacroAssignment MacroAssignment_9 (valuereference_token p_valuereference_token, AgentCapabilitiesMacro p_AgentCapabilitiesMacro, SyntaxTreeToken p_token, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_valuereference_token, p_AgentCapabilitiesMacro, p_token, p_ObjectIdentifierValue);
			p_valuereference_token.parent = p_MacroAssignment_ref;
			p_AgentCapabilitiesMacro.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_ObjectIdentifierValue.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_9, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroAssignment: valuereference-token TrapTypeMacro "::=" IntegerValue

		//

		public MacroAssignment MacroAssignment_10 (valuereference_token p_valuereference_token, TrapTypeMacro p_TrapTypeMacro, SyntaxTreeToken p_token, IntegerValue p_IntegerValue)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_valuereference_token, p_TrapTypeMacro, p_token, p_IntegerValue);
			p_valuereference_token.parent = p_MacroAssignment_ref;
			p_TrapTypeMacro.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_IntegerValue.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_10, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroAssignment: typereference-token "::=" ModuleIdentityMacro

		//

		public MacroAssignment MacroAssignment_11 (typereference_token p_typereference_token, SyntaxTreeToken p_token, ModuleIdentityMacro p_ModuleIdentityMacro)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_typereference_token, p_token, p_ModuleIdentityMacro);
			p_typereference_token.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_ModuleIdentityMacro.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_11, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroAssignment: typereference-token "::=" ObjectIdentityMacro

		//

		public MacroAssignment MacroAssignment_12 (typereference_token p_typereference_token, SyntaxTreeToken p_token, ObjectIdentityMacro p_ObjectIdentityMacro)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_typereference_token, p_token, p_ObjectIdentityMacro);
			p_typereference_token.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_ObjectIdentityMacro.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_12, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroAssignment: typereference-token "::=" ObjectTypeMacro

		//

		public MacroAssignment MacroAssignment_13 (typereference_token p_typereference_token, SyntaxTreeToken p_token, ObjectTypeMacro p_ObjectTypeMacro)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_typereference_token, p_token, p_ObjectTypeMacro);
			p_typereference_token.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_ObjectTypeMacro.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_13, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroAssignment: typereference-token "::=" NotificationTypeMacro

		//

		public MacroAssignment MacroAssignment_14 (typereference_token p_typereference_token, SyntaxTreeToken p_token, NotificationTypeMacro p_NotificationTypeMacro)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_typereference_token, p_token, p_NotificationTypeMacro);
			p_typereference_token.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_NotificationTypeMacro.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_14, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroAssignment: typereference-token "::=" TextualConventionMacro

		//

		public MacroAssignment MacroAssignment_15 (typereference_token p_typereference_token, SyntaxTreeToken p_token, TextualConventionMacro p_TextualConventionMacro)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_typereference_token, p_token, p_TextualConventionMacro);
			p_typereference_token.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_TextualConventionMacro.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_15, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroAssignment: typereference-token "::=" ObjectGroupMacro

		//

		public MacroAssignment MacroAssignment_16 (typereference_token p_typereference_token, SyntaxTreeToken p_token, ObjectGroupMacro p_ObjectGroupMacro)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_typereference_token, p_token, p_ObjectGroupMacro);
			p_typereference_token.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_ObjectGroupMacro.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_16, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroAssignment: typereference-token "::=" NotificationGroupMacro

		//

		public MacroAssignment MacroAssignment_17 (typereference_token p_typereference_token, SyntaxTreeToken p_token, NotificationGroupMacro p_NotificationGroupMacro)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_typereference_token, p_token, p_NotificationGroupMacro);
			p_typereference_token.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_NotificationGroupMacro.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_17, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroAssignment: typereference-token "::=" ModuleComplianceMacro

		//

		public MacroAssignment MacroAssignment_18 (typereference_token p_typereference_token, SyntaxTreeToken p_token, ModuleComplianceMacro p_ModuleComplianceMacro)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_typereference_token, p_token, p_ModuleComplianceMacro);
			p_typereference_token.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_ModuleComplianceMacro.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_18, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroAssignment: typereference-token "::=" AgentCapabilitiesMacro

		//

		public MacroAssignment MacroAssignment_19 (typereference_token p_typereference_token, SyntaxTreeToken p_token, AgentCapabilitiesMacro p_AgentCapabilitiesMacro)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_typereference_token, p_token, p_AgentCapabilitiesMacro);
			p_typereference_token.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_AgentCapabilitiesMacro.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_19, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroAssignment: typereference-token "::=" TrapTypeMacro

		//

		public MacroAssignment MacroAssignment_20 (typereference_token p_typereference_token, SyntaxTreeToken p_token, TrapTypeMacro p_TrapTypeMacro)
		{
			MacroAssignment p_MacroAssignment_ref = new MacroAssignment(p_typereference_token, p_token, p_TrapTypeMacro);
			p_typereference_token.parent = p_MacroAssignment_ref;
			p_token.parent = p_MacroAssignment_ref;
			p_TrapTypeMacro.parent = p_MacroAssignment_ref;
			Raise_MacroAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroAssignment.production_kind.g_MacroAssignment_20, p_MacroAssignment_ref);
			return p_MacroAssignment_ref;
		}
		#endregion
	};
}
