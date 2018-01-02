using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium3
{
    class LoginPageObject
    {

        //inicializirane na page
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using ="Login")]
        public IWebElement btnLogin { get; set; }



        //we will write a method and for the login and we will invoke it from the Program.cs
        //след като кликна на бутона ще върне ЕАpageObject, което всъщност е втората страница и го пишем като инстанция на логин пейджа "public EApageObject Login"
        public EApageObject Login(string userName, string password)
        {
            //user name
            txtUserName.SendKeys(userName);
            //password
            txtPassword.SendKeys(password);
            //click button
            btnLogin.Submit();
            //or btnLogin.Click();

            //Return the page object - redirecting to the next page
            return new EApageObject();

        }
    }
}
