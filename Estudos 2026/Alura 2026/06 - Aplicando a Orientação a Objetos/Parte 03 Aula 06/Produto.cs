class Produto
{
    private double preco;
    private int estoque;
    public string Nome {get; set;}
    public string Marca {get; set;}
    public double Preco {
        get => preco; 
        set
        {
            if(value > 0)
                preco = value;
            else
                preco = 10;
        }
    }
    
    public int Estoque {
        get => estoque; 
        set 
        {
            if(value > 0)
                estoque = value;
            else
                estoque = 0;

        }
    }

    public string Descricao => $"{this.Nome} {this.Marca} - {this.Preco} - Quantidade: {this.Estoque}";

}


class EstoqueDeProdutos
{
    private List<Produto> Produtos {get; set;} = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add((produto));
        Console.WriteLine($"Produto {produto.Nome} adicionado ao estoque");
    }

    public void ExibirProdutos()
    {
        if(Produtos.Count == 0)
        {
            Console.WriteLine("Estoque vazio. Nenhum produto disponível");
        }else
        {
            Console.WriteLine("Lista de produtos no estoque:");
            foreach(var produto in Produtos){
                Console.WriteLine(produto.Descricao);
            }
        }
    }
}