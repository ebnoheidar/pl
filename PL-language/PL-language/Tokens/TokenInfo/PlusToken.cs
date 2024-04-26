using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class PlusToken : BaseToken
    {
        public PlusToken()
        {
            Lexem = "+";
            Token = "T_AOp_PⅬ";
            Type = TokenTypes.Operators;
        }
    }
}
