using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MultiScreenApp
{
    public class Cliente
    {
        [DisplayName("Id do cliente: ")] public int Id { get; set; }
        [DisplayName("Nome do cliente: ")] public string Nome { get; set; }
        [DisplayName("E-mail: ")] public string Email {  get; set; }
        [DisplayName("Número de telefone: ")] public string Telefone { get; set; }
        [DisplayName("Logradouro: ")] public string Endereco {  get; set; }
    }
}
