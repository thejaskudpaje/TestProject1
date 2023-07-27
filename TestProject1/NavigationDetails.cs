using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    [TestCategory("navigation")]
    public class NavigationDetails
    {
        IWebDriver driver = new ChromeDriver();
        [TestMethod]
        public void GoToUrl_Test()
        {
            driver.Navigate().GoToUrl("https://secure.indeed.com/");
        }


        [TestMethod]
        public void Back_Test()
        {
            driver.Navigate().GoToUrl("https://secure.indeed.com/");
            driver.FindElement(By.XPath("//span[contains(text(),'Google')]")).Click();
            driver.Navigate().Back();
        }


        public void Forward_Test()
        {
            driver.Navigate().GoToUrl("https://secure.indeed.com/");
            driver.FindElement(By.XPath("//span[contains(text(),'Google')]")).Click();
            driver.Navigate().Back();
            driver.Navigate().Forward();    
        }


        [TestMethod]
        public void Refresh_Test()
        {
            driver.Navigate().GoToUrl("https://secure.indeed.com/");
            driver.Navigate().Refresh();
        }
    }
}
