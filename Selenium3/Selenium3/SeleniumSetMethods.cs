using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium3
{
    public static class SeleniumSetMethods
    {

        //ако добавим this пред IWebElement то това ще се превърне в екстеншън метод, говорим а EnterText 
        //за да се случи това трябва class SeleniumSetMethods да бъде сменен на public static class SeleniumSetMethods
        //същото можем а направим с метода Click и метода SelectDropDown


        /// <summary>
        /// Extended method for entering text in the control(this)
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void EnterText(/*string element,*/this IWebElement element, string value/*, PropertyType elementtype*/)
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



        /// <summary>
        /// Extended method for click operation a button, Checkbox, option etc
        /// </summary>
        /// <param name="element"></param>
        public static void Clicks(this IWebElement element/*, PropertyType elementtype*/)
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


        /// <summary>
        /// Extended method for selecting Drop down control
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SelectDropDown(this IWebElement element, string value/*, PropertyType elementtype*/)
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
