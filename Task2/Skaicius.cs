using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Skaicius
    {

        public List<double> IvedimasTTwo()
        {
            List<double> skaiciuSarasas = new List<double>();
            for (double i = 1; i < 5; i++)
            {
                Console.WriteLine($"Įveskite {i} teigiamą skaičių:");
                string ivestis = Console.ReadLine();
                double sveikassSkaicius = Convert.ToInt32(ivestis);

                skaiciuSarasas.Add(sveikassSkaicius);
            }
            return skaiciuSarasas;
        }

        public void PatikrintiArTeigiamiSkaiciai(List<double> sarasas)
        {
            foreach (double skaicius in sarasas)
            {
                if (skaicius < 0)
                {
                    Console.WriteLine($"\nĮvedėte neigiamą skaičių ({skaicius}).\n");
                }
            }
        }

        public double SudetiSkaicius(List<double> sarasas)
        {
            double sum = 0;
            foreach (double elementas in sarasas)
            {
                sum += elementas;
            }
            return sum;
        }

        public double AtimtiSkaicius(List<double> sarasas)
        {
            double skirtumas = 0;
            foreach (double elementas in sarasas)
            {
                skirtumas -= elementas;
            }
            return skirtumas;
        }

        public double SudaugintiSkaicius(List<double> sarasas)
        {
            double sandauga = 1;
            foreach (double elementas in sarasas)
            {
                sandauga *= elementas;
            }
            return sandauga;
        }

        public double DalinaSkaicius(List<double> sarasas)
        {
            double dalyba = 1;
            foreach (double elementas in sarasas)
            {
                dalyba /= elementas;
            }
            return dalyba;
        }
    }
}
