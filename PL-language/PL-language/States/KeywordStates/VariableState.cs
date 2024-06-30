using PL_language.Tokens.TokenInfo;

namespace PL_language.States.KeywordStates
{
    internal class VariableState : StateBase
    {
        public override StateBase ReadCharacter()
        {
            HelperState helperState = new HelperState();
            if (helperState.CheckWhiteSpace(DFA.CharacterPointer))
            {
                helperState.WhiteSpaceReader();
                DFA.SetBaseToken(new WhiteSpaceToken());
                return (this);
            }
            else if (helperState.CheckDivision(DFA.CharacterPointer))
            {
                return new DivisionState(this, this);
            }
            else if (helperState.CheckAllowedWordForFirst(DFA.CharacterPointer))
            {
                return new TokenWordState();
            }
            else
                throw new Exception($"Error: in variable state/" +
                   $" position: {DFA.GetCodePosition()} (Tokenize State #103)");
        }
    }
}
