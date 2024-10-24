using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MultiScreenApp
{
    internal class Fornecedor
    {
        [DisplayName("Id: ")] public int Id { get; set; }
        [DisplayName("CNPJ: ")] public string CNPJ { get; set; }
        [DisplayName("Nome da empresa: ")] public string NomeEmpresa { get; set; }
        [DisplayName("Nome de contato: ")] public string NomeContato { get; set; }
        [DisplayName("Número de telefone: ")] public string Telefone { get; set; }
        [DisplayName("Endereço de E-mail: ")] public string Email { get; set; }
        [DisplayName("Logradouro: ")] public string Endereco { get; set; }

    }
}
