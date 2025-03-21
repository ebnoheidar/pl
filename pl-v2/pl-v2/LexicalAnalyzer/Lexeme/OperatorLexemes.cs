using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pl_v2.LexicalAnalyzer.Lexeme
{
    internal class OperatorLexemes
    {
        internal OperatorLexemes()
        {
            OneCharLexemes.Add(new Lexeme("+", "T_AOp_PⅬ"));
            OneCharLexemes.Add(new Lexeme("-", "T_AOp_ⅯNⅬ"));
            OneCharLexemes.Add(new Lexeme("*", "T_AOp_ⅯⅬⅬ"));
            OneCharLexemes.Add(new Lexeme("/", "T_AOp_ⅮVⅬ"));
            OneCharLexemes.Add(new Lexeme("%", "T_AOp_RⅯⅬ"));
            OneCharLexemes.Add(new Lexeme("<", "T_ROp_Ⅼ"));
            OneCharLexemes.Add(new Lexeme(">", "T_ROp_G"));
            OneCharLexemes.Add(new Lexeme("!", "T_ⅬOp_NOT"));
            OneCharLexemes.Add(new Lexeme("=", "T_Assign"));
            OneCharLexemes.Add(new Lexeme("(", "T_ⅬP"));
            OneCharLexemes.Add(new Lexeme(")", "T_RP"));
            OneCharLexemes.Add(new Lexeme("{", "T_ⅬⅭ"));
            OneCharLexemes.Add(new Lexeme("}", "T_RⅭ"));
            OneCharLexemes.Add(new Lexeme("[", "T_ⅬB"));
            OneCharLexemes.Add(new Lexeme("]", "T_RB"));
            OneCharLexemes.Add(new Lexeme("[", "T_ⅬB"));
            OneCharLexemes.Add(new Lexeme(";", "T_Seⅿiⅽoⅼon"));
            OneCharLexemes.Add(new Lexeme("[", "T_ⅬB"));
            TwoCharLexemes.Add(new Lexeme("<=", "T_ROp_ⅬE"));
            TwoCharLexemes.Add(new Lexeme(">=", "T_ROp_GE"));
            TwoCharLexemes.Add(new Lexeme("!=", "T_ROp_NE"));
            TwoCharLexemes.Add(new Lexeme("==", "T_ROp_E"));
            TwoCharLexemes.Add(new Lexeme("&&", "T_ⅬOp_ANⅮ"));
            TwoCharLexemes.Add(new Lexeme("||", "T_ⅬOp_OR"));
        }
        internal List<Lexeme> OneCharLexemes = new List<Lexeme>();
        internal List<Lexeme> TwoCharLexemes = new List<Lexeme>();
        internal Lexeme? CheckLexemExist(string token, LexicalAnalyzer lexicalAnalyzer)
        {
            foreach (Lexeme item in OneCharLexemes)
            {
                if(item.TokenName ==  token)
                {
                    Lexeme? twoCharLexeme = checkTwoCharLexeme(token + lexicalAnalyzer.SeeNext());
                    if (twoCharLexeme == null)
                        return item;
                    else
                    {
                        lexicalAnalyzer.Next();
                        lexicalAnalyzer.Next();
                        return twoCharLexeme;
                    }
                }
            }
            return null;
        }
        private Lexeme? checkTwoCharLexeme(string token)
        {
            foreach (Lexeme item in TwoCharLexemes)
            {
                if (item.LexemeName == token)
                    return item;
            }
            return null;
        }
    }
}
