using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class ReturnToken : BaseToken
    {
        public ReturnToken()
        {
            Lexem = "return";
            Token = "T_Return";
            Type = TokenTypes.Keyword;
        }
    }
}
