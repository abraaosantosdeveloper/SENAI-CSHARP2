using System.ComponentModel;

namespace MultiScreenApp
{
    public partial class Form1 : Form
    {
        public BindingList<Produto> Produtos = new BindingList<Produto>();
        public BindingList<Cliente> Clientes = new BindingList<Cliente>();
        public BindingList<Compra> Compras = new BindingList<Compra>();
        public BindingList<Venda> Vendas = new BindingList<Venda>();
        public BindingList<Fornecedor> Fornecedores = new BindingList<Fornecedor>();
        public Form1()
        {
            InitializeComponent();

            buttonProdutos.Image = Image.FromFile("images/produto.png");
            buttonClientes.Image = Image.FromFile("images/cliente.png");
            buttonFornecedores.Image = Image.FromFile("images/fornecedor.png");
            buttonCompras.Image = Image.FromFile("images/compra.png");
            buttonVendas.Image = Image.FromFile("images/venda.png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Adicionar produto

        private void AddProduct_Click(object sender, EventArgs e)
        {
            FormNovoProduto windowAdd = new FormNovoProduto();
            DialogResult dr = windowAdd.ShowDialog();
            if (dr == DialogResult.OK)
            {

                Produto produto = new Produto();
                if (Produtos.Count == 0) produto.Id = 1;
                else produto.Id = Produtos.Max(x => x.Id) + 1;

                produto.Nome = windowAdd.Nome;
                produto.Fabricante = windowAdd.Fabricante;
                produto.PrecoCompra = windowAdd.PrecoCompra;
                produto.PrecoVenda = windowAdd.PrecoVenda;


                Produtos.Add(produto);
            }
        }

        // Remover produto
        private void DeleteProduct_Click(object sender, EventArgs e)
        {

            if (dataGridView1.DataSource == Produtos)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button_Click(object sender, EventArgs e)
        {

        }
        // Adicionar Fornecedor

        private void adicionarFornecedor_Click(object sender, EventArgs e)
        {
            NovoFornecedor adicionarFornecedor = new NovoFornecedor();
            DialogResult dr = adicionarFornecedor.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Fornecedor fornecedor = new Fornecedor();
                if (Fornecedores.Count == 0) fornecedor.Id = 1;
                else fornecedor.Id = Fornecedores.Max(x => x.Id) + 1;

                fornecedor.Id = adicionarFornecedor.Id;
                fornecedor.CNPJ = adicionarFornecedor.CNPJ;
                fornecedor.Endereco = adicionarFornecedor.Endereco;
                fornecedor.Email = adicionarFornecedor.Email;
                fornecedor.NomeEmpresa = adicionarFornecedor.NomeEmpresa;
                fornecedor.Telefone = adicionarFornecedor.Telefone;
                fornecedor.NomeContato = adicionarFornecedor.NomeContato;


                Fornecedores.Add(fornecedor);
            }
        }

        // Remover fornecedor

        private void apagarFornecedor_Click(object sender, EventArgs e)
        {

            if (dataGridView1.DataSource == Fornecedores)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Fornecedores.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }

        }

        // Adicionar Cliente
        private void buttonNovoCliente_Click(object sender, EventArgs e)
        {
            NovaCompra adicionarCliente = new NovaCompra();
            DialogResult dr = adicionarCliente.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Cliente cliente = new Cliente();
                if (Clientes.Count == 0) cliente.Id = 1;
                else cliente.Id = Clientes.Max(x => x.Id) + 1;

                cliente.Id = adicionarCliente.Id;
                cliente.Nome = adicionarCliente.Nome;
                cliente.Telefone = adicionarCliente.Telefone;
                cliente.Email = adicionarCliente.Email;
                cliente.Endereco = adicionarCliente.Endereco;


                Clientes.Add(cliente);
            }
        }
        // remover Cliente

        private void buttonRemoverCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Clientes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Clientes.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }




        // DataSources

        private void buttonProduto_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Produtos;
        }
        private void buttonFornecedores_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Fornecedores;
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Clientes;

        }

        private void buttonCompras_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Compras;

        }

        private void buttonVendas_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Vendas;

        }


    }
}
