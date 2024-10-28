using System;

namespace Estaticos
{
    public class Pessoa
    {
        private static int _ContagemPessoasCadastradas = 0;
        public static int ContagemPessoasCadastradas { get => _ContagemPessoasCadastradas; }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa()
        {
            _ContagemPessoasCadastradas++;
        }


        public class ContaBancaria
        {
            private static int _ContagemContasCadastradas = 0;
            public static int ContagemContasCadastradas { get => _ContagemContasCadastradas; }

            public static int GerarNumeroConta() => ++_ContagemContasCadastradas;
            public int NumeroConta { get; private set; }
            public string Titular { get; private set; }
            public decimal Saldo { get; private set; }

            public ContaBancaria(string titular, decimal saldoInicial)
            {
                Titular = titular;
                Saldo = saldoInicial;
                NumeroConta = GerarNumeroConta();
            }

            public void Depositar(decimal valor)
            {
                if (valor > 0)
                {
                    Saldo += valor;
                }
            }

            public void Sacar(decimal valor)
            {
                if (valor > 0 && Saldo >= valor)
                {
                    Saldo -= valor;
                }
            }
        }
    }
}
