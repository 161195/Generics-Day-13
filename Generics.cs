using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_problem
{
    class Generics
    {
        public static string MaxNumber (string first, string second,string third)
        {
            if (first.CompareTo(second)>0 && first.CompareTo(third)>0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third)>0)
            {
                return second;
            }
            if(third.CompareTo(first)>0 && third.CompareTo(second)>0)
            {
                return third;
            }
            return default;
        }

    }
}
