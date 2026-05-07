using System;
using System.Collections.Generic;
using System.Text;

namespace MinhaLojaAfiliados;

internal class Produto {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Marca { get; set; }
    public string Descricao { get; set; }
    public string Plataforma { get; set; }

    public string Categoria { get; set; }
    public string Link { get; set; }
    public string ImagemUrl { get; set; }

    /*public Produto(int id, string nome, string marca, string descricao, string plataforma, string categoria, string link, string imagemurl) {
        this.Id = id;
        this.Nome = nome;
        this.Marca = marca;
        this.Descricao = descricao;
        this.Plataforma = plataforma;
        this.Categoria = categoria;
        this.Link = link;
        this.ImagemUrl = imagemurl;
    }*/

    public void Cadastrar() {
        string[] vetProduto = Console.ReadLine().Split(' ');
        Id = int.Parse(vetProduto[0]);
        Nome = vetProduto[1];
        Marca = vetProduto[2];
        Descricao = vetProduto[3];
        Plataforma = vetProduto[4];
        Categoria = vetProduto[5];
        Link = vetProduto[6];
        ImagemUrl = vetProduto[7];
        // Mas assim não é uma boa ideia, pois o produto pode ter nome composto, como a descrição precisa ser grande, então separados por Split, vai acabar dando erro com informações a mais.
    }

    public void Exibir() {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Descrição: {Descricao}");
        Console.WriteLine($"Plataforma Afiliado: {Plataforma}");
        Console.WriteLine($"Categoria do Produto: {Categoria}");
        Console.WriteLine($"Link para compra: {Link}");
        Console.WriteLine($"Imagem: {ImagemUrl}");
    }

}
