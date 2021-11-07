using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class TaskFourClass
    {
        public List<string> IvestiTeksta()
        {
            List<string> tekstoSarasas = new List<string>();
            List<string> kitasTekstoSarasas = new List<string>();

            string ivestasZodis = "END";

            do
            {
                Console.WriteLine("Įveskite žodį (įrašius paskutinį žodį, įveskite END):");
                ivestasZodis = Console.ReadLine();
                tekstoSarasas.Add(ivestasZodis);

                if (!kitasTekstoSarasas.Contains(ivestasZodis))
                {
                    kitasTekstoSarasas.Add(ivestasZodis);
                }

                else
                {
                    Console.WriteLine("Šis žodis jau yra įvestas!");
                }
            }
            while (ivestasZodis != "END");

            if (kitasTekstoSarasas.Contains("END")) ;
            {
                kitasTekstoSarasas.Remove("END");
            }

            return kitasTekstoSarasas;
        }

        public void isvestiZodzius(List<string> sarasas)
        {
            foreach (string zodis in sarasas)
            {
                Console.WriteLine(zodis);
            }
        }
    }
}
