namespace PL_language
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            richTextBox1 = new RichTextBox();
            tabPage2 = new TabPage();
            richTextBox2 = new RichTextBox();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(24, 21);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "import";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(168, 21);
            button2.Name = "button2";
            button2.Size = new Size(152, 34);
            button2.TabIndex = 2;
            button2.Text = "lexical analyzer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.AppWorkspace;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 585);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1202, 60);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 89);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1202, 496);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1194, 458);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "dfa.CharacterPointer";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Segoe UI", 12F);
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1188, 452);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(richTextBox2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1194, 458);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "output";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.Location = new Point(3, 3);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(1188, 452);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 32);
            label1.TabIndex = 5;
            label1.Text = "   ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 645);
            Controls.Add(tabControl1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private RichTextBox richTextBox1;
        private TabPage tabPage2;
        private RichTextBox richTextBox2;
        private Label label1;
    }
}
