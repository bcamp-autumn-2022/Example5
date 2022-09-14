using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int answer;
            double resSqrt;
            while (1 == 1)
            {
                Console.WriteLine("Give me a number");
                a = int.Parse(Console.ReadLine());
                answer = MyMath.Factorial(a);
                resSqrt = Math.Sqrt(a);
                Console.WriteLine("The square of "+a+ " is "+resSqrt);
                Console.WriteLine("The factorial of " + a + " is " + answer);
            }

        }
    }
}
