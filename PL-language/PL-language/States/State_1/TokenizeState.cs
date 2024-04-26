using PL_language.Tokens;

namespace PL_language.States.State_1
{
    internal class TokenizeState : StateBase
    {
        public override StateBase ReadCharacter(char input, DFA dfa)
        {
            HelperState helperState = new HelperState();
            string token = "";
            while (!helperState.CheckWhiteSpace(input) && !helperState.CheckSignChar(input))
            {
                if (helperState.CheckAllowedWord(input))
                {
                    token += input;
                    dfa.SetCodePosition(dfa.GetCodePosition() + 1);
                    input = dfa.code[dfa.GetCodePosition()];
                }
                else
                {
                    throw new Exception($"Identifier \"{input}\" undefined /" +
                    $" position: {dfa.GetCodePosition()} (Divivsion State #102)");
                }
            }
            dfa.SetCodePosition(dfa.GetCodePosition() - 1);
            BaseToken tokenIdentify = helperState.IdentifyWordToken(token);



        }
    }
}
