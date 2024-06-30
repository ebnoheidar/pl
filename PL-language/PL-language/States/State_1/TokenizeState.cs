using PL_language.States.KeywordStates;
using PL_language.Tokens;

namespace PL_language.States.State_1
{
    internal class TokenizeState : StateBase
    {
        public override StateBase ReadCharacter()
        {
            HelperState helperState = new HelperState();
            string token = "";
            while (!helperState.CheckWhiteSpace(DFA.CharacterPointer) && !helperState.CheckSignChar(DFA.CharacterPointer) && helperState.CheckAllowedWord(DFA.CharacterPointer))
            {
                if (helperState.CheckAllowedWord(DFA.CharacterPointer))
                {
                    token += DFA.CharacterPointer;
                    DFA.codePosition++;
                }
                else
                {
                    throw new Exception($"Identifier \"{DFA.CharacterPointer}\" undefined /" +
                    $" position: {DFA.GetCodePosition()} (Divivsion State #102)");
                }
            }
            BaseToken tokenIdentify = helperState.IdentifyWordToken(token);
            if (tokenIdentify.Lexem == "bool" || tokenIdentify.Lexem == "char" ||
                tokenIdentify.Lexem == "int")
            {
                DFA.codePosition++;
                DFA.SetBaseToken(tokenIdentify);
                return new TokenizeState();
            }
            else
            {
                DFA.codePosition++;
                DFA.SetBaseToken(tokenIdentify);
                return new TokenizeState();
            }
        }
    }
}
