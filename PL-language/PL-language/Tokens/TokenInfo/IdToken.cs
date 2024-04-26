using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class IdToken : BaseToken
    {
        public IdToken()
        {
            Lexem = "";
            Token = "T_Iⅾ";
            Type = TokenTypes.Id;
        }
    }
}
