Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

TestaArrayInt();


void TestaArrayInt()
{
    int[] idades = new int[5];

    idades[0] = 30;
    idades[1] = 19;
    idades[2] = 32;
    idades[3] = 12;
    idades[4] = 28;

    Console.WriteLine($"Tamanho do Array {idades.Length}");

    for(int i = 0; i< idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"indice [{i}] = {idades[i]}");
    }
}

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for(int i = 0; i< arrayDePalavras.Length; i++)
    {
        Console.WriteLine($"Digite {i+1} palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.WriteLine("Digite a palavea a ser encontrada: ");
    var busca = Console.ReadLine();
}