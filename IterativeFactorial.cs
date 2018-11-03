using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class IterativeFactorial
    {

        public static ulong GetFactorialIterative(ulong num)
        {
            ulong fact = 1;

            while (num != 1)
            {
                fact = num * fact;
                num--;
            }

            return fact;
        }

    }
}
