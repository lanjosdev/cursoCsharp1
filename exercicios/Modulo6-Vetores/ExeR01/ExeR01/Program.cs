using System;


class Program
{
    static void Main(string[] args)
    {
        int N;
        int[] array;

        N = int.Parse(Console.ReadLine());
        array = new int[N];

        string[] array2 = Console.ReadLine().Split(' ');
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(array2[i]);
        }

        for (int i = 0; i < N; i++) {
            if (array[i] < 0)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
