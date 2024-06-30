using PL_language.States;
using PL_language.Tokens;

namespace PL_language
{
    internal static class DFA
    {
        public static string code { get; set; }
        public static int codePosition { get; set; }
        private static StateBase currentState { get; set; }
        private static string tokens { get; set; }
        public static char CharacterPointer { get { return code[codePosition]; } }
        public static void SetState(StateBase state)
        {
            if (code.Length == codePosition - 1)
                return;
            currentState = state;
            SetState(currentState.ReadCharacter());
        }
        public static void SetBaseToken(BaseToken token)
        {
            tokens = tokens + Environment.NewLine + token.Token;
        }
        public static int GetCodePosition() { return codePosition; }
        public static string getTokens()
        {
            return tokens;
        }
    }
}
