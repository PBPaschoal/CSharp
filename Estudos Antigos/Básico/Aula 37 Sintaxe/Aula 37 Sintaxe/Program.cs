//Rio de Janeiro Dia 15-08-2021
//Sintaxe opcional: estrutura switch-case Aula 37 Curso: C# primeiros passos Lógica de Programação e Algoritmos - Professor Nélio Alves
//Fazer um programa para ler um valor inteiro de 1 a 7 representando um dia da semana (sendo 1=domingo, 2=segunda, e assim por diante).
//Escrever na tela o dia da semana correspondente, conforme exemplos.
//Entrada:                                                  Saída:
//1                                                         Dia da semana: domingo
//Entrada:                                                  Saída:
//4                                                         Dia da semana: quarta

using System;

namespace Aula_37_Sintaxe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o dia da semana: ");
            int valor = int.Parse(Console.ReadLine());
            string dia;

            switch (valor)
            {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda";
                    break;
                case 3:
                    dia = "Terça";
                    break;
                case 4:
                    dia = "Quarta";
                    break;
                case 5:
                    dia = "Quinta";
                    break;
                case 6:
                    dia = "Sexta";
                    break;
                case 7:
                    dia = "Sábado";
                    break;
                default:
                    dia = "valor inválido";
                    break;
            }

            Console.WriteLine("Dia da semana: " + dia);
            Console.ReadLine();
        }
    }
}
