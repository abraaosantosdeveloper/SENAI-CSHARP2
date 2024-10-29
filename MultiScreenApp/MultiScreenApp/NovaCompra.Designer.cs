namespace MultiScreenApp
{
    partial class NovaCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            numericUpDown2 = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            textBoxPrecoUnit = new TextBox();
            textBoxValorDesc = new TextBox();
            textBoxTotal = new TextBox();
            buttonOK = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Produto:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(132, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 23);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Fornecedor:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(132, 52);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(171, 23);
            comboBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Quantidade:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(132, 84);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(170, 23);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 118);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 6;
            label4.Text = "Desconto (%):";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(132, 116);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(170, 23);
            numericUpDown2.TabIndex = 7;
            numericUpDown2.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 31);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 8;
            label5.Text = "Preço unitário:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 105);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 9;
            label6.Text = "Valor total:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 67);
            label7.Name = "label7";
            label7.Size = new Size(115, 15);
            label7.TabIndex = 10;
            label7.Text = "Valor com desconto:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxTotal);
            groupBox1.Controls.Add(textBoxValorDesc);
            groupBox1.Controls.Add(textBoxPrecoUnit);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(12, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 145);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações da compra";
            // 
            // textBoxPrecoUnit
            // 
            textBoxPrecoUnit.BackColor = SystemColors.Window;
            textBoxPrecoUnit.Location = new Point(137, 28);
            textBoxPrecoUnit.Name = "textBoxPrecoUnit";
            textBoxPrecoUnit.ReadOnly = true;
            textBoxPrecoUnit.Size = new Size(148, 23);
            textBoxPrecoUnit.TabIndex = 11;
            // 
            // textBoxValorDesc
            // 
            textBoxValorDesc.BackColor = SystemColors.Window;
            textBoxValorDesc.Location = new Point(137, 64);
            textBoxValorDesc.Name = "textBoxValorDesc";
            textBoxValorDesc.ReadOnly = true;
            textBoxValorDesc.Size = new Size(148, 23);
            textBoxValorDesc.TabIndex = 12;
            // 
            // textBoxTotal
            // 
            textBoxTotal.BackColor = SystemColors.Window;
            textBoxTotal.Location = new Point(137, 102);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(148, 23);
            textBoxTotal.TabIndex = 13;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(132, 322);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 14;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(222, 322);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.RightToLeft = RightToLeft.No;
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // NovaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 357);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(groupBox1);
            Controls.Add(numericUpDown2);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "NovaCompra";
            Text = "NovaCompra";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox textBoxValorDesc;
        private TextBox textBoxPrecoUnit;
        private TextBox textBoxTotal;
        private Button buttonOK;
        private Button buttonCancel;
    }
}