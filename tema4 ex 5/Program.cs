using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul");
            int n = int.Parse(Console.ReadLine());
            int sum = SumaNumerelor(n);
            Console.WriteLine($"Suma numerelor de la 1 la {n} este: {sum}");
        }

        static int SumaNumerelor(int n)
        {
            if (n == 1)
                return 1;
            else
                return n + SumaNumerelor(n - 1);
        }
    }
}
//Scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n, apelati - o si afisati-i rezultatul.
