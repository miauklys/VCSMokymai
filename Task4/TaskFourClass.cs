using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class TaskFourClass
    {
        private List<string> zodziuSarasas;
        private TaskFourClass()
        {
            zodziuSarasas = new List<string>();

            bool noriuTesti = true;

            while (noriuTesti)
            {
                Console.WriteLine("Įveskite žodį:");
                string ivestis = Console.ReadLine();
                zodziuSarasas.Add(ivestis);

                noriuTesti = Console.ReadLine() == "taip";
            }
        }
    }
}
