using System;
using System.Collections.Generic;
namespace SistemaVotacao.Cadastro;

public class Candidatos {
     public string Nome {get; set;}
    public string Partido {get; set;}
    public int Numero {get; set;}

    public Candidatos(string Nome, string Partido, int Numero) {
        this.Nome = Nome;
        this.Partido = Partido;
        this.Numero = Numero;
    }

    public Dictionary<string, (string Partido, int Numero)> cadastro = new Dictionary<string, (string, int)>();

    public void CadastroPerfil() {
        for(int i = 1; i <= 3; i++) {
            Console.WriteLine($"INFORME O NOME DO {i}º CANDIDATO: ");
            string Nome = Console.ReadLine();
            Console.WriteLine($"INFORME O PARTIDO DO {i}º CANDIDATO: ");
            string Partido = Console.ReadLine();
            Console.WriteLine($"INFORME O NÚMERO DO {i}º CANDIDATO: ");
            int Numero = int.Parse(Console.ReadLine());
            cadastro.Add(Nome, (Partido, Numero));
        }
    }

    public void ExibirPerfil() {
        foreach (var perfil in cadastro) {
            Console.WriteLine($"NOME DO CANDIDATO: {Nome} | PARTIDO DO CANDIDATO: {Partido} | NÚMERO: {Numero}");
        }
    }
}