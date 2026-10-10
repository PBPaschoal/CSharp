namespace SistemaVotacao.Menu;

public class Senha {
    public string senhaPadrao {get;}
    public string novaSenha {get; set;}

    public Senha() {
        this.senhaPadrao = senhaPadrao;
        this.novaSenha = novaSenha;
    }

    public void NovaSenha(string senhaPadrao) {
        Console.WriteLine("###############################");
        Console.WriteLine("INFORME A SENHA ADMINISTRATIVA:");
        int tentativas = 3;
        do {
            string login01 = Console.ReadLine();
            if(login01 == senhaPadrao) {
                Console.WriteLine("LOGADO COM SUCESSO!");
                Console.WriteLine("###############################");
                Console.WriteLine();
                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::");
                Console.WriteLine("TROCA DE SENHA OBRIGATORIA!\nINFORME A NOVA SENHA:");
                novaSenha = Console.ReadLine();
                Console.WriteLine(">>> SENHA GRAVADA COM SUCESSO! <<<");
                Console.WriteLine("\n> [ APERTE ENTER PARA CONTINUAR ] <");
                Console.ReadLine();
                Console.Clear();
                break;
            } else {
                Console.WriteLine("SENHA INVALIDA!");
                tentativas--;
                if(tentativas > 0) {
                    Console.WriteLine($"VOCÊ TEM MAIS [{tentativas}] TENTATIVAS.");
                    Console.WriteLine("INFORME A SENHA ADMINISTRATIVA:");
                } else {
                    Console.WriteLine("NÚMERO DE TENTATIVAS EXPIRADO! SENHA INVALIDA!!!\nPROGRAMA ENCERRADO!!!");
                }
            }
        } while (tentativas > 0);
    }
}