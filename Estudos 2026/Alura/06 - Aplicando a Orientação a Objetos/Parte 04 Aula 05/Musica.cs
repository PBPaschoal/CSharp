class Musica {

    public Musica(Banda artista, string nome) {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }
    //public string DescricaoResumida { get {return $"A música {Nome} pertence à banda {Artista}";} }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFichaTecnica() {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if(Disponivel) {
            Console.WriteLine("Disponível no plano.");
        } else {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}