using System;
using System.Collections.Generic;
class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Adicionando Banda!");
        Console.Write("Digite o nome da banda: ");
        string nomeDaBanda = Console.ReadLine();

        List<string> minhasMusicas = new List<string>();
        minhasMusicas.Add(nomeDaBanda);

        AddNovaBanda(minhasMusicas);

        foreach (string banda in minhasMusicas) {
            Console.WriteLine($"Banda adicionada: {banda}");
        }
    }
    static void AddNovaBanda(List<string> minhasMusicas) {
        Console.Write("Deseja adicionar outra banda? (1 = Sim / 0 = Não): ");
        int escolha = int.Parse(Console.ReadLine());

        if (escolha == 1) {
            Console.Write("Digite o nome da banda: ");
            string nomeDaBanda = Console.ReadLine();
            minhasMusicas.Add(nomeDaBanda);

            AddNovaBanda(minhasMusicas);
        }
    }
}
