using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class DiscoVoador : Ivoador, Ipairador, Imaquina
    {
        public void abastecer()
        {
            Console.WriteLine("How does this thing refuel?");
        }

        public void decolar()
        {
            Console.WriteLine("Decolando");
        }

        public void desligar()
        {
            Console.WriteLine("Never drove a UFO... =P");
        }

        public void ligar()
        {
            Console.WriteLine("I don't even know how is this thing's dashboard...");
        }

        public void limpar_ou_lavar()
        {
            Console.WriteLine("Should I use water?");
        }

        public void manutenir()
        {
            Console.WriteLine("What does this thing use to fly?");
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
