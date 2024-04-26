using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class DivisionToken : BaseToken
    {
        public DivisionToken()
        {
            Lexem = "/";
            Token = "T_AOp_ⅮVⅼ";
            Type = TokenTypes.Operators;
        }
    }
}
