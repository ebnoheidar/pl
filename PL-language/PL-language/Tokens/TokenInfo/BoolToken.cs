using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class BoolToken : BaseToken
    {
        public BoolToken()
        {
            Lexem = "bool";
            Token = "T_Booⅼ";
            Type = TokenTypes.Keyword;
        }
    }
}
