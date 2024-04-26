namespace PL_language.Tokens.TokenInfo
{
    internal class FalseToken : BaseToken
    {
        public FalseToken()
        {
            Lexem = "false";
            Token = "T_Faⅼse";
            Type = TokenTypes.Keyword;
        }
    }
}
