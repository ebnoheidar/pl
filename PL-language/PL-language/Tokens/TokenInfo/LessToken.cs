﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class LessToken : BaseToken
    {
        public LessToken()
        {
            Lexem = "<";
            Token = "T_ROp_Ⅼ";
            Type = TokenTypes.Operators;
        }
    }
}
