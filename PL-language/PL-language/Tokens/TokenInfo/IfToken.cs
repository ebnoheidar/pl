namespace PL_language.Tokens.TokenInfo
{
    internal class IfToken : BaseToken
    {
        public IfToken()
        {
            Lexem = "if";
            Token = "T_If";
            Type = TokenTypes.Keyword;
        }
    }
}
