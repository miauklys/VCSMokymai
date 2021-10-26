using System;

namespace Event
{
    class Program
    {
        private static void manoBankasIdetiPinigai(object sender, string suma)
        {
            Console.WriteLine($"{suma}");
        }

        static void Main(string[] args)
        {
            Bank manoBankas = new Bank("SwedBank", 3000);
            manoBankas.PervestiPinigeliai += manoBankasIdetiPinigai;
            //manoBankas.KeiciamiPinigai(5000, "USD", 2.89);
            //manoBankas.InestiPinigai(5000) += manoBankasIdetiPinigai;
            manoBankas.PervestiPinigeliai += manoBankasIdetiPinigai;
            //manoBankas.Pakeistvaliuta(10000) += manoBankasIdetiPinigai;

            Console.ReadLine();
        }
    }
}
