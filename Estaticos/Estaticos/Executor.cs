using System;

namespace Estaticos
{
    class Executor
    {
        static void Main(string[] args)
        {
            var pessoa1 = new Pessoa { Nome = "Alice", Idade = 30 };
            var pessoa2 = new Pessoa { Nome = "Bob", Idade = 25 };
            var pessoa3 = new Pessoa { Nome = "Rodrigo", Idade = 25 };

            var conta1 = new Pessoa.ContaBancaria("Alice", 1000);
            var conta2 = new Pessoa.ContaBancaria("Bob", 2000);
            var conta3 = new Pessoa.ContaBancaria("Rodrigo", 2000);

            Console.WriteLine($"Total de pessoas cadastradas: {Pessoa.ContagemPessoasCadastradas}");
            Console.WriteLine($"Total de contas cadastradas: {Pessoa.ContaBancaria.ContagemContasCadastradas}");
        }
    }
}
