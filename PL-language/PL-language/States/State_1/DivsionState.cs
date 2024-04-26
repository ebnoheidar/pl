namespace PL_language.States.State_1
{
    internal class DivisionState : StateBase
    {
        internal DivisionState(StartState beforeState)
        {
            StateName = "Division";
            BeforeState = beforeState;
        }
        public override StateBase ReadCharacter(char input, DFA dfa)
        {
            HelperState helperState = new HelperState();
            if (BeforeState is StartState && helperState.CheckDivision(input))
            {
                return new CommentState(this);
            }
            else
            {
                throw new Exception($"Error in {input} input character /" +
                    $" position: {dfa.GetCodePosition()} (Divivsion State #101)");
            }
        }
    }
}
