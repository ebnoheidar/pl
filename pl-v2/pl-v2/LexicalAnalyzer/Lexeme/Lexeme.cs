using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pl_v2.LexicalAnalyzer.Lexeme
{
    internal class Lexeme
    {
        internal Lexeme(string lexemeName, string tokenName) 
        {
            LexemeName = lexemeName;
            TokenName = tokenName;
        }
        internal string LexemeName { get; set; }
        internal string TokenName { get; set; }
    }
}
