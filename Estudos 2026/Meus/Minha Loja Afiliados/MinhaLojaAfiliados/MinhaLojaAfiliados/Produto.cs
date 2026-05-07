using System;
using System.Collections.Generic;
using System.Text;

namespace MinhaLojaAfiliados;

internal class Produto {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Descricao { get; set; }
    public string Plataforma { get; set; }

    public string Categoria { get; set; }
    public string Link { get; set; }
    public string ImagemUrl { get; set; }

    public Produto(int id, string nome, string marca, string modelo, string descricao, string plataforma, string categoria, string link, string imagemurl) {
        this.Id = id;
        this.Nome = nome;
        this.Marca = marca;
        this.Modelo = modelo;
        this.Descricao = descricao;
        this.Plataforma = plataforma;
        this.Categoria = categoria;
        this.Link = link;
        this.ImagemUrl = imagemurl;
    }

    public void Exibir() {
        Console.WriteLine($"ID do produto: {Id}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Descricao: {Descricao}");
        Console.WriteLine($"Plataforma: {Plataforma}");
        Console.WriteLine($"Categoria: {Categoria}");
        Console.WriteLine($"Link para compra: {Link}");
        Console.WriteLine($"Link da imagem do produto: {ImagemUrl}");
    }
}
