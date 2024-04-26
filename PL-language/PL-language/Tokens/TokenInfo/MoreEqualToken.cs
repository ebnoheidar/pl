using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class MoreEqualToken : BaseToken
    {
        public MoreEqualToken()
        {
            Lexem = ">=";
            Token = "T_ROp_GE";
            Type = TokenTypes.Operators;
        }
    }
}
