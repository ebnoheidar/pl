using System.Windows.Forms;

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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "open file";
            ofd.Filter = "txt files (*.txt)|*.txt|c files(*.c)|*.c|All files (*.*)|*.*";

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

        }
    }
}
