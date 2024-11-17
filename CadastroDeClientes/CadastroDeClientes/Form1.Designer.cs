namespace CadastroDeClientes
{
    partial class Home_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_form));
            ActionsGroupBox = new GroupBox();
            buttonCadastrar = new Button();
            dataGridView1 = new DataGridView();
            buttonDelete = new Button();
            ActionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ActionsGroupBox
            // 
            ActionsGroupBox.BackColor = Color.Transparent;
            ActionsGroupBox.Controls.Add(buttonDelete);
            ActionsGroupBox.Controls.Add(buttonCadastrar);
            ActionsGroupBox.Location = new Point(12, 12);
            ActionsGroupBox.Name = "ActionsGroupBox";
            ActionsGroupBox.Size = new Size(375, 110);
            ActionsGroupBox.TabIndex = 0;
            ActionsGroupBox.TabStop = false;
            ActionsGroupBox.Text = "Ações";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(6, 40);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(85, 50);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += ButtonCadastrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(982, 482);
            dataGridView1.TabIndex = 1;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(97, 40);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 50);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Excluir";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Home_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1006, 633);
            Controls.Add(dataGridView1);
            Controls.Add(ActionsGroupBox);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Home_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Início";
            Load += Form1_Load;
            ActionsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ActionsGroupBox;
        private Button buttonCadastrar;
        private DataGridView dataGridView1;
        private Button buttonDelete;
    }
}
