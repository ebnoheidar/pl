using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class TrueToken : BaseToken
    {
        public TrueToken()
        {
            Lexem = "true";
            Token = "T_True";
            Type = TokenTypes.Keyword;
        }
    }
}
