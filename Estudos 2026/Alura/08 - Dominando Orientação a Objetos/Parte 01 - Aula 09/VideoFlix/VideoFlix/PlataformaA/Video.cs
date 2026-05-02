namespace VideoFlix.PlataformaA;

using System.Globalization;

class Video { 
    public string NomeStreamingA { get; set; }
    public double ValorStreamingA { get; set; }

    public Video(string nomeStreamingA, double valorStreamingA) {
        this.NomeStreamingA = nomeStreamingA;
        this.ValorStreamingA = valorStreamingA;
    }

    public void ExibirA() {
        Console.WriteLine($"{NomeStreamingA} por apenas R$ {ValorStreamingA.ToString("F2", CultureInfo.InvariantCulture)} mensal!");
    }
}