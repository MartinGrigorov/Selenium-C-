using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium2
{
    class Program
    {

        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
        }
        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine("Open Url");//we can check this way on which step we are into the TestExplorer
        }


        [Test]
        public void ExecuteTest()
        {
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("Gergin Borisov");
        }

        [Test]
        //if we want to add another test:
        public void NextTest() => Console.WriteLine("Next test");

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
