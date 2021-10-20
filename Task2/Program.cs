using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Skaicius> teigiamuSkaiciuSarasass = new List<Skaicius>();
            Skaicius sumosVeiksmas = new Skaicius();

            int suma = sumosVeiksmas.Suma(teigiamuSkaiciuSarasass);

            Console.WriteLine($"{suma}");
            Console.ReadLine();

        }
    }
}
