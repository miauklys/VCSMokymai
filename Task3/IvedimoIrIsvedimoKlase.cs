using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class IvedimoIrIsvedimoKlase
    {
        public List<int> IvestiSkaicius() //tipas turi buti List
        {
            List<int> skaiciusSarasas = new List<int>();
            Console.WriteLine("Įveskite skaičių:");
            int ivestasSkaicius = Convert.ToInt32(Console.ReadLine());

            if (ivestasSkaicius != 0)
            {
                skaiciusSarasas.Add(ivestasSkaicius);
                Console.WriteLine("Įveskite skaičių:");
                ivestasSkaicius = Convert.ToInt32(Console.ReadLine());
                skaiciusSarasas.Add(ivestasSkaicius);

                while (ivestasSkaicius != 0)
                {
                    Console.WriteLine("Įveskite skaičių:");
                    ivestasSkaicius = Convert.ToInt32(Console.ReadLine());
                    skaiciusSarasas.Add(ivestasSkaicius);
                }
            }
            return skaiciusSarasas;
        }

        public void AtspausdintiSkaicius(List<int> sarasas)
        {
            foreach (int skaiciusSarase in sarasas)
            {
                Console.Write(skaiciusSarase);
            }
        }
    }
}
