using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    public static class MyMath
    {
        public static int Factorial(int n)
        {
            int result = 1;
            for(int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
