using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class Ghost : Ivoador, Ipairador
    {
        public void decolar()
        {
            Console.WriteLine("Decolando");
        }

        public void pairar()
        {
            Console.WriteLine("Pairando");
        }

        public void pousar()
        {
            Console.WriteLine("Pousando");
        }

        public void voar()
        {
            Console.WriteLine("Voando");
        }
    }
}
