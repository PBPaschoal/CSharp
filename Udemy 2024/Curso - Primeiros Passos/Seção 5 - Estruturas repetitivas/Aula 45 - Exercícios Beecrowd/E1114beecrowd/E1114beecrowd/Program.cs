/* Aula 45 Exercício 1114 Beecrowd - Senha Fixa
 * Escreva um programa que repita a leitura de uma senha até que ela seja válida. 
 * Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida". 
 * Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. 
 * Considere que a senha correta é o valor 2002. 
 * 
 * Entrada
 * A entrada é composta por vários casos de testes contendo valores inteiros.
 * 
 * Saída
 * Para cada valor lido mostre a mensagem correspondente à descrição do problema.
 * 
 * Exemplo de Entrada	        Exemplo de Saída
 * 2200                         Senha Invalida
 * 1020                         Senha Invalida
 * 2022                         Senha Invalida
 * 2002                         Acesso Permitido */

using System;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {
            int senhaOriginal = 2002;
            int acessar;
            acessar = int.Parse(Console.ReadLine());
            while(acessar != senhaOriginal) {
                Console.WriteLine("Senha Invalida");
                acessar = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}