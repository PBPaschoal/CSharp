class ContaBancaria {

    public string NumeroConta { get; set; }
    public double Saldo { get; set; }

    public ContaBancaria(string numeroconta, double saldo) {
        this.NumeroConta = numeroconta;
        this.Saldo = saldo;
    }
    public void Depositar(double valor) {
        Saldo += valor;
    }
}