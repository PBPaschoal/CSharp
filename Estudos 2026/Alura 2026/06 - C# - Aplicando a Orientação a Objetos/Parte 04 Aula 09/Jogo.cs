
class Jogo {
    public string Nome { get; set; }
    public string Genero { get; set; }
    public int AnoLancamento { get; set; }

    public Jogo(string nome, string genero, int anoLancamento) {
        Nome = nome;
        Genero = genero;
        AnoLancamento = anoLancamento;
    }
}

class CatalogoJogos {
    private List<Jogo> Jogos { get; set; }

    // Propriedade que retorna se o catálogo está vazio
    public bool CatalogoVazio => Jogos.Count == 0;

    // Construtor para inicializar o catálogo de jogos vazio
    public CatalogoJogos() {
        Jogos = new List<Jogo>();
    }

    // Método para adicionar um jogo ao catálogo
    public void AdicionarJogo(string nome, string genero, int anoLancamento) {
        Jogo novoJogo = new Jogo(nome, genero, anoLancamento);
        Jogos.Add(novoJogo);
        Console.WriteLine($"Jogo \"{nome}\" adicionado ao catálogo.");
    }

    // Método para listar todos os jogos no catálogo
    public void ListarJogos() {
        if (CatalogoVazio) {
            Console.WriteLine("O catálogo de jogos está vazio.");
        } else {
            Console.WriteLine("Catálogo de Jogos:");
            foreach (var jogo in Jogos) {
                Console.WriteLine($"Nome: {jogo.Nome}, Gênero: {jogo.Genero}, Ano de Lançamento: {jogo.AnoLancamento}");
            }
        }
    }
}
