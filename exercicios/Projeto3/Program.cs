using System;

namespace Projeto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três palavras em sequencia: ");

            string[] arr = Console.ReadLine().Split(' ');
            string a = arr[0];
            string b = arr[1];
            string c = arr[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            
            Console.ReadLine(); 
        }
    }

}