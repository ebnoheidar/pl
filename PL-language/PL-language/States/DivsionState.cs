using PL_language.States.KeywordStates;
using PL_language.States.State_1;

namespace PL_language.States
{
    internal class DivisionState : StateBase
    {
        private StateBase backState { get; set; }
        internal DivisionState(StateBase beforeState, StateBase backState)
        {
            StateName = "Division";
            BeforeState = beforeState;
            this.backState = backState;
        }
        public override StateBase ReadCharacter(char input, DFA dfa)
        {
            HelperState helperState = new HelperState();
            if ((BeforeState is StartState || BeforeState is VariableState) && helperState.CheckDivision(input))
            {
                return new CommentState(this, backState);
            }
            else
            {
                throw new Exception($"Error in {input} input character /" +
                    $" position: {dfa.GetCodePosition()} (Divivsion State #101)");
            }
        }
    }
}
