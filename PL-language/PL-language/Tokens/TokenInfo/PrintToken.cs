using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class PrintToken : BaseToken
    {
        public PrintToken()
        {
            Lexem = "print";
            Token = "T_Print";
            Type = TokenTypes.Keyword;
        }
    }
}
