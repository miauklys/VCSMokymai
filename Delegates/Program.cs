using System;

namespace Delegates
{
    //public delegate void ManoDelegates(string manoTekstoEilute);
    public delegate int DoOperation(int m1, int m2);
    class Program
    {
        //private static ManoDelegates manoProvatusDelegatas;
        private static DoOperation manoPrivatusDelegatas;
        static void Main(string[] args)
        {
            //manoProvatusDelegatas = Console.WriteLine;
            //SavotiskaiPasisveikinti("L d!");
            //manoPrivatusDelegatas = Sum;
            //manoPrivatusDelegatas += Multiply;

            manoPrivatusDelegatas = MySum;
            manoPrivatusDelegatas += MyMultiply;
            manoPrivatusDelegatas += MyMultiply;

            manoPrivatusDelegatas(3, 2);            

            Console.ReadLine();
        }

        //public static void SavotiskaiPasisveikinti(string fraze)
        //{
        //    manoProvatusDelegatas(fraze);
        //}
        static int MyMultiply(int m1, int m2)
        {
            Console.WriteLine(m1 * m2);
            return m1 * m2;            
        }
        static int MySum(int m1, int m2)
        {
            Console.WriteLine(m1 + m2);
            return m1 + m2;
        }
    }
}
