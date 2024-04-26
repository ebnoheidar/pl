namespace PL_language.Tokens.TokenInfo
{
    internal class ElseToken : BaseToken
    {
        public ElseToken()
        {
            Lexem = "else";
            Token = "T_Eⅼse";
            Type = TokenTypes.Keyword;
        }
    }
}
