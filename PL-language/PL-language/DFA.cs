using PL_language.States;
using PL_language.Tokens;

namespace PL_language
{
    internal class DFA
    {
        public string code { get; set; }
        private int codePosition { get; set; }
        private StateBase currentState { get; set; }
        private string tokens { get; set; }
        public void SetState(StateBase state)
        {
            currentState = state;
            codePosition += 1;
            SetState(currentState.ReadCharacter(code[codePosition], this));
        }
        public void SetBaseToken(BaseToken token)
        {
            tokens = tokens + Environment.NewLine + token.Token;
        }
        public void SetCodePosition(int codePosition)
        {
            this.codePosition = codePosition;
        }
        public int GetCodePosition() { return codePosition; }
        public string getTokens()
        {
            return tokens;
        }
    }
}
