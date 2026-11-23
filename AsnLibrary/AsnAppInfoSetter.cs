using Anglr.Parser.Core;
using Anglr.Parser.SyntaxTree;
using Anglr.Parser.Walker;
using Asn.Parser;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsnLibrary
{
    public class AsnAppInfoSetter : SyntaxTreeWalker
    {
        public object obj { get; set; }
        private bool setop = false;

        public AsnAppInfoSetter ()
        {
            identifier_token_Event += (SyntaxTreeCallbackReason reason, identifier_token.production_kind kind, identifier_token p_identifier_token) =>
            {
                switch (reason)
                {
                    case SyntaxTreeCallbackReason.BuilderCallbackReason:
                        break;
                    case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                        if (setop)
                            p_identifier_token.m_identifier.appInfo = obj;
                        else
                            obj = p_identifier_token.m_identifier.appInfo;
                        break;
                    case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                        break;
                    case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                        break;
                }
                return true;
            };

            typereference_token_Event += (SyntaxTreeCallbackReason reason, typereference_token.production_kind kind, typereference_token p_typereference_token) =>
            {
                switch (reason)
                {
                    case SyntaxTreeCallbackReason.BuilderCallbackReason:
                        break;
                    case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                        if (setop)
                            p_typereference_token.m_typereference.appInfo = obj;
                        else
                            obj = p_typereference_token.m_typereference.appInfo;
                        break;
                    case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                        break;
                    case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                        break;
                }
                return true;
            };
        }

        public void SetInfo (SyntaxTreeBase node, object obj)
        {
            setop = true;
            this.obj = obj;
            SyntaxTreeBase.enableLocking = false;
            node.InvokeTraverse (this);
            SyntaxTreeBase.enableLocking = true;
        }

        public object GetInfo (SyntaxTreeBase node)
        {
            setop = false;
            this.obj = null;
            SyntaxTreeBase.enableLocking = false;
            node.InvokeTraverse (this);
            SyntaxTreeBase.enableLocking = true;
            return obj;
        }
    }
}
