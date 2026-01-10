Musica musica1 = new Musica();
musica1.nome = "Roxane";
musica1.artista = "The Police";
musica1.duracao = 273;
musica1.EscreveDisponivel(true);
Console.WriteLine(musica1.LeDisponivel());

Musica musica2 = new Musica();
musica2.nome = "Vertigo";
musica2.artista = "U2";
musica2.duracao = 367;
musica2.EscreveDisponivel(false);
Console.WriteLine(musica2.LeDisponivel());

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();