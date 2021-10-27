using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Skaicius programaIvesti = new Skaicius();
            List<double> teigiamuSkaiciuSarasas = programaIvesti.IvedimasTTwo();

            Skaicius programaPatikrinaArTeigiamiSkaiciai = new Skaicius();
            programaPatikrinaArTeigiamiSkaiciai.PatikrintiArTeigiamiSkaiciai(teigiamuSkaiciuSarasas);

            Skaicius sumosVeiksmas = new Skaicius();
            double suma = sumosVeiksmas.SudetiSkaicius(teigiamuSkaiciuSarasas);

            Skaicius atimtiesVeiksmas = new Skaicius();
            double atimtis = atimtiesVeiksmas.AtimtiSkaicius(teigiamuSkaiciuSarasas);

            Skaicius sandaugosVeiksmas = new Skaicius();
            double sandauga = sandaugosVeiksmas.SudaugintiSkaicius(teigiamuSkaiciuSarasas);

            Skaicius dalybosVeiksmas = new Skaicius();
            double dalyba = dalybosVeiksmas.DalinaSkaicius(teigiamuSkaiciuSarasas);


            Console.WriteLine($"Įvestų skaičių suma: {suma}.\n" +
                $"--------------------------------------------------------------------------------------");
            Console.WriteLine($"Įvestų skaičių skirtumas: {atimtis}.\n" +
                $"--------------------------------------------------------------------------------------");
            Console.WriteLine($"Įvestų skaičių sandauga: {sandauga}.\n" +
                $"--------------------------------------------------------------------------------------");
            Console.WriteLine($"Įvestų skaičių dalyba: {dalyba:0.000000}.\n" +
                $"--------------------------------------------------------------------------------------");

            Console.ReadLine();

        }
    }
}
