﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium3
{
    class EApageObject
    {
        public EApageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement ddlTitleID { get; set; }


        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirsName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }


        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }


        public void FillUserForm(string initial, string middleName, string firstName)
        {
            //txtInitial.SendKeys(initial);
            //txtMiddleName.SendKeys(middleName);
            //txtFirsName.SendKeys(firstName);
            //btnSave.Click();


            //with custom methods
            SeleniumSetMethods.EnterText(txtInitial, initial);
            SeleniumSetMethods.EnterText(txtFirsName, firstName);
            SeleniumSetMethods.EnterText(txtMiddleName, middleName);
            SeleniumSetMethods.Click(btnSave);
        }
    }
}
