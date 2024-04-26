using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class StringToken : BaseToken
    {
        public StringToken()
        {
            Lexem = "";
            Token = "T_String";
            Type = TokenTypes.Keyword;
        }
    }
}
