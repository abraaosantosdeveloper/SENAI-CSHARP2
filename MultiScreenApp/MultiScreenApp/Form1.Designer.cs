
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
            AddProduct.Location = new Point(3, 50);
            AddProduct.Margin = new Padding(3, 2, 3, 2);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(159, 22);
            AddProduct.TabIndex = 0;
            AddProduct.Text = "Novo";
            AddProduct.UseVisualStyleBackColor = true;
            AddProduct.Click += AddProduct_Click;
            // 
            // DeleteProduct
            // 
            DeleteProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DeleteProduct.Dock = DockStyle.Fill;
            DeleteProduct.Location = new Point(3, 76);
            DeleteProduct.Margin = new Padding(3, 2, 3, 2);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(159, 25);
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 166F));
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
            tableLayoutPanel1.Location = new Point(10, 11);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.0485458F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.951458F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.Size = new Size(824, 103);
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
            buttonProdutos.Location = new Point(3, 2);
            buttonProdutos.Margin = new Padding(3, 2, 3, 2);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.RightToLeft = RightToLeft.No;
            buttonProdutos.Size = new Size(159, 44);
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
            buttonFornecedores.Location = new Point(168, 2);
            buttonFornecedores.Margin = new Padding(3, 2, 3, 2);
            buttonFornecedores.Name = "buttonFornecedores";
            buttonFornecedores.Size = new Size(166, 44);
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
            buttonClientes.Location = new Point(340, 2);
            buttonClientes.Margin = new Padding(3, 2, 3, 2);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(159, 44);
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
            buttonCompras.Location = new Point(505, 2);
            buttonCompras.Margin = new Padding(3, 2, 3, 2);
            buttonCompras.Name = "buttonCompras";
            buttonCompras.Size = new Size(149, 44);
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
            buttonVendas.Location = new Point(660, 2);
            buttonVendas.Margin = new Padding(3, 2, 3, 2);
            buttonVendas.Name = "buttonVendas";
            buttonVendas.Size = new Size(161, 44);
            buttonVendas.TabIndex = 5;
            buttonVendas.Text = "Vendas";
            buttonVendas.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonVendas.UseVisualStyleBackColor = false;
            buttonVendas.Click += buttonVendas_Click;
            // 
            // adicionarFornecedor
            // 
            adicionarFornecedor.Dock = DockStyle.Fill;
            adicionarFornecedor.Location = new Point(168, 50);
            adicionarFornecedor.Margin = new Padding(3, 2, 3, 2);
            adicionarFornecedor.Name = "adicionarFornecedor";
            adicionarFornecedor.Size = new Size(166, 22);
            adicionarFornecedor.TabIndex = 6;
            adicionarFornecedor.Text = "Novo";
            adicionarFornecedor.UseVisualStyleBackColor = true;
            adicionarFornecedor.Click += adicionarFornecedor_Click;
            // 
            // apagarFornecedor
            // 
            apagarFornecedor.Dock = DockStyle.Fill;
            apagarFornecedor.Location = new Point(168, 76);
            apagarFornecedor.Margin = new Padding(3, 2, 3, 2);
            apagarFornecedor.Name = "apagarFornecedor";
            apagarFornecedor.Size = new Size(166, 25);
            apagarFornecedor.TabIndex = 7;
            apagarFornecedor.Text = "Apagar";
            apagarFornecedor.UseVisualStyleBackColor = true;
            apagarFornecedor.Click += apagarFornecedor_Click;
            // 
            // buttonNovoCliente
            // 
            buttonNovoCliente.Dock = DockStyle.Fill;
            buttonNovoCliente.Location = new Point(340, 50);
            buttonNovoCliente.Margin = new Padding(3, 2, 3, 2);
            buttonNovoCliente.Name = "buttonNovoCliente";
            buttonNovoCliente.Size = new Size(159, 22);
            buttonNovoCliente.TabIndex = 8;
            buttonNovoCliente.Text = "Novo";
            buttonNovoCliente.UseVisualStyleBackColor = true;
            buttonNovoCliente.Click += buttonNovoCliente_Click;
            // 
            // buttonRemoverCliente
            // 
            buttonRemoverCliente.Dock = DockStyle.Fill;
            buttonRemoverCliente.Location = new Point(340, 76);
            buttonRemoverCliente.Margin = new Padding(3, 2, 3, 2);
            buttonRemoverCliente.Name = "buttonRemoverCliente";
            buttonRemoverCliente.Size = new Size(159, 25);
            buttonRemoverCliente.TabIndex = 9;
            buttonRemoverCliente.Text = "Apagar";
            buttonRemoverCliente.UseVisualStyleBackColor = true;
            buttonRemoverCliente.Click += buttonRemoverCliente_Click;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(505, 50);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(149, 22);
            button9.TabIndex = 10;
            button9.Text = "Nova";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(505, 76);
            button10.Margin = new Padding(3, 2, 3, 2);
            button10.Name = "button10";
            button10.Size = new Size(149, 25);
            button10.TabIndex = 11;
            button10.Text = "Apagar";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(660, 50);
            button11.Margin = new Padding(3, 2, 3, 2);
            button11.Name = "button11";
            button11.Size = new Size(161, 22);
            button11.TabIndex = 12;
            button11.Text = "Nova";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Dock = DockStyle.Fill;
            button12.Location = new Point(660, 76);
            button12.Margin = new Padding(3, 2, 3, 2);
            button12.Name = "button12";
            button12.Size = new Size(161, 25);
            button12.TabIndex = 13;
            button12.Text = "Apagar";
            button12.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 118);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(824, 347);
            dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(844, 481);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(860, 520);
            MinimumSize = new Size(860, 520);
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
