Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");
Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(2, "Minhas gatas", 67);
ep2.AdicionarConvidados("Pandora");
ep2.AdicionarConvidados("Lolla");
Console.WriteLine(ep2.Resumo);

Episodio ep3 = new(3, "Meus gatos", 67);
ep3.AdicionarConvidados("Pepe Antonio");
ep3.AdicionarConvidados("Simon");
Console.WriteLine(ep3.Resumo);

Podcast podcast = new("Podecast especial", "Bruno");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);
podcast.ExibirDetalhes();