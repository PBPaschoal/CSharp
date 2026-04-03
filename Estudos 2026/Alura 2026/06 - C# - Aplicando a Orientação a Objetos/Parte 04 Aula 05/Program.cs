Album albumDoQueen = new Album("A night at the opera");
Album albumDoMaroon5 = new Album("Songs About Jane (2002)");

Banda queen = new Banda("Queen");
Banda maroon5 = new Banda("Maroon 5");

Musica musica0 = new Musica(queen, "A night at the opera") {
    Duracao = 304,
    Disponivel = true,
};

Musica musica1 = new Musica(maroon5, "She Will Be Loved") {
    Duracao = 273,
    Disponivel = true,
};

Musica musica2 = new Musica(maroon5, "This Love") {
    Duracao = 206,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica0);
albumDoMaroon5.AdicionarMusica(musica1);
albumDoMaroon5.AdicionarMusica(musica2);

albumDoMaroon5.ExibirMusicasDoAlbum();
maroon5.AdicionarAlbum(albumDoMaroon5);
maroon5.ExibirDiscografia();

albumDoQueen.ExibirMusicasDoAlbum();
queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();

musica0.ExibirFichaTecnica();
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();