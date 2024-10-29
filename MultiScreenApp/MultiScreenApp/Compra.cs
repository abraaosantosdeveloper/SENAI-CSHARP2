using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MultiScreenApp
{
    public class Compra
    {
        [DisplayName("Id: ")] public int Id { get; set; }
        [DisplayName("Id do produto: ")] public int IdProduto { get; set; }
        [DisplayName("Id do fornecedor: ")] public int IdFornecedor {  get; set; }
        [DisplayName("Quantidade comprada: ")] public int Quantidade {  get; set; }
        [DisplayName("Porcentagem de desconto: ")] public decimal Desconto { get; set; }
        [DisplayName("Data da compra: ")] public DateTime DataCompra { get; set; }
    }
}
