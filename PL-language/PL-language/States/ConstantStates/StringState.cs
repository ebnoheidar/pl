using PL_language.States.State_1;

namespace PL_language.States.ConstantStates
{
    internal class StringState : StateBase
    {
        public override StateBase ReadCharacter(char input, DFA dfa)
        {
            if (input == '\\')
            {
                dfa.SetCodePosition(dfa.GetCodePosition() + 1);
                input = dfa.code[dfa.GetCodePosition()];
                return this;
            }
            else if (input == '\"')
            {
                dfa.SetBaseToken(new Tokens.TokenInfo.StringToken());
                return new FinalState(new StartState());
            }
            else
                throw new Exception($"expected ‘;’ /" +
                    $" position: {dfa.GetCodePosition()} (String State State #108)");
        }
    }
}
