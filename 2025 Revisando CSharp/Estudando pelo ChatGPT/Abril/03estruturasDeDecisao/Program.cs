using System;

namespace Program {

    internal class Program {

        static void Main(string[] args) {

            Console.Write("Que dia é hoje? ");
            string dia = Console.ReadLine();

            Console.Write("E está de noite? ");
            string resposta = Console.ReadLine();

            if (resposta == "Sim" || resposta == "sim") {
                Console.WriteLine($"Então se hoje é {dia} e está de noite, então estamos em casa!");
            } else {
                Console.WriteLine($"Então se hoje é {dia} e não está de noite, então não estamos em casa!");
            }
            Console.WriteLine("");
            Console.Write("Confirme o dia de hoje: ");
            int numero_dia = int.Parse(Console.ReadLine());

            Console.Write("Sim, hoje é ");
            switch (numero_dia) {
                case 0: Console.Write("Domingo");
                    break;
                case 1: Console.Write("Segunda-feira");
                    break;
                case 2: Console.Write("Terça-feira");
                    break;
                case 3: Console.Write("Quarta-feira");
                    break;
                case 4: Console.Write("Quinta-feira");
                    break;
                case 5: Console.Write("Sexta-feira");
                    break;
                case 6: Console.Write("Sábado");
                    break;
                default: Console.WriteLine("- ERRO!");
                    break;
            }
        }
    }
}