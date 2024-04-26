using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class ContinueToken : BaseToken
    {
        public ContinueToken()
        {
            Lexem = "continue";
            Token = "T_Ⅽontinueⅼ";
            Type = TokenTypes.Keyword;
        }
    }
}
