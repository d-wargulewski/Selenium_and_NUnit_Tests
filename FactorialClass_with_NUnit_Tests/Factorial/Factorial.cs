using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Factorial
{
    public static class Factorial
    {
        public static int Calculate(int number)
        {
            if (number < 0) throw new ArgumentException();
                else if (number == 0) return 1;
                    else
                    {
                        return number * Factorial.Calculate(number - 1);
                    }
        }
    }
}
