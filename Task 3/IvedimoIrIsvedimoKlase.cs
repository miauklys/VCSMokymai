using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class IvedimoIrIsvedimoKlase
    {
        private List<int> manoSarasas;
        public IvedimoIrIsvedimoKlase()
        {
            manoSarasas = new List<int>();
        }

        public void Ivedimas()
        { 
            //bool noriuTesti = true;

            while (noriuTesti)
            {
                Console.WriteLine("Įveskite skaičių:");
                int ivestis = Convert.ToInt32(Console.ReadLine());
                if (ivestis == 0)
                {
                    break;

                }

                manoSarasas.Add(ivestis);

                //noriuTesti = Console.ReadLine() != 0;
            }
        }

        public void Isvedimas()
        {
            
            foreach (var kintamasis in manoSarasas)
            {
                Console.Write($"{kintamasis}");
            }

            Console.ReadLine();
        }
    }
}
