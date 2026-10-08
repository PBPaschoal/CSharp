using SistemaVotacao.Menu;


Console.WriteLine("********************");
Console.WriteLine(" SISTEMA DE VOTAÇÃO ");
Console.WriteLine("********************\n");

int opcao = 0;
string senhaPadrao = "votos2026";

Candidatos perfil = new Candidatos();
Menu menu = new Menu();
Senha senha = new Senha();

Console.WriteLine("[1] - CADASTRAR CANDIDATOS");
Console.WriteLine("[2] - SAIR");
opcao = int.Parse(Console.ReadLine());
if(opcao == 1) {
    senha.NovaSenha("votos2026");
    perfil.CadastroPerfil();
    perfil.ExibirPerfil();
    menu.OpcoesDeMenu();
} else {
    Console.WriteLine("PROGRAMA ENCERRADO.");
}