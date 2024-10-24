using System.ComponentModel;

namespace MultiScreenApp
{
    public partial class Form1 : Form
    {
        private BindingList<Produto> Produtos = new BindingList<Produto>();
        private BindingList<Cliente> Clientes = new BindingList<Cliente>();
        private BindingList<Compra> Compras = new BindingList<Compra>();
        private BindingList<Venda> Vendas = new BindingList<Venda>();
        private BindingList<Fornecedor> Fornecedores = new BindingList<Fornecedor>();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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

        private void buttonNovoFornecedor_Click(object sender, EventArgs e)
        {

        }
    }
}
