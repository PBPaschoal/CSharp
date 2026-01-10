//Crie um programa que implemente um quiz simples de perguntas e respostas. 
//Utilize um dicionário para armazenar as perguntas e as respostas corretas.
using System;
using System.Collections.Generic;
class Program {
    public static void Main(string[] args) {
        Dictionary<string, string> perguntas = new Dictionary<string, string> {
            { "Qual é a capital do estado de São Paulo?", "São Paulo" },
            { "Qual é a capital do Brasil?", "Brasília" },
            { "Em que mês estamos?", "Janeiro" }
        };

        int acertos = 0;

        foreach (var pergunta in perguntas) {
            Console.WriteLine(pergunta.Key);
            Console.Write("Sua resposta: ");
            string respostaUsuario = Console.ReadLine();

            if (respostaUsuario.Equals(pergunta.Value, StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("Resposta correta!\n");
                acertos++;
            } else {
                Console.WriteLine($"Você errou! A resposta correta é: {pergunta.Value}\n");
            }
        }

        Console.WriteLine($"Você acertou {acertos} de {perguntas.Count} perguntas.");
    }
}
