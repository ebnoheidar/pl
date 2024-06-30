using PL_language.States.State_1;
using PL_language.Tokens;

namespace PL_language.States.KeywordStates
{
    internal class SignState : StateBase
    {
        public override StateBase ReadCharacter()
        {
            HelperState helperState = new HelperState();
            BaseToken tokenIdentify = helperState.IdentifyWordToken(DFA.CharacterPointer.ToString());
            if(tokenIdentify.Type== TokenTypes.Id)
            {
                return new TokenizeState();
            }
            else
            {
                DFA.SetBaseToken(tokenIdentify);
                DFA.codePosition++;
                return new TokenizeState();
            }
        }
    }
}
