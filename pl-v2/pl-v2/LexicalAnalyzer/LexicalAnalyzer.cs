using pl_v2.Exceptions;
using pl_v2.LexicalAnalyzer.Lexeme;

namespace pl_v2.LexicalAnalyzer
{
    internal class LexicalAnalyzer
    {
        internal LexicalAnalyzer(string code)
        {
            this.code = code;
        }
        private int now_position = 0;
        private string code { get; set; }
        private List<Lexeme.Lexeme> TokenList = new List<Lexeme.Lexeme>();
        private KeywordLexemes keywordLexemes = new KeywordLexemes();
        private OperatorLexemes operatorLexemes = new OperatorLexemes();
        internal string SeeNext()
        {
            if (now_position + 1 == code.Length)
            {
                return "";
            }
            return code[now_position + 1].ToString();
        }
        internal void Next()
        {
            now_position++;
        }
        internal char GetChar()
        {
            return code[now_position + 1];
        }
        internal bool CheckFinishAnalyze()
        {
            if(now_position == code.Length) 
                return true;
            return false;
        }
        internal void Analyze()
        {
            if(CheckFinishAnalyze())
                return;

            string token = "";
            while (true)
            {
                char nowChar = GetChar();                
                if (keywordLexemes.CheckToken(nowChar, !string.IsNullOrEmpty(token)))
                {
                    token += nowChar.ToString();
                    Next();
                    continue;
                }
                else
                {
                    AnalyzeToken(token);
                    Next();
                    break;
                }
            }
            Analyze();
        }
        internal void AnalyzeToken(string token)
        {
            if (string.IsNullOrEmpty(token))
            {
                Lexeme.Lexeme? operatorLexem = operatorLexemes.CheckLexemExist(token, this);
                if (operatorLexem == null)
                    throw new UndefinedTokenException();
                else 
                    TokenList.Add(operatorLexem);
            }
            else
                TokenList.Add(keywordLexemes.CheckKeywordLexeme(token));            
        }
    }
}
