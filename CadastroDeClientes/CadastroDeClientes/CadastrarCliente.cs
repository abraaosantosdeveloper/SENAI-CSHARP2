using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CadastroDeClientes
{
    public partial class CadastrarCliente : Form
    {
        private object comboBoxStatus;

        public CadastrarCliente()
        {
            InitializeComponent();

            // Listas de estados e países
            List<string> estadosBrasil = new List<string>
            {
                "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espírito Santo",
                "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba",
                "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul",
                "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins"
            };

            List<string> paises = new List<string>
            {
                "Brazil", "United States of America", "Canada", "France", "Germany", "Italy", "Japan", "United Kingdom", "Australia",
                "Mexico", "Argentina", "Chile", "China", "Russia", "India", "South Africa", "New Zealand"
            };

            // Configuração dos ComboBoxes
            comboBoxUF.DataSource = estadosBrasil;
            comboBoxUF.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxUF.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxPais.DataSource = paises;
            comboBoxPais.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxPais.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public int ID { get; set; }
        public string Nome { get { return textBoxNome.Text; } }
        public string CPF { get { return textBoxCPF.Text; } }
        public string RG { get { return textBoxRG.Text; } }
        public string Telefone { get { return textBoxTelefone.Text; } }
        public string Email { get { return textBoxEmail.Text; } }
        public string DataNascimento { get { return dateTimePickerNascimento.Text; } }
        public string Genero { get { return radioButtonMasculino.Checked ? "Masculino" : "Feminino"; } }
        public string Status { get { return radioButtonVigente.Checked ? "Vigente" : "Rescindido"; } }

        // Propriedade Endereço aprimorada
        public string Endereco
        {
            get
            {
                return $"{textBoxLogradouro.Text}, {textBoxNumero.Text}, {textBoxBairro.Text}, {textBoxCidade.Text}, " +
                       $"{comboBoxUF.Text}, {textBoxCEP.Text}, {comboBoxPais.Text}";
            }
        }
        public string Observacoes { get { return textBoxObs.Text; } }

        // Método para criar um objeto Cliente
        private Cliente CriarCliente()
        {
            return new Cliente
            {
                Nome = this.Nome,
                CPF = this.CPF,
                RG = this.RG,
                Telefone = this.Telefone,
                Email = this.Email,
                DataNascimento = this.DataNascimento,
                Genero = this.Genero,
                Status = this.Status,
                Endereco = this.Endereco,
                Observacoes = this.Observacoes
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validação básica antes de salvar
            if (string.IsNullOrWhiteSpace(Nome) || string.IsNullOrWhiteSpace(CPF))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cliente novoCliente = CriarCliente();
            MessageBox.Show($"Cliente {novoCliente.Nome} cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK);
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}
