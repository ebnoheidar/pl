using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class ForToken : BaseToken
    {
        public ForToken()
        {
            Lexem = "for";
            Token = "T_Forⅼ";
            Type = TokenTypes.Keyword;
        }
    }
}
