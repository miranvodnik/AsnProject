using Asn.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsnLibrary
{
    public static class AsnDataBase
    {
        public static string [] GlobalModule { get; } = new string []
        {
            "",
            "GLOBAL-MODULE",
            "DEFINITIONS ::=",
            "BEGIN",
            "",
            "GLOBAL-INTEGER ::= INTEGER",
            "",
            "TYPE-IDENTIFIER ::= CLASS",
            "{",
            "\t&id OBJECT IDENTIFIER UNIQUE,",
            "\t&Type",
            "}",
            "WITH SYNTAX",
            "{&Type IDENTIFIED BY &id}",
            "",
            "ABSTRACT-SYNTAX ::= CLASS",
            "{",
            "\t&id OBJECT IDENTIFIER UNIQUE,",
            "\t&Type,",
            "\t&property BIT STRING {handles-invalid-encodings(0)} DEFAULT {}",
            "}",
            "WITH SYNTAX",
            "{&Type IDENTIFIED BY &id [HAS PROPERTY &property]}",
            "",
            "EmbeddedPDVType ::= SEQUENCE",
            "{",
            "\tidentification CHOICE",
            "\t{",
            "\t\t-- Abstract and transfer syntax object identifiers",
            "\t\tsyntaxes SEQUENCE",
            "\t\t{",
            "\t\t\tabstract OBJECT IDENTIFIER,",
            "\t\t\ttransfer OBJECT IDENTIFIER",
            "\t\t},",

            "\t\t-- A single object identifier for identification of the abstract",
            "\t\t-- and transfer syntaxes",
            "\t\tsyntax OBJECT IDENTIFIER,",

            "\t\t-- (Applicable only to OSI environments)",
            "\t\t-- The negotiated OSI presentation context identifies the",
            "\t\t-- abstract and transfer syntaxes",
            "\t\tpresentation-context-id INTEGER,",

            "\t\t-- (Applicable only to OSI environments)",
            "\t\t-- Context-negotiation in progress, presentation-context-id",
            "\t\t-- identifies only the abstract syntax",
            "\t\t-- so the transfer syntax shall be specified",
            "\t\tcontext-negotiation SEQUENCE ",
            "\t\t{",
            "\t\t\tpresentation-context-id INTEGER,",
            "\t\t\ttransfer-syntax OBJECT IDENTIFIER ",
            "\t\t},",

            "\t\t-- The type of the value (for example, specification that it is",
            "\t\t-- the value of an ASN.1 type)",
            "\t\t-- is fixed by the application designer (and hence known to both",
            "\t\t-- sender and receiver). This",
            "\t\t-- case is provided primarily to support",
            "\t\t-- selective-field-encryption (or other encoding",
            "\t\t-- transformations) of an ASN.1 type",
            "\t\ttransfer-syntax OBJECT IDENTIFIER,",

            "\t\t-- The data value is the value of a fixed ASN.1 type (and hence",
            "\t\t-- known to both sender",
            "\t\t-- and receiver)",
            "\t\tfixed NULL",
            "\t},",

            "\t-- This provides human-readable identification of the class of the",
            "\t-- value",
            "\tdata-value-descriptor ObjectDescriptor OPTIONAL,",
            "\tdata-value OCTET STRING",
            "}",
            "(",
            "\tWITH COMPONENTS",
            "\t{",
            "\t\t... ,",
            "\t\tdata-value-descriptor ABSENT",
            "\t}",
            ")",
            "",
            "ExternalType ::= SEQUENCE",
            "{",
            "\tidentification CHOICE",
            "\t{",
            "\t\t-- Abstract and transfer syntax object identifiers",
            "\t\tsyntaxes SEQUENCE",
            "\t\t{",
            "\t\t\tabstract OBJECT IDENTIFIER,",
            "\t\t\ttransfer OBJECT IDENTIFIER",
            "\t\t},",

            "\t\t-- A single object identifier for identification of the abstract",
            "\t\t-- and transfer syntaxes",
            "\t\tsyntax OBJECT IDENTIFIER,",

            "\t\t-- (Applicable only to OSI environments)",
            "\t\t-- The negotiated OSI presentation context identifies the",
            "\t\t-- abstract and transfer syntaxes",
            "\t\tpresentation-context-id INTEGER,",

            "\t\t-- (Applicable only to OSI environments)",
            "\t\t-- Context-negotiation in progress, presentation-context-id",
            "\t\t-- identifies only the abstract syntax",
            "\t\t-- so the transfer syntax shall be specified",
            "\t\tcontext-negotiation SEQUENCE",
            "\t\t{",
            "\t\t\tpresentation-context-id INTEGER,",
            "\t\t\ttransfer-syntax OBJECT IDENTIFIER",
            "\t\t},",

            "\t\t-- The type of the value (for example, specification that it is",
            "\t\t-- the value of an ASN.1 type)",
            "\t\t-- is fixed by the application designer (and hence known to both",
            "\t\t-- sender and receiver). This",
            "\t\t-- case is provided primarily to support",
            "\t\t-- selective-field-encryption (or other encoding",
            "\t\t-- transformations) of an ASN.1 type",
            "\t\ttransfer-syntax OBJECT IDENTIFIER,",

            "\t\t-- The data value is the value of a fixed ASN.1 type (and hence",
            "\t\t-- known to both sender",
            "\t\t-- and receiver)",
            "\t\tfixed NULL",
            "\t},",

            "\t-- This provides human-readable identification of the class of",
            "\t-- the value",
            "\tdata-value-descriptor ObjectDescriptor OPTIONAL,",
            "\tdata-value OCTET STRING",
            "}",
            "(",
            "\tWITH COMPONENTS",
            "\t{",
            "\t\t... ,",
            "\t\tidentification",
            "\t\t(",
            "\t\t\tWITH COMPONENTS ",
            "\t\t\t{",
            "\t\t\t\t... ,",
            "\t\t\t\tsyntaxes ABSENT,",
            "\t\t\t\ttransfer-syntax ABSENT,",
            "\t\t\t\tfixed ABSENT",
            "\t\t\t}",
            "\t\t)",
            "\t}",
            ")",
            "END",
            ""
        };
        public static List<(asn_features, string)> asnFeatures { get; private set; } = new List<(asn_features, string)> ();
        public static List<(asn_features, string)> accumulatedFeatures { get; private set; } = new List<(asn_features, string)> ();
        public static ModuleCollection moduleDefinitions { get; private set; } = new ModuleCollection ();
        public static ModuleCollection accumulatedModuleDefinitions { get; private set; } = new ModuleCollection ();
        public static SymbolTable symbolTable { get; private set; } = new SymbolTable ();
        public static ReferenceCollection referenceCollection { get; private set; } = new ReferenceCollection ();
        public static ParameterDictionary ParameterCollection { get; private set; } = new ParameterDictionary ();
        public static List<string> GeneratedModules { get; private set; } = new List<string> ();

        public static void SaveFeatures()
        {
            accumulatedFeatures.AddRange (asnFeatures);
            asnFeatures.Clear ();
        }

        public static void SaveModules()
        {
            foreach (KeyValuePair<string, List<ModuleDescriptor>> keyValue in moduleDefinitions)
            {
                string moduleName = keyValue.Key;
                List<ModuleDescriptor> moduleList = keyValue.Value;
                if (!accumulatedModuleDefinitions.Keys.Contains (moduleName))
                    accumulatedModuleDefinitions [moduleName] = new List<ModuleDescriptor> ();
                accumulatedModuleDefinitions [moduleName].AddRange (moduleList);
            }
            moduleDefinitions.Clear ();
        }

        public static bool NextIteration()
        {
            if (asnFeatures.Count == 0)
                return false;
            GeneratedModules.Clear ();
            return true;
        }
    }
}
