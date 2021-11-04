using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskTwoClass programaIvesti = new TaskTwoClass();
            List<double> teigiamuSkaiciuSarasas = programaIvesti.IvedimasTTwo();

            TaskTwoClass programaPatikrinaArTeigiamiSkaiciai = new TaskTwoClass();
            programaPatikrinaArTeigiamiSkaiciai.PatikrintiArTeigiamiSkaiciai(teigiamuSkaiciuSarasas);

            TaskTwoClass sumosVeiksmas = new TaskTwoClass();
            double suma = sumosVeiksmas.SudetiSkaicius(teigiamuSkaiciuSarasas);

            TaskTwoClass atimtiesVeiksmas = new TaskTwoClass();
            double atimtis = atimtiesVeiksmas.AtimtiSkaicius(teigiamuSkaiciuSarasas);

            TaskTwoClass sandaugosVeiksmas = new TaskTwoClass();
            double sandauga = sandaugosVeiksmas.SudaugintiSkaicius(teigiamuSkaiciuSarasas);

            TaskTwoClass dalybosVeiksmas = new TaskTwoClass();
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
