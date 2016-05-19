using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects; // PageFactory

using OpenQA.Selenium.Interactions; // Actions
// Actions
using TestAutomation.SeleniumWebDriver;


//OpenQA.Selenium.Interactions.Internal.ICoordinates;

namespace TestAutomation
{
    [TestClass]
    public class GoogleSearchPage
    {
        #region Variables
        IWebDriver _driver;
        string URL = "https://www.google.pl/";

        [FindsBy(How = How.XPath, Using = ".//*[@id='lst-ib']")]
        IWebElement SearchBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='tsf']/div[2]/div[3]/center/input[1]")]
        IWebElement btnGoogleSearch { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='tsf']/div[2]/div[3]/center/input[2]")]
        IWebElement btnImFeelingLucky { get; set; }
        #endregion



        #region Initialize and Cleanup
        [TestInitialize]
        public void Initialize()
        {
            _driver = InitializeWebDriver.Initialize(_driver, Browser.Firefox, 15, true);
            PageFactory.InitElements(_driver, this);
        }

        [TestCleanup]
        public void Dispose()
        {
            _driver.Close();
        }
        #endregion



        #region Tests
        [TestMethod]
        public void Google_TurningLanguageIntoPolish()
        {
            _driver.Navigate().GoToUrl(URL);
            SearchBox.Clear();
            SearchBox.SendKeys("SeleniumTest");
            SearchBox.SendKeys(Keys.Enter);

            Thread.Sleep(2000);

            //IWebElement review = _driver.FindElement(By.XPath(".//*[@id='cnsr']/div"));
            //review.Click();

            IWebElement review = _driver.FindElement(By.CssSelector("span._CJi"));
            review.Click();

            //action.MoveToElement(review).Perform();


            Thread.Sleep(20000);

            Console.WriteLine(SearchBox.GetAttribute("value"));

            Assert.IsTrue(SearchBox.GetAttribute("value") == "SeleniumTest");
        }

        [TestMethod]
        public void DragAndDrop()
        {
            _driver.Navigate().GoToUrl("http://jqueryui.com/droppable/");
            IWebElement draggable_element = _driver.FindElement(By.XPath(".//*[@id='draggable']"));
            Actions akcja = new Actions(_driver);

            akcja.DragAndDropToOffset(draggable_element, 60, -10);
        }

        #endregion
    }
}
