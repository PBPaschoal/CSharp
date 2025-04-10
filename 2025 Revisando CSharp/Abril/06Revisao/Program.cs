using System;

namespace Program {

    internal class Program {

        public static void Main(string[] args) {

            Console.Write("Informe o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Informe a sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Que dia da semana é hoje? ");
            int dia = int.Parse(Console.ReadLine());

            if (dia <= 7 && dia >= 1)
            {
                Console.Write("Então hoje é ");
            }

            switch (dia) {
                case 1:
                    Console.WriteLine("Domingo!");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira!");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira!");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira!");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira!");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira!");
                    break;
                case 7:
                    Console.WriteLine("Sábado!");
                    break;
                default:
                    Console.WriteLine("Dia invalido!");
                    break;
            }

            bool confereIdade;
            if (confereIdade = idade >= 18) {
                Console.WriteLine("Como você é maior de idade, já pode ir ao mercado de carro.");
            }
            else {
                Console.WriteLine("Você ainda não pode dirigir o proprio carro por ser menor de idade.");
            }

            int ano = 2025 - idade;
            Console.WriteLine("Você nasceu em " + ano);
            Console.WriteLine("Você deseja contar até quanto? ");
            int contagem = int.Parse(Console.ReadLine());
            for (int i = 0; i <= contagem; i++) {
                Console.Write(i + ", ");
            }
            Console.WriteLine("");
            Console.WriteLine("Agora vou contar ao contrario:");
            while (contagem >= 0) {
                Console.Write(contagem-- + ", ");
            }


        }
    }
}