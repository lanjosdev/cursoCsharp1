using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;

            string[] arr = Console.ReadLine().Split(' ');
            A = int.Parse(arr[0]);
            B = int.Parse(arr[1]);
            C = int.Parse(arr[2]);
            D = int.Parse(arr[3]);


            if(B > C && D > A && C+D > A+B && (C > 0 && D > 0) && A % 2 == 0)
            {
                Console.WriteLine("Valores nao aceitos");
            }
            else
            {
                Console.WriteLine("Valores aceitos");
            }
        }
    }
}