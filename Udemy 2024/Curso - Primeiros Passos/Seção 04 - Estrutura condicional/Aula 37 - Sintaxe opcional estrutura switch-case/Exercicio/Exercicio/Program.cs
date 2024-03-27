/* Fazer um programa para ler um valor inteiro de 1 a 7 representando um dia da semana
 * (sendo 1=domingo, 2=segunda, e assim por diante).
 * Escrever na tela o dia da semana correspondente, conforme exemplos:
 * 
 * Entrada: 			Saída:
 * 1     				Dia da semana: domingo
 * 
 * Entrada: 			Saída:
 * 4 		        	Dia da semana: quarta
 * 
 * Entrada:			    Saída:
 * 9				    Dia da semana: valor inválido */

using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            valor = int.Parse(Console.ReadLine());
            string dia;

            switch (valor)
            {
                case 1:
                    dia = "domingo";
                    break;
                case 2:
                    dia = "segunda";
                    break;
                case 3:
                    dia = "terça";
                    break;
                case 4:
                    dia = "quarta";
                    break;
                case 5:
                    dia = "quinta";
                    break;
                case 6:
                    dia = "sexta";
                    break;
                case 7:
                    dia = "sábado";
                    break;
                default:
                    dia = "valor inválido";
                    break;
            }
            Console.WriteLine("Dia da semana: " + dia);
        }
    }
}