using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class AndToken : BaseToken
    {
        public AndToken()
        {
            Lexem = "&&";
            Token = "T_ⅬOp_ANⅮ";
            Type = TokenTypes.Operators;
        }
    }
}
