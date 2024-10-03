// Tipos de visibilidade: public, private, internal, protected, protected internal

/*
Console.Write("Insira o nome: ");
string novo_nome = Console.ReadLine();
Console.Write("Insira a idade: ");
int valor = int.Parse(Console.ReadLine());

p.setNome(novo_nome); 
p.Idade = valor;

Console.WriteLine(p.Idade);*/


using aula031024visibilidade;

Pessoa p = new Pessoa();

Console.Write("Digite o Nome: ");
p.Nome = Console.ReadLine();


Console.Write("Digite o idade: ");
p.Idade = int.Parse(Console.ReadLine());


Console.Write("Digite o telefone: ");
p.Telefone = Console.ReadLine();


Console.Write("Digite o endereço: ");
p.Endereco = Console.ReadLine();


Console.Write("Digite o Email: ");
p.Email = Console.ReadLine();

Console.WriteLine("===================================================");

Console.WriteLine("Informações cadastradas do usuário: ");
Console.WriteLine(p.Nome);
Console.WriteLine(p.Idade);
Console.WriteLine(p.Telefone);
Console.WriteLine(p.Endereco);
Console.WriteLine(p.Email);
