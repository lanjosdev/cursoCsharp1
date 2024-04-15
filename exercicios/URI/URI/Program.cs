using System;
using System.Globalization;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal, newSal, reajuste, percentual;

            Console.Write("Entre com seu salario: ");
            sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if(sal <= 400.00)
            {
                percentual = 15.0;
            }
            else if(sal <= 800.00)
            {
                percentual = 12.0;
            }
            else if (sal <= 1200.00)
            {
                percentual = 10.0;
            }
            else if(sal <= 2000.00)
            {
                percentual = 7.0;
            }
            else
            {
                percentual = 4.0;
            }

            newSal = sal * (1.0 + percentual/100);
            reajuste = newSal - sal;


            Console.WriteLine("Novo salario: " + newSal.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual + " %");
        }
    }
}