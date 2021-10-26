using System;
using System.Collections.Generic;
using System.IO;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string ivestiKazkokieDuomenys = DuomenuIvedimas();
            IrasytiDuomenis(ivestiKazkokieDuomenys);

            Console.ReadLine();        
        }

        public static string DuomenuIvedimas()
        {
            Console.WriteLine("Įveskite duomenis:");
            string duom = Console.ReadLine();
            return duom;
        }

        public static void IrasytiDuomenis(string duomenys)
        {
            string vieta = "C:/test/duomenuFailas.txt";
            DirectoryInfo direktorija = Directory.GetParent(vieta);               
            
            if (direktorija.Exists == true)
            {
                File.WriteAllText(vieta, duomenys);
            }
                else
            {
                Console.WriteLine("Įvyko klaida, vieta neegzistuoja.");
            }
        }
    }
}
