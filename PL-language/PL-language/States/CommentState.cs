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
        public override StateBase ReadCharacter()
        {
            ReadComments();
            return backState;
        }
        public void ReadComments()
        {
            HelperState helperState = new HelperState();
            while (!helperState.CheckNewLine(DFA.CharacterPointer))
            {
                DFA.codePosition++;
            }
            DFA.SetBaseToken(new Tokens.TokenInfo.NewLineToken());
        }
    }
}
