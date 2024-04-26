using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class  CharToken : BaseToken
    {
        public CharToken()
        {
            Lexem = "char";
            Token = "T_Ⅽharⅼ";
            Type = TokenTypes.Keyword;
        }
    }
}
