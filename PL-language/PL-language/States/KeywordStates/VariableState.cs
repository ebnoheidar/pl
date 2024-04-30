using PL_language.Tokens.TokenInfo;

namespace PL_language.States.KeywordStates
{
    internal class VariableState : StateBase
    {
        public override StateBase ReadCharacter(char input, DFA dfa)
        {
            HelperState helperState = new HelperState();
            if (helperState.CheckWhiteSpace(input))
            {
                helperState.WhiteSpaceReader(dfa, input);
                dfa.SetBaseToken(new WhiteSpaceToken());
                return (this);
            }
            else if (helperState.CheckDivision(input))
            {
                return new DivisionState(this, this);
            }
            else if (helperState.CheckAllowedWordForFirst(input))
            {
                return new TokenWordState();
            }
            else
                throw new Exception($"Error: in variable state/" +
                   $" position: {dfa.GetCodePosition()} (Tokenize State #103)");
        }
    }
}
