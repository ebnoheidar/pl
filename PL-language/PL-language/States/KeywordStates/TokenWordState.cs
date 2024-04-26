using PL_language.States.FunctionStates;

namespace PL_language.States.KeywordStates
{
    internal class TokenWordState : StateBase
    {
        public override StateBase ReadCharacter(char input, DFA dfa)
        {
            HelperState helperState = new HelperState();
            if (helperState.CheckAllowedWord(input))
            {
                return this;
            }
            else if (helperState.CheckWhiteSpace(input))
            {
                helperState.WhiteSpaceReader(dfa, input);
                dfa.SetCodePosition(dfa.GetCodePosition() + 1);
                input = dfa.code[dfa.GetCodePosition()];
                if (input == '=')
                {
                    dfa.SetBaseToken(new Tokens.TokenInfo.IdToken());
                    dfa.SetBaseToken(new Tokens.TokenInfo.AssignToken());
                    return new VariableAssignState();
                }
                else if (input == '(')
                {
                    dfa.SetBaseToken(new Tokens.TokenInfo.IdToken());
                    dfa.SetBaseToken(new Tokens.TokenInfo.OpenParenthesesToken());
                    return new InputFunctionState();
                }
                else
                    throw new Exception($"Error in {input} input character /" +
                   $" position: {dfa.GetCodePosition()} (Token Word State #105)");
            }
            else if (input == '=')
            {
                dfa.SetBaseToken(new Tokens.TokenInfo.IdToken());
                dfa.SetBaseToken(new Tokens.TokenInfo.AssignToken());
                return new VariableAssignState();
            }
            else if (input == '(')
            {
                dfa.SetBaseToken(new Tokens.TokenInfo.IdToken());
                dfa.SetBaseToken(new Tokens.TokenInfo.OpenParenthesesToken());
                return new InputFunctionState();
            }
            else
                throw new Exception($"Error in {input} input character /" +
                    $" position: {dfa.GetCodePosition()} (Token Word State #105)");
        }
    }
}
