using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Utils
{
    public class Test
    {
        public static void Main()
        {
            Console.WriteLine("Enter first number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int y = int.Parse(Console.ReadLine());
            int greater = Utils.Greater(x, y);
            Console.WriteLine($"The greater value is {greater}");

            Console.WriteLine($"Before swap: {x} and {y}");
            Ex02.Utils.Swap(ref x, ref y);
            Console.WriteLine($"After swap: {x} and {y}");

            bool ok;
            int f;
            Console.WriteLine("Number for factorial:");
            int n = int.Parse(Console.ReadLine());
            ok = Ex03.Utils.Factorial(n, out f);
            if (ok)
                {
                Console.WriteLine($"Factorial({n}) = {f}");
                }
            else
                {
                Console.WriteLine("Cannot compute this factorial");
                }
        }
    }
}
