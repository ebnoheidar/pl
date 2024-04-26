using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class CommaToken : BaseToken
    {
        public CommaToken()
        {
            Lexem = ",";
            Token = "T_Ⅽoⅿⅿa";
            Type = TokenTypes.Sign;
        }
    }
}
