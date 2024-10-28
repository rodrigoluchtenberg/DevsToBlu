using System;

namespace FormaGeometrica
{
    public abstract class FormaGeometrica
    {
        public abstract double CalcularPerimetro();
    }

    public class Retangulo : FormaGeometrica
    {
        private double largura;
        private double altura;

        public Retangulo(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (largura + altura);
        }
    }

    public class Triangulo : FormaGeometrica
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public override double CalcularPerimetro()
        {
            return lado1 + lado2 + lado3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo(23, 3);
            Triangulo triangulo = new Triangulo(3, 4, 5);

            Console.WriteLine($"Perímetro do retângulo: {retangulo.CalcularPerimetro()}");
            Console.WriteLine($"Perímetro do triângulo: {triangulo.CalcularPerimetro()}");
        }
    }
}
