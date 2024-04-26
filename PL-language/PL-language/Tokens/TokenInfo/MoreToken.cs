using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class MoreToken : BaseToken
    {
        public MoreToken()
        {
            Lexem = ">";
            Token = "T_ROp_G";
            Type = TokenTypes.Operators;
        }
    }
}
