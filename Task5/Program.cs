using System;
using System.Collections.Generic;
using System.IO;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            ////File.ReadAllText...
            ////File.WriteAllText..
            //string s = "asddddddddddd asdd";
            //string[] manoEilutes = { s, "asd ", "aaaaaaaaa", "kkkkkkkkkkkk" };

            //Directory.CreateDirectory("C:/test");
            //var stream = File.Create(@"C:/test/test_failas.txt");
            //stream.Write(manoEilutes, 3, 5);

            //stream.Close();

            // Specify the directory you want to manipulate.
            //string path = @"c:\MyDir";

            //try
            //{
            //    // Determine whether the directory exists.
            //    if (Directory.Exists(path))
            //    {
            //        Console.WriteLine("That path exists already.");
            //        return;
            //    }

            //    // Try to create the directory.
            //    DirectoryInfo di = Directory.CreateDirectory(path);
            //    Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

            //    // Delete the directory.
            //    //di.Delete();
            //    //Console.WriteLine("The directory was deleted successfully.");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("The process failed: {0}", e.ToString());
            //}
            //finally { }
        
        
        
        
        
        }


        private List<string> zodziuSarasas;
        private Program()
        {
            zodziuSarasas = new List<string>();

            bool noriuTesti = true;

            while (noriuTesti)
            {
                Console.WriteLine("Įveskite žodį:");
                string ivestis = Console.ReadLine();
                zodziuSarasas.Add(ivestis);

                noriuTesti = Console.ReadLine() == "taip";
            }
        }

        public async void ExampleAsync()
        {
            using StreamWriter failas = new("WriteLines2.txt");
            foreach (string zodis in zodziuSarasas)
            {
                if (!zodis.Contains("Second"))
                {
                    await failas.WriteLineAsync(zodis);
                }
            }
        }


    }
}
