using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    public static class Utils
    {
        public static bool Factorial(int n, out int answer)
        {
            int k;
            int f = 1;
            bool ok = true;
            try
            {
                checked
                {
                    for (k = 2; k <= n; k++)
                    {
                        f *= k;
                    }
                }
            }
            catch(Exception)
            {
                f = 0;
                ok = false;
            }
            answer = f;

            return ok;
        }
    }
}
