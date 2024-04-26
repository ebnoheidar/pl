using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class WhiteSpaceToken : BaseToken
    {
        public WhiteSpaceToken()
        {
            Lexem = " ";
            Token = "T_Whitespaⅽe";
            Type = TokenTypes.Keyword;
        }
    }
}
