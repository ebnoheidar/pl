namespace PL_language.States.State_1
{
    internal class CommentState : StateBase
    {
        internal CommentState(StateBase beforeState)
        {
            StateName = "comment";
            BeforeState = beforeState;
        }
        public override StateBase ReadCharacter(char input, DFA dfa)
        {
            ReadComments(input, dfa);
            return new StartState();
        }
        public void ReadComments(char input, DFA dfa)
        {
            HelperState helperState = new HelperState();
            while (!helperState.CheckNewLine(input))
            {
                dfa.SetCodePosition(dfa.GetCodePosition() + 1);
                input = dfa.code[dfa.GetCodePosition()];
            }
            dfa.SetBaseToken(new Tokens.TokenInfo.NewLineToken());
        }
    }
}
