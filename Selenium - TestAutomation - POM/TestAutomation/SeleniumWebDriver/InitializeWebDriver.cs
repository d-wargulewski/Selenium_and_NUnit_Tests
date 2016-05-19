using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace TestAutomation.SeleniumWebDriver
{
        static class InitializeWebDriver
        {
            public static IWebDriver Initialize(IWebDriver Driver, Browser Type, int ImplicitlyWaitInSeconds, bool Maximize)
            {
                Console.WriteLine("Opening selenium Driver");
                Driver = null;

                switch (Type)
                {
                    case Browser.Chrome:
                        Driver = new ChromeDriver(@"E:\Drivers\ChromeDriver");
                        Console.WriteLine("The browser is set to Chrome");
                        break;

                    case Browser.IE:
                        Driver = new InternetExplorerDriver(@"E:\Drivers\IEDriverServer");
                        Console.WriteLine("The browser is set to IE");
                        break;

                    case Browser.Firefox:
                        Driver = new FirefoxDriver();
                        Console.WriteLine("The browser is set to Firefox");
                        break;
                }


                if (Driver != null)
                {
                    // An explicit waits is code you define to wait for a certain condition
                    // to occur before proceeding further in the code. The worst case of this is Thread.sleep(), 
                    // which sets the condition to an exact time period to wait.
                    // This waits up to 10 seconds before throwing a TimeoutException or 
                    // if it finds the element will return it in 0 - 10 seconds.WebDriverWait 
                    // by default calls the ExpectedCondition every 500 milliseconds until it returns successfully.
                    Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(ImplicitlyWaitInSeconds));
                    Console.WriteLine("ImplicitlyWait is set to" + ImplicitlyWaitInSeconds.ToString());

                    if (Maximize == true)
                    {
                        Console.WriteLine("Windows is maximized");
                        Driver.Manage().Window.Maximize();
                    }
                }


                // Return setup driver
                return Driver;
            }
    }
}
