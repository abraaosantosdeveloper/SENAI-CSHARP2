using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiScreenApp
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace MultiScreenApp
    {
    }


    public partial class NovaCompra : Form
    {
        private BindingList<Fornecedor> Fornecedores { get; set; }
        private Fornecedor Fornecedor { get { return Fornecedores.FirstOrDefault(f => f.Id == (int)comboBoxFornecedor.SelectedValue); } }
        public int IdFornecedor { get { return (int)comboBoxFornecedor.SelectedValue; } }
        private BindingList<Produto> Produtos { get; set; }
        public NovaCompra(BindingList<Fornecedor> fornecedores, BindingList<Produto> produtos)
        {
            InitializeComponent();
            Fornecedores = fornecedores;
            comboBoxFornecedor.ValueMember = "Id";
            comboBoxFornecedor.DisplayMember = "NomeEmpresa";
            comboBoxFornecedor.DataSource = Fornecedores;
            comboBoxFornecedor.SelectedIndex = 0;


            Produtos = produtos;
            comboBoxProduto.ValueMember = "Id";
            comboBoxFornecedor.DisplayMember = "Nome";
            comboBoxFornecedor.DataSource = Produtos;
            comboBoxProduto.SelectedIndex = 0;

        }
    }
}
