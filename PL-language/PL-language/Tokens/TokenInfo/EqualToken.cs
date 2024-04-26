namespace PL_language.Tokens.TokenInfo
{
    internal class EqualToken : BaseToken
    {
        public EqualToken()
        {
            Lexem = "==";
            Token = "T_ROp_E";
            Type = TokenTypes.Operators;
        }
    }
}
