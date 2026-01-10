//Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
using System;
using System.Collections.Generic;

class Program {
    public static void Main(string[] args) {
        Dictionary<string, List<double>> alunoRegistrado =
            new Dictionary<string, List<double>>();

        alunoRegistrado.Add("Claudia", new List<double> { 10, 9, 9 });

        foreach (var aluno in alunoRegistrado) {
            double soma = 0;

            foreach (double nota in aluno.Value) {
                soma += nota;
            }

            double media = soma / aluno.Value.Count;

            Console.WriteLine($"Aluno: {aluno.Key} | Média: {media}");
        }
    }
}
