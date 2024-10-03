using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula031024visibilidade
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        private string telefone;
        private string endereco;
        private string email;

        /*        public void setIdade(int valor)
        /*        {
                    if (valor > 0)
                    {
                        this.idade = valor;
                        Console.WriteLine($"Idade atual: {this.idade}");
                    }
                    else
                    {
                        Console.WriteLine($"A idade inserida ({valor}) é inválida.");
                    }
                }*/

/*        public void setNome(string novo_nome) { 
            if (nome == "")
            {
                Console.WriteLine("O nome inserido é inválido");
            }
            else
            {
                this.nome = novo_nome;
                Console.WriteLine(this.nome);
            }
        }*/

        public string Nome
        {
            get { return (string) nome; }
            set { if (string.IsNullOrWhiteSpace(value)) this.nome = value; else Console.WriteLine("Nome inválido"); }
        }

        public int Idade
        {
            get { return (int)(idade * 0.7); }
            set { if (value > 0) this.idade = value;  }
        }

        public string Telefone
        {
            get { return (string)telefone; }
            set { if (string.IsNullOrWhiteSpace(value)) this.telefone = value; else Console.WriteLine("Telefone inválido"); }
        }

        public string Endereco
        {
            get { return (string)endereco; }
            set { if (string.IsNullOrWhiteSpace(value)) this.endereco = value; else Console.WriteLine("Email inválido"); }
        }

        public string Email
        {
            get { return (string)email; }
            set { if (string.IsNullOrWhiteSpace(value)) this.email = value; else Console.WriteLine("Email inválido"); }
        }

    }
}
