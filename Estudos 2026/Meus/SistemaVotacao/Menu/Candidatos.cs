namespace SistemaVotacao.Menu;

public class Candidatos {
     public string Nome {get; set;}
    public string Partido {get; set;}
    public int Numero {get; set;}

    public Candidatos() {
        this.Nome = Nome;
        this.Partido = Partido;
        this.Numero = Numero;
    }

    public static Dictionary<string, (string Partido, int Numero)> cadastro = new Dictionary<string, (string, int)>();

    public void CadastroPerfil() {
        for(int i = 1; i <= 3; i++) {
            Console.WriteLine("******************************");
            Console.WriteLine($"DADOS DO(A) {i}º CANDIDATO(A):");
            Console.WriteLine("******************************\n");
            Console.Write("INFORME O NOME: ");
            Nome = Console.ReadLine();
            Console.Write("INFORME O PARTIDO: ");
            Partido = Console.ReadLine();
            Console.Write("INFORME O NÚMERO: ");
            Numero = int.Parse(Console.ReadLine());
            cadastro.Add(Nome, (Partido, Numero));
            Console.WriteLine("\n:::::: CANDIDATO(A) CADASTRADO COM SUCESSO ::::::");
            Console.WriteLine("\n[ APERTE ENTER PARA CONTINUAR ]");
            Console.ReadLine();
            Console.Clear();
        }
    }

    public void ExibirPerfil() {
        Console.WriteLine("EXIBINDO CANDIDATOS:\n");
        foreach (var perfil in cadastro) {
            Console.WriteLine($"NOME DO(A) CANDIDATO(A): {perfil.Key}\nPARTIDO DO(A) CANDIDATO(A): {perfil.Value.Partido}\nNÚMERO: {perfil.Value.Numero}\n");
        }
        Console.WriteLine("\n[ APERTE ENTER PARA CONTINUAR ]");
        Console.ReadLine();
        Console.Clear();
    }
}