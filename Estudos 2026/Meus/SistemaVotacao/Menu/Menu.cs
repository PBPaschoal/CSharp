using System;
using System.Dynamic;
namespace SistemaVotacao.Menu;

public class Menu {
    public int Opcao {get; set;}

    public Menu() {
        this.Opcao = Opcao;
    }

    public void OpcoesDeMenu() {
        Console.WriteLine(":::::: INICIANDO MENU ::::::");
        Console.WriteLine("[1] VOTAR");
        Console.WriteLine("[2] PAINEL ADMINISTRATIVO");
        Console.Write("ESCOLHA UMA OPÇÃO: ");
        Opcao = int.Parse(Console.ReadLine());
        switch(Opcao){
            case 1:
                Console.WriteLine("Opção 1");
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