using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class OrToken : BaseToken
    {
        public OrToken()
        {
            Lexem = "||";
            Token = "T_ⅬOp_OR";
            Type = TokenTypes.Operators;
        }
    }
}
