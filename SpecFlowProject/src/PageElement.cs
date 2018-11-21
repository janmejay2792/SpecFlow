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
        public IWebDriver driver;
        public static By AmazonHomePageSearchBox = By.XPath("//*[@id='twotabsearchtextbox']");
        public static By SerachButton = By.XPath("//*[@value='Go']");

        


        //private IDictionary<string, IWebElement> dictionary = new Dictionary<string, IWebElement>();
        public static void Main(string[] args)
        {          Console.WriteLine("Dictionary Element for Object"); }

        // Added all the element locater in distionary object
        public IWebElement DictionaryObject(IWebDriver driver, String var) {
            IDictionary<string, IWebElement> dictionary = new Dictionary<string, IWebElement>();
            dictionary.Add("AmazonSearchEditBox", driver.FindElement(AmazonHomePageSearchBox));
            dictionary.Add("SerachButton", driver.FindElement(SerachButton));


            // Search the WebElement in String Format and return WebElement value
            
            IWebElement value = dictionary[var];
            Console.WriteLine(dictionary[var].Text);
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
