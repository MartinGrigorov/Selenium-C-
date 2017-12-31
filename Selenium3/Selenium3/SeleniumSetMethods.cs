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
        public static void EnterText(IWebDriver driver, string element, string value, string elemettype)
        {
            if (elemettype == "Id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (elemettype == "Name")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);
            }
        }


        //click operation a button, Checkbox, option etc
        public static void Click(IWebDriver driver, string element, string elemettype)
        {
            if (elemettype == "Id")
            {
                driver.FindElement(By.Id(element)).Click();
            }
            if (elemettype == "Name")
            {
                driver.FindElement(By.Name(element)).Click();
            }
        }


        //selecting Drop down control
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elemettype)
        {
            if (elemettype == "Id")
            {
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            }
            if (elemettype == "Name")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            }
        }

    }
}
