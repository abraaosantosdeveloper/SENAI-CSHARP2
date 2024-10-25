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
    public partial class NovoCliente : Form
    {
        public NovoCliente()
        {
            InitializeComponent();
        }
        public string Endereco
        {
            get
            {
                string endereco = "";
                endereco += $"{textBoxLogradouro.Text} - ";
                endereco += $"{textBoxNumero.Text} - ";
                endereco += $"{textBoxComplemento.Text} - ";
                endereco += $"{textBoxCidade.Text} - ";
                endereco += $"{textBoxUF.Text} - ";
                endereco += $"CEP: {textBoxCEP.Text}";
                return endereco;

            }
        }
        public string Email { get { return textBoxEmail.Text; } }
        public string Nome { get { return textBoxNome.Text; } }
        public string Telefone { get { return textBoxTelefone.Text; } }

        public int Id { get; internal set; }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
