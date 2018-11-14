using NUnit.Framework.Internal;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject
{
    class PageElement
    {
        private IWebDriver driver;
        //private IDictionary<string, IWebElement> dictionary = new Dictionary<string, IWebElement>();
        public static void Main(string[] args)
        {          Console.WriteLine("Dictionary Element for Object"); }

        // Added all the element locater in distionary object
        public IWebElement dictionaryObject(IWebDriver driver, String var) {
            IDictionary<string, IWebElement> dictionary = new Dictionary<string, IWebElement>();
            dictionary.Add("AmazonSearchEditBox", driver.FindElement(By.XPath("//*[@id='twotabsearchtextbox']")));
            dictionary.Add("SerachButton", driver.FindElement(By.XPath("//*[@value='Go']")));




            // Search the WebElement in String Format and return WebElement value
            
            IWebElement value = dictionary[var];
            Console.WriteLine(dictionary[var]);
            return value;
        }

        //public IWebElement retrieveDataFromDictionary(string var)
        //{
        //    if (dictionary.ContainsKey(var))
        //    {
        //        IWebElement value = dictionary[var];
        //        Console.WriteLine(value);
        //    }
        //    return value;

        //}



    }
}
