using System;

namespace TaskSev
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = $"C:/Users/sakav/user.txt";

            User logger = new User();
            string ivestis = logger.Logger();
            Selection pas = logger.LoggingIn(ivestis);
            Log(pas);

            Console.ReadLine();
        }
        private static string Log(Selection pas)
        {
            
            switch (pas)
            {
                case Selection.LogIn:
                    User p = new User(); p.LoggingIn();
                    return string.Empty;
                case Selection.LogOn:
                    User pp = new User(); pp.LoggingIn();
                    return string.Empty;
            }
        }
    }
}
