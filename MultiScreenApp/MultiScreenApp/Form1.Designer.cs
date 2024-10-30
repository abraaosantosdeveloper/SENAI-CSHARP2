
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
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonProdutos = new Button();
            buttonFornecedores = new Button();
            buttonClientes = new Button();
            buttonCompras = new Button();
            buttonVendas = new Button();
            adicionarFornecedor = new Button();
            apagarFornecedor = new Button();
            buttonNovoCliente = new Button();
            buttonRemoverCliente = new Button();
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
            AddProduct.Size = new Size(182, 28);
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
            DeleteProduct.Size = new Size(182, 32);
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 191F));
            tableLayoutPanel1.Controls.Add(AddProduct, 0, 1);
            tableLayoutPanel1.Controls.Add(DeleteProduct, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonProdutos, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonFornecedores, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonClientes, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonCompras, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonVendas, 4, 0);
            tableLayoutPanel1.Controls.Add(adicionarFornecedor, 1, 1);
            tableLayoutPanel1.Controls.Add(apagarFornecedor, 1, 2);
            tableLayoutPanel1.Controls.Add(buttonNovoCliente, 2, 1);
            tableLayoutPanel1.Controls.Add(buttonRemoverCliente, 2, 2);
            tableLayoutPanel1.Controls.Add(button9, 3, 1);
            tableLayoutPanel1.Controls.Add(button10, 3, 2);
            tableLayoutPanel1.Controls.Add(button11, 4, 1);
            tableLayoutPanel1.Controls.Add(button12, 4, 2);
            tableLayoutPanel1.Location = new Point(11, 15);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.0485458F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.951458F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.Size = new Size(942, 137);
            tableLayoutPanel1.TabIndex = 3;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // buttonProdutos
            // 
            buttonProdutos.BackColor = Color.PaleGreen;
            buttonProdutos.BackgroundImageLayout = ImageLayout.None;
            buttonProdutos.Dock = DockStyle.Fill;
            buttonProdutos.FlatStyle = FlatStyle.Flat;
            buttonProdutos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProdutos.ForeColor = Color.DarkGreen;
            buttonProdutos.ImageAlign = ContentAlignment.MiddleRight;
            buttonProdutos.Location = new Point(3, 3);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.RightToLeft = RightToLeft.No;
            buttonProdutos.Size = new Size(182, 59);
            buttonProdutos.TabIndex = 0;
            buttonProdutos.Text = "Produtos";
            buttonProdutos.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonProdutos.UseVisualStyleBackColor = false;
            buttonProdutos.Click += buttonProduto_Click;
            // 
            // buttonFornecedores
            // 
            buttonFornecedores.BackColor = Color.MediumTurquoise;
            buttonFornecedores.Dock = DockStyle.Fill;
            buttonFornecedores.FlatStyle = FlatStyle.Flat;
            buttonFornecedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFornecedores.ForeColor = Color.DarkSlateGray;
            buttonFornecedores.ImageAlign = ContentAlignment.MiddleRight;
            buttonFornecedores.Location = new Point(191, 3);
            buttonFornecedores.Name = "buttonFornecedores";
            buttonFornecedores.Size = new Size(190, 59);
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
            buttonClientes.FlatStyle = FlatStyle.Flat;
            buttonClientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClientes.ForeColor = Color.Olive;
            buttonClientes.Location = new Point(387, 3);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(183, 59);
            buttonClientes.TabIndex = 3;
            buttonClientes.Text = "Clientes";
            buttonClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonClientes.UseVisualStyleBackColor = false;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // buttonCompras
            // 
            buttonCompras.BackColor = Color.LightSteelBlue;
            buttonCompras.Dock = DockStyle.Fill;
            buttonCompras.FlatStyle = FlatStyle.Flat;
            buttonCompras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCompras.ForeColor = Color.FromArgb(64, 64, 64);
            buttonCompras.ImageAlign = ContentAlignment.MiddleRight;
            buttonCompras.Location = new Point(576, 3);
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
            buttonVendas.FlatStyle = FlatStyle.Flat;
            buttonVendas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVendas.ForeColor = Color.DarkMagenta;
            buttonVendas.ImageAlign = ContentAlignment.MiddleRight;
            buttonVendas.Location = new Point(753, 3);
            buttonVendas.Name = "buttonVendas";
            buttonVendas.Size = new Size(186, 59);
            buttonVendas.TabIndex = 5;
            buttonVendas.Text = "Vendas";
            buttonVendas.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonVendas.UseVisualStyleBackColor = false;
            buttonVendas.Click += buttonVendas_Click;
            // 
            // adicionarFornecedor
            // 
            adicionarFornecedor.Dock = DockStyle.Fill;
            adicionarFornecedor.Location = new Point(191, 68);
            adicionarFornecedor.Name = "adicionarFornecedor";
            adicionarFornecedor.Size = new Size(190, 28);
            adicionarFornecedor.TabIndex = 6;
            adicionarFornecedor.Text = "Novo";
            adicionarFornecedor.UseVisualStyleBackColor = true;
            adicionarFornecedor.Click += adicionarFornecedor_Click;
            // 
            // apagarFornecedor
            // 
            apagarFornecedor.Dock = DockStyle.Fill;
            apagarFornecedor.Location = new Point(191, 102);
            apagarFornecedor.Name = "apagarFornecedor";
            apagarFornecedor.Size = new Size(190, 32);
            apagarFornecedor.TabIndex = 7;
            apagarFornecedor.Text = "Apagar";
            apagarFornecedor.UseVisualStyleBackColor = true;
            apagarFornecedor.Click += apagarFornecedor_Click;
            // 
            // buttonNovoCliente
            // 
            buttonNovoCliente.Dock = DockStyle.Fill;
            buttonNovoCliente.Location = new Point(387, 68);
            buttonNovoCliente.Name = "buttonNovoCliente";
            buttonNovoCliente.Size = new Size(183, 28);
            buttonNovoCliente.TabIndex = 8;
            buttonNovoCliente.Text = "Novo";
            buttonNovoCliente.UseVisualStyleBackColor = true;
            buttonNovoCliente.Click += buttonNovoCliente_Click;
            // 
            // buttonRemoverCliente
            // 
            buttonRemoverCliente.Dock = DockStyle.Fill;
            buttonRemoverCliente.Location = new Point(387, 102);
            buttonRemoverCliente.Name = "buttonRemoverCliente";
            buttonRemoverCliente.Size = new Size(183, 32);
            buttonRemoverCliente.TabIndex = 9;
            buttonRemoverCliente.Text = "Apagar";
            buttonRemoverCliente.UseVisualStyleBackColor = true;
            buttonRemoverCliente.Click += buttonRemoverCliente_Click;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(576, 68);
            button9.Name = "button9";
            button9.Size = new Size(171, 28);
            button9.TabIndex = 10;
            button9.Text = "Nova";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(576, 102);
            button10.Name = "button10";
            button10.Size = new Size(171, 32);
            button10.TabIndex = 11;
            button10.Text = "Apagar";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(753, 68);
            button11.Name = "button11";
            button11.Size = new Size(186, 28);
            button11.TabIndex = 12;
            button11.Text = "Nova";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Dock = DockStyle.Fill;
            button12.Location = new Point(753, 102);
            button12.Name = "button12";
            button12.Size = new Size(186, 32);
            button12.TabIndex = 13;
            button12.Text = "Apagar";
            button12.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 157);
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
            ClientSize = new Size(962, 631);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(980, 678);
            MinimumSize = new Size(980, 678);
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
        private Button buttonProdutos;
        private Button buttonFornecedores;
        private Button buttonClientes;
        private Button buttonCompras;
        private Button buttonVendas;
        private Button adicionarFornecedor;
        private Button apagarFornecedor;
        private Button buttonNovoCliente;
        private Button buttonRemoverCliente;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
    }
}
