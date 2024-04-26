using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class NotEqualToken : BaseToken
    {
        public NotEqualToken()
        {
            Lexem = "!=";
            Token = "T_ROp_NE";
            Type = TokenTypes.Operators;
        }
    }
}
