using PL_language.States.State_1;

namespace PL_language.States.ConstantStates
{
    internal class StringState : StateBase
    {
        public override StateBase ReadCharacter()
        {
            if (DFA.CharacterPointer == '\\')
            {
                DFA.codePosition++;
                return this;
            }
            else if (DFA.CharacterPointer == '\"')
            {
                DFA.SetBaseToken(new Tokens.TokenInfo.StringToken());
                return new FinalState(new StartState());
            }
            else
                return new StringState();
        }
    }
}
