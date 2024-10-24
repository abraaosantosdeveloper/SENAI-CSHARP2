
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AddProduct = new Button();
            DeleteProduct = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonProduto = new Button();
            buttonFornecedores = new Button();
            buttonClientes = new Button();
            buttonCompras = new Button();
            buttonVendas = new Button();
            adicionarFornecedor = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AddProduct
            // 
            AddProduct.Dock = DockStyle.Fill;
            AddProduct.Location = new Point(3, 68);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(183, 28);
            AddProduct.TabIndex = 0;
            AddProduct.Text = "Novo";
            AddProduct.UseVisualStyleBackColor = true;
            AddProduct.Click += AddProduct_Click;
            // 
            // DeleteProduct
            // 
            DeleteProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DeleteProduct.Dock = DockStyle.Fill;
            DeleteProduct.Location = new Point(3, 102);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(183, 32);
            DeleteProduct.TabIndex = 1;
            DeleteProduct.Text = "Apagar";
            DeleteProduct.UseVisualStyleBackColor = true;
            DeleteProduct.Click += DeleteProduct_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.96373F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.03627F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 189F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 177F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            tableLayoutPanel1.Controls.Add(AddProduct, 0, 1);
            tableLayoutPanel1.Controls.Add(DeleteProduct, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonProduto, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonFornecedores, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonClientes, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonCompras, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonVendas, 4, 0);
            tableLayoutPanel1.Controls.Add(adicionarFornecedor, 1, 1);
            tableLayoutPanel1.Controls.Add(button6, 1, 2);
            tableLayoutPanel1.Controls.Add(button7, 2, 1);
            tableLayoutPanel1.Controls.Add(button8, 2, 2);
            tableLayoutPanel1.Controls.Add(button9, 3, 1);
            tableLayoutPanel1.Controls.Add(button10, 3, 2);
            tableLayoutPanel1.Controls.Add(button11, 4, 1);
            tableLayoutPanel1.Controls.Add(button12, 4, 2);
            tableLayoutPanel1.Location = new Point(12, 15);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.0485458F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.951458F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.Size = new Size(942, 137);
            tableLayoutPanel1.TabIndex = 3;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // buttonProduto
            // 
            buttonProduto.BackColor = Color.PaleGreen;
            buttonProduto.BackgroundImageLayout = ImageLayout.None;
            buttonProduto.Dock = DockStyle.Fill;
            buttonProduto.Image = (Image)resources.GetObject("buttonProduto.Image");
            buttonProduto.ImageAlign = ContentAlignment.MiddleRight;
            buttonProduto.Location = new Point(3, 3);
            buttonProduto.Name = "buttonProduto";
            buttonProduto.RightToLeft = RightToLeft.No;
            buttonProduto.Size = new Size(183, 59);
            buttonProduto.TabIndex = 0;
            buttonProduto.Text = "Produto";
            buttonProduto.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonProduto.UseVisualStyleBackColor = false;
            buttonProduto.Click += buttonProduto_Click;
            // 
            // buttonFornecedores
            // 
            buttonFornecedores.BackColor = Color.MediumTurquoise;
            buttonFornecedores.Dock = DockStyle.Fill;
            buttonFornecedores.Image = (Image)resources.GetObject("buttonFornecedores.Image");
            buttonFornecedores.ImageAlign = ContentAlignment.MiddleRight;
            buttonFornecedores.Location = new Point(192, 3);
            buttonFornecedores.Name = "buttonFornecedores";
            buttonFornecedores.Size = new Size(191, 59);
            buttonFornecedores.TabIndex = 2;
            buttonFornecedores.Text = "Fornecedores";
            buttonFornecedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFornecedores.UseVisualStyleBackColor = false;
            buttonFornecedores.Click += buttonFornecedores_Click;
            // 
            // buttonClientes
            // 
            buttonClientes.BackColor = Color.LemonChiffon;
            buttonClientes.Dock = DockStyle.Fill;
            buttonClientes.Image = (Image)resources.GetObject("buttonClientes.Image");
            buttonClientes.Location = new Point(389, 3);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(183, 59);
            buttonClientes.TabIndex = 3;
            buttonClientes.Text = "Clientes";
            buttonClientes.TextAlign = ContentAlignment.MiddleRight;
            buttonClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonClientes.UseVisualStyleBackColor = false;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // buttonCompras
            // 
            buttonCompras.BackColor = Color.LightSteelBlue;
            buttonCompras.Dock = DockStyle.Fill;
            buttonCompras.Image = (Image)resources.GetObject("buttonCompras.Image");
            buttonCompras.ImageAlign = ContentAlignment.MiddleRight;
            buttonCompras.Location = new Point(578, 3);
            buttonCompras.Name = "buttonCompras";
            buttonCompras.Size = new Size(171, 59);
            buttonCompras.TabIndex = 4;
            buttonCompras.Text = "Compras";
            buttonCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCompras.UseVisualStyleBackColor = false;
            buttonCompras.Click += buttonCompras_Click;
            // 
            // buttonVendas
            // 
            buttonVendas.BackColor = Color.Plum;
            buttonVendas.Dock = DockStyle.Fill;
            buttonVendas.Image = (Image)resources.GetObject("buttonVendas.Image");
            buttonVendas.ImageAlign = ContentAlignment.MiddleRight;
            buttonVendas.Location = new Point(755, 3);
            buttonVendas.Name = "buttonVendas";
            buttonVendas.Size = new Size(184, 59);
            buttonVendas.TabIndex = 5;
            buttonVendas.Text = "Vendas";
            buttonVendas.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonVendas.UseVisualStyleBackColor = false;
            buttonVendas.Click += buttonVendas_Click;
            // 
            // adicionarFornecedor
            // 
            adicionarFornecedor.Dock = DockStyle.Fill;
            adicionarFornecedor.Location = new Point(192, 68);
            adicionarFornecedor.Name = "adicionarFornecedor";
            adicionarFornecedor.Size = new Size(191, 28);
            adicionarFornecedor.TabIndex = 6;
            adicionarFornecedor.Text = "Novo";
            adicionarFornecedor.UseVisualStyleBackColor = true;
            adicionarFornecedor.Click += adicionarFornecedor_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(192, 102);
            button6.Name = "button6";
            button6.Size = new Size(191, 32);
            button6.TabIndex = 7;
            button6.Text = "Apagar";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(389, 68);
            button7.Name = "button7";
            button7.Size = new Size(183, 28);
            button7.TabIndex = 8;
            button7.Text = "Novo";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(389, 102);
            button8.Name = "button8";
            button8.Size = new Size(183, 32);
            button8.TabIndex = 9;
            button8.Text = "Apagar";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(578, 68);
            button9.Name = "button9";
            button9.Size = new Size(171, 28);
            button9.TabIndex = 10;
            button9.Text = "Nova";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(578, 102);
            button10.Name = "button10";
            button10.Size = new Size(171, 32);
            button10.TabIndex = 11;
            button10.Text = "Apagar";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(755, 68);
            button11.Name = "button11";
            button11.Size = new Size(184, 28);
            button11.TabIndex = 12;
            button11.Text = "Nova";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Dock = DockStyle.Fill;
            button12.Location = new Point(755, 102);
            button12.Name = "button12";
            button12.Size = new Size(184, 32);
            button12.TabIndex = 13;
            button12.Text = "Apagar";
            button12.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(942, 463);
            dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(962, 633);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(980, 680);
            MinimumSize = new Size(980, 680);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddProduct;
        private Button DeleteProduct;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private Button buttonProduto;
        private Button buttonFornecedores;
        private Button buttonClientes;
        private Button buttonCompras;
        private Button buttonVendas;
        private Button adicionarFornecedor;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
    }
}
