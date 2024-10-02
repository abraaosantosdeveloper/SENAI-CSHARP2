using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class Aviao : Ivoador, Imaquina
    {
        public void abastecer()
        {
            Console.WriteLine("Refueling...");
        }

        public void decolar()
        {
            Console.WriteLine("V1, Rotate...");
        }

        public void desligar()
        {
            Console.WriteLine("Engines off..."); ;
        }

        public void ligar()
        {
            Console.WriteLine("Beacon lights on...");
        }

        public void limpar_ou_lavar()
        {
            Console.WriteLine("Cleaning seats");
        }

        public void manutenir()
        {
            Console.WriteLine("Searching for issues...");
        }

        public void pousar()
        {
            Console.WriteLine("50, 40, 30, 20, 10, retard... retard... retard... 5");
        }

        public void voar()
        {
            Console.WriteLine("Reached cruise altitude.");
        }
    }
}
