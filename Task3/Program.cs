using System;
using System.Collections.Generic;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskThreeClass ivedimoPrograma = new TaskThreeClass();
            List<int> sudarytasSarasas = ivedimoPrograma.IvestiSkaicius(); //įvesti duomenys išsaugojami sąraše

            TaskThreeClass isvedimoPrograma = new TaskThreeClass();
            isvedimoPrograma.AtspausdintiSkaicius(sudarytasSarasas);

            Console.ReadLine();
        }
    }
}
