using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class HexadecimalToken : BaseToken
    {
        public HexadecimalToken()
        {
            Lexem = "";
            Token = "T_Hexaⅾeⅽiⅿaⅼ";
            Type = TokenTypes.Number;
        }
    }
}
