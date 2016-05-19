using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Factorial;


namespace Factorial.Tests
{
    [TestFixture]
    public class FactorialTests
    {
        // exceptional situations:
        // for: !(number < 0)   -> throw new ArgumentException();

        // Normal situations:
        // for: !0              -> 1
        // for: !1              -> 1
        // for: !2              -> 2
        // for: !4              -> 24

        [Test, ExpectedException(typeof(ArgumentException))]
        public void input_minus_five__expected__throw_new_argument_exception()
        {
            Factorial.Calculate(-5);
        }

        [TestCase(0, Result = 1)]
        public int input_zero__excepted_one(int number)
        {
            int value = Factorial.Calculate(number);
            return value;
        }

        [TestCase(1, Result = 1)]
        public int input_one__excepted_one(int number)
        {
            int value = Factorial.Calculate(number);
            return value;
        }

        [TestCase(2, Result = 2)]
        public int input_two__excepted_two(int number)
        {
            int value = Factorial.Calculate(number);
            return value;
        }

        [TestCase(4, Result = 24)]
        public int input_four__excepted_twentyfour(int number)
        {
            int value = Factorial.Calculate(number);
            return value;
        }
    }
}
