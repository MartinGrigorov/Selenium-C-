using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium3
{
    class SeleniumSetMethods
    {
        //Enter Text
        public static void EnterText(/*string element,*/IWebElement element, string value/*, PropertyType elementtype*/)
        {
            //if (elementtype == PropertyType.Id)
            //{
            //    PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            //}
            //if (elementtype == PropertyType.Name)
            //{
            //    PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
            //}

            element.SendKeys(value);
        }


        //click operation a button, Checkbox, option etc
        public static void Click(IWebElement element/*, PropertyType elementtype*/)
        {
            //if (elementtype == PropertyType.Id)
            //{
            //    PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            //}
            //if (elementtype == PropertyType.Name)
            //{
            //    PropertiesCollection.driver.FindElement(By.Name(element)).Click();
            //}
            element.Click();
        }


        //selecting Drop down control
        public static void SelectDropDown(IWebElement element, string value/*, PropertyType elementtype*/)
        {
            //if (elementtype == PropertyType.Id)
            //{
            //    new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            //}
            //if (elementtype == PropertyType.Name)
            //{
            //    new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
            //}

            new SelectElement(element).SelectByText(value);
        }

    }
}
