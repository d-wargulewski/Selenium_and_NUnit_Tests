using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TestAutomation.SeleniumWebDriver;

namespace TestAutomation.Tests._00_TestFramework
{
        [TestClass]
        public class Framework
        {
            #region Variables
            IWebDriver _driver;
            string URL = "Enter URL Page";
            #endregion



            #region Initialize and Cleanup
            [TestInitialize]
            public void Initialize()
            {
                _driver = InitializeWebDriver.Initialize(_driver, Browser.Chrome, 5, true);
            }

            [TestCleanup]
            public void Dispose()
            {
                _driver.Close();
            }
            #endregion



            #region Tests
            [TestMethod]
            public void Test()
            {
                _driver.Navigate().GoToUrl(URL);
            }
            #endregion
    }
}
