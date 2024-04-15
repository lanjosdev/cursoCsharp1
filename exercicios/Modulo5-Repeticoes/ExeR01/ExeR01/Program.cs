using System;

namespace ExeR01
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;

            string[] arr = Console.ReadLine().Split(' ');
            X = int.Parse(arr[0]);
            Y = int.Parse(arr[1]);


            while (X != Y)
            {
                if(X > Y)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }

                arr = Console.ReadLine().Split(' ');
                X = int.Parse(arr[0]);
                Y = int.Parse(arr[1]);
            }

            Console.WriteLine("FIM");
        }
    }
}