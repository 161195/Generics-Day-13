using System;

namespace Generics_problem
{
    class Program
    {
        static void Main(string[] args)
        {
           double Result=Generics.MaxNumber(15.20,20.25,25.15);
            Console.WriteLine("{0} is max number", Result);
            Console.ReadLine();

        }
    }
}
