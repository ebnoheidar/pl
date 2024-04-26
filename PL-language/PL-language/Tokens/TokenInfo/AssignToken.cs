using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class AssignToken : BaseToken
    {
        public AssignToken()
        {
            Lexem = "=";
            Token = "T_Assign";
            Type = TokenTypes.Operators;
        }
    }
}
