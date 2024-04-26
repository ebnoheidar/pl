using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class IntToken : BaseToken
    {
        public IntToken()
        {
            Lexem = "int";
            Token = "T_Int";
            Type = TokenTypes.Keyword;
        }
    }
}
