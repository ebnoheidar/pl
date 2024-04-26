using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class CloseBracketToken : BaseToken
    {
        public CloseBracketToken()
        {
            Lexem = "]";
            Token = "T_RB";
            Type = TokenTypes.Sign;
        }
    }
}
