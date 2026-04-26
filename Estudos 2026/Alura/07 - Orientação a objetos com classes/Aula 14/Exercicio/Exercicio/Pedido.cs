class Pedido { 
    
    public string NumeroPedido { get; set; }
    public string NomeCliente { get; set; }
    public string Status { get; set; }

    public Pedido(string numeroPedido, string nomeCliente, string status) {
        this.NumeroPedido = numeroPedido;
        this.NomeCliente = nomeCliente;
        this.Status = status;
    }

    public void AtualizarStatus(string novoStatus) {
        Status = novoStatus;
    }

    public void ExibirPedido() {
        Console.WriteLine($"\nPedido nº: {NumeroPedido}");
        Console.WriteLine($"Cliente: {NomeCliente}");
        Console.WriteLine($"Status: {Status}");
    }
}