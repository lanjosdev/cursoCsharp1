using System;


class Program
{
    static void Main(string[] args)
    {
        int N;

        Console.Write("Tabuada do numero: ");
        N = int.Parse(Console.ReadLine());


        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i + " x " + N + " = " + (i * N));
        }
    }
}
