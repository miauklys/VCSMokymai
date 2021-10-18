﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class AmziausNustatymas
    {
        public int nuskaitymas()
        {
            Console.WriteLine("Įveskite amžių:");
            int amzius = Convert.ToInt32(Console.ReadLine());
            return amzius;
        }

        public Galimybes amziausIvertinimas(int amzius)
        { 
            if (amzius < 18)
            {
                return Galimybes.nieko;
            }

            if (amzius >= 18 && amzius <= 20)
            {
                return Galimybes.vairuoti;
            }

            else
            {
                return Galimybes.vairuotiGerti;
            }
        }       
    }
}
