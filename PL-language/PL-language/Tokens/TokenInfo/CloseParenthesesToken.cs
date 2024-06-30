namespace PL_language.Tokens.TokenInfo
{
    internal class CloseParenthesesToken : BaseToken
    {
        public CloseParenthesesToken()
        {
            Lexem = ")";
            Token = "T_RP";
            Type = TokenTypes.Sign;
        }
    }
}
