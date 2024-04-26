namespace PL_language.States
{
    internal class CommentState : StateBase
    {
        private StateBase backState { get; set; }
        internal CommentState(StateBase beforeState, StateBase backState)
        {
            StateName = "comment";
            BeforeState = beforeState;
            this.backState = backState;
        }
        public override StateBase ReadCharacter(char input, DFA dfa)
        {
            ReadComments(input, dfa);
            return backState;
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
