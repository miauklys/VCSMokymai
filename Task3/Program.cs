using System;
using System.Collections.Generic;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IvedimoIrIsvedimoKlase ivedimoPrograma = new IvedimoIrIsvedimoKlase();
            List<int> sudarytasSarasas = ivedimoPrograma.IvestiSkaicius(); //įvesti duomenys išsaugojami sąraše

            IvedimoIrIsvedimoKlase isvedimoPrograma = new IvedimoIrIsvedimoKlase();
            isvedimoPrograma.AtspausdintiSkaicius(sudarytasSarasas);

            Console.ReadLine();
        }
    }
}
