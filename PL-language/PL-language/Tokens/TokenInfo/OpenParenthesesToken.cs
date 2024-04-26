namespace PL_language.Tokens.TokenInfo
{
    internal class OpenParenthesesToken : BaseToken
    {
        public OpenParenthesesToken()
        {
            Lexem = "(";
            Token = "T_ⅬP";
            Type = TokenTypes.Sign;
        }
    }
}
