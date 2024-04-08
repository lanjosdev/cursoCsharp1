using System;
using System.Globalization;


namespace ExeR03
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            byte idade1, idade2;
            double media;
            string[] arrayPessoa;


            Console.Write("Pessoa 1: ");
            arrayPessoa = Console.ReadLine().Split(' ');
            nome1 = arrayPessoa[0];
            idade1 = byte.Parse(arrayPessoa[1]);

            Console.Write("Pessoa 2: ");
            arrayPessoa = Console.ReadLine().Split(' ');
            nome2 = arrayPessoa[0];
            idade2 = byte.Parse(arrayPessoa[1]);


            media = (double)(idade1 + idade2) / 2; //casting double 
           

            Console.WriteLine("");
            Console.WriteLine("SAIDA:");
            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("f1", CultureInfo.InvariantCulture) + " anos.");
        }
    }
}