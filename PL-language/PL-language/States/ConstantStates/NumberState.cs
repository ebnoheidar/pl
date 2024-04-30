using PL_language.States.State_1;

namespace PL_language.States.ConstantStates
{
    internal class NumberState : StateBase
    {
        public string Number { get; set; }
        public NumberState(string beforNumber)
        {
            Number = beforNumber;
        }
        public override StateBase ReadCharacter(char input, DFA dfa)
        {
            HelperState helperState = new HelperState();
            Number += input;

            if (helperState.CheckWhiteSpace(input) || input == ';')
            {
                if (Number.StartsWith("0x"))
                    dfa.SetBaseToken(new Tokens.TokenInfo.HexadecimalToken());
                else
                    dfa.SetBaseToken(new Tokens.TokenInfo.DecimalToken());
                dfa.SetCodePosition(dfa.GetCodePosition() - 1);
                return new FinalState(new StartState());
            }
            else if (Char.IsDigit(input))
            {
                return new NumberState(Number);
            }
            else if (input == 'x')
            {
                if (Number == "0")
                {
                    return new NumberState(Number);
                }
                else
                    throw new Exception($"Error: {Number} was not declared in this scope /" +
                    $" position: {dfa.GetCodePosition()} (Number State #108)");
            }
            else if (Char.IsLetter(input) && Number.StartsWith("0x"))
            {
                if ((input >= 65 && input <= 70) || (input >= 97 && input <= 102))
                { return new NumberState(Number); }
                else
                    throw new Exception($"Error: unable to find numeric literal operator {Number}/" +
                    $" position: {dfa.GetCodePosition()} (Divivsion State #109)");
            }
            else
                throw new Exception($"Error: Not allowed character after number {Number} /" +
                    $" position: {dfa.GetCodePosition()} (Number State #110)");
        }
    }
}
