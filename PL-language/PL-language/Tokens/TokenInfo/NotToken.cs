using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class NotToken : BaseToken
    {
        public NotToken()
        {
            Lexem = "!";
            Token = "T_ⅬOp_NOT";
            Type = TokenTypes.Keyword;
        }
    }
}
