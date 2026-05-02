namespace Alura.Filmes;

/* Uma forma de fazer:
 class Filme { 
    
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public string Elenco { get; set; }

    public Filme(string titulo, int duracao, string elenco) {
        this.Titulo = titulo;
        this.Duracao = duracao;
        this.Elenco = elenco;
    }

} */

class Filme {
    public List<Artista> Elenco { get; set; }
    public string Titulo { get; set; }
    public int Duracao { get; set; }

    public Filme(string titulo, int duracao, List<Artista> elenco) {
        if (elenco == null) {
            Elenco = new List<Artista>();
        }
        else {
            Elenco = elenco;
            foreach (var artista in Elenco) {
                artista.AdicionarFilme(this);
            }
        }

        Titulo = titulo;
        Duracao = duracao;
    }

    public void AdicionarElenco(Artista artista) {
        Elenco.Add(artista);
        if (!artista.FilmesAtuados.Contains(this)) {
            artista.AdicionarFilme(this);
        }
        Console.WriteLine($"{artista} adicionado/a ao elenco.");
    }

    public void ListarElenco() {
        if (Elenco.Count == 0) {
            Console.WriteLine("Elenco vazio.");
        }
        else {
            Console.WriteLine("Elenco... ");
            foreach (var artista in Elenco) {
                Console.WriteLine(artista.Nome);
            }
        }
    }
}

class Artista {
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Filme> FilmesAtuados { get; set; }
    public int QuantidadeDeFilmes => FilmesAtuados.Count;


    public Artista(string nome, int idade) {
        Nome = nome;
        Idade = idade;
        FilmesAtuados = new List<Filme>();
    }

    public void AdicionarFilme(Filme filme) {
        FilmesAtuados.Add(filme);
        if (!filme.Elenco.Contains(this)) filme.AdicionarElenco(this);
    }


    public void MostrarFilmesAtuados() {

        if (this.FilmesAtuados.Count == 0) {
            Console.WriteLine($"Nenhum filme encontrado na base para {this.Nome}");
            return;
        }

        Console.WriteLine($"Filmes de {this.Nome}...");
        foreach (var filme in FilmesAtuados) {
            Console.WriteLine($"Filme: {filme.Titulo}");
        }
    }
}
