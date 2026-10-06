using SistemaVotacao.Cadastro;


Console.WriteLine("********************");
Console.WriteLine(" SISTEMA DE VOTAÇÃO ");
Console.WriteLine("********************\n");

int opcao = 0;
string senhaPadrao = "votos2026";

Candidatos perfil = new Candidatos();

Console.WriteLine("[1] - CADASTRAR CANDIDATOS");
Console.WriteLine("[2] - SAIR");
opcao = int.Parse(Console.ReadLine());
if(opcao == 1) {
    Console.WriteLine("###############################");
    Console.WriteLine("INFORME A SENHA ADMINISTRATIVA:");
    int tentativas = 3;
    do {
        string login01 = Console.ReadLine();
        if(login01 == senhaPadrao) {
            Console.WriteLine("LOGADO COM SUCESSO!");
            Console.WriteLine();
            Console.WriteLine("TROCA DE SENHA OBRIGATORIA!\nINFORME A NOVA SENHA:");
            senhaPadrao = Console.ReadLine();
            Console.WriteLine("SENHA GRAVADA COM SUCESSO!!!");
            Console.WriteLine("[APERTE ENTER PARA CONTINUAR...]");
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

} else {
    Console.WriteLine("PROGRAMA ENCERRADO.");
}