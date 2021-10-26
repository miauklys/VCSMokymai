using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Bank
    {
        public string Pavadinimas;
        public double BankoBalansas;

        public event EventHandler<string> BankoOperacija;
        public event EventHandler<string> PervestiPinigeliai;
        public event EventHandler<string> InestiPinigai;
        public event EventHandler<string> Pakeistvaliuta;

        public Bank(string pavadinimas, double bankoBalansas)
        {
            Pavadinimas = pavadinimas;
            BankoBalansas = bankoBalansas;
        }

        public double PervestiPinigai(double piniguSumele) //isveda i konsole
        {
            BankoBalansas = BankoBalansas + piniguSumele;
            //Console.WriteLine($"Jūs gavote {BankoBalansas} Eur.");
            BankoOperacija?.Invoke(this, $"Buvo atliktas pinigų pervedimas.");
            PervestiPinigeliai?.Invoke(this, $"Jūs gavote {BankoBalansas} Eur.");
            return BankoBalansas;
        }

        public double IdetiPinigai(double piniguSumele)
        {
            BankoBalansas = BankoBalansas - piniguSumele;
            BankoOperacija.Invoke(this, $"Buvo atliktas pinigų įnešimas.");
            InestiPinigai.Invoke(this, $"Jūs įnešėte {BankoBalansas} Eur.");
            // Console.WriteLine($"Jūs įnešėte {BankoBalansas} Eur.");
            return BankoBalansas;
        }

        public double KeiciamiPinigai(double piniguSumele, string valiuta, double valiutosKurosas)
        {
            BankoBalansas = piniguSumele * valiutosKurosas;
            BankoOperacija.Invoke(this, $"Buvo atliktas pinigų keitimas.");
            Pakeistvaliuta.Invoke(this, $"Jūs iškeitėte {BankoBalansas} Eur.");
            //Console.WriteLine($"Jūs iškeitėte {piniguSumele} į {BankoBalansas} Eur.");
            return BankoBalansas;
        }
    }
}