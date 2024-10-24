using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreenApp
{
    internal class Venda
    {
        [DisplayName("Id: ")] public int Id { get; set; }
        [DisplayName("Id do produto: ")] public int IdProduto { get; set; }
        [DisplayName("Id cliente: ")] public int IdCliente { get; set; }
        [DisplayName("Quantidade: ")] public int Quantidade {  get; set; }
        [DisplayName("Desconto: ")] public decimal Desconto { get; set; }
        [DisplayName("Data da venda: ")] public DateTime DataVenda { get; set; }

    }
}
