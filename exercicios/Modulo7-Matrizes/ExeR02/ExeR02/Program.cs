using System;

class Program
{
    static void Main(string[] args)
    {
        int L, N;
        int[,] matriz;
        int[] arraySomas;


        // INICIO:
        string[] temp = Console.ReadLine().Split(' ');
        L = int.Parse(temp[0]);
        N = int.Parse(temp[1]);
        matriz = new int[L, N];

        // Leitura/Atribuição na matriz:
        for (int i = 0; i < L; i++)
        {
            temp = Console.ReadLine().Split(' ');
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = int.Parse(temp[j]);
            }
        }


        // PROCESSAMENTO:
        // Criar array com soma de cada linha da matriz:
        arraySomas = new int[L];
        int soma;
        for (int i = 0; i < L; i++)
        {
            soma = 0;
            for (int j = 0; j < N; j++)
            {
                soma += matriz[i, j];
            }
            arraySomas[i] = soma;
        }


        // SAIDA:
        Console.WriteLine();

        foreach (int elemento in arraySomas)
        {
            Console.WriteLine(elemento);
        }
    }
}
