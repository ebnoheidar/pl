using PL_language.Tokens.TokenInfo;

namespace PL_language.States
{
    internal class FinalState : StateBase
    {
        private StateBase backState { get; set; }
        internal FinalState(StateBase backState)
        {
            StateName = "Final";
            this.backState = backState;
        }
        public override StateBase ReadCharacter()
        {
            HelperState helperState = new HelperState();
            if (helperState.CheckWhiteSpace(DFA.CharacterPointer))
            {
                helperState.WhiteSpaceReader();
                return this;
            }
            else if (DFA.CharacterPointer == ';')
            {
                DFA.SetBaseToken(new SemicolonToken());
                return backState;
            }
            else
            {
                throw new Exception($"expected ‘;’ /" +
                    $" position: {DFA.GetCodePosition()} (Final State #107)");
            }
        }
    }
}
