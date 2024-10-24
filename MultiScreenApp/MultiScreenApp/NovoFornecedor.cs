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
    public partial class NovoFornecedor : Form
    {
        public NovoFornecedor()
        {
            InitializeComponent();
        }

        public string CNPJ { get { return textBoxCNPJ.Text; } }
        public string Endereco
        {
            get
            {
                string endereco = "";
                endereco += $"{textBoxLogradouro.Text} - ";
                endereco += $"{textBoxNumero.Text} - ";
                endereco += $"{textBoxComplemento.Text} - ";
                endereco += $"{textBoxCidade.Text} - ";
                endereco += $"{textBoxEstado.Text} - ";
                endereco += $"CEP: {textBoxCEP.Text}";
                return endereco;

            }
        }
        public string Email { get { return textBoxEmail.Text;  } }
        public string NomeEmpresa { get { return textBoxNomeEmpresa.Text; } }
        public string Telefone { get { return textBoxTelefone.Text; } }
        public string NomeContato { get { return textBoxNomeContato.Text; } }

        public int Id { get; internal set; }

        private void btnFornecedorOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnFornecedorCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
