using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class BreakToken : BaseToken
    {
        public BreakToken()
        {
            Lexem = "break";
            Token = "T_Breakⅼ";
            Type = TokenTypes.Keyword;
        }
    }
}
