
namespace WinFormsApp1
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Fira Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(712, 46);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(138, 28);
            label1.TabIndex = 0;
            label1.Text = "Task List";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.AllowDrop = true;
            textBox1.Location = new Point(70, 99);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(362, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "Task name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Fira Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(183, 46);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 2;
            label2.Text = "New Task";
            label2.Click += label2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Cursor = Cursors.IBeam;
            richTextBox1.Location = new Point(70, 176);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(362, 183);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(70, 153);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 4;
            label3.Text = "Task description";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(579, 87);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(394, 334);
            checkedListBox1.TabIndex = 5;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(70, 407);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 6;
            button1.Text = "Add New Task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(257, 407);
            button2.Name = "button2";
            button2.Size = new Size(175, 29);
            button2.TabIndex = 7;
            button2.Text = "Remove Task";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._6235177;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1016, 479);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Task manager";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label3;
        private CheckedListBox checkedListBox1;
        private Button button1;
        private Button button2;
    }
}
