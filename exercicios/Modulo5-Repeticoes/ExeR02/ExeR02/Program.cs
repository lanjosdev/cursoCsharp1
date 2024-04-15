using System;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        double idade, soma, media, cont;

        idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(idade < 0)
        {
            Console.WriteLine("impossivel calcular");
        }
        else
        {
            soma = 0;
            cont = 0;

            while(idade >= 0)
            {
                soma += idade;
                cont++;
                idade = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);
            }


            media = soma / cont;
            Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
