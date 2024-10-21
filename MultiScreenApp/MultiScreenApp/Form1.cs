namespace MultiScreenApp
{
    public partial class Form1 : Form
    {

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
                string productInfo = $"{windowAdd.Nome} - {windowAdd.Fabricante} - R$ {windowAdd.PrecoCompra} - R$ {windowAdd.PrecoVenda}";
                ProdutosListBox.Items.Add(productInfo);
            }
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            if (ProdutosListBox.Items.Count > 0)
            {
                if (ProdutosListBox.Items.Count >= 0)
                {
                    ProdutosListBox.Items.RemoveAt(ProdutosListBox.SelectedIndex);
                }
            }

        }
    }
}
