using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class NewLineToken : BaseToken
    {
        public NewLineToken()
        {
            Lexem = "\n";
            Token = "T_Whitespaⅽe";
            Type = TokenTypes.Keyword;
        }
    }
}
