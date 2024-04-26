using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class PercentToken : BaseToken
    {
        public PercentToken()
        {
            Lexem = "%";
            Token = "T_AOp_RⅯ";
            Type = TokenTypes.Operators;
        }
    }
}
