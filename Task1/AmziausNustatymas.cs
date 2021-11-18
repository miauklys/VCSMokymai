using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class AmziausNustatymas
    {
        // metodas, kuris nuskaito įvestą amžių:

        public int amziausNuskaitymas()
        {
            Console.WriteLine("Įveskite amžių:");
            int amzius = Convert.ToInt32(Console.ReadLine());

            return amzius;
        }

        // metodas, kuris įvertina galimybes pagal įvestą amžių:
        public Galimybes amziausIvertinimas(int amzius)
        {
            if (amzius < 18)
            {
                return Galimybes.nieko;
            }

            if (amzius >= 18 && amzius < 20)
            {
                return Galimybes.vairuoti;
            }

            else
            {
                return Galimybes.vairuotiIrGerti;
            }
        }

        public void RezultatoIsvedimas(Galimybes arGaliVairuoti)
        {
            switch (arGaliVairuoti)
            {
                case Galimybes.nieko:
                    Console.WriteLine("Negali nei vairuoti, nei gerti.");
                    break;
                case Galimybes.vairuoti:
                    Console.WriteLine("Gali tik vairuoti.");
                    break;
                case Galimybes.vairuotiIrGerti:
                    Console.WriteLine("Gali ir gerti, ir vairuoti.");
                    break;
            }
        }
    }
}
