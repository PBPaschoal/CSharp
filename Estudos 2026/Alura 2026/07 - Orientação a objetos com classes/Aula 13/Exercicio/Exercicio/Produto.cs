class Produto { 
    public string Nome { get; set; }
    private int quantidadeEstoque { get; set; }

    public Produto(string nome, int quantidadeInicial) {
        this.Nome = nome;
        this.quantidadeEstoque = quantidadeInicial;
    }

    public void Retirar(int quantidade) {
        if (quantidade <= quantidadeEstoque) {
            quantidadeEstoque -= quantidade;
            Console.WriteLine($"Retirada de {quantidade} unidade(s) realizada com sucesso.");
        } else {
            Console.WriteLine($"Erro: Estoque insuficiente para retirada de {quantidade} unidade(s).");
        }
    }

    public void ExibirEstoque() {
        Console.WriteLine($"Produto: {Nome}");
        Console.WriteLine($"Estoque: {quantidadeEstoque}");
    }
}