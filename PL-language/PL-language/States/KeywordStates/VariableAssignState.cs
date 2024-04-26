using PL_language.States.ConstantStates;

namespace PL_language.States.KeywordStates
{
    internal class VariableAssignState : StateBase
    {
        public override StateBase ReadCharacter(char input, DFA dfa)
        {
            HelperState helperState = new HelperState();
            if (helperState.CheckWhiteSpace(input))
            {
                helperState.WhiteSpaceReader(dfa, input);
                return this;
            }
            else if (input == '\"')
                return StringState();
        }
    }
}
