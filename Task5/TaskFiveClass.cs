using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class TaskFiveClass
    {
        private List<string> zodziuSarasas;
        private TaskFiveClass()
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

        public async void ExampleAsync()
        {
            using StreamWriter failas = new("WriteLines2.txt");
            foreach (string zodis in zodziuSarasas)
            {
                if (!zodis.Contains("Second"))
                {
                    await failas.WriteLineAsync(zodis);
                }
            }
        }
    }
}
