// See https://aka.ms/new-console-template for more information

using UC_Backend.classes;

Console.Clear();

PessoaJuridica pj = new PessoaJuridica();
PessoaJuridica MetodosPJ = new PessoaJuridica();
Console.WriteLine("Qual o nome da Pessoa Juridica?");
pj.Nome = Console.ReadLine();

Console.WriteLine("Qual o CNPJ da Pessoa Juridica?");
pj.CNPJ = Console.ReadLine();

Console.WriteLine("Qual o Rendimento da Pessoa Juridica?");
pj.Rendimento = float.Parse(Console.ReadLine());

MetodosPJ.Inserir(pj);
Console.WriteLine("Sucesso!");

