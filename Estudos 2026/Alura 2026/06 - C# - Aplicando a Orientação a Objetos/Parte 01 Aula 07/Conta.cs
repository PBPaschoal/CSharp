class Conta {
    public int idConta;
    public string nomeTitular;
    public double saldo;
    public int senha;

    public void ExibirDadosConta() {
        Console.WriteLine($"\nNúmero da Conta: {this.idConta}");
        Console.WriteLine($"Nome do titular: {this.nomeTitular}");
        Console.WriteLine($"Saldo da conta: {this.saldo.ToString("F2")}");
        Console.Write($"Deseja visualizar a senha (1 = SIM | 2 = NÃO)? ");
        int opcao = int.Parse(Console.ReadLine());
        if(opcao == 1) {
            Console.WriteLine($"A sua senha é: {this.senha}\n");
        } else {
            Console.WriteLine($"A senha não pode ser exibida: ****\n");
        }
    }
}