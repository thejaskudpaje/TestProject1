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
    [TestCategory("WebElements")]
    public class WebElementDetails
    {
        IWebDriver driver = new ChromeDriver();
        
        [TestMethod]
        public void TagName_Test()
        {
            driver.Navigate().GoToUrl("https://secure.indeed.com/");
           String TagName= driver.FindElement(By.XPath("//span[contains(text(),'Google')]")).TagName;
            Console.WriteLine(TagName);
            driver.Close();
        }

        [TestMethod]
        public void Text_Test()
        {
            driver.Navigate().GoToUrl("https://secure.indeed.com/");
            String text = driver.FindElement(By.XPath("//span[contains(text(),'Google')]")).Text;
            Console.WriteLine(text);
            driver.Close();
        }

        [TestMethod]
        public void Enabled_Test()
        {
            driver.Navigate().GoToUrl("https://www.facebook.com/login/");
           bool res= driver.FindElement(By.Id("loginbutton")).Enabled;
            Console.WriteLine(res);
            driver.Close() ;    
        }


        [TestMethod]
        public void Location_Test()
        {
            driver.Navigate().GoToUrl("https://www.facebook.com/login/");
           int xLocation= driver.FindElement(By.Id("loginbutton")).Location.X;
            int yLocation = driver.FindElement(By.Id("loginbutton")).Location.Y;
            Console.WriteLine(xLocation+","+ yLocation);
            driver.Close ();    
        }

        [TestMethod]
        public void Size_Test()
        {
            driver.Navigate().GoToUrl("https://www.facebook.com/login/");
            int width = driver.FindElement(By.Id("loginbutton")).Size.Width;
            int height = driver.FindElement(By.Id("loginbutton")).Size.Height;
            Console.WriteLine(width+", "+height);
            driver.Close () ;   
        }

        [TestMethod]
        public void Selected_Test()
        {
            driver.Manage().Timeouts().ImplicitWait.TotalSeconds.Equals(10);
            driver.Navigate().GoToUrl("https://demo.actitime.com/login.do");
           bool IsSelected= driver.FindElement(By.XPath("//input[@id='keepLoggedInCheckBox']")).Selected;
            Console.WriteLine(IsSelected);
            driver.Close(); 
        }

        [TestMethod]
        public void Displayed_Test()
        {

            driver.Manage().Timeouts().ImplicitWait.TotalSeconds.Equals(10);
            driver.Navigate().GoToUrl("https://www.facebook.com/login/o");
          bool display=  driver.FindElement(By.XPath("//img[@class='_97vu img']")).Displayed;
            Console.WriteLine(display);
            driver.Close(); 
        }

        [TestMethod]
        public void SendKeys_Test()
        {
            driver.Manage().Timeouts().ImplicitWait.TotalSeconds.Equals(10);
            driver.Navigate().GoToUrl("https://www.facebook.com/login/o");
            driver.FindElement(By.XPath("//img[@class='_97vu img']")).SendKeys("thejas");
            driver.Close ();    
        }


        [TestMethod]
        public void Clear_Test()
        {
            driver.Manage().Timeouts().ImplicitWait.TotalSeconds.Equals(10);
            driver.Navigate().GoToUrl("https://www.facebook.com/login/o");
            driver.FindElement(By.XPath("//img[@class='_97vu img']")).SendKeys("thejas");
            driver.FindElement(By.XPath("//img[@class='_97vu img']")).Clear();
            driver.Close();
        }


        [TestMethod]
        public void Submit_Test()
        {
            driver.Manage().Timeouts().ImplicitWait.TotalSeconds.Equals(10);
            driver.Navigate().GoToUrl("https://www.facebook.com/login/o");
            driver.FindElement(By.Id("loginbutton")).Submit();
            driver.Close();
        }

        [TestMethod]
        public void Click_Test()
        {
            driver.Manage().Timeouts().ImplicitWait.TotalSeconds.Equals(10);
            driver.Navigate().GoToUrl("https://demo.actitime.com/login.do");
            driver.FindElement(By.Id("loginButton")).Click();
     
            driver.Close();
        }

        [TestMethod]
        public void GetAttrubute_Test()
        {
            driver.Manage().Timeouts().ImplicitWait.TotalSeconds.Equals(10);
            driver.Navigate().GoToUrl("https://demo.actitime.com/login.do");
           String attributeValue=driver.FindElement(By.Id("loginButton")).GetAttribute("href");

            driver.Close();
        }
    }
}
