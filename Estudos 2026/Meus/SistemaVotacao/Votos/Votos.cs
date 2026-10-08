namespace SistemaVotacao.Menu;

public class Votos {
    public int VotoValidos {get; set;}
    public int VotosEmBranco {get; set;}
    public int VotosNulos {get; set;}
    public int Opcao {get; set;}

    public Votos() {
        this.VotoValidos = VotoValidos;
        this.VotosEmBranco = VotosEmBranco;
        this.VotosNulos = VotosNulos;
        this.Opcao = Opcao;
    }

    Candidatos candidatos = new();

    public void Votacoes() {
        Console.WriteLine(":::::::::::::::::::::::::::::");
        Console.WriteLine("::::: INICIANDO VOTAÇÃO :::::");
        Console.WriteLine("> ESCOLHA UM(A) CANDIDATO(A) ");
        Console.WriteLine(":::::::::::::::::::::::::::::");
        candidatos.ExibirPerfil();
        Console.Write("\nDIGITE O NÚMERO DO(A) CANDIDATO(A): ");
        Opcao = int.Parse(Console.ReadLine());
        switch(Opcao) {
            case int valorOpcao when valorOpcao == candidatos.Numero:
                Console.WriteLine($"1 VOTO SALVO PARA {candidatos.Nome}");
                break;
        }
    }

}