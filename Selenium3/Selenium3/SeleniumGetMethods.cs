using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium3
{
    class SeleniumGetMethods
    {
        //geting the input value
        public static string GetText(IWebDriver driver, string element, string elemettype)
        {
            if (elemettype == "Id")
            {
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            }
            if (elemettype == "Name")
            {
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            }
            else
            {
                return String.Empty;
            }
        }

        //geting the drop down list (DDL) value
        public static string GetTextFromDDL(IWebDriver driver, string element, string elemettype)
        {
            if (elemettype == "Id")
            {
                return  new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            if (elemettype == "Name")
            {
                return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            else
            {
                return String.Empty;
            }
        }
    }
}

