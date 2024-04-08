using System;
using System.Globalization;


namespace Exe01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nameFull = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            byte qtdQuarto = byte.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            string[] infos = Console.ReadLine().Split(' ');
            string lastName = infos[0];
            byte idade = byte.Parse(infos[1]);
            double height = double.Parse(infos[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nameFull);
            Console.WriteLine(qtdQuarto);
            Console.WriteLine(price.ToString("f2", CultureInfo.InvariantCulture));

            Console.WriteLine(lastName);
            Console.WriteLine(idade);
            Console.WriteLine(height.ToString("f2", CultureInfo.InvariantCulture));            
        }
    }

}