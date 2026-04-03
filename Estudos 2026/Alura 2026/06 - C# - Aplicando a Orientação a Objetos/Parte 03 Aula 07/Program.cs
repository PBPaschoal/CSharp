/* Musica musica1 = new Musica();
musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);

Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.Disponivel = false;
Console.WriteLine(musica2.DescricaoResumida);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica(); */

Album albumDoMaroon5 = new Album();
albumDoMaroon5.Nome = "Songs About Jane (2002)";

Musica musica1 = new Musica();
musica1.Nome = "She Will Be Loved";
musica1.Artista = "Maroon 5";
musica1.Duracao = 273;

Musica musica2 = new Musica();
musica2.Nome = "This Love";
musica2.Artista = "Maroon 5";
musica2.Duracao = 206;

albumDoMaroon5.AdicionarMusica(musica1);
albumDoMaroon5.AdicionarMusica(musica2);

albumDoMaroon5.ExibirMusicasDoAlbum();

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();