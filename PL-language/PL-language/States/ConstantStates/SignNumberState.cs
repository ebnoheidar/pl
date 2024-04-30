namespace PL_language.States.ConstantStates
{
    internal class SignNumberState : StateBase

    {
        public override StateBase ReadCharacter(char input, DFA dfa)
        {
            HelperState helperState = new HelperState();
            if (helperState.CheckWhiteSpace(input))
            {
                helperState.WhiteSpaceReader(dfa, input);
                return new SignNumberState();
            }
            else if (input == '+')
            {
                dfa.SetBaseToken(new Tokens.TokenInfo.PlusToken());
            }
            else if (input == '-')
            {
                dfa.SetBaseToken(new Tokens.TokenInfo.MinusToken());
            }
            else throw new Exception($"Error: Error in sign number /" +
                    $" position: {dfa.GetCodePosition()} (Sign Number State #111)"); helperState.WhiteSpaceReader(dfa, input);
            dfa.SetCodePosition(dfa.GetCodePosition() + 1);
            input = dfa.code[dfa.GetCodePosition()];
            return new NumberState(input.ToString());
        }
    }
}
