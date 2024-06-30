using PL_language.States.FunctionStates;
using PL_language.Tokens.TokenInfo;

namespace PL_language.States.KeywordStates
{
    internal class TokenWordState : StateBase
    {
        public override StateBase ReadCharacter()
        {
            HelperState helperState = new HelperState();
            if (helperState.CheckWhiteSpace(DFA.CharacterPointer))
            {
                helperState.WhiteSpaceReader();
                DFA.SetBaseToken(new WhiteSpaceToken());
                DFA.codePosition++;
                return this;
            }
            else if (DFA.CharacterPointer == '=')
            {
                DFA.SetBaseToken(new Tokens.TokenInfo.IdToken());
                DFA.SetBaseToken(new Tokens.TokenInfo.AssignToken());
                return new VariableAssignState();
            }
            else if (DFA.CharacterPointer == '(')
            {
                DFA.SetBaseToken(new Tokens.TokenInfo.IdToken());
                DFA.SetBaseToken(new Tokens.TokenInfo.OpenParenthesesToken());
                return new CharacterPointerFunctionState();
            }
            else
                throw new Exception($"Error in {DFA.CharacterPointer} dfa.CharacterPointer character /" +
                    $" position: {DFA.GetCodePosition()} (Token Word State #105)");
        }
    }
}
