namespace MultiScreenApp
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
            AddProduct = new Button();
            DeleteProduct = new Button();
            ProdutosListBox = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // AddProduct
            // 
            AddProduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddProduct.Location = new Point(3, 3);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(458, 52);
            AddProduct.TabIndex = 0;
            AddProduct.Text = "Novo Produto";
            AddProduct.UseVisualStyleBackColor = true;
            AddProduct.Click += AddProduct_Click;
            // 
            // DeleteProduct
            // 
            DeleteProduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DeleteProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DeleteProduct.Location = new Point(467, 3);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(458, 52);
            DeleteProduct.TabIndex = 1;
            DeleteProduct.Text = "Deletar produto";
            DeleteProduct.UseVisualStyleBackColor = true;
            DeleteProduct.Click += DeleteProduct_Click;
            // 
            // ProdutosListBox
            // 
            ProdutosListBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ProdutosListBox.FormattingEnabled = true;
            ProdutosListBox.Location = new Point(12, 82);
            ProdutosListBox.Name = "ProdutosListBox";
            ProdutosListBox.Size = new Size(924, 424);
            ProdutosListBox.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(AddProduct, 0, 0);
            tableLayoutPanel1.Controls.Add(DeleteProduct, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 18);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(928, 58);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(948, 519);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(ProdutosListBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddProduct;
        private Button DeleteProduct;
        private ListBox ProdutosListBox;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
