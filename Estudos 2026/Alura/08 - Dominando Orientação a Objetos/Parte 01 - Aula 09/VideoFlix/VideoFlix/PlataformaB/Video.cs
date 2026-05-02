namespace VideoFlix.PlataformaB;

using System.Globalization;

class Video {
    public string NomeStreamingB { get; set; }
    public double ValorStreamingB { get; set; }

    public Video(string nomeStreamingB, double valorStreamingB) { 
        this.NomeStreamingB = nomeStreamingB;
        this.ValorStreamingB = valorStreamingB;
    }

    public void ExibirB() {
        Console.WriteLine($"{NomeStreamingB} por apenas R$ {ValorStreamingB.ToString("F2", CultureInfo.InvariantCulture)} mensal!");
    }
}