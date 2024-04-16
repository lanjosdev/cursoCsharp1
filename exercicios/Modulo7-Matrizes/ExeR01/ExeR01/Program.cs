using System;

class Program
{
    static void Main(string[] args)
    {
        int N;
        int[,] matriz;

        N = int.Parse(Console.ReadLine());
        matriz = new int[N,N];

        // Leitura/Atribuição:
        for (int i = 0; i < N; i++)
        {
            string[] temp = Console.ReadLine().Split(' ');
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = int.Parse(temp[j]);
            }
        }


        // Pegar diagonal:
        Console.WriteLine();
        Console.Write("DIAGONAL PRINCIPAL: ");
        for (int i = 0;i < N; i++)
        {
            Console.Write(matriz[i,i] + " ");
        }
        Console.WriteLine();

        // Pega negativos:
        int negativos = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matriz[i,j] < 0) { 
                    negativos++;
                }
            }
        }


        // Resul:
        Console.WriteLine("QUANTIDADE DE NEGATIVOS: " + negativos);
    }
}
