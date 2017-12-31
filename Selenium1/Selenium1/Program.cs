using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the reference for or browser
            IWebDriver driver = new ChromeDriver();

            //navigate to Google page
            driver.Navigate().GoToUrl("http://www.google.com");

            //finding the input
            IWebElement element = driver.FindElement(By.Name("q"));


            //writing text
            element.SendKeys("Gergin Borisov");
        }
    }
}
