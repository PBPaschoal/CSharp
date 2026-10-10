using System.Linq;
namespace SistemaVotacao.Menu;

public class Votos {
    public int VotoValidos {get; set;}
    public int VotosEmBranco {get; set;}
    public int VotosNulos {get; set;}
    public int Opcao {get; set;}
    public int primeiroCandidato = 0; 
    public int segundoCandidato = 0;
    public int terceiroCandidato = 0;

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
        for(int i = 1; i <= 10; i++) {
            Console.WriteLine("> ESCOLHA UM(A) CANDIDATO(A) ");
            Console.WriteLine(":::::::::::::::::::::::::::::");
            candidatos.ExibirPerfil();
            Console.Write("\nDIGITE O NÚMERO DO(A) CANDIDATO(A): ");
            Opcao = int.Parse(Console.ReadLine());
            var valores = Candidatos.cadastro.Values.ToArray();
            var nomes = Candidatos.cadastro.Keys.ToArray();
            int numeroDoCadastro1 = valores[0].Numero;
            int numeroDoCadastro2 = valores[1].Numero;
            int numeroDoCadastro3 = valores[2].Numero;
            string nomeCandidato1 = nomes[0];
            string nomeCandidato2 = nomes[1];
            string nomeCandidato3 = nomes[2];
            if(Opcao == numeroDoCadastro1) {
                Console.WriteLine($"1 VOTO SALVO PARA {nomeCandidato1}");
                primeiroCandidato++;
            } else if(Opcao == numeroDoCadastro2) {
                Console.WriteLine($"1 VOTO SALVO PARA {nomeCandidato2}");
                segundoCandidato++;
            } else if(Opcao == numeroDoCadastro3) {
                Console.WriteLine($"1 VOTO SALVO PARA {nomeCandidato3}");
                terceiroCandidato++;
            } else {
                Console.WriteLine($"{Opcao} NÃO PERTENCE A NENHUM(A) CANDIDATO(A).");
            }
            if(i < 10) {
                Console.WriteLine(":::::::::::::");
                Console.WriteLine($"{i}/10: PROXIMO VOTO!");
                Console.WriteLine(":::::::::::::\n");
            } else {
                Console.WriteLine(":::::::::::::::::::::::::::::::::::");
                Console.WriteLine(":::::::: VOTAÇÃO ENCERRADA ::::::::");
                Console.WriteLine(":::::::::::::::::::::::::::::::::::");
                Console.WriteLine("CALCULANDO VOTOS...");
                CalcularTotalVotos();
            }
        }
    }

    public void CalcularTotalVotos() {
        string vencedor = ">>>>>>>>> VENCEDOR(A)! <<<<<<<<<";
        string empate = "OS(AS) CANDIDATOS(AS)";
        string desempate = "\nNOVA VOTAÇÃO PARA DESEMPATE!\n";
        var nomes = Candidatos.cadastro.Keys.ToArray();
        var valores = Candidatos.cadastro.Values.ToArray();
        string nomeCandidato1 = nomes[0];
        string nomeCandidato2 = nomes[1];
        string nomeCandidato3 = nomes[2];
        int numeroDoCadastro1 = valores[0].Numero;
        int numeroDoCadastro2 = valores[1].Numero;
        int numeroDoCadastro3 = valores[2].Numero;
        if(primeiroCandidato > segundoCandidato && primeiroCandidato > terceiroCandidato) {
            Console.WriteLine($">>>>>>>>> CANDIDATO(A) {nomeCandidato1} RECEBEU {primeiroCandidato} VOTOS!");
            Console.WriteLine(vencedor);
        } else if (segundoCandidato > primeiroCandidato && segundoCandidato > terceiroCandidato) {
            Console.WriteLine($">>>>>>>>> CANDIDATO(A) {nomeCandidato2} RECEBEU {segundoCandidato} VOTOS!");
            Console.WriteLine(vencedor);
        } else if (terceiroCandidato > primeiroCandidato && terceiroCandidato > segundoCandidato) {
            Console.WriteLine($">>>>>>>>> CANDIDATO(A) {nomeCandidato3} RECEBEU {terceiroCandidato} VOTOS!");
            Console.WriteLine(vencedor);
        } else {
            Console.WriteLine("TEMOS UM EMPATE!!!");
            if(primeiroCandidato == segundoCandidato && primeiroCandidato > terceiroCandidato) {
                Console.WriteLine($"{empate + " " + nomeCandidato1 + " E " + nomeCandidato2} RECEBERAM {primeiroCandidato} VOTOS CADA UM!");
                Console.WriteLine(desempate);
                VotacaoDesempate(numeroDoCadastro1, nomeCandidato1, numeroDoCadastro2, nomeCandidato2);
            } else if (segundoCandidato == terceiroCandidato && segundoCandidato > primeiroCandidato) {
                Console.WriteLine($"{empate + " " +nomeCandidato2 + " E " + nomeCandidato3} RECEBERAM {segundoCandidato} VOTOS CADA UM!");
                Console.WriteLine(desempate);
                VotacaoDesempate(numeroDoCadastro2, nomeCandidato2, numeroDoCadastro3, nomeCandidato3);
            } else if (primeiroCandidato == terceiroCandidato && primeiroCandidato > segundoCandidato) {
                Console.WriteLine($"{empate + " " +nomeCandidato1 + " E " + nomeCandidato3} RECEBERAM {terceiroCandidato} VOTOS CADA UM!");
                Console.WriteLine(desempate);
                VotacaoDesempate(numeroDoCadastro1, nomeCandidato1, numeroDoCadastro3, nomeCandidato3);
            } else {
                Console.WriteLine("ERRO?");
            }
        }
    }

    public void VotacaoDesempate(int numeroCandA, string nomeCandA, int numeroCandB, string nomeCandB) {
        var nomes = Candidatos.cadastro.Keys.ToArray();
        var valores = Candidatos.cadastro.Values.ToArray();
        string nomeCandidato1 = nomes[0];
        string nomeCandidato2 = nomes[1];
        string nomeCandidato3 = nomes[2];
        int numeroDoCadastro1 = valores[0].Numero;
        int numeroDoCadastro2 = valores[1].Numero;
        int numeroDoCadastro3 = valores[2].Numero;
        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::");
        Console.Write("\nPARA DESEMPATE: DIGITE O NÚMERO DO(A) CANDIDATO(A): ");
        Opcao = int.Parse(Console.ReadLine());
        for(int i = 1; i <= 11; i++) {
            if(Opcao == numeroDoCadastro1) {
                Console.WriteLine($"1 VOTO SALVO PARA {nomeCandidato1}");
                primeiroCandidato++;
            } else if(Opcao == numeroDoCadastro2) {
                Console.WriteLine($"1 VOTO SALVO PARA {nomeCandidato2}");
                segundoCandidato++;
            } else if(Opcao == numeroDoCadastro3) {
                Console.WriteLine($"1 VOTO SALVO PARA {nomeCandidato3}");
                terceiroCandidato++;
            } else {
                Console.WriteLine($"{Opcao} NÃO PERTENCE A NENHUM(A) CANDIDATO(A).");
            }
            if(i < 11) {
                Console.WriteLine(":::::::::::::");
                Console.WriteLine($"{i}/11: PROXIMO VOTO!");
                Console.WriteLine(":::::::::::::\n");
            } else {
                Console.WriteLine(":::::::::::::::::::::::::::::::::::");
                Console.WriteLine(":::::::: VOTAÇÃO ENCERRADA ::::::::");
                Console.WriteLine(":::::::::::::::::::::::::::::::::::");
                Console.WriteLine("CALCULANDO VOTOS...");
                CalcularTotalVotos();
            }
        }
    }
}