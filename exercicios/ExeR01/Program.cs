using System;
using System.Globalization;


namespace ExeR01
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, valorMetro, area, precoTotal;

            Console.WriteLine("Largura:");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Comprimento:");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor do metro:");
            valorMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            precoTotal = area * valorMetro;

            Console.WriteLine("");
            Console.WriteLine("SAIDA:");
            Console.WriteLine("AREA = " + area.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("PREÇO = " + precoTotal.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}