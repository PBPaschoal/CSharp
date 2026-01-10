class Musica {
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;
    public void ExibirFichaTecnica() {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel) {
            Console.WriteLine("Disponível no plano.");
        } else {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}