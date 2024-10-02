using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class Beijaflor : Passaro, Ipairador
    {
        // { ... }
        public void pairar()
        {
            Console.WriteLine("Pairando");
        }
    }
}
