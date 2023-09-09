Banda linkinPark = new Banda("Linkin Park");

Album albumLinkinPark = new Album("Hybrid Theory");

Musica musica1 = new Musica(linkinPark, "In The End")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(linkinPark, "Crawling")
{
    Duracao = 415,
    Disponivel = false,
};

albumLinkinPark.AdicionarMusica(musica1);
albumLinkinPark.AdicionarMusica(musica2);
linkinPark.AdicionarAlbum(albumLinkinPark);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumLinkinPark.ExibirMusicasDoAlbum();
linkinPark.ExibirDiscografia();