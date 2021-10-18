using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Skaicius
    {
        
        public void ivestis()      
        {
           List<int> sarasas = new List<int>();
           for (int i = 0; i < 4; i++)
           {
                Console.WriteLine("Įveskite keturis teigiamus skaičius:");
                string ivestis = Console.ReadLine();
                int sk = Convert.ToInt32(ivestis);
                sarasas.Add(sk);
           }            
        }

        public bool SarTeig(List<int> sar) 
        {
            
            bool rezultas = false;
            // 1, 2, -1, 5
            if (sar == null || sar.Count == 0)
            {
                rezultas = false;
            }

            foreach (var sk in sar)
            {
                // 1 - nieko nereturninis ir pasibaigs - nieko nedaro;
                // 2 - -||-;
                // -1 - rezultatui priskirs false reikšmę;
                // 5 - nieko nereturninis ir pasibaigs - nieko nedaro;
                if (sk <= 0)
                {
                    rezultas = false;
                }
            }
            // rezultatas - false
            return rezultas; // retrun grąžinama false rezultatą;                             
        
        } 
        
        public int suma(int suma)
        {
            ivestis();
            List<int> sar = new List<int>();
            int sum = 0;
            foreach (int elementas in sar)
            {
                sum += elementas;
            }
            return suma;
        }
    }
}
