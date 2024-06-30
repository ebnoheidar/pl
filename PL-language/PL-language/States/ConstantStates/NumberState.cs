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
        public override StateBase ReadCharacter()
        {
            HelperState helperState = new HelperState();
            Number += DFA.CharacterPointer;

            if (helperState.CheckWhiteSpace(DFA.CharacterPointer) || DFA.CharacterPointer == ';')
            {
                if (Number.StartsWith("0x"))
                    DFA.SetBaseToken(new Tokens.TokenInfo.HexadecimalToken());
                else
                    DFA.SetBaseToken(new Tokens.TokenInfo.DecimalToken());
                DFA.codePosition++;
                return new FinalState(new StartState());
            }
            else if (Char.IsDigit(DFA.CharacterPointer))
            {
                return new NumberState(Number);
            }
            else if (DFA.CharacterPointer == 'x')
            {
                if (Number == "0")
                {
                    return new NumberState(Number);
                }
                else
                    throw new Exception($"Error: {Number} was not declared in this scope /" +
                    $" position: {DFA.GetCodePosition()} (Number State #108)");
            }
            else if (Char.IsLetter(DFA.CharacterPointer) && Number.StartsWith("0x"))
            {
                if ((DFA.CharacterPointer >= 65 && DFA.CharacterPointer <= 70) || (DFA.CharacterPointer >= 97 && DFA.CharacterPointer <= 102))
                { return new NumberState(Number); }
                else
                    throw new Exception($"Error: unable to find numeric literal operator {Number}/" +
                    $" position: {DFA.GetCodePosition()} (Divivsion State #109)");
            }
            else
                throw new Exception($"Error: Not allowed character after number {Number} /" +
                    $" position: {DFA.GetCodePosition()} (Number State #110)");
        }
    }
}
