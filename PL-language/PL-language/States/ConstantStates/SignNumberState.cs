namespace PL_language.States.ConstantStates
{
    internal class SignNumberState : StateBase

    {
        public override StateBase ReadCharacter()
        {
            HelperState helperState = new HelperState();
            if (helperState.CheckWhiteSpace(DFA.CharacterPointer))
            {
                helperState.WhiteSpaceReader();
                return new SignNumberState();
            }
            else if (DFA.CharacterPointer == '+')
            {
                DFA.SetBaseToken(new Tokens.TokenInfo.PlusToken());
            }
            else if (DFA.CharacterPointer == '-')
            {
                DFA.SetBaseToken(new Tokens.TokenInfo.MinusToken());
            }
            else throw new Exception($"Error: Error in sign number /" +
                    $" position: {DFA.GetCodePosition()} (Sign Number State #111)"); helperState.WhiteSpaceReader();
            DFA.codePosition++;
            return new NumberState(DFA.CharacterPointer.ToString());
        }
    }
}
