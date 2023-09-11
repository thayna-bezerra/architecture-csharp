namespace ScreenSound.Modelos;

internal class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; } //deixa explicito que esta variavel tem operação de leitura/escrita
    public Genero Genero { get; set; }


    public string DescricaoResumida => //so modo leitura
        $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");

        if (Disponivel)
            Console.WriteLine("Disponível no Plano");
        else
            Console.WriteLine("Adquira o panlo Plus+");
    }
}