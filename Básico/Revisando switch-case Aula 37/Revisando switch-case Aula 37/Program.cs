/* Revisando Aula 37 switch-case
 * Rio de Janeiro dia 11-01-2021
 * Estrutura switch-case
 * Quando se tem três ou mais opções de fluxo a serem tratadas com base no valor de uma variável, ao invés de várias estruturas 
 * if-else encadeadas, alguns preferem utilizar a estrutura switch-case.
 * Problema exemplo:
 * Fazer um programa para ler um valor inteiro de 1 a 7 representando um dia da semana (sendo 1=domingo, 2=segunda, e assim por
 * diante). Escrever na tela o dia da semana correspondente, conforme exemplos.
 * Entrada:
 * 1
 * Saída:
 * Dia da semana: domingo
 * Entrada:
 * 4
 * Saída:
 * Dia da semana: quarta */

using System;

namespace Revisando_switch_case_Aula_37
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());

            switch (entrada)
            {
                case 1: 
                    Console.WriteLine("Dia da semana: domingo");
                    break;
                case 2:
                    Console.WriteLine("Dia da semana: segunda");
                    break;
                case 3:
                    Console.WriteLine("Dia da semana: terça");
                    break;
                case 4:
                    Console.WriteLine("Dia da semana: quarta");
                    break;
                case 5:
                    Console.WriteLine("Dia da semana: quinta");
                    break;
                case 6:
                    Console.WriteLine("Dia da semana: sexta");
                    break;
                case 7:
                    Console.WriteLine("Dia da semana: sexta");
                    break;
                default:
                    Console.WriteLine("Valor invalido");
                    break;
            }
        }
    }
}
