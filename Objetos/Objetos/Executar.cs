using System;
using System.Collections.Generic;

namespace Objetos
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
    }

    public class Carro
    {
        public string? Modelo { get; set; }
        public string? Marca { get; set; }
        public int Ano { get; set; }
        public string? Placa { get; set; }
        public string? Cor { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("O carro está acelerando!");
        }
        public override string ToString()
        {
            return $"Modelo: {Modelo}, Cor: {Cor}, Ano: {Ano}";
        }
    }

    public class Executar
    {
        public static void ExecutarAPlicacao()
        {
            var carro = new Carro();
            carro.Modelo = "HB20";
            carro.Cor = "Prata";
            carro.Ano = 2022;

            var carroCopia = new Carro();
            carroCopia.Modelo = "Celta";
            carroCopia.Cor = "Vermelho";
            carroCopia.Ano = 2024;

            Console.WriteLine(carro.ToString());
            Console.WriteLine(carroCopia.ToString());


        }
    }
}
