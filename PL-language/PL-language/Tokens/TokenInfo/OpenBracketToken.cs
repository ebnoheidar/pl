using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class OpenBracketToken : BaseToken
    {
        public OpenBracketToken()
        {
            Lexem = "[";
            Token = "T_ⅬB";
            Type = TokenTypes.Keyword;
        }
    }
}
