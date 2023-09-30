Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

//TestaArrayInt();
//TestaBuscarPalavra();

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
        arrayDePalavras[i] = Console.ReadLine()!;
    }

    Console.WriteLine("Digite a palavea a ser encontrada: ");
    var busca = Console.ReadLine();
}

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

TestaMediana(amostra);

void TestaMediana (Array array)
{
    if((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio]:
        (numerosOrdenados[meio] + numerosOrdenados[meio - 1])/2;

    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}