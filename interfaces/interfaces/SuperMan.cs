using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class SuperMan : Ivoador, Ipairador, Iservivo
    {
        public void comer()
        {
            Console.WriteLine("I need some baggels...");
        }

        public void decolar()
        {
            Console.WriteLine("Decolando");
        }

        public void descansar()
        {
            Console.WriteLine("Zzz...");
        }

        public void fazer_necessidades()
        {
            Console.WriteLine("Vou ao banheiro...");
        }

        public void pairar()
        {
            Console.WriteLine("Pairando");
        }

        public void pousar()
        {
            Console.WriteLine("Pousando");
        }

        public void tomar_banho()
        {
            Console.WriteLine("Singing under the shower...");
        }

        public void voar()
        {
            Console.WriteLine("Voando");
        }
    }
}
