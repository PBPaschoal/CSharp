using System.Security.Cryptography;
using System.Globalization;

class ProdutoDigital { 

    public string Nome { get; set; }
    public double Preco { get; set; }
    public InformacaoTecnica InfoTecnica { get; set; }

    public ProdutoDigital(string nome, double preco, InformacaoTecnica infoTec) {
        this.Nome = nome;
        this.Preco = preco;
        this.InfoTecnica = infoTec;
    }

    public void ExibirDetalhes() {
        Console.WriteLine($"Produto: {Nome}");
        Console.WriteLine($"Preço: R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Tamanho: {InfoTecnica.TamanhoMB}MB");
        Console.WriteLine($"Compatível com: {InfoTecnica.SistemaOperacional}");
    }
}