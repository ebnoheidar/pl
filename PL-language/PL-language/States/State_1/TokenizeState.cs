using PL_language.States.KeywordStates;
using PL_language.Tokens;
using PL_language.Tokens.TokenInfo;

namespace PL_language.States.State_1
{
    internal class TokenizeState : StateBase
    {
        public override StateBase ReadCharacter()
        {
            HelperState helperState = new HelperState();
            string token = "";
            if (helperState.CheckWhiteSpace(DFA.CharacterPointer))
            {
                helperState.WhiteSpaceReader();
                DFA.SetBaseToken(new WhiteSpaceToken());
            }
            else if (helperState.CheckSignChar(DFA.CharacterPointer))
                return new SignState();
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
                DFA.SetBaseToken(tokenIdentify);
                return new TokenizeState();
            }
            else if (tokenIdentify.Type != TokenTypes.Id)
            {
                DFA.SetBaseToken(tokenIdentify);
                DFA.codePosition++;
                return new TokenizeState();
            }
            else
            {
                DFA.SetBaseToken(tokenIdentify);
                return new TokenizeState();
            }
        }
    }
}
