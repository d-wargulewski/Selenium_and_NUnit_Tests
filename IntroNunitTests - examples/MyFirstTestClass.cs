//PPM - IntroNunitTests -> Add -> Class...
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace IntroNunitTests
{
    [TestFixture]
    public class MyFirstTestClass
    {
        #region SimpleTests
        [Test]
        public void PositiveTest()
        {
            int x = 7;
            int y = 7;

            Assert.AreEqual(x, y);
        }

        [Test]
        public void NegativeTest()
        {
            if (true)
                Assert.Fail("This is a failure");
        }

        [Test,ExpectedException(typeof(NotSupportedException))]
        public void ExpectedExceptionTest()
        {
            throw new NotSupportedException();        }

        
        [Test,Ignore("Exception is not implemented yet")]
        public void NotImplementedException()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region CreatingMailAdress
        [TestCase("damian","domain","pl","damian@domain.pl")]
        public void CreatingMailAdress(string name, string domain, string country, string exceptedString)
        {
            string actualString = name + "@" + domain + "." + country;
            Assert.AreEqual(exceptedString, actualString);
        }

        [TestCase("damian", "domain", "pl", Result="damian@domain.pl")]
        public string CreatingMailAdressAnotherImplementation(string name, string domain, string country)
        {
            string actualString = name + "@" + domain + "." + country;
            return actualString;
        }
        #endregion
    }
}
