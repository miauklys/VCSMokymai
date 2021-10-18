using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //    AmziausNustatymas nustatytasAmzius = new AmziausNustatymas();
            //    int amzius = nustatytasAmzius.nuskaitymas();

            //    Galimybes arGaliVairuoti = nustatytasAmzius.amziausIvertinimas(amzius);
            //    Console.WriteLine(arGaliVairuoti);

            //    Console.ReadLine();

            /// variantas su switch:
            /// 

        AmziausNustatymas nustatytasAmzius = new AmziausNustatymas();
        int amziusVartotojo = nustatytasAmzius.nuskaitymas();
        Galimybes arGaliVairuoti = nustatytasAmzius.amziausIvertinimas(amziusVartotojo);
        RezultatoIsvedimas(arGaliVairuoti);       

        Console.ReadLine();
        }

        public static void RezultatoIsvedimas(Galimybes arGaliVairuoti)
        {
             switch (arGaliVairuoti)
             {
                 case Galimybes.nieko:
                     Console.WriteLine("Negali nei vairuoti, nei gerti.");
                     break;
                 case Galimybes.vairuoti:
                     Console.WriteLine("Gali tik vairuoti.");
                     break;
                 case Galimybes.vairuotiGerti:
                     Console.WriteLine("Gali ir gerti, ir vairuoti.");
                     break;
             }                
        }        
    }
}