using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //AmziausKlase programa = new AmziausKlase();
            //int age = programa.amziausNuskaitymas();

            //Galimybes kaGaliDaryti = programa.amziausIvertinimas(age);

            //Console.WriteLine(kaGaliDaryti);

            //Console.ReadLine();

            /// variantas su switch:
            /// 

            AmziausNustatymas nustatytasAmzius = new AmziausNustatymas();
            int amziusVartotojo = nustatytasAmzius.amziausNuskaitymas();
            
            Galimybes arGaliVairuoti = nustatytasAmzius.amziausIvertinimas(amziusVartotojo);
            
            AmziausNustatymas prog = new AmziausNustatymas();
            prog.RezultatoIsvedimas(arGaliVairuoti);
           

            Console.ReadLine();
        }

      
    }
}