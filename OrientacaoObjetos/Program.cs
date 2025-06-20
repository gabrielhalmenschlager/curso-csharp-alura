
Musica musica1 = new Musica
{
    Nome = "Bohemian Rhapsody",
    Artista = "Queen",
    Duracao = 354,
    Disponivel = true
};
Console.WriteLine(musica1.Disponivel);

Musica musica2 = new Musica
{
    Nome = "Vertigo",
    Artista = "U2",
    Duracao = 278,
    Disponivel = false
};
Console.WriteLine(musica2.Disponivel);

musica1.ExibirFichaTecnia();
musica2.ExibirFichaTecnia();