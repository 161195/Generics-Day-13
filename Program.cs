using System;

namespace Generics_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result=Generics.MaxNumber(15,20,25);
            Console.WriteLine("{0} is max number", Result);
            Console.ReadLine();

        }
    }
}
