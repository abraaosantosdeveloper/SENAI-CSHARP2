using System.ComponentModel;

namespace CadastroDeClientes
{
    internal class Cliente
    {
        [DisplayName("ID")] public int ID { get; set; }
        [DisplayName("Nome do Cliente")] public string Nome { get; set; }
        [DisplayName("CPF")] public string CPF { get; set; }
        [DisplayName("Registro Geral")] public string RG { get; set; }
        [DisplayName("Telefone")] public string Telefone { get; set; }
        [DisplayName("Email")] public string Email { get; set; }
        [DisplayName("Data de Nascimento")] public string DataNascimento { get; set; }
        [DisplayName("Gênero")] public string Genero { get; set; }
        [DisplayName("Status")] public string Status { get; set; }
        [DisplayName("Endereço")] public string Endereco { get; set; }
        [DisplayName("Observações")] public string Observacoes { get; set; }
    }
}
