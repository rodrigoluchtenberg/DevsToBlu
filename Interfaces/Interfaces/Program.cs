using System;

namespace Interfaces
{
    public interface IAutenticavel
    {
        void Autenticar(string senha);
        void Deslogar();
    }

    public class Usuario : IAutenticavel
    {
        private string Senha { get; set; }
        public string Nome { get; set; }
        public bool EstaAutenticado { get; private set; }

        public Usuario(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
            EstaAutenticado = false;
        }

        public void Autenticar(string senha)
        {
            if (senha == Senha)
            {
                EstaAutenticado = true;
                Console.WriteLine($"{Nome} autenticado com sucesso!");
            }
            else
            {
                Console.WriteLine("Senha incorreta. Autenticação falhou.");
            }
        }

        public void Deslogar()
        {
            EstaAutenticado = false;
            Console.WriteLine($"{Nome} deslogado com sucesso.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario("João", "senha123");

            usuario.Autenticar("senha123");
            usuario.Deslogar();

            usuario.Autenticar("senhaErrada");
        }
    }
}









//namespace Interfaces
//{
//    public interface IMotor
//    {
//        void Ligar();
//        void Desligar();
//    }

//    public abstract class Carro
//    {
//        public string Marca { get; set; }
//        public string Modelo { get; set; }
//        public IMotor Motor { get; set; }

//        public void Acelerar()
//        {
//            Console.WriteLine($"{Modelo} está acelerando!");
//        }

//        public void Frear()
//        {
//            Console.WriteLine($"{Modelo} está freando!");
//        }
//    }

//    public class Gol : Carro
//    {
//        public Gol(IMotor motor)
//        {
//            Marca = "Volkswagen";
//            Modelo = "Gol";
//            Motor = motor;
//        }
//    }

//    public class MotorGasolina : IMotor
//    {
//        public void Ligar()
//        {
//            Console.WriteLine("Motor a gasolina ligado.");
//        }

//        public void Desligar()
//        {
//            Console.WriteLine("Motor a gasolina desligado.");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            IMotor motor = new MotorGasolina();
//            Carro meuCarro = new Gol(motor);

//            meuCarro.Motor.Ligar();
//            meuCarro.Acelerar();
//            meuCarro.Frear();
//            meuCarro.Motor.Desligar();
//        }
//    }
//}
