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


            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }

        [Test]
        public void ExcludeTests()
        {


            //login to the application
            LoginPageObject pageLogin = new LoginPageObject();
            EApageObject pageEA = pageLogin.Login("execute", "automation");

            ////POM which is page objec model! separating the 
            ////Initialize the page by calling its reference
            //EApageObject page = new EApageObject();            
            //page.txtInitial.SendKeys("executeoperation");
            //page.btnSave.Click();

            //hardcode without table
            pageEA.FillUserForm("KK", "Grigorov", "Martin");



            ////Title
            //SeleniumSetMethods.SelectDropDown("TitleId", "Ms.", PropertyType.Id);

            ////Initial
            //SeleniumSetMethods.EnterText("Initial", "executeoperation", PropertyType.Name);

            //Console.WriteLine("The value from the Title is: " + SeleniumGetMethods.GetText("TitleId", PropertyType.Id));
            //Console.WriteLine("The value from the Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));   

            ////Click
            //SeleniumSetMethods.Click("Save", PropertyType.Name);
        }
        
    }
}
