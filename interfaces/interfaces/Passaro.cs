using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class Passaro : Ivoador, Iservivo
    {
        public void comer()
        {
            Console.WriteLine("Eating");
        }

        public void decolar()
        {
            Console.WriteLine("Decolando");
        }

        public void descansar()
        {
            Console.WriteLine("Sleeping...");
        }

        public void fazer_necessidades()
        {
            Console.WriteLine("...");
        }

        public void pousar()
        {
            Console.WriteLine("Pousando");
        }

        public void tomar_banho()
        {
            Console.WriteLine("Washing");
        }

        public void voar()
        {
            Console.WriteLine("Voando"); ;
        }
    }
}
