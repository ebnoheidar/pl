using PL_language.States;
using PL_language.States.State_1;

namespace PL_language
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeTokenList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "open file";
            ofd.Filter = "c files(*.c)|*.c|All files (*.*)|*.*";

            string fileAddress = "";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileAddress = ofd.FileName;
            }
            string fileContain = File.ReadAllText(fileAddress);
            richTextBox1.Text = fileContain;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DFA.code = richTextBox1.Text;
            DFA.codePosition = 0;
            try
             {
                DFA.SetState(new StartState());
                richTextBox2.Text = DFA.getTokens();
            }
            catch (Exception error)
            {
                label1.Text = error.Message;
                richTextBox2.Text = DFA.getTokens();

            }
        }
        private void InitializeTokenList()
        {
            HelperState.Tokens.Add(new Tokens.TokenInfo.AndToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.AssignToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.BoolToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.BreakToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.CharacterToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.CharToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.CloseBlockToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.CloseParenthesesToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.CloseBracketToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.CommaToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.CommentToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.ContinueToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.DecimalToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.DivisionToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.ElseToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.EqualToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.FalseToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.ForToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.HexadecimalToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.IdToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.IfToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.IntToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.LessEqualToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.LessToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.MinusToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.MoreEqualToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.MoreToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.NewLineToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.NotEqualToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.NotToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.OpenBlockToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.OpenBracketToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.OpenParenthesesToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.OrToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.PercentToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.PlusToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.PrintToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.ReturnToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.SemicolonToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.StarToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.StringToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.TabToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.TrueToken());
            HelperState.Tokens.Add(new Tokens.TokenInfo.WhiteSpaceToken());
        }
    }
}
