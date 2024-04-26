using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens.TokenInfo
{
    internal class CommentToken : BaseToken
    {
        public CommentToken()
        {
            Lexem = "";
            Token = "T_Ⅽoⅿⅿentⅼ";
            Type = TokenTypes.Comment;
        }
    }
}
