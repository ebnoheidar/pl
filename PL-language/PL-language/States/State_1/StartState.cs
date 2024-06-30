using PL_language.Tokens.TokenInfo;

namespace PL_language.States.State_1
{
    internal class StartState : StateBase
    {
        public StartState() { StateName = "Start State"; }
        public override StateBase ReadCharacter()
        {
            HelperState helperState = new HelperState();
            if (helperState.CheckWhiteSpace(DFA.CharacterPointer))
            {
                helperState.WhiteSpaceReader();
                return new StartState();
            }
            else if (helperState.CheckDivision(DFA.CharacterPointer))
            {
                DFA.codePosition++;
                return new DivisionState(this, this);
            }
            else if (helperState.CheckAllowedWordForFirst(DFA.CharacterPointer))
            {
                return new TokenizeState();
            }
            else
                throw new Exception($"Error in {DFA.CharacterPointer} dfa.CharacterPointer character /" +
                    $" position: {DFA.GetCodePosition()} (Start State #104)");
        }
    }
}
