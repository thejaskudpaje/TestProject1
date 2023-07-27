using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
   [TestClass]
    [TestCategory("UnitTest1")]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Launch")]
        public void TestMethod1()
        {

            IWebDriver driver=new ChromeDriver();
            driver.Url = "https://google.com";
            Console.WriteLine("Success");
            driver.Close();
        }
      
    }
}