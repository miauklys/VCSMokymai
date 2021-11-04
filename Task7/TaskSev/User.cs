using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSev
{
    public class User
    {
        public string Logger()
        {

            Console.WriteLine("\nPrašome prisijungti arba užsiregistruoti:\n" +
                "------------------------------------------------------------------\n");
            Console.WriteLine("\njei norite prisijungti, įveskite 'LogIn', jei registruotis - 'LogOn':\n" +
                "------------------------------------------------------------------\n");
            string ivestis = Console.ReadLine();
            return ivestis;
        }

        ////////////////////Logging In////////////////////
        public Selection LoggingIn(string ivestis)
        {
            string dir = $"C:/Users/sakav/user.txt";

            Console.WriteLine("Įveskite vardą:");
            string namoLogIn = Console.ReadLine();
            bool atsakymasIrasytas = false;
            using (StreamReader streamReader = File.OpenText(dir))
            {
                string[] eilutesLogInName = File.ReadAllLines(dir);
                for (int namoIn = 0; namoIn < eilutesLogInName.Length - 1; namoIn++)
                {
                    if (namoLogIn == eilutesLogInName[namoIn])
                    {
                        streamReader.Close();
                        atsakymasIrasytas = true;

                        Console.WriteLine("Įveskite slaptažodį:");
                        string passLogIn = Console.ReadLine();
                        bool passNukskaitymas = false;
                        using (StreamReader streamReaderslap = File.OpenText(dir))
                        {
                            string[] eilutesLogInPass = File.ReadAllLines(dir);
                            for (int passIn = 0; passIn < eilutesLogInPass.Length - 1; passIn++)
                            {
                                if (passLogIn == eilutesLogInPass[passIn])
                                {
                                    streamReader.Close();
                                    Console.WriteLine("Sėkmingai prisijungėte!");

                                    passNukskaitymas = true;
                                }
                            }
                            if (!passNukskaitymas)
                            {
                                Console.WriteLine("Blogai įvestas slaptažodis!");
                            }
                        }
                    }
                }
            }
            //return string.Empty;
            //if (!atsakymasIrasytas)
            //{
            //    Console.WriteLine("Įveskite vardą, kurį ketinate naudoti registracijai:");
            //    string nameLogOn = Console.ReadLine();
            //    string[] eilutesLogOnName = File.ReadAllLines(dir);

            //    using (StreamWriter streamWriter = File.CreateText(dir))
            //    for (int nameOn = 0; nameOn < eilutesLogOnName.Length - 1; nameOn++)
            //    {
            //        streamWriter.WriteLine(nameLogOn);
            //    }

            //    string ivestasSlaptazodis;
            //    int ilgis;
            //    do
            //    {
            //        Console.WriteLine("Įveskite ilgesnį nei šešių simbolių slaptažodį:");
            //        ivestasSlaptazodis = Console.ReadLine();
            //        ilgis = ivestasSlaptazodis.Length;
            //    }

            //    while (ilgis < 6);

            //    bool atsakymasArGerasSlap = false;
            //    using (StreamReader streamReaderSlap = File.OpenText(dir))
            //    {
            //        string[] eilutesSlap = File.ReadAllLines(dir);
            //        for (int x = 0; x < eilutes.Length - 1; x++)
            //        {
            //            if (ivestasSlaptazodis == eilutes[x])
            //            {
            //                streamReader.Close();
            //                Console.WriteLine("Sėkmingai užsiregistravote.");
            //                atsakymasIrasytas = true;
            //            }
            //        }
            //        if (!atsakymasArGerasSlap)
            //        {
            //            Console.WriteLine("Blogai įvestas slaptažodis!");
            //        }
            //    }
            //}
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Įveskite vardą:");
            //    string atsakymas = Console.ReadLine();
            //    bool atsakymasIrasytas = false;
            //    using (StreamReader streamReader = File.OpenText(dir))
            //    {
            //        string[] eilutes = File.ReadAllLines(dir);
            //        for (int x = 0; x < eilutes.Length - 1; x++)
            //        {
            //            if (atsakymas == eilutes[x])
            //            {
            //                streamReader.Close();
            //                Console.WriteLine("Toks vardas jau panaudotas kito vartotojo.");
            //                atsakymasIrasytas = true;
            //            }
            //        }
            //        if (!atsakymasIrasytas)
            //        {
            //            using (StreamWriter streamWriter = File.CreateText(dir))
            //            {
            //                streamWriter.WriteLine(atsakymas);
            //            }

            //            Console.WriteLine("Įveskite slaptažodį:");
            //            string ivestasSlaptazodis = Console.ReadLine();

            //            bool atsakymasArGerasSlap = false;
            //            using (StreamReader streamReaderSlap = File.OpenText(dir))
            //            {
            //                string[] eilutesSlap = File.ReadAllLines(dir);
            //                for (int x = 0; x < eilutes.Length - 1; x++)
            //                {
            //                    if (ivestasSlaptazodis == eilutes[x])
            //                    {
            //                        streamReader.Close();
            //                        Console.WriteLine("Sėkmingai prisijungėte.");
            //                        atsakymasIrasytas = true;
            //                    }
            //                }
            //                if (!atsakymasArGerasSlap)
            //                {
            //                    Console.WriteLine("BLOgai įvestas slaptažodis!");
            //                }
            //            }
            //        }
            //    }
            //}       

        }
    }
}
