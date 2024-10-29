using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreenApp
{
    public class Produto
    {
        [DisplayName("Id")] public int Id { get; set; }
        [DisplayName("Nome")] public string Nome { get; set; }
        [DisplayName("Nome do fabricante")] public string Fabricante { get; set; }

        [DisplayName("Preço de compra")] public decimal PrecoCompra {  get; set; }
        [DisplayName("Preço de venda")] public decimal PrecoVenda { get; set; }
    }
}
