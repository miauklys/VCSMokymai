using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class SesUzdKlase
    {
        // pirmasis metodas patikrina, ar faile egzistuoja įrašas bei gražina "taip" arba "ne"

                
        public void Patikrinimas()
        {
            string failoVieta = @"C:\test\test.txt";

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(failoVieta).ToList();

            if (new FileInfo("file").Length == 0)
            {
                Console.WriteLine("Failas tuščias.");
            }
            else
            {
                Console.WriteLine("Failas netuščias.");
            }

        }

        // antrasis metodas įrašą įrašo į failą

        public void IrasymasIFaila()
        {
            string failoVieta = @"C:\test\test.txt";

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(failoVieta).ToList();
            if (new FileInfo("file").Length == 0)
            {
                lines.Add("Failas tuščias.");
            }
            else
            {
                lines.Add("Failas netuščias.");
            }
        }


        // nutikus klaida, klaida įrašoma į atskirą failą
    }
}
