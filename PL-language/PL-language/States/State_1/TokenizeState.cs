using PL_language.States.KeywordStates;
using PL_language.Tokens;

namespace PL_language.States.State_1
{
    internal class TokenizeState : StateBase
    {
        public override StateBase ReadCharacter(char input, DFA dfa)
        {
            HelperState helperState = new HelperState();
            string token = "";
            while (!helperState.CheckWhiteSpace(input) && !helperState.CheckSignChar(input) && helperState.CheckAllowedWord(input))
            {
                if (helperState.CheckAllowedWord(input))
                {
                    token += input;
                    dfa.codePosition++;
                    input = dfa.code[dfa.GetCodePosition()];
                }
                else
                {
                    throw new Exception($"Identifier \"{input}\" undefined /" +
                    $" position: {dfa.GetCodePosition()} (Divivsion State #102)");
                }
            }
            dfa.SetCodePosition(dfa.GetCodePosition() - 1);
            BaseToken tokenIdentify = helperState.IdentifyWordToken(token);
            if (tokenIdentify.Lexem == "bool" || tokenIdentify.Lexem == "char" ||
                tokenIdentify.Lexem == "int")
            {
                dfa.SetBaseToken(tokenIdentify);
                return new VariableState();
            }
            else
                throw new Exception($"Error: expected unqualified-id before {token}/" +
                    $" position: {dfa.GetCodePosition()} (Tokenize State #103)");
        }
    }
}
