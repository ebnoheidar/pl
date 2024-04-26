namespace PL_language.States.State_1
{
    internal class StartState : StateBase
    {
        public StartState() { StateName = "Start State"; }
        public override StateBase ReadCharacter(char input, DFA dfa)
        {
            HelperState helperState = new HelperState();
            if (helperState.CheckWhiteSpace(input))
            {
                return new StartState();
            }
            else if (helperState.CheckDivision(input))
            {
                return new DivisionState(this);
            }
        }
    }
}
