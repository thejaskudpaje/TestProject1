using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    [TestCategory("WebdriverClass")]
    public class WebDriverDetails

    {
        IWebDriver driver= new ChromeDriver();
    /*    public void CreateObjrctTest()
        {
            driver = new ChromeDriver();
        }*/
        /// <summary>
        /// This method shows the working of "URL"
        /// </summary>
        [TestMethod]
        public void URL_Test()
        {          
            driver.Url = "https://google.com";
            Console.WriteLine("Url executed ");
            driver.Close();
        }

        [TestMethod]
        public void Title_Test()
        {
            driver.Navigate().GoToUrl("https://www.flipkart.com/");
            Console.WriteLine(driver.Title);
            driver.Close();
        }

        [TestMethod]
        public void Page_Source_Test()
        {
            driver.Navigate().GoToUrl("https://www.flipkart.com/");
            Console.WriteLine(driver.PageSource);
            driver.Close();
        }


        [TestMethod]
        public void Current_Window_Handl_Test()
        {
            driver.Navigate().GoToUrl("https://www.flipkart.com/");
            Console.WriteLine(driver.CurrentWindowHandle);
            driver.Close();
        }

        [TestMethod]
        public void Window_Handles()
        {
            driver.Navigate().GoToUrl("https://secure.indeed.com/");
            driver.FindElement(By.XPath("//span[contains(text(),'Google')]")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Apple')]")).Click();
            ReadOnlyCollection<string> all_URL = driver.WindowHandles;
            foreach(string url in all_URL)
            {

                Console.WriteLine(url); 
            }
            driver.Quit();  
        }

        [TestMethod]
        public void Close_Test()
        {
            driver.Close();
        }

        [TestMethod]
        public void Quite_Test()
        {
            driver.Quit();
        }

        [TestMethod]
        public void Dispose_Test()
        {
            driver.Dispose();
        }

        [TestMethod]
        public void Manage_Test()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait.TotalSeconds.Equals(10);
        }

        [TestMethod]
        public void Switch_To_Test()
        {
            driver.Navigate().GoToUrl("https://secure.indeed.com/");
            driver.FindElement(By.XPath("//span[contains(text(),'Google')]")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Apple')]")).Click();
            ReadOnlyCollection<string> all_URL = driver.WindowHandles;
            foreach (string url in all_URL)
            {

                driver.SwitchTo().Window(url);
            }
            driver.Quit();
        }

    }
}
