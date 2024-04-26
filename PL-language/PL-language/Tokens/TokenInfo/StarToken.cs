using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class StarToken : BaseToken
    {
        public StarToken()
        {
            Lexem = "*";
            Token = "T_AOp_ⅯⅬ";
            Type = TokenTypes.Operators;
        }
    }
}
