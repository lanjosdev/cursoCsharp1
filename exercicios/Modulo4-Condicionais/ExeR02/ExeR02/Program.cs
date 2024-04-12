using System;
using System.Globalization;


namespace ExeR02
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, baskara1, baskara2;
            string[] valores;


            Console.Write("Entre com os valores de a, b e c: ");
            valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);


            delta = (double)(Math.Pow(b, 2) - 4*a*c);
            

            //delta not - // a not 0
            if (delta < 0 || a == 0)
            {
                Console.WriteLine("Impossível calcular");
            }
            else
            {
                baskara1 = (double)((-b + Math.Sqrt(delta)) / (2 * a));
                baskara2 = (double)((-b - Math.Sqrt(delta)) / (2 * a));

                Console.WriteLine("R1 = " + baskara1.ToString("f5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + baskara2.ToString("f5", CultureInfo.InvariantCulture));
            }
        }
    }
}