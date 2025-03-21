using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pl_v2.LexicalAnalyzer.Lexeme
{
    internal class KeywordLexemes
    {
        internal KeywordLexemes() 
        {
            Lexemes.Add(new Lexeme("bool", "T_Bool"));
            Lexemes.Add(new Lexeme("break", "T_Break"));
            Lexemes.Add(new Lexeme("char", "T_Char"));
            Lexemes.Add(new Lexeme("continue", "T_Continue"));
            Lexemes.Add(new Lexeme("else", "T_Else"));
            Lexemes.Add(new Lexeme("false", "T_False"));
            Lexemes.Add(new Lexeme("for", "T_For"));
            Lexemes.Add(new Lexeme("if", "T_If"));
            Lexemes.Add(new Lexeme("int", "T_Int"));
            Lexemes.Add(new Lexeme("print", "T_Print"));
            Lexemes.Add(new Lexeme("return", "T_Return"));
            Lexemes.Add(new Lexeme("true", "T_True"));
        }
        internal List<Lexeme> Lexemes = new List<Lexeme> ();
        internal Lexeme CheckKeywordLexeme(string token, LexicalAnalyzer analyzer)
        {
            foreach (Lexeme lexeme in Lexemes)
            {
                if (lexeme.LexemeName == token)
                    return lexeme;
            }
            return new Lexeme("id", "T_Iⅾ");
        }
        internal bool CheckToken(char token, bool preTokenIsLetter = false)
        {
            if(char.IsLetter(token) || token == '_' || (preTokenIsLetter & char.IsDigit(token)))
                return true;
            else
                return false;
        }
    }
}
