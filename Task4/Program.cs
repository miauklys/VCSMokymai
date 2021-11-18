using System;
using System.Collections.Generic;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskFourClass programaIvesti = new TaskFourClass();
            List<string> ivestasTekstas = programaIvesti.IvestiTeksta();

            TaskFourClass programaIsvesti = new TaskFourClass();
            programaIsvesti.isvestiZodzius(ivestasTekstas);

            Console.ReadLine();
        }
    }
}
