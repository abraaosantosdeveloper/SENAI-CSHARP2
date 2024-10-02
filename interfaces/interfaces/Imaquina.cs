using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public interface Imaquina
    {
        public void ligar();
        public void desligar();
        public void abastecer();
        public void manutenir();
        public void limpar_ou_lavar();
    }
}
