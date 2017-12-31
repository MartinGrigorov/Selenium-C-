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
        static void Main(string[] args)
        {
        }
        [SetUp]
        public void Start()
        {
            PropertiesCollection.driver = new ChromeDriver();


            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
        }

        [Test]
        public void ExcludeTests()
        {
            //Title
            SeleniumSetMethods.SelectDropDown("TitleId", "Ms.", PropertyType.Id);

            //Initial
            SeleniumSetMethods.EnterText("Initial", "executeoperation", PropertyType.Name);

            Console.WriteLine("The value from the Title is: " + SeleniumGetMethods.GetText("TitleId", PropertyType.Id));
            Console.WriteLine("The value from the Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));
           
                

            //Click
            SeleniumSetMethods.Click("Save", PropertyType.Name);
        }
        
    }
}
