using System;
using System.Globalization;


namespace ExeR04
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos, minutos, horas;



            Console.Write("Total de tempo (s): ");
            segundos = int.Parse(Console.ReadLine());



            horas = segundos / 3600;
            segundos %= 3600;
            minutos = segundos / 60;
            segundos %= 60;



            Console.WriteLine("");
            Console.WriteLine("SAIDA:");
            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}