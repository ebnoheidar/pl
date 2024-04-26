using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class DecimalToken : BaseToken
    {
        public DecimalToken()
        {
            Lexem = "";
            Token = "T_Ⅾeⅽiⅿaⅼⅼ";
            Type = TokenTypes.Number;
        }
    }
}
