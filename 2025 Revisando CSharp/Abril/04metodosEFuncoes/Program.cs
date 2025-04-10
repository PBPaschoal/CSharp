using System;

namespace Program {

    internal class Program {

        public static void Main(string[] args) {

            DigaOla();
            Saudacao("Paulo");
            int resultado = Somar(10, 5);
            Console.WriteLine("Resultado: " + resultado);
        }

        static void DigaOla() {
            Console.WriteLine("Olá, tudo bem?");
        }

        static void Saudacao(string nome) {
            Console.WriteLine("Olá, " + nome + "!");
        }

        static int Somar(int a, int b) {
            return a + b;
        }
    }
}