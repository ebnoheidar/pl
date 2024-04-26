namespace PL_language.Tokens.TokenInfo
{
    internal class WhiteSpaceToken : BaseToken
    {
        public WhiteSpaceToken()
        {
            Lexem = " ";
            Token = "T_Whitespaⅽe";
            Type = TokenTypes.Whitespace;
        }
    }
}
