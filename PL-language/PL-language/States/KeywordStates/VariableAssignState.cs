using PL_language.States.ConstantStates;

namespace PL_language.States.KeywordStates
{
    internal class VariableAssignState : StateBase
    {
        public override StateBase ReadCharacter()
        {
            HelperState helperState = new HelperState();
            if (helperState.CheckWhiteSpace(DFA.CharacterPointer))
            {
                helperState.WhiteSpaceReader();
                return this;
            }
            else if (DFA.CharacterPointer == '\"')
                return new StringState();
            else if (Char.IsDigit(DFA.CharacterPointer))
            {
                DFA.codePosition--;
                return new NumberState("");
            }
            else if (DFA.CharacterPointer == '-' || DFA.CharacterPointer == '+')
            {
                DFA.codePosition--;
                return new SignNumberState();
            }
            else
                throw new Exception($"Error: error in assign/" + $" position: {DFA.GetCodePosition()} (Variable Assign State #112)");

        }
    }
}
