using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RecursiveFactorial
    {
        public static ulong GetFactorialRecursive(ulong num)
        {
            if (num == 1)
                return 1;
            else
                return num * GetFactorialRecursive(num - 1);
        }
    }
}
