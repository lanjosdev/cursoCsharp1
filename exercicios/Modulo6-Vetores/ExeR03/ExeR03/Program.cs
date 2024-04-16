using System;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        int N;
        double[] alturas;
        int[] idades;


        N = int.Parse(Console.ReadLine());
        alturas = new double[N]; 
        idades = new int[N];

        for (int i = 0; i < N; i++)
        {
            string[] temps = Console.ReadLine().Split(' ');
            alturas[i] = double.Parse(temps[2], CultureInfo.InvariantCulture);
            idades[i] = int.Parse(temps[1]);   
        }


        double mediaAltura, somaAltura = 0, menos16, count = 0;
        for (int i = 0; i < N; i++)
        {
            somaAltura += alturas[i];

            if (idades[i] < 16)
            {
                count++;
            }
        }

        mediaAltura = somaAltura / N;
        menos16 = (double) count / N;


        Console.WriteLine("Altura média: " + mediaAltura.ToString("f2", CultureInfo.InvariantCulture));
        Console.WriteLine("Pessoas com menos de 16 anos: " + (menos16*100).ToString("f1", CultureInfo.InvariantCulture) + "%");
    }
}
