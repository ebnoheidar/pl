using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class OpenBlockToken : BaseToken
    {
        public OpenBlockToken()
        {
            Lexem = "{";
            Token = "T_ⅬⅭ";
            Type = TokenTypes.Sign;
        }
    }
}
