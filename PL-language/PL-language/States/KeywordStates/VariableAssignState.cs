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
                return new StringState();
            else if(Char.IsDigit(input))
            {
                dfa.SetCodePosition(dfa.GetCodePosition()-1);
                return new NumberState("");
            }
            else if (input == '-' || input == '+')
            {
                dfa.SetCodePosition(dfa.GetCodePosition() - 1);
                return new SignNumberState();
            }
            else
                throw  new Exception($"Error: error in assign/" +
     $" position: {dfa.GetCodePosition()} (Variable Assign State #112)");

        }
    }
}
