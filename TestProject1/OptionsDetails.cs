using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace TestProject1
{
    [TestClass]
    [TestCategory("Options")]
    public class OptionsDetails
    {

        IWebDriver driver = new ChromeDriver();
        [TestMethod]
        public void Window_Test()
        {
           // driver.Manage().Window.Maximize();
            
            KeyboardSimulator keyboard=new KeyboardSimulator(new InputSimulator());
            keyboard.KeyPress(VirtualKeyCode.F11);
            driver.Close();
        }

        [TestMethod]
        public void TimeOuts_Test()
        {
            driver.Manage().Timeouts().ImplicitWait.TotalSeconds.Equals(10);
        }
    }
}
