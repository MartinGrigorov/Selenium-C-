using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace Selenium3
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
        }
        [SetUp]
        public void Start()
        {
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
        }

        [Test]
        public void ExcludeTests()
        {
            //Title
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Ms.", "Id");

            //Initial
            SeleniumSetMethods.EnterText(driver, "Initial", "executeoperation", "Name");

            Console.WriteLine("The value from the Title is: " + SeleniumGetMethods.GetText(driver, "TitleId", "Id"));
            Console.WriteLine("The value from the Initial is: " + SeleniumGetMethods.GetText(driver, "Initial", "Name"));

            //Click
            SeleniumSetMethods.Click(driver, "Save", "Name");
        }

    }
}
