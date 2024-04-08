using System;
using System.Globalization;


namespace ExeR02
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseR, alturaR, area, perimetro, diagonal;


            Console.Write("Base: ");
            baseR = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            alturaR = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            area = baseR * alturaR;
            perimetro = 2*baseR + 2*alturaR;
            diagonal = Math.Sqrt(Math.Pow(baseR, 2) + Math.Pow(alturaR, 2));

            Console.WriteLine("");
            Console.WriteLine("SAIDA:");
            Console.WriteLine("AREA = " + area.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("f4", CultureInfo.InvariantCulture));
        }
    }
}