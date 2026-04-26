class Titular
{
    public string Nome {get; set;}
    public string Cpf {get; set;}
    public string Endereco {get; set;}

    public Titular(string nome, string cpf, string endereco) {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }
}
