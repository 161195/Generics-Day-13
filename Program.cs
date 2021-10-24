using System;

namespace Generics_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating object 
            int[] arra = { 123, 456, 78, 358, 456 };
            double[] arr = { 12.3, 45.6, 7.8, 35.8, 45.8 };
            Generics<int> generic = new Generics<int>(arra);
            Generics<double> gener = new Generics<double>(arr);
            generic.PrintMaxValue();
            gener.PrintMaxValue();

            Console.ReadLine();

        }
    }
}
