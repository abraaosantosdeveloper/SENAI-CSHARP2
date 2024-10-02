using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class Helicopter : Ivoador, Ipairador, Imaquina
    {
        public void abastecer()
        {
            Console.WriteLine("Refueling...");
        }

        public void decolar()
        {
            Console.WriteLine("Decolando");
        }

        public void desligar()
        {
            Console.WriteLine("Engines off...");
        }

        public void ligar()
        {
            Console.WriteLine("Engines On...");
        }

        public void limpar_ou_lavar()
        {
            Console.WriteLine("Washing...");
        }

        public void manutenir()
        {
            Console.WriteLine("Searching for issues...");
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
