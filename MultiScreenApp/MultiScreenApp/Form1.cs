using System.ComponentModel;

namespace MultiScreenApp
{
    public partial class Form1 : Form
    {
        private BindingList<Produto> Produtos = new BindingList<Produto>();
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = Produtos;
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
                //string productInfo = $"{windowAdd.Nome} - {windowAdd.Fabricante} - R$ {windowAdd.PrecoCompra} - R$ {windowAdd.PrecoVenda}";
                //windowAdd.Items.Add(productInfo);
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
            //if (ProdutosListBox.Items.Count > 0)
            //{
            //    if (ProdutosListBox.Items.Count >= 0)
            //    {
            //        ProdutosListBox.Items.RemoveAt(ProdutosListBox.SelectedIndex);
            //    }
            //}

            if(dataGridView1.DataSource == Produtos)
            {
                if(dataGridView1.SelectedRows.Count > 0)
                {
                    Produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }

        }
    }
}
