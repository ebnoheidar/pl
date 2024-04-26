using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class CharacterToken : BaseToken
    {
        public CharacterToken()
        {
            Lexem = "";
            Token = "T_Ⅽharaⅽter";
            Type = TokenTypes.ConstantString;
        }
    }
}
