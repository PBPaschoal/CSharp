class Funcionario { 
    public string Nome { get; set; }
    public string Cargo { get; set; }

    public Funcionario(string nome, string cargo) {
        this.Nome = nome;
        this.Cargo = cargo;
    }

    public void Promover(string novoCargo) {
        if (novoCargo == Cargo) {
            Console.WriteLine("\nErro: O novo cargo deve ser diferente do cargo atual.");
        }
        else {
            Cargo = novoCargo;
            Console.WriteLine("\nPromoção realizada com sucesso!");
        }
    }
}