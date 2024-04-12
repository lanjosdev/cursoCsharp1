using System;
using System.Globalization;

namespace ExeR03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, menor;

            Console.Write("Entre com três números: ");
            string[] array = Console.ReadLine().Split(' ');
            num1 = int.Parse(array[0], CultureInfo.InvariantCulture);
            num2 = int.Parse(array[1], CultureInfo.InvariantCulture);
            num3 = int.Parse(array[2], CultureInfo.InvariantCulture);


            if(num1 < num2 && num1 < num3) {
                menor = num1;
            }
            else if(num2 < num3)
            {
                menor = num2;
            }
            else
            {
                menor = num3;
            }


            Console.WriteLine("MENOR = " + menor);

        }
    }
}