using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main(string[] args) {
        for (int i = 0; i <= 10; i++) {
            Console.WriteLine(i);
        }

        Console.WriteLine("----");
        int saldo = 100;
        while (saldo > 0) {
            saldo -= 15;
            Console.WriteLine($"Saldo restante: {saldo}");
        }

        int opcao;

        do {
            Console.WriteLine("Digite um número (0 para sair):");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou: {opcao}");
        } while (opcao != 0);

        string[] frutas = { "maçã", "banana", "uva" };
        foreach (string fruta in frutas) {
            Console.WriteLine(fruta);
        }

        //Exercício 1 (for):
        //Escreva um programa que imprima os números de 1 a 20, mas pule os múltiplos de 3(não imprima eles).
        
        for (int i = 1; i <= 20; i++) {
            if (i % 3 != 0) {
                Console.WriteLine(i);
            }
        }

        //Exercício 2 (while):
        //Peça ao usuário para digitar números inteiros. Continue somando os números digitados 
        // até que o usuário digite 0. No final, mostre a soma total. 
        // (Dica: pense por que aqui faz mais sentido while do que do-while, ou será que 
        // faz mais sentido do-while? Pense nisso.)

        int soma = 0;
        int valor;
        do {
            Console.WriteLine("Digite um valor:");
            valor = int.Parse(Console.ReadLine());
            soma += valor;
        } while (valor != 0);

        Console.WriteLine($"A soma total dos valores digitados são: {soma}");

        // Exercício 4 (foreach):
        // Dada uma lista de nomes List<string> nomes = new List<string> { "Anna", "Bruno", "Carla", "Diego" }, percorra a lista e 
        // imprima apenas os nomes que começam com a letra "A" ou "B".
        List<string> nomes = new List<string> { "Anna", "Bruno", "Carla", "Diego"};

        Console.WriteLine("---- LINQ + StartsWith ----");
        // Usando LINQ + StartsWith
        var nomesFiltrados = nomes.Where(nome => nome.StartsWith("A") || nome.StartsWith("B"));

        foreach (string nome in nomesFiltrados) {
            Console.WriteLine(nome);
        }

        Console.WriteLine("---- StartsWith ----");
        // Usando apenas .StartsWith()
        foreach (string nome in nomes)
        {
            if (nome.StartsWith("A") || nome.StartsWith("B"))
            {
                Console.WriteLine(nome);
            }
        }
        
    }
}