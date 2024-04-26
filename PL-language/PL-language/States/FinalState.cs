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
        public override StateBase ReadCharacter(char input, DFA dfa)
        {
            HelperState helperState = new HelperState();
            if (helperState.CheckWhiteSpace(input))
            {
                helperState.WhiteSpaceReader(dfa, input);
                return this;
            }
            else if (input == ';')
            {
                dfa.SetBaseToken(new SemicolonToken());
                return backState;
            }
            else
            {
                throw new Exception($"expected ‘;’ /" +
                    $" position: {dfa.GetCodePosition()} (Final State #107)");
            }
        }
    }
}
