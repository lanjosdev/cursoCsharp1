using System;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        int N;
        double[] arr;
        double soma, media;
        /*string texto;*/

        N = int.Parse(Console.ReadLine());
        arr = new double[N];

        string[] arrTemp = Console.ReadLine().Split(' ');
        for (int i = 0; i < N; i++)
        {
            arr[i] = double.Parse(arrTemp[i], CultureInfo.InvariantCulture);
        }


        /*texto = "";*/
        soma = 0;
        for (int i = 0; i < N; i++)
        {
            soma += arr[i];
            Console.Write(arr[i].ToString("f1", CultureInfo.InvariantCulture) + " ");
        }
        Console.WriteLine();

        media = soma / N;


        /*Console.WriteLine(texto);*/
        Console.WriteLine(soma.ToString("f2", CultureInfo.InvariantCulture));
        Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));
    }
}
