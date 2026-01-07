//Criar um programa que gerencie o estoque de uma loja. 
//Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque. 
using System;
using System.Collections.Generic;
class Program {
    public static void Main(string[] args) {
        Dictionary<string, int> produtosEstoque = new Dictionary<string, int> {
            { "Arroz", 102 },
            { "Feijão", 99 },
            { "Café", 100 }
        };
        Console.Write("Digite um produto: ");
        string nomeProduto = Console.ReadLine();
        if (produtosEstoque.ContainsKey(nomeProduto)) {
            Console.WriteLine($"Quantidade em estoque de {nomeProduto}: {produtosEstoque[nomeProduto]} unidades.");
        } else {
            Console.WriteLine("Produto não encontrado no estoque.");
        }
    }
}