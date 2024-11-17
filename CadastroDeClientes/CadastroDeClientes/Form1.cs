using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CadastroDeClientes
{
    public partial class Home_form : Form
    {
        // Lista para armazenar os clientes cadastrados
        private List<Cliente> listaClientes = new List<Cliente>();
        private BindingSource bindingSource = new BindingSource();


        public Home_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configurar o DataGridView
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            // Definir as colunas do DataGridView
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Configurar colunas
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "ID" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nome", DataPropertyName = "Nome" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "CPF", DataPropertyName = "CPF" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Telefone", DataPropertyName = "Telefone" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Endereço", DataPropertyName = "Endereco" });

            // Vincular o BindingSource ao DataGridView
            bindingSource.DataSource = listaClientes;
            dataGridView1.DataSource = bindingSource;
        }

        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            // Abrir a janela de cadastro de cliente
            CadastrarCliente janelaCadastrar = new CadastrarCliente();

            if (janelaCadastrar.ShowDialog() == DialogResult.OK)
            {
                // Criar um novo cliente com os dados do formulário
                Cliente novoCliente = new Cliente
                {
                    ID = listaClientes.Count + 1,
                    Nome = janelaCadastrar.Nome,
                    CPF = janelaCadastrar.CPF,
                    Telefone = janelaCadastrar.Telefone,
                    Email = janelaCadastrar.Email,
                    Endereco = janelaCadastrar.Endereco
                };

                // Adicionar o novo cliente à lista
                listaClientes.Add(novoCliente);

                // Atualizar o DataGridView
                bindingSource.ResetBindings(false);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente excluir o cliente selecionado?", "Aviso:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Obter o cliente selecionado diretamente da linha selecionada
                    Cliente clienteSelecionado = (Cliente)dataGridView1.SelectedRows[0].DataBoundItem;

                    // Remover o cliente da lista
                    listaClientes.Remove(clienteSelecionado);

                    // Atualizar o DataGridView
                    bindingSource.ResetBindings(false);
                }
                else
                {
                    MessageBox.Show("Nenhum cliente selecionado para exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
