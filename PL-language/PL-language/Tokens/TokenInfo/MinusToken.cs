using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class MinusToken : BaseToken
    {
        public MinusToken()
        {
            Lexem = "-";
            Token = "T_AOp_ⅯN";
            Type = TokenTypes.Operators;
        }
    }
}
