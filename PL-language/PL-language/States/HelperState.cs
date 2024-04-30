using PL_language.Tokens;
using PL_language.Tokens.TokenInfo;

namespace PL_language.States
{
    internal class HelperState
    {
        internal static List<BaseToken> Tokens = new List<BaseToken>();
        internal bool CheckWhiteSpace(char character)
        {
            return Tokens.Where(item => item.Type == TokenTypes.Whitespace &&
            character == item.Lexem[0]).Count() > 0;
        }
        internal bool CheckDivision(char character) { return character == '/'; }
        internal bool CheckNewLine(char character) { return character == '\n'; }
        internal bool CheckSignChar(char character)
        {
            return Tokens.Where(item =>
            item.Type == TokenTypes.Operators && character == item.Lexem[0] ||
            item.Type == TokenTypes.Sign && character == item.Lexem[0]).Count() > 0;
        }
        /// <summary>
        /// check a to z and numbers and underline
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        internal bool CheckAllowedWord(char character)
        {
            return char.IsLetterOrDigit(character) || character == '_';
        }
        /// <summary>
        /// Check a to z and underline
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        internal bool CheckAllowedWordForFirst(char character)
        {
            return char.IsLetter(character) || character == '_';
        }
        internal BaseToken IdentifyWordToken(string token)
        {
            List<BaseToken> tokens = Tokens.Where(item => item.Lexem == token).ToList();
            if (tokens.Count() == 1)
                return tokens[0];
            else
            {
                return new IdToken();
            }
        }
        internal void WhiteSpaceReader(DFA dfa, char input)
        {
            while (CheckWhiteSpace(input))
            {
                dfa.SetCodePosition(dfa.GetCodePosition() + 1);
                input = dfa.code[dfa.GetCodePosition()];
            }
            dfa.SetBaseToken(new WhiteSpaceToken());
        }
        internal BaseToken GetOperatorToken(string lexem)
        {
            return Tokens.Where(item => item.Type == TokenTypes.Operators &&
            item.Lexem == lexem).ToArray().First();
        }
    }
}
