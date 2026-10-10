namespace SistemaVotacao.Menu;

public class Menu {
    public int Opcao {get; set;}

    public Menu() {
        this.Opcao = Opcao;
    }

Votos votos = new();
    public void OpcoesDeMenu() {
        Console.WriteLine(":::::::::: MENU :::::;::::");
        Console.WriteLine("[1] VOTAR");
        Console.WriteLine("[2] PAINEL ADMINISTRATIVO");
        Console.Write("ESCOLHA UMA OPÇÃO: ");
        Opcao = int.Parse(Console.ReadLine());
        switch(Opcao){
            case 1:
                Console.WriteLine("Opção 1");
                votos.Votacoes();
                break;
            case 2:
                Console.WriteLine("Opção 2");
                break;
            default:
                Console.WriteLine("Opção invalida.");
                break;
        }
    }
}