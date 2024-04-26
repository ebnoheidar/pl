using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class TabToken : BaseToken
    {
        public TabToken()
        {
            Lexem = "   ";
            Token = "T_Whitespace";
            Type = TokenTypes.Whitespace;
        }
    }
}
