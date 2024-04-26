using PL_language.Tokens.TokenInfo;

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
                while (helperState.CheckWhiteSpace(input))
                {
                    dfa.SetCodePosition(dfa.GetCodePosition() + 1);
                    input = dfa.code[dfa.GetCodePosition()];
                }
                dfa.SetCodePosition(dfa.GetCodePosition() - 1);
                dfa.SetBaseToken(new WhiteSpaceToken());
                return new StartState();
            }
            else if (helperState.CheckDivision(input))
            {
                return new DivisionState(this, this);
            }
            else if (helperState.CheckAllowedWordForFirst(input))
            {
                return new TokenizeState();
            }
            else
                throw new Exception($"Error in {input} input character /" +
                    $" position: {dfa.GetCodePosition()} (Start State #104)");
        }
    }
}
