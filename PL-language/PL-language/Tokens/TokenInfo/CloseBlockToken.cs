using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class CloseBlockToken : BaseToken
    {
        public CloseBlockToken()
        {
            Lexem = "}";
            Token = "T_RⅭ";
            Type = TokenTypes.Sign;
        }
    }
}
