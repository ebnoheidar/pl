using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class LessEqualToken : BaseToken
    {
        public LessEqualToken()
        {
            Lexem = "<=";
            Token = "T_ROp_ⅬE";
            Type = TokenTypes.Operators;
        }
    }
}
