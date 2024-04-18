/* Aula 51 - Estrutura repetitiva faça-enquanto
 * 
 * Menos utilizada, mas em alguns casos se encaixa melhor ao problema.
 * 
 * O bloco de comandos executa pelo menos uma vez, pois a condição é verificada no final.
 * 
 * Sintaxe / regra
 * 
 * do { 
 * 	comando 1
 * 	comando 2
 * } while (condição) ;
 * 
 * Regra:
 * 
 * V: volta
 * F: pula fora
 * 
 * Problema exemplo:
 * 
 * Fazer um programa para ler uma temperatura em Celsius e mostrar o equivalente em Fahrenheit.
 * Perguntar se o usuário deseja repetir (s/n). Caso o usuário digite "s", repetir o programa.
 * 
 * Fórmula: F = 9C / 5 + 32
 * 
 * Exemplo:
 * 
 * Digite a temperatura em Celsius: 30.0
 * Equivalente em Fahrenheit: 86.0
 * Deseja repetir(s/n)? s
 * Digite a temperatura em Celsius: 21.0
 * Equivalente em Fahrenheit: 69.8
 * Deseja repetir(s/n)? s
 * Digite a temperatura em Celsius: -10.5
 * Equivalente em Fahrenheit: 13.1
 * Deseja repetir(s/n)? n */

using System;
using System.Globalization;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {
            char repetir;
            double C, F;
            do {
                Console.Write("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = 9.0 * C / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));
                Console.Write("Deseja repetir(s/n)? ");
                repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's');
        }
    }
}