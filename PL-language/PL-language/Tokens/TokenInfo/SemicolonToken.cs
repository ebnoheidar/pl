using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class SemicolonToken : BaseToken
    {
        public SemicolonToken()
        {
            Lexem = ";";
            Token = "T_Seⅿiⅽoⅼon";
            Type = TokenTypes.Sign;
        }
    }
}
