using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTask1
{
    public static class Math
    {
        public static int Factorial(int i)
        {
            int result;
            if (i == 1)
                return 1;
            result = Factorial(i - 1) * i;
            return result;
        }
        static public double Sqr(double d)
        {
            return d * d;
        }
    }
}
