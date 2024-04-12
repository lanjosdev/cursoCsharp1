using System;
using System.Globalization;


namespace ExeR01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, notaFinal;


            Console.Write("Nota1: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota2: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            notaFinal = nota1 + nota2;


            Console.WriteLine("");
            Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("f1", CultureInfo.InvariantCulture));
            if (notaFinal < 60.0) 
            {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}